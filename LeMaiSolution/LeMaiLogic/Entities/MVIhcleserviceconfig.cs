using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIhcleserviceconfig:IVIhcleserviceconfig
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIhcleserviceconfig(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VihcleServiceConfig từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleServiceConfig]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VihcleServiceConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleServiceConfig] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VihcleServiceConfig từ Database
		/// </summary>
		public List<VihcleServiceConfig> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleServiceConfig]");
				List<VihcleServiceConfig> items = new List<VihcleServiceConfig>();
				VihcleServiceConfig item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VihcleServiceConfig();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ServiceId"] != null && dr["FK_ServiceId"] != DBNull.Value)
					{
						item.FK_ServiceId = Convert.ToString(dr["FK_ServiceId"]);
					}
					if (dr["FK_Vihcle"] != null && dr["FK_Vihcle"] != DBNull.Value)
					{
						item.FK_Vihcle = Convert.ToString(dr["FK_Vihcle"]);
					}
					if (dr["ValueCycle"] != null && dr["ValueCycle"] != DBNull.Value)
					{
						item.ValueCycle = Convert.ToDecimal(dr["ValueCycle"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
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
		/// Lấy danh sách VihcleServiceConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VihcleServiceConfig> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VihcleServiceConfig] A "+ condition,  parameters);
				List<VihcleServiceConfig> items = new List<VihcleServiceConfig>();
				VihcleServiceConfig item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VihcleServiceConfig();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ServiceId"] != null && dr["FK_ServiceId"] != DBNull.Value)
					{
						item.FK_ServiceId = Convert.ToString(dr["FK_ServiceId"]);
					}
					if (dr["FK_Vihcle"] != null && dr["FK_Vihcle"] != DBNull.Value)
					{
						item.FK_Vihcle = Convert.ToString(dr["FK_Vihcle"]);
					}
					if (dr["ValueCycle"] != null && dr["ValueCycle"] != DBNull.Value)
					{
						item.ValueCycle = Convert.ToDecimal(dr["ValueCycle"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
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

		public List<VihcleServiceConfig> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VihcleServiceConfig] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VihcleServiceConfig] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VihcleServiceConfig>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VihcleServiceConfig từ Database
		/// </summary>
		public VihcleServiceConfig GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleServiceConfig] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					VihcleServiceConfig item=new VihcleServiceConfig();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ServiceId"] != null && dr["FK_ServiceId"] != DBNull.Value)
						{
							item.FK_ServiceId = Convert.ToString(dr["FK_ServiceId"]);
						}
						if (dr["FK_Vihcle"] != null && dr["FK_Vihcle"] != DBNull.Value)
						{
							item.FK_Vihcle = Convert.ToString(dr["FK_Vihcle"]);
						}
						if (dr["ValueCycle"] != null && dr["ValueCycle"] != DBNull.Value)
						{
							item.ValueCycle = Convert.ToDecimal(dr["ValueCycle"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
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
		/// Lấy một VihcleServiceConfig đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VihcleServiceConfig GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VihcleServiceConfig] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VihcleServiceConfig item=new VihcleServiceConfig();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ServiceId"] != null && dr["FK_ServiceId"] != DBNull.Value)
						{
							item.FK_ServiceId = Convert.ToString(dr["FK_ServiceId"]);
						}
						if (dr["FK_Vihcle"] != null && dr["FK_Vihcle"] != DBNull.Value)
						{
							item.FK_Vihcle = Convert.ToString(dr["FK_Vihcle"]);
						}
						if (dr["ValueCycle"] != null && dr["ValueCycle"] != DBNull.Value)
						{
							item.ValueCycle = Convert.ToDecimal(dr["ValueCycle"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
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

		public VihcleServiceConfig GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VihcleServiceConfig] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VihcleServiceConfig>(ds);
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
		/// Thêm mới VihcleServiceConfig vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VihcleServiceConfig _VihcleServiceConfig)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VihcleServiceConfig](Id, FK_ServiceId, FK_Vihcle, ValueCycle, Note) VALUES(@Id, @FK_ServiceId, @FK_Vihcle, @ValueCycle, @Note)", 
					"@Id",  _VihcleServiceConfig.Id, 
					"@FK_ServiceId",  _VihcleServiceConfig.FK_ServiceId, 
					"@FK_Vihcle",  _VihcleServiceConfig.FK_Vihcle, 
					"@ValueCycle",  _VihcleServiceConfig.ValueCycle, 
					"@Note",  _VihcleServiceConfig.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VihcleServiceConfig vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VihcleServiceConfig> _VihcleServiceConfigs)
		{
			foreach (VihcleServiceConfig item in _VihcleServiceConfigs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VihcleServiceConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VihcleServiceConfig _VihcleServiceConfig, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleServiceConfig] SET Id=@Id, FK_ServiceId=@FK_ServiceId, FK_Vihcle=@FK_Vihcle, ValueCycle=@ValueCycle, Note=@Note WHERE Id=@Id", 
					"@Id",  _VihcleServiceConfig.Id, 
					"@FK_ServiceId",  _VihcleServiceConfig.FK_ServiceId, 
					"@FK_Vihcle",  _VihcleServiceConfig.FK_Vihcle, 
					"@ValueCycle",  _VihcleServiceConfig.ValueCycle, 
					"@Note",  _VihcleServiceConfig.Note, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VihcleServiceConfig vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VihcleServiceConfig _VihcleServiceConfig)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleServiceConfig] SET FK_ServiceId=@FK_ServiceId, FK_Vihcle=@FK_Vihcle, ValueCycle=@ValueCycle, Note=@Note WHERE Id=@Id", 
					"@FK_ServiceId",  _VihcleServiceConfig.FK_ServiceId, 
					"@FK_Vihcle",  _VihcleServiceConfig.FK_Vihcle, 
					"@ValueCycle",  _VihcleServiceConfig.ValueCycle, 
					"@Note",  _VihcleServiceConfig.Note, 
					"@Id", _VihcleServiceConfig.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VihcleServiceConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VihcleServiceConfig> _VihcleServiceConfigs)
		{
			foreach (VihcleServiceConfig item in _VihcleServiceConfigs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VihcleServiceConfig vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VihcleServiceConfig _VihcleServiceConfig, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleServiceConfig] SET Id=@Id, FK_ServiceId=@FK_ServiceId, FK_Vihcle=@FK_Vihcle, ValueCycle=@ValueCycle, Note=@Note "+ condition, 
					"@Id",  _VihcleServiceConfig.Id, 
					"@FK_ServiceId",  _VihcleServiceConfig.FK_ServiceId, 
					"@FK_Vihcle",  _VihcleServiceConfig.FK_Vihcle, 
					"@ValueCycle",  _VihcleServiceConfig.ValueCycle, 
					"@Note",  _VihcleServiceConfig.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VihcleServiceConfig trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleServiceConfig] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleServiceConfig trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VihcleServiceConfig _VihcleServiceConfig)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleServiceConfig] WHERE Id=@Id",
					"@Id", _VihcleServiceConfig.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleServiceConfig trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleServiceConfig] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleServiceConfig trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VihcleServiceConfig> _VihcleServiceConfigs)
		{
			foreach (VihcleServiceConfig item in _VihcleServiceConfigs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
