using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdistrictvnp:IGExpdistrictvnp
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdistrictvnp(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDistrictVNP từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVNP]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDistrictVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVNP] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDistrictVNP từ Database
		/// </summary>
		public List<GExpDistrictVNP> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVNP]");
				List<GExpDistrictVNP> items = new List<GExpDistrictVNP>();
				GExpDistrictVNP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrictVNP();
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
		/// Lấy danh sách GExpDistrictVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDistrictVNP> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrictVNP] A "+ condition,  parameters);
				List<GExpDistrictVNP> items = new List<GExpDistrictVNP>();
				GExpDistrictVNP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrictVNP();
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

		public List<GExpDistrictVNP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrictVNP] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDistrictVNP] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDistrictVNP>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDistrictVNP từ Database
		/// </summary>
		public GExpDistrictVNP GetObject(string schema, String districtCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVNP] where districtCode=@districtCode",
					"@districtCode", districtCode);
				if (ds.Rows.Count > 0)
				{
					GExpDistrictVNP item=new GExpDistrictVNP();
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
		/// Lấy một GExpDistrictVNP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDistrictVNP GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrictVNP] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDistrictVNP item=new GExpDistrictVNP();
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

		public GExpDistrictVNP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrictVNP] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDistrictVNP>(ds);
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
		/// Thêm mới GExpDistrictVNP vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDistrictVNP _GExpDistrictVNP)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDistrictVNP](districtCode, districtName, provinceCode, DistrictID) VALUES(@districtCode, @districtName, @provinceCode, @DistrictID)", 
					"@districtCode",  _GExpDistrictVNP.districtCode, 
					"@districtName",  _GExpDistrictVNP.districtName, 
					"@provinceCode",  _GExpDistrictVNP.provinceCode, 
					"@DistrictID",  _GExpDistrictVNP.DistrictID);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDistrictVNP vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDistrictVNP> _GExpDistrictVNPs)
		{
			foreach (GExpDistrictVNP item in _GExpDistrictVNPs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDistrictVNP _GExpDistrictVNP, String districtCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictVNP] SET districtCode=@districtCode, districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID WHERE districtCode=@districtCode", 
					"@districtCode",  _GExpDistrictVNP.districtCode, 
					"@districtName",  _GExpDistrictVNP.districtName, 
					"@provinceCode",  _GExpDistrictVNP.provinceCode, 
					"@DistrictID",  _GExpDistrictVNP.DistrictID, 
					"@districtCode", districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictVNP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDistrictVNP _GExpDistrictVNP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictVNP] SET districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID WHERE districtCode=@districtCode", 
					"@districtName",  _GExpDistrictVNP.districtName, 
					"@provinceCode",  _GExpDistrictVNP.provinceCode, 
					"@DistrictID",  _GExpDistrictVNP.DistrictID, 
					"@districtCode", _GExpDistrictVNP.districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDistrictVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDistrictVNP> _GExpDistrictVNPs)
		{
			foreach (GExpDistrictVNP item in _GExpDistrictVNPs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictVNP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDistrictVNP _GExpDistrictVNP, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictVNP] SET districtCode=@districtCode, districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID "+ condition, 
					"@districtCode",  _GExpDistrictVNP.districtCode, 
					"@districtName",  _GExpDistrictVNP.districtName, 
					"@provinceCode",  _GExpDistrictVNP.provinceCode, 
					"@DistrictID",  _GExpDistrictVNP.DistrictID);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDistrictVNP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String districtCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictVNP] WHERE districtCode=@districtCode",
					"@districtCode", districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictVNP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDistrictVNP _GExpDistrictVNP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictVNP] WHERE districtCode=@districtCode",
					"@districtCode", _GExpDistrictVNP.districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictVNP trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictVNP] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictVNP trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDistrictVNP> _GExpDistrictVNPs)
		{
			foreach (GExpDistrictVNP item in _GExpDistrictVNPs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
