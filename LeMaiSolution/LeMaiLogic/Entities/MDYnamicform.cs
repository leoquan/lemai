using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MDYnamicform:IDYnamicform
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MDYnamicform(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable DynamicForm từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicForm]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable DynamicForm từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicForm] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách DynamicForm từ Database
		/// </summary>
		public List<DynamicForm> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicForm]");
				List<DynamicForm> items = new List<DynamicForm>();
				DynamicForm item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicForm();
					if (dr["FormName"] != null && dr["FormName"] != DBNull.Value)
					{
						item.FormName = Convert.ToString(dr["FormName"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy danh sách DynamicForm từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<DynamicForm> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicForm] A "+ condition,  parameters);
				List<DynamicForm> items = new List<DynamicForm>();
				DynamicForm item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicForm();
					if (dr["FormName"] != null && dr["FormName"] != DBNull.Value)
					{
						item.FormName = Convert.ToString(dr["FormName"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public List<DynamicForm> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicForm] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[DynamicForm] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<DynamicForm>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một DynamicForm từ Database
		/// </summary>
		public DynamicForm GetObject(string schema, String FormName)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicForm] where FormName=@FormName",
					"@FormName", FormName);
				if (ds.Rows.Count > 0)
				{
					DynamicForm item=new DynamicForm();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FormName"] != null && dr["FormName"] != DBNull.Value)
						{
							item.FormName = Convert.ToString(dr["FormName"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy một DynamicForm đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public DynamicForm GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicForm] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					DynamicForm item=new DynamicForm();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FormName"] != null && dr["FormName"] != DBNull.Value)
						{
							item.FormName = Convert.ToString(dr["FormName"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public DynamicForm GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicForm] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<DynamicForm>(ds);
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
		/// Thêm mới DynamicForm vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, DynamicForm _DynamicForm)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[DynamicForm](FormName, CreateDate) VALUES(@FormName, @CreateDate)", 
					"@FormName",  _DynamicForm.FormName, 
					"@CreateDate", this._dataContext.ConvertDateString( _DynamicForm.CreateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng DynamicForm vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<DynamicForm> _DynamicForms)
		{
			foreach (DynamicForm item in _DynamicForms)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicForm vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, DynamicForm _DynamicForm, String FormName)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicForm] SET FormName=@FormName, CreateDate=@CreateDate WHERE FormName=@FormName", 
					"@FormName",  _DynamicForm.FormName, 
					"@CreateDate", this._dataContext.ConvertDateString( _DynamicForm.CreateDate), 
					"@FormName", FormName);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật DynamicForm vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, DynamicForm _DynamicForm)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicForm] SET CreateDate=@CreateDate WHERE FormName=@FormName", 
					"@CreateDate", this._dataContext.ConvertDateString( _DynamicForm.CreateDate), 
					"@FormName", _DynamicForm.FormName);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách DynamicForm vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<DynamicForm> _DynamicForms)
		{
			foreach (DynamicForm item in _DynamicForms)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicForm vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, DynamicForm _DynamicForm, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicForm] SET FormName=@FormName, CreateDate=@CreateDate "+ condition, 
					"@FormName",  _DynamicForm.FormName, 
					"@CreateDate", this._dataContext.ConvertDateString( _DynamicForm.CreateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa DynamicForm trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FormName)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicForm] WHERE FormName=@FormName",
					"@FormName", FormName);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicForm trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, DynamicForm _DynamicForm)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicForm] WHERE FormName=@FormName",
					"@FormName", _DynamicForm.FormName);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicForm trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicForm] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicForm trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<DynamicForm> _DynamicForms)
		{
			foreach (DynamicForm item in _DynamicForms)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
