using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcheckbalance:IEXpcheckbalance
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcheckbalance(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCheckBalance từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCheckBalance]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCheckBalance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCheckBalance] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCheckBalance từ Database
		/// </summary>
		public List<ExpCheckBalance> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCheckBalance]");
				List<ExpCheckBalance> items = new List<ExpCheckBalance>();
				ExpCheckBalance item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCheckBalance();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["CurMoney"] != null && dr["CurMoney"] != DBNull.Value)
					{
						item.CurMoney = Convert.ToDecimal(dr["CurMoney"]);
					}
					if (dr["CheckDate"] != null && dr["CheckDate"] != DBNull.Value)
					{
						item.CheckDate = Convert.ToDateTime(dr["CheckDate"]);
					}
					if (dr["DiffMoney"] != null && dr["DiffMoney"] != DBNull.Value)
					{
						item.DiffMoney = Convert.ToDecimal(dr["DiffMoney"]);
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
		/// Lấy danh sách ExpCheckBalance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCheckBalance> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCheckBalance] A "+ condition,  parameters);
				List<ExpCheckBalance> items = new List<ExpCheckBalance>();
				ExpCheckBalance item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCheckBalance();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["CurMoney"] != null && dr["CurMoney"] != DBNull.Value)
					{
						item.CurMoney = Convert.ToDecimal(dr["CurMoney"]);
					}
					if (dr["CheckDate"] != null && dr["CheckDate"] != DBNull.Value)
					{
						item.CheckDate = Convert.ToDateTime(dr["CheckDate"]);
					}
					if (dr["DiffMoney"] != null && dr["DiffMoney"] != DBNull.Value)
					{
						item.DiffMoney = Convert.ToDecimal(dr["DiffMoney"]);
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

		public List<ExpCheckBalance> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCheckBalance] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCheckBalance] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCheckBalance>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCheckBalance từ Database
		/// </summary>
		public ExpCheckBalance GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCheckBalance] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpCheckBalance item=new ExpCheckBalance();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
						}
						if (dr["CurMoney"] != null && dr["CurMoney"] != DBNull.Value)
						{
							item.CurMoney = Convert.ToDecimal(dr["CurMoney"]);
						}
						if (dr["CheckDate"] != null && dr["CheckDate"] != DBNull.Value)
						{
							item.CheckDate = Convert.ToDateTime(dr["CheckDate"]);
						}
						if (dr["DiffMoney"] != null && dr["DiffMoney"] != DBNull.Value)
						{
							item.DiffMoney = Convert.ToDecimal(dr["DiffMoney"]);
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
		/// Lấy một ExpCheckBalance đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCheckBalance GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCheckBalance] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCheckBalance item=new ExpCheckBalance();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
						}
						if (dr["CurMoney"] != null && dr["CurMoney"] != DBNull.Value)
						{
							item.CurMoney = Convert.ToDecimal(dr["CurMoney"]);
						}
						if (dr["CheckDate"] != null && dr["CheckDate"] != DBNull.Value)
						{
							item.CheckDate = Convert.ToDateTime(dr["CheckDate"]);
						}
						if (dr["DiffMoney"] != null && dr["DiffMoney"] != DBNull.Value)
						{
							item.DiffMoney = Convert.ToDecimal(dr["DiffMoney"]);
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

		public ExpCheckBalance GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCheckBalance] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCheckBalance>(ds);
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
		/// Thêm mới ExpCheckBalance vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCheckBalance _ExpCheckBalance)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCheckBalance](Id, Post, CurMoney, CheckDate, DiffMoney) VALUES(@Id, @Post, @CurMoney, @CheckDate, @DiffMoney)", 
					"@Id",  _ExpCheckBalance.Id, 
					"@Post",  _ExpCheckBalance.Post, 
					"@CurMoney",  _ExpCheckBalance.CurMoney, 
					"@CheckDate", this._dataContext.ConvertDateString( _ExpCheckBalance.CheckDate), 
					"@DiffMoney",  _ExpCheckBalance.DiffMoney);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCheckBalance vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCheckBalance> _ExpCheckBalances)
		{
			foreach (ExpCheckBalance item in _ExpCheckBalances)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCheckBalance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCheckBalance _ExpCheckBalance, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCheckBalance] SET Id=@Id, Post=@Post, CurMoney=@CurMoney, CheckDate=@CheckDate, DiffMoney=@DiffMoney WHERE Id=@Id", 
					"@Id",  _ExpCheckBalance.Id, 
					"@Post",  _ExpCheckBalance.Post, 
					"@CurMoney",  _ExpCheckBalance.CurMoney, 
					"@CheckDate", this._dataContext.ConvertDateString( _ExpCheckBalance.CheckDate), 
					"@DiffMoney",  _ExpCheckBalance.DiffMoney, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCheckBalance vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCheckBalance _ExpCheckBalance)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCheckBalance] SET Post=@Post, CurMoney=@CurMoney, CheckDate=@CheckDate, DiffMoney=@DiffMoney WHERE Id=@Id", 
					"@Post",  _ExpCheckBalance.Post, 
					"@CurMoney",  _ExpCheckBalance.CurMoney, 
					"@CheckDate", this._dataContext.ConvertDateString( _ExpCheckBalance.CheckDate), 
					"@DiffMoney",  _ExpCheckBalance.DiffMoney, 
					"@Id", _ExpCheckBalance.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCheckBalance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCheckBalance> _ExpCheckBalances)
		{
			foreach (ExpCheckBalance item in _ExpCheckBalances)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCheckBalance vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCheckBalance _ExpCheckBalance, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCheckBalance] SET Id=@Id, Post=@Post, CurMoney=@CurMoney, CheckDate=@CheckDate, DiffMoney=@DiffMoney "+ condition, 
					"@Id",  _ExpCheckBalance.Id, 
					"@Post",  _ExpCheckBalance.Post, 
					"@CurMoney",  _ExpCheckBalance.CurMoney, 
					"@CheckDate", this._dataContext.ConvertDateString( _ExpCheckBalance.CheckDate), 
					"@DiffMoney",  _ExpCheckBalance.DiffMoney);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCheckBalance trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCheckBalance] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCheckBalance trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCheckBalance _ExpCheckBalance)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCheckBalance] WHERE Id=@Id",
					"@Id", _ExpCheckBalance.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCheckBalance trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCheckBalance] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCheckBalance trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCheckBalance> _ExpCheckBalances)
		{
			foreach (ExpCheckBalance item in _ExpCheckBalances)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
