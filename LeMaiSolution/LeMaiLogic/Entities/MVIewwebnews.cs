using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewwebnews:IVIewwebnews
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewwebnews(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_WebNews từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_WebNews]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_WebNews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_WebNews] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_WebNews từ Database
		/// </summary>
		public List<view_WebNews> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_WebNews]");
				List<view_WebNews> items = new List<view_WebNews>();
				view_WebNews item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_WebNews();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Title"] != null && dr["Title"] != DBNull.Value)
					{
						item.Title = Convert.ToString(dr["Title"]);
					}
					if (dr["Tag"] != null && dr["Tag"] != DBNull.Value)
					{
						item.Tag = Convert.ToString(dr["Tag"]);
					}
					if (dr["StaticLink"] != null && dr["StaticLink"] != DBNull.Value)
					{
						item.StaticLink = Convert.ToString(dr["StaticLink"]);
					}
					if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
					{
						item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
					}
					if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
					{
						item.ContentBody = Convert.ToString(dr["ContentBody"]);
					}
					if (dr["FK_Author"] != null && dr["FK_Author"] != DBNull.Value)
					{
						item.FK_Author = Convert.ToString(dr["FK_Author"]);
					}
					if (dr["FK_Category"] != null && dr["FK_Category"] != DBNull.Value)
					{
						item.FK_Category = Convert.ToString(dr["FK_Category"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["ShowPage"] != null && dr["ShowPage"] != DBNull.Value)
					{
						item.ShowPage = Convert.ToInt32(dr["ShowPage"]);
					}
					if (dr["StatusPage"] != null && dr["StatusPage"] != DBNull.Value)
					{
						item.StatusPage = Convert.ToInt32(dr["StatusPage"]);
					}
					if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
					{
						item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["CategoryName"] != null && dr["CategoryName"] != DBNull.Value)
					{
						item.CategoryName = Convert.ToString(dr["CategoryName"]);
					}
					if (dr["Path"] != null && dr["Path"] != DBNull.Value)
					{
						item.Path = Convert.ToString(dr["Path"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
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
		/// Lấy danh sách view_WebNews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_WebNews> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_WebNews] A "+ condition,  parameters);
				List<view_WebNews> items = new List<view_WebNews>();
				view_WebNews item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_WebNews();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Title"] != null && dr["Title"] != DBNull.Value)
					{
						item.Title = Convert.ToString(dr["Title"]);
					}
					if (dr["Tag"] != null && dr["Tag"] != DBNull.Value)
					{
						item.Tag = Convert.ToString(dr["Tag"]);
					}
					if (dr["StaticLink"] != null && dr["StaticLink"] != DBNull.Value)
					{
						item.StaticLink = Convert.ToString(dr["StaticLink"]);
					}
					if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
					{
						item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
					}
					if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
					{
						item.ContentBody = Convert.ToString(dr["ContentBody"]);
					}
					if (dr["FK_Author"] != null && dr["FK_Author"] != DBNull.Value)
					{
						item.FK_Author = Convert.ToString(dr["FK_Author"]);
					}
					if (dr["FK_Category"] != null && dr["FK_Category"] != DBNull.Value)
					{
						item.FK_Category = Convert.ToString(dr["FK_Category"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["ShowPage"] != null && dr["ShowPage"] != DBNull.Value)
					{
						item.ShowPage = Convert.ToInt32(dr["ShowPage"]);
					}
					if (dr["StatusPage"] != null && dr["StatusPage"] != DBNull.Value)
					{
						item.StatusPage = Convert.ToInt32(dr["StatusPage"]);
					}
					if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
					{
						item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["CategoryName"] != null && dr["CategoryName"] != DBNull.Value)
					{
						item.CategoryName = Convert.ToString(dr["CategoryName"]);
					}
					if (dr["Path"] != null && dr["Path"] != DBNull.Value)
					{
						item.Path = Convert.ToString(dr["Path"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
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

		public List<view_WebNews> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_WebNews] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_WebNews] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_WebNews>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_WebNews đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_WebNews GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_WebNews] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_WebNews item=new view_WebNews();
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
						if (dr["Tag"] != null && dr["Tag"] != DBNull.Value)
						{
							item.Tag = Convert.ToString(dr["Tag"]);
						}
						if (dr["StaticLink"] != null && dr["StaticLink"] != DBNull.Value)
						{
							item.StaticLink = Convert.ToString(dr["StaticLink"]);
						}
						if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
						{
							item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
						}
						if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
						{
							item.ContentBody = Convert.ToString(dr["ContentBody"]);
						}
						if (dr["FK_Author"] != null && dr["FK_Author"] != DBNull.Value)
						{
							item.FK_Author = Convert.ToString(dr["FK_Author"]);
						}
						if (dr["FK_Category"] != null && dr["FK_Category"] != DBNull.Value)
						{
							item.FK_Category = Convert.ToString(dr["FK_Category"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["ShowPage"] != null && dr["ShowPage"] != DBNull.Value)
						{
							item.ShowPage = Convert.ToInt32(dr["ShowPage"]);
						}
						if (dr["StatusPage"] != null && dr["StatusPage"] != DBNull.Value)
						{
							item.StatusPage = Convert.ToInt32(dr["StatusPage"]);
						}
						if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
						{
							item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["CategoryName"] != null && dr["CategoryName"] != DBNull.Value)
						{
							item.CategoryName = Convert.ToString(dr["CategoryName"]);
						}
						if (dr["Path"] != null && dr["Path"] != DBNull.Value)
						{
							item.Path = Convert.ToString(dr["Path"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
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

		public view_WebNews GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_WebNews] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_WebNews>(ds);
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
