using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprovincevtp:IGExpprovincevtp
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprovincevtp(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProvinceVTP từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVTP]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProvinceVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVTP] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProvinceVTP từ Database
		/// </summary>
		public List<GExpProvinceVTP> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVTP]");
				List<GExpProvinceVTP> items = new List<GExpProvinceVTP>();
				GExpProvinceVTP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceVTP();
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
		/// Lấy danh sách GExpProvinceVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProvinceVTP> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceVTP] A "+ condition,  parameters);
				List<GExpProvinceVTP> items = new List<GExpProvinceVTP>();
				GExpProvinceVTP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceVTP();
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

		public List<GExpProvinceVTP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceVTP] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProvinceVTP] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProvinceVTP>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProvinceVTP từ Database
		/// </summary>
		public GExpProvinceVTP GetObject(string schema, String provinceCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceVTP] where provinceCode=@provinceCode",
					"@provinceCode", provinceCode);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceVTP item=new GExpProvinceVTP();
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
		/// Lấy một GExpProvinceVTP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProvinceVTP GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceVTP] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceVTP item=new GExpProvinceVTP();
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

		public GExpProvinceVTP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceVTP] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProvinceVTP>(ds);
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
		/// Thêm mới GExpProvinceVTP vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProvinceVTP _GExpProvinceVTP)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProvinceVTP](provinceCode, provinceName, ProvinceID) VALUES(@provinceCode, @provinceName, @ProvinceID)", 
					"@provinceCode",  _GExpProvinceVTP.provinceCode, 
					"@provinceName",  _GExpProvinceVTP.provinceName, 
					"@ProvinceID",  _GExpProvinceVTP.ProvinceID);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceVTP vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProvinceVTP> _GExpProvinceVTPs)
		{
			foreach (GExpProvinceVTP item in _GExpProvinceVTPs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProvinceVTP _GExpProvinceVTP, String provinceCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceVTP] SET provinceCode=@provinceCode, provinceName=@provinceName, ProvinceID=@ProvinceID WHERE provinceCode=@provinceCode", 
					"@provinceCode",  _GExpProvinceVTP.provinceCode, 
					"@provinceName",  _GExpProvinceVTP.provinceName, 
					"@ProvinceID",  _GExpProvinceVTP.ProvinceID, 
					"@provinceCode", provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceVTP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProvinceVTP _GExpProvinceVTP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceVTP] SET provinceName=@provinceName, ProvinceID=@ProvinceID WHERE provinceCode=@provinceCode", 
					"@provinceName",  _GExpProvinceVTP.provinceName, 
					"@ProvinceID",  _GExpProvinceVTP.ProvinceID, 
					"@provinceCode", _GExpProvinceVTP.provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProvinceVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProvinceVTP> _GExpProvinceVTPs)
		{
			foreach (GExpProvinceVTP item in _GExpProvinceVTPs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceVTP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProvinceVTP _GExpProvinceVTP, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceVTP] SET provinceCode=@provinceCode, provinceName=@provinceName, ProvinceID=@ProvinceID "+ condition, 
					"@provinceCode",  _GExpProvinceVTP.provinceCode, 
					"@provinceName",  _GExpProvinceVTP.provinceName, 
					"@ProvinceID",  _GExpProvinceVTP.ProvinceID);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProvinceVTP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String provinceCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceVTP] WHERE provinceCode=@provinceCode",
					"@provinceCode", provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceVTP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProvinceVTP _GExpProvinceVTP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceVTP] WHERE provinceCode=@provinceCode",
					"@provinceCode", _GExpProvinceVTP.provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceVTP trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceVTP] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceVTP trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProvinceVTP> _GExpProvinceVTPs)
		{
			foreach (GExpProvinceVTP item in _GExpProvinceVTPs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
