using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public class BalanceDetailLogic : BaseLogic
    {
        public BalanceDetailLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        public async Task<List<GExpBalanceDetailType>> GetBalanceTypeList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBalanceDetailType type = new GExpBalanceDetailType();
                type.Id = "9999";
                type.TenLoai = "Tất cả";
                var list = new List<GExpBalanceDetailType>();
                list.Add(type);
                list.AddRange(dc.GExpbalancedetailtype.GetListObjectCon(base.ConnectionData.Schema, "ORDER BY SortIndex"));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<BalanceDetailModel>> GetBalanDetailList(string post, string billCode, string balanceType, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<BalanceDetailModel> lsResult = new List<BalanceDetailModel>();
                string condition = "WHERE (FK_ExtPostFrom=@post OR FK_ExtPostTo=@post) AND CreateDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (!string.IsNullOrEmpty(billCode))
                {
                    condition += "BillCode='" + billCode + "' &";
                }
                if (balanceType != "9999")
                {
                    condition += "Type='" + balanceType + "' &";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY CreateDate ASC";
                List<view_GExpBalanceDetail> list = dc.VIewgexpbalancedetail.GetListObjectCon(base.ConnectionData.Schema, condition, "@post", post);
                foreach (var item in list)
                {
                    BalanceDetailModel balance = new BalanceDetailModel();
                    balance.Id = item.Id;
                    balance.Ngay = item.CreateDate;
                    balance.GhiChu = item.Note;
                    balance.Value = item.Value;
                    balance.BillCode = item.BillCode;
                    balance.TenLoaiThanhToan = item.TenLoai;
                    balance.NgayS = string.Format("{0:dd/MM/yyyy}", item.CreateDate);
                    balance.GioS = string.Format("{0:HH:mm}", item.CreateDate);
                    balance.SoChi = 0;
                    balance.SoThu = 0;
                    if (item.FK_ExtPostFrom == post)
                    {
                        // Bưu cục đang xem là bưu cục trả tiền
                        balance.BuuCuc = item.ToPost;
                        balance.IsPay = true;
                        balance.BeforeValue = item.CurrentExtPostFrom;
                        balance.AffterValue = item.AfterPostFrom;
                        balance.SoChi = item.Value;
                    }
                    else
                    {
                        // Bưu cục đang xem là bưu cục nhận tiền
                        balance.BuuCuc = item.FromPost;
                        balance.IsPay = false;
                        balance.BeforeValue = item.CurrentExtPostTo;
                        balance.AffterValue = item.AfterPostTo;
                        balance.SoThu = item.Value;
                    }
                    lsResult.Add(balance);
                }
                return lsResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }

    }
}
