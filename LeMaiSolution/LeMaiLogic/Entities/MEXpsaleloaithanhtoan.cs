using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpsaleloaithanhtoan:IEXpsaleloaithanhtoan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpsaleloaithanhtoan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpSaleLoaiThanhToan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleLoaiThanhToan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpSaleLoaiThanhToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleLoaiThanhToan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpSaleLoaiThanhToan từ Database
		/// </summary>
		public List<ExpSaleLoaiThanhToan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleLoaiThanhToan]");
				List<ExpSaleLoaiThanhToan> items = new List<ExpSaleLoaiThanhToan>();
				ExpSaleLoaiThanhToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleLoaiThanhToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
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
		/// Lấy danh sách ExpSaleLoaiThanhToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpSaleLoaiThanhToan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleLoaiThanhToan] A "+ condition,  parameters);
				List<ExpSaleLoaiThanhToan> items = new List<ExpSaleLoaiThanhToan>();
				ExpSaleLoaiThanhToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleLoaiThanhToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
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

		public List<ExpSaleLoaiThanhToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleLoaiThanhToan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpSaleLoaiThanhToan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpSaleLoaiThanhToan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpSaleLoaiThanhToan từ Database
		/// </summary>
		public ExpSaleLoaiThanhToan GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleLoaiThanhToan] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpSaleLoaiThanhToan item=new ExpSaleLoaiThanhToan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
						{
							item.TenLoai = Convert.ToString(dr["TenLoai"]);
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
		/// Lấy một ExpSaleLoaiThanhToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpSaleLoaiThanhToan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleLoaiThanhToan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpSaleLoaiThanhToan item=new ExpSaleLoaiThanhToan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
						{
							item.TenLoai = Convert.ToString(dr["TenLoai"]);
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

		public ExpSaleLoaiThanhToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleLoaiThanhToan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpSaleLoaiThanhToan>(ds);
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
		/// Thêm mới ExpSaleLoaiThanhToan vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpSaleLoaiThanhToan _ExpSaleLoaiThanhToan)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpSaleLoaiThanhToan](Id, TenLoai) VALUES(@Id, @TenLoai)", 
					"@Id",  _ExpSaleLoaiThanhToan.Id, 
					"@TenLoai",  _ExpSaleLoaiThanhToan.TenLoai);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpSaleLoaiThanhToan vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpSaleLoaiThanhToan> _ExpSaleLoaiThanhToans)
		{
			foreach (ExpSaleLoaiThanhToan item in _ExpSaleLoaiThanhToans)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleLoaiThanhToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpSaleLoaiThanhToan _ExpSaleLoaiThanhToan, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleLoaiThanhToan] SET Id=@Id, TenLoai=@TenLoai WHERE Id=@Id", 
					"@Id",  _ExpSaleLoaiThanhToan.Id, 
					"@TenLoai",  _ExpSaleLoaiThanhToan.TenLoai, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleLoaiThanhToan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpSaleLoaiThanhToan _ExpSaleLoaiThanhToan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleLoaiThanhToan] SET TenLoai=@TenLoai WHERE Id=@Id", 
					"@TenLoai",  _ExpSaleLoaiThanhToan.TenLoai, 
					"@Id", _ExpSaleLoaiThanhToan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpSaleLoaiThanhToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpSaleLoaiThanhToan> _ExpSaleLoaiThanhToans)
		{
			foreach (ExpSaleLoaiThanhToan item in _ExpSaleLoaiThanhToans)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleLoaiThanhToan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpSaleLoaiThanhToan _ExpSaleLoaiThanhToan, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleLoaiThanhToan] SET Id=@Id, TenLoai=@TenLoai "+ condition, 
					"@Id",  _ExpSaleLoaiThanhToan.Id, 
					"@TenLoai",  _ExpSaleLoaiThanhToan.TenLoai);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpSaleLoaiThanhToan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleLoaiThanhToan] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleLoaiThanhToan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpSaleLoaiThanhToan _ExpSaleLoaiThanhToan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleLoaiThanhToan] WHERE Id=@Id",
					"@Id", _ExpSaleLoaiThanhToan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleLoaiThanhToan trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleLoaiThanhToan] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleLoaiThanhToan trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpSaleLoaiThanhToan> _ExpSaleLoaiThanhToans)
		{
			foreach (ExpSaleLoaiThanhToan item in _ExpSaleLoaiThanhToans)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
