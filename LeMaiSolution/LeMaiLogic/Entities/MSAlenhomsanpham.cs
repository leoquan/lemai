using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSAlenhomsanpham:ISAlenhomsanpham
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSAlenhomsanpham(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SaleNhomSanPham từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleNhomSanPham]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SaleNhomSanPham từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleNhomSanPham] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SaleNhomSanPham từ Database
		/// </summary>
		public List<SaleNhomSanPham> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleNhomSanPham]");
				List<SaleNhomSanPham> items = new List<SaleNhomSanPham>();
				SaleNhomSanPham item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleNhomSanPham();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenNhomSanPham"] != null && dr["TenNhomSanPham"] != DBNull.Value)
					{
						item.TenNhomSanPham = Convert.ToString(dr["TenNhomSanPham"]);
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
		/// Lấy danh sách SaleNhomSanPham từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SaleNhomSanPham> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleNhomSanPham] A "+ condition,  parameters);
				List<SaleNhomSanPham> items = new List<SaleNhomSanPham>();
				SaleNhomSanPham item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleNhomSanPham();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenNhomSanPham"] != null && dr["TenNhomSanPham"] != DBNull.Value)
					{
						item.TenNhomSanPham = Convert.ToString(dr["TenNhomSanPham"]);
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

		public List<SaleNhomSanPham> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleNhomSanPham] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SaleNhomSanPham] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SaleNhomSanPham>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SaleNhomSanPham từ Database
		/// </summary>
		public SaleNhomSanPham GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleNhomSanPham] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SaleNhomSanPham item=new SaleNhomSanPham();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenNhomSanPham"] != null && dr["TenNhomSanPham"] != DBNull.Value)
						{
							item.TenNhomSanPham = Convert.ToString(dr["TenNhomSanPham"]);
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
		/// Lấy một SaleNhomSanPham đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SaleNhomSanPham GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleNhomSanPham] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SaleNhomSanPham item=new SaleNhomSanPham();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenNhomSanPham"] != null && dr["TenNhomSanPham"] != DBNull.Value)
						{
							item.TenNhomSanPham = Convert.ToString(dr["TenNhomSanPham"]);
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

		public SaleNhomSanPham GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleNhomSanPham] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SaleNhomSanPham>(ds);
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
		/// Thêm mới SaleNhomSanPham vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SaleNhomSanPham _SaleNhomSanPham)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SaleNhomSanPham](Id, TenNhomSanPham) VALUES(@Id, @TenNhomSanPham)", 
					"@Id",  _SaleNhomSanPham.Id, 
					"@TenNhomSanPham",  _SaleNhomSanPham.TenNhomSanPham);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SaleNhomSanPham vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SaleNhomSanPham> _SaleNhomSanPhams)
		{
			foreach (SaleNhomSanPham item in _SaleNhomSanPhams)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleNhomSanPham vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SaleNhomSanPham _SaleNhomSanPham, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleNhomSanPham] SET Id=@Id, TenNhomSanPham=@TenNhomSanPham WHERE Id=@Id", 
					"@Id",  _SaleNhomSanPham.Id, 
					"@TenNhomSanPham",  _SaleNhomSanPham.TenNhomSanPham, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SaleNhomSanPham vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SaleNhomSanPham _SaleNhomSanPham)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleNhomSanPham] SET TenNhomSanPham=@TenNhomSanPham WHERE Id=@Id", 
					"@TenNhomSanPham",  _SaleNhomSanPham.TenNhomSanPham, 
					"@Id", _SaleNhomSanPham.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SaleNhomSanPham vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SaleNhomSanPham> _SaleNhomSanPhams)
		{
			foreach (SaleNhomSanPham item in _SaleNhomSanPhams)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleNhomSanPham vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SaleNhomSanPham _SaleNhomSanPham, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleNhomSanPham] SET Id=@Id, TenNhomSanPham=@TenNhomSanPham "+ condition, 
					"@Id",  _SaleNhomSanPham.Id, 
					"@TenNhomSanPham",  _SaleNhomSanPham.TenNhomSanPham);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SaleNhomSanPham trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleNhomSanPham] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleNhomSanPham trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SaleNhomSanPham _SaleNhomSanPham)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleNhomSanPham] WHERE Id=@Id",
					"@Id", _SaleNhomSanPham.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleNhomSanPham trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleNhomSanPham] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleNhomSanPham trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SaleNhomSanPham> _SaleNhomSanPhams)
		{
			foreach (SaleNhomSanPham item in _SaleNhomSanPhams)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
