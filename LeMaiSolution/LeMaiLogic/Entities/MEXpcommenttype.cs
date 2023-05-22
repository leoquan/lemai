using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcommenttype:IEXpcommenttype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcommenttype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCommentType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCommentType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCommentType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCommentType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCommentType từ Database
		/// </summary>
		public List<ExpCommentType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCommentType]");
				List<ExpCommentType> items = new List<ExpCommentType>();
				ExpCommentType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCommentType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
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
		/// Lấy danh sách ExpCommentType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCommentType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCommentType] A "+ condition,  parameters);
				List<ExpCommentType> items = new List<ExpCommentType>();
				ExpCommentType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCommentType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
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

		public List<ExpCommentType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCommentType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCommentType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCommentType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCommentType từ Database
		/// </summary>
		public ExpCommentType GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCommentType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpCommentType item=new ExpCommentType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
						{
							item.TypeName = Convert.ToString(dr["TypeName"]);
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
		/// Lấy một ExpCommentType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCommentType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCommentType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCommentType item=new ExpCommentType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
						{
							item.TypeName = Convert.ToString(dr["TypeName"]);
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

		public ExpCommentType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCommentType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCommentType>(ds);
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
		/// Thêm mới ExpCommentType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCommentType _ExpCommentType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCommentType](Id, TypeName) VALUES(@Id, @TypeName)", 
					"@Id",  _ExpCommentType.Id, 
					"@TypeName",  _ExpCommentType.TypeName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCommentType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCommentType> _ExpCommentTypes)
		{
			foreach (ExpCommentType item in _ExpCommentTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCommentType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCommentType _ExpCommentType, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCommentType] SET Id=@Id, TypeName=@TypeName WHERE Id=@Id", 
					"@Id",  _ExpCommentType.Id, 
					"@TypeName",  _ExpCommentType.TypeName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCommentType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCommentType _ExpCommentType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCommentType] SET TypeName=@TypeName WHERE Id=@Id", 
					"@TypeName",  _ExpCommentType.TypeName, 
					"@Id", _ExpCommentType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCommentType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCommentType> _ExpCommentTypes)
		{
			foreach (ExpCommentType item in _ExpCommentTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCommentType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCommentType _ExpCommentType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCommentType] SET Id=@Id, TypeName=@TypeName "+ condition, 
					"@Id",  _ExpCommentType.Id, 
					"@TypeName",  _ExpCommentType.TypeName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCommentType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCommentType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCommentType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCommentType _ExpCommentType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCommentType] WHERE Id=@Id",
					"@Id", _ExpCommentType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCommentType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCommentType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCommentType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCommentType> _ExpCommentTypes)
		{
			foreach (ExpCommentType item in _ExpCommentTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
