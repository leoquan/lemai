using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewinvoiceprint:IVIewinvoiceprint
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewinvoiceprint(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_invoicePrint từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_invoicePrint]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_invoicePrint từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_invoicePrint] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_invoicePrint từ Database
		/// </summary>
		public List<view_invoicePrint> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_invoicePrint]");
				List<view_invoicePrint> items = new List<view_invoicePrint>();
				view_invoicePrint item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_invoicePrint();
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
					if (dr["InvoiceId"] != null && dr["InvoiceId"] != DBNull.Value)
					{
						item.InvoiceId = Convert.ToString(dr["InvoiceId"]);
					}
					if (dr["InvoiceNumber"] != null && dr["InvoiceNumber"] != DBNull.Value)
					{
						item.InvoiceNumber = Convert.ToString(dr["InvoiceNumber"]);
					}
					if (dr["InvoiceDate"] != null && dr["InvoiceDate"] != DBNull.Value)
					{
						item.InvoiceDate = Convert.ToDateTime(dr["InvoiceDate"]);
					}
					if (dr["TotalItem"] != null && dr["TotalItem"] != DBNull.Value)
					{
						item.TotalItem = Convert.ToInt32(dr["TotalItem"]);
					}
					if (dr["ExtraPrice"] != null && dr["ExtraPrice"] != DBNull.Value)
					{
						item.ExtraPrice = Convert.ToInt32(dr["ExtraPrice"]);
					}
					if (dr["ServicePrice"] != null && dr["ServicePrice"] != DBNull.Value)
					{
						item.ServicePrice = Convert.ToInt32(dr["ServicePrice"]);
					}
					if (dr["InvoiceTotal"] != null && dr["InvoiceTotal"] != DBNull.Value)
					{
						item.InvoiceTotal = Convert.ToInt32(dr["InvoiceTotal"]);
					}
					if (dr["VoucherPrice"] != null && dr["VoucherPrice"] != DBNull.Value)
					{
						item.VoucherPrice = Convert.ToInt32(dr["VoucherPrice"]);
					}
					if (dr["PCode"] != null && dr["PCode"] != DBNull.Value)
					{
						item.PCode = Convert.ToString(dr["PCode"]);
					}
					if (dr["PName"] != null && dr["PName"] != DBNull.Value)
					{
						item.PName = Convert.ToString(dr["PName"]);
					}
					if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
					{
						item.UnitName = Convert.ToString(dr["UnitName"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["TaxCode"] != null && dr["TaxCode"] != DBNull.Value)
					{
						item.TaxCode = Convert.ToString(dr["TaxCode"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["CusName"] != null && dr["CusName"] != DBNull.Value)
					{
						item.CusName = Convert.ToString(dr["CusName"]);
					}
					if (dr["CusCode"] != null && dr["CusCode"] != DBNull.Value)
					{
						item.CusCode = Convert.ToString(dr["CusCode"]);
					}
					if (dr["CusAddress"] != null && dr["CusAddress"] != DBNull.Value)
					{
						item.CusAddress = Convert.ToString(dr["CusAddress"]);
					}
					if (dr["CusPhone"] != null && dr["CusPhone"] != DBNull.Value)
					{
						item.CusPhone = Convert.ToString(dr["CusPhone"]);
					}
					if (dr["CusEmail"] != null && dr["CusEmail"] != DBNull.Value)
					{
						item.CusEmail = Convert.ToString(dr["CusEmail"]);
					}
					if (dr["Balance"] != null && dr["Balance"] != DBNull.Value)
					{
						item.Balance = Convert.ToInt32(dr["Balance"]);
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
		/// Lấy danh sách view_invoicePrint từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_invoicePrint> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_invoicePrint] A "+ condition,  parameters);
				List<view_invoicePrint> items = new List<view_invoicePrint>();
				view_invoicePrint item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_invoicePrint();
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
					if (dr["InvoiceId"] != null && dr["InvoiceId"] != DBNull.Value)
					{
						item.InvoiceId = Convert.ToString(dr["InvoiceId"]);
					}
					if (dr["InvoiceNumber"] != null && dr["InvoiceNumber"] != DBNull.Value)
					{
						item.InvoiceNumber = Convert.ToString(dr["InvoiceNumber"]);
					}
					if (dr["InvoiceDate"] != null && dr["InvoiceDate"] != DBNull.Value)
					{
						item.InvoiceDate = Convert.ToDateTime(dr["InvoiceDate"]);
					}
					if (dr["TotalItem"] != null && dr["TotalItem"] != DBNull.Value)
					{
						item.TotalItem = Convert.ToInt32(dr["TotalItem"]);
					}
					if (dr["ExtraPrice"] != null && dr["ExtraPrice"] != DBNull.Value)
					{
						item.ExtraPrice = Convert.ToInt32(dr["ExtraPrice"]);
					}
					if (dr["ServicePrice"] != null && dr["ServicePrice"] != DBNull.Value)
					{
						item.ServicePrice = Convert.ToInt32(dr["ServicePrice"]);
					}
					if (dr["InvoiceTotal"] != null && dr["InvoiceTotal"] != DBNull.Value)
					{
						item.InvoiceTotal = Convert.ToInt32(dr["InvoiceTotal"]);
					}
					if (dr["VoucherPrice"] != null && dr["VoucherPrice"] != DBNull.Value)
					{
						item.VoucherPrice = Convert.ToInt32(dr["VoucherPrice"]);
					}
					if (dr["PCode"] != null && dr["PCode"] != DBNull.Value)
					{
						item.PCode = Convert.ToString(dr["PCode"]);
					}
					if (dr["PName"] != null && dr["PName"] != DBNull.Value)
					{
						item.PName = Convert.ToString(dr["PName"]);
					}
					if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
					{
						item.UnitName = Convert.ToString(dr["UnitName"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["TaxCode"] != null && dr["TaxCode"] != DBNull.Value)
					{
						item.TaxCode = Convert.ToString(dr["TaxCode"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["CusName"] != null && dr["CusName"] != DBNull.Value)
					{
						item.CusName = Convert.ToString(dr["CusName"]);
					}
					if (dr["CusCode"] != null && dr["CusCode"] != DBNull.Value)
					{
						item.CusCode = Convert.ToString(dr["CusCode"]);
					}
					if (dr["CusAddress"] != null && dr["CusAddress"] != DBNull.Value)
					{
						item.CusAddress = Convert.ToString(dr["CusAddress"]);
					}
					if (dr["CusPhone"] != null && dr["CusPhone"] != DBNull.Value)
					{
						item.CusPhone = Convert.ToString(dr["CusPhone"]);
					}
					if (dr["CusEmail"] != null && dr["CusEmail"] != DBNull.Value)
					{
						item.CusEmail = Convert.ToString(dr["CusEmail"]);
					}
					if (dr["Balance"] != null && dr["Balance"] != DBNull.Value)
					{
						item.Balance = Convert.ToInt32(dr["Balance"]);
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

		public List<view_invoicePrint> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_invoicePrint] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_invoicePrint] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_invoicePrint>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_invoicePrint đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_invoicePrint GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_invoicePrint] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_invoicePrint item=new view_invoicePrint();
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
						if (dr["InvoiceId"] != null && dr["InvoiceId"] != DBNull.Value)
						{
							item.InvoiceId = Convert.ToString(dr["InvoiceId"]);
						}
						if (dr["InvoiceNumber"] != null && dr["InvoiceNumber"] != DBNull.Value)
						{
							item.InvoiceNumber = Convert.ToString(dr["InvoiceNumber"]);
						}
						if (dr["InvoiceDate"] != null && dr["InvoiceDate"] != DBNull.Value)
						{
							item.InvoiceDate = Convert.ToDateTime(dr["InvoiceDate"]);
						}
						if (dr["TotalItem"] != null && dr["TotalItem"] != DBNull.Value)
						{
							item.TotalItem = Convert.ToInt32(dr["TotalItem"]);
						}
						if (dr["ExtraPrice"] != null && dr["ExtraPrice"] != DBNull.Value)
						{
							item.ExtraPrice = Convert.ToInt32(dr["ExtraPrice"]);
						}
						if (dr["ServicePrice"] != null && dr["ServicePrice"] != DBNull.Value)
						{
							item.ServicePrice = Convert.ToInt32(dr["ServicePrice"]);
						}
						if (dr["InvoiceTotal"] != null && dr["InvoiceTotal"] != DBNull.Value)
						{
							item.InvoiceTotal = Convert.ToInt32(dr["InvoiceTotal"]);
						}
						if (dr["VoucherPrice"] != null && dr["VoucherPrice"] != DBNull.Value)
						{
							item.VoucherPrice = Convert.ToInt32(dr["VoucherPrice"]);
						}
						if (dr["PCode"] != null && dr["PCode"] != DBNull.Value)
						{
							item.PCode = Convert.ToString(dr["PCode"]);
						}
						if (dr["PName"] != null && dr["PName"] != DBNull.Value)
						{
							item.PName = Convert.ToString(dr["PName"]);
						}
						if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
						{
							item.UnitName = Convert.ToString(dr["UnitName"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
						{
							item.BranchName = Convert.ToString(dr["BranchName"]);
						}
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["TaxCode"] != null && dr["TaxCode"] != DBNull.Value)
						{
							item.TaxCode = Convert.ToString(dr["TaxCode"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["CusName"] != null && dr["CusName"] != DBNull.Value)
						{
							item.CusName = Convert.ToString(dr["CusName"]);
						}
						if (dr["CusCode"] != null && dr["CusCode"] != DBNull.Value)
						{
							item.CusCode = Convert.ToString(dr["CusCode"]);
						}
						if (dr["CusAddress"] != null && dr["CusAddress"] != DBNull.Value)
						{
							item.CusAddress = Convert.ToString(dr["CusAddress"]);
						}
						if (dr["CusPhone"] != null && dr["CusPhone"] != DBNull.Value)
						{
							item.CusPhone = Convert.ToString(dr["CusPhone"]);
						}
						if (dr["CusEmail"] != null && dr["CusEmail"] != DBNull.Value)
						{
							item.CusEmail = Convert.ToString(dr["CusEmail"]);
						}
						if (dr["Balance"] != null && dr["Balance"] != DBNull.Value)
						{
							item.Balance = Convert.ToInt32(dr["Balance"]);
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

		public view_invoicePrint GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_invoicePrint] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_invoicePrint>(ds);
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
