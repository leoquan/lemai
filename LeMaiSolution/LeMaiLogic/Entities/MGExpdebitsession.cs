using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdebitsession:IGExpdebitsession
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdebitsession(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDebitSession từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitSession]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDebitSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitSession] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDebitSession từ Database
		/// </summary>
		public List<GExpDebitSession> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitSession]");
				List<GExpDebitSession> items = new List<GExpDebitSession>();
				GExpDebitSession item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDebitSession();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SessionCode"] != null && dr["SessionCode"] != DBNull.Value)
					{
						item.SessionCode = Convert.ToString(dr["SessionCode"]);
					}
					if (dr["DebitSessionDate"] != null && dr["DebitSessionDate"] != DBNull.Value)
					{
						item.DebitSessionDate = Convert.ToDateTime(dr["DebitSessionDate"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
					{
						item.TotalFee = Convert.ToDecimal(dr["TotalFee"]);
					}
					if (dr["ReturnFee"] != null && dr["ReturnFee"] != DBNull.Value)
					{
						item.ReturnFee = Convert.ToDecimal(dr["ReturnFee"]);
					}
					if (dr["InsuranceFee"] != null && dr["InsuranceFee"] != DBNull.Value)
					{
						item.InsuranceFee = Convert.ToDecimal(dr["InsuranceFee"]);
					}
					if (dr["ReturnCOD"] != null && dr["ReturnCOD"] != DBNull.Value)
					{
						item.ReturnCOD = Convert.ToDecimal(dr["ReturnCOD"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["FK_DebitComparison"] != null && dr["FK_DebitComparison"] != DBNull.Value)
					{
						item.FK_DebitComparison = Convert.ToString(dr["FK_DebitComparison"]);
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
		/// Lấy danh sách GExpDebitSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDebitSession> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDebitSession] A "+ condition,  parameters);
				List<GExpDebitSession> items = new List<GExpDebitSession>();
				GExpDebitSession item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDebitSession();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SessionCode"] != null && dr["SessionCode"] != DBNull.Value)
					{
						item.SessionCode = Convert.ToString(dr["SessionCode"]);
					}
					if (dr["DebitSessionDate"] != null && dr["DebitSessionDate"] != DBNull.Value)
					{
						item.DebitSessionDate = Convert.ToDateTime(dr["DebitSessionDate"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
					{
						item.TotalFee = Convert.ToDecimal(dr["TotalFee"]);
					}
					if (dr["ReturnFee"] != null && dr["ReturnFee"] != DBNull.Value)
					{
						item.ReturnFee = Convert.ToDecimal(dr["ReturnFee"]);
					}
					if (dr["InsuranceFee"] != null && dr["InsuranceFee"] != DBNull.Value)
					{
						item.InsuranceFee = Convert.ToDecimal(dr["InsuranceFee"]);
					}
					if (dr["ReturnCOD"] != null && dr["ReturnCOD"] != DBNull.Value)
					{
						item.ReturnCOD = Convert.ToDecimal(dr["ReturnCOD"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["FK_DebitComparison"] != null && dr["FK_DebitComparison"] != DBNull.Value)
					{
						item.FK_DebitComparison = Convert.ToString(dr["FK_DebitComparison"]);
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

		public List<GExpDebitSession> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDebitSession] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDebitSession] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDebitSession>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDebitSession từ Database
		/// </summary>
		public GExpDebitSession GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitSession] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpDebitSession item=new GExpDebitSession();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["SessionCode"] != null && dr["SessionCode"] != DBNull.Value)
						{
							item.SessionCode = Convert.ToString(dr["SessionCode"]);
						}
						if (dr["DebitSessionDate"] != null && dr["DebitSessionDate"] != DBNull.Value)
						{
							item.DebitSessionDate = Convert.ToDateTime(dr["DebitSessionDate"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
						{
							item.TotalFee = Convert.ToDecimal(dr["TotalFee"]);
						}
						if (dr["ReturnFee"] != null && dr["ReturnFee"] != DBNull.Value)
						{
							item.ReturnFee = Convert.ToDecimal(dr["ReturnFee"]);
						}
						if (dr["InsuranceFee"] != null && dr["InsuranceFee"] != DBNull.Value)
						{
							item.InsuranceFee = Convert.ToDecimal(dr["InsuranceFee"]);
						}
						if (dr["ReturnCOD"] != null && dr["ReturnCOD"] != DBNull.Value)
						{
							item.ReturnCOD = Convert.ToDecimal(dr["ReturnCOD"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["FK_DebitComparison"] != null && dr["FK_DebitComparison"] != DBNull.Value)
						{
							item.FK_DebitComparison = Convert.ToString(dr["FK_DebitComparison"]);
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
		/// Lấy một GExpDebitSession đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDebitSession GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDebitSession] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDebitSession item=new GExpDebitSession();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["SessionCode"] != null && dr["SessionCode"] != DBNull.Value)
						{
							item.SessionCode = Convert.ToString(dr["SessionCode"]);
						}
						if (dr["DebitSessionDate"] != null && dr["DebitSessionDate"] != DBNull.Value)
						{
							item.DebitSessionDate = Convert.ToDateTime(dr["DebitSessionDate"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
						{
							item.TotalFee = Convert.ToDecimal(dr["TotalFee"]);
						}
						if (dr["ReturnFee"] != null && dr["ReturnFee"] != DBNull.Value)
						{
							item.ReturnFee = Convert.ToDecimal(dr["ReturnFee"]);
						}
						if (dr["InsuranceFee"] != null && dr["InsuranceFee"] != DBNull.Value)
						{
							item.InsuranceFee = Convert.ToDecimal(dr["InsuranceFee"]);
						}
						if (dr["ReturnCOD"] != null && dr["ReturnCOD"] != DBNull.Value)
						{
							item.ReturnCOD = Convert.ToDecimal(dr["ReturnCOD"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["FK_DebitComparison"] != null && dr["FK_DebitComparison"] != DBNull.Value)
						{
							item.FK_DebitComparison = Convert.ToString(dr["FK_DebitComparison"]);
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

		public GExpDebitSession GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDebitSession] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDebitSession>(ds);
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
		/// Thêm mới GExpDebitSession vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDebitSession _GExpDebitSession)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDebitSession](Id, SessionCode, DebitSessionDate, COD, TotalFee, ReturnFee, InsuranceFee, ReturnCOD, FK_Account, FK_DebitComparison) VALUES(@Id, @SessionCode, @DebitSessionDate, @COD, @TotalFee, @ReturnFee, @InsuranceFee, @ReturnCOD, @FK_Account, @FK_DebitComparison)", 
					"@Id",  _GExpDebitSession.Id, 
					"@SessionCode",  _GExpDebitSession.SessionCode, 
					"@DebitSessionDate", this._dataContext.ConvertDateString( _GExpDebitSession.DebitSessionDate), 
					"@COD",  _GExpDebitSession.COD, 
					"@TotalFee",  _GExpDebitSession.TotalFee, 
					"@ReturnFee",  _GExpDebitSession.ReturnFee, 
					"@InsuranceFee",  _GExpDebitSession.InsuranceFee, 
					"@ReturnCOD",  _GExpDebitSession.ReturnCOD, 
					"@FK_Account",  _GExpDebitSession.FK_Account, 
					"@FK_DebitComparison",  _GExpDebitSession.FK_DebitComparison);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDebitSession vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDebitSession> _GExpDebitSessions)
		{
			foreach (GExpDebitSession item in _GExpDebitSessions)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDebitSession _GExpDebitSession, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitSession] SET Id=@Id, SessionCode=@SessionCode, DebitSessionDate=@DebitSessionDate, COD=@COD, TotalFee=@TotalFee, ReturnFee=@ReturnFee, InsuranceFee=@InsuranceFee, ReturnCOD=@ReturnCOD, FK_Account=@FK_Account, FK_DebitComparison=@FK_DebitComparison WHERE Id=@Id", 
					"@Id",  _GExpDebitSession.Id, 
					"@SessionCode",  _GExpDebitSession.SessionCode, 
					"@DebitSessionDate", this._dataContext.ConvertDateString( _GExpDebitSession.DebitSessionDate), 
					"@COD",  _GExpDebitSession.COD, 
					"@TotalFee",  _GExpDebitSession.TotalFee, 
					"@ReturnFee",  _GExpDebitSession.ReturnFee, 
					"@InsuranceFee",  _GExpDebitSession.InsuranceFee, 
					"@ReturnCOD",  _GExpDebitSession.ReturnCOD, 
					"@FK_Account",  _GExpDebitSession.FK_Account, 
					"@FK_DebitComparison",  _GExpDebitSession.FK_DebitComparison, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitSession vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDebitSession _GExpDebitSession)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitSession] SET SessionCode=@SessionCode, DebitSessionDate=@DebitSessionDate, COD=@COD, TotalFee=@TotalFee, ReturnFee=@ReturnFee, InsuranceFee=@InsuranceFee, ReturnCOD=@ReturnCOD, FK_Account=@FK_Account, FK_DebitComparison=@FK_DebitComparison WHERE Id=@Id", 
					"@SessionCode",  _GExpDebitSession.SessionCode, 
					"@DebitSessionDate", this._dataContext.ConvertDateString( _GExpDebitSession.DebitSessionDate), 
					"@COD",  _GExpDebitSession.COD, 
					"@TotalFee",  _GExpDebitSession.TotalFee, 
					"@ReturnFee",  _GExpDebitSession.ReturnFee, 
					"@InsuranceFee",  _GExpDebitSession.InsuranceFee, 
					"@ReturnCOD",  _GExpDebitSession.ReturnCOD, 
					"@FK_Account",  _GExpDebitSession.FK_Account, 
					"@FK_DebitComparison",  _GExpDebitSession.FK_DebitComparison, 
					"@Id", _GExpDebitSession.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDebitSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDebitSession> _GExpDebitSessions)
		{
			foreach (GExpDebitSession item in _GExpDebitSessions)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitSession vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDebitSession _GExpDebitSession, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitSession] SET Id=@Id, SessionCode=@SessionCode, DebitSessionDate=@DebitSessionDate, COD=@COD, TotalFee=@TotalFee, ReturnFee=@ReturnFee, InsuranceFee=@InsuranceFee, ReturnCOD=@ReturnCOD, FK_Account=@FK_Account, FK_DebitComparison=@FK_DebitComparison "+ condition, 
					"@Id",  _GExpDebitSession.Id, 
					"@SessionCode",  _GExpDebitSession.SessionCode, 
					"@DebitSessionDate", this._dataContext.ConvertDateString( _GExpDebitSession.DebitSessionDate), 
					"@COD",  _GExpDebitSession.COD, 
					"@TotalFee",  _GExpDebitSession.TotalFee, 
					"@ReturnFee",  _GExpDebitSession.ReturnFee, 
					"@InsuranceFee",  _GExpDebitSession.InsuranceFee, 
					"@ReturnCOD",  _GExpDebitSession.ReturnCOD, 
					"@FK_Account",  _GExpDebitSession.FK_Account, 
					"@FK_DebitComparison",  _GExpDebitSession.FK_DebitComparison);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDebitSession trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitSession] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitSession trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDebitSession _GExpDebitSession)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitSession] WHERE Id=@Id",
					"@Id", _GExpDebitSession.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitSession trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitSession] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitSession trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDebitSession> _GExpDebitSessions)
		{
			foreach (GExpDebitSession item in _GExpDebitSessions)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
