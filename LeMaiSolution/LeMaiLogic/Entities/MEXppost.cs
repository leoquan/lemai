using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXppost:IEXppost
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXppost(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpPost từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPost]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPost] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpPost từ Database
		/// </summary>
		public List<ExpPost> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPost]");
				List<ExpPost> items = new List<ExpPost>();
				ExpPost item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpPost();
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
					if (dr["WebsiteCheckBill"] != null && dr["WebsiteCheckBill"] != DBNull.Value)
					{
						item.WebsiteCheckBill = Convert.ToString(dr["WebsiteCheckBill"]);
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
		/// Lấy danh sách ExpPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpPost> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpPost] A "+ condition,  parameters);
				List<ExpPost> items = new List<ExpPost>();
				ExpPost item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpPost();
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
					if (dr["WebsiteCheckBill"] != null && dr["WebsiteCheckBill"] != DBNull.Value)
					{
						item.WebsiteCheckBill = Convert.ToString(dr["WebsiteCheckBill"]);
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

		public List<ExpPost> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpPost] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpPost] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpPost>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpPost từ Database
		/// </summary>
		public ExpPost GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPost] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpPost item=new ExpPost();
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
						if (dr["WebsiteCheckBill"] != null && dr["WebsiteCheckBill"] != DBNull.Value)
						{
							item.WebsiteCheckBill = Convert.ToString(dr["WebsiteCheckBill"]);
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
		/// Lấy một ExpPost đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpPost GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpPost] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpPost item=new ExpPost();
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
						if (dr["WebsiteCheckBill"] != null && dr["WebsiteCheckBill"] != DBNull.Value)
						{
							item.WebsiteCheckBill = Convert.ToString(dr["WebsiteCheckBill"]);
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

		public ExpPost GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpPost] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpPost>(ds);
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
		/// Thêm mới ExpPost vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpPost _ExpPost)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpPost](Id, Code, TenDaiLy, Phone, DiaChi, Email, QuanLy, SoDienThoai, MaBuuCuc, IDLogin, Pass, DieuPhoi, NamSinh, CMND, NgayCap, SDTCaNhan, SoTaiKhoan, NganHang, ThuongTru, FK_DVHC, CreateBy, CreateDate, GoogleMap, ParrentPost, ValueBlance, DeliveryFee, SytemFee, CodeFee, CODFee, InternalDeliveryFee, ShipperFee, ValueBlanceMoney, ZoneCode, WebsiteCheckBill) VALUES(@Id, @Code, @TenDaiLy, @Phone, @DiaChi, @Email, @QuanLy, @SoDienThoai, @MaBuuCuc, @IDLogin, @Pass, @DieuPhoi, @NamSinh, @CMND, @NgayCap, @SDTCaNhan, @SoTaiKhoan, @NganHang, @ThuongTru, @FK_DVHC, @CreateBy, @CreateDate, @GoogleMap, @ParrentPost, @ValueBlance, @DeliveryFee, @SytemFee, @CodeFee, @CODFee, @InternalDeliveryFee, @ShipperFee, @ValueBlanceMoney, @ZoneCode, @WebsiteCheckBill)", 
					"@Id",  _ExpPost.Id, 
					"@Code",  _ExpPost.Code, 
					"@TenDaiLy",  _ExpPost.TenDaiLy, 
					"@Phone",  _ExpPost.Phone, 
					"@DiaChi",  _ExpPost.DiaChi, 
					"@Email",  _ExpPost.Email, 
					"@QuanLy",  _ExpPost.QuanLy, 
					"@SoDienThoai",  _ExpPost.SoDienThoai, 
					"@MaBuuCuc",  _ExpPost.MaBuuCuc, 
					"@IDLogin",  _ExpPost.IDLogin, 
					"@Pass",  _ExpPost.Pass, 
					"@DieuPhoi",  _ExpPost.DieuPhoi, 
					"@NamSinh",  _ExpPost.NamSinh, 
					"@CMND",  _ExpPost.CMND, 
					"@NgayCap", this._dataContext.ConvertDateString( _ExpPost.NgayCap), 
					"@SDTCaNhan",  _ExpPost.SDTCaNhan, 
					"@SoTaiKhoan",  _ExpPost.SoTaiKhoan, 
					"@NganHang",  _ExpPost.NganHang, 
					"@ThuongTru",  _ExpPost.ThuongTru, 
					"@FK_DVHC",  _ExpPost.FK_DVHC, 
					"@CreateBy",  _ExpPost.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPost.CreateDate), 
					"@GoogleMap",  _ExpPost.GoogleMap, 
					"@ParrentPost",  _ExpPost.ParrentPost, 
					"@ValueBlance",  _ExpPost.ValueBlance, 
					"@DeliveryFee",  _ExpPost.DeliveryFee, 
					"@SytemFee",  _ExpPost.SytemFee, 
					"@CodeFee",  _ExpPost.CodeFee, 
					"@CODFee",  _ExpPost.CODFee, 
					"@InternalDeliveryFee",  _ExpPost.InternalDeliveryFee, 
					"@ShipperFee",  _ExpPost.ShipperFee, 
					"@ValueBlanceMoney",  _ExpPost.ValueBlanceMoney, 
					"@ZoneCode",  _ExpPost.ZoneCode, 
					"@WebsiteCheckBill",  _ExpPost.WebsiteCheckBill);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpPost vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpPost> _ExpPosts)
		{
			foreach (ExpPost item in _ExpPosts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpPost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpPost _ExpPost, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPost] SET Id=@Id, Code=@Code, TenDaiLy=@TenDaiLy, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, QuanLy=@QuanLy, SoDienThoai=@SoDienThoai, MaBuuCuc=@MaBuuCuc, IDLogin=@IDLogin, Pass=@Pass, DieuPhoi=@DieuPhoi, NamSinh=@NamSinh, CMND=@CMND, NgayCap=@NgayCap, SDTCaNhan=@SDTCaNhan, SoTaiKhoan=@SoTaiKhoan, NganHang=@NganHang, ThuongTru=@ThuongTru, FK_DVHC=@FK_DVHC, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, ParrentPost=@ParrentPost, ValueBlance=@ValueBlance, DeliveryFee=@DeliveryFee, SytemFee=@SytemFee, CodeFee=@CodeFee, CODFee=@CODFee, InternalDeliveryFee=@InternalDeliveryFee, ShipperFee=@ShipperFee, ValueBlanceMoney=@ValueBlanceMoney, ZoneCode=@ZoneCode, WebsiteCheckBill=@WebsiteCheckBill WHERE Id=@Id", 
					"@Id",  _ExpPost.Id, 
					"@Code",  _ExpPost.Code, 
					"@TenDaiLy",  _ExpPost.TenDaiLy, 
					"@Phone",  _ExpPost.Phone, 
					"@DiaChi",  _ExpPost.DiaChi, 
					"@Email",  _ExpPost.Email, 
					"@QuanLy",  _ExpPost.QuanLy, 
					"@SoDienThoai",  _ExpPost.SoDienThoai, 
					"@MaBuuCuc",  _ExpPost.MaBuuCuc, 
					"@IDLogin",  _ExpPost.IDLogin, 
					"@Pass",  _ExpPost.Pass, 
					"@DieuPhoi",  _ExpPost.DieuPhoi, 
					"@NamSinh",  _ExpPost.NamSinh, 
					"@CMND",  _ExpPost.CMND, 
					"@NgayCap", this._dataContext.ConvertDateString( _ExpPost.NgayCap), 
					"@SDTCaNhan",  _ExpPost.SDTCaNhan, 
					"@SoTaiKhoan",  _ExpPost.SoTaiKhoan, 
					"@NganHang",  _ExpPost.NganHang, 
					"@ThuongTru",  _ExpPost.ThuongTru, 
					"@FK_DVHC",  _ExpPost.FK_DVHC, 
					"@CreateBy",  _ExpPost.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPost.CreateDate), 
					"@GoogleMap",  _ExpPost.GoogleMap, 
					"@ParrentPost",  _ExpPost.ParrentPost, 
					"@ValueBlance",  _ExpPost.ValueBlance, 
					"@DeliveryFee",  _ExpPost.DeliveryFee, 
					"@SytemFee",  _ExpPost.SytemFee, 
					"@CodeFee",  _ExpPost.CodeFee, 
					"@CODFee",  _ExpPost.CODFee, 
					"@InternalDeliveryFee",  _ExpPost.InternalDeliveryFee, 
					"@ShipperFee",  _ExpPost.ShipperFee, 
					"@ValueBlanceMoney",  _ExpPost.ValueBlanceMoney, 
					"@ZoneCode",  _ExpPost.ZoneCode, 
					"@WebsiteCheckBill",  _ExpPost.WebsiteCheckBill, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpPost vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpPost _ExpPost)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPost] SET Code=@Code, TenDaiLy=@TenDaiLy, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, QuanLy=@QuanLy, SoDienThoai=@SoDienThoai, MaBuuCuc=@MaBuuCuc, IDLogin=@IDLogin, Pass=@Pass, DieuPhoi=@DieuPhoi, NamSinh=@NamSinh, CMND=@CMND, NgayCap=@NgayCap, SDTCaNhan=@SDTCaNhan, SoTaiKhoan=@SoTaiKhoan, NganHang=@NganHang, ThuongTru=@ThuongTru, FK_DVHC=@FK_DVHC, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, ParrentPost=@ParrentPost, ValueBlance=@ValueBlance, DeliveryFee=@DeliveryFee, SytemFee=@SytemFee, CodeFee=@CodeFee, CODFee=@CODFee, InternalDeliveryFee=@InternalDeliveryFee, ShipperFee=@ShipperFee, ValueBlanceMoney=@ValueBlanceMoney, ZoneCode=@ZoneCode, WebsiteCheckBill=@WebsiteCheckBill WHERE Id=@Id", 
					"@Code",  _ExpPost.Code, 
					"@TenDaiLy",  _ExpPost.TenDaiLy, 
					"@Phone",  _ExpPost.Phone, 
					"@DiaChi",  _ExpPost.DiaChi, 
					"@Email",  _ExpPost.Email, 
					"@QuanLy",  _ExpPost.QuanLy, 
					"@SoDienThoai",  _ExpPost.SoDienThoai, 
					"@MaBuuCuc",  _ExpPost.MaBuuCuc, 
					"@IDLogin",  _ExpPost.IDLogin, 
					"@Pass",  _ExpPost.Pass, 
					"@DieuPhoi",  _ExpPost.DieuPhoi, 
					"@NamSinh",  _ExpPost.NamSinh, 
					"@CMND",  _ExpPost.CMND, 
					"@NgayCap", this._dataContext.ConvertDateString( _ExpPost.NgayCap), 
					"@SDTCaNhan",  _ExpPost.SDTCaNhan, 
					"@SoTaiKhoan",  _ExpPost.SoTaiKhoan, 
					"@NganHang",  _ExpPost.NganHang, 
					"@ThuongTru",  _ExpPost.ThuongTru, 
					"@FK_DVHC",  _ExpPost.FK_DVHC, 
					"@CreateBy",  _ExpPost.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPost.CreateDate), 
					"@GoogleMap",  _ExpPost.GoogleMap, 
					"@ParrentPost",  _ExpPost.ParrentPost, 
					"@ValueBlance",  _ExpPost.ValueBlance, 
					"@DeliveryFee",  _ExpPost.DeliveryFee, 
					"@SytemFee",  _ExpPost.SytemFee, 
					"@CodeFee",  _ExpPost.CodeFee, 
					"@CODFee",  _ExpPost.CODFee, 
					"@InternalDeliveryFee",  _ExpPost.InternalDeliveryFee, 
					"@ShipperFee",  _ExpPost.ShipperFee, 
					"@ValueBlanceMoney",  _ExpPost.ValueBlanceMoney, 
					"@ZoneCode",  _ExpPost.ZoneCode, 
					"@WebsiteCheckBill",  _ExpPost.WebsiteCheckBill, 
					"@Id", _ExpPost.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpPost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpPost> _ExpPosts)
		{
			foreach (ExpPost item in _ExpPosts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpPost vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpPost _ExpPost, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPost] SET Id=@Id, Code=@Code, TenDaiLy=@TenDaiLy, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, QuanLy=@QuanLy, SoDienThoai=@SoDienThoai, MaBuuCuc=@MaBuuCuc, IDLogin=@IDLogin, Pass=@Pass, DieuPhoi=@DieuPhoi, NamSinh=@NamSinh, CMND=@CMND, NgayCap=@NgayCap, SDTCaNhan=@SDTCaNhan, SoTaiKhoan=@SoTaiKhoan, NganHang=@NganHang, ThuongTru=@ThuongTru, FK_DVHC=@FK_DVHC, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, ParrentPost=@ParrentPost, ValueBlance=@ValueBlance, DeliveryFee=@DeliveryFee, SytemFee=@SytemFee, CodeFee=@CodeFee, CODFee=@CODFee, InternalDeliveryFee=@InternalDeliveryFee, ShipperFee=@ShipperFee, ValueBlanceMoney=@ValueBlanceMoney, ZoneCode=@ZoneCode, WebsiteCheckBill=@WebsiteCheckBill "+ condition, 
					"@Id",  _ExpPost.Id, 
					"@Code",  _ExpPost.Code, 
					"@TenDaiLy",  _ExpPost.TenDaiLy, 
					"@Phone",  _ExpPost.Phone, 
					"@DiaChi",  _ExpPost.DiaChi, 
					"@Email",  _ExpPost.Email, 
					"@QuanLy",  _ExpPost.QuanLy, 
					"@SoDienThoai",  _ExpPost.SoDienThoai, 
					"@MaBuuCuc",  _ExpPost.MaBuuCuc, 
					"@IDLogin",  _ExpPost.IDLogin, 
					"@Pass",  _ExpPost.Pass, 
					"@DieuPhoi",  _ExpPost.DieuPhoi, 
					"@NamSinh",  _ExpPost.NamSinh, 
					"@CMND",  _ExpPost.CMND, 
					"@NgayCap", this._dataContext.ConvertDateString( _ExpPost.NgayCap), 
					"@SDTCaNhan",  _ExpPost.SDTCaNhan, 
					"@SoTaiKhoan",  _ExpPost.SoTaiKhoan, 
					"@NganHang",  _ExpPost.NganHang, 
					"@ThuongTru",  _ExpPost.ThuongTru, 
					"@FK_DVHC",  _ExpPost.FK_DVHC, 
					"@CreateBy",  _ExpPost.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPost.CreateDate), 
					"@GoogleMap",  _ExpPost.GoogleMap, 
					"@ParrentPost",  _ExpPost.ParrentPost, 
					"@ValueBlance",  _ExpPost.ValueBlance, 
					"@DeliveryFee",  _ExpPost.DeliveryFee, 
					"@SytemFee",  _ExpPost.SytemFee, 
					"@CodeFee",  _ExpPost.CodeFee, 
					"@CODFee",  _ExpPost.CODFee, 
					"@InternalDeliveryFee",  _ExpPost.InternalDeliveryFee, 
					"@ShipperFee",  _ExpPost.ShipperFee, 
					"@ValueBlanceMoney",  _ExpPost.ValueBlanceMoney, 
					"@ZoneCode",  _ExpPost.ZoneCode, 
					"@WebsiteCheckBill",  _ExpPost.WebsiteCheckBill);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpPost trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPost] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPost trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpPost _ExpPost)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPost] WHERE Id=@Id",
					"@Id", _ExpPost.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPost trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPost] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPost trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpPost> _ExpPosts)
		{
			foreach (ExpPost item in _ExpPosts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
