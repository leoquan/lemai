using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpsalenhapvattu:IVIewexpsalenhapvattu
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpsalenhapvattu(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpSaleNhapVatTu từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpSaleNhapVatTu]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpSaleNhapVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpSaleNhapVatTu] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpSaleNhapVatTu từ Database
		/// </summary>
		public List<view_ExpSaleNhapVatTu> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpSaleNhapVatTu]");
				List<view_ExpSaleNhapVatTu> items = new List<view_ExpSaleNhapVatTu>();
				view_ExpSaleNhapVatTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpSaleNhapVatTu();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
					{
						item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
					}
					if (dr["NgayNhap"] != null && dr["NgayNhap"] != DBNull.Value)
					{
						item.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
					}
					if (dr["NguoiNhap"] != null && dr["NguoiNhap"] != DBNull.Value)
					{
						item.NguoiNhap = Convert.ToString(dr["NguoiNhap"]);
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
					if (dr["SoLuongTonKho"] != null && dr["SoLuongTonKho"] != DBNull.Value)
					{
						item.SoLuongTonKho = Convert.ToDecimal(dr["SoLuongTonKho"]);
					}
					if (dr["QuyCach"] != null && dr["QuyCach"] != DBNull.Value)
					{
						item.QuyCach = Convert.ToString(dr["QuyCach"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
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
		/// Lấy danh sách view_ExpSaleNhapVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpSaleNhapVatTu> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpSaleNhapVatTu] A "+ condition,  parameters);
				List<view_ExpSaleNhapVatTu> items = new List<view_ExpSaleNhapVatTu>();
				view_ExpSaleNhapVatTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpSaleNhapVatTu();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
					{
						item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
					}
					if (dr["NgayNhap"] != null && dr["NgayNhap"] != DBNull.Value)
					{
						item.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
					}
					if (dr["NguoiNhap"] != null && dr["NguoiNhap"] != DBNull.Value)
					{
						item.NguoiNhap = Convert.ToString(dr["NguoiNhap"]);
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
					if (dr["SoLuongTonKho"] != null && dr["SoLuongTonKho"] != DBNull.Value)
					{
						item.SoLuongTonKho = Convert.ToDecimal(dr["SoLuongTonKho"]);
					}
					if (dr["QuyCach"] != null && dr["QuyCach"] != DBNull.Value)
					{
						item.QuyCach = Convert.ToString(dr["QuyCach"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
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

		public List<view_ExpSaleNhapVatTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpSaleNhapVatTu] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpSaleNhapVatTu] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpSaleNhapVatTu>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpSaleNhapVatTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpSaleNhapVatTu GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpSaleNhapVatTu] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpSaleNhapVatTu item=new view_ExpSaleNhapVatTu();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
						{
							item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
						}
						if (dr["NgayNhap"] != null && dr["NgayNhap"] != DBNull.Value)
						{
							item.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
						}
						if (dr["NguoiNhap"] != null && dr["NguoiNhap"] != DBNull.Value)
						{
							item.NguoiNhap = Convert.ToString(dr["NguoiNhap"]);
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
						if (dr["SoLuongTonKho"] != null && dr["SoLuongTonKho"] != DBNull.Value)
						{
							item.SoLuongTonKho = Convert.ToDecimal(dr["SoLuongTonKho"]);
						}
						if (dr["QuyCach"] != null && dr["QuyCach"] != DBNull.Value)
						{
							item.QuyCach = Convert.ToString(dr["QuyCach"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
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

		public view_ExpSaleNhapVatTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpSaleNhapVatTu] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpSaleNhapVatTu>(ds);
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
