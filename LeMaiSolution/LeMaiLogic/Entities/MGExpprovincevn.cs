using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprovincevn:IGExpprovincevn
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprovincevn(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProvinceVN từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVN]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProvinceVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVN] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProvinceVN từ Database
		/// </summary>
		public List<GExpProvinceVN> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVN]");
				List<GExpProvinceVN> items = new List<GExpProvinceVN>();
				GExpProvinceVN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceVN();
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
		/// Lấy danh sách GExpProvinceVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProvinceVN> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceVN] A "+ condition,  parameters);
				List<GExpProvinceVN> items = new List<GExpProvinceVN>();
				GExpProvinceVN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceVN();
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

		public List<GExpProvinceVN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceVN] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProvinceVN] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProvinceVN>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProvinceVN từ Database
		/// </summary>
		public GExpProvinceVN GetObject(string schema, String provinceCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVN] where provinceCode=@provinceCode",
					"@provinceCode", provinceCode);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceVN item=new GExpProvinceVN();
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
		/// Lấy một GExpProvinceVN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProvinceVN GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceVN] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceVN item=new GExpProvinceVN();
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

		public GExpProvinceVN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceVN] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProvinceVN>(ds);
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
		/// Thêm mới GExpProvinceVN vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProvinceVN _GExpProvinceVN)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProvinceVN](provinceCode, provinceName, ProvinceID) VALUES(@provinceCode, @provinceName, @ProvinceID)", 
					"@provinceCode",  _GExpProvinceVN.provinceCode, 
					"@provinceName",  _GExpProvinceVN.provinceName, 
					"@ProvinceID",  _GExpProvinceVN.ProvinceID);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceVN vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProvinceVN> _GExpProvinceVNs)
		{
			foreach (GExpProvinceVN item in _GExpProvinceVNs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProvinceVN _GExpProvinceVN, String provinceCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceVN] SET provinceCode=@provinceCode, provinceName=@provinceName, ProvinceID=@ProvinceID WHERE provinceCode=@provinceCode", 
					"@provinceCode",  _GExpProvinceVN.provinceCode, 
					"@provinceName",  _GExpProvinceVN.provinceName, 
					"@ProvinceID",  _GExpProvinceVN.ProvinceID, 
					"@provinceCode", provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceVN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProvinceVN _GExpProvinceVN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceVN] SET provinceName=@provinceName, ProvinceID=@ProvinceID WHERE provinceCode=@provinceCode", 
					"@provinceName",  _GExpProvinceVN.provinceName, 
					"@ProvinceID",  _GExpProvinceVN.ProvinceID, 
					"@provinceCode", _GExpProvinceVN.provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProvinceVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProvinceVN> _GExpProvinceVNs)
		{
			foreach (GExpProvinceVN item in _GExpProvinceVNs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceVN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProvinceVN _GExpProvinceVN, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceVN] SET provinceCode=@provinceCode, provinceName=@provinceName, ProvinceID=@ProvinceID "+ condition, 
					"@provinceCode",  _GExpProvinceVN.provinceCode, 
					"@provinceName",  _GExpProvinceVN.provinceName, 
					"@ProvinceID",  _GExpProvinceVN.ProvinceID);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProvinceVN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String provinceCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceVN] WHERE provinceCode=@provinceCode",
					"@provinceCode", provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceVN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProvinceVN _GExpProvinceVN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceVN] WHERE provinceCode=@provinceCode",
					"@provinceCode", _GExpProvinceVN.provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceVN trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceVN] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceVN trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProvinceVN> _GExpProvinceVNs)
		{
			foreach (GExpProvinceVN item in _GExpProvinceVNs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
