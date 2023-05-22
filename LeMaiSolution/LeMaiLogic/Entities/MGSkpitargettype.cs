using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSkpitargettype:IGSkpitargettype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSkpitargettype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsKPITargetType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPITargetType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsKPITargetType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPITargetType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsKPITargetType từ Database
		/// </summary>
		public List<GsKPITargetType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPITargetType]");
				List<GsKPITargetType> items = new List<GsKPITargetType>();
				GsKPITargetType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsKPITargetType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TargetTypeName"] != null && dr["TargetTypeName"] != DBNull.Value)
					{
						item.TargetTypeName = Convert.ToString(dr["TargetTypeName"]);
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
		/// Lấy danh sách GsKPITargetType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsKPITargetType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsKPITargetType] A "+ condition,  parameters);
				List<GsKPITargetType> items = new List<GsKPITargetType>();
				GsKPITargetType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsKPITargetType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TargetTypeName"] != null && dr["TargetTypeName"] != DBNull.Value)
					{
						item.TargetTypeName = Convert.ToString(dr["TargetTypeName"]);
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

		public List<GsKPITargetType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsKPITargetType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsKPITargetType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsKPITargetType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsKPITargetType từ Database
		/// </summary>
		public GsKPITargetType GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPITargetType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsKPITargetType item=new GsKPITargetType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TargetTypeName"] != null && dr["TargetTypeName"] != DBNull.Value)
						{
							item.TargetTypeName = Convert.ToString(dr["TargetTypeName"]);
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
		/// Lấy một GsKPITargetType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsKPITargetType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsKPITargetType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsKPITargetType item=new GsKPITargetType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TargetTypeName"] != null && dr["TargetTypeName"] != DBNull.Value)
						{
							item.TargetTypeName = Convert.ToString(dr["TargetTypeName"]);
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

		public GsKPITargetType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsKPITargetType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsKPITargetType>(ds);
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
		/// Thêm mới GsKPITargetType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsKPITargetType _GsKPITargetType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsKPITargetType](Id, TargetTypeName) VALUES(@Id, @TargetTypeName)", 
					"@Id",  _GsKPITargetType.Id, 
					"@TargetTypeName",  _GsKPITargetType.TargetTypeName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsKPITargetType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsKPITargetType> _GsKPITargetTypes)
		{
			foreach (GsKPITargetType item in _GsKPITargetTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsKPITargetType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsKPITargetType _GsKPITargetType, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPITargetType] SET Id=@Id, TargetTypeName=@TargetTypeName WHERE Id=@Id", 
					"@Id",  _GsKPITargetType.Id, 
					"@TargetTypeName",  _GsKPITargetType.TargetTypeName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsKPITargetType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsKPITargetType _GsKPITargetType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPITargetType] SET TargetTypeName=@TargetTypeName WHERE Id=@Id", 
					"@TargetTypeName",  _GsKPITargetType.TargetTypeName, 
					"@Id", _GsKPITargetType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsKPITargetType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsKPITargetType> _GsKPITargetTypes)
		{
			foreach (GsKPITargetType item in _GsKPITargetTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsKPITargetType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsKPITargetType _GsKPITargetType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPITargetType] SET Id=@Id, TargetTypeName=@TargetTypeName "+ condition, 
					"@Id",  _GsKPITargetType.Id, 
					"@TargetTypeName",  _GsKPITargetType.TargetTypeName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsKPITargetType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPITargetType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPITargetType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsKPITargetType _GsKPITargetType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPITargetType] WHERE Id=@Id",
					"@Id", _GsKPITargetType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPITargetType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPITargetType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPITargetType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsKPITargetType> _GsKPITargetTypes)
		{
			foreach (GsKPITargetType item in _GsKPITargetTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
