using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbsetting:IWEbsetting
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbsetting(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebSetting từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebSetting]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebSetting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebSetting] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebSetting từ Database
		/// </summary>
		public List<WebSetting> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebSetting]");
				List<WebSetting> items = new List<WebSetting>();
				WebSetting item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebSetting();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToString(dr["Value"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy danh sách WebSetting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebSetting> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebSetting] A "+ condition,  parameters);
				List<WebSetting> items = new List<WebSetting>();
				WebSetting item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebSetting();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToString(dr["Value"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public List<WebSetting> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebSetting] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebSetting] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebSetting>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebSetting từ Database
		/// </summary>
		public WebSetting GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebSetting] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebSetting item=new WebSetting();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToString(dr["Value"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy một WebSetting đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebSetting GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebSetting] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebSetting item=new WebSetting();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToString(dr["Value"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public WebSetting GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebSetting] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebSetting>(ds);
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
		/// Thêm mới WebSetting vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebSetting _WebSetting)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebSetting](Id, Value, Description, BranchCode) VALUES(@Id, @Value, @Description, @BranchCode)", 
					"@Id",  _WebSetting.Id, 
					"@Value",  _WebSetting.Value, 
					"@Description",  _WebSetting.Description, 
					"@BranchCode",  _WebSetting.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebSetting vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebSetting> _WebSettings)
		{
			foreach (WebSetting item in _WebSettings)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebSetting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebSetting _WebSetting, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebSetting] SET Id=@Id, Value=@Value, Description=@Description, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebSetting.Id, 
					"@Value",  _WebSetting.Value, 
					"@Description",  _WebSetting.Description, 
					"@BranchCode",  _WebSetting.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebSetting vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebSetting _WebSetting)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebSetting] SET Value=@Value, Description=@Description, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Value",  _WebSetting.Value, 
					"@Description",  _WebSetting.Description, 
					"@BranchCode",  _WebSetting.BranchCode, 
					"@Id", _WebSetting.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebSetting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebSetting> _WebSettings)
		{
			foreach (WebSetting item in _WebSettings)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebSetting vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebSetting _WebSetting, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebSetting] SET Id=@Id, Value=@Value, Description=@Description, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebSetting.Id, 
					"@Value",  _WebSetting.Value, 
					"@Description",  _WebSetting.Description, 
					"@BranchCode",  _WebSetting.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebSetting trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebSetting] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebSetting trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebSetting _WebSetting)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebSetting] WHERE Id=@Id",
					"@Id", _WebSetting.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebSetting trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebSetting] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebSetting trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebSetting> _WebSettings)
		{
			foreach (WebSetting item in _WebSettings)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
