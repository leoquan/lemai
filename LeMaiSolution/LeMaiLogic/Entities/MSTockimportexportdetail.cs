using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSTockimportexportdetail:ISTockimportexportdetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSTockimportexportdetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable StockImportExportDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[StockImportExportDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable StockImportExportDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[StockImportExportDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách StockImportExportDetail từ Database
		/// </summary>
		public List<StockImportExportDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[StockImportExportDetail]");
				List<StockImportExportDetail> items = new List<StockImportExportDetail>();
				StockImportExportDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new StockImportExportDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["FK_StockImporOrExporttId"] != null && dr["FK_StockImporOrExporttId"] != DBNull.Value)
					{
						item.FK_StockImporOrExporttId = Convert.ToString(dr["FK_StockImporOrExporttId"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToDecimal(dr["Quantity"]);
					}
					if (dr["TotalAmountWithOutTax"] != null && dr["TotalAmountWithOutTax"] != DBNull.Value)
					{
						item.TotalAmountWithOutTax = Convert.ToDecimal(dr["TotalAmountWithOutTax"]);
					}
					if (dr["TotalDiscount"] != null && dr["TotalDiscount"] != DBNull.Value)
					{
						item.TotalDiscount = Convert.ToDecimal(dr["TotalDiscount"]);
					}
					if (dr["TaxAmount"] != null && dr["TaxAmount"] != DBNull.Value)
					{
						item.TaxAmount = Convert.ToDecimal(dr["TaxAmount"]);
					}
					if (dr["Lot"] != null && dr["Lot"] != DBNull.Value)
					{
						item.Lot = Convert.ToString(dr["Lot"]);
					}
					if (dr["ExpirationDate"] != null && dr["ExpirationDate"] != DBNull.Value)
					{
						item.ExpirationDate = Convert.ToDateTime(dr["ExpirationDate"]);
					}
					if (dr["FK_Inventory"] != null && dr["FK_Inventory"] != DBNull.Value)
					{
						item.FK_Inventory = Convert.ToString(dr["FK_Inventory"]);
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
		/// Lấy danh sách StockImportExportDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<StockImportExportDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[StockImportExportDetail] A "+ condition,  parameters);
				List<StockImportExportDetail> items = new List<StockImportExportDetail>();
				StockImportExportDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new StockImportExportDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["FK_StockImporOrExporttId"] != null && dr["FK_StockImporOrExporttId"] != DBNull.Value)
					{
						item.FK_StockImporOrExporttId = Convert.ToString(dr["FK_StockImporOrExporttId"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToDecimal(dr["Quantity"]);
					}
					if (dr["TotalAmountWithOutTax"] != null && dr["TotalAmountWithOutTax"] != DBNull.Value)
					{
						item.TotalAmountWithOutTax = Convert.ToDecimal(dr["TotalAmountWithOutTax"]);
					}
					if (dr["TotalDiscount"] != null && dr["TotalDiscount"] != DBNull.Value)
					{
						item.TotalDiscount = Convert.ToDecimal(dr["TotalDiscount"]);
					}
					if (dr["TaxAmount"] != null && dr["TaxAmount"] != DBNull.Value)
					{
						item.TaxAmount = Convert.ToDecimal(dr["TaxAmount"]);
					}
					if (dr["Lot"] != null && dr["Lot"] != DBNull.Value)
					{
						item.Lot = Convert.ToString(dr["Lot"]);
					}
					if (dr["ExpirationDate"] != null && dr["ExpirationDate"] != DBNull.Value)
					{
						item.ExpirationDate = Convert.ToDateTime(dr["ExpirationDate"]);
					}
					if (dr["FK_Inventory"] != null && dr["FK_Inventory"] != DBNull.Value)
					{
						item.FK_Inventory = Convert.ToString(dr["FK_Inventory"]);
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

		public List<StockImportExportDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[StockImportExportDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[StockImportExportDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<StockImportExportDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một StockImportExportDetail từ Database
		/// </summary>
		public StockImportExportDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[StockImportExportDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					StockImportExportDetail item=new StockImportExportDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["FK_StockImporOrExporttId"] != null && dr["FK_StockImporOrExporttId"] != DBNull.Value)
						{
							item.FK_StockImporOrExporttId = Convert.ToString(dr["FK_StockImporOrExporttId"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
						{
							item.Quantity = Convert.ToDecimal(dr["Quantity"]);
						}
						if (dr["TotalAmountWithOutTax"] != null && dr["TotalAmountWithOutTax"] != DBNull.Value)
						{
							item.TotalAmountWithOutTax = Convert.ToDecimal(dr["TotalAmountWithOutTax"]);
						}
						if (dr["TotalDiscount"] != null && dr["TotalDiscount"] != DBNull.Value)
						{
							item.TotalDiscount = Convert.ToDecimal(dr["TotalDiscount"]);
						}
						if (dr["TaxAmount"] != null && dr["TaxAmount"] != DBNull.Value)
						{
							item.TaxAmount = Convert.ToDecimal(dr["TaxAmount"]);
						}
						if (dr["Lot"] != null && dr["Lot"] != DBNull.Value)
						{
							item.Lot = Convert.ToString(dr["Lot"]);
						}
						if (dr["ExpirationDate"] != null && dr["ExpirationDate"] != DBNull.Value)
						{
							item.ExpirationDate = Convert.ToDateTime(dr["ExpirationDate"]);
						}
						if (dr["FK_Inventory"] != null && dr["FK_Inventory"] != DBNull.Value)
						{
							item.FK_Inventory = Convert.ToString(dr["FK_Inventory"]);
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
		/// Lấy một StockImportExportDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public StockImportExportDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[StockImportExportDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					StockImportExportDetail item=new StockImportExportDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["FK_StockImporOrExporttId"] != null && dr["FK_StockImporOrExporttId"] != DBNull.Value)
						{
							item.FK_StockImporOrExporttId = Convert.ToString(dr["FK_StockImporOrExporttId"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
						{
							item.Quantity = Convert.ToDecimal(dr["Quantity"]);
						}
						if (dr["TotalAmountWithOutTax"] != null && dr["TotalAmountWithOutTax"] != DBNull.Value)
						{
							item.TotalAmountWithOutTax = Convert.ToDecimal(dr["TotalAmountWithOutTax"]);
						}
						if (dr["TotalDiscount"] != null && dr["TotalDiscount"] != DBNull.Value)
						{
							item.TotalDiscount = Convert.ToDecimal(dr["TotalDiscount"]);
						}
						if (dr["TaxAmount"] != null && dr["TaxAmount"] != DBNull.Value)
						{
							item.TaxAmount = Convert.ToDecimal(dr["TaxAmount"]);
						}
						if (dr["Lot"] != null && dr["Lot"] != DBNull.Value)
						{
							item.Lot = Convert.ToString(dr["Lot"]);
						}
						if (dr["ExpirationDate"] != null && dr["ExpirationDate"] != DBNull.Value)
						{
							item.ExpirationDate = Convert.ToDateTime(dr["ExpirationDate"]);
						}
						if (dr["FK_Inventory"] != null && dr["FK_Inventory"] != DBNull.Value)
						{
							item.FK_Inventory = Convert.ToString(dr["FK_Inventory"]);
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

		public StockImportExportDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[StockImportExportDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<StockImportExportDetail>(ds);
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
		/// Thêm mới StockImportExportDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, StockImportExportDetail _StockImportExportDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[StockImportExportDetail](Id, FK_Service, FK_StockImporOrExporttId, SortIndex, Quantity, TotalAmountWithOutTax, TotalDiscount, TaxAmount, Lot, ExpirationDate, FK_Inventory) VALUES(@Id, @FK_Service, @FK_StockImporOrExporttId, @SortIndex, @Quantity, @TotalAmountWithOutTax, @TotalDiscount, @TaxAmount, @Lot, @ExpirationDate, @FK_Inventory)", 
					"@Id",  _StockImportExportDetail.Id, 
					"@FK_Service",  _StockImportExportDetail.FK_Service, 
					"@FK_StockImporOrExporttId",  _StockImportExportDetail.FK_StockImporOrExporttId, 
					"@SortIndex",  _StockImportExportDetail.SortIndex, 
					"@Quantity",  _StockImportExportDetail.Quantity, 
					"@TotalAmountWithOutTax",  _StockImportExportDetail.TotalAmountWithOutTax, 
					"@TotalDiscount",  _StockImportExportDetail.TotalDiscount, 
					"@TaxAmount",  _StockImportExportDetail.TaxAmount, 
					"@Lot",  _StockImportExportDetail.Lot, 
					"@ExpirationDate", this._dataContext.ConvertDateString( _StockImportExportDetail.ExpirationDate), 
					"@FK_Inventory",  _StockImportExportDetail.FK_Inventory);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng StockImportExportDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<StockImportExportDetail> _StockImportExportDetails)
		{
			foreach (StockImportExportDetail item in _StockImportExportDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật StockImportExportDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, StockImportExportDetail _StockImportExportDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[StockImportExportDetail] SET Id=@Id, FK_Service=@FK_Service, FK_StockImporOrExporttId=@FK_StockImporOrExporttId, SortIndex=@SortIndex, Quantity=@Quantity, TotalAmountWithOutTax=@TotalAmountWithOutTax, TotalDiscount=@TotalDiscount, TaxAmount=@TaxAmount, Lot=@Lot, ExpirationDate=@ExpirationDate, FK_Inventory=@FK_Inventory WHERE Id=@Id", 
					"@Id",  _StockImportExportDetail.Id, 
					"@FK_Service",  _StockImportExportDetail.FK_Service, 
					"@FK_StockImporOrExporttId",  _StockImportExportDetail.FK_StockImporOrExporttId, 
					"@SortIndex",  _StockImportExportDetail.SortIndex, 
					"@Quantity",  _StockImportExportDetail.Quantity, 
					"@TotalAmountWithOutTax",  _StockImportExportDetail.TotalAmountWithOutTax, 
					"@TotalDiscount",  _StockImportExportDetail.TotalDiscount, 
					"@TaxAmount",  _StockImportExportDetail.TaxAmount, 
					"@Lot",  _StockImportExportDetail.Lot, 
					"@ExpirationDate", this._dataContext.ConvertDateString( _StockImportExportDetail.ExpirationDate), 
					"@FK_Inventory",  _StockImportExportDetail.FK_Inventory, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật StockImportExportDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, StockImportExportDetail _StockImportExportDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[StockImportExportDetail] SET FK_Service=@FK_Service, FK_StockImporOrExporttId=@FK_StockImporOrExporttId, SortIndex=@SortIndex, Quantity=@Quantity, TotalAmountWithOutTax=@TotalAmountWithOutTax, TotalDiscount=@TotalDiscount, TaxAmount=@TaxAmount, Lot=@Lot, ExpirationDate=@ExpirationDate, FK_Inventory=@FK_Inventory WHERE Id=@Id", 
					"@FK_Service",  _StockImportExportDetail.FK_Service, 
					"@FK_StockImporOrExporttId",  _StockImportExportDetail.FK_StockImporOrExporttId, 
					"@SortIndex",  _StockImportExportDetail.SortIndex, 
					"@Quantity",  _StockImportExportDetail.Quantity, 
					"@TotalAmountWithOutTax",  _StockImportExportDetail.TotalAmountWithOutTax, 
					"@TotalDiscount",  _StockImportExportDetail.TotalDiscount, 
					"@TaxAmount",  _StockImportExportDetail.TaxAmount, 
					"@Lot",  _StockImportExportDetail.Lot, 
					"@ExpirationDate", this._dataContext.ConvertDateString( _StockImportExportDetail.ExpirationDate), 
					"@FK_Inventory",  _StockImportExportDetail.FK_Inventory, 
					"@Id", _StockImportExportDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách StockImportExportDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<StockImportExportDetail> _StockImportExportDetails)
		{
			foreach (StockImportExportDetail item in _StockImportExportDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật StockImportExportDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, StockImportExportDetail _StockImportExportDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[StockImportExportDetail] SET Id=@Id, FK_Service=@FK_Service, FK_StockImporOrExporttId=@FK_StockImporOrExporttId, SortIndex=@SortIndex, Quantity=@Quantity, TotalAmountWithOutTax=@TotalAmountWithOutTax, TotalDiscount=@TotalDiscount, TaxAmount=@TaxAmount, Lot=@Lot, ExpirationDate=@ExpirationDate, FK_Inventory=@FK_Inventory "+ condition, 
					"@Id",  _StockImportExportDetail.Id, 
					"@FK_Service",  _StockImportExportDetail.FK_Service, 
					"@FK_StockImporOrExporttId",  _StockImportExportDetail.FK_StockImporOrExporttId, 
					"@SortIndex",  _StockImportExportDetail.SortIndex, 
					"@Quantity",  _StockImportExportDetail.Quantity, 
					"@TotalAmountWithOutTax",  _StockImportExportDetail.TotalAmountWithOutTax, 
					"@TotalDiscount",  _StockImportExportDetail.TotalDiscount, 
					"@TaxAmount",  _StockImportExportDetail.TaxAmount, 
					"@Lot",  _StockImportExportDetail.Lot, 
					"@ExpirationDate", this._dataContext.ConvertDateString( _StockImportExportDetail.ExpirationDate), 
					"@FK_Inventory",  _StockImportExportDetail.FK_Inventory);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa StockImportExportDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[StockImportExportDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa StockImportExportDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, StockImportExportDetail _StockImportExportDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[StockImportExportDetail] WHERE Id=@Id",
					"@Id", _StockImportExportDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa StockImportExportDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[StockImportExportDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa StockImportExportDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<StockImportExportDetail> _StockImportExportDetails)
		{
			foreach (StockImportExportDetail item in _StockImportExportDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
