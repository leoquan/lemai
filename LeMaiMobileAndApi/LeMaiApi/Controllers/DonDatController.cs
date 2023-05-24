using IdentityModel.Client;
using LeMai.Efs;
using LeMaiApi.Models;
using LeMaiDto;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using Windows.ApplicationModel.Activation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeMaiApi.Controllers;

[Authorize]
public class DonDatController : GhControllerBase<DonDatController>
{
    private readonly LeMaiDbContext _dbCtx;

    public DonDatController(ILogger<DonDatController> logger
        , LeMaiDbContext dbContext
        ) : base(logger)
    {
        _dbCtx = dbContext;
    }

    [HttpGet]
    public async Task<ApiResult<VanDonListMasterOutput>> ListMaster()
    {


        var listStatusName = await _dbCtx.GexpOrderStatuses
            //.Where(h => h.IsShowMobile)
            .Select(h => new
            {
                h.StatusName,
                h.StatusBackgroundColor,
                h.StatusTextColor
            })
            //.OrderBy(h => h)
            .ToListAsync();

        return CreateOk(new VanDonListMasterOutput
        {
            ListStatusName = listStatusName.Select(h => h.StatusName).ToList(),
            ListStatusBgColor = listStatusName.Select(h => h.StatusBackgroundColor).ToList(),
            ListStatusTextColor = listStatusName.Select(h => h.StatusTextColor).ToList(),
        });
    }


