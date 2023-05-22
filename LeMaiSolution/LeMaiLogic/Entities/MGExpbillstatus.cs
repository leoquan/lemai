using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpbillstatus:IGExpbillstatus
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpbillstatus(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpBillStatus từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillStatus]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillStatus] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpBillStatus từ Database
		/// </summary>
		public List<GExpBillStatus> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillStatus]");
				List<GExpBillStatus> items = new List<GExpBillStatus>();
				GExpBillStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBillStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["StatusType"] != null && dr["StatusType"] != DBNull.Value)
					{
						item.StatusType = Convert.ToInt32(dr["StatusType"]);
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
					if (dr["SelectNV"] != null && dr["SelectNV"] != DBNull.Value)
					{
						item.SelectNV = Convert.ToInt32(dr["SelectNV"]);
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
		/// Lấy danh sách GExpBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpBillStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBillStatus] A "+ condition,  parameters);
				List<GExpBillStatus> items = new List<GExpBillStatus>();
				GExpBillStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBillStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["StatusType"] != null && dr["StatusType"] != DBNull.Value)
					{
						item.StatusType = Convert.ToInt32(dr["StatusType"]);
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
					if (dr["SelectNV"] != null && dr["SelectNV"] != DBNull.Value)
					{
						item.SelectNV = Convert.ToInt32(dr["SelectNV"]);
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

		public List<GExpBillStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBillStatus] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpBillStatus] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpBillStatus>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpBillStatus từ Database
		/// </summary>
		public GExpBillStatus GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillStatus] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpBillStatus item=new GExpBillStatus();
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
						if (dr["StatusType"] != null && dr["StatusType"] != DBNull.Value)
						{
							item.StatusType = Convert.ToInt32(dr["StatusType"]);
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
						if (dr["SelectNV"] != null && dr["SelectNV"] != DBNull.Value)
						{
							item.SelectNV = Convert.ToInt32(dr["SelectNV"]);
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
		/// Lấy một GExpBillStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpBillStatus GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBillStatus] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpBillStatus item=new GExpBillStatus();
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
						if (dr["StatusType"] != null && dr["StatusType"] != DBNull.Value)
						{
							item.StatusType = Convert.ToInt32(dr["StatusType"]);
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
						if (dr["SelectNV"] != null && dr["SelectNV"] != DBNull.Value)
						{
							item.SelectNV = Convert.ToInt32(dr["SelectNV"]);
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

		public GExpBillStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBillStatus] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpBillStatus>(ds);
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
		/// Thêm mới GExpBillStatus vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpBillStatus _GExpBillStatus)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpBillStatus](Id, StatusName, StatusType, IsShowMobile, StatusBackgroundColor, StatusTextColor, SelectNV) VALUES(@Id, @StatusName, @StatusType, @IsShowMobile, @StatusBackgroundColor, @StatusTextColor, @SelectNV)", 
					"@Id",  _GExpBillStatus.Id, 
					"@StatusName",  _GExpBillStatus.StatusName, 
					"@StatusType",  _GExpBillStatus.StatusType, 
					"@IsShowMobile",  _GExpBillStatus.IsShowMobile, 
					"@StatusBackgroundColor",  _GExpBillStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpBillStatus.StatusTextColor, 
					"@SelectNV",  _GExpBillStatus.SelectNV);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpBillStatus vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpBillStatus> _GExpBillStatuss)
		{
			foreach (GExpBillStatus item in _GExpBillStatuss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBillStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpBillStatus _GExpBillStatus, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBillStatus] SET Id=@Id, StatusName=@StatusName, StatusType=@StatusType, IsShowMobile=@IsShowMobile, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor, SelectNV=@SelectNV WHERE Id=@Id", 
					"@Id",  _GExpBillStatus.Id, 
					"@StatusName",  _GExpBillStatus.StatusName, 
					"@StatusType",  _GExpBillStatus.StatusType, 
					"@IsShowMobile",  _GExpBillStatus.IsShowMobile, 
					"@StatusBackgroundColor",  _GExpBillStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpBillStatus.StatusTextColor, 
					"@SelectNV",  _GExpBillStatus.SelectNV, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpBillStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpBillStatus _GExpBillStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBillStatus] SET StatusName=@StatusName, StatusType=@StatusType, IsShowMobile=@IsShowMobile, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor, SelectNV=@SelectNV WHERE Id=@Id", 
					"@StatusName",  _GExpBillStatus.StatusName, 
					"@StatusType",  _GExpBillStatus.StatusType, 
					"@IsShowMobile",  _GExpBillStatus.IsShowMobile, 
					"@StatusBackgroundColor",  _GExpBillStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpBillStatus.StatusTextColor, 
					"@SelectNV",  _GExpBillStatus.SelectNV, 
					"@Id", _GExpBillStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpBillStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpBillStatus> _GExpBillStatuss)
		{
			foreach (GExpBillStatus item in _GExpBillStatuss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBillStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpBillStatus _GExpBillStatus, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBillStatus] SET Id=@Id, StatusName=@StatusName, StatusType=@StatusType, IsShowMobile=@IsShowMobile, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor, SelectNV=@SelectNV "+ condition, 
					"@Id",  _GExpBillStatus.Id, 
					"@StatusName",  _GExpBillStatus.StatusName, 
					"@StatusType",  _GExpBillStatus.StatusType, 
					"@IsShowMobile",  _GExpBillStatus.IsShowMobile, 
					"@StatusBackgroundColor",  _GExpBillStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpBillStatus.StatusTextColor, 
					"@SelectNV",  _GExpBillStatus.SelectNV);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpBillStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBillStatus] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBillStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpBillStatus _GExpBillStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBillStatus] WHERE Id=@Id",
					"@Id", _GExpBillStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBillStatus trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBillStatus] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBillStatus trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpBillStatus> _GExpBillStatuss)
		{
			foreach (GExpBillStatus item in _GExpBillStatuss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
