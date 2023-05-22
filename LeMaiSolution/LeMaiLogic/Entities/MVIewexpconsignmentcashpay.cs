using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpconsignmentcashpay:IVIewexpconsignmentcashpay
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpconsignmentcashpay(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentCashPay từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignmentCashPay]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignmentCashPay] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpConsignmentCashPay từ Database
		/// </summary>
		public List<view_ExpConsignmentCashPay> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignmentCashPay]");
				List<view_ExpConsignmentCashPay> items = new List<view_ExpConsignmentCashPay>();
				view_ExpConsignmentCashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignmentCashPay();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExtPostFrom"] != null && dr["FK_ExtPostFrom"] != DBNull.Value)
					{
						item.FK_ExtPostFrom = Convert.ToString(dr["FK_ExtPostFrom"]);
					}
					if (dr["CurrentExtPostFrom"] != null && dr["CurrentExtPostFrom"] != DBNull.Value)
					{
						item.CurrentExtPostFrom = Convert.ToInt32(dr["CurrentExtPostFrom"]);
					}
					if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
					{
						item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
					}
					if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
					{
						item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
					{
						item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
					}
					if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
					{
						item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["RequestId"] != null && dr["RequestId"] != DBNull.Value)
					{
						item.RequestId = Convert.ToString(dr["RequestId"]);
					}
					if (dr["FromPost"] != null && dr["FromPost"] != DBNull.Value)
					{
						item.FromPost = Convert.ToString(dr["FromPost"]);
					}
					if (dr["ToPost"] != null && dr["ToPost"] != DBNull.Value)
					{
						item.ToPost = Convert.ToString(dr["ToPost"]);
					}
					if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
					{
						item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
					{
						item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
					}
					if (dr["SoDienThoaiNguoiGui"] != null && dr["SoDienThoaiNguoiGui"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiGui = Convert.ToString(dr["SoDienThoaiNguoiGui"]);
					}
					if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
					{
						item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
					}
					if (dr["SoDienThoaiNguoiNhan"] != null && dr["SoDienThoaiNguoiNhan"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiNhan = Convert.ToString(dr["SoDienThoaiNguoiNhan"]);
					}
					if (dr["DiaChiNguoiNhan"] != null && dr["DiaChiNguoiNhan"] != DBNull.Value)
					{
						item.DiaChiNguoiNhan = Convert.ToString(dr["DiaChiNguoiNhan"]);
					}
					if (dr["TongCuoc"] != null && dr["TongCuoc"] != DBNull.Value)
					{
						item.TongCuoc = Convert.ToInt32(dr["TongCuoc"]);
					}
					if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
					{
						item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
					}
					if (dr["NguoiXoa"] != null && dr["NguoiXoa"] != DBNull.Value)
					{
						item.NguoiXoa = Convert.ToString(dr["NguoiXoa"]);
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
		/// Lấy danh sách view_ExpConsignmentCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpConsignmentCashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignmentCashPay] A "+ condition,  parameters);
				List<view_ExpConsignmentCashPay> items = new List<view_ExpConsignmentCashPay>();
				view_ExpConsignmentCashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignmentCashPay();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExtPostFrom"] != null && dr["FK_ExtPostFrom"] != DBNull.Value)
					{
						item.FK_ExtPostFrom = Convert.ToString(dr["FK_ExtPostFrom"]);
					}
					if (dr["CurrentExtPostFrom"] != null && dr["CurrentExtPostFrom"] != DBNull.Value)
					{
						item.CurrentExtPostFrom = Convert.ToInt32(dr["CurrentExtPostFrom"]);
					}
					if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
					{
						item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
					}
					if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
					{
						item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
					{
						item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
					}
					if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
					{
						item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["RequestId"] != null && dr["RequestId"] != DBNull.Value)
					{
						item.RequestId = Convert.ToString(dr["RequestId"]);
					}
					if (dr["FromPost"] != null && dr["FromPost"] != DBNull.Value)
					{
						item.FromPost = Convert.ToString(dr["FromPost"]);
					}
					if (dr["ToPost"] != null && dr["ToPost"] != DBNull.Value)
					{
						item.ToPost = Convert.ToString(dr["ToPost"]);
					}
					if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
					{
						item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
					{
						item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
					}
					if (dr["SoDienThoaiNguoiGui"] != null && dr["SoDienThoaiNguoiGui"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiGui = Convert.ToString(dr["SoDienThoaiNguoiGui"]);
					}
					if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
					{
						item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
					}
					if (dr["SoDienThoaiNguoiNhan"] != null && dr["SoDienThoaiNguoiNhan"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiNhan = Convert.ToString(dr["SoDienThoaiNguoiNhan"]);
					}
					if (dr["DiaChiNguoiNhan"] != null && dr["DiaChiNguoiNhan"] != DBNull.Value)
					{
						item.DiaChiNguoiNhan = Convert.ToString(dr["DiaChiNguoiNhan"]);
					}
					if (dr["TongCuoc"] != null && dr["TongCuoc"] != DBNull.Value)
					{
						item.TongCuoc = Convert.ToInt32(dr["TongCuoc"]);
					}
					if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
					{
						item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
					}
					if (dr["NguoiXoa"] != null && dr["NguoiXoa"] != DBNull.Value)
					{
						item.NguoiXoa = Convert.ToString(dr["NguoiXoa"]);
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

		public List<view_ExpConsignmentCashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignmentCashPay] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignmentCashPay] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpConsignmentCashPay>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpConsignmentCashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpConsignmentCashPay GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignmentCashPay] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpConsignmentCashPay item=new view_ExpConsignmentCashPay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExtPostFrom"] != null && dr["FK_ExtPostFrom"] != DBNull.Value)
						{
							item.FK_ExtPostFrom = Convert.ToString(dr["FK_ExtPostFrom"]);
						}
						if (dr["CurrentExtPostFrom"] != null && dr["CurrentExtPostFrom"] != DBNull.Value)
						{
							item.CurrentExtPostFrom = Convert.ToInt32(dr["CurrentExtPostFrom"]);
						}
						if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
						{
							item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
						}
						if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
						{
							item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
						{
							item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
						{
							item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
						}
						if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
						{
							item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
						}
						if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
						{
							item.Reason = Convert.ToString(dr["Reason"]);
						}
						if (dr["RequestId"] != null && dr["RequestId"] != DBNull.Value)
						{
							item.RequestId = Convert.ToString(dr["RequestId"]);
						}
						if (dr["FromPost"] != null && dr["FromPost"] != DBNull.Value)
						{
							item.FromPost = Convert.ToString(dr["FromPost"]);
						}
						if (dr["ToPost"] != null && dr["ToPost"] != DBNull.Value)
						{
							item.ToPost = Convert.ToString(dr["ToPost"]);
						}
						if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
						{
							item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
						}
						if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
						{
							item.TenHang = Convert.ToString(dr["TenHang"]);
						}
						if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
						{
							item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
						}
						if (dr["SoDienThoaiNguoiGui"] != null && dr["SoDienThoaiNguoiGui"] != DBNull.Value)
						{
							item.SoDienThoaiNguoiGui = Convert.ToString(dr["SoDienThoaiNguoiGui"]);
						}
						if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
						{
							item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
						}
						if (dr["SoDienThoaiNguoiNhan"] != null && dr["SoDienThoaiNguoiNhan"] != DBNull.Value)
						{
							item.SoDienThoaiNguoiNhan = Convert.ToString(dr["SoDienThoaiNguoiNhan"]);
						}
						if (dr["DiaChiNguoiNhan"] != null && dr["DiaChiNguoiNhan"] != DBNull.Value)
						{
							item.DiaChiNguoiNhan = Convert.ToString(dr["DiaChiNguoiNhan"]);
						}
						if (dr["TongCuoc"] != null && dr["TongCuoc"] != DBNull.Value)
						{
							item.TongCuoc = Convert.ToInt32(dr["TongCuoc"]);
						}
						if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
						{
							item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
						}
						if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
						{
							item.TenLoai = Convert.ToString(dr["TenLoai"]);
						}
						if (dr["NguoiXoa"] != null && dr["NguoiXoa"] != DBNull.Value)
						{
							item.NguoiXoa = Convert.ToString(dr["NguoiXoa"]);
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

		public view_ExpConsignmentCashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignmentCashPay] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpConsignmentCashPay>(ds);
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
