using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdebitcomparisondetail:IGExpdebitcomparisondetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdebitcomparisondetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDebitComparisonDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitComparisonDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDebitComparisonDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitComparisonDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDebitComparisonDetail từ Database
		/// </summary>
		public List<GExpDebitComparisonDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitComparisonDetail]");
				List<GExpDebitComparisonDetail> items = new List<GExpDebitComparisonDetail>();
				GExpDebitComparisonDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDebitComparisonDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DebitComparison"] != null && dr["FK_DebitComparison"] != DBNull.Value)
					{
						item.FK_DebitComparison = Convert.ToString(dr["FK_DebitComparison"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
					}
					if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
					{
						item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
					}
					if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
					{
						item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["Fee"] != null && dr["Fee"] != DBNull.Value)
					{
						item.Fee = Convert.ToDecimal(dr["Fee"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["PayDate"] != null && dr["PayDate"] != DBNull.Value)
					{
						item.PayDate = Convert.ToDateTime(dr["PayDate"]);
					}
					if (dr["FK_KyDoiSoat"] != null && dr["FK_KyDoiSoat"] != DBNull.Value)
					{
						item.FK_KyDoiSoat = Convert.ToString(dr["FK_KyDoiSoat"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["DebitComparisonCode"] != null && dr["DebitComparisonCode"] != DBNull.Value)
					{
						item.DebitComparisonCode = Convert.ToString(dr["DebitComparisonCode"]);
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
		/// Lấy danh sách GExpDebitComparisonDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDebitComparisonDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDebitComparisonDetail] A "+ condition,  parameters);
				List<GExpDebitComparisonDetail> items = new List<GExpDebitComparisonDetail>();
				GExpDebitComparisonDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDebitComparisonDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DebitComparison"] != null && dr["FK_DebitComparison"] != DBNull.Value)
					{
						item.FK_DebitComparison = Convert.ToString(dr["FK_DebitComparison"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
					}
					if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
					{
						item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
					}
					if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
					{
						item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["Fee"] != null && dr["Fee"] != DBNull.Value)
					{
						item.Fee = Convert.ToDecimal(dr["Fee"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["PayDate"] != null && dr["PayDate"] != DBNull.Value)
					{
						item.PayDate = Convert.ToDateTime(dr["PayDate"]);
					}
					if (dr["FK_KyDoiSoat"] != null && dr["FK_KyDoiSoat"] != DBNull.Value)
					{
						item.FK_KyDoiSoat = Convert.ToString(dr["FK_KyDoiSoat"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["DebitComparisonCode"] != null && dr["DebitComparisonCode"] != DBNull.Value)
					{
						item.DebitComparisonCode = Convert.ToString(dr["DebitComparisonCode"]);
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

		public List<GExpDebitComparisonDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDebitComparisonDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDebitComparisonDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDebitComparisonDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDebitComparisonDetail từ Database
		/// </summary>
		public GExpDebitComparisonDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitComparisonDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpDebitComparisonDetail item=new GExpDebitComparisonDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DebitComparison"] != null && dr["FK_DebitComparison"] != DBNull.Value)
						{
							item.FK_DebitComparison = Convert.ToString(dr["FK_DebitComparison"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
						{
							item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
						}
						if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
						{
							item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
						}
						if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
						{
							item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["Fee"] != null && dr["Fee"] != DBNull.Value)
						{
							item.Fee = Convert.ToDecimal(dr["Fee"]);
						}
						if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
						{
							item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
						}
						if (dr["PayDate"] != null && dr["PayDate"] != DBNull.Value)
						{
							item.PayDate = Convert.ToDateTime(dr["PayDate"]);
						}
						if (dr["FK_KyDoiSoat"] != null && dr["FK_KyDoiSoat"] != DBNull.Value)
						{
							item.FK_KyDoiSoat = Convert.ToString(dr["FK_KyDoiSoat"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["DebitComparisonCode"] != null && dr["DebitComparisonCode"] != DBNull.Value)
						{
							item.DebitComparisonCode = Convert.ToString(dr["DebitComparisonCode"]);
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
		/// Lấy một GExpDebitComparisonDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDebitComparisonDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDebitComparisonDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDebitComparisonDetail item=new GExpDebitComparisonDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DebitComparison"] != null && dr["FK_DebitComparison"] != DBNull.Value)
						{
							item.FK_DebitComparison = Convert.ToString(dr["FK_DebitComparison"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
						{
							item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
						}
						if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
						{
							item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
						}
						if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
						{
							item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["Fee"] != null && dr["Fee"] != DBNull.Value)
						{
							item.Fee = Convert.ToDecimal(dr["Fee"]);
						}
						if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
						{
							item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
						}
						if (dr["PayDate"] != null && dr["PayDate"] != DBNull.Value)
						{
							item.PayDate = Convert.ToDateTime(dr["PayDate"]);
						}
						if (dr["FK_KyDoiSoat"] != null && dr["FK_KyDoiSoat"] != DBNull.Value)
						{
							item.FK_KyDoiSoat = Convert.ToString(dr["FK_KyDoiSoat"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["DebitComparisonCode"] != null && dr["DebitComparisonCode"] != DBNull.Value)
						{
							item.DebitComparisonCode = Convert.ToString(dr["DebitComparisonCode"]);
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

		public GExpDebitComparisonDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDebitComparisonDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDebitComparisonDetail>(ds);
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
		/// Thêm mới GExpDebitComparisonDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDebitComparisonDetail _GExpDebitComparisonDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDebitComparisonDetail](Id, FK_DebitComparison, BT3Code, AcceptMan, AcceptAddress, AcceptManPhone, Status, COD, Fee, IsPayCustomer, PayDate, FK_KyDoiSoat, FK_Post, DebitComparisonCode) VALUES(@Id, @FK_DebitComparison, @BT3Code, @AcceptMan, @AcceptAddress, @AcceptManPhone, @Status, @COD, @Fee, @IsPayCustomer, @PayDate, @FK_KyDoiSoat, @FK_Post, @DebitComparisonCode)", 
					"@Id",  _GExpDebitComparisonDetail.Id, 
					"@FK_DebitComparison",  _GExpDebitComparisonDetail.FK_DebitComparison, 
					"@BT3Code",  _GExpDebitComparisonDetail.BT3Code, 
					"@AcceptMan",  _GExpDebitComparisonDetail.AcceptMan, 
					"@AcceptAddress",  _GExpDebitComparisonDetail.AcceptAddress, 
					"@AcceptManPhone",  _GExpDebitComparisonDetail.AcceptManPhone, 
					"@Status",  _GExpDebitComparisonDetail.Status, 
					"@COD",  _GExpDebitComparisonDetail.COD, 
					"@Fee",  _GExpDebitComparisonDetail.Fee, 
					"@IsPayCustomer",  _GExpDebitComparisonDetail.IsPayCustomer, 
					"@PayDate", this._dataContext.ConvertDateString( _GExpDebitComparisonDetail.PayDate), 
					"@FK_KyDoiSoat",  _GExpDebitComparisonDetail.FK_KyDoiSoat, 
					"@FK_Post",  _GExpDebitComparisonDetail.FK_Post, 
					"@DebitComparisonCode",  _GExpDebitComparisonDetail.DebitComparisonCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDebitComparisonDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDebitComparisonDetail> _GExpDebitComparisonDetails)
		{
			foreach (GExpDebitComparisonDetail item in _GExpDebitComparisonDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitComparisonDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDebitComparisonDetail _GExpDebitComparisonDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitComparisonDetail] SET Id=@Id, FK_DebitComparison=@FK_DebitComparison, BT3Code=@BT3Code, AcceptMan=@AcceptMan, AcceptAddress=@AcceptAddress, AcceptManPhone=@AcceptManPhone, Status=@Status, COD=@COD, Fee=@Fee, IsPayCustomer=@IsPayCustomer, PayDate=@PayDate, FK_KyDoiSoat=@FK_KyDoiSoat, FK_Post=@FK_Post, DebitComparisonCode=@DebitComparisonCode WHERE Id=@Id", 
					"@Id",  _GExpDebitComparisonDetail.Id, 
					"@FK_DebitComparison",  _GExpDebitComparisonDetail.FK_DebitComparison, 
					"@BT3Code",  _GExpDebitComparisonDetail.BT3Code, 
					"@AcceptMan",  _GExpDebitComparisonDetail.AcceptMan, 
					"@AcceptAddress",  _GExpDebitComparisonDetail.AcceptAddress, 
					"@AcceptManPhone",  _GExpDebitComparisonDetail.AcceptManPhone, 
					"@Status",  _GExpDebitComparisonDetail.Status, 
					"@COD",  _GExpDebitComparisonDetail.COD, 
					"@Fee",  _GExpDebitComparisonDetail.Fee, 
					"@IsPayCustomer",  _GExpDebitComparisonDetail.IsPayCustomer, 
					"@PayDate", this._dataContext.ConvertDateString( _GExpDebitComparisonDetail.PayDate), 
					"@FK_KyDoiSoat",  _GExpDebitComparisonDetail.FK_KyDoiSoat, 
					"@FK_Post",  _GExpDebitComparisonDetail.FK_Post, 
					"@DebitComparisonCode",  _GExpDebitComparisonDetail.DebitComparisonCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitComparisonDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDebitComparisonDetail _GExpDebitComparisonDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitComparisonDetail] SET FK_DebitComparison=@FK_DebitComparison, BT3Code=@BT3Code, AcceptMan=@AcceptMan, AcceptAddress=@AcceptAddress, AcceptManPhone=@AcceptManPhone, Status=@Status, COD=@COD, Fee=@Fee, IsPayCustomer=@IsPayCustomer, PayDate=@PayDate, FK_KyDoiSoat=@FK_KyDoiSoat, FK_Post=@FK_Post, DebitComparisonCode=@DebitComparisonCode WHERE Id=@Id", 
					"@FK_DebitComparison",  _GExpDebitComparisonDetail.FK_DebitComparison, 
					"@BT3Code",  _GExpDebitComparisonDetail.BT3Code, 
					"@AcceptMan",  _GExpDebitComparisonDetail.AcceptMan, 
					"@AcceptAddress",  _GExpDebitComparisonDetail.AcceptAddress, 
					"@AcceptManPhone",  _GExpDebitComparisonDetail.AcceptManPhone, 
					"@Status",  _GExpDebitComparisonDetail.Status, 
					"@COD",  _GExpDebitComparisonDetail.COD, 
					"@Fee",  _GExpDebitComparisonDetail.Fee, 
					"@IsPayCustomer",  _GExpDebitComparisonDetail.IsPayCustomer, 
					"@PayDate", this._dataContext.ConvertDateString( _GExpDebitComparisonDetail.PayDate), 
					"@FK_KyDoiSoat",  _GExpDebitComparisonDetail.FK_KyDoiSoat, 
					"@FK_Post",  _GExpDebitComparisonDetail.FK_Post, 
					"@DebitComparisonCode",  _GExpDebitComparisonDetail.DebitComparisonCode, 
					"@Id", _GExpDebitComparisonDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDebitComparisonDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDebitComparisonDetail> _GExpDebitComparisonDetails)
		{
			foreach (GExpDebitComparisonDetail item in _GExpDebitComparisonDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitComparisonDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDebitComparisonDetail _GExpDebitComparisonDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitComparisonDetail] SET Id=@Id, FK_DebitComparison=@FK_DebitComparison, BT3Code=@BT3Code, AcceptMan=@AcceptMan, AcceptAddress=@AcceptAddress, AcceptManPhone=@AcceptManPhone, Status=@Status, COD=@COD, Fee=@Fee, IsPayCustomer=@IsPayCustomer, PayDate=@PayDate, FK_KyDoiSoat=@FK_KyDoiSoat, FK_Post=@FK_Post, DebitComparisonCode=@DebitComparisonCode "+ condition, 
					"@Id",  _GExpDebitComparisonDetail.Id, 
					"@FK_DebitComparison",  _GExpDebitComparisonDetail.FK_DebitComparison, 
					"@BT3Code",  _GExpDebitComparisonDetail.BT3Code, 
					"@AcceptMan",  _GExpDebitComparisonDetail.AcceptMan, 
					"@AcceptAddress",  _GExpDebitComparisonDetail.AcceptAddress, 
					"@AcceptManPhone",  _GExpDebitComparisonDetail.AcceptManPhone, 
					"@Status",  _GExpDebitComparisonDetail.Status, 
					"@COD",  _GExpDebitComparisonDetail.COD, 
					"@Fee",  _GExpDebitComparisonDetail.Fee, 
					"@IsPayCustomer",  _GExpDebitComparisonDetail.IsPayCustomer, 
					"@PayDate", this._dataContext.ConvertDateString( _GExpDebitComparisonDetail.PayDate), 
					"@FK_KyDoiSoat",  _GExpDebitComparisonDetail.FK_KyDoiSoat, 
					"@FK_Post",  _GExpDebitComparisonDetail.FK_Post, 
					"@DebitComparisonCode",  _GExpDebitComparisonDetail.DebitComparisonCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDebitComparisonDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitComparisonDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitComparisonDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDebitComparisonDetail _GExpDebitComparisonDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitComparisonDetail] WHERE Id=@Id",
					"@Id", _GExpDebitComparisonDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitComparisonDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitComparisonDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitComparisonDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDebitComparisonDetail> _GExpDebitComparisonDetails)
		{
			foreach (GExpDebitComparisonDetail item in _GExpDebitComparisonDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
