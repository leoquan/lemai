using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpmoneyreturnsession:IGExpmoneyreturnsession
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpmoneyreturnsession(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpMoneyReturnSession từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturnSession]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpMoneyReturnSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturnSession] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpMoneyReturnSession từ Database
		/// </summary>
		public List<GExpMoneyReturnSession> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturnSession]");
				List<GExpMoneyReturnSession> items = new List<GExpMoneyReturnSession>();
				GExpMoneyReturnSession item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpMoneyReturnSession();
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
					if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
					{
						item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
					}
					if (dr["SessionCode"] != null && dr["SessionCode"] != DBNull.Value)
					{
						item.SessionCode = Convert.ToString(dr["SessionCode"]);
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
		/// Lấy danh sách GExpMoneyReturnSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpMoneyReturnSession> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpMoneyReturnSession] A "+ condition,  parameters);
				List<GExpMoneyReturnSession> items = new List<GExpMoneyReturnSession>();
				GExpMoneyReturnSession item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpMoneyReturnSession();
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
					if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
					{
						item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
					}
					if (dr["SessionCode"] != null && dr["SessionCode"] != DBNull.Value)
					{
						item.SessionCode = Convert.ToString(dr["SessionCode"]);
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

		public List<GExpMoneyReturnSession> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpMoneyReturnSession] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpMoneyReturnSession] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpMoneyReturnSession>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpMoneyReturnSession từ Database
		/// </summary>
		public GExpMoneyReturnSession GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturnSession] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpMoneyReturnSession item=new GExpMoneyReturnSession();
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
						if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
						{
							item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
						}
						if (dr["SessionCode"] != null && dr["SessionCode"] != DBNull.Value)
						{
							item.SessionCode = Convert.ToString(dr["SessionCode"]);
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
		/// Lấy một GExpMoneyReturnSession đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpMoneyReturnSession GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpMoneyReturnSession] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpMoneyReturnSession item=new GExpMoneyReturnSession();
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
						if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
						{
							item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
						}
						if (dr["SessionCode"] != null && dr["SessionCode"] != DBNull.Value)
						{
							item.SessionCode = Convert.ToString(dr["SessionCode"]);
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

		public GExpMoneyReturnSession GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpMoneyReturnSession] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpMoneyReturnSession>(ds);
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
		/// Thêm mới GExpMoneyReturnSession vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpMoneyReturnSession _GExpMoneyReturnSession)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpMoneyReturnSession](Id, FK_ProviderAccount, Post, Note, BT3COD, BT3TotalPaid, BT3TotalDiscount, BT3TotalFee, MoneyReturn, FK_AccountRefer, DateReturn, IsPayCustomer, FK_DoiSoat, SessionCode) VALUES(@Id, @FK_ProviderAccount, @Post, @Note, @BT3COD, @BT3TotalPaid, @BT3TotalDiscount, @BT3TotalFee, @MoneyReturn, @FK_AccountRefer, @DateReturn, @IsPayCustomer, @FK_DoiSoat, @SessionCode)", 
					"@Id",  _GExpMoneyReturnSession.Id, 
					"@FK_ProviderAccount",  _GExpMoneyReturnSession.FK_ProviderAccount, 
					"@Post",  _GExpMoneyReturnSession.Post, 
					"@Note",  _GExpMoneyReturnSession.Note, 
					"@BT3COD",  _GExpMoneyReturnSession.BT3COD, 
					"@BT3TotalPaid",  _GExpMoneyReturnSession.BT3TotalPaid, 
					"@BT3TotalDiscount",  _GExpMoneyReturnSession.BT3TotalDiscount, 
					"@BT3TotalFee",  _GExpMoneyReturnSession.BT3TotalFee, 
					"@MoneyReturn",  _GExpMoneyReturnSession.MoneyReturn, 
					"@FK_AccountRefer",  _GExpMoneyReturnSession.FK_AccountRefer, 
					"@DateReturn", this._dataContext.ConvertDateString( _GExpMoneyReturnSession.DateReturn), 
					"@IsPayCustomer",  _GExpMoneyReturnSession.IsPayCustomer, 
					"@FK_DoiSoat",  _GExpMoneyReturnSession.FK_DoiSoat, 
					"@SessionCode",  _GExpMoneyReturnSession.SessionCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpMoneyReturnSession vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpMoneyReturnSession> _GExpMoneyReturnSessions)
		{
			foreach (GExpMoneyReturnSession item in _GExpMoneyReturnSessions)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpMoneyReturnSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpMoneyReturnSession _GExpMoneyReturnSession, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpMoneyReturnSession] SET Id=@Id, FK_ProviderAccount=@FK_ProviderAccount, Post=@Post, Note=@Note, BT3COD=@BT3COD, BT3TotalPaid=@BT3TotalPaid, BT3TotalDiscount=@BT3TotalDiscount, BT3TotalFee=@BT3TotalFee, MoneyReturn=@MoneyReturn, FK_AccountRefer=@FK_AccountRefer, DateReturn=@DateReturn, IsPayCustomer=@IsPayCustomer, FK_DoiSoat=@FK_DoiSoat, SessionCode=@SessionCode WHERE Id=@Id", 
					"@Id",  _GExpMoneyReturnSession.Id, 
					"@FK_ProviderAccount",  _GExpMoneyReturnSession.FK_ProviderAccount, 
					"@Post",  _GExpMoneyReturnSession.Post, 
					"@Note",  _GExpMoneyReturnSession.Note, 
					"@BT3COD",  _GExpMoneyReturnSession.BT3COD, 
					"@BT3TotalPaid",  _GExpMoneyReturnSession.BT3TotalPaid, 
					"@BT3TotalDiscount",  _GExpMoneyReturnSession.BT3TotalDiscount, 
					"@BT3TotalFee",  _GExpMoneyReturnSession.BT3TotalFee, 
					"@MoneyReturn",  _GExpMoneyReturnSession.MoneyReturn, 
					"@FK_AccountRefer",  _GExpMoneyReturnSession.FK_AccountRefer, 
					"@DateReturn", this._dataContext.ConvertDateString( _GExpMoneyReturnSession.DateReturn), 
					"@IsPayCustomer",  _GExpMoneyReturnSession.IsPayCustomer, 
					"@FK_DoiSoat",  _GExpMoneyReturnSession.FK_DoiSoat, 
					"@SessionCode",  _GExpMoneyReturnSession.SessionCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpMoneyReturnSession vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpMoneyReturnSession _GExpMoneyReturnSession)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpMoneyReturnSession] SET FK_ProviderAccount=@FK_ProviderAccount, Post=@Post, Note=@Note, BT3COD=@BT3COD, BT3TotalPaid=@BT3TotalPaid, BT3TotalDiscount=@BT3TotalDiscount, BT3TotalFee=@BT3TotalFee, MoneyReturn=@MoneyReturn, FK_AccountRefer=@FK_AccountRefer, DateReturn=@DateReturn, IsPayCustomer=@IsPayCustomer, FK_DoiSoat=@FK_DoiSoat, SessionCode=@SessionCode WHERE Id=@Id", 
					"@FK_ProviderAccount",  _GExpMoneyReturnSession.FK_ProviderAccount, 
					"@Post",  _GExpMoneyReturnSession.Post, 
					"@Note",  _GExpMoneyReturnSession.Note, 
					"@BT3COD",  _GExpMoneyReturnSession.BT3COD, 
					"@BT3TotalPaid",  _GExpMoneyReturnSession.BT3TotalPaid, 
					"@BT3TotalDiscount",  _GExpMoneyReturnSession.BT3TotalDiscount, 
					"@BT3TotalFee",  _GExpMoneyReturnSession.BT3TotalFee, 
					"@MoneyReturn",  _GExpMoneyReturnSession.MoneyReturn, 
					"@FK_AccountRefer",  _GExpMoneyReturnSession.FK_AccountRefer, 
					"@DateReturn", this._dataContext.ConvertDateString( _GExpMoneyReturnSession.DateReturn), 
					"@IsPayCustomer",  _GExpMoneyReturnSession.IsPayCustomer, 
					"@FK_DoiSoat",  _GExpMoneyReturnSession.FK_DoiSoat, 
					"@SessionCode",  _GExpMoneyReturnSession.SessionCode, 
					"@Id", _GExpMoneyReturnSession.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpMoneyReturnSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpMoneyReturnSession> _GExpMoneyReturnSessions)
		{
			foreach (GExpMoneyReturnSession item in _GExpMoneyReturnSessions)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpMoneyReturnSession vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpMoneyReturnSession _GExpMoneyReturnSession, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpMoneyReturnSession] SET Id=@Id, FK_ProviderAccount=@FK_ProviderAccount, Post=@Post, Note=@Note, BT3COD=@BT3COD, BT3TotalPaid=@BT3TotalPaid, BT3TotalDiscount=@BT3TotalDiscount, BT3TotalFee=@BT3TotalFee, MoneyReturn=@MoneyReturn, FK_AccountRefer=@FK_AccountRefer, DateReturn=@DateReturn, IsPayCustomer=@IsPayCustomer, FK_DoiSoat=@FK_DoiSoat, SessionCode=@SessionCode "+ condition, 
					"@Id",  _GExpMoneyReturnSession.Id, 
					"@FK_ProviderAccount",  _GExpMoneyReturnSession.FK_ProviderAccount, 
					"@Post",  _GExpMoneyReturnSession.Post, 
					"@Note",  _GExpMoneyReturnSession.Note, 
					"@BT3COD",  _GExpMoneyReturnSession.BT3COD, 
					"@BT3TotalPaid",  _GExpMoneyReturnSession.BT3TotalPaid, 
					"@BT3TotalDiscount",  _GExpMoneyReturnSession.BT3TotalDiscount, 
					"@BT3TotalFee",  _GExpMoneyReturnSession.BT3TotalFee, 
					"@MoneyReturn",  _GExpMoneyReturnSession.MoneyReturn, 
					"@FK_AccountRefer",  _GExpMoneyReturnSession.FK_AccountRefer, 
					"@DateReturn", this._dataContext.ConvertDateString( _GExpMoneyReturnSession.DateReturn), 
					"@IsPayCustomer",  _GExpMoneyReturnSession.IsPayCustomer, 
					"@FK_DoiSoat",  _GExpMoneyReturnSession.FK_DoiSoat, 
					"@SessionCode",  _GExpMoneyReturnSession.SessionCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpMoneyReturnSession trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpMoneyReturnSession] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpMoneyReturnSession trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpMoneyReturnSession _GExpMoneyReturnSession)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpMoneyReturnSession] WHERE Id=@Id",
					"@Id", _GExpMoneyReturnSession.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpMoneyReturnSession trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpMoneyReturnSession] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpMoneyReturnSession trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpMoneyReturnSession> _GExpMoneyReturnSessions)
		{
			foreach (GExpMoneyReturnSession item in _GExpMoneyReturnSessions)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
