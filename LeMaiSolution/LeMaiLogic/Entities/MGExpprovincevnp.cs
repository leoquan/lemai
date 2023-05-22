using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprovincevnp:IGExpprovincevnp
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprovincevnp(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProvinceVNP từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVNP]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProvinceVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVNP] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProvinceVNP từ Database
		/// </summary>
		public List<GExpProvinceVNP> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVNP]");
				List<GExpProvinceVNP> items = new List<GExpProvinceVNP>();
				GExpProvinceVNP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceVNP();
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
		/// Lấy danh sách GExpProvinceVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProvinceVNP> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceVNP] A "+ condition,  parameters);
				List<GExpProvinceVNP> items = new List<GExpProvinceVNP>();
				GExpProvinceVNP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceVNP();
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

		public List<GExpProvinceVNP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceVNP] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProvinceVNP] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProvinceVNP>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProvinceVNP từ Database
		/// </summary>
		public GExpProvinceVNP GetObject(string schema, String provinceCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVNP] where provinceCode=@provinceCode",
					"@provinceCode", provinceCode);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceVNP item=new GExpProvinceVNP();
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
		/// Lấy một GExpProvinceVNP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProvinceVNP GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceVNP] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceVNP item=new GExpProvinceVNP();
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

		public GExpProvinceVNP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceVNP] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProvinceVNP>(ds);
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
		/// Thêm mới GExpProvinceVNP vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProvinceVNP _GExpProvinceVNP)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProvinceVNP](provinceCode, provinceName, ProvinceID) VALUES(@provinceCode, @provinceName, @ProvinceID)", 
					"@provinceCode",  _GExpProvinceVNP.provinceCode, 
					"@provinceName",  _GExpProvinceVNP.provinceName, 
					"@ProvinceID",  _GExpProvinceVNP.ProvinceID);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceVNP vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProvinceVNP> _GExpProvinceVNPs)
		{
			foreach (GExpProvinceVNP item in _GExpProvinceVNPs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProvinceVNP _GExpProvinceVNP, String provinceCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceVNP] SET provinceCode=@provinceCode, provinceName=@provinceName, ProvinceID=@ProvinceID WHERE provinceCode=@provinceCode", 
					"@provinceCode",  _GExpProvinceVNP.provinceCode, 
					"@provinceName",  _GExpProvinceVNP.provinceName, 
					"@ProvinceID",  _GExpProvinceVNP.ProvinceID, 
					"@provinceCode", provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceVNP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProvinceVNP _GExpProvinceVNP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceVNP] SET provinceName=@provinceName, ProvinceID=@ProvinceID WHERE provinceCode=@provinceCode", 
					"@provinceName",  _GExpProvinceVNP.provinceName, 
					"@ProvinceID",  _GExpProvinceVNP.ProvinceID, 
					"@provinceCode", _GExpProvinceVNP.provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProvinceVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProvinceVNP> _GExpProvinceVNPs)
		{
			foreach (GExpProvinceVNP item in _GExpProvinceVNPs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceVNP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProvinceVNP _GExpProvinceVNP, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceVNP] SET provinceCode=@provinceCode, provinceName=@provinceName, ProvinceID=@ProvinceID "+ condition, 
					"@provinceCode",  _GExpProvinceVNP.provinceCode, 
					"@provinceName",  _GExpProvinceVNP.provinceName, 
					"@ProvinceID",  _GExpProvinceVNP.ProvinceID);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProvinceVNP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String provinceCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceVNP] WHERE provinceCode=@provinceCode",
					"@provinceCode", provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceVNP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProvinceVNP _GExpProvinceVNP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceVNP] WHERE provinceCode=@provinceCode",
					"@provinceCode", _GExpProvinceVNP.provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceVNP trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceVNP] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceVNP trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProvinceVNP> _GExpProvinceVNPs)
		{
			foreach (GExpProvinceVNP item in _GExpProvinceVNPs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
