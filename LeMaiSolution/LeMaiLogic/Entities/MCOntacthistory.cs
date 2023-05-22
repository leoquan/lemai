using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MCOntacthistory:ICOntacthistory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MCOntacthistory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ContactHistory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ContactHistory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ContactHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ContactHistory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ContactHistory từ Database
		/// </summary>
		public List<ContactHistory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ContactHistory]");
				List<ContactHistory> items = new List<ContactHistory>();
				ContactHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ContactHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["Title"] != null && dr["Title"] != DBNull.Value)
					{
						item.Title = Convert.ToString(dr["Title"]);
					}
					if (dr["ContactMesage"] != null && dr["ContactMesage"] != DBNull.Value)
					{
						item.ContactMesage = Convert.ToString(dr["ContactMesage"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["IsRead"] != null && dr["IsRead"] != DBNull.Value)
					{
						item.IsRead = Convert.ToBoolean(dr["IsRead"]);
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
		/// Lấy danh sách ContactHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ContactHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ContactHistory] A "+ condition,  parameters);
				List<ContactHistory> items = new List<ContactHistory>();
				ContactHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ContactHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["Title"] != null && dr["Title"] != DBNull.Value)
					{
						item.Title = Convert.ToString(dr["Title"]);
					}
					if (dr["ContactMesage"] != null && dr["ContactMesage"] != DBNull.Value)
					{
						item.ContactMesage = Convert.ToString(dr["ContactMesage"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["IsRead"] != null && dr["IsRead"] != DBNull.Value)
					{
						item.IsRead = Convert.ToBoolean(dr["IsRead"]);
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

		public List<ContactHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ContactHistory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ContactHistory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ContactHistory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ContactHistory từ Database
		/// </summary>
		public ContactHistory GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ContactHistory] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ContactHistory item=new ContactHistory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["Title"] != null && dr["Title"] != DBNull.Value)
						{
							item.Title = Convert.ToString(dr["Title"]);
						}
						if (dr["ContactMesage"] != null && dr["ContactMesage"] != DBNull.Value)
						{
							item.ContactMesage = Convert.ToString(dr["ContactMesage"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["IsRead"] != null && dr["IsRead"] != DBNull.Value)
						{
							item.IsRead = Convert.ToBoolean(dr["IsRead"]);
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
		/// Lấy một ContactHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ContactHistory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ContactHistory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ContactHistory item=new ContactHistory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["Title"] != null && dr["Title"] != DBNull.Value)
						{
							item.Title = Convert.ToString(dr["Title"]);
						}
						if (dr["ContactMesage"] != null && dr["ContactMesage"] != DBNull.Value)
						{
							item.ContactMesage = Convert.ToString(dr["ContactMesage"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["IsRead"] != null && dr["IsRead"] != DBNull.Value)
						{
							item.IsRead = Convert.ToBoolean(dr["IsRead"]);
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

		public ContactHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ContactHistory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ContactHistory>(ds);
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
		/// Thêm mới ContactHistory vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ContactHistory _ContactHistory)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ContactHistory](Id, Name, Phone, Email, Title, ContactMesage, CreateDate, IsRead) VALUES(@Id, @Name, @Phone, @Email, @Title, @ContactMesage, @CreateDate, @IsRead)", 
					"@Id",  _ContactHistory.Id, 
					"@Name",  _ContactHistory.Name, 
					"@Phone",  _ContactHistory.Phone, 
					"@Email",  _ContactHistory.Email, 
					"@Title",  _ContactHistory.Title, 
					"@ContactMesage",  _ContactHistory.ContactMesage, 
					"@CreateDate", this._dataContext.ConvertDateString( _ContactHistory.CreateDate), 
					"@IsRead",  _ContactHistory.IsRead);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ContactHistory vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ContactHistory> _ContactHistorys)
		{
			foreach (ContactHistory item in _ContactHistorys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ContactHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ContactHistory _ContactHistory, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ContactHistory] SET Id=@Id, Name=@Name, Phone=@Phone, Email=@Email, Title=@Title, ContactMesage=@ContactMesage, CreateDate=@CreateDate, IsRead=@IsRead WHERE Id=@Id", 
					"@Id",  _ContactHistory.Id, 
					"@Name",  _ContactHistory.Name, 
					"@Phone",  _ContactHistory.Phone, 
					"@Email",  _ContactHistory.Email, 
					"@Title",  _ContactHistory.Title, 
					"@ContactMesage",  _ContactHistory.ContactMesage, 
					"@CreateDate", this._dataContext.ConvertDateString( _ContactHistory.CreateDate), 
					"@IsRead",  _ContactHistory.IsRead, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ContactHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ContactHistory _ContactHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ContactHistory] SET Name=@Name, Phone=@Phone, Email=@Email, Title=@Title, ContactMesage=@ContactMesage, CreateDate=@CreateDate, IsRead=@IsRead WHERE Id=@Id", 
					"@Name",  _ContactHistory.Name, 
					"@Phone",  _ContactHistory.Phone, 
					"@Email",  _ContactHistory.Email, 
					"@Title",  _ContactHistory.Title, 
					"@ContactMesage",  _ContactHistory.ContactMesage, 
					"@CreateDate", this._dataContext.ConvertDateString( _ContactHistory.CreateDate), 
					"@IsRead",  _ContactHistory.IsRead, 
					"@Id", _ContactHistory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ContactHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ContactHistory> _ContactHistorys)
		{
			foreach (ContactHistory item in _ContactHistorys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ContactHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ContactHistory _ContactHistory, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ContactHistory] SET Id=@Id, Name=@Name, Phone=@Phone, Email=@Email, Title=@Title, ContactMesage=@ContactMesage, CreateDate=@CreateDate, IsRead=@IsRead "+ condition, 
					"@Id",  _ContactHistory.Id, 
					"@Name",  _ContactHistory.Name, 
					"@Phone",  _ContactHistory.Phone, 
					"@Email",  _ContactHistory.Email, 
					"@Title",  _ContactHistory.Title, 
					"@ContactMesage",  _ContactHistory.ContactMesage, 
					"@CreateDate", this._dataContext.ConvertDateString( _ContactHistory.CreateDate), 
					"@IsRead",  _ContactHistory.IsRead);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ContactHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ContactHistory] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ContactHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ContactHistory _ContactHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ContactHistory] WHERE Id=@Id",
					"@Id", _ContactHistory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ContactHistory trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ContactHistory] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ContactHistory trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ContactHistory> _ContactHistorys)
		{
			foreach (ContactHistory item in _ContactHistorys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
