using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpscantt:IEXpscantt
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpscantt(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpScanTT từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpScanTT]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpScanTT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpScanTT] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpScanTT từ Database
		/// </summary>
		public List<ExpScanTT> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpScanTT]");
				List<ExpScanTT> items = new List<ExpScanTT>();
				ExpScanTT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpScanTT();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["ScanDate"] != null && dr["ScanDate"] != DBNull.Value)
					{
						item.ScanDate = Convert.ToDateTime(dr["ScanDate"]);
					}
					if (dr["ToSite"] != null && dr["ToSite"] != DBNull.Value)
					{
						item.ToSite = Convert.ToString(dr["ToSite"]);
					}
					if (dr["FromSite"] != null && dr["FromSite"] != DBNull.Value)
					{
						item.FromSite = Convert.ToString(dr["FromSite"]);
					}
					if (dr["BillSite"] != null && dr["BillSite"] != DBNull.Value)
					{
						item.BillSite = Convert.ToString(dr["BillSite"]);
					}
					if (dr["ScanManCode"] != null && dr["ScanManCode"] != DBNull.Value)
					{
						item.ScanManCode = Convert.ToString(dr["ScanManCode"]);
					}
					if (dr["ErrorMessage"] != null && dr["ErrorMessage"] != DBNull.Value)
					{
						item.ErrorMessage = Convert.ToString(dr["ErrorMessage"]);
					}
					if (dr["IsUpdate"] != null && dr["IsUpdate"] != DBNull.Value)
					{
						item.IsUpdate = Convert.ToBoolean(dr["IsUpdate"]);
					}
					if (dr["ChangeSiteCode"] != null && dr["ChangeSiteCode"] != DBNull.Value)
					{
						item.ChangeSiteCode = Convert.ToString(dr["ChangeSiteCode"]);
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
		/// Lấy danh sách ExpScanTT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpScanTT> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpScanTT] A "+ condition,  parameters);
				List<ExpScanTT> items = new List<ExpScanTT>();
				ExpScanTT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpScanTT();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["ScanDate"] != null && dr["ScanDate"] != DBNull.Value)
					{
						item.ScanDate = Convert.ToDateTime(dr["ScanDate"]);
					}
					if (dr["ToSite"] != null && dr["ToSite"] != DBNull.Value)
					{
						item.ToSite = Convert.ToString(dr["ToSite"]);
					}
					if (dr["FromSite"] != null && dr["FromSite"] != DBNull.Value)
					{
						item.FromSite = Convert.ToString(dr["FromSite"]);
					}
					if (dr["BillSite"] != null && dr["BillSite"] != DBNull.Value)
					{
						item.BillSite = Convert.ToString(dr["BillSite"]);
					}
					if (dr["ScanManCode"] != null && dr["ScanManCode"] != DBNull.Value)
					{
						item.ScanManCode = Convert.ToString(dr["ScanManCode"]);
					}
					if (dr["ErrorMessage"] != null && dr["ErrorMessage"] != DBNull.Value)
					{
						item.ErrorMessage = Convert.ToString(dr["ErrorMessage"]);
					}
					if (dr["IsUpdate"] != null && dr["IsUpdate"] != DBNull.Value)
					{
						item.IsUpdate = Convert.ToBoolean(dr["IsUpdate"]);
					}
					if (dr["ChangeSiteCode"] != null && dr["ChangeSiteCode"] != DBNull.Value)
					{
						item.ChangeSiteCode = Convert.ToString(dr["ChangeSiteCode"]);
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

		public List<ExpScanTT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpScanTT] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpScanTT] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpScanTT>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpScanTT từ Database
		/// </summary>
		public ExpScanTT GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpScanTT] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpScanTT item=new ExpScanTT();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["ScanDate"] != null && dr["ScanDate"] != DBNull.Value)
						{
							item.ScanDate = Convert.ToDateTime(dr["ScanDate"]);
						}
						if (dr["ToSite"] != null && dr["ToSite"] != DBNull.Value)
						{
							item.ToSite = Convert.ToString(dr["ToSite"]);
						}
						if (dr["FromSite"] != null && dr["FromSite"] != DBNull.Value)
						{
							item.FromSite = Convert.ToString(dr["FromSite"]);
						}
						if (dr["BillSite"] != null && dr["BillSite"] != DBNull.Value)
						{
							item.BillSite = Convert.ToString(dr["BillSite"]);
						}
						if (dr["ScanManCode"] != null && dr["ScanManCode"] != DBNull.Value)
						{
							item.ScanManCode = Convert.ToString(dr["ScanManCode"]);
						}
						if (dr["ErrorMessage"] != null && dr["ErrorMessage"] != DBNull.Value)
						{
							item.ErrorMessage = Convert.ToString(dr["ErrorMessage"]);
						}
						if (dr["IsUpdate"] != null && dr["IsUpdate"] != DBNull.Value)
						{
							item.IsUpdate = Convert.ToBoolean(dr["IsUpdate"]);
						}
						if (dr["ChangeSiteCode"] != null && dr["ChangeSiteCode"] != DBNull.Value)
						{
							item.ChangeSiteCode = Convert.ToString(dr["ChangeSiteCode"]);
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
		/// Lấy một ExpScanTT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpScanTT GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpScanTT] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpScanTT item=new ExpScanTT();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["ScanDate"] != null && dr["ScanDate"] != DBNull.Value)
						{
							item.ScanDate = Convert.ToDateTime(dr["ScanDate"]);
						}
						if (dr["ToSite"] != null && dr["ToSite"] != DBNull.Value)
						{
							item.ToSite = Convert.ToString(dr["ToSite"]);
						}
						if (dr["FromSite"] != null && dr["FromSite"] != DBNull.Value)
						{
							item.FromSite = Convert.ToString(dr["FromSite"]);
						}
						if (dr["BillSite"] != null && dr["BillSite"] != DBNull.Value)
						{
							item.BillSite = Convert.ToString(dr["BillSite"]);
						}
						if (dr["ScanManCode"] != null && dr["ScanManCode"] != DBNull.Value)
						{
							item.ScanManCode = Convert.ToString(dr["ScanManCode"]);
						}
						if (dr["ErrorMessage"] != null && dr["ErrorMessage"] != DBNull.Value)
						{
							item.ErrorMessage = Convert.ToString(dr["ErrorMessage"]);
						}
						if (dr["IsUpdate"] != null && dr["IsUpdate"] != DBNull.Value)
						{
							item.IsUpdate = Convert.ToBoolean(dr["IsUpdate"]);
						}
						if (dr["ChangeSiteCode"] != null && dr["ChangeSiteCode"] != DBNull.Value)
						{
							item.ChangeSiteCode = Convert.ToString(dr["ChangeSiteCode"]);
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

		public ExpScanTT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpScanTT] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpScanTT>(ds);
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
		/// Thêm mới ExpScanTT vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpScanTT _ExpScanTT)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpScanTT](Id, BillCode, ScanDate, ToSite, FromSite, BillSite, ScanManCode, ErrorMessage, IsUpdate, ChangeSiteCode) VALUES(@Id, @BillCode, @ScanDate, @ToSite, @FromSite, @BillSite, @ScanManCode, @ErrorMessage, @IsUpdate, @ChangeSiteCode)", 
					"@Id",  _ExpScanTT.Id, 
					"@BillCode",  _ExpScanTT.BillCode, 
					"@ScanDate", this._dataContext.ConvertDateString( _ExpScanTT.ScanDate), 
					"@ToSite",  _ExpScanTT.ToSite, 
					"@FromSite",  _ExpScanTT.FromSite, 
					"@BillSite",  _ExpScanTT.BillSite, 
					"@ScanManCode",  _ExpScanTT.ScanManCode, 
					"@ErrorMessage",  _ExpScanTT.ErrorMessage, 
					"@IsUpdate",  _ExpScanTT.IsUpdate, 
					"@ChangeSiteCode",  _ExpScanTT.ChangeSiteCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpScanTT vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpScanTT> _ExpScanTTs)
		{
			foreach (ExpScanTT item in _ExpScanTTs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpScanTT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpScanTT _ExpScanTT, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpScanTT] SET Id=@Id, BillCode=@BillCode, ScanDate=@ScanDate, ToSite=@ToSite, FromSite=@FromSite, BillSite=@BillSite, ScanManCode=@ScanManCode, ErrorMessage=@ErrorMessage, IsUpdate=@IsUpdate, ChangeSiteCode=@ChangeSiteCode WHERE Id=@Id", 
					"@Id",  _ExpScanTT.Id, 
					"@BillCode",  _ExpScanTT.BillCode, 
					"@ScanDate", this._dataContext.ConvertDateString( _ExpScanTT.ScanDate), 
					"@ToSite",  _ExpScanTT.ToSite, 
					"@FromSite",  _ExpScanTT.FromSite, 
					"@BillSite",  _ExpScanTT.BillSite, 
					"@ScanManCode",  _ExpScanTT.ScanManCode, 
					"@ErrorMessage",  _ExpScanTT.ErrorMessage, 
					"@IsUpdate",  _ExpScanTT.IsUpdate, 
					"@ChangeSiteCode",  _ExpScanTT.ChangeSiteCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpScanTT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpScanTT _ExpScanTT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpScanTT] SET BillCode=@BillCode, ScanDate=@ScanDate, ToSite=@ToSite, FromSite=@FromSite, BillSite=@BillSite, ScanManCode=@ScanManCode, ErrorMessage=@ErrorMessage, IsUpdate=@IsUpdate, ChangeSiteCode=@ChangeSiteCode WHERE Id=@Id", 
					"@BillCode",  _ExpScanTT.BillCode, 
					"@ScanDate", this._dataContext.ConvertDateString( _ExpScanTT.ScanDate), 
					"@ToSite",  _ExpScanTT.ToSite, 
					"@FromSite",  _ExpScanTT.FromSite, 
					"@BillSite",  _ExpScanTT.BillSite, 
					"@ScanManCode",  _ExpScanTT.ScanManCode, 
					"@ErrorMessage",  _ExpScanTT.ErrorMessage, 
					"@IsUpdate",  _ExpScanTT.IsUpdate, 
					"@ChangeSiteCode",  _ExpScanTT.ChangeSiteCode, 
					"@Id", _ExpScanTT.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpScanTT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpScanTT> _ExpScanTTs)
		{
			foreach (ExpScanTT item in _ExpScanTTs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpScanTT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpScanTT _ExpScanTT, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpScanTT] SET Id=@Id, BillCode=@BillCode, ScanDate=@ScanDate, ToSite=@ToSite, FromSite=@FromSite, BillSite=@BillSite, ScanManCode=@ScanManCode, ErrorMessage=@ErrorMessage, IsUpdate=@IsUpdate, ChangeSiteCode=@ChangeSiteCode "+ condition, 
					"@Id",  _ExpScanTT.Id, 
					"@BillCode",  _ExpScanTT.BillCode, 
					"@ScanDate", this._dataContext.ConvertDateString( _ExpScanTT.ScanDate), 
					"@ToSite",  _ExpScanTT.ToSite, 
					"@FromSite",  _ExpScanTT.FromSite, 
					"@BillSite",  _ExpScanTT.BillSite, 
					"@ScanManCode",  _ExpScanTT.ScanManCode, 
					"@ErrorMessage",  _ExpScanTT.ErrorMessage, 
					"@IsUpdate",  _ExpScanTT.IsUpdate, 
					"@ChangeSiteCode",  _ExpScanTT.ChangeSiteCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpScanTT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpScanTT] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpScanTT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpScanTT _ExpScanTT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpScanTT] WHERE Id=@Id",
					"@Id", _ExpScanTT.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpScanTT trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpScanTT] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpScanTT trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpScanTT> _ExpScanTTs)
		{
			foreach (ExpScanTT item in _ExpScanTTs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
