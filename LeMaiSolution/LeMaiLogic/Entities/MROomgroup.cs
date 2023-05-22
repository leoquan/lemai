using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MROomgroup:IROomgroup
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MROomgroup(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable RoomGroup từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[RoomGroup]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable RoomGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[RoomGroup] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách RoomGroup từ Database
		/// </summary>
		public List<RoomGroup> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[RoomGroup]");
				List<RoomGroup> items = new List<RoomGroup>();
				RoomGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new RoomGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
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
		/// Lấy danh sách RoomGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<RoomGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[RoomGroup] A "+ condition,  parameters);
				List<RoomGroup> items = new List<RoomGroup>();
				RoomGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new RoomGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
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

		public List<RoomGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[RoomGroup] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[RoomGroup] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<RoomGroup>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một RoomGroup từ Database
		/// </summary>
		public RoomGroup GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[RoomGroup] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					RoomGroup item=new RoomGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
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
		/// Lấy một RoomGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public RoomGroup GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[RoomGroup] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					RoomGroup item=new RoomGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
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

		public RoomGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[RoomGroup] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<RoomGroup>(ds);
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
		/// Thêm mới RoomGroup vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, RoomGroup _RoomGroup)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[RoomGroup](Id, Name, FK_Branch, CreateBy, CreateDate) VALUES(@Id, @Name, @FK_Branch, @CreateBy, @CreateDate)", 
					"@Id",  _RoomGroup.Id, 
					"@Name",  _RoomGroup.Name, 
					"@FK_Branch",  _RoomGroup.FK_Branch, 
					"@CreateBy",  _RoomGroup.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _RoomGroup.CreateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng RoomGroup vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<RoomGroup> _RoomGroups)
		{
			foreach (RoomGroup item in _RoomGroups)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật RoomGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, RoomGroup _RoomGroup, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[RoomGroup] SET Id=@Id, Name=@Name, FK_Branch=@FK_Branch, CreateBy=@CreateBy, CreateDate=@CreateDate WHERE Id=@Id", 
					"@Id",  _RoomGroup.Id, 
					"@Name",  _RoomGroup.Name, 
					"@FK_Branch",  _RoomGroup.FK_Branch, 
					"@CreateBy",  _RoomGroup.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _RoomGroup.CreateDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật RoomGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, RoomGroup _RoomGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[RoomGroup] SET Name=@Name, FK_Branch=@FK_Branch, CreateBy=@CreateBy, CreateDate=@CreateDate WHERE Id=@Id", 
					"@Name",  _RoomGroup.Name, 
					"@FK_Branch",  _RoomGroup.FK_Branch, 
					"@CreateBy",  _RoomGroup.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _RoomGroup.CreateDate), 
					"@Id", _RoomGroup.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách RoomGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<RoomGroup> _RoomGroups)
		{
			foreach (RoomGroup item in _RoomGroups)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật RoomGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, RoomGroup _RoomGroup, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[RoomGroup] SET Id=@Id, Name=@Name, FK_Branch=@FK_Branch, CreateBy=@CreateBy, CreateDate=@CreateDate "+ condition, 
					"@Id",  _RoomGroup.Id, 
					"@Name",  _RoomGroup.Name, 
					"@FK_Branch",  _RoomGroup.FK_Branch, 
					"@CreateBy",  _RoomGroup.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _RoomGroup.CreateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa RoomGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[RoomGroup] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa RoomGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, RoomGroup _RoomGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[RoomGroup] WHERE Id=@Id",
					"@Id", _RoomGroup.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa RoomGroup trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[RoomGroup] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa RoomGroup trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<RoomGroup> _RoomGroups)
		{
			foreach (RoomGroup item in _RoomGroups)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
