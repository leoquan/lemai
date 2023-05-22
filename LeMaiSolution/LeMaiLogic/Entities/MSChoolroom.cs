using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSChoolroom:ISChoolroom
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSChoolroom(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SchoolRoom từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolRoom]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SchoolRoom từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolRoom] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SchoolRoom từ Database
		/// </summary>
		public List<SchoolRoom> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolRoom]");
				List<SchoolRoom> items = new List<SchoolRoom>();
				SchoolRoom item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolRoom();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
					{
						item.TenPhong = Convert.ToString(dr["TenPhong"]);
					}
					if (dr["FK_TrungTam"] != null && dr["FK_TrungTam"] != DBNull.Value)
					{
						item.FK_TrungTam = Convert.ToString(dr["FK_TrungTam"]);
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
		/// Lấy danh sách SchoolRoom từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SchoolRoom> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolRoom] A "+ condition,  parameters);
				List<SchoolRoom> items = new List<SchoolRoom>();
				SchoolRoom item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolRoom();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
					{
						item.TenPhong = Convert.ToString(dr["TenPhong"]);
					}
					if (dr["FK_TrungTam"] != null && dr["FK_TrungTam"] != DBNull.Value)
					{
						item.FK_TrungTam = Convert.ToString(dr["FK_TrungTam"]);
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

		public List<SchoolRoom> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolRoom] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SchoolRoom] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SchoolRoom>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SchoolRoom từ Database
		/// </summary>
		public SchoolRoom GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolRoom] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SchoolRoom item=new SchoolRoom();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
						{
							item.TenPhong = Convert.ToString(dr["TenPhong"]);
						}
						if (dr["FK_TrungTam"] != null && dr["FK_TrungTam"] != DBNull.Value)
						{
							item.FK_TrungTam = Convert.ToString(dr["FK_TrungTam"]);
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
		/// Lấy một SchoolRoom đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SchoolRoom GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolRoom] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SchoolRoom item=new SchoolRoom();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
						{
							item.TenPhong = Convert.ToString(dr["TenPhong"]);
						}
						if (dr["FK_TrungTam"] != null && dr["FK_TrungTam"] != DBNull.Value)
						{
							item.FK_TrungTam = Convert.ToString(dr["FK_TrungTam"]);
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

		public SchoolRoom GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolRoom] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SchoolRoom>(ds);
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
		/// Thêm mới SchoolRoom vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SchoolRoom _SchoolRoom)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SchoolRoom](Id, TenPhong, FK_TrungTam) VALUES(@Id, @TenPhong, @FK_TrungTam)", 
					"@Id",  _SchoolRoom.Id, 
					"@TenPhong",  _SchoolRoom.TenPhong, 
					"@FK_TrungTam",  _SchoolRoom.FK_TrungTam);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SchoolRoom vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SchoolRoom> _SchoolRooms)
		{
			foreach (SchoolRoom item in _SchoolRooms)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolRoom vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SchoolRoom _SchoolRoom, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolRoom] SET Id=@Id, TenPhong=@TenPhong, FK_TrungTam=@FK_TrungTam WHERE Id=@Id", 
					"@Id",  _SchoolRoom.Id, 
					"@TenPhong",  _SchoolRoom.TenPhong, 
					"@FK_TrungTam",  _SchoolRoom.FK_TrungTam, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SchoolRoom vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SchoolRoom _SchoolRoom)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolRoom] SET TenPhong=@TenPhong, FK_TrungTam=@FK_TrungTam WHERE Id=@Id", 
					"@TenPhong",  _SchoolRoom.TenPhong, 
					"@FK_TrungTam",  _SchoolRoom.FK_TrungTam, 
					"@Id", _SchoolRoom.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SchoolRoom vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SchoolRoom> _SchoolRooms)
		{
			foreach (SchoolRoom item in _SchoolRooms)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolRoom vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SchoolRoom _SchoolRoom, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolRoom] SET Id=@Id, TenPhong=@TenPhong, FK_TrungTam=@FK_TrungTam "+ condition, 
					"@Id",  _SchoolRoom.Id, 
					"@TenPhong",  _SchoolRoom.TenPhong, 
					"@FK_TrungTam",  _SchoolRoom.FK_TrungTam);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SchoolRoom trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolRoom] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolRoom trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SchoolRoom _SchoolRoom)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolRoom] WHERE Id=@Id",
					"@Id", _SchoolRoom.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolRoom trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolRoom] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolRoom trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SchoolRoom> _SchoolRooms)
		{
			foreach (SchoolRoom item in _SchoolRooms)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