    [HttpGet]
    public async Task<ApiResult<List<DonDatDanhSachOutput>>> DanhSach(
        string id
        , string findItem
        , string registerDateType
        , DateTime? registerDateFrom
        , DateTime? registerDateTo
        , [FromQuery] List<string> listStatusName
        )
    {
        var fkCustomer = GetLoginUserId();

        var query = _dbCtx.ViewGexpOrders.AsNoTracking()
            .Where(h => h.FkCustomerId == fkCustomer);

        if (!string.IsNullOrWhiteSpace(id))
        {
            query = query.Where(h => h.Id == id);
        }


        if (listStatusName != null)
        {
            listStatusName = listStatusName.Where(h => !string.IsNullOrWhiteSpace(h))
                .Select(h => h.NormlizeWhitespace())
                .Distinct()
                .ToList();
            if (listStatusName.Count == 1)
            {
                var statusName = listStatusName[0];
                query = query.Where(h => h.StatusName == statusName);
            }
            else if (listStatusName.Count > 1)
            {
                query = query.Where(h => listStatusName.Contains(h.StatusName));
            }
        }

        if (registerDateType == "Trước 7 ngày")
        {
            registerDateTo = GetDateNow().Date;
            registerDateFrom = registerDateTo.Value.AddDays(-7);
        }
        else if (registerDateType == "Trước 30 ngày")
        {
            registerDateTo = GetDateNow().Date;
            registerDateFrom = registerDateTo.Value.AddDays(-30);
        }
        else if (registerDateType == "Tuần này")
        {
            registerDateFrom = GetDateNow().Date;
            if (GetDateNow().DayOfWeek == DayOfWeek.Sunday)
            {
                registerDateFrom = registerDateFrom.Value.AddDays(-6);
            }
            else
            {
                registerDateFrom = registerDateFrom.Value.AddDays(1 - (int)GetDateNow().DayOfWeek);
            }

            registerDateTo = registerDateFrom.Value.AddDays(6);
        }
        else if (registerDateType == "Tháng này")
        {
            registerDateFrom = new DateTime(GetDateNow().Year, GetDateNow().Month, 1);
            registerDateTo = registerDateFrom.Value.AddMonths(1).AddDays(-1);
        }
        else if (registerDateType == "Tháng trước")
        {
            registerDateFrom = (new DateTime(GetDateNow().Year, GetDateNow().Month, 1)).AddMonths(-1);
            registerDateTo = registerDateFrom.Value.AddMonths(1).AddDays(-1);
        }

        if (registerDateFrom.HasValue)
        {
            var compareDate = registerDateFrom.Value.Date;
            query = query.Where(h => h.CreateDate >= compareDate);
        }
        if (registerDateTo.HasValue)
        {
            var compareDate = registerDateTo.Value.Date.AddDays(1);
            query = query.Where(h => h.CreateDate < compareDate);
        }


        if (!string.IsNullOrWhiteSpace(findItem))
        {
            findItem = findItem.NormlizeWhitespace();
            var findItemLowerNonUnicode = findItem.NonUnicodeLower();
            query = query.Where(h =>
                h.OrderCode.Contains(findItemLowerNonUnicode)
                || h.AcceptPhone.Contains(findItemLowerNonUnicode)
                || h.AcceptName.Contains(findItem)
            );
        }

        var list = await query.Select(h => new DonDatDanhSachOutput
        {
            Id = h.Id,
            OrderCode = h.OrderCode,
            AcceptName = h.AcceptName,
            AcceptPhone = h.AcceptPhone,
            AcceptAddress = h.AcceptAddress,
            CreateDate = h.CreateDate,
            StatusName = h.StatusName,
            GoodsName = h.GoodsName,
            StatusBackgroundColor = h.StatusBackgroundColor,
            StatusTextColor = h.StatusTextColor,
            Cod = h.Cod
        })
            .OrderByDescending(h => h.CreateDate)
            .ToListAsync();

        return CreateOk(list);
    }
    private async Task<int> GetCalculatorFee(string customerId, int weight, int provine, int district)
    {
        var customer = await _dbCtx.ExpCustomers.FirstOrDefaultAsync(u => u.Id == customerId);
        if (customer != null)
        {
            if (weight > 0)
            {
                try
                {
                    List<ViewGexpFeeDetailsPro> lsProFeeDetail = new List<ViewGexpFeeDetailsPro>();
                    List<ViewGexpFeeDetail> lsSubFeeDetail = new List<ViewGexpFeeDetail>();
                    // Khách hàng sỉ
                    lsSubFeeDetail = await _dbCtx.ViewGexpFeeDetails.Where(u => u.FkPost == customer.FkPost && u.FkGexpFee == customer.FkGiaCuoc).ToListAsync();
                    lsProFeeDetail = await _dbCtx.ViewGexpFeeDetailsPros.Where(u => u.FkPost == customer.FkPost && u.FkGexpFee == customer.FkGiaCuoc && u.ProvineId == provine && u.District.Contains(district.ToString())).ToListAsync();
                    if (lsProFeeDetail.Count > 0)
                    {
                        // Ưu tiên Provine
                        int MinWeight = 0;
                        int MinFee = 0;
                        int StepWeight = 0;
                        int NextFee = 0;
                        foreach (var item in lsProFeeDetail.OrderBy(u => u.MinWeight))
                        {
                            MinWeight = item.MinWeight;
                            MinFee = item.MinFee;
                            StepWeight = item.StepWeight;
                            NextFee = item.NextFee;
                            if (weight <= MinWeight)
                            {
                                break;
                            }
                        }
                        if (weight <= MinWeight)
                        {
                            return MinFee;
                        }
                        else
                        {
                            decimal fee = ((decimal)(weight - MinWeight) / StepWeight) * NextFee;
                            return (int)(fee + MinFee);
                        }
                    }
                    else if (lsSubFeeDetail.Count > 0)
                    {
                        ExpPost postObject = await _dbCtx.ExpPosts.FirstOrDefaultAsync(u => u.Id == customer.FkPost);
                        GexpProvince province = await _dbCtx.GexpProvinces.FirstOrDefaultAsync(u => u.ProvinceId == provine);
                        if (province != null)
                        {
                            int MinWeight = 0;
                            int MinFee = 0;
                            int StepWeight = 0;
                            int NextFee = 0;
                            foreach (var item in lsSubFeeDetail.OrderBy(u => u.MinWeightInt))
                            {
                                if (province.ProvinceId == postObject.FkDvhc)
                                {
                                    // Nội tỉnh
                                    MinWeight = item.MinWeightInt;
                                    MinFee = item.MinFeeInt;
                                    StepWeight = item.StepWeightInt;
                                    NextFee = item.NextFeeInt;
                                }
                                else if (province.ZoneCode == postObject.ZoneCode)
                                {
                                    // Nội miền
                                    MinWeight = item.MinWeightMn;
                                    MinFee = item.MinFeeMn;
                                    StepWeight = item.StepWeightMn;
                                    NextFee = item.NextFeeMn;
                                }
                                else
                                {
                                    int zoneNhan = Int32.Parse(province.ZoneCode);
                                    int zonePost = Int32.Parse(postObject.ZoneCode);
                                    int zonediff = Math.Abs(zonePost - zoneNhan);
                                    if (zonediff == 1)
                                    {
                                        // Cận miền
                                        MinWeight = item.MinWeightMt;
                                        MinFee = item.MinFeeMt;
                                        StepWeight = item.StepWeightMt;
                                        NextFee = item.NextFeeMt;
                                    }
                                    else
                                    {
                                        // Liên miền
                                        MinWeight = item.MinWeightMb;
                                        MinFee = item.MinFeeMb;
                                        StepWeight = item.StepWeightMb;
                                        NextFee = item.NextFeeMb;
                                    }
                                }
                                // Tìm điều kiện phù hợp
                                if (weight <= MinWeight)
                                {
                                    break;
                                }
                            }
                            if (weight <= MinWeight)
                            {
                                return MinFee;
                            }
                            else
                            {
                                decimal fee = ((decimal)(weight - MinWeight) / StepWeight) * NextFee;
                                return (int)(fee + MinFee);
                            }
                        }
                        else
                        {
                            return 0;
                        }

                    }
                    else
                    {
                        return 0;
                    }
                }
                catch
                {
                    return 0;
                }
            }
            return 0;
        }
        else
        {
            return 0;
        }
    }
    [HttpGet]
    public async Task<ApiResult<int>> GetFee([FromHeader] int? weight, [FromHeader] int? provine, [FromHeader] int? district)
    {
        var fkCustomer = GetLoginUserId();
        int w = weight == null ? 0 : weight.Value;
        int p = provine == null ? 0 : provine.Value;
        int d = district == null ? 0 : district.Value;
        if (w == 0)
        {
            return CreateOk(0);
        }
        int fee = await GetCalculatorFee(fkCustomer, w, p, d);
        return CreateOk(fee);
    }

