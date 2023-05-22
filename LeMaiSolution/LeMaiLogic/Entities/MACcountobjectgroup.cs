using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MACcountobjectgroup:IACcountobjectgroup
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MACcountobjectgroup(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable AccountObjectGroup từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectGroup]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable AccountObjectGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectGroup] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách AccountObjectGroup từ Database
		/// </summary>
		public List<AccountObjectGroup> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectGroup]");
				List<AccountObjectGroup> items = new List<AccountObjectGroup>();
				AccountObjectGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
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
		/// Lấy danh sách AccountObjectGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<AccountObjectGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectGroup] A "+ condition,  parameters);
				List<AccountObjectGroup> items = new List<AccountObjectGroup>();
				AccountObjectGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
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

		public List<AccountObjectGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectGroup] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[AccountObjectGroup] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<AccountObjectGroup>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một AccountObjectGroup từ Database
		/// </summary>
		public AccountObjectGroup GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectGroup] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					AccountObjectGroup item=new AccountObjectGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
						{
							item.GroupName = Convert.ToString(dr["GroupName"]);
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
		/// Lấy một AccountObjectGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public AccountObjectGroup GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectGroup] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					AccountObjectGroup item=new AccountObjectGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
						{
							item.GroupName = Convert.ToString(dr["GroupName"]);
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

		public AccountObjectGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectGroup] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<AccountObjectGroup>(ds);
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
		/// Thêm mới AccountObjectGroup vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, AccountObjectGroup _AccountObjectGroup)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[AccountObjectGroup](Id, GroupName) VALUES(@Id, @GroupName)", 
					"@Id",  _AccountObjectGroup.Id, 
					"@GroupName",  _AccountObjectGroup.GroupName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng AccountObjectGroup vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<AccountObjectGroup> _AccountObjectGroups)
		{
			foreach (AccountObjectGroup item in _AccountObjectGroups)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, AccountObjectGroup _AccountObjectGroup, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectGroup] SET Id=@Id, GroupName=@GroupName WHERE Id=@Id", 
					"@Id",  _AccountObjectGroup.Id, 
					"@GroupName",  _AccountObjectGroup.GroupName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, AccountObjectGroup _AccountObjectGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectGroup] SET GroupName=@GroupName WHERE Id=@Id", 
					"@GroupName",  _AccountObjectGroup.GroupName, 
					"@Id", _AccountObjectGroup.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách AccountObjectGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<AccountObjectGroup> _AccountObjectGroups)
		{
			foreach (AccountObjectGroup item in _AccountObjectGroups)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, AccountObjectGroup _AccountObjectGroup, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectGroup] SET Id=@Id, GroupName=@GroupName "+ condition, 
					"@Id",  _AccountObjectGroup.Id, 
					"@GroupName",  _AccountObjectGroup.GroupName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa AccountObjectGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectGroup] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, AccountObjectGroup _AccountObjectGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectGroup] WHERE Id=@Id",
					"@Id", _AccountObjectGroup.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectGroup trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectGroup] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectGroup trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<AccountObjectGroup> _AccountObjectGroups)
		{
			foreach (AccountObjectGroup item in _AccountObjectGroups)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
