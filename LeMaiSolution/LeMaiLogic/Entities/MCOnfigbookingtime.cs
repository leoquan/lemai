using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MCOnfigbookingtime:ICOnfigbookingtime
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MCOnfigbookingtime(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ConfigBookingTime từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ConfigBookingTime]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ConfigBookingTime từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ConfigBookingTime] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ConfigBookingTime từ Database
		/// </summary>
		public List<ConfigBookingTime> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ConfigBookingTime]");
				List<ConfigBookingTime> items = new List<ConfigBookingTime>();
				ConfigBookingTime item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ConfigBookingTime();
					if (dr["ID"] != null && dr["ID"] != DBNull.Value)
					{
						item.ID = Convert.ToString(dr["ID"]);
					}
					if (dr["Hour"] != null && dr["Hour"] != DBNull.Value)
					{
						item.Hour = Convert.ToInt32(dr["Hour"]);
					}
					if (dr["Minute"] != null && dr["Minute"] != DBNull.Value)
					{
						item.Minute = Convert.ToInt32(dr["Minute"]);
					}
					if (dr["IsPause"] != null && dr["IsPause"] != DBNull.Value)
					{
						item.IsPause = Convert.ToBoolean(dr["IsPause"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["Day"] != null && dr["Day"] != DBNull.Value)
					{
						item.Day = Convert.ToInt32(dr["Day"]);
					}
					if (dr["Slot"] != null && dr["Slot"] != DBNull.Value)
					{
						item.Slot = Convert.ToInt32(dr["Slot"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["ModifyDate"] != null && dr["ModifyDate"] != DBNull.Value)
					{
						item.ModifyDate = Convert.ToDateTime(dr["ModifyDate"]);
					}
					if (dr["ModifyBy"] != null && dr["ModifyBy"] != DBNull.Value)
					{
						item.ModifyBy = Convert.ToString(dr["ModifyBy"]);
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
		/// Lấy danh sách ConfigBookingTime từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ConfigBookingTime> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ConfigBookingTime] A "+ condition,  parameters);
				List<ConfigBookingTime> items = new List<ConfigBookingTime>();
				ConfigBookingTime item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ConfigBookingTime();
					if (dr["ID"] != null && dr["ID"] != DBNull.Value)
					{
						item.ID = Convert.ToString(dr["ID"]);
					}
					if (dr["Hour"] != null && dr["Hour"] != DBNull.Value)
					{
						item.Hour = Convert.ToInt32(dr["Hour"]);
					}
					if (dr["Minute"] != null && dr["Minute"] != DBNull.Value)
					{
						item.Minute = Convert.ToInt32(dr["Minute"]);
					}
					if (dr["IsPause"] != null && dr["IsPause"] != DBNull.Value)
					{
						item.IsPause = Convert.ToBoolean(dr["IsPause"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["Day"] != null && dr["Day"] != DBNull.Value)
					{
						item.Day = Convert.ToInt32(dr["Day"]);
					}
					if (dr["Slot"] != null && dr["Slot"] != DBNull.Value)
					{
						item.Slot = Convert.ToInt32(dr["Slot"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["ModifyDate"] != null && dr["ModifyDate"] != DBNull.Value)
					{
						item.ModifyDate = Convert.ToDateTime(dr["ModifyDate"]);
					}
					if (dr["ModifyBy"] != null && dr["ModifyBy"] != DBNull.Value)
					{
						item.ModifyBy = Convert.ToString(dr["ModifyBy"]);
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

		public List<ConfigBookingTime> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ConfigBookingTime] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ConfigBookingTime] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ConfigBookingTime>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ConfigBookingTime từ Database
		/// </summary>
		public ConfigBookingTime GetObject(string schema, String ID, Int32 Hour, Int32 Minute, Int32 Day)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ConfigBookingTime] where ID=@ID and Hour=@Hour and Minute=@Minute and Day=@Day",
					"@ID", ID, 
					"@Hour", Hour, 
					"@Minute", Minute, 
					"@Day", Day);
				if (ds.Rows.Count > 0)
				{
					ConfigBookingTime item=new ConfigBookingTime();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ID"] != null && dr["ID"] != DBNull.Value)
						{
							item.ID = Convert.ToString(dr["ID"]);
						}
						if (dr["Hour"] != null && dr["Hour"] != DBNull.Value)
						{
							item.Hour = Convert.ToInt32(dr["Hour"]);
						}
						if (dr["Minute"] != null && dr["Minute"] != DBNull.Value)
						{
							item.Minute = Convert.ToInt32(dr["Minute"]);
						}
						if (dr["IsPause"] != null && dr["IsPause"] != DBNull.Value)
						{
							item.IsPause = Convert.ToBoolean(dr["IsPause"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["Day"] != null && dr["Day"] != DBNull.Value)
						{
							item.Day = Convert.ToInt32(dr["Day"]);
						}
						if (dr["Slot"] != null && dr["Slot"] != DBNull.Value)
						{
							item.Slot = Convert.ToInt32(dr["Slot"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["ModifyDate"] != null && dr["ModifyDate"] != DBNull.Value)
						{
							item.ModifyDate = Convert.ToDateTime(dr["ModifyDate"]);
						}
						if (dr["ModifyBy"] != null && dr["ModifyBy"] != DBNull.Value)
						{
							item.ModifyBy = Convert.ToString(dr["ModifyBy"]);
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
		/// Lấy một ConfigBookingTime đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ConfigBookingTime GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ConfigBookingTime] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ConfigBookingTime item=new ConfigBookingTime();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ID"] != null && dr["ID"] != DBNull.Value)
						{
							item.ID = Convert.ToString(dr["ID"]);
						}
						if (dr["Hour"] != null && dr["Hour"] != DBNull.Value)
						{
							item.Hour = Convert.ToInt32(dr["Hour"]);
						}
						if (dr["Minute"] != null && dr["Minute"] != DBNull.Value)
						{
							item.Minute = Convert.ToInt32(dr["Minute"]);
						}
						if (dr["IsPause"] != null && dr["IsPause"] != DBNull.Value)
						{
							item.IsPause = Convert.ToBoolean(dr["IsPause"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["Day"] != null && dr["Day"] != DBNull.Value)
						{
							item.Day = Convert.ToInt32(dr["Day"]);
						}
						if (dr["Slot"] != null && dr["Slot"] != DBNull.Value)
						{
							item.Slot = Convert.ToInt32(dr["Slot"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["ModifyDate"] != null && dr["ModifyDate"] != DBNull.Value)
						{
							item.ModifyDate = Convert.ToDateTime(dr["ModifyDate"]);
						}
						if (dr["ModifyBy"] != null && dr["ModifyBy"] != DBNull.Value)
						{
							item.ModifyBy = Convert.ToString(dr["ModifyBy"]);
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

		public ConfigBookingTime GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ConfigBookingTime] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ConfigBookingTime>(ds);
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
		/// Thêm mới ConfigBookingTime vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ConfigBookingTime _ConfigBookingTime)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ConfigBookingTime](ID, Hour, Minute, IsPause, IsDelete, Day, Slot, CreateDate, CreateBy, ModifyDate, ModifyBy) VALUES(@ID, @Hour, @Minute, @IsPause, @IsDelete, @Day, @Slot, @CreateDate, @CreateBy, @ModifyDate, @ModifyBy)", 
					"@ID",  _ConfigBookingTime.ID, 
					"@Hour",  _ConfigBookingTime.Hour, 
					"@Minute",  _ConfigBookingTime.Minute, 
					"@IsPause",  _ConfigBookingTime.IsPause, 
					"@IsDelete",  _ConfigBookingTime.IsDelete, 
					"@Day",  _ConfigBookingTime.Day, 
					"@Slot",  _ConfigBookingTime.Slot, 
					"@CreateDate", this._dataContext.ConvertDateString( _ConfigBookingTime.CreateDate), 
					"@CreateBy",  _ConfigBookingTime.CreateBy, 
					"@ModifyDate", this._dataContext.ConvertDateString( _ConfigBookingTime.ModifyDate), 
					"@ModifyBy",  _ConfigBookingTime.ModifyBy);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ConfigBookingTime vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ConfigBookingTime> _ConfigBookingTimes)
		{
			foreach (ConfigBookingTime item in _ConfigBookingTimes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ConfigBookingTime vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ConfigBookingTime _ConfigBookingTime, String ID, Int32 Hour, Int32 Minute, Int32 Day)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ConfigBookingTime] SET ID=@ID, Hour=@Hour, Minute=@Minute, IsPause=@IsPause, IsDelete=@IsDelete, Day=@Day, Slot=@Slot, CreateDate=@CreateDate, CreateBy=@CreateBy, ModifyDate=@ModifyDate, ModifyBy=@ModifyBy WHERE ID=@ID and Hour=@Hour and Minute=@Minute and Day=@Day", 
					"@ID",  _ConfigBookingTime.ID, 
					"@Hour",  _ConfigBookingTime.Hour, 
					"@Minute",  _ConfigBookingTime.Minute, 
					"@IsPause",  _ConfigBookingTime.IsPause, 
					"@IsDelete",  _ConfigBookingTime.IsDelete, 
					"@Day",  _ConfigBookingTime.Day, 
					"@Slot",  _ConfigBookingTime.Slot, 
					"@CreateDate", this._dataContext.ConvertDateString( _ConfigBookingTime.CreateDate), 
					"@CreateBy",  _ConfigBookingTime.CreateBy, 
					"@ModifyDate", this._dataContext.ConvertDateString( _ConfigBookingTime.ModifyDate), 
					"@ModifyBy",  _ConfigBookingTime.ModifyBy, 
					"@ID", ID, 
					"@Hour", Hour, 
					"@Minute", Minute, 
					"@Day", Day);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ConfigBookingTime vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ConfigBookingTime _ConfigBookingTime)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ConfigBookingTime] SET IsPause=@IsPause, IsDelete=@IsDelete, Slot=@Slot, CreateDate=@CreateDate, CreateBy=@CreateBy, ModifyDate=@ModifyDate, ModifyBy=@ModifyBy WHERE ID=@ID and Hour=@Hour and Minute=@Minute and Day=@Day", 
					"@IsPause",  _ConfigBookingTime.IsPause, 
					"@IsDelete",  _ConfigBookingTime.IsDelete, 
					"@Slot",  _ConfigBookingTime.Slot, 
					"@CreateDate", this._dataContext.ConvertDateString( _ConfigBookingTime.CreateDate), 
					"@CreateBy",  _ConfigBookingTime.CreateBy, 
					"@ModifyDate", this._dataContext.ConvertDateString( _ConfigBookingTime.ModifyDate), 
					"@ModifyBy",  _ConfigBookingTime.ModifyBy, 
					"@ID", _ConfigBookingTime.ID, 
					"@Hour", _ConfigBookingTime.Hour, 
					"@Minute", _ConfigBookingTime.Minute, 
					"@Day", _ConfigBookingTime.Day);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ConfigBookingTime vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ConfigBookingTime> _ConfigBookingTimes)
		{
			foreach (ConfigBookingTime item in _ConfigBookingTimes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ConfigBookingTime vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ConfigBookingTime _ConfigBookingTime, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ConfigBookingTime] SET ID=@ID, Hour=@Hour, Minute=@Minute, IsPause=@IsPause, IsDelete=@IsDelete, Day=@Day, Slot=@Slot, CreateDate=@CreateDate, CreateBy=@CreateBy, ModifyDate=@ModifyDate, ModifyBy=@ModifyBy "+ condition, 
					"@ID",  _ConfigBookingTime.ID, 
					"@Hour",  _ConfigBookingTime.Hour, 
					"@Minute",  _ConfigBookingTime.Minute, 
					"@IsPause",  _ConfigBookingTime.IsPause, 
					"@IsDelete",  _ConfigBookingTime.IsDelete, 
					"@Day",  _ConfigBookingTime.Day, 
					"@Slot",  _ConfigBookingTime.Slot, 
					"@CreateDate", this._dataContext.ConvertDateString( _ConfigBookingTime.CreateDate), 
					"@CreateBy",  _ConfigBookingTime.CreateBy, 
					"@ModifyDate", this._dataContext.ConvertDateString( _ConfigBookingTime.ModifyDate), 
					"@ModifyBy",  _ConfigBookingTime.ModifyBy);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ConfigBookingTime trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String ID, Int32 Hour, Int32 Minute, Int32 Day)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ConfigBookingTime] WHERE ID=@ID and Hour=@Hour and Minute=@Minute and Day=@Day",
					"@ID", ID, 
					"@Hour", Hour, 
					"@Minute", Minute, 
					"@Day", Day);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ConfigBookingTime trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ConfigBookingTime _ConfigBookingTime)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ConfigBookingTime] WHERE ID=@ID and Hour=@Hour and Minute=@Minute and Day=@Day",
					"@ID", _ConfigBookingTime.ID, 
					"@Hour", _ConfigBookingTime.Hour, 
					"@Minute", _ConfigBookingTime.Minute, 
					"@Day", _ConfigBookingTime.Day);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ConfigBookingTime trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ConfigBookingTime] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ConfigBookingTime trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ConfigBookingTime> _ConfigBookingTimes)
		{
			foreach (ConfigBookingTime item in _ConfigBookingTimes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
