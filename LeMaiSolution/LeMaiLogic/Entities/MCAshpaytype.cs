using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MCAshpaytype:ICAshpaytype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MCAshpaytype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable CashPayType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPayType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable CashPayType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPayType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách CashPayType từ Database
		/// </summary>
		public List<CashPayType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPayType]");
				List<CashPayType> items = new List<CashPayType>();
				CashPayType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new CashPayType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
					}
					if (dr["IsWithraw"] != null && dr["IsWithraw"] != DBNull.Value)
					{
						item.IsWithraw = Convert.ToBoolean(dr["IsWithraw"]);
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
		/// Lấy danh sách CashPayType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<CashPayType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[CashPayType] A "+ condition,  parameters);
				List<CashPayType> items = new List<CashPayType>();
				CashPayType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new CashPayType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
					}
					if (dr["IsWithraw"] != null && dr["IsWithraw"] != DBNull.Value)
					{
						item.IsWithraw = Convert.ToBoolean(dr["IsWithraw"]);
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

		public List<CashPayType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[CashPayType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[CashPayType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<CashPayType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một CashPayType từ Database
		/// </summary>
		public CashPayType GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[CashPayType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					CashPayType item=new CashPayType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
						{
							item.TypeName = Convert.ToString(dr["TypeName"]);
						}
						if (dr["IsWithraw"] != null && dr["IsWithraw"] != DBNull.Value)
						{
							item.IsWithraw = Convert.ToBoolean(dr["IsWithraw"]);
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
		/// Lấy một CashPayType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public CashPayType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[CashPayType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					CashPayType item=new CashPayType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
						{
							item.TypeName = Convert.ToString(dr["TypeName"]);
						}
						if (dr["IsWithraw"] != null && dr["IsWithraw"] != DBNull.Value)
						{
							item.IsWithraw = Convert.ToBoolean(dr["IsWithraw"]);
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

		public CashPayType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[CashPayType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<CashPayType>(ds);
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
		/// Thêm mới CashPayType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, CashPayType _CashPayType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[CashPayType](Id, TypeName, IsWithraw) VALUES(@Id, @TypeName, @IsWithraw)", 
					"@Id",  _CashPayType.Id, 
					"@TypeName",  _CashPayType.TypeName, 
					"@IsWithraw",  _CashPayType.IsWithraw);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng CashPayType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<CashPayType> _CashPayTypes)
		{
			foreach (CashPayType item in _CashPayTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật CashPayType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, CashPayType _CashPayType, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[CashPayType] SET Id=@Id, TypeName=@TypeName, IsWithraw=@IsWithraw WHERE Id=@Id", 
					"@Id",  _CashPayType.Id, 
					"@TypeName",  _CashPayType.TypeName, 
					"@IsWithraw",  _CashPayType.IsWithraw, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật CashPayType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, CashPayType _CashPayType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[CashPayType] SET TypeName=@TypeName, IsWithraw=@IsWithraw WHERE Id=@Id", 
					"@TypeName",  _CashPayType.TypeName, 
					"@IsWithraw",  _CashPayType.IsWithraw, 
					"@Id", _CashPayType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách CashPayType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<CashPayType> _CashPayTypes)
		{
			foreach (CashPayType item in _CashPayTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật CashPayType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, CashPayType _CashPayType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[CashPayType] SET Id=@Id, TypeName=@TypeName, IsWithraw=@IsWithraw "+ condition, 
					"@Id",  _CashPayType.Id, 
					"@TypeName",  _CashPayType.TypeName, 
					"@IsWithraw",  _CashPayType.IsWithraw);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa CashPayType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[CashPayType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa CashPayType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, CashPayType _CashPayType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[CashPayType] WHERE Id=@Id",
					"@Id", _CashPayType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa CashPayType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[CashPayType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa CashPayType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<CashPayType> _CashPayTypes)
		{
			foreach (CashPayType item in _CashPayTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
