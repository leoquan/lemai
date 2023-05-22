using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSAlekhachhang:ISAlekhachhang
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSAlekhachhang(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SaleKhachHang từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleKhachHang]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SaleKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleKhachHang] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SaleKhachHang từ Database
		/// </summary>
		public List<SaleKhachHang> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleKhachHang]");
				List<SaleKhachHang> items = new List<SaleKhachHang>();
				SaleKhachHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleKhachHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["SoTienCongNo"] != null && dr["SoTienCongNo"] != DBNull.Value)
					{
						item.SoTienCongNo = Convert.ToInt32(dr["SoTienCongNo"]);
					}
					if (dr["FK_BangGia"] != null && dr["FK_BangGia"] != DBNull.Value)
					{
						item.FK_BangGia = Convert.ToString(dr["FK_BangGia"]);
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
		/// Lấy danh sách SaleKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SaleKhachHang> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleKhachHang] A "+ condition,  parameters);
				List<SaleKhachHang> items = new List<SaleKhachHang>();
				SaleKhachHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleKhachHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["SoTienCongNo"] != null && dr["SoTienCongNo"] != DBNull.Value)
					{
						item.SoTienCongNo = Convert.ToInt32(dr["SoTienCongNo"]);
					}
					if (dr["FK_BangGia"] != null && dr["FK_BangGia"] != DBNull.Value)
					{
						item.FK_BangGia = Convert.ToString(dr["FK_BangGia"]);
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

		public List<SaleKhachHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleKhachHang] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SaleKhachHang] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SaleKhachHang>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SaleKhachHang từ Database
		/// </summary>
		public SaleKhachHang GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleKhachHang] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SaleKhachHang item=new SaleKhachHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
						{
							item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["SoTienCongNo"] != null && dr["SoTienCongNo"] != DBNull.Value)
						{
							item.SoTienCongNo = Convert.ToInt32(dr["SoTienCongNo"]);
						}
						if (dr["FK_BangGia"] != null && dr["FK_BangGia"] != DBNull.Value)
						{
							item.FK_BangGia = Convert.ToString(dr["FK_BangGia"]);
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
		/// Lấy một SaleKhachHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SaleKhachHang GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleKhachHang] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SaleKhachHang item=new SaleKhachHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
						{
							item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["SoTienCongNo"] != null && dr["SoTienCongNo"] != DBNull.Value)
						{
							item.SoTienCongNo = Convert.ToInt32(dr["SoTienCongNo"]);
						}
						if (dr["FK_BangGia"] != null && dr["FK_BangGia"] != DBNull.Value)
						{
							item.FK_BangGia = Convert.ToString(dr["FK_BangGia"]);
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

		public SaleKhachHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleKhachHang] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SaleKhachHang>(ds);
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
		/// Thêm mới SaleKhachHang vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SaleKhachHang _SaleKhachHang)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SaleKhachHang](Id, TenKhachHang, SoDienThoai, SoTienCongNo, FK_BangGia) VALUES(@Id, @TenKhachHang, @SoDienThoai, @SoTienCongNo, @FK_BangGia)", 
					"@Id",  _SaleKhachHang.Id, 
					"@TenKhachHang",  _SaleKhachHang.TenKhachHang, 
					"@SoDienThoai",  _SaleKhachHang.SoDienThoai, 
					"@SoTienCongNo",  _SaleKhachHang.SoTienCongNo, 
					"@FK_BangGia",  _SaleKhachHang.FK_BangGia);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SaleKhachHang vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SaleKhachHang> _SaleKhachHangs)
		{
			foreach (SaleKhachHang item in _SaleKhachHangs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleKhachHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SaleKhachHang _SaleKhachHang, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleKhachHang] SET Id=@Id, TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, SoTienCongNo=@SoTienCongNo, FK_BangGia=@FK_BangGia WHERE Id=@Id", 
					"@Id",  _SaleKhachHang.Id, 
					"@TenKhachHang",  _SaleKhachHang.TenKhachHang, 
					"@SoDienThoai",  _SaleKhachHang.SoDienThoai, 
					"@SoTienCongNo",  _SaleKhachHang.SoTienCongNo, 
					"@FK_BangGia",  _SaleKhachHang.FK_BangGia, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SaleKhachHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SaleKhachHang _SaleKhachHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleKhachHang] SET TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, SoTienCongNo=@SoTienCongNo, FK_BangGia=@FK_BangGia WHERE Id=@Id", 
					"@TenKhachHang",  _SaleKhachHang.TenKhachHang, 
					"@SoDienThoai",  _SaleKhachHang.SoDienThoai, 
					"@SoTienCongNo",  _SaleKhachHang.SoTienCongNo, 
					"@FK_BangGia",  _SaleKhachHang.FK_BangGia, 
					"@Id", _SaleKhachHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SaleKhachHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SaleKhachHang> _SaleKhachHangs)
		{
			foreach (SaleKhachHang item in _SaleKhachHangs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleKhachHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SaleKhachHang _SaleKhachHang, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleKhachHang] SET Id=@Id, TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, SoTienCongNo=@SoTienCongNo, FK_BangGia=@FK_BangGia "+ condition, 
					"@Id",  _SaleKhachHang.Id, 
					"@TenKhachHang",  _SaleKhachHang.TenKhachHang, 
					"@SoDienThoai",  _SaleKhachHang.SoDienThoai, 
					"@SoTienCongNo",  _SaleKhachHang.SoTienCongNo, 
					"@FK_BangGia",  _SaleKhachHang.FK_BangGia);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SaleKhachHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleKhachHang] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleKhachHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SaleKhachHang _SaleKhachHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleKhachHang] WHERE Id=@Id",
					"@Id", _SaleKhachHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleKhachHang trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleKhachHang] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleKhachHang trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SaleKhachHang> _SaleKhachHangs)
		{
			foreach (SaleKhachHang item in _SaleKhachHangs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
