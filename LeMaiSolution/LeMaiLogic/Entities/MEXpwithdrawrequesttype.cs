using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpwithdrawrequesttype:IEXpwithdrawrequesttype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpwithdrawrequesttype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequestType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequestType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequestType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequestType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpWithdrawRequestType từ Database
		/// </summary>
		public List<ExpWithdrawRequestType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequestType]");
				List<ExpWithdrawRequestType> items = new List<ExpWithdrawRequestType>();
				ExpWithdrawRequestType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpWithdrawRequestType();
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
		/// Lấy danh sách ExpWithdrawRequestType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpWithdrawRequestType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpWithdrawRequestType] A "+ condition,  parameters);
				List<ExpWithdrawRequestType> items = new List<ExpWithdrawRequestType>();
				ExpWithdrawRequestType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpWithdrawRequestType();
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

		public List<ExpWithdrawRequestType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpWithdrawRequestType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpWithdrawRequestType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpWithdrawRequestType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpWithdrawRequestType từ Database
		/// </summary>
		public ExpWithdrawRequestType GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequestType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpWithdrawRequestType item=new ExpWithdrawRequestType();
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
		/// Lấy một ExpWithdrawRequestType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpWithdrawRequestType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpWithdrawRequestType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpWithdrawRequestType item=new ExpWithdrawRequestType();
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

		public ExpWithdrawRequestType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpWithdrawRequestType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpWithdrawRequestType>(ds);
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
		/// Thêm mới ExpWithdrawRequestType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpWithdrawRequestType _ExpWithdrawRequestType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpWithdrawRequestType](Id, TypeName) VALUES(@Id, @TypeName)", 
					"@Id",  _ExpWithdrawRequestType.Id, 
					"@TypeName",  _ExpWithdrawRequestType.TypeName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpWithdrawRequestType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpWithdrawRequestType> _ExpWithdrawRequestTypes)
		{
			foreach (ExpWithdrawRequestType item in _ExpWithdrawRequestTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpWithdrawRequestType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpWithdrawRequestType _ExpWithdrawRequestType, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithdrawRequestType] SET Id=@Id, TypeName=@TypeName WHERE Id=@Id", 
					"@Id",  _ExpWithdrawRequestType.Id, 
					"@TypeName",  _ExpWithdrawRequestType.TypeName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpWithdrawRequestType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpWithdrawRequestType _ExpWithdrawRequestType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithdrawRequestType] SET TypeName=@TypeName WHERE Id=@Id", 
					"@TypeName",  _ExpWithdrawRequestType.TypeName, 
					"@Id", _ExpWithdrawRequestType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpWithdrawRequestType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpWithdrawRequestType> _ExpWithdrawRequestTypes)
		{
			foreach (ExpWithdrawRequestType item in _ExpWithdrawRequestTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpWithdrawRequestType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpWithdrawRequestType _ExpWithdrawRequestType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithdrawRequestType] SET Id=@Id, TypeName=@TypeName "+ condition, 
					"@Id",  _ExpWithdrawRequestType.Id, 
					"@TypeName",  _ExpWithdrawRequestType.TypeName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpWithdrawRequestType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithdrawRequestType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithdrawRequestType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpWithdrawRequestType _ExpWithdrawRequestType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithdrawRequestType] WHERE Id=@Id",
					"@Id", _ExpWithdrawRequestType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithdrawRequestType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithdrawRequestType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithdrawRequestType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpWithdrawRequestType> _ExpWithdrawRequestTypes)
		{
			foreach (ExpWithdrawRequestType item in _ExpWithdrawRequestTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
