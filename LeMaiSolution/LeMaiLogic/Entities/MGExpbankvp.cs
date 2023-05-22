using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpbankvp:IGExpbankvp
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpbankvp(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpBankVP từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBankVP]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpBankVP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBankVP] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpBankVP từ Database
		/// </summary>
		public List<GExpBankVP> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBankVP]");
				List<GExpBankVP> items = new List<GExpBankVP>();
				GExpBankVP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBankVP();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
					{
						item.BankCode = Convert.ToString(dr["BankCode"]);
					}
					if (dr["BankId"] != null && dr["BankId"] != DBNull.Value)
					{
						item.BankId = Convert.ToInt32(dr["BankId"]);
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
		/// Lấy danh sách GExpBankVP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpBankVP> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBankVP] A "+ condition,  parameters);
				List<GExpBankVP> items = new List<GExpBankVP>();
				GExpBankVP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBankVP();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
					{
						item.BankCode = Convert.ToString(dr["BankCode"]);
					}
					if (dr["BankId"] != null && dr["BankId"] != DBNull.Value)
					{
						item.BankId = Convert.ToInt32(dr["BankId"]);
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

		public List<GExpBankVP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBankVP] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpBankVP] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpBankVP>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpBankVP từ Database
		/// </summary>
		public GExpBankVP GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBankVP] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpBankVP item=new GExpBankVP();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
						{
							item.BankName = Convert.ToString(dr["BankName"]);
						}
						if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
						{
							item.BankCode = Convert.ToString(dr["BankCode"]);
						}
						if (dr["BankId"] != null && dr["BankId"] != DBNull.Value)
						{
							item.BankId = Convert.ToInt32(dr["BankId"]);
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
		/// Lấy một GExpBankVP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpBankVP GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBankVP] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpBankVP item=new GExpBankVP();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
						{
							item.BankName = Convert.ToString(dr["BankName"]);
						}
						if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
						{
							item.BankCode = Convert.ToString(dr["BankCode"]);
						}
						if (dr["BankId"] != null && dr["BankId"] != DBNull.Value)
						{
							item.BankId = Convert.ToInt32(dr["BankId"]);
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

		public GExpBankVP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBankVP] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpBankVP>(ds);
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
		/// Thêm mới GExpBankVP vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpBankVP _GExpBankVP)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpBankVP](Id, BankName, BankCode, BankId) VALUES(@Id, @BankName, @BankCode, @BankId)", 
					"@Id",  _GExpBankVP.Id, 
					"@BankName",  _GExpBankVP.BankName, 
					"@BankCode",  _GExpBankVP.BankCode, 
					"@BankId",  _GExpBankVP.BankId);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpBankVP vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpBankVP> _GExpBankVPs)
		{
			foreach (GExpBankVP item in _GExpBankVPs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBankVP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpBankVP _GExpBankVP, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBankVP] SET Id=@Id, BankName=@BankName, BankCode=@BankCode, BankId=@BankId WHERE Id=@Id", 
					"@Id",  _GExpBankVP.Id, 
					"@BankName",  _GExpBankVP.BankName, 
					"@BankCode",  _GExpBankVP.BankCode, 
					"@BankId",  _GExpBankVP.BankId, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpBankVP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpBankVP _GExpBankVP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBankVP] SET BankName=@BankName, BankCode=@BankCode, BankId=@BankId WHERE Id=@Id", 
					"@BankName",  _GExpBankVP.BankName, 
					"@BankCode",  _GExpBankVP.BankCode, 
					"@BankId",  _GExpBankVP.BankId, 
					"@Id", _GExpBankVP.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpBankVP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpBankVP> _GExpBankVPs)
		{
			foreach (GExpBankVP item in _GExpBankVPs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBankVP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpBankVP _GExpBankVP, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBankVP] SET Id=@Id, BankName=@BankName, BankCode=@BankCode, BankId=@BankId "+ condition, 
					"@Id",  _GExpBankVP.Id, 
					"@BankName",  _GExpBankVP.BankName, 
					"@BankCode",  _GExpBankVP.BankCode, 
					"@BankId",  _GExpBankVP.BankId);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpBankVP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBankVP] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBankVP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpBankVP _GExpBankVP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBankVP] WHERE Id=@Id",
					"@Id", _GExpBankVP.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBankVP trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBankVP] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBankVP trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpBankVP> _GExpBankVPs)
		{
			foreach (GExpBankVP item in _GExpBankVPs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
