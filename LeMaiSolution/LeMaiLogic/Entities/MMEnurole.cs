using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEnurole:IMEnurole
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEnurole(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MenuRole từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuRole]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MenuRole từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuRole] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MenuRole từ Database
		/// </summary>
		public List<MenuRole> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuRole]");
				List<MenuRole> items = new List<MenuRole>();
				MenuRole item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuRole();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["RoleName"] != null && dr["RoleName"] != DBNull.Value)
					{
						item.RoleName = Convert.ToString(dr["RoleName"]);
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
					if (dr["Prioty"] != null && dr["Prioty"] != DBNull.Value)
					{
						item.Prioty = Convert.ToInt32(dr["Prioty"]);
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
		/// Lấy danh sách MenuRole từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MenuRole> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuRole] A "+ condition,  parameters);
				List<MenuRole> items = new List<MenuRole>();
				MenuRole item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuRole();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["RoleName"] != null && dr["RoleName"] != DBNull.Value)
					{
						item.RoleName = Convert.ToString(dr["RoleName"]);
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
					if (dr["Prioty"] != null && dr["Prioty"] != DBNull.Value)
					{
						item.Prioty = Convert.ToInt32(dr["Prioty"]);
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

		public List<MenuRole> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuRole] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MenuRole] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MenuRole>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MenuRole từ Database
		/// </summary>
		public MenuRole GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuRole] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MenuRole item=new MenuRole();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["RoleName"] != null && dr["RoleName"] != DBNull.Value)
						{
							item.RoleName = Convert.ToString(dr["RoleName"]);
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
						if (dr["Prioty"] != null && dr["Prioty"] != DBNull.Value)
						{
							item.Prioty = Convert.ToInt32(dr["Prioty"]);
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
		/// Lấy một MenuRole đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MenuRole GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuRole] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MenuRole item=new MenuRole();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["RoleName"] != null && dr["RoleName"] != DBNull.Value)
						{
							item.RoleName = Convert.ToString(dr["RoleName"]);
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
						if (dr["Prioty"] != null && dr["Prioty"] != DBNull.Value)
						{
							item.Prioty = Convert.ToInt32(dr["Prioty"]);
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

		public MenuRole GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuRole] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MenuRole>(ds);
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
		/// Thêm mới MenuRole vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MenuRole _MenuRole)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MenuRole](Id, Code, RoleName, AtCreatedDate, AtCreatedBy, AtLastModifiedDate, AtLastModifiedBy, AtRowStatus, Prioty) VALUES(@Id, @Code, @RoleName, @AtCreatedDate, @AtCreatedBy, @AtLastModifiedDate, @AtLastModifiedBy, @AtRowStatus, @Prioty)", 
					"@Id",  _MenuRole.Id, 
					"@Code",  _MenuRole.Code, 
					"@RoleName",  _MenuRole.RoleName, 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _MenuRole.AtCreatedDate), 
					"@AtCreatedBy",  _MenuRole.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _MenuRole.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _MenuRole.AtLastModifiedBy, 
					"@AtRowStatus",  _MenuRole.AtRowStatus, 
					"@Prioty",  _MenuRole.Prioty);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MenuRole vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MenuRole> _MenuRoles)
		{
			foreach (MenuRole item in _MenuRoles)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuRole vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MenuRole _MenuRole, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuRole] SET Id=@Id, Code=@Code, RoleName=@RoleName, AtCreatedDate=@AtCreatedDate, AtCreatedBy=@AtCreatedBy, AtLastModifiedDate=@AtLastModifiedDate, AtLastModifiedBy=@AtLastModifiedBy, AtRowStatus=@AtRowStatus, Prioty=@Prioty WHERE Id=@Id", 
					"@Id",  _MenuRole.Id, 
					"@Code",  _MenuRole.Code, 
					"@RoleName",  _MenuRole.RoleName, 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _MenuRole.AtCreatedDate), 
					"@AtCreatedBy",  _MenuRole.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _MenuRole.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _MenuRole.AtLastModifiedBy, 
					"@AtRowStatus",  _MenuRole.AtRowStatus, 
					"@Prioty",  _MenuRole.Prioty, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MenuRole vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MenuRole _MenuRole)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuRole] SET Code=@Code, RoleName=@RoleName, AtCreatedDate=@AtCreatedDate, AtCreatedBy=@AtCreatedBy, AtLastModifiedDate=@AtLastModifiedDate, AtLastModifiedBy=@AtLastModifiedBy, AtRowStatus=@AtRowStatus, Prioty=@Prioty WHERE Id=@Id", 
					"@Code",  _MenuRole.Code, 
					"@RoleName",  _MenuRole.RoleName, 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _MenuRole.AtCreatedDate), 
					"@AtCreatedBy",  _MenuRole.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _MenuRole.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _MenuRole.AtLastModifiedBy, 
					"@AtRowStatus",  _MenuRole.AtRowStatus, 
					"@Prioty",  _MenuRole.Prioty, 
					"@Id", _MenuRole.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MenuRole vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MenuRole> _MenuRoles)
		{
			foreach (MenuRole item in _MenuRoles)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuRole vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MenuRole _MenuRole, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuRole] SET Id=@Id, Code=@Code, RoleName=@RoleName, AtCreatedDate=@AtCreatedDate, AtCreatedBy=@AtCreatedBy, AtLastModifiedDate=@AtLastModifiedDate, AtLastModifiedBy=@AtLastModifiedBy, AtRowStatus=@AtRowStatus, Prioty=@Prioty "+ condition, 
					"@Id",  _MenuRole.Id, 
					"@Code",  _MenuRole.Code, 
					"@RoleName",  _MenuRole.RoleName, 
					"@AtCreatedDate", this._dataContext.ConvertDateString( _MenuRole.AtCreatedDate), 
					"@AtCreatedBy",  _MenuRole.AtCreatedBy, 
					"@AtLastModifiedDate", this._dataContext.ConvertDateString( _MenuRole.AtLastModifiedDate), 
					"@AtLastModifiedBy",  _MenuRole.AtLastModifiedBy, 
					"@AtRowStatus",  _MenuRole.AtRowStatus, 
					"@Prioty",  _MenuRole.Prioty);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MenuRole trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuRole] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuRole trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MenuRole _MenuRole)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuRole] WHERE Id=@Id",
					"@Id", _MenuRole.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuRole trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuRole] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuRole trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MenuRole> _MenuRoles)
		{
			foreach (MenuRole item in _MenuRoles)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
