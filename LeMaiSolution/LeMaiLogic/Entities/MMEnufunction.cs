using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEnufunction:IMEnufunction
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEnufunction(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MenuFunction từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MenuFunction từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MenuFunction từ Database
		/// </summary>
		public List<MenuFunction> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction]");
				List<MenuFunction> items = new List<MenuFunction>();
				MenuFunction item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuFunction();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Title"] != null && dr["Title"] != DBNull.Value)
					{
						item.Title = Convert.ToString(dr["Title"]);
					}
					if (dr["ControllerName"] != null && dr["ControllerName"] != DBNull.Value)
					{
						item.ControllerName = Convert.ToString(dr["ControllerName"]);
					}
					if (dr["AcctionName"] != null && dr["AcctionName"] != DBNull.Value)
					{
						item.AcctionName = Convert.ToString(dr["AcctionName"]);
					}
					if (dr["ControllerNameApi"] != null && dr["ControllerNameApi"] != DBNull.Value)
					{
						item.ControllerNameApi = Convert.ToString(dr["ControllerNameApi"]);
					}
					if (dr["AcctionNameApi"] != null && dr["AcctionNameApi"] != DBNull.Value)
					{
						item.AcctionNameApi = Convert.ToString(dr["AcctionNameApi"]);
					}
					if (dr["RouteId"] != null && dr["RouteId"] != DBNull.Value)
					{
						item.RouteId = Convert.ToString(dr["RouteId"]);
					}
					if (dr["IsMenu"] != null && dr["IsMenu"] != DBNull.Value)
					{
						item.IsMenu = Convert.ToBoolean(dr["IsMenu"]);
					}
					if (dr["IsPublic"] != null && dr["IsPublic"] != DBNull.Value)
					{
						item.IsPublic = Convert.ToBoolean(dr["IsPublic"]);
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
					}
					if (dr["CssClass"] != null && dr["CssClass"] != DBNull.Value)
					{
						item.CssClass = Convert.ToString(dr["CssClass"]);
					}
					if (dr["Parrent"] != null && dr["Parrent"] != DBNull.Value)
					{
						item.Parrent = Convert.ToString(dr["Parrent"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["ProjectUsed"] != null && dr["ProjectUsed"] != DBNull.Value)
					{
						item.ProjectUsed = Convert.ToInt32(dr["ProjectUsed"]);
					}
					if (dr["FK_MenuGroup"] != null && dr["FK_MenuGroup"] != DBNull.Value)
					{
						item.FK_MenuGroup = Convert.ToString(dr["FK_MenuGroup"]);
					}
					if (dr["MenuWidth"] != null && dr["MenuWidth"] != DBNull.Value)
					{
						item.MenuWidth = Convert.ToInt32(dr["MenuWidth"]);
					}
					if (dr["MenuImageName"] != null && dr["MenuImageName"] != DBNull.Value)
					{
						item.MenuImageName = Convert.ToString(dr["MenuImageName"]);
					}
					if (dr["FK_MenuImage"] != null && dr["FK_MenuImage"] != DBNull.Value)
					{
						item.FK_MenuImage = Convert.ToString(dr["FK_MenuImage"]);
					}
					if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
					{
						item.CreateUser = Convert.ToString(dr["CreateUser"]);
					}
					if (dr["UpdateUser"] != null && dr["UpdateUser"] != DBNull.Value)
					{
						item.UpdateUser = Convert.ToString(dr["UpdateUser"]);
					}
					if (dr["FormShowType"] != null && dr["FormShowType"] != DBNull.Value)
					{
						item.FormShowType = Convert.ToInt32(dr["FormShowType"]);
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
		/// Lấy danh sách MenuFunction từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MenuFunction> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuFunction] A "+ condition,  parameters);
				List<MenuFunction> items = new List<MenuFunction>();
				MenuFunction item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuFunction();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Title"] != null && dr["Title"] != DBNull.Value)
					{
						item.Title = Convert.ToString(dr["Title"]);
					}
					if (dr["ControllerName"] != null && dr["ControllerName"] != DBNull.Value)
					{
						item.ControllerName = Convert.ToString(dr["ControllerName"]);
					}
					if (dr["AcctionName"] != null && dr["AcctionName"] != DBNull.Value)
					{
						item.AcctionName = Convert.ToString(dr["AcctionName"]);
					}
					if (dr["ControllerNameApi"] != null && dr["ControllerNameApi"] != DBNull.Value)
					{
						item.ControllerNameApi = Convert.ToString(dr["ControllerNameApi"]);
					}
					if (dr["AcctionNameApi"] != null && dr["AcctionNameApi"] != DBNull.Value)
					{
						item.AcctionNameApi = Convert.ToString(dr["AcctionNameApi"]);
					}
					if (dr["RouteId"] != null && dr["RouteId"] != DBNull.Value)
					{
						item.RouteId = Convert.ToString(dr["RouteId"]);
					}
					if (dr["IsMenu"] != null && dr["IsMenu"] != DBNull.Value)
					{
						item.IsMenu = Convert.ToBoolean(dr["IsMenu"]);
					}
					if (dr["IsPublic"] != null && dr["IsPublic"] != DBNull.Value)
					{
						item.IsPublic = Convert.ToBoolean(dr["IsPublic"]);
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
					}
					if (dr["CssClass"] != null && dr["CssClass"] != DBNull.Value)
					{
						item.CssClass = Convert.ToString(dr["CssClass"]);
					}
					if (dr["Parrent"] != null && dr["Parrent"] != DBNull.Value)
					{
						item.Parrent = Convert.ToString(dr["Parrent"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["ProjectUsed"] != null && dr["ProjectUsed"] != DBNull.Value)
					{
						item.ProjectUsed = Convert.ToInt32(dr["ProjectUsed"]);
					}
					if (dr["FK_MenuGroup"] != null && dr["FK_MenuGroup"] != DBNull.Value)
					{
						item.FK_MenuGroup = Convert.ToString(dr["FK_MenuGroup"]);
					}
					if (dr["MenuWidth"] != null && dr["MenuWidth"] != DBNull.Value)
					{
						item.MenuWidth = Convert.ToInt32(dr["MenuWidth"]);
					}
					if (dr["MenuImageName"] != null && dr["MenuImageName"] != DBNull.Value)
					{
						item.MenuImageName = Convert.ToString(dr["MenuImageName"]);
					}
					if (dr["FK_MenuImage"] != null && dr["FK_MenuImage"] != DBNull.Value)
					{
						item.FK_MenuImage = Convert.ToString(dr["FK_MenuImage"]);
					}
					if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
					{
						item.CreateUser = Convert.ToString(dr["CreateUser"]);
					}
					if (dr["UpdateUser"] != null && dr["UpdateUser"] != DBNull.Value)
					{
						item.UpdateUser = Convert.ToString(dr["UpdateUser"]);
					}
					if (dr["FormShowType"] != null && dr["FormShowType"] != DBNull.Value)
					{
						item.FormShowType = Convert.ToInt32(dr["FormShowType"]);
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

		public List<MenuFunction> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuFunction] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MenuFunction] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MenuFunction>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MenuFunction từ Database
		/// </summary>
		public MenuFunction GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunction] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MenuFunction item=new MenuFunction();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Title"] != null && dr["Title"] != DBNull.Value)
						{
							item.Title = Convert.ToString(dr["Title"]);
						}
						if (dr["ControllerName"] != null && dr["ControllerName"] != DBNull.Value)
						{
							item.ControllerName = Convert.ToString(dr["ControllerName"]);
						}
						if (dr["AcctionName"] != null && dr["AcctionName"] != DBNull.Value)
						{
							item.AcctionName = Convert.ToString(dr["AcctionName"]);
						}
						if (dr["ControllerNameApi"] != null && dr["ControllerNameApi"] != DBNull.Value)
						{
							item.ControllerNameApi = Convert.ToString(dr["ControllerNameApi"]);
						}
						if (dr["AcctionNameApi"] != null && dr["AcctionNameApi"] != DBNull.Value)
						{
							item.AcctionNameApi = Convert.ToString(dr["AcctionNameApi"]);
						}
						if (dr["RouteId"] != null && dr["RouteId"] != DBNull.Value)
						{
							item.RouteId = Convert.ToString(dr["RouteId"]);
						}
						if (dr["IsMenu"] != null && dr["IsMenu"] != DBNull.Value)
						{
							item.IsMenu = Convert.ToBoolean(dr["IsMenu"]);
						}
						if (dr["IsPublic"] != null && dr["IsPublic"] != DBNull.Value)
						{
							item.IsPublic = Convert.ToBoolean(dr["IsPublic"]);
						}
						if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
						{
							item.Icon = Convert.ToString(dr["Icon"]);
						}
						if (dr["CssClass"] != null && dr["CssClass"] != DBNull.Value)
						{
							item.CssClass = Convert.ToString(dr["CssClass"]);
						}
						if (dr["Parrent"] != null && dr["Parrent"] != DBNull.Value)
						{
							item.Parrent = Convert.ToString(dr["Parrent"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["ProjectUsed"] != null && dr["ProjectUsed"] != DBNull.Value)
						{
							item.ProjectUsed = Convert.ToInt32(dr["ProjectUsed"]);
						}
						if (dr["FK_MenuGroup"] != null && dr["FK_MenuGroup"] != DBNull.Value)
						{
							item.FK_MenuGroup = Convert.ToString(dr["FK_MenuGroup"]);
						}
						if (dr["MenuWidth"] != null && dr["MenuWidth"] != DBNull.Value)
						{
							item.MenuWidth = Convert.ToInt32(dr["MenuWidth"]);
						}
						if (dr["MenuImageName"] != null && dr["MenuImageName"] != DBNull.Value)
						{
							item.MenuImageName = Convert.ToString(dr["MenuImageName"]);
						}
						if (dr["FK_MenuImage"] != null && dr["FK_MenuImage"] != DBNull.Value)
						{
							item.FK_MenuImage = Convert.ToString(dr["FK_MenuImage"]);
						}
						if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
						{
							item.CreateUser = Convert.ToString(dr["CreateUser"]);
						}
						if (dr["UpdateUser"] != null && dr["UpdateUser"] != DBNull.Value)
						{
							item.UpdateUser = Convert.ToString(dr["UpdateUser"]);
						}
						if (dr["FormShowType"] != null && dr["FormShowType"] != DBNull.Value)
						{
							item.FormShowType = Convert.ToInt32(dr["FormShowType"]);
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
		/// Lấy một MenuFunction đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MenuFunction GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuFunction] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MenuFunction item=new MenuFunction();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Title"] != null && dr["Title"] != DBNull.Value)
						{
							item.Title = Convert.ToString(dr["Title"]);
						}
						if (dr["ControllerName"] != null && dr["ControllerName"] != DBNull.Value)
						{
							item.ControllerName = Convert.ToString(dr["ControllerName"]);
						}
						if (dr["AcctionName"] != null && dr["AcctionName"] != DBNull.Value)
						{
							item.AcctionName = Convert.ToString(dr["AcctionName"]);
						}
						if (dr["ControllerNameApi"] != null && dr["ControllerNameApi"] != DBNull.Value)
						{
							item.ControllerNameApi = Convert.ToString(dr["ControllerNameApi"]);
						}
						if (dr["AcctionNameApi"] != null && dr["AcctionNameApi"] != DBNull.Value)
						{
							item.AcctionNameApi = Convert.ToString(dr["AcctionNameApi"]);
						}
						if (dr["RouteId"] != null && dr["RouteId"] != DBNull.Value)
						{
							item.RouteId = Convert.ToString(dr["RouteId"]);
						}
						if (dr["IsMenu"] != null && dr["IsMenu"] != DBNull.Value)
						{
							item.IsMenu = Convert.ToBoolean(dr["IsMenu"]);
						}
						if (dr["IsPublic"] != null && dr["IsPublic"] != DBNull.Value)
						{
							item.IsPublic = Convert.ToBoolean(dr["IsPublic"]);
						}
						if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
						{
							item.Icon = Convert.ToString(dr["Icon"]);
						}
						if (dr["CssClass"] != null && dr["CssClass"] != DBNull.Value)
						{
							item.CssClass = Convert.ToString(dr["CssClass"]);
						}
						if (dr["Parrent"] != null && dr["Parrent"] != DBNull.Value)
						{
							item.Parrent = Convert.ToString(dr["Parrent"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["ProjectUsed"] != null && dr["ProjectUsed"] != DBNull.Value)
						{
							item.ProjectUsed = Convert.ToInt32(dr["ProjectUsed"]);
						}
						if (dr["FK_MenuGroup"] != null && dr["FK_MenuGroup"] != DBNull.Value)
						{
							item.FK_MenuGroup = Convert.ToString(dr["FK_MenuGroup"]);
						}
						if (dr["MenuWidth"] != null && dr["MenuWidth"] != DBNull.Value)
						{
							item.MenuWidth = Convert.ToInt32(dr["MenuWidth"]);
						}
						if (dr["MenuImageName"] != null && dr["MenuImageName"] != DBNull.Value)
						{
							item.MenuImageName = Convert.ToString(dr["MenuImageName"]);
						}
						if (dr["FK_MenuImage"] != null && dr["FK_MenuImage"] != DBNull.Value)
						{
							item.FK_MenuImage = Convert.ToString(dr["FK_MenuImage"]);
						}
						if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
						{
							item.CreateUser = Convert.ToString(dr["CreateUser"]);
						}
						if (dr["UpdateUser"] != null && dr["UpdateUser"] != DBNull.Value)
						{
							item.UpdateUser = Convert.ToString(dr["UpdateUser"]);
						}
						if (dr["FormShowType"] != null && dr["FormShowType"] != DBNull.Value)
						{
							item.FormShowType = Convert.ToInt32(dr["FormShowType"]);
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

		public MenuFunction GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuFunction] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MenuFunction>(ds);
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
		/// Thêm mới MenuFunction vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MenuFunction _MenuFunction)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MenuFunction](Id, Title, ControllerName, AcctionName, ControllerNameApi, AcctionNameApi, RouteId, IsMenu, IsPublic, Icon, CssClass, Parrent, Status, CreateDate, SortIndex, Note, ProjectUsed, FK_MenuGroup, MenuWidth, MenuImageName, FK_MenuImage, CreateUser, UpdateUser, FormShowType) VALUES(@Id, @Title, @ControllerName, @AcctionName, @ControllerNameApi, @AcctionNameApi, @RouteId, @IsMenu, @IsPublic, @Icon, @CssClass, @Parrent, @Status, @CreateDate, @SortIndex, @Note, @ProjectUsed, @FK_MenuGroup, @MenuWidth, @MenuImageName, @FK_MenuImage, @CreateUser, @UpdateUser, @FormShowType)", 
					"@Id",  _MenuFunction.Id, 
					"@Title",  _MenuFunction.Title, 
					"@ControllerName",  _MenuFunction.ControllerName, 
					"@AcctionName",  _MenuFunction.AcctionName, 
					"@ControllerNameApi",  _MenuFunction.ControllerNameApi, 
					"@AcctionNameApi",  _MenuFunction.AcctionNameApi, 
					"@RouteId",  _MenuFunction.RouteId, 
					"@IsMenu",  _MenuFunction.IsMenu, 
					"@IsPublic",  _MenuFunction.IsPublic, 
					"@Icon",  _MenuFunction.Icon, 
					"@CssClass",  _MenuFunction.CssClass, 
					"@Parrent",  _MenuFunction.Parrent, 
					"@Status",  _MenuFunction.Status, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction.CreateDate), 
					"@SortIndex",  _MenuFunction.SortIndex, 
					"@Note",  _MenuFunction.Note, 
					"@ProjectUsed",  _MenuFunction.ProjectUsed, 
					"@FK_MenuGroup",  _MenuFunction.FK_MenuGroup, 
					"@MenuWidth",  _MenuFunction.MenuWidth, 
					"@MenuImageName",  _MenuFunction.MenuImageName, 
					"@FK_MenuImage",  _MenuFunction.FK_MenuImage, 
					"@CreateUser",  _MenuFunction.CreateUser, 
					"@UpdateUser",  _MenuFunction.UpdateUser, 
					"@FormShowType",  _MenuFunction.FormShowType);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MenuFunction vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MenuFunction> _MenuFunctions)
		{
			foreach (MenuFunction item in _MenuFunctions)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuFunction vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MenuFunction _MenuFunction, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunction] SET Id=@Id, Title=@Title, ControllerName=@ControllerName, AcctionName=@AcctionName, ControllerNameApi=@ControllerNameApi, AcctionNameApi=@AcctionNameApi, RouteId=@RouteId, IsMenu=@IsMenu, IsPublic=@IsPublic, Icon=@Icon, CssClass=@CssClass, Parrent=@Parrent, Status=@Status, CreateDate=@CreateDate, SortIndex=@SortIndex, Note=@Note, ProjectUsed=@ProjectUsed, FK_MenuGroup=@FK_MenuGroup, MenuWidth=@MenuWidth, MenuImageName=@MenuImageName, FK_MenuImage=@FK_MenuImage, CreateUser=@CreateUser, UpdateUser=@UpdateUser, FormShowType=@FormShowType WHERE Id=@Id", 
					"@Id",  _MenuFunction.Id, 
					"@Title",  _MenuFunction.Title, 
					"@ControllerName",  _MenuFunction.ControllerName, 
					"@AcctionName",  _MenuFunction.AcctionName, 
					"@ControllerNameApi",  _MenuFunction.ControllerNameApi, 
					"@AcctionNameApi",  _MenuFunction.AcctionNameApi, 
					"@RouteId",  _MenuFunction.RouteId, 
					"@IsMenu",  _MenuFunction.IsMenu, 
					"@IsPublic",  _MenuFunction.IsPublic, 
					"@Icon",  _MenuFunction.Icon, 
					"@CssClass",  _MenuFunction.CssClass, 
					"@Parrent",  _MenuFunction.Parrent, 
					"@Status",  _MenuFunction.Status, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction.CreateDate), 
					"@SortIndex",  _MenuFunction.SortIndex, 
					"@Note",  _MenuFunction.Note, 
					"@ProjectUsed",  _MenuFunction.ProjectUsed, 
					"@FK_MenuGroup",  _MenuFunction.FK_MenuGroup, 
					"@MenuWidth",  _MenuFunction.MenuWidth, 
					"@MenuImageName",  _MenuFunction.MenuImageName, 
					"@FK_MenuImage",  _MenuFunction.FK_MenuImage, 
					"@CreateUser",  _MenuFunction.CreateUser, 
					"@UpdateUser",  _MenuFunction.UpdateUser, 
					"@FormShowType",  _MenuFunction.FormShowType, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MenuFunction vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MenuFunction _MenuFunction)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunction] SET Title=@Title, ControllerName=@ControllerName, AcctionName=@AcctionName, ControllerNameApi=@ControllerNameApi, AcctionNameApi=@AcctionNameApi, RouteId=@RouteId, IsMenu=@IsMenu, IsPublic=@IsPublic, Icon=@Icon, CssClass=@CssClass, Parrent=@Parrent, Status=@Status, CreateDate=@CreateDate, SortIndex=@SortIndex, Note=@Note, ProjectUsed=@ProjectUsed, FK_MenuGroup=@FK_MenuGroup, MenuWidth=@MenuWidth, MenuImageName=@MenuImageName, FK_MenuImage=@FK_MenuImage, CreateUser=@CreateUser, UpdateUser=@UpdateUser, FormShowType=@FormShowType WHERE Id=@Id", 
					"@Title",  _MenuFunction.Title, 
					"@ControllerName",  _MenuFunction.ControllerName, 
					"@AcctionName",  _MenuFunction.AcctionName, 
					"@ControllerNameApi",  _MenuFunction.ControllerNameApi, 
					"@AcctionNameApi",  _MenuFunction.AcctionNameApi, 
					"@RouteId",  _MenuFunction.RouteId, 
					"@IsMenu",  _MenuFunction.IsMenu, 
					"@IsPublic",  _MenuFunction.IsPublic, 
					"@Icon",  _MenuFunction.Icon, 
					"@CssClass",  _MenuFunction.CssClass, 
					"@Parrent",  _MenuFunction.Parrent, 
					"@Status",  _MenuFunction.Status, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction.CreateDate), 
					"@SortIndex",  _MenuFunction.SortIndex, 
					"@Note",  _MenuFunction.Note, 
					"@ProjectUsed",  _MenuFunction.ProjectUsed, 
					"@FK_MenuGroup",  _MenuFunction.FK_MenuGroup, 
					"@MenuWidth",  _MenuFunction.MenuWidth, 
					"@MenuImageName",  _MenuFunction.MenuImageName, 
					"@FK_MenuImage",  _MenuFunction.FK_MenuImage, 
					"@CreateUser",  _MenuFunction.CreateUser, 
					"@UpdateUser",  _MenuFunction.UpdateUser, 
					"@FormShowType",  _MenuFunction.FormShowType, 
					"@Id", _MenuFunction.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MenuFunction vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MenuFunction> _MenuFunctions)
		{
			foreach (MenuFunction item in _MenuFunctions)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuFunction vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MenuFunction _MenuFunction, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunction] SET Id=@Id, Title=@Title, ControllerName=@ControllerName, AcctionName=@AcctionName, ControllerNameApi=@ControllerNameApi, AcctionNameApi=@AcctionNameApi, RouteId=@RouteId, IsMenu=@IsMenu, IsPublic=@IsPublic, Icon=@Icon, CssClass=@CssClass, Parrent=@Parrent, Status=@Status, CreateDate=@CreateDate, SortIndex=@SortIndex, Note=@Note, ProjectUsed=@ProjectUsed, FK_MenuGroup=@FK_MenuGroup, MenuWidth=@MenuWidth, MenuImageName=@MenuImageName, FK_MenuImage=@FK_MenuImage, CreateUser=@CreateUser, UpdateUser=@UpdateUser, FormShowType=@FormShowType "+ condition, 
					"@Id",  _MenuFunction.Id, 
					"@Title",  _MenuFunction.Title, 
					"@ControllerName",  _MenuFunction.ControllerName, 
					"@AcctionName",  _MenuFunction.AcctionName, 
					"@ControllerNameApi",  _MenuFunction.ControllerNameApi, 
					"@AcctionNameApi",  _MenuFunction.AcctionNameApi, 
					"@RouteId",  _MenuFunction.RouteId, 
					"@IsMenu",  _MenuFunction.IsMenu, 
					"@IsPublic",  _MenuFunction.IsPublic, 
					"@Icon",  _MenuFunction.Icon, 
					"@CssClass",  _MenuFunction.CssClass, 
					"@Parrent",  _MenuFunction.Parrent, 
					"@Status",  _MenuFunction.Status, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunction.CreateDate), 
					"@SortIndex",  _MenuFunction.SortIndex, 
					"@Note",  _MenuFunction.Note, 
					"@ProjectUsed",  _MenuFunction.ProjectUsed, 
					"@FK_MenuGroup",  _MenuFunction.FK_MenuGroup, 
					"@MenuWidth",  _MenuFunction.MenuWidth, 
					"@MenuImageName",  _MenuFunction.MenuImageName, 
					"@FK_MenuImage",  _MenuFunction.FK_MenuImage, 
					"@CreateUser",  _MenuFunction.CreateUser, 
					"@UpdateUser",  _MenuFunction.UpdateUser, 
					"@FormShowType",  _MenuFunction.FormShowType);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MenuFunction trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunction] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunction trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MenuFunction _MenuFunction)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunction] WHERE Id=@Id",
					"@Id", _MenuFunction.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunction trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunction] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunction trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MenuFunction> _MenuFunctions)
		{
			foreach (MenuFunction item in _MenuFunctions)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
