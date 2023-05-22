using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbconfig:IWEbconfig
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbconfig(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebConfig từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebConfig]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebConfig] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebConfig từ Database
		/// </summary>
		public List<WebConfig> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebConfig]");
				List<WebConfig> items = new List<WebConfig>();
				WebConfig item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebConfig();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["KeyConfig"] != null && dr["KeyConfig"] != DBNull.Value)
					{
						item.KeyConfig = Convert.ToString(dr["KeyConfig"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToString(dr["Value"]);
					}
					if (dr["ConfigGroup"] != null && dr["ConfigGroup"] != DBNull.Value)
					{
						item.ConfigGroup = Convert.ToString(dr["ConfigGroup"]);
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
		/// Lấy danh sách WebConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebConfig> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebConfig] A "+ condition,  parameters);
				List<WebConfig> items = new List<WebConfig>();
				WebConfig item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebConfig();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["KeyConfig"] != null && dr["KeyConfig"] != DBNull.Value)
					{
						item.KeyConfig = Convert.ToString(dr["KeyConfig"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToString(dr["Value"]);
					}
					if (dr["ConfigGroup"] != null && dr["ConfigGroup"] != DBNull.Value)
					{
						item.ConfigGroup = Convert.ToString(dr["ConfigGroup"]);
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

		public List<WebConfig> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebConfig] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebConfig] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebConfig>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebConfig từ Database
		/// </summary>
		public WebConfig GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebConfig] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebConfig item=new WebConfig();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["KeyConfig"] != null && dr["KeyConfig"] != DBNull.Value)
						{
							item.KeyConfig = Convert.ToString(dr["KeyConfig"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToString(dr["Value"]);
						}
						if (dr["ConfigGroup"] != null && dr["ConfigGroup"] != DBNull.Value)
						{
							item.ConfigGroup = Convert.ToString(dr["ConfigGroup"]);
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
		/// Lấy một WebConfig đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebConfig GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebConfig] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebConfig item=new WebConfig();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["KeyConfig"] != null && dr["KeyConfig"] != DBNull.Value)
						{
							item.KeyConfig = Convert.ToString(dr["KeyConfig"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToString(dr["Value"]);
						}
						if (dr["ConfigGroup"] != null && dr["ConfigGroup"] != DBNull.Value)
						{
							item.ConfigGroup = Convert.ToString(dr["ConfigGroup"]);
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

		public WebConfig GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebConfig] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebConfig>(ds);
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
		/// Thêm mới WebConfig vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebConfig _WebConfig)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebConfig](Id, KeyConfig, Value, ConfigGroup, BranchCode) VALUES(@Id, @KeyConfig, @Value, @ConfigGroup, @BranchCode)", 
					"@Id",  _WebConfig.Id, 
					"@KeyConfig",  _WebConfig.KeyConfig, 
					"@Value",  _WebConfig.Value, 
					"@ConfigGroup",  _WebConfig.ConfigGroup, 
					"@BranchCode",  _WebConfig.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebConfig vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebConfig> _WebConfigs)
		{
			foreach (WebConfig item in _WebConfigs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebConfig _WebConfig, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebConfig] SET Id=@Id, KeyConfig=@KeyConfig, Value=@Value, ConfigGroup=@ConfigGroup, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebConfig.Id, 
					"@KeyConfig",  _WebConfig.KeyConfig, 
					"@Value",  _WebConfig.Value, 
					"@ConfigGroup",  _WebConfig.ConfigGroup, 
					"@BranchCode",  _WebConfig.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebConfig vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebConfig _WebConfig)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebConfig] SET KeyConfig=@KeyConfig, Value=@Value, ConfigGroup=@ConfigGroup, BranchCode=@BranchCode WHERE Id=@Id", 
					"@KeyConfig",  _WebConfig.KeyConfig, 
					"@Value",  _WebConfig.Value, 
					"@ConfigGroup",  _WebConfig.ConfigGroup, 
					"@BranchCode",  _WebConfig.BranchCode, 
					"@Id", _WebConfig.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebConfig> _WebConfigs)
		{
			foreach (WebConfig item in _WebConfigs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebConfig vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebConfig _WebConfig, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebConfig] SET Id=@Id, KeyConfig=@KeyConfig, Value=@Value, ConfigGroup=@ConfigGroup, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebConfig.Id, 
					"@KeyConfig",  _WebConfig.KeyConfig, 
					"@Value",  _WebConfig.Value, 
					"@ConfigGroup",  _WebConfig.ConfigGroup, 
					"@BranchCode",  _WebConfig.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebConfig trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebConfig] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebConfig trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebConfig _WebConfig)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebConfig] WHERE Id=@Id",
					"@Id", _WebConfig.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebConfig trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebConfig] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebConfig trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebConfig> _WebConfigs)
		{
			foreach (WebConfig item in _WebConfigs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