    [HttpGet]
    public async Task<ApiResult<AcceptOutput>> GetAccepntMan([FromHeader] string phone)
    {
        AcceptOutput model = new AcceptOutput();
        model.IsFound = false;
        var accept = await _dbCtx.GexpAccepts.FirstOrDefaultAsync(u => u.AcceptPhone == phone);
        if (accept != null)
        {
            model.IsFound = true;
            model.AcceptName = accept.AcceptMan;
            model.AcceptPhone = accept.AcceptPhone;
            model.AcceptAddress = accept.AcceptAddress;
            model.ProvineCode = accept.AcceptProvince;
            model.DistrictCode = accept.AcceptDistrict;
            model.WardCode = accept.AcceptWard;
            model.DanhSachHuyen = await _dbCtx.GexpDistricts.AsNoTracking().Where(u => u.ProvinceId == model.ProvineCode).Select(h => new DistrictDanhSachOutput { Id = h.DistrictId, Name = h.DistrictName, ProvineId = h.ProvinceId }).ToListAsync();
            model.DanhSachXa = await _dbCtx.GexpWards.AsNoTracking().Where(u => u.DistrictId == model.DistrictCode).Select(h => new WardDanhSachOutput { Id = h.WardId, Name = h.WardName, DistrictId = h.DistrictId }).ToListAsync();
        }
        return CreateOk(model);
    }
    [HttpGet]
    public async Task<ApiResult<DistrictDanhSachFeeOutput>> GetDistrict([FromHeader] int provine, [FromHeader] int? weight)
    {
        var fkCustomer = GetLoginUserId();
        int w = weight == null ? 0 : weight.Value;
        int d = 0;

        DistrictDanhSachFeeOutput model = new DistrictDanhSachFeeOutput();
        model.DanhSachHuyen = await _dbCtx.GexpDistricts.AsNoTracking().Where(u => u.ProvinceId == provine).Select(h => new DistrictDanhSachOutput { Id = h.DistrictId, Name = h.DistrictName, ProvineId = h.ProvinceId }).ToListAsync();
        if (model.DanhSachHuyen.Count > 0)
        {
            d = model.DanhSachHuyen[0].Id;
            model.DanhSachXa = await _dbCtx.GexpWards.AsNoTracking().Where(u => u.DistrictId == model.DanhSachHuyen[0].Id).Select(h => new WardDanhSachOutput { Id = h.WardId, Name = h.WardName, DistrictId = h.DistrictId }).ToListAsync();
        }
        model.Fee = await GetCalculatorFee(fkCustomer, w, provine, d);
        return CreateOk(model);
    }
    [HttpGet]
    public async Task<ApiResult<WardDanhSachFeeOutput>> GetWard([FromHeader] int districtId, [FromHeader] int? provine, [FromHeader] int? weight)
    {
        var fkCustomer = GetLoginUserId();
        WardDanhSachFeeOutput model = new WardDanhSachFeeOutput();
        model.DanhSachXa = await _dbCtx.GexpWards.AsNoTracking().Where(u => u.DistrictId == districtId).Select(h => new WardDanhSachOutput { Id = h.WardId, Name = h.WardName, DistrictId = h.DistrictId }).ToListAsync();
        int w = weight == null ? 0 : weight.Value;
        int p = provine == null ? 0 : provine.Value;
        int d = districtId;
        model.Fee = await GetCalculatorFee(fkCustomer, w, p, d);
        return CreateOk(model);
    }

