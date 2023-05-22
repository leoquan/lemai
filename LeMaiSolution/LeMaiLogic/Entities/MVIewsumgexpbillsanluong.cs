using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewsumgexpbillsanluong:IVIewsumgexpbillsanluong
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewsumgexpbillsanluong(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_SumGExpBillSanLuong từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SumGExpBillSanLuong]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_SumGExpBillSanLuong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SumGExpBillSanLuong] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_SumGExpBillSanLuong từ Database
		/// </summary>
		public List<view_SumGExpBillSanLuong> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SumGExpBillSanLuong]");
				List<view_SumGExpBillSanLuong> items = new List<view_SumGExpBillSanLuong>();
				view_SumGExpBillSanLuong item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SumGExpBillSanLuong();
					if (dr["DATE_TT"] != null && dr["DATE_TT"] != DBNull.Value)
					{
						item.DATE_TT = Convert.ToDateTime(dr["DATE_TT"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["COUNT_TT"] != null && dr["COUNT_TT"] != DBNull.Value)
					{
						item.COUNT_TT = Convert.ToInt32(dr["COUNT_TT"]);
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
		/// Lấy danh sách view_SumGExpBillSanLuong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_SumGExpBillSanLuong> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SumGExpBillSanLuong] A "+ condition,  parameters);
				List<view_SumGExpBillSanLuong> items = new List<view_SumGExpBillSanLuong>();
				view_SumGExpBillSanLuong item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SumGExpBillSanLuong();
					if (dr["DATE_TT"] != null && dr["DATE_TT"] != DBNull.Value)
					{
						item.DATE_TT = Convert.ToDateTime(dr["DATE_TT"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["COUNT_TT"] != null && dr["COUNT_TT"] != DBNull.Value)
					{
						item.COUNT_TT = Convert.ToInt32(dr["COUNT_TT"]);
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

		public List<view_SumGExpBillSanLuong> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SumGExpBillSanLuong] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_SumGExpBillSanLuong] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_SumGExpBillSanLuong>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_SumGExpBillSanLuong đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_SumGExpBillSanLuong GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SumGExpBillSanLuong] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_SumGExpBillSanLuong item=new view_SumGExpBillSanLuong();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["DATE_TT"] != null && dr["DATE_TT"] != DBNull.Value)
						{
							item.DATE_TT = Convert.ToDateTime(dr["DATE_TT"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["COUNT_TT"] != null && dr["COUNT_TT"] != DBNull.Value)
						{
							item.COUNT_TT = Convert.ToInt32(dr["COUNT_TT"]);
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

		public view_SumGExpBillSanLuong GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SumGExpBillSanLuong] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_SumGExpBillSanLuong>(ds);
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
