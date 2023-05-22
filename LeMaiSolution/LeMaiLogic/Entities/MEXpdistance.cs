using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpdistance:IEXpdistance
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpdistance(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpDistance từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDistance]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpDistance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDistance] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpDistance từ Database
		/// </summary>
		public List<ExpDistance> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDistance]");
				List<ExpDistance> items = new List<ExpDistance>();
				ExpDistance item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDistance();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Target"] != null && dr["Target"] != DBNull.Value)
					{
						item.Target = Convert.ToString(dr["Target"]);
					}
					if (dr["FromProvine"] != null && dr["FromProvine"] != DBNull.Value)
					{
						item.FromProvine = Convert.ToString(dr["FromProvine"]);
					}
					if (dr["ToProvine"] != null && dr["ToProvine"] != DBNull.Value)
					{
						item.ToProvine = Convert.ToString(dr["ToProvine"]);
					}
					if (dr["Distance"] != null && dr["Distance"] != DBNull.Value)
					{
						item.Distance = Convert.ToInt32(dr["Distance"]);
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
		/// Lấy danh sách ExpDistance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpDistance> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDistance] A "+ condition,  parameters);
				List<ExpDistance> items = new List<ExpDistance>();
				ExpDistance item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDistance();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Target"] != null && dr["Target"] != DBNull.Value)
					{
						item.Target = Convert.ToString(dr["Target"]);
					}
					if (dr["FromProvine"] != null && dr["FromProvine"] != DBNull.Value)
					{
						item.FromProvine = Convert.ToString(dr["FromProvine"]);
					}
					if (dr["ToProvine"] != null && dr["ToProvine"] != DBNull.Value)
					{
						item.ToProvine = Convert.ToString(dr["ToProvine"]);
					}
					if (dr["Distance"] != null && dr["Distance"] != DBNull.Value)
					{
						item.Distance = Convert.ToInt32(dr["Distance"]);
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

		public List<ExpDistance> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDistance] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpDistance] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpDistance>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpDistance từ Database
		/// </summary>
		public ExpDistance GetObject(string schema, String Id, String Target)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDistance] where Id=@Id and Target=@Target",
					"@Id", Id, 
					"@Target", Target);
				if (ds.Rows.Count > 0)
				{
					ExpDistance item=new ExpDistance();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Target"] != null && dr["Target"] != DBNull.Value)
						{
							item.Target = Convert.ToString(dr["Target"]);
						}
						if (dr["FromProvine"] != null && dr["FromProvine"] != DBNull.Value)
						{
							item.FromProvine = Convert.ToString(dr["FromProvine"]);
						}
						if (dr["ToProvine"] != null && dr["ToProvine"] != DBNull.Value)
						{
							item.ToProvine = Convert.ToString(dr["ToProvine"]);
						}
						if (dr["Distance"] != null && dr["Distance"] != DBNull.Value)
						{
							item.Distance = Convert.ToInt32(dr["Distance"]);
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
		/// Lấy một ExpDistance đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpDistance GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDistance] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpDistance item=new ExpDistance();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Target"] != null && dr["Target"] != DBNull.Value)
						{
							item.Target = Convert.ToString(dr["Target"]);
						}
						if (dr["FromProvine"] != null && dr["FromProvine"] != DBNull.Value)
						{
							item.FromProvine = Convert.ToString(dr["FromProvine"]);
						}
						if (dr["ToProvine"] != null && dr["ToProvine"] != DBNull.Value)
						{
							item.ToProvine = Convert.ToString(dr["ToProvine"]);
						}
						if (dr["Distance"] != null && dr["Distance"] != DBNull.Value)
						{
							item.Distance = Convert.ToInt32(dr["Distance"]);
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

		public ExpDistance GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDistance] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpDistance>(ds);
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
		/// Thêm mới ExpDistance vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpDistance _ExpDistance)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpDistance](Id, Target, FromProvine, ToProvine, Distance) VALUES(@Id, @Target, @FromProvine, @ToProvine, @Distance)", 
					"@Id",  _ExpDistance.Id, 
					"@Target",  _ExpDistance.Target, 
					"@FromProvine",  _ExpDistance.FromProvine, 
					"@ToProvine",  _ExpDistance.ToProvine, 
					"@Distance",  _ExpDistance.Distance);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpDistance vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpDistance> _ExpDistances)
		{
			foreach (ExpDistance item in _ExpDistances)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDistance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpDistance _ExpDistance, String Id, String Target)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDistance] SET Id=@Id, Target=@Target, FromProvine=@FromProvine, ToProvine=@ToProvine, Distance=@Distance WHERE Id=@Id and Target=@Target", 
					"@Id",  _ExpDistance.Id, 
					"@Target",  _ExpDistance.Target, 
					"@FromProvine",  _ExpDistance.FromProvine, 
					"@ToProvine",  _ExpDistance.ToProvine, 
					"@Distance",  _ExpDistance.Distance, 
					"@Id", Id, 
					"@Target", Target);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpDistance vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpDistance _ExpDistance)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDistance] SET FromProvine=@FromProvine, ToProvine=@ToProvine, Distance=@Distance WHERE Id=@Id and Target=@Target", 
					"@FromProvine",  _ExpDistance.FromProvine, 
					"@ToProvine",  _ExpDistance.ToProvine, 
					"@Distance",  _ExpDistance.Distance, 
					"@Id", _ExpDistance.Id, 
					"@Target", _ExpDistance.Target);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpDistance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpDistance> _ExpDistances)
		{
			foreach (ExpDistance item in _ExpDistances)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDistance vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpDistance _ExpDistance, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDistance] SET Id=@Id, Target=@Target, FromProvine=@FromProvine, ToProvine=@ToProvine, Distance=@Distance "+ condition, 
					"@Id",  _ExpDistance.Id, 
					"@Target",  _ExpDistance.Target, 
					"@FromProvine",  _ExpDistance.FromProvine, 
					"@ToProvine",  _ExpDistance.ToProvine, 
					"@Distance",  _ExpDistance.Distance);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpDistance trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id, String Target)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDistance] WHERE Id=@Id and Target=@Target",
					"@Id", Id, 
					"@Target", Target);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDistance trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpDistance _ExpDistance)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDistance] WHERE Id=@Id and Target=@Target",
					"@Id", _ExpDistance.Id, 
					"@Target", _ExpDistance.Target);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDistance trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDistance] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDistance trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpDistance> _ExpDistances)
		{
			foreach (ExpDistance item in _ExpDistances)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
