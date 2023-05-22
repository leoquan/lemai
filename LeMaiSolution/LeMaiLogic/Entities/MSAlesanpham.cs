using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSAlesanpham:ISAlesanpham
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSAlesanpham(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SaleSanPham từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleSanPham]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SaleSanPham từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleSanPham] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SaleSanPham từ Database
		/// </summary>
		public List<SaleSanPham> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleSanPham]");
				List<SaleSanPham> items = new List<SaleSanPham>();
				SaleSanPham item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleSanPham();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
					{
						item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
					}
					if (dr["DonViTinh"] != null && dr["DonViTinh"] != DBNull.Value)
					{
						item.DonViTinh = Convert.ToString(dr["DonViTinh"]);
					}
					if (dr["QuyCach"] != null && dr["QuyCach"] != DBNull.Value)
					{
						item.QuyCach = Convert.ToString(dr["QuyCach"]);
					}
					if (dr["HeSoQuyDoi"] != null && dr["HeSoQuyDoi"] != DBNull.Value)
					{
						item.HeSoQuyDoi = Convert.ToInt32(dr["HeSoQuyDoi"]);
					}
					if (dr["FK_NhomSanPham"] != null && dr["FK_NhomSanPham"] != DBNull.Value)
					{
						item.FK_NhomSanPham = Convert.ToString(dr["FK_NhomSanPham"]);
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
		/// Lấy danh sách SaleSanPham từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SaleSanPham> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleSanPham] A "+ condition,  parameters);
				List<SaleSanPham> items = new List<SaleSanPham>();
				SaleSanPham item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleSanPham();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
					{
						item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
					}
					if (dr["DonViTinh"] != null && dr["DonViTinh"] != DBNull.Value)
					{
						item.DonViTinh = Convert.ToString(dr["DonViTinh"]);
					}
					if (dr["QuyCach"] != null && dr["QuyCach"] != DBNull.Value)
					{
						item.QuyCach = Convert.ToString(dr["QuyCach"]);
					}
					if (dr["HeSoQuyDoi"] != null && dr["HeSoQuyDoi"] != DBNull.Value)
					{
						item.HeSoQuyDoi = Convert.ToInt32(dr["HeSoQuyDoi"]);
					}
					if (dr["FK_NhomSanPham"] != null && dr["FK_NhomSanPham"] != DBNull.Value)
					{
						item.FK_NhomSanPham = Convert.ToString(dr["FK_NhomSanPham"]);
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

		public List<SaleSanPham> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleSanPham] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SaleSanPham] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SaleSanPham>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SaleSanPham từ Database
		/// </summary>
		public SaleSanPham GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleSanPham] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SaleSanPham item=new SaleSanPham();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
						{
							item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
						}
						if (dr["DonViTinh"] != null && dr["DonViTinh"] != DBNull.Value)
						{
							item.DonViTinh = Convert.ToString(dr["DonViTinh"]);
						}
						if (dr["QuyCach"] != null && dr["QuyCach"] != DBNull.Value)
						{
							item.QuyCach = Convert.ToString(dr["QuyCach"]);
						}
						if (dr["HeSoQuyDoi"] != null && dr["HeSoQuyDoi"] != DBNull.Value)
						{
							item.HeSoQuyDoi = Convert.ToInt32(dr["HeSoQuyDoi"]);
						}
						if (dr["FK_NhomSanPham"] != null && dr["FK_NhomSanPham"] != DBNull.Value)
						{
							item.FK_NhomSanPham = Convert.ToString(dr["FK_NhomSanPham"]);
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
		/// Lấy một SaleSanPham đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SaleSanPham GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleSanPham] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SaleSanPham item=new SaleSanPham();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
						{
							item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
						}
						if (dr["DonViTinh"] != null && dr["DonViTinh"] != DBNull.Value)
						{
							item.DonViTinh = Convert.ToString(dr["DonViTinh"]);
						}
						if (dr["QuyCach"] != null && dr["QuyCach"] != DBNull.Value)
						{
							item.QuyCach = Convert.ToString(dr["QuyCach"]);
						}
						if (dr["HeSoQuyDoi"] != null && dr["HeSoQuyDoi"] != DBNull.Value)
						{
							item.HeSoQuyDoi = Convert.ToInt32(dr["HeSoQuyDoi"]);
						}
						if (dr["FK_NhomSanPham"] != null && dr["FK_NhomSanPham"] != DBNull.Value)
						{
							item.FK_NhomSanPham = Convert.ToString(dr["FK_NhomSanPham"]);
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

		public SaleSanPham GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleSanPham] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SaleSanPham>(ds);
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
		/// Thêm mới SaleSanPham vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SaleSanPham _SaleSanPham)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SaleSanPham](Id, TenSanPham, DonViTinh, QuyCach, HeSoQuyDoi, FK_NhomSanPham) VALUES(@Id, @TenSanPham, @DonViTinh, @QuyCach, @HeSoQuyDoi, @FK_NhomSanPham)", 
					"@Id",  _SaleSanPham.Id, 
					"@TenSanPham",  _SaleSanPham.TenSanPham, 
					"@DonViTinh",  _SaleSanPham.DonViTinh, 
					"@QuyCach",  _SaleSanPham.QuyCach, 
					"@HeSoQuyDoi",  _SaleSanPham.HeSoQuyDoi, 
					"@FK_NhomSanPham",  _SaleSanPham.FK_NhomSanPham);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SaleSanPham vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SaleSanPham> _SaleSanPhams)
		{
			foreach (SaleSanPham item in _SaleSanPhams)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleSanPham vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SaleSanPham _SaleSanPham, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleSanPham] SET Id=@Id, TenSanPham=@TenSanPham, DonViTinh=@DonViTinh, QuyCach=@QuyCach, HeSoQuyDoi=@HeSoQuyDoi, FK_NhomSanPham=@FK_NhomSanPham WHERE Id=@Id", 
					"@Id",  _SaleSanPham.Id, 
					"@TenSanPham",  _SaleSanPham.TenSanPham, 
					"@DonViTinh",  _SaleSanPham.DonViTinh, 
					"@QuyCach",  _SaleSanPham.QuyCach, 
					"@HeSoQuyDoi",  _SaleSanPham.HeSoQuyDoi, 
					"@FK_NhomSanPham",  _SaleSanPham.FK_NhomSanPham, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SaleSanPham vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SaleSanPham _SaleSanPham)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleSanPham] SET TenSanPham=@TenSanPham, DonViTinh=@DonViTinh, QuyCach=@QuyCach, HeSoQuyDoi=@HeSoQuyDoi, FK_NhomSanPham=@FK_NhomSanPham WHERE Id=@Id", 
					"@TenSanPham",  _SaleSanPham.TenSanPham, 
					"@DonViTinh",  _SaleSanPham.DonViTinh, 
					"@QuyCach",  _SaleSanPham.QuyCach, 
					"@HeSoQuyDoi",  _SaleSanPham.HeSoQuyDoi, 
					"@FK_NhomSanPham",  _SaleSanPham.FK_NhomSanPham, 
					"@Id", _SaleSanPham.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SaleSanPham vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SaleSanPham> _SaleSanPhams)
		{
			foreach (SaleSanPham item in _SaleSanPhams)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleSanPham vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SaleSanPham _SaleSanPham, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleSanPham] SET Id=@Id, TenSanPham=@TenSanPham, DonViTinh=@DonViTinh, QuyCach=@QuyCach, HeSoQuyDoi=@HeSoQuyDoi, FK_NhomSanPham=@FK_NhomSanPham "+ condition, 
					"@Id",  _SaleSanPham.Id, 
					"@TenSanPham",  _SaleSanPham.TenSanPham, 
					"@DonViTinh",  _SaleSanPham.DonViTinh, 
					"@QuyCach",  _SaleSanPham.QuyCach, 
					"@HeSoQuyDoi",  _SaleSanPham.HeSoQuyDoi, 
					"@FK_NhomSanPham",  _SaleSanPham.FK_NhomSanPham);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SaleSanPham trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleSanPham] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleSanPham trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SaleSanPham _SaleSanPham)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleSanPham] WHERE Id=@Id",
					"@Id", _SaleSanPham.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleSanPham trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleSanPham] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleSanPham trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SaleSanPham> _SaleSanPhams)
		{
			foreach (SaleSanPham item in _SaleSanPhams)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
