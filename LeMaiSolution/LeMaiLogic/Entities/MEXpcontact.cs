using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcontact:IEXpcontact
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcontact(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpContact từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpContact]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpContact từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpContact] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpContact từ Database
		/// </summary>
		public List<ExpContact> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpContact]");
				List<ExpContact> items = new List<ExpContact>();
				ExpContact item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpContact();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["PostName"] != null && dr["PostName"] != DBNull.Value)
					{
						item.PostName = Convert.ToString(dr["PostName"]);
					}
					if (dr["Zalo"] != null && dr["Zalo"] != DBNull.Value)
					{
						item.Zalo = Convert.ToString(dr["Zalo"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
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
		/// Lấy danh sách ExpContact từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpContact> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpContact] A "+ condition,  parameters);
				List<ExpContact> items = new List<ExpContact>();
				ExpContact item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpContact();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["PostName"] != null && dr["PostName"] != DBNull.Value)
					{
						item.PostName = Convert.ToString(dr["PostName"]);
					}
					if (dr["Zalo"] != null && dr["Zalo"] != DBNull.Value)
					{
						item.Zalo = Convert.ToString(dr["Zalo"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
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

		public List<ExpContact> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpContact] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpContact] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpContact>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpContact từ Database
		/// </summary>
		public ExpContact GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpContact] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpContact item=new ExpContact();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["PostName"] != null && dr["PostName"] != DBNull.Value)
						{
							item.PostName = Convert.ToString(dr["PostName"]);
						}
						if (dr["Zalo"] != null && dr["Zalo"] != DBNull.Value)
						{
							item.Zalo = Convert.ToString(dr["Zalo"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
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
		/// Lấy một ExpContact đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpContact GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpContact] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpContact item=new ExpContact();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["PostName"] != null && dr["PostName"] != DBNull.Value)
						{
							item.PostName = Convert.ToString(dr["PostName"]);
						}
						if (dr["Zalo"] != null && dr["Zalo"] != DBNull.Value)
						{
							item.Zalo = Convert.ToString(dr["Zalo"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
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

		public ExpContact GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpContact] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpContact>(ds);
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
		/// Thêm mới ExpContact vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpContact _ExpContact)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpContact](Id, PostName, Zalo, Phone) VALUES(@Id, @PostName, @Zalo, @Phone)", 
					"@Id",  _ExpContact.Id, 
					"@PostName",  _ExpContact.PostName, 
					"@Zalo",  _ExpContact.Zalo, 
					"@Phone",  _ExpContact.Phone);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpContact vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpContact> _ExpContacts)
		{
			foreach (ExpContact item in _ExpContacts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpContact vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpContact _ExpContact, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpContact] SET Id=@Id, PostName=@PostName, Zalo=@Zalo, Phone=@Phone WHERE Id=@Id", 
					"@Id",  _ExpContact.Id, 
					"@PostName",  _ExpContact.PostName, 
					"@Zalo",  _ExpContact.Zalo, 
					"@Phone",  _ExpContact.Phone, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpContact vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpContact _ExpContact)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpContact] SET PostName=@PostName, Zalo=@Zalo, Phone=@Phone WHERE Id=@Id", 
					"@PostName",  _ExpContact.PostName, 
					"@Zalo",  _ExpContact.Zalo, 
					"@Phone",  _ExpContact.Phone, 
					"@Id", _ExpContact.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpContact vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpContact> _ExpContacts)
		{
			foreach (ExpContact item in _ExpContacts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpContact vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpContact _ExpContact, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpContact] SET Id=@Id, PostName=@PostName, Zalo=@Zalo, Phone=@Phone "+ condition, 
					"@Id",  _ExpContact.Id, 
					"@PostName",  _ExpContact.PostName, 
					"@Zalo",  _ExpContact.Zalo, 
					"@Phone",  _ExpContact.Phone);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpContact trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpContact] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpContact trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpContact _ExpContact)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpContact] WHERE Id=@Id",
					"@Id", _ExpContact.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpContact trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpContact] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpContact trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpContact> _ExpContacts)
		{
			foreach (ExpContact item in _ExpContacts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
