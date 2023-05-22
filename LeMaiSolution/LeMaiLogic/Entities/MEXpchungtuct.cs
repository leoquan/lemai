using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpchungtuct:IEXpchungtuct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpchungtuct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpChungTuCt từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpChungTuCt]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpChungTuCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpChungTuCt] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpChungTuCt từ Database
		/// </summary>
		public List<ExpChungTuCt> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpChungTuCt]");
				List<ExpChungTuCt> items = new List<ExpChungTuCt>();
				ExpChungTuCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpChungTuCt();
					if (dr["FK_ExpChungTu"] != null && dr["FK_ExpChungTu"] != DBNull.Value)
					{
						item.FK_ExpChungTu = Convert.ToString(dr["FK_ExpChungTu"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["SoTienPhaiThu"] != null && dr["SoTienPhaiThu"] != DBNull.Value)
					{
						item.SoTienPhaiThu = Convert.ToDecimal(dr["SoTienPhaiThu"]);
					}
					if (dr["SoTienPhaiChi"] != null && dr["SoTienPhaiChi"] != DBNull.Value)
					{
						item.SoTienPhaiChi = Convert.ToDecimal(dr["SoTienPhaiChi"]);
					}
					if (dr["TenNguoiNhan"] != null && dr["TenNguoiNhan"] != DBNull.Value)
					{
						item.TenNguoiNhan = Convert.ToString(dr["TenNguoiNhan"]);
					}
					if (dr["SoDienThoaiNhan"] != null && dr["SoDienThoaiNhan"] != DBNull.Value)
					{
						item.SoDienThoaiNhan = Convert.ToString(dr["SoDienThoaiNhan"]);
					}
					if (dr["DiaChiNhan"] != null && dr["DiaChiNhan"] != DBNull.Value)
					{
						item.DiaChiNhan = Convert.ToString(dr["DiaChiNhan"]);
					}
					if (dr["SoTienThuHo"] != null && dr["SoTienThuHo"] != DBNull.Value)
					{
						item.SoTienThuHo = Convert.ToDecimal(dr["SoTienThuHo"]);
					}
					if (dr["CuocPhiVanChuyen"] != null && dr["CuocPhiVanChuyen"] != DBNull.Value)
					{
						item.CuocPhiVanChuyen = Convert.ToDecimal(dr["CuocPhiVanChuyen"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["TrongLuong"] != null && dr["TrongLuong"] != DBNull.Value)
					{
						item.TrongLuong = Convert.ToDecimal(dr["TrongLuong"]);
					}
					if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
					{
						item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
					}
					if (dr["CuocPhiChuaGTGT"] != null && dr["CuocPhiChuaGTGT"] != DBNull.Value)
					{
						item.CuocPhiChuaGTGT = Convert.ToDecimal(dr["CuocPhiChuaGTGT"]);
					}
					if (dr["ThueGTGT"] != null && dr["ThueGTGT"] != DBNull.Value)
					{
						item.ThueGTGT = Convert.ToDecimal(dr["ThueGTGT"]);
					}
					if (dr["NgayGuiHang"] != null && dr["NgayGuiHang"] != DBNull.Value)
					{
						item.NgayGuiHang = Convert.ToDateTime(dr["NgayGuiHang"]);
					}
					if (dr["LoaiThanhToan"] != null && dr["LoaiThanhToan"] != DBNull.Value)
					{
						item.LoaiThanhToan = Convert.ToString(dr["LoaiThanhToan"]);
					}
					if (dr["GiaoHangThanhCong"] != null && dr["GiaoHangThanhCong"] != DBNull.Value)
					{
						item.GiaoHangThanhCong = Convert.ToBoolean(dr["GiaoHangThanhCong"]);
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
		/// Lấy danh sách ExpChungTuCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpChungTuCt> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpChungTuCt] A "+ condition,  parameters);
				List<ExpChungTuCt> items = new List<ExpChungTuCt>();
				ExpChungTuCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpChungTuCt();
					if (dr["FK_ExpChungTu"] != null && dr["FK_ExpChungTu"] != DBNull.Value)
					{
						item.FK_ExpChungTu = Convert.ToString(dr["FK_ExpChungTu"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["SoTienPhaiThu"] != null && dr["SoTienPhaiThu"] != DBNull.Value)
					{
						item.SoTienPhaiThu = Convert.ToDecimal(dr["SoTienPhaiThu"]);
					}
					if (dr["SoTienPhaiChi"] != null && dr["SoTienPhaiChi"] != DBNull.Value)
					{
						item.SoTienPhaiChi = Convert.ToDecimal(dr["SoTienPhaiChi"]);
					}
					if (dr["TenNguoiNhan"] != null && dr["TenNguoiNhan"] != DBNull.Value)
					{
						item.TenNguoiNhan = Convert.ToString(dr["TenNguoiNhan"]);
					}
					if (dr["SoDienThoaiNhan"] != null && dr["SoDienThoaiNhan"] != DBNull.Value)
					{
						item.SoDienThoaiNhan = Convert.ToString(dr["SoDienThoaiNhan"]);
					}
					if (dr["DiaChiNhan"] != null && dr["DiaChiNhan"] != DBNull.Value)
					{
						item.DiaChiNhan = Convert.ToString(dr["DiaChiNhan"]);
					}
					if (dr["SoTienThuHo"] != null && dr["SoTienThuHo"] != DBNull.Value)
					{
						item.SoTienThuHo = Convert.ToDecimal(dr["SoTienThuHo"]);
					}
					if (dr["CuocPhiVanChuyen"] != null && dr["CuocPhiVanChuyen"] != DBNull.Value)
					{
						item.CuocPhiVanChuyen = Convert.ToDecimal(dr["CuocPhiVanChuyen"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["TrongLuong"] != null && dr["TrongLuong"] != DBNull.Value)
					{
						item.TrongLuong = Convert.ToDecimal(dr["TrongLuong"]);
					}
					if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
					{
						item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
					}
					if (dr["CuocPhiChuaGTGT"] != null && dr["CuocPhiChuaGTGT"] != DBNull.Value)
					{
						item.CuocPhiChuaGTGT = Convert.ToDecimal(dr["CuocPhiChuaGTGT"]);
					}
					if (dr["ThueGTGT"] != null && dr["ThueGTGT"] != DBNull.Value)
					{
						item.ThueGTGT = Convert.ToDecimal(dr["ThueGTGT"]);
					}
					if (dr["NgayGuiHang"] != null && dr["NgayGuiHang"] != DBNull.Value)
					{
						item.NgayGuiHang = Convert.ToDateTime(dr["NgayGuiHang"]);
					}
					if (dr["LoaiThanhToan"] != null && dr["LoaiThanhToan"] != DBNull.Value)
					{
						item.LoaiThanhToan = Convert.ToString(dr["LoaiThanhToan"]);
					}
					if (dr["GiaoHangThanhCong"] != null && dr["GiaoHangThanhCong"] != DBNull.Value)
					{
						item.GiaoHangThanhCong = Convert.ToBoolean(dr["GiaoHangThanhCong"]);
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

		public List<ExpChungTuCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpChungTuCt] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpChungTuCt] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpChungTuCt>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpChungTuCt từ Database
		/// </summary>
		public ExpChungTuCt GetObject(string schema, String FK_ExpChungTu, String BILL_CODE)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpChungTuCt] where FK_ExpChungTu=@FK_ExpChungTu and BILL_CODE=@BILL_CODE",
					"@FK_ExpChungTu", FK_ExpChungTu, 
					"@BILL_CODE", BILL_CODE);
				if (ds.Rows.Count > 0)
				{
					ExpChungTuCt item=new ExpChungTuCt();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_ExpChungTu"] != null && dr["FK_ExpChungTu"] != DBNull.Value)
						{
							item.FK_ExpChungTu = Convert.ToString(dr["FK_ExpChungTu"]);
						}
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["SoTienPhaiThu"] != null && dr["SoTienPhaiThu"] != DBNull.Value)
						{
							item.SoTienPhaiThu = Convert.ToDecimal(dr["SoTienPhaiThu"]);
						}
						if (dr["SoTienPhaiChi"] != null && dr["SoTienPhaiChi"] != DBNull.Value)
						{
							item.SoTienPhaiChi = Convert.ToDecimal(dr["SoTienPhaiChi"]);
						}
						if (dr["TenNguoiNhan"] != null && dr["TenNguoiNhan"] != DBNull.Value)
						{
							item.TenNguoiNhan = Convert.ToString(dr["TenNguoiNhan"]);
						}
						if (dr["SoDienThoaiNhan"] != null && dr["SoDienThoaiNhan"] != DBNull.Value)
						{
							item.SoDienThoaiNhan = Convert.ToString(dr["SoDienThoaiNhan"]);
						}
						if (dr["DiaChiNhan"] != null && dr["DiaChiNhan"] != DBNull.Value)
						{
							item.DiaChiNhan = Convert.ToString(dr["DiaChiNhan"]);
						}
						if (dr["SoTienThuHo"] != null && dr["SoTienThuHo"] != DBNull.Value)
						{
							item.SoTienThuHo = Convert.ToDecimal(dr["SoTienThuHo"]);
						}
						if (dr["CuocPhiVanChuyen"] != null && dr["CuocPhiVanChuyen"] != DBNull.Value)
						{
							item.CuocPhiVanChuyen = Convert.ToDecimal(dr["CuocPhiVanChuyen"]);
						}
						if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
						{
							item.TenHang = Convert.ToString(dr["TenHang"]);
						}
						if (dr["TrongLuong"] != null && dr["TrongLuong"] != DBNull.Value)
						{
							item.TrongLuong = Convert.ToDecimal(dr["TrongLuong"]);
						}
						if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
						{
							item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
						}
						if (dr["CuocPhiChuaGTGT"] != null && dr["CuocPhiChuaGTGT"] != DBNull.Value)
						{
							item.CuocPhiChuaGTGT = Convert.ToDecimal(dr["CuocPhiChuaGTGT"]);
						}
						if (dr["ThueGTGT"] != null && dr["ThueGTGT"] != DBNull.Value)
						{
							item.ThueGTGT = Convert.ToDecimal(dr["ThueGTGT"]);
						}
						if (dr["NgayGuiHang"] != null && dr["NgayGuiHang"] != DBNull.Value)
						{
							item.NgayGuiHang = Convert.ToDateTime(dr["NgayGuiHang"]);
						}
						if (dr["LoaiThanhToan"] != null && dr["LoaiThanhToan"] != DBNull.Value)
						{
							item.LoaiThanhToan = Convert.ToString(dr["LoaiThanhToan"]);
						}
						if (dr["GiaoHangThanhCong"] != null && dr["GiaoHangThanhCong"] != DBNull.Value)
						{
							item.GiaoHangThanhCong = Convert.ToBoolean(dr["GiaoHangThanhCong"]);
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
		/// Lấy một ExpChungTuCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpChungTuCt GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpChungTuCt] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpChungTuCt item=new ExpChungTuCt();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_ExpChungTu"] != null && dr["FK_ExpChungTu"] != DBNull.Value)
						{
							item.FK_ExpChungTu = Convert.ToString(dr["FK_ExpChungTu"]);
						}
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["SoTienPhaiThu"] != null && dr["SoTienPhaiThu"] != DBNull.Value)
						{
							item.SoTienPhaiThu = Convert.ToDecimal(dr["SoTienPhaiThu"]);
						}
						if (dr["SoTienPhaiChi"] != null && dr["SoTienPhaiChi"] != DBNull.Value)
						{
							item.SoTienPhaiChi = Convert.ToDecimal(dr["SoTienPhaiChi"]);
						}
						if (dr["TenNguoiNhan"] != null && dr["TenNguoiNhan"] != DBNull.Value)
						{
							item.TenNguoiNhan = Convert.ToString(dr["TenNguoiNhan"]);
						}
						if (dr["SoDienThoaiNhan"] != null && dr["SoDienThoaiNhan"] != DBNull.Value)
						{
							item.SoDienThoaiNhan = Convert.ToString(dr["SoDienThoaiNhan"]);
						}
						if (dr["DiaChiNhan"] != null && dr["DiaChiNhan"] != DBNull.Value)
						{
							item.DiaChiNhan = Convert.ToString(dr["DiaChiNhan"]);
						}
						if (dr["SoTienThuHo"] != null && dr["SoTienThuHo"] != DBNull.Value)
						{
							item.SoTienThuHo = Convert.ToDecimal(dr["SoTienThuHo"]);
						}
						if (dr["CuocPhiVanChuyen"] != null && dr["CuocPhiVanChuyen"] != DBNull.Value)
						{
							item.CuocPhiVanChuyen = Convert.ToDecimal(dr["CuocPhiVanChuyen"]);
						}
						if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
						{
							item.TenHang = Convert.ToString(dr["TenHang"]);
						}
						if (dr["TrongLuong"] != null && dr["TrongLuong"] != DBNull.Value)
						{
							item.TrongLuong = Convert.ToDecimal(dr["TrongLuong"]);
						}
						if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
						{
							item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
						}
						if (dr["CuocPhiChuaGTGT"] != null && dr["CuocPhiChuaGTGT"] != DBNull.Value)
						{
							item.CuocPhiChuaGTGT = Convert.ToDecimal(dr["CuocPhiChuaGTGT"]);
						}
						if (dr["ThueGTGT"] != null && dr["ThueGTGT"] != DBNull.Value)
						{
							item.ThueGTGT = Convert.ToDecimal(dr["ThueGTGT"]);
						}
						if (dr["NgayGuiHang"] != null && dr["NgayGuiHang"] != DBNull.Value)
						{
							item.NgayGuiHang = Convert.ToDateTime(dr["NgayGuiHang"]);
						}
						if (dr["LoaiThanhToan"] != null && dr["LoaiThanhToan"] != DBNull.Value)
						{
							item.LoaiThanhToan = Convert.ToString(dr["LoaiThanhToan"]);
						}
						if (dr["GiaoHangThanhCong"] != null && dr["GiaoHangThanhCong"] != DBNull.Value)
						{
							item.GiaoHangThanhCong = Convert.ToBoolean(dr["GiaoHangThanhCong"]);
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

		public ExpChungTuCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpChungTuCt] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpChungTuCt>(ds);
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
		/// Thêm mới ExpChungTuCt vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpChungTuCt _ExpChungTuCt)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpChungTuCt](FK_ExpChungTu, BILL_CODE, SoTienPhaiThu, SoTienPhaiChi, TenNguoiNhan, SoDienThoaiNhan, DiaChiNhan, SoTienThuHo, CuocPhiVanChuyen, TenHang, TrongLuong, IsPhatHanh, CuocPhiChuaGTGT, ThueGTGT, NgayGuiHang, LoaiThanhToan, GiaoHangThanhCong) VALUES(@FK_ExpChungTu, @BILL_CODE, @SoTienPhaiThu, @SoTienPhaiChi, @TenNguoiNhan, @SoDienThoaiNhan, @DiaChiNhan, @SoTienThuHo, @CuocPhiVanChuyen, @TenHang, @TrongLuong, @IsPhatHanh, @CuocPhiChuaGTGT, @ThueGTGT, @NgayGuiHang, @LoaiThanhToan, @GiaoHangThanhCong)", 
					"@FK_ExpChungTu",  _ExpChungTuCt.FK_ExpChungTu, 
					"@BILL_CODE",  _ExpChungTuCt.BILL_CODE, 
					"@SoTienPhaiThu",  _ExpChungTuCt.SoTienPhaiThu, 
					"@SoTienPhaiChi",  _ExpChungTuCt.SoTienPhaiChi, 
					"@TenNguoiNhan",  _ExpChungTuCt.TenNguoiNhan, 
					"@SoDienThoaiNhan",  _ExpChungTuCt.SoDienThoaiNhan, 
					"@DiaChiNhan",  _ExpChungTuCt.DiaChiNhan, 
					"@SoTienThuHo",  _ExpChungTuCt.SoTienThuHo, 
					"@CuocPhiVanChuyen",  _ExpChungTuCt.CuocPhiVanChuyen, 
					"@TenHang",  _ExpChungTuCt.TenHang, 
					"@TrongLuong",  _ExpChungTuCt.TrongLuong, 
					"@IsPhatHanh",  _ExpChungTuCt.IsPhatHanh, 
					"@CuocPhiChuaGTGT",  _ExpChungTuCt.CuocPhiChuaGTGT, 
					"@ThueGTGT",  _ExpChungTuCt.ThueGTGT, 
					"@NgayGuiHang", this._dataContext.ConvertDateString( _ExpChungTuCt.NgayGuiHang), 
					"@LoaiThanhToan",  _ExpChungTuCt.LoaiThanhToan, 
					"@GiaoHangThanhCong",  _ExpChungTuCt.GiaoHangThanhCong);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpChungTuCt vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpChungTuCt> _ExpChungTuCts)
		{
			foreach (ExpChungTuCt item in _ExpChungTuCts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpChungTuCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpChungTuCt _ExpChungTuCt, String FK_ExpChungTu, String BILL_CODE)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpChungTuCt] SET FK_ExpChungTu=@FK_ExpChungTu, BILL_CODE=@BILL_CODE, SoTienPhaiThu=@SoTienPhaiThu, SoTienPhaiChi=@SoTienPhaiChi, TenNguoiNhan=@TenNguoiNhan, SoDienThoaiNhan=@SoDienThoaiNhan, DiaChiNhan=@DiaChiNhan, SoTienThuHo=@SoTienThuHo, CuocPhiVanChuyen=@CuocPhiVanChuyen, TenHang=@TenHang, TrongLuong=@TrongLuong, IsPhatHanh=@IsPhatHanh, CuocPhiChuaGTGT=@CuocPhiChuaGTGT, ThueGTGT=@ThueGTGT, NgayGuiHang=@NgayGuiHang, LoaiThanhToan=@LoaiThanhToan, GiaoHangThanhCong=@GiaoHangThanhCong WHERE FK_ExpChungTu=@FK_ExpChungTu and BILL_CODE=@BILL_CODE", 
					"@FK_ExpChungTu",  _ExpChungTuCt.FK_ExpChungTu, 
					"@BILL_CODE",  _ExpChungTuCt.BILL_CODE, 
					"@SoTienPhaiThu",  _ExpChungTuCt.SoTienPhaiThu, 
					"@SoTienPhaiChi",  _ExpChungTuCt.SoTienPhaiChi, 
					"@TenNguoiNhan",  _ExpChungTuCt.TenNguoiNhan, 
					"@SoDienThoaiNhan",  _ExpChungTuCt.SoDienThoaiNhan, 
					"@DiaChiNhan",  _ExpChungTuCt.DiaChiNhan, 
					"@SoTienThuHo",  _ExpChungTuCt.SoTienThuHo, 
					"@CuocPhiVanChuyen",  _ExpChungTuCt.CuocPhiVanChuyen, 
					"@TenHang",  _ExpChungTuCt.TenHang, 
					"@TrongLuong",  _ExpChungTuCt.TrongLuong, 
					"@IsPhatHanh",  _ExpChungTuCt.IsPhatHanh, 
					"@CuocPhiChuaGTGT",  _ExpChungTuCt.CuocPhiChuaGTGT, 
					"@ThueGTGT",  _ExpChungTuCt.ThueGTGT, 
					"@NgayGuiHang", this._dataContext.ConvertDateString( _ExpChungTuCt.NgayGuiHang), 
					"@LoaiThanhToan",  _ExpChungTuCt.LoaiThanhToan, 
					"@GiaoHangThanhCong",  _ExpChungTuCt.GiaoHangThanhCong, 
					"@FK_ExpChungTu", FK_ExpChungTu, 
					"@BILL_CODE", BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpChungTuCt vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpChungTuCt _ExpChungTuCt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpChungTuCt] SET SoTienPhaiThu=@SoTienPhaiThu, SoTienPhaiChi=@SoTienPhaiChi, TenNguoiNhan=@TenNguoiNhan, SoDienThoaiNhan=@SoDienThoaiNhan, DiaChiNhan=@DiaChiNhan, SoTienThuHo=@SoTienThuHo, CuocPhiVanChuyen=@CuocPhiVanChuyen, TenHang=@TenHang, TrongLuong=@TrongLuong, IsPhatHanh=@IsPhatHanh, CuocPhiChuaGTGT=@CuocPhiChuaGTGT, ThueGTGT=@ThueGTGT, NgayGuiHang=@NgayGuiHang, LoaiThanhToan=@LoaiThanhToan, GiaoHangThanhCong=@GiaoHangThanhCong WHERE FK_ExpChungTu=@FK_ExpChungTu and BILL_CODE=@BILL_CODE", 
					"@SoTienPhaiThu",  _ExpChungTuCt.SoTienPhaiThu, 
					"@SoTienPhaiChi",  _ExpChungTuCt.SoTienPhaiChi, 
					"@TenNguoiNhan",  _ExpChungTuCt.TenNguoiNhan, 
					"@SoDienThoaiNhan",  _ExpChungTuCt.SoDienThoaiNhan, 
					"@DiaChiNhan",  _ExpChungTuCt.DiaChiNhan, 
					"@SoTienThuHo",  _ExpChungTuCt.SoTienThuHo, 
					"@CuocPhiVanChuyen",  _ExpChungTuCt.CuocPhiVanChuyen, 
					"@TenHang",  _ExpChungTuCt.TenHang, 
					"@TrongLuong",  _ExpChungTuCt.TrongLuong, 
					"@IsPhatHanh",  _ExpChungTuCt.IsPhatHanh, 
					"@CuocPhiChuaGTGT",  _ExpChungTuCt.CuocPhiChuaGTGT, 
					"@ThueGTGT",  _ExpChungTuCt.ThueGTGT, 
					"@NgayGuiHang", this._dataContext.ConvertDateString( _ExpChungTuCt.NgayGuiHang), 
					"@LoaiThanhToan",  _ExpChungTuCt.LoaiThanhToan, 
					"@GiaoHangThanhCong",  _ExpChungTuCt.GiaoHangThanhCong, 
					"@FK_ExpChungTu", _ExpChungTuCt.FK_ExpChungTu, 
					"@BILL_CODE", _ExpChungTuCt.BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpChungTuCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpChungTuCt> _ExpChungTuCts)
		{
			foreach (ExpChungTuCt item in _ExpChungTuCts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpChungTuCt vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpChungTuCt _ExpChungTuCt, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpChungTuCt] SET FK_ExpChungTu=@FK_ExpChungTu, BILL_CODE=@BILL_CODE, SoTienPhaiThu=@SoTienPhaiThu, SoTienPhaiChi=@SoTienPhaiChi, TenNguoiNhan=@TenNguoiNhan, SoDienThoaiNhan=@SoDienThoaiNhan, DiaChiNhan=@DiaChiNhan, SoTienThuHo=@SoTienThuHo, CuocPhiVanChuyen=@CuocPhiVanChuyen, TenHang=@TenHang, TrongLuong=@TrongLuong, IsPhatHanh=@IsPhatHanh, CuocPhiChuaGTGT=@CuocPhiChuaGTGT, ThueGTGT=@ThueGTGT, NgayGuiHang=@NgayGuiHang, LoaiThanhToan=@LoaiThanhToan, GiaoHangThanhCong=@GiaoHangThanhCong "+ condition, 
					"@FK_ExpChungTu",  _ExpChungTuCt.FK_ExpChungTu, 
					"@BILL_CODE",  _ExpChungTuCt.BILL_CODE, 
					"@SoTienPhaiThu",  _ExpChungTuCt.SoTienPhaiThu, 
					"@SoTienPhaiChi",  _ExpChungTuCt.SoTienPhaiChi, 
					"@TenNguoiNhan",  _ExpChungTuCt.TenNguoiNhan, 
					"@SoDienThoaiNhan",  _ExpChungTuCt.SoDienThoaiNhan, 
					"@DiaChiNhan",  _ExpChungTuCt.DiaChiNhan, 
					"@SoTienThuHo",  _ExpChungTuCt.SoTienThuHo, 
					"@CuocPhiVanChuyen",  _ExpChungTuCt.CuocPhiVanChuyen, 
					"@TenHang",  _ExpChungTuCt.TenHang, 
					"@TrongLuong",  _ExpChungTuCt.TrongLuong, 
					"@IsPhatHanh",  _ExpChungTuCt.IsPhatHanh, 
					"@CuocPhiChuaGTGT",  _ExpChungTuCt.CuocPhiChuaGTGT, 
					"@ThueGTGT",  _ExpChungTuCt.ThueGTGT, 
					"@NgayGuiHang", this._dataContext.ConvertDateString( _ExpChungTuCt.NgayGuiHang), 
					"@LoaiThanhToan",  _ExpChungTuCt.LoaiThanhToan, 
					"@GiaoHangThanhCong",  _ExpChungTuCt.GiaoHangThanhCong);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpChungTuCt trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_ExpChungTu, String BILL_CODE)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpChungTuCt] WHERE FK_ExpChungTu=@FK_ExpChungTu and BILL_CODE=@BILL_CODE",
					"@FK_ExpChungTu", FK_ExpChungTu, 
					"@BILL_CODE", BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpChungTuCt trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpChungTuCt _ExpChungTuCt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpChungTuCt] WHERE FK_ExpChungTu=@FK_ExpChungTu and BILL_CODE=@BILL_CODE",
					"@FK_ExpChungTu", _ExpChungTuCt.FK_ExpChungTu, 
					"@BILL_CODE", _ExpChungTuCt.BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpChungTuCt trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpChungTuCt] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpChungTuCt trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpChungTuCt> _ExpChungTuCts)
		{
			foreach (ExpChungTuCt item in _ExpChungTuCts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
