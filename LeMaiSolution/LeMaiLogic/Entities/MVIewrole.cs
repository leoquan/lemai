using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewrole:IVIewrole
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewrole(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_Role từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_Role]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_Role từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_Role] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_Role từ Database
		/// </summary>
		public List<view_Role> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_Role]");
				List<view_Role> items = new List<view_Role>();
				view_Role item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_Role();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["RoleName"] != null && dr["RoleName"] != DBNull.Value)
					{
						item.RoleName = Convert.ToString(dr["RoleName"]);
					}
					if (dr["AtCreatedDate"] != null && dr["AtCreatedDate"] != DBNull.Value)
					{
						item.AtCreatedDate = Convert.ToDateTime(dr["AtCreatedDate"]);
					}
					if (dr["AtCreatedBy"] != null && dr["AtCreatedBy"] != DBNull.Value)
					{
						item.AtCreatedBy = Convert.ToString(dr["AtCreatedBy"]);
					}
					if (dr["AtLastModifiedDate"] != null && dr["AtLastModifiedDate"] != DBNull.Value)
					{
						item.AtLastModifiedDate = Convert.ToDateTime(dr["AtLastModifiedDate"]);
					}
					if (dr["AtLastModifiedBy"] != null && dr["AtLastModifiedBy"] != DBNull.Value)
					{
						item.AtLastModifiedBy = Convert.ToString(dr["AtLastModifiedBy"]);
					}
					if (dr["AtRowStatus"] != null && dr["AtRowStatus"] != DBNull.Value)
					{
						item.AtRowStatus = Convert.ToInt32(dr["AtRowStatus"]);
					}
					if (dr["Prioty"] != null && dr["Prioty"] != DBNull.Value)
					{
						item.Prioty = Convert.ToInt32(dr["Prioty"]);
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
		/// Lấy danh sách view_Role từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_Role> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_Role] A "+ condition,  parameters);
				List<view_Role> items = new List<view_Role>();
				view_Role item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_Role();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["RoleName"] != null && dr["RoleName"] != DBNull.Value)
					{
						item.RoleName = Convert.ToString(dr["RoleName"]);
					}
					if (dr["AtCreatedDate"] != null && dr["AtCreatedDate"] != DBNull.Value)
					{
						item.AtCreatedDate = Convert.ToDateTime(dr["AtCreatedDate"]);
					}
					if (dr["AtCreatedBy"] != null && dr["AtCreatedBy"] != DBNull.Value)
					{
						item.AtCreatedBy = Convert.ToString(dr["AtCreatedBy"]);
					}
					if (dr["AtLastModifiedDate"] != null && dr["AtLastModifiedDate"] != DBNull.Value)
					{
						item.AtLastModifiedDate = Convert.ToDateTime(dr["AtLastModifiedDate"]);
					}
					if (dr["AtLastModifiedBy"] != null && dr["AtLastModifiedBy"] != DBNull.Value)
					{
						item.AtLastModifiedBy = Convert.ToString(dr["AtLastModifiedBy"]);
					}
					if (dr["AtRowStatus"] != null && dr["AtRowStatus"] != DBNull.Value)
					{
						item.AtRowStatus = Convert.ToInt32(dr["AtRowStatus"]);
					}
					if (dr["Prioty"] != null && dr["Prioty"] != DBNull.Value)
					{
						item.Prioty = Convert.ToInt32(dr["Prioty"]);
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

		public List<view_Role> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_Role] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_Role] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_Role>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_Role đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_Role GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_Role] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_Role item=new view_Role();
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
						if (dr["RoleName"] != null && dr["RoleName"] != DBNull.Value)
						{
							item.RoleName = Convert.ToString(dr["RoleName"]);
						}
						if (dr["AtCreatedDate"] != null && dr["AtCreatedDate"] != DBNull.Value)
						{
							item.AtCreatedDate = Convert.ToDateTime(dr["AtCreatedDate"]);
						}
						if (dr["AtCreatedBy"] != null && dr["AtCreatedBy"] != DBNull.Value)
						{
							item.AtCreatedBy = Convert.ToString(dr["AtCreatedBy"]);
						}
						if (dr["AtLastModifiedDate"] != null && dr["AtLastModifiedDate"] != DBNull.Value)
						{
							item.AtLastModifiedDate = Convert.ToDateTime(dr["AtLastModifiedDate"]);
						}
						if (dr["AtLastModifiedBy"] != null && dr["AtLastModifiedBy"] != DBNull.Value)
						{
							item.AtLastModifiedBy = Convert.ToString(dr["AtLastModifiedBy"]);
						}
						if (dr["AtRowStatus"] != null && dr["AtRowStatus"] != DBNull.Value)
						{
							item.AtRowStatus = Convert.ToInt32(dr["AtRowStatus"]);
						}
						if (dr["Prioty"] != null && dr["Prioty"] != DBNull.Value)
						{
							item.Prioty = Convert.ToInt32(dr["Prioty"]);
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

		public view_Role GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_Role] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_Role>(ds);
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
