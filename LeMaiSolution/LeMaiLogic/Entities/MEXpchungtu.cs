using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpchungtu:IEXpchungtu
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpchungtu(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpChungTu từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpChungTu]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpChungTu] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpChungTu từ Database
		/// </summary>
		public List<ExpChungTu> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpChungTu]");
				List<ExpChungTu> items = new List<ExpChungTu>();
				ExpChungTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpChungTu();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["NgayChungTu"] != null && dr["NgayChungTu"] != DBNull.Value)
					{
						item.NgayChungTu = Convert.ToDateTime(dr["NgayChungTu"]);
					}
					if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
					{
						item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
					}
					if (dr["NgayHoaDon"] != null && dr["NgayHoaDon"] != DBNull.Value)
					{
						item.NgayHoaDon = Convert.ToDateTime(dr["NgayHoaDon"]);
					}
					if (dr["SoTienThu"] != null && dr["SoTienThu"] != DBNull.Value)
					{
						item.SoTienThu = Convert.ToDecimal(dr["SoTienThu"]);
					}
					if (dr["SoTienChi"] != null && dr["SoTienChi"] != DBNull.Value)
					{
						item.SoTienChi = Convert.ToDecimal(dr["SoTienChi"]);
					}
					if (dr["LyDoChi"] != null && dr["LyDoChi"] != DBNull.Value)
					{
						item.LyDoChi = Convert.ToString(dr["LyDoChi"]);
					}
					if (dr["LyDoThu"] != null && dr["LyDoThu"] != DBNull.Value)
					{
						item.LyDoThu = Convert.ToString(dr["LyDoThu"]);
					}
					if (dr["SoChungTuThu"] != null && dr["SoChungTuThu"] != DBNull.Value)
					{
						item.SoChungTuThu = Convert.ToString(dr["SoChungTuThu"]);
					}
					if (dr["SoChungTuChi"] != null && dr["SoChungTuChi"] != DBNull.Value)
					{
						item.SoChungTuChi = Convert.ToString(dr["SoChungTuChi"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["ThangKT"] != null && dr["ThangKT"] != DBNull.Value)
					{
						item.ThangKT = Convert.ToDateTime(dr["ThangKT"]);
					}
					if (dr["FK_KyKetToan"] != null && dr["FK_KyKetToan"] != DBNull.Value)
					{
						item.FK_KyKetToan = Convert.ToString(dr["FK_KyKetToan"]);
					}
					if (dr["NguoiMuaHang"] != null && dr["NguoiMuaHang"] != DBNull.Value)
					{
						item.NguoiMuaHang = Convert.ToString(dr["NguoiMuaHang"]);
					}
					if (dr["DonViMuaHang"] != null && dr["DonViMuaHang"] != DBNull.Value)
					{
						item.DonViMuaHang = Convert.ToString(dr["DonViMuaHang"]);
					}
					if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
					{
						item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
					{
						item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
					}
					if (dr["TongThuHo"] != null && dr["TongThuHo"] != DBNull.Value)
					{
						item.TongThuHo = Convert.ToDecimal(dr["TongThuHo"]);
					}
					if (dr["TongPhiNhanTra"] != null && dr["TongPhiNhanTra"] != DBNull.Value)
					{
						item.TongPhiNhanTra = Convert.ToDecimal(dr["TongPhiNhanTra"]);
					}
					if (dr["TongPhiGuiTra"] != null && dr["TongPhiGuiTra"] != DBNull.Value)
					{
						item.TongPhiGuiTra = Convert.ToDecimal(dr["TongPhiGuiTra"]);
					}
					if (dr["TongPhiChuaVAT"] != null && dr["TongPhiChuaVAT"] != DBNull.Value)
					{
						item.TongPhiChuaVAT = Convert.ToDecimal(dr["TongPhiChuaVAT"]);
					}
					if (dr["ThueVAT"] != null && dr["ThueVAT"] != DBNull.Value)
					{
						item.ThueVAT = Convert.ToDecimal(dr["ThueVAT"]);
					}
					if (dr["TongPhiVanChuyen"] != null && dr["TongPhiVanChuyen"] != DBNull.Value)
					{
						item.TongPhiVanChuyen = Convert.ToDecimal(dr["TongPhiVanChuyen"]);
					}
					if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
					{
						item.SoChungTu = Convert.ToInt32(dr["SoChungTu"]);
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
		/// Lấy danh sách ExpChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpChungTu> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpChungTu] A "+ condition,  parameters);
				List<ExpChungTu> items = new List<ExpChungTu>();
				ExpChungTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpChungTu();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["NgayChungTu"] != null && dr["NgayChungTu"] != DBNull.Value)
					{
						item.NgayChungTu = Convert.ToDateTime(dr["NgayChungTu"]);
					}
					if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
					{
						item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
					}
					if (dr["NgayHoaDon"] != null && dr["NgayHoaDon"] != DBNull.Value)
					{
						item.NgayHoaDon = Convert.ToDateTime(dr["NgayHoaDon"]);
					}
					if (dr["SoTienThu"] != null && dr["SoTienThu"] != DBNull.Value)
					{
						item.SoTienThu = Convert.ToDecimal(dr["SoTienThu"]);
					}
					if (dr["SoTienChi"] != null && dr["SoTienChi"] != DBNull.Value)
					{
						item.SoTienChi = Convert.ToDecimal(dr["SoTienChi"]);
					}
					if (dr["LyDoChi"] != null && dr["LyDoChi"] != DBNull.Value)
					{
						item.LyDoChi = Convert.ToString(dr["LyDoChi"]);
					}
					if (dr["LyDoThu"] != null && dr["LyDoThu"] != DBNull.Value)
					{
						item.LyDoThu = Convert.ToString(dr["LyDoThu"]);
					}
					if (dr["SoChungTuThu"] != null && dr["SoChungTuThu"] != DBNull.Value)
					{
						item.SoChungTuThu = Convert.ToString(dr["SoChungTuThu"]);
					}
					if (dr["SoChungTuChi"] != null && dr["SoChungTuChi"] != DBNull.Value)
					{
						item.SoChungTuChi = Convert.ToString(dr["SoChungTuChi"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["ThangKT"] != null && dr["ThangKT"] != DBNull.Value)
					{
						item.ThangKT = Convert.ToDateTime(dr["ThangKT"]);
					}
					if (dr["FK_KyKetToan"] != null && dr["FK_KyKetToan"] != DBNull.Value)
					{
						item.FK_KyKetToan = Convert.ToString(dr["FK_KyKetToan"]);
					}
					if (dr["NguoiMuaHang"] != null && dr["NguoiMuaHang"] != DBNull.Value)
					{
						item.NguoiMuaHang = Convert.ToString(dr["NguoiMuaHang"]);
					}
					if (dr["DonViMuaHang"] != null && dr["DonViMuaHang"] != DBNull.Value)
					{
						item.DonViMuaHang = Convert.ToString(dr["DonViMuaHang"]);
					}
					if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
					{
						item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
					{
						item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
					}
					if (dr["TongThuHo"] != null && dr["TongThuHo"] != DBNull.Value)
					{
						item.TongThuHo = Convert.ToDecimal(dr["TongThuHo"]);
					}
					if (dr["TongPhiNhanTra"] != null && dr["TongPhiNhanTra"] != DBNull.Value)
					{
						item.TongPhiNhanTra = Convert.ToDecimal(dr["TongPhiNhanTra"]);
					}
					if (dr["TongPhiGuiTra"] != null && dr["TongPhiGuiTra"] != DBNull.Value)
					{
						item.TongPhiGuiTra = Convert.ToDecimal(dr["TongPhiGuiTra"]);
					}
					if (dr["TongPhiChuaVAT"] != null && dr["TongPhiChuaVAT"] != DBNull.Value)
					{
						item.TongPhiChuaVAT = Convert.ToDecimal(dr["TongPhiChuaVAT"]);
					}
					if (dr["ThueVAT"] != null && dr["ThueVAT"] != DBNull.Value)
					{
						item.ThueVAT = Convert.ToDecimal(dr["ThueVAT"]);
					}
					if (dr["TongPhiVanChuyen"] != null && dr["TongPhiVanChuyen"] != DBNull.Value)
					{
						item.TongPhiVanChuyen = Convert.ToDecimal(dr["TongPhiVanChuyen"]);
					}
					if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
					{
						item.SoChungTu = Convert.ToInt32(dr["SoChungTu"]);
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

		public List<ExpChungTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpChungTu] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpChungTu] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpChungTu>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpChungTu từ Database
		/// </summary>
		public ExpChungTu GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpChungTu] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpChungTu item=new ExpChungTu();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["NgayChungTu"] != null && dr["NgayChungTu"] != DBNull.Value)
						{
							item.NgayChungTu = Convert.ToDateTime(dr["NgayChungTu"]);
						}
						if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
						{
							item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
						}
						if (dr["NgayHoaDon"] != null && dr["NgayHoaDon"] != DBNull.Value)
						{
							item.NgayHoaDon = Convert.ToDateTime(dr["NgayHoaDon"]);
						}
						if (dr["SoTienThu"] != null && dr["SoTienThu"] != DBNull.Value)
						{
							item.SoTienThu = Convert.ToDecimal(dr["SoTienThu"]);
						}
						if (dr["SoTienChi"] != null && dr["SoTienChi"] != DBNull.Value)
						{
							item.SoTienChi = Convert.ToDecimal(dr["SoTienChi"]);
						}
						if (dr["LyDoChi"] != null && dr["LyDoChi"] != DBNull.Value)
						{
							item.LyDoChi = Convert.ToString(dr["LyDoChi"]);
						}
						if (dr["LyDoThu"] != null && dr["LyDoThu"] != DBNull.Value)
						{
							item.LyDoThu = Convert.ToString(dr["LyDoThu"]);
						}
						if (dr["SoChungTuThu"] != null && dr["SoChungTuThu"] != DBNull.Value)
						{
							item.SoChungTuThu = Convert.ToString(dr["SoChungTuThu"]);
						}
						if (dr["SoChungTuChi"] != null && dr["SoChungTuChi"] != DBNull.Value)
						{
							item.SoChungTuChi = Convert.ToString(dr["SoChungTuChi"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["ThangKT"] != null && dr["ThangKT"] != DBNull.Value)
						{
							item.ThangKT = Convert.ToDateTime(dr["ThangKT"]);
						}
						if (dr["FK_KyKetToan"] != null && dr["FK_KyKetToan"] != DBNull.Value)
						{
							item.FK_KyKetToan = Convert.ToString(dr["FK_KyKetToan"]);
						}
						if (dr["NguoiMuaHang"] != null && dr["NguoiMuaHang"] != DBNull.Value)
						{
							item.NguoiMuaHang = Convert.ToString(dr["NguoiMuaHang"]);
						}
						if (dr["DonViMuaHang"] != null && dr["DonViMuaHang"] != DBNull.Value)
						{
							item.DonViMuaHang = Convert.ToString(dr["DonViMuaHang"]);
						}
						if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
						{
							item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
						{
							item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
						}
						if (dr["TongThuHo"] != null && dr["TongThuHo"] != DBNull.Value)
						{
							item.TongThuHo = Convert.ToDecimal(dr["TongThuHo"]);
						}
						if (dr["TongPhiNhanTra"] != null && dr["TongPhiNhanTra"] != DBNull.Value)
						{
							item.TongPhiNhanTra = Convert.ToDecimal(dr["TongPhiNhanTra"]);
						}
						if (dr["TongPhiGuiTra"] != null && dr["TongPhiGuiTra"] != DBNull.Value)
						{
							item.TongPhiGuiTra = Convert.ToDecimal(dr["TongPhiGuiTra"]);
						}
						if (dr["TongPhiChuaVAT"] != null && dr["TongPhiChuaVAT"] != DBNull.Value)
						{
							item.TongPhiChuaVAT = Convert.ToDecimal(dr["TongPhiChuaVAT"]);
						}
						if (dr["ThueVAT"] != null && dr["ThueVAT"] != DBNull.Value)
						{
							item.ThueVAT = Convert.ToDecimal(dr["ThueVAT"]);
						}
						if (dr["TongPhiVanChuyen"] != null && dr["TongPhiVanChuyen"] != DBNull.Value)
						{
							item.TongPhiVanChuyen = Convert.ToDecimal(dr["TongPhiVanChuyen"]);
						}
						if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
						{
							item.SoChungTu = Convert.ToInt32(dr["SoChungTu"]);
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

		/// <summary>
		/// Lấy một ExpChungTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpChungTu GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpChungTu] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpChungTu item=new ExpChungTu();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["NgayChungTu"] != null && dr["NgayChungTu"] != DBNull.Value)
						{
							item.NgayChungTu = Convert.ToDateTime(dr["NgayChungTu"]);
						}
						if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
						{
							item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
						}
						if (dr["NgayHoaDon"] != null && dr["NgayHoaDon"] != DBNull.Value)
						{
							item.NgayHoaDon = Convert.ToDateTime(dr["NgayHoaDon"]);
						}
						if (dr["SoTienThu"] != null && dr["SoTienThu"] != DBNull.Value)
						{
							item.SoTienThu = Convert.ToDecimal(dr["SoTienThu"]);
						}
						if (dr["SoTienChi"] != null && dr["SoTienChi"] != DBNull.Value)
						{
							item.SoTienChi = Convert.ToDecimal(dr["SoTienChi"]);
						}
						if (dr["LyDoChi"] != null && dr["LyDoChi"] != DBNull.Value)
						{
							item.LyDoChi = Convert.ToString(dr["LyDoChi"]);
						}
						if (dr["LyDoThu"] != null && dr["LyDoThu"] != DBNull.Value)
						{
							item.LyDoThu = Convert.ToString(dr["LyDoThu"]);
						}
						if (dr["SoChungTuThu"] != null && dr["SoChungTuThu"] != DBNull.Value)
						{
							item.SoChungTuThu = Convert.ToString(dr["SoChungTuThu"]);
						}
						if (dr["SoChungTuChi"] != null && dr["SoChungTuChi"] != DBNull.Value)
						{
							item.SoChungTuChi = Convert.ToString(dr["SoChungTuChi"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["ThangKT"] != null && dr["ThangKT"] != DBNull.Value)
						{
							item.ThangKT = Convert.ToDateTime(dr["ThangKT"]);
						}
						if (dr["FK_KyKetToan"] != null && dr["FK_KyKetToan"] != DBNull.Value)
						{
							item.FK_KyKetToan = Convert.ToString(dr["FK_KyKetToan"]);
						}
						if (dr["NguoiMuaHang"] != null && dr["NguoiMuaHang"] != DBNull.Value)
						{
							item.NguoiMuaHang = Convert.ToString(dr["NguoiMuaHang"]);
						}
						if (dr["DonViMuaHang"] != null && dr["DonViMuaHang"] != DBNull.Value)
						{
							item.DonViMuaHang = Convert.ToString(dr["DonViMuaHang"]);
						}
						if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
						{
							item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
						{
							item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
						}
						if (dr["TongThuHo"] != null && dr["TongThuHo"] != DBNull.Value)
						{
							item.TongThuHo = Convert.ToDecimal(dr["TongThuHo"]);
						}
						if (dr["TongPhiNhanTra"] != null && dr["TongPhiNhanTra"] != DBNull.Value)
						{
							item.TongPhiNhanTra = Convert.ToDecimal(dr["TongPhiNhanTra"]);
						}
						if (dr["TongPhiGuiTra"] != null && dr["TongPhiGuiTra"] != DBNull.Value)
						{
							item.TongPhiGuiTra = Convert.ToDecimal(dr["TongPhiGuiTra"]);
						}
						if (dr["TongPhiChuaVAT"] != null && dr["TongPhiChuaVAT"] != DBNull.Value)
						{
							item.TongPhiChuaVAT = Convert.ToDecimal(dr["TongPhiChuaVAT"]);
						}
						if (dr["ThueVAT"] != null && dr["ThueVAT"] != DBNull.Value)
						{
							item.ThueVAT = Convert.ToDecimal(dr["ThueVAT"]);
						}
						if (dr["TongPhiVanChuyen"] != null && dr["TongPhiVanChuyen"] != DBNull.Value)
						{
							item.TongPhiVanChuyen = Convert.ToDecimal(dr["TongPhiVanChuyen"]);
						}
						if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
						{
							item.SoChungTu = Convert.ToInt32(dr["SoChungTu"]);
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

		public ExpChungTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpChungTu] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpChungTu>(ds);
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
		/// <summary>
		/// Thêm mới ExpChungTu vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpChungTu _ExpChungTu)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpChungTu](Id, FK_Customer, NgayChungTu, SoHoaDon, NgayHoaDon, SoTienThu, SoTienChi, LyDoChi, LyDoThu, SoChungTuThu, SoChungTuChi, FK_Account, ThangKT, FK_KyKetToan, NguoiMuaHang, DonViMuaHang, MaSoThue, DiaChi, IsPhatHanh, TongThuHo, TongPhiNhanTra, TongPhiGuiTra, TongPhiChuaVAT, ThueVAT, TongPhiVanChuyen, SoChungTu) VALUES(@Id, @FK_Customer, @NgayChungTu, @SoHoaDon, @NgayHoaDon, @SoTienThu, @SoTienChi, @LyDoChi, @LyDoThu, @SoChungTuThu, @SoChungTuChi, @FK_Account, @ThangKT, @FK_KyKetToan, @NguoiMuaHang, @DonViMuaHang, @MaSoThue, @DiaChi, @IsPhatHanh, @TongThuHo, @TongPhiNhanTra, @TongPhiGuiTra, @TongPhiChuaVAT, @ThueVAT, @TongPhiVanChuyen, @SoChungTu)", 
					"@Id",  _ExpChungTu.Id, 
					"@FK_Customer",  _ExpChungTu.FK_Customer, 
					"@NgayChungTu", this._dataContext.ConvertDateString( _ExpChungTu.NgayChungTu), 
					"@SoHoaDon",  _ExpChungTu.SoHoaDon, 
					"@NgayHoaDon", this._dataContext.ConvertDateString( _ExpChungTu.NgayHoaDon), 
					"@SoTienThu",  _ExpChungTu.SoTienThu, 
					"@SoTienChi",  _ExpChungTu.SoTienChi, 
					"@LyDoChi",  _ExpChungTu.LyDoChi, 
					"@LyDoThu",  _ExpChungTu.LyDoThu, 
					"@SoChungTuThu",  _ExpChungTu.SoChungTuThu, 
					"@SoChungTuChi",  _ExpChungTu.SoChungTuChi, 
					"@FK_Account",  _ExpChungTu.FK_Account, 
					"@ThangKT", this._dataContext.ConvertDateString( _ExpChungTu.ThangKT), 
					"@FK_KyKetToan",  _ExpChungTu.FK_KyKetToan, 
					"@NguoiMuaHang",  _ExpChungTu.NguoiMuaHang, 
					"@DonViMuaHang",  _ExpChungTu.DonViMuaHang, 
					"@MaSoThue",  _ExpChungTu.MaSoThue, 
					"@DiaChi",  _ExpChungTu.DiaChi, 
					"@IsPhatHanh",  _ExpChungTu.IsPhatHanh, 
					"@TongThuHo",  _ExpChungTu.TongThuHo, 
					"@TongPhiNhanTra",  _ExpChungTu.TongPhiNhanTra, 
					"@TongPhiGuiTra",  _ExpChungTu.TongPhiGuiTra, 
					"@TongPhiChuaVAT",  _ExpChungTu.TongPhiChuaVAT, 
					"@ThueVAT",  _ExpChungTu.ThueVAT, 
					"@TongPhiVanChuyen",  _ExpChungTu.TongPhiVanChuyen, 
					"@SoChungTu",  _ExpChungTu.SoChungTu);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpChungTu vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpChungTu> _ExpChungTus)
		{
			foreach (ExpChungTu item in _ExpChungTus)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpChungTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpChungTu _ExpChungTu, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpChungTu] SET Id=@Id, FK_Customer=@FK_Customer, NgayChungTu=@NgayChungTu, SoHoaDon=@SoHoaDon, NgayHoaDon=@NgayHoaDon, SoTienThu=@SoTienThu, SoTienChi=@SoTienChi, LyDoChi=@LyDoChi, LyDoThu=@LyDoThu, SoChungTuThu=@SoChungTuThu, SoChungTuChi=@SoChungTuChi, FK_Account=@FK_Account, ThangKT=@ThangKT, FK_KyKetToan=@FK_KyKetToan, NguoiMuaHang=@NguoiMuaHang, DonViMuaHang=@DonViMuaHang, MaSoThue=@MaSoThue, DiaChi=@DiaChi, IsPhatHanh=@IsPhatHanh, TongThuHo=@TongThuHo, TongPhiNhanTra=@TongPhiNhanTra, TongPhiGuiTra=@TongPhiGuiTra, TongPhiChuaVAT=@TongPhiChuaVAT, ThueVAT=@ThueVAT, TongPhiVanChuyen=@TongPhiVanChuyen, SoChungTu=@SoChungTu WHERE Id=@Id", 
					"@Id",  _ExpChungTu.Id, 
					"@FK_Customer",  _ExpChungTu.FK_Customer, 
					"@NgayChungTu", this._dataContext.ConvertDateString( _ExpChungTu.NgayChungTu), 
					"@SoHoaDon",  _ExpChungTu.SoHoaDon, 
					"@NgayHoaDon", this._dataContext.ConvertDateString( _ExpChungTu.NgayHoaDon), 
					"@SoTienThu",  _ExpChungTu.SoTienThu, 
					"@SoTienChi",  _ExpChungTu.SoTienChi, 
					"@LyDoChi",  _ExpChungTu.LyDoChi, 
					"@LyDoThu",  _ExpChungTu.LyDoThu, 
					"@SoChungTuThu",  _ExpChungTu.SoChungTuThu, 
					"@SoChungTuChi",  _ExpChungTu.SoChungTuChi, 
					"@FK_Account",  _ExpChungTu.FK_Account, 
					"@ThangKT", this._dataContext.ConvertDateString( _ExpChungTu.ThangKT), 
					"@FK_KyKetToan",  _ExpChungTu.FK_KyKetToan, 
					"@NguoiMuaHang",  _ExpChungTu.NguoiMuaHang, 
					"@DonViMuaHang",  _ExpChungTu.DonViMuaHang, 
					"@MaSoThue",  _ExpChungTu.MaSoThue, 
					"@DiaChi",  _ExpChungTu.DiaChi, 
					"@IsPhatHanh",  _ExpChungTu.IsPhatHanh, 
					"@TongThuHo",  _ExpChungTu.TongThuHo, 
					"@TongPhiNhanTra",  _ExpChungTu.TongPhiNhanTra, 
					"@TongPhiGuiTra",  _ExpChungTu.TongPhiGuiTra, 
					"@TongPhiChuaVAT",  _ExpChungTu.TongPhiChuaVAT, 
					"@ThueVAT",  _ExpChungTu.ThueVAT, 
					"@TongPhiVanChuyen",  _ExpChungTu.TongPhiVanChuyen, 
					"@SoChungTu",  _ExpChungTu.SoChungTu, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpChungTu vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpChungTu _ExpChungTu)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpChungTu] SET FK_Customer=@FK_Customer, NgayChungTu=@NgayChungTu, SoHoaDon=@SoHoaDon, NgayHoaDon=@NgayHoaDon, SoTienThu=@SoTienThu, SoTienChi=@SoTienChi, LyDoChi=@LyDoChi, LyDoThu=@LyDoThu, SoChungTuThu=@SoChungTuThu, SoChungTuChi=@SoChungTuChi, FK_Account=@FK_Account, ThangKT=@ThangKT, FK_KyKetToan=@FK_KyKetToan, NguoiMuaHang=@NguoiMuaHang, DonViMuaHang=@DonViMuaHang, MaSoThue=@MaSoThue, DiaChi=@DiaChi, IsPhatHanh=@IsPhatHanh, TongThuHo=@TongThuHo, TongPhiNhanTra=@TongPhiNhanTra, TongPhiGuiTra=@TongPhiGuiTra, TongPhiChuaVAT=@TongPhiChuaVAT, ThueVAT=@ThueVAT, TongPhiVanChuyen=@TongPhiVanChuyen, SoChungTu=@SoChungTu WHERE Id=@Id", 
					"@FK_Customer",  _ExpChungTu.FK_Customer, 
					"@NgayChungTu", this._dataContext.ConvertDateString( _ExpChungTu.NgayChungTu), 
					"@SoHoaDon",  _ExpChungTu.SoHoaDon, 
					"@NgayHoaDon", this._dataContext.ConvertDateString( _ExpChungTu.NgayHoaDon), 
					"@SoTienThu",  _ExpChungTu.SoTienThu, 
					"@SoTienChi",  _ExpChungTu.SoTienChi, 
					"@LyDoChi",  _ExpChungTu.LyDoChi, 
					"@LyDoThu",  _ExpChungTu.LyDoThu, 
					"@SoChungTuThu",  _ExpChungTu.SoChungTuThu, 
					"@SoChungTuChi",  _ExpChungTu.SoChungTuChi, 
					"@FK_Account",  _ExpChungTu.FK_Account, 
					"@ThangKT", this._dataContext.ConvertDateString( _ExpChungTu.ThangKT), 
					"@FK_KyKetToan",  _ExpChungTu.FK_KyKetToan, 
					"@NguoiMuaHang",  _ExpChungTu.NguoiMuaHang, 
					"@DonViMuaHang",  _ExpChungTu.DonViMuaHang, 
					"@MaSoThue",  _ExpChungTu.MaSoThue, 
					"@DiaChi",  _ExpChungTu.DiaChi, 
					"@IsPhatHanh",  _ExpChungTu.IsPhatHanh, 
					"@TongThuHo",  _ExpChungTu.TongThuHo, 
					"@TongPhiNhanTra",  _ExpChungTu.TongPhiNhanTra, 
					"@TongPhiGuiTra",  _ExpChungTu.TongPhiGuiTra, 
					"@TongPhiChuaVAT",  _ExpChungTu.TongPhiChuaVAT, 
					"@ThueVAT",  _ExpChungTu.ThueVAT, 
					"@TongPhiVanChuyen",  _ExpChungTu.TongPhiVanChuyen, 
					"@SoChungTu",  _ExpChungTu.SoChungTu, 
					"@Id", _ExpChungTu.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpChungTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpChungTu> _ExpChungTus)
		{
			foreach (ExpChungTu item in _ExpChungTus)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpChungTu vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpChungTu _ExpChungTu, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpChungTu] SET Id=@Id, FK_Customer=@FK_Customer, NgayChungTu=@NgayChungTu, SoHoaDon=@SoHoaDon, NgayHoaDon=@NgayHoaDon, SoTienThu=@SoTienThu, SoTienChi=@SoTienChi, LyDoChi=@LyDoChi, LyDoThu=@LyDoThu, SoChungTuThu=@SoChungTuThu, SoChungTuChi=@SoChungTuChi, FK_Account=@FK_Account, ThangKT=@ThangKT, FK_KyKetToan=@FK_KyKetToan, NguoiMuaHang=@NguoiMuaHang, DonViMuaHang=@DonViMuaHang, MaSoThue=@MaSoThue, DiaChi=@DiaChi, IsPhatHanh=@IsPhatHanh, TongThuHo=@TongThuHo, TongPhiNhanTra=@TongPhiNhanTra, TongPhiGuiTra=@TongPhiGuiTra, TongPhiChuaVAT=@TongPhiChuaVAT, ThueVAT=@ThueVAT, TongPhiVanChuyen=@TongPhiVanChuyen, SoChungTu=@SoChungTu "+ condition, 
					"@Id",  _ExpChungTu.Id, 
					"@FK_Customer",  _ExpChungTu.FK_Customer, 
					"@NgayChungTu", this._dataContext.ConvertDateString( _ExpChungTu.NgayChungTu), 
					"@SoHoaDon",  _ExpChungTu.SoHoaDon, 
					"@NgayHoaDon", this._dataContext.ConvertDateString( _ExpChungTu.NgayHoaDon), 
					"@SoTienThu",  _ExpChungTu.SoTienThu, 
					"@SoTienChi",  _ExpChungTu.SoTienChi, 
					"@LyDoChi",  _ExpChungTu.LyDoChi, 
					"@LyDoThu",  _ExpChungTu.LyDoThu, 
					"@SoChungTuThu",  _ExpChungTu.SoChungTuThu, 
					"@SoChungTuChi",  _ExpChungTu.SoChungTuChi, 
					"@FK_Account",  _ExpChungTu.FK_Account, 
					"@ThangKT", this._dataContext.ConvertDateString( _ExpChungTu.ThangKT), 
					"@FK_KyKetToan",  _ExpChungTu.FK_KyKetToan, 
					"@NguoiMuaHang",  _ExpChungTu.NguoiMuaHang, 
					"@DonViMuaHang",  _ExpChungTu.DonViMuaHang, 
					"@MaSoThue",  _ExpChungTu.MaSoThue, 
					"@DiaChi",  _ExpChungTu.DiaChi, 
					"@IsPhatHanh",  _ExpChungTu.IsPhatHanh, 
					"@TongThuHo",  _ExpChungTu.TongThuHo, 
					"@TongPhiNhanTra",  _ExpChungTu.TongPhiNhanTra, 
					"@TongPhiGuiTra",  _ExpChungTu.TongPhiGuiTra, 
					"@TongPhiChuaVAT",  _ExpChungTu.TongPhiChuaVAT, 
					"@ThueVAT",  _ExpChungTu.ThueVAT, 
					"@TongPhiVanChuyen",  _ExpChungTu.TongPhiVanChuyen, 
					"@SoChungTu",  _ExpChungTu.SoChungTu);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpChungTu trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpChungTu] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpChungTu trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpChungTu _ExpChungTu)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpChungTu] WHERE Id=@Id",
					"@Id", _ExpChungTu.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpChungTu trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpChungTu] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpChungTu trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpChungTu> _ExpChungTus)
		{
			foreach (ExpChungTu item in _ExpChungTus)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
