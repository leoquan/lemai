using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MACcountobjectandgroup:IACcountobjectandgroup
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MACcountobjectandgroup(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable AccountObjectAndGroup từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectAndGroup]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable AccountObjectAndGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectAndGroup] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách AccountObjectAndGroup từ Database
		/// </summary>
		public List<AccountObjectAndGroup> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectAndGroup]");
				List<AccountObjectAndGroup> items = new List<AccountObjectAndGroup>();
				AccountObjectAndGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectAndGroup();
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
					{
						item.FK_Group = Convert.ToString(dr["FK_Group"]);
					}
					if (dr["Valid"] != null && dr["Valid"] != DBNull.Value)
					{
						item.Valid = Convert.ToDateTime(dr["Valid"]);
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
		/// Lấy danh sách AccountObjectAndGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<AccountObjectAndGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectAndGroup] A "+ condition,  parameters);
				List<AccountObjectAndGroup> items = new List<AccountObjectAndGroup>();
				AccountObjectAndGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectAndGroup();
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
					{
						item.FK_Group = Convert.ToString(dr["FK_Group"]);
					}
					if (dr["Valid"] != null && dr["Valid"] != DBNull.Value)
					{
						item.Valid = Convert.ToDateTime(dr["Valid"]);
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

		public List<AccountObjectAndGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectAndGroup] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[AccountObjectAndGroup] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<AccountObjectAndGroup>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một AccountObjectAndGroup từ Database
		/// </summary>
		public AccountObjectAndGroup GetObject(string schema, String FK_Account, String FK_Group)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectAndGroup] where FK_Account=@FK_Account and FK_Group=@FK_Group",
					"@FK_Account", FK_Account, 
					"@FK_Group", FK_Group);
				if (ds.Rows.Count > 0)
				{
					AccountObjectAndGroup item=new AccountObjectAndGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
						{
							item.FK_Group = Convert.ToString(dr["FK_Group"]);
						}
						if (dr["Valid"] != null && dr["Valid"] != DBNull.Value)
						{
							item.Valid = Convert.ToDateTime(dr["Valid"]);
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
		/// Lấy một AccountObjectAndGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public AccountObjectAndGroup GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectAndGroup] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					AccountObjectAndGroup item=new AccountObjectAndGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
						{
							item.FK_Group = Convert.ToString(dr["FK_Group"]);
						}
						if (dr["Valid"] != null && dr["Valid"] != DBNull.Value)
						{
							item.Valid = Convert.ToDateTime(dr["Valid"]);
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

		public AccountObjectAndGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectAndGroup] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<AccountObjectAndGroup>(ds);
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
		/// Thêm mới AccountObjectAndGroup vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, AccountObjectAndGroup _AccountObjectAndGroup)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[AccountObjectAndGroup](FK_Account, FK_Group, Valid) VALUES(@FK_Account, @FK_Group, @Valid)", 
					"@FK_Account",  _AccountObjectAndGroup.FK_Account, 
					"@FK_Group",  _AccountObjectAndGroup.FK_Group, 
					"@Valid", this._dataContext.ConvertDateString( _AccountObjectAndGroup.Valid));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng AccountObjectAndGroup vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<AccountObjectAndGroup> _AccountObjectAndGroups)
		{
			foreach (AccountObjectAndGroup item in _AccountObjectAndGroups)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectAndGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, AccountObjectAndGroup _AccountObjectAndGroup, String FK_Account, String FK_Group)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectAndGroup] SET FK_Account=@FK_Account, FK_Group=@FK_Group, Valid=@Valid WHERE FK_Account=@FK_Account and FK_Group=@FK_Group", 
					"@FK_Account",  _AccountObjectAndGroup.FK_Account, 
					"@FK_Group",  _AccountObjectAndGroup.FK_Group, 
					"@Valid", this._dataContext.ConvertDateString( _AccountObjectAndGroup.Valid), 
					"@FK_Account", FK_Account, 
					"@FK_Group", FK_Group);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectAndGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, AccountObjectAndGroup _AccountObjectAndGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectAndGroup] SET Valid=@Valid WHERE FK_Account=@FK_Account and FK_Group=@FK_Group", 
					"@Valid", this._dataContext.ConvertDateString( _AccountObjectAndGroup.Valid), 
					"@FK_Account", _AccountObjectAndGroup.FK_Account, 
					"@FK_Group", _AccountObjectAndGroup.FK_Group);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách AccountObjectAndGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<AccountObjectAndGroup> _AccountObjectAndGroups)
		{
			foreach (AccountObjectAndGroup item in _AccountObjectAndGroups)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectAndGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, AccountObjectAndGroup _AccountObjectAndGroup, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectAndGroup] SET FK_Account=@FK_Account, FK_Group=@FK_Group, Valid=@Valid "+ condition, 
					"@FK_Account",  _AccountObjectAndGroup.FK_Account, 
					"@FK_Group",  _AccountObjectAndGroup.FK_Group, 
					"@Valid", this._dataContext.ConvertDateString( _AccountObjectAndGroup.Valid));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa AccountObjectAndGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_Account, String FK_Group)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectAndGroup] WHERE FK_Account=@FK_Account and FK_Group=@FK_Group",
					"@FK_Account", FK_Account, 
					"@FK_Group", FK_Group);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectAndGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, AccountObjectAndGroup _AccountObjectAndGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectAndGroup] WHERE FK_Account=@FK_Account and FK_Group=@FK_Group",
					"@FK_Account", _AccountObjectAndGroup.FK_Account, 
					"@FK_Group", _AccountObjectAndGroup.FK_Group);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectAndGroup trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectAndGroup] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectAndGroup trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<AccountObjectAndGroup> _AccountObjectAndGroups)
		{
			foreach (AccountObjectAndGroup item in _AccountObjectAndGroups)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
