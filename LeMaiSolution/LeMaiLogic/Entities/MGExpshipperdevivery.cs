using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpshipperdevivery:IGExpshipperdevivery
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpshipperdevivery(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpShipperDevivery từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperDevivery]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpShipperDevivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperDevivery] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpShipperDevivery từ Database
		/// </summary>
		public List<GExpShipperDevivery> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperDevivery]");
				List<GExpShipperDevivery> items = new List<GExpShipperDevivery>();
				GExpShipperDevivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipperDevivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ShipperId"] != null && dr["ShipperId"] != DBNull.Value)
					{
						item.ShipperId = Convert.ToString(dr["ShipperId"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["SignDate"] != null && dr["SignDate"] != DBNull.Value)
					{
						item.SignDate = Convert.ToDateTime(dr["SignDate"]);
					}
					if (dr["TotalCOD"] != null && dr["TotalCOD"] != DBNull.Value)
					{
						item.TotalCOD = Convert.ToDecimal(dr["TotalCOD"]);
					}
					if (dr["IsCash"] != null && dr["IsCash"] != DBNull.Value)
					{
						item.IsCash = Convert.ToBoolean(dr["IsCash"]);
					}
					if (dr["CashTime"] != null && dr["CashTime"] != DBNull.Value)
					{
						item.CashTime = Convert.ToDateTime(dr["CashTime"]);
					}
					if (dr["FK_AccountCash"] != null && dr["FK_AccountCash"] != DBNull.Value)
					{
						item.FK_AccountCash = Convert.ToString(dr["FK_AccountCash"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_CashId"] != null && dr["FK_CashId"] != DBNull.Value)
					{
						item.FK_CashId = Convert.ToString(dr["FK_CashId"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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
		/// Lấy danh sách GExpShipperDevivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpShipperDevivery> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipperDevivery] A "+ condition,  parameters);
				List<GExpShipperDevivery> items = new List<GExpShipperDevivery>();
				GExpShipperDevivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipperDevivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ShipperId"] != null && dr["ShipperId"] != DBNull.Value)
					{
						item.ShipperId = Convert.ToString(dr["ShipperId"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["SignDate"] != null && dr["SignDate"] != DBNull.Value)
					{
						item.SignDate = Convert.ToDateTime(dr["SignDate"]);
					}
					if (dr["TotalCOD"] != null && dr["TotalCOD"] != DBNull.Value)
					{
						item.TotalCOD = Convert.ToDecimal(dr["TotalCOD"]);
					}
					if (dr["IsCash"] != null && dr["IsCash"] != DBNull.Value)
					{
						item.IsCash = Convert.ToBoolean(dr["IsCash"]);
					}
					if (dr["CashTime"] != null && dr["CashTime"] != DBNull.Value)
					{
						item.CashTime = Convert.ToDateTime(dr["CashTime"]);
					}
					if (dr["FK_AccountCash"] != null && dr["FK_AccountCash"] != DBNull.Value)
					{
						item.FK_AccountCash = Convert.ToString(dr["FK_AccountCash"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_CashId"] != null && dr["FK_CashId"] != DBNull.Value)
					{
						item.FK_CashId = Convert.ToString(dr["FK_CashId"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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

		public List<GExpShipperDevivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipperDevivery] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpShipperDevivery] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpShipperDevivery>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpShipperDevivery từ Database
		/// </summary>
		public GExpShipperDevivery GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperDevivery] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpShipperDevivery item=new GExpShipperDevivery();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ShipperId"] != null && dr["ShipperId"] != DBNull.Value)
						{
							item.ShipperId = Convert.ToString(dr["ShipperId"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["SignDate"] != null && dr["SignDate"] != DBNull.Value)
						{
							item.SignDate = Convert.ToDateTime(dr["SignDate"]);
						}
						if (dr["TotalCOD"] != null && dr["TotalCOD"] != DBNull.Value)
						{
							item.TotalCOD = Convert.ToDecimal(dr["TotalCOD"]);
						}
						if (dr["IsCash"] != null && dr["IsCash"] != DBNull.Value)
						{
							item.IsCash = Convert.ToBoolean(dr["IsCash"]);
						}
						if (dr["CashTime"] != null && dr["CashTime"] != DBNull.Value)
						{
							item.CashTime = Convert.ToDateTime(dr["CashTime"]);
						}
						if (dr["FK_AccountCash"] != null && dr["FK_AccountCash"] != DBNull.Value)
						{
							item.FK_AccountCash = Convert.ToString(dr["FK_AccountCash"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["FK_CashId"] != null && dr["FK_CashId"] != DBNull.Value)
						{
							item.FK_CashId = Convert.ToString(dr["FK_CashId"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
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
		/// Lấy một GExpShipperDevivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpShipperDevivery GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipperDevivery] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpShipperDevivery item=new GExpShipperDevivery();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ShipperId"] != null && dr["ShipperId"] != DBNull.Value)
						{
							item.ShipperId = Convert.ToString(dr["ShipperId"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["SignDate"] != null && dr["SignDate"] != DBNull.Value)
						{
							item.SignDate = Convert.ToDateTime(dr["SignDate"]);
						}
						if (dr["TotalCOD"] != null && dr["TotalCOD"] != DBNull.Value)
						{
							item.TotalCOD = Convert.ToDecimal(dr["TotalCOD"]);
						}
						if (dr["IsCash"] != null && dr["IsCash"] != DBNull.Value)
						{
							item.IsCash = Convert.ToBoolean(dr["IsCash"]);
						}
						if (dr["CashTime"] != null && dr["CashTime"] != DBNull.Value)
						{
							item.CashTime = Convert.ToDateTime(dr["CashTime"]);
						}
						if (dr["FK_AccountCash"] != null && dr["FK_AccountCash"] != DBNull.Value)
						{
							item.FK_AccountCash = Convert.ToString(dr["FK_AccountCash"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["FK_CashId"] != null && dr["FK_CashId"] != DBNull.Value)
						{
							item.FK_CashId = Convert.ToString(dr["FK_CashId"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
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

		public GExpShipperDevivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipperDevivery] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpShipperDevivery>(ds);
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
		/// Thêm mới GExpShipperDevivery vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpShipperDevivery _GExpShipperDevivery)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpShipperDevivery](Id, ShipperId, BillCode, SignDate, TotalCOD, IsCash, CashTime, FK_AccountCash, Note, FK_CashId, FK_Post) VALUES(@Id, @ShipperId, @BillCode, @SignDate, @TotalCOD, @IsCash, @CashTime, @FK_AccountCash, @Note, @FK_CashId, @FK_Post)", 
					"@Id",  _GExpShipperDevivery.Id, 
					"@ShipperId",  _GExpShipperDevivery.ShipperId, 
					"@BillCode",  _GExpShipperDevivery.BillCode, 
					"@SignDate", this._dataContext.ConvertDateString( _GExpShipperDevivery.SignDate), 
					"@TotalCOD",  _GExpShipperDevivery.TotalCOD, 
					"@IsCash",  _GExpShipperDevivery.IsCash, 
					"@CashTime", this._dataContext.ConvertDateString( _GExpShipperDevivery.CashTime), 
					"@FK_AccountCash",  _GExpShipperDevivery.FK_AccountCash, 
					"@Note",  _GExpShipperDevivery.Note, 
					"@FK_CashId",  _GExpShipperDevivery.FK_CashId, 
					"@FK_Post",  _GExpShipperDevivery.FK_Post);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpShipperDevivery vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpShipperDevivery> _GExpShipperDeviverys)
		{
			foreach (GExpShipperDevivery item in _GExpShipperDeviverys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperDevivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpShipperDevivery _GExpShipperDevivery, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperDevivery] SET Id=@Id, ShipperId=@ShipperId, BillCode=@BillCode, SignDate=@SignDate, TotalCOD=@TotalCOD, IsCash=@IsCash, CashTime=@CashTime, FK_AccountCash=@FK_AccountCash, Note=@Note, FK_CashId=@FK_CashId, FK_Post=@FK_Post WHERE Id=@Id", 
					"@Id",  _GExpShipperDevivery.Id, 
					"@ShipperId",  _GExpShipperDevivery.ShipperId, 
					"@BillCode",  _GExpShipperDevivery.BillCode, 
					"@SignDate", this._dataContext.ConvertDateString( _GExpShipperDevivery.SignDate), 
					"@TotalCOD",  _GExpShipperDevivery.TotalCOD, 
					"@IsCash",  _GExpShipperDevivery.IsCash, 
					"@CashTime", this._dataContext.ConvertDateString( _GExpShipperDevivery.CashTime), 
					"@FK_AccountCash",  _GExpShipperDevivery.FK_AccountCash, 
					"@Note",  _GExpShipperDevivery.Note, 
					"@FK_CashId",  _GExpShipperDevivery.FK_CashId, 
					"@FK_Post",  _GExpShipperDevivery.FK_Post, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperDevivery vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpShipperDevivery _GExpShipperDevivery)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperDevivery] SET ShipperId=@ShipperId, BillCode=@BillCode, SignDate=@SignDate, TotalCOD=@TotalCOD, IsCash=@IsCash, CashTime=@CashTime, FK_AccountCash=@FK_AccountCash, Note=@Note, FK_CashId=@FK_CashId, FK_Post=@FK_Post WHERE Id=@Id", 
					"@ShipperId",  _GExpShipperDevivery.ShipperId, 
					"@BillCode",  _GExpShipperDevivery.BillCode, 
					"@SignDate", this._dataContext.ConvertDateString( _GExpShipperDevivery.SignDate), 
					"@TotalCOD",  _GExpShipperDevivery.TotalCOD, 
					"@IsCash",  _GExpShipperDevivery.IsCash, 
					"@CashTime", this._dataContext.ConvertDateString( _GExpShipperDevivery.CashTime), 
					"@FK_AccountCash",  _GExpShipperDevivery.FK_AccountCash, 
					"@Note",  _GExpShipperDevivery.Note, 
					"@FK_CashId",  _GExpShipperDevivery.FK_CashId, 
					"@FK_Post",  _GExpShipperDevivery.FK_Post, 
					"@Id", _GExpShipperDevivery.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpShipperDevivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpShipperDevivery> _GExpShipperDeviverys)
		{
			foreach (GExpShipperDevivery item in _GExpShipperDeviverys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperDevivery vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpShipperDevivery _GExpShipperDevivery, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperDevivery] SET Id=@Id, ShipperId=@ShipperId, BillCode=@BillCode, SignDate=@SignDate, TotalCOD=@TotalCOD, IsCash=@IsCash, CashTime=@CashTime, FK_AccountCash=@FK_AccountCash, Note=@Note, FK_CashId=@FK_CashId, FK_Post=@FK_Post "+ condition, 
					"@Id",  _GExpShipperDevivery.Id, 
					"@ShipperId",  _GExpShipperDevivery.ShipperId, 
					"@BillCode",  _GExpShipperDevivery.BillCode, 
					"@SignDate", this._dataContext.ConvertDateString( _GExpShipperDevivery.SignDate), 
					"@TotalCOD",  _GExpShipperDevivery.TotalCOD, 
					"@IsCash",  _GExpShipperDevivery.IsCash, 
					"@CashTime", this._dataContext.ConvertDateString( _GExpShipperDevivery.CashTime), 
					"@FK_AccountCash",  _GExpShipperDevivery.FK_AccountCash, 
					"@Note",  _GExpShipperDevivery.Note, 
					"@FK_CashId",  _GExpShipperDevivery.FK_CashId, 
					"@FK_Post",  _GExpShipperDevivery.FK_Post);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpShipperDevivery trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperDevivery] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperDevivery trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpShipperDevivery _GExpShipperDevivery)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperDevivery] WHERE Id=@Id",
					"@Id", _GExpShipperDevivery.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperDevivery trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperDevivery] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperDevivery trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpShipperDevivery> _GExpShipperDeviverys)
		{
			foreach (GExpShipperDevivery item in _GExpShipperDeviverys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
