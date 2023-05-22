using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcodck:IEXpcodck
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcodck(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCODCK từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCODCK]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCODCK từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCODCK] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCODCK từ Database
		/// </summary>
		public List<ExpCODCK> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCODCK]");
				List<ExpCODCK> items = new List<ExpCODCK>();
				ExpCODCK item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCODCK();
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["SoTienCKCOD"] != null && dr["SoTienCKCOD"] != DBNull.Value)
					{
						item.SoTienCKCOD = Convert.ToInt32(dr["SoTienCKCOD"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy danh sách ExpCODCK từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCODCK> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCODCK] A "+ condition,  parameters);
				List<ExpCODCK> items = new List<ExpCODCK>();
				ExpCODCK item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCODCK();
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["SoTienCKCOD"] != null && dr["SoTienCKCOD"] != DBNull.Value)
					{
						item.SoTienCKCOD = Convert.ToInt32(dr["SoTienCKCOD"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public List<ExpCODCK> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCODCK] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCODCK] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCODCK>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCODCK từ Database
		/// </summary>
		public ExpCODCK GetObject(string schema, String BILL_CODE)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCODCK] where BILL_CODE=@BILL_CODE",
					"@BILL_CODE", BILL_CODE);
				if (ds.Rows.Count > 0)
				{
					ExpCODCK item=new ExpCODCK();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["SoTienCKCOD"] != null && dr["SoTienCKCOD"] != DBNull.Value)
						{
							item.SoTienCKCOD = Convert.ToInt32(dr["SoTienCKCOD"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy một ExpCODCK đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCODCK GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCODCK] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCODCK item=new ExpCODCK();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["SoTienCKCOD"] != null && dr["SoTienCKCOD"] != DBNull.Value)
						{
							item.SoTienCKCOD = Convert.ToInt32(dr["SoTienCKCOD"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public ExpCODCK GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCODCK] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCODCK>(ds);
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
		/// Thêm mới ExpCODCK vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCODCK _ExpCODCK)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCODCK](BILL_CODE, SoTienCKCOD, FK_Post, FK_Account, CreateDate) VALUES(@BILL_CODE, @SoTienCKCOD, @FK_Post, @FK_Account, @CreateDate)", 
					"@BILL_CODE",  _ExpCODCK.BILL_CODE, 
					"@SoTienCKCOD",  _ExpCODCK.SoTienCKCOD, 
					"@FK_Post",  _ExpCODCK.FK_Post, 
					"@FK_Account",  _ExpCODCK.FK_Account, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCODCK.CreateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCODCK vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCODCK> _ExpCODCKs)
		{
			foreach (ExpCODCK item in _ExpCODCKs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCODCK vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCODCK _ExpCODCK, String BILL_CODE)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCODCK] SET BILL_CODE=@BILL_CODE, SoTienCKCOD=@SoTienCKCOD, FK_Post=@FK_Post, FK_Account=@FK_Account, CreateDate=@CreateDate WHERE BILL_CODE=@BILL_CODE", 
					"@BILL_CODE",  _ExpCODCK.BILL_CODE, 
					"@SoTienCKCOD",  _ExpCODCK.SoTienCKCOD, 
					"@FK_Post",  _ExpCODCK.FK_Post, 
					"@FK_Account",  _ExpCODCK.FK_Account, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCODCK.CreateDate), 
					"@BILL_CODE", BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCODCK vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCODCK _ExpCODCK)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCODCK] SET SoTienCKCOD=@SoTienCKCOD, FK_Post=@FK_Post, FK_Account=@FK_Account, CreateDate=@CreateDate WHERE BILL_CODE=@BILL_CODE", 
					"@SoTienCKCOD",  _ExpCODCK.SoTienCKCOD, 
					"@FK_Post",  _ExpCODCK.FK_Post, 
					"@FK_Account",  _ExpCODCK.FK_Account, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCODCK.CreateDate), 
					"@BILL_CODE", _ExpCODCK.BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCODCK vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCODCK> _ExpCODCKs)
		{
			foreach (ExpCODCK item in _ExpCODCKs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCODCK vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCODCK _ExpCODCK, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCODCK] SET BILL_CODE=@BILL_CODE, SoTienCKCOD=@SoTienCKCOD, FK_Post=@FK_Post, FK_Account=@FK_Account, CreateDate=@CreateDate "+ condition, 
					"@BILL_CODE",  _ExpCODCK.BILL_CODE, 
					"@SoTienCKCOD",  _ExpCODCK.SoTienCKCOD, 
					"@FK_Post",  _ExpCODCK.FK_Post, 
					"@FK_Account",  _ExpCODCK.FK_Account, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCODCK.CreateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCODCK trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BILL_CODE)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCODCK] WHERE BILL_CODE=@BILL_CODE",
					"@BILL_CODE", BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCODCK trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCODCK _ExpCODCK)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCODCK] WHERE BILL_CODE=@BILL_CODE",
					"@BILL_CODE", _ExpCODCK.BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCODCK trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCODCK] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCODCK trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCODCK> _ExpCODCKs)
		{
			foreach (ExpCODCK item in _ExpCODCKs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
