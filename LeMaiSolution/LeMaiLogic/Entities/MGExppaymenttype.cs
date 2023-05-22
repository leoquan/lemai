using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExppaymenttype:IGExppaymenttype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExppaymenttype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpPaymentType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpPaymentType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpPaymentType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpPaymentType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpPaymentType từ Database
		/// </summary>
		public List<GExpPaymentType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpPaymentType]");
				List<GExpPaymentType> items = new List<GExpPaymentType>();
				GExpPaymentType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpPaymentType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["PaymentTypeName"] != null && dr["PaymentTypeName"] != DBNull.Value)
					{
						item.PaymentTypeName = Convert.ToString(dr["PaymentTypeName"]);
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
		/// Lấy danh sách GExpPaymentType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpPaymentType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpPaymentType] A "+ condition,  parameters);
				List<GExpPaymentType> items = new List<GExpPaymentType>();
				GExpPaymentType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpPaymentType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["PaymentTypeName"] != null && dr["PaymentTypeName"] != DBNull.Value)
					{
						item.PaymentTypeName = Convert.ToString(dr["PaymentTypeName"]);
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

		public List<GExpPaymentType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpPaymentType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpPaymentType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpPaymentType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpPaymentType từ Database
		/// </summary>
		public GExpPaymentType GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpPaymentType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpPaymentType item=new GExpPaymentType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["PaymentTypeName"] != null && dr["PaymentTypeName"] != DBNull.Value)
						{
							item.PaymentTypeName = Convert.ToString(dr["PaymentTypeName"]);
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
		/// Lấy một GExpPaymentType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpPaymentType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpPaymentType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpPaymentType item=new GExpPaymentType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["PaymentTypeName"] != null && dr["PaymentTypeName"] != DBNull.Value)
						{
							item.PaymentTypeName = Convert.ToString(dr["PaymentTypeName"]);
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

		public GExpPaymentType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpPaymentType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpPaymentType>(ds);
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
		/// Thêm mới GExpPaymentType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpPaymentType _GExpPaymentType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpPaymentType](Id, PaymentTypeName) VALUES(@Id, @PaymentTypeName)", 
					"@Id",  _GExpPaymentType.Id, 
					"@PaymentTypeName",  _GExpPaymentType.PaymentTypeName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpPaymentType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpPaymentType> _GExpPaymentTypes)
		{
			foreach (GExpPaymentType item in _GExpPaymentTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpPaymentType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpPaymentType _GExpPaymentType, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpPaymentType] SET Id=@Id, PaymentTypeName=@PaymentTypeName WHERE Id=@Id", 
					"@Id",  _GExpPaymentType.Id, 
					"@PaymentTypeName",  _GExpPaymentType.PaymentTypeName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpPaymentType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpPaymentType _GExpPaymentType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpPaymentType] SET PaymentTypeName=@PaymentTypeName WHERE Id=@Id", 
					"@PaymentTypeName",  _GExpPaymentType.PaymentTypeName, 
					"@Id", _GExpPaymentType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpPaymentType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpPaymentType> _GExpPaymentTypes)
		{
			foreach (GExpPaymentType item in _GExpPaymentTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpPaymentType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpPaymentType _GExpPaymentType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpPaymentType] SET Id=@Id, PaymentTypeName=@PaymentTypeName "+ condition, 
					"@Id",  _GExpPaymentType.Id, 
					"@PaymentTypeName",  _GExpPaymentType.PaymentTypeName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpPaymentType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpPaymentType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpPaymentType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpPaymentType _GExpPaymentType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpPaymentType] WHERE Id=@Id",
					"@Id", _GExpPaymentType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpPaymentType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpPaymentType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpPaymentType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpPaymentType> _GExpPaymentTypes)
		{
			foreach (GExpPaymentType item in _GExpPaymentTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
