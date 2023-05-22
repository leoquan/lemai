using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpward:IGExpward
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpward(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpWard từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWard]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpWard từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWard] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpWard từ Database
		/// </summary>
		public List<GExpWard> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWard]");
				List<GExpWard> items = new List<GExpWard>();
				GExpWard item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWard();
					if (dr["WardId"] != null && dr["WardId"] != DBNull.Value)
					{
						item.WardId = Convert.ToString(dr["WardId"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
					{
						item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
					}
					if (dr["WardName"] != null && dr["WardName"] != DBNull.Value)
					{
						item.WardName = Convert.ToString(dr["WardName"]);
					}
					if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
					{
						item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
					}
					if (dr["SearchKey"] != null && dr["SearchKey"] != DBNull.Value)
					{
						item.SearchKey = Convert.ToString(dr["SearchKey"]);
					}
					if (dr["DisplayValue"] != null && dr["DisplayValue"] != DBNull.Value)
					{
						item.DisplayValue = Convert.ToString(dr["DisplayValue"]);
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
		/// Lấy danh sách GExpWard từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpWard> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWard] A "+ condition,  parameters);
				List<GExpWard> items = new List<GExpWard>();
				GExpWard item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWard();
					if (dr["WardId"] != null && dr["WardId"] != DBNull.Value)
					{
						item.WardId = Convert.ToString(dr["WardId"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
					{
						item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
					}
					if (dr["WardName"] != null && dr["WardName"] != DBNull.Value)
					{
						item.WardName = Convert.ToString(dr["WardName"]);
					}
					if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
					{
						item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
					}
					if (dr["SearchKey"] != null && dr["SearchKey"] != DBNull.Value)
					{
						item.SearchKey = Convert.ToString(dr["SearchKey"]);
					}
					if (dr["DisplayValue"] != null && dr["DisplayValue"] != DBNull.Value)
					{
						item.DisplayValue = Convert.ToString(dr["DisplayValue"]);
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

		public List<GExpWard> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWard] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpWard] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpWard>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpWard từ Database
		/// </summary>
		public GExpWard GetObject(string schema, String WardId)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWard] where WardId=@WardId",
					"@WardId", WardId);
				if (ds.Rows.Count > 0)
				{
					GExpWard item=new GExpWard();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["WardId"] != null && dr["WardId"] != DBNull.Value)
						{
							item.WardId = Convert.ToString(dr["WardId"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
						{
							item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
						}
						if (dr["WardName"] != null && dr["WardName"] != DBNull.Value)
						{
							item.WardName = Convert.ToString(dr["WardName"]);
						}
						if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
						{
							item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
						}
						if (dr["SearchKey"] != null && dr["SearchKey"] != DBNull.Value)
						{
							item.SearchKey = Convert.ToString(dr["SearchKey"]);
						}
						if (dr["DisplayValue"] != null && dr["DisplayValue"] != DBNull.Value)
						{
							item.DisplayValue = Convert.ToString(dr["DisplayValue"]);
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
		/// Lấy một GExpWard đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpWard GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWard] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpWard item=new GExpWard();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["WardId"] != null && dr["WardId"] != DBNull.Value)
						{
							item.WardId = Convert.ToString(dr["WardId"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
						{
							item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
						}
						if (dr["WardName"] != null && dr["WardName"] != DBNull.Value)
						{
							item.WardName = Convert.ToString(dr["WardName"]);
						}
						if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
						{
							item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
						}
						if (dr["SearchKey"] != null && dr["SearchKey"] != DBNull.Value)
						{
							item.SearchKey = Convert.ToString(dr["SearchKey"]);
						}
						if (dr["DisplayValue"] != null && dr["DisplayValue"] != DBNull.Value)
						{
							item.DisplayValue = Convert.ToString(dr["DisplayValue"]);
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

		public GExpWard GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWard] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpWard>(ds);
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
		/// Thêm mới GExpWard vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpWard _GExpWard)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpWard](WardId, Code, DistrictID, WardName, ProvinceID, SearchKey, DisplayValue) VALUES(@WardId, @Code, @DistrictID, @WardName, @ProvinceID, @SearchKey, @DisplayValue)", 
					"@WardId",  _GExpWard.WardId, 
					"@Code",  _GExpWard.Code, 
					"@DistrictID",  _GExpWard.DistrictID, 
					"@WardName",  _GExpWard.WardName, 
					"@ProvinceID",  _GExpWard.ProvinceID, 
					"@SearchKey",  _GExpWard.SearchKey, 
					"@DisplayValue",  _GExpWard.DisplayValue);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpWard vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpWard> _GExpWards)
		{
			foreach (GExpWard item in _GExpWards)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWard vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpWard _GExpWard, String WardId)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWard] SET WardId=@WardId, Code=@Code, DistrictID=@DistrictID, WardName=@WardName, ProvinceID=@ProvinceID, SearchKey=@SearchKey, DisplayValue=@DisplayValue WHERE WardId=@WardId", 
					"@WardId",  _GExpWard.WardId, 
					"@Code",  _GExpWard.Code, 
					"@DistrictID",  _GExpWard.DistrictID, 
					"@WardName",  _GExpWard.WardName, 
					"@ProvinceID",  _GExpWard.ProvinceID, 
					"@SearchKey",  _GExpWard.SearchKey, 
					"@DisplayValue",  _GExpWard.DisplayValue, 
					"@WardId", WardId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpWard vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpWard _GExpWard)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWard] SET Code=@Code, DistrictID=@DistrictID, WardName=@WardName, ProvinceID=@ProvinceID, SearchKey=@SearchKey, DisplayValue=@DisplayValue WHERE WardId=@WardId", 
					"@Code",  _GExpWard.Code, 
					"@DistrictID",  _GExpWard.DistrictID, 
					"@WardName",  _GExpWard.WardName, 
					"@ProvinceID",  _GExpWard.ProvinceID, 
					"@SearchKey",  _GExpWard.SearchKey, 
					"@DisplayValue",  _GExpWard.DisplayValue, 
					"@WardId", _GExpWard.WardId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpWard vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpWard> _GExpWards)
		{
			foreach (GExpWard item in _GExpWards)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWard vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpWard _GExpWard, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWard] SET WardId=@WardId, Code=@Code, DistrictID=@DistrictID, WardName=@WardName, ProvinceID=@ProvinceID, SearchKey=@SearchKey, DisplayValue=@DisplayValue "+ condition, 
					"@WardId",  _GExpWard.WardId, 
					"@Code",  _GExpWard.Code, 
					"@DistrictID",  _GExpWard.DistrictID, 
					"@WardName",  _GExpWard.WardName, 
					"@ProvinceID",  _GExpWard.ProvinceID, 
					"@SearchKey",  _GExpWard.SearchKey, 
					"@DisplayValue",  _GExpWard.DisplayValue);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpWard trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String WardId)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWard] WHERE WardId=@WardId",
					"@WardId", WardId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWard trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpWard _GExpWard)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWard] WHERE WardId=@WardId",
					"@WardId", _GExpWard.WardId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWard trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWard] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWard trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpWard> _GExpWards)
		{
			foreach (GExpWard item in _GExpWards)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
