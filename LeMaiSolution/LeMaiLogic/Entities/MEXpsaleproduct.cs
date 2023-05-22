using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpsaleproduct:IEXpsaleproduct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpsaleproduct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpSaleProduct từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleProduct]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpSaleProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleProduct] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpSaleProduct từ Database
		/// </summary>
		public List<ExpSaleProduct> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleProduct]");
				List<ExpSaleProduct> items = new List<ExpSaleProduct>();
				ExpSaleProduct item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleProduct();
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
					if (dr["SoLuongGiaSi"] != null && dr["SoLuongGiaSi"] != DBNull.Value)
					{
						item.SoLuongGiaSi = Convert.ToInt32(dr["SoLuongGiaSi"]);
					}
					if (dr["GiaLe"] != null && dr["GiaLe"] != DBNull.Value)
					{
						item.GiaLe = Convert.ToInt32(dr["GiaLe"]);
					}
					if (dr["GiaSi"] != null && dr["GiaSi"] != DBNull.Value)
					{
						item.GiaSi = Convert.ToInt32(dr["GiaSi"]);
					}
					if (dr["SoLuongTon"] != null && dr["SoLuongTon"] != DBNull.Value)
					{
						item.SoLuongTon = Convert.ToDecimal(dr["SoLuongTon"]);
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
		/// Lấy danh sách ExpSaleProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpSaleProduct> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleProduct] A "+ condition,  parameters);
				List<ExpSaleProduct> items = new List<ExpSaleProduct>();
				ExpSaleProduct item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleProduct();
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
					if (dr["SoLuongGiaSi"] != null && dr["SoLuongGiaSi"] != DBNull.Value)
					{
						item.SoLuongGiaSi = Convert.ToInt32(dr["SoLuongGiaSi"]);
					}
					if (dr["GiaLe"] != null && dr["GiaLe"] != DBNull.Value)
					{
						item.GiaLe = Convert.ToInt32(dr["GiaLe"]);
					}
					if (dr["GiaSi"] != null && dr["GiaSi"] != DBNull.Value)
					{
						item.GiaSi = Convert.ToInt32(dr["GiaSi"]);
					}
					if (dr["SoLuongTon"] != null && dr["SoLuongTon"] != DBNull.Value)
					{
						item.SoLuongTon = Convert.ToDecimal(dr["SoLuongTon"]);
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

		public List<ExpSaleProduct> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleProduct] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpSaleProduct] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpSaleProduct>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpSaleProduct từ Database
		/// </summary>
		public ExpSaleProduct GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleProduct] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpSaleProduct item=new ExpSaleProduct();
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
						if (dr["SoLuongGiaSi"] != null && dr["SoLuongGiaSi"] != DBNull.Value)
						{
							item.SoLuongGiaSi = Convert.ToInt32(dr["SoLuongGiaSi"]);
						}
						if (dr["GiaLe"] != null && dr["GiaLe"] != DBNull.Value)
						{
							item.GiaLe = Convert.ToInt32(dr["GiaLe"]);
						}
						if (dr["GiaSi"] != null && dr["GiaSi"] != DBNull.Value)
						{
							item.GiaSi = Convert.ToInt32(dr["GiaSi"]);
						}
						if (dr["SoLuongTon"] != null && dr["SoLuongTon"] != DBNull.Value)
						{
							item.SoLuongTon = Convert.ToDecimal(dr["SoLuongTon"]);
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
		/// Lấy một ExpSaleProduct đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpSaleProduct GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleProduct] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpSaleProduct item=new ExpSaleProduct();
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
						if (dr["SoLuongGiaSi"] != null && dr["SoLuongGiaSi"] != DBNull.Value)
						{
							item.SoLuongGiaSi = Convert.ToInt32(dr["SoLuongGiaSi"]);
						}
						if (dr["GiaLe"] != null && dr["GiaLe"] != DBNull.Value)
						{
							item.GiaLe = Convert.ToInt32(dr["GiaLe"]);
						}
						if (dr["GiaSi"] != null && dr["GiaSi"] != DBNull.Value)
						{
							item.GiaSi = Convert.ToInt32(dr["GiaSi"]);
						}
						if (dr["SoLuongTon"] != null && dr["SoLuongTon"] != DBNull.Value)
						{
							item.SoLuongTon = Convert.ToDecimal(dr["SoLuongTon"]);
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

		public ExpSaleProduct GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleProduct] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpSaleProduct>(ds);
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
		/// Thêm mới ExpSaleProduct vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpSaleProduct _ExpSaleProduct)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpSaleProduct](Id, TenSanPham, DonViTinh, SoLuongGiaSi, GiaLe, GiaSi, SoLuongTon) VALUES(@Id, @TenSanPham, @DonViTinh, @SoLuongGiaSi, @GiaLe, @GiaSi, @SoLuongTon)", 
					"@Id",  _ExpSaleProduct.Id, 
					"@TenSanPham",  _ExpSaleProduct.TenSanPham, 
					"@DonViTinh",  _ExpSaleProduct.DonViTinh, 
					"@SoLuongGiaSi",  _ExpSaleProduct.SoLuongGiaSi, 
					"@GiaLe",  _ExpSaleProduct.GiaLe, 
					"@GiaSi",  _ExpSaleProduct.GiaSi, 
					"@SoLuongTon",  _ExpSaleProduct.SoLuongTon);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpSaleProduct vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpSaleProduct> _ExpSaleProducts)
		{
			foreach (ExpSaleProduct item in _ExpSaleProducts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpSaleProduct _ExpSaleProduct, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleProduct] SET Id=@Id, TenSanPham=@TenSanPham, DonViTinh=@DonViTinh, SoLuongGiaSi=@SoLuongGiaSi, GiaLe=@GiaLe, GiaSi=@GiaSi, SoLuongTon=@SoLuongTon WHERE Id=@Id", 
					"@Id",  _ExpSaleProduct.Id, 
					"@TenSanPham",  _ExpSaleProduct.TenSanPham, 
					"@DonViTinh",  _ExpSaleProduct.DonViTinh, 
					"@SoLuongGiaSi",  _ExpSaleProduct.SoLuongGiaSi, 
					"@GiaLe",  _ExpSaleProduct.GiaLe, 
					"@GiaSi",  _ExpSaleProduct.GiaSi, 
					"@SoLuongTon",  _ExpSaleProduct.SoLuongTon, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleProduct vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpSaleProduct _ExpSaleProduct)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleProduct] SET TenSanPham=@TenSanPham, DonViTinh=@DonViTinh, SoLuongGiaSi=@SoLuongGiaSi, GiaLe=@GiaLe, GiaSi=@GiaSi, SoLuongTon=@SoLuongTon WHERE Id=@Id", 
					"@TenSanPham",  _ExpSaleProduct.TenSanPham, 
					"@DonViTinh",  _ExpSaleProduct.DonViTinh, 
					"@SoLuongGiaSi",  _ExpSaleProduct.SoLuongGiaSi, 
					"@GiaLe",  _ExpSaleProduct.GiaLe, 
					"@GiaSi",  _ExpSaleProduct.GiaSi, 
					"@SoLuongTon",  _ExpSaleProduct.SoLuongTon, 
					"@Id", _ExpSaleProduct.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpSaleProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpSaleProduct> _ExpSaleProducts)
		{
			foreach (ExpSaleProduct item in _ExpSaleProducts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleProduct vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpSaleProduct _ExpSaleProduct, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleProduct] SET Id=@Id, TenSanPham=@TenSanPham, DonViTinh=@DonViTinh, SoLuongGiaSi=@SoLuongGiaSi, GiaLe=@GiaLe, GiaSi=@GiaSi, SoLuongTon=@SoLuongTon "+ condition, 
					"@Id",  _ExpSaleProduct.Id, 
					"@TenSanPham",  _ExpSaleProduct.TenSanPham, 
					"@DonViTinh",  _ExpSaleProduct.DonViTinh, 
					"@SoLuongGiaSi",  _ExpSaleProduct.SoLuongGiaSi, 
					"@GiaLe",  _ExpSaleProduct.GiaLe, 
					"@GiaSi",  _ExpSaleProduct.GiaSi, 
					"@SoLuongTon",  _ExpSaleProduct.SoLuongTon);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpSaleProduct trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleProduct] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleProduct trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpSaleProduct _ExpSaleProduct)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleProduct] WHERE Id=@Id",
					"@Id", _ExpSaleProduct.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleProduct trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleProduct] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleProduct trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpSaleProduct> _ExpSaleProducts)
		{
			foreach (ExpSaleProduct item in _ExpSaleProducts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
