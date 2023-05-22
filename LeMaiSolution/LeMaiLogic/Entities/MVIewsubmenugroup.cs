using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewsubmenugroup:IVIewsubmenugroup
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewsubmenugroup(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_SubMenuGroup từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SubMenuGroup]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_SubMenuGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SubMenuGroup] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_SubMenuGroup từ Database
		/// </summary>
		public List<view_SubMenuGroup> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SubMenuGroup]");
				List<view_SubMenuGroup> items = new List<view_SubMenuGroup>();
				view_SubMenuGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SubMenuGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
					}
					if (dr["CssClass"] != null && dr["CssClass"] != DBNull.Value)
					{
						item.CssClass = Convert.ToString(dr["CssClass"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["FK_MenuGroup"] != null && dr["FK_MenuGroup"] != DBNull.Value)
					{
						item.FK_MenuGroup = Convert.ToString(dr["FK_MenuGroup"]);
					}
					if (dr["ProjectUsed"] != null && dr["ProjectUsed"] != DBNull.Value)
					{
						item.ProjectUsed = Convert.ToInt32(dr["ProjectUsed"]);
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
		/// Lấy danh sách view_SubMenuGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_SubMenuGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SubMenuGroup] A "+ condition,  parameters);
				List<view_SubMenuGroup> items = new List<view_SubMenuGroup>();
				view_SubMenuGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SubMenuGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
					}
					if (dr["CssClass"] != null && dr["CssClass"] != DBNull.Value)
					{
						item.CssClass = Convert.ToString(dr["CssClass"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["FK_MenuGroup"] != null && dr["FK_MenuGroup"] != DBNull.Value)
					{
						item.FK_MenuGroup = Convert.ToString(dr["FK_MenuGroup"]);
					}
					if (dr["ProjectUsed"] != null && dr["ProjectUsed"] != DBNull.Value)
					{
						item.ProjectUsed = Convert.ToInt32(dr["ProjectUsed"]);
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<view_SubMenuGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SubMenuGroup] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_SubMenuGroup] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_SubMenuGroup>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_SubMenuGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_SubMenuGroup GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SubMenuGroup] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_SubMenuGroup item=new view_SubMenuGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
						{
							item.GroupName = Convert.ToString(dr["GroupName"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
						{
							item.Icon = Convert.ToString(dr["Icon"]);
						}
						if (dr["CssClass"] != null && dr["CssClass"] != DBNull.Value)
						{
							item.CssClass = Convert.ToString(dr["CssClass"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["FK_MenuGroup"] != null && dr["FK_MenuGroup"] != DBNull.Value)
						{
							item.FK_MenuGroup = Convert.ToString(dr["FK_MenuGroup"]);
						}
						if (dr["ProjectUsed"] != null && dr["ProjectUsed"] != DBNull.Value)
						{
							item.ProjectUsed = Convert.ToInt32(dr["ProjectUsed"]);
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

		public view_SubMenuGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SubMenuGroup] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_SubMenuGroup>(ds);
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
