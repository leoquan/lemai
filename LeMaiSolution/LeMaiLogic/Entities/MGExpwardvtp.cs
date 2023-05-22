using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpwardvtp:IGExpwardvtp
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpwardvtp(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpWardVTP từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVTP]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpWardVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVTP] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpWardVTP từ Database
		/// </summary>
		public List<GExpWardVTP> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVTP]");
				List<GExpWardVTP> items = new List<GExpWardVTP>();
				GExpWardVTP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardVTP();
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
		/// Lấy danh sách GExpWardVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpWardVTP> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardVTP] A "+ condition,  parameters);
				List<GExpWardVTP> items = new List<GExpWardVTP>();
				GExpWardVTP item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardVTP();
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

		public List<GExpWardVTP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardVTP] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpWardVTP] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpWardVTP>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpWardVTP từ Database
		/// </summary>
		public GExpWardVTP GetObject(string schema, String communeCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardVTP] where communeCode=@communeCode",
					"@communeCode", communeCode);
				if (ds.Rows.Count > 0)
				{
					GExpWardVTP item=new GExpWardVTP();
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
		/// Lấy một GExpWardVTP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpWardVTP GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardVTP] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpWardVTP item=new GExpWardVTP();
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

		public GExpWardVTP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardVTP] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpWardVTP>(ds);
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
		/// Thêm mới GExpWardVTP vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpWardVTP _GExpWardVTP)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpWardVTP](communeCode, communeName, districtCode, WardId) VALUES(@communeCode, @communeName, @districtCode, @WardId)", 
					"@communeCode",  _GExpWardVTP.communeCode, 
					"@communeName",  _GExpWardVTP.communeName, 
					"@districtCode",  _GExpWardVTP.districtCode, 
					"@WardId",  _GExpWardVTP.WardId);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpWardVTP vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpWardVTP> _GExpWardVTPs)
		{
			foreach (GExpWardVTP item in _GExpWardVTPs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpWardVTP _GExpWardVTP, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardVTP] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId WHERE communeCode=@communeCode", 
					"@communeCode",  _GExpWardVTP.communeCode, 
					"@communeName",  _GExpWardVTP.communeName, 
					"@districtCode",  _GExpWardVTP.districtCode, 
					"@WardId",  _GExpWardVTP.WardId, 
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpWardVTP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpWardVTP _GExpWardVTP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardVTP] SET communeName=@communeName, districtCode=@districtCode, WardId=@WardId WHERE communeCode=@communeCode", 
					"@communeName",  _GExpWardVTP.communeName, 
					"@districtCode",  _GExpWardVTP.districtCode, 
					"@WardId",  _GExpWardVTP.WardId, 
					"@communeCode", _GExpWardVTP.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpWardVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpWardVTP> _GExpWardVTPs)
		{
			foreach (GExpWardVTP item in _GExpWardVTPs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardVTP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpWardVTP _GExpWardVTP, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardVTP] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId "+ condition, 
					"@communeCode",  _GExpWardVTP.communeCode, 
					"@communeName",  _GExpWardVTP.communeName, 
					"@districtCode",  _GExpWardVTP.districtCode, 
					"@WardId",  _GExpWardVTP.WardId);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpWardVTP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardVTP] WHERE communeCode=@communeCode",
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardVTP trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpWardVTP _GExpWardVTP)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardVTP] WHERE communeCode=@communeCode",
					"@communeCode", _GExpWardVTP.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardVTP trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardVTP] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardVTP trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpWardVTP> _GExpWardVTPs)
		{
			foreach (GExpWardVTP item in _GExpWardVTPs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
