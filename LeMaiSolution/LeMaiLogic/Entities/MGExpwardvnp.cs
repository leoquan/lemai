using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpwardvnp:IGExpwardvnp
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpwardvnp(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpWardVNP từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVNP]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpWardVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVNP] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpWardVNP từ Database
		/// </summary>
		public List<GExpWardVNP> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVNP]");
				List<GExpWardVNP> items = new List<GExpWardVNP>();
				GExpWardVNP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardVNP();
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
		/// Lấy danh sách GExpWardVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpWardVNP> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardVNP] A "+ condition,  parameters);
				List<GExpWardVNP> items = new List<GExpWardVNP>();
				GExpWardVNP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardVNP();
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<GExpWardVNP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardVNP] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpWardVNP] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpWardVNP>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpWardVNP từ Database
		/// </summary>
		public GExpWardVNP GetObject(string schema, String communeCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVNP] where communeCode=@communeCode",
					"@communeCode", communeCode);
				if (ds.Rows.Count > 0)
				{
					GExpWardVNP item=new GExpWardVNP();
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
		/// Lấy một GExpWardVNP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpWardVNP GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardVNP] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpWardVNP item=new GExpWardVNP();
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

		public GExpWardVNP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardVNP] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpWardVNP>(ds);
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
		/// Thêm mới GExpWardVNP vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpWardVNP _GExpWardVNP)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpWardVNP](communeCode, communeName, districtCode, WardId) VALUES(@communeCode, @communeName, @districtCode, @WardId)", 
					"@communeCode",  _GExpWardVNP.communeCode, 
					"@communeName",  _GExpWardVNP.communeName, 
					"@districtCode",  _GExpWardVNP.districtCode, 
					"@WardId",  _GExpWardVNP.WardId);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpWardVNP vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpWardVNP> _GExpWardVNPs)
		{
			foreach (GExpWardVNP item in _GExpWardVNPs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpWardVNP _GExpWardVNP, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardVNP] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId WHERE communeCode=@communeCode", 
					"@communeCode",  _GExpWardVNP.communeCode, 
					"@communeName",  _GExpWardVNP.communeName, 
					"@districtCode",  _GExpWardVNP.districtCode, 
					"@WardId",  _GExpWardVNP.WardId, 
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpWardVNP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpWardVNP _GExpWardVNP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardVNP] SET communeName=@communeName, districtCode=@districtCode, WardId=@WardId WHERE communeCode=@communeCode", 
					"@communeName",  _GExpWardVNP.communeName, 
					"@districtCode",  _GExpWardVNP.districtCode, 
					"@WardId",  _GExpWardVNP.WardId, 
					"@communeCode", _GExpWardVNP.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpWardVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpWardVNP> _GExpWardVNPs)
		{
			foreach (GExpWardVNP item in _GExpWardVNPs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardVNP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpWardVNP _GExpWardVNP, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardVNP] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId "+ condition, 
					"@communeCode",  _GExpWardVNP.communeCode, 
					"@communeName",  _GExpWardVNP.communeName, 
					"@districtCode",  _GExpWardVNP.districtCode, 
					"@WardId",  _GExpWardVNP.WardId);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpWardVNP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardVNP] WHERE communeCode=@communeCode",
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardVNP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpWardVNP _GExpWardVNP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardVNP] WHERE communeCode=@communeCode",
					"@communeCode", _GExpWardVNP.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardVNP trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardVNP] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardVNP trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpWardVNP> _GExpWardVNPs)
		{
			foreach (GExpWardVNP item in _GExpWardVNPs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
