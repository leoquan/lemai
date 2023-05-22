using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpproviceproblem:IVIewexpproviceproblem
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpproviceproblem(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpProviceProblem từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpProviceProblem]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpProviceProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpProviceProblem] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpProviceProblem từ Database
		/// </summary>
		public List<view_ExpProviceProblem> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpProviceProblem]");
				List<view_ExpProviceProblem> items = new List<view_ExpProviceProblem>();
				view_ExpProviceProblem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpProviceProblem();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
					{
						item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
					}
					if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
					{
						item.KeyWord = Convert.ToString(dr["KeyWord"]);
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
		/// Lấy danh sách view_ExpProviceProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpProviceProblem> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpProviceProblem] A "+ condition,  parameters);
				List<view_ExpProviceProblem> items = new List<view_ExpProviceProblem>();
				view_ExpProviceProblem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpProviceProblem();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
					{
						item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
					}
					if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
					{
						item.KeyWord = Convert.ToString(dr["KeyWord"]);
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

		public List<view_ExpProviceProblem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpProviceProblem] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpProviceProblem] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpProviceProblem>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpProviceProblem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpProviceProblem GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpProviceProblem] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpProviceProblem item=new view_ExpProviceProblem();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
						{
							item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
						}
						if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
						{
							item.KeyWord = Convert.ToString(dr["KeyWord"]);
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

		public view_ExpProviceProblem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpProviceProblem] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpProviceProblem>(ds);
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
