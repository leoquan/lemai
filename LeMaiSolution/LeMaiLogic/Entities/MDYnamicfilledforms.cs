using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MDYnamicfilledforms:IDYnamicfilledforms
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MDYnamicfilledforms(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable DynamicFilledForms từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFilledForms]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable DynamicFilledForms từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFilledForms] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách DynamicFilledForms từ Database
		/// </summary>
		public List<DynamicFilledForms> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFilledForms]");
				List<DynamicFilledForms> items = new List<DynamicFilledForms>();
				DynamicFilledForms item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicFilledForms();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DynamicForm"] != null && dr["FK_DynamicForm"] != DBNull.Value)
					{
						item.FK_DynamicForm = Convert.ToString(dr["FK_DynamicForm"]);
					}
					if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
					{
						item.UserName = Convert.ToString(dr["UserName"]);
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
		/// Lấy danh sách DynamicFilledForms từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<DynamicFilledForms> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicFilledForms] A "+ condition,  parameters);
				List<DynamicFilledForms> items = new List<DynamicFilledForms>();
				DynamicFilledForms item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new DynamicFilledForms();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DynamicForm"] != null && dr["FK_DynamicForm"] != DBNull.Value)
					{
						item.FK_DynamicForm = Convert.ToString(dr["FK_DynamicForm"]);
					}
					if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
					{
						item.UserName = Convert.ToString(dr["UserName"]);
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

		public List<DynamicFilledForms> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicFilledForms] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[DynamicFilledForms] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<DynamicFilledForms>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một DynamicFilledForms từ Database
		/// </summary>
		public DynamicFilledForms GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[DynamicFilledForms] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					DynamicFilledForms item=new DynamicFilledForms();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DynamicForm"] != null && dr["FK_DynamicForm"] != DBNull.Value)
						{
							item.FK_DynamicForm = Convert.ToString(dr["FK_DynamicForm"]);
						}
						if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
						{
							item.UserName = Convert.ToString(dr["UserName"]);
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
		/// Lấy một DynamicFilledForms đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public DynamicFilledForms GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[DynamicFilledForms] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					DynamicFilledForms item=new DynamicFilledForms();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DynamicForm"] != null && dr["FK_DynamicForm"] != DBNull.Value)
						{
							item.FK_DynamicForm = Convert.ToString(dr["FK_DynamicForm"]);
						}
						if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
						{
							item.UserName = Convert.ToString(dr["UserName"]);
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

		public DynamicFilledForms GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[DynamicFilledForms] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<DynamicFilledForms>(ds);
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
		/// Thêm mới DynamicFilledForms vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, DynamicFilledForms _DynamicFilledForms)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[DynamicFilledForms](Id, FK_DynamicForm, UserName) VALUES(@Id, @FK_DynamicForm, @UserName)", 
					"@Id",  _DynamicFilledForms.Id, 
					"@FK_DynamicForm",  _DynamicFilledForms.FK_DynamicForm, 
					"@UserName",  _DynamicFilledForms.UserName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng DynamicFilledForms vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<DynamicFilledForms> _DynamicFilledFormss)
		{
			foreach (DynamicFilledForms item in _DynamicFilledFormss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicFilledForms vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, DynamicFilledForms _DynamicFilledForms, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFilledForms] SET Id=@Id, FK_DynamicForm=@FK_DynamicForm, UserName=@UserName WHERE Id=@Id", 
					"@Id",  _DynamicFilledForms.Id, 
					"@FK_DynamicForm",  _DynamicFilledForms.FK_DynamicForm, 
					"@UserName",  _DynamicFilledForms.UserName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật DynamicFilledForms vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, DynamicFilledForms _DynamicFilledForms)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFilledForms] SET FK_DynamicForm=@FK_DynamicForm, UserName=@UserName WHERE Id=@Id", 
					"@FK_DynamicForm",  _DynamicFilledForms.FK_DynamicForm, 
					"@UserName",  _DynamicFilledForms.UserName, 
					"@Id", _DynamicFilledForms.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách DynamicFilledForms vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<DynamicFilledForms> _DynamicFilledFormss)
		{
			foreach (DynamicFilledForms item in _DynamicFilledFormss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật DynamicFilledForms vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, DynamicFilledForms _DynamicFilledForms, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[DynamicFilledForms] SET Id=@Id, FK_DynamicForm=@FK_DynamicForm, UserName=@UserName "+ condition, 
					"@Id",  _DynamicFilledForms.Id, 
					"@FK_DynamicForm",  _DynamicFilledForms.FK_DynamicForm, 
					"@UserName",  _DynamicFilledForms.UserName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa DynamicFilledForms trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFilledForms] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFilledForms trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, DynamicFilledForms _DynamicFilledForms)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFilledForms] WHERE Id=@Id",
					"@Id", _DynamicFilledForms.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFilledForms trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[DynamicFilledForms] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa DynamicFilledForms trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<DynamicFilledForms> _DynamicFilledFormss)
		{
			foreach (DynamicFilledForms item in _DynamicFilledFormss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
