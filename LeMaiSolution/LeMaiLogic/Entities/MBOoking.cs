using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MBOoking:IBOoking
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MBOoking(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable Booking từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Booking]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable Booking từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Booking] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách Booking từ Database
		/// </summary>
		public List<Booking> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Booking]");
				List<Booking> items = new List<Booking>();
				Booking item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Booking();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["DateBook"] != null && dr["DateBook"] != DBNull.Value)
					{
						item.DateBook = Convert.ToDateTime(dr["DateBook"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["IsGift"] != null && dr["IsGift"] != DBNull.Value)
					{
						item.IsGift = Convert.ToBoolean(dr["IsGift"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["FK_ConfigBookingTime"] != null && dr["FK_ConfigBookingTime"] != DBNull.Value)
					{
						item.FK_ConfigBookingTime = Convert.ToString(dr["FK_ConfigBookingTime"]);
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
		/// Lấy danh sách Booking từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<Booking> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Booking] A "+ condition,  parameters);
				List<Booking> items = new List<Booking>();
				Booking item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Booking();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["DateBook"] != null && dr["DateBook"] != DBNull.Value)
					{
						item.DateBook = Convert.ToDateTime(dr["DateBook"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["IsGift"] != null && dr["IsGift"] != DBNull.Value)
					{
						item.IsGift = Convert.ToBoolean(dr["IsGift"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["FK_ConfigBookingTime"] != null && dr["FK_ConfigBookingTime"] != DBNull.Value)
					{
						item.FK_ConfigBookingTime = Convert.ToString(dr["FK_ConfigBookingTime"]);
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

		public List<Booking> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Booking] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[Booking] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<Booking>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một Booking từ Database
		/// </summary>
		public Booking GetObject(string schema, String Id, String FK_ConfigBookingTime)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Booking] where Id=@Id and FK_ConfigBookingTime=@FK_ConfigBookingTime",
					"@Id", Id, 
					"@FK_ConfigBookingTime", FK_ConfigBookingTime);
				if (ds.Rows.Count > 0)
				{
					Booking item=new Booking();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["DateBook"] != null && dr["DateBook"] != DBNull.Value)
						{
							item.DateBook = Convert.ToDateTime(dr["DateBook"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["IsGift"] != null && dr["IsGift"] != DBNull.Value)
						{
							item.IsGift = Convert.ToBoolean(dr["IsGift"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["FK_ConfigBookingTime"] != null && dr["FK_ConfigBookingTime"] != DBNull.Value)
						{
							item.FK_ConfigBookingTime = Convert.ToString(dr["FK_ConfigBookingTime"]);
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
		/// Lấy một Booking đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public Booking GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Booking] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					Booking item=new Booking();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["DateBook"] != null && dr["DateBook"] != DBNull.Value)
						{
							item.DateBook = Convert.ToDateTime(dr["DateBook"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["IsGift"] != null && dr["IsGift"] != DBNull.Value)
						{
							item.IsGift = Convert.ToBoolean(dr["IsGift"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["FK_ConfigBookingTime"] != null && dr["FK_ConfigBookingTime"] != DBNull.Value)
						{
							item.FK_ConfigBookingTime = Convert.ToString(dr["FK_ConfigBookingTime"]);
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

		public Booking GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Booking] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<Booking>(ds);
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
		/// Thêm mới Booking vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, Booking _Booking)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[Booking](Id, FK_AccountObject, CreateDate, DateBook, Note, FK_Branch, Status, IsGift, Name, Phone, FK_ConfigBookingTime) VALUES(@Id, @FK_AccountObject, @CreateDate, @DateBook, @Note, @FK_Branch, @Status, @IsGift, @Name, @Phone, @FK_ConfigBookingTime)", 
					"@Id",  _Booking.Id, 
					"@FK_AccountObject",  _Booking.FK_AccountObject, 
					"@CreateDate", this._dataContext.ConvertDateString( _Booking.CreateDate), 
					"@DateBook", this._dataContext.ConvertDateString( _Booking.DateBook), 
					"@Note",  _Booking.Note, 
					"@FK_Branch",  _Booking.FK_Branch, 
					"@Status",  _Booking.Status, 
					"@IsGift",  _Booking.IsGift, 
					"@Name",  _Booking.Name, 
					"@Phone",  _Booking.Phone, 
					"@FK_ConfigBookingTime",  _Booking.FK_ConfigBookingTime);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng Booking vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<Booking> _Bookings)
		{
			foreach (Booking item in _Bookings)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Booking vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, Booking _Booking, String Id, String FK_ConfigBookingTime)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Booking] SET Id=@Id, FK_AccountObject=@FK_AccountObject, CreateDate=@CreateDate, DateBook=@DateBook, Note=@Note, FK_Branch=@FK_Branch, Status=@Status, IsGift=@IsGift, Name=@Name, Phone=@Phone, FK_ConfigBookingTime=@FK_ConfigBookingTime WHERE Id=@Id and FK_ConfigBookingTime=@FK_ConfigBookingTime", 
					"@Id",  _Booking.Id, 
					"@FK_AccountObject",  _Booking.FK_AccountObject, 
					"@CreateDate", this._dataContext.ConvertDateString( _Booking.CreateDate), 
					"@DateBook", this._dataContext.ConvertDateString( _Booking.DateBook), 
					"@Note",  _Booking.Note, 
					"@FK_Branch",  _Booking.FK_Branch, 
					"@Status",  _Booking.Status, 
					"@IsGift",  _Booking.IsGift, 
					"@Name",  _Booking.Name, 
					"@Phone",  _Booking.Phone, 
					"@FK_ConfigBookingTime",  _Booking.FK_ConfigBookingTime, 
					"@Id", Id, 
					"@FK_ConfigBookingTime", FK_ConfigBookingTime);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật Booking vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, Booking _Booking)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Booking] SET FK_AccountObject=@FK_AccountObject, CreateDate=@CreateDate, DateBook=@DateBook, Note=@Note, FK_Branch=@FK_Branch, Status=@Status, IsGift=@IsGift, Name=@Name, Phone=@Phone WHERE Id=@Id and FK_ConfigBookingTime=@FK_ConfigBookingTime", 
					"@FK_AccountObject",  _Booking.FK_AccountObject, 
					"@CreateDate", this._dataContext.ConvertDateString( _Booking.CreateDate), 
					"@DateBook", this._dataContext.ConvertDateString( _Booking.DateBook), 
					"@Note",  _Booking.Note, 
					"@FK_Branch",  _Booking.FK_Branch, 
					"@Status",  _Booking.Status, 
					"@IsGift",  _Booking.IsGift, 
					"@Name",  _Booking.Name, 
					"@Phone",  _Booking.Phone, 
					"@Id", _Booking.Id, 
					"@FK_ConfigBookingTime", _Booking.FK_ConfigBookingTime);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách Booking vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<Booking> _Bookings)
		{
			foreach (Booking item in _Bookings)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Booking vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, Booking _Booking, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Booking] SET Id=@Id, FK_AccountObject=@FK_AccountObject, CreateDate=@CreateDate, DateBook=@DateBook, Note=@Note, FK_Branch=@FK_Branch, Status=@Status, IsGift=@IsGift, Name=@Name, Phone=@Phone, FK_ConfigBookingTime=@FK_ConfigBookingTime "+ condition, 
					"@Id",  _Booking.Id, 
					"@FK_AccountObject",  _Booking.FK_AccountObject, 
					"@CreateDate", this._dataContext.ConvertDateString( _Booking.CreateDate), 
					"@DateBook", this._dataContext.ConvertDateString( _Booking.DateBook), 
					"@Note",  _Booking.Note, 
					"@FK_Branch",  _Booking.FK_Branch, 
					"@Status",  _Booking.Status, 
					"@IsGift",  _Booking.IsGift, 
					"@Name",  _Booking.Name, 
					"@Phone",  _Booking.Phone, 
					"@FK_ConfigBookingTime",  _Booking.FK_ConfigBookingTime);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa Booking trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id, String FK_ConfigBookingTime)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Booking] WHERE Id=@Id and FK_ConfigBookingTime=@FK_ConfigBookingTime",
					"@Id", Id, 
					"@FK_ConfigBookingTime", FK_ConfigBookingTime);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Booking trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Booking _Booking)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Booking] WHERE Id=@Id and FK_ConfigBookingTime=@FK_ConfigBookingTime",
					"@Id", _Booking.Id, 
					"@FK_ConfigBookingTime", _Booking.FK_ConfigBookingTime);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Booking trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Booking] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Booking trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<Booking> _Bookings)
		{
			foreach (Booking item in _Bookings)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
