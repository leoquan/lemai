using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MDYnamicfield:IDYnamicfield
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MDYnamicfield(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable DynamicField từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicField]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable DynamicField từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicField] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách DynamicField từ Database
		/// </summary>
		public List<DynamicField> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicField]");
				List<DynamicField> items = new List<DynamicField>();
				DynamicField item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicField();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FieldName"] != null && dr["FieldName"] != DBNull.Value)
					{
						item.FieldName = Convert.ToString(dr["FieldName"]);
					}
					if (dr["FK_FieldType"] != null && dr["FK_FieldType"] != DBNull.Value)
					{
						item.FK_FieldType = Convert.ToInt32(dr["FK_FieldType"]);
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
		/// Lấy danh sách DynamicField từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<DynamicField> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicField] A "+ condition,  parameters);
				List<DynamicField> items = new List<DynamicField>();
				DynamicField item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicField();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FieldName"] != null && dr["FieldName"] != DBNull.Value)
					{
						item.FieldName = Convert.ToString(dr["FieldName"]);
					}
					if (dr["FK_FieldType"] != null && dr["FK_FieldType"] != DBNull.Value)
					{
						item.FK_FieldType = Convert.ToInt32(dr["FK_FieldType"]);
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

		public List<DynamicField> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicField] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[DynamicField] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<DynamicField>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một DynamicField từ Database
		/// </summary>
		public DynamicField GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicField] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					DynamicField item=new DynamicField();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FieldName"] != null && dr["FieldName"] != DBNull.Value)
						{
							item.FieldName = Convert.ToString(dr["FieldName"]);
						}
						if (dr["FK_FieldType"] != null && dr["FK_FieldType"] != DBNull.Value)
						{
							item.FK_FieldType = Convert.ToInt32(dr["FK_FieldType"]);
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
		/// Lấy một DynamicField đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public DynamicField GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicField] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					DynamicField item=new DynamicField();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FieldName"] != null && dr["FieldName"] != DBNull.Value)
						{
							item.FieldName = Convert.ToString(dr["FieldName"]);
						}
						if (dr["FK_FieldType"] != null && dr["FK_FieldType"] != DBNull.Value)
						{
							item.FK_FieldType = Convert.ToInt32(dr["FK_FieldType"]);
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

		public DynamicField GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicField] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<DynamicField>(ds);
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
		/// Thêm mới DynamicField vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, DynamicField _DynamicField)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[DynamicField](Id, FieldName, FK_FieldType) VALUES(@Id, @FieldName, @FK_FieldType)", 
					"@Id",  _DynamicField.Id, 
					"@FieldName",  _DynamicField.FieldName, 
					"@FK_FieldType",  _DynamicField.FK_FieldType);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng DynamicField vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<DynamicField> _DynamicFields)
		{
			foreach (DynamicField item in _DynamicFields)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicField vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, DynamicField _DynamicField, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicField] SET Id=@Id, FieldName=@FieldName, FK_FieldType=@FK_FieldType WHERE Id=@Id", 
					"@Id",  _DynamicField.Id, 
					"@FieldName",  _DynamicField.FieldName, 
					"@FK_FieldType",  _DynamicField.FK_FieldType, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật DynamicField vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, DynamicField _DynamicField)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicField] SET FieldName=@FieldName, FK_FieldType=@FK_FieldType WHERE Id=@Id", 
					"@FieldName",  _DynamicField.FieldName, 
					"@FK_FieldType",  _DynamicField.FK_FieldType, 
					"@Id", _DynamicField.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách DynamicField vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<DynamicField> _DynamicFields)
		{
			foreach (DynamicField item in _DynamicFields)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicField vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, DynamicField _DynamicField, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicField] SET Id=@Id, FieldName=@FieldName, FK_FieldType=@FK_FieldType "+ condition, 
					"@Id",  _DynamicField.Id, 
					"@FieldName",  _DynamicField.FieldName, 
					"@FK_FieldType",  _DynamicField.FK_FieldType);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa DynamicField trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicField] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicField trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, DynamicField _DynamicField)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicField] WHERE Id=@Id",
					"@Id", _DynamicField.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicField trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicField] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicField trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<DynamicField> _DynamicFields)
		{
			foreach (DynamicField item in _DynamicFields)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
