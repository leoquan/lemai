using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewmenufunctionaccount:IVIewmenufunctionaccount
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewmenufunctionaccount(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_MenuFunctionAccount từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_MenuFunctionAccount]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_MenuFunctionAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_MenuFunctionAccount] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_MenuFunctionAccount từ Database
		/// </summary>
		public List<view_MenuFunctionAccount> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_MenuFunctionAccount]");
				List<view_MenuFunctionAccount> items = new List<view_MenuFunctionAccount>();
				view_MenuFunctionAccount item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_MenuFunctionAccount();
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
					if (dr["SubId"] != null && dr["SubId"] != DBNull.Value)
					{
						item.SubId = Convert.ToString(dr["SubId"]);
					}
					if (dr["SubGroupName"] != null && dr["SubGroupName"] != DBNull.Value)
					{
						item.SubGroupName = Convert.ToString(dr["SubGroupName"]);
					}
					if (dr["SubSortIndex"] != null && dr["SubSortIndex"] != DBNull.Value)
					{
						item.SubSortIndex = Convert.ToInt32(dr["SubSortIndex"]);
					}
					if (dr["SubIcon"] != null && dr["SubIcon"] != DBNull.Value)
					{
						item.SubIcon = Convert.ToString(dr["SubIcon"]);
					}
					if (dr["SubCssClass"] != null && dr["SubCssClass"] != DBNull.Value)
					{
						item.SubCssClass = Convert.ToString(dr["SubCssClass"]);
					}
					if (dr["SubCreateDate"] != null && dr["SubCreateDate"] != DBNull.Value)
					{
						item.SubCreateDate = Convert.ToDateTime(dr["SubCreateDate"]);
					}
					if (dr["SubStatus"] != null && dr["SubStatus"] != DBNull.Value)
					{
						item.SubStatus = Convert.ToInt32(dr["SubStatus"]);
					}
					if (dr["SubFK_MenuGroup"] != null && dr["SubFK_MenuGroup"] != DBNull.Value)
					{
						item.SubFK_MenuGroup = Convert.ToString(dr["SubFK_MenuGroup"]);
					}
					if (dr["SubProjectUsed"] != null && dr["SubProjectUsed"] != DBNull.Value)
					{
						item.SubProjectUsed = Convert.ToInt32(dr["SubProjectUsed"]);
					}
					if (dr["GroupId"] != null && dr["GroupId"] != DBNull.Value)
					{
						item.GroupId = Convert.ToString(dr["GroupId"]);
					}
					if (dr["GroupGroupName"] != null && dr["GroupGroupName"] != DBNull.Value)
					{
						item.GroupGroupName = Convert.ToString(dr["GroupGroupName"]);
					}
					if (dr["GroupSortIndex"] != null && dr["GroupSortIndex"] != DBNull.Value)
					{
						item.GroupSortIndex = Convert.ToInt32(dr["GroupSortIndex"]);
					}
					if (dr["GroupIcon"] != null && dr["GroupIcon"] != DBNull.Value)
					{
						item.GroupIcon = Convert.ToString(dr["GroupIcon"]);
					}
					if (dr["GroupCssClass"] != null && dr["GroupCssClass"] != DBNull.Value)
					{
						item.GroupCssClass = Convert.ToString(dr["GroupCssClass"]);
					}
					if (dr["GroupCreateDate"] != null && dr["GroupCreateDate"] != DBNull.Value)
					{
						item.GroupCreateDate = Convert.ToDateTime(dr["GroupCreateDate"]);
					}
					if (dr["GroupStatus"] != null && dr["GroupStatus"] != DBNull.Value)
					{
						item.GroupStatus = Convert.ToInt32(dr["GroupStatus"]);
					}
					if (dr["GroupFK_MenuGroup"] != null && dr["GroupFK_MenuGroup"] != DBNull.Value)
					{
						item.GroupFK_MenuGroup = Convert.ToString(dr["GroupFK_MenuGroup"]);
					}
					if (dr["GroupProjectUsed"] != null && dr["GroupProjectUsed"] != DBNull.Value)
					{
						item.GroupProjectUsed = Convert.ToInt32(dr["GroupProjectUsed"]);
					}
					if (dr["AccountId"] != null && dr["AccountId"] != DBNull.Value)
					{
						item.AccountId = Convert.ToString(dr["AccountId"]);
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
		/// Lấy danh sách view_MenuFunctionAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_MenuFunctionAccount> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_MenuFunctionAccount] A "+ condition,  parameters);
				List<view_MenuFunctionAccount> items = new List<view_MenuFunctionAccount>();
				view_MenuFunctionAccount item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_MenuFunctionAccount();
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
					if (dr["SubId"] != null && dr["SubId"] != DBNull.Value)
					{
						item.SubId = Convert.ToString(dr["SubId"]);
					}
					if (dr["SubGroupName"] != null && dr["SubGroupName"] != DBNull.Value)
					{
						item.SubGroupName = Convert.ToString(dr["SubGroupName"]);
					}
					if (dr["SubSortIndex"] != null && dr["SubSortIndex"] != DBNull.Value)
					{
						item.SubSortIndex = Convert.ToInt32(dr["SubSortIndex"]);
					}
					if (dr["SubIcon"] != null && dr["SubIcon"] != DBNull.Value)
					{
						item.SubIcon = Convert.ToString(dr["SubIcon"]);
					}
					if (dr["SubCssClass"] != null && dr["SubCssClass"] != DBNull.Value)
					{
						item.SubCssClass = Convert.ToString(dr["SubCssClass"]);
					}
					if (dr["SubCreateDate"] != null && dr["SubCreateDate"] != DBNull.Value)
					{
						item.SubCreateDate = Convert.ToDateTime(dr["SubCreateDate"]);
					}
					if (dr["SubStatus"] != null && dr["SubStatus"] != DBNull.Value)
					{
						item.SubStatus = Convert.ToInt32(dr["SubStatus"]);
					}
					if (dr["SubFK_MenuGroup"] != null && dr["SubFK_MenuGroup"] != DBNull.Value)
					{
						item.SubFK_MenuGroup = Convert.ToString(dr["SubFK_MenuGroup"]);
					}
					if (dr["SubProjectUsed"] != null && dr["SubProjectUsed"] != DBNull.Value)
					{
						item.SubProjectUsed = Convert.ToInt32(dr["SubProjectUsed"]);
					}
					if (dr["GroupId"] != null && dr["GroupId"] != DBNull.Value)
					{
						item.GroupId = Convert.ToString(dr["GroupId"]);
					}
					if (dr["GroupGroupName"] != null && dr["GroupGroupName"] != DBNull.Value)
					{
						item.GroupGroupName = Convert.ToString(dr["GroupGroupName"]);
					}
					if (dr["GroupSortIndex"] != null && dr["GroupSortIndex"] != DBNull.Value)
					{
						item.GroupSortIndex = Convert.ToInt32(dr["GroupSortIndex"]);
					}
					if (dr["GroupIcon"] != null && dr["GroupIcon"] != DBNull.Value)
					{
						item.GroupIcon = Convert.ToString(dr["GroupIcon"]);
					}
					if (dr["GroupCssClass"] != null && dr["GroupCssClass"] != DBNull.Value)
					{
						item.GroupCssClass = Convert.ToString(dr["GroupCssClass"]);
					}
					if (dr["GroupCreateDate"] != null && dr["GroupCreateDate"] != DBNull.Value)
					{
						item.GroupCreateDate = Convert.ToDateTime(dr["GroupCreateDate"]);
					}
					if (dr["GroupStatus"] != null && dr["GroupStatus"] != DBNull.Value)
					{
						item.GroupStatus = Convert.ToInt32(dr["GroupStatus"]);
					}
					if (dr["GroupFK_MenuGroup"] != null && dr["GroupFK_MenuGroup"] != DBNull.Value)
					{
						item.GroupFK_MenuGroup = Convert.ToString(dr["GroupFK_MenuGroup"]);
					}
					if (dr["GroupProjectUsed"] != null && dr["GroupProjectUsed"] != DBNull.Value)
					{
						item.GroupProjectUsed = Convert.ToInt32(dr["GroupProjectUsed"]);
					}
					if (dr["AccountId"] != null && dr["AccountId"] != DBNull.Value)
					{
						item.AccountId = Convert.ToString(dr["AccountId"]);
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

		public List<view_MenuFunctionAccount> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_MenuFunctionAccount] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_MenuFunctionAccount] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_MenuFunctionAccount>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_MenuFunctionAccount đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_MenuFunctionAccount GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_MenuFunctionAccount] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_MenuFunctionAccount item=new view_MenuFunctionAccount();
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
						if (dr["SubId"] != null && dr["SubId"] != DBNull.Value)
						{
							item.SubId = Convert.ToString(dr["SubId"]);
						}
						if (dr["SubGroupName"] != null && dr["SubGroupName"] != DBNull.Value)
						{
							item.SubGroupName = Convert.ToString(dr["SubGroupName"]);
						}
						if (dr["SubSortIndex"] != null && dr["SubSortIndex"] != DBNull.Value)
						{
							item.SubSortIndex = Convert.ToInt32(dr["SubSortIndex"]);
						}
						if (dr["SubIcon"] != null && dr["SubIcon"] != DBNull.Value)
						{
							item.SubIcon = Convert.ToString(dr["SubIcon"]);
						}
						if (dr["SubCssClass"] != null && dr["SubCssClass"] != DBNull.Value)
						{
							item.SubCssClass = Convert.ToString(dr["SubCssClass"]);
						}
						if (dr["SubCreateDate"] != null && dr["SubCreateDate"] != DBNull.Value)
						{
							item.SubCreateDate = Convert.ToDateTime(dr["SubCreateDate"]);
						}
						if (dr["SubStatus"] != null && dr["SubStatus"] != DBNull.Value)
						{
							item.SubStatus = Convert.ToInt32(dr["SubStatus"]);
						}
						if (dr["SubFK_MenuGroup"] != null && dr["SubFK_MenuGroup"] != DBNull.Value)
						{
							item.SubFK_MenuGroup = Convert.ToString(dr["SubFK_MenuGroup"]);
						}
						if (dr["SubProjectUsed"] != null && dr["SubProjectUsed"] != DBNull.Value)
						{
							item.SubProjectUsed = Convert.ToInt32(dr["SubProjectUsed"]);
						}
						if (dr["GroupId"] != null && dr["GroupId"] != DBNull.Value)
						{
							item.GroupId = Convert.ToString(dr["GroupId"]);
						}
						if (dr["GroupGroupName"] != null && dr["GroupGroupName"] != DBNull.Value)
						{
							item.GroupGroupName = Convert.ToString(dr["GroupGroupName"]);
						}
						if (dr["GroupSortIndex"] != null && dr["GroupSortIndex"] != DBNull.Value)
						{
							item.GroupSortIndex = Convert.ToInt32(dr["GroupSortIndex"]);
						}
						if (dr["GroupIcon"] != null && dr["GroupIcon"] != DBNull.Value)
						{
							item.GroupIcon = Convert.ToString(dr["GroupIcon"]);
						}
						if (dr["GroupCssClass"] != null && dr["GroupCssClass"] != DBNull.Value)
						{
							item.GroupCssClass = Convert.ToString(dr["GroupCssClass"]);
						}
						if (dr["GroupCreateDate"] != null && dr["GroupCreateDate"] != DBNull.Value)
						{
							item.GroupCreateDate = Convert.ToDateTime(dr["GroupCreateDate"]);
						}
						if (dr["GroupStatus"] != null && dr["GroupStatus"] != DBNull.Value)
						{
							item.GroupStatus = Convert.ToInt32(dr["GroupStatus"]);
						}
						if (dr["GroupFK_MenuGroup"] != null && dr["GroupFK_MenuGroup"] != DBNull.Value)
						{
							item.GroupFK_MenuGroup = Convert.ToString(dr["GroupFK_MenuGroup"]);
						}
						if (dr["GroupProjectUsed"] != null && dr["GroupProjectUsed"] != DBNull.Value)
						{
							item.GroupProjectUsed = Convert.ToInt32(dr["GroupProjectUsed"]);
						}
						if (dr["AccountId"] != null && dr["AccountId"] != DBNull.Value)
						{
							item.AccountId = Convert.ToString(dr["AccountId"]);
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

		public view_MenuFunctionAccount GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_MenuFunctionAccount] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_MenuFunctionAccount>(ds);
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
	}
}
