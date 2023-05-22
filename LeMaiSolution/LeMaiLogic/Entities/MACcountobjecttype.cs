using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MACcountobjecttype:IACcountobjecttype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MACcountobjecttype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable AccountObjectType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable AccountObjectType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách AccountObjectType từ Database
		/// </summary>
		public List<AccountObjectType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectType]");
				List<AccountObjectType> items = new List<AccountObjectType>();
				AccountObjectType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["AccountTypeName"] != null && dr["AccountTypeName"] != DBNull.Value)
					{
						item.AccountTypeName = Convert.ToString(dr["AccountTypeName"]);
					}
					if (dr["NhomTaiKhoan"] != null && dr["NhomTaiKhoan"] != DBNull.Value)
					{
						item.NhomTaiKhoan = Convert.ToString(dr["NhomTaiKhoan"]);
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
		/// Lấy danh sách AccountObjectType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<AccountObjectType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectType] A "+ condition,  parameters);
				List<AccountObjectType> items = new List<AccountObjectType>();
				AccountObjectType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["AccountTypeName"] != null && dr["AccountTypeName"] != DBNull.Value)
					{
						item.AccountTypeName = Convert.ToString(dr["AccountTypeName"]);
					}
					if (dr["NhomTaiKhoan"] != null && dr["NhomTaiKhoan"] != DBNull.Value)
					{
						item.NhomTaiKhoan = Convert.ToString(dr["NhomTaiKhoan"]);
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

		public List<AccountObjectType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[AccountObjectType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<AccountObjectType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một AccountObjectType từ Database
		/// </summary>
		public AccountObjectType GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					AccountObjectType item=new AccountObjectType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["AccountTypeName"] != null && dr["AccountTypeName"] != DBNull.Value)
						{
							item.AccountTypeName = Convert.ToString(dr["AccountTypeName"]);
						}
						if (dr["NhomTaiKhoan"] != null && dr["NhomTaiKhoan"] != DBNull.Value)
						{
							item.NhomTaiKhoan = Convert.ToString(dr["NhomTaiKhoan"]);
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
		/// Lấy một AccountObjectType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public AccountObjectType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					AccountObjectType item=new AccountObjectType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["AccountTypeName"] != null && dr["AccountTypeName"] != DBNull.Value)
						{
							item.AccountTypeName = Convert.ToString(dr["AccountTypeName"]);
						}
						if (dr["NhomTaiKhoan"] != null && dr["NhomTaiKhoan"] != DBNull.Value)
						{
							item.NhomTaiKhoan = Convert.ToString(dr["NhomTaiKhoan"]);
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

		public AccountObjectType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<AccountObjectType>(ds);
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
		/// Thêm mới AccountObjectType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, AccountObjectType _AccountObjectType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[AccountObjectType](Id, AccountTypeName, NhomTaiKhoan) VALUES(@Id, @AccountTypeName, @NhomTaiKhoan)", 
					"@Id",  _AccountObjectType.Id, 
					"@AccountTypeName",  _AccountObjectType.AccountTypeName, 
					"@NhomTaiKhoan",  _AccountObjectType.NhomTaiKhoan);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng AccountObjectType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<AccountObjectType> _AccountObjectTypes)
		{
			foreach (AccountObjectType item in _AccountObjectTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, AccountObjectType _AccountObjectType, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectType] SET Id=@Id, AccountTypeName=@AccountTypeName, NhomTaiKhoan=@NhomTaiKhoan WHERE Id=@Id", 
					"@Id",  _AccountObjectType.Id, 
					"@AccountTypeName",  _AccountObjectType.AccountTypeName, 
					"@NhomTaiKhoan",  _AccountObjectType.NhomTaiKhoan, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, AccountObjectType _AccountObjectType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectType] SET AccountTypeName=@AccountTypeName, NhomTaiKhoan=@NhomTaiKhoan WHERE Id=@Id", 
					"@AccountTypeName",  _AccountObjectType.AccountTypeName, 
					"@NhomTaiKhoan",  _AccountObjectType.NhomTaiKhoan, 
					"@Id", _AccountObjectType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách AccountObjectType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<AccountObjectType> _AccountObjectTypes)
		{
			foreach (AccountObjectType item in _AccountObjectTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, AccountObjectType _AccountObjectType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectType] SET Id=@Id, AccountTypeName=@AccountTypeName, NhomTaiKhoan=@NhomTaiKhoan "+ condition, 
					"@Id",  _AccountObjectType.Id, 
					"@AccountTypeName",  _AccountObjectType.AccountTypeName, 
					"@NhomTaiKhoan",  _AccountObjectType.NhomTaiKhoan);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa AccountObjectType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, AccountObjectType _AccountObjectType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectType] WHERE Id=@Id",
					"@Id", _AccountObjectType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<AccountObjectType> _AccountObjectTypes)
		{
			foreach (AccountObjectType item in _AccountObjectTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
