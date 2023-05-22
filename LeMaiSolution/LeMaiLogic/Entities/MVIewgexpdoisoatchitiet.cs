using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpdoisoatchitiet:IVIewgexpdoisoatchitiet
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpdoisoatchitiet(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpDoiSoatChiTiet từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpDoiSoatChiTiet]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpDoiSoatChiTiet] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpDoiSoatChiTiet từ Database
		/// </summary>
		public List<view_GExpDoiSoatChiTiet> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpDoiSoatChiTiet]");
				List<view_GExpDoiSoatChiTiet> items = new List<view_GExpDoiSoatChiTiet>();
				view_GExpDoiSoatChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpDoiSoatChiTiet();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
					{
						item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["SoLuongDon"] != null && dr["SoLuongDon"] != DBNull.Value)
					{
						item.SoLuongDon = Convert.ToInt32(dr["SoLuongDon"]);
					}
					if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
					{
						item.ThuHo = Convert.ToDecimal(dr["ThuHo"]);
					}
					if (dr["ThuHoKT"] != null && dr["ThuHoKT"] != DBNull.Value)
					{
						item.ThuHoKT = Convert.ToDecimal(dr["ThuHoKT"]);
					}
					if (dr["SaiLech"] != null && dr["SaiLech"] != DBNull.Value)
					{
						item.SaiLech = Convert.ToDecimal(dr["SaiLech"]);
					}
					if (dr["CuocGuiTra"] != null && dr["CuocGuiTra"] != DBNull.Value)
					{
						item.CuocGuiTra = Convert.ToDecimal(dr["CuocGuiTra"]);
					}
					if (dr["CuocNhanTra"] != null && dr["CuocNhanTra"] != DBNull.Value)
					{
						item.CuocNhanTra = Convert.ToDecimal(dr["CuocNhanTra"]);
					}
					if (dr["ChiPhi"] != null && dr["ChiPhi"] != DBNull.Value)
					{
						item.ChiPhi = Convert.ToDecimal(dr["ChiPhi"]);
					}
					if (dr["LoiNhuan"] != null && dr["LoiNhuan"] != DBNull.Value)
					{
						item.LoiNhuan = Convert.ToDecimal(dr["LoiNhuan"]);
					}
					if (dr["ThanhToanKH"] != null && dr["ThanhToanKH"] != DBNull.Value)
					{
						item.ThanhToanKH = Convert.ToDecimal(dr["ThanhToanKH"]);
					}
					if (dr["DaThanhToanKH"] != null && dr["DaThanhToanKH"] != DBNull.Value)
					{
						item.DaThanhToanKH = Convert.ToDecimal(dr["DaThanhToanKH"]);
					}
					if (dr["PhuongThucThanhToan"] != null && dr["PhuongThucThanhToan"] != DBNull.Value)
					{
						item.PhuongThucThanhToan = Convert.ToString(dr["PhuongThucThanhToan"]);
					}
					if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
					{
						item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
					}
					if (dr["IsHoanThanh"] != null && dr["IsHoanThanh"] != DBNull.Value)
					{
						item.IsHoanThanh = Convert.ToBoolean(dr["IsHoanThanh"]);
					}
					if (dr["NgayDoiSoat"] != null && dr["NgayDoiSoat"] != DBNull.Value)
					{
						item.NgayDoiSoat = Convert.ToDateTime(dr["NgayDoiSoat"]);
					}
					if (dr["AccountCode"] != null && dr["AccountCode"] != DBNull.Value)
					{
						item.AccountCode = Convert.ToString(dr["AccountCode"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["AccountName"] != null && dr["AccountName"] != DBNull.Value)
					{
						item.AccountName = Convert.ToString(dr["AccountName"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["BankId"] != null && dr["BankId"] != DBNull.Value)
					{
						item.BankId = Convert.ToInt32(dr["BankId"]);
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
		/// Lấy danh sách view_GExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpDoiSoatChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpDoiSoatChiTiet] A "+ condition,  parameters);
				List<view_GExpDoiSoatChiTiet> items = new List<view_GExpDoiSoatChiTiet>();
				view_GExpDoiSoatChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpDoiSoatChiTiet();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
					{
						item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["SoLuongDon"] != null && dr["SoLuongDon"] != DBNull.Value)
					{
						item.SoLuongDon = Convert.ToInt32(dr["SoLuongDon"]);
					}
					if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
					{
						item.ThuHo = Convert.ToDecimal(dr["ThuHo"]);
					}
					if (dr["ThuHoKT"] != null && dr["ThuHoKT"] != DBNull.Value)
					{
						item.ThuHoKT = Convert.ToDecimal(dr["ThuHoKT"]);
					}
					if (dr["SaiLech"] != null && dr["SaiLech"] != DBNull.Value)
					{
						item.SaiLech = Convert.ToDecimal(dr["SaiLech"]);
					}
					if (dr["CuocGuiTra"] != null && dr["CuocGuiTra"] != DBNull.Value)
					{
						item.CuocGuiTra = Convert.ToDecimal(dr["CuocGuiTra"]);
					}
					if (dr["CuocNhanTra"] != null && dr["CuocNhanTra"] != DBNull.Value)
					{
						item.CuocNhanTra = Convert.ToDecimal(dr["CuocNhanTra"]);
					}
					if (dr["ChiPhi"] != null && dr["ChiPhi"] != DBNull.Value)
					{
						item.ChiPhi = Convert.ToDecimal(dr["ChiPhi"]);
					}
					if (dr["LoiNhuan"] != null && dr["LoiNhuan"] != DBNull.Value)
					{
						item.LoiNhuan = Convert.ToDecimal(dr["LoiNhuan"]);
					}
					if (dr["ThanhToanKH"] != null && dr["ThanhToanKH"] != DBNull.Value)
					{
						item.ThanhToanKH = Convert.ToDecimal(dr["ThanhToanKH"]);
					}
					if (dr["DaThanhToanKH"] != null && dr["DaThanhToanKH"] != DBNull.Value)
					{
						item.DaThanhToanKH = Convert.ToDecimal(dr["DaThanhToanKH"]);
					}
					if (dr["PhuongThucThanhToan"] != null && dr["PhuongThucThanhToan"] != DBNull.Value)
					{
						item.PhuongThucThanhToan = Convert.ToString(dr["PhuongThucThanhToan"]);
					}
					if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
					{
						item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
					}
					if (dr["IsHoanThanh"] != null && dr["IsHoanThanh"] != DBNull.Value)
					{
						item.IsHoanThanh = Convert.ToBoolean(dr["IsHoanThanh"]);
					}
					if (dr["NgayDoiSoat"] != null && dr["NgayDoiSoat"] != DBNull.Value)
					{
						item.NgayDoiSoat = Convert.ToDateTime(dr["NgayDoiSoat"]);
					}
					if (dr["AccountCode"] != null && dr["AccountCode"] != DBNull.Value)
					{
						item.AccountCode = Convert.ToString(dr["AccountCode"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["AccountName"] != null && dr["AccountName"] != DBNull.Value)
					{
						item.AccountName = Convert.ToString(dr["AccountName"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["BankId"] != null && dr["BankId"] != DBNull.Value)
					{
						item.BankId = Convert.ToInt32(dr["BankId"]);
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

		public List<view_GExpDoiSoatChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpDoiSoatChiTiet] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpDoiSoatChiTiet] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpDoiSoatChiTiet>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpDoiSoatChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpDoiSoatChiTiet GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpDoiSoatChiTiet] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpDoiSoatChiTiet item=new view_GExpDoiSoatChiTiet();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
						{
							item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
						}
						if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
						{
							item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["SoLuongDon"] != null && dr["SoLuongDon"] != DBNull.Value)
						{
							item.SoLuongDon = Convert.ToInt32(dr["SoLuongDon"]);
						}
						if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
						{
							item.ThuHo = Convert.ToDecimal(dr["ThuHo"]);
						}
						if (dr["ThuHoKT"] != null && dr["ThuHoKT"] != DBNull.Value)
						{
							item.ThuHoKT = Convert.ToDecimal(dr["ThuHoKT"]);
						}
						if (dr["SaiLech"] != null && dr["SaiLech"] != DBNull.Value)
						{
							item.SaiLech = Convert.ToDecimal(dr["SaiLech"]);
						}
						if (dr["CuocGuiTra"] != null && dr["CuocGuiTra"] != DBNull.Value)
						{
							item.CuocGuiTra = Convert.ToDecimal(dr["CuocGuiTra"]);
						}
						if (dr["CuocNhanTra"] != null && dr["CuocNhanTra"] != DBNull.Value)
						{
							item.CuocNhanTra = Convert.ToDecimal(dr["CuocNhanTra"]);
						}
						if (dr["ChiPhi"] != null && dr["ChiPhi"] != DBNull.Value)
						{
							item.ChiPhi = Convert.ToDecimal(dr["ChiPhi"]);
						}
						if (dr["LoiNhuan"] != null && dr["LoiNhuan"] != DBNull.Value)
						{
							item.LoiNhuan = Convert.ToDecimal(dr["LoiNhuan"]);
						}
						if (dr["ThanhToanKH"] != null && dr["ThanhToanKH"] != DBNull.Value)
						{
							item.ThanhToanKH = Convert.ToDecimal(dr["ThanhToanKH"]);
						}
						if (dr["DaThanhToanKH"] != null && dr["DaThanhToanKH"] != DBNull.Value)
						{
							item.DaThanhToanKH = Convert.ToDecimal(dr["DaThanhToanKH"]);
						}
						if (dr["PhuongThucThanhToan"] != null && dr["PhuongThucThanhToan"] != DBNull.Value)
						{
							item.PhuongThucThanhToan = Convert.ToString(dr["PhuongThucThanhToan"]);
						}
						if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
						{
							item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
						}
						if (dr["IsHoanThanh"] != null && dr["IsHoanThanh"] != DBNull.Value)
						{
							item.IsHoanThanh = Convert.ToBoolean(dr["IsHoanThanh"]);
						}
						if (dr["NgayDoiSoat"] != null && dr["NgayDoiSoat"] != DBNull.Value)
						{
							item.NgayDoiSoat = Convert.ToDateTime(dr["NgayDoiSoat"]);
						}
						if (dr["AccountCode"] != null && dr["AccountCode"] != DBNull.Value)
						{
							item.AccountCode = Convert.ToString(dr["AccountCode"]);
						}
						if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
						{
							item.BankName = Convert.ToString(dr["BankName"]);
						}
						if (dr["AccountName"] != null && dr["AccountName"] != DBNull.Value)
						{
							item.AccountName = Convert.ToString(dr["AccountName"]);
						}
						if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
						{
							item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
						}
						if (dr["BankId"] != null && dr["BankId"] != DBNull.Value)
						{
							item.BankId = Convert.ToInt32(dr["BankId"]);
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

		public view_GExpDoiSoatChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpDoiSoatChiTiet] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpDoiSoatChiTiet>(ds);
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
