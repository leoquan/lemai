using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbicon:IWEbicon
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbicon(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebIcon từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebIcon]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebIcon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebIcon] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebIcon từ Database
		/// </summary>
		public List<WebIcon> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebIcon]");
				List<WebIcon> items = new List<WebIcon>();
				WebIcon item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebIcon();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["IconName"] != null && dr["IconName"] != DBNull.Value)
					{
						item.IconName = Convert.ToString(dr["IconName"]);
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
		/// Lấy danh sách WebIcon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebIcon> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebIcon] A "+ condition,  parameters);
				List<WebIcon> items = new List<WebIcon>();
				WebIcon item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebIcon();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["IconName"] != null && dr["IconName"] != DBNull.Value)
					{
						item.IconName = Convert.ToString(dr["IconName"]);
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

		public List<WebIcon> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebIcon] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebIcon] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebIcon>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebIcon từ Database
		/// </summary>
		public WebIcon GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebIcon] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebIcon item=new WebIcon();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["IconName"] != null && dr["IconName"] != DBNull.Value)
						{
							item.IconName = Convert.ToString(dr["IconName"]);
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
		/// Lấy một WebIcon đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebIcon GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebIcon] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebIcon item=new WebIcon();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["IconName"] != null && dr["IconName"] != DBNull.Value)
						{
							item.IconName = Convert.ToString(dr["IconName"]);
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

		public WebIcon GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebIcon] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebIcon>(ds);
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
		/// Thêm mới WebIcon vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebIcon _WebIcon)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebIcon](Id, IconName, BranchCode) VALUES(@Id, @IconName, @BranchCode)", 
					"@Id",  _WebIcon.Id, 
					"@IconName",  _WebIcon.IconName, 
					"@BranchCode",  _WebIcon.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebIcon vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebIcon> _WebIcons)
		{
			foreach (WebIcon item in _WebIcons)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebIcon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebIcon _WebIcon, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebIcon] SET Id=@Id, IconName=@IconName, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebIcon.Id, 
					"@IconName",  _WebIcon.IconName, 
					"@BranchCode",  _WebIcon.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebIcon vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebIcon _WebIcon)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebIcon] SET IconName=@IconName, BranchCode=@BranchCode WHERE Id=@Id", 
					"@IconName",  _WebIcon.IconName, 
					"@BranchCode",  _WebIcon.BranchCode, 
					"@Id", _WebIcon.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebIcon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebIcon> _WebIcons)
		{
			foreach (WebIcon item in _WebIcons)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebIcon vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebIcon _WebIcon, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebIcon] SET Id=@Id, IconName=@IconName, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebIcon.Id, 
					"@IconName",  _WebIcon.IconName, 
					"@BranchCode",  _WebIcon.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebIcon trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebIcon] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebIcon trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebIcon _WebIcon)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebIcon] WHERE Id=@Id",
					"@Id", _WebIcon.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebIcon trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebIcon] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebIcon trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebIcon> _WebIcons)
		{
			foreach (WebIcon item in _WebIcons)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
