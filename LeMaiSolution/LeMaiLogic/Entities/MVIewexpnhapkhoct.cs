using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpnhapkhoct:IVIewexpnhapkhoct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpnhapkhoct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpNhapKhoCt từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpNhapKhoCt]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpNhapKhoCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpNhapKhoCt] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpNhapKhoCt từ Database
		/// </summary>
		public List<view_ExpNhapKhoCt> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpNhapKhoCt]");
				List<view_ExpNhapKhoCt> items = new List<view_ExpNhapKhoCt>();
				view_ExpNhapKhoCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpNhapKhoCt();
					if (dr["FK_NhapKho"] != null && dr["FK_NhapKho"] != DBNull.Value)
					{
						item.FK_NhapKho = Convert.ToString(dr["FK_NhapKho"]);
					}
					if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
					{
						item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToDecimal(dr["DonGia"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
					}
					if (dr["TenVatTu"] != null && dr["TenVatTu"] != DBNull.Value)
					{
						item.TenVatTu = Convert.ToString(dr["TenVatTu"]);
					}
					if (dr["DVT"] != null && dr["DVT"] != DBNull.Value)
					{
						item.DVT = Convert.ToString(dr["DVT"]);
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
		/// Lấy danh sách view_ExpNhapKhoCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpNhapKhoCt> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpNhapKhoCt] A "+ condition,  parameters);
				List<view_ExpNhapKhoCt> items = new List<view_ExpNhapKhoCt>();
				view_ExpNhapKhoCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpNhapKhoCt();
					if (dr["FK_NhapKho"] != null && dr["FK_NhapKho"] != DBNull.Value)
					{
						item.FK_NhapKho = Convert.ToString(dr["FK_NhapKho"]);
					}
					if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
					{
						item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToDecimal(dr["DonGia"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
					}
					if (dr["TenVatTu"] != null && dr["TenVatTu"] != DBNull.Value)
					{
						item.TenVatTu = Convert.ToString(dr["TenVatTu"]);
					}
					if (dr["DVT"] != null && dr["DVT"] != DBNull.Value)
					{
						item.DVT = Convert.ToString(dr["DVT"]);
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

		public List<view_ExpNhapKhoCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpNhapKhoCt] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpNhapKhoCt] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpNhapKhoCt>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpNhapKhoCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpNhapKhoCt GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpNhapKhoCt] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpNhapKhoCt item=new view_ExpNhapKhoCt();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_NhapKho"] != null && dr["FK_NhapKho"] != DBNull.Value)
						{
							item.FK_NhapKho = Convert.ToString(dr["FK_NhapKho"]);
						}
						if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
						{
							item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToDecimal(dr["DonGia"]);
						}
						if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
						{
							item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
						}
						if (dr["TenVatTu"] != null && dr["TenVatTu"] != DBNull.Value)
						{
							item.TenVatTu = Convert.ToString(dr["TenVatTu"]);
						}
						if (dr["DVT"] != null && dr["DVT"] != DBNull.Value)
						{
							item.DVT = Convert.ToString(dr["DVT"]);
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

		public view_ExpNhapKhoCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpNhapKhoCt] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpNhapKhoCt>(ds);
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
