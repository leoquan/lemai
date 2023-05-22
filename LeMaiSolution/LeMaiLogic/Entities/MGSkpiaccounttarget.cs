using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSkpiaccounttarget:IGSkpiaccounttarget
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSkpiaccounttarget(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsKPIAccountTarget từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPIAccountTarget]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsKPIAccountTarget từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPIAccountTarget] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsKPIAccountTarget từ Database
		/// </summary>
		public List<GsKPIAccountTarget> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPIAccountTarget]");
				List<GsKPIAccountTarget> items = new List<GsKPIAccountTarget>();
				GsKPIAccountTarget item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsKPIAccountTarget();
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
					if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
					{
						item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
					}
					if (dr["RegisterValue"] != null && dr["RegisterValue"] != DBNull.Value)
					{
						item.RegisterValue = Convert.ToInt32(dr["RegisterValue"]);
					}
					if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
					{
						item.CreateUser = Convert.ToString(dr["CreateUser"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["UpdateUser"] != null && dr["UpdateUser"] != DBNull.Value)
					{
						item.UpdateUser = Convert.ToString(dr["UpdateUser"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["IsValid"] != null && dr["IsValid"] != DBNull.Value)
					{
						item.IsValid = Convert.ToBoolean(dr["IsValid"]);
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
		/// Lấy danh sách GsKPIAccountTarget từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsKPIAccountTarget> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsKPIAccountTarget] A "+ condition,  parameters);
				List<GsKPIAccountTarget> items = new List<GsKPIAccountTarget>();
				GsKPIAccountTarget item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsKPIAccountTarget();
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
					if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
					{
						item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
					}
					if (dr["RegisterValue"] != null && dr["RegisterValue"] != DBNull.Value)
					{
						item.RegisterValue = Convert.ToInt32(dr["RegisterValue"]);
					}
					if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
					{
						item.CreateUser = Convert.ToString(dr["CreateUser"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["UpdateUser"] != null && dr["UpdateUser"] != DBNull.Value)
					{
						item.UpdateUser = Convert.ToString(dr["UpdateUser"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["IsValid"] != null && dr["IsValid"] != DBNull.Value)
					{
						item.IsValid = Convert.ToBoolean(dr["IsValid"]);
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

		public List<GsKPIAccountTarget> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsKPIAccountTarget] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsKPIAccountTarget] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsKPIAccountTarget>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsKPIAccountTarget từ Database
		/// </summary>
		public GsKPIAccountTarget GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPIAccountTarget] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsKPIAccountTarget item=new GsKPIAccountTarget();
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
						if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
						{
							item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
						}
						if (dr["RegisterValue"] != null && dr["RegisterValue"] != DBNull.Value)
						{
							item.RegisterValue = Convert.ToInt32(dr["RegisterValue"]);
						}
						if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
						{
							item.CreateUser = Convert.ToString(dr["CreateUser"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["UpdateUser"] != null && dr["UpdateUser"] != DBNull.Value)
						{
							item.UpdateUser = Convert.ToString(dr["UpdateUser"]);
						}
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
						}
						if (dr["IsValid"] != null && dr["IsValid"] != DBNull.Value)
						{
							item.IsValid = Convert.ToBoolean(dr["IsValid"]);
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
		/// Lấy một GsKPIAccountTarget đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsKPIAccountTarget GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsKPIAccountTarget] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsKPIAccountTarget item=new GsKPIAccountTarget();
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
						if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
						{
							item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
						}
						if (dr["RegisterValue"] != null && dr["RegisterValue"] != DBNull.Value)
						{
							item.RegisterValue = Convert.ToInt32(dr["RegisterValue"]);
						}
						if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
						{
							item.CreateUser = Convert.ToString(dr["CreateUser"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["UpdateUser"] != null && dr["UpdateUser"] != DBNull.Value)
						{
							item.UpdateUser = Convert.ToString(dr["UpdateUser"]);
						}
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
						}
						if (dr["IsValid"] != null && dr["IsValid"] != DBNull.Value)
						{
							item.IsValid = Convert.ToBoolean(dr["IsValid"]);
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

		public GsKPIAccountTarget GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsKPIAccountTarget] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsKPIAccountTarget>(ds);
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
		/// Thêm mới GsKPIAccountTarget vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsKPIAccountTarget _GsKPIAccountTarget)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsKPIAccountTarget](Id, FK_AccountEmployee, FK_KPITarget, RegisterDate, RegisterValue, CreateUser, CreateDate, UpdateUser, UpdateDate, IsValid) VALUES(@Id, @FK_AccountEmployee, @FK_KPITarget, @RegisterDate, @RegisterValue, @CreateUser, @CreateDate, @UpdateUser, @UpdateDate, @IsValid)", 
					"@Id",  _GsKPIAccountTarget.Id, 
					"@FK_AccountEmployee",  _GsKPIAccountTarget.FK_AccountEmployee, 
					"@FK_KPITarget",  _GsKPIAccountTarget.FK_KPITarget, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.RegisterDate), 
					"@RegisterValue",  _GsKPIAccountTarget.RegisterValue, 
					"@CreateUser",  _GsKPIAccountTarget.CreateUser, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.CreateDate), 
					"@UpdateUser",  _GsKPIAccountTarget.UpdateUser, 
					"@UpdateDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.UpdateDate), 
					"@IsValid",  _GsKPIAccountTarget.IsValid);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsKPIAccountTarget vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsKPIAccountTarget> _GsKPIAccountTargets)
		{
			foreach (GsKPIAccountTarget item in _GsKPIAccountTargets)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsKPIAccountTarget vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsKPIAccountTarget _GsKPIAccountTarget, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPIAccountTarget] SET Id=@Id, FK_AccountEmployee=@FK_AccountEmployee, FK_KPITarget=@FK_KPITarget, RegisterDate=@RegisterDate, RegisterValue=@RegisterValue, CreateUser=@CreateUser, CreateDate=@CreateDate, UpdateUser=@UpdateUser, UpdateDate=@UpdateDate, IsValid=@IsValid WHERE Id=@Id", 
					"@Id",  _GsKPIAccountTarget.Id, 
					"@FK_AccountEmployee",  _GsKPIAccountTarget.FK_AccountEmployee, 
					"@FK_KPITarget",  _GsKPIAccountTarget.FK_KPITarget, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.RegisterDate), 
					"@RegisterValue",  _GsKPIAccountTarget.RegisterValue, 
					"@CreateUser",  _GsKPIAccountTarget.CreateUser, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.CreateDate), 
					"@UpdateUser",  _GsKPIAccountTarget.UpdateUser, 
					"@UpdateDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.UpdateDate), 
					"@IsValid",  _GsKPIAccountTarget.IsValid, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsKPIAccountTarget vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsKPIAccountTarget _GsKPIAccountTarget)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPIAccountTarget] SET FK_AccountEmployee=@FK_AccountEmployee, FK_KPITarget=@FK_KPITarget, RegisterDate=@RegisterDate, RegisterValue=@RegisterValue, CreateUser=@CreateUser, CreateDate=@CreateDate, UpdateUser=@UpdateUser, UpdateDate=@UpdateDate, IsValid=@IsValid WHERE Id=@Id", 
					"@FK_AccountEmployee",  _GsKPIAccountTarget.FK_AccountEmployee, 
					"@FK_KPITarget",  _GsKPIAccountTarget.FK_KPITarget, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.RegisterDate), 
					"@RegisterValue",  _GsKPIAccountTarget.RegisterValue, 
					"@CreateUser",  _GsKPIAccountTarget.CreateUser, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.CreateDate), 
					"@UpdateUser",  _GsKPIAccountTarget.UpdateUser, 
					"@UpdateDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.UpdateDate), 
					"@IsValid",  _GsKPIAccountTarget.IsValid, 
					"@Id", _GsKPIAccountTarget.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsKPIAccountTarget vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsKPIAccountTarget> _GsKPIAccountTargets)
		{
			foreach (GsKPIAccountTarget item in _GsKPIAccountTargets)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsKPIAccountTarget vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsKPIAccountTarget _GsKPIAccountTarget, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPIAccountTarget] SET Id=@Id, FK_AccountEmployee=@FK_AccountEmployee, FK_KPITarget=@FK_KPITarget, RegisterDate=@RegisterDate, RegisterValue=@RegisterValue, CreateUser=@CreateUser, CreateDate=@CreateDate, UpdateUser=@UpdateUser, UpdateDate=@UpdateDate, IsValid=@IsValid "+ condition, 
					"@Id",  _GsKPIAccountTarget.Id, 
					"@FK_AccountEmployee",  _GsKPIAccountTarget.FK_AccountEmployee, 
					"@FK_KPITarget",  _GsKPIAccountTarget.FK_KPITarget, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.RegisterDate), 
					"@RegisterValue",  _GsKPIAccountTarget.RegisterValue, 
					"@CreateUser",  _GsKPIAccountTarget.CreateUser, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.CreateDate), 
					"@UpdateUser",  _GsKPIAccountTarget.UpdateUser, 
					"@UpdateDate", this._dataContext.ConvertDateString( _GsKPIAccountTarget.UpdateDate), 
					"@IsValid",  _GsKPIAccountTarget.IsValid);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsKPIAccountTarget trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPIAccountTarget] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPIAccountTarget trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsKPIAccountTarget _GsKPIAccountTarget)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPIAccountTarget] WHERE Id=@Id",
					"@Id", _GsKPIAccountTarget.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPIAccountTarget trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPIAccountTarget] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPIAccountTarget trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsKPIAccountTarget> _GsKPIAccountTargets)
		{
			foreach (GsKPIAccountTarget item in _GsKPIAccountTargets)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
