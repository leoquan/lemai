using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MDYnamicformfield:IDYnamicformfield
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MDYnamicformfield(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable DynamicFormField từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFormField]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable DynamicFormField từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFormField] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách DynamicFormField từ Database
		/// </summary>
		public List<DynamicFormField> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFormField]");
				List<DynamicFormField> items = new List<DynamicFormField>();
				DynamicFormField item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicFormField();
					if (dr["FK_DynamicForm"] != null && dr["FK_DynamicForm"] != DBNull.Value)
					{
						item.FK_DynamicForm = Convert.ToString(dr["FK_DynamicForm"]);
					}
					if (dr["FK_DynamicField"] != null && dr["FK_DynamicField"] != DBNull.Value)
					{
						item.FK_DynamicField = Convert.ToString(dr["FK_DynamicField"]);
					}
					if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
					{
						item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
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
		/// Lấy danh sách DynamicFormField từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<DynamicFormField> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicFormField] A "+ condition,  parameters);
				List<DynamicFormField> items = new List<DynamicFormField>();
				DynamicFormField item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicFormField();
					if (dr["FK_DynamicForm"] != null && dr["FK_DynamicForm"] != DBNull.Value)
					{
						item.FK_DynamicForm = Convert.ToString(dr["FK_DynamicForm"]);
					}
					if (dr["FK_DynamicField"] != null && dr["FK_DynamicField"] != DBNull.Value)
					{
						item.FK_DynamicField = Convert.ToString(dr["FK_DynamicField"]);
					}
					if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
					{
						item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
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

		public List<DynamicFormField> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicFormField] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[DynamicFormField] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<DynamicFormField>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một DynamicFormField từ Database
		/// </summary>
		public DynamicFormField GetObject(string schema, String FK_DynamicForm, String FK_DynamicField)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFormField] where FK_DynamicForm=@FK_DynamicForm and FK_DynamicField=@FK_DynamicField",
					"@FK_DynamicForm", FK_DynamicForm, 
					"@FK_DynamicField", FK_DynamicField);
				if (ds.Rows.Count > 0)
				{
					DynamicFormField item=new DynamicFormField();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_DynamicForm"] != null && dr["FK_DynamicForm"] != DBNull.Value)
						{
							item.FK_DynamicForm = Convert.ToString(dr["FK_DynamicForm"]);
						}
						if (dr["FK_DynamicField"] != null && dr["FK_DynamicField"] != DBNull.Value)
						{
							item.FK_DynamicField = Convert.ToString(dr["FK_DynamicField"]);
						}
						if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
						{
							item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
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
		/// Lấy một DynamicFormField đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public DynamicFormField GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicFormField] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					DynamicFormField item=new DynamicFormField();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_DynamicForm"] != null && dr["FK_DynamicForm"] != DBNull.Value)
						{
							item.FK_DynamicForm = Convert.ToString(dr["FK_DynamicForm"]);
						}
						if (dr["FK_DynamicField"] != null && dr["FK_DynamicField"] != DBNull.Value)
						{
							item.FK_DynamicField = Convert.ToString(dr["FK_DynamicField"]);
						}
						if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
						{
							item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
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

		public DynamicFormField GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicFormField] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<DynamicFormField>(ds);
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
		/// Thêm mới DynamicFormField vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, DynamicFormField _DynamicFormField)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[DynamicFormField](FK_DynamicForm, FK_DynamicField, OrderNo) VALUES(@FK_DynamicForm, @FK_DynamicField, @OrderNo)", 
					"@FK_DynamicForm",  _DynamicFormField.FK_DynamicForm, 
					"@FK_DynamicField",  _DynamicFormField.FK_DynamicField, 
					"@OrderNo",  _DynamicFormField.OrderNo);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng DynamicFormField vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<DynamicFormField> _DynamicFormFields)
		{
			foreach (DynamicFormField item in _DynamicFormFields)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicFormField vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, DynamicFormField _DynamicFormField, String FK_DynamicForm, String FK_DynamicField)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFormField] SET FK_DynamicForm=@FK_DynamicForm, FK_DynamicField=@FK_DynamicField, OrderNo=@OrderNo WHERE FK_DynamicForm=@FK_DynamicForm and FK_DynamicField=@FK_DynamicField", 
					"@FK_DynamicForm",  _DynamicFormField.FK_DynamicForm, 
					"@FK_DynamicField",  _DynamicFormField.FK_DynamicField, 
					"@OrderNo",  _DynamicFormField.OrderNo, 
					"@FK_DynamicForm", FK_DynamicForm, 
					"@FK_DynamicField", FK_DynamicField);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật DynamicFormField vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, DynamicFormField _DynamicFormField)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFormField] SET OrderNo=@OrderNo WHERE FK_DynamicForm=@FK_DynamicForm and FK_DynamicField=@FK_DynamicField", 
					"@OrderNo",  _DynamicFormField.OrderNo, 
					"@FK_DynamicForm", _DynamicFormField.FK_DynamicForm, 
					"@FK_DynamicField", _DynamicFormField.FK_DynamicField);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách DynamicFormField vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<DynamicFormField> _DynamicFormFields)
		{
			foreach (DynamicFormField item in _DynamicFormFields)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicFormField vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, DynamicFormField _DynamicFormField, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFormField] SET FK_DynamicForm=@FK_DynamicForm, FK_DynamicField=@FK_DynamicField, OrderNo=@OrderNo "+ condition, 
					"@FK_DynamicForm",  _DynamicFormField.FK_DynamicForm, 
					"@FK_DynamicField",  _DynamicFormField.FK_DynamicField, 
					"@OrderNo",  _DynamicFormField.OrderNo);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa DynamicFormField trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_DynamicForm, String FK_DynamicField)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFormField] WHERE FK_DynamicForm=@FK_DynamicForm and FK_DynamicField=@FK_DynamicField",
					"@FK_DynamicForm", FK_DynamicForm, 
					"@FK_DynamicField", FK_DynamicField);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFormField trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, DynamicFormField _DynamicFormField)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFormField] WHERE FK_DynamicForm=@FK_DynamicForm and FK_DynamicField=@FK_DynamicField",
					"@FK_DynamicForm", _DynamicFormField.FK_DynamicForm, 
					"@FK_DynamicField", _DynamicFormField.FK_DynamicField);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFormField trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFormField] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFormField trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<DynamicFormField> _DynamicFormFields)
		{
			foreach (DynamicFormField item in _DynamicFormFields)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
