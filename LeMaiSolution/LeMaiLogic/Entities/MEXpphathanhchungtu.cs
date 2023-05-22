using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpphathanhchungtu:IEXpphathanhchungtu
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpphathanhchungtu(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpPhatHanhChungTu từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPhatHanhChungTu]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpPhatHanhChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPhatHanhChungTu] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpPhatHanhChungTu từ Database
		/// </summary>
		public List<ExpPhatHanhChungTu> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPhatHanhChungTu]");
				List<ExpPhatHanhChungTu> items = new List<ExpPhatHanhChungTu>();
				ExpPhatHanhChungTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpPhatHanhChungTu();
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["FK_ChungTuCT"] != null && dr["FK_ChungTuCT"] != DBNull.Value)
					{
						item.FK_ChungTuCT = Convert.ToString(dr["FK_ChungTuCT"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
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
		/// Lấy danh sách ExpPhatHanhChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpPhatHanhChungTu> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpPhatHanhChungTu] A "+ condition,  parameters);
				List<ExpPhatHanhChungTu> items = new List<ExpPhatHanhChungTu>();
				ExpPhatHanhChungTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpPhatHanhChungTu();
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["FK_ChungTuCT"] != null && dr["FK_ChungTuCT"] != DBNull.Value)
					{
						item.FK_ChungTuCT = Convert.ToString(dr["FK_ChungTuCT"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
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

		public List<ExpPhatHanhChungTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpPhatHanhChungTu] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpPhatHanhChungTu] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpPhatHanhChungTu>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpPhatHanhChungTu từ Database
		/// </summary>
		public ExpPhatHanhChungTu GetObject(string schema, String BILL_CODE)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPhatHanhChungTu] where BILL_CODE=@BILL_CODE",
					"@BILL_CODE", BILL_CODE);
				if (ds.Rows.Count > 0)
				{
					ExpPhatHanhChungTu item=new ExpPhatHanhChungTu();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["FK_ChungTuCT"] != null && dr["FK_ChungTuCT"] != DBNull.Value)
						{
							item.FK_ChungTuCT = Convert.ToString(dr["FK_ChungTuCT"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
						{
							item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
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
		/// Lấy một ExpPhatHanhChungTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpPhatHanhChungTu GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpPhatHanhChungTu] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpPhatHanhChungTu item=new ExpPhatHanhChungTu();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["FK_ChungTuCT"] != null && dr["FK_ChungTuCT"] != DBNull.Value)
						{
							item.FK_ChungTuCT = Convert.ToString(dr["FK_ChungTuCT"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
						{
							item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
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

		public ExpPhatHanhChungTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpPhatHanhChungTu] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpPhatHanhChungTu>(ds);
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
		/// Thêm mới ExpPhatHanhChungTu vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpPhatHanhChungTu _ExpPhatHanhChungTu)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpPhatHanhChungTu](BILL_CODE, FK_ChungTuCT, CreateDate, FK_CreateBy) VALUES(@BILL_CODE, @FK_ChungTuCT, @CreateDate, @FK_CreateBy)", 
					"@BILL_CODE",  _ExpPhatHanhChungTu.BILL_CODE, 
					"@FK_ChungTuCT",  _ExpPhatHanhChungTu.FK_ChungTuCT, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPhatHanhChungTu.CreateDate), 
					"@FK_CreateBy",  _ExpPhatHanhChungTu.FK_CreateBy);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpPhatHanhChungTu vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpPhatHanhChungTu> _ExpPhatHanhChungTus)
		{
			foreach (ExpPhatHanhChungTu item in _ExpPhatHanhChungTus)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpPhatHanhChungTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpPhatHanhChungTu _ExpPhatHanhChungTu, String BILL_CODE)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPhatHanhChungTu] SET BILL_CODE=@BILL_CODE, FK_ChungTuCT=@FK_ChungTuCT, CreateDate=@CreateDate, FK_CreateBy=@FK_CreateBy WHERE BILL_CODE=@BILL_CODE", 
					"@BILL_CODE",  _ExpPhatHanhChungTu.BILL_CODE, 
					"@FK_ChungTuCT",  _ExpPhatHanhChungTu.FK_ChungTuCT, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPhatHanhChungTu.CreateDate), 
					"@FK_CreateBy",  _ExpPhatHanhChungTu.FK_CreateBy, 
					"@BILL_CODE", BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpPhatHanhChungTu vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpPhatHanhChungTu _ExpPhatHanhChungTu)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPhatHanhChungTu] SET FK_ChungTuCT=@FK_ChungTuCT, CreateDate=@CreateDate, FK_CreateBy=@FK_CreateBy WHERE BILL_CODE=@BILL_CODE", 
					"@FK_ChungTuCT",  _ExpPhatHanhChungTu.FK_ChungTuCT, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPhatHanhChungTu.CreateDate), 
					"@FK_CreateBy",  _ExpPhatHanhChungTu.FK_CreateBy, 
					"@BILL_CODE", _ExpPhatHanhChungTu.BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpPhatHanhChungTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpPhatHanhChungTu> _ExpPhatHanhChungTus)
		{
			foreach (ExpPhatHanhChungTu item in _ExpPhatHanhChungTus)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpPhatHanhChungTu vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpPhatHanhChungTu _ExpPhatHanhChungTu, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPhatHanhChungTu] SET BILL_CODE=@BILL_CODE, FK_ChungTuCT=@FK_ChungTuCT, CreateDate=@CreateDate, FK_CreateBy=@FK_CreateBy "+ condition, 
					"@BILL_CODE",  _ExpPhatHanhChungTu.BILL_CODE, 
					"@FK_ChungTuCT",  _ExpPhatHanhChungTu.FK_ChungTuCT, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPhatHanhChungTu.CreateDate), 
					"@FK_CreateBy",  _ExpPhatHanhChungTu.FK_CreateBy);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpPhatHanhChungTu trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BILL_CODE)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPhatHanhChungTu] WHERE BILL_CODE=@BILL_CODE",
					"@BILL_CODE", BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPhatHanhChungTu trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpPhatHanhChungTu _ExpPhatHanhChungTu)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPhatHanhChungTu] WHERE BILL_CODE=@BILL_CODE",
					"@BILL_CODE", _ExpPhatHanhChungTu.BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPhatHanhChungTu trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPhatHanhChungTu] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPhatHanhChungTu trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpPhatHanhChungTu> _ExpPhatHanhChungTus)
		{
			foreach (ExpPhatHanhChungTu item in _ExpPhatHanhChungTus)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
