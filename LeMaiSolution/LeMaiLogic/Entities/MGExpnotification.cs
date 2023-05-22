using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpnotification:IGExpnotification
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpnotification(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpNotification từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpNotification]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpNotification từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpNotification] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpNotification từ Database
		/// </summary>
		public List<GExpNotification> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpNotification]");
				List<GExpNotification> items = new List<GExpNotification>();
				GExpNotification item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpNotification();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
					{
						item.KeyDate = Convert.ToString(dr["KeyDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_AccountRead"] != null && dr["FK_AccountRead"] != DBNull.Value)
					{
						item.FK_AccountRead = Convert.ToString(dr["FK_AccountRead"]);
					}
					if (dr["DateRead"] != null && dr["DateRead"] != DBNull.Value)
					{
						item.DateRead = Convert.ToDateTime(dr["DateRead"]);
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
		/// Lấy danh sách GExpNotification từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpNotification> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpNotification] A "+ condition,  parameters);
				List<GExpNotification> items = new List<GExpNotification>();
				GExpNotification item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpNotification();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
					{
						item.KeyDate = Convert.ToString(dr["KeyDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_AccountRead"] != null && dr["FK_AccountRead"] != DBNull.Value)
					{
						item.FK_AccountRead = Convert.ToString(dr["FK_AccountRead"]);
					}
					if (dr["DateRead"] != null && dr["DateRead"] != DBNull.Value)
					{
						item.DateRead = Convert.ToDateTime(dr["DateRead"]);
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

		public List<GExpNotification> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpNotification] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpNotification] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpNotification>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpNotification từ Database
		/// </summary>
		public GExpNotification GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpNotification] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpNotification item=new GExpNotification();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
						{
							item.KeyDate = Convert.ToString(dr["KeyDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_AccountRead"] != null && dr["FK_AccountRead"] != DBNull.Value)
						{
							item.FK_AccountRead = Convert.ToString(dr["FK_AccountRead"]);
						}
						if (dr["DateRead"] != null && dr["DateRead"] != DBNull.Value)
						{
							item.DateRead = Convert.ToDateTime(dr["DateRead"]);
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
		/// Lấy một GExpNotification đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpNotification GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpNotification] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpNotification item=new GExpNotification();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
						{
							item.KeyDate = Convert.ToString(dr["KeyDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_AccountRead"] != null && dr["FK_AccountRead"] != DBNull.Value)
						{
							item.FK_AccountRead = Convert.ToString(dr["FK_AccountRead"]);
						}
						if (dr["DateRead"] != null && dr["DateRead"] != DBNull.Value)
						{
							item.DateRead = Convert.ToDateTime(dr["DateRead"]);
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

		public GExpNotification GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpNotification] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpNotification>(ds);
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
		/// Thêm mới GExpNotification vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpNotification _GExpNotification)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpNotification](Id, BillCode, KeyDate, Note, CreateDate, FK_AccountRead, DateRead) VALUES(@Id, @BillCode, @KeyDate, @Note, @CreateDate, @FK_AccountRead, @DateRead)", 
					"@Id",  _GExpNotification.Id, 
					"@BillCode",  _GExpNotification.BillCode, 
					"@KeyDate",  _GExpNotification.KeyDate, 
					"@Note",  _GExpNotification.Note, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpNotification.CreateDate), 
					"@FK_AccountRead",  _GExpNotification.FK_AccountRead, 
					"@DateRead", this._dataContext.ConvertDateString( _GExpNotification.DateRead));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpNotification vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpNotification> _GExpNotifications)
		{
			foreach (GExpNotification item in _GExpNotifications)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpNotification vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpNotification _GExpNotification, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpNotification] SET Id=@Id, BillCode=@BillCode, KeyDate=@KeyDate, Note=@Note, CreateDate=@CreateDate, FK_AccountRead=@FK_AccountRead, DateRead=@DateRead WHERE Id=@Id", 
					"@Id",  _GExpNotification.Id, 
					"@BillCode",  _GExpNotification.BillCode, 
					"@KeyDate",  _GExpNotification.KeyDate, 
					"@Note",  _GExpNotification.Note, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpNotification.CreateDate), 
					"@FK_AccountRead",  _GExpNotification.FK_AccountRead, 
					"@DateRead", this._dataContext.ConvertDateString( _GExpNotification.DateRead), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpNotification vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpNotification _GExpNotification)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpNotification] SET BillCode=@BillCode, KeyDate=@KeyDate, Note=@Note, CreateDate=@CreateDate, FK_AccountRead=@FK_AccountRead, DateRead=@DateRead WHERE Id=@Id", 
					"@BillCode",  _GExpNotification.BillCode, 
					"@KeyDate",  _GExpNotification.KeyDate, 
					"@Note",  _GExpNotification.Note, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpNotification.CreateDate), 
					"@FK_AccountRead",  _GExpNotification.FK_AccountRead, 
					"@DateRead", this._dataContext.ConvertDateString( _GExpNotification.DateRead), 
					"@Id", _GExpNotification.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpNotification vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpNotification> _GExpNotifications)
		{
			foreach (GExpNotification item in _GExpNotifications)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpNotification vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpNotification _GExpNotification, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpNotification] SET Id=@Id, BillCode=@BillCode, KeyDate=@KeyDate, Note=@Note, CreateDate=@CreateDate, FK_AccountRead=@FK_AccountRead, DateRead=@DateRead "+ condition, 
					"@Id",  _GExpNotification.Id, 
					"@BillCode",  _GExpNotification.BillCode, 
					"@KeyDate",  _GExpNotification.KeyDate, 
					"@Note",  _GExpNotification.Note, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpNotification.CreateDate), 
					"@FK_AccountRead",  _GExpNotification.FK_AccountRead, 
					"@DateRead", this._dataContext.ConvertDateString( _GExpNotification.DateRead));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpNotification trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpNotification] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpNotification trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpNotification _GExpNotification)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpNotification] WHERE Id=@Id",
					"@Id", _GExpNotification.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpNotification trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpNotification] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpNotification trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpNotification> _GExpNotifications)
		{
			foreach (GExpNotification item in _GExpNotifications)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
