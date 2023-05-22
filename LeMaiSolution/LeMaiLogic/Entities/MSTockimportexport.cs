using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSTockimportexport:ISTockimportexport
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSTockimportexport(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable StockImportExport từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[StockImportExport]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable StockImportExport từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[StockImportExport] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách StockImportExport từ Database
		/// </summary>
		public List<StockImportExport> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[StockImportExport]");
				List<StockImportExport> items = new List<StockImportExport>();
				StockImportExport item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new StockImportExport();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["IsImport"] != null && dr["IsImport"] != DBNull.Value)
					{
						item.IsImport = Convert.ToBoolean(dr["IsImport"]);
					}
					if (dr["FK_ProviderOrCustomer"] != null && dr["FK_ProviderOrCustomer"] != DBNull.Value)
					{
						item.FK_ProviderOrCustomer = Convert.ToString(dr["FK_ProviderOrCustomer"]);
					}
					if (dr["FK_Stock"] != null && dr["FK_Stock"] != DBNull.Value)
					{
						item.FK_Stock = Convert.ToString(dr["FK_Stock"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CreateUser"] != null && dr["FK_CreateUser"] != DBNull.Value)
					{
						item.FK_CreateUser = Convert.ToString(dr["FK_CreateUser"]);
					}
					if (dr["TotalAmountWithOutTax"] != null && dr["TotalAmountWithOutTax"] != DBNull.Value)
					{
						item.TotalAmountWithOutTax = Convert.ToDecimal(dr["TotalAmountWithOutTax"]);
					}
					if (dr["TotalAmountTax"] != null && dr["TotalAmountTax"] != DBNull.Value)
					{
						item.TotalAmountTax = Convert.ToDecimal(dr["TotalAmountTax"]);
					}
					if (dr["TotalTaxAmount"] != null && dr["TotalTaxAmount"] != DBNull.Value)
					{
						item.TotalTaxAmount = Convert.ToDecimal(dr["TotalTaxAmount"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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
		/// Lấy danh sách StockImportExport từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<StockImportExport> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[StockImportExport] A "+ condition,  parameters);
				List<StockImportExport> items = new List<StockImportExport>();
				StockImportExport item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new StockImportExport();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["IsImport"] != null && dr["IsImport"] != DBNull.Value)
					{
						item.IsImport = Convert.ToBoolean(dr["IsImport"]);
					}
					if (dr["FK_ProviderOrCustomer"] != null && dr["FK_ProviderOrCustomer"] != DBNull.Value)
					{
						item.FK_ProviderOrCustomer = Convert.ToString(dr["FK_ProviderOrCustomer"]);
					}
					if (dr["FK_Stock"] != null && dr["FK_Stock"] != DBNull.Value)
					{
						item.FK_Stock = Convert.ToString(dr["FK_Stock"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CreateUser"] != null && dr["FK_CreateUser"] != DBNull.Value)
					{
						item.FK_CreateUser = Convert.ToString(dr["FK_CreateUser"]);
					}
					if (dr["TotalAmountWithOutTax"] != null && dr["TotalAmountWithOutTax"] != DBNull.Value)
					{
						item.TotalAmountWithOutTax = Convert.ToDecimal(dr["TotalAmountWithOutTax"]);
					}
					if (dr["TotalAmountTax"] != null && dr["TotalAmountTax"] != DBNull.Value)
					{
						item.TotalAmountTax = Convert.ToDecimal(dr["TotalAmountTax"]);
					}
					if (dr["TotalTaxAmount"] != null && dr["TotalTaxAmount"] != DBNull.Value)
					{
						item.TotalTaxAmount = Convert.ToDecimal(dr["TotalTaxAmount"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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

		public List<StockImportExport> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[StockImportExport] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[StockImportExport] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<StockImportExport>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một StockImportExport từ Database
		/// </summary>
		public StockImportExport GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[StockImportExport] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					StockImportExport item=new StockImportExport();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["IsImport"] != null && dr["IsImport"] != DBNull.Value)
						{
							item.IsImport = Convert.ToBoolean(dr["IsImport"]);
						}
						if (dr["FK_ProviderOrCustomer"] != null && dr["FK_ProviderOrCustomer"] != DBNull.Value)
						{
							item.FK_ProviderOrCustomer = Convert.ToString(dr["FK_ProviderOrCustomer"]);
						}
						if (dr["FK_Stock"] != null && dr["FK_Stock"] != DBNull.Value)
						{
							item.FK_Stock = Convert.ToString(dr["FK_Stock"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CreateUser"] != null && dr["FK_CreateUser"] != DBNull.Value)
						{
							item.FK_CreateUser = Convert.ToString(dr["FK_CreateUser"]);
						}
						if (dr["TotalAmountWithOutTax"] != null && dr["TotalAmountWithOutTax"] != DBNull.Value)
						{
							item.TotalAmountWithOutTax = Convert.ToDecimal(dr["TotalAmountWithOutTax"]);
						}
						if (dr["TotalAmountTax"] != null && dr["TotalAmountTax"] != DBNull.Value)
						{
							item.TotalAmountTax = Convert.ToDecimal(dr["TotalAmountTax"]);
						}
						if (dr["TotalTaxAmount"] != null && dr["TotalTaxAmount"] != DBNull.Value)
						{
							item.TotalTaxAmount = Convert.ToDecimal(dr["TotalTaxAmount"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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
		/// Lấy một StockImportExport đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public StockImportExport GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[StockImportExport] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					StockImportExport item=new StockImportExport();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["IsImport"] != null && dr["IsImport"] != DBNull.Value)
						{
							item.IsImport = Convert.ToBoolean(dr["IsImport"]);
						}
						if (dr["FK_ProviderOrCustomer"] != null && dr["FK_ProviderOrCustomer"] != DBNull.Value)
						{
							item.FK_ProviderOrCustomer = Convert.ToString(dr["FK_ProviderOrCustomer"]);
						}
						if (dr["FK_Stock"] != null && dr["FK_Stock"] != DBNull.Value)
						{
							item.FK_Stock = Convert.ToString(dr["FK_Stock"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CreateUser"] != null && dr["FK_CreateUser"] != DBNull.Value)
						{
							item.FK_CreateUser = Convert.ToString(dr["FK_CreateUser"]);
						}
						if (dr["TotalAmountWithOutTax"] != null && dr["TotalAmountWithOutTax"] != DBNull.Value)
						{
							item.TotalAmountWithOutTax = Convert.ToDecimal(dr["TotalAmountWithOutTax"]);
						}
						if (dr["TotalAmountTax"] != null && dr["TotalAmountTax"] != DBNull.Value)
						{
							item.TotalAmountTax = Convert.ToDecimal(dr["TotalAmountTax"]);
						}
						if (dr["TotalTaxAmount"] != null && dr["TotalTaxAmount"] != DBNull.Value)
						{
							item.TotalTaxAmount = Convert.ToDecimal(dr["TotalTaxAmount"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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

		public StockImportExport GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[StockImportExport] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<StockImportExport>(ds);
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
		/// Thêm mới StockImportExport vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, StockImportExport _StockImportExport)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[StockImportExport](Id, IsImport, FK_ProviderOrCustomer, FK_Stock, Code, CreateDate, FK_CreateUser, TotalAmountWithOutTax, TotalAmountTax, TotalTaxAmount, Note, IsDelete) VALUES(@Id, @IsImport, @FK_ProviderOrCustomer, @FK_Stock, @Code, @CreateDate, @FK_CreateUser, @TotalAmountWithOutTax, @TotalAmountTax, @TotalTaxAmount, @Note, @IsDelete)", 
					"@Id",  _StockImportExport.Id, 
					"@IsImport",  _StockImportExport.IsImport, 
					"@FK_ProviderOrCustomer",  _StockImportExport.FK_ProviderOrCustomer, 
					"@FK_Stock",  _StockImportExport.FK_Stock, 
					"@Code",  _StockImportExport.Code, 
					"@CreateDate", this._dataContext.ConvertDateString( _StockImportExport.CreateDate), 
					"@FK_CreateUser",  _StockImportExport.FK_CreateUser, 
					"@TotalAmountWithOutTax",  _StockImportExport.TotalAmountWithOutTax, 
					"@TotalAmountTax",  _StockImportExport.TotalAmountTax, 
					"@TotalTaxAmount",  _StockImportExport.TotalTaxAmount, 
					"@Note",  _StockImportExport.Note, 
					"@IsDelete",  _StockImportExport.IsDelete);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng StockImportExport vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<StockImportExport> _StockImportExports)
		{
			foreach (StockImportExport item in _StockImportExports)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật StockImportExport vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, StockImportExport _StockImportExport, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[StockImportExport] SET Id=@Id, IsImport=@IsImport, FK_ProviderOrCustomer=@FK_ProviderOrCustomer, FK_Stock=@FK_Stock, Code=@Code, CreateDate=@CreateDate, FK_CreateUser=@FK_CreateUser, TotalAmountWithOutTax=@TotalAmountWithOutTax, TotalAmountTax=@TotalAmountTax, TotalTaxAmount=@TotalTaxAmount, Note=@Note, IsDelete=@IsDelete WHERE Id=@Id", 
					"@Id",  _StockImportExport.Id, 
					"@IsImport",  _StockImportExport.IsImport, 
					"@FK_ProviderOrCustomer",  _StockImportExport.FK_ProviderOrCustomer, 
					"@FK_Stock",  _StockImportExport.FK_Stock, 
					"@Code",  _StockImportExport.Code, 
					"@CreateDate", this._dataContext.ConvertDateString( _StockImportExport.CreateDate), 
					"@FK_CreateUser",  _StockImportExport.FK_CreateUser, 
					"@TotalAmountWithOutTax",  _StockImportExport.TotalAmountWithOutTax, 
					"@TotalAmountTax",  _StockImportExport.TotalAmountTax, 
					"@TotalTaxAmount",  _StockImportExport.TotalTaxAmount, 
					"@Note",  _StockImportExport.Note, 
					"@IsDelete",  _StockImportExport.IsDelete, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật StockImportExport vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, StockImportExport _StockImportExport)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[StockImportExport] SET IsImport=@IsImport, FK_ProviderOrCustomer=@FK_ProviderOrCustomer, FK_Stock=@FK_Stock, Code=@Code, CreateDate=@CreateDate, FK_CreateUser=@FK_CreateUser, TotalAmountWithOutTax=@TotalAmountWithOutTax, TotalAmountTax=@TotalAmountTax, TotalTaxAmount=@TotalTaxAmount, Note=@Note, IsDelete=@IsDelete WHERE Id=@Id", 
					"@IsImport",  _StockImportExport.IsImport, 
					"@FK_ProviderOrCustomer",  _StockImportExport.FK_ProviderOrCustomer, 
					"@FK_Stock",  _StockImportExport.FK_Stock, 
					"@Code",  _StockImportExport.Code, 
					"@CreateDate", this._dataContext.ConvertDateString( _StockImportExport.CreateDate), 
					"@FK_CreateUser",  _StockImportExport.FK_CreateUser, 
					"@TotalAmountWithOutTax",  _StockImportExport.TotalAmountWithOutTax, 
					"@TotalAmountTax",  _StockImportExport.TotalAmountTax, 
					"@TotalTaxAmount",  _StockImportExport.TotalTaxAmount, 
					"@Note",  _StockImportExport.Note, 
					"@IsDelete",  _StockImportExport.IsDelete, 
					"@Id", _StockImportExport.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách StockImportExport vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<StockImportExport> _StockImportExports)
		{
			foreach (StockImportExport item in _StockImportExports)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật StockImportExport vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, StockImportExport _StockImportExport, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[StockImportExport] SET Id=@Id, IsImport=@IsImport, FK_ProviderOrCustomer=@FK_ProviderOrCustomer, FK_Stock=@FK_Stock, Code=@Code, CreateDate=@CreateDate, FK_CreateUser=@FK_CreateUser, TotalAmountWithOutTax=@TotalAmountWithOutTax, TotalAmountTax=@TotalAmountTax, TotalTaxAmount=@TotalTaxAmount, Note=@Note, IsDelete=@IsDelete "+ condition, 
					"@Id",  _StockImportExport.Id, 
					"@IsImport",  _StockImportExport.IsImport, 
					"@FK_ProviderOrCustomer",  _StockImportExport.FK_ProviderOrCustomer, 
					"@FK_Stock",  _StockImportExport.FK_Stock, 
					"@Code",  _StockImportExport.Code, 
					"@CreateDate", this._dataContext.ConvertDateString( _StockImportExport.CreateDate), 
					"@FK_CreateUser",  _StockImportExport.FK_CreateUser, 
					"@TotalAmountWithOutTax",  _StockImportExport.TotalAmountWithOutTax, 
					"@TotalAmountTax",  _StockImportExport.TotalAmountTax, 
					"@TotalTaxAmount",  _StockImportExport.TotalTaxAmount, 
					"@Note",  _StockImportExport.Note, 
					"@IsDelete",  _StockImportExport.IsDelete);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa StockImportExport trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[StockImportExport] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa StockImportExport trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, StockImportExport _StockImportExport)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[StockImportExport] WHERE Id=@Id",
					"@Id", _StockImportExport.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa StockImportExport trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[StockImportExport] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa StockImportExport trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<StockImportExport> _StockImportExports)
		{
			foreach (StockImportExport item in _StockImportExports)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
