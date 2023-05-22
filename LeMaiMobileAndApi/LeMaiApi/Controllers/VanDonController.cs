﻿using LeMai.Efs;
using LeMaiApi.Models;
using LeMaiDto;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LeMaiApi.Controllers;

[Authorize]
public class VanDonController : GhControllerBase<VanDonController>
{
    private readonly LeMaiDbContext _dbCtx;

    public VanDonController(ILogger<VanDonController> logger
        , LeMaiDbContext dbContext
        ) : base(logger)
    {
        _dbCtx = dbContext;
    }

    [HttpGet]
    public async Task<ApiResult<VanDonListMasterOutput>> ListMaster()
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


    [HttpGet]
    public async Task<ApiResult<List<VanDonDanhSachOutput>>> DanhSach(
        string findItem
        , string registerDateType
        , DateTime? registerDateFrom
        , DateTime? registerDateTo
        , [FromQuery] List<string> listStatusName
        , bool? isSigned
        , bool? isPayCustomer
        )
    {
        var fkCustomer = GetLoginUserId();

        var query = _dbCtx.ViewGexpBills.AsNoTracking()
            .Where(h => h.FkCustomer == fkCustomer);

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

    [HttpGet]
    public async Task<ApiResult<VanDonChiTietOutput>> ChiTiet(
        [Required] string billCode
        )
    {
        var fkCustomer = GetLoginUserId();

        var vanDon = await _dbCtx.ViewGexpBills.AsNoTracking()
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



    [HttpGet]
    public async Task<ApiResult<VanDonThongKeOutput>> ThongKe(
     string registerDateType
    , DateTime? registerDateFrom
    , DateTime? registerDateTo
    )
    {
        var fkCustomer = GetLoginUserId();

        var query = _dbCtx.ViewGexpBills.AsNoTracking()
            .Where(h => h.FkCustomer == fkCustomer);
       
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

}

