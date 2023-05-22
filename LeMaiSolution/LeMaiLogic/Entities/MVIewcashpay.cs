using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewcashpay:IVIewcashpay
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewcashpay(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_CashPay từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_CashPay]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_CashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_CashPay] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_CashPay từ Database
		/// </summary>
		public List<view_CashPay> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_CashPay]");
				List<view_CashPay> items = new List<view_CashPay>();
				view_CashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_CashPay();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["IsWithDraw"] != null && dr["IsWithDraw"] != DBNull.Value)
					{
						item.IsWithDraw = Convert.ToBoolean(dr["IsWithDraw"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["AcctionDate"] != null && dr["AcctionDate"] != DBNull.Value)
					{
						item.AcctionDate = Convert.ToDateTime(dr["AcctionDate"]);
					}
					if (dr["FK_Cashier"] != null && dr["FK_Cashier"] != DBNull.Value)
					{
						item.FK_Cashier = Convert.ToString(dr["FK_Cashier"]);
					}
					if (dr["BillNumber"] != null && dr["BillNumber"] != DBNull.Value)
					{
						item.BillNumber = Convert.ToString(dr["BillNumber"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["MoneyType"] != null && dr["MoneyType"] != DBNull.Value)
					{
						item.MoneyType = Convert.ToInt32(dr["MoneyType"]);
					}
					if (dr["DescriptionMoney"] != null && dr["DescriptionMoney"] != DBNull.Value)
					{
						item.DescriptionMoney = Convert.ToString(dr["DescriptionMoney"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
					{
						item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
					}
					if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
					{
						item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["PrintCopied"] != null && dr["PrintCopied"] != DBNull.Value)
					{
						item.PrintCopied = Convert.ToInt32(dr["PrintCopied"]);
					}
					if (dr["TypeCashName"] != null && dr["TypeCashName"] != DBNull.Value)
					{
						item.TypeCashName = Convert.ToString(dr["TypeCashName"]);
					}
					if (dr["PayForName"] != null && dr["PayForName"] != DBNull.Value)
					{
						item.PayForName = Convert.ToString(dr["PayForName"]);
					}
					if (dr["CashierName"] != null && dr["CashierName"] != DBNull.Value)
					{
						item.CashierName = Convert.ToString(dr["CashierName"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
					}
					if (dr["MoneyTypeName"] != null && dr["MoneyTypeName"] != DBNull.Value)
					{
						item.MoneyTypeName = Convert.ToString(dr["MoneyTypeName"]);
					}
					if (dr["InvoiceCode"] != null && dr["InvoiceCode"] != DBNull.Value)
					{
						item.InvoiceCode = Convert.ToString(dr["InvoiceCode"]);
					}
					if (dr["DeleteName"] != null && dr["DeleteName"] != DBNull.Value)
					{
						item.DeleteName = Convert.ToString(dr["DeleteName"]);
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
		/// Lấy danh sách view_CashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_CashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_CashPay] A "+ condition,  parameters);
				List<view_CashPay> items = new List<view_CashPay>();
				view_CashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_CashPay();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["IsWithDraw"] != null && dr["IsWithDraw"] != DBNull.Value)
					{
						item.IsWithDraw = Convert.ToBoolean(dr["IsWithDraw"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["AcctionDate"] != null && dr["AcctionDate"] != DBNull.Value)
					{
						item.AcctionDate = Convert.ToDateTime(dr["AcctionDate"]);
					}
					if (dr["FK_Cashier"] != null && dr["FK_Cashier"] != DBNull.Value)
					{
						item.FK_Cashier = Convert.ToString(dr["FK_Cashier"]);
					}
					if (dr["BillNumber"] != null && dr["BillNumber"] != DBNull.Value)
					{
						item.BillNumber = Convert.ToString(dr["BillNumber"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["MoneyType"] != null && dr["MoneyType"] != DBNull.Value)
					{
						item.MoneyType = Convert.ToInt32(dr["MoneyType"]);
					}
					if (dr["DescriptionMoney"] != null && dr["DescriptionMoney"] != DBNull.Value)
					{
						item.DescriptionMoney = Convert.ToString(dr["DescriptionMoney"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
					{
						item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
					}
					if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
					{
						item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["PrintCopied"] != null && dr["PrintCopied"] != DBNull.Value)
					{
						item.PrintCopied = Convert.ToInt32(dr["PrintCopied"]);
					}
					if (dr["TypeCashName"] != null && dr["TypeCashName"] != DBNull.Value)
					{
						item.TypeCashName = Convert.ToString(dr["TypeCashName"]);
					}
					if (dr["PayForName"] != null && dr["PayForName"] != DBNull.Value)
					{
						item.PayForName = Convert.ToString(dr["PayForName"]);
					}
					if (dr["CashierName"] != null && dr["CashierName"] != DBNull.Value)
					{
						item.CashierName = Convert.ToString(dr["CashierName"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
					}
					if (dr["MoneyTypeName"] != null && dr["MoneyTypeName"] != DBNull.Value)
					{
						item.MoneyTypeName = Convert.ToString(dr["MoneyTypeName"]);
					}
					if (dr["InvoiceCode"] != null && dr["InvoiceCode"] != DBNull.Value)
					{
						item.InvoiceCode = Convert.ToString(dr["InvoiceCode"]);
					}
					if (dr["DeleteName"] != null && dr["DeleteName"] != DBNull.Value)
					{
						item.DeleteName = Convert.ToString(dr["DeleteName"]);
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

		public List<view_CashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_CashPay] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_CashPay] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_CashPay>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_CashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_CashPay GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_CashPay] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_CashPay item=new view_CashPay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["IsWithDraw"] != null && dr["IsWithDraw"] != DBNull.Value)
						{
							item.IsWithDraw = Convert.ToBoolean(dr["IsWithDraw"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["AcctionDate"] != null && dr["AcctionDate"] != DBNull.Value)
						{
							item.AcctionDate = Convert.ToDateTime(dr["AcctionDate"]);
						}
						if (dr["FK_Cashier"] != null && dr["FK_Cashier"] != DBNull.Value)
						{
							item.FK_Cashier = Convert.ToString(dr["FK_Cashier"]);
						}
						if (dr["BillNumber"] != null && dr["BillNumber"] != DBNull.Value)
						{
							item.BillNumber = Convert.ToString(dr["BillNumber"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToInt32(dr["Type"]);
						}
						if (dr["MoneyType"] != null && dr["MoneyType"] != DBNull.Value)
						{
							item.MoneyType = Convert.ToInt32(dr["MoneyType"]);
						}
						if (dr["DescriptionMoney"] != null && dr["DescriptionMoney"] != DBNull.Value)
						{
							item.DescriptionMoney = Convert.ToString(dr["DescriptionMoney"]);
						}
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
						{
							item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
						}
						if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
						{
							item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
						}
						if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
						{
							item.Reason = Convert.ToString(dr["Reason"]);
						}
						if (dr["PrintCopied"] != null && dr["PrintCopied"] != DBNull.Value)
						{
							item.PrintCopied = Convert.ToInt32(dr["PrintCopied"]);
						}
						if (dr["TypeCashName"] != null && dr["TypeCashName"] != DBNull.Value)
						{
							item.TypeCashName = Convert.ToString(dr["TypeCashName"]);
						}
						if (dr["PayForName"] != null && dr["PayForName"] != DBNull.Value)
						{
							item.PayForName = Convert.ToString(dr["PayForName"]);
						}
						if (dr["CashierName"] != null && dr["CashierName"] != DBNull.Value)
						{
							item.CashierName = Convert.ToString(dr["CashierName"]);
						}
						if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
						{
							item.BranchName = Convert.ToString(dr["BranchName"]);
						}
						if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
						{
							item.TypeName = Convert.ToString(dr["TypeName"]);
						}
						if (dr["MoneyTypeName"] != null && dr["MoneyTypeName"] != DBNull.Value)
						{
							item.MoneyTypeName = Convert.ToString(dr["MoneyTypeName"]);
						}
						if (dr["InvoiceCode"] != null && dr["InvoiceCode"] != DBNull.Value)
						{
							item.InvoiceCode = Convert.ToString(dr["InvoiceCode"]);
						}
						if (dr["DeleteName"] != null && dr["DeleteName"] != DBNull.Value)
						{
							item.DeleteName = Convert.ToString(dr["DeleteName"]);
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

		public view_CashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_CashPay] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_CashPay>(ds);
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
