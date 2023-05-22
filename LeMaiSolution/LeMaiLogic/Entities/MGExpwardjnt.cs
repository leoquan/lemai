using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpwardjnt:IGExpwardjnt
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpwardjnt(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpWardJNT từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardJNT]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpWardJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardJNT] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpWardJNT từ Database
		/// </summary>
		public List<GExpWardJNT> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardJNT]");
				List<GExpWardJNT> items = new List<GExpWardJNT>();
				GExpWardJNT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardJNT();
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
		/// Lấy danh sách GExpWardJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpWardJNT> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardJNT] A "+ condition,  parameters);
				List<GExpWardJNT> items = new List<GExpWardJNT>();
				GExpWardJNT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWardJNT();
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

		public List<GExpWardJNT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardJNT] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpWardJNT] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpWardJNT>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpWardJNT từ Database
		/// </summary>
		public GExpWardJNT GetObject(string schema, String communeCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWardJNT] where communeCode=@communeCode",
					"@communeCode", communeCode);
				if (ds.Rows.Count > 0)
				{
					GExpWardJNT item=new GExpWardJNT();
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
		/// Lấy một GExpWardJNT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpWardJNT GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWardJNT] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpWardJNT item=new GExpWardJNT();
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

		public GExpWardJNT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWardJNT] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpWardJNT>(ds);
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
		/// Thêm mới GExpWardJNT vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpWardJNT _GExpWardJNT)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpWardJNT](communeCode, communeName, districtCode, WardId) VALUES(@communeCode, @communeName, @districtCode, @WardId)", 
					"@communeCode",  _GExpWardJNT.communeCode, 
					"@communeName",  _GExpWardJNT.communeName, 
					"@districtCode",  _GExpWardJNT.districtCode, 
					"@WardId",  _GExpWardJNT.WardId);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpWardJNT vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpWardJNT> _GExpWardJNTs)
		{
			foreach (GExpWardJNT item in _GExpWardJNTs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpWardJNT _GExpWardJNT, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardJNT] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId WHERE communeCode=@communeCode", 
					"@communeCode",  _GExpWardJNT.communeCode, 
					"@communeName",  _GExpWardJNT.communeName, 
					"@districtCode",  _GExpWardJNT.districtCode, 
					"@WardId",  _GExpWardJNT.WardId, 
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpWardJNT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpWardJNT _GExpWardJNT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardJNT] SET communeName=@communeName, districtCode=@districtCode, WardId=@WardId WHERE communeCode=@communeCode", 
					"@communeName",  _GExpWardJNT.communeName, 
					"@districtCode",  _GExpWardJNT.districtCode, 
					"@WardId",  _GExpWardJNT.WardId, 
					"@communeCode", _GExpWardJNT.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpWardJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpWardJNT> _GExpWardJNTs)
		{
			foreach (GExpWardJNT item in _GExpWardJNTs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWardJNT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpWardJNT _GExpWardJNT, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWardJNT] SET communeCode=@communeCode, communeName=@communeName, districtCode=@districtCode, WardId=@WardId "+ condition, 
					"@communeCode",  _GExpWardJNT.communeCode, 
					"@communeName",  _GExpWardJNT.communeName, 
					"@districtCode",  _GExpWardJNT.districtCode, 
					"@WardId",  _GExpWardJNT.WardId);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpWardJNT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String communeCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardJNT] WHERE communeCode=@communeCode",
					"@communeCode", communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardJNT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpWardJNT _GExpWardJNT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardJNT] WHERE communeCode=@communeCode",
					"@communeCode", _GExpWardJNT.communeCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardJNT trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWardJNT] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWardJNT trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpWardJNT> _GExpWardJNTs)
		{
			foreach (GExpWardJNT item in _GExpWardJNTs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
