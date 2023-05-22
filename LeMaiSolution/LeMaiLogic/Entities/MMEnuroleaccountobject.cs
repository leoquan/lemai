using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEnuroleaccountobject:IMEnuroleaccountobject
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEnuroleaccountobject(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MenuRole_AccountObject từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuRole_AccountObject]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MenuRole_AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuRole_AccountObject] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MenuRole_AccountObject từ Database
		/// </summary>
		public List<MenuRole_AccountObject> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuRole_AccountObject]");
				List<MenuRole_AccountObject> items = new List<MenuRole_AccountObject>();
				MenuRole_AccountObject item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuRole_AccountObject();
					if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
					{
						item.FK_Role = Convert.ToString(dr["FK_Role"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["AtCreatedDate"] != null && dr["AtCreatedDate"] != DBNull.Value)
					{
						item.AtCreatedDate = Convert.ToDateTime(dr["AtCreatedDate"]);
					}
					if (dr["AtCreatedBy"] != null && dr["AtCreatedBy"] != DBNull.Value)
					{
						item.AtCreatedBy = Convert.ToString(dr["AtCreatedBy"]);
					}
					if (dr["AtLastModifiedDate"] != null && dr["AtLastModifiedDate"] != DBNull.Value)
					{
						item.AtLastModifiedDate = Convert.ToDateTime(dr["AtLastModifiedDate"]);
					}
					if (dr["AtLastModifiedBy"] != null && dr["AtLastModifiedBy"] != DBNull.Value)
					{
						item.AtLastModifiedBy = Convert.ToString(dr["AtLastModifiedBy"]);
					}
					if (dr["AtRowStatus"] != null && dr["AtRowStatus"] != DBNull.Value)
					{
						item.AtRowStatus = Convert.ToInt32(dr["AtRowStatus"]);
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
		/// Lấy danh sách MenuRole_AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MenuRole_AccountObject> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuRole_AccountObject] A "+ condition,  parameters);
				List<MenuRole_AccountObject> items = new List<MenuRole_AccountObject>();
				MenuRole_AccountObject item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuRole_AccountObject();
					if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
					{
						item.FK_Role = Convert.ToString(dr["FK_Role"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["AtCreatedDate"] != null && dr["AtCreatedDate"] != DBNull.Value)
					{
						item.AtCreatedDate = Convert.ToDateTime(dr["AtCreatedDate"]);
					}
					if (dr["AtCreatedBy"] != null && dr["AtCreatedBy"] != DBNull.Value)
					{
						item.AtCreatedBy = Convert.ToString(dr["AtCreatedBy"]);
					}
					if (dr["AtLastModifiedDate"] != null && dr["AtLastModifiedDate"] != DBNull.Value)
					{
						item.AtLastModifiedDate = Convert.ToDateTime(dr["AtLastModifiedDate"]);
					}
					if (dr["AtLastModifiedBy"] != null && dr["AtLastModifiedBy"] != DBNull.Value)
					{
						item.AtLastModifiedBy = Convert.ToString(dr["AtLastModifiedBy"]);
					}
					if (dr["AtRowStatus"] != null && dr["AtRowStatus"] != DBNull.Value)
					{
						item.AtRowStatus = Convert.ToInt32(dr["AtRowStatus"]);
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

		public List<MenuRole_AccountObject> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuRole_AccountObject] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MenuRole_AccountObject] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MenuRole_AccountObject>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MenuRole_AccountObject từ Database
		/// </summary>
		public MenuRole_AccountObject GetObject(string schema, String FK_Role, String FK_AccountObject)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuRole_AccountObject] where FK_Role=@FK_Role and FK_AccountObject=@FK_AccountObject",
					"@FK_Role", FK_Role, 
					"@FK_AccountObject", FK_AccountObject);
				if (ds.Rows.Count > 0)
				{
					MenuRole_AccountObject item=new MenuRole_AccountObject();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
						{
							item.FK_Role = Convert.ToString(dr["FK_Role"]);
						}
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["AtCreatedDate"] != null && dr["AtCreatedDate"] != DBNull.Value)
						{
							item.AtCreatedDate = Convert.ToDateTime(dr["AtCreatedDate"]);
						}
						if (dr["AtCreatedBy"] != null && dr["AtCreatedBy"] != DBNull.Value)
						{
							item.AtCreatedBy = Convert.ToString(dr["AtCreatedBy"]);
						}
						if (dr["AtLastModifiedDate"] != null && dr["AtLastModifiedDate"] != DBNull.Value)
						{
							item.AtLastModifiedDate = Convert.ToDateTime(dr["AtLastModifiedDate"]);
						}
						if (dr["AtLastModifiedBy"] != null && dr["AtLastModifiedBy"] != DBNull.Value)
						{
							item.AtLastModifiedBy = Convert.ToString(dr["AtLastModifiedBy"]);
						}
						if (dr["AtRowStatus"] != null && dr["AtRowStatus"] != DBNull.Value)
						{
							item.AtRowStatus = Convert.ToInt32(dr["AtRowStatus"]);
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
		/// Lấy một MenuRole_AccountObject đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MenuRole_AccountObject GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuRole_AccountObject] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MenuRole_AccountObject item=new MenuRole_AccountObject();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_Role"] != null && dr["FK_Role"] != DBNull.Value)
						{
							item.FK_Role = Convert.ToString(dr["FK_Role"]);
						}
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["AtCreatedDate"] != null && dr["AtCreatedDate"] != DBNull.Value)
						{
							item.AtCreatedDate = Convert.ToDateTime(dr["AtCreatedDate"]);
						}
						if (dr["AtCreatedBy"] != null && dr["AtCreatedBy"] != DBNull.Value)
						{
							item.AtCreatedBy = Convert.ToString(dr["AtCreatedBy"]);
						}
						if (dr["AtLastModifiedDate"] != null && dr["AtLastModifiedDate"] != DBNull.Value)
						{
							item.AtLastModifiedDate = Convert.ToDateTime(dr["AtLastModifiedDate"]);
						}
						if (dr["AtLastModifiedBy"] != null && dr["AtLastModifiedBy"] != DBNull.Value)
						{
							item.AtLastModifiedBy = Convert.ToString(dr["AtLastModifiedBy"]);
						}
						if (dr["AtRowStatus"] != null && dr["AtRowStatus"] != DBNull.Value)
						{
							item.AtRowStatus = Convert.ToInt32(dr["AtRowStatus"]);
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

		public MenuRole_AccountObject GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuRole_AccountObject] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MenuRole_AccountObject>(ds);
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
		/// Thêm mới MenuRole_AccountObject vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MenuRole_AccountObject _MenuRole_AccountObject)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MenuRole_AccountObject](FK_Role, FK_AccountObject, AtCreatedDate, AtCreatedBy, AtLastModifiedDate, AtLastModifiedBy, AtRowStatus) VALUES(@FK_Role, @FK_AccountObject, @AtCreatedDate, @AtCreatedBy, @AtLastModifiedDate, @AtLastModifiedBy, @AtRowStatus)", 
					"@FK_Role",  _MenuRole_AccountObject.FK_Role, 
					"@FK_AccountObject",  _MenuRole_AccountObject.FK_AccountObject, 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _MenuRole_AccountObject.AtCreatedDate), 
					"@AtCreatedBy",  _MenuRole_AccountObject.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _MenuRole_AccountObject.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _MenuRole_AccountObject.AtLastModifiedBy, 
					"@AtRowStatus",  _MenuRole_AccountObject.AtRowStatus);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MenuRole_AccountObject vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MenuRole_AccountObject> _MenuRole_AccountObjects)
		{
			foreach (MenuRole_AccountObject item in _MenuRole_AccountObjects)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuRole_AccountObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MenuRole_AccountObject _MenuRole_AccountObject, String FK_Role, String FK_AccountObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuRole_AccountObject] SET FK_Role=@FK_Role, FK_AccountObject=@FK_AccountObject, AtCreatedDate=@AtCreatedDate, AtCreatedBy=@AtCreatedBy, AtLastModifiedDate=@AtLastModifiedDate, AtLastModifiedBy=@AtLastModifiedBy, AtRowStatus=@AtRowStatus WHERE FK_Role=@FK_Role and FK_AccountObject=@FK_AccountObject", 
					"@FK_Role",  _MenuRole_AccountObject.FK_Role, 
					"@FK_AccountObject",  _MenuRole_AccountObject.FK_AccountObject, 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _MenuRole_AccountObject.AtCreatedDate), 
					"@AtCreatedBy",  _MenuRole_AccountObject.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _MenuRole_AccountObject.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _MenuRole_AccountObject.AtLastModifiedBy, 
					"@AtRowStatus",  _MenuRole_AccountObject.AtRowStatus, 
					"@FK_Role", FK_Role, 
					"@FK_AccountObject", FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MenuRole_AccountObject vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MenuRole_AccountObject _MenuRole_AccountObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuRole_AccountObject] SET AtCreatedDate=@AtCreatedDate, AtCreatedBy=@AtCreatedBy, AtLastModifiedDate=@AtLastModifiedDate, AtLastModifiedBy=@AtLastModifiedBy, AtRowStatus=@AtRowStatus WHERE FK_Role=@FK_Role and FK_AccountObject=@FK_AccountObject", 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _MenuRole_AccountObject.AtCreatedDate), 
					"@AtCreatedBy",  _MenuRole_AccountObject.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _MenuRole_AccountObject.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _MenuRole_AccountObject.AtLastModifiedBy, 
					"@AtRowStatus",  _MenuRole_AccountObject.AtRowStatus, 
					"@FK_Role", _MenuRole_AccountObject.FK_Role, 
					"@FK_AccountObject", _MenuRole_AccountObject.FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MenuRole_AccountObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MenuRole_AccountObject> _MenuRole_AccountObjects)
		{
			foreach (MenuRole_AccountObject item in _MenuRole_AccountObjects)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuRole_AccountObject vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MenuRole_AccountObject _MenuRole_AccountObject, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuRole_AccountObject] SET FK_Role=@FK_Role, FK_AccountObject=@FK_AccountObject, AtCreatedDate=@AtCreatedDate, AtCreatedBy=@AtCreatedBy, AtLastModifiedDate=@AtLastModifiedDate, AtLastModifiedBy=@AtLastModifiedBy, AtRowStatus=@AtRowStatus "+ condition, 
					"@FK_Role",  _MenuRole_AccountObject.FK_Role, 
					"@FK_AccountObject",  _MenuRole_AccountObject.FK_AccountObject, 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _MenuRole_AccountObject.AtCreatedDate), 
					"@AtCreatedBy",  _MenuRole_AccountObject.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _MenuRole_AccountObject.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _MenuRole_AccountObject.AtLastModifiedBy, 
					"@AtRowStatus",  _MenuRole_AccountObject.AtRowStatus);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MenuRole_AccountObject trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_Role, String FK_AccountObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuRole_AccountObject] WHERE FK_Role=@FK_Role and FK_AccountObject=@FK_AccountObject",
					"@FK_Role", FK_Role, 
					"@FK_AccountObject", FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuRole_AccountObject trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MenuRole_AccountObject _MenuRole_AccountObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuRole_AccountObject] WHERE FK_Role=@FK_Role and FK_AccountObject=@FK_AccountObject",
					"@FK_Role", _MenuRole_AccountObject.FK_Role, 
					"@FK_AccountObject", _MenuRole_AccountObject.FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuRole_AccountObject trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuRole_AccountObject] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuRole_AccountObject trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MenuRole_AccountObject> _MenuRole_AccountObjects)
		{
			foreach (MenuRole_AccountObject item in _MenuRole_AccountObjects)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
