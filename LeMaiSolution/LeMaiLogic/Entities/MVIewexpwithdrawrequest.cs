using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpwithdrawrequest:IVIewexpwithdrawrequest
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpwithdrawrequest(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpWithdrawRequest từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpWithdrawRequest]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpWithdrawRequest từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpWithdrawRequest] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpWithdrawRequest từ Database
		/// </summary>
		public List<view_ExpWithdrawRequest> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpWithdrawRequest]");
				List<view_ExpWithdrawRequest> items = new List<view_ExpWithdrawRequest>();
				view_ExpWithdrawRequest item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpWithdrawRequest();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_PostRequest"] != null && dr["FK_PostRequest"] != DBNull.Value)
					{
						item.FK_PostRequest = Convert.ToString(dr["FK_PostRequest"]);
					}
					if (dr["WithdrawType"] != null && dr["WithdrawType"] != DBNull.Value)
					{
						item.WithdrawType = Convert.ToString(dr["WithdrawType"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToString(dr["Status"]);
					}
					if (dr["ApproveBy"] != null && dr["ApproveBy"] != DBNull.Value)
					{
						item.ApproveBy = Convert.ToString(dr["ApproveBy"]);
					}
					if (dr["ApproveDate"] != null && dr["ApproveDate"] != DBNull.Value)
					{
						item.ApproveDate = Convert.ToDateTime(dr["ApproveDate"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["NguoiYeuCau"] != null && dr["NguoiYeuCau"] != DBNull.Value)
					{
						item.NguoiYeuCau = Convert.ToString(dr["NguoiYeuCau"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["NguoiXuLy"] != null && dr["NguoiXuLy"] != DBNull.Value)
					{
						item.NguoiXuLy = Convert.ToString(dr["NguoiXuLy"]);
					}
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpWithdrawRequest từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpWithdrawRequest> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpWithdrawRequest] A "+ condition,  parameters);
				List<view_ExpWithdrawRequest> items = new List<view_ExpWithdrawRequest>();
				view_ExpWithdrawRequest item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpWithdrawRequest();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_PostRequest"] != null && dr["FK_PostRequest"] != DBNull.Value)
					{
						item.FK_PostRequest = Convert.ToString(dr["FK_PostRequest"]);
					}
					if (dr["WithdrawType"] != null && dr["WithdrawType"] != DBNull.Value)
					{
						item.WithdrawType = Convert.ToString(dr["WithdrawType"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToString(dr["Status"]);
					}
					if (dr["ApproveBy"] != null && dr["ApproveBy"] != DBNull.Value)
					{
						item.ApproveBy = Convert.ToString(dr["ApproveBy"]);
					}
					if (dr["ApproveDate"] != null && dr["ApproveDate"] != DBNull.Value)
					{
						item.ApproveDate = Convert.ToDateTime(dr["ApproveDate"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["NguoiYeuCau"] != null && dr["NguoiYeuCau"] != DBNull.Value)
					{
						item.NguoiYeuCau = Convert.ToString(dr["NguoiYeuCau"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["NguoiXuLy"] != null && dr["NguoiXuLy"] != DBNull.Value)
					{
						item.NguoiXuLy = Convert.ToString(dr["NguoiXuLy"]);
					}
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<view_ExpWithdrawRequest> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpWithdrawRequest] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpWithdrawRequest] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpWithdrawRequest>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpWithdrawRequest đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpWithdrawRequest GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpWithdrawRequest] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpWithdrawRequest item=new view_ExpWithdrawRequest();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_PostRequest"] != null && dr["FK_PostRequest"] != DBNull.Value)
						{
							item.FK_PostRequest = Convert.ToString(dr["FK_PostRequest"]);
						}
						if (dr["WithdrawType"] != null && dr["WithdrawType"] != DBNull.Value)
						{
							item.WithdrawType = Convert.ToString(dr["WithdrawType"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
						{
							item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToString(dr["Status"]);
						}
						if (dr["ApproveBy"] != null && dr["ApproveBy"] != DBNull.Value)
						{
							item.ApproveBy = Convert.ToString(dr["ApproveBy"]);
						}
						if (dr["ApproveDate"] != null && dr["ApproveDate"] != DBNull.Value)
						{
							item.ApproveDate = Convert.ToDateTime(dr["ApproveDate"]);
						}
						if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
						{
							item.Reason = Convert.ToString(dr["Reason"]);
						}
						if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
						{
							item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
						}
						if (dr["NguoiYeuCau"] != null && dr["NguoiYeuCau"] != DBNull.Value)
						{
							item.NguoiYeuCau = Convert.ToString(dr["NguoiYeuCau"]);
						}
						if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
						{
							item.TenLoai = Convert.ToString(dr["TenLoai"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["NguoiXuLy"] != null && dr["NguoiXuLy"] != DBNull.Value)
						{
							item.NguoiXuLy = Convert.ToString(dr["NguoiXuLy"]);
						}

						break;
					}
					return item;
				}
				else
				{
					return null;
				}
			}
			catch
			{
				throw;
			}
		}

		public view_ExpWithdrawRequest GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpWithdrawRequest] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpWithdrawRequest>(ds);
				}
				else
				{
					return null;
				}
			}
			catch
			{
				throw;
			}
		}
	}
}
