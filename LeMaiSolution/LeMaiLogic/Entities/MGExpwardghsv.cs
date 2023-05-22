using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpwardghsv:IGExpwardghsv
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpwardghsv(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpWardGHSV từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardGHSV]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpWardGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardGHSV] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpWardGHSV từ Database
		/// </summary>
		public List<GExpWardGHSV> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardGHSV]");
				List<GExpWardGHSV> items = new List<GExpWardGHSV>();
				GExpWardGHSV item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardGHSV();
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
		/// Lấy danh sách GExpWardGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpWardGHSV> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardGHSV] A "+ condition,  parameters);
				List<GExpWardGHSV> items = new List<GExpWardGHSV>();
				GExpWardGHSV item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardGHSV();
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

		public List<GExpWardGHSV> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardGHSV] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpWardGHSV] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpWardGHSV>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpWardGHSV từ Database
		/// </summary>
		public GExpWardGHSV GetObject(string schema, String communeCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardGHSV] where communeCode=@communeCode",
					"@communeCode", communeCode);
				if (ds.Rows.Count > 0)
				{
					GExpWardGHSV item=new GExpWardGHSV();
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
		/// Lấy một GExpWardGHSV đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpWardGHSV GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardGHSV] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpWardGHSV item=new GExpWardGHSV();
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

		public GExpWardGHSV GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardGHSV] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpWardGHSV>(ds);
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
		/// Thêm mới GExpWardGHSV vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpWardGHSV _GExpWardGHSV)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpWardGHSV](communeCode, communeName, districtCode, WardId) VALUES(@communeCode, @communeName, @districtCode, @WardId)", 
					"@communeCode",  _GExpWardGHSV.communeCode, 
					"@communeName",  _GExpWardGHSV.communeName, 
					"@districtCode",  _GExpWardGHSV.districtCode, 
					"@WardId",  _GExpWardGHSV.WardId);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpWardGHSV vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpWardGHSV> _GExpWardGHSVs)
		{
			foreach (GExpWardGHSV item in _GExpWardGHSVs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpWardGHSV _GExpWardGHSV, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardGHSV] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId WHERE communeCode=@communeCode", 
					"@communeCode",  _GExpWardGHSV.communeCode, 
					"@communeName",  _GExpWardGHSV.communeName, 
					"@districtCode",  _GExpWardGHSV.districtCode, 
					"@WardId",  _GExpWardGHSV.WardId, 
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpWardGHSV vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpWardGHSV _GExpWardGHSV)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardGHSV] SET communeName=@communeName, districtCode=@districtCode, WardId=@WardId WHERE communeCode=@communeCode", 
					"@communeName",  _GExpWardGHSV.communeName, 
					"@districtCode",  _GExpWardGHSV.districtCode, 
					"@WardId",  _GExpWardGHSV.WardId, 
					"@communeCode", _GExpWardGHSV.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpWardGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpWardGHSV> _GExpWardGHSVs)
		{
			foreach (GExpWardGHSV item in _GExpWardGHSVs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardGHSV vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpWardGHSV _GExpWardGHSV, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardGHSV] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId "+ condition, 
					"@communeCode",  _GExpWardGHSV.communeCode, 
					"@communeName",  _GExpWardGHSV.communeName, 
					"@districtCode",  _GExpWardGHSV.districtCode, 
					"@WardId",  _GExpWardGHSV.WardId);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpWardGHSV trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardGHSV] WHERE communeCode=@communeCode",
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardGHSV trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpWardGHSV _GExpWardGHSV)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardGHSV] WHERE communeCode=@communeCode",
					"@communeCode", _GExpWardGHSV.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardGHSV trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardGHSV] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardGHSV trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpWardGHSV> _GExpWardGHSVs)
		{
			foreach (GExpWardGHSV item in _GExpWardGHSVs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
