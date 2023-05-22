using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSbank:IGSbank
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSbank(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsBank từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsBank]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsBank từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsBank] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsBank từ Database
		/// </summary>
		public List<GsBank> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsBank]");
				List<GsBank> items = new List<GsBank>();
				GsBank item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsBank();
					if (dr["BankID"] != null && dr["BankID"] != DBNull.Value)
					{
						item.BankID = Convert.ToString(dr["BankID"]);
					}
					if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
					{
						item.BankCode = Convert.ToString(dr["BankCode"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["BankNameEnglish"] != null && dr["BankNameEnglish"] != DBNull.Value)
					{
						item.BankNameEnglish = Convert.ToString(dr["BankNameEnglish"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["CreatedBy"] != null && dr["CreatedBy"] != DBNull.Value)
					{
						item.CreatedBy = Convert.ToString(dr["CreatedBy"]);
					}
					if (dr["CreatedDate"] != null && dr["CreatedDate"] != DBNull.Value)
					{
						item.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
					}
					if (dr["ModifiedBy"] != null && dr["ModifiedBy"] != DBNull.Value)
					{
						item.ModifiedBy = Convert.ToString(dr["ModifiedBy"]);
					}
					if (dr["ModifiedDate"] != null && dr["ModifiedDate"] != DBNull.Value)
					{
						item.ModifiedDate = Convert.ToDateTime(dr["ModifiedDate"]);
					}
					if (dr["EBankCode"] != null && dr["EBankCode"] != DBNull.Value)
					{
						item.EBankCode = Convert.ToString(dr["EBankCode"]);
					}
					if (dr["SwiftCode"] != null && dr["SwiftCode"] != DBNull.Value)
					{
						item.SwiftCode = Convert.ToString(dr["SwiftCode"]);
					}
					if (dr["Fk_Region"] != null && dr["Fk_Region"] != DBNull.Value)
					{
						item.Fk_Region = Convert.ToString(dr["Fk_Region"]);
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
		/// Lấy danh sách GsBank từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsBank> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsBank] A "+ condition,  parameters);
				List<GsBank> items = new List<GsBank>();
				GsBank item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsBank();
					if (dr["BankID"] != null && dr["BankID"] != DBNull.Value)
					{
						item.BankID = Convert.ToString(dr["BankID"]);
					}
					if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
					{
						item.BankCode = Convert.ToString(dr["BankCode"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["BankNameEnglish"] != null && dr["BankNameEnglish"] != DBNull.Value)
					{
						item.BankNameEnglish = Convert.ToString(dr["BankNameEnglish"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["CreatedBy"] != null && dr["CreatedBy"] != DBNull.Value)
					{
						item.CreatedBy = Convert.ToString(dr["CreatedBy"]);
					}
					if (dr["CreatedDate"] != null && dr["CreatedDate"] != DBNull.Value)
					{
						item.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
					}
					if (dr["ModifiedBy"] != null && dr["ModifiedBy"] != DBNull.Value)
					{
						item.ModifiedBy = Convert.ToString(dr["ModifiedBy"]);
					}
					if (dr["ModifiedDate"] != null && dr["ModifiedDate"] != DBNull.Value)
					{
						item.ModifiedDate = Convert.ToDateTime(dr["ModifiedDate"]);
					}
					if (dr["EBankCode"] != null && dr["EBankCode"] != DBNull.Value)
					{
						item.EBankCode = Convert.ToString(dr["EBankCode"]);
					}
					if (dr["SwiftCode"] != null && dr["SwiftCode"] != DBNull.Value)
					{
						item.SwiftCode = Convert.ToString(dr["SwiftCode"]);
					}
					if (dr["Fk_Region"] != null && dr["Fk_Region"] != DBNull.Value)
					{
						item.Fk_Region = Convert.ToString(dr["Fk_Region"]);
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

		public List<GsBank> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsBank] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsBank] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsBank>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsBank từ Database
		/// </summary>
		public GsBank GetObject(string schema, String BankID)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsBank] where BankID=@BankID",
					"@BankID", BankID);
				if (ds.Rows.Count > 0)
				{
					GsBank item=new GsBank();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BankID"] != null && dr["BankID"] != DBNull.Value)
						{
							item.BankID = Convert.ToString(dr["BankID"]);
						}
						if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
						{
							item.BankCode = Convert.ToString(dr["BankCode"]);
						}
						if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
						{
							item.BankName = Convert.ToString(dr["BankName"]);
						}
						if (dr["BankNameEnglish"] != null && dr["BankNameEnglish"] != DBNull.Value)
						{
							item.BankNameEnglish = Convert.ToString(dr["BankNameEnglish"]);
						}
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["CreatedBy"] != null && dr["CreatedBy"] != DBNull.Value)
						{
							item.CreatedBy = Convert.ToString(dr["CreatedBy"]);
						}
						if (dr["CreatedDate"] != null && dr["CreatedDate"] != DBNull.Value)
						{
							item.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
						}
						if (dr["ModifiedBy"] != null && dr["ModifiedBy"] != DBNull.Value)
						{
							item.ModifiedBy = Convert.ToString(dr["ModifiedBy"]);
						}
						if (dr["ModifiedDate"] != null && dr["ModifiedDate"] != DBNull.Value)
						{
							item.ModifiedDate = Convert.ToDateTime(dr["ModifiedDate"]);
						}
						if (dr["EBankCode"] != null && dr["EBankCode"] != DBNull.Value)
						{
							item.EBankCode = Convert.ToString(dr["EBankCode"]);
						}
						if (dr["SwiftCode"] != null && dr["SwiftCode"] != DBNull.Value)
						{
							item.SwiftCode = Convert.ToString(dr["SwiftCode"]);
						}
						if (dr["Fk_Region"] != null && dr["Fk_Region"] != DBNull.Value)
						{
							item.Fk_Region = Convert.ToString(dr["Fk_Region"]);
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
		/// Lấy một GsBank đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsBank GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsBank] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsBank item=new GsBank();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BankID"] != null && dr["BankID"] != DBNull.Value)
						{
							item.BankID = Convert.ToString(dr["BankID"]);
						}
						if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
						{
							item.BankCode = Convert.ToString(dr["BankCode"]);
						}
						if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
						{
							item.BankName = Convert.ToString(dr["BankName"]);
						}
						if (dr["BankNameEnglish"] != null && dr["BankNameEnglish"] != DBNull.Value)
						{
							item.BankNameEnglish = Convert.ToString(dr["BankNameEnglish"]);
						}
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["CreatedBy"] != null && dr["CreatedBy"] != DBNull.Value)
						{
							item.CreatedBy = Convert.ToString(dr["CreatedBy"]);
						}
						if (dr["CreatedDate"] != null && dr["CreatedDate"] != DBNull.Value)
						{
							item.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
						}
						if (dr["ModifiedBy"] != null && dr["ModifiedBy"] != DBNull.Value)
						{
							item.ModifiedBy = Convert.ToString(dr["ModifiedBy"]);
						}
						if (dr["ModifiedDate"] != null && dr["ModifiedDate"] != DBNull.Value)
						{
							item.ModifiedDate = Convert.ToDateTime(dr["ModifiedDate"]);
						}
						if (dr["EBankCode"] != null && dr["EBankCode"] != DBNull.Value)
						{
							item.EBankCode = Convert.ToString(dr["EBankCode"]);
						}
						if (dr["SwiftCode"] != null && dr["SwiftCode"] != DBNull.Value)
						{
							item.SwiftCode = Convert.ToString(dr["SwiftCode"]);
						}
						if (dr["Fk_Region"] != null && dr["Fk_Region"] != DBNull.Value)
						{
							item.Fk_Region = Convert.ToString(dr["Fk_Region"]);
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

		public GsBank GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsBank] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsBank>(ds);
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
		/// Thêm mới GsBank vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsBank _GsBank)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsBank](BankID, BankCode, BankName, BankNameEnglish, Address, Description, IsDelete, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, EBankCode, SwiftCode, Fk_Region) VALUES(@BankID, @BankCode, @BankName, @BankNameEnglish, @Address, @Description, @IsDelete, @CreatedBy, @CreatedDate, @ModifiedBy, @ModifiedDate, @EBankCode, @SwiftCode, @Fk_Region)", 
					"@BankID",  _GsBank.BankID, 
					"@BankCode",  _GsBank.BankCode, 
					"@BankName",  _GsBank.BankName, 
					"@BankNameEnglish",  _GsBank.BankNameEnglish, 
					"@Address",  _GsBank.Address, 
					"@Description",  _GsBank.Description, 
					"@IsDelete",  _GsBank.IsDelete, 
					"@CreatedBy",  _GsBank.CreatedBy, 
					"@CreatedDate", this._dataContext.ConvertDateString( _GsBank.CreatedDate), 
					"@ModifiedBy",  _GsBank.ModifiedBy, 
					"@ModifiedDate", this._dataContext.ConvertDateString( _GsBank.ModifiedDate), 
					"@EBankCode",  _GsBank.EBankCode, 
					"@SwiftCode",  _GsBank.SwiftCode, 
					"@Fk_Region",  _GsBank.Fk_Region);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsBank vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsBank> _GsBanks)
		{
			foreach (GsBank item in _GsBanks)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsBank vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsBank _GsBank, String BankID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsBank] SET BankID=@BankID, BankCode=@BankCode, BankName=@BankName, BankNameEnglish=@BankNameEnglish, Address=@Address, Description=@Description, IsDelete=@IsDelete, CreatedBy=@CreatedBy, CreatedDate=@CreatedDate, ModifiedBy=@ModifiedBy, ModifiedDate=@ModifiedDate, EBankCode=@EBankCode, SwiftCode=@SwiftCode, Fk_Region=@Fk_Region WHERE BankID=@BankID", 
					"@BankID",  _GsBank.BankID, 
					"@BankCode",  _GsBank.BankCode, 
					"@BankName",  _GsBank.BankName, 
					"@BankNameEnglish",  _GsBank.BankNameEnglish, 
					"@Address",  _GsBank.Address, 
					"@Description",  _GsBank.Description, 
					"@IsDelete",  _GsBank.IsDelete, 
					"@CreatedBy",  _GsBank.CreatedBy, 
					"@CreatedDate", this._dataContext.ConvertDateString( _GsBank.CreatedDate), 
					"@ModifiedBy",  _GsBank.ModifiedBy, 
					"@ModifiedDate", this._dataContext.ConvertDateString( _GsBank.ModifiedDate), 
					"@EBankCode",  _GsBank.EBankCode, 
					"@SwiftCode",  _GsBank.SwiftCode, 
					"@Fk_Region",  _GsBank.Fk_Region, 
					"@BankID", BankID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsBank vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsBank _GsBank)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsBank] SET BankCode=@BankCode, BankName=@BankName, BankNameEnglish=@BankNameEnglish, Address=@Address, Description=@Description, IsDelete=@IsDelete, CreatedBy=@CreatedBy, CreatedDate=@CreatedDate, ModifiedBy=@ModifiedBy, ModifiedDate=@ModifiedDate, EBankCode=@EBankCode, SwiftCode=@SwiftCode, Fk_Region=@Fk_Region WHERE BankID=@BankID", 
					"@BankCode",  _GsBank.BankCode, 
					"@BankName",  _GsBank.BankName, 
					"@BankNameEnglish",  _GsBank.BankNameEnglish, 
					"@Address",  _GsBank.Address, 
					"@Description",  _GsBank.Description, 
					"@IsDelete",  _GsBank.IsDelete, 
					"@CreatedBy",  _GsBank.CreatedBy, 
					"@CreatedDate", this._dataContext.ConvertDateString( _GsBank.CreatedDate), 
					"@ModifiedBy",  _GsBank.ModifiedBy, 
					"@ModifiedDate", this._dataContext.ConvertDateString( _GsBank.ModifiedDate), 
					"@EBankCode",  _GsBank.EBankCode, 
					"@SwiftCode",  _GsBank.SwiftCode, 
					"@Fk_Region",  _GsBank.Fk_Region, 
					"@BankID", _GsBank.BankID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsBank vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsBank> _GsBanks)
		{
			foreach (GsBank item in _GsBanks)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsBank vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsBank _GsBank, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsBank] SET BankID=@BankID, BankCode=@BankCode, BankName=@BankName, BankNameEnglish=@BankNameEnglish, Address=@Address, Description=@Description, IsDelete=@IsDelete, CreatedBy=@CreatedBy, CreatedDate=@CreatedDate, ModifiedBy=@ModifiedBy, ModifiedDate=@ModifiedDate, EBankCode=@EBankCode, SwiftCode=@SwiftCode, Fk_Region=@Fk_Region "+ condition, 
					"@BankID",  _GsBank.BankID, 
					"@BankCode",  _GsBank.BankCode, 
					"@BankName",  _GsBank.BankName, 
					"@BankNameEnglish",  _GsBank.BankNameEnglish, 
					"@Address",  _GsBank.Address, 
					"@Description",  _GsBank.Description, 
					"@IsDelete",  _GsBank.IsDelete, 
					"@CreatedBy",  _GsBank.CreatedBy, 
					"@CreatedDate", this._dataContext.ConvertDateString( _GsBank.CreatedDate), 
					"@ModifiedBy",  _GsBank.ModifiedBy, 
					"@ModifiedDate", this._dataContext.ConvertDateString( _GsBank.ModifiedDate), 
					"@EBankCode",  _GsBank.EBankCode, 
					"@SwiftCode",  _GsBank.SwiftCode, 
					"@Fk_Region",  _GsBank.Fk_Region);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsBank trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BankID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsBank] WHERE BankID=@BankID",
					"@BankID", BankID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsBank trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsBank _GsBank)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsBank] WHERE BankID=@BankID",
					"@BankID", _GsBank.BankID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsBank trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsBank] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsBank trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsBank> _GsBanks)
		{
			foreach (GsBank item in _GsBanks)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
