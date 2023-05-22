using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpwardvn:IGExpwardvn
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpwardvn(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpWardVN từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVN]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpWardVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVN] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpWardVN từ Database
		/// </summary>
		public List<GExpWardVN> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVN]");
				List<GExpWardVN> items = new List<GExpWardVN>();
				GExpWardVN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardVN();
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
		/// Lấy danh sách GExpWardVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpWardVN> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardVN] A "+ condition,  parameters);
				List<GExpWardVN> items = new List<GExpWardVN>();
				GExpWardVN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardVN();
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

		public List<GExpWardVN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardVN] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpWardVN] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpWardVN>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpWardVN từ Database
		/// </summary>
		public GExpWardVN GetObject(string schema, String communeCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVN] where communeCode=@communeCode",
					"@communeCode", communeCode);
				if (ds.Rows.Count > 0)
				{
					GExpWardVN item=new GExpWardVN();
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
		/// Lấy một GExpWardVN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpWardVN GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardVN] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpWardVN item=new GExpWardVN();
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

		public GExpWardVN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardVN] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpWardVN>(ds);
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
		/// Thêm mới GExpWardVN vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpWardVN _GExpWardVN)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpWardVN](communeCode, communeName, districtCode, WardId) VALUES(@communeCode, @communeName, @districtCode, @WardId)", 
					"@communeCode",  _GExpWardVN.communeCode, 
					"@communeName",  _GExpWardVN.communeName, 
					"@districtCode",  _GExpWardVN.districtCode, 
					"@WardId",  _GExpWardVN.WardId);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpWardVN vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpWardVN> _GExpWardVNs)
		{
			foreach (GExpWardVN item in _GExpWardVNs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpWardVN _GExpWardVN, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardVN] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId WHERE communeCode=@communeCode", 
					"@communeCode",  _GExpWardVN.communeCode, 
					"@communeName",  _GExpWardVN.communeName, 
					"@districtCode",  _GExpWardVN.districtCode, 
					"@WardId",  _GExpWardVN.WardId, 
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpWardVN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpWardVN _GExpWardVN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardVN] SET communeName=@communeName, districtCode=@districtCode, WardId=@WardId WHERE communeCode=@communeCode", 
					"@communeName",  _GExpWardVN.communeName, 
					"@districtCode",  _GExpWardVN.districtCode, 
					"@WardId",  _GExpWardVN.WardId, 
					"@communeCode", _GExpWardVN.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpWardVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpWardVN> _GExpWardVNs)
		{
			foreach (GExpWardVN item in _GExpWardVNs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardVN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpWardVN _GExpWardVN, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardVN] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId "+ condition, 
					"@communeCode",  _GExpWardVN.communeCode, 
					"@communeName",  _GExpWardVN.communeName, 
					"@districtCode",  _GExpWardVN.districtCode, 
					"@WardId",  _GExpWardVN.WardId);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpWardVN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardVN] WHERE communeCode=@communeCode",
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardVN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpWardVN _GExpWardVN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardVN] WHERE communeCode=@communeCode",
					"@communeCode", _GExpWardVN.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardVN trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardVN] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardVN trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpWardVN> _GExpWardVNs)
		{
			foreach (GExpWardVN item in _GExpWardVNs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
