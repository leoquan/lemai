using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpscantype:IGExpscantype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpscantype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpScanType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpScanType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpScanType từ Database
		/// </summary>
		public List<GExpScanType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanType]");
				List<GExpScanType> items = new List<GExpScanType>();
				GExpScanType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ScanName"] != null && dr["ScanName"] != DBNull.Value)
					{
						item.ScanName = Convert.ToString(dr["ScanName"]);
					}
					if (dr["FormatRegexString"] != null && dr["FormatRegexString"] != DBNull.Value)
					{
						item.FormatRegexString = Convert.ToString(dr["FormatRegexString"]);
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
		/// Lấy danh sách GExpScanType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpScanType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanType] A "+ condition,  parameters);
				List<GExpScanType> items = new List<GExpScanType>();
				GExpScanType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ScanName"] != null && dr["ScanName"] != DBNull.Value)
					{
						item.ScanName = Convert.ToString(dr["ScanName"]);
					}
					if (dr["FormatRegexString"] != null && dr["FormatRegexString"] != DBNull.Value)
					{
						item.FormatRegexString = Convert.ToString(dr["FormatRegexString"]);
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

		public List<GExpScanType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpScanType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpScanType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpScanType từ Database
		/// </summary>
		public GExpScanType GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpScanType item=new GExpScanType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ScanName"] != null && dr["ScanName"] != DBNull.Value)
						{
							item.ScanName = Convert.ToString(dr["ScanName"]);
						}
						if (dr["FormatRegexString"] != null && dr["FormatRegexString"] != DBNull.Value)
						{
							item.FormatRegexString = Convert.ToString(dr["FormatRegexString"]);
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
		/// Lấy một GExpScanType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpScanType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpScanType item=new GExpScanType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ScanName"] != null && dr["ScanName"] != DBNull.Value)
						{
							item.ScanName = Convert.ToString(dr["ScanName"]);
						}
						if (dr["FormatRegexString"] != null && dr["FormatRegexString"] != DBNull.Value)
						{
							item.FormatRegexString = Convert.ToString(dr["FormatRegexString"]);
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

		public GExpScanType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpScanType>(ds);
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
		/// Thêm mới GExpScanType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpScanType _GExpScanType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpScanType](Id, ScanName, FormatRegexString) VALUES(@Id, @ScanName, @FormatRegexString)", 
					"@Id",  _GExpScanType.Id, 
					"@ScanName",  _GExpScanType.ScanName, 
					"@FormatRegexString",  _GExpScanType.FormatRegexString);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpScanType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpScanType> _GExpScanTypes)
		{
			foreach (GExpScanType item in _GExpScanTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpScanType _GExpScanType, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanType] SET Id=@Id, ScanName=@ScanName, FormatRegexString=@FormatRegexString WHERE Id=@Id", 
					"@Id",  _GExpScanType.Id, 
					"@ScanName",  _GExpScanType.ScanName, 
					"@FormatRegexString",  _GExpScanType.FormatRegexString, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpScanType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpScanType _GExpScanType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanType] SET ScanName=@ScanName, FormatRegexString=@FormatRegexString WHERE Id=@Id", 
					"@ScanName",  _GExpScanType.ScanName, 
					"@FormatRegexString",  _GExpScanType.FormatRegexString, 
					"@Id", _GExpScanType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpScanType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpScanType> _GExpScanTypes)
		{
			foreach (GExpScanType item in _GExpScanTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpScanType _GExpScanType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanType] SET Id=@Id, ScanName=@ScanName, FormatRegexString=@FormatRegexString "+ condition, 
					"@Id",  _GExpScanType.Id, 
					"@ScanName",  _GExpScanType.ScanName, 
					"@FormatRegexString",  _GExpScanType.FormatRegexString);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpScanType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpScanType _GExpScanType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanType] WHERE Id=@Id",
					"@Id", _GExpScanType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpScanType> _GExpScanTypes)
		{
			foreach (GExpScanType item in _GExpScanTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
