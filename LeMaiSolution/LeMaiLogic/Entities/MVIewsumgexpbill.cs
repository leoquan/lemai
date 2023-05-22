using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewsumgexpbill:IVIewsumgexpbill
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewsumgexpbill(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_SumGExpBill từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SumGExpBill]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_SumGExpBill từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SumGExpBill] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_SumGExpBill từ Database
		/// </summary>
		public List<view_SumGExpBill> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SumGExpBill]");
				List<view_SumGExpBill> items = new List<view_SumGExpBill>();
				view_SumGExpBill item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SumGExpBill();
					if (dr["SODON"] != null && dr["SODON"] != DBNull.Value)
					{
						item.SODON = Convert.ToInt32(dr["SODON"]);
					}
					if (dr["COD_DATT"] != null && dr["COD_DATT"] != DBNull.Value)
					{
						item.COD_DATT = Convert.ToDecimal(dr["COD_DATT"]);
					}
					if (dr["COD_CHUATT"] != null && dr["COD_CHUATT"] != DBNull.Value)
					{
						item.COD_CHUATT = Convert.ToDecimal(dr["COD_CHUATT"]);
					}
					if (dr["TONGTIEN"] != null && dr["TONGTIEN"] != DBNull.Value)
					{
						item.TONGTIEN = Convert.ToDecimal(dr["TONGTIEN"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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
		/// Lấy danh sách view_SumGExpBill từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_SumGExpBill> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SumGExpBill] A "+ condition,  parameters);
				List<view_SumGExpBill> items = new List<view_SumGExpBill>();
				view_SumGExpBill item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SumGExpBill();
					if (dr["SODON"] != null && dr["SODON"] != DBNull.Value)
					{
						item.SODON = Convert.ToInt32(dr["SODON"]);
					}
					if (dr["COD_DATT"] != null && dr["COD_DATT"] != DBNull.Value)
					{
						item.COD_DATT = Convert.ToDecimal(dr["COD_DATT"]);
					}
					if (dr["COD_CHUATT"] != null && dr["COD_CHUATT"] != DBNull.Value)
					{
						item.COD_CHUATT = Convert.ToDecimal(dr["COD_CHUATT"]);
					}
					if (dr["TONGTIEN"] != null && dr["TONGTIEN"] != DBNull.Value)
					{
						item.TONGTIEN = Convert.ToDecimal(dr["TONGTIEN"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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

		public List<view_SumGExpBill> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SumGExpBill] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_SumGExpBill] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_SumGExpBill>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_SumGExpBill đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_SumGExpBill GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SumGExpBill] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_SumGExpBill item=new view_SumGExpBill();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["SODON"] != null && dr["SODON"] != DBNull.Value)
						{
							item.SODON = Convert.ToInt32(dr["SODON"]);
						}
						if (dr["COD_DATT"] != null && dr["COD_DATT"] != DBNull.Value)
						{
							item.COD_DATT = Convert.ToDecimal(dr["COD_DATT"]);
						}
						if (dr["COD_CHUATT"] != null && dr["COD_CHUATT"] != DBNull.Value)
						{
							item.COD_CHUATT = Convert.ToDecimal(dr["COD_CHUATT"]);
						}
						if (dr["TONGTIEN"] != null && dr["TONGTIEN"] != DBNull.Value)
						{
							item.TONGTIEN = Convert.ToDecimal(dr["TONGTIEN"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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

		public view_SumGExpBill GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SumGExpBill] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_SumGExpBill>(ds);
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
