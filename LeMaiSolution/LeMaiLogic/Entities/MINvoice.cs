using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MINvoice:IINvoice
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MINvoice(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable Invoice từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Invoice]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable Invoice từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Invoice] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách Invoice từ Database
		/// </summary>
		public List<Invoice> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Invoice]");
				List<Invoice> items = new List<Invoice>();
				Invoice item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Invoice();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["Tile"] != null && dr["Tile"] != DBNull.Value)
					{
						item.Tile = Convert.ToString(dr["Tile"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["FK_Cashier"] != null && dr["FK_Cashier"] != DBNull.Value)
					{
						item.FK_Cashier = Convert.ToString(dr["FK_Cashier"]);
					}
					if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
					{
						item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
					}
					if (dr["FK_Voucher"] != null && dr["FK_Voucher"] != DBNull.Value)
					{
						item.FK_Voucher = Convert.ToString(dr["FK_Voucher"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
					{
						item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
					}
					if (dr["VoucherPrice"] != null && dr["VoucherPrice"] != DBNull.Value)
					{
						item.VoucherPrice = Convert.ToInt32(dr["VoucherPrice"]);
					}
					if (dr["TotalItem"] != null && dr["TotalItem"] != DBNull.Value)
					{
						item.TotalItem = Convert.ToInt32(dr["TotalItem"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["FK_DeleteBy"] != null && dr["FK_DeleteBy"] != DBNull.Value)
					{
						item.FK_DeleteBy = Convert.ToString(dr["FK_DeleteBy"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["FK_Room"] != null && dr["FK_Room"] != DBNull.Value)
					{
						item.FK_Room = Convert.ToString(dr["FK_Room"]);
					}
					if (dr["ExtraPrice"] != null && dr["ExtraPrice"] != DBNull.Value)
					{
						item.ExtraPrice = Convert.ToInt32(dr["ExtraPrice"]);
					}
					if (dr["ServicePrice"] != null && dr["ServicePrice"] != DBNull.Value)
					{
						item.ServicePrice = Convert.ToInt32(dr["ServicePrice"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["NumberPrint"] != null && dr["NumberPrint"] != DBNull.Value)
					{
						item.NumberPrint = Convert.ToInt32(dr["NumberPrint"]);
					}
					if (dr["ModifyBy"] != null && dr["ModifyBy"] != DBNull.Value)
					{
						item.ModifyBy = Convert.ToString(dr["ModifyBy"]);
					}
					if (dr["ModifyDate"] != null && dr["ModifyDate"] != DBNull.Value)
					{
						item.ModifyDate = Convert.ToString(dr["ModifyDate"]);
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
		/// Lấy danh sách Invoice từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<Invoice> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Invoice] A "+ condition,  parameters);
				List<Invoice> items = new List<Invoice>();
				Invoice item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Invoice();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["Tile"] != null && dr["Tile"] != DBNull.Value)
					{
						item.Tile = Convert.ToString(dr["Tile"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["FK_Cashier"] != null && dr["FK_Cashier"] != DBNull.Value)
					{
						item.FK_Cashier = Convert.ToString(dr["FK_Cashier"]);
					}
					if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
					{
						item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
					}
					if (dr["FK_Voucher"] != null && dr["FK_Voucher"] != DBNull.Value)
					{
						item.FK_Voucher = Convert.ToString(dr["FK_Voucher"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
					{
						item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
					}
					if (dr["VoucherPrice"] != null && dr["VoucherPrice"] != DBNull.Value)
					{
						item.VoucherPrice = Convert.ToInt32(dr["VoucherPrice"]);
					}
					if (dr["TotalItem"] != null && dr["TotalItem"] != DBNull.Value)
					{
						item.TotalItem = Convert.ToInt32(dr["TotalItem"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["FK_DeleteBy"] != null && dr["FK_DeleteBy"] != DBNull.Value)
					{
						item.FK_DeleteBy = Convert.ToString(dr["FK_DeleteBy"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["FK_Room"] != null && dr["FK_Room"] != DBNull.Value)
					{
						item.FK_Room = Convert.ToString(dr["FK_Room"]);
					}
					if (dr["ExtraPrice"] != null && dr["ExtraPrice"] != DBNull.Value)
					{
						item.ExtraPrice = Convert.ToInt32(dr["ExtraPrice"]);
					}
					if (dr["ServicePrice"] != null && dr["ServicePrice"] != DBNull.Value)
					{
						item.ServicePrice = Convert.ToInt32(dr["ServicePrice"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["NumberPrint"] != null && dr["NumberPrint"] != DBNull.Value)
					{
						item.NumberPrint = Convert.ToInt32(dr["NumberPrint"]);
					}
					if (dr["ModifyBy"] != null && dr["ModifyBy"] != DBNull.Value)
					{
						item.ModifyBy = Convert.ToString(dr["ModifyBy"]);
					}
					if (dr["ModifyDate"] != null && dr["ModifyDate"] != DBNull.Value)
					{
						item.ModifyDate = Convert.ToString(dr["ModifyDate"]);
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

		public List<Invoice> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Invoice] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[Invoice] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<Invoice>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một Invoice từ Database
		/// </summary>
		public Invoice GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Invoice] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					Invoice item=new Invoice();
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
						if (dr["Tile"] != null && dr["Tile"] != DBNull.Value)
						{
							item.Tile = Convert.ToString(dr["Tile"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["FK_Cashier"] != null && dr["FK_Cashier"] != DBNull.Value)
						{
							item.FK_Cashier = Convert.ToString(dr["FK_Cashier"]);
						}
						if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
						{
							item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
						}
						if (dr["FK_Voucher"] != null && dr["FK_Voucher"] != DBNull.Value)
						{
							item.FK_Voucher = Convert.ToString(dr["FK_Voucher"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
						{
							item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
						}
						if (dr["VoucherPrice"] != null && dr["VoucherPrice"] != DBNull.Value)
						{
							item.VoucherPrice = Convert.ToInt32(dr["VoucherPrice"]);
						}
						if (dr["TotalItem"] != null && dr["TotalItem"] != DBNull.Value)
						{
							item.TotalItem = Convert.ToInt32(dr["TotalItem"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["FK_DeleteBy"] != null && dr["FK_DeleteBy"] != DBNull.Value)
						{
							item.FK_DeleteBy = Convert.ToString(dr["FK_DeleteBy"]);
						}
						if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
						{
							item.Reason = Convert.ToString(dr["Reason"]);
						}
						if (dr["FK_Room"] != null && dr["FK_Room"] != DBNull.Value)
						{
							item.FK_Room = Convert.ToString(dr["FK_Room"]);
						}
						if (dr["ExtraPrice"] != null && dr["ExtraPrice"] != DBNull.Value)
						{
							item.ExtraPrice = Convert.ToInt32(dr["ExtraPrice"]);
						}
						if (dr["ServicePrice"] != null && dr["ServicePrice"] != DBNull.Value)
						{
							item.ServicePrice = Convert.ToInt32(dr["ServicePrice"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["NumberPrint"] != null && dr["NumberPrint"] != DBNull.Value)
						{
							item.NumberPrint = Convert.ToInt32(dr["NumberPrint"]);
						}
						if (dr["ModifyBy"] != null && dr["ModifyBy"] != DBNull.Value)
						{
							item.ModifyBy = Convert.ToString(dr["ModifyBy"]);
						}
						if (dr["ModifyDate"] != null && dr["ModifyDate"] != DBNull.Value)
						{
							item.ModifyDate = Convert.ToString(dr["ModifyDate"]);
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
		/// Lấy một Invoice đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public Invoice GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Invoice] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					Invoice item=new Invoice();
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
						if (dr["Tile"] != null && dr["Tile"] != DBNull.Value)
						{
							item.Tile = Convert.ToString(dr["Tile"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["FK_Cashier"] != null && dr["FK_Cashier"] != DBNull.Value)
						{
							item.FK_Cashier = Convert.ToString(dr["FK_Cashier"]);
						}
						if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
						{
							item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
						}
						if (dr["FK_Voucher"] != null && dr["FK_Voucher"] != DBNull.Value)
						{
							item.FK_Voucher = Convert.ToString(dr["FK_Voucher"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
						{
							item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
						}
						if (dr["VoucherPrice"] != null && dr["VoucherPrice"] != DBNull.Value)
						{
							item.VoucherPrice = Convert.ToInt32(dr["VoucherPrice"]);
						}
						if (dr["TotalItem"] != null && dr["TotalItem"] != DBNull.Value)
						{
							item.TotalItem = Convert.ToInt32(dr["TotalItem"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["FK_DeleteBy"] != null && dr["FK_DeleteBy"] != DBNull.Value)
						{
							item.FK_DeleteBy = Convert.ToString(dr["FK_DeleteBy"]);
						}
						if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
						{
							item.Reason = Convert.ToString(dr["Reason"]);
						}
						if (dr["FK_Room"] != null && dr["FK_Room"] != DBNull.Value)
						{
							item.FK_Room = Convert.ToString(dr["FK_Room"]);
						}
						if (dr["ExtraPrice"] != null && dr["ExtraPrice"] != DBNull.Value)
						{
							item.ExtraPrice = Convert.ToInt32(dr["ExtraPrice"]);
						}
						if (dr["ServicePrice"] != null && dr["ServicePrice"] != DBNull.Value)
						{
							item.ServicePrice = Convert.ToInt32(dr["ServicePrice"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["NumberPrint"] != null && dr["NumberPrint"] != DBNull.Value)
						{
							item.NumberPrint = Convert.ToInt32(dr["NumberPrint"]);
						}
						if (dr["ModifyBy"] != null && dr["ModifyBy"] != DBNull.Value)
						{
							item.ModifyBy = Convert.ToString(dr["ModifyBy"]);
						}
						if (dr["ModifyDate"] != null && dr["ModifyDate"] != DBNull.Value)
						{
							item.ModifyDate = Convert.ToString(dr["ModifyDate"]);
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

		public Invoice GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Invoice] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<Invoice>(ds);
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
		/// Thêm mới Invoice vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, Invoice _Invoice)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[Invoice](Id, Code, Tile, FK_Customer, FK_Branch, FK_Cashier, FK_Employee, FK_Voucher, CreateDate, TotalPrice, VoucherPrice, TotalItem, Note, Status, FK_DeleteBy, Reason, FK_Room, ExtraPrice, ServicePrice, IsDelete, NumberPrint, ModifyBy, ModifyDate) VALUES(@Id, @Code, @Tile, @FK_Customer, @FK_Branch, @FK_Cashier, @FK_Employee, @FK_Voucher, @CreateDate, @TotalPrice, @VoucherPrice, @TotalItem, @Note, @Status, @FK_DeleteBy, @Reason, @FK_Room, @ExtraPrice, @ServicePrice, @IsDelete, @NumberPrint, @ModifyBy, @ModifyDate)", 
					"@Id",  _Invoice.Id, 
					"@Code",  _Invoice.Code, 
					"@Tile",  _Invoice.Tile, 
					"@FK_Customer",  _Invoice.FK_Customer, 
					"@FK_Branch",  _Invoice.FK_Branch, 
					"@FK_Cashier",  _Invoice.FK_Cashier, 
					"@FK_Employee",  _Invoice.FK_Employee, 
					"@FK_Voucher",  _Invoice.FK_Voucher, 
					"@CreateDate", this._dataContext.ConvertDateString( _Invoice.CreateDate), 
					"@TotalPrice",  _Invoice.TotalPrice, 
					"@VoucherPrice",  _Invoice.VoucherPrice, 
					"@TotalItem",  _Invoice.TotalItem, 
					"@Note",  _Invoice.Note, 
					"@Status",  _Invoice.Status, 
					"@FK_DeleteBy",  _Invoice.FK_DeleteBy, 
					"@Reason",  _Invoice.Reason, 
					"@FK_Room",  _Invoice.FK_Room, 
					"@ExtraPrice",  _Invoice.ExtraPrice, 
					"@ServicePrice",  _Invoice.ServicePrice, 
					"@IsDelete",  _Invoice.IsDelete, 
					"@NumberPrint",  _Invoice.NumberPrint, 
					"@ModifyBy",  _Invoice.ModifyBy, 
					"@ModifyDate",  _Invoice.ModifyDate);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng Invoice vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<Invoice> _Invoices)
		{
			foreach (Invoice item in _Invoices)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Invoice vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, Invoice _Invoice, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Invoice] SET Id=@Id, Code=@Code, Tile=@Tile, FK_Customer=@FK_Customer, FK_Branch=@FK_Branch, FK_Cashier=@FK_Cashier, FK_Employee=@FK_Employee, FK_Voucher=@FK_Voucher, CreateDate=@CreateDate, TotalPrice=@TotalPrice, VoucherPrice=@VoucherPrice, TotalItem=@TotalItem, Note=@Note, Status=@Status, FK_DeleteBy=@FK_DeleteBy, Reason=@Reason, FK_Room=@FK_Room, ExtraPrice=@ExtraPrice, ServicePrice=@ServicePrice, IsDelete=@IsDelete, NumberPrint=@NumberPrint, ModifyBy=@ModifyBy, ModifyDate=@ModifyDate WHERE Id=@Id", 
					"@Id",  _Invoice.Id, 
					"@Code",  _Invoice.Code, 
					"@Tile",  _Invoice.Tile, 
					"@FK_Customer",  _Invoice.FK_Customer, 
					"@FK_Branch",  _Invoice.FK_Branch, 
					"@FK_Cashier",  _Invoice.FK_Cashier, 
					"@FK_Employee",  _Invoice.FK_Employee, 
					"@FK_Voucher",  _Invoice.FK_Voucher, 
					"@CreateDate", this._dataContext.ConvertDateString( _Invoice.CreateDate), 
					"@TotalPrice",  _Invoice.TotalPrice, 
					"@VoucherPrice",  _Invoice.VoucherPrice, 
					"@TotalItem",  _Invoice.TotalItem, 
					"@Note",  _Invoice.Note, 
					"@Status",  _Invoice.Status, 
					"@FK_DeleteBy",  _Invoice.FK_DeleteBy, 
					"@Reason",  _Invoice.Reason, 
					"@FK_Room",  _Invoice.FK_Room, 
					"@ExtraPrice",  _Invoice.ExtraPrice, 
					"@ServicePrice",  _Invoice.ServicePrice, 
					"@IsDelete",  _Invoice.IsDelete, 
					"@NumberPrint",  _Invoice.NumberPrint, 
					"@ModifyBy",  _Invoice.ModifyBy, 
					"@ModifyDate",  _Invoice.ModifyDate, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật Invoice vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, Invoice _Invoice)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Invoice] SET Code=@Code, Tile=@Tile, FK_Customer=@FK_Customer, FK_Branch=@FK_Branch, FK_Cashier=@FK_Cashier, FK_Employee=@FK_Employee, FK_Voucher=@FK_Voucher, CreateDate=@CreateDate, TotalPrice=@TotalPrice, VoucherPrice=@VoucherPrice, TotalItem=@TotalItem, Note=@Note, Status=@Status, FK_DeleteBy=@FK_DeleteBy, Reason=@Reason, FK_Room=@FK_Room, ExtraPrice=@ExtraPrice, ServicePrice=@ServicePrice, IsDelete=@IsDelete, NumberPrint=@NumberPrint, ModifyBy=@ModifyBy, ModifyDate=@ModifyDate WHERE Id=@Id", 
					"@Code",  _Invoice.Code, 
					"@Tile",  _Invoice.Tile, 
					"@FK_Customer",  _Invoice.FK_Customer, 
					"@FK_Branch",  _Invoice.FK_Branch, 
					"@FK_Cashier",  _Invoice.FK_Cashier, 
					"@FK_Employee",  _Invoice.FK_Employee, 
					"@FK_Voucher",  _Invoice.FK_Voucher, 
					"@CreateDate", this._dataContext.ConvertDateString( _Invoice.CreateDate), 
					"@TotalPrice",  _Invoice.TotalPrice, 
					"@VoucherPrice",  _Invoice.VoucherPrice, 
					"@TotalItem",  _Invoice.TotalItem, 
					"@Note",  _Invoice.Note, 
					"@Status",  _Invoice.Status, 
					"@FK_DeleteBy",  _Invoice.FK_DeleteBy, 
					"@Reason",  _Invoice.Reason, 
					"@FK_Room",  _Invoice.FK_Room, 
					"@ExtraPrice",  _Invoice.ExtraPrice, 
					"@ServicePrice",  _Invoice.ServicePrice, 
					"@IsDelete",  _Invoice.IsDelete, 
					"@NumberPrint",  _Invoice.NumberPrint, 
					"@ModifyBy",  _Invoice.ModifyBy, 
					"@ModifyDate",  _Invoice.ModifyDate, 
					"@Id", _Invoice.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách Invoice vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<Invoice> _Invoices)
		{
			foreach (Invoice item in _Invoices)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Invoice vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, Invoice _Invoice, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Invoice] SET Id=@Id, Code=@Code, Tile=@Tile, FK_Customer=@FK_Customer, FK_Branch=@FK_Branch, FK_Cashier=@FK_Cashier, FK_Employee=@FK_Employee, FK_Voucher=@FK_Voucher, CreateDate=@CreateDate, TotalPrice=@TotalPrice, VoucherPrice=@VoucherPrice, TotalItem=@TotalItem, Note=@Note, Status=@Status, FK_DeleteBy=@FK_DeleteBy, Reason=@Reason, FK_Room=@FK_Room, ExtraPrice=@ExtraPrice, ServicePrice=@ServicePrice, IsDelete=@IsDelete, NumberPrint=@NumberPrint, ModifyBy=@ModifyBy, ModifyDate=@ModifyDate "+ condition, 
					"@Id",  _Invoice.Id, 
					"@Code",  _Invoice.Code, 
					"@Tile",  _Invoice.Tile, 
					"@FK_Customer",  _Invoice.FK_Customer, 
					"@FK_Branch",  _Invoice.FK_Branch, 
					"@FK_Cashier",  _Invoice.FK_Cashier, 
					"@FK_Employee",  _Invoice.FK_Employee, 
					"@FK_Voucher",  _Invoice.FK_Voucher, 
					"@CreateDate", this._dataContext.ConvertDateString( _Invoice.CreateDate), 
					"@TotalPrice",  _Invoice.TotalPrice, 
					"@VoucherPrice",  _Invoice.VoucherPrice, 
					"@TotalItem",  _Invoice.TotalItem, 
					"@Note",  _Invoice.Note, 
					"@Status",  _Invoice.Status, 
					"@FK_DeleteBy",  _Invoice.FK_DeleteBy, 
					"@Reason",  _Invoice.Reason, 
					"@FK_Room",  _Invoice.FK_Room, 
					"@ExtraPrice",  _Invoice.ExtraPrice, 
					"@ServicePrice",  _Invoice.ServicePrice, 
					"@IsDelete",  _Invoice.IsDelete, 
					"@NumberPrint",  _Invoice.NumberPrint, 
					"@ModifyBy",  _Invoice.ModifyBy, 
					"@ModifyDate",  _Invoice.ModifyDate);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa Invoice trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Invoice] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Invoice trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Invoice _Invoice)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Invoice] WHERE Id=@Id",
					"@Id", _Invoice.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Invoice trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Invoice] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Invoice trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<Invoice> _Invoices)
		{
			foreach (Invoice item in _Invoices)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
