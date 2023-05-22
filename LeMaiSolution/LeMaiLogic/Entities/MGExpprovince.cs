using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprovince:IGExpprovince
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprovince(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProvince từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvince]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProvince từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvince] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProvince từ Database
		/// </summary>
		public List<GExpProvince> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvince]");
				List<GExpProvince> items = new List<GExpProvince>();
				GExpProvince item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvince();
					if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
					{
						item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
					}
					if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
					{
						item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["ZoneCode"] != null && dr["ZoneCode"] != DBNull.Value)
					{
						item.ZoneCode = Convert.ToString(dr["ZoneCode"]);
					}
					if (dr["Delay"] != null && dr["Delay"] != DBNull.Value)
					{
						item.Delay = Convert.ToBoolean(dr["Delay"]);
					}
					if (dr["Short"] != null && dr["Short"] != DBNull.Value)
					{
						item.Short = Convert.ToString(dr["Short"]);
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
		/// Lấy danh sách GExpProvince từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProvince> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvince] A "+ condition,  parameters);
				List<GExpProvince> items = new List<GExpProvince>();
				GExpProvince item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvince();
					if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
					{
						item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
					}
					if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
					{
						item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["ZoneCode"] != null && dr["ZoneCode"] != DBNull.Value)
					{
						item.ZoneCode = Convert.ToString(dr["ZoneCode"]);
					}
					if (dr["Delay"] != null && dr["Delay"] != DBNull.Value)
					{
						item.Delay = Convert.ToBoolean(dr["Delay"]);
					}
					if (dr["Short"] != null && dr["Short"] != DBNull.Value)
					{
						item.Short = Convert.ToString(dr["Short"]);
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

		public List<GExpProvince> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvince] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProvince] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProvince>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProvince từ Database
		/// </summary>
		public GExpProvince GetObject(string schema, Int32 ProvinceID)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvince] where ProvinceID=@ProvinceID",
					"@ProvinceID", ProvinceID);
				if (ds.Rows.Count > 0)
				{
					GExpProvince item=new GExpProvince();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
						{
							item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
						}
						if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
						{
							item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["ZoneCode"] != null && dr["ZoneCode"] != DBNull.Value)
						{
							item.ZoneCode = Convert.ToString(dr["ZoneCode"]);
						}
						if (dr["Delay"] != null && dr["Delay"] != DBNull.Value)
						{
							item.Delay = Convert.ToBoolean(dr["Delay"]);
						}
						if (dr["Short"] != null && dr["Short"] != DBNull.Value)
						{
							item.Short = Convert.ToString(dr["Short"]);
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
		/// Lấy một GExpProvince đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProvince GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvince] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProvince item=new GExpProvince();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
						{
							item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
						}
						if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
						{
							item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["ZoneCode"] != null && dr["ZoneCode"] != DBNull.Value)
						{
							item.ZoneCode = Convert.ToString(dr["ZoneCode"]);
						}
						if (dr["Delay"] != null && dr["Delay"] != DBNull.Value)
						{
							item.Delay = Convert.ToBoolean(dr["Delay"]);
						}
						if (dr["Short"] != null && dr["Short"] != DBNull.Value)
						{
							item.Short = Convert.ToString(dr["Short"]);
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

		public GExpProvince GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvince] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProvince>(ds);
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
		/// Thêm mới GExpProvince vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProvince _GExpProvince)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProvince](ProvinceID, ProvinceName, Code, ZoneCode, Delay, Short) VALUES(@ProvinceID, @ProvinceName, @Code, @ZoneCode, @Delay, @Short)", 
					"@ProvinceID",  _GExpProvince.ProvinceID, 
					"@ProvinceName",  _GExpProvince.ProvinceName, 
					"@Code",  _GExpProvince.Code, 
					"@ZoneCode",  _GExpProvince.ZoneCode, 
					"@Delay",  _GExpProvince.Delay, 
					"@Short",  _GExpProvince.Short);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProvince vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProvince> _GExpProvinces)
		{
			foreach (GExpProvince item in _GExpProvinces)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvince vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProvince _GExpProvince, Int32 ProvinceID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvince] SET ProvinceID=@ProvinceID, ProvinceName=@ProvinceName, Code=@Code, ZoneCode=@ZoneCode, Delay=@Delay, Short=@Short WHERE ProvinceID=@ProvinceID", 
					"@ProvinceID",  _GExpProvince.ProvinceID, 
					"@ProvinceName",  _GExpProvince.ProvinceName, 
					"@Code",  _GExpProvince.Code, 
					"@ZoneCode",  _GExpProvince.ZoneCode, 
					"@Delay",  _GExpProvince.Delay, 
					"@Short",  _GExpProvince.Short, 
					"@ProvinceID", ProvinceID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProvince vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProvince _GExpProvince)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvince] SET ProvinceName=@ProvinceName, Code=@Code, ZoneCode=@ZoneCode, Delay=@Delay, Short=@Short WHERE ProvinceID=@ProvinceID", 
					"@ProvinceName",  _GExpProvince.ProvinceName, 
					"@Code",  _GExpProvince.Code, 
					"@ZoneCode",  _GExpProvince.ZoneCode, 
					"@Delay",  _GExpProvince.Delay, 
					"@Short",  _GExpProvince.Short, 
					"@ProvinceID", _GExpProvince.ProvinceID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProvince vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProvince> _GExpProvinces)
		{
			foreach (GExpProvince item in _GExpProvinces)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvince vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProvince _GExpProvince, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvince] SET ProvinceID=@ProvinceID, ProvinceName=@ProvinceName, Code=@Code, ZoneCode=@ZoneCode, Delay=@Delay, Short=@Short "+ condition, 
					"@ProvinceID",  _GExpProvince.ProvinceID, 
					"@ProvinceName",  _GExpProvince.ProvinceName, 
					"@Code",  _GExpProvince.Code, 
					"@ZoneCode",  _GExpProvince.ZoneCode, 
					"@Delay",  _GExpProvince.Delay, 
					"@Short",  _GExpProvince.Short);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProvince trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 ProvinceID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvince] WHERE ProvinceID=@ProvinceID",
					"@ProvinceID", ProvinceID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvince trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProvince _GExpProvince)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvince] WHERE ProvinceID=@ProvinceID",
					"@ProvinceID", _GExpProvince.ProvinceID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvince trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvince] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvince trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProvince> _GExpProvinces)
		{
			foreach (GExpProvince item in _GExpProvinces)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
