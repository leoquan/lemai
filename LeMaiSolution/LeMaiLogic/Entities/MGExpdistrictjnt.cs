using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdistrictjnt:IGExpdistrictjnt
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdistrictjnt(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDistrictJNT từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictJNT]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDistrictJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictJNT] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDistrictJNT từ Database
		/// </summary>
		public List<GExpDistrictJNT> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictJNT]");
				List<GExpDistrictJNT> items = new List<GExpDistrictJNT>();
				GExpDistrictJNT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrictJNT();
					if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
					{
						item.districtCode = Convert.ToString(dr["districtCode"]);
					}
					if (dr["districtName"] != null && dr["districtName"] != DBNull.Value)
					{
						item.districtName = Convert.ToString(dr["districtName"]);
					}
					if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
					{
						item.provinceCode = Convert.ToString(dr["provinceCode"]);
					}
					if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
					{
						item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
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
		/// Lấy danh sách GExpDistrictJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDistrictJNT> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrictJNT] A "+ condition,  parameters);
				List<GExpDistrictJNT> items = new List<GExpDistrictJNT>();
				GExpDistrictJNT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDistrictJNT();
					if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
					{
						item.districtCode = Convert.ToString(dr["districtCode"]);
					}
					if (dr["districtName"] != null && dr["districtName"] != DBNull.Value)
					{
						item.districtName = Convert.ToString(dr["districtName"]);
					}
					if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
					{
						item.provinceCode = Convert.ToString(dr["provinceCode"]);
					}
					if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
					{
						item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
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

		public List<GExpDistrictJNT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrictJNT] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDistrictJNT] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDistrictJNT>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDistrictJNT từ Database
		/// </summary>
		public GExpDistrictJNT GetObject(string schema, String districtCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDistrictJNT] where districtCode=@districtCode",
					"@districtCode", districtCode);
				if (ds.Rows.Count > 0)
				{
					GExpDistrictJNT item=new GExpDistrictJNT();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
						{
							item.districtCode = Convert.ToString(dr["districtCode"]);
						}
						if (dr["districtName"] != null && dr["districtName"] != DBNull.Value)
						{
							item.districtName = Convert.ToString(dr["districtName"]);
						}
						if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
						{
							item.provinceCode = Convert.ToString(dr["provinceCode"]);
						}
						if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
						{
							item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
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
		/// Lấy một GExpDistrictJNT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDistrictJNT GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDistrictJNT] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDistrictJNT item=new GExpDistrictJNT();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["districtCode"] != null && dr["districtCode"] != DBNull.Value)
						{
							item.districtCode = Convert.ToString(dr["districtCode"]);
						}
						if (dr["districtName"] != null && dr["districtName"] != DBNull.Value)
						{
							item.districtName = Convert.ToString(dr["districtName"]);
						}
						if (dr["provinceCode"] != null && dr["provinceCode"] != DBNull.Value)
						{
							item.provinceCode = Convert.ToString(dr["provinceCode"]);
						}
						if (dr["DistrictID"] != null && dr["DistrictID"] != DBNull.Value)
						{
							item.DistrictID = Convert.ToInt32(dr["DistrictID"]);
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

		public GExpDistrictJNT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDistrictJNT] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDistrictJNT>(ds);
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
		/// Thêm mới GExpDistrictJNT vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDistrictJNT _GExpDistrictJNT)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDistrictJNT](districtCode, districtName, provinceCode, DistrictID) VALUES(@districtCode, @districtName, @provinceCode, @DistrictID)", 
					"@districtCode",  _GExpDistrictJNT.districtCode, 
					"@districtName",  _GExpDistrictJNT.districtName, 
					"@provinceCode",  _GExpDistrictJNT.provinceCode, 
					"@DistrictID",  _GExpDistrictJNT.DistrictID);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDistrictJNT vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDistrictJNT> _GExpDistrictJNTs)
		{
			foreach (GExpDistrictJNT item in _GExpDistrictJNTs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDistrictJNT _GExpDistrictJNT, String districtCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictJNT] SET districtCode=@districtCode, districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID WHERE districtCode=@districtCode", 
					"@districtCode",  _GExpDistrictJNT.districtCode, 
					"@districtName",  _GExpDistrictJNT.districtName, 
					"@provinceCode",  _GExpDistrictJNT.provinceCode, 
					"@DistrictID",  _GExpDistrictJNT.DistrictID, 
					"@districtCode", districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictJNT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDistrictJNT _GExpDistrictJNT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictJNT] SET districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID WHERE districtCode=@districtCode", 
					"@districtName",  _GExpDistrictJNT.districtName, 
					"@provinceCode",  _GExpDistrictJNT.provinceCode, 
					"@DistrictID",  _GExpDistrictJNT.DistrictID, 
					"@districtCode", _GExpDistrictJNT.districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDistrictJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDistrictJNT> _GExpDistrictJNTs)
		{
			foreach (GExpDistrictJNT item in _GExpDistrictJNTs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDistrictJNT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDistrictJNT _GExpDistrictJNT, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDistrictJNT] SET districtCode=@districtCode, districtName=@districtName, provinceCode=@provinceCode, DistrictID=@DistrictID "+ condition, 
					"@districtCode",  _GExpDistrictJNT.districtCode, 
					"@districtName",  _GExpDistrictJNT.districtName, 
					"@provinceCode",  _GExpDistrictJNT.provinceCode, 
					"@DistrictID",  _GExpDistrictJNT.DistrictID);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDistrictJNT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String districtCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictJNT] WHERE districtCode=@districtCode",
					"@districtCode", districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictJNT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDistrictJNT _GExpDistrictJNT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictJNT] WHERE districtCode=@districtCode",
					"@districtCode", _GExpDistrictJNT.districtCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictJNT trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDistrictJNT] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDistrictJNT trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDistrictJNT> _GExpDistrictJNTs)
		{
			foreach (GExpDistrictJNT item in _GExpDistrictJNTs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
