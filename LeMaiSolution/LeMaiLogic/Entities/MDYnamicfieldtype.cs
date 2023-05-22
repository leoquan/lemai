using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MDYnamicfieldtype:IDYnamicfieldtype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MDYnamicfieldtype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable DynamicFieldType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFieldType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable DynamicFieldType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFieldType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách DynamicFieldType từ Database
		/// </summary>
		public List<DynamicFieldType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFieldType]");
				List<DynamicFieldType> items = new List<DynamicFieldType>();
				DynamicFieldType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicFieldType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
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
		/// Lấy danh sách DynamicFieldType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<DynamicFieldType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicFieldType] A "+ condition,  parameters);
				List<DynamicFieldType> items = new List<DynamicFieldType>();
				DynamicFieldType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicFieldType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
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

		public List<DynamicFieldType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicFieldType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[DynamicFieldType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<DynamicFieldType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một DynamicFieldType từ Database
		/// </summary>
		public DynamicFieldType GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFieldType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					DynamicFieldType item=new DynamicFieldType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
						{
							item.TypeName = Convert.ToString(dr["TypeName"]);
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
		/// Lấy một DynamicFieldType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public DynamicFieldType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicFieldType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					DynamicFieldType item=new DynamicFieldType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
						{
							item.TypeName = Convert.ToString(dr["TypeName"]);
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

		public DynamicFieldType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicFieldType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<DynamicFieldType>(ds);
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
		/// Thêm mới DynamicFieldType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, DynamicFieldType _DynamicFieldType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[DynamicFieldType](Id, TypeName) VALUES(@Id, @TypeName)", 
					"@Id",  _DynamicFieldType.Id, 
					"@TypeName",  _DynamicFieldType.TypeName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng DynamicFieldType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<DynamicFieldType> _DynamicFieldTypes)
		{
			foreach (DynamicFieldType item in _DynamicFieldTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicFieldType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, DynamicFieldType _DynamicFieldType, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFieldType] SET Id=@Id, TypeName=@TypeName WHERE Id=@Id", 
					"@Id",  _DynamicFieldType.Id, 
					"@TypeName",  _DynamicFieldType.TypeName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật DynamicFieldType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, DynamicFieldType _DynamicFieldType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFieldType] SET TypeName=@TypeName WHERE Id=@Id", 
					"@TypeName",  _DynamicFieldType.TypeName, 
					"@Id", _DynamicFieldType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách DynamicFieldType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<DynamicFieldType> _DynamicFieldTypes)
		{
			foreach (DynamicFieldType item in _DynamicFieldTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicFieldType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, DynamicFieldType _DynamicFieldType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFieldType] SET Id=@Id, TypeName=@TypeName "+ condition, 
					"@Id",  _DynamicFieldType.Id, 
					"@TypeName",  _DynamicFieldType.TypeName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa DynamicFieldType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFieldType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFieldType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, DynamicFieldType _DynamicFieldType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFieldType] WHERE Id=@Id",
					"@Id", _DynamicFieldType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFieldType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFieldType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFieldType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<DynamicFieldType> _DynamicFieldTypes)
		{
			foreach (DynamicFieldType item in _DynamicFieldTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
