using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGScustomeroder:IGScustomeroder
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGScustomeroder(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsCustomerOder từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCustomerOder]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsCustomerOder từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCustomerOder] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsCustomerOder từ Database
		/// </summary>
		public List<GsCustomerOder> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCustomerOder]");
				List<GsCustomerOder> items = new List<GsCustomerOder>();
				GsCustomerOder item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsCustomerOder();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["AccountObjecID"] != null && dr["AccountObjecID"] != DBNull.Value)
					{
						item.AccountObjecID = Convert.ToString(dr["AccountObjecID"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Department"] != null && dr["FK_Department"] != DBNull.Value)
					{
						item.FK_Department = Convert.ToString(dr["FK_Department"]);
					}
					if (dr["FK_ACEmployee"] != null && dr["FK_ACEmployee"] != DBNull.Value)
					{
						item.FK_ACEmployee = Convert.ToString(dr["FK_ACEmployee"]);
					}
					if (dr["FK_CustomerSource"] != null && dr["FK_CustomerSource"] != DBNull.Value)
					{
						item.FK_CustomerSource = Convert.ToString(dr["FK_CustomerSource"]);
					}
					if (dr["FK_DataChanel"] != null && dr["FK_DataChanel"] != DBNull.Value)
					{
						item.FK_DataChanel = Convert.ToString(dr["FK_DataChanel"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["CustomerAdd"] != null && dr["CustomerAdd"] != DBNull.Value)
					{
						item.CustomerAdd = Convert.ToString(dr["CustomerAdd"]);
					}
					if (dr["FK_Contry"] != null && dr["FK_Contry"] != DBNull.Value)
					{
						item.FK_Contry = Convert.ToString(dr["FK_Contry"]);
					}
					if (dr["FK_CompanyType"] != null && dr["FK_CompanyType"] != DBNull.Value)
					{
						item.FK_CompanyType = Convert.ToString(dr["FK_CompanyType"]);
					}
					if (dr["Website"] != null && dr["Website"] != DBNull.Value)
					{
						item.Website = Convert.ToString(dr["Website"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["ContactName"] != null && dr["ContactName"] != DBNull.Value)
					{
						item.ContactName = Convert.ToString(dr["ContactName"]);
					}
					if (dr["ContactPosition"] != null && dr["ContactPosition"] != DBNull.Value)
					{
						item.ContactPosition = Convert.ToString(dr["ContactPosition"]);
					}
					if (dr["ContactMobile"] != null && dr["ContactMobile"] != DBNull.Value)
					{
						item.ContactMobile = Convert.ToString(dr["ContactMobile"]);
					}
					if (dr["MessengerChat"] != null && dr["MessengerChat"] != DBNull.Value)
					{
						item.MessengerChat = Convert.ToString(dr["MessengerChat"]);
					}
					if (dr["ImportFrom"] != null && dr["ImportFrom"] != DBNull.Value)
					{
						item.ImportFrom = Convert.ToString(dr["ImportFrom"]);
					}
					if (dr["ExportTo"] != null && dr["ExportTo"] != DBNull.Value)
					{
						item.ExportTo = Convert.ToString(dr["ExportTo"]);
					}
					if (dr["ProductName"] != null && dr["ProductName"] != DBNull.Value)
					{
						item.ProductName = Convert.ToString(dr["ProductName"]);
					}
					if (dr["ProductDescription"] != null && dr["ProductDescription"] != DBNull.Value)
					{
						item.ProductDescription = Convert.ToString(dr["ProductDescription"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToInt32(dr["Quantity"]);
					}
					if (dr["DeliveryCondition"] != null && dr["DeliveryCondition"] != DBNull.Value)
					{
						item.DeliveryCondition = Convert.ToString(dr["DeliveryCondition"]);
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
		/// Lấy danh sách GsCustomerOder từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsCustomerOder> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsCustomerOder] A "+ condition,  parameters);
				List<GsCustomerOder> items = new List<GsCustomerOder>();
				GsCustomerOder item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsCustomerOder();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["AccountObjecID"] != null && dr["AccountObjecID"] != DBNull.Value)
					{
						item.AccountObjecID = Convert.ToString(dr["AccountObjecID"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Department"] != null && dr["FK_Department"] != DBNull.Value)
					{
						item.FK_Department = Convert.ToString(dr["FK_Department"]);
					}
					if (dr["FK_ACEmployee"] != null && dr["FK_ACEmployee"] != DBNull.Value)
					{
						item.FK_ACEmployee = Convert.ToString(dr["FK_ACEmployee"]);
					}
					if (dr["FK_CustomerSource"] != null && dr["FK_CustomerSource"] != DBNull.Value)
					{
						item.FK_CustomerSource = Convert.ToString(dr["FK_CustomerSource"]);
					}
					if (dr["FK_DataChanel"] != null && dr["FK_DataChanel"] != DBNull.Value)
					{
						item.FK_DataChanel = Convert.ToString(dr["FK_DataChanel"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["CustomerAdd"] != null && dr["CustomerAdd"] != DBNull.Value)
					{
						item.CustomerAdd = Convert.ToString(dr["CustomerAdd"]);
					}
					if (dr["FK_Contry"] != null && dr["FK_Contry"] != DBNull.Value)
					{
						item.FK_Contry = Convert.ToString(dr["FK_Contry"]);
					}
					if (dr["FK_CompanyType"] != null && dr["FK_CompanyType"] != DBNull.Value)
					{
						item.FK_CompanyType = Convert.ToString(dr["FK_CompanyType"]);
					}
					if (dr["Website"] != null && dr["Website"] != DBNull.Value)
					{
						item.Website = Convert.ToString(dr["Website"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["ContactName"] != null && dr["ContactName"] != DBNull.Value)
					{
						item.ContactName = Convert.ToString(dr["ContactName"]);
					}
					if (dr["ContactPosition"] != null && dr["ContactPosition"] != DBNull.Value)
					{
						item.ContactPosition = Convert.ToString(dr["ContactPosition"]);
					}
					if (dr["ContactMobile"] != null && dr["ContactMobile"] != DBNull.Value)
					{
						item.ContactMobile = Convert.ToString(dr["ContactMobile"]);
					}
					if (dr["MessengerChat"] != null && dr["MessengerChat"] != DBNull.Value)
					{
						item.MessengerChat = Convert.ToString(dr["MessengerChat"]);
					}
					if (dr["ImportFrom"] != null && dr["ImportFrom"] != DBNull.Value)
					{
						item.ImportFrom = Convert.ToString(dr["ImportFrom"]);
					}
					if (dr["ExportTo"] != null && dr["ExportTo"] != DBNull.Value)
					{
						item.ExportTo = Convert.ToString(dr["ExportTo"]);
					}
					if (dr["ProductName"] != null && dr["ProductName"] != DBNull.Value)
					{
						item.ProductName = Convert.ToString(dr["ProductName"]);
					}
					if (dr["ProductDescription"] != null && dr["ProductDescription"] != DBNull.Value)
					{
						item.ProductDescription = Convert.ToString(dr["ProductDescription"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToInt32(dr["Quantity"]);
					}
					if (dr["DeliveryCondition"] != null && dr["DeliveryCondition"] != DBNull.Value)
					{
						item.DeliveryCondition = Convert.ToString(dr["DeliveryCondition"]);
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

		public List<GsCustomerOder> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsCustomerOder] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsCustomerOder] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsCustomerOder>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsCustomerOder từ Database
		/// </summary>
		public GsCustomerOder GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCustomerOder] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsCustomerOder item=new GsCustomerOder();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["AccountObjecID"] != null && dr["AccountObjecID"] != DBNull.Value)
						{
							item.AccountObjecID = Convert.ToString(dr["AccountObjecID"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_Department"] != null && dr["FK_Department"] != DBNull.Value)
						{
							item.FK_Department = Convert.ToString(dr["FK_Department"]);
						}
						if (dr["FK_ACEmployee"] != null && dr["FK_ACEmployee"] != DBNull.Value)
						{
							item.FK_ACEmployee = Convert.ToString(dr["FK_ACEmployee"]);
						}
						if (dr["FK_CustomerSource"] != null && dr["FK_CustomerSource"] != DBNull.Value)
						{
							item.FK_CustomerSource = Convert.ToString(dr["FK_CustomerSource"]);
						}
						if (dr["FK_DataChanel"] != null && dr["FK_DataChanel"] != DBNull.Value)
						{
							item.FK_DataChanel = Convert.ToString(dr["FK_DataChanel"]);
						}
						if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
						{
							item.CustomerName = Convert.ToString(dr["CustomerName"]);
						}
						if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
						{
							item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
						}
						if (dr["CustomerAdd"] != null && dr["CustomerAdd"] != DBNull.Value)
						{
							item.CustomerAdd = Convert.ToString(dr["CustomerAdd"]);
						}
						if (dr["FK_Contry"] != null && dr["FK_Contry"] != DBNull.Value)
						{
							item.FK_Contry = Convert.ToString(dr["FK_Contry"]);
						}
						if (dr["FK_CompanyType"] != null && dr["FK_CompanyType"] != DBNull.Value)
						{
							item.FK_CompanyType = Convert.ToString(dr["FK_CompanyType"]);
						}
						if (dr["Website"] != null && dr["Website"] != DBNull.Value)
						{
							item.Website = Convert.ToString(dr["Website"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["ContactName"] != null && dr["ContactName"] != DBNull.Value)
						{
							item.ContactName = Convert.ToString(dr["ContactName"]);
						}
						if (dr["ContactPosition"] != null && dr["ContactPosition"] != DBNull.Value)
						{
							item.ContactPosition = Convert.ToString(dr["ContactPosition"]);
						}
						if (dr["ContactMobile"] != null && dr["ContactMobile"] != DBNull.Value)
						{
							item.ContactMobile = Convert.ToString(dr["ContactMobile"]);
						}
						if (dr["MessengerChat"] != null && dr["MessengerChat"] != DBNull.Value)
						{
							item.MessengerChat = Convert.ToString(dr["MessengerChat"]);
						}
						if (dr["ImportFrom"] != null && dr["ImportFrom"] != DBNull.Value)
						{
							item.ImportFrom = Convert.ToString(dr["ImportFrom"]);
						}
						if (dr["ExportTo"] != null && dr["ExportTo"] != DBNull.Value)
						{
							item.ExportTo = Convert.ToString(dr["ExportTo"]);
						}
						if (dr["ProductName"] != null && dr["ProductName"] != DBNull.Value)
						{
							item.ProductName = Convert.ToString(dr["ProductName"]);
						}
						if (dr["ProductDescription"] != null && dr["ProductDescription"] != DBNull.Value)
						{
							item.ProductDescription = Convert.ToString(dr["ProductDescription"]);
						}
						if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
						{
							item.Quantity = Convert.ToInt32(dr["Quantity"]);
						}
						if (dr["DeliveryCondition"] != null && dr["DeliveryCondition"] != DBNull.Value)
						{
							item.DeliveryCondition = Convert.ToString(dr["DeliveryCondition"]);
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
		/// Lấy một GsCustomerOder đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsCustomerOder GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsCustomerOder] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsCustomerOder item=new GsCustomerOder();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["AccountObjecID"] != null && dr["AccountObjecID"] != DBNull.Value)
						{
							item.AccountObjecID = Convert.ToString(dr["AccountObjecID"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_Department"] != null && dr["FK_Department"] != DBNull.Value)
						{
							item.FK_Department = Convert.ToString(dr["FK_Department"]);
						}
						if (dr["FK_ACEmployee"] != null && dr["FK_ACEmployee"] != DBNull.Value)
						{
							item.FK_ACEmployee = Convert.ToString(dr["FK_ACEmployee"]);
						}
						if (dr["FK_CustomerSource"] != null && dr["FK_CustomerSource"] != DBNull.Value)
						{
							item.FK_CustomerSource = Convert.ToString(dr["FK_CustomerSource"]);
						}
						if (dr["FK_DataChanel"] != null && dr["FK_DataChanel"] != DBNull.Value)
						{
							item.FK_DataChanel = Convert.ToString(dr["FK_DataChanel"]);
						}
						if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
						{
							item.CustomerName = Convert.ToString(dr["CustomerName"]);
						}
						if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
						{
							item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
						}
						if (dr["CustomerAdd"] != null && dr["CustomerAdd"] != DBNull.Value)
						{
							item.CustomerAdd = Convert.ToString(dr["CustomerAdd"]);
						}
						if (dr["FK_Contry"] != null && dr["FK_Contry"] != DBNull.Value)
						{
							item.FK_Contry = Convert.ToString(dr["FK_Contry"]);
						}
						if (dr["FK_CompanyType"] != null && dr["FK_CompanyType"] != DBNull.Value)
						{
							item.FK_CompanyType = Convert.ToString(dr["FK_CompanyType"]);
						}
						if (dr["Website"] != null && dr["Website"] != DBNull.Value)
						{
							item.Website = Convert.ToString(dr["Website"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["ContactName"] != null && dr["ContactName"] != DBNull.Value)
						{
							item.ContactName = Convert.ToString(dr["ContactName"]);
						}
						if (dr["ContactPosition"] != null && dr["ContactPosition"] != DBNull.Value)
						{
							item.ContactPosition = Convert.ToString(dr["ContactPosition"]);
						}
						if (dr["ContactMobile"] != null && dr["ContactMobile"] != DBNull.Value)
						{
							item.ContactMobile = Convert.ToString(dr["ContactMobile"]);
						}
						if (dr["MessengerChat"] != null && dr["MessengerChat"] != DBNull.Value)
						{
							item.MessengerChat = Convert.ToString(dr["MessengerChat"]);
						}
						if (dr["ImportFrom"] != null && dr["ImportFrom"] != DBNull.Value)
						{
							item.ImportFrom = Convert.ToString(dr["ImportFrom"]);
						}
						if (dr["ExportTo"] != null && dr["ExportTo"] != DBNull.Value)
						{
							item.ExportTo = Convert.ToString(dr["ExportTo"]);
						}
						if (dr["ProductName"] != null && dr["ProductName"] != DBNull.Value)
						{
							item.ProductName = Convert.ToString(dr["ProductName"]);
						}
						if (dr["ProductDescription"] != null && dr["ProductDescription"] != DBNull.Value)
						{
							item.ProductDescription = Convert.ToString(dr["ProductDescription"]);
						}
						if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
						{
							item.Quantity = Convert.ToInt32(dr["Quantity"]);
						}
						if (dr["DeliveryCondition"] != null && dr["DeliveryCondition"] != DBNull.Value)
						{
							item.DeliveryCondition = Convert.ToString(dr["DeliveryCondition"]);
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

		public GsCustomerOder GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsCustomerOder] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsCustomerOder>(ds);
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
		/// Thêm mới GsCustomerOder vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsCustomerOder _GsCustomerOder)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsCustomerOder](Id, AccountObjecID, CreateDate, FK_Department, FK_ACEmployee, FK_CustomerSource, FK_DataChanel, CustomerName, CustomerCode, CustomerAdd, FK_Contry, FK_CompanyType, Website, Phone, ContactName, ContactPosition, ContactMobile, MessengerChat, ImportFrom, ExportTo, ProductName, ProductDescription, Quantity, DeliveryCondition) VALUES(@Id, @AccountObjecID, @CreateDate, @FK_Department, @FK_ACEmployee, @FK_CustomerSource, @FK_DataChanel, @CustomerName, @CustomerCode, @CustomerAdd, @FK_Contry, @FK_CompanyType, @Website, @Phone, @ContactName, @ContactPosition, @ContactMobile, @MessengerChat, @ImportFrom, @ExportTo, @ProductName, @ProductDescription, @Quantity, @DeliveryCondition)", 
					"@Id",  _GsCustomerOder.Id, 
					"@AccountObjecID",  _GsCustomerOder.AccountObjecID, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsCustomerOder.CreateDate), 
					"@FK_Department",  _GsCustomerOder.FK_Department, 
					"@FK_ACEmployee",  _GsCustomerOder.FK_ACEmployee, 
					"@FK_CustomerSource",  _GsCustomerOder.FK_CustomerSource, 
					"@FK_DataChanel",  _GsCustomerOder.FK_DataChanel, 
					"@CustomerName",  _GsCustomerOder.CustomerName, 
					"@CustomerCode",  _GsCustomerOder.CustomerCode, 
					"@CustomerAdd",  _GsCustomerOder.CustomerAdd, 
					"@FK_Contry",  _GsCustomerOder.FK_Contry, 
					"@FK_CompanyType",  _GsCustomerOder.FK_CompanyType, 
					"@Website",  _GsCustomerOder.Website, 
					"@Phone",  _GsCustomerOder.Phone, 
					"@ContactName",  _GsCustomerOder.ContactName, 
					"@ContactPosition",  _GsCustomerOder.ContactPosition, 
					"@ContactMobile",  _GsCustomerOder.ContactMobile, 
					"@MessengerChat",  _GsCustomerOder.MessengerChat, 
					"@ImportFrom",  _GsCustomerOder.ImportFrom, 
					"@ExportTo",  _GsCustomerOder.ExportTo, 
					"@ProductName",  _GsCustomerOder.ProductName, 
					"@ProductDescription",  _GsCustomerOder.ProductDescription, 
					"@Quantity",  _GsCustomerOder.Quantity, 
					"@DeliveryCondition",  _GsCustomerOder.DeliveryCondition);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsCustomerOder vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsCustomerOder> _GsCustomerOders)
		{
			foreach (GsCustomerOder item in _GsCustomerOders)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsCustomerOder vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsCustomerOder _GsCustomerOder, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCustomerOder] SET Id=@Id, AccountObjecID=@AccountObjecID, CreateDate=@CreateDate, FK_Department=@FK_Department, FK_ACEmployee=@FK_ACEmployee, FK_CustomerSource=@FK_CustomerSource, FK_DataChanel=@FK_DataChanel, CustomerName=@CustomerName, CustomerCode=@CustomerCode, CustomerAdd=@CustomerAdd, FK_Contry=@FK_Contry, FK_CompanyType=@FK_CompanyType, Website=@Website, Phone=@Phone, ContactName=@ContactName, ContactPosition=@ContactPosition, ContactMobile=@ContactMobile, MessengerChat=@MessengerChat, ImportFrom=@ImportFrom, ExportTo=@ExportTo, ProductName=@ProductName, ProductDescription=@ProductDescription, Quantity=@Quantity, DeliveryCondition=@DeliveryCondition WHERE Id=@Id", 
					"@Id",  _GsCustomerOder.Id, 
					"@AccountObjecID",  _GsCustomerOder.AccountObjecID, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsCustomerOder.CreateDate), 
					"@FK_Department",  _GsCustomerOder.FK_Department, 
					"@FK_ACEmployee",  _GsCustomerOder.FK_ACEmployee, 
					"@FK_CustomerSource",  _GsCustomerOder.FK_CustomerSource, 
					"@FK_DataChanel",  _GsCustomerOder.FK_DataChanel, 
					"@CustomerName",  _GsCustomerOder.CustomerName, 
					"@CustomerCode",  _GsCustomerOder.CustomerCode, 
					"@CustomerAdd",  _GsCustomerOder.CustomerAdd, 
					"@FK_Contry",  _GsCustomerOder.FK_Contry, 
					"@FK_CompanyType",  _GsCustomerOder.FK_CompanyType, 
					"@Website",  _GsCustomerOder.Website, 
					"@Phone",  _GsCustomerOder.Phone, 
					"@ContactName",  _GsCustomerOder.ContactName, 
					"@ContactPosition",  _GsCustomerOder.ContactPosition, 
					"@ContactMobile",  _GsCustomerOder.ContactMobile, 
					"@MessengerChat",  _GsCustomerOder.MessengerChat, 
					"@ImportFrom",  _GsCustomerOder.ImportFrom, 
					"@ExportTo",  _GsCustomerOder.ExportTo, 
					"@ProductName",  _GsCustomerOder.ProductName, 
					"@ProductDescription",  _GsCustomerOder.ProductDescription, 
					"@Quantity",  _GsCustomerOder.Quantity, 
					"@DeliveryCondition",  _GsCustomerOder.DeliveryCondition, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsCustomerOder vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsCustomerOder _GsCustomerOder)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCustomerOder] SET AccountObjecID=@AccountObjecID, CreateDate=@CreateDate, FK_Department=@FK_Department, FK_ACEmployee=@FK_ACEmployee, FK_CustomerSource=@FK_CustomerSource, FK_DataChanel=@FK_DataChanel, CustomerName=@CustomerName, CustomerCode=@CustomerCode, CustomerAdd=@CustomerAdd, FK_Contry=@FK_Contry, FK_CompanyType=@FK_CompanyType, Website=@Website, Phone=@Phone, ContactName=@ContactName, ContactPosition=@ContactPosition, ContactMobile=@ContactMobile, MessengerChat=@MessengerChat, ImportFrom=@ImportFrom, ExportTo=@ExportTo, ProductName=@ProductName, ProductDescription=@ProductDescription, Quantity=@Quantity, DeliveryCondition=@DeliveryCondition WHERE Id=@Id", 
					"@AccountObjecID",  _GsCustomerOder.AccountObjecID, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsCustomerOder.CreateDate), 
					"@FK_Department",  _GsCustomerOder.FK_Department, 
					"@FK_ACEmployee",  _GsCustomerOder.FK_ACEmployee, 
					"@FK_CustomerSource",  _GsCustomerOder.FK_CustomerSource, 
					"@FK_DataChanel",  _GsCustomerOder.FK_DataChanel, 
					"@CustomerName",  _GsCustomerOder.CustomerName, 
					"@CustomerCode",  _GsCustomerOder.CustomerCode, 
					"@CustomerAdd",  _GsCustomerOder.CustomerAdd, 
					"@FK_Contry",  _GsCustomerOder.FK_Contry, 
					"@FK_CompanyType",  _GsCustomerOder.FK_CompanyType, 
					"@Website",  _GsCustomerOder.Website, 
					"@Phone",  _GsCustomerOder.Phone, 
					"@ContactName",  _GsCustomerOder.ContactName, 
					"@ContactPosition",  _GsCustomerOder.ContactPosition, 
					"@ContactMobile",  _GsCustomerOder.ContactMobile, 
					"@MessengerChat",  _GsCustomerOder.MessengerChat, 
					"@ImportFrom",  _GsCustomerOder.ImportFrom, 
					"@ExportTo",  _GsCustomerOder.ExportTo, 
					"@ProductName",  _GsCustomerOder.ProductName, 
					"@ProductDescription",  _GsCustomerOder.ProductDescription, 
					"@Quantity",  _GsCustomerOder.Quantity, 
					"@DeliveryCondition",  _GsCustomerOder.DeliveryCondition, 
					"@Id", _GsCustomerOder.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsCustomerOder vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsCustomerOder> _GsCustomerOders)
		{
			foreach (GsCustomerOder item in _GsCustomerOders)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsCustomerOder vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsCustomerOder _GsCustomerOder, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCustomerOder] SET Id=@Id, AccountObjecID=@AccountObjecID, CreateDate=@CreateDate, FK_Department=@FK_Department, FK_ACEmployee=@FK_ACEmployee, FK_CustomerSource=@FK_CustomerSource, FK_DataChanel=@FK_DataChanel, CustomerName=@CustomerName, CustomerCode=@CustomerCode, CustomerAdd=@CustomerAdd, FK_Contry=@FK_Contry, FK_CompanyType=@FK_CompanyType, Website=@Website, Phone=@Phone, ContactName=@ContactName, ContactPosition=@ContactPosition, ContactMobile=@ContactMobile, MessengerChat=@MessengerChat, ImportFrom=@ImportFrom, ExportTo=@ExportTo, ProductName=@ProductName, ProductDescription=@ProductDescription, Quantity=@Quantity, DeliveryCondition=@DeliveryCondition "+ condition, 
					"@Id",  _GsCustomerOder.Id, 
					"@AccountObjecID",  _GsCustomerOder.AccountObjecID, 
					"@CreateDate", this._dataContext.ConvertDateString( _GsCustomerOder.CreateDate), 
					"@FK_Department",  _GsCustomerOder.FK_Department, 
					"@FK_ACEmployee",  _GsCustomerOder.FK_ACEmployee, 
					"@FK_CustomerSource",  _GsCustomerOder.FK_CustomerSource, 
					"@FK_DataChanel",  _GsCustomerOder.FK_DataChanel, 
					"@CustomerName",  _GsCustomerOder.CustomerName, 
					"@CustomerCode",  _GsCustomerOder.CustomerCode, 
					"@CustomerAdd",  _GsCustomerOder.CustomerAdd, 
					"@FK_Contry",  _GsCustomerOder.FK_Contry, 
					"@FK_CompanyType",  _GsCustomerOder.FK_CompanyType, 
					"@Website",  _GsCustomerOder.Website, 
					"@Phone",  _GsCustomerOder.Phone, 
					"@ContactName",  _GsCustomerOder.ContactName, 
					"@ContactPosition",  _GsCustomerOder.ContactPosition, 
					"@ContactMobile",  _GsCustomerOder.ContactMobile, 
					"@MessengerChat",  _GsCustomerOder.MessengerChat, 
					"@ImportFrom",  _GsCustomerOder.ImportFrom, 
					"@ExportTo",  _GsCustomerOder.ExportTo, 
					"@ProductName",  _GsCustomerOder.ProductName, 
					"@ProductDescription",  _GsCustomerOder.ProductDescription, 
					"@Quantity",  _GsCustomerOder.Quantity, 
					"@DeliveryCondition",  _GsCustomerOder.DeliveryCondition);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsCustomerOder trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCustomerOder] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCustomerOder trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsCustomerOder _GsCustomerOder)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCustomerOder] WHERE Id=@Id",
					"@Id", _GsCustomerOder.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCustomerOder trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCustomerOder] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCustomerOder trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsCustomerOder> _GsCustomerOders)
		{
			foreach (GsCustomerOder item in _GsCustomerOders)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
