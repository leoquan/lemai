using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdistrictvn:IGExpdistrictvn
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdistrictvn(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDistrictVN từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVN]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDistrictVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVN] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDistrictVN từ Database
		/// </summary>
		public List<GExpDistrictVN> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVN]");
				List<GExpDistrictVN> items = new List<GExpDistrictVN>();
				GExpDistrictVN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrictVN();
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
		/// Lấy danh sách GExpDistrictVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDistrictVN> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrictVN] A "+ condition,  parameters);
				List<GExpDistrictVN> items = new List<GExpDistrictVN>();
				GExpDistrictVN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrictVN();
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

		public List<GExpDistrictVN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrictVN] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDistrictVN] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDistrictVN>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDistrictVN từ Database
		/// </summary>
		public GExpDistrictVN GetObject(string schema, String districtCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVN] where districtCode=@districtCode",
					"@districtCode", districtCode);
				if (ds.Rows.Count > 0)
				{
					GExpDistrictVN item=new GExpDistrictVN();
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
		/// Lấy một GExpDistrictVN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDistrictVN GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrictVN] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDistrictVN item=new GExpDistrictVN();
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

		public GExpDistrictVN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrictVN] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDistrictVN>(ds);
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
		/// Thêm mới GExpDistrictVN vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDistrictVN _GExpDistrictVN)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDistrictVN](districtCode, districtName, provinceCode, DistrictID) VALUES(@districtCode, @districtName, @provinceCode, @DistrictID)", 
					"@districtCode",  _GExpDistrictVN.districtCode, 
					"@districtName",  _GExpDistrictVN.districtName, 
					"@provinceCode",  _GExpDistrictVN.provinceCode, 
					"@DistrictID",  _GExpDistrictVN.DistrictID);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDistrictVN vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDistrictVN> _GExpDistrictVNs)
		{
			foreach (GExpDistrictVN item in _GExpDistrictVNs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDistrictVN _GExpDistrictVN, String districtCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictVN] SET districtCode=@districtCode, districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID WHERE districtCode=@districtCode", 
					"@districtCode",  _GExpDistrictVN.districtCode, 
					"@districtName",  _GExpDistrictVN.districtName, 
					"@provinceCode",  _GExpDistrictVN.provinceCode, 
					"@DistrictID",  _GExpDistrictVN.DistrictID, 
					"@districtCode", districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictVN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDistrictVN _GExpDistrictVN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictVN] SET districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID WHERE districtCode=@districtCode", 
					"@districtName",  _GExpDistrictVN.districtName, 
					"@provinceCode",  _GExpDistrictVN.provinceCode, 
					"@DistrictID",  _GExpDistrictVN.DistrictID, 
					"@districtCode", _GExpDistrictVN.districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDistrictVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDistrictVN> _GExpDistrictVNs)
		{
			foreach (GExpDistrictVN item in _GExpDistrictVNs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictVN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDistrictVN _GExpDistrictVN, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictVN] SET districtCode=@districtCode, districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID "+ condition, 
					"@districtCode",  _GExpDistrictVN.districtCode, 
					"@districtName",  _GExpDistrictVN.districtName, 
					"@provinceCode",  _GExpDistrictVN.provinceCode, 
					"@DistrictID",  _GExpDistrictVN.DistrictID);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDistrictVN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String districtCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictVN] WHERE districtCode=@districtCode",
					"@districtCode", districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictVN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDistrictVN _GExpDistrictVN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictVN] WHERE districtCode=@districtCode",
					"@districtCode", _GExpDistrictVN.districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictVN trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictVN] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictVN trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDistrictVN> _GExpDistrictVNs)
		{
			foreach (GExpDistrictVN item in _GExpDistrictVNs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
