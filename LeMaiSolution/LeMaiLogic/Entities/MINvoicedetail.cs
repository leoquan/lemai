using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MINvoicedetail:IINvoicedetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MINvoicedetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable InvoiceDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[InvoiceDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable InvoiceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[InvoiceDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách InvoiceDetail từ Database
		/// </summary>
		public List<InvoiceDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[InvoiceDetail]");
				List<InvoiceDetail> items = new List<InvoiceDetail>();
				InvoiceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new InvoiceDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["FK_Invoice"] != null && dr["FK_Invoice"] != DBNull.Value)
					{
						item.FK_Invoice = Convert.ToString(dr["FK_Invoice"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
					{
						item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToInt32(dr["Quantity"]);
					}
					if (dr["Price"] != null && dr["Price"] != DBNull.Value)
					{
						item.Price = Convert.ToInt32(dr["Price"]);
					}
					if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
					{
						item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
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
		/// Lấy danh sách InvoiceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<InvoiceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[InvoiceDetail] A "+ condition,  parameters);
				List<InvoiceDetail> items = new List<InvoiceDetail>();
				InvoiceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new InvoiceDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["FK_Invoice"] != null && dr["FK_Invoice"] != DBNull.Value)
					{
						item.FK_Invoice = Convert.ToString(dr["FK_Invoice"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
					{
						item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToInt32(dr["Quantity"]);
					}
					if (dr["Price"] != null && dr["Price"] != DBNull.Value)
					{
						item.Price = Convert.ToInt32(dr["Price"]);
					}
					if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
					{
						item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
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

		public List<InvoiceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[InvoiceDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[InvoiceDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<InvoiceDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một InvoiceDetail từ Database
		/// </summary>
		public InvoiceDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[InvoiceDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					InvoiceDetail item=new InvoiceDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["FK_Invoice"] != null && dr["FK_Invoice"] != DBNull.Value)
						{
							item.FK_Invoice = Convert.ToString(dr["FK_Invoice"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
						{
							item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
						}
						if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
						{
							item.Quantity = Convert.ToInt32(dr["Quantity"]);
						}
						if (dr["Price"] != null && dr["Price"] != DBNull.Value)
						{
							item.Price = Convert.ToInt32(dr["Price"]);
						}
						if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
						{
							item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
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
		/// Lấy một InvoiceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public InvoiceDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[InvoiceDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					InvoiceDetail item=new InvoiceDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["FK_Invoice"] != null && dr["FK_Invoice"] != DBNull.Value)
						{
							item.FK_Invoice = Convert.ToString(dr["FK_Invoice"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
						{
							item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
						}
						if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
						{
							item.Quantity = Convert.ToInt32(dr["Quantity"]);
						}
						if (dr["Price"] != null && dr["Price"] != DBNull.Value)
						{
							item.Price = Convert.ToInt32(dr["Price"]);
						}
						if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
						{
							item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
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

		public InvoiceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[InvoiceDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<InvoiceDetail>(ds);
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
		/// Thêm mới InvoiceDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, InvoiceDetail _InvoiceDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[InvoiceDetail](Id, SortIndex, FK_Invoice, FK_Service, FK_Employee, Quantity, Price, TotalPrice, Status) VALUES(@Id, @SortIndex, @FK_Invoice, @FK_Service, @FK_Employee, @Quantity, @Price, @TotalPrice, @Status)", 
					"@Id",  _InvoiceDetail.Id, 
					"@SortIndex",  _InvoiceDetail.SortIndex, 
					"@FK_Invoice",  _InvoiceDetail.FK_Invoice, 
					"@FK_Service",  _InvoiceDetail.FK_Service, 
					"@FK_Employee",  _InvoiceDetail.FK_Employee, 
					"@Quantity",  _InvoiceDetail.Quantity, 
					"@Price",  _InvoiceDetail.Price, 
					"@TotalPrice",  _InvoiceDetail.TotalPrice, 
					"@Status",  _InvoiceDetail.Status);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng InvoiceDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<InvoiceDetail> _InvoiceDetails)
		{
			foreach (InvoiceDetail item in _InvoiceDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật InvoiceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, InvoiceDetail _InvoiceDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[InvoiceDetail] SET Id=@Id, SortIndex=@SortIndex, FK_Invoice=@FK_Invoice, FK_Service=@FK_Service, FK_Employee=@FK_Employee, Quantity=@Quantity, Price=@Price, TotalPrice=@TotalPrice, Status=@Status WHERE Id=@Id", 
					"@Id",  _InvoiceDetail.Id, 
					"@SortIndex",  _InvoiceDetail.SortIndex, 
					"@FK_Invoice",  _InvoiceDetail.FK_Invoice, 
					"@FK_Service",  _InvoiceDetail.FK_Service, 
					"@FK_Employee",  _InvoiceDetail.FK_Employee, 
					"@Quantity",  _InvoiceDetail.Quantity, 
					"@Price",  _InvoiceDetail.Price, 
					"@TotalPrice",  _InvoiceDetail.TotalPrice, 
					"@Status",  _InvoiceDetail.Status, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật InvoiceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, InvoiceDetail _InvoiceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[InvoiceDetail] SET SortIndex=@SortIndex, FK_Invoice=@FK_Invoice, FK_Service=@FK_Service, FK_Employee=@FK_Employee, Quantity=@Quantity, Price=@Price, TotalPrice=@TotalPrice, Status=@Status WHERE Id=@Id", 
					"@SortIndex",  _InvoiceDetail.SortIndex, 
					"@FK_Invoice",  _InvoiceDetail.FK_Invoice, 
					"@FK_Service",  _InvoiceDetail.FK_Service, 
					"@FK_Employee",  _InvoiceDetail.FK_Employee, 
					"@Quantity",  _InvoiceDetail.Quantity, 
					"@Price",  _InvoiceDetail.Price, 
					"@TotalPrice",  _InvoiceDetail.TotalPrice, 
					"@Status",  _InvoiceDetail.Status, 
					"@Id", _InvoiceDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách InvoiceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<InvoiceDetail> _InvoiceDetails)
		{
			foreach (InvoiceDetail item in _InvoiceDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật InvoiceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, InvoiceDetail _InvoiceDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[InvoiceDetail] SET Id=@Id, SortIndex=@SortIndex, FK_Invoice=@FK_Invoice, FK_Service=@FK_Service, FK_Employee=@FK_Employee, Quantity=@Quantity, Price=@Price, TotalPrice=@TotalPrice, Status=@Status "+ condition, 
					"@Id",  _InvoiceDetail.Id, 
					"@SortIndex",  _InvoiceDetail.SortIndex, 
					"@FK_Invoice",  _InvoiceDetail.FK_Invoice, 
					"@FK_Service",  _InvoiceDetail.FK_Service, 
					"@FK_Employee",  _InvoiceDetail.FK_Employee, 
					"@Quantity",  _InvoiceDetail.Quantity, 
					"@Price",  _InvoiceDetail.Price, 
					"@TotalPrice",  _InvoiceDetail.TotalPrice, 
					"@Status",  _InvoiceDetail.Status);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa InvoiceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[InvoiceDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa InvoiceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, InvoiceDetail _InvoiceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[InvoiceDetail] WHERE Id=@Id",
					"@Id", _InvoiceDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa InvoiceDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[InvoiceDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa InvoiceDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<InvoiceDetail> _InvoiceDetails)
		{
			foreach (InvoiceDetail item in _InvoiceDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
