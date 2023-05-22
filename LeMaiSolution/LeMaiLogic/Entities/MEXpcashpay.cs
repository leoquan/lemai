using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcashpay:IEXpcashpay
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcashpay(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCashPay từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCashPay]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCashPay] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCashPay từ Database
		/// </summary>
		public List<ExpCashPay> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCashPay]");
				List<ExpCashPay> items = new List<ExpCashPay>();
				ExpCashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCashPay();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExtPost"] != null && dr["FK_ExtPost"] != DBNull.Value)
					{
						item.FK_ExtPost = Convert.ToString(dr["FK_ExtPost"]);
					}
					if (dr["IsPay"] != null && dr["IsPay"] != DBNull.Value)
					{
						item.IsPay = Convert.ToBoolean(dr["IsPay"]);
					}
					if (dr["MaNguoiNopNhan"] != null && dr["MaNguoiNopNhan"] != DBNull.Value)
					{
						item.MaNguoiNopNhan = Convert.ToString(dr["MaNguoiNopNhan"]);
					}
					if (dr["TenNguoiNopNhan"] != null && dr["TenNguoiNopNhan"] != DBNull.Value)
					{
						item.TenNguoiNopNhan = Convert.ToString(dr["TenNguoiNopNhan"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["AfterTotalValue"] != null && dr["AfterTotalValue"] != DBNull.Value)
					{
						item.AfterTotalValue = Convert.ToInt32(dr["AfterTotalValue"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
					{
						item.SoChungTu = Convert.ToString(dr["SoChungTu"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
					{
						item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
					}
					if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
					{
						item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["PrintCopied"] != null && dr["PrintCopied"] != DBNull.Value)
					{
						item.PrintCopied = Convert.ToInt32(dr["PrintCopied"]);
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
		/// Lấy danh sách ExpCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCashPay] A "+ condition,  parameters);
				List<ExpCashPay> items = new List<ExpCashPay>();
				ExpCashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCashPay();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExtPost"] != null && dr["FK_ExtPost"] != DBNull.Value)
					{
						item.FK_ExtPost = Convert.ToString(dr["FK_ExtPost"]);
					}
					if (dr["IsPay"] != null && dr["IsPay"] != DBNull.Value)
					{
						item.IsPay = Convert.ToBoolean(dr["IsPay"]);
					}
					if (dr["MaNguoiNopNhan"] != null && dr["MaNguoiNopNhan"] != DBNull.Value)
					{
						item.MaNguoiNopNhan = Convert.ToString(dr["MaNguoiNopNhan"]);
					}
					if (dr["TenNguoiNopNhan"] != null && dr["TenNguoiNopNhan"] != DBNull.Value)
					{
						item.TenNguoiNopNhan = Convert.ToString(dr["TenNguoiNopNhan"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["AfterTotalValue"] != null && dr["AfterTotalValue"] != DBNull.Value)
					{
						item.AfterTotalValue = Convert.ToInt32(dr["AfterTotalValue"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
					{
						item.SoChungTu = Convert.ToString(dr["SoChungTu"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
					{
						item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
					}
					if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
					{
						item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["PrintCopied"] != null && dr["PrintCopied"] != DBNull.Value)
					{
						item.PrintCopied = Convert.ToInt32(dr["PrintCopied"]);
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

		public List<ExpCashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCashPay] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCashPay] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCashPay>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCashPay từ Database
		/// </summary>
		public ExpCashPay GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCashPay] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpCashPay item=new ExpCashPay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExtPost"] != null && dr["FK_ExtPost"] != DBNull.Value)
						{
							item.FK_ExtPost = Convert.ToString(dr["FK_ExtPost"]);
						}
						if (dr["IsPay"] != null && dr["IsPay"] != DBNull.Value)
						{
							item.IsPay = Convert.ToBoolean(dr["IsPay"]);
						}
						if (dr["MaNguoiNopNhan"] != null && dr["MaNguoiNopNhan"] != DBNull.Value)
						{
							item.MaNguoiNopNhan = Convert.ToString(dr["MaNguoiNopNhan"]);
						}
						if (dr["TenNguoiNopNhan"] != null && dr["TenNguoiNopNhan"] != DBNull.Value)
						{
							item.TenNguoiNopNhan = Convert.ToString(dr["TenNguoiNopNhan"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["AfterTotalValue"] != null && dr["AfterTotalValue"] != DBNull.Value)
						{
							item.AfterTotalValue = Convert.ToInt32(dr["AfterTotalValue"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
						{
							item.SoChungTu = Convert.ToString(dr["SoChungTu"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
						{
							item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
						}
						if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
						{
							item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
						}
						if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
						{
							item.Reason = Convert.ToString(dr["Reason"]);
						}
						if (dr["PrintCopied"] != null && dr["PrintCopied"] != DBNull.Value)
						{
							item.PrintCopied = Convert.ToInt32(dr["PrintCopied"]);
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
		/// Lấy một ExpCashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCashPay GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCashPay] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCashPay item=new ExpCashPay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExtPost"] != null && dr["FK_ExtPost"] != DBNull.Value)
						{
							item.FK_ExtPost = Convert.ToString(dr["FK_ExtPost"]);
						}
						if (dr["IsPay"] != null && dr["IsPay"] != DBNull.Value)
						{
							item.IsPay = Convert.ToBoolean(dr["IsPay"]);
						}
						if (dr["MaNguoiNopNhan"] != null && dr["MaNguoiNopNhan"] != DBNull.Value)
						{
							item.MaNguoiNopNhan = Convert.ToString(dr["MaNguoiNopNhan"]);
						}
						if (dr["TenNguoiNopNhan"] != null && dr["TenNguoiNopNhan"] != DBNull.Value)
						{
							item.TenNguoiNopNhan = Convert.ToString(dr["TenNguoiNopNhan"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["AfterTotalValue"] != null && dr["AfterTotalValue"] != DBNull.Value)
						{
							item.AfterTotalValue = Convert.ToInt32(dr["AfterTotalValue"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
						{
							item.SoChungTu = Convert.ToString(dr["SoChungTu"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
						{
							item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
						}
						if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
						{
							item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
						}
						if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
						{
							item.Reason = Convert.ToString(dr["Reason"]);
						}
						if (dr["PrintCopied"] != null && dr["PrintCopied"] != DBNull.Value)
						{
							item.PrintCopied = Convert.ToInt32(dr["PrintCopied"]);
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

		public ExpCashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCashPay] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCashPay>(ds);
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
		/// Thêm mới ExpCashPay vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCashPay _ExpCashPay)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCashPay](Id, FK_ExtPost, IsPay, MaNguoiNopNhan, TenNguoiNopNhan, DiaChi, SoDienThoai, Value, AfterTotalValue, CreateDate, CreateBy, SoChungTu, Type, Note, IsDelete, FK_AccountDelete, CreateDelete, Reason, PrintCopied) VALUES(@Id, @FK_ExtPost, @IsPay, @MaNguoiNopNhan, @TenNguoiNopNhan, @DiaChi, @SoDienThoai, @Value, @AfterTotalValue, @CreateDate, @CreateBy, @SoChungTu, @Type, @Note, @IsDelete, @FK_AccountDelete, @CreateDelete, @Reason, @PrintCopied)", 
					"@Id",  _ExpCashPay.Id, 
					"@FK_ExtPost",  _ExpCashPay.FK_ExtPost, 
					"@IsPay",  _ExpCashPay.IsPay, 
					"@MaNguoiNopNhan",  _ExpCashPay.MaNguoiNopNhan, 
					"@TenNguoiNopNhan",  _ExpCashPay.TenNguoiNopNhan, 
					"@DiaChi",  _ExpCashPay.DiaChi, 
					"@SoDienThoai",  _ExpCashPay.SoDienThoai, 
					"@Value",  _ExpCashPay.Value, 
					"@AfterTotalValue",  _ExpCashPay.AfterTotalValue, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCashPay.CreateDate), 
					"@CreateBy",  _ExpCashPay.CreateBy, 
					"@SoChungTu",  _ExpCashPay.SoChungTu, 
					"@Type",  _ExpCashPay.Type, 
					"@Note",  _ExpCashPay.Note, 
					"@IsDelete",  _ExpCashPay.IsDelete, 
					"@FK_AccountDelete",  _ExpCashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _ExpCashPay.CreateDelete), 
					"@Reason",  _ExpCashPay.Reason, 
					"@PrintCopied",  _ExpCashPay.PrintCopied);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCashPay vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCashPay> _ExpCashPays)
		{
			foreach (ExpCashPay item in _ExpCashPays)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCashPay _ExpCashPay, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCashPay] SET Id=@Id, FK_ExtPost=@FK_ExtPost, IsPay=@IsPay, MaNguoiNopNhan=@MaNguoiNopNhan, TenNguoiNopNhan=@TenNguoiNopNhan, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, Value=@Value, AfterTotalValue=@AfterTotalValue, CreateDate=@CreateDate, CreateBy=@CreateBy, SoChungTu=@SoChungTu, Type=@Type, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, PrintCopied=@PrintCopied WHERE Id=@Id", 
					"@Id",  _ExpCashPay.Id, 
					"@FK_ExtPost",  _ExpCashPay.FK_ExtPost, 
					"@IsPay",  _ExpCashPay.IsPay, 
					"@MaNguoiNopNhan",  _ExpCashPay.MaNguoiNopNhan, 
					"@TenNguoiNopNhan",  _ExpCashPay.TenNguoiNopNhan, 
					"@DiaChi",  _ExpCashPay.DiaChi, 
					"@SoDienThoai",  _ExpCashPay.SoDienThoai, 
					"@Value",  _ExpCashPay.Value, 
					"@AfterTotalValue",  _ExpCashPay.AfterTotalValue, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCashPay.CreateDate), 
					"@CreateBy",  _ExpCashPay.CreateBy, 
					"@SoChungTu",  _ExpCashPay.SoChungTu, 
					"@Type",  _ExpCashPay.Type, 
					"@Note",  _ExpCashPay.Note, 
					"@IsDelete",  _ExpCashPay.IsDelete, 
					"@FK_AccountDelete",  _ExpCashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _ExpCashPay.CreateDelete), 
					"@Reason",  _ExpCashPay.Reason, 
					"@PrintCopied",  _ExpCashPay.PrintCopied, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCashPay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCashPay _ExpCashPay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCashPay] SET FK_ExtPost=@FK_ExtPost, IsPay=@IsPay, MaNguoiNopNhan=@MaNguoiNopNhan, TenNguoiNopNhan=@TenNguoiNopNhan, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, Value=@Value, AfterTotalValue=@AfterTotalValue, CreateDate=@CreateDate, CreateBy=@CreateBy, SoChungTu=@SoChungTu, Type=@Type, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, PrintCopied=@PrintCopied WHERE Id=@Id", 
					"@FK_ExtPost",  _ExpCashPay.FK_ExtPost, 
					"@IsPay",  _ExpCashPay.IsPay, 
					"@MaNguoiNopNhan",  _ExpCashPay.MaNguoiNopNhan, 
					"@TenNguoiNopNhan",  _ExpCashPay.TenNguoiNopNhan, 
					"@DiaChi",  _ExpCashPay.DiaChi, 
					"@SoDienThoai",  _ExpCashPay.SoDienThoai, 
					"@Value",  _ExpCashPay.Value, 
					"@AfterTotalValue",  _ExpCashPay.AfterTotalValue, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCashPay.CreateDate), 
					"@CreateBy",  _ExpCashPay.CreateBy, 
					"@SoChungTu",  _ExpCashPay.SoChungTu, 
					"@Type",  _ExpCashPay.Type, 
					"@Note",  _ExpCashPay.Note, 
					"@IsDelete",  _ExpCashPay.IsDelete, 
					"@FK_AccountDelete",  _ExpCashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _ExpCashPay.CreateDelete), 
					"@Reason",  _ExpCashPay.Reason, 
					"@PrintCopied",  _ExpCashPay.PrintCopied, 
					"@Id", _ExpCashPay.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCashPay> _ExpCashPays)
		{
			foreach (ExpCashPay item in _ExpCashPays)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCashPay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCashPay _ExpCashPay, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCashPay] SET Id=@Id, FK_ExtPost=@FK_ExtPost, IsPay=@IsPay, MaNguoiNopNhan=@MaNguoiNopNhan, TenNguoiNopNhan=@TenNguoiNopNhan, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, Value=@Value, AfterTotalValue=@AfterTotalValue, CreateDate=@CreateDate, CreateBy=@CreateBy, SoChungTu=@SoChungTu, Type=@Type, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, PrintCopied=@PrintCopied "+ condition, 
					"@Id",  _ExpCashPay.Id, 
					"@FK_ExtPost",  _ExpCashPay.FK_ExtPost, 
					"@IsPay",  _ExpCashPay.IsPay, 
					"@MaNguoiNopNhan",  _ExpCashPay.MaNguoiNopNhan, 
					"@TenNguoiNopNhan",  _ExpCashPay.TenNguoiNopNhan, 
					"@DiaChi",  _ExpCashPay.DiaChi, 
					"@SoDienThoai",  _ExpCashPay.SoDienThoai, 
					"@Value",  _ExpCashPay.Value, 
					"@AfterTotalValue",  _ExpCashPay.AfterTotalValue, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCashPay.CreateDate), 
					"@CreateBy",  _ExpCashPay.CreateBy, 
					"@SoChungTu",  _ExpCashPay.SoChungTu, 
					"@Type",  _ExpCashPay.Type, 
					"@Note",  _ExpCashPay.Note, 
					"@IsDelete",  _ExpCashPay.IsDelete, 
					"@FK_AccountDelete",  _ExpCashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _ExpCashPay.CreateDelete), 
					"@Reason",  _ExpCashPay.Reason, 
					"@PrintCopied",  _ExpCashPay.PrintCopied);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCashPay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCashPay] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCashPay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCashPay _ExpCashPay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCashPay] WHERE Id=@Id",
					"@Id", _ExpCashPay.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCashPay trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCashPay] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCashPay trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCashPay> _ExpCashPays)
		{
			foreach (ExpCashPay item in _ExpCashPays)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
