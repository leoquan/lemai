using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVPtemp:IVPtemp
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVPtemp(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VPTemp từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VPTemp]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VPTemp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VPTemp] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VPTemp từ Database
		/// </summary>
		public List<VPTemp> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VPTemp]");
				List<VPTemp> items = new List<VPTemp>();
				VPTemp item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VPTemp();
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
		/// Lấy danh sách VPTemp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VPTemp> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VPTemp] A "+ condition,  parameters);
				List<VPTemp> items = new List<VPTemp>();
				VPTemp item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VPTemp();
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

		public List<VPTemp> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VPTemp] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VPTemp] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VPTemp>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VPTemp từ Database
		/// </summary>
		public VPTemp GetObject(string schema, String ID)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VPTemp] where ID=@ID",
					"@ID", ID);
				if (ds.Rows.Count > 0)
				{
					VPTemp item=new VPTemp();
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
		/// Lấy một VPTemp đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VPTemp GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VPTemp] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VPTemp item=new VPTemp();
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

		public VPTemp GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VPTemp] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VPTemp>(ds);
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
		/// Thêm mới VPTemp vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VPTemp _VPTemp)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VPTemp](ID, GroupId, STTTN, STTTT, MaThuoc, HoatChat, BietDuoc, NongDo, BaoChe, TrinhBay, DuongDung, DVT, NHOM, SoLuong, DonGia, ThanhTien, DonGiaMin, DonGiaMax, CTY1, TENT1, DONGIA1, GIAKK1, CTY2, TENT2, DONGIA2, GIAKK2, CTY3, TENT3, DONGIA3, GIAKK3, Note) VALUES(@ID, @GroupId, @STTTN, @STTTT, @MaThuoc, @HoatChat, @BietDuoc, @NongDo, @BaoChe, @TrinhBay, @DuongDung, @DVT, @NHOM, @SoLuong, @DonGia, @ThanhTien, @DonGiaMin, @DonGiaMax, @CTY1, @TENT1, @DONGIA1, @GIAKK1, @CTY2, @TENT2, @DONGIA2, @GIAKK2, @CTY3, @TENT3, @DONGIA3, @GIAKK3, @Note)", 
					"@ID",  _VPTemp.ID, 
					"@GroupId",  _VPTemp.GroupId, 
					"@STTTN",  _VPTemp.STTTN, 
					"@STTTT",  _VPTemp.STTTT, 
					"@MaThuoc",  _VPTemp.MaThuoc, 
					"@HoatChat",  _VPTemp.HoatChat, 
					"@BietDuoc",  _VPTemp.BietDuoc, 
					"@NongDo",  _VPTemp.NongDo, 
					"@BaoChe",  _VPTemp.BaoChe, 
					"@TrinhBay",  _VPTemp.TrinhBay, 
					"@DuongDung",  _VPTemp.DuongDung, 
					"@DVT",  _VPTemp.DVT, 
					"@NHOM",  _VPTemp.NHOM, 
					"@SoLuong",  _VPTemp.SoLuong, 
					"@DonGia",  _VPTemp.DonGia, 
					"@ThanhTien",  _VPTemp.ThanhTien, 
					"@DonGiaMin",  _VPTemp.DonGiaMin, 
					"@DonGiaMax",  _VPTemp.DonGiaMax, 
					"@CTY1",  _VPTemp.CTY1, 
					"@TENT1",  _VPTemp.TENT1, 
					"@DONGIA1",  _VPTemp.DONGIA1, 
					"@GIAKK1",  _VPTemp.GIAKK1, 
					"@CTY2",  _VPTemp.CTY2, 
					"@TENT2",  _VPTemp.TENT2, 
					"@DONGIA2",  _VPTemp.DONGIA2, 
					"@GIAKK2",  _VPTemp.GIAKK2, 
					"@CTY3",  _VPTemp.CTY3, 
					"@TENT3",  _VPTemp.TENT3, 
					"@DONGIA3",  _VPTemp.DONGIA3, 
					"@GIAKK3",  _VPTemp.GIAKK3, 
					"@Note",  _VPTemp.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VPTemp vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VPTemp> _VPTemps)
		{
			foreach (VPTemp item in _VPTemps)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VPTemp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VPTemp _VPTemp, String ID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VPTemp] SET ID=@ID, GroupId=@GroupId, STTTN=@STTTN, STTTT=@STTTT, MaThuoc=@MaThuoc, HoatChat=@HoatChat, BietDuoc=@BietDuoc, NongDo=@NongDo, BaoChe=@BaoChe, TrinhBay=@TrinhBay, DuongDung=@DuongDung, DVT=@DVT, NHOM=@NHOM, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, DonGiaMin=@DonGiaMin, DonGiaMax=@DonGiaMax, CTY1=@CTY1, TENT1=@TENT1, DONGIA1=@DONGIA1, GIAKK1=@GIAKK1, CTY2=@CTY2, TENT2=@TENT2, DONGIA2=@DONGIA2, GIAKK2=@GIAKK2, CTY3=@CTY3, TENT3=@TENT3, DONGIA3=@DONGIA3, GIAKK3=@GIAKK3, Note=@Note WHERE ID=@ID", 
					"@ID",  _VPTemp.ID, 
					"@GroupId",  _VPTemp.GroupId, 
					"@STTTN",  _VPTemp.STTTN, 
					"@STTTT",  _VPTemp.STTTT, 
					"@MaThuoc",  _VPTemp.MaThuoc, 
					"@HoatChat",  _VPTemp.HoatChat, 
					"@BietDuoc",  _VPTemp.BietDuoc, 
					"@NongDo",  _VPTemp.NongDo, 
					"@BaoChe",  _VPTemp.BaoChe, 
					"@TrinhBay",  _VPTemp.TrinhBay, 
					"@DuongDung",  _VPTemp.DuongDung, 
					"@DVT",  _VPTemp.DVT, 
					"@NHOM",  _VPTemp.NHOM, 
					"@SoLuong",  _VPTemp.SoLuong, 
					"@DonGia",  _VPTemp.DonGia, 
					"@ThanhTien",  _VPTemp.ThanhTien, 
					"@DonGiaMin",  _VPTemp.DonGiaMin, 
					"@DonGiaMax",  _VPTemp.DonGiaMax, 
					"@CTY1",  _VPTemp.CTY1, 
					"@TENT1",  _VPTemp.TENT1, 
					"@DONGIA1",  _VPTemp.DONGIA1, 
					"@GIAKK1",  _VPTemp.GIAKK1, 
					"@CTY2",  _VPTemp.CTY2, 
					"@TENT2",  _VPTemp.TENT2, 
					"@DONGIA2",  _VPTemp.DONGIA2, 
					"@GIAKK2",  _VPTemp.GIAKK2, 
					"@CTY3",  _VPTemp.CTY3, 
					"@TENT3",  _VPTemp.TENT3, 
					"@DONGIA3",  _VPTemp.DONGIA3, 
					"@GIAKK3",  _VPTemp.GIAKK3, 
					"@Note",  _VPTemp.Note, 
					"@ID", ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VPTemp vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VPTemp _VPTemp)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VPTemp] SET GroupId=@GroupId, STTTN=@STTTN, STTTT=@STTTT, MaThuoc=@MaThuoc, HoatChat=@HoatChat, BietDuoc=@BietDuoc, NongDo=@NongDo, BaoChe=@BaoChe, TrinhBay=@TrinhBay, DuongDung=@DuongDung, DVT=@DVT, NHOM=@NHOM, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, DonGiaMin=@DonGiaMin, DonGiaMax=@DonGiaMax, CTY1=@CTY1, TENT1=@TENT1, DONGIA1=@DONGIA1, GIAKK1=@GIAKK1, CTY2=@CTY2, TENT2=@TENT2, DONGIA2=@DONGIA2, GIAKK2=@GIAKK2, CTY3=@CTY3, TENT3=@TENT3, DONGIA3=@DONGIA3, GIAKK3=@GIAKK3, Note=@Note WHERE ID=@ID", 
					"@GroupId",  _VPTemp.GroupId, 
					"@STTTN",  _VPTemp.STTTN, 
					"@STTTT",  _VPTemp.STTTT, 
					"@MaThuoc",  _VPTemp.MaThuoc, 
					"@HoatChat",  _VPTemp.HoatChat, 
					"@BietDuoc",  _VPTemp.BietDuoc, 
					"@NongDo",  _VPTemp.NongDo, 
					"@BaoChe",  _VPTemp.BaoChe, 
					"@TrinhBay",  _VPTemp.TrinhBay, 
					"@DuongDung",  _VPTemp.DuongDung, 
					"@DVT",  _VPTemp.DVT, 
					"@NHOM",  _VPTemp.NHOM, 
					"@SoLuong",  _VPTemp.SoLuong, 
					"@DonGia",  _VPTemp.DonGia, 
					"@ThanhTien",  _VPTemp.ThanhTien, 
					"@DonGiaMin",  _VPTemp.DonGiaMin, 
					"@DonGiaMax",  _VPTemp.DonGiaMax, 
					"@CTY1",  _VPTemp.CTY1, 
					"@TENT1",  _VPTemp.TENT1, 
					"@DONGIA1",  _VPTemp.DONGIA1, 
					"@GIAKK1",  _VPTemp.GIAKK1, 
					"@CTY2",  _VPTemp.CTY2, 
					"@TENT2",  _VPTemp.TENT2, 
					"@DONGIA2",  _VPTemp.DONGIA2, 
					"@GIAKK2",  _VPTemp.GIAKK2, 
					"@CTY3",  _VPTemp.CTY3, 
					"@TENT3",  _VPTemp.TENT3, 
					"@DONGIA3",  _VPTemp.DONGIA3, 
					"@GIAKK3",  _VPTemp.GIAKK3, 
					"@Note",  _VPTemp.Note, 
					"@ID", _VPTemp.ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VPTemp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VPTemp> _VPTemps)
		{
			foreach (VPTemp item in _VPTemps)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VPTemp vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VPTemp _VPTemp, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VPTemp] SET ID=@ID, GroupId=@GroupId, STTTN=@STTTN, STTTT=@STTTT, MaThuoc=@MaThuoc, HoatChat=@HoatChat, BietDuoc=@BietDuoc, NongDo=@NongDo, BaoChe=@BaoChe, TrinhBay=@TrinhBay, DuongDung=@DuongDung, DVT=@DVT, NHOM=@NHOM, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, DonGiaMin=@DonGiaMin, DonGiaMax=@DonGiaMax, CTY1=@CTY1, TENT1=@TENT1, DONGIA1=@DONGIA1, GIAKK1=@GIAKK1, CTY2=@CTY2, TENT2=@TENT2, DONGIA2=@DONGIA2, GIAKK2=@GIAKK2, CTY3=@CTY3, TENT3=@TENT3, DONGIA3=@DONGIA3, GIAKK3=@GIAKK3, Note=@Note "+ condition, 
					"@ID",  _VPTemp.ID, 
					"@GroupId",  _VPTemp.GroupId, 
					"@STTTN",  _VPTemp.STTTN, 
					"@STTTT",  _VPTemp.STTTT, 
					"@MaThuoc",  _VPTemp.MaThuoc, 
					"@HoatChat",  _VPTemp.HoatChat, 
					"@BietDuoc",  _VPTemp.BietDuoc, 
					"@NongDo",  _VPTemp.NongDo, 
					"@BaoChe",  _VPTemp.BaoChe, 
					"@TrinhBay",  _VPTemp.TrinhBay, 
					"@DuongDung",  _VPTemp.DuongDung, 
					"@DVT",  _VPTemp.DVT, 
					"@NHOM",  _VPTemp.NHOM, 
					"@SoLuong",  _VPTemp.SoLuong, 
					"@DonGia",  _VPTemp.DonGia, 
					"@ThanhTien",  _VPTemp.ThanhTien, 
					"@DonGiaMin",  _VPTemp.DonGiaMin, 
					"@DonGiaMax",  _VPTemp.DonGiaMax, 
					"@CTY1",  _VPTemp.CTY1, 
					"@TENT1",  _VPTemp.TENT1, 
					"@DONGIA1",  _VPTemp.DONGIA1, 
					"@GIAKK1",  _VPTemp.GIAKK1, 
					"@CTY2",  _VPTemp.CTY2, 
					"@TENT2",  _VPTemp.TENT2, 
					"@DONGIA2",  _VPTemp.DONGIA2, 
					"@GIAKK2",  _VPTemp.GIAKK2, 
					"@CTY3",  _VPTemp.CTY3, 
					"@TENT3",  _VPTemp.TENT3, 
					"@DONGIA3",  _VPTemp.DONGIA3, 
					"@GIAKK3",  _VPTemp.GIAKK3, 
					"@Note",  _VPTemp.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VPTemp trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String ID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VPTemp] WHERE ID=@ID",
					"@ID", ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VPTemp trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VPTemp _VPTemp)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VPTemp] WHERE ID=@ID",
					"@ID", _VPTemp.ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VPTemp trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VPTemp] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VPTemp trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VPTemp> _VPTemps)
		{
			foreach (VPTemp item in _VPTemps)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
