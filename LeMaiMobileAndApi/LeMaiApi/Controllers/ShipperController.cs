﻿using IdentityModel;
using LeMai.Efs;
using LeMaiApi.Models;
using LeMaiDto;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LeMaiApi.Controllers
{
    public class ShipperController : GhControllerBase<ShipperController>
    {
        private readonly LeMaiDbContext _dbCtx;
        private readonly IConfiguration _config;

        public ShipperController(ILogger<ShipperController> logger
            , LeMaiDbContext dbContext
            , IConfiguration config
            ) : base(logger)
        {
            _dbCtx = dbContext;
            _config = config;
        }
        #region Tài khoản Shipper
        [HttpPost]
        public async Task<ApiResult<TaiKhoanDangNhapOutput>> DangNhap(
        [FromServices] IWebHostEnvironment env,
        TaiKhoanDangNhapInput model)
        {
            var taiKhoan = await _dbCtx.GexpShippers.AsNoTracking().FirstOrDefaultAsync(h =>
                h.UserName == model.TenDangNhap && h.IsDelete == false
            );

            if (taiKhoan == null)
            {
                throw new LogicException("Tài khoản không tồn tại.");
            }
            else if (taiKhoan.Password != model.MatKhau)
            {
                throw new LogicException("Mật khẩu không chính xác.");
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_config["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                new Claim(JwtClaimTypes.Name, taiKhoan.ShipperName),
                new Claim(JwtClaimTypes.Id, taiKhoan.Id),
                new Claim(ClaimTypes.UserData, "UserData")
                }),

                Audience = _config["Jwt:Audience"],
                Issuer = _config["Jwt:Issuer"],

                //Expires = DateTime.UtcNow.AddMinutes(_config.GetValue<double>("Jwt:ExpiresAccessToken")),
                Expires = DateTime.UtcNow.AddDays(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // Kiem tra co gan ket can ho

            var result = new TaiKhoanDangNhapOutput
            {
                Id = taiKhoan.Id,
                Code = taiKhoan.UserName,
                HoTen = taiKhoan.ShipperName,
                SoDienThoai = taiKhoan.ShipperPhone,
                AccessToken = tokenHandler.WriteToken(token),
                AccessTimeoutUtc = tokenDescriptor.Expires?.ToString("yyyy-MM-dd HH:mm:ss"),
            };

            return CreateOk(result);
        }

        [Authorize]
        [HttpPost]
        public async Task<ApiResult<bool>> DoiMatKhau(TaiKhoanDoiMatKhauInput model)
        {
            var userId = GetLoginUserId();

            var taiKhoan = await _dbCtx.GexpShippers.FirstOrDefaultAsync(h => h.Id == userId);
            if (taiKhoan == null)
            {
                throw new LogicException("Tài khoản không tồn tại.");
            }

            taiKhoan.Password = model.MatKhauMoi;

            await _dbCtx.SaveChangesAsync();


            return CreateOk(true);
        }
        [Authorize]
        [HttpPost]
        public async Task<ApiResult<bool>> XoaTaiKhoan()
        {
            var userId = GetLoginUserId();

            var taiKhoan = await _dbCtx.GexpShippers.FirstOrDefaultAsync(h =>
                h.Id == userId
            );

            if (taiKhoan == null)
            {
                throw new LogicException("Tài khoản không tồn tại.");
            }

            taiKhoan.IsDelete = true;

            await _dbCtx.SaveChangesAsync();

            return CreateOk(true);
        }
        [HttpPost]
        public async Task<ApiResult<bool>> DangKy(TaiKhoanDangKyInput model)
        {
            var customerCode = model.SoDienThoai;
            var taiKhoan = await _dbCtx.GexpShippers.AsNoTracking().FirstOrDefaultAsync(h =>
                h.UserName == customerCode
            );
            if (taiKhoan != null)
            {
                throw new LogicException("Tài khoản đã tồn tại.");
            }
            taiKhoan = new GexpShipper
            {
                Id = Guid.NewGuid().ToString(),
                ShipperName = model.HoTen,
                UserName = customerCode,
                ShipperPhone = model.SoDienThoai,
                Password = model.MatKhau,
                IsDelete = false,
                FkPost = "0000"
            };

            _dbCtx.GexpShippers.Add(taiKhoan);
            await _dbCtx.SaveChangesAsync();


            return CreateOk(true);
        }
        #endregion

        #region Tổng Hợp Thống Kê Page
        [HttpGet]
        public async Task<ApiResult<VanDonThongKeOutput>> ThongKeVanDon(
         string registerDateType
        , DateTime? registerDateFrom
        , DateTime? registerDateTo
        )
        {
            var fkshipperId = GetLoginUserId();

            var query = _dbCtx.ViewGexpBillDeliveries.AsNoTracking()
                .Where(h => h.FkShipperId == fkshipperId);

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
                query = query.Where(h => h.DeliveryDate >= compareDate);
            }
            if (registerDateTo.HasValue)
            {
                var compareDate = registerDateTo.Value.Date.AddDays(1);
                query = query.Where(h => h.DeliveryDate < compareDate);
            }


            var list = await query.Select(h => new
            {
                h.StatusName,
                h.Cod,
                h.IsPayCustomer,
                h.FeeWeight
            })
                .ToListAsync();

            var group = list.GroupBy(h => h.StatusName).ToList();
            var listStatusName = new List<string>(group.Count);
            var listCountStatusName = new List<int>(group.Count);

            foreach (var item in group)
            {
                listStatusName.Add(item.Key);
                listCountStatusName.Add(item.Count());
            }

            var result = new VanDonThongKeOutput
            {
                TongDon = list.Count,
                ListStatusName = listStatusName,
                ListCountStatusName = listCountStatusName,
                TongTien = list.Sum(h => h.Cod),
                DaThanhToan = list.Where(h => h.IsPayCustomer).Sum(h => h.Cod),
                TongCanNang = list.Sum(h => h.FeeWeight)
            };
            result.ChuaThanhToan = result.TongTien - result.DaThanhToan;

            return CreateOk(result);
        }
        #endregion

        #region Giao Hàng Page
        /// <summary>
        /// Danh sách trạng thái
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ApiResult<VanDonListMasterOutput>> ListMasterVanDon()
        {


            var listStatusName = await _dbCtx.GexpBillStatuses
                .Where(h => h.IsShowMobile)
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
        /// <summary>
        /// Danh sách đơn hàng giao
        /// </summary>
        /// <param name="findItem"></param>
        /// <param name="registerDateType"></param>
        /// <param name="registerDateFrom"></param>
        /// <param name="registerDateTo"></param>
        /// <param name="listStatusName"></param>
        /// <param name="isSigned"></param>
        /// <param name="isPayCustomer"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ApiResult<List<VanDonDanhSachOutput>>> DanhSachVanDon(
            string findItem
            , string registerDateType
            , DateTime? registerDateFrom
            , DateTime? registerDateTo
            , [FromQuery] List<string> listStatusName
            , bool? isSigned
            , bool? isPayCustomer
            )
        {
            var fkShipperId = GetLoginUserId();

            var query = _dbCtx.ViewGexpBillDeliveries.AsNoTracking()
                .Where(h => h.FkShipperId == fkShipperId);

            if (isSigned.HasValue)
            {
                query = query.Where(h => h.IsSigned == isSigned.Value);
            }
            if (isPayCustomer.HasValue)
            {
                query = query.Where(h => h.IsPayCustomer == isPayCustomer.Value);
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
                query = query.Where(h => h.DeliveryDate >= compareDate);
            }
            if (registerDateTo.HasValue)
            {
                var compareDate = registerDateTo.Value.Date.AddDays(1);
                query = query.Where(h => h.DeliveryDate < compareDate);
            }


            if (!string.IsNullOrWhiteSpace(findItem))
            {
                findItem = findItem.NormlizeWhitespace();
                var findItemLowerNonUnicode = findItem.NonUnicodeLower();
                query = query.Where(h =>
                    h.BillCode.Contains(findItemLowerNonUnicode)
                    || h.AcceptManPhone.Contains(findItemLowerNonUnicode)
                    || h.AcceptMan.Contains(findItem)
                    || h.AcceptManUs.Contains(findItemLowerNonUnicode)
                );
            }

            var list = await query.Select(h => new VanDonDanhSachOutput
            {
                BillCode = h.BillCode,
                AcceptMan = h.AcceptMan,
                AcceptManPhone = h.AcceptManPhone,
                AcceptProvince = h.AcceptProvince,
                RegisterDate = h.RegisterDate,
                StatusName = h.StatusName,
                GoodsName = h.GoodsName,
                StatusBackgroundColor = h.StatusBackgroundColor,
                StatusTextColor = h.StatusTextColor,
                FeeWeight = h.BillWeight / 1000,
                Cod = h.FkPaymentType == "GTT" ? h.Cod : h.Cod + h.Freight,
                GoodsNumber = h.GoodsNumber,
                Address = h.FullAddress,
                Payment = h.FkPaymentType,
                Freight = h.Freight,
                SendMan = h.SendMan,
                SendManPhone= h.SendManPhone

            })
                .OrderByDescending(h => h.RegisterDate)
                .ToListAsync();

            return CreateOk(list);
        }
        /// <summary>
        /// Chi tiết vận đơn
        /// </summary>
        /// <param name="billCode"></param>
        /// <returns></returns>
        /// <exception cref="LogicException"></exception>
        [HttpGet]
        public async Task<ApiResult<VanDonChiTietOutput>> ChiTietVanDon(
            [Required] string billCode
            )
        {
            var vanDon = await _dbCtx.ViewGexpBillDeliveries.AsNoTracking()
                .Where(h => h.BillCode == billCode)
                .ProjectToType<VanDonChiTietViewGexpBill>()
                .FirstOrDefaultAsync()
                ;
            if (vanDon == null)
            {
                throw new LogicException("Không tìm thấy vận đơn.");
            }

            var listHanhTrinh = await _dbCtx.GexpScans.AsNoTracking()
                .Where(h => h.BillCode == billCode)
                .OrderByDescending(h => h.CreateDate)
                .ProjectToType<VanDonChitietGexpScan>()
                .ToListAsync();
            return CreateOk(new VanDonChiTietOutput
            {
                ChiTiet = vanDon,
                ListHanhTrinh = listHanhTrinh
            });
        }
        #endregion

        #region Kiện vấn đề
        public async Task<ApiResult<VanDonListMasterOutput>> ListMasterKienVanDe()
        {


            var listStatusName = await _dbCtx.GexpBillStatuses
                .Where(h => h.IsShowMobile)
                .Select(h => new
                {
                    h.StatusName,
                    h.StatusBackgroundColor,
                    h.StatusTextColor
                })
                .ToListAsync();

            return CreateOk(new VanDonListMasterOutput
            {
                ListStatusName = listStatusName.Select(h => h.StatusName).ToList(),
                ListStatusBgColor = listStatusName.Select(h => h.StatusBackgroundColor).ToList(),
                ListStatusTextColor = listStatusName.Select(h => h.StatusTextColor).ToList(),
            });
        }


        [HttpGet]
        public async Task<ApiResult<List<KienVanDeDanhSachOutput>>> DanhSachKienVanDe(
            string findItem
            , string registerDateType
            , DateTime? registerDateFrom
            , DateTime? registerDateTo
            , [FromQuery] List<string> listStatusName
            )
        {
            var fkShipperId = GetLoginUserId();

            var query = _dbCtx.ViewGexpProblems.AsNoTracking()
                .Where(h => h.UserId == fkShipperId);
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
                query = query.Where(h => h.RegisterDate >= compareDate);
            }
            if (registerDateTo.HasValue)
            {
                var compareDate = registerDateTo.Value.Date.AddDays(1);
                query = query.Where(h => h.RegisterDate < compareDate);
            }


            if (!string.IsNullOrWhiteSpace(findItem))
            {
                findItem = findItem.NormlizeWhitespace();
                var findItemLowerNonUnicode = findItem.NonUnicodeLower();
                query = query.Where(h =>
                    h.BillCode.Contains(findItemLowerNonUnicode)
                    || h.AcceptManPhone.Contains(findItemLowerNonUnicode)
                    || h.AcceptMan.Contains(findItem)
                );
            }

            var list = await query.Select(h => new KienVanDeDanhSachOutput
            {
                BillCode = h.BillCode,
                AcceptMan = h.AcceptMan,
                AcceptManPhone = h.AcceptManPhone,
                AcceptProvince = h.AcceptProvince,
                RegisterDate = h.RegisterDate,
                StatusName = h.StatusName,
                GoodsName = h.GoodsName,
                StatusBackgroundColor = h.StatusBackgroundColor,
                StatusTextColor = h.StatusTextColor,
                Note = h.Note
            })
                .OrderByDescending(h => h.RegisterDate)
                .ToListAsync();

            return CreateOk(list);
        }
        #endregion

        #region COD
        [HttpGet]
        public async Task<ApiResult<List<VanDonDanhSachOutput>>> DanhSachCOD(
        string findItem
        , string registerDateType
        , DateTime? registerDateFrom
        , DateTime? registerDateTo
        , [FromQuery] List<string> listStatusName
        , bool? isSigned
        , bool? isPayCustomer
        )
        {
            var fkShipperId = GetLoginUserId();

            var query = _dbCtx.ViewGexpBillDeliveries.AsNoTracking()
                .Where(h => h.FkShipperId == fkShipperId);

            if (isSigned.HasValue)
            {
                query = query.Where(h => h.IsSigned == isSigned.Value);
            }
            if (isPayCustomer.HasValue)
            {
                query = query.Where(h => h.IsPayCustomer == isPayCustomer.Value);
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
                query = query.Where(h => h.DeliveryDate >= compareDate);
            }
            if (registerDateTo.HasValue)
            {
                var compareDate = registerDateTo.Value.Date.AddDays(1);
                query = query.Where(h => h.DeliveryDate < compareDate);
            }


            if (!string.IsNullOrWhiteSpace(findItem))
            {
                findItem = findItem.NormlizeWhitespace();
                var findItemLowerNonUnicode = findItem.NonUnicodeLower();
                query = query.Where(h =>
                    h.BillCode.Contains(findItemLowerNonUnicode)
                    || h.AcceptManPhone.Contains(findItemLowerNonUnicode)
                    || h.AcceptMan.Contains(findItem)
                    || h.AcceptManUs.Contains(findItemLowerNonUnicode)
                );
            }

            var list = await query.Select(h => new VanDonDanhSachOutput
            {
                BillCode = h.BillCode,
                AcceptMan = h.AcceptMan,
                AcceptManPhone = h.AcceptManPhone,
                AcceptProvince = h.AcceptProvince,
                RegisterDate = h.RegisterDate,
                StatusName = h.StatusName,
                GoodsName = h.GoodsName,
                StatusBackgroundColor = h.StatusBackgroundColor,
                StatusTextColor = h.StatusTextColor,
                FeeWeight = h.FeeWeight,
                Cod = h.Cod
            })
                .OrderByDescending(h => h.RegisterDate)
                .ToListAsync();

            return CreateOk(list);
        }
        #endregion

        #region Danh Sách Pickup
        [HttpGet]
        public async Task<ApiResult<List<DonDatDanhSachOutput>>> DanhSachPickup(
        string id
        , string findItem
        , string registerDateType
        , DateTime? registerDateFrom
        , DateTime? registerDateTo
        , [FromQuery] List<string> listStatusName
        )
        {
            var fkShipperId = GetLoginUserId();

            var query = _dbCtx.ViewGexpReceiveTasks.AsNoTracking()
                .Where(h => h.FkShipperId == fkShipperId);

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
                    query = query.Where(h => h.StatusReceiveName == statusName);
                }
                else if (listStatusName.Count > 1)
                {
                    query = query.Where(h => listStatusName.Contains(h.StatusReceiveName));
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
                    h.CustomerPhone.Contains(findItemLowerNonUnicode)
                    || h.CustomerName.Contains(findItem)
                );
            }

            var list = await query.Select(h => new DonDatDanhSachOutput
            {
                Id = h.Id,
                OrderCode = h.CustomerCode,
                AcceptName = h.CustomerName,
                AcceptPhone = h.CustomerPhone,
                AcceptAddress = h.DiaChi,
                CreateDate = h.CreateDate,
                StatusName = h.StatusReceiveName
            })
                .OrderByDescending(h => h.CreateDate)
                .ToListAsync();

            return CreateOk(list);
        }

        [HttpPost]
        public async Task<ApiResult<GexpOrderDto>> CapNhatPickup(DonDatEditInput input)
        {
            var dbItem = await _dbCtx.GexpReceiveTasks.FirstOrDefaultAsync(h => h.Id == input.Id);
            if (dbItem == null)
            {
                throw new LogicException("Nhiệm vụ lấy hàng không tồn tại");
            }
            var fkShipperId = GetLoginUserId();
            dbItem.PickupDate = DateTime.Now;
            dbItem.FkPickupShipper = fkShipperId;
            dbItem.ReceiveStatus = input.StatusOrder;
            await _dbCtx.SaveChangesAsync();

            var result = dbItem.Adapt<GexpOrderDto>();
            return CreateOk(result);
        }
        #endregion

    }
}
