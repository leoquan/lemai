using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXppostfeeprovider:IEXppostfeeprovider
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXppostfeeprovider(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpPostFeeProvider từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPostFeeProvider]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpPostFeeProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPostFeeProvider] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpPostFeeProvider từ Database
		/// </summary>
		public List<ExpPostFeeProvider> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPostFeeProvider]");
				List<ExpPostFeeProvider> items = new List<ExpPostFeeProvider>();
				ExpPostFeeProvider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpPostFeeProvider();
					if (dr["FK_ExpProvider"] != null && dr["FK_ExpProvider"] != DBNull.Value)
					{
						item.FK_ExpProvider = Convert.ToString(dr["FK_ExpProvider"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["FK_ExpFee"] != null && dr["FK_ExpFee"] != DBNull.Value)
					{
						item.FK_ExpFee = Convert.ToString(dr["FK_ExpFee"]);
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
		/// Lấy danh sách ExpPostFeeProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpPostFeeProvider> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpPostFeeProvider] A "+ condition,  parameters);
				List<ExpPostFeeProvider> items = new List<ExpPostFeeProvider>();
				ExpPostFeeProvider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpPostFeeProvider();
					if (dr["FK_ExpProvider"] != null && dr["FK_ExpProvider"] != DBNull.Value)
					{
						item.FK_ExpProvider = Convert.ToString(dr["FK_ExpProvider"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["FK_ExpFee"] != null && dr["FK_ExpFee"] != DBNull.Value)
					{
						item.FK_ExpFee = Convert.ToString(dr["FK_ExpFee"]);
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

		public List<ExpPostFeeProvider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpPostFeeProvider] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpPostFeeProvider] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpPostFeeProvider>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpPostFeeProvider từ Database
		/// </summary>
		public ExpPostFeeProvider GetObject(string schema, String FK_ExpProvider, String FK_ExpPost)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPostFeeProvider] where FK_ExpProvider=@FK_ExpProvider and FK_ExpPost=@FK_ExpPost",
					"@FK_ExpProvider", FK_ExpProvider, 
					"@FK_ExpPost", FK_ExpPost);
				if (ds.Rows.Count > 0)
				{
					ExpPostFeeProvider item=new ExpPostFeeProvider();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_ExpProvider"] != null && dr["FK_ExpProvider"] != DBNull.Value)
						{
							item.FK_ExpProvider = Convert.ToString(dr["FK_ExpProvider"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["FK_ExpFee"] != null && dr["FK_ExpFee"] != DBNull.Value)
						{
							item.FK_ExpFee = Convert.ToString(dr["FK_ExpFee"]);
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
		/// Lấy một ExpPostFeeProvider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpPostFeeProvider GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpPostFeeProvider] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpPostFeeProvider item=new ExpPostFeeProvider();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_ExpProvider"] != null && dr["FK_ExpProvider"] != DBNull.Value)
						{
							item.FK_ExpProvider = Convert.ToString(dr["FK_ExpProvider"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["FK_ExpFee"] != null && dr["FK_ExpFee"] != DBNull.Value)
						{
							item.FK_ExpFee = Convert.ToString(dr["FK_ExpFee"]);
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

		public ExpPostFeeProvider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpPostFeeProvider] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpPostFeeProvider>(ds);
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
		/// Thêm mới ExpPostFeeProvider vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpPostFeeProvider _ExpPostFeeProvider)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpPostFeeProvider](FK_ExpProvider, FK_ExpPost, FK_ExpFee) VALUES(@FK_ExpProvider, @FK_ExpPost, @FK_ExpFee)", 
					"@FK_ExpProvider",  _ExpPostFeeProvider.FK_ExpProvider, 
					"@FK_ExpPost",  _ExpPostFeeProvider.FK_ExpPost, 
					"@FK_ExpFee",  _ExpPostFeeProvider.FK_ExpFee);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpPostFeeProvider vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpPostFeeProvider> _ExpPostFeeProviders)
		{
			foreach (ExpPostFeeProvider item in _ExpPostFeeProviders)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpPostFeeProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpPostFeeProvider _ExpPostFeeProvider, String FK_ExpProvider, String FK_ExpPost)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPostFeeProvider] SET FK_ExpProvider=@FK_ExpProvider, FK_ExpPost=@FK_ExpPost, FK_ExpFee=@FK_ExpFee WHERE FK_ExpProvider=@FK_ExpProvider and FK_ExpPost=@FK_ExpPost", 
					"@FK_ExpProvider",  _ExpPostFeeProvider.FK_ExpProvider, 
					"@FK_ExpPost",  _ExpPostFeeProvider.FK_ExpPost, 
					"@FK_ExpFee",  _ExpPostFeeProvider.FK_ExpFee, 
					"@FK_ExpProvider", FK_ExpProvider, 
					"@FK_ExpPost", FK_ExpPost);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpPostFeeProvider vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpPostFeeProvider _ExpPostFeeProvider)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPostFeeProvider] SET FK_ExpFee=@FK_ExpFee WHERE FK_ExpProvider=@FK_ExpProvider and FK_ExpPost=@FK_ExpPost", 
					"@FK_ExpFee",  _ExpPostFeeProvider.FK_ExpFee, 
					"@FK_ExpProvider", _ExpPostFeeProvider.FK_ExpProvider, 
					"@FK_ExpPost", _ExpPostFeeProvider.FK_ExpPost);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpPostFeeProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpPostFeeProvider> _ExpPostFeeProviders)
		{
			foreach (ExpPostFeeProvider item in _ExpPostFeeProviders)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpPostFeeProvider vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpPostFeeProvider _ExpPostFeeProvider, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPostFeeProvider] SET FK_ExpProvider=@FK_ExpProvider, FK_ExpPost=@FK_ExpPost, FK_ExpFee=@FK_ExpFee "+ condition, 
					"@FK_ExpProvider",  _ExpPostFeeProvider.FK_ExpProvider, 
					"@FK_ExpPost",  _ExpPostFeeProvider.FK_ExpPost, 
					"@FK_ExpFee",  _ExpPostFeeProvider.FK_ExpFee);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpPostFeeProvider trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_ExpProvider, String FK_ExpPost)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPostFeeProvider] WHERE FK_ExpProvider=@FK_ExpProvider and FK_ExpPost=@FK_ExpPost",
					"@FK_ExpProvider", FK_ExpProvider, 
					"@FK_ExpPost", FK_ExpPost);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPostFeeProvider trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpPostFeeProvider _ExpPostFeeProvider)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPostFeeProvider] WHERE FK_ExpProvider=@FK_ExpProvider and FK_ExpPost=@FK_ExpPost",
					"@FK_ExpProvider", _ExpPostFeeProvider.FK_ExpProvider, 
					"@FK_ExpPost", _ExpPostFeeProvider.FK_ExpPost);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPostFeeProvider trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPostFeeProvider] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPostFeeProvider trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpPostFeeProvider> _ExpPostFeeProviders)
		{
			foreach (ExpPostFeeProvider item in _ExpPostFeeProviders)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
