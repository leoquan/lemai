using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVPtempr:IVPtempr
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVPtempr(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VPTempR từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VPTempR]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VPTempR từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VPTempR] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VPTempR từ Database
		/// </summary>
		public List<VPTempR> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VPTempR]");
				List<VPTempR> items = new List<VPTempR>();
				VPTempR item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VPTempR();
					if (dr["ID"] != null && dr["ID"] != DBNull.Value)
					{
						item.ID = Convert.ToString(dr["ID"]);
					}
					if (dr["GroupId"] != null && dr["GroupId"] != DBNull.Value)
					{
						item.GroupId = Convert.ToString(dr["GroupId"]);
					}
					if (dr["STTTN"] != null && dr["STTTN"] != DBNull.Value)
					{
						item.STTTN = Convert.ToString(dr["STTTN"]);
					}
					if (dr["STTTT"] != null && dr["STTTT"] != DBNull.Value)
					{
						item.STTTT = Convert.ToString(dr["STTTT"]);
					}
					if (dr["MaThuoc"] != null && dr["MaThuoc"] != DBNull.Value)
					{
						item.MaThuoc = Convert.ToString(dr["MaThuoc"]);
					}
					if (dr["HoatChat"] != null && dr["HoatChat"] != DBNull.Value)
					{
						item.HoatChat = Convert.ToString(dr["HoatChat"]);
					}
					if (dr["BietDuoc"] != null && dr["BietDuoc"] != DBNull.Value)
					{
						item.BietDuoc = Convert.ToString(dr["BietDuoc"]);
					}
					if (dr["NongDo"] != null && dr["NongDo"] != DBNull.Value)
					{
						item.NongDo = Convert.ToString(dr["NongDo"]);
					}
					if (dr["BaoChe"] != null && dr["BaoChe"] != DBNull.Value)
					{
						item.BaoChe = Convert.ToString(dr["BaoChe"]);
					}
					if (dr["TrinhBay"] != null && dr["TrinhBay"] != DBNull.Value)
					{
						item.TrinhBay = Convert.ToString(dr["TrinhBay"]);
					}
					if (dr["DuongDung"] != null && dr["DuongDung"] != DBNull.Value)
					{
						item.DuongDung = Convert.ToString(dr["DuongDung"]);
					}
					if (dr["DVT"] != null && dr["DVT"] != DBNull.Value)
					{
						item.DVT = Convert.ToString(dr["DVT"]);
					}
					if (dr["NHOM"] != null && dr["NHOM"] != DBNull.Value)
					{
						item.NHOM = Convert.ToString(dr["NHOM"]);
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
					if (dr["DonGiaMin"] != null && dr["DonGiaMin"] != DBNull.Value)
					{
						item.DonGiaMin = Convert.ToDecimal(dr["DonGiaMin"]);
					}
					if (dr["DonGiaMax"] != null && dr["DonGiaMax"] != DBNull.Value)
					{
						item.DonGiaMax = Convert.ToDecimal(dr["DonGiaMax"]);
					}
					if (dr["CTY1"] != null && dr["CTY1"] != DBNull.Value)
					{
						item.CTY1 = Convert.ToString(dr["CTY1"]);
					}
					if (dr["TENT1"] != null && dr["TENT1"] != DBNull.Value)
					{
						item.TENT1 = Convert.ToString(dr["TENT1"]);
					}
					if (dr["DONGIA1"] != null && dr["DONGIA1"] != DBNull.Value)
					{
						item.DONGIA1 = Convert.ToString(dr["DONGIA1"]);
					}
					if (dr["GIAKK1"] != null && dr["GIAKK1"] != DBNull.Value)
					{
						item.GIAKK1 = Convert.ToString(dr["GIAKK1"]);
					}
					if (dr["CTY2"] != null && dr["CTY2"] != DBNull.Value)
					{
						item.CTY2 = Convert.ToString(dr["CTY2"]);
					}
					if (dr["TENT2"] != null && dr["TENT2"] != DBNull.Value)
					{
						item.TENT2 = Convert.ToString(dr["TENT2"]);
					}
					if (dr["DONGIA2"] != null && dr["DONGIA2"] != DBNull.Value)
					{
						item.DONGIA2 = Convert.ToString(dr["DONGIA2"]);
					}
					if (dr["GIAKK2"] != null && dr["GIAKK2"] != DBNull.Value)
					{
						item.GIAKK2 = Convert.ToString(dr["GIAKK2"]);
					}
					if (dr["CTY3"] != null && dr["CTY3"] != DBNull.Value)
					{
						item.CTY3 = Convert.ToString(dr["CTY3"]);
					}
					if (dr["TENT3"] != null && dr["TENT3"] != DBNull.Value)
					{
						item.TENT3 = Convert.ToString(dr["TENT3"]);
					}
					if (dr["DONGIA3"] != null && dr["DONGIA3"] != DBNull.Value)
					{
						item.DONGIA3 = Convert.ToString(dr["DONGIA3"]);
					}
					if (dr["GIAKK3"] != null && dr["GIAKK3"] != DBNull.Value)
					{
						item.GIAKK3 = Convert.ToString(dr["GIAKK3"]);
					}
					if (dr["SanPhamTT"] != null && dr["SanPhamTT"] != DBNull.Value)
					{
						item.SanPhamTT = Convert.ToString(dr["SanPhamTT"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
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
		/// Lấy danh sách VPTempR từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VPTempR> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VPTempR] A "+ condition,  parameters);
				List<VPTempR> items = new List<VPTempR>();
				VPTempR item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VPTempR();
					if (dr["ID"] != null && dr["ID"] != DBNull.Value)
					{
						item.ID = Convert.ToString(dr["ID"]);
					}
					if (dr["GroupId"] != null && dr["GroupId"] != DBNull.Value)
					{
						item.GroupId = Convert.ToString(dr["GroupId"]);
					}
					if (dr["STTTN"] != null && dr["STTTN"] != DBNull.Value)
					{
						item.STTTN = Convert.ToString(dr["STTTN"]);
					}
					if (dr["STTTT"] != null && dr["STTTT"] != DBNull.Value)
					{
						item.STTTT = Convert.ToString(dr["STTTT"]);
					}
					if (dr["MaThuoc"] != null && dr["MaThuoc"] != DBNull.Value)
					{
						item.MaThuoc = Convert.ToString(dr["MaThuoc"]);
					}
					if (dr["HoatChat"] != null && dr["HoatChat"] != DBNull.Value)
					{
						item.HoatChat = Convert.ToString(dr["HoatChat"]);
					}
					if (dr["BietDuoc"] != null && dr["BietDuoc"] != DBNull.Value)
					{
						item.BietDuoc = Convert.ToString(dr["BietDuoc"]);
					}
					if (dr["NongDo"] != null && dr["NongDo"] != DBNull.Value)
					{
						item.NongDo = Convert.ToString(dr["NongDo"]);
					}
					if (dr["BaoChe"] != null && dr["BaoChe"] != DBNull.Value)
					{
						item.BaoChe = Convert.ToString(dr["BaoChe"]);
					}
					if (dr["TrinhBay"] != null && dr["TrinhBay"] != DBNull.Value)
					{
						item.TrinhBay = Convert.ToString(dr["TrinhBay"]);
					}
					if (dr["DuongDung"] != null && dr["DuongDung"] != DBNull.Value)
					{
						item.DuongDung = Convert.ToString(dr["DuongDung"]);
					}
					if (dr["DVT"] != null && dr["DVT"] != DBNull.Value)
					{
						item.DVT = Convert.ToString(dr["DVT"]);
					}
					if (dr["NHOM"] != null && dr["NHOM"] != DBNull.Value)
					{
						item.NHOM = Convert.ToString(dr["NHOM"]);
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
					if (dr["DonGiaMin"] != null && dr["DonGiaMin"] != DBNull.Value)
					{
						item.DonGiaMin = Convert.ToDecimal(dr["DonGiaMin"]);
					}
					if (dr["DonGiaMax"] != null && dr["DonGiaMax"] != DBNull.Value)
					{
						item.DonGiaMax = Convert.ToDecimal(dr["DonGiaMax"]);
					}
					if (dr["CTY1"] != null && dr["CTY1"] != DBNull.Value)
					{
						item.CTY1 = Convert.ToString(dr["CTY1"]);
					}
					if (dr["TENT1"] != null && dr["TENT1"] != DBNull.Value)
					{
						item.TENT1 = Convert.ToString(dr["TENT1"]);
					}
					if (dr["DONGIA1"] != null && dr["DONGIA1"] != DBNull.Value)
					{
						item.DONGIA1 = Convert.ToString(dr["DONGIA1"]);
					}
					if (dr["GIAKK1"] != null && dr["GIAKK1"] != DBNull.Value)
					{
						item.GIAKK1 = Convert.ToString(dr["GIAKK1"]);
					}
					if (dr["CTY2"] != null && dr["CTY2"] != DBNull.Value)
					{
						item.CTY2 = Convert.ToString(dr["CTY2"]);
					}
					if (dr["TENT2"] != null && dr["TENT2"] != DBNull.Value)
					{
						item.TENT2 = Convert.ToString(dr["TENT2"]);
					}
					if (dr["DONGIA2"] != null && dr["DONGIA2"] != DBNull.Value)
					{
						item.DONGIA2 = Convert.ToString(dr["DONGIA2"]);
					}
					if (dr["GIAKK2"] != null && dr["GIAKK2"] != DBNull.Value)
					{
						item.GIAKK2 = Convert.ToString(dr["GIAKK2"]);
					}
					if (dr["CTY3"] != null && dr["CTY3"] != DBNull.Value)
					{
						item.CTY3 = Convert.ToString(dr["CTY3"]);
					}
					if (dr["TENT3"] != null && dr["TENT3"] != DBNull.Value)
					{
						item.TENT3 = Convert.ToString(dr["TENT3"]);
					}
					if (dr["DONGIA3"] != null && dr["DONGIA3"] != DBNull.Value)
					{
						item.DONGIA3 = Convert.ToString(dr["DONGIA3"]);
					}
					if (dr["GIAKK3"] != null && dr["GIAKK3"] != DBNull.Value)
					{
						item.GIAKK3 = Convert.ToString(dr["GIAKK3"]);
					}
					if (dr["SanPhamTT"] != null && dr["SanPhamTT"] != DBNull.Value)
					{
						item.SanPhamTT = Convert.ToString(dr["SanPhamTT"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
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

		public List<VPTempR> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VPTempR] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VPTempR] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VPTempR>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VPTempR từ Database
		/// </summary>
		public VPTempR GetObject(string schema, String ID)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VPTempR] where ID=@ID",
					"@ID", ID);
				if (ds.Rows.Count > 0)
				{
					VPTempR item=new VPTempR();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ID"] != null && dr["ID"] != DBNull.Value)
						{
							item.ID = Convert.ToString(dr["ID"]);
						}
						if (dr["GroupId"] != null && dr["GroupId"] != DBNull.Value)
						{
							item.GroupId = Convert.ToString(dr["GroupId"]);
						}
						if (dr["STTTN"] != null && dr["STTTN"] != DBNull.Value)
						{
							item.STTTN = Convert.ToString(dr["STTTN"]);
						}
						if (dr["STTTT"] != null && dr["STTTT"] != DBNull.Value)
						{
							item.STTTT = Convert.ToString(dr["STTTT"]);
						}
						if (dr["MaThuoc"] != null && dr["MaThuoc"] != DBNull.Value)
						{
							item.MaThuoc = Convert.ToString(dr["MaThuoc"]);
						}
						if (dr["HoatChat"] != null && dr["HoatChat"] != DBNull.Value)
						{
							item.HoatChat = Convert.ToString(dr["HoatChat"]);
						}
						if (dr["BietDuoc"] != null && dr["BietDuoc"] != DBNull.Value)
						{
							item.BietDuoc = Convert.ToString(dr["BietDuoc"]);
						}
						if (dr["NongDo"] != null && dr["NongDo"] != DBNull.Value)
						{
							item.NongDo = Convert.ToString(dr["NongDo"]);
						}
						if (dr["BaoChe"] != null && dr["BaoChe"] != DBNull.Value)
						{
							item.BaoChe = Convert.ToString(dr["BaoChe"]);
						}
						if (dr["TrinhBay"] != null && dr["TrinhBay"] != DBNull.Value)
						{
							item.TrinhBay = Convert.ToString(dr["TrinhBay"]);
						}
						if (dr["DuongDung"] != null && dr["DuongDung"] != DBNull.Value)
						{
							item.DuongDung = Convert.ToString(dr["DuongDung"]);
						}
						if (dr["DVT"] != null && dr["DVT"] != DBNull.Value)
						{
							item.DVT = Convert.ToString(dr["DVT"]);
						}
						if (dr["NHOM"] != null && dr["NHOM"] != DBNull.Value)
						{
							item.NHOM = Convert.ToString(dr["NHOM"]);
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
						if (dr["DonGiaMin"] != null && dr["DonGiaMin"] != DBNull.Value)
						{
							item.DonGiaMin = Convert.ToDecimal(dr["DonGiaMin"]);
						}
						if (dr["DonGiaMax"] != null && dr["DonGiaMax"] != DBNull.Value)
						{
							item.DonGiaMax = Convert.ToDecimal(dr["DonGiaMax"]);
						}
						if (dr["CTY1"] != null && dr["CTY1"] != DBNull.Value)
						{
							item.CTY1 = Convert.ToString(dr["CTY1"]);
						}
						if (dr["TENT1"] != null && dr["TENT1"] != DBNull.Value)
						{
							item.TENT1 = Convert.ToString(dr["TENT1"]);
						}
						if (dr["DONGIA1"] != null && dr["DONGIA1"] != DBNull.Value)
						{
							item.DONGIA1 = Convert.ToString(dr["DONGIA1"]);
						}
						if (dr["GIAKK1"] != null && dr["GIAKK1"] != DBNull.Value)
						{
							item.GIAKK1 = Convert.ToString(dr["GIAKK1"]);
						}
						if (dr["CTY2"] != null && dr["CTY2"] != DBNull.Value)
						{
							item.CTY2 = Convert.ToString(dr["CTY2"]);
						}
						if (dr["TENT2"] != null && dr["TENT2"] != DBNull.Value)
						{
							item.TENT2 = Convert.ToString(dr["TENT2"]);
						}
						if (dr["DONGIA2"] != null && dr["DONGIA2"] != DBNull.Value)
						{
							item.DONGIA2 = Convert.ToString(dr["DONGIA2"]);
						}
						if (dr["GIAKK2"] != null && dr["GIAKK2"] != DBNull.Value)
						{
							item.GIAKK2 = Convert.ToString(dr["GIAKK2"]);
						}
						if (dr["CTY3"] != null && dr["CTY3"] != DBNull.Value)
						{
							item.CTY3 = Convert.ToString(dr["CTY3"]);
						}
						if (dr["TENT3"] != null && dr["TENT3"] != DBNull.Value)
						{
							item.TENT3 = Convert.ToString(dr["TENT3"]);
						}
						if (dr["DONGIA3"] != null && dr["DONGIA3"] != DBNull.Value)
						{
							item.DONGIA3 = Convert.ToString(dr["DONGIA3"]);
						}
						if (dr["GIAKK3"] != null && dr["GIAKK3"] != DBNull.Value)
						{
							item.GIAKK3 = Convert.ToString(dr["GIAKK3"]);
						}
						if (dr["SanPhamTT"] != null && dr["SanPhamTT"] != DBNull.Value)
						{
							item.SanPhamTT = Convert.ToString(dr["SanPhamTT"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
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
		/// Lấy một VPTempR đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VPTempR GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VPTempR] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VPTempR item=new VPTempR();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ID"] != null && dr["ID"] != DBNull.Value)
						{
							item.ID = Convert.ToString(dr["ID"]);
						}
						if (dr["GroupId"] != null && dr["GroupId"] != DBNull.Value)
						{
							item.GroupId = Convert.ToString(dr["GroupId"]);
						}
						if (dr["STTTN"] != null && dr["STTTN"] != DBNull.Value)
						{
							item.STTTN = Convert.ToString(dr["STTTN"]);
						}
						if (dr["STTTT"] != null && dr["STTTT"] != DBNull.Value)
						{
							item.STTTT = Convert.ToString(dr["STTTT"]);
						}
						if (dr["MaThuoc"] != null && dr["MaThuoc"] != DBNull.Value)
						{
							item.MaThuoc = Convert.ToString(dr["MaThuoc"]);
						}
						if (dr["HoatChat"] != null && dr["HoatChat"] != DBNull.Value)
						{
							item.HoatChat = Convert.ToString(dr["HoatChat"]);
						}
						if (dr["BietDuoc"] != null && dr["BietDuoc"] != DBNull.Value)
						{
							item.BietDuoc = Convert.ToString(dr["BietDuoc"]);
						}
						if (dr["NongDo"] != null && dr["NongDo"] != DBNull.Value)
						{
							item.NongDo = Convert.ToString(dr["NongDo"]);
						}
						if (dr["BaoChe"] != null && dr["BaoChe"] != DBNull.Value)
						{
							item.BaoChe = Convert.ToString(dr["BaoChe"]);
						}
						if (dr["TrinhBay"] != null && dr["TrinhBay"] != DBNull.Value)
						{
							item.TrinhBay = Convert.ToString(dr["TrinhBay"]);
						}
						if (dr["DuongDung"] != null && dr["DuongDung"] != DBNull.Value)
						{
							item.DuongDung = Convert.ToString(dr["DuongDung"]);
						}
						if (dr["DVT"] != null && dr["DVT"] != DBNull.Value)
						{
							item.DVT = Convert.ToString(dr["DVT"]);
						}
						if (dr["NHOM"] != null && dr["NHOM"] != DBNull.Value)
						{
							item.NHOM = Convert.ToString(dr["NHOM"]);
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
						if (dr["DonGiaMin"] != null && dr["DonGiaMin"] != DBNull.Value)
						{
							item.DonGiaMin = Convert.ToDecimal(dr["DonGiaMin"]);
						}
						if (dr["DonGiaMax"] != null && dr["DonGiaMax"] != DBNull.Value)
						{
							item.DonGiaMax = Convert.ToDecimal(dr["DonGiaMax"]);
						}
						if (dr["CTY1"] != null && dr["CTY1"] != DBNull.Value)
						{
							item.CTY1 = Convert.ToString(dr["CTY1"]);
						}
						if (dr["TENT1"] != null && dr["TENT1"] != DBNull.Value)
						{
							item.TENT1 = Convert.ToString(dr["TENT1"]);
						}
						if (dr["DONGIA1"] != null && dr["DONGIA1"] != DBNull.Value)
						{
							item.DONGIA1 = Convert.ToString(dr["DONGIA1"]);
						}
						if (dr["GIAKK1"] != null && dr["GIAKK1"] != DBNull.Value)
						{
							item.GIAKK1 = Convert.ToString(dr["GIAKK1"]);
						}
						if (dr["CTY2"] != null && dr["CTY2"] != DBNull.Value)
						{
							item.CTY2 = Convert.ToString(dr["CTY2"]);
						}
						if (dr["TENT2"] != null && dr["TENT2"] != DBNull.Value)
						{
							item.TENT2 = Convert.ToString(dr["TENT2"]);
						}
						if (dr["DONGIA2"] != null && dr["DONGIA2"] != DBNull.Value)
						{
							item.DONGIA2 = Convert.ToString(dr["DONGIA2"]);
						}
						if (dr["GIAKK2"] != null && dr["GIAKK2"] != DBNull.Value)
						{
							item.GIAKK2 = Convert.ToString(dr["GIAKK2"]);
						}
						if (dr["CTY3"] != null && dr["CTY3"] != DBNull.Value)
						{
							item.CTY3 = Convert.ToString(dr["CTY3"]);
						}
						if (dr["TENT3"] != null && dr["TENT3"] != DBNull.Value)
						{
							item.TENT3 = Convert.ToString(dr["TENT3"]);
						}
						if (dr["DONGIA3"] != null && dr["DONGIA3"] != DBNull.Value)
						{
							item.DONGIA3 = Convert.ToString(dr["DONGIA3"]);
						}
						if (dr["GIAKK3"] != null && dr["GIAKK3"] != DBNull.Value)
						{
							item.GIAKK3 = Convert.ToString(dr["GIAKK3"]);
						}
						if (dr["SanPhamTT"] != null && dr["SanPhamTT"] != DBNull.Value)
						{
							item.SanPhamTT = Convert.ToString(dr["SanPhamTT"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
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

		public VPTempR GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VPTempR] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VPTempR>(ds);
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
		/// Thêm mới VPTempR vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VPTempR _VPTempR)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VPTempR](ID, GroupId, STTTN, STTTT, MaThuoc, HoatChat, BietDuoc, NongDo, BaoChe, TrinhBay, DuongDung, DVT, NHOM, SoLuong, DonGia, ThanhTien, DonGiaMin, DonGiaMax, CTY1, TENT1, DONGIA1, GIAKK1, CTY2, TENT2, DONGIA2, GIAKK2, CTY3, TENT3, DONGIA3, GIAKK3, SanPhamTT, Note) VALUES(@ID, @GroupId, @STTTN, @STTTT, @MaThuoc, @HoatChat, @BietDuoc, @NongDo, @BaoChe, @TrinhBay, @DuongDung, @DVT, @NHOM, @SoLuong, @DonGia, @ThanhTien, @DonGiaMin, @DonGiaMax, @CTY1, @TENT1, @DONGIA1, @GIAKK1, @CTY2, @TENT2, @DONGIA2, @GIAKK2, @CTY3, @TENT3, @DONGIA3, @GIAKK3, @SanPhamTT, @Note)", 
					"@ID",  _VPTempR.ID, 
					"@GroupId",  _VPTempR.GroupId, 
					"@STTTN",  _VPTempR.STTTN, 
					"@STTTT",  _VPTempR.STTTT, 
					"@MaThuoc",  _VPTempR.MaThuoc, 
					"@HoatChat",  _VPTempR.HoatChat, 
					"@BietDuoc",  _VPTempR.BietDuoc, 
					"@NongDo",  _VPTempR.NongDo, 
					"@BaoChe",  _VPTempR.BaoChe, 
					"@TrinhBay",  _VPTempR.TrinhBay, 
					"@DuongDung",  _VPTempR.DuongDung, 
					"@DVT",  _VPTempR.DVT, 
					"@NHOM",  _VPTempR.NHOM, 
					"@SoLuong",  _VPTempR.SoLuong, 
					"@DonGia",  _VPTempR.DonGia, 
					"@ThanhTien",  _VPTempR.ThanhTien, 
					"@DonGiaMin",  _VPTempR.DonGiaMin, 
					"@DonGiaMax",  _VPTempR.DonGiaMax, 
					"@CTY1",  _VPTempR.CTY1, 
					"@TENT1",  _VPTempR.TENT1, 
					"@DONGIA1",  _VPTempR.DONGIA1, 
					"@GIAKK1",  _VPTempR.GIAKK1, 
					"@CTY2",  _VPTempR.CTY2, 
					"@TENT2",  _VPTempR.TENT2, 
					"@DONGIA2",  _VPTempR.DONGIA2, 
					"@GIAKK2",  _VPTempR.GIAKK2, 
					"@CTY3",  _VPTempR.CTY3, 
					"@TENT3",  _VPTempR.TENT3, 
					"@DONGIA3",  _VPTempR.DONGIA3, 
					"@GIAKK3",  _VPTempR.GIAKK3, 
					"@SanPhamTT",  _VPTempR.SanPhamTT, 
					"@Note",  _VPTempR.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VPTempR vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VPTempR> _VPTempRs)
		{
			foreach (VPTempR item in _VPTempRs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VPTempR vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VPTempR _VPTempR, String ID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VPTempR] SET ID=@ID, GroupId=@GroupId, STTTN=@STTTN, STTTT=@STTTT, MaThuoc=@MaThuoc, HoatChat=@HoatChat, BietDuoc=@BietDuoc, NongDo=@NongDo, BaoChe=@BaoChe, TrinhBay=@TrinhBay, DuongDung=@DuongDung, DVT=@DVT, NHOM=@NHOM, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, DonGiaMin=@DonGiaMin, DonGiaMax=@DonGiaMax, CTY1=@CTY1, TENT1=@TENT1, DONGIA1=@DONGIA1, GIAKK1=@GIAKK1, CTY2=@CTY2, TENT2=@TENT2, DONGIA2=@DONGIA2, GIAKK2=@GIAKK2, CTY3=@CTY3, TENT3=@TENT3, DONGIA3=@DONGIA3, GIAKK3=@GIAKK3, SanPhamTT=@SanPhamTT, Note=@Note WHERE ID=@ID", 
					"@ID",  _VPTempR.ID, 
					"@GroupId",  _VPTempR.GroupId, 
					"@STTTN",  _VPTempR.STTTN, 
					"@STTTT",  _VPTempR.STTTT, 
					"@MaThuoc",  _VPTempR.MaThuoc, 
					"@HoatChat",  _VPTempR.HoatChat, 
					"@BietDuoc",  _VPTempR.BietDuoc, 
					"@NongDo",  _VPTempR.NongDo, 
					"@BaoChe",  _VPTempR.BaoChe, 
					"@TrinhBay",  _VPTempR.TrinhBay, 
					"@DuongDung",  _VPTempR.DuongDung, 
					"@DVT",  _VPTempR.DVT, 
					"@NHOM",  _VPTempR.NHOM, 
					"@SoLuong",  _VPTempR.SoLuong, 
					"@DonGia",  _VPTempR.DonGia, 
					"@ThanhTien",  _VPTempR.ThanhTien, 
					"@DonGiaMin",  _VPTempR.DonGiaMin, 
					"@DonGiaMax",  _VPTempR.DonGiaMax, 
					"@CTY1",  _VPTempR.CTY1, 
					"@TENT1",  _VPTempR.TENT1, 
					"@DONGIA1",  _VPTempR.DONGIA1, 
					"@GIAKK1",  _VPTempR.GIAKK1, 
					"@CTY2",  _VPTempR.CTY2, 
					"@TENT2",  _VPTempR.TENT2, 
					"@DONGIA2",  _VPTempR.DONGIA2, 
					"@GIAKK2",  _VPTempR.GIAKK2, 
					"@CTY3",  _VPTempR.CTY3, 
					"@TENT3",  _VPTempR.TENT3, 
					"@DONGIA3",  _VPTempR.DONGIA3, 
					"@GIAKK3",  _VPTempR.GIAKK3, 
					"@SanPhamTT",  _VPTempR.SanPhamTT, 
					"@Note",  _VPTempR.Note, 
					"@ID", ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VPTempR vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VPTempR _VPTempR)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VPTempR] SET GroupId=@GroupId, STTTN=@STTTN, STTTT=@STTTT, MaThuoc=@MaThuoc, HoatChat=@HoatChat, BietDuoc=@BietDuoc, NongDo=@NongDo, BaoChe=@BaoChe, TrinhBay=@TrinhBay, DuongDung=@DuongDung, DVT=@DVT, NHOM=@NHOM, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, DonGiaMin=@DonGiaMin, DonGiaMax=@DonGiaMax, CTY1=@CTY1, TENT1=@TENT1, DONGIA1=@DONGIA1, GIAKK1=@GIAKK1, CTY2=@CTY2, TENT2=@TENT2, DONGIA2=@DONGIA2, GIAKK2=@GIAKK2, CTY3=@CTY3, TENT3=@TENT3, DONGIA3=@DONGIA3, GIAKK3=@GIAKK3, SanPhamTT=@SanPhamTT, Note=@Note WHERE ID=@ID", 
					"@GroupId",  _VPTempR.GroupId, 
					"@STTTN",  _VPTempR.STTTN, 
					"@STTTT",  _VPTempR.STTTT, 
					"@MaThuoc",  _VPTempR.MaThuoc, 
					"@HoatChat",  _VPTempR.HoatChat, 
					"@BietDuoc",  _VPTempR.BietDuoc, 
					"@NongDo",  _VPTempR.NongDo, 
					"@BaoChe",  _VPTempR.BaoChe, 
					"@TrinhBay",  _VPTempR.TrinhBay, 
					"@DuongDung",  _VPTempR.DuongDung, 
					"@DVT",  _VPTempR.DVT, 
					"@NHOM",  _VPTempR.NHOM, 
					"@SoLuong",  _VPTempR.SoLuong, 
					"@DonGia",  _VPTempR.DonGia, 
					"@ThanhTien",  _VPTempR.ThanhTien, 
					"@DonGiaMin",  _VPTempR.DonGiaMin, 
					"@DonGiaMax",  _VPTempR.DonGiaMax, 
					"@CTY1",  _VPTempR.CTY1, 
					"@TENT1",  _VPTempR.TENT1, 
					"@DONGIA1",  _VPTempR.DONGIA1, 
					"@GIAKK1",  _VPTempR.GIAKK1, 
					"@CTY2",  _VPTempR.CTY2, 
					"@TENT2",  _VPTempR.TENT2, 
					"@DONGIA2",  _VPTempR.DONGIA2, 
					"@GIAKK2",  _VPTempR.GIAKK2, 
					"@CTY3",  _VPTempR.CTY3, 
					"@TENT3",  _VPTempR.TENT3, 
					"@DONGIA3",  _VPTempR.DONGIA3, 
					"@GIAKK3",  _VPTempR.GIAKK3, 
					"@SanPhamTT",  _VPTempR.SanPhamTT, 
					"@Note",  _VPTempR.Note, 
					"@ID", _VPTempR.ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VPTempR vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VPTempR> _VPTempRs)
		{
			foreach (VPTempR item in _VPTempRs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VPTempR vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VPTempR _VPTempR, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VPTempR] SET ID=@ID, GroupId=@GroupId, STTTN=@STTTN, STTTT=@STTTT, MaThuoc=@MaThuoc, HoatChat=@HoatChat, BietDuoc=@BietDuoc, NongDo=@NongDo, BaoChe=@BaoChe, TrinhBay=@TrinhBay, DuongDung=@DuongDung, DVT=@DVT, NHOM=@NHOM, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, DonGiaMin=@DonGiaMin, DonGiaMax=@DonGiaMax, CTY1=@CTY1, TENT1=@TENT1, DONGIA1=@DONGIA1, GIAKK1=@GIAKK1, CTY2=@CTY2, TENT2=@TENT2, DONGIA2=@DONGIA2, GIAKK2=@GIAKK2, CTY3=@CTY3, TENT3=@TENT3, DONGIA3=@DONGIA3, GIAKK3=@GIAKK3, SanPhamTT=@SanPhamTT, Note=@Note "+ condition, 
					"@ID",  _VPTempR.ID, 
					"@GroupId",  _VPTempR.GroupId, 
					"@STTTN",  _VPTempR.STTTN, 
					"@STTTT",  _VPTempR.STTTT, 
					"@MaThuoc",  _VPTempR.MaThuoc, 
					"@HoatChat",  _VPTempR.HoatChat, 
					"@BietDuoc",  _VPTempR.BietDuoc, 
					"@NongDo",  _VPTempR.NongDo, 
					"@BaoChe",  _VPTempR.BaoChe, 
					"@TrinhBay",  _VPTempR.TrinhBay, 
					"@DuongDung",  _VPTempR.DuongDung, 
					"@DVT",  _VPTempR.DVT, 
					"@NHOM",  _VPTempR.NHOM, 
					"@SoLuong",  _VPTempR.SoLuong, 
					"@DonGia",  _VPTempR.DonGia, 
					"@ThanhTien",  _VPTempR.ThanhTien, 
					"@DonGiaMin",  _VPTempR.DonGiaMin, 
					"@DonGiaMax",  _VPTempR.DonGiaMax, 
					"@CTY1",  _VPTempR.CTY1, 
					"@TENT1",  _VPTempR.TENT1, 
					"@DONGIA1",  _VPTempR.DONGIA1, 
					"@GIAKK1",  _VPTempR.GIAKK1, 
					"@CTY2",  _VPTempR.CTY2, 
					"@TENT2",  _VPTempR.TENT2, 
					"@DONGIA2",  _VPTempR.DONGIA2, 
					"@GIAKK2",  _VPTempR.GIAKK2, 
					"@CTY3",  _VPTempR.CTY3, 
					"@TENT3",  _VPTempR.TENT3, 
					"@DONGIA3",  _VPTempR.DONGIA3, 
					"@GIAKK3",  _VPTempR.GIAKK3, 
					"@SanPhamTT",  _VPTempR.SanPhamTT, 
					"@Note",  _VPTempR.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VPTempR trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String ID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VPTempR] WHERE ID=@ID",
					"@ID", ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VPTempR trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VPTempR _VPTempR)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VPTempR] WHERE ID=@ID",
					"@ID", _VPTempR.ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VPTempR trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VPTempR] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VPTempR trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VPTempR> _VPTempRs)
		{
			foreach (VPTempR item in _VPTempRs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
