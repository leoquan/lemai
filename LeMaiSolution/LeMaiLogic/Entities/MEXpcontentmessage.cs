using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcontentmessage:IEXpcontentmessage
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcontentmessage(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpContentMessage từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpContentMessage]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpContentMessage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpContentMessage] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpContentMessage từ Database
		/// </summary>
		public List<ExpContentMessage> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpContentMessage]");
				List<ExpContentMessage> items = new List<ExpContentMessage>();
				ExpContentMessage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpContentMessage();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["AccessToken"] != null && dr["AccessToken"] != DBNull.Value)
					{
						item.AccessToken = Convert.ToString(dr["AccessToken"]);
					}
					if (dr["RefreshToken"] != null && dr["RefreshToken"] != DBNull.Value)
					{
						item.RefreshToken = Convert.ToString(dr["RefreshToken"]);
					}
					if (dr["ContentMessage"] != null && dr["ContentMessage"] != DBNull.Value)
					{
						item.ContentMessage = Convert.ToString(dr["ContentMessage"]);
					}
					if (dr["NotifyAddress"] != null && dr["NotifyAddress"] != DBNull.Value)
					{
						item.NotifyAddress = Convert.ToString(dr["NotifyAddress"]);
					}
					if (dr["NotifyType"] != null && dr["NotifyType"] != DBNull.Value)
					{
						item.NotifyType = Convert.ToString(dr["NotifyType"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
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
		/// Lấy danh sách ExpContentMessage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpContentMessage> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpContentMessage] A "+ condition,  parameters);
				List<ExpContentMessage> items = new List<ExpContentMessage>();
				ExpContentMessage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpContentMessage();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["AccessToken"] != null && dr["AccessToken"] != DBNull.Value)
					{
						item.AccessToken = Convert.ToString(dr["AccessToken"]);
					}
					if (dr["RefreshToken"] != null && dr["RefreshToken"] != DBNull.Value)
					{
						item.RefreshToken = Convert.ToString(dr["RefreshToken"]);
					}
					if (dr["ContentMessage"] != null && dr["ContentMessage"] != DBNull.Value)
					{
						item.ContentMessage = Convert.ToString(dr["ContentMessage"]);
					}
					if (dr["NotifyAddress"] != null && dr["NotifyAddress"] != DBNull.Value)
					{
						item.NotifyAddress = Convert.ToString(dr["NotifyAddress"]);
					}
					if (dr["NotifyType"] != null && dr["NotifyType"] != DBNull.Value)
					{
						item.NotifyType = Convert.ToString(dr["NotifyType"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
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

		public List<ExpContentMessage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpContentMessage] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpContentMessage] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpContentMessage>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpContentMessage từ Database
		/// </summary>
		public ExpContentMessage GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpContentMessage] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpContentMessage item=new ExpContentMessage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["AccessToken"] != null && dr["AccessToken"] != DBNull.Value)
						{
							item.AccessToken = Convert.ToString(dr["AccessToken"]);
						}
						if (dr["RefreshToken"] != null && dr["RefreshToken"] != DBNull.Value)
						{
							item.RefreshToken = Convert.ToString(dr["RefreshToken"]);
						}
						if (dr["ContentMessage"] != null && dr["ContentMessage"] != DBNull.Value)
						{
							item.ContentMessage = Convert.ToString(dr["ContentMessage"]);
						}
						if (dr["NotifyAddress"] != null && dr["NotifyAddress"] != DBNull.Value)
						{
							item.NotifyAddress = Convert.ToString(dr["NotifyAddress"]);
						}
						if (dr["NotifyType"] != null && dr["NotifyType"] != DBNull.Value)
						{
							item.NotifyType = Convert.ToString(dr["NotifyType"]);
						}
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
						}
						if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
						{
							item.IsDone = Convert.ToBoolean(dr["IsDone"]);
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
		/// Lấy một ExpContentMessage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpContentMessage GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpContentMessage] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpContentMessage item=new ExpContentMessage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["AccessToken"] != null && dr["AccessToken"] != DBNull.Value)
						{
							item.AccessToken = Convert.ToString(dr["AccessToken"]);
						}
						if (dr["RefreshToken"] != null && dr["RefreshToken"] != DBNull.Value)
						{
							item.RefreshToken = Convert.ToString(dr["RefreshToken"]);
						}
						if (dr["ContentMessage"] != null && dr["ContentMessage"] != DBNull.Value)
						{
							item.ContentMessage = Convert.ToString(dr["ContentMessage"]);
						}
						if (dr["NotifyAddress"] != null && dr["NotifyAddress"] != DBNull.Value)
						{
							item.NotifyAddress = Convert.ToString(dr["NotifyAddress"]);
						}
						if (dr["NotifyType"] != null && dr["NotifyType"] != DBNull.Value)
						{
							item.NotifyType = Convert.ToString(dr["NotifyType"]);
						}
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
						}
						if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
						{
							item.IsDone = Convert.ToBoolean(dr["IsDone"]);
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

		public ExpContentMessage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpContentMessage] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpContentMessage>(ds);
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
		/// Thêm mới ExpContentMessage vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpContentMessage _ExpContentMessage)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpContentMessage](Id, AccessToken, RefreshToken, ContentMessage, NotifyAddress, NotifyType, UpdateDate, IsDone) VALUES(@Id, @AccessToken, @RefreshToken, @ContentMessage, @NotifyAddress, @NotifyType, @UpdateDate, @IsDone)", 
					"@Id",  _ExpContentMessage.Id, 
					"@AccessToken",  _ExpContentMessage.AccessToken, 
					"@RefreshToken",  _ExpContentMessage.RefreshToken, 
					"@ContentMessage",  _ExpContentMessage.ContentMessage, 
					"@NotifyAddress",  _ExpContentMessage.NotifyAddress, 
					"@NotifyType",  _ExpContentMessage.NotifyType, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpContentMessage.UpdateDate), 
					"@IsDone",  _ExpContentMessage.IsDone);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpContentMessage vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpContentMessage> _ExpContentMessages)
		{
			foreach (ExpContentMessage item in _ExpContentMessages)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpContentMessage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpContentMessage _ExpContentMessage, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpContentMessage] SET Id=@Id, AccessToken=@AccessToken, RefreshToken=@RefreshToken, ContentMessage=@ContentMessage, NotifyAddress=@NotifyAddress, NotifyType=@NotifyType, UpdateDate=@UpdateDate, IsDone=@IsDone WHERE Id=@Id", 
					"@Id",  _ExpContentMessage.Id, 
					"@AccessToken",  _ExpContentMessage.AccessToken, 
					"@RefreshToken",  _ExpContentMessage.RefreshToken, 
					"@ContentMessage",  _ExpContentMessage.ContentMessage, 
					"@NotifyAddress",  _ExpContentMessage.NotifyAddress, 
					"@NotifyType",  _ExpContentMessage.NotifyType, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpContentMessage.UpdateDate), 
					"@IsDone",  _ExpContentMessage.IsDone, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpContentMessage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpContentMessage _ExpContentMessage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpContentMessage] SET AccessToken=@AccessToken, RefreshToken=@RefreshToken, ContentMessage=@ContentMessage, NotifyAddress=@NotifyAddress, NotifyType=@NotifyType, UpdateDate=@UpdateDate, IsDone=@IsDone WHERE Id=@Id", 
					"@AccessToken",  _ExpContentMessage.AccessToken, 
					"@RefreshToken",  _ExpContentMessage.RefreshToken, 
					"@ContentMessage",  _ExpContentMessage.ContentMessage, 
					"@NotifyAddress",  _ExpContentMessage.NotifyAddress, 
					"@NotifyType",  _ExpContentMessage.NotifyType, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpContentMessage.UpdateDate), 
					"@IsDone",  _ExpContentMessage.IsDone, 
					"@Id", _ExpContentMessage.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpContentMessage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpContentMessage> _ExpContentMessages)
		{
			foreach (ExpContentMessage item in _ExpContentMessages)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpContentMessage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpContentMessage _ExpContentMessage, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpContentMessage] SET Id=@Id, AccessToken=@AccessToken, RefreshToken=@RefreshToken, ContentMessage=@ContentMessage, NotifyAddress=@NotifyAddress, NotifyType=@NotifyType, UpdateDate=@UpdateDate, IsDone=@IsDone "+ condition, 
					"@Id",  _ExpContentMessage.Id, 
					"@AccessToken",  _ExpContentMessage.AccessToken, 
					"@RefreshToken",  _ExpContentMessage.RefreshToken, 
					"@ContentMessage",  _ExpContentMessage.ContentMessage, 
					"@NotifyAddress",  _ExpContentMessage.NotifyAddress, 
					"@NotifyType",  _ExpContentMessage.NotifyType, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpContentMessage.UpdateDate), 
					"@IsDone",  _ExpContentMessage.IsDone);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpContentMessage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpContentMessage] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpContentMessage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpContentMessage _ExpContentMessage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpContentMessage] WHERE Id=@Id",
					"@Id", _ExpContentMessage.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpContentMessage trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpContentMessage] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpContentMessage trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpContentMessage> _ExpContentMessages)
		{
			foreach (ExpContentMessage item in _ExpContentMessages)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
