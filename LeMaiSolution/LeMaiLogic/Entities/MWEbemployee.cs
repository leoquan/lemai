using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbemployee:IWEbemployee
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbemployee(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebEmployee từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebEmployee]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebEmployee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebEmployee] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebEmployee từ Database
		/// </summary>
		public List<WebEmployee> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebEmployee]");
				List<WebEmployee> items = new List<WebEmployee>();
				WebEmployee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebEmployee();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Position"] != null && dr["Position"] != DBNull.Value)
					{
						item.Position = Convert.ToString(dr["Position"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["Facebook"] != null && dr["Facebook"] != DBNull.Value)
					{
						item.Facebook = Convert.ToString(dr["Facebook"]);
					}
					if (dr["Twitter"] != null && dr["Twitter"] != DBNull.Value)
					{
						item.Twitter = Convert.ToString(dr["Twitter"]);
					}
					if (dr["Instagram"] != null && dr["Instagram"] != DBNull.Value)
					{
						item.Instagram = Convert.ToString(dr["Instagram"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
					}
					if (dr["ShowOnAbout"] != null && dr["ShowOnAbout"] != DBNull.Value)
					{
						item.ShowOnAbout = Convert.ToBoolean(dr["ShowOnAbout"]);
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
		/// Lấy danh sách WebEmployee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebEmployee> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebEmployee] A "+ condition,  parameters);
				List<WebEmployee> items = new List<WebEmployee>();
				WebEmployee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebEmployee();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Position"] != null && dr["Position"] != DBNull.Value)
					{
						item.Position = Convert.ToString(dr["Position"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["Facebook"] != null && dr["Facebook"] != DBNull.Value)
					{
						item.Facebook = Convert.ToString(dr["Facebook"]);
					}
					if (dr["Twitter"] != null && dr["Twitter"] != DBNull.Value)
					{
						item.Twitter = Convert.ToString(dr["Twitter"]);
					}
					if (dr["Instagram"] != null && dr["Instagram"] != DBNull.Value)
					{
						item.Instagram = Convert.ToString(dr["Instagram"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
					}
					if (dr["ShowOnAbout"] != null && dr["ShowOnAbout"] != DBNull.Value)
					{
						item.ShowOnAbout = Convert.ToBoolean(dr["ShowOnAbout"]);
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

		public List<WebEmployee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebEmployee] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebEmployee] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebEmployee>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebEmployee từ Database
		/// </summary>
		public WebEmployee GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebEmployee] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebEmployee item=new WebEmployee();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Position"] != null && dr["Position"] != DBNull.Value)
						{
							item.Position = Convert.ToString(dr["Position"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["Facebook"] != null && dr["Facebook"] != DBNull.Value)
						{
							item.Facebook = Convert.ToString(dr["Facebook"]);
						}
						if (dr["Twitter"] != null && dr["Twitter"] != DBNull.Value)
						{
							item.Twitter = Convert.ToString(dr["Twitter"]);
						}
						if (dr["Instagram"] != null && dr["Instagram"] != DBNull.Value)
						{
							item.Instagram = Convert.ToString(dr["Instagram"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
						{
							item.Icon = Convert.ToString(dr["Icon"]);
						}
						if (dr["ShowOnAbout"] != null && dr["ShowOnAbout"] != DBNull.Value)
						{
							item.ShowOnAbout = Convert.ToBoolean(dr["ShowOnAbout"]);
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
		/// Lấy một WebEmployee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebEmployee GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebEmployee] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebEmployee item=new WebEmployee();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Position"] != null && dr["Position"] != DBNull.Value)
						{
							item.Position = Convert.ToString(dr["Position"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["Facebook"] != null && dr["Facebook"] != DBNull.Value)
						{
							item.Facebook = Convert.ToString(dr["Facebook"]);
						}
						if (dr["Twitter"] != null && dr["Twitter"] != DBNull.Value)
						{
							item.Twitter = Convert.ToString(dr["Twitter"]);
						}
						if (dr["Instagram"] != null && dr["Instagram"] != DBNull.Value)
						{
							item.Instagram = Convert.ToString(dr["Instagram"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
						{
							item.Icon = Convert.ToString(dr["Icon"]);
						}
						if (dr["ShowOnAbout"] != null && dr["ShowOnAbout"] != DBNull.Value)
						{
							item.ShowOnAbout = Convert.ToBoolean(dr["ShowOnAbout"]);
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

		public WebEmployee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebEmployee] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebEmployee>(ds);
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
		/// Thêm mới WebEmployee vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebEmployee _WebEmployee)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebEmployee](Id, Name, Position, Email, Facebook, Twitter, Instagram, OrderNumber, ImagePath, Icon, ShowOnAbout, BranchCode) VALUES(@Id, @Name, @Position, @Email, @Facebook, @Twitter, @Instagram, @OrderNumber, @ImagePath, @Icon, @ShowOnAbout, @BranchCode)", 
					"@Id",  _WebEmployee.Id, 
					"@Name",  _WebEmployee.Name, 
					"@Position",  _WebEmployee.Position, 
					"@Email",  _WebEmployee.Email, 
					"@Facebook",  _WebEmployee.Facebook, 
					"@Twitter",  _WebEmployee.Twitter, 
					"@Instagram",  _WebEmployee.Instagram, 
					"@OrderNumber",  _WebEmployee.OrderNumber, 
					"@ImagePath",  _WebEmployee.ImagePath, 
					"@Icon",  _WebEmployee.Icon, 
					"@ShowOnAbout",  _WebEmployee.ShowOnAbout, 
					"@BranchCode",  _WebEmployee.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebEmployee vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebEmployee> _WebEmployees)
		{
			foreach (WebEmployee item in _WebEmployees)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebEmployee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebEmployee _WebEmployee, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebEmployee] SET Id=@Id, Name=@Name, Position=@Position, Email=@Email, Facebook=@Facebook, Twitter=@Twitter, Instagram=@Instagram, OrderNumber=@OrderNumber, ImagePath=@ImagePath, Icon=@Icon, ShowOnAbout=@ShowOnAbout, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebEmployee.Id, 
					"@Name",  _WebEmployee.Name, 
					"@Position",  _WebEmployee.Position, 
					"@Email",  _WebEmployee.Email, 
					"@Facebook",  _WebEmployee.Facebook, 
					"@Twitter",  _WebEmployee.Twitter, 
					"@Instagram",  _WebEmployee.Instagram, 
					"@OrderNumber",  _WebEmployee.OrderNumber, 
					"@ImagePath",  _WebEmployee.ImagePath, 
					"@Icon",  _WebEmployee.Icon, 
					"@ShowOnAbout",  _WebEmployee.ShowOnAbout, 
					"@BranchCode",  _WebEmployee.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebEmployee vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebEmployee _WebEmployee)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebEmployee] SET Name=@Name, Position=@Position, Email=@Email, Facebook=@Facebook, Twitter=@Twitter, Instagram=@Instagram, OrderNumber=@OrderNumber, ImagePath=@ImagePath, Icon=@Icon, ShowOnAbout=@ShowOnAbout, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Name",  _WebEmployee.Name, 
					"@Position",  _WebEmployee.Position, 
					"@Email",  _WebEmployee.Email, 
					"@Facebook",  _WebEmployee.Facebook, 
					"@Twitter",  _WebEmployee.Twitter, 
					"@Instagram",  _WebEmployee.Instagram, 
					"@OrderNumber",  _WebEmployee.OrderNumber, 
					"@ImagePath",  _WebEmployee.ImagePath, 
					"@Icon",  _WebEmployee.Icon, 
					"@ShowOnAbout",  _WebEmployee.ShowOnAbout, 
					"@BranchCode",  _WebEmployee.BranchCode, 
					"@Id", _WebEmployee.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebEmployee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebEmployee> _WebEmployees)
		{
			foreach (WebEmployee item in _WebEmployees)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebEmployee vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebEmployee _WebEmployee, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebEmployee] SET Id=@Id, Name=@Name, Position=@Position, Email=@Email, Facebook=@Facebook, Twitter=@Twitter, Instagram=@Instagram, OrderNumber=@OrderNumber, ImagePath=@ImagePath, Icon=@Icon, ShowOnAbout=@ShowOnAbout, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebEmployee.Id, 
					"@Name",  _WebEmployee.Name, 
					"@Position",  _WebEmployee.Position, 
					"@Email",  _WebEmployee.Email, 
					"@Facebook",  _WebEmployee.Facebook, 
					"@Twitter",  _WebEmployee.Twitter, 
					"@Instagram",  _WebEmployee.Instagram, 
					"@OrderNumber",  _WebEmployee.OrderNumber, 
					"@ImagePath",  _WebEmployee.ImagePath, 
					"@Icon",  _WebEmployee.Icon, 
					"@ShowOnAbout",  _WebEmployee.ShowOnAbout, 
					"@BranchCode",  _WebEmployee.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebEmployee trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebEmployee] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebEmployee trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebEmployee _WebEmployee)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebEmployee] WHERE Id=@Id",
					"@Id", _WebEmployee.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebEmployee trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebEmployee] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebEmployee trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebEmployee> _WebEmployees)
		{
			foreach (WebEmployee item in _WebEmployees)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
