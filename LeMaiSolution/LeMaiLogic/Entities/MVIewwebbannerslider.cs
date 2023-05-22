using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewwebbannerslider:IVIewwebbannerslider
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewwebbannerslider(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_WebBannerSlider từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_WebBannerSlider]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_WebBannerSlider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_WebBannerSlider] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_WebBannerSlider từ Database
		/// </summary>
		public List<view_WebBannerSlider> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_WebBannerSlider]");
				List<view_WebBannerSlider> items = new List<view_WebBannerSlider>();
				view_WebBannerSlider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_WebBannerSlider();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BannerName"] != null && dr["BannerName"] != DBNull.Value)
					{
						item.BannerName = Convert.ToString(dr["BannerName"]);
					}
					if (dr["BannerTitle"] != null && dr["BannerTitle"] != DBNull.Value)
					{
						item.BannerTitle = Convert.ToString(dr["BannerTitle"]);
					}
					if (dr["BannerDescription"] != null && dr["BannerDescription"] != DBNull.Value)
					{
						item.BannerDescription = Convert.ToString(dr["BannerDescription"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["LinkDetail"] != null && dr["LinkDetail"] != DBNull.Value)
					{
						item.LinkDetail = Convert.ToString(dr["LinkDetail"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
					}
					if (dr["PostValidDate"] != null && dr["PostValidDate"] != DBNull.Value)
					{
						item.PostValidDate = Convert.ToDateTime(dr["PostValidDate"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["typeDisplay"] != null && dr["typeDisplay"] != DBNull.Value)
					{
						item.typeDisplay = Convert.ToInt32(dr["typeDisplay"]);
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
		/// Lấy danh sách view_WebBannerSlider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_WebBannerSlider> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_WebBannerSlider] A "+ condition,  parameters);
				List<view_WebBannerSlider> items = new List<view_WebBannerSlider>();
				view_WebBannerSlider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_WebBannerSlider();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BannerName"] != null && dr["BannerName"] != DBNull.Value)
					{
						item.BannerName = Convert.ToString(dr["BannerName"]);
					}
					if (dr["BannerTitle"] != null && dr["BannerTitle"] != DBNull.Value)
					{
						item.BannerTitle = Convert.ToString(dr["BannerTitle"]);
					}
					if (dr["BannerDescription"] != null && dr["BannerDescription"] != DBNull.Value)
					{
						item.BannerDescription = Convert.ToString(dr["BannerDescription"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["LinkDetail"] != null && dr["LinkDetail"] != DBNull.Value)
					{
						item.LinkDetail = Convert.ToString(dr["LinkDetail"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
					}
					if (dr["PostValidDate"] != null && dr["PostValidDate"] != DBNull.Value)
					{
						item.PostValidDate = Convert.ToDateTime(dr["PostValidDate"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["typeDisplay"] != null && dr["typeDisplay"] != DBNull.Value)
					{
						item.typeDisplay = Convert.ToInt32(dr["typeDisplay"]);
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

		public List<view_WebBannerSlider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_WebBannerSlider] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_WebBannerSlider] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_WebBannerSlider>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_WebBannerSlider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_WebBannerSlider GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_WebBannerSlider] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_WebBannerSlider item=new view_WebBannerSlider();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BannerName"] != null && dr["BannerName"] != DBNull.Value)
						{
							item.BannerName = Convert.ToString(dr["BannerName"]);
						}
						if (dr["BannerTitle"] != null && dr["BannerTitle"] != DBNull.Value)
						{
							item.BannerTitle = Convert.ToString(dr["BannerTitle"]);
						}
						if (dr["BannerDescription"] != null && dr["BannerDescription"] != DBNull.Value)
						{
							item.BannerDescription = Convert.ToString(dr["BannerDescription"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["LinkDetail"] != null && dr["LinkDetail"] != DBNull.Value)
						{
							item.LinkDetail = Convert.ToString(dr["LinkDetail"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
						{
							item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
						}
						if (dr["PostValidDate"] != null && dr["PostValidDate"] != DBNull.Value)
						{
							item.PostValidDate = Convert.ToDateTime(dr["PostValidDate"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToInt32(dr["Type"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["typeDisplay"] != null && dr["typeDisplay"] != DBNull.Value)
						{
							item.typeDisplay = Convert.ToInt32(dr["typeDisplay"]);
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

		public view_WebBannerSlider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_WebBannerSlider] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_WebBannerSlider>(ds);
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
