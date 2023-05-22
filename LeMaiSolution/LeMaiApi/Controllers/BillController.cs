using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : BaseController
    {
        private readonly BillLogic _logic;
        private readonly IConfiguration _configuration;
        public BillController(ILogger<BaseController> logger,
            IConfiguration config) : base(logger)
        {
            _configuration = config;
            BaseLogicConnectionData connection = new BaseLogicConnectionData();
            connection.ConnectionString = _configuration["DefaultConnection"];
            connection.Schema = _configuration["DefaultSheme"];
            _logic = new BillLogic(connection);
        }

        [HttpPost(nameof(CancelOrder))]
        public async Task<ActionResult<ApiResultDto<ApiExecuteResult>>> CancelOrder(string BillCode)
        {
            try
            {
                var bill = await _logic.GetBillDetail(BillCode).ConfigureAwait(_configAwait);

                if (bill != null)
                {
                    return CreateResult(new ApiExecuteResult { Success = true, Code = "200", Message = "Hủy đơn hàng thành công!" });
                }
                else
                {
                    return CreateError<ApiExecuteResult>(ErrorCodeEnum.QueryNotFound, "Không tìm thấy thông tin đơn hàng " + BillCode);
                }
            }
            catch (Exception ex)
            {
                return HandleException<ApiExecuteResult>(ex);
            }
        }
        [HttpGet(nameof(GetOrderDetail))]
        public async Task<ActionResult<ApiResultDto<GExpBill>>> GetOrderDetail(string BillCode)
        {
            try
            {
                var bill = await _logic.GetBillDetail(BillCode).ConfigureAwait(_configAwait);

                if (bill != null)
                {
                    return CreateResult(bill);
                }
                else
                {
                    return CreateError<GExpBill>(ErrorCodeEnum.QueryNotFound, "Không tìm thấy thông tin đơn hàng " + BillCode);
                }
            }
            catch (Exception ex)
            {
                return HandleException<GExpBill>(ex);
            }
        }

        [HttpGet(nameof(Tracking))]
        public async Task<ActionResult<ApiResultDto<List<GExpScan>>>> Tracking(string billCode)
        {
            try
            {
                var list = await _logic.GetScanList(billCode).ConfigureAwait(_configAwait);
                if (list.Count > 0)
                {
                    return CreateResult(list);
                }
                else
                {
                    return CreateError<List<GExpScan>>(ErrorCodeEnum.QueryNotFound, "Không tìm thấy thông tin dữ liệu quét hàng [" + billCode + "]");
                }
            }
            catch (Exception ex)
            {
                return HandleException<List<GExpScan>>(ex);
            }
        }
        [HttpGet(nameof(GetProblemList))]
        public async Task<ActionResult<ApiResultDto<List<GExpScan>>>> GetProblemList(string billCode)
        {
            try
            {
                var list = await _logic.GetScanList(billCode).ConfigureAwait(_configAwait);
                if (list.Count > 0)
                {
                    return CreateResult(list);
                }
                else
                {
                    return CreateError<List<GExpScan>>(ErrorCodeEnum.QueryNotFound, "Không tìm thấy thông tin dữ liệu quét hàng [" + billCode + "]");
                }
            }
            catch (Exception ex)
            {
                return HandleException<List<GExpScan>>(ex);
            }
        }
    }
}