    [HttpGet]
    public async Task<ApiResult<GexpOrderDto>> ChiTiet([Required] string id)
    {
        var fkCustomer = GetLoginUserId();
        var dbItem = await _dbCtx.GexpOrders.AsNoTracking().FirstOrDefaultAsync(h => h.Id == id);
        if (dbItem == null)
        {
            if (id == "0000")
            {
                // Load các giá trị khởi tạo cho list
                var resultNew = new GexpOrderDto();
                resultNew.DanhSachProvine = await _dbCtx.GexpProvinces.AsNoTracking().Select(h => new ProvineDanhSachOutput { Id = h.ProvinceId, Name = h.ProvinceName }).ToListAsync();
                resultNew.ProvinceCode = resultNew.DanhSachProvine[0].Id;
                resultNew.DanhSachDistrict = await _dbCtx.GexpDistricts.AsNoTracking().Where(u => u.ProvinceId == resultNew.ProvinceCode).Select(h => new DistrictDanhSachOutput { Id = h.DistrictId, Name = h.DistrictName, ProvineId = h.ProvinceId }).ToListAsync();
                resultNew.DistrictCode = resultNew.DanhSachDistrict[0].Id;
                resultNew.DanhSachWard = await _dbCtx.GexpWards.AsNoTracking().Where(u => u.DistrictId == resultNew.DistrictCode).Select(h => new WardDanhSachOutput { Id = h.WardId, Name = h.WardName, DistrictId = h.DistrictId }).ToListAsync();
                resultNew.DistrictWard = resultNew.DanhSachWard[0].Id;
                resultNew.IsShopPay = true;
                resultNew.FkShipperNot = "CXH";

                resultNew.Note = "Đơn hàng có vấn đề vui lòng liên hệ lại shop.";
                var customer = await _dbCtx.ExpCustomers.FirstOrDefaultAsync(u => u.Id == fkCustomer);
                if (customer != null)
                {
                    resultNew.GoodsName = customer.TenSanPham;
                    resultNew.Note = "Đơn hàng có vấn đề vui lòng liên hệ " + customer.CustomerPhone + " để được xử lý.";
                }
                return CreateOk(resultNew);
            }
            else
            {
                throw new LogicException("Đơn đặt hàng không tồn tại");
            }

        }
        // Lấy danh sách tỉnh huyện xã

        var result = dbItem.Adapt<GexpOrderDto>();
        result.DanhSachProvine = await _dbCtx.GexpProvinces.AsNoTracking().Select(h => new ProvineDanhSachOutput { Id = h.ProvinceId, Name = h.ProvinceName }).ToListAsync();
        if (result.DanhSachProvine.Count > 0)
        {
            result.DanhSachDistrict = await _dbCtx.GexpDistricts.AsNoTracking().Where(u => u.ProvinceId == result.ProvinceCode).Select(h => new DistrictDanhSachOutput { Id = h.DistrictId, Name = h.DistrictName, ProvineId = h.ProvinceId }).ToListAsync();
            if (result.DanhSachDistrict.Count > 0)
            {
                result.DanhSachWard = await _dbCtx.GexpWards.AsNoTracking().Where(u => u.DistrictId == result.DistrictCode).Select(h => new WardDanhSachOutput { Id = h.WardId, Name = h.WardName, DistrictId = h.DistrictId }).ToListAsync();
            }
        }

        return CreateOk(result);
    }


    [HttpPost]
    public async Task<ApiResult<GexpOrderDto>> TaoMoi(DonDatEditInput input)
    {
        var validateError = DonDatValidate.ValidateAndNormalize(input, false);
        if (validateError.Length > 0)
        {
            throw new LogicException("Dữ liệu đầu vào không hợp lệ:\n" + validateError);
        }

        var dbItem = new GexpOrder
        {
            Id = Guid.NewGuid().ToString(),
            OrderCode = GetDateNow().ToString("yyMMddHHmmss"),
            AcceptName = input.AcceptName,
            AcceptPhone = input.AcceptPhone,
            AcceptAddress = input.AcceptAddress,
            GoodsName = input.GoodsName,
            Cod = input.Cod,
            IsShopPay = input.IsShopPay,
            Note = input.Note,
            CreateDate = GetDateNow(),
            FkCustomerId = GetLoginUserId(),
            StatusOrder = 0,
            Weight = input.Weight,
            ProvinceCode = input.ProvinceCode,
            DistrictCode = input.DistrictCode,
            DistrictWard = input.DistrictWard,
            FkShipperNot = input.FK_ShipperNot,
            Freight = input.Freight
        };

        _dbCtx.GexpOrders.Add(dbItem);
        await _dbCtx.SaveChangesAsync();

        var result = dbItem.Adapt<GexpOrderDto>();

        return CreateOk(result);
    }

