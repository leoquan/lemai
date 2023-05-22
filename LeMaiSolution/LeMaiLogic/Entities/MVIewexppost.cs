using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexppost:IVIewexppost
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexppost(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpPost từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpPost]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpPost] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpPost từ Database
		/// </summary>
		public List<view_ExpPost> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpPost]");
				List<view_ExpPost> items = new List<view_ExpPost>();
				view_ExpPost item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpPost();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["QuanLy"] != null && dr["QuanLy"] != DBNull.Value)
					{
						item.QuanLy = Convert.ToString(dr["QuanLy"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["MaBuuCuc"] != null && dr["MaBuuCuc"] != DBNull.Value)
					{
						item.MaBuuCuc = Convert.ToString(dr["MaBuuCuc"]);
					}
					if (dr["IDLogin"] != null && dr["IDLogin"] != DBNull.Value)
					{
						item.IDLogin = Convert.ToString(dr["IDLogin"]);
					}
					if (dr["Pass"] != null && dr["Pass"] != DBNull.Value)
					{
						item.Pass = Convert.ToString(dr["Pass"]);
					}
					if (dr["DieuPhoi"] != null && dr["DieuPhoi"] != DBNull.Value)
					{
						item.DieuPhoi = Convert.ToString(dr["DieuPhoi"]);
					}
					if (dr["NamSinh"] != null && dr["NamSinh"] != DBNull.Value)
					{
						item.NamSinh = Convert.ToInt32(dr["NamSinh"]);
					}
					if (dr["CMND"] != null && dr["CMND"] != DBNull.Value)
					{
						item.CMND = Convert.ToString(dr["CMND"]);
					}
					if (dr["NgayCap"] != null && dr["NgayCap"] != DBNull.Value)
					{
						item.NgayCap = Convert.ToDateTime(dr["NgayCap"]);
					}
					if (dr["SDTCaNhan"] != null && dr["SDTCaNhan"] != DBNull.Value)
					{
						item.SDTCaNhan = Convert.ToString(dr["SDTCaNhan"]);
					}
					if (dr["SoTaiKhoan"] != null && dr["SoTaiKhoan"] != DBNull.Value)
					{
						item.SoTaiKhoan = Convert.ToString(dr["SoTaiKhoan"]);
					}
					if (dr["NganHang"] != null && dr["NganHang"] != DBNull.Value)
					{
						item.NganHang = Convert.ToString(dr["NganHang"]);
					}
					if (dr["ThuongTru"] != null && dr["ThuongTru"] != DBNull.Value)
					{
						item.ThuongTru = Convert.ToString(dr["ThuongTru"]);
					}
					if (dr["FK_DVHC"] != null && dr["FK_DVHC"] != DBNull.Value)
					{
						item.FK_DVHC = Convert.ToInt32(dr["FK_DVHC"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["ParrentPost"] != null && dr["ParrentPost"] != DBNull.Value)
					{
						item.ParrentPost = Convert.ToString(dr["ParrentPost"]);
					}
					if (dr["ValueBlance"] != null && dr["ValueBlance"] != DBNull.Value)
					{
						item.ValueBlance = Convert.ToInt32(dr["ValueBlance"]);
					}
					if (dr["DeliveryFee"] != null && dr["DeliveryFee"] != DBNull.Value)
					{
						item.DeliveryFee = Convert.ToInt32(dr["DeliveryFee"]);
					}
					if (dr["SytemFee"] != null && dr["SytemFee"] != DBNull.Value)
					{
						item.SytemFee = Convert.ToInt32(dr["SytemFee"]);
					}
					if (dr["CodeFee"] != null && dr["CodeFee"] != DBNull.Value)
					{
						item.CodeFee = Convert.ToInt32(dr["CodeFee"]);
					}
					if (dr["CODFee"] != null && dr["CODFee"] != DBNull.Value)
					{
						item.CODFee = Convert.ToInt32(dr["CODFee"]);
					}
					if (dr["InternalDeliveryFee"] != null && dr["InternalDeliveryFee"] != DBNull.Value)
					{
						item.InternalDeliveryFee = Convert.ToInt32(dr["InternalDeliveryFee"]);
					}
					if (dr["ShipperFee"] != null && dr["ShipperFee"] != DBNull.Value)
					{
						item.ShipperFee = Convert.ToInt32(dr["ShipperFee"]);
					}
					if (dr["ValueBlanceMoney"] != null && dr["ValueBlanceMoney"] != DBNull.Value)
					{
						item.ValueBlanceMoney = Convert.ToInt32(dr["ValueBlanceMoney"]);
					}
					if (dr["ZoneCode"] != null && dr["ZoneCode"] != DBNull.Value)
					{
						item.ZoneCode = Convert.ToString(dr["ZoneCode"]);
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
		/// Lấy danh sách view_ExpPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpPost> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpPost] A "+ condition,  parameters);
				List<view_ExpPost> items = new List<view_ExpPost>();
				view_ExpPost item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpPost();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["QuanLy"] != null && dr["QuanLy"] != DBNull.Value)
					{
						item.QuanLy = Convert.ToString(dr["QuanLy"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["MaBuuCuc"] != null && dr["MaBuuCuc"] != DBNull.Value)
					{
						item.MaBuuCuc = Convert.ToString(dr["MaBuuCuc"]);
					}
					if (dr["IDLogin"] != null && dr["IDLogin"] != DBNull.Value)
					{
						item.IDLogin = Convert.ToString(dr["IDLogin"]);
					}
					if (dr["Pass"] != null && dr["Pass"] != DBNull.Value)
					{
						item.Pass = Convert.ToString(dr["Pass"]);
					}
					if (dr["DieuPhoi"] != null && dr["DieuPhoi"] != DBNull.Value)
					{
						item.DieuPhoi = Convert.ToString(dr["DieuPhoi"]);
					}
					if (dr["NamSinh"] != null && dr["NamSinh"] != DBNull.Value)
					{
						item.NamSinh = Convert.ToInt32(dr["NamSinh"]);
					}
					if (dr["CMND"] != null && dr["CMND"] != DBNull.Value)
					{
						item.CMND = Convert.ToString(dr["CMND"]);
					}
					if (dr["NgayCap"] != null && dr["NgayCap"] != DBNull.Value)
					{
						item.NgayCap = Convert.ToDateTime(dr["NgayCap"]);
					}
					if (dr["SDTCaNhan"] != null && dr["SDTCaNhan"] != DBNull.Value)
					{
						item.SDTCaNhan = Convert.ToString(dr["SDTCaNhan"]);
					}
					if (dr["SoTaiKhoan"] != null && dr["SoTaiKhoan"] != DBNull.Value)
					{
						item.SoTaiKhoan = Convert.ToString(dr["SoTaiKhoan"]);
					}
					if (dr["NganHang"] != null && dr["NganHang"] != DBNull.Value)
					{
						item.NganHang = Convert.ToString(dr["NganHang"]);
					}
					if (dr["ThuongTru"] != null && dr["ThuongTru"] != DBNull.Value)
					{
						item.ThuongTru = Convert.ToString(dr["ThuongTru"]);
					}
					if (dr["FK_DVHC"] != null && dr["FK_DVHC"] != DBNull.Value)
					{
						item.FK_DVHC = Convert.ToInt32(dr["FK_DVHC"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["ParrentPost"] != null && dr["ParrentPost"] != DBNull.Value)
					{
						item.ParrentPost = Convert.ToString(dr["ParrentPost"]);
					}
					if (dr["ValueBlance"] != null && dr["ValueBlance"] != DBNull.Value)
					{
						item.ValueBlance = Convert.ToInt32(dr["ValueBlance"]);
					}
					if (dr["DeliveryFee"] != null && dr["DeliveryFee"] != DBNull.Value)
					{
						item.DeliveryFee = Convert.ToInt32(dr["DeliveryFee"]);
					}
					if (dr["SytemFee"] != null && dr["SytemFee"] != DBNull.Value)
					{
						item.SytemFee = Convert.ToInt32(dr["SytemFee"]);
					}
					if (dr["CodeFee"] != null && dr["CodeFee"] != DBNull.Value)
					{
						item.CodeFee = Convert.ToInt32(dr["CodeFee"]);
					}
					if (dr["CODFee"] != null && dr["CODFee"] != DBNull.Value)
					{
						item.CODFee = Convert.ToInt32(dr["CODFee"]);
					}
					if (dr["InternalDeliveryFee"] != null && dr["InternalDeliveryFee"] != DBNull.Value)
					{
						item.InternalDeliveryFee = Convert.ToInt32(dr["InternalDeliveryFee"]);
					}
					if (dr["ShipperFee"] != null && dr["ShipperFee"] != DBNull.Value)
					{
						item.ShipperFee = Convert.ToInt32(dr["ShipperFee"]);
					}
					if (dr["ValueBlanceMoney"] != null && dr["ValueBlanceMoney"] != DBNull.Value)
					{
						item.ValueBlanceMoney = Convert.ToInt32(dr["ValueBlanceMoney"]);
					}
					if (dr["ZoneCode"] != null && dr["ZoneCode"] != DBNull.Value)
					{
						item.ZoneCode = Convert.ToString(dr["ZoneCode"]);
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

		public List<view_ExpPost> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpPost] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpPost] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpPost>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpPost đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpPost GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpPost] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpPost item=new view_ExpPost();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
						{
							item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["QuanLy"] != null && dr["QuanLy"] != DBNull.Value)
						{
							item.QuanLy = Convert.ToString(dr["QuanLy"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["MaBuuCuc"] != null && dr["MaBuuCuc"] != DBNull.Value)
						{
							item.MaBuuCuc = Convert.ToString(dr["MaBuuCuc"]);
						}
						if (dr["IDLogin"] != null && dr["IDLogin"] != DBNull.Value)
						{
							item.IDLogin = Convert.ToString(dr["IDLogin"]);
						}
						if (dr["Pass"] != null && dr["Pass"] != DBNull.Value)
						{
							item.Pass = Convert.ToString(dr["Pass"]);
						}
						if (dr["DieuPhoi"] != null && dr["DieuPhoi"] != DBNull.Value)
						{
							item.DieuPhoi = Convert.ToString(dr["DieuPhoi"]);
						}
						if (dr["NamSinh"] != null && dr["NamSinh"] != DBNull.Value)
						{
							item.NamSinh = Convert.ToInt32(dr["NamSinh"]);
						}
						if (dr["CMND"] != null && dr["CMND"] != DBNull.Value)
						{
							item.CMND = Convert.ToString(dr["CMND"]);
						}
						if (dr["NgayCap"] != null && dr["NgayCap"] != DBNull.Value)
						{
							item.NgayCap = Convert.ToDateTime(dr["NgayCap"]);
						}
						if (dr["SDTCaNhan"] != null && dr["SDTCaNhan"] != DBNull.Value)
						{
							item.SDTCaNhan = Convert.ToString(dr["SDTCaNhan"]);
						}
						if (dr["SoTaiKhoan"] != null && dr["SoTaiKhoan"] != DBNull.Value)
						{
							item.SoTaiKhoan = Convert.ToString(dr["SoTaiKhoan"]);
						}
						if (dr["NganHang"] != null && dr["NganHang"] != DBNull.Value)
						{
							item.NganHang = Convert.ToString(dr["NganHang"]);
						}
						if (dr["ThuongTru"] != null && dr["ThuongTru"] != DBNull.Value)
						{
							item.ThuongTru = Convert.ToString(dr["ThuongTru"]);
						}
						if (dr["FK_DVHC"] != null && dr["FK_DVHC"] != DBNull.Value)
						{
							item.FK_DVHC = Convert.ToInt32(dr["FK_DVHC"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
						}
						if (dr["ParrentPost"] != null && dr["ParrentPost"] != DBNull.Value)
						{
							item.ParrentPost = Convert.ToString(dr["ParrentPost"]);
						}
						if (dr["ValueBlance"] != null && dr["ValueBlance"] != DBNull.Value)
						{
							item.ValueBlance = Convert.ToInt32(dr["ValueBlance"]);
						}
						if (dr["DeliveryFee"] != null && dr["DeliveryFee"] != DBNull.Value)
						{
							item.DeliveryFee = Convert.ToInt32(dr["DeliveryFee"]);
						}
						if (dr["SytemFee"] != null && dr["SytemFee"] != DBNull.Value)
						{
							item.SytemFee = Convert.ToInt32(dr["SytemFee"]);
						}
						if (dr["CodeFee"] != null && dr["CodeFee"] != DBNull.Value)
						{
							item.CodeFee = Convert.ToInt32(dr["CodeFee"]);
						}
						if (dr["CODFee"] != null && dr["CODFee"] != DBNull.Value)
						{
							item.CODFee = Convert.ToInt32(dr["CODFee"]);
						}
						if (dr["InternalDeliveryFee"] != null && dr["InternalDeliveryFee"] != DBNull.Value)
						{
							item.InternalDeliveryFee = Convert.ToInt32(dr["InternalDeliveryFee"]);
						}
						if (dr["ShipperFee"] != null && dr["ShipperFee"] != DBNull.Value)
						{
							item.ShipperFee = Convert.ToInt32(dr["ShipperFee"]);
						}
						if (dr["ValueBlanceMoney"] != null && dr["ValueBlanceMoney"] != DBNull.Value)
						{
							item.ValueBlanceMoney = Convert.ToInt32(dr["ValueBlanceMoney"]);
						}
						if (dr["ZoneCode"] != null && dr["ZoneCode"] != DBNull.Value)
						{
							item.ZoneCode = Convert.ToString(dr["ZoneCode"]);
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

		public view_ExpPost GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpPost] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpPost>(ds);
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
