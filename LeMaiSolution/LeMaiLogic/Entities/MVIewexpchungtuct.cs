using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpchungtuct:IVIewexpchungtuct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpchungtuct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpChungTuCt từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpChungTuCt]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpChungTuCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpChungTuCt] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpChungTuCt từ Database
		/// </summary>
		public List<view_ExpChungTuCt> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpChungTuCt]");
				List<view_ExpChungTuCt> items = new List<view_ExpChungTuCt>();
				view_ExpChungTuCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpChungTuCt();
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
		/// Lấy danh sách view_ExpChungTuCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpChungTuCt> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpChungTuCt] A "+ condition,  parameters);
				List<view_ExpChungTuCt> items = new List<view_ExpChungTuCt>();
				view_ExpChungTuCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpChungTuCt();
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<view_ExpChungTuCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpChungTuCt] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpChungTuCt] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpChungTuCt>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpChungTuCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpChungTuCt GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpChungTuCt] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpChungTuCt item=new view_ExpChungTuCt();
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

		public view_ExpChungTuCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpChungTuCt] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpChungTuCt>(ds);
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
