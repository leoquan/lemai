using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpdvhcxa:IVIewexpdvhcxa
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpdvhcxa(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpDVHC_XA từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpDVHC_XA]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpDVHC_XA từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpDVHC_XA] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpDVHC_XA từ Database
		/// </summary>
		public List<view_ExpDVHC_XA> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpDVHC_XA]");
				List<view_ExpDVHC_XA> items = new List<view_ExpDVHC_XA>();
				view_ExpDVHC_XA item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpDVHC_XA();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
					{
						item.Ten = Convert.ToString(dr["Ten"]);
					}
					if (dr["Cap"] != null && dr["Cap"] != DBNull.Value)
					{
						item.Cap = Convert.ToString(dr["Cap"]);
					}
					if (dr["CapTren"] != null && dr["CapTren"] != DBNull.Value)
					{
						item.CapTren = Convert.ToString(dr["CapTren"]);
					}
					if (dr["InternalPost"] != null && dr["InternalPost"] != DBNull.Value)
					{
						item.InternalPost = Convert.ToBoolean(dr["InternalPost"]);
					}
					if (dr["TenHuyen"] != null && dr["TenHuyen"] != DBNull.Value)
					{
						item.TenHuyen = Convert.ToString(dr["TenHuyen"]);
					}
					if (dr["TenTinh"] != null && dr["TenTinh"] != DBNull.Value)
					{
						item.TenTinh = Convert.ToString(dr["TenTinh"]);
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
		/// Lấy danh sách view_ExpDVHC_XA từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpDVHC_XA> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpDVHC_XA] A "+ condition,  parameters);
				List<view_ExpDVHC_XA> items = new List<view_ExpDVHC_XA>();
				view_ExpDVHC_XA item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpDVHC_XA();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
					{
						item.Ten = Convert.ToString(dr["Ten"]);
					}
					if (dr["Cap"] != null && dr["Cap"] != DBNull.Value)
					{
						item.Cap = Convert.ToString(dr["Cap"]);
					}
					if (dr["CapTren"] != null && dr["CapTren"] != DBNull.Value)
					{
						item.CapTren = Convert.ToString(dr["CapTren"]);
					}
					if (dr["InternalPost"] != null && dr["InternalPost"] != DBNull.Value)
					{
						item.InternalPost = Convert.ToBoolean(dr["InternalPost"]);
					}
					if (dr["TenHuyen"] != null && dr["TenHuyen"] != DBNull.Value)
					{
						item.TenHuyen = Convert.ToString(dr["TenHuyen"]);
					}
					if (dr["TenTinh"] != null && dr["TenTinh"] != DBNull.Value)
					{
						item.TenTinh = Convert.ToString(dr["TenTinh"]);
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

		public List<view_ExpDVHC_XA> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpDVHC_XA] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpDVHC_XA] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpDVHC_XA>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpDVHC_XA đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpDVHC_XA GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpDVHC_XA] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpDVHC_XA item=new view_ExpDVHC_XA();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
						{
							item.Ten = Convert.ToString(dr["Ten"]);
						}
						if (dr["Cap"] != null && dr["Cap"] != DBNull.Value)
						{
							item.Cap = Convert.ToString(dr["Cap"]);
						}
						if (dr["CapTren"] != null && dr["CapTren"] != DBNull.Value)
						{
							item.CapTren = Convert.ToString(dr["CapTren"]);
						}
						if (dr["InternalPost"] != null && dr["InternalPost"] != DBNull.Value)
						{
							item.InternalPost = Convert.ToBoolean(dr["InternalPost"]);
						}
						if (dr["TenHuyen"] != null && dr["TenHuyen"] != DBNull.Value)
						{
							item.TenHuyen = Convert.ToString(dr["TenHuyen"]);
						}
						if (dr["TenTinh"] != null && dr["TenTinh"] != DBNull.Value)
						{
							item.TenTinh = Convert.ToString(dr["TenTinh"]);
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

		public view_ExpDVHC_XA GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpDVHC_XA] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpDVHC_XA>(ds);
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
