using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbshoping:IWEbshoping
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbshoping(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebShoping từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebShoping]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebShoping từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebShoping] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebShoping từ Database
		/// </summary>
		public List<WebShoping> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebShoping]");
				List<WebShoping> items = new List<WebShoping>();
				WebShoping item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebShoping();
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
					if (dr["CusName"] != null && dr["CusName"] != DBNull.Value)
					{
						item.CusName = Convert.ToString(dr["CusName"]);
					}
					if (dr["CusAddress"] != null && dr["CusAddress"] != DBNull.Value)
					{
						item.CusAddress = Convert.ToString(dr["CusAddress"]);
					}
					if (dr["FK_City"] != null && dr["FK_City"] != DBNull.Value)
					{
						item.FK_City = Convert.ToString(dr["FK_City"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["PhoneNumber"] != null && dr["PhoneNumber"] != DBNull.Value)
					{
						item.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
					}
					if (dr["ReName"] != null && dr["ReName"] != DBNull.Value)
					{
						item.ReName = Convert.ToString(dr["ReName"]);
					}
					if (dr["ReAddress"] != null && dr["ReAddress"] != DBNull.Value)
					{
						item.ReAddress = Convert.ToString(dr["ReAddress"]);
					}
					if (dr["FK_ReCity"] != null && dr["FK_ReCity"] != DBNull.Value)
					{
						item.FK_ReCity = Convert.ToString(dr["FK_ReCity"]);
					}
					if (dr["ReEmail"] != null && dr["ReEmail"] != DBNull.Value)
					{
						item.ReEmail = Convert.ToString(dr["ReEmail"]);
					}
					if (dr["RePhoneNumber"] != null && dr["RePhoneNumber"] != DBNull.Value)
					{
						item.RePhoneNumber = Convert.ToString(dr["RePhoneNumber"]);
					}
					if (dr["ReNote"] != null && dr["ReNote"] != DBNull.Value)
					{
						item.ReNote = Convert.ToString(dr["ReNote"]);
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
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["ShipPrice"] != null && dr["ShipPrice"] != DBNull.Value)
					{
						item.ShipPrice = Convert.ToInt32(dr["ShipPrice"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_DeleteBy"] != null && dr["FK_DeleteBy"] != DBNull.Value)
					{
						item.FK_DeleteBy = Convert.ToString(dr["FK_DeleteBy"]);
					}
					if (dr["DeleteReason"] != null && dr["DeleteReason"] != DBNull.Value)
					{
						item.DeleteReason = Convert.ToString(dr["DeleteReason"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy danh sách WebShoping từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebShoping> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebShoping] A "+ condition,  parameters);
				List<WebShoping> items = new List<WebShoping>();
				WebShoping item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebShoping();
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
					if (dr["CusName"] != null && dr["CusName"] != DBNull.Value)
					{
						item.CusName = Convert.ToString(dr["CusName"]);
					}
					if (dr["CusAddress"] != null && dr["CusAddress"] != DBNull.Value)
					{
						item.CusAddress = Convert.ToString(dr["CusAddress"]);
					}
					if (dr["FK_City"] != null && dr["FK_City"] != DBNull.Value)
					{
						item.FK_City = Convert.ToString(dr["FK_City"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["PhoneNumber"] != null && dr["PhoneNumber"] != DBNull.Value)
					{
						item.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
					}
					if (dr["ReName"] != null && dr["ReName"] != DBNull.Value)
					{
						item.ReName = Convert.ToString(dr["ReName"]);
					}
					if (dr["ReAddress"] != null && dr["ReAddress"] != DBNull.Value)
					{
						item.ReAddress = Convert.ToString(dr["ReAddress"]);
					}
					if (dr["FK_ReCity"] != null && dr["FK_ReCity"] != DBNull.Value)
					{
						item.FK_ReCity = Convert.ToString(dr["FK_ReCity"]);
					}
					if (dr["ReEmail"] != null && dr["ReEmail"] != DBNull.Value)
					{
						item.ReEmail = Convert.ToString(dr["ReEmail"]);
					}
					if (dr["RePhoneNumber"] != null && dr["RePhoneNumber"] != DBNull.Value)
					{
						item.RePhoneNumber = Convert.ToString(dr["RePhoneNumber"]);
					}
					if (dr["ReNote"] != null && dr["ReNote"] != DBNull.Value)
					{
						item.ReNote = Convert.ToString(dr["ReNote"]);
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
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["ShipPrice"] != null && dr["ShipPrice"] != DBNull.Value)
					{
						item.ShipPrice = Convert.ToInt32(dr["ShipPrice"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_DeleteBy"] != null && dr["FK_DeleteBy"] != DBNull.Value)
					{
						item.FK_DeleteBy = Convert.ToString(dr["FK_DeleteBy"]);
					}
					if (dr["DeleteReason"] != null && dr["DeleteReason"] != DBNull.Value)
					{
						item.DeleteReason = Convert.ToString(dr["DeleteReason"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public List<WebShoping> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebShoping] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebShoping] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebShoping>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebShoping từ Database
		/// </summary>
		public WebShoping GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebShoping] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebShoping item=new WebShoping();
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
						if (dr["CusName"] != null && dr["CusName"] != DBNull.Value)
						{
							item.CusName = Convert.ToString(dr["CusName"]);
						}
						if (dr["CusAddress"] != null && dr["CusAddress"] != DBNull.Value)
						{
							item.CusAddress = Convert.ToString(dr["CusAddress"]);
						}
						if (dr["FK_City"] != null && dr["FK_City"] != DBNull.Value)
						{
							item.FK_City = Convert.ToString(dr["FK_City"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["PhoneNumber"] != null && dr["PhoneNumber"] != DBNull.Value)
						{
							item.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
						}
						if (dr["ReName"] != null && dr["ReName"] != DBNull.Value)
						{
							item.ReName = Convert.ToString(dr["ReName"]);
						}
						if (dr["ReAddress"] != null && dr["ReAddress"] != DBNull.Value)
						{
							item.ReAddress = Convert.ToString(dr["ReAddress"]);
						}
						if (dr["FK_ReCity"] != null && dr["FK_ReCity"] != DBNull.Value)
						{
							item.FK_ReCity = Convert.ToString(dr["FK_ReCity"]);
						}
						if (dr["ReEmail"] != null && dr["ReEmail"] != DBNull.Value)
						{
							item.ReEmail = Convert.ToString(dr["ReEmail"]);
						}
						if (dr["RePhoneNumber"] != null && dr["RePhoneNumber"] != DBNull.Value)
						{
							item.RePhoneNumber = Convert.ToString(dr["RePhoneNumber"]);
						}
						if (dr["ReNote"] != null && dr["ReNote"] != DBNull.Value)
						{
							item.ReNote = Convert.ToString(dr["ReNote"]);
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
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["ShipPrice"] != null && dr["ShipPrice"] != DBNull.Value)
						{
							item.ShipPrice = Convert.ToInt32(dr["ShipPrice"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["FK_DeleteBy"] != null && dr["FK_DeleteBy"] != DBNull.Value)
						{
							item.FK_DeleteBy = Convert.ToString(dr["FK_DeleteBy"]);
						}
						if (dr["DeleteReason"] != null && dr["DeleteReason"] != DBNull.Value)
						{
							item.DeleteReason = Convert.ToString(dr["DeleteReason"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy một WebShoping đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebShoping GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebShoping] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebShoping item=new WebShoping();
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
						if (dr["CusName"] != null && dr["CusName"] != DBNull.Value)
						{
							item.CusName = Convert.ToString(dr["CusName"]);
						}
						if (dr["CusAddress"] != null && dr["CusAddress"] != DBNull.Value)
						{
							item.CusAddress = Convert.ToString(dr["CusAddress"]);
						}
						if (dr["FK_City"] != null && dr["FK_City"] != DBNull.Value)
						{
							item.FK_City = Convert.ToString(dr["FK_City"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["PhoneNumber"] != null && dr["PhoneNumber"] != DBNull.Value)
						{
							item.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
						}
						if (dr["ReName"] != null && dr["ReName"] != DBNull.Value)
						{
							item.ReName = Convert.ToString(dr["ReName"]);
						}
						if (dr["ReAddress"] != null && dr["ReAddress"] != DBNull.Value)
						{
							item.ReAddress = Convert.ToString(dr["ReAddress"]);
						}
						if (dr["FK_ReCity"] != null && dr["FK_ReCity"] != DBNull.Value)
						{
							item.FK_ReCity = Convert.ToString(dr["FK_ReCity"]);
						}
						if (dr["ReEmail"] != null && dr["ReEmail"] != DBNull.Value)
						{
							item.ReEmail = Convert.ToString(dr["ReEmail"]);
						}
						if (dr["RePhoneNumber"] != null && dr["RePhoneNumber"] != DBNull.Value)
						{
							item.RePhoneNumber = Convert.ToString(dr["RePhoneNumber"]);
						}
						if (dr["ReNote"] != null && dr["ReNote"] != DBNull.Value)
						{
							item.ReNote = Convert.ToString(dr["ReNote"]);
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
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["ShipPrice"] != null && dr["ShipPrice"] != DBNull.Value)
						{
							item.ShipPrice = Convert.ToInt32(dr["ShipPrice"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["FK_DeleteBy"] != null && dr["FK_DeleteBy"] != DBNull.Value)
						{
							item.FK_DeleteBy = Convert.ToString(dr["FK_DeleteBy"]);
						}
						if (dr["DeleteReason"] != null && dr["DeleteReason"] != DBNull.Value)
						{
							item.DeleteReason = Convert.ToString(dr["DeleteReason"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public WebShoping GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebShoping] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebShoping>(ds);
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
		/// Thêm mới WebShoping vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebShoping _WebShoping)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebShoping](Id, Code, Tile, FK_Customer, CusName, CusAddress, FK_City, Email, PhoneNumber, ReName, ReAddress, FK_ReCity, ReEmail, RePhoneNumber, ReNote, CreateDate, TotalPrice, VoucherPrice, TotalItem, Status, ShipPrice, Note, FK_DeleteBy, DeleteReason, IsDelete, BranchCode) VALUES(@Id, @Code, @Tile, @FK_Customer, @CusName, @CusAddress, @FK_City, @Email, @PhoneNumber, @ReName, @ReAddress, @FK_ReCity, @ReEmail, @RePhoneNumber, @ReNote, @CreateDate, @TotalPrice, @VoucherPrice, @TotalItem, @Status, @ShipPrice, @Note, @FK_DeleteBy, @DeleteReason, @IsDelete, @BranchCode)", 
					"@Id",  _WebShoping.Id, 
					"@Code",  _WebShoping.Code, 
					"@Tile",  _WebShoping.Tile, 
					"@FK_Customer",  _WebShoping.FK_Customer, 
					"@CusName",  _WebShoping.CusName, 
					"@CusAddress",  _WebShoping.CusAddress, 
					"@FK_City",  _WebShoping.FK_City, 
					"@Email",  _WebShoping.Email, 
					"@PhoneNumber",  _WebShoping.PhoneNumber, 
					"@ReName",  _WebShoping.ReName, 
					"@ReAddress",  _WebShoping.ReAddress, 
					"@FK_ReCity",  _WebShoping.FK_ReCity, 
					"@ReEmail",  _WebShoping.ReEmail, 
					"@RePhoneNumber",  _WebShoping.RePhoneNumber, 
					"@ReNote",  _WebShoping.ReNote, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebShoping.CreateDate), 
					"@TotalPrice",  _WebShoping.TotalPrice, 
					"@VoucherPrice",  _WebShoping.VoucherPrice, 
					"@TotalItem",  _WebShoping.TotalItem, 
					"@Status",  _WebShoping.Status, 
					"@ShipPrice",  _WebShoping.ShipPrice, 
					"@Note",  _WebShoping.Note, 
					"@FK_DeleteBy",  _WebShoping.FK_DeleteBy, 
					"@DeleteReason",  _WebShoping.DeleteReason, 
					"@IsDelete",  _WebShoping.IsDelete, 
					"@BranchCode",  _WebShoping.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebShoping vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebShoping> _WebShopings)
		{
			foreach (WebShoping item in _WebShopings)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebShoping vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebShoping _WebShoping, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebShoping] SET Id=@Id, Code=@Code, Tile=@Tile, FK_Customer=@FK_Customer, CusName=@CusName, CusAddress=@CusAddress, FK_City=@FK_City, Email=@Email, PhoneNumber=@PhoneNumber, ReName=@ReName, ReAddress=@ReAddress, FK_ReCity=@FK_ReCity, ReEmail=@ReEmail, RePhoneNumber=@RePhoneNumber, ReNote=@ReNote, CreateDate=@CreateDate, TotalPrice=@TotalPrice, VoucherPrice=@VoucherPrice, TotalItem=@TotalItem, Status=@Status, ShipPrice=@ShipPrice, Note=@Note, FK_DeleteBy=@FK_DeleteBy, DeleteReason=@DeleteReason, IsDelete=@IsDelete, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebShoping.Id, 
					"@Code",  _WebShoping.Code, 
					"@Tile",  _WebShoping.Tile, 
					"@FK_Customer",  _WebShoping.FK_Customer, 
					"@CusName",  _WebShoping.CusName, 
					"@CusAddress",  _WebShoping.CusAddress, 
					"@FK_City",  _WebShoping.FK_City, 
					"@Email",  _WebShoping.Email, 
					"@PhoneNumber",  _WebShoping.PhoneNumber, 
					"@ReName",  _WebShoping.ReName, 
					"@ReAddress",  _WebShoping.ReAddress, 
					"@FK_ReCity",  _WebShoping.FK_ReCity, 
					"@ReEmail",  _WebShoping.ReEmail, 
					"@RePhoneNumber",  _WebShoping.RePhoneNumber, 
					"@ReNote",  _WebShoping.ReNote, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebShoping.CreateDate), 
					"@TotalPrice",  _WebShoping.TotalPrice, 
					"@VoucherPrice",  _WebShoping.VoucherPrice, 
					"@TotalItem",  _WebShoping.TotalItem, 
					"@Status",  _WebShoping.Status, 
					"@ShipPrice",  _WebShoping.ShipPrice, 
					"@Note",  _WebShoping.Note, 
					"@FK_DeleteBy",  _WebShoping.FK_DeleteBy, 
					"@DeleteReason",  _WebShoping.DeleteReason, 
					"@IsDelete",  _WebShoping.IsDelete, 
					"@BranchCode",  _WebShoping.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebShoping vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebShoping _WebShoping)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebShoping] SET Code=@Code, Tile=@Tile, FK_Customer=@FK_Customer, CusName=@CusName, CusAddress=@CusAddress, FK_City=@FK_City, Email=@Email, PhoneNumber=@PhoneNumber, ReName=@ReName, ReAddress=@ReAddress, FK_ReCity=@FK_ReCity, ReEmail=@ReEmail, RePhoneNumber=@RePhoneNumber, ReNote=@ReNote, CreateDate=@CreateDate, TotalPrice=@TotalPrice, VoucherPrice=@VoucherPrice, TotalItem=@TotalItem, Status=@Status, ShipPrice=@ShipPrice, Note=@Note, FK_DeleteBy=@FK_DeleteBy, DeleteReason=@DeleteReason, IsDelete=@IsDelete, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Code",  _WebShoping.Code, 
					"@Tile",  _WebShoping.Tile, 
					"@FK_Customer",  _WebShoping.FK_Customer, 
					"@CusName",  _WebShoping.CusName, 
					"@CusAddress",  _WebShoping.CusAddress, 
					"@FK_City",  _WebShoping.FK_City, 
					"@Email",  _WebShoping.Email, 
					"@PhoneNumber",  _WebShoping.PhoneNumber, 
					"@ReName",  _WebShoping.ReName, 
					"@ReAddress",  _WebShoping.ReAddress, 
					"@FK_ReCity",  _WebShoping.FK_ReCity, 
					"@ReEmail",  _WebShoping.ReEmail, 
					"@RePhoneNumber",  _WebShoping.RePhoneNumber, 
					"@ReNote",  _WebShoping.ReNote, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebShoping.CreateDate), 
					"@TotalPrice",  _WebShoping.TotalPrice, 
					"@VoucherPrice",  _WebShoping.VoucherPrice, 
					"@TotalItem",  _WebShoping.TotalItem, 
					"@Status",  _WebShoping.Status, 
					"@ShipPrice",  _WebShoping.ShipPrice, 
					"@Note",  _WebShoping.Note, 
					"@FK_DeleteBy",  _WebShoping.FK_DeleteBy, 
					"@DeleteReason",  _WebShoping.DeleteReason, 
					"@IsDelete",  _WebShoping.IsDelete, 
					"@BranchCode",  _WebShoping.BranchCode, 
					"@Id", _WebShoping.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebShoping vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebShoping> _WebShopings)
		{
			foreach (WebShoping item in _WebShopings)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebShoping vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebShoping _WebShoping, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebShoping] SET Id=@Id, Code=@Code, Tile=@Tile, FK_Customer=@FK_Customer, CusName=@CusName, CusAddress=@CusAddress, FK_City=@FK_City, Email=@Email, PhoneNumber=@PhoneNumber, ReName=@ReName, ReAddress=@ReAddress, FK_ReCity=@FK_ReCity, ReEmail=@ReEmail, RePhoneNumber=@RePhoneNumber, ReNote=@ReNote, CreateDate=@CreateDate, TotalPrice=@TotalPrice, VoucherPrice=@VoucherPrice, TotalItem=@TotalItem, Status=@Status, ShipPrice=@ShipPrice, Note=@Note, FK_DeleteBy=@FK_DeleteBy, DeleteReason=@DeleteReason, IsDelete=@IsDelete, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebShoping.Id, 
					"@Code",  _WebShoping.Code, 
					"@Tile",  _WebShoping.Tile, 
					"@FK_Customer",  _WebShoping.FK_Customer, 
					"@CusName",  _WebShoping.CusName, 
					"@CusAddress",  _WebShoping.CusAddress, 
					"@FK_City",  _WebShoping.FK_City, 
					"@Email",  _WebShoping.Email, 
					"@PhoneNumber",  _WebShoping.PhoneNumber, 
					"@ReName",  _WebShoping.ReName, 
					"@ReAddress",  _WebShoping.ReAddress, 
					"@FK_ReCity",  _WebShoping.FK_ReCity, 
					"@ReEmail",  _WebShoping.ReEmail, 
					"@RePhoneNumber",  _WebShoping.RePhoneNumber, 
					"@ReNote",  _WebShoping.ReNote, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebShoping.CreateDate), 
					"@TotalPrice",  _WebShoping.TotalPrice, 
					"@VoucherPrice",  _WebShoping.VoucherPrice, 
					"@TotalItem",  _WebShoping.TotalItem, 
					"@Status",  _WebShoping.Status, 
					"@ShipPrice",  _WebShoping.ShipPrice, 
					"@Note",  _WebShoping.Note, 
					"@FK_DeleteBy",  _WebShoping.FK_DeleteBy, 
					"@DeleteReason",  _WebShoping.DeleteReason, 
					"@IsDelete",  _WebShoping.IsDelete, 
					"@BranchCode",  _WebShoping.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebShoping trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebShoping] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebShoping trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebShoping _WebShoping)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebShoping] WHERE Id=@Id",
					"@Id", _WebShoping.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebShoping trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebShoping] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebShoping trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebShoping> _WebShopings)
		{
			foreach (WebShoping item in _WebShopings)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
