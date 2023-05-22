using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpwebhook:IGExpwebhook
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpwebhook(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpWebhook từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWebhook]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpWebhook từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWebhook] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpWebhook từ Database
		/// </summary>
		public List<GExpWebhook> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWebhook]");
				List<GExpWebhook> items = new List<GExpWebhook>();
				GExpWebhook item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWebhook();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
					{
						item.Provider = Convert.ToString(dr["Provider"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["JsonContent"] != null && dr["JsonContent"] != DBNull.Value)
					{
						item.JsonContent = Convert.ToString(dr["JsonContent"]);
					}
					if (dr["IsProcess"] != null && dr["IsProcess"] != DBNull.Value)
					{
						item.IsProcess = Convert.ToBoolean(dr["IsProcess"]);
					}
					if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
					{
						item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
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
		/// Lấy danh sách GExpWebhook từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpWebhook> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWebhook] A "+ condition,  parameters);
				List<GExpWebhook> items = new List<GExpWebhook>();
				GExpWebhook item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWebhook();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
					{
						item.Provider = Convert.ToString(dr["Provider"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["JsonContent"] != null && dr["JsonContent"] != DBNull.Value)
					{
						item.JsonContent = Convert.ToString(dr["JsonContent"]);
					}
					if (dr["IsProcess"] != null && dr["IsProcess"] != DBNull.Value)
					{
						item.IsProcess = Convert.ToBoolean(dr["IsProcess"]);
					}
					if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
					{
						item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
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

		public List<GExpWebhook> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWebhook] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpWebhook] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpWebhook>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpWebhook từ Database
		/// </summary>
		public GExpWebhook GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWebhook] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpWebhook item=new GExpWebhook();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
						{
							item.Provider = Convert.ToString(dr["Provider"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["JsonContent"] != null && dr["JsonContent"] != DBNull.Value)
						{
							item.JsonContent = Convert.ToString(dr["JsonContent"]);
						}
						if (dr["IsProcess"] != null && dr["IsProcess"] != DBNull.Value)
						{
							item.IsProcess = Convert.ToBoolean(dr["IsProcess"]);
						}
						if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
						{
							item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
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
		/// Lấy một GExpWebhook đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpWebhook GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWebhook] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpWebhook item=new GExpWebhook();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
						{
							item.Provider = Convert.ToString(dr["Provider"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["JsonContent"] != null && dr["JsonContent"] != DBNull.Value)
						{
							item.JsonContent = Convert.ToString(dr["JsonContent"]);
						}
						if (dr["IsProcess"] != null && dr["IsProcess"] != DBNull.Value)
						{
							item.IsProcess = Convert.ToBoolean(dr["IsProcess"]);
						}
						if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
						{
							item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
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

		public GExpWebhook GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWebhook] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpWebhook>(ds);
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
		/// Thêm mới GExpWebhook vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpWebhook _GExpWebhook)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpWebhook](Id, Provider, CreateDate, JsonContent, IsProcess, ProcessDate) VALUES(@Id, @Provider, @CreateDate, @JsonContent, @IsProcess, @ProcessDate)", 
					"@Id",  _GExpWebhook.Id, 
					"@Provider",  _GExpWebhook.Provider, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpWebhook.CreateDate), 
					"@JsonContent",  _GExpWebhook.JsonContent, 
					"@IsProcess",  _GExpWebhook.IsProcess, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GExpWebhook.ProcessDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpWebhook vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpWebhook> _GExpWebhooks)
		{
			foreach (GExpWebhook item in _GExpWebhooks)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWebhook vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpWebhook _GExpWebhook, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWebhook] SET Id=@Id, Provider=@Provider, CreateDate=@CreateDate, JsonContent=@JsonContent, IsProcess=@IsProcess, ProcessDate=@ProcessDate WHERE Id=@Id", 
					"@Id",  _GExpWebhook.Id, 
					"@Provider",  _GExpWebhook.Provider, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpWebhook.CreateDate), 
					"@JsonContent",  _GExpWebhook.JsonContent, 
					"@IsProcess",  _GExpWebhook.IsProcess, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GExpWebhook.ProcessDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpWebhook vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpWebhook _GExpWebhook)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWebhook] SET Provider=@Provider, CreateDate=@CreateDate, JsonContent=@JsonContent, IsProcess=@IsProcess, ProcessDate=@ProcessDate WHERE Id=@Id", 
					"@Provider",  _GExpWebhook.Provider, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpWebhook.CreateDate), 
					"@JsonContent",  _GExpWebhook.JsonContent, 
					"@IsProcess",  _GExpWebhook.IsProcess, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GExpWebhook.ProcessDate), 
					"@Id", _GExpWebhook.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpWebhook vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpWebhook> _GExpWebhooks)
		{
			foreach (GExpWebhook item in _GExpWebhooks)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWebhook vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpWebhook _GExpWebhook, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWebhook] SET Id=@Id, Provider=@Provider, CreateDate=@CreateDate, JsonContent=@JsonContent, IsProcess=@IsProcess, ProcessDate=@ProcessDate "+ condition, 
					"@Id",  _GExpWebhook.Id, 
					"@Provider",  _GExpWebhook.Provider, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpWebhook.CreateDate), 
					"@JsonContent",  _GExpWebhook.JsonContent, 
					"@IsProcess",  _GExpWebhook.IsProcess, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GExpWebhook.ProcessDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpWebhook trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWebhook] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWebhook trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpWebhook _GExpWebhook)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWebhook] WHERE Id=@Id",
					"@Id", _GExpWebhook.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWebhook trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWebhook] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWebhook trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpWebhook> _GExpWebhooks)
		{
			foreach (GExpWebhook item in _GExpWebhooks)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
