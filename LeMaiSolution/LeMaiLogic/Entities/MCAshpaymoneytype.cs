using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MCAshpaymoneytype:ICAshpaymoneytype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MCAshpaymoneytype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable CashPayMoneyType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPayMoneyType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable CashPayMoneyType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPayMoneyType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách CashPayMoneyType từ Database
		/// </summary>
		public List<CashPayMoneyType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPayMoneyType]");
				List<CashPayMoneyType> items = new List<CashPayMoneyType>();
				CashPayMoneyType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new CashPayMoneyType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["MoneyTypeName"] != null && dr["MoneyTypeName"] != DBNull.Value)
					{
						item.MoneyTypeName = Convert.ToString(dr["MoneyTypeName"]);
					}
					if (dr["Image"] != null && dr["Image"] != DBNull.Value)
					{
						item.Image = Convert.ToString(dr["Image"]);
					}
					if (dr["IsUsing"] != null && dr["IsUsing"] != DBNull.Value)
					{
						item.IsUsing = Convert.ToBoolean(dr["IsUsing"]);
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
		/// Lấy danh sách CashPayMoneyType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<CashPayMoneyType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[CashPayMoneyType] A "+ condition,  parameters);
				List<CashPayMoneyType> items = new List<CashPayMoneyType>();
				CashPayMoneyType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new CashPayMoneyType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["MoneyTypeName"] != null && dr["MoneyTypeName"] != DBNull.Value)
					{
						item.MoneyTypeName = Convert.ToString(dr["MoneyTypeName"]);
					}
					if (dr["Image"] != null && dr["Image"] != DBNull.Value)
					{
						item.Image = Convert.ToString(dr["Image"]);
					}
					if (dr["IsUsing"] != null && dr["IsUsing"] != DBNull.Value)
					{
						item.IsUsing = Convert.ToBoolean(dr["IsUsing"]);
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

		public List<CashPayMoneyType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[CashPayMoneyType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[CashPayMoneyType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<CashPayMoneyType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một CashPayMoneyType từ Database
		/// </summary>
		public CashPayMoneyType GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPayMoneyType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					CashPayMoneyType item=new CashPayMoneyType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["MoneyTypeName"] != null && dr["MoneyTypeName"] != DBNull.Value)
						{
							item.MoneyTypeName = Convert.ToString(dr["MoneyTypeName"]);
						}
						if (dr["Image"] != null && dr["Image"] != DBNull.Value)
						{
							item.Image = Convert.ToString(dr["Image"]);
						}
						if (dr["IsUsing"] != null && dr["IsUsing"] != DBNull.Value)
						{
							item.IsUsing = Convert.ToBoolean(dr["IsUsing"]);
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
		/// Lấy một CashPayMoneyType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public CashPayMoneyType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[CashPayMoneyType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					CashPayMoneyType item=new CashPayMoneyType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["MoneyTypeName"] != null && dr["MoneyTypeName"] != DBNull.Value)
						{
							item.MoneyTypeName = Convert.ToString(dr["MoneyTypeName"]);
						}
						if (dr["Image"] != null && dr["Image"] != DBNull.Value)
						{
							item.Image = Convert.ToString(dr["Image"]);
						}
						if (dr["IsUsing"] != null && dr["IsUsing"] != DBNull.Value)
						{
							item.IsUsing = Convert.ToBoolean(dr["IsUsing"]);
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

		public CashPayMoneyType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[CashPayMoneyType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<CashPayMoneyType>(ds);
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
		/// Thêm mới CashPayMoneyType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, CashPayMoneyType _CashPayMoneyType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[CashPayMoneyType](Id, MoneyTypeName, Image, IsUsing) VALUES(@Id, @MoneyTypeName, @Image, @IsUsing)", 
					"@Id",  _CashPayMoneyType.Id, 
					"@MoneyTypeName",  _CashPayMoneyType.MoneyTypeName, 
					"@Image",  _CashPayMoneyType.Image, 
					"@IsUsing",  _CashPayMoneyType.IsUsing);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng CashPayMoneyType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<CashPayMoneyType> _CashPayMoneyTypes)
		{
			foreach (CashPayMoneyType item in _CashPayMoneyTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật CashPayMoneyType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, CashPayMoneyType _CashPayMoneyType, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[CashPayMoneyType] SET Id=@Id, MoneyTypeName=@MoneyTypeName, Image=@Image, IsUsing=@IsUsing WHERE Id=@Id", 
					"@Id",  _CashPayMoneyType.Id, 
					"@MoneyTypeName",  _CashPayMoneyType.MoneyTypeName, 
					"@Image",  _CashPayMoneyType.Image, 
					"@IsUsing",  _CashPayMoneyType.IsUsing, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật CashPayMoneyType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, CashPayMoneyType _CashPayMoneyType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[CashPayMoneyType] SET MoneyTypeName=@MoneyTypeName, Image=@Image, IsUsing=@IsUsing WHERE Id=@Id", 
					"@MoneyTypeName",  _CashPayMoneyType.MoneyTypeName, 
					"@Image",  _CashPayMoneyType.Image, 
					"@IsUsing",  _CashPayMoneyType.IsUsing, 
					"@Id", _CashPayMoneyType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách CashPayMoneyType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<CashPayMoneyType> _CashPayMoneyTypes)
		{
			foreach (CashPayMoneyType item in _CashPayMoneyTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật CashPayMoneyType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, CashPayMoneyType _CashPayMoneyType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[CashPayMoneyType] SET Id=@Id, MoneyTypeName=@MoneyTypeName, Image=@Image, IsUsing=@IsUsing "+ condition, 
					"@Id",  _CashPayMoneyType.Id, 
					"@MoneyTypeName",  _CashPayMoneyType.MoneyTypeName, 
					"@Image",  _CashPayMoneyType.Image, 
					"@IsUsing",  _CashPayMoneyType.IsUsing);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa CashPayMoneyType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[CashPayMoneyType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa CashPayMoneyType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, CashPayMoneyType _CashPayMoneyType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[CashPayMoneyType] WHERE Id=@Id",
					"@Id", _CashPayMoneyType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa CashPayMoneyType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[CashPayMoneyType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa CashPayMoneyType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<CashPayMoneyType> _CashPayMoneyTypes)
		{
			foreach (CashPayMoneyType item in _CashPayMoneyTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
