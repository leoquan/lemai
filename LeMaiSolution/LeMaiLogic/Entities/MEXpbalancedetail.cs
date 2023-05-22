using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpbalancedetail:IEXpbalancedetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpbalancedetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpBalanceDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBalanceDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBalanceDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpBalanceDetail từ Database
		/// </summary>
		public List<ExpBalanceDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBalanceDetail]");
				List<ExpBalanceDetail> items = new List<ExpBalanceDetail>();
				ExpBalanceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpBalanceDetail();
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
		/// Lấy danh sách ExpBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpBalanceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpBalanceDetail] A "+ condition,  parameters);
				List<ExpBalanceDetail> items = new List<ExpBalanceDetail>();
				ExpBalanceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpBalanceDetail();
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<ExpBalanceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpBalanceDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpBalanceDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpBalanceDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpBalanceDetail từ Database
		/// </summary>
		public ExpBalanceDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBalanceDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpBalanceDetail item=new ExpBalanceDetail();
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
		/// Lấy một ExpBalanceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpBalanceDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpBalanceDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpBalanceDetail item=new ExpBalanceDetail();
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

		public ExpBalanceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpBalanceDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpBalanceDetail>(ds);
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
		/// Thêm mới ExpBalanceDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpBalanceDetail _ExpBalanceDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpBalanceDetail](Id, BILL_CODE, CapDoDaiLy, TrucThuocDaiLy, ThoiGianDatHang, ThoiGianKetToan, KeyThoiGianKetToan, MaDaiLy, TenDaiLy, MaChiPhi, TenChiPhi, LoaiThu, SoDuTruoc, SoTien, SoDuSau, LoaiTaiKhoan, TrongLuongThanhToan, SyncDate) VALUES(@Id, @BILL_CODE, @CapDoDaiLy, @TrucThuocDaiLy, @ThoiGianDatHang, @ThoiGianKetToan, @KeyThoiGianKetToan, @MaDaiLy, @TenDaiLy, @MaChiPhi, @TenChiPhi, @LoaiThu, @SoDuTruoc, @SoTien, @SoDuSau, @LoaiTaiKhoan, @TrongLuongThanhToan, @SyncDate)", 
					"@Id",  _ExpBalanceDetail.Id, 
					"@BILL_CODE",  _ExpBalanceDetail.BILL_CODE, 
					"@CapDoDaiLy",  _ExpBalanceDetail.CapDoDaiLy, 
					"@TrucThuocDaiLy",  _ExpBalanceDetail.TrucThuocDaiLy, 
					"@ThoiGianDatHang", this._dataContext.ConvertDateString( _ExpBalanceDetail.ThoiGianDatHang), 
					"@ThoiGianKetToan", this._dataContext.ConvertDateString( _ExpBalanceDetail.ThoiGianKetToan), 
					"@KeyThoiGianKetToan",  _ExpBalanceDetail.KeyThoiGianKetToan, 
					"@MaDaiLy",  _ExpBalanceDetail.MaDaiLy, 
					"@TenDaiLy",  _ExpBalanceDetail.TenDaiLy, 
					"@MaChiPhi",  _ExpBalanceDetail.MaChiPhi, 
					"@TenChiPhi",  _ExpBalanceDetail.TenChiPhi, 
					"@LoaiThu",  _ExpBalanceDetail.LoaiThu, 
					"@SoDuTruoc",  _ExpBalanceDetail.SoDuTruoc, 
					"@SoTien",  _ExpBalanceDetail.SoTien, 
					"@SoDuSau",  _ExpBalanceDetail.SoDuSau, 
					"@LoaiTaiKhoan",  _ExpBalanceDetail.LoaiTaiKhoan, 
					"@TrongLuongThanhToan",  _ExpBalanceDetail.TrongLuongThanhToan, 
					"@SyncDate", this._dataContext.ConvertDateString( _ExpBalanceDetail.SyncDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpBalanceDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpBalanceDetail> _ExpBalanceDetails)
		{
			foreach (ExpBalanceDetail item in _ExpBalanceDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpBalanceDetail _ExpBalanceDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBalanceDetail] SET Id=@Id, BILL_CODE=@BILL_CODE, CapDoDaiLy=@CapDoDaiLy, TrucThuocDaiLy=@TrucThuocDaiLy, ThoiGianDatHang=@ThoiGianDatHang, ThoiGianKetToan=@ThoiGianKetToan, KeyThoiGianKetToan=@KeyThoiGianKetToan, MaDaiLy=@MaDaiLy, TenDaiLy=@TenDaiLy, MaChiPhi=@MaChiPhi, TenChiPhi=@TenChiPhi, LoaiThu=@LoaiThu, SoDuTruoc=@SoDuTruoc, SoTien=@SoTien, SoDuSau=@SoDuSau, LoaiTaiKhoan=@LoaiTaiKhoan, TrongLuongThanhToan=@TrongLuongThanhToan, SyncDate=@SyncDate WHERE Id=@Id", 
					"@Id",  _ExpBalanceDetail.Id, 
					"@BILL_CODE",  _ExpBalanceDetail.BILL_CODE, 
					"@CapDoDaiLy",  _ExpBalanceDetail.CapDoDaiLy, 
					"@TrucThuocDaiLy",  _ExpBalanceDetail.TrucThuocDaiLy, 
					"@ThoiGianDatHang", this._dataContext.ConvertDateString( _ExpBalanceDetail.ThoiGianDatHang), 
					"@ThoiGianKetToan", this._dataContext.ConvertDateString( _ExpBalanceDetail.ThoiGianKetToan), 
					"@KeyThoiGianKetToan",  _ExpBalanceDetail.KeyThoiGianKetToan, 
					"@MaDaiLy",  _ExpBalanceDetail.MaDaiLy, 
					"@TenDaiLy",  _ExpBalanceDetail.TenDaiLy, 
					"@MaChiPhi",  _ExpBalanceDetail.MaChiPhi, 
					"@TenChiPhi",  _ExpBalanceDetail.TenChiPhi, 
					"@LoaiThu",  _ExpBalanceDetail.LoaiThu, 
					"@SoDuTruoc",  _ExpBalanceDetail.SoDuTruoc, 
					"@SoTien",  _ExpBalanceDetail.SoTien, 
					"@SoDuSau",  _ExpBalanceDetail.SoDuSau, 
					"@LoaiTaiKhoan",  _ExpBalanceDetail.LoaiTaiKhoan, 
					"@TrongLuongThanhToan",  _ExpBalanceDetail.TrongLuongThanhToan, 
					"@SyncDate", this._dataContext.ConvertDateString( _ExpBalanceDetail.SyncDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpBalanceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpBalanceDetail _ExpBalanceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBalanceDetail] SET BILL_CODE=@BILL_CODE, CapDoDaiLy=@CapDoDaiLy, TrucThuocDaiLy=@TrucThuocDaiLy, ThoiGianDatHang=@ThoiGianDatHang, ThoiGianKetToan=@ThoiGianKetToan, KeyThoiGianKetToan=@KeyThoiGianKetToan, MaDaiLy=@MaDaiLy, TenDaiLy=@TenDaiLy, MaChiPhi=@MaChiPhi, TenChiPhi=@TenChiPhi, LoaiThu=@LoaiThu, SoDuTruoc=@SoDuTruoc, SoTien=@SoTien, SoDuSau=@SoDuSau, LoaiTaiKhoan=@LoaiTaiKhoan, TrongLuongThanhToan=@TrongLuongThanhToan, SyncDate=@SyncDate WHERE Id=@Id", 
					"@BILL_CODE",  _ExpBalanceDetail.BILL_CODE, 
					"@CapDoDaiLy",  _ExpBalanceDetail.CapDoDaiLy, 
					"@TrucThuocDaiLy",  _ExpBalanceDetail.TrucThuocDaiLy, 
					"@ThoiGianDatHang", this._dataContext.ConvertDateString( _ExpBalanceDetail.ThoiGianDatHang), 
					"@ThoiGianKetToan", this._dataContext.ConvertDateString( _ExpBalanceDetail.ThoiGianKetToan), 
					"@KeyThoiGianKetToan",  _ExpBalanceDetail.KeyThoiGianKetToan, 
					"@MaDaiLy",  _ExpBalanceDetail.MaDaiLy, 
					"@TenDaiLy",  _ExpBalanceDetail.TenDaiLy, 
					"@MaChiPhi",  _ExpBalanceDetail.MaChiPhi, 
					"@TenChiPhi",  _ExpBalanceDetail.TenChiPhi, 
					"@LoaiThu",  _ExpBalanceDetail.LoaiThu, 
					"@SoDuTruoc",  _ExpBalanceDetail.SoDuTruoc, 
					"@SoTien",  _ExpBalanceDetail.SoTien, 
					"@SoDuSau",  _ExpBalanceDetail.SoDuSau, 
					"@LoaiTaiKhoan",  _ExpBalanceDetail.LoaiTaiKhoan, 
					"@TrongLuongThanhToan",  _ExpBalanceDetail.TrongLuongThanhToan, 
					"@SyncDate", this._dataContext.ConvertDateString( _ExpBalanceDetail.SyncDate), 
					"@Id", _ExpBalanceDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpBalanceDetail> _ExpBalanceDetails)
		{
			foreach (ExpBalanceDetail item in _ExpBalanceDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpBalanceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpBalanceDetail _ExpBalanceDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBalanceDetail] SET Id=@Id, BILL_CODE=@BILL_CODE, CapDoDaiLy=@CapDoDaiLy, TrucThuocDaiLy=@TrucThuocDaiLy, ThoiGianDatHang=@ThoiGianDatHang, ThoiGianKetToan=@ThoiGianKetToan, KeyThoiGianKetToan=@KeyThoiGianKetToan, MaDaiLy=@MaDaiLy, TenDaiLy=@TenDaiLy, MaChiPhi=@MaChiPhi, TenChiPhi=@TenChiPhi, LoaiThu=@LoaiThu, SoDuTruoc=@SoDuTruoc, SoTien=@SoTien, SoDuSau=@SoDuSau, LoaiTaiKhoan=@LoaiTaiKhoan, TrongLuongThanhToan=@TrongLuongThanhToan, SyncDate=@SyncDate "+ condition, 
					"@Id",  _ExpBalanceDetail.Id, 
					"@BILL_CODE",  _ExpBalanceDetail.BILL_CODE, 
					"@CapDoDaiLy",  _ExpBalanceDetail.CapDoDaiLy, 
					"@TrucThuocDaiLy",  _ExpBalanceDetail.TrucThuocDaiLy, 
					"@ThoiGianDatHang", this._dataContext.ConvertDateString( _ExpBalanceDetail.ThoiGianDatHang), 
					"@ThoiGianKetToan", this._dataContext.ConvertDateString( _ExpBalanceDetail.ThoiGianKetToan), 
					"@KeyThoiGianKetToan",  _ExpBalanceDetail.KeyThoiGianKetToan, 
					"@MaDaiLy",  _ExpBalanceDetail.MaDaiLy, 
					"@TenDaiLy",  _ExpBalanceDetail.TenDaiLy, 
					"@MaChiPhi",  _ExpBalanceDetail.MaChiPhi, 
					"@TenChiPhi",  _ExpBalanceDetail.TenChiPhi, 
					"@LoaiThu",  _ExpBalanceDetail.LoaiThu, 
					"@SoDuTruoc",  _ExpBalanceDetail.SoDuTruoc, 
					"@SoTien",  _ExpBalanceDetail.SoTien, 
					"@SoDuSau",  _ExpBalanceDetail.SoDuSau, 
					"@LoaiTaiKhoan",  _ExpBalanceDetail.LoaiTaiKhoan, 
					"@TrongLuongThanhToan",  _ExpBalanceDetail.TrongLuongThanhToan, 
					"@SyncDate", this._dataContext.ConvertDateString( _ExpBalanceDetail.SyncDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpBalanceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBalanceDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBalanceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpBalanceDetail _ExpBalanceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBalanceDetail] WHERE Id=@Id",
					"@Id", _ExpBalanceDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBalanceDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBalanceDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBalanceDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpBalanceDetail> _ExpBalanceDetails)
		{
			foreach (ExpBalanceDetail item in _ExpBalanceDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
