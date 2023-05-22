using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpconsignmentcashpaytype:IEXpconsignmentcashpaytype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpconsignmentcashpaytype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpConsignmentCashPayType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentCashPayType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpConsignmentCashPayType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentCashPayType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpConsignmentCashPayType từ Database
		/// </summary>
		public List<ExpConsignmentCashPayType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentCashPayType]");
				List<ExpConsignmentCashPayType> items = new List<ExpConsignmentCashPayType>();
				ExpConsignmentCashPayType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentCashPayType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
					}
					if (dr["UsingCashPay"] != null && dr["UsingCashPay"] != DBNull.Value)
					{
						item.UsingCashPay = Convert.ToBoolean(dr["UsingCashPay"]);
					}
					if (dr["IsPay"] != null && dr["IsPay"] != DBNull.Value)
					{
						item.IsPay = Convert.ToBoolean(dr["IsPay"]);
					}
					if (dr["Supper"] != null && dr["Supper"] != DBNull.Value)
					{
						item.Supper = Convert.ToBoolean(dr["Supper"]);
					}
					if (dr["RequireBill"] != null && dr["RequireBill"] != DBNull.Value)
					{
						item.RequireBill = Convert.ToBoolean(dr["RequireBill"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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
		/// Lấy danh sách ExpConsignmentCashPayType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpConsignmentCashPayType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentCashPayType] A "+ condition,  parameters);
				List<ExpConsignmentCashPayType> items = new List<ExpConsignmentCashPayType>();
				ExpConsignmentCashPayType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentCashPayType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
					}
					if (dr["UsingCashPay"] != null && dr["UsingCashPay"] != DBNull.Value)
					{
						item.UsingCashPay = Convert.ToBoolean(dr["UsingCashPay"]);
					}
					if (dr["IsPay"] != null && dr["IsPay"] != DBNull.Value)
					{
						item.IsPay = Convert.ToBoolean(dr["IsPay"]);
					}
					if (dr["Supper"] != null && dr["Supper"] != DBNull.Value)
					{
						item.Supper = Convert.ToBoolean(dr["Supper"]);
					}
					if (dr["RequireBill"] != null && dr["RequireBill"] != DBNull.Value)
					{
						item.RequireBill = Convert.ToBoolean(dr["RequireBill"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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

		public List<ExpConsignmentCashPayType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentCashPayType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentCashPayType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpConsignmentCashPayType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpConsignmentCashPayType từ Database
		/// </summary>
		public ExpConsignmentCashPayType GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentCashPayType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentCashPayType item=new ExpConsignmentCashPayType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
						{
							item.TenLoai = Convert.ToString(dr["TenLoai"]);
						}
						if (dr["UsingCashPay"] != null && dr["UsingCashPay"] != DBNull.Value)
						{
							item.UsingCashPay = Convert.ToBoolean(dr["UsingCashPay"]);
						}
						if (dr["IsPay"] != null && dr["IsPay"] != DBNull.Value)
						{
							item.IsPay = Convert.ToBoolean(dr["IsPay"]);
						}
						if (dr["Supper"] != null && dr["Supper"] != DBNull.Value)
						{
							item.Supper = Convert.ToBoolean(dr["Supper"]);
						}
						if (dr["RequireBill"] != null && dr["RequireBill"] != DBNull.Value)
						{
							item.RequireBill = Convert.ToBoolean(dr["RequireBill"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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
		/// Lấy một ExpConsignmentCashPayType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpConsignmentCashPayType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentCashPayType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentCashPayType item=new ExpConsignmentCashPayType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
						{
							item.TenLoai = Convert.ToString(dr["TenLoai"]);
						}
						if (dr["UsingCashPay"] != null && dr["UsingCashPay"] != DBNull.Value)
						{
							item.UsingCashPay = Convert.ToBoolean(dr["UsingCashPay"]);
						}
						if (dr["IsPay"] != null && dr["IsPay"] != DBNull.Value)
						{
							item.IsPay = Convert.ToBoolean(dr["IsPay"]);
						}
						if (dr["Supper"] != null && dr["Supper"] != DBNull.Value)
						{
							item.Supper = Convert.ToBoolean(dr["Supper"]);
						}
						if (dr["RequireBill"] != null && dr["RequireBill"] != DBNull.Value)
						{
							item.RequireBill = Convert.ToBoolean(dr["RequireBill"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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

		public ExpConsignmentCashPayType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentCashPayType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpConsignmentCashPayType>(ds);
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
		/// Thêm mới ExpConsignmentCashPayType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpConsignmentCashPayType _ExpConsignmentCashPayType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpConsignmentCashPayType](Id, TenLoai, UsingCashPay, IsPay, Supper, RequireBill, SortIndex) VALUES(@Id, @TenLoai, @UsingCashPay, @IsPay, @Supper, @RequireBill, @SortIndex)", 
					"@Id",  _ExpConsignmentCashPayType.Id, 
					"@TenLoai",  _ExpConsignmentCashPayType.TenLoai, 
					"@UsingCashPay",  _ExpConsignmentCashPayType.UsingCashPay, 
					"@IsPay",  _ExpConsignmentCashPayType.IsPay, 
					"@Supper",  _ExpConsignmentCashPayType.Supper, 
					"@RequireBill",  _ExpConsignmentCashPayType.RequireBill, 
					"@SortIndex",  _ExpConsignmentCashPayType.SortIndex);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentCashPayType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpConsignmentCashPayType> _ExpConsignmentCashPayTypes)
		{
			foreach (ExpConsignmentCashPayType item in _ExpConsignmentCashPayTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentCashPayType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpConsignmentCashPayType _ExpConsignmentCashPayType, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentCashPayType] SET Id=@Id, TenLoai=@TenLoai, UsingCashPay=@UsingCashPay, IsPay=@IsPay, Supper=@Supper, RequireBill=@RequireBill, SortIndex=@SortIndex WHERE Id=@Id", 
					"@Id",  _ExpConsignmentCashPayType.Id, 
					"@TenLoai",  _ExpConsignmentCashPayType.TenLoai, 
					"@UsingCashPay",  _ExpConsignmentCashPayType.UsingCashPay, 
					"@IsPay",  _ExpConsignmentCashPayType.IsPay, 
					"@Supper",  _ExpConsignmentCashPayType.Supper, 
					"@RequireBill",  _ExpConsignmentCashPayType.RequireBill, 
					"@SortIndex",  _ExpConsignmentCashPayType.SortIndex, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentCashPayType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpConsignmentCashPayType _ExpConsignmentCashPayType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentCashPayType] SET TenLoai=@TenLoai, UsingCashPay=@UsingCashPay, IsPay=@IsPay, Supper=@Supper, RequireBill=@RequireBill, SortIndex=@SortIndex WHERE Id=@Id", 
					"@TenLoai",  _ExpConsignmentCashPayType.TenLoai, 
					"@UsingCashPay",  _ExpConsignmentCashPayType.UsingCashPay, 
					"@IsPay",  _ExpConsignmentCashPayType.IsPay, 
					"@Supper",  _ExpConsignmentCashPayType.Supper, 
					"@RequireBill",  _ExpConsignmentCashPayType.RequireBill, 
					"@SortIndex",  _ExpConsignmentCashPayType.SortIndex, 
					"@Id", _ExpConsignmentCashPayType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpConsignmentCashPayType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpConsignmentCashPayType> _ExpConsignmentCashPayTypes)
		{
			foreach (ExpConsignmentCashPayType item in _ExpConsignmentCashPayTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentCashPayType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpConsignmentCashPayType _ExpConsignmentCashPayType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentCashPayType] SET Id=@Id, TenLoai=@TenLoai, UsingCashPay=@UsingCashPay, IsPay=@IsPay, Supper=@Supper, RequireBill=@RequireBill, SortIndex=@SortIndex "+ condition, 
					"@Id",  _ExpConsignmentCashPayType.Id, 
					"@TenLoai",  _ExpConsignmentCashPayType.TenLoai, 
					"@UsingCashPay",  _ExpConsignmentCashPayType.UsingCashPay, 
					"@IsPay",  _ExpConsignmentCashPayType.IsPay, 
					"@Supper",  _ExpConsignmentCashPayType.Supper, 
					"@RequireBill",  _ExpConsignmentCashPayType.RequireBill, 
					"@SortIndex",  _ExpConsignmentCashPayType.SortIndex);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpConsignmentCashPayType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentCashPayType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentCashPayType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpConsignmentCashPayType _ExpConsignmentCashPayType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentCashPayType] WHERE Id=@Id",
					"@Id", _ExpConsignmentCashPayType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentCashPayType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentCashPayType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentCashPayType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpConsignmentCashPayType> _ExpConsignmentCashPayTypes)
		{
			foreach (ExpConsignmentCashPayType item in _ExpConsignmentCashPayTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
