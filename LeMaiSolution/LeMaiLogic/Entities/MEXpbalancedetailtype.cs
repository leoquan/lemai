using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpbalancedetailtype:IEXpbalancedetailtype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpbalancedetailtype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpBalanceDetailType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBalanceDetailType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpBalanceDetailType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBalanceDetailType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpBalanceDetailType từ Database
		/// </summary>
		public List<ExpBalanceDetailType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBalanceDetailType]");
				List<ExpBalanceDetailType> items = new List<ExpBalanceDetailType>();
				ExpBalanceDetailType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpBalanceDetailType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BalanceTypeName"] != null && dr["BalanceTypeName"] != DBNull.Value)
					{
						item.BalanceTypeName = Convert.ToString(dr["BalanceTypeName"]);
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
		/// Lấy danh sách ExpBalanceDetailType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpBalanceDetailType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpBalanceDetailType] A "+ condition,  parameters);
				List<ExpBalanceDetailType> items = new List<ExpBalanceDetailType>();
				ExpBalanceDetailType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpBalanceDetailType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BalanceTypeName"] != null && dr["BalanceTypeName"] != DBNull.Value)
					{
						item.BalanceTypeName = Convert.ToString(dr["BalanceTypeName"]);
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

		public List<ExpBalanceDetailType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpBalanceDetailType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpBalanceDetailType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpBalanceDetailType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpBalanceDetailType từ Database
		/// </summary>
		public ExpBalanceDetailType GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBalanceDetailType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpBalanceDetailType item=new ExpBalanceDetailType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BalanceTypeName"] != null && dr["BalanceTypeName"] != DBNull.Value)
						{
							item.BalanceTypeName = Convert.ToString(dr["BalanceTypeName"]);
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
		/// Lấy một ExpBalanceDetailType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpBalanceDetailType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpBalanceDetailType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpBalanceDetailType item=new ExpBalanceDetailType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BalanceTypeName"] != null && dr["BalanceTypeName"] != DBNull.Value)
						{
							item.BalanceTypeName = Convert.ToString(dr["BalanceTypeName"]);
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

		public ExpBalanceDetailType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpBalanceDetailType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpBalanceDetailType>(ds);
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
		/// Thêm mới ExpBalanceDetailType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpBalanceDetailType _ExpBalanceDetailType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpBalanceDetailType](Id, BalanceTypeName) VALUES(@Id, @BalanceTypeName)", 
					"@Id",  _ExpBalanceDetailType.Id, 
					"@BalanceTypeName",  _ExpBalanceDetailType.BalanceTypeName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpBalanceDetailType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpBalanceDetailType> _ExpBalanceDetailTypes)
		{
			foreach (ExpBalanceDetailType item in _ExpBalanceDetailTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpBalanceDetailType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpBalanceDetailType _ExpBalanceDetailType, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBalanceDetailType] SET Id=@Id, BalanceTypeName=@BalanceTypeName WHERE Id=@Id", 
					"@Id",  _ExpBalanceDetailType.Id, 
					"@BalanceTypeName",  _ExpBalanceDetailType.BalanceTypeName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpBalanceDetailType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpBalanceDetailType _ExpBalanceDetailType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBalanceDetailType] SET BalanceTypeName=@BalanceTypeName WHERE Id=@Id", 
					"@BalanceTypeName",  _ExpBalanceDetailType.BalanceTypeName, 
					"@Id", _ExpBalanceDetailType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpBalanceDetailType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpBalanceDetailType> _ExpBalanceDetailTypes)
		{
			foreach (ExpBalanceDetailType item in _ExpBalanceDetailTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpBalanceDetailType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpBalanceDetailType _ExpBalanceDetailType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBalanceDetailType] SET Id=@Id, BalanceTypeName=@BalanceTypeName "+ condition, 
					"@Id",  _ExpBalanceDetailType.Id, 
					"@BalanceTypeName",  _ExpBalanceDetailType.BalanceTypeName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpBalanceDetailType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBalanceDetailType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBalanceDetailType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpBalanceDetailType _ExpBalanceDetailType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBalanceDetailType] WHERE Id=@Id",
					"@Id", _ExpBalanceDetailType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBalanceDetailType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBalanceDetailType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBalanceDetailType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpBalanceDetailType> _ExpBalanceDetailTypes)
		{
			foreach (ExpBalanceDetailType item in _ExpBalanceDetailTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
