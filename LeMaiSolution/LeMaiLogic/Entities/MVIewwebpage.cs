using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewwebpage:IVIewwebpage
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewwebpage(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_WebPage từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_WebPage]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_WebPage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_WebPage] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_WebPage từ Database
		/// </summary>
		public List<view_WebPage> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_WebPage]");
				List<view_WebPage> items = new List<view_WebPage>();
				view_WebPage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_WebPage();
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
					if (dr["FK_ParrentPage"] != null && dr["FK_ParrentPage"] != DBNull.Value)
					{
						item.FK_ParrentPage = Convert.ToString(dr["FK_ParrentPage"]);
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
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["pTitle"] != null && dr["pTitle"] != DBNull.Value)
					{
						item.pTitle = Convert.ToString(dr["pTitle"]);
					}
					if (dr["pTag"] != null && dr["pTag"] != DBNull.Value)
					{
						item.pTag = Convert.ToString(dr["pTag"]);
					}
					if (dr["pShortDescription"] != null && dr["pShortDescription"] != DBNull.Value)
					{
						item.pShortDescription = Convert.ToString(dr["pShortDescription"]);
					}
					if (dr["pStaticLink"] != null && dr["pStaticLink"] != DBNull.Value)
					{
						item.pStaticLink = Convert.ToString(dr["pStaticLink"]);
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
		/// Lấy danh sách view_WebPage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_WebPage> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_WebPage] A "+ condition,  parameters);
				List<view_WebPage> items = new List<view_WebPage>();
				view_WebPage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_WebPage();
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
					if (dr["FK_ParrentPage"] != null && dr["FK_ParrentPage"] != DBNull.Value)
					{
						item.FK_ParrentPage = Convert.ToString(dr["FK_ParrentPage"]);
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
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["pTitle"] != null && dr["pTitle"] != DBNull.Value)
					{
						item.pTitle = Convert.ToString(dr["pTitle"]);
					}
					if (dr["pTag"] != null && dr["pTag"] != DBNull.Value)
					{
						item.pTag = Convert.ToString(dr["pTag"]);
					}
					if (dr["pShortDescription"] != null && dr["pShortDescription"] != DBNull.Value)
					{
						item.pShortDescription = Convert.ToString(dr["pShortDescription"]);
					}
					if (dr["pStaticLink"] != null && dr["pStaticLink"] != DBNull.Value)
					{
						item.pStaticLink = Convert.ToString(dr["pStaticLink"]);
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

		public List<view_WebPage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_WebPage] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_WebPage] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_WebPage>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_WebPage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_WebPage GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_WebPage] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_WebPage item=new view_WebPage();
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
						if (dr["FK_ParrentPage"] != null && dr["FK_ParrentPage"] != DBNull.Value)
						{
							item.FK_ParrentPage = Convert.ToString(dr["FK_ParrentPage"]);
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
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["pTitle"] != null && dr["pTitle"] != DBNull.Value)
						{
							item.pTitle = Convert.ToString(dr["pTitle"]);
						}
						if (dr["pTag"] != null && dr["pTag"] != DBNull.Value)
						{
							item.pTag = Convert.ToString(dr["pTag"]);
						}
						if (dr["pShortDescription"] != null && dr["pShortDescription"] != DBNull.Value)
						{
							item.pShortDescription = Convert.ToString(dr["pShortDescription"]);
						}
						if (dr["pStaticLink"] != null && dr["pStaticLink"] != DBNull.Value)
						{
							item.pStaticLink = Convert.ToString(dr["pStaticLink"]);
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

		public view_WebPage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_WebPage] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_WebPage>(ds);
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
