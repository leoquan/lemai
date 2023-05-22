using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpbillstatus:IEXpbillstatus
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpbillstatus(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpBILLStatus từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBILLStatus]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpBILLStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBILLStatus] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpBILLStatus từ Database
		/// </summary>
		public List<ExpBILLStatus> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBILLStatus]");
				List<ExpBILLStatus> items = new List<ExpBILLStatus>();
				ExpBILLStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpBILLStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
					}
					if (dr["SelectNV"] != null && dr["SelectNV"] != DBNull.Value)
					{
						item.SelectNV = Convert.ToBoolean(dr["SelectNV"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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
		/// Lấy danh sách ExpBILLStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpBILLStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpBILLStatus] A "+ condition,  parameters);
				List<ExpBILLStatus> items = new List<ExpBILLStatus>();
				ExpBILLStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpBILLStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
					}
					if (dr["SelectNV"] != null && dr["SelectNV"] != DBNull.Value)
					{
						item.SelectNV = Convert.ToBoolean(dr["SelectNV"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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

		public List<ExpBILLStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpBILLStatus] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpBILLStatus] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpBILLStatus>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpBILLStatus từ Database
		/// </summary>
		public ExpBILLStatus GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBILLStatus] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpBILLStatus item=new ExpBILLStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
						}
						if (dr["SelectNV"] != null && dr["SelectNV"] != DBNull.Value)
						{
							item.SelectNV = Convert.ToBoolean(dr["SelectNV"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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
		/// Lấy một ExpBILLStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpBILLStatus GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpBILLStatus] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpBILLStatus item=new ExpBILLStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
						}
						if (dr["SelectNV"] != null && dr["SelectNV"] != DBNull.Value)
						{
							item.SelectNV = Convert.ToBoolean(dr["SelectNV"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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

		public ExpBILLStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpBILLStatus] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpBILLStatus>(ds);
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
		/// Thêm mới ExpBILLStatus vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpBILLStatus _ExpBILLStatus)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpBILLStatus](Id, StatusName, GhiChu, SelectNV, SortIndex) VALUES(@Id, @StatusName, @GhiChu, @SelectNV, @SortIndex)", 
					"@Id",  _ExpBILLStatus.Id, 
					"@StatusName",  _ExpBILLStatus.StatusName, 
					"@GhiChu",  _ExpBILLStatus.GhiChu, 
					"@SelectNV",  _ExpBILLStatus.SelectNV, 
					"@SortIndex",  _ExpBILLStatus.SortIndex);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpBILLStatus vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpBILLStatus> _ExpBILLStatuss)
		{
			foreach (ExpBILLStatus item in _ExpBILLStatuss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpBILLStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpBILLStatus _ExpBILLStatus, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBILLStatus] SET Id=@Id, StatusName=@StatusName, GhiChu=@GhiChu, SelectNV=@SelectNV, SortIndex=@SortIndex WHERE Id=@Id", 
					"@Id",  _ExpBILLStatus.Id, 
					"@StatusName",  _ExpBILLStatus.StatusName, 
					"@GhiChu",  _ExpBILLStatus.GhiChu, 
					"@SelectNV",  _ExpBILLStatus.SelectNV, 
					"@SortIndex",  _ExpBILLStatus.SortIndex, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpBILLStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpBILLStatus _ExpBILLStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBILLStatus] SET StatusName=@StatusName, GhiChu=@GhiChu, SelectNV=@SelectNV, SortIndex=@SortIndex WHERE Id=@Id", 
					"@StatusName",  _ExpBILLStatus.StatusName, 
					"@GhiChu",  _ExpBILLStatus.GhiChu, 
					"@SelectNV",  _ExpBILLStatus.SelectNV, 
					"@SortIndex",  _ExpBILLStatus.SortIndex, 
					"@Id", _ExpBILLStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpBILLStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpBILLStatus> _ExpBILLStatuss)
		{
			foreach (ExpBILLStatus item in _ExpBILLStatuss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpBILLStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpBILLStatus _ExpBILLStatus, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBILLStatus] SET Id=@Id, StatusName=@StatusName, GhiChu=@GhiChu, SelectNV=@SelectNV, SortIndex=@SortIndex "+ condition, 
					"@Id",  _ExpBILLStatus.Id, 
					"@StatusName",  _ExpBILLStatus.StatusName, 
					"@GhiChu",  _ExpBILLStatus.GhiChu, 
					"@SelectNV",  _ExpBILLStatus.SelectNV, 
					"@SortIndex",  _ExpBILLStatus.SortIndex);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpBILLStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBILLStatus] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBILLStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpBILLStatus _ExpBILLStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBILLStatus] WHERE Id=@Id",
					"@Id", _ExpBILLStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBILLStatus trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBILLStatus] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBILLStatus trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpBILLStatus> _ExpBILLStatuss)
		{
			foreach (ExpBILLStatus item in _ExpBILLStatuss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
