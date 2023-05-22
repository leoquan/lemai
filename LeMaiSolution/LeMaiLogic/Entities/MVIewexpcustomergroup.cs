using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpcustomergroup:IVIewexpcustomergroup
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpcustomergroup(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpCustomerGroup từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpCustomerGroup]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpCustomerGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpCustomerGroup] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpCustomerGroup từ Database
		/// </summary>
		public List<view_ExpCustomerGroup> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpCustomerGroup]");
				List<view_ExpCustomerGroup> items = new List<view_ExpCustomerGroup>();
				view_ExpCustomerGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpCustomerGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenNhom"] != null && dr["TenNhom"] != DBNull.Value)
					{
						item.TenNhom = Convert.ToString(dr["TenNhom"]);
					}
					if (dr["MacDinh"] != null && dr["MacDinh"] != DBNull.Value)
					{
						item.MacDinh = Convert.ToBoolean(dr["MacDinh"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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
		/// Lấy danh sách view_ExpCustomerGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpCustomerGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpCustomerGroup] A "+ condition,  parameters);
				List<view_ExpCustomerGroup> items = new List<view_ExpCustomerGroup>();
				view_ExpCustomerGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpCustomerGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenNhom"] != null && dr["TenNhom"] != DBNull.Value)
					{
						item.TenNhom = Convert.ToString(dr["TenNhom"]);
					}
					if (dr["MacDinh"] != null && dr["MacDinh"] != DBNull.Value)
					{
						item.MacDinh = Convert.ToBoolean(dr["MacDinh"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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

		public List<view_ExpCustomerGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpCustomerGroup] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpCustomerGroup] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpCustomerGroup>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpCustomerGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpCustomerGroup GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpCustomerGroup] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpCustomerGroup item=new view_ExpCustomerGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["TenNhom"] != null && dr["TenNhom"] != DBNull.Value)
						{
							item.TenNhom = Convert.ToString(dr["TenNhom"]);
						}
						if (dr["MacDinh"] != null && dr["MacDinh"] != DBNull.Value)
						{
							item.MacDinh = Convert.ToBoolean(dr["MacDinh"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
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

		public view_ExpCustomerGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpCustomerGroup] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpCustomerGroup>(ds);
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
