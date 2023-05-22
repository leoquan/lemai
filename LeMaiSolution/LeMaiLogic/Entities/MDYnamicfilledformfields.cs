using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MDYnamicfilledformfields:IDYnamicfilledformfields
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MDYnamicfilledformfields(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable DynamicFilledFormFields từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFilledFormFields]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable DynamicFilledFormFields từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFilledFormFields] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách DynamicFilledFormFields từ Database
		/// </summary>
		public List<DynamicFilledFormFields> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFilledFormFields]");
				List<DynamicFilledFormFields> items = new List<DynamicFilledFormFields>();
				DynamicFilledFormFields item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicFilledFormFields();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DynamicFilledForms"] != null && dr["FK_DynamicFilledForms"] != DBNull.Value)
					{
						item.FK_DynamicFilledForms = Convert.ToString(dr["FK_DynamicFilledForms"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToString(dr["Value"]);
					}
					if (dr["FK_DynamicField"] != null && dr["FK_DynamicField"] != DBNull.Value)
					{
						item.FK_DynamicField = Convert.ToString(dr["FK_DynamicField"]);
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
		/// Lấy danh sách DynamicFilledFormFields từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<DynamicFilledFormFields> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicFilledFormFields] A "+ condition,  parameters);
				List<DynamicFilledFormFields> items = new List<DynamicFilledFormFields>();
				DynamicFilledFormFields item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicFilledFormFields();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DynamicFilledForms"] != null && dr["FK_DynamicFilledForms"] != DBNull.Value)
					{
						item.FK_DynamicFilledForms = Convert.ToString(dr["FK_DynamicFilledForms"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToString(dr["Value"]);
					}
					if (dr["FK_DynamicField"] != null && dr["FK_DynamicField"] != DBNull.Value)
					{
						item.FK_DynamicField = Convert.ToString(dr["FK_DynamicField"]);
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

		public List<DynamicFilledFormFields> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicFilledFormFields] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[DynamicFilledFormFields] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<DynamicFilledFormFields>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một DynamicFilledFormFields từ Database
		/// </summary>
		public DynamicFilledFormFields GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFilledFormFields] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					DynamicFilledFormFields item=new DynamicFilledFormFields();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DynamicFilledForms"] != null && dr["FK_DynamicFilledForms"] != DBNull.Value)
						{
							item.FK_DynamicFilledForms = Convert.ToString(dr["FK_DynamicFilledForms"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToString(dr["Value"]);
						}
						if (dr["FK_DynamicField"] != null && dr["FK_DynamicField"] != DBNull.Value)
						{
							item.FK_DynamicField = Convert.ToString(dr["FK_DynamicField"]);
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
		/// Lấy một DynamicFilledFormFields đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public DynamicFilledFormFields GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicFilledFormFields] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					DynamicFilledFormFields item=new DynamicFilledFormFields();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DynamicFilledForms"] != null && dr["FK_DynamicFilledForms"] != DBNull.Value)
						{
							item.FK_DynamicFilledForms = Convert.ToString(dr["FK_DynamicFilledForms"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToString(dr["Value"]);
						}
						if (dr["FK_DynamicField"] != null && dr["FK_DynamicField"] != DBNull.Value)
						{
							item.FK_DynamicField = Convert.ToString(dr["FK_DynamicField"]);
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

		public DynamicFilledFormFields GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicFilledFormFields] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<DynamicFilledFormFields>(ds);
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
		/// Thêm mới DynamicFilledFormFields vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, DynamicFilledFormFields _DynamicFilledFormFields)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[DynamicFilledFormFields](Id, FK_DynamicFilledForms, Value, FK_DynamicField) VALUES(@Id, @FK_DynamicFilledForms, @Value, @FK_DynamicField)", 
					"@Id",  _DynamicFilledFormFields.Id, 
					"@FK_DynamicFilledForms",  _DynamicFilledFormFields.FK_DynamicFilledForms, 
					"@Value",  _DynamicFilledFormFields.Value, 
					"@FK_DynamicField",  _DynamicFilledFormFields.FK_DynamicField);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng DynamicFilledFormFields vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<DynamicFilledFormFields> _DynamicFilledFormFieldss)
		{
			foreach (DynamicFilledFormFields item in _DynamicFilledFormFieldss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicFilledFormFields vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, DynamicFilledFormFields _DynamicFilledFormFields, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFilledFormFields] SET Id=@Id, FK_DynamicFilledForms=@FK_DynamicFilledForms, Value=@Value, FK_DynamicField=@FK_DynamicField WHERE Id=@Id", 
					"@Id",  _DynamicFilledFormFields.Id, 
					"@FK_DynamicFilledForms",  _DynamicFilledFormFields.FK_DynamicFilledForms, 
					"@Value",  _DynamicFilledFormFields.Value, 
					"@FK_DynamicField",  _DynamicFilledFormFields.FK_DynamicField, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật DynamicFilledFormFields vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, DynamicFilledFormFields _DynamicFilledFormFields)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFilledFormFields] SET FK_DynamicFilledForms=@FK_DynamicFilledForms, Value=@Value, FK_DynamicField=@FK_DynamicField WHERE Id=@Id", 
					"@FK_DynamicFilledForms",  _DynamicFilledFormFields.FK_DynamicFilledForms, 
					"@Value",  _DynamicFilledFormFields.Value, 
					"@FK_DynamicField",  _DynamicFilledFormFields.FK_DynamicField, 
					"@Id", _DynamicFilledFormFields.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách DynamicFilledFormFields vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<DynamicFilledFormFields> _DynamicFilledFormFieldss)
		{
			foreach (DynamicFilledFormFields item in _DynamicFilledFormFieldss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicFilledFormFields vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, DynamicFilledFormFields _DynamicFilledFormFields, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFilledFormFields] SET Id=@Id, FK_DynamicFilledForms=@FK_DynamicFilledForms, Value=@Value, FK_DynamicField=@FK_DynamicField "+ condition, 
					"@Id",  _DynamicFilledFormFields.Id, 
					"@FK_DynamicFilledForms",  _DynamicFilledFormFields.FK_DynamicFilledForms, 
					"@Value",  _DynamicFilledFormFields.Value, 
					"@FK_DynamicField",  _DynamicFilledFormFields.FK_DynamicField);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa DynamicFilledFormFields trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFilledFormFields] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFilledFormFields trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, DynamicFilledFormFields _DynamicFilledFormFields)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFilledFormFields] WHERE Id=@Id",
					"@Id", _DynamicFilledFormFields.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFilledFormFields trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFilledFormFields] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFilledFormFields trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<DynamicFilledFormFields> _DynamicFilledFormFieldss)
		{
			foreach (DynamicFilledFormFields item in _DynamicFilledFormFieldss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
