using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpfeedetailspro:IVIewgexpfeedetailspro
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpfeedetailspro(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpFeeDetailsPro từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpFeeDetailsPro]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpFeeDetailsPro từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpFeeDetailsPro] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpFeeDetailsPro từ Database
		/// </summary>
		public List<view_GExpFeeDetailsPro> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpFeeDetailsPro]");
				List<view_GExpFeeDetailsPro> items = new List<view_GExpFeeDetailsPro>();
				view_GExpFeeDetailsPro item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpFeeDetailsPro();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_GExpFee"] != null && dr["FK_GExpFee"] != DBNull.Value)
					{
						item.FK_GExpFee = Convert.ToString(dr["FK_GExpFee"]);
					}
					if (dr["MinWeight"] != null && dr["MinWeight"] != DBNull.Value)
					{
						item.MinWeight = Convert.ToInt32(dr["MinWeight"]);
					}
					if (dr["MinFee"] != null && dr["MinFee"] != DBNull.Value)
					{
						item.MinFee = Convert.ToInt32(dr["MinFee"]);
					}
					if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
					{
						item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
					}
					if (dr["NextFee"] != null && dr["NextFee"] != DBNull.Value)
					{
						item.NextFee = Convert.ToInt32(dr["NextFee"]);
					}
					if (dr["ProvineId"] != null && dr["ProvineId"] != DBNull.Value)
					{
						item.ProvineId = Convert.ToInt32(dr["ProvineId"]);
					}
					if (dr["District"] != null && dr["District"] != DBNull.Value)
					{
						item.District = Convert.ToString(dr["District"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
					{
						item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
					}
					if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
					{
						item.FeeName = Convert.ToString(dr["FeeName"]);
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
		/// Lấy danh sách view_GExpFeeDetailsPro từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpFeeDetailsPro> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpFeeDetailsPro] A "+ condition,  parameters);
				List<view_GExpFeeDetailsPro> items = new List<view_GExpFeeDetailsPro>();
				view_GExpFeeDetailsPro item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpFeeDetailsPro();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_GExpFee"] != null && dr["FK_GExpFee"] != DBNull.Value)
					{
						item.FK_GExpFee = Convert.ToString(dr["FK_GExpFee"]);
					}
					if (dr["MinWeight"] != null && dr["MinWeight"] != DBNull.Value)
					{
						item.MinWeight = Convert.ToInt32(dr["MinWeight"]);
					}
					if (dr["MinFee"] != null && dr["MinFee"] != DBNull.Value)
					{
						item.MinFee = Convert.ToInt32(dr["MinFee"]);
					}
					if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
					{
						item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
					}
					if (dr["NextFee"] != null && dr["NextFee"] != DBNull.Value)
					{
						item.NextFee = Convert.ToInt32(dr["NextFee"]);
					}
					if (dr["ProvineId"] != null && dr["ProvineId"] != DBNull.Value)
					{
						item.ProvineId = Convert.ToInt32(dr["ProvineId"]);
					}
					if (dr["District"] != null && dr["District"] != DBNull.Value)
					{
						item.District = Convert.ToString(dr["District"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
					{
						item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
					}
					if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
					{
						item.FeeName = Convert.ToString(dr["FeeName"]);
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

		public List<view_GExpFeeDetailsPro> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpFeeDetailsPro] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpFeeDetailsPro] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpFeeDetailsPro>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpFeeDetailsPro đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpFeeDetailsPro GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpFeeDetailsPro] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpFeeDetailsPro item=new view_GExpFeeDetailsPro();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_GExpFee"] != null && dr["FK_GExpFee"] != DBNull.Value)
						{
							item.FK_GExpFee = Convert.ToString(dr["FK_GExpFee"]);
						}
						if (dr["MinWeight"] != null && dr["MinWeight"] != DBNull.Value)
						{
							item.MinWeight = Convert.ToInt32(dr["MinWeight"]);
						}
						if (dr["MinFee"] != null && dr["MinFee"] != DBNull.Value)
						{
							item.MinFee = Convert.ToInt32(dr["MinFee"]);
						}
						if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
						{
							item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
						}
						if (dr["NextFee"] != null && dr["NextFee"] != DBNull.Value)
						{
							item.NextFee = Convert.ToInt32(dr["NextFee"]);
						}
						if (dr["ProvineId"] != null && dr["ProvineId"] != DBNull.Value)
						{
							item.ProvineId = Convert.ToInt32(dr["ProvineId"]);
						}
						if (dr["District"] != null && dr["District"] != DBNull.Value)
						{
							item.District = Convert.ToString(dr["District"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
						{
							item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
						}
						if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
						{
							item.FeeName = Convert.ToString(dr["FeeName"]);
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

		public view_GExpFeeDetailsPro GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpFeeDetailsPro] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpFeeDetailsPro>(ds);
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
