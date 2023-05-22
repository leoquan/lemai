using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdistrict:IGExpdistrict
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdistrict(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDistrict từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrict]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDistrict từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrict] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDistrict từ Database
		/// </summary>
		public List<GExpDistrict> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrict]");
				List<GExpDistrict> items = new List<GExpDistrict>();
				GExpDistrict item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrict();
					if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
					{
						item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
					}
					if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
					{
						item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
					}
					if (dr["DistrictName"] != null && dr["DistrictName"] != DBNull.Value)
					{
						item.DistrictName = Convert.ToString(dr["DistrictName"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["SupportType"] != null && dr["SupportType"] != DBNull.Value)
					{
						item.SupportType = Convert.ToInt32(dr["SupportType"]);
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
		/// Lấy danh sách GExpDistrict từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDistrict> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrict] A "+ condition,  parameters);
				List<GExpDistrict> items = new List<GExpDistrict>();
				GExpDistrict item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrict();
					if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
					{
						item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
					}
					if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
					{
						item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
					}
					if (dr["DistrictName"] != null && dr["DistrictName"] != DBNull.Value)
					{
						item.DistrictName = Convert.ToString(dr["DistrictName"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["SupportType"] != null && dr["SupportType"] != DBNull.Value)
					{
						item.SupportType = Convert.ToInt32(dr["SupportType"]);
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

		public List<GExpDistrict> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrict] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDistrict] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDistrict>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDistrict từ Database
		/// </summary>
		public GExpDistrict GetObject(string schema, Int32 DistrictID)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrict] where DistrictID=@DistrictID",
					"@DistrictID", DistrictID);
				if (ds.Rows.Count > 0)
				{
					GExpDistrict item=new GExpDistrict();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
						{
							item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
						}
						if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
						{
							item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
						}
						if (dr["DistrictName"] != null && dr["DistrictName"] != DBNull.Value)
						{
							item.DistrictName = Convert.ToString(dr["DistrictName"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToInt32(dr["Type"]);
						}
						if (dr["SupportType"] != null && dr["SupportType"] != DBNull.Value)
						{
							item.SupportType = Convert.ToInt32(dr["SupportType"]);
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
		/// Lấy một GExpDistrict đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDistrict GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrict] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDistrict item=new GExpDistrict();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
						{
							item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
						}
						if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
						{
							item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
						}
						if (dr["DistrictName"] != null && dr["DistrictName"] != DBNull.Value)
						{
							item.DistrictName = Convert.ToString(dr["DistrictName"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToInt32(dr["Type"]);
						}
						if (dr["SupportType"] != null && dr["SupportType"] != DBNull.Value)
						{
							item.SupportType = Convert.ToInt32(dr["SupportType"]);
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

		public GExpDistrict GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrict] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDistrict>(ds);
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
		/// Thêm mới GExpDistrict vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDistrict _GExpDistrict)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDistrict](DistrictID, ProvinceID, DistrictName, Code, Type, SupportType) VALUES(@DistrictID, @ProvinceID, @DistrictName, @Code, @Type, @SupportType)", 
					"@DistrictID",  _GExpDistrict.DistrictID, 
					"@ProvinceID",  _GExpDistrict.ProvinceID, 
					"@DistrictName",  _GExpDistrict.DistrictName, 
					"@Code",  _GExpDistrict.Code, 
					"@Type",  _GExpDistrict.Type, 
					"@SupportType",  _GExpDistrict.SupportType);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDistrict vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDistrict> _GExpDistricts)
		{
			foreach (GExpDistrict item in _GExpDistricts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrict vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDistrict _GExpDistrict, Int32 DistrictID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrict] SET DistrictID=@DistrictID, ProvinceID=@ProvinceID, DistrictName=@DistrictName, Code=@Code, Type=@Type, SupportType=@SupportType WHERE DistrictID=@DistrictID", 
					"@DistrictID",  _GExpDistrict.DistrictID, 
					"@ProvinceID",  _GExpDistrict.ProvinceID, 
					"@DistrictName",  _GExpDistrict.DistrictName, 
					"@Code",  _GExpDistrict.Code, 
					"@Type",  _GExpDistrict.Type, 
					"@SupportType",  _GExpDistrict.SupportType, 
					"@DistrictID", DistrictID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrict vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDistrict _GExpDistrict)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrict] SET ProvinceID=@ProvinceID, DistrictName=@DistrictName, Code=@Code, Type=@Type, SupportType=@SupportType WHERE DistrictID=@DistrictID", 
					"@ProvinceID",  _GExpDistrict.ProvinceID, 
					"@DistrictName",  _GExpDistrict.DistrictName, 
					"@Code",  _GExpDistrict.Code, 
					"@Type",  _GExpDistrict.Type, 
					"@SupportType",  _GExpDistrict.SupportType, 
					"@DistrictID", _GExpDistrict.DistrictID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDistrict vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDistrict> _GExpDistricts)
		{
			foreach (GExpDistrict item in _GExpDistricts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrict vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDistrict _GExpDistrict, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrict] SET DistrictID=@DistrictID, ProvinceID=@ProvinceID, DistrictName=@DistrictName, Code=@Code, Type=@Type, SupportType=@SupportType "+ condition, 
					"@DistrictID",  _GExpDistrict.DistrictID, 
					"@ProvinceID",  _GExpDistrict.ProvinceID, 
					"@DistrictName",  _GExpDistrict.DistrictName, 
					"@Code",  _GExpDistrict.Code, 
					"@Type",  _GExpDistrict.Type, 
					"@SupportType",  _GExpDistrict.SupportType);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDistrict trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 DistrictID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrict] WHERE DistrictID=@DistrictID",
					"@DistrictID", DistrictID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrict trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDistrict _GExpDistrict)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrict] WHERE DistrictID=@DistrictID",
					"@DistrictID", _GExpDistrict.DistrictID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrict trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrict] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrict trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDistrict> _GExpDistricts)
		{
			foreach (GExpDistrict item in _GExpDistricts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
