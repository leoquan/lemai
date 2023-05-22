using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVCxuathang:IVCxuathang
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVCxuathang(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VCXuatHang từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCXuatHang]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VCXuatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCXuatHang] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VCXuatHang từ Database
		/// </summary>
		public List<VCXuatHang> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCXuatHang]");
				List<VCXuatHang> items = new List<VCXuatHang>();
				VCXuatHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCXuatHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ngay"] != null && dr["Ngay"] != DBNull.Value)
					{
						item.Ngay = Convert.ToDateTime(dr["Ngay"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
					}
					if (dr["FK_MatHang"] != null && dr["FK_MatHang"] != DBNull.Value)
					{
						item.FK_MatHang = Convert.ToString(dr["FK_MatHang"]);
					}
					if (dr["FK_NhapHang"] != null && dr["FK_NhapHang"] != DBNull.Value)
					{
						item.FK_NhapHang = Convert.ToString(dr["FK_NhapHang"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToInt32(dr["DonGia"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
					}
					if (dr["ThanhToan"] != null && dr["ThanhToan"] != DBNull.Value)
					{
						item.ThanhToan = Convert.ToDecimal(dr["ThanhToan"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
					{
						item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
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
		/// Lấy danh sách VCXuatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VCXuatHang> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCXuatHang] A "+ condition,  parameters);
				List<VCXuatHang> items = new List<VCXuatHang>();
				VCXuatHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCXuatHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ngay"] != null && dr["Ngay"] != DBNull.Value)
					{
						item.Ngay = Convert.ToDateTime(dr["Ngay"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
					}
					if (dr["FK_MatHang"] != null && dr["FK_MatHang"] != DBNull.Value)
					{
						item.FK_MatHang = Convert.ToString(dr["FK_MatHang"]);
					}
					if (dr["FK_NhapHang"] != null && dr["FK_NhapHang"] != DBNull.Value)
					{
						item.FK_NhapHang = Convert.ToString(dr["FK_NhapHang"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToInt32(dr["DonGia"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
					}
					if (dr["ThanhToan"] != null && dr["ThanhToan"] != DBNull.Value)
					{
						item.ThanhToan = Convert.ToDecimal(dr["ThanhToan"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
					{
						item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
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

		public List<VCXuatHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCXuatHang] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VCXuatHang] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VCXuatHang>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VCXuatHang từ Database
		/// </summary>
		public VCXuatHang GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCXuatHang] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					VCXuatHang item=new VCXuatHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Ngay"] != null && dr["Ngay"] != DBNull.Value)
						{
							item.Ngay = Convert.ToDateTime(dr["Ngay"]);
						}
						if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
						{
							item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
						}
						if (dr["FK_MatHang"] != null && dr["FK_MatHang"] != DBNull.Value)
						{
							item.FK_MatHang = Convert.ToString(dr["FK_MatHang"]);
						}
						if (dr["FK_NhapHang"] != null && dr["FK_NhapHang"] != DBNull.Value)
						{
							item.FK_NhapHang = Convert.ToString(dr["FK_NhapHang"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToInt32(dr["DonGia"]);
						}
						if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
						{
							item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
						}
						if (dr["ThanhToan"] != null && dr["ThanhToan"] != DBNull.Value)
						{
							item.ThanhToan = Convert.ToDecimal(dr["ThanhToan"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
						{
							item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
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
		/// Lấy một VCXuatHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VCXuatHang GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCXuatHang] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VCXuatHang item=new VCXuatHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Ngay"] != null && dr["Ngay"] != DBNull.Value)
						{
							item.Ngay = Convert.ToDateTime(dr["Ngay"]);
						}
						if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
						{
							item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
						}
						if (dr["FK_MatHang"] != null && dr["FK_MatHang"] != DBNull.Value)
						{
							item.FK_MatHang = Convert.ToString(dr["FK_MatHang"]);
						}
						if (dr["FK_NhapHang"] != null && dr["FK_NhapHang"] != DBNull.Value)
						{
							item.FK_NhapHang = Convert.ToString(dr["FK_NhapHang"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToInt32(dr["DonGia"]);
						}
						if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
						{
							item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
						}
						if (dr["ThanhToan"] != null && dr["ThanhToan"] != DBNull.Value)
						{
							item.ThanhToan = Convert.ToDecimal(dr["ThanhToan"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
						{
							item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
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

		public VCXuatHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCXuatHang] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VCXuatHang>(ds);
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
		/// Thêm mới VCXuatHang vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VCXuatHang _VCXuatHang)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VCXuatHang](Id, Ngay, FK_KhachHang, FK_MatHang, FK_NhapHang, SoLuong, DonGia, ThanhTien, ThanhToan, FK_Account, NgayXuat) VALUES(@Id, @Ngay, @FK_KhachHang, @FK_MatHang, @FK_NhapHang, @SoLuong, @DonGia, @ThanhTien, @ThanhToan, @FK_Account, @NgayXuat)", 
					"@Id",  _VCXuatHang.Id, 
					"@Ngay", this._dataContext.ConvertDateString( _VCXuatHang.Ngay), 
					"@FK_KhachHang",  _VCXuatHang.FK_KhachHang, 
					"@FK_MatHang",  _VCXuatHang.FK_MatHang, 
					"@FK_NhapHang",  _VCXuatHang.FK_NhapHang, 
					"@SoLuong",  _VCXuatHang.SoLuong, 
					"@DonGia",  _VCXuatHang.DonGia, 
					"@ThanhTien",  _VCXuatHang.ThanhTien, 
					"@ThanhToan",  _VCXuatHang.ThanhToan, 
					"@FK_Account",  _VCXuatHang.FK_Account, 
					"@NgayXuat", this._dataContext.ConvertDateString( _VCXuatHang.NgayXuat));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VCXuatHang vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VCXuatHang> _VCXuatHangs)
		{
			foreach (VCXuatHang item in _VCXuatHangs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCXuatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VCXuatHang _VCXuatHang, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCXuatHang] SET Id=@Id, Ngay=@Ngay, FK_KhachHang=@FK_KhachHang, FK_MatHang=@FK_MatHang, FK_NhapHang=@FK_NhapHang, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, ThanhToan=@ThanhToan, FK_Account=@FK_Account, NgayXuat=@NgayXuat WHERE Id=@Id", 
					"@Id",  _VCXuatHang.Id, 
					"@Ngay", this._dataContext.ConvertDateString( _VCXuatHang.Ngay), 
					"@FK_KhachHang",  _VCXuatHang.FK_KhachHang, 
					"@FK_MatHang",  _VCXuatHang.FK_MatHang, 
					"@FK_NhapHang",  _VCXuatHang.FK_NhapHang, 
					"@SoLuong",  _VCXuatHang.SoLuong, 
					"@DonGia",  _VCXuatHang.DonGia, 
					"@ThanhTien",  _VCXuatHang.ThanhTien, 
					"@ThanhToan",  _VCXuatHang.ThanhToan, 
					"@FK_Account",  _VCXuatHang.FK_Account, 
					"@NgayXuat", this._dataContext.ConvertDateString( _VCXuatHang.NgayXuat), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VCXuatHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VCXuatHang _VCXuatHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCXuatHang] SET Ngay=@Ngay, FK_KhachHang=@FK_KhachHang, FK_MatHang=@FK_MatHang, FK_NhapHang=@FK_NhapHang, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, ThanhToan=@ThanhToan, FK_Account=@FK_Account, NgayXuat=@NgayXuat WHERE Id=@Id", 
					"@Ngay", this._dataContext.ConvertDateString( _VCXuatHang.Ngay), 
					"@FK_KhachHang",  _VCXuatHang.FK_KhachHang, 
					"@FK_MatHang",  _VCXuatHang.FK_MatHang, 
					"@FK_NhapHang",  _VCXuatHang.FK_NhapHang, 
					"@SoLuong",  _VCXuatHang.SoLuong, 
					"@DonGia",  _VCXuatHang.DonGia, 
					"@ThanhTien",  _VCXuatHang.ThanhTien, 
					"@ThanhToan",  _VCXuatHang.ThanhToan, 
					"@FK_Account",  _VCXuatHang.FK_Account, 
					"@NgayXuat", this._dataContext.ConvertDateString( _VCXuatHang.NgayXuat), 
					"@Id", _VCXuatHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VCXuatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VCXuatHang> _VCXuatHangs)
		{
			foreach (VCXuatHang item in _VCXuatHangs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCXuatHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VCXuatHang _VCXuatHang, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCXuatHang] SET Id=@Id, Ngay=@Ngay, FK_KhachHang=@FK_KhachHang, FK_MatHang=@FK_MatHang, FK_NhapHang=@FK_NhapHang, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, ThanhToan=@ThanhToan, FK_Account=@FK_Account, NgayXuat=@NgayXuat "+ condition, 
					"@Id",  _VCXuatHang.Id, 
					"@Ngay", this._dataContext.ConvertDateString( _VCXuatHang.Ngay), 
					"@FK_KhachHang",  _VCXuatHang.FK_KhachHang, 
					"@FK_MatHang",  _VCXuatHang.FK_MatHang, 
					"@FK_NhapHang",  _VCXuatHang.FK_NhapHang, 
					"@SoLuong",  _VCXuatHang.SoLuong, 
					"@DonGia",  _VCXuatHang.DonGia, 
					"@ThanhTien",  _VCXuatHang.ThanhTien, 
					"@ThanhToan",  _VCXuatHang.ThanhToan, 
					"@FK_Account",  _VCXuatHang.FK_Account, 
					"@NgayXuat", this._dataContext.ConvertDateString( _VCXuatHang.NgayXuat));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VCXuatHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCXuatHang] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCXuatHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VCXuatHang _VCXuatHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCXuatHang] WHERE Id=@Id",
					"@Id", _VCXuatHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCXuatHang trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCXuatHang] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCXuatHang trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VCXuatHang> _VCXuatHangs)
		{
			foreach (VCXuatHang item in _VCXuatHangs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
