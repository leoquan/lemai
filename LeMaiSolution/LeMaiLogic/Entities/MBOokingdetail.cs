using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MBOokingdetail:IBOokingdetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MBOokingdetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable BookingDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[BookingDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable BookingDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[BookingDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách BookingDetail từ Database
		/// </summary>
		public List<BookingDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[BookingDetail]");
				List<BookingDetail> items = new List<BookingDetail>();
				BookingDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new BookingDetail();
					if (dr["ID"] != null && dr["ID"] != DBNull.Value)
					{
						item.ID = Convert.ToString(dr["ID"]);
					}
					if (dr["FK_Booking"] != null && dr["FK_Booking"] != DBNull.Value)
					{
						item.FK_Booking = Convert.ToString(dr["FK_Booking"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
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
		/// Lấy danh sách BookingDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<BookingDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[BookingDetail] A "+ condition,  parameters);
				List<BookingDetail> items = new List<BookingDetail>();
				BookingDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new BookingDetail();
					if (dr["ID"] != null && dr["ID"] != DBNull.Value)
					{
						item.ID = Convert.ToString(dr["ID"]);
					}
					if (dr["FK_Booking"] != null && dr["FK_Booking"] != DBNull.Value)
					{
						item.FK_Booking = Convert.ToString(dr["FK_Booking"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
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

		public List<BookingDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[BookingDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[BookingDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<BookingDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một BookingDetail từ Database
		/// </summary>
		public BookingDetail GetObject(string schema, String ID)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[BookingDetail] where ID=@ID",
					"@ID", ID);
				if (ds.Rows.Count > 0)
				{
					BookingDetail item=new BookingDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ID"] != null && dr["ID"] != DBNull.Value)
						{
							item.ID = Convert.ToString(dr["ID"]);
						}
						if (dr["FK_Booking"] != null && dr["FK_Booking"] != DBNull.Value)
						{
							item.FK_Booking = Convert.ToString(dr["FK_Booking"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
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
		/// Lấy một BookingDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public BookingDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[BookingDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					BookingDetail item=new BookingDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ID"] != null && dr["ID"] != DBNull.Value)
						{
							item.ID = Convert.ToString(dr["ID"]);
						}
						if (dr["FK_Booking"] != null && dr["FK_Booking"] != DBNull.Value)
						{
							item.FK_Booking = Convert.ToString(dr["FK_Booking"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
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

		public BookingDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[BookingDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<BookingDetail>(ds);
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
		/// Thêm mới BookingDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, BookingDetail _BookingDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[BookingDetail](ID, FK_Booking, FK_Service, CreateBy, CreateDate) VALUES(@ID, @FK_Booking, @FK_Service, @CreateBy, @CreateDate)", 
					"@ID",  _BookingDetail.ID, 
					"@FK_Booking",  _BookingDetail.FK_Booking, 
					"@FK_Service",  _BookingDetail.FK_Service, 
					"@CreateBy",  _BookingDetail.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _BookingDetail.CreateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng BookingDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<BookingDetail> _BookingDetails)
		{
			foreach (BookingDetail item in _BookingDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật BookingDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, BookingDetail _BookingDetail, String ID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[BookingDetail] SET ID=@ID, FK_Booking=@FK_Booking, FK_Service=@FK_Service, CreateBy=@CreateBy, CreateDate=@CreateDate WHERE ID=@ID", 
					"@ID",  _BookingDetail.ID, 
					"@FK_Booking",  _BookingDetail.FK_Booking, 
					"@FK_Service",  _BookingDetail.FK_Service, 
					"@CreateBy",  _BookingDetail.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _BookingDetail.CreateDate), 
					"@ID", ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật BookingDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, BookingDetail _BookingDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[BookingDetail] SET FK_Booking=@FK_Booking, FK_Service=@FK_Service, CreateBy=@CreateBy, CreateDate=@CreateDate WHERE ID=@ID", 
					"@FK_Booking",  _BookingDetail.FK_Booking, 
					"@FK_Service",  _BookingDetail.FK_Service, 
					"@CreateBy",  _BookingDetail.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _BookingDetail.CreateDate), 
					"@ID", _BookingDetail.ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách BookingDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<BookingDetail> _BookingDetails)
		{
			foreach (BookingDetail item in _BookingDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật BookingDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, BookingDetail _BookingDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[BookingDetail] SET ID=@ID, FK_Booking=@FK_Booking, FK_Service=@FK_Service, CreateBy=@CreateBy, CreateDate=@CreateDate "+ condition, 
					"@ID",  _BookingDetail.ID, 
					"@FK_Booking",  _BookingDetail.FK_Booking, 
					"@FK_Service",  _BookingDetail.FK_Service, 
					"@CreateBy",  _BookingDetail.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _BookingDetail.CreateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa BookingDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String ID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[BookingDetail] WHERE ID=@ID",
					"@ID", ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa BookingDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, BookingDetail _BookingDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[BookingDetail] WHERE ID=@ID",
					"@ID", _BookingDetail.ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa BookingDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[BookingDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa BookingDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<BookingDetail> _BookingDetails)
		{
			foreach (BookingDetail item in _BookingDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
