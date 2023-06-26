using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpmoneyreturnsession:IVIewgexpmoneyreturnsession
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpmoneyreturnsession(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpMoneyReturnSession từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpMoneyReturnSession]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpMoneyReturnSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpMoneyReturnSession] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpMoneyReturnSession từ Database
		/// </summary>
		public List<view_GExpMoneyReturnSession> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpMoneyReturnSession]");
				List<view_GExpMoneyReturnSession> items = new List<view_GExpMoneyReturnSession>();
				view_GExpMoneyReturnSession item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpMoneyReturnSession();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
					{
						item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
					{
						item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
					}
					if (dr["BT3TotalPaid"] != null && dr["BT3TotalPaid"] != DBNull.Value)
					{
						item.BT3TotalPaid = Convert.ToDecimal(dr["BT3TotalPaid"]);
					}
					if (dr["BT3TotalDiscount"] != null && dr["BT3TotalDiscount"] != DBNull.Value)
					{
						item.BT3TotalDiscount = Convert.ToDecimal(dr["BT3TotalDiscount"]);
					}
					if (dr["BT3TotalFee"] != null && dr["BT3TotalFee"] != DBNull.Value)
					{
						item.BT3TotalFee = Convert.ToDecimal(dr["BT3TotalFee"]);
					}
					if (dr["MoneyReturn"] != null && dr["MoneyReturn"] != DBNull.Value)
					{
						item.MoneyReturn = Convert.ToDecimal(dr["MoneyReturn"]);
					}
					if (dr["FK_AccountRefer"] != null && dr["FK_AccountRefer"] != DBNull.Value)
					{
						item.FK_AccountRefer = Convert.ToString(dr["FK_AccountRefer"]);
					}
					if (dr["DateReturn"] != null && dr["DateReturn"] != DBNull.Value)
					{
						item.DateReturn = Convert.ToDateTime(dr["DateReturn"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["SessionCode"] != null && dr["SessionCode"] != DBNull.Value)
					{
						item.SessionCode = Convert.ToString(dr["SessionCode"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
					{
						item.ShopName = Convert.ToString(dr["ShopName"]);
					}
					if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
					{
						item.UserApi = Convert.ToString(dr["UserApi"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
					{
						item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
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
		/// Lấy danh sách view_GExpMoneyReturnSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpMoneyReturnSession> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpMoneyReturnSession] A "+ condition,  parameters);
				List<view_GExpMoneyReturnSession> items = new List<view_GExpMoneyReturnSession>();
				view_GExpMoneyReturnSession item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpMoneyReturnSession();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
					{
						item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
					{
						item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
					}
					if (dr["BT3TotalPaid"] != null && dr["BT3TotalPaid"] != DBNull.Value)
					{
						item.BT3TotalPaid = Convert.ToDecimal(dr["BT3TotalPaid"]);
					}
					if (dr["BT3TotalDiscount"] != null && dr["BT3TotalDiscount"] != DBNull.Value)
					{
						item.BT3TotalDiscount = Convert.ToDecimal(dr["BT3TotalDiscount"]);
					}
					if (dr["BT3TotalFee"] != null && dr["BT3TotalFee"] != DBNull.Value)
					{
						item.BT3TotalFee = Convert.ToDecimal(dr["BT3TotalFee"]);
					}
					if (dr["MoneyReturn"] != null && dr["MoneyReturn"] != DBNull.Value)
					{
						item.MoneyReturn = Convert.ToDecimal(dr["MoneyReturn"]);
					}
					if (dr["FK_AccountRefer"] != null && dr["FK_AccountRefer"] != DBNull.Value)
					{
						item.FK_AccountRefer = Convert.ToString(dr["FK_AccountRefer"]);
					}
					if (dr["DateReturn"] != null && dr["DateReturn"] != DBNull.Value)
					{
						item.DateReturn = Convert.ToDateTime(dr["DateReturn"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["SessionCode"] != null && dr["SessionCode"] != DBNull.Value)
					{
						item.SessionCode = Convert.ToString(dr["SessionCode"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
					{
						item.ShopName = Convert.ToString(dr["ShopName"]);
					}
					if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
					{
						item.UserApi = Convert.ToString(dr["UserApi"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
					{
						item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
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

		public List<view_GExpMoneyReturnSession> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpMoneyReturnSession] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpMoneyReturnSession] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpMoneyReturnSession>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpMoneyReturnSession đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpMoneyReturnSession GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpMoneyReturnSession] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpMoneyReturnSession item=new view_GExpMoneyReturnSession();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
						{
							item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
						{
							item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
						}
						if (dr["BT3TotalPaid"] != null && dr["BT3TotalPaid"] != DBNull.Value)
						{
							item.BT3TotalPaid = Convert.ToDecimal(dr["BT3TotalPaid"]);
						}
						if (dr["BT3TotalDiscount"] != null && dr["BT3TotalDiscount"] != DBNull.Value)
						{
							item.BT3TotalDiscount = Convert.ToDecimal(dr["BT3TotalDiscount"]);
						}
						if (dr["BT3TotalFee"] != null && dr["BT3TotalFee"] != DBNull.Value)
						{
							item.BT3TotalFee = Convert.ToDecimal(dr["BT3TotalFee"]);
						}
						if (dr["MoneyReturn"] != null && dr["MoneyReturn"] != DBNull.Value)
						{
							item.MoneyReturn = Convert.ToDecimal(dr["MoneyReturn"]);
						}
						if (dr["FK_AccountRefer"] != null && dr["FK_AccountRefer"] != DBNull.Value)
						{
							item.FK_AccountRefer = Convert.ToString(dr["FK_AccountRefer"]);
						}
						if (dr["DateReturn"] != null && dr["DateReturn"] != DBNull.Value)
						{
							item.DateReturn = Convert.ToDateTime(dr["DateReturn"]);
						}
						if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
						{
							item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
						}
						if (dr["SessionCode"] != null && dr["SessionCode"] != DBNull.Value)
						{
							item.SessionCode = Convert.ToString(dr["SessionCode"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
						{
							item.ShopName = Convert.ToString(dr["ShopName"]);
						}
						if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
						{
							item.UserApi = Convert.ToString(dr["UserApi"]);
						}
						if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
						{
							item.ProviderName = Convert.ToString(dr["ProviderName"]);
						}
						if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
						{
							item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
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

		public view_GExpMoneyReturnSession GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpMoneyReturnSession] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpMoneyReturnSession>(ds);
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