    [HttpPost]
    public async Task<ApiResult<GexpOrderDto>> CapNhat(DonDatEditInput input)
    {
        var validateError = DonDatValidate.ValidateAndNormalize(input, true);
        if (validateError.Length > 0)
        {
            throw new LogicException("Dữ liệu đầu vào không hợp lệ:\n" + validateError);
        }

        var dbItem = await _dbCtx.GexpOrders.FirstOrDefaultAsync(h => h.Id == input.Id);
        if (dbItem == null)
        {
            throw new LogicException("Đơn đặt hàng không tồn tại");
        }

        dbItem.AcceptName = input.AcceptName;
        dbItem.AcceptPhone = input.AcceptPhone;
        dbItem.AcceptAddress = input.AcceptAddress;
        dbItem.GoodsName = input.GoodsName;
        dbItem.Cod = input.Cod;
        dbItem.IsShopPay = input.IsShopPay;
        dbItem.Note = input.Note;
        dbItem.Weight = input.Weight;
        dbItem.ProvinceCode = input.ProvinceCode;
        dbItem.DistrictCode = input.DistrictCode;
        dbItem.DistrictWard = input.DistrictWard;
        dbItem.Freight = input.Freight;

        await _dbCtx.SaveChangesAsync();

        var result = dbItem.Adapt<GexpOrderDto>();

        return CreateOk(result);
    }


    [HttpPost]
    public async Task<ApiResult<bool>> Xoa([Required] string id)
    {
        try
        {
            var dbItem = await _dbCtx.GexpOrders.FirstOrDefaultAsync(h => h.Id == id);
            if (dbItem == null)
            {
                throw new LogicException("Đơn đặt hàng không tồn tại");
            }
            dbItem.StatusOrder = 2; // Xóa
            await _dbCtx.SaveChangesAsync();

            return CreateOk(true);
        }
        catch (Exception ex)
        {
            throw new LogicException(ex.ToString());
        }
    }


    [HttpPost]
    public async Task<ApiResult<DonDatDanhSachOutput>> SaoChep(DonDatEditInput input)
    {


        var dbItem = await _dbCtx.GexpOrders.AsNoTracking().FirstOrDefaultAsync(h => h.Id == input.Id);
        if (dbItem == null)
        {
            throw new LogicException("Đơn đặt hàng không tồn tại");
        }

        var dbItemNew = new GexpOrder
        {
            Id = Guid.NewGuid().ToString(),
            OrderCode = GetDateNow().ToString("yyMMddHHmmss"),
            AcceptName = dbItem.AcceptName,
            AcceptPhone = dbItem.AcceptPhone,
            AcceptAddress = dbItem.AcceptAddress,
            GoodsName = dbItem.GoodsName,
            Cod = dbItem.Cod,
            IsShopPay = dbItem.IsShopPay,
            Note = dbItem.Note,
            CreateDate = GetDateNow(),
            FkCustomerId = GetLoginUserId(),
            StatusOrder = 0,
            Weight = dbItem.Weight,
            ProvinceCode = dbItem.ProvinceCode,
            DistrictCode = dbItem.DistrictCode,
            DistrictWard = dbItem.DistrictWard,
            FkShipperNot = dbItem.FkShipperNot,
            Freight = dbItem.Freight
        };
        _dbCtx.GexpOrders.Add(dbItemNew);


        await _dbCtx.SaveChangesAsync();

        var result = await _dbCtx.ViewGexpOrders.AsNoTracking()
            .Where(h => h.Id == dbItemNew.Id)
            .Select(h => new DonDatDanhSachOutput
            {
                Id = h.Id,
                OrderCode = h.OrderCode,
                AcceptName = h.AcceptName,
                AcceptPhone = h.AcceptPhone,
                AcceptAddress = h.AcceptAddress,
                CreateDate = h.CreateDate,
                StatusName = h.StatusName,
                GoodsName = h.GoodsName,
                StatusBackgroundColor = h.StatusBackgroundColor,
                StatusTextColor = h.StatusTextColor,
                Cod = h.Cod
            })
            .FirstOrDefaultAsync()
            ;

        return CreateOk(result);
    }


}

