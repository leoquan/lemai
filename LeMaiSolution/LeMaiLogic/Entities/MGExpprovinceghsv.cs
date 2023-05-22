using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprovinceghsv:IGExpprovinceghsv
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprovinceghsv(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProvinceGHSV từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceGHSV]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProvinceGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceGHSV] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProvinceGHSV từ Database
		/// </summary>
		public List<GExpProvinceGHSV> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceGHSV]");
				List<GExpProvinceGHSV> items = new List<GExpProvinceGHSV>();
				GExpProvinceGHSV item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceGHSV();
					if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
					{
						item.provinceCode = Convert.ToString(dr["provinceCode"]);
					}
					if (dr["provinceName"] != null && dr["provinceName"] != DBNull.Value)
					{
						item.provinceName = Convert.ToString(dr["provinceName"]);
					}
					if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
					{
						item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
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
		/// Lấy danh sách GExpProvinceGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProvinceGHSV> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceGHSV] A "+ condition,  parameters);
				List<GExpProvinceGHSV> items = new List<GExpProvinceGHSV>();
				GExpProvinceGHSV item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceGHSV();
					if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
					{
						item.provinceCode = Convert.ToString(dr["provinceCode"]);
					}
					if (dr["provinceName"] != null && dr["provinceName"] != DBNull.Value)
					{
						item.provinceName = Convert.ToString(dr["provinceName"]);
					}
					if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
					{
						item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
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

		public List<GExpProvinceGHSV> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceGHSV] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProvinceGHSV] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProvinceGHSV>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProvinceGHSV từ Database
		/// </summary>
		public GExpProvinceGHSV GetObject(string schema, String provinceCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceGHSV] where provinceCode=@provinceCode",
					"@provinceCode", provinceCode);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceGHSV item=new GExpProvinceGHSV();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
						{
							item.provinceCode = Convert.ToString(dr["provinceCode"]);
						}
						if (dr["provinceName"] != null && dr["provinceName"] != DBNull.Value)
						{
							item.provinceName = Convert.ToString(dr["provinceName"]);
						}
						if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
						{
							item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
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
		/// Lấy một GExpProvinceGHSV đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProvinceGHSV GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceGHSV] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceGHSV item=new GExpProvinceGHSV();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
						{
							item.provinceCode = Convert.ToString(dr["provinceCode"]);
						}
						if (dr["provinceName"] != null && dr["provinceName"] != DBNull.Value)
						{
							item.provinceName = Convert.ToString(dr["provinceName"]);
						}
						if (dr["ProvinceID"] != null && dr["ProvinceID"] != DBNull.Value)
						{
							item.ProvinceID = Convert.ToInt32(dr["ProvinceID"]);
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

		public GExpProvinceGHSV GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceGHSV] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProvinceGHSV>(ds);
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
		/// Thêm mới GExpProvinceGHSV vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProvinceGHSV _GExpProvinceGHSV)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProvinceGHSV](provinceCode, provinceName, ProvinceID) VALUES(@provinceCode, @provinceName, @ProvinceID)", 
					"@provinceCode",  _GExpProvinceGHSV.provinceCode, 
					"@provinceName",  _GExpProvinceGHSV.provinceName, 
					"@ProvinceID",  _GExpProvinceGHSV.ProvinceID);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceGHSV vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProvinceGHSV> _GExpProvinceGHSVs)
		{
			foreach (GExpProvinceGHSV item in _GExpProvinceGHSVs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProvinceGHSV _GExpProvinceGHSV, String provinceCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceGHSV] SET provinceCode=@provinceCode, provinceName=@provinceName, ProvinceID=@ProvinceID WHERE provinceCode=@provinceCode", 
					"@provinceCode",  _GExpProvinceGHSV.provinceCode, 
					"@provinceName",  _GExpProvinceGHSV.provinceName, 
					"@ProvinceID",  _GExpProvinceGHSV.ProvinceID, 
					"@provinceCode", provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceGHSV vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProvinceGHSV _GExpProvinceGHSV)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceGHSV] SET provinceName=@provinceName, ProvinceID=@ProvinceID WHERE provinceCode=@provinceCode", 
					"@provinceName",  _GExpProvinceGHSV.provinceName, 
					"@ProvinceID",  _GExpProvinceGHSV.ProvinceID, 
					"@provinceCode", _GExpProvinceGHSV.provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProvinceGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProvinceGHSV> _GExpProvinceGHSVs)
		{
			foreach (GExpProvinceGHSV item in _GExpProvinceGHSVs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceGHSV vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProvinceGHSV _GExpProvinceGHSV, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceGHSV] SET provinceCode=@provinceCode, provinceName=@provinceName, ProvinceID=@ProvinceID "+ condition, 
					"@provinceCode",  _GExpProvinceGHSV.provinceCode, 
					"@provinceName",  _GExpProvinceGHSV.provinceName, 
					"@ProvinceID",  _GExpProvinceGHSV.ProvinceID);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProvinceGHSV trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String provinceCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceGHSV] WHERE provinceCode=@provinceCode",
					"@provinceCode", provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceGHSV trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProvinceGHSV _GExpProvinceGHSV)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceGHSV] WHERE provinceCode=@provinceCode",
					"@provinceCode", _GExpProvinceGHSV.provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceGHSV trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceGHSV] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceGHSV trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProvinceGHSV> _GExpProvinceGHSVs)
		{
			foreach (GExpProvinceGHSV item in _GExpProvinceGHSVs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
