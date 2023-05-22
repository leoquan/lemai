using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpsalexuatkho:IEXpsalexuatkho
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpsalexuatkho(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpSaleXuatKho từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleXuatKho]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpSaleXuatKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleXuatKho] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpSaleXuatKho từ Database
		/// </summary>
		public List<ExpSaleXuatKho> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleXuatKho]");
				List<ExpSaleXuatKho> items = new List<ExpSaleXuatKho>();
				ExpSaleXuatKho item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleXuatKho();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Product"] != null && dr["FK_Product"] != DBNull.Value)
					{
						item.FK_Product = Convert.ToString(dr["FK_Product"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
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
					if (dr["IsThanhToan"] != null && dr["IsThanhToan"] != DBNull.Value)
					{
						item.IsThanhToan = Convert.ToBoolean(dr["IsThanhToan"]);
					}
					if (dr["FK_LoaiThanhToan"] != null && dr["FK_LoaiThanhToan"] != DBNull.Value)
					{
						item.FK_LoaiThanhToan = Convert.ToString(dr["FK_LoaiThanhToan"]);
					}
					if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
					{
						item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
					}
					if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
					{
						item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
					}
					if (dr["FK_NguoiXuat"] != null && dr["FK_NguoiXuat"] != DBNull.Value)
					{
						item.FK_NguoiXuat = Convert.ToString(dr["FK_NguoiXuat"]);
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
		/// Lấy danh sách ExpSaleXuatKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpSaleXuatKho> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleXuatKho] A "+ condition,  parameters);
				List<ExpSaleXuatKho> items = new List<ExpSaleXuatKho>();
				ExpSaleXuatKho item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleXuatKho();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Product"] != null && dr["FK_Product"] != DBNull.Value)
					{
						item.FK_Product = Convert.ToString(dr["FK_Product"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
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
					if (dr["IsThanhToan"] != null && dr["IsThanhToan"] != DBNull.Value)
					{
						item.IsThanhToan = Convert.ToBoolean(dr["IsThanhToan"]);
					}
					if (dr["FK_LoaiThanhToan"] != null && dr["FK_LoaiThanhToan"] != DBNull.Value)
					{
						item.FK_LoaiThanhToan = Convert.ToString(dr["FK_LoaiThanhToan"]);
					}
					if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
					{
						item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
					}
					if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
					{
						item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
					}
					if (dr["FK_NguoiXuat"] != null && dr["FK_NguoiXuat"] != DBNull.Value)
					{
						item.FK_NguoiXuat = Convert.ToString(dr["FK_NguoiXuat"]);
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

		public List<ExpSaleXuatKho> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleXuatKho] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpSaleXuatKho] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpSaleXuatKho>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpSaleXuatKho từ Database
		/// </summary>
		public ExpSaleXuatKho GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleXuatKho] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpSaleXuatKho item=new ExpSaleXuatKho();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Product"] != null && dr["FK_Product"] != DBNull.Value)
						{
							item.FK_Product = Convert.ToString(dr["FK_Product"]);
						}
						if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
						{
							item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
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
						if (dr["IsThanhToan"] != null && dr["IsThanhToan"] != DBNull.Value)
						{
							item.IsThanhToan = Convert.ToBoolean(dr["IsThanhToan"]);
						}
						if (dr["FK_LoaiThanhToan"] != null && dr["FK_LoaiThanhToan"] != DBNull.Value)
						{
							item.FK_LoaiThanhToan = Convert.ToString(dr["FK_LoaiThanhToan"]);
						}
						if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
						{
							item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
						}
						if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
						{
							item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
						}
						if (dr["FK_NguoiXuat"] != null && dr["FK_NguoiXuat"] != DBNull.Value)
						{
							item.FK_NguoiXuat = Convert.ToString(dr["FK_NguoiXuat"]);
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
		/// Lấy một ExpSaleXuatKho đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpSaleXuatKho GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleXuatKho] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpSaleXuatKho item=new ExpSaleXuatKho();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Product"] != null && dr["FK_Product"] != DBNull.Value)
						{
							item.FK_Product = Convert.ToString(dr["FK_Product"]);
						}
						if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
						{
							item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
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
						if (dr["IsThanhToan"] != null && dr["IsThanhToan"] != DBNull.Value)
						{
							item.IsThanhToan = Convert.ToBoolean(dr["IsThanhToan"]);
						}
						if (dr["FK_LoaiThanhToan"] != null && dr["FK_LoaiThanhToan"] != DBNull.Value)
						{
							item.FK_LoaiThanhToan = Convert.ToString(dr["FK_LoaiThanhToan"]);
						}
						if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
						{
							item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
						}
						if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
						{
							item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
						}
						if (dr["FK_NguoiXuat"] != null && dr["FK_NguoiXuat"] != DBNull.Value)
						{
							item.FK_NguoiXuat = Convert.ToString(dr["FK_NguoiXuat"]);
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

		public ExpSaleXuatKho GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleXuatKho] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpSaleXuatKho>(ds);
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
		/// Thêm mới ExpSaleXuatKho vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpSaleXuatKho _ExpSaleXuatKho)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpSaleXuatKho](Id, FK_Product, FK_KhachHang, SoLuong, DonGia, ThanhTien, IsThanhToan, FK_LoaiThanhToan, NgayThanhToan, NgayXuat, FK_NguoiXuat) VALUES(@Id, @FK_Product, @FK_KhachHang, @SoLuong, @DonGia, @ThanhTien, @IsThanhToan, @FK_LoaiThanhToan, @NgayThanhToan, @NgayXuat, @FK_NguoiXuat)", 
					"@Id",  _ExpSaleXuatKho.Id, 
					"@FK_Product",  _ExpSaleXuatKho.FK_Product, 
					"@FK_KhachHang",  _ExpSaleXuatKho.FK_KhachHang, 
					"@SoLuong",  _ExpSaleXuatKho.SoLuong, 
					"@DonGia",  _ExpSaleXuatKho.DonGia, 
					"@ThanhTien",  _ExpSaleXuatKho.ThanhTien, 
					"@IsThanhToan",  _ExpSaleXuatKho.IsThanhToan, 
					"@FK_LoaiThanhToan",  _ExpSaleXuatKho.FK_LoaiThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpSaleXuatKho.NgayThanhToan), 
					"@NgayXuat", this._dataContext.ConvertDateString( _ExpSaleXuatKho.NgayXuat), 
					"@FK_NguoiXuat",  _ExpSaleXuatKho.FK_NguoiXuat);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpSaleXuatKho vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpSaleXuatKho> _ExpSaleXuatKhos)
		{
			foreach (ExpSaleXuatKho item in _ExpSaleXuatKhos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleXuatKho vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpSaleXuatKho _ExpSaleXuatKho, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleXuatKho] SET Id=@Id, FK_Product=@FK_Product, FK_KhachHang=@FK_KhachHang, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, IsThanhToan=@IsThanhToan, FK_LoaiThanhToan=@FK_LoaiThanhToan, NgayThanhToan=@NgayThanhToan, NgayXuat=@NgayXuat, FK_NguoiXuat=@FK_NguoiXuat WHERE Id=@Id", 
					"@Id",  _ExpSaleXuatKho.Id, 
					"@FK_Product",  _ExpSaleXuatKho.FK_Product, 
					"@FK_KhachHang",  _ExpSaleXuatKho.FK_KhachHang, 
					"@SoLuong",  _ExpSaleXuatKho.SoLuong, 
					"@DonGia",  _ExpSaleXuatKho.DonGia, 
					"@ThanhTien",  _ExpSaleXuatKho.ThanhTien, 
					"@IsThanhToan",  _ExpSaleXuatKho.IsThanhToan, 
					"@FK_LoaiThanhToan",  _ExpSaleXuatKho.FK_LoaiThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpSaleXuatKho.NgayThanhToan), 
					"@NgayXuat", this._dataContext.ConvertDateString( _ExpSaleXuatKho.NgayXuat), 
					"@FK_NguoiXuat",  _ExpSaleXuatKho.FK_NguoiXuat, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleXuatKho vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpSaleXuatKho _ExpSaleXuatKho)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleXuatKho] SET FK_Product=@FK_Product, FK_KhachHang=@FK_KhachHang, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, IsThanhToan=@IsThanhToan, FK_LoaiThanhToan=@FK_LoaiThanhToan, NgayThanhToan=@NgayThanhToan, NgayXuat=@NgayXuat, FK_NguoiXuat=@FK_NguoiXuat WHERE Id=@Id", 
					"@FK_Product",  _ExpSaleXuatKho.FK_Product, 
					"@FK_KhachHang",  _ExpSaleXuatKho.FK_KhachHang, 
					"@SoLuong",  _ExpSaleXuatKho.SoLuong, 
					"@DonGia",  _ExpSaleXuatKho.DonGia, 
					"@ThanhTien",  _ExpSaleXuatKho.ThanhTien, 
					"@IsThanhToan",  _ExpSaleXuatKho.IsThanhToan, 
					"@FK_LoaiThanhToan",  _ExpSaleXuatKho.FK_LoaiThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpSaleXuatKho.NgayThanhToan), 
					"@NgayXuat", this._dataContext.ConvertDateString( _ExpSaleXuatKho.NgayXuat), 
					"@FK_NguoiXuat",  _ExpSaleXuatKho.FK_NguoiXuat, 
					"@Id", _ExpSaleXuatKho.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpSaleXuatKho vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpSaleXuatKho> _ExpSaleXuatKhos)
		{
			foreach (ExpSaleXuatKho item in _ExpSaleXuatKhos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleXuatKho vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpSaleXuatKho _ExpSaleXuatKho, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleXuatKho] SET Id=@Id, FK_Product=@FK_Product, FK_KhachHang=@FK_KhachHang, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, IsThanhToan=@IsThanhToan, FK_LoaiThanhToan=@FK_LoaiThanhToan, NgayThanhToan=@NgayThanhToan, NgayXuat=@NgayXuat, FK_NguoiXuat=@FK_NguoiXuat "+ condition, 
					"@Id",  _ExpSaleXuatKho.Id, 
					"@FK_Product",  _ExpSaleXuatKho.FK_Product, 
					"@FK_KhachHang",  _ExpSaleXuatKho.FK_KhachHang, 
					"@SoLuong",  _ExpSaleXuatKho.SoLuong, 
					"@DonGia",  _ExpSaleXuatKho.DonGia, 
					"@ThanhTien",  _ExpSaleXuatKho.ThanhTien, 
					"@IsThanhToan",  _ExpSaleXuatKho.IsThanhToan, 
					"@FK_LoaiThanhToan",  _ExpSaleXuatKho.FK_LoaiThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpSaleXuatKho.NgayThanhToan), 
					"@NgayXuat", this._dataContext.ConvertDateString( _ExpSaleXuatKho.NgayXuat), 
					"@FK_NguoiXuat",  _ExpSaleXuatKho.FK_NguoiXuat);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpSaleXuatKho trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleXuatKho] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleXuatKho trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpSaleXuatKho _ExpSaleXuatKho)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleXuatKho] WHERE Id=@Id",
					"@Id", _ExpSaleXuatKho.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleXuatKho trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleXuatKho] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleXuatKho trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpSaleXuatKho> _ExpSaleXuatKhos)
		{
			foreach (ExpSaleXuatKho item in _ExpSaleXuatKhos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
