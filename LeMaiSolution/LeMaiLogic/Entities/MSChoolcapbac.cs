using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSChoolcapbac:ISChoolcapbac
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSChoolcapbac(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SchoolCapBac từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolCapBac]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SchoolCapBac từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolCapBac] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SchoolCapBac từ Database
		/// </summary>
		public List<SchoolCapBac> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolCapBac]");
				List<SchoolCapBac> items = new List<SchoolCapBac>();
				SchoolCapBac item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolCapBac();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CapBac"] != null && dr["CapBac"] != DBNull.Value)
					{
						item.CapBac = Convert.ToString(dr["CapBac"]);
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
		/// Lấy danh sách SchoolCapBac từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SchoolCapBac> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolCapBac] A "+ condition,  parameters);
				List<SchoolCapBac> items = new List<SchoolCapBac>();
				SchoolCapBac item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolCapBac();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CapBac"] != null && dr["CapBac"] != DBNull.Value)
					{
						item.CapBac = Convert.ToString(dr["CapBac"]);
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

		public List<SchoolCapBac> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolCapBac] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SchoolCapBac] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SchoolCapBac>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SchoolCapBac từ Database
		/// </summary>
		public SchoolCapBac GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolCapBac] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SchoolCapBac item=new SchoolCapBac();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CapBac"] != null && dr["CapBac"] != DBNull.Value)
						{
							item.CapBac = Convert.ToString(dr["CapBac"]);
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
		/// Lấy một SchoolCapBac đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SchoolCapBac GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolCapBac] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SchoolCapBac item=new SchoolCapBac();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CapBac"] != null && dr["CapBac"] != DBNull.Value)
						{
							item.CapBac = Convert.ToString(dr["CapBac"]);
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

		public SchoolCapBac GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolCapBac] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SchoolCapBac>(ds);
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
		/// Thêm mới SchoolCapBac vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SchoolCapBac _SchoolCapBac)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SchoolCapBac](Id, CapBac) VALUES(@Id, @CapBac)", 
					"@Id",  _SchoolCapBac.Id, 
					"@CapBac",  _SchoolCapBac.CapBac);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SchoolCapBac vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SchoolCapBac> _SchoolCapBacs)
		{
			foreach (SchoolCapBac item in _SchoolCapBacs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolCapBac vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SchoolCapBac _SchoolCapBac, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolCapBac] SET Id=@Id, CapBac=@CapBac WHERE Id=@Id", 
					"@Id",  _SchoolCapBac.Id, 
					"@CapBac",  _SchoolCapBac.CapBac, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SchoolCapBac vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SchoolCapBac _SchoolCapBac)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolCapBac] SET CapBac=@CapBac WHERE Id=@Id", 
					"@CapBac",  _SchoolCapBac.CapBac, 
					"@Id", _SchoolCapBac.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SchoolCapBac vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SchoolCapBac> _SchoolCapBacs)
		{
			foreach (SchoolCapBac item in _SchoolCapBacs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolCapBac vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SchoolCapBac _SchoolCapBac, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolCapBac] SET Id=@Id, CapBac=@CapBac "+ condition, 
					"@Id",  _SchoolCapBac.Id, 
					"@CapBac",  _SchoolCapBac.CapBac);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SchoolCapBac trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolCapBac] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolCapBac trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SchoolCapBac _SchoolCapBac)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolCapBac] WHERE Id=@Id",
					"@Id", _SchoolCapBac.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolCapBac trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolCapBac] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolCapBac trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SchoolCapBac> _SchoolCapBacs)
		{
			foreach (SchoolCapBac item in _SchoolCapBacs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
