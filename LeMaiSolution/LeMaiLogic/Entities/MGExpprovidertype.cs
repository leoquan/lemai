using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprovidertype:IGExpprovidertype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprovidertype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProviderType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProviderType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProviderType từ Database
		/// </summary>
		public List<GExpProviderType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderType]");
				List<GExpProviderType> items = new List<GExpProviderType>();
				GExpProviderType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProviderType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
					{
						item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
					}
					if (dr["ConfigRequest"] != null && dr["ConfigRequest"] != DBNull.Value)
					{
						item.ConfigRequest = Convert.ToString(dr["ConfigRequest"]);
					}
					if (dr["TrackLink"] != null && dr["TrackLink"] != DBNull.Value)
					{
						item.TrackLink = Convert.ToString(dr["TrackLink"]);
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
		/// Lấy danh sách GExpProviderType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProviderType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProviderType] A "+ condition,  parameters);
				List<GExpProviderType> items = new List<GExpProviderType>();
				GExpProviderType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProviderType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
					{
						item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
					}
					if (dr["ConfigRequest"] != null && dr["ConfigRequest"] != DBNull.Value)
					{
						item.ConfigRequest = Convert.ToString(dr["ConfigRequest"]);
					}
					if (dr["TrackLink"] != null && dr["TrackLink"] != DBNull.Value)
					{
						item.TrackLink = Convert.ToString(dr["TrackLink"]);
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

		public List<GExpProviderType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProviderType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProviderType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProviderType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProviderType từ Database
		/// </summary>
		public GExpProviderType GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpProviderType item=new GExpProviderType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
						{
							item.ProviderName = Convert.ToString(dr["ProviderName"]);
						}
						if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
						{
							item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
						}
						if (dr["ConfigRequest"] != null && dr["ConfigRequest"] != DBNull.Value)
						{
							item.ConfigRequest = Convert.ToString(dr["ConfigRequest"]);
						}
						if (dr["TrackLink"] != null && dr["TrackLink"] != DBNull.Value)
						{
							item.TrackLink = Convert.ToString(dr["TrackLink"]);
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
		/// Lấy một GExpProviderType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProviderType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProviderType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProviderType item=new GExpProviderType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
						{
							item.ProviderName = Convert.ToString(dr["ProviderName"]);
						}
						if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
						{
							item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
						}
						if (dr["ConfigRequest"] != null && dr["ConfigRequest"] != DBNull.Value)
						{
							item.ConfigRequest = Convert.ToString(dr["ConfigRequest"]);
						}
						if (dr["TrackLink"] != null && dr["TrackLink"] != DBNull.Value)
						{
							item.TrackLink = Convert.ToString(dr["TrackLink"]);
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

		public GExpProviderType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProviderType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProviderType>(ds);
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
		/// Thêm mới GExpProviderType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProviderType _GExpProviderType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProviderType](Id, ProviderName, LinkCustomerLogin, ConfigRequest, TrackLink) VALUES(@Id, @ProviderName, @LinkCustomerLogin, @ConfigRequest, @TrackLink)", 
					"@Id",  _GExpProviderType.Id, 
					"@ProviderName",  _GExpProviderType.ProviderName, 
					"@LinkCustomerLogin",  _GExpProviderType.LinkCustomerLogin, 
					"@ConfigRequest",  _GExpProviderType.ConfigRequest, 
					"@TrackLink",  _GExpProviderType.TrackLink);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProviderType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProviderType> _GExpProviderTypes)
		{
			foreach (GExpProviderType item in _GExpProviderTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProviderType _GExpProviderType, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderType] SET Id=@Id, ProviderName=@ProviderName, LinkCustomerLogin=@LinkCustomerLogin, ConfigRequest=@ConfigRequest, TrackLink=@TrackLink WHERE Id=@Id", 
					"@Id",  _GExpProviderType.Id, 
					"@ProviderName",  _GExpProviderType.ProviderName, 
					"@LinkCustomerLogin",  _GExpProviderType.LinkCustomerLogin, 
					"@ConfigRequest",  _GExpProviderType.ConfigRequest, 
					"@TrackLink",  _GExpProviderType.TrackLink, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProviderType _GExpProviderType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderType] SET ProviderName=@ProviderName, LinkCustomerLogin=@LinkCustomerLogin, ConfigRequest=@ConfigRequest, TrackLink=@TrackLink WHERE Id=@Id", 
					"@ProviderName",  _GExpProviderType.ProviderName, 
					"@LinkCustomerLogin",  _GExpProviderType.LinkCustomerLogin, 
					"@ConfigRequest",  _GExpProviderType.ConfigRequest, 
					"@TrackLink",  _GExpProviderType.TrackLink, 
					"@Id", _GExpProviderType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProviderType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProviderType> _GExpProviderTypes)
		{
			foreach (GExpProviderType item in _GExpProviderTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProviderType _GExpProviderType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderType] SET Id=@Id, ProviderName=@ProviderName, LinkCustomerLogin=@LinkCustomerLogin, ConfigRequest=@ConfigRequest, TrackLink=@TrackLink "+ condition, 
					"@Id",  _GExpProviderType.Id, 
					"@ProviderName",  _GExpProviderType.ProviderName, 
					"@LinkCustomerLogin",  _GExpProviderType.LinkCustomerLogin, 
					"@ConfigRequest",  _GExpProviderType.ConfigRequest, 
					"@TrackLink",  _GExpProviderType.TrackLink);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProviderType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProviderType _GExpProviderType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderType] WHERE Id=@Id",
					"@Id", _GExpProviderType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProviderType> _GExpProviderTypes)
		{
			foreach (GExpProviderType item in _GExpProviderTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
