using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewbaocaotaichinh:IVIewbaocaotaichinh
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewbaocaotaichinh(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_BaoCaoTaiChinh từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_BaoCaoTaiChinh]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_BaoCaoTaiChinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_BaoCaoTaiChinh] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_BaoCaoTaiChinh từ Database
		/// </summary>
		public List<view_BaoCaoTaiChinh> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_BaoCaoTaiChinh]");
				List<view_BaoCaoTaiChinh> items = new List<view_BaoCaoTaiChinh>();
				view_BaoCaoTaiChinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_BaoCaoTaiChinh();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["CapDoDaiLy"] != null && dr["CapDoDaiLy"] != DBNull.Value)
					{
						item.CapDoDaiLy = Convert.ToString(dr["CapDoDaiLy"]);
					}
					if (dr["TrucThuocDaiLy"] != null && dr["TrucThuocDaiLy"] != DBNull.Value)
					{
						item.TrucThuocDaiLy = Convert.ToString(dr["TrucThuocDaiLy"]);
					}
					if (dr["ThoiGianDatHang"] != null && dr["ThoiGianDatHang"] != DBNull.Value)
					{
						item.ThoiGianDatHang = Convert.ToDateTime(dr["ThoiGianDatHang"]);
					}
					if (dr["ThoiGianKetToan"] != null && dr["ThoiGianKetToan"] != DBNull.Value)
					{
						item.ThoiGianKetToan = Convert.ToDateTime(dr["ThoiGianKetToan"]);
					}
					if (dr["KeyThoiGianKetToan"] != null && dr["KeyThoiGianKetToan"] != DBNull.Value)
					{
						item.KeyThoiGianKetToan = Convert.ToString(dr["KeyThoiGianKetToan"]);
					}
					if (dr["MaDaiLy"] != null && dr["MaDaiLy"] != DBNull.Value)
					{
						item.MaDaiLy = Convert.ToString(dr["MaDaiLy"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["MaChiPhi"] != null && dr["MaChiPhi"] != DBNull.Value)
					{
						item.MaChiPhi = Convert.ToString(dr["MaChiPhi"]);
					}
					if (dr["TenChiPhi"] != null && dr["TenChiPhi"] != DBNull.Value)
					{
						item.TenChiPhi = Convert.ToString(dr["TenChiPhi"]);
					}
					if (dr["LoaiThu"] != null && dr["LoaiThu"] != DBNull.Value)
					{
						item.LoaiThu = Convert.ToString(dr["LoaiThu"]);
					}
					if (dr["SoDuTruoc"] != null && dr["SoDuTruoc"] != DBNull.Value)
					{
						item.SoDuTruoc = Convert.ToDecimal(dr["SoDuTruoc"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToDecimal(dr["SoTien"]);
					}
					if (dr["SoDuSau"] != null && dr["SoDuSau"] != DBNull.Value)
					{
						item.SoDuSau = Convert.ToDecimal(dr["SoDuSau"]);
					}
					if (dr["LoaiTaiKhoan"] != null && dr["LoaiTaiKhoan"] != DBNull.Value)
					{
						item.LoaiTaiKhoan = Convert.ToString(dr["LoaiTaiKhoan"]);
					}
					if (dr["TrongLuongThanhToan"] != null && dr["TrongLuongThanhToan"] != DBNull.Value)
					{
						item.TrongLuongThanhToan = Convert.ToDecimal(dr["TrongLuongThanhToan"]);
					}
					if (dr["SyncDate"] != null && dr["SyncDate"] != DBNull.Value)
					{
						item.SyncDate = Convert.ToDateTime(dr["SyncDate"]);
					}
					if (dr["PAY_TYPE"] != null && dr["PAY_TYPE"] != DBNull.Value)
					{
						item.PAY_TYPE = Convert.ToString(dr["PAY_TYPE"]);
					}
					if (dr["GOODS_PAYMENT"] != null && dr["GOODS_PAYMENT"] != DBNull.Value)
					{
						item.GOODS_PAYMENT = Convert.ToDecimal(dr["GOODS_PAYMENT"]);
					}
					if (dr["FREIGHT"] != null && dr["FREIGHT"] != DBNull.Value)
					{
						item.FREIGHT = Convert.ToDecimal(dr["FREIGHT"]);
					}
					if (dr["ContractCustomer"] != null && dr["ContractCustomer"] != DBNull.Value)
					{
						item.ContractCustomer = Convert.ToBoolean(dr["ContractCustomer"]);
					}
					if (dr["SUM_CHIPHI"] != null && dr["SUM_CHIPHI"] != DBNull.Value)
					{
						item.SUM_CHIPHI = Convert.ToDecimal(dr["SUM_CHIPHI"]);
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
		/// Lấy danh sách view_BaoCaoTaiChinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_BaoCaoTaiChinh> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_BaoCaoTaiChinh] A "+ condition,  parameters);
				List<view_BaoCaoTaiChinh> items = new List<view_BaoCaoTaiChinh>();
				view_BaoCaoTaiChinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_BaoCaoTaiChinh();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["CapDoDaiLy"] != null && dr["CapDoDaiLy"] != DBNull.Value)
					{
						item.CapDoDaiLy = Convert.ToString(dr["CapDoDaiLy"]);
					}
					if (dr["TrucThuocDaiLy"] != null && dr["TrucThuocDaiLy"] != DBNull.Value)
					{
						item.TrucThuocDaiLy = Convert.ToString(dr["TrucThuocDaiLy"]);
					}
					if (dr["ThoiGianDatHang"] != null && dr["ThoiGianDatHang"] != DBNull.Value)
					{
						item.ThoiGianDatHang = Convert.ToDateTime(dr["ThoiGianDatHang"]);
					}
					if (dr["ThoiGianKetToan"] != null && dr["ThoiGianKetToan"] != DBNull.Value)
					{
						item.ThoiGianKetToan = Convert.ToDateTime(dr["ThoiGianKetToan"]);
					}
					if (dr["KeyThoiGianKetToan"] != null && dr["KeyThoiGianKetToan"] != DBNull.Value)
					{
						item.KeyThoiGianKetToan = Convert.ToString(dr["KeyThoiGianKetToan"]);
					}
					if (dr["MaDaiLy"] != null && dr["MaDaiLy"] != DBNull.Value)
					{
						item.MaDaiLy = Convert.ToString(dr["MaDaiLy"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["MaChiPhi"] != null && dr["MaChiPhi"] != DBNull.Value)
					{
						item.MaChiPhi = Convert.ToString(dr["MaChiPhi"]);
					}
					if (dr["TenChiPhi"] != null && dr["TenChiPhi"] != DBNull.Value)
					{
						item.TenChiPhi = Convert.ToString(dr["TenChiPhi"]);
					}
					if (dr["LoaiThu"] != null && dr["LoaiThu"] != DBNull.Value)
					{
						item.LoaiThu = Convert.ToString(dr["LoaiThu"]);
					}
					if (dr["SoDuTruoc"] != null && dr["SoDuTruoc"] != DBNull.Value)
					{
						item.SoDuTruoc = Convert.ToDecimal(dr["SoDuTruoc"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToDecimal(dr["SoTien"]);
					}
					if (dr["SoDuSau"] != null && dr["SoDuSau"] != DBNull.Value)
					{
						item.SoDuSau = Convert.ToDecimal(dr["SoDuSau"]);
					}
					if (dr["LoaiTaiKhoan"] != null && dr["LoaiTaiKhoan"] != DBNull.Value)
					{
						item.LoaiTaiKhoan = Convert.ToString(dr["LoaiTaiKhoan"]);
					}
					if (dr["TrongLuongThanhToan"] != null && dr["TrongLuongThanhToan"] != DBNull.Value)
					{
						item.TrongLuongThanhToan = Convert.ToDecimal(dr["TrongLuongThanhToan"]);
					}
					if (dr["SyncDate"] != null && dr["SyncDate"] != DBNull.Value)
					{
						item.SyncDate = Convert.ToDateTime(dr["SyncDate"]);
					}
					if (dr["PAY_TYPE"] != null && dr["PAY_TYPE"] != DBNull.Value)
					{
						item.PAY_TYPE = Convert.ToString(dr["PAY_TYPE"]);
					}
					if (dr["GOODS_PAYMENT"] != null && dr["GOODS_PAYMENT"] != DBNull.Value)
					{
						item.GOODS_PAYMENT = Convert.ToDecimal(dr["GOODS_PAYMENT"]);
					}
					if (dr["FREIGHT"] != null && dr["FREIGHT"] != DBNull.Value)
					{
						item.FREIGHT = Convert.ToDecimal(dr["FREIGHT"]);
					}
					if (dr["ContractCustomer"] != null && dr["ContractCustomer"] != DBNull.Value)
					{
						item.ContractCustomer = Convert.ToBoolean(dr["ContractCustomer"]);
					}
					if (dr["SUM_CHIPHI"] != null && dr["SUM_CHIPHI"] != DBNull.Value)
					{
						item.SUM_CHIPHI = Convert.ToDecimal(dr["SUM_CHIPHI"]);
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

		public List<view_BaoCaoTaiChinh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_BaoCaoTaiChinh] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_BaoCaoTaiChinh] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_BaoCaoTaiChinh>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_BaoCaoTaiChinh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_BaoCaoTaiChinh GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_BaoCaoTaiChinh] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_BaoCaoTaiChinh item=new view_BaoCaoTaiChinh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["CapDoDaiLy"] != null && dr["CapDoDaiLy"] != DBNull.Value)
						{
							item.CapDoDaiLy = Convert.ToString(dr["CapDoDaiLy"]);
						}
						if (dr["TrucThuocDaiLy"] != null && dr["TrucThuocDaiLy"] != DBNull.Value)
						{
							item.TrucThuocDaiLy = Convert.ToString(dr["TrucThuocDaiLy"]);
						}
						if (dr["ThoiGianDatHang"] != null && dr["ThoiGianDatHang"] != DBNull.Value)
						{
							item.ThoiGianDatHang = Convert.ToDateTime(dr["ThoiGianDatHang"]);
						}
						if (dr["ThoiGianKetToan"] != null && dr["ThoiGianKetToan"] != DBNull.Value)
						{
							item.ThoiGianKetToan = Convert.ToDateTime(dr["ThoiGianKetToan"]);
						}
						if (dr["KeyThoiGianKetToan"] != null && dr["KeyThoiGianKetToan"] != DBNull.Value)
						{
							item.KeyThoiGianKetToan = Convert.ToString(dr["KeyThoiGianKetToan"]);
						}
						if (dr["MaDaiLy"] != null && dr["MaDaiLy"] != DBNull.Value)
						{
							item.MaDaiLy = Convert.ToString(dr["MaDaiLy"]);
						}
						if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
						{
							item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
						}
						if (dr["MaChiPhi"] != null && dr["MaChiPhi"] != DBNull.Value)
						{
							item.MaChiPhi = Convert.ToString(dr["MaChiPhi"]);
						}
						if (dr["TenChiPhi"] != null && dr["TenChiPhi"] != DBNull.Value)
						{
							item.TenChiPhi = Convert.ToString(dr["TenChiPhi"]);
						}
						if (dr["LoaiThu"] != null && dr["LoaiThu"] != DBNull.Value)
						{
							item.LoaiThu = Convert.ToString(dr["LoaiThu"]);
						}
						if (dr["SoDuTruoc"] != null && dr["SoDuTruoc"] != DBNull.Value)
						{
							item.SoDuTruoc = Convert.ToDecimal(dr["SoDuTruoc"]);
						}
						if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
						{
							item.SoTien = Convert.ToDecimal(dr["SoTien"]);
						}
						if (dr["SoDuSau"] != null && dr["SoDuSau"] != DBNull.Value)
						{
							item.SoDuSau = Convert.ToDecimal(dr["SoDuSau"]);
						}
						if (dr["LoaiTaiKhoan"] != null && dr["LoaiTaiKhoan"] != DBNull.Value)
						{
							item.LoaiTaiKhoan = Convert.ToString(dr["LoaiTaiKhoan"]);
						}
						if (dr["TrongLuongThanhToan"] != null && dr["TrongLuongThanhToan"] != DBNull.Value)
						{
							item.TrongLuongThanhToan = Convert.ToDecimal(dr["TrongLuongThanhToan"]);
						}
						if (dr["SyncDate"] != null && dr["SyncDate"] != DBNull.Value)
						{
							item.SyncDate = Convert.ToDateTime(dr["SyncDate"]);
						}
						if (dr["PAY_TYPE"] != null && dr["PAY_TYPE"] != DBNull.Value)
						{
							item.PAY_TYPE = Convert.ToString(dr["PAY_TYPE"]);
						}
						if (dr["GOODS_PAYMENT"] != null && dr["GOODS_PAYMENT"] != DBNull.Value)
						{
							item.GOODS_PAYMENT = Convert.ToDecimal(dr["GOODS_PAYMENT"]);
						}
						if (dr["FREIGHT"] != null && dr["FREIGHT"] != DBNull.Value)
						{
							item.FREIGHT = Convert.ToDecimal(dr["FREIGHT"]);
						}
						if (dr["ContractCustomer"] != null && dr["ContractCustomer"] != DBNull.Value)
						{
							item.ContractCustomer = Convert.ToBoolean(dr["ContractCustomer"]);
						}
						if (dr["SUM_CHIPHI"] != null && dr["SUM_CHIPHI"] != DBNull.Value)
						{
							item.SUM_CHIPHI = Convert.ToDecimal(dr["SUM_CHIPHI"]);
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

		public view_BaoCaoTaiChinh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_BaoCaoTaiChinh] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_BaoCaoTaiChinh>(ds);
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
