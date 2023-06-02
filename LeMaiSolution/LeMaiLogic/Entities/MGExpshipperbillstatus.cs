using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpshipperbillstatus:IGExpshipperbillstatus
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpshipperbillstatus(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpShipperBillStatus từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperBillStatus]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpShipperBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperBillStatus] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpShipperBillStatus từ Database
		/// </summary>
		public List<GExpShipperBillStatus> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperBillStatus]");
				List<GExpShipperBillStatus> items = new List<GExpShipperBillStatus>();
				GExpShipperBillStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipperBillStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["IsShowMobile"] != null && dr["IsShowMobile"] != DBNull.Value)
					{
						item.IsShowMobile = Convert.ToBoolean(dr["IsShowMobile"]);
					}
					if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
					{
						item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
					}
					if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
					{
						item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
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
		/// Lấy danh sách GExpShipperBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpShipperBillStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipperBillStatus] A "+ condition,  parameters);
				List<GExpShipperBillStatus> items = new List<GExpShipperBillStatus>();
				GExpShipperBillStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipperBillStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["IsShowMobile"] != null && dr["IsShowMobile"] != DBNull.Value)
					{
						item.IsShowMobile = Convert.ToBoolean(dr["IsShowMobile"]);
					}
					if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
					{
						item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
					}
					if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
					{
						item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
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

		public List<GExpShipperBillStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipperBillStatus] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpShipperBillStatus] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpShipperBillStatus>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpShipperBillStatus từ Database
		/// </summary>
		public GExpShipperBillStatus GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperBillStatus] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpShipperBillStatus item=new GExpShipperBillStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["IsShowMobile"] != null && dr["IsShowMobile"] != DBNull.Value)
						{
							item.IsShowMobile = Convert.ToBoolean(dr["IsShowMobile"]);
						}
						if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
						{
							item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
						}
						if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
						{
							item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
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
		/// Lấy một GExpShipperBillStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpShipperBillStatus GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipperBillStatus] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpShipperBillStatus item=new GExpShipperBillStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["IsShowMobile"] != null && dr["IsShowMobile"] != DBNull.Value)
						{
							item.IsShowMobile = Convert.ToBoolean(dr["IsShowMobile"]);
						}
						if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
						{
							item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
						}
						if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
						{
							item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
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

		public GExpShipperBillStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipperBillStatus] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpShipperBillStatus>(ds);
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
		/// Thêm mới GExpShipperBillStatus vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpShipperBillStatus _GExpShipperBillStatus)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpShipperBillStatus](Id, StatusName, IsShowMobile, StatusBackgroundColor, StatusTextColor) VALUES(@Id, @StatusName, @IsShowMobile, @StatusBackgroundColor, @StatusTextColor)", 
					"@Id",  _GExpShipperBillStatus.Id, 
					"@StatusName",  _GExpShipperBillStatus.StatusName, 
					"@IsShowMobile",  _GExpShipperBillStatus.IsShowMobile, 
					"@StatusBackgroundColor",  _GExpShipperBillStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpShipperBillStatus.StatusTextColor);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpShipperBillStatus vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpShipperBillStatus> _GExpShipperBillStatuss)
		{
			foreach (GExpShipperBillStatus item in _GExpShipperBillStatuss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperBillStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpShipperBillStatus _GExpShipperBillStatus, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperBillStatus] SET Id=@Id, StatusName=@StatusName, IsShowMobile=@IsShowMobile, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor WHERE Id=@Id", 
					"@Id",  _GExpShipperBillStatus.Id, 
					"@StatusName",  _GExpShipperBillStatus.StatusName, 
					"@IsShowMobile",  _GExpShipperBillStatus.IsShowMobile, 
					"@StatusBackgroundColor",  _GExpShipperBillStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpShipperBillStatus.StatusTextColor, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperBillStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpShipperBillStatus _GExpShipperBillStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperBillStatus] SET StatusName=@StatusName, IsShowMobile=@IsShowMobile, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor WHERE Id=@Id", 
					"@StatusName",  _GExpShipperBillStatus.StatusName, 
					"@IsShowMobile",  _GExpShipperBillStatus.IsShowMobile, 
					"@StatusBackgroundColor",  _GExpShipperBillStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpShipperBillStatus.StatusTextColor, 
					"@Id", _GExpShipperBillStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpShipperBillStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpShipperBillStatus> _GExpShipperBillStatuss)
		{
			foreach (GExpShipperBillStatus item in _GExpShipperBillStatuss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperBillStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpShipperBillStatus _GExpShipperBillStatus, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperBillStatus] SET Id=@Id, StatusName=@StatusName, IsShowMobile=@IsShowMobile, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor "+ condition, 
					"@Id",  _GExpShipperBillStatus.Id, 
					"@StatusName",  _GExpShipperBillStatus.StatusName, 
					"@IsShowMobile",  _GExpShipperBillStatus.IsShowMobile, 
					"@StatusBackgroundColor",  _GExpShipperBillStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpShipperBillStatus.StatusTextColor);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpShipperBillStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperBillStatus] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperBillStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpShipperBillStatus _GExpShipperBillStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperBillStatus] WHERE Id=@Id",
					"@Id", _GExpShipperBillStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperBillStatus trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperBillStatus] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperBillStatus trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpShipperBillStatus> _GExpShipperBillStatuss)
		{
			foreach (GExpShipperBillStatus item in _GExpShipperBillStatuss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
