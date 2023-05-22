using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGScountry:IGScountry
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGScountry(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsCountry từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCountry]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsCountry từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCountry] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsCountry từ Database
		/// </summary>
		public List<GsCountry> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCountry]");
				List<GsCountry> items = new List<GsCountry>();
				GsCountry item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsCountry();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CountryCode"] != null && dr["CountryCode"] != DBNull.Value)
					{
						item.CountryCode = Convert.ToString(dr["CountryCode"]);
					}
					if (dr["CommonName"] != null && dr["CommonName"] != DBNull.Value)
					{
						item.CommonName = Convert.ToString(dr["CommonName"]);
					}
					if (dr["FormalName"] != null && dr["FormalName"] != DBNull.Value)
					{
						item.FormalName = Convert.ToString(dr["FormalName"]);
					}
					if (dr["CountryType"] != null && dr["CountryType"] != DBNull.Value)
					{
						item.CountryType = Convert.ToString(dr["CountryType"]);
					}
					if (dr["CountrySubType"] != null && dr["CountrySubType"] != DBNull.Value)
					{
						item.CountrySubType = Convert.ToString(dr["CountrySubType"]);
					}
					if (dr["Sovereignty"] != null && dr["Sovereignty"] != DBNull.Value)
					{
						item.Sovereignty = Convert.ToString(dr["Sovereignty"]);
					}
					if (dr["Capital"] != null && dr["Capital"] != DBNull.Value)
					{
						item.Capital = Convert.ToString(dr["Capital"]);
					}
					if (dr["CurrencyCode"] != null && dr["CurrencyCode"] != DBNull.Value)
					{
						item.CurrencyCode = Convert.ToString(dr["CurrencyCode"]);
					}
					if (dr["CurrencyName"] != null && dr["CurrencyName"] != DBNull.Value)
					{
						item.CurrencyName = Convert.ToString(dr["CurrencyName"]);
					}
					if (dr["TelephoneCode"] != null && dr["TelephoneCode"] != DBNull.Value)
					{
						item.TelephoneCode = Convert.ToString(dr["TelephoneCode"]);
					}
					if (dr["CountryCode3"] != null && dr["CountryCode3"] != DBNull.Value)
					{
						item.CountryCode3 = Convert.ToString(dr["CountryCode3"]);
					}
					if (dr["CountryNumber"] != null && dr["CountryNumber"] != DBNull.Value)
					{
						item.CountryNumber = Convert.ToString(dr["CountryNumber"]);
					}
					if (dr["InternetCountryCode"] != null && dr["InternetCountryCode"] != DBNull.Value)
					{
						item.InternetCountryCode = Convert.ToString(dr["InternetCountryCode"]);
					}
					if (dr["SortOrder"] != null && dr["SortOrder"] != DBNull.Value)
					{
						item.SortOrder = Convert.ToInt32(dr["SortOrder"]);
					}
					if (dr["IsPublished"] != null && dr["IsPublished"] != DBNull.Value)
					{
						item.IsPublished = Convert.ToBoolean(dr["IsPublished"]);
					}
					if (dr["Flags"] != null && dr["Flags"] != DBNull.Value)
					{
						item.Flags = Convert.ToString(dr["Flags"]);
					}
					if (dr["IsDeleted"] != null && dr["IsDeleted"] != DBNull.Value)
					{
						item.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
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
		/// Lấy danh sách GsCountry từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsCountry> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsCountry] A "+ condition,  parameters);
				List<GsCountry> items = new List<GsCountry>();
				GsCountry item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsCountry();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CountryCode"] != null && dr["CountryCode"] != DBNull.Value)
					{
						item.CountryCode = Convert.ToString(dr["CountryCode"]);
					}
					if (dr["CommonName"] != null && dr["CommonName"] != DBNull.Value)
					{
						item.CommonName = Convert.ToString(dr["CommonName"]);
					}
					if (dr["FormalName"] != null && dr["FormalName"] != DBNull.Value)
					{
						item.FormalName = Convert.ToString(dr["FormalName"]);
					}
					if (dr["CountryType"] != null && dr["CountryType"] != DBNull.Value)
					{
						item.CountryType = Convert.ToString(dr["CountryType"]);
					}
					if (dr["CountrySubType"] != null && dr["CountrySubType"] != DBNull.Value)
					{
						item.CountrySubType = Convert.ToString(dr["CountrySubType"]);
					}
					if (dr["Sovereignty"] != null && dr["Sovereignty"] != DBNull.Value)
					{
						item.Sovereignty = Convert.ToString(dr["Sovereignty"]);
					}
					if (dr["Capital"] != null && dr["Capital"] != DBNull.Value)
					{
						item.Capital = Convert.ToString(dr["Capital"]);
					}
					if (dr["CurrencyCode"] != null && dr["CurrencyCode"] != DBNull.Value)
					{
						item.CurrencyCode = Convert.ToString(dr["CurrencyCode"]);
					}
					if (dr["CurrencyName"] != null && dr["CurrencyName"] != DBNull.Value)
					{
						item.CurrencyName = Convert.ToString(dr["CurrencyName"]);
					}
					if (dr["TelephoneCode"] != null && dr["TelephoneCode"] != DBNull.Value)
					{
						item.TelephoneCode = Convert.ToString(dr["TelephoneCode"]);
					}
					if (dr["CountryCode3"] != null && dr["CountryCode3"] != DBNull.Value)
					{
						item.CountryCode3 = Convert.ToString(dr["CountryCode3"]);
					}
					if (dr["CountryNumber"] != null && dr["CountryNumber"] != DBNull.Value)
					{
						item.CountryNumber = Convert.ToString(dr["CountryNumber"]);
					}
					if (dr["InternetCountryCode"] != null && dr["InternetCountryCode"] != DBNull.Value)
					{
						item.InternetCountryCode = Convert.ToString(dr["InternetCountryCode"]);
					}
					if (dr["SortOrder"] != null && dr["SortOrder"] != DBNull.Value)
					{
						item.SortOrder = Convert.ToInt32(dr["SortOrder"]);
					}
					if (dr["IsPublished"] != null && dr["IsPublished"] != DBNull.Value)
					{
						item.IsPublished = Convert.ToBoolean(dr["IsPublished"]);
					}
					if (dr["Flags"] != null && dr["Flags"] != DBNull.Value)
					{
						item.Flags = Convert.ToString(dr["Flags"]);
					}
					if (dr["IsDeleted"] != null && dr["IsDeleted"] != DBNull.Value)
					{
						item.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
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

		public List<GsCountry> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsCountry] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsCountry] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsCountry>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsCountry từ Database
		/// </summary>
		public GsCountry GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCountry] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsCountry item=new GsCountry();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CountryCode"] != null && dr["CountryCode"] != DBNull.Value)
						{
							item.CountryCode = Convert.ToString(dr["CountryCode"]);
						}
						if (dr["CommonName"] != null && dr["CommonName"] != DBNull.Value)
						{
							item.CommonName = Convert.ToString(dr["CommonName"]);
						}
						if (dr["FormalName"] != null && dr["FormalName"] != DBNull.Value)
						{
							item.FormalName = Convert.ToString(dr["FormalName"]);
						}
						if (dr["CountryType"] != null && dr["CountryType"] != DBNull.Value)
						{
							item.CountryType = Convert.ToString(dr["CountryType"]);
						}
						if (dr["CountrySubType"] != null && dr["CountrySubType"] != DBNull.Value)
						{
							item.CountrySubType = Convert.ToString(dr["CountrySubType"]);
						}
						if (dr["Sovereignty"] != null && dr["Sovereignty"] != DBNull.Value)
						{
							item.Sovereignty = Convert.ToString(dr["Sovereignty"]);
						}
						if (dr["Capital"] != null && dr["Capital"] != DBNull.Value)
						{
							item.Capital = Convert.ToString(dr["Capital"]);
						}
						if (dr["CurrencyCode"] != null && dr["CurrencyCode"] != DBNull.Value)
						{
							item.CurrencyCode = Convert.ToString(dr["CurrencyCode"]);
						}
						if (dr["CurrencyName"] != null && dr["CurrencyName"] != DBNull.Value)
						{
							item.CurrencyName = Convert.ToString(dr["CurrencyName"]);
						}
						if (dr["TelephoneCode"] != null && dr["TelephoneCode"] != DBNull.Value)
						{
							item.TelephoneCode = Convert.ToString(dr["TelephoneCode"]);
						}
						if (dr["CountryCode3"] != null && dr["CountryCode3"] != DBNull.Value)
						{
							item.CountryCode3 = Convert.ToString(dr["CountryCode3"]);
						}
						if (dr["CountryNumber"] != null && dr["CountryNumber"] != DBNull.Value)
						{
							item.CountryNumber = Convert.ToString(dr["CountryNumber"]);
						}
						if (dr["InternetCountryCode"] != null && dr["InternetCountryCode"] != DBNull.Value)
						{
							item.InternetCountryCode = Convert.ToString(dr["InternetCountryCode"]);
						}
						if (dr["SortOrder"] != null && dr["SortOrder"] != DBNull.Value)
						{
							item.SortOrder = Convert.ToInt32(dr["SortOrder"]);
						}
						if (dr["IsPublished"] != null && dr["IsPublished"] != DBNull.Value)
						{
							item.IsPublished = Convert.ToBoolean(dr["IsPublished"]);
						}
						if (dr["Flags"] != null && dr["Flags"] != DBNull.Value)
						{
							item.Flags = Convert.ToString(dr["Flags"]);
						}
						if (dr["IsDeleted"] != null && dr["IsDeleted"] != DBNull.Value)
						{
							item.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
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
		/// Lấy một GsCountry đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsCountry GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsCountry] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsCountry item=new GsCountry();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CountryCode"] != null && dr["CountryCode"] != DBNull.Value)
						{
							item.CountryCode = Convert.ToString(dr["CountryCode"]);
						}
						if (dr["CommonName"] != null && dr["CommonName"] != DBNull.Value)
						{
							item.CommonName = Convert.ToString(dr["CommonName"]);
						}
						if (dr["FormalName"] != null && dr["FormalName"] != DBNull.Value)
						{
							item.FormalName = Convert.ToString(dr["FormalName"]);
						}
						if (dr["CountryType"] != null && dr["CountryType"] != DBNull.Value)
						{
							item.CountryType = Convert.ToString(dr["CountryType"]);
						}
						if (dr["CountrySubType"] != null && dr["CountrySubType"] != DBNull.Value)
						{
							item.CountrySubType = Convert.ToString(dr["CountrySubType"]);
						}
						if (dr["Sovereignty"] != null && dr["Sovereignty"] != DBNull.Value)
						{
							item.Sovereignty = Convert.ToString(dr["Sovereignty"]);
						}
						if (dr["Capital"] != null && dr["Capital"] != DBNull.Value)
						{
							item.Capital = Convert.ToString(dr["Capital"]);
						}
						if (dr["CurrencyCode"] != null && dr["CurrencyCode"] != DBNull.Value)
						{
							item.CurrencyCode = Convert.ToString(dr["CurrencyCode"]);
						}
						if (dr["CurrencyName"] != null && dr["CurrencyName"] != DBNull.Value)
						{
							item.CurrencyName = Convert.ToString(dr["CurrencyName"]);
						}
						if (dr["TelephoneCode"] != null && dr["TelephoneCode"] != DBNull.Value)
						{
							item.TelephoneCode = Convert.ToString(dr["TelephoneCode"]);
						}
						if (dr["CountryCode3"] != null && dr["CountryCode3"] != DBNull.Value)
						{
							item.CountryCode3 = Convert.ToString(dr["CountryCode3"]);
						}
						if (dr["CountryNumber"] != null && dr["CountryNumber"] != DBNull.Value)
						{
							item.CountryNumber = Convert.ToString(dr["CountryNumber"]);
						}
						if (dr["InternetCountryCode"] != null && dr["InternetCountryCode"] != DBNull.Value)
						{
							item.InternetCountryCode = Convert.ToString(dr["InternetCountryCode"]);
						}
						if (dr["SortOrder"] != null && dr["SortOrder"] != DBNull.Value)
						{
							item.SortOrder = Convert.ToInt32(dr["SortOrder"]);
						}
						if (dr["IsPublished"] != null && dr["IsPublished"] != DBNull.Value)
						{
							item.IsPublished = Convert.ToBoolean(dr["IsPublished"]);
						}
						if (dr["Flags"] != null && dr["Flags"] != DBNull.Value)
						{
							item.Flags = Convert.ToString(dr["Flags"]);
						}
						if (dr["IsDeleted"] != null && dr["IsDeleted"] != DBNull.Value)
						{
							item.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
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

		public GsCountry GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsCountry] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsCountry>(ds);
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
		/// Thêm mới GsCountry vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsCountry _GsCountry)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsCountry](Id, CountryCode, CommonName, FormalName, CountryType, CountrySubType, Sovereignty, Capital, CurrencyCode, CurrencyName, TelephoneCode, CountryCode3, CountryNumber, InternetCountryCode, SortOrder, IsPublished, Flags, IsDeleted) VALUES(@Id, @CountryCode, @CommonName, @FormalName, @CountryType, @CountrySubType, @Sovereignty, @Capital, @CurrencyCode, @CurrencyName, @TelephoneCode, @CountryCode3, @CountryNumber, @InternetCountryCode, @SortOrder, @IsPublished, @Flags, @IsDeleted)", 
					"@Id",  _GsCountry.Id, 
					"@CountryCode",  _GsCountry.CountryCode, 
					"@CommonName",  _GsCountry.CommonName, 
					"@FormalName",  _GsCountry.FormalName, 
					"@CountryType",  _GsCountry.CountryType, 
					"@CountrySubType",  _GsCountry.CountrySubType, 
					"@Sovereignty",  _GsCountry.Sovereignty, 
					"@Capital",  _GsCountry.Capital, 
					"@CurrencyCode",  _GsCountry.CurrencyCode, 
					"@CurrencyName",  _GsCountry.CurrencyName, 
					"@TelephoneCode",  _GsCountry.TelephoneCode, 
					"@CountryCode3",  _GsCountry.CountryCode3, 
					"@CountryNumber",  _GsCountry.CountryNumber, 
					"@InternetCountryCode",  _GsCountry.InternetCountryCode, 
					"@SortOrder",  _GsCountry.SortOrder, 
					"@IsPublished",  _GsCountry.IsPublished, 
					"@Flags",  _GsCountry.Flags, 
					"@IsDeleted",  _GsCountry.IsDeleted);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsCountry vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsCountry> _GsCountrys)
		{
			foreach (GsCountry item in _GsCountrys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsCountry vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsCountry _GsCountry, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCountry] SET Id=@Id, CountryCode=@CountryCode, CommonName=@CommonName, FormalName=@FormalName, CountryType=@CountryType, CountrySubType=@CountrySubType, Sovereignty=@Sovereignty, Capital=@Capital, CurrencyCode=@CurrencyCode, CurrencyName=@CurrencyName, TelephoneCode=@TelephoneCode, CountryCode3=@CountryCode3, CountryNumber=@CountryNumber, InternetCountryCode=@InternetCountryCode, SortOrder=@SortOrder, IsPublished=@IsPublished, Flags=@Flags, IsDeleted=@IsDeleted WHERE Id=@Id", 
					"@Id",  _GsCountry.Id, 
					"@CountryCode",  _GsCountry.CountryCode, 
					"@CommonName",  _GsCountry.CommonName, 
					"@FormalName",  _GsCountry.FormalName, 
					"@CountryType",  _GsCountry.CountryType, 
					"@CountrySubType",  _GsCountry.CountrySubType, 
					"@Sovereignty",  _GsCountry.Sovereignty, 
					"@Capital",  _GsCountry.Capital, 
					"@CurrencyCode",  _GsCountry.CurrencyCode, 
					"@CurrencyName",  _GsCountry.CurrencyName, 
					"@TelephoneCode",  _GsCountry.TelephoneCode, 
					"@CountryCode3",  _GsCountry.CountryCode3, 
					"@CountryNumber",  _GsCountry.CountryNumber, 
					"@InternetCountryCode",  _GsCountry.InternetCountryCode, 
					"@SortOrder",  _GsCountry.SortOrder, 
					"@IsPublished",  _GsCountry.IsPublished, 
					"@Flags",  _GsCountry.Flags, 
					"@IsDeleted",  _GsCountry.IsDeleted, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsCountry vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsCountry _GsCountry)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCountry] SET CountryCode=@CountryCode, CommonName=@CommonName, FormalName=@FormalName, CountryType=@CountryType, CountrySubType=@CountrySubType, Sovereignty=@Sovereignty, Capital=@Capital, CurrencyCode=@CurrencyCode, CurrencyName=@CurrencyName, TelephoneCode=@TelephoneCode, CountryCode3=@CountryCode3, CountryNumber=@CountryNumber, InternetCountryCode=@InternetCountryCode, SortOrder=@SortOrder, IsPublished=@IsPublished, Flags=@Flags, IsDeleted=@IsDeleted WHERE Id=@Id", 
					"@CountryCode",  _GsCountry.CountryCode, 
					"@CommonName",  _GsCountry.CommonName, 
					"@FormalName",  _GsCountry.FormalName, 
					"@CountryType",  _GsCountry.CountryType, 
					"@CountrySubType",  _GsCountry.CountrySubType, 
					"@Sovereignty",  _GsCountry.Sovereignty, 
					"@Capital",  _GsCountry.Capital, 
					"@CurrencyCode",  _GsCountry.CurrencyCode, 
					"@CurrencyName",  _GsCountry.CurrencyName, 
					"@TelephoneCode",  _GsCountry.TelephoneCode, 
					"@CountryCode3",  _GsCountry.CountryCode3, 
					"@CountryNumber",  _GsCountry.CountryNumber, 
					"@InternetCountryCode",  _GsCountry.InternetCountryCode, 
					"@SortOrder",  _GsCountry.SortOrder, 
					"@IsPublished",  _GsCountry.IsPublished, 
					"@Flags",  _GsCountry.Flags, 
					"@IsDeleted",  _GsCountry.IsDeleted, 
					"@Id", _GsCountry.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsCountry vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsCountry> _GsCountrys)
		{
			foreach (GsCountry item in _GsCountrys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsCountry vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsCountry _GsCountry, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCountry] SET Id=@Id, CountryCode=@CountryCode, CommonName=@CommonName, FormalName=@FormalName, CountryType=@CountryType, CountrySubType=@CountrySubType, Sovereignty=@Sovereignty, Capital=@Capital, CurrencyCode=@CurrencyCode, CurrencyName=@CurrencyName, TelephoneCode=@TelephoneCode, CountryCode3=@CountryCode3, CountryNumber=@CountryNumber, InternetCountryCode=@InternetCountryCode, SortOrder=@SortOrder, IsPublished=@IsPublished, Flags=@Flags, IsDeleted=@IsDeleted "+ condition, 
					"@Id",  _GsCountry.Id, 
					"@CountryCode",  _GsCountry.CountryCode, 
					"@CommonName",  _GsCountry.CommonName, 
					"@FormalName",  _GsCountry.FormalName, 
					"@CountryType",  _GsCountry.CountryType, 
					"@CountrySubType",  _GsCountry.CountrySubType, 
					"@Sovereignty",  _GsCountry.Sovereignty, 
					"@Capital",  _GsCountry.Capital, 
					"@CurrencyCode",  _GsCountry.CurrencyCode, 
					"@CurrencyName",  _GsCountry.CurrencyName, 
					"@TelephoneCode",  _GsCountry.TelephoneCode, 
					"@CountryCode3",  _GsCountry.CountryCode3, 
					"@CountryNumber",  _GsCountry.CountryNumber, 
					"@InternetCountryCode",  _GsCountry.InternetCountryCode, 
					"@SortOrder",  _GsCountry.SortOrder, 
					"@IsPublished",  _GsCountry.IsPublished, 
					"@Flags",  _GsCountry.Flags, 
					"@IsDeleted",  _GsCountry.IsDeleted);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsCountry trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCountry] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCountry trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsCountry _GsCountry)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCountry] WHERE Id=@Id",
					"@Id", _GsCountry.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCountry trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCountry] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCountry trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsCountry> _GsCountrys)
		{
			foreach (GsCountry item in _GsCountrys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
