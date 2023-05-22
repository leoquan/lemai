using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSkpiaccounttargetruntime:IGSkpiaccounttargetruntime
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSkpiaccounttargetruntime(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsKPIAccountTargetRuntime từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPIAccountTargetRuntime]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsKPIAccountTargetRuntime từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPIAccountTargetRuntime] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsKPIAccountTargetRuntime từ Database
		/// </summary>
		public List<GsKPIAccountTargetRuntime> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPIAccountTargetRuntime]");
				List<GsKPIAccountTargetRuntime> items = new List<GsKPIAccountTargetRuntime>();
				GsKPIAccountTargetRuntime item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsKPIAccountTargetRuntime();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_AccountEmployee"] != null && dr["FK_AccountEmployee"] != DBNull.Value)
					{
						item.FK_AccountEmployee = Convert.ToString(dr["FK_AccountEmployee"]);
					}
					if (dr["FK_KPITarget"] != null && dr["FK_KPITarget"] != DBNull.Value)
					{
						item.FK_KPITarget = Convert.ToString(dr["FK_KPITarget"]);
					}
					if (dr["KPIValue"] != null && dr["KPIValue"] != DBNull.Value)
					{
						item.KPIValue = Convert.ToInt32(dr["KPIValue"]);
					}
					if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
					{
						item.CreateUser = Convert.ToString(dr["CreateUser"]);
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
		/// Lấy danh sách GsKPIAccountTargetRuntime từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsKPIAccountTargetRuntime> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsKPIAccountTargetRuntime] A "+ condition,  parameters);
				List<GsKPIAccountTargetRuntime> items = new List<GsKPIAccountTargetRuntime>();
				GsKPIAccountTargetRuntime item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsKPIAccountTargetRuntime();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_AccountEmployee"] != null && dr["FK_AccountEmployee"] != DBNull.Value)
					{
						item.FK_AccountEmployee = Convert.ToString(dr["FK_AccountEmployee"]);
					}
					if (dr["FK_KPITarget"] != null && dr["FK_KPITarget"] != DBNull.Value)
					{
						item.FK_KPITarget = Convert.ToString(dr["FK_KPITarget"]);
					}
					if (dr["KPIValue"] != null && dr["KPIValue"] != DBNull.Value)
					{
						item.KPIValue = Convert.ToInt32(dr["KPIValue"]);
					}
					if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
					{
						item.CreateUser = Convert.ToString(dr["CreateUser"]);
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

		public List<GsKPIAccountTargetRuntime> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsKPIAccountTargetRuntime] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsKPIAccountTargetRuntime] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsKPIAccountTargetRuntime>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsKPIAccountTargetRuntime từ Database
		/// </summary>
		public GsKPIAccountTargetRuntime GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPIAccountTargetRuntime] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsKPIAccountTargetRuntime item=new GsKPIAccountTargetRuntime();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_AccountEmployee"] != null && dr["FK_AccountEmployee"] != DBNull.Value)
						{
							item.FK_AccountEmployee = Convert.ToString(dr["FK_AccountEmployee"]);
						}
						if (dr["FK_KPITarget"] != null && dr["FK_KPITarget"] != DBNull.Value)
						{
							item.FK_KPITarget = Convert.ToString(dr["FK_KPITarget"]);
						}
						if (dr["KPIValue"] != null && dr["KPIValue"] != DBNull.Value)
						{
							item.KPIValue = Convert.ToInt32(dr["KPIValue"]);
						}
						if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
						{
							item.CreateUser = Convert.ToString(dr["CreateUser"]);
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
		/// Lấy một GsKPIAccountTargetRuntime đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsKPIAccountTargetRuntime GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsKPIAccountTargetRuntime] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsKPIAccountTargetRuntime item=new GsKPIAccountTargetRuntime();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_AccountEmployee"] != null && dr["FK_AccountEmployee"] != DBNull.Value)
						{
							item.FK_AccountEmployee = Convert.ToString(dr["FK_AccountEmployee"]);
						}
						if (dr["FK_KPITarget"] != null && dr["FK_KPITarget"] != DBNull.Value)
						{
							item.FK_KPITarget = Convert.ToString(dr["FK_KPITarget"]);
						}
						if (dr["KPIValue"] != null && dr["KPIValue"] != DBNull.Value)
						{
							item.KPIValue = Convert.ToInt32(dr["KPIValue"]);
						}
						if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
						{
							item.CreateUser = Convert.ToString(dr["CreateUser"]);
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

		public GsKPIAccountTargetRuntime GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsKPIAccountTargetRuntime] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsKPIAccountTargetRuntime>(ds);
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
		/// Thêm mới GsKPIAccountTargetRuntime vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsKPIAccountTargetRuntime _GsKPIAccountTargetRuntime)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsKPIAccountTargetRuntime](Id, FK_AccountEmployee, FK_KPITarget, KPIValue, CreateUser, CreateDate) VALUES(@Id, @FK_AccountEmployee, @FK_KPITarget, @KPIValue, @CreateUser, @CreateDate)", 
					"@Id",  _GsKPIAccountTargetRuntime.Id, 
					"@FK_AccountEmployee",  _GsKPIAccountTargetRuntime.FK_AccountEmployee, 
					"@FK_KPITarget",  _GsKPIAccountTargetRuntime.FK_KPITarget, 
					"@KPIValue",  _GsKPIAccountTargetRuntime.KPIValue, 
					"@CreateUser",  _GsKPIAccountTargetRuntime.CreateUser, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsKPIAccountTargetRuntime.CreateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsKPIAccountTargetRuntime vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsKPIAccountTargetRuntime> _GsKPIAccountTargetRuntimes)
		{
			foreach (GsKPIAccountTargetRuntime item in _GsKPIAccountTargetRuntimes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsKPIAccountTargetRuntime vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsKPIAccountTargetRuntime _GsKPIAccountTargetRuntime, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPIAccountTargetRuntime] SET Id=@Id, FK_AccountEmployee=@FK_AccountEmployee, FK_KPITarget=@FK_KPITarget, KPIValue=@KPIValue, CreateUser=@CreateUser, CreateDate=@CreateDate WHERE Id=@Id", 
					"@Id",  _GsKPIAccountTargetRuntime.Id, 
					"@FK_AccountEmployee",  _GsKPIAccountTargetRuntime.FK_AccountEmployee, 
					"@FK_KPITarget",  _GsKPIAccountTargetRuntime.FK_KPITarget, 
					"@KPIValue",  _GsKPIAccountTargetRuntime.KPIValue, 
					"@CreateUser",  _GsKPIAccountTargetRuntime.CreateUser, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsKPIAccountTargetRuntime.CreateDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsKPIAccountTargetRuntime vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsKPIAccountTargetRuntime _GsKPIAccountTargetRuntime)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPIAccountTargetRuntime] SET FK_AccountEmployee=@FK_AccountEmployee, FK_KPITarget=@FK_KPITarget, KPIValue=@KPIValue, CreateUser=@CreateUser, CreateDate=@CreateDate WHERE Id=@Id", 
					"@FK_AccountEmployee",  _GsKPIAccountTargetRuntime.FK_AccountEmployee, 
					"@FK_KPITarget",  _GsKPIAccountTargetRuntime.FK_KPITarget, 
					"@KPIValue",  _GsKPIAccountTargetRuntime.KPIValue, 
					"@CreateUser",  _GsKPIAccountTargetRuntime.CreateUser, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsKPIAccountTargetRuntime.CreateDate), 
					"@Id", _GsKPIAccountTargetRuntime.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsKPIAccountTargetRuntime vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsKPIAccountTargetRuntime> _GsKPIAccountTargetRuntimes)
		{
			foreach (GsKPIAccountTargetRuntime item in _GsKPIAccountTargetRuntimes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsKPIAccountTargetRuntime vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsKPIAccountTargetRuntime _GsKPIAccountTargetRuntime, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPIAccountTargetRuntime] SET Id=@Id, FK_AccountEmployee=@FK_AccountEmployee, FK_KPITarget=@FK_KPITarget, KPIValue=@KPIValue, CreateUser=@CreateUser, CreateDate=@CreateDate "+ condition, 
					"@Id",  _GsKPIAccountTargetRuntime.Id, 
					"@FK_AccountEmployee",  _GsKPIAccountTargetRuntime.FK_AccountEmployee, 
					"@FK_KPITarget",  _GsKPIAccountTargetRuntime.FK_KPITarget, 
					"@KPIValue",  _GsKPIAccountTargetRuntime.KPIValue, 
					"@CreateUser",  _GsKPIAccountTargetRuntime.CreateUser, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsKPIAccountTargetRuntime.CreateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsKPIAccountTargetRuntime trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPIAccountTargetRuntime] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPIAccountTargetRuntime trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsKPIAccountTargetRuntime _GsKPIAccountTargetRuntime)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPIAccountTargetRuntime] WHERE Id=@Id",
					"@Id", _GsKPIAccountTargetRuntime.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPIAccountTargetRuntime trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPIAccountTargetRuntime] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPIAccountTargetRuntime trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsKPIAccountTargetRuntime> _GsKPIAccountTargetRuntimes)
		{
			foreach (GsKPIAccountTargetRuntime item in _GsKPIAccountTargetRuntimes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
