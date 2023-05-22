using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprovincejnt:IGExpprovincejnt
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprovincejnt(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProvinceJNT từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceJNT]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProvinceJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceJNT] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProvinceJNT từ Database
		/// </summary>
		public List<GExpProvinceJNT> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceJNT]");
				List<GExpProvinceJNT> items = new List<GExpProvinceJNT>();
				GExpProvinceJNT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceJNT();
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
		/// Lấy danh sách GExpProvinceJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProvinceJNT> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceJNT] A "+ condition,  parameters);
				List<GExpProvinceJNT> items = new List<GExpProvinceJNT>();
				GExpProvinceJNT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceJNT();
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

		public List<GExpProvinceJNT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceJNT] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProvinceJNT] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProvinceJNT>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProvinceJNT từ Database
		/// </summary>
		public GExpProvinceJNT GetObject(string schema, String provinceCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceJNT] where provinceCode=@provinceCode",
					"@provinceCode", provinceCode);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceJNT item=new GExpProvinceJNT();
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
		/// Lấy một GExpProvinceJNT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProvinceJNT GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceJNT] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceJNT item=new GExpProvinceJNT();
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

		public GExpProvinceJNT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceJNT] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProvinceJNT>(ds);
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
		/// Thêm mới GExpProvinceJNT vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProvinceJNT _GExpProvinceJNT)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProvinceJNT](provinceCode, provinceName, ProvinceID) VALUES(@provinceCode, @provinceName, @ProvinceID)", 
					"@provinceCode",  _GExpProvinceJNT.provinceCode, 
					"@provinceName",  _GExpProvinceJNT.provinceName, 
					"@ProvinceID",  _GExpProvinceJNT.ProvinceID);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceJNT vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProvinceJNT> _GExpProvinceJNTs)
		{
			foreach (GExpProvinceJNT item in _GExpProvinceJNTs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProvinceJNT _GExpProvinceJNT, String provinceCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceJNT] SET provinceCode=@provinceCode, provinceName=@provinceName, ProvinceID=@ProvinceID WHERE provinceCode=@provinceCode", 
					"@provinceCode",  _GExpProvinceJNT.provinceCode, 
					"@provinceName",  _GExpProvinceJNT.provinceName, 
					"@ProvinceID",  _GExpProvinceJNT.ProvinceID, 
					"@provinceCode", provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceJNT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProvinceJNT _GExpProvinceJNT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceJNT] SET provinceName=@provinceName, ProvinceID=@ProvinceID WHERE provinceCode=@provinceCode", 
					"@provinceName",  _GExpProvinceJNT.provinceName, 
					"@ProvinceID",  _GExpProvinceJNT.ProvinceID, 
					"@provinceCode", _GExpProvinceJNT.provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProvinceJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProvinceJNT> _GExpProvinceJNTs)
		{
			foreach (GExpProvinceJNT item in _GExpProvinceJNTs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceJNT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProvinceJNT _GExpProvinceJNT, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceJNT] SET provinceCode=@provinceCode, provinceName=@provinceName, ProvinceID=@ProvinceID "+ condition, 
					"@provinceCode",  _GExpProvinceJNT.provinceCode, 
					"@provinceName",  _GExpProvinceJNT.provinceName, 
					"@ProvinceID",  _GExpProvinceJNT.ProvinceID);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProvinceJNT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String provinceCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceJNT] WHERE provinceCode=@provinceCode",
					"@provinceCode", provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceJNT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProvinceJNT _GExpProvinceJNT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceJNT] WHERE provinceCode=@provinceCode",
					"@provinceCode", _GExpProvinceJNT.provinceCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceJNT trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceJNT] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceJNT trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProvinceJNT> _GExpProvinceJNTs)
		{
			foreach (GExpProvinceJNT item in _GExpProvinceJNTs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
