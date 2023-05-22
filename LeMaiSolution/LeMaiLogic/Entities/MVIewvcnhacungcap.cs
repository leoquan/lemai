using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewvcnhacungcap:IVIewvcnhacungcap
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewvcnhacungcap(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_VCNhaCungCap từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCNhaCungCap]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_VCNhaCungCap từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCNhaCungCap] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_VCNhaCungCap từ Database
		/// </summary>
		public List<view_VCNhaCungCap> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCNhaCungCap]");
				List<view_VCNhaCungCap> items = new List<view_VCNhaCungCap>();
				view_VCNhaCungCap item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VCNhaCungCap();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaNCC"] != null && dr["MaNCC"] != DBNull.Value)
					{
						item.MaNCC = Convert.ToString(dr["MaNCC"]);
					}
					if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
					{
						item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
					}
					if (dr["TenNhaCungCapKD"] != null && dr["TenNhaCungCapKD"] != DBNull.Value)
					{
						item.TenNhaCungCapKD = Convert.ToString(dr["TenNhaCungCapKD"]);
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
		/// Lấy danh sách view_VCNhaCungCap từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_VCNhaCungCap> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VCNhaCungCap] A "+ condition,  parameters);
				List<view_VCNhaCungCap> items = new List<view_VCNhaCungCap>();
				view_VCNhaCungCap item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VCNhaCungCap();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaNCC"] != null && dr["MaNCC"] != DBNull.Value)
					{
						item.MaNCC = Convert.ToString(dr["MaNCC"]);
					}
					if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
					{
						item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
					}
					if (dr["TenNhaCungCapKD"] != null && dr["TenNhaCungCapKD"] != DBNull.Value)
					{
						item.TenNhaCungCapKD = Convert.ToString(dr["TenNhaCungCapKD"]);
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

		public List<view_VCNhaCungCap> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VCNhaCungCap] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_VCNhaCungCap] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_VCNhaCungCap>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_VCNhaCungCap đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_VCNhaCungCap GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VCNhaCungCap] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_VCNhaCungCap item=new view_VCNhaCungCap();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaNCC"] != null && dr["MaNCC"] != DBNull.Value)
						{
							item.MaNCC = Convert.ToString(dr["MaNCC"]);
						}
						if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
						{
							item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
						}
						if (dr["TenNhaCungCapKD"] != null && dr["TenNhaCungCapKD"] != DBNull.Value)
						{
							item.TenNhaCungCapKD = Convert.ToString(dr["TenNhaCungCapKD"]);
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

		public view_VCNhaCungCap GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VCNhaCungCap] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_VCNhaCungCap>(ds);
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
