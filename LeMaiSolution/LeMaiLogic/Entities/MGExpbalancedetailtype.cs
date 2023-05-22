using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpbalancedetailtype:IGExpbalancedetailtype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpbalancedetailtype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpBalanceDetailType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetailType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpBalanceDetailType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetailType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpBalanceDetailType từ Database
		/// </summary>
		public List<GExpBalanceDetailType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetailType]");
				List<GExpBalanceDetailType> items = new List<GExpBalanceDetailType>();
				GExpBalanceDetailType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBalanceDetailType();
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
		/// Lấy danh sách GExpBalanceDetailType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpBalanceDetailType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBalanceDetailType] A "+ condition,  parameters);
				List<GExpBalanceDetailType> items = new List<GExpBalanceDetailType>();
				GExpBalanceDetailType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBalanceDetailType();
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

		public List<GExpBalanceDetailType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBalanceDetailType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpBalanceDetailType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpBalanceDetailType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpBalanceDetailType từ Database
		/// </summary>
		public GExpBalanceDetailType GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetailType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpBalanceDetailType item=new GExpBalanceDetailType();
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
		/// Lấy một GExpBalanceDetailType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpBalanceDetailType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBalanceDetailType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpBalanceDetailType item=new GExpBalanceDetailType();
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

		public GExpBalanceDetailType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBalanceDetailType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpBalanceDetailType>(ds);
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
		/// Thêm mới GExpBalanceDetailType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpBalanceDetailType _GExpBalanceDetailType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpBalanceDetailType](Id, TenLoai, UsingCashPay, IsPay, Supper, RequireBill, SortIndex) VALUES(@Id, @TenLoai, @UsingCashPay, @IsPay, @Supper, @RequireBill, @SortIndex)", 
					"@Id",  _GExpBalanceDetailType.Id, 
					"@TenLoai",  _GExpBalanceDetailType.TenLoai, 
					"@UsingCashPay",  _GExpBalanceDetailType.UsingCashPay, 
					"@IsPay",  _GExpBalanceDetailType.IsPay, 
					"@Supper",  _GExpBalanceDetailType.Supper, 
					"@RequireBill",  _GExpBalanceDetailType.RequireBill, 
					"@SortIndex",  _GExpBalanceDetailType.SortIndex);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpBalanceDetailType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpBalanceDetailType> _GExpBalanceDetailTypes)
		{
			foreach (GExpBalanceDetailType item in _GExpBalanceDetailTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBalanceDetailType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpBalanceDetailType _GExpBalanceDetailType, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBalanceDetailType] SET Id=@Id, TenLoai=@TenLoai, UsingCashPay=@UsingCashPay, IsPay=@IsPay, Supper=@Supper, RequireBill=@RequireBill, SortIndex=@SortIndex WHERE Id=@Id", 
					"@Id",  _GExpBalanceDetailType.Id, 
					"@TenLoai",  _GExpBalanceDetailType.TenLoai, 
					"@UsingCashPay",  _GExpBalanceDetailType.UsingCashPay, 
					"@IsPay",  _GExpBalanceDetailType.IsPay, 
					"@Supper",  _GExpBalanceDetailType.Supper, 
					"@RequireBill",  _GExpBalanceDetailType.RequireBill, 
					"@SortIndex",  _GExpBalanceDetailType.SortIndex, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpBalanceDetailType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpBalanceDetailType _GExpBalanceDetailType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBalanceDetailType] SET TenLoai=@TenLoai, UsingCashPay=@UsingCashPay, IsPay=@IsPay, Supper=@Supper, RequireBill=@RequireBill, SortIndex=@SortIndex WHERE Id=@Id", 
					"@TenLoai",  _GExpBalanceDetailType.TenLoai, 
					"@UsingCashPay",  _GExpBalanceDetailType.UsingCashPay, 
					"@IsPay",  _GExpBalanceDetailType.IsPay, 
					"@Supper",  _GExpBalanceDetailType.Supper, 
					"@RequireBill",  _GExpBalanceDetailType.RequireBill, 
					"@SortIndex",  _GExpBalanceDetailType.SortIndex, 
					"@Id", _GExpBalanceDetailType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpBalanceDetailType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpBalanceDetailType> _GExpBalanceDetailTypes)
		{
			foreach (GExpBalanceDetailType item in _GExpBalanceDetailTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBalanceDetailType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpBalanceDetailType _GExpBalanceDetailType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBalanceDetailType] SET Id=@Id, TenLoai=@TenLoai, UsingCashPay=@UsingCashPay, IsPay=@IsPay, Supper=@Supper, RequireBill=@RequireBill, SortIndex=@SortIndex "+ condition, 
					"@Id",  _GExpBalanceDetailType.Id, 
					"@TenLoai",  _GExpBalanceDetailType.TenLoai, 
					"@UsingCashPay",  _GExpBalanceDetailType.UsingCashPay, 
					"@IsPay",  _GExpBalanceDetailType.IsPay, 
					"@Supper",  _GExpBalanceDetailType.Supper, 
					"@RequireBill",  _GExpBalanceDetailType.RequireBill, 
					"@SortIndex",  _GExpBalanceDetailType.SortIndex);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpBalanceDetailType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBalanceDetailType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBalanceDetailType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpBalanceDetailType _GExpBalanceDetailType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBalanceDetailType] WHERE Id=@Id",
					"@Id", _GExpBalanceDetailType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBalanceDetailType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBalanceDetailType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBalanceDetailType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpBalanceDetailType> _GExpBalanceDetailTypes)
		{
			foreach (GExpBalanceDetailType item in _GExpBalanceDetailTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
