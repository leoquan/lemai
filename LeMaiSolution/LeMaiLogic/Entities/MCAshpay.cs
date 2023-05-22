using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MCAshpay:ICAshpay
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MCAshpay(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable CashPay từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPay]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable CashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPay] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách CashPay từ Database
		/// </summary>
		public List<CashPay> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPay]");
				List<CashPay> items = new List<CashPay>();
				CashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new CashPay();
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
		/// Lấy danh sách CashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<CashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[CashPay] A "+ condition,  parameters);
				List<CashPay> items = new List<CashPay>();
				CashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new CashPay();
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<CashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[CashPay] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[CashPay] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<CashPay>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một CashPay từ Database
		/// </summary>
		public CashPay GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPay] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					CashPay item=new CashPay();
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

		/// <summary>
		/// Lấy một CashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public CashPay GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[CashPay] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					CashPay item=new CashPay();
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

		public CashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[CashPay] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<CashPay>(ds);
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
		/// <summary>
		/// Thêm mới CashPay vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, CashPay _CashPay)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[CashPay](Id, FK_Branch, IsWithDraw, Value, AcctionDate, FK_Cashier, BillNumber, Type, MoneyType, DescriptionMoney, FK_AccountObject, Note, IsDelete, FK_AccountDelete, CreateDelete, Reason, PrintCopied) VALUES(@Id, @FK_Branch, @IsWithDraw, @Value, @AcctionDate, @FK_Cashier, @BillNumber, @Type, @MoneyType, @DescriptionMoney, @FK_AccountObject, @Note, @IsDelete, @FK_AccountDelete, @CreateDelete, @Reason, @PrintCopied)", 
					"@Id",  _CashPay.Id, 
					"@FK_Branch",  _CashPay.FK_Branch, 
					"@IsWithDraw",  _CashPay.IsWithDraw, 
					"@Value",  _CashPay.Value, 
					"@AcctionDate", this._dataContext.ConvertDateString( _CashPay.AcctionDate), 
					"@FK_Cashier",  _CashPay.FK_Cashier, 
					"@BillNumber",  _CashPay.BillNumber, 
					"@Type",  _CashPay.Type, 
					"@MoneyType",  _CashPay.MoneyType, 
					"@DescriptionMoney",  _CashPay.DescriptionMoney, 
					"@FK_AccountObject",  _CashPay.FK_AccountObject, 
					"@Note",  _CashPay.Note, 
					"@IsDelete",  _CashPay.IsDelete, 
					"@FK_AccountDelete",  _CashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _CashPay.CreateDelete), 
					"@Reason",  _CashPay.Reason, 
					"@PrintCopied",  _CashPay.PrintCopied);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng CashPay vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<CashPay> _CashPays)
		{
			foreach (CashPay item in _CashPays)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật CashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, CashPay _CashPay, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[CashPay] SET Id=@Id, FK_Branch=@FK_Branch, IsWithDraw=@IsWithDraw, Value=@Value, AcctionDate=@AcctionDate, FK_Cashier=@FK_Cashier, BillNumber=@BillNumber, Type=@Type, MoneyType=@MoneyType, DescriptionMoney=@DescriptionMoney, FK_AccountObject=@FK_AccountObject, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, PrintCopied=@PrintCopied WHERE Id=@Id", 
					"@Id",  _CashPay.Id, 
					"@FK_Branch",  _CashPay.FK_Branch, 
					"@IsWithDraw",  _CashPay.IsWithDraw, 
					"@Value",  _CashPay.Value, 
					"@AcctionDate", this._dataContext.ConvertDateString( _CashPay.AcctionDate), 
					"@FK_Cashier",  _CashPay.FK_Cashier, 
					"@BillNumber",  _CashPay.BillNumber, 
					"@Type",  _CashPay.Type, 
					"@MoneyType",  _CashPay.MoneyType, 
					"@DescriptionMoney",  _CashPay.DescriptionMoney, 
					"@FK_AccountObject",  _CashPay.FK_AccountObject, 
					"@Note",  _CashPay.Note, 
					"@IsDelete",  _CashPay.IsDelete, 
					"@FK_AccountDelete",  _CashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _CashPay.CreateDelete), 
					"@Reason",  _CashPay.Reason, 
					"@PrintCopied",  _CashPay.PrintCopied, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật CashPay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, CashPay _CashPay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[CashPay] SET FK_Branch=@FK_Branch, IsWithDraw=@IsWithDraw, Value=@Value, AcctionDate=@AcctionDate, FK_Cashier=@FK_Cashier, BillNumber=@BillNumber, Type=@Type, MoneyType=@MoneyType, DescriptionMoney=@DescriptionMoney, FK_AccountObject=@FK_AccountObject, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, PrintCopied=@PrintCopied WHERE Id=@Id", 
					"@FK_Branch",  _CashPay.FK_Branch, 
					"@IsWithDraw",  _CashPay.IsWithDraw, 
					"@Value",  _CashPay.Value, 
					"@AcctionDate", this._dataContext.ConvertDateString( _CashPay.AcctionDate), 
					"@FK_Cashier",  _CashPay.FK_Cashier, 
					"@BillNumber",  _CashPay.BillNumber, 
					"@Type",  _CashPay.Type, 
					"@MoneyType",  _CashPay.MoneyType, 
					"@DescriptionMoney",  _CashPay.DescriptionMoney, 
					"@FK_AccountObject",  _CashPay.FK_AccountObject, 
					"@Note",  _CashPay.Note, 
					"@IsDelete",  _CashPay.IsDelete, 
					"@FK_AccountDelete",  _CashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _CashPay.CreateDelete), 
					"@Reason",  _CashPay.Reason, 
					"@PrintCopied",  _CashPay.PrintCopied, 
					"@Id", _CashPay.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách CashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<CashPay> _CashPays)
		{
			foreach (CashPay item in _CashPays)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật CashPay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, CashPay _CashPay, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[CashPay] SET Id=@Id, FK_Branch=@FK_Branch, IsWithDraw=@IsWithDraw, Value=@Value, AcctionDate=@AcctionDate, FK_Cashier=@FK_Cashier, BillNumber=@BillNumber, Type=@Type, MoneyType=@MoneyType, DescriptionMoney=@DescriptionMoney, FK_AccountObject=@FK_AccountObject, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, PrintCopied=@PrintCopied "+ condition, 
					"@Id",  _CashPay.Id, 
					"@FK_Branch",  _CashPay.FK_Branch, 
					"@IsWithDraw",  _CashPay.IsWithDraw, 
					"@Value",  _CashPay.Value, 
					"@AcctionDate", this._dataContext.ConvertDateString( _CashPay.AcctionDate), 
					"@FK_Cashier",  _CashPay.FK_Cashier, 
					"@BillNumber",  _CashPay.BillNumber, 
					"@Type",  _CashPay.Type, 
					"@MoneyType",  _CashPay.MoneyType, 
					"@DescriptionMoney",  _CashPay.DescriptionMoney, 
					"@FK_AccountObject",  _CashPay.FK_AccountObject, 
					"@Note",  _CashPay.Note, 
					"@IsDelete",  _CashPay.IsDelete, 
					"@FK_AccountDelete",  _CashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _CashPay.CreateDelete), 
					"@Reason",  _CashPay.Reason, 
					"@PrintCopied",  _CashPay.PrintCopied);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa CashPay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[CashPay] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa CashPay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, CashPay _CashPay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[CashPay] WHERE Id=@Id",
					"@Id", _CashPay.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa CashPay trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[CashPay] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa CashPay trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<CashPay> _CashPays)
		{
			foreach (CashPay item in _CashPays)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
