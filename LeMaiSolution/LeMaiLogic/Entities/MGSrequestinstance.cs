using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSrequestinstance:IGSrequestinstance
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSrequestinstance(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsRequestInstance từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestInstance]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsRequestInstance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestInstance] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsRequestInstance từ Database
		/// </summary>
		public List<GsRequestInstance> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestInstance]");
				List<GsRequestInstance> items = new List<GsRequestInstance>();
				GsRequestInstance item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsRequestInstance();
					if (dr["FK_RequestProduct"] != null && dr["FK_RequestProduct"] != DBNull.Value)
					{
						item.FK_RequestProduct = Convert.ToString(dr["FK_RequestProduct"]);
					}
					if (dr["FK_StepDef"] != null && dr["FK_StepDef"] != DBNull.Value)
					{
						item.FK_StepDef = Convert.ToString(dr["FK_StepDef"]);
					}
					if (dr["FK_AssignGroup"] != null && dr["FK_AssignGroup"] != DBNull.Value)
					{
						item.FK_AssignGroup = Convert.ToString(dr["FK_AssignGroup"]);
					}
					if (dr["FK_AssignAccount"] != null && dr["FK_AssignAccount"] != DBNull.Value)
					{
						item.FK_AssignAccount = Convert.ToString(dr["FK_AssignAccount"]);
					}
					if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
					{
						item.StartDate = Convert.ToDateTime(dr["StartDate"]);
					}
					if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
					{
						item.EndDate = Convert.ToDateTime(dr["EndDate"]);
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
		/// Lấy danh sách GsRequestInstance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsRequestInstance> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsRequestInstance] A "+ condition,  parameters);
				List<GsRequestInstance> items = new List<GsRequestInstance>();
				GsRequestInstance item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsRequestInstance();
					if (dr["FK_RequestProduct"] != null && dr["FK_RequestProduct"] != DBNull.Value)
					{
						item.FK_RequestProduct = Convert.ToString(dr["FK_RequestProduct"]);
					}
					if (dr["FK_StepDef"] != null && dr["FK_StepDef"] != DBNull.Value)
					{
						item.FK_StepDef = Convert.ToString(dr["FK_StepDef"]);
					}
					if (dr["FK_AssignGroup"] != null && dr["FK_AssignGroup"] != DBNull.Value)
					{
						item.FK_AssignGroup = Convert.ToString(dr["FK_AssignGroup"]);
					}
					if (dr["FK_AssignAccount"] != null && dr["FK_AssignAccount"] != DBNull.Value)
					{
						item.FK_AssignAccount = Convert.ToString(dr["FK_AssignAccount"]);
					}
					if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
					{
						item.StartDate = Convert.ToDateTime(dr["StartDate"]);
					}
					if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
					{
						item.EndDate = Convert.ToDateTime(dr["EndDate"]);
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

		public List<GsRequestInstance> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsRequestInstance] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsRequestInstance] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsRequestInstance>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsRequestInstance từ Database
		/// </summary>
		public GsRequestInstance GetObject(string schema, String FK_RequestProduct, String FK_StepDef)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestInstance] where FK_RequestProduct=@FK_RequestProduct and FK_StepDef=@FK_StepDef",
					"@FK_RequestProduct", FK_RequestProduct, 
					"@FK_StepDef", FK_StepDef);
				if (ds.Rows.Count > 0)
				{
					GsRequestInstance item=new GsRequestInstance();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_RequestProduct"] != null && dr["FK_RequestProduct"] != DBNull.Value)
						{
							item.FK_RequestProduct = Convert.ToString(dr["FK_RequestProduct"]);
						}
						if (dr["FK_StepDef"] != null && dr["FK_StepDef"] != DBNull.Value)
						{
							item.FK_StepDef = Convert.ToString(dr["FK_StepDef"]);
						}
						if (dr["FK_AssignGroup"] != null && dr["FK_AssignGroup"] != DBNull.Value)
						{
							item.FK_AssignGroup = Convert.ToString(dr["FK_AssignGroup"]);
						}
						if (dr["FK_AssignAccount"] != null && dr["FK_AssignAccount"] != DBNull.Value)
						{
							item.FK_AssignAccount = Convert.ToString(dr["FK_AssignAccount"]);
						}
						if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
						{
							item.StartDate = Convert.ToDateTime(dr["StartDate"]);
						}
						if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
						{
							item.EndDate = Convert.ToDateTime(dr["EndDate"]);
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
		/// Lấy một GsRequestInstance đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsRequestInstance GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsRequestInstance] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsRequestInstance item=new GsRequestInstance();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_RequestProduct"] != null && dr["FK_RequestProduct"] != DBNull.Value)
						{
							item.FK_RequestProduct = Convert.ToString(dr["FK_RequestProduct"]);
						}
						if (dr["FK_StepDef"] != null && dr["FK_StepDef"] != DBNull.Value)
						{
							item.FK_StepDef = Convert.ToString(dr["FK_StepDef"]);
						}
						if (dr["FK_AssignGroup"] != null && dr["FK_AssignGroup"] != DBNull.Value)
						{
							item.FK_AssignGroup = Convert.ToString(dr["FK_AssignGroup"]);
						}
						if (dr["FK_AssignAccount"] != null && dr["FK_AssignAccount"] != DBNull.Value)
						{
							item.FK_AssignAccount = Convert.ToString(dr["FK_AssignAccount"]);
						}
						if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
						{
							item.StartDate = Convert.ToDateTime(dr["StartDate"]);
						}
						if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
						{
							item.EndDate = Convert.ToDateTime(dr["EndDate"]);
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

		public GsRequestInstance GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsRequestInstance] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsRequestInstance>(ds);
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
		/// Thêm mới GsRequestInstance vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsRequestInstance _GsRequestInstance)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsRequestInstance](FK_RequestProduct, FK_StepDef, FK_AssignGroup, FK_AssignAccount, StartDate, EndDate) VALUES(@FK_RequestProduct, @FK_StepDef, @FK_AssignGroup, @FK_AssignAccount, @StartDate, @EndDate)", 
					"@FK_RequestProduct",  _GsRequestInstance.FK_RequestProduct, 
					"@FK_StepDef",  _GsRequestInstance.FK_StepDef, 
					"@FK_AssignGroup",  _GsRequestInstance.FK_AssignGroup, 
					"@FK_AssignAccount",  _GsRequestInstance.FK_AssignAccount, 
					"@StartDate", this._dataContext.ConvertDateString( _GsRequestInstance.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _GsRequestInstance.EndDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsRequestInstance vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsRequestInstance> _GsRequestInstances)
		{
			foreach (GsRequestInstance item in _GsRequestInstances)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsRequestInstance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsRequestInstance _GsRequestInstance, String FK_RequestProduct, String FK_StepDef)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsRequestInstance] SET FK_RequestProduct=@FK_RequestProduct, FK_StepDef=@FK_StepDef, FK_AssignGroup=@FK_AssignGroup, FK_AssignAccount=@FK_AssignAccount, StartDate=@StartDate, EndDate=@EndDate WHERE FK_RequestProduct=@FK_RequestProduct and FK_StepDef=@FK_StepDef", 
					"@FK_RequestProduct",  _GsRequestInstance.FK_RequestProduct, 
					"@FK_StepDef",  _GsRequestInstance.FK_StepDef, 
					"@FK_AssignGroup",  _GsRequestInstance.FK_AssignGroup, 
					"@FK_AssignAccount",  _GsRequestInstance.FK_AssignAccount, 
					"@StartDate", this._dataContext.ConvertDateString( _GsRequestInstance.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _GsRequestInstance.EndDate), 
					"@FK_RequestProduct", FK_RequestProduct, 
					"@FK_StepDef", FK_StepDef);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsRequestInstance vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsRequestInstance _GsRequestInstance)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsRequestInstance] SET FK_AssignGroup=@FK_AssignGroup, FK_AssignAccount=@FK_AssignAccount, StartDate=@StartDate, EndDate=@EndDate WHERE FK_RequestProduct=@FK_RequestProduct and FK_StepDef=@FK_StepDef", 
					"@FK_AssignGroup",  _GsRequestInstance.FK_AssignGroup, 
					"@FK_AssignAccount",  _GsRequestInstance.FK_AssignAccount, 
					"@StartDate", this._dataContext.ConvertDateString( _GsRequestInstance.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _GsRequestInstance.EndDate), 
					"@FK_RequestProduct", _GsRequestInstance.FK_RequestProduct, 
					"@FK_StepDef", _GsRequestInstance.FK_StepDef);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsRequestInstance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsRequestInstance> _GsRequestInstances)
		{
			foreach (GsRequestInstance item in _GsRequestInstances)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsRequestInstance vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsRequestInstance _GsRequestInstance, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsRequestInstance] SET FK_RequestProduct=@FK_RequestProduct, FK_StepDef=@FK_StepDef, FK_AssignGroup=@FK_AssignGroup, FK_AssignAccount=@FK_AssignAccount, StartDate=@StartDate, EndDate=@EndDate "+ condition, 
					"@FK_RequestProduct",  _GsRequestInstance.FK_RequestProduct, 
					"@FK_StepDef",  _GsRequestInstance.FK_StepDef, 
					"@FK_AssignGroup",  _GsRequestInstance.FK_AssignGroup, 
					"@FK_AssignAccount",  _GsRequestInstance.FK_AssignAccount, 
					"@StartDate", this._dataContext.ConvertDateString( _GsRequestInstance.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _GsRequestInstance.EndDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsRequestInstance trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_RequestProduct, String FK_StepDef)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsRequestInstance] WHERE FK_RequestProduct=@FK_RequestProduct and FK_StepDef=@FK_StepDef",
					"@FK_RequestProduct", FK_RequestProduct, 
					"@FK_StepDef", FK_StepDef);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsRequestInstance trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsRequestInstance _GsRequestInstance)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsRequestInstance] WHERE FK_RequestProduct=@FK_RequestProduct and FK_StepDef=@FK_StepDef",
					"@FK_RequestProduct", _GsRequestInstance.FK_RequestProduct, 
					"@FK_StepDef", _GsRequestInstance.FK_StepDef);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsRequestInstance trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsRequestInstance] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsRequestInstance trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsRequestInstance> _GsRequestInstances)
		{
			foreach (GsRequestInstance item in _GsRequestInstances)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
