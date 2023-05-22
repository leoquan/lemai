using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MROom:IROom
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MROom(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable Room từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Room]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable Room từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Room] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách Room từ Database
		/// </summary>
		public List<Room> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Room]");
				List<Room> items = new List<Room>();
				Room item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Room();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["FK_TableGroup"] != null && dr["FK_TableGroup"] != DBNull.Value)
					{
						item.FK_TableGroup = Convert.ToString(dr["FK_TableGroup"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
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
		/// Lấy danh sách Room từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<Room> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Room] A "+ condition,  parameters);
				List<Room> items = new List<Room>();
				Room item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Room();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["FK_TableGroup"] != null && dr["FK_TableGroup"] != DBNull.Value)
					{
						item.FK_TableGroup = Convert.ToString(dr["FK_TableGroup"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
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

		public List<Room> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Room] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[Room] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<Room>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một Room từ Database
		/// </summary>
		public Room GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Room] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					Room item=new Room();
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
						if (dr["FK_TableGroup"] != null && dr["FK_TableGroup"] != DBNull.Value)
						{
							item.FK_TableGroup = Convert.ToString(dr["FK_TableGroup"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
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
		/// Lấy một Room đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public Room GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Room] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					Room item=new Room();
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
						if (dr["FK_TableGroup"] != null && dr["FK_TableGroup"] != DBNull.Value)
						{
							item.FK_TableGroup = Convert.ToString(dr["FK_TableGroup"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
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

		public Room GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Room] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<Room>(ds);
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
		/// Thêm mới Room vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, Room _Room)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[Room](Id, Name, FK_TableGroup, CreateBy, CreateDate, Status, ImagePath) VALUES(@Id, @Name, @FK_TableGroup, @CreateBy, @CreateDate, @Status, @ImagePath)", 
					"@Id",  _Room.Id, 
					"@Name",  _Room.Name, 
					"@FK_TableGroup",  _Room.FK_TableGroup, 
					"@CreateBy",  _Room.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _Room.CreateDate), 
					"@Status",  _Room.Status, 
					"@ImagePath",  _Room.ImagePath);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng Room vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<Room> _Rooms)
		{
			foreach (Room item in _Rooms)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Room vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, Room _Room, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Room] SET Id=@Id, Name=@Name, FK_TableGroup=@FK_TableGroup, CreateBy=@CreateBy, CreateDate=@CreateDate, Status=@Status, ImagePath=@ImagePath WHERE Id=@Id", 
					"@Id",  _Room.Id, 
					"@Name",  _Room.Name, 
					"@FK_TableGroup",  _Room.FK_TableGroup, 
					"@CreateBy",  _Room.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _Room.CreateDate), 
					"@Status",  _Room.Status, 
					"@ImagePath",  _Room.ImagePath, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật Room vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, Room _Room)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Room] SET Name=@Name, FK_TableGroup=@FK_TableGroup, CreateBy=@CreateBy, CreateDate=@CreateDate, Status=@Status, ImagePath=@ImagePath WHERE Id=@Id", 
					"@Name",  _Room.Name, 
					"@FK_TableGroup",  _Room.FK_TableGroup, 
					"@CreateBy",  _Room.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _Room.CreateDate), 
					"@Status",  _Room.Status, 
					"@ImagePath",  _Room.ImagePath, 
					"@Id", _Room.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách Room vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<Room> _Rooms)
		{
			foreach (Room item in _Rooms)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Room vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, Room _Room, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Room] SET Id=@Id, Name=@Name, FK_TableGroup=@FK_TableGroup, CreateBy=@CreateBy, CreateDate=@CreateDate, Status=@Status, ImagePath=@ImagePath "+ condition, 
					"@Id",  _Room.Id, 
					"@Name",  _Room.Name, 
					"@FK_TableGroup",  _Room.FK_TableGroup, 
					"@CreateBy",  _Room.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _Room.CreateDate), 
					"@Status",  _Room.Status, 
					"@ImagePath",  _Room.ImagePath);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa Room trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Room] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Room trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Room _Room)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Room] WHERE Id=@Id",
					"@Id", _Room.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Room trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Room] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Room trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<Room> _Rooms)
		{
			foreach (Room item in _Rooms)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
