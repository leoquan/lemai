using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdistrictghsv:IGExpdistrictghsv
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdistrictghsv(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDistrictGHSV từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictGHSV]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDistrictGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictGHSV] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDistrictGHSV từ Database
		/// </summary>
		public List<GExpDistrictGHSV> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictGHSV]");
				List<GExpDistrictGHSV> items = new List<GExpDistrictGHSV>();
				GExpDistrictGHSV item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrictGHSV();
					if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
					{
						item.districtCode = Convert.ToString(dr["districtCode"]);
					}
					if (dr["districtName"] != null && dr["districtName"] != DBNull.Value)
					{
						item.districtName = Convert.ToString(dr["districtName"]);
					}
					if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
					{
						item.provinceCode = Convert.ToString(dr["provinceCode"]);
					}
					if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
					{
						item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
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
		/// Lấy danh sách GExpDistrictGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDistrictGHSV> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrictGHSV] A "+ condition,  parameters);
				List<GExpDistrictGHSV> items = new List<GExpDistrictGHSV>();
				GExpDistrictGHSV item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrictGHSV();
					if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
					{
						item.districtCode = Convert.ToString(dr["districtCode"]);
					}
					if (dr["districtName"] != null && dr["districtName"] != DBNull.Value)
					{
						item.districtName = Convert.ToString(dr["districtName"]);
					}
					if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
					{
						item.provinceCode = Convert.ToString(dr["provinceCode"]);
					}
					if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
					{
						item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
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

		public List<GExpDistrictGHSV> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrictGHSV] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDistrictGHSV] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDistrictGHSV>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDistrictGHSV từ Database
		/// </summary>
		public GExpDistrictGHSV GetObject(string schema, String districtCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictGHSV] where districtCode=@districtCode",
					"@districtCode", districtCode);
				if (ds.Rows.Count > 0)
				{
					GExpDistrictGHSV item=new GExpDistrictGHSV();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
						{
							item.districtCode = Convert.ToString(dr["districtCode"]);
						}
						if (dr["districtName"] != null && dr["districtName"] != DBNull.Value)
						{
							item.districtName = Convert.ToString(dr["districtName"]);
						}
						if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
						{
							item.provinceCode = Convert.ToString(dr["provinceCode"]);
						}
						if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
						{
							item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
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
		/// Lấy một GExpDistrictGHSV đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDistrictGHSV GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrictGHSV] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDistrictGHSV item=new GExpDistrictGHSV();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
						{
							item.districtCode = Convert.ToString(dr["districtCode"]);
						}
						if (dr["districtName"] != null && dr["districtName"] != DBNull.Value)
						{
							item.districtName = Convert.ToString(dr["districtName"]);
						}
						if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
						{
							item.provinceCode = Convert.ToString(dr["provinceCode"]);
						}
						if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
						{
							item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
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

		public GExpDistrictGHSV GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrictGHSV] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDistrictGHSV>(ds);
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
		/// Thêm mới GExpDistrictGHSV vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDistrictGHSV _GExpDistrictGHSV)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDistrictGHSV](districtCode, districtName, provinceCode, DistrictID) VALUES(@districtCode, @districtName, @provinceCode, @DistrictID)", 
					"@districtCode",  _GExpDistrictGHSV.districtCode, 
					"@districtName",  _GExpDistrictGHSV.districtName, 
					"@provinceCode",  _GExpDistrictGHSV.provinceCode, 
					"@DistrictID",  _GExpDistrictGHSV.DistrictID);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDistrictGHSV vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDistrictGHSV> _GExpDistrictGHSVs)
		{
			foreach (GExpDistrictGHSV item in _GExpDistrictGHSVs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDistrictGHSV _GExpDistrictGHSV, String districtCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictGHSV] SET districtCode=@districtCode, districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID WHERE districtCode=@districtCode", 
					"@districtCode",  _GExpDistrictGHSV.districtCode, 
					"@districtName",  _GExpDistrictGHSV.districtName, 
					"@provinceCode",  _GExpDistrictGHSV.provinceCode, 
					"@DistrictID",  _GExpDistrictGHSV.DistrictID, 
					"@districtCode", districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictGHSV vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDistrictGHSV _GExpDistrictGHSV)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictGHSV] SET districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID WHERE districtCode=@districtCode", 
					"@districtName",  _GExpDistrictGHSV.districtName, 
					"@provinceCode",  _GExpDistrictGHSV.provinceCode, 
					"@DistrictID",  _GExpDistrictGHSV.DistrictID, 
					"@districtCode", _GExpDistrictGHSV.districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDistrictGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDistrictGHSV> _GExpDistrictGHSVs)
		{
			foreach (GExpDistrictGHSV item in _GExpDistrictGHSVs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictGHSV vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDistrictGHSV _GExpDistrictGHSV, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictGHSV] SET districtCode=@districtCode, districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID "+ condition, 
					"@districtCode",  _GExpDistrictGHSV.districtCode, 
					"@districtName",  _GExpDistrictGHSV.districtName, 
					"@provinceCode",  _GExpDistrictGHSV.provinceCode, 
					"@DistrictID",  _GExpDistrictGHSV.DistrictID);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDistrictGHSV trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String districtCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictGHSV] WHERE districtCode=@districtCode",
					"@districtCode", districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictGHSV trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDistrictGHSV _GExpDistrictGHSV)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictGHSV] WHERE districtCode=@districtCode",
					"@districtCode", _GExpDistrictGHSV.districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictGHSV trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictGHSV] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictGHSV trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDistrictGHSV> _GExpDistrictGHSVs)
		{
			foreach (GExpDistrictGHSV item in _GExpDistrictGHSVs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
