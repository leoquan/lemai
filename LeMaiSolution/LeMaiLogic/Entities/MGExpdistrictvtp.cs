using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdistrictvtp:IGExpdistrictvtp
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdistrictvtp(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDistrictVTP từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVTP]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDistrictVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVTP] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDistrictVTP từ Database
		/// </summary>
		public List<GExpDistrictVTP> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVTP]");
				List<GExpDistrictVTP> items = new List<GExpDistrictVTP>();
				GExpDistrictVTP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrictVTP();
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
		/// Lấy danh sách GExpDistrictVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDistrictVTP> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrictVTP] A "+ condition,  parameters);
				List<GExpDistrictVTP> items = new List<GExpDistrictVTP>();
				GExpDistrictVTP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrictVTP();
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

		public List<GExpDistrictVTP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrictVTP] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDistrictVTP] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDistrictVTP>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDistrictVTP từ Database
		/// </summary>
		public GExpDistrictVTP GetObject(string schema, String districtCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictVTP] where districtCode=@districtCode",
					"@districtCode", districtCode);
				if (ds.Rows.Count > 0)
				{
					GExpDistrictVTP item=new GExpDistrictVTP();
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
		/// Lấy một GExpDistrictVTP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDistrictVTP GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrictVTP] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDistrictVTP item=new GExpDistrictVTP();
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

		public GExpDistrictVTP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrictVTP] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDistrictVTP>(ds);
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
		/// Thêm mới GExpDistrictVTP vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDistrictVTP _GExpDistrictVTP)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDistrictVTP](districtCode, districtName, provinceCode, DistrictID) VALUES(@districtCode, @districtName, @provinceCode, @DistrictID)", 
					"@districtCode",  _GExpDistrictVTP.districtCode, 
					"@districtName",  _GExpDistrictVTP.districtName, 
					"@provinceCode",  _GExpDistrictVTP.provinceCode, 
					"@DistrictID",  _GExpDistrictVTP.DistrictID);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDistrictVTP vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDistrictVTP> _GExpDistrictVTPs)
		{
			foreach (GExpDistrictVTP item in _GExpDistrictVTPs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDistrictVTP _GExpDistrictVTP, String districtCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictVTP] SET districtCode=@districtCode, districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID WHERE districtCode=@districtCode", 
					"@districtCode",  _GExpDistrictVTP.districtCode, 
					"@districtName",  _GExpDistrictVTP.districtName, 
					"@provinceCode",  _GExpDistrictVTP.provinceCode, 
					"@DistrictID",  _GExpDistrictVTP.DistrictID, 
					"@districtCode", districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictVTP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDistrictVTP _GExpDistrictVTP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictVTP] SET districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID WHERE districtCode=@districtCode", 
					"@districtName",  _GExpDistrictVTP.districtName, 
					"@provinceCode",  _GExpDistrictVTP.provinceCode, 
					"@DistrictID",  _GExpDistrictVTP.DistrictID, 
					"@districtCode", _GExpDistrictVTP.districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDistrictVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDistrictVTP> _GExpDistrictVTPs)
		{
			foreach (GExpDistrictVTP item in _GExpDistrictVTPs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictVTP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDistrictVTP _GExpDistrictVTP, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictVTP] SET districtCode=@districtCode, districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID "+ condition, 
					"@districtCode",  _GExpDistrictVTP.districtCode, 
					"@districtName",  _GExpDistrictVTP.districtName, 
					"@provinceCode",  _GExpDistrictVTP.provinceCode, 
					"@DistrictID",  _GExpDistrictVTP.DistrictID);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDistrictVTP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String districtCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictVTP] WHERE districtCode=@districtCode",
					"@districtCode", districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictVTP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDistrictVTP _GExpDistrictVTP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictVTP] WHERE districtCode=@districtCode",
					"@districtCode", _GExpDistrictVTP.districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictVTP trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictVTP] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictVTP trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDistrictVTP> _GExpDistrictVTPs)
		{
			foreach (GExpDistrictVTP item in _GExpDistrictVTPs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
