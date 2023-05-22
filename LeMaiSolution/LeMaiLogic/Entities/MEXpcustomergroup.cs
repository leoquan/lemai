using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcustomergroup:IEXpcustomergroup
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcustomergroup(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCustomerGroup từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomerGroup]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCustomerGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomerGroup] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCustomerGroup từ Database
		/// </summary>
		public List<ExpCustomerGroup> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomerGroup]");
				List<ExpCustomerGroup> items = new List<ExpCustomerGroup>();
				ExpCustomerGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCustomerGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenNhom"] != null && dr["TenNhom"] != DBNull.Value)
					{
						item.TenNhom = Convert.ToString(dr["TenNhom"]);
					}
					if (dr["MacDinh"] != null && dr["MacDinh"] != DBNull.Value)
					{
						item.MacDinh = Convert.ToBoolean(dr["MacDinh"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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
		/// Lấy danh sách ExpCustomerGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCustomerGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCustomerGroup] A "+ condition,  parameters);
				List<ExpCustomerGroup> items = new List<ExpCustomerGroup>();
				ExpCustomerGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCustomerGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenNhom"] != null && dr["TenNhom"] != DBNull.Value)
					{
						item.TenNhom = Convert.ToString(dr["TenNhom"]);
					}
					if (dr["MacDinh"] != null && dr["MacDinh"] != DBNull.Value)
					{
						item.MacDinh = Convert.ToBoolean(dr["MacDinh"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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

		public List<ExpCustomerGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCustomerGroup] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCustomerGroup] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCustomerGroup>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCustomerGroup từ Database
		/// </summary>
		public ExpCustomerGroup GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomerGroup] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpCustomerGroup item=new ExpCustomerGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["TenNhom"] != null && dr["TenNhom"] != DBNull.Value)
						{
							item.TenNhom = Convert.ToString(dr["TenNhom"]);
						}
						if (dr["MacDinh"] != null && dr["MacDinh"] != DBNull.Value)
						{
							item.MacDinh = Convert.ToBoolean(dr["MacDinh"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
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
		/// Lấy một ExpCustomerGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCustomerGroup GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCustomerGroup] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCustomerGroup item=new ExpCustomerGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["TenNhom"] != null && dr["TenNhom"] != DBNull.Value)
						{
							item.TenNhom = Convert.ToString(dr["TenNhom"]);
						}
						if (dr["MacDinh"] != null && dr["MacDinh"] != DBNull.Value)
						{
							item.MacDinh = Convert.ToBoolean(dr["MacDinh"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
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

		public ExpCustomerGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCustomerGroup] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCustomerGroup>(ds);
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
		/// Thêm mới ExpCustomerGroup vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCustomerGroup _ExpCustomerGroup)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCustomerGroup](Id, Code, TenNhom, MacDinh, FK_Post) VALUES(@Id, @Code, @TenNhom, @MacDinh, @FK_Post)", 
					"@Id",  _ExpCustomerGroup.Id, 
					"@Code",  _ExpCustomerGroup.Code, 
					"@TenNhom",  _ExpCustomerGroup.TenNhom, 
					"@MacDinh",  _ExpCustomerGroup.MacDinh, 
					"@FK_Post",  _ExpCustomerGroup.FK_Post);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCustomerGroup vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCustomerGroup> _ExpCustomerGroups)
		{
			foreach (ExpCustomerGroup item in _ExpCustomerGroups)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCustomerGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCustomerGroup _ExpCustomerGroup, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCustomerGroup] SET Id=@Id, Code=@Code, TenNhom=@TenNhom, MacDinh=@MacDinh, FK_Post=@FK_Post WHERE Id=@Id", 
					"@Id",  _ExpCustomerGroup.Id, 
					"@Code",  _ExpCustomerGroup.Code, 
					"@TenNhom",  _ExpCustomerGroup.TenNhom, 
					"@MacDinh",  _ExpCustomerGroup.MacDinh, 
					"@FK_Post",  _ExpCustomerGroup.FK_Post, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCustomerGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCustomerGroup _ExpCustomerGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCustomerGroup] SET Code=@Code, TenNhom=@TenNhom, MacDinh=@MacDinh, FK_Post=@FK_Post WHERE Id=@Id", 
					"@Code",  _ExpCustomerGroup.Code, 
					"@TenNhom",  _ExpCustomerGroup.TenNhom, 
					"@MacDinh",  _ExpCustomerGroup.MacDinh, 
					"@FK_Post",  _ExpCustomerGroup.FK_Post, 
					"@Id", _ExpCustomerGroup.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCustomerGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCustomerGroup> _ExpCustomerGroups)
		{
			foreach (ExpCustomerGroup item in _ExpCustomerGroups)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCustomerGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCustomerGroup _ExpCustomerGroup, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCustomerGroup] SET Id=@Id, Code=@Code, TenNhom=@TenNhom, MacDinh=@MacDinh, FK_Post=@FK_Post "+ condition, 
					"@Id",  _ExpCustomerGroup.Id, 
					"@Code",  _ExpCustomerGroup.Code, 
					"@TenNhom",  _ExpCustomerGroup.TenNhom, 
					"@MacDinh",  _ExpCustomerGroup.MacDinh, 
					"@FK_Post",  _ExpCustomerGroup.FK_Post);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCustomerGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCustomerGroup] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCustomerGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCustomerGroup _ExpCustomerGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCustomerGroup] WHERE Id=@Id",
					"@Id", _ExpCustomerGroup.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCustomerGroup trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCustomerGroup] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCustomerGroup trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCustomerGroup> _ExpCustomerGroups)
		{
			foreach (ExpCustomerGroup item in _ExpCustomerGroups)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
