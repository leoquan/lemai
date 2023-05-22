using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVOucher:IVOucher
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVOucher(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable Voucher từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Voucher]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable Voucher từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Voucher] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách Voucher từ Database
		/// </summary>
		public List<Voucher> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Voucher]");
				List<Voucher> items = new List<Voucher>();
				Voucher item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Voucher();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["ValidDate"] != null && dr["ValidDate"] != DBNull.Value)
					{
						item.ValidDate = Convert.ToDateTime(dr["ValidDate"]);
					}
					if (dr["ExperidDate"] != null && dr["ExperidDate"] != DBNull.Value)
					{
						item.ExperidDate = Convert.ToDateTime(dr["ExperidDate"]);
					}
					if (dr["IsUsed"] != null && dr["IsUsed"] != DBNull.Value)
					{
						item.IsUsed = Convert.ToBoolean(dr["IsUsed"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["IsPercentValue"] != null && dr["IsPercentValue"] != DBNull.Value)
					{
						item.IsPercentValue = Convert.ToBoolean(dr["IsPercentValue"]);
					}
					if (dr["IsOnlyService"] != null && dr["IsOnlyService"] != DBNull.Value)
					{
						item.IsOnlyService = Convert.ToBoolean(dr["IsOnlyService"]);
					}
					if (dr["Fk_ServiceOrGroup"] != null && dr["Fk_ServiceOrGroup"] != DBNull.Value)
					{
						item.Fk_ServiceOrGroup = Convert.ToString(dr["Fk_ServiceOrGroup"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["IsVoucher"] != null && dr["IsVoucher"] != DBNull.Value)
					{
						item.IsVoucher = Convert.ToBoolean(dr["IsVoucher"]);
					}
					if (dr["IsTotalBill"] != null && dr["IsTotalBill"] != DBNull.Value)
					{
						item.IsTotalBill = Convert.ToBoolean(dr["IsTotalBill"]);
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
		/// Lấy danh sách Voucher từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<Voucher> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Voucher] A "+ condition,  parameters);
				List<Voucher> items = new List<Voucher>();
				Voucher item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Voucher();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["ValidDate"] != null && dr["ValidDate"] != DBNull.Value)
					{
						item.ValidDate = Convert.ToDateTime(dr["ValidDate"]);
					}
					if (dr["ExperidDate"] != null && dr["ExperidDate"] != DBNull.Value)
					{
						item.ExperidDate = Convert.ToDateTime(dr["ExperidDate"]);
					}
					if (dr["IsUsed"] != null && dr["IsUsed"] != DBNull.Value)
					{
						item.IsUsed = Convert.ToBoolean(dr["IsUsed"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["IsPercentValue"] != null && dr["IsPercentValue"] != DBNull.Value)
					{
						item.IsPercentValue = Convert.ToBoolean(dr["IsPercentValue"]);
					}
					if (dr["IsOnlyService"] != null && dr["IsOnlyService"] != DBNull.Value)
					{
						item.IsOnlyService = Convert.ToBoolean(dr["IsOnlyService"]);
					}
					if (dr["Fk_ServiceOrGroup"] != null && dr["Fk_ServiceOrGroup"] != DBNull.Value)
					{
						item.Fk_ServiceOrGroup = Convert.ToString(dr["Fk_ServiceOrGroup"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["IsVoucher"] != null && dr["IsVoucher"] != DBNull.Value)
					{
						item.IsVoucher = Convert.ToBoolean(dr["IsVoucher"]);
					}
					if (dr["IsTotalBill"] != null && dr["IsTotalBill"] != DBNull.Value)
					{
						item.IsTotalBill = Convert.ToBoolean(dr["IsTotalBill"]);
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

		public List<Voucher> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Voucher] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[Voucher] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<Voucher>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một Voucher từ Database
		/// </summary>
		public Voucher GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Voucher] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					Voucher item=new Voucher();
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
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["ValidDate"] != null && dr["ValidDate"] != DBNull.Value)
						{
							item.ValidDate = Convert.ToDateTime(dr["ValidDate"]);
						}
						if (dr["ExperidDate"] != null && dr["ExperidDate"] != DBNull.Value)
						{
							item.ExperidDate = Convert.ToDateTime(dr["ExperidDate"]);
						}
						if (dr["IsUsed"] != null && dr["IsUsed"] != DBNull.Value)
						{
							item.IsUsed = Convert.ToBoolean(dr["IsUsed"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["IsPercentValue"] != null && dr["IsPercentValue"] != DBNull.Value)
						{
							item.IsPercentValue = Convert.ToBoolean(dr["IsPercentValue"]);
						}
						if (dr["IsOnlyService"] != null && dr["IsOnlyService"] != DBNull.Value)
						{
							item.IsOnlyService = Convert.ToBoolean(dr["IsOnlyService"]);
						}
						if (dr["Fk_ServiceOrGroup"] != null && dr["Fk_ServiceOrGroup"] != DBNull.Value)
						{
							item.Fk_ServiceOrGroup = Convert.ToString(dr["Fk_ServiceOrGroup"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["IsVoucher"] != null && dr["IsVoucher"] != DBNull.Value)
						{
							item.IsVoucher = Convert.ToBoolean(dr["IsVoucher"]);
						}
						if (dr["IsTotalBill"] != null && dr["IsTotalBill"] != DBNull.Value)
						{
							item.IsTotalBill = Convert.ToBoolean(dr["IsTotalBill"]);
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
		/// Lấy một Voucher đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public Voucher GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Voucher] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					Voucher item=new Voucher();
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
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["ValidDate"] != null && dr["ValidDate"] != DBNull.Value)
						{
							item.ValidDate = Convert.ToDateTime(dr["ValidDate"]);
						}
						if (dr["ExperidDate"] != null && dr["ExperidDate"] != DBNull.Value)
						{
							item.ExperidDate = Convert.ToDateTime(dr["ExperidDate"]);
						}
						if (dr["IsUsed"] != null && dr["IsUsed"] != DBNull.Value)
						{
							item.IsUsed = Convert.ToBoolean(dr["IsUsed"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["IsPercentValue"] != null && dr["IsPercentValue"] != DBNull.Value)
						{
							item.IsPercentValue = Convert.ToBoolean(dr["IsPercentValue"]);
						}
						if (dr["IsOnlyService"] != null && dr["IsOnlyService"] != DBNull.Value)
						{
							item.IsOnlyService = Convert.ToBoolean(dr["IsOnlyService"]);
						}
						if (dr["Fk_ServiceOrGroup"] != null && dr["Fk_ServiceOrGroup"] != DBNull.Value)
						{
							item.Fk_ServiceOrGroup = Convert.ToString(dr["Fk_ServiceOrGroup"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["IsVoucher"] != null && dr["IsVoucher"] != DBNull.Value)
						{
							item.IsVoucher = Convert.ToBoolean(dr["IsVoucher"]);
						}
						if (dr["IsTotalBill"] != null && dr["IsTotalBill"] != DBNull.Value)
						{
							item.IsTotalBill = Convert.ToBoolean(dr["IsTotalBill"]);
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

		public Voucher GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Voucher] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<Voucher>(ds);
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
		/// Thêm mới Voucher vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, Voucher _Voucher)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[Voucher](Id, Code, Name, Description, ValidDate, ExperidDate, IsUsed, Value, IsPercentValue, IsOnlyService, Fk_ServiceOrGroup, CreateDate, CreateBy, IsDelete, IsVoucher, IsTotalBill) VALUES(@Id, @Code, @Name, @Description, @ValidDate, @ExperidDate, @IsUsed, @Value, @IsPercentValue, @IsOnlyService, @Fk_ServiceOrGroup, @CreateDate, @CreateBy, @IsDelete, @IsVoucher, @IsTotalBill)", 
					"@Id",  _Voucher.Id, 
					"@Code",  _Voucher.Code, 
					"@Name",  _Voucher.Name, 
					"@Description",  _Voucher.Description, 
					"@ValidDate", this._dataContext.ConvertDateString( _Voucher.ValidDate), 
					"@ExperidDate", this._dataContext.ConvertDateString( _Voucher.ExperidDate), 
					"@IsUsed",  _Voucher.IsUsed, 
					"@Value",  _Voucher.Value, 
					"@IsPercentValue",  _Voucher.IsPercentValue, 
					"@IsOnlyService",  _Voucher.IsOnlyService, 
					"@Fk_ServiceOrGroup",  _Voucher.Fk_ServiceOrGroup, 
					"@CreateDate", this._dataContext.ConvertDateString( _Voucher.CreateDate), 
					"@CreateBy",  _Voucher.CreateBy, 
					"@IsDelete",  _Voucher.IsDelete, 
					"@IsVoucher",  _Voucher.IsVoucher, 
					"@IsTotalBill",  _Voucher.IsTotalBill);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng Voucher vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<Voucher> _Vouchers)
		{
			foreach (Voucher item in _Vouchers)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Voucher vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, Voucher _Voucher, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Voucher] SET Id=@Id, Code=@Code, Name=@Name, Description=@Description, ValidDate=@ValidDate, ExperidDate=@ExperidDate, IsUsed=@IsUsed, Value=@Value, IsPercentValue=@IsPercentValue, IsOnlyService=@IsOnlyService, Fk_ServiceOrGroup=@Fk_ServiceOrGroup, CreateDate=@CreateDate, CreateBy=@CreateBy, IsDelete=@IsDelete, IsVoucher=@IsVoucher, IsTotalBill=@IsTotalBill WHERE Id=@Id", 
					"@Id",  _Voucher.Id, 
					"@Code",  _Voucher.Code, 
					"@Name",  _Voucher.Name, 
					"@Description",  _Voucher.Description, 
					"@ValidDate", this._dataContext.ConvertDateString( _Voucher.ValidDate), 
					"@ExperidDate", this._dataContext.ConvertDateString( _Voucher.ExperidDate), 
					"@IsUsed",  _Voucher.IsUsed, 
					"@Value",  _Voucher.Value, 
					"@IsPercentValue",  _Voucher.IsPercentValue, 
					"@IsOnlyService",  _Voucher.IsOnlyService, 
					"@Fk_ServiceOrGroup",  _Voucher.Fk_ServiceOrGroup, 
					"@CreateDate", this._dataContext.ConvertDateString( _Voucher.CreateDate), 
					"@CreateBy",  _Voucher.CreateBy, 
					"@IsDelete",  _Voucher.IsDelete, 
					"@IsVoucher",  _Voucher.IsVoucher, 
					"@IsTotalBill",  _Voucher.IsTotalBill, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật Voucher vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, Voucher _Voucher)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Voucher] SET Code=@Code, Name=@Name, Description=@Description, ValidDate=@ValidDate, ExperidDate=@ExperidDate, IsUsed=@IsUsed, Value=@Value, IsPercentValue=@IsPercentValue, IsOnlyService=@IsOnlyService, Fk_ServiceOrGroup=@Fk_ServiceOrGroup, CreateDate=@CreateDate, CreateBy=@CreateBy, IsDelete=@IsDelete, IsVoucher=@IsVoucher, IsTotalBill=@IsTotalBill WHERE Id=@Id", 
					"@Code",  _Voucher.Code, 
					"@Name",  _Voucher.Name, 
					"@Description",  _Voucher.Description, 
					"@ValidDate", this._dataContext.ConvertDateString( _Voucher.ValidDate), 
					"@ExperidDate", this._dataContext.ConvertDateString( _Voucher.ExperidDate), 
					"@IsUsed",  _Voucher.IsUsed, 
					"@Value",  _Voucher.Value, 
					"@IsPercentValue",  _Voucher.IsPercentValue, 
					"@IsOnlyService",  _Voucher.IsOnlyService, 
					"@Fk_ServiceOrGroup",  _Voucher.Fk_ServiceOrGroup, 
					"@CreateDate", this._dataContext.ConvertDateString( _Voucher.CreateDate), 
					"@CreateBy",  _Voucher.CreateBy, 
					"@IsDelete",  _Voucher.IsDelete, 
					"@IsVoucher",  _Voucher.IsVoucher, 
					"@IsTotalBill",  _Voucher.IsTotalBill, 
					"@Id", _Voucher.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách Voucher vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<Voucher> _Vouchers)
		{
			foreach (Voucher item in _Vouchers)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Voucher vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, Voucher _Voucher, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Voucher] SET Id=@Id, Code=@Code, Name=@Name, Description=@Description, ValidDate=@ValidDate, ExperidDate=@ExperidDate, IsUsed=@IsUsed, Value=@Value, IsPercentValue=@IsPercentValue, IsOnlyService=@IsOnlyService, Fk_ServiceOrGroup=@Fk_ServiceOrGroup, CreateDate=@CreateDate, CreateBy=@CreateBy, IsDelete=@IsDelete, IsVoucher=@IsVoucher, IsTotalBill=@IsTotalBill "+ condition, 
					"@Id",  _Voucher.Id, 
					"@Code",  _Voucher.Code, 
					"@Name",  _Voucher.Name, 
					"@Description",  _Voucher.Description, 
					"@ValidDate", this._dataContext.ConvertDateString( _Voucher.ValidDate), 
					"@ExperidDate", this._dataContext.ConvertDateString( _Voucher.ExperidDate), 
					"@IsUsed",  _Voucher.IsUsed, 
					"@Value",  _Voucher.Value, 
					"@IsPercentValue",  _Voucher.IsPercentValue, 
					"@IsOnlyService",  _Voucher.IsOnlyService, 
					"@Fk_ServiceOrGroup",  _Voucher.Fk_ServiceOrGroup, 
					"@CreateDate", this._dataContext.ConvertDateString( _Voucher.CreateDate), 
					"@CreateBy",  _Voucher.CreateBy, 
					"@IsDelete",  _Voucher.IsDelete, 
					"@IsVoucher",  _Voucher.IsVoucher, 
					"@IsTotalBill",  _Voucher.IsTotalBill);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa Voucher trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Voucher] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Voucher trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Voucher _Voucher)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Voucher] WHERE Id=@Id",
					"@Id", _Voucher.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Voucher trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Voucher] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Voucher trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<Voucher> _Vouchers)
		{
			foreach (Voucher item in _Vouchers)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
