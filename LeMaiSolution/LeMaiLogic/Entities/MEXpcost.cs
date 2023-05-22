using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcost:IEXpcost
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcost(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCost từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCost]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCost] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCost từ Database
		/// </summary>
		public List<ExpCost> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCost]");
				List<ExpCost> items = new List<ExpCost>();
				ExpCost item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCost();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
					{
						item.Ten = Convert.ToString(dr["Ten"]);
					}
					if (dr["Cap"] != null && dr["Cap"] != DBNull.Value)
					{
						item.Cap = Convert.ToString(dr["Cap"]);
					}
					if (dr["CapTren"] != null && dr["CapTren"] != DBNull.Value)
					{
						item.CapTren = Convert.ToString(dr["CapTren"]);
					}
					if (dr["InternalPost"] != null && dr["InternalPost"] != DBNull.Value)
					{
						item.InternalPost = Convert.ToBoolean(dr["InternalPost"]);
					}
					if (dr["Fee1"] != null && dr["Fee1"] != DBNull.Value)
					{
						item.Fee1 = Convert.ToInt32(dr["Fee1"]);
					}
					if (dr["Fee2"] != null && dr["Fee2"] != DBNull.Value)
					{
						item.Fee2 = Convert.ToInt32(dr["Fee2"]);
					}
					if (dr["Fee3"] != null && dr["Fee3"] != DBNull.Value)
					{
						item.Fee3 = Convert.ToInt32(dr["Fee3"]);
					}
					if (dr["Fee4"] != null && dr["Fee4"] != DBNull.Value)
					{
						item.Fee4 = Convert.ToInt32(dr["Fee4"]);
					}
					if (dr["Fee5"] != null && dr["Fee5"] != DBNull.Value)
					{
						item.Fee5 = Convert.ToInt32(dr["Fee5"]);
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
		/// Lấy danh sách ExpCost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCost> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCost] A "+ condition,  parameters);
				List<ExpCost> items = new List<ExpCost>();
				ExpCost item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCost();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
					{
						item.Ten = Convert.ToString(dr["Ten"]);
					}
					if (dr["Cap"] != null && dr["Cap"] != DBNull.Value)
					{
						item.Cap = Convert.ToString(dr["Cap"]);
					}
					if (dr["CapTren"] != null && dr["CapTren"] != DBNull.Value)
					{
						item.CapTren = Convert.ToString(dr["CapTren"]);
					}
					if (dr["InternalPost"] != null && dr["InternalPost"] != DBNull.Value)
					{
						item.InternalPost = Convert.ToBoolean(dr["InternalPost"]);
					}
					if (dr["Fee1"] != null && dr["Fee1"] != DBNull.Value)
					{
						item.Fee1 = Convert.ToInt32(dr["Fee1"]);
					}
					if (dr["Fee2"] != null && dr["Fee2"] != DBNull.Value)
					{
						item.Fee2 = Convert.ToInt32(dr["Fee2"]);
					}
					if (dr["Fee3"] != null && dr["Fee3"] != DBNull.Value)
					{
						item.Fee3 = Convert.ToInt32(dr["Fee3"]);
					}
					if (dr["Fee4"] != null && dr["Fee4"] != DBNull.Value)
					{
						item.Fee4 = Convert.ToInt32(dr["Fee4"]);
					}
					if (dr["Fee5"] != null && dr["Fee5"] != DBNull.Value)
					{
						item.Fee5 = Convert.ToInt32(dr["Fee5"]);
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

		public List<ExpCost> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCost] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCost] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCost>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCost từ Database
		/// </summary>
		public ExpCost GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCost] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpCost item=new ExpCost();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
						{
							item.Ten = Convert.ToString(dr["Ten"]);
						}
						if (dr["Cap"] != null && dr["Cap"] != DBNull.Value)
						{
							item.Cap = Convert.ToString(dr["Cap"]);
						}
						if (dr["CapTren"] != null && dr["CapTren"] != DBNull.Value)
						{
							item.CapTren = Convert.ToString(dr["CapTren"]);
						}
						if (dr["InternalPost"] != null && dr["InternalPost"] != DBNull.Value)
						{
							item.InternalPost = Convert.ToBoolean(dr["InternalPost"]);
						}
						if (dr["Fee1"] != null && dr["Fee1"] != DBNull.Value)
						{
							item.Fee1 = Convert.ToInt32(dr["Fee1"]);
						}
						if (dr["Fee2"] != null && dr["Fee2"] != DBNull.Value)
						{
							item.Fee2 = Convert.ToInt32(dr["Fee2"]);
						}
						if (dr["Fee3"] != null && dr["Fee3"] != DBNull.Value)
						{
							item.Fee3 = Convert.ToInt32(dr["Fee3"]);
						}
						if (dr["Fee4"] != null && dr["Fee4"] != DBNull.Value)
						{
							item.Fee4 = Convert.ToInt32(dr["Fee4"]);
						}
						if (dr["Fee5"] != null && dr["Fee5"] != DBNull.Value)
						{
							item.Fee5 = Convert.ToInt32(dr["Fee5"]);
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
		/// Lấy một ExpCost đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCost GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCost] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCost item=new ExpCost();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
						{
							item.Ten = Convert.ToString(dr["Ten"]);
						}
						if (dr["Cap"] != null && dr["Cap"] != DBNull.Value)
						{
							item.Cap = Convert.ToString(dr["Cap"]);
						}
						if (dr["CapTren"] != null && dr["CapTren"] != DBNull.Value)
						{
							item.CapTren = Convert.ToString(dr["CapTren"]);
						}
						if (dr["InternalPost"] != null && dr["InternalPost"] != DBNull.Value)
						{
							item.InternalPost = Convert.ToBoolean(dr["InternalPost"]);
						}
						if (dr["Fee1"] != null && dr["Fee1"] != DBNull.Value)
						{
							item.Fee1 = Convert.ToInt32(dr["Fee1"]);
						}
						if (dr["Fee2"] != null && dr["Fee2"] != DBNull.Value)
						{
							item.Fee2 = Convert.ToInt32(dr["Fee2"]);
						}
						if (dr["Fee3"] != null && dr["Fee3"] != DBNull.Value)
						{
							item.Fee3 = Convert.ToInt32(dr["Fee3"]);
						}
						if (dr["Fee4"] != null && dr["Fee4"] != DBNull.Value)
						{
							item.Fee4 = Convert.ToInt32(dr["Fee4"]);
						}
						if (dr["Fee5"] != null && dr["Fee5"] != DBNull.Value)
						{
							item.Fee5 = Convert.ToInt32(dr["Fee5"]);
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

		public ExpCost GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCost] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCost>(ds);
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
		/// Thêm mới ExpCost vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCost _ExpCost)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCost](Id, Ten, Cap, CapTren, InternalPost, Fee1, Fee2, Fee3, Fee4, Fee5) VALUES(@Id, @Ten, @Cap, @CapTren, @InternalPost, @Fee1, @Fee2, @Fee3, @Fee4, @Fee5)", 
					"@Id",  _ExpCost.Id, 
					"@Ten",  _ExpCost.Ten, 
					"@Cap",  _ExpCost.Cap, 
					"@CapTren",  _ExpCost.CapTren, 
					"@InternalPost",  _ExpCost.InternalPost, 
					"@Fee1",  _ExpCost.Fee1, 
					"@Fee2",  _ExpCost.Fee2, 
					"@Fee3",  _ExpCost.Fee3, 
					"@Fee4",  _ExpCost.Fee4, 
					"@Fee5",  _ExpCost.Fee5);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCost vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCost> _ExpCosts)
		{
			foreach (ExpCost item in _ExpCosts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCost _ExpCost, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCost] SET Id=@Id, Ten=@Ten, Cap=@Cap, CapTren=@CapTren, InternalPost=@InternalPost, Fee1=@Fee1, Fee2=@Fee2, Fee3=@Fee3, Fee4=@Fee4, Fee5=@Fee5 WHERE Id=@Id", 
					"@Id",  _ExpCost.Id, 
					"@Ten",  _ExpCost.Ten, 
					"@Cap",  _ExpCost.Cap, 
					"@CapTren",  _ExpCost.CapTren, 
					"@InternalPost",  _ExpCost.InternalPost, 
					"@Fee1",  _ExpCost.Fee1, 
					"@Fee2",  _ExpCost.Fee2, 
					"@Fee3",  _ExpCost.Fee3, 
					"@Fee4",  _ExpCost.Fee4, 
					"@Fee5",  _ExpCost.Fee5, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCost vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCost _ExpCost)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCost] SET Ten=@Ten, Cap=@Cap, CapTren=@CapTren, InternalPost=@InternalPost, Fee1=@Fee1, Fee2=@Fee2, Fee3=@Fee3, Fee4=@Fee4, Fee5=@Fee5 WHERE Id=@Id", 
					"@Ten",  _ExpCost.Ten, 
					"@Cap",  _ExpCost.Cap, 
					"@CapTren",  _ExpCost.CapTren, 
					"@InternalPost",  _ExpCost.InternalPost, 
					"@Fee1",  _ExpCost.Fee1, 
					"@Fee2",  _ExpCost.Fee2, 
					"@Fee3",  _ExpCost.Fee3, 
					"@Fee4",  _ExpCost.Fee4, 
					"@Fee5",  _ExpCost.Fee5, 
					"@Id", _ExpCost.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCost> _ExpCosts)
		{
			foreach (ExpCost item in _ExpCosts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCost vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCost _ExpCost, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCost] SET Id=@Id, Ten=@Ten, Cap=@Cap, CapTren=@CapTren, InternalPost=@InternalPost, Fee1=@Fee1, Fee2=@Fee2, Fee3=@Fee3, Fee4=@Fee4, Fee5=@Fee5 "+ condition, 
					"@Id",  _ExpCost.Id, 
					"@Ten",  _ExpCost.Ten, 
					"@Cap",  _ExpCost.Cap, 
					"@CapTren",  _ExpCost.CapTren, 
					"@InternalPost",  _ExpCost.InternalPost, 
					"@Fee1",  _ExpCost.Fee1, 
					"@Fee2",  _ExpCost.Fee2, 
					"@Fee3",  _ExpCost.Fee3, 
					"@Fee4",  _ExpCost.Fee4, 
					"@Fee5",  _ExpCost.Fee5);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCost trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCost] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCost trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCost _ExpCost)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCost] WHERE Id=@Id",
					"@Id", _ExpCost.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCost trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCost] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCost trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCost> _ExpCosts)
		{
			foreach (ExpCost item in _ExpCosts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
