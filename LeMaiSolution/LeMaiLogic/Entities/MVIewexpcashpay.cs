using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpcashpay:IVIewexpcashpay
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpcashpay(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpCashPay từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpCashPay]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpCashPay] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpCashPay từ Database
		/// </summary>
		public List<view_ExpCashPay> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpCashPay]");
				List<view_ExpCashPay> items = new List<view_ExpCashPay>();
				view_ExpCashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpCashPay();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExtPost"] != null && dr["FK_ExtPost"] != DBNull.Value)
					{
						item.FK_ExtPost = Convert.ToString(dr["FK_ExtPost"]);
					}
					if (dr["IsPay"] != null && dr["IsPay"] != DBNull.Value)
					{
						item.IsPay = Convert.ToBoolean(dr["IsPay"]);
					}
					if (dr["MaNguoiNopNhan"] != null && dr["MaNguoiNopNhan"] != DBNull.Value)
					{
						item.MaNguoiNopNhan = Convert.ToString(dr["MaNguoiNopNhan"]);
					}
					if (dr["TenNguoiNopNhan"] != null && dr["TenNguoiNopNhan"] != DBNull.Value)
					{
						item.TenNguoiNopNhan = Convert.ToString(dr["TenNguoiNopNhan"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["AfterTotalValue"] != null && dr["AfterTotalValue"] != DBNull.Value)
					{
						item.AfterTotalValue = Convert.ToInt32(dr["AfterTotalValue"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
					{
						item.SoChungTu = Convert.ToString(dr["SoChungTu"]);
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
					if (dr["PrintCopied"] != null && dr["PrintCopied"] != DBNull.Value)
					{
						item.PrintCopied = Convert.ToInt32(dr["PrintCopied"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
					}
					if (dr["NguoiThu"] != null && dr["NguoiThu"] != DBNull.Value)
					{
						item.NguoiThu = Convert.ToString(dr["NguoiThu"]);
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
		/// Lấy danh sách view_ExpCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpCashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpCashPay] A "+ condition,  parameters);
				List<view_ExpCashPay> items = new List<view_ExpCashPay>();
				view_ExpCashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpCashPay();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExtPost"] != null && dr["FK_ExtPost"] != DBNull.Value)
					{
						item.FK_ExtPost = Convert.ToString(dr["FK_ExtPost"]);
					}
					if (dr["IsPay"] != null && dr["IsPay"] != DBNull.Value)
					{
						item.IsPay = Convert.ToBoolean(dr["IsPay"]);
					}
					if (dr["MaNguoiNopNhan"] != null && dr["MaNguoiNopNhan"] != DBNull.Value)
					{
						item.MaNguoiNopNhan = Convert.ToString(dr["MaNguoiNopNhan"]);
					}
					if (dr["TenNguoiNopNhan"] != null && dr["TenNguoiNopNhan"] != DBNull.Value)
					{
						item.TenNguoiNopNhan = Convert.ToString(dr["TenNguoiNopNhan"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["AfterTotalValue"] != null && dr["AfterTotalValue"] != DBNull.Value)
					{
						item.AfterTotalValue = Convert.ToInt32(dr["AfterTotalValue"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
					{
						item.SoChungTu = Convert.ToString(dr["SoChungTu"]);
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
					if (dr["PrintCopied"] != null && dr["PrintCopied"] != DBNull.Value)
					{
						item.PrintCopied = Convert.ToInt32(dr["PrintCopied"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
					}
					if (dr["NguoiThu"] != null && dr["NguoiThu"] != DBNull.Value)
					{
						item.NguoiThu = Convert.ToString(dr["NguoiThu"]);
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

		public List<view_ExpCashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpCashPay] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpCashPay] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpCashPay>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpCashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpCashPay GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpCashPay] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpCashPay item=new view_ExpCashPay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExtPost"] != null && dr["FK_ExtPost"] != DBNull.Value)
						{
							item.FK_ExtPost = Convert.ToString(dr["FK_ExtPost"]);
						}
						if (dr["IsPay"] != null && dr["IsPay"] != DBNull.Value)
						{
							item.IsPay = Convert.ToBoolean(dr["IsPay"]);
						}
						if (dr["MaNguoiNopNhan"] != null && dr["MaNguoiNopNhan"] != DBNull.Value)
						{
							item.MaNguoiNopNhan = Convert.ToString(dr["MaNguoiNopNhan"]);
						}
						if (dr["TenNguoiNopNhan"] != null && dr["TenNguoiNopNhan"] != DBNull.Value)
						{
							item.TenNguoiNopNhan = Convert.ToString(dr["TenNguoiNopNhan"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["AfterTotalValue"] != null && dr["AfterTotalValue"] != DBNull.Value)
						{
							item.AfterTotalValue = Convert.ToInt32(dr["AfterTotalValue"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
						{
							item.SoChungTu = Convert.ToString(dr["SoChungTu"]);
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
						if (dr["PrintCopied"] != null && dr["PrintCopied"] != DBNull.Value)
						{
							item.PrintCopied = Convert.ToInt32(dr["PrintCopied"]);
						}
						if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
						{
							item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
						}
						if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
						{
							item.TenLoai = Convert.ToString(dr["TenLoai"]);
						}
						if (dr["NguoiThu"] != null && dr["NguoiThu"] != DBNull.Value)
						{
							item.NguoiThu = Convert.ToString(dr["NguoiThu"]);
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

		public view_ExpCashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpCashPay] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpCashPay>(ds);
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
