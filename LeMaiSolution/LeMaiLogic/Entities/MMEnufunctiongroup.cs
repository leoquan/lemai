using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEnufunctiongroup:IMEnufunctiongroup
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEnufunctiongroup(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MenuFunctionGroup từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunctionGroup]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MenuFunctionGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunctionGroup] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MenuFunctionGroup từ Database
		/// </summary>
		public List<MenuFunctionGroup> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunctionGroup]");
				List<MenuFunctionGroup> items = new List<MenuFunctionGroup>();
				MenuFunctionGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuFunctionGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
					}
					if (dr["CssClass"] != null && dr["CssClass"] != DBNull.Value)
					{
						item.CssClass = Convert.ToString(dr["CssClass"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["FK_MenuGroup"] != null && dr["FK_MenuGroup"] != DBNull.Value)
					{
						item.FK_MenuGroup = Convert.ToString(dr["FK_MenuGroup"]);
					}
					if (dr["ProjectUsed"] != null && dr["ProjectUsed"] != DBNull.Value)
					{
						item.ProjectUsed = Convert.ToInt32(dr["ProjectUsed"]);
					}
					if (dr["ProgramGroup"] != null && dr["ProgramGroup"] != DBNull.Value)
					{
						item.ProgramGroup = Convert.ToString(dr["ProgramGroup"]);
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
		/// Lấy danh sách MenuFunctionGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MenuFunctionGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuFunctionGroup] A "+ condition,  parameters);
				List<MenuFunctionGroup> items = new List<MenuFunctionGroup>();
				MenuFunctionGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuFunctionGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
					}
					if (dr["CssClass"] != null && dr["CssClass"] != DBNull.Value)
					{
						item.CssClass = Convert.ToString(dr["CssClass"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["FK_MenuGroup"] != null && dr["FK_MenuGroup"] != DBNull.Value)
					{
						item.FK_MenuGroup = Convert.ToString(dr["FK_MenuGroup"]);
					}
					if (dr["ProjectUsed"] != null && dr["ProjectUsed"] != DBNull.Value)
					{
						item.ProjectUsed = Convert.ToInt32(dr["ProjectUsed"]);
					}
					if (dr["ProgramGroup"] != null && dr["ProgramGroup"] != DBNull.Value)
					{
						item.ProgramGroup = Convert.ToString(dr["ProgramGroup"]);
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

		public List<MenuFunctionGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuFunctionGroup] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MenuFunctionGroup] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MenuFunctionGroup>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MenuFunctionGroup từ Database
		/// </summary>
		public MenuFunctionGroup GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuFunctionGroup] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MenuFunctionGroup item=new MenuFunctionGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
						{
							item.GroupName = Convert.ToString(dr["GroupName"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
						{
							item.Icon = Convert.ToString(dr["Icon"]);
						}
						if (dr["CssClass"] != null && dr["CssClass"] != DBNull.Value)
						{
							item.CssClass = Convert.ToString(dr["CssClass"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["FK_MenuGroup"] != null && dr["FK_MenuGroup"] != DBNull.Value)
						{
							item.FK_MenuGroup = Convert.ToString(dr["FK_MenuGroup"]);
						}
						if (dr["ProjectUsed"] != null && dr["ProjectUsed"] != DBNull.Value)
						{
							item.ProjectUsed = Convert.ToInt32(dr["ProjectUsed"]);
						}
						if (dr["ProgramGroup"] != null && dr["ProgramGroup"] != DBNull.Value)
						{
							item.ProgramGroup = Convert.ToString(dr["ProgramGroup"]);
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
		/// Lấy một MenuFunctionGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MenuFunctionGroup GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuFunctionGroup] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MenuFunctionGroup item=new MenuFunctionGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
						{
							item.GroupName = Convert.ToString(dr["GroupName"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
						{
							item.Icon = Convert.ToString(dr["Icon"]);
						}
						if (dr["CssClass"] != null && dr["CssClass"] != DBNull.Value)
						{
							item.CssClass = Convert.ToString(dr["CssClass"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["FK_MenuGroup"] != null && dr["FK_MenuGroup"] != DBNull.Value)
						{
							item.FK_MenuGroup = Convert.ToString(dr["FK_MenuGroup"]);
						}
						if (dr["ProjectUsed"] != null && dr["ProjectUsed"] != DBNull.Value)
						{
							item.ProjectUsed = Convert.ToInt32(dr["ProjectUsed"]);
						}
						if (dr["ProgramGroup"] != null && dr["ProgramGroup"] != DBNull.Value)
						{
							item.ProgramGroup = Convert.ToString(dr["ProgramGroup"]);
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

		public MenuFunctionGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuFunctionGroup] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MenuFunctionGroup>(ds);
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
		/// Thêm mới MenuFunctionGroup vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MenuFunctionGroup _MenuFunctionGroup)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MenuFunctionGroup](Id, GroupName, SortIndex, Icon, CssClass, CreateDate, Status, FK_MenuGroup, ProjectUsed, ProgramGroup) VALUES(@Id, @GroupName, @SortIndex, @Icon, @CssClass, @CreateDate, @Status, @FK_MenuGroup, @ProjectUsed, @ProgramGroup)", 
					"@Id",  _MenuFunctionGroup.Id, 
					"@GroupName",  _MenuFunctionGroup.GroupName, 
					"@SortIndex",  _MenuFunctionGroup.SortIndex, 
					"@Icon",  _MenuFunctionGroup.Icon, 
					"@CssClass",  _MenuFunctionGroup.CssClass, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunctionGroup.CreateDate), 
					"@Status",  _MenuFunctionGroup.Status, 
					"@FK_MenuGroup",  _MenuFunctionGroup.FK_MenuGroup, 
					"@ProjectUsed",  _MenuFunctionGroup.ProjectUsed, 
					"@ProgramGroup",  _MenuFunctionGroup.ProgramGroup);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MenuFunctionGroup vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MenuFunctionGroup> _MenuFunctionGroups)
		{
			foreach (MenuFunctionGroup item in _MenuFunctionGroups)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuFunctionGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MenuFunctionGroup _MenuFunctionGroup, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunctionGroup] SET Id=@Id, GroupName=@GroupName, SortIndex=@SortIndex, Icon=@Icon, CssClass=@CssClass, CreateDate=@CreateDate, Status=@Status, FK_MenuGroup=@FK_MenuGroup, ProjectUsed=@ProjectUsed, ProgramGroup=@ProgramGroup WHERE Id=@Id", 
					"@Id",  _MenuFunctionGroup.Id, 
					"@GroupName",  _MenuFunctionGroup.GroupName, 
					"@SortIndex",  _MenuFunctionGroup.SortIndex, 
					"@Icon",  _MenuFunctionGroup.Icon, 
					"@CssClass",  _MenuFunctionGroup.CssClass, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunctionGroup.CreateDate), 
					"@Status",  _MenuFunctionGroup.Status, 
					"@FK_MenuGroup",  _MenuFunctionGroup.FK_MenuGroup, 
					"@ProjectUsed",  _MenuFunctionGroup.ProjectUsed, 
					"@ProgramGroup",  _MenuFunctionGroup.ProgramGroup, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MenuFunctionGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MenuFunctionGroup _MenuFunctionGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunctionGroup] SET GroupName=@GroupName, SortIndex=@SortIndex, Icon=@Icon, CssClass=@CssClass, CreateDate=@CreateDate, Status=@Status, FK_MenuGroup=@FK_MenuGroup, ProjectUsed=@ProjectUsed, ProgramGroup=@ProgramGroup WHERE Id=@Id", 
					"@GroupName",  _MenuFunctionGroup.GroupName, 
					"@SortIndex",  _MenuFunctionGroup.SortIndex, 
					"@Icon",  _MenuFunctionGroup.Icon, 
					"@CssClass",  _MenuFunctionGroup.CssClass, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunctionGroup.CreateDate), 
					"@Status",  _MenuFunctionGroup.Status, 
					"@FK_MenuGroup",  _MenuFunctionGroup.FK_MenuGroup, 
					"@ProjectUsed",  _MenuFunctionGroup.ProjectUsed, 
					"@ProgramGroup",  _MenuFunctionGroup.ProgramGroup, 
					"@Id", _MenuFunctionGroup.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MenuFunctionGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MenuFunctionGroup> _MenuFunctionGroups)
		{
			foreach (MenuFunctionGroup item in _MenuFunctionGroups)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuFunctionGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MenuFunctionGroup _MenuFunctionGroup, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuFunctionGroup] SET Id=@Id, GroupName=@GroupName, SortIndex=@SortIndex, Icon=@Icon, CssClass=@CssClass, CreateDate=@CreateDate, Status=@Status, FK_MenuGroup=@FK_MenuGroup, ProjectUsed=@ProjectUsed, ProgramGroup=@ProgramGroup "+ condition, 
					"@Id",  _MenuFunctionGroup.Id, 
					"@GroupName",  _MenuFunctionGroup.GroupName, 
					"@SortIndex",  _MenuFunctionGroup.SortIndex, 
					"@Icon",  _MenuFunctionGroup.Icon, 
					"@CssClass",  _MenuFunctionGroup.CssClass, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuFunctionGroup.CreateDate), 
					"@Status",  _MenuFunctionGroup.Status, 
					"@FK_MenuGroup",  _MenuFunctionGroup.FK_MenuGroup, 
					"@ProjectUsed",  _MenuFunctionGroup.ProjectUsed, 
					"@ProgramGroup",  _MenuFunctionGroup.ProgramGroup);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MenuFunctionGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunctionGroup] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunctionGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MenuFunctionGroup _MenuFunctionGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunctionGroup] WHERE Id=@Id",
					"@Id", _MenuFunctionGroup.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunctionGroup trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuFunctionGroup] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuFunctionGroup trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MenuFunctionGroup> _MenuFunctionGroups)
		{
			foreach (MenuFunctionGroup item in _MenuFunctionGroups)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
