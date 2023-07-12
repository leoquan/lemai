using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpwardbamboo:IGExpwardbamboo
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpwardbamboo(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpWardBamboo từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardBamboo]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpWardBamboo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardBamboo] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpWardBamboo từ Database
		/// </summary>
		public List<GExpWardBamboo> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardBamboo]");
				List<GExpWardBamboo> items = new List<GExpWardBamboo>();
				GExpWardBamboo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardBamboo();
					if (dr["communeCode"] != null && dr["communeCode"] != DBNull.Value)
					{
						item.communeCode = Convert.ToString(dr["communeCode"]);
					}
					if (dr["communeName"] != null && dr["communeName"] != DBNull.Value)
					{
						item.communeName = Convert.ToString(dr["communeName"]);
					}
					if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
					{
						item.districtCode = Convert.ToString(dr["districtCode"]);
					}
					if (dr["WardId"] != null && dr["WardId"] != DBNull.Value)
					{
						item.WardId = Convert.ToString(dr["WardId"]);
					}
					if (dr["PortCode"] != null && dr["PortCode"] != DBNull.Value)
					{
						item.PortCode = Convert.ToString(dr["PortCode"]);
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
		/// Lấy danh sách GExpWardBamboo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpWardBamboo> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardBamboo] A "+ condition,  parameters);
				List<GExpWardBamboo> items = new List<GExpWardBamboo>();
				GExpWardBamboo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardBamboo();
					if (dr["communeCode"] != null && dr["communeCode"] != DBNull.Value)
					{
						item.communeCode = Convert.ToString(dr["communeCode"]);
					}
					if (dr["communeName"] != null && dr["communeName"] != DBNull.Value)
					{
						item.communeName = Convert.ToString(dr["communeName"]);
					}
					if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
					{
						item.districtCode = Convert.ToString(dr["districtCode"]);
					}
					if (dr["WardId"] != null && dr["WardId"] != DBNull.Value)
					{
						item.WardId = Convert.ToString(dr["WardId"]);
					}
					if (dr["PortCode"] != null && dr["PortCode"] != DBNull.Value)
					{
						item.PortCode = Convert.ToString(dr["PortCode"]);
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

		public List<GExpWardBamboo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardBamboo] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpWardBamboo] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpWardBamboo>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpWardBamboo từ Database
		/// </summary>
		public GExpWardBamboo GetObject(string schema, String communeCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardBamboo] where communeCode=@communeCode",
					"@communeCode", communeCode);
				if (ds.Rows.Count > 0)
				{
					GExpWardBamboo item=new GExpWardBamboo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["communeCode"] != null && dr["communeCode"] != DBNull.Value)
						{
							item.communeCode = Convert.ToString(dr["communeCode"]);
						}
						if (dr["communeName"] != null && dr["communeName"] != DBNull.Value)
						{
							item.communeName = Convert.ToString(dr["communeName"]);
						}
						if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
						{
							item.districtCode = Convert.ToString(dr["districtCode"]);
						}
						if (dr["WardId"] != null && dr["WardId"] != DBNull.Value)
						{
							item.WardId = Convert.ToString(dr["WardId"]);
						}
						if (dr["PortCode"] != null && dr["PortCode"] != DBNull.Value)
						{
							item.PortCode = Convert.ToString(dr["PortCode"]);
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
		/// Lấy một GExpWardBamboo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpWardBamboo GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardBamboo] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpWardBamboo item=new GExpWardBamboo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["communeCode"] != null && dr["communeCode"] != DBNull.Value)
						{
							item.communeCode = Convert.ToString(dr["communeCode"]);
						}
						if (dr["communeName"] != null && dr["communeName"] != DBNull.Value)
						{
							item.communeName = Convert.ToString(dr["communeName"]);
						}
						if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
						{
							item.districtCode = Convert.ToString(dr["districtCode"]);
						}
						if (dr["WardId"] != null && dr["WardId"] != DBNull.Value)
						{
							item.WardId = Convert.ToString(dr["WardId"]);
						}
						if (dr["PortCode"] != null && dr["PortCode"] != DBNull.Value)
						{
							item.PortCode = Convert.ToString(dr["PortCode"]);
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

		public GExpWardBamboo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardBamboo] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpWardBamboo>(ds);
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
		/// Thêm mới GExpWardBamboo vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpWardBamboo _GExpWardBamboo)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpWardBamboo](communeCode, communeName, districtCode, WardId, PortCode) VALUES(@communeCode, @communeName, @districtCode, @WardId, @PortCode)", 
					"@communeCode",  _GExpWardBamboo.communeCode, 
					"@communeName",  _GExpWardBamboo.communeName, 
					"@districtCode",  _GExpWardBamboo.districtCode, 
					"@WardId",  _GExpWardBamboo.WardId, 
					"@PortCode",  _GExpWardBamboo.PortCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpWardBamboo vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpWardBamboo> _GExpWardBamboos)
		{
			foreach (GExpWardBamboo item in _GExpWardBamboos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardBamboo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpWardBamboo _GExpWardBamboo, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardBamboo] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId, PortCode=@PortCode WHERE communeCode=@communeCode", 
					"@communeCode",  _GExpWardBamboo.communeCode, 
					"@communeName",  _GExpWardBamboo.communeName, 
					"@districtCode",  _GExpWardBamboo.districtCode, 
					"@WardId",  _GExpWardBamboo.WardId, 
					"@PortCode",  _GExpWardBamboo.PortCode, 
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpWardBamboo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpWardBamboo _GExpWardBamboo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardBamboo] SET communeName=@communeName, districtCode=@districtCode, WardId=@WardId, PortCode=@PortCode WHERE communeCode=@communeCode", 
					"@communeName",  _GExpWardBamboo.communeName, 
					"@districtCode",  _GExpWardBamboo.districtCode, 
					"@WardId",  _GExpWardBamboo.WardId, 
					"@PortCode",  _GExpWardBamboo.PortCode, 
					"@communeCode", _GExpWardBamboo.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpWardBamboo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpWardBamboo> _GExpWardBamboos)
		{
			foreach (GExpWardBamboo item in _GExpWardBamboos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardBamboo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpWardBamboo _GExpWardBamboo, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardBamboo] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId, PortCode=@PortCode "+ condition, 
					"@communeCode",  _GExpWardBamboo.communeCode, 
					"@communeName",  _GExpWardBamboo.communeName, 
					"@districtCode",  _GExpWardBamboo.districtCode, 
					"@WardId",  _GExpWardBamboo.WardId, 
					"@PortCode",  _GExpWardBamboo.PortCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpWardBamboo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardBamboo] WHERE communeCode=@communeCode",
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardBamboo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpWardBamboo _GExpWardBamboo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardBamboo] WHERE communeCode=@communeCode",
					"@communeCode", _GExpWardBamboo.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardBamboo trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardBamboo] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardBamboo trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpWardBamboo> _GExpWardBamboos)
		{
			foreach (GExpWardBamboo item in _GExpWardBamboos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
