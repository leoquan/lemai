using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewinvoicelist:IVIewinvoicelist
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewinvoicelist(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_InvoiceList từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_InvoiceList]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_InvoiceList từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_InvoiceList] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_InvoiceList từ Database
		/// </summary>
		public List<view_InvoiceList> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_InvoiceList]");
				List<view_InvoiceList> items = new List<view_InvoiceList>();
				view_InvoiceList item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_InvoiceList();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["FK_Invoice"] != null && dr["FK_Invoice"] != DBNull.Value)
					{
						item.FK_Invoice = Convert.ToString(dr["FK_Invoice"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToInt32(dr["Quantity"]);
					}
					if (dr["Price"] != null && dr["Price"] != DBNull.Value)
					{
						item.Price = Convert.ToInt32(dr["Price"]);
					}
					if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
					{
						item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
					}
					if (dr["ServiceName"] != null && dr["ServiceName"] != DBNull.Value)
					{
						item.ServiceName = Convert.ToString(dr["ServiceName"]);
					}
					if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
					{
						item.UnitName = Convert.ToString(dr["UnitName"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy danh sách view_InvoiceList từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_InvoiceList> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_InvoiceList] A "+ condition,  parameters);
				List<view_InvoiceList> items = new List<view_InvoiceList>();
				view_InvoiceList item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_InvoiceList();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["FK_Invoice"] != null && dr["FK_Invoice"] != DBNull.Value)
					{
						item.FK_Invoice = Convert.ToString(dr["FK_Invoice"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToInt32(dr["Quantity"]);
					}
					if (dr["Price"] != null && dr["Price"] != DBNull.Value)
					{
						item.Price = Convert.ToInt32(dr["Price"]);
					}
					if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
					{
						item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
					}
					if (dr["ServiceName"] != null && dr["ServiceName"] != DBNull.Value)
					{
						item.ServiceName = Convert.ToString(dr["ServiceName"]);
					}
					if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
					{
						item.UnitName = Convert.ToString(dr["UnitName"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public List<view_InvoiceList> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_InvoiceList] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_InvoiceList] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_InvoiceList>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_InvoiceList đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_InvoiceList GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_InvoiceList] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_InvoiceList item=new view_InvoiceList();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["FK_Invoice"] != null && dr["FK_Invoice"] != DBNull.Value)
						{
							item.FK_Invoice = Convert.ToString(dr["FK_Invoice"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
						{
							item.Quantity = Convert.ToInt32(dr["Quantity"]);
						}
						if (dr["Price"] != null && dr["Price"] != DBNull.Value)
						{
							item.Price = Convert.ToInt32(dr["Price"]);
						}
						if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
						{
							item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
						}
						if (dr["ServiceName"] != null && dr["ServiceName"] != DBNull.Value)
						{
							item.ServiceName = Convert.ToString(dr["ServiceName"]);
						}
						if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
						{
							item.UnitName = Convert.ToString(dr["UnitName"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public view_InvoiceList GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_InvoiceList] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_InvoiceList>(ds);
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
