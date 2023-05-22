using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MPRoductquota:IPRoductquota
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MPRoductquota(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ProductQuota từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ProductQuota]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ProductQuota từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ProductQuota] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ProductQuota từ Database
		/// </summary>
		public List<ProductQuota> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ProductQuota]");
				List<ProductQuota> items = new List<ProductQuota>();
				ProductQuota item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ProductQuota();
					if (dr["FK_ServiceQuota"] != null && dr["FK_ServiceQuota"] != DBNull.Value)
					{
						item.FK_ServiceQuota = Convert.ToString(dr["FK_ServiceQuota"]);
					}
					if (dr["FK_ServiceRefer"] != null && dr["FK_ServiceRefer"] != DBNull.Value)
					{
						item.FK_ServiceRefer = Convert.ToString(dr["FK_ServiceRefer"]);
					}
					if (dr["Quota"] != null && dr["Quota"] != DBNull.Value)
					{
						item.Quota = Convert.ToInt32(dr["Quota"]);
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
		/// Lấy danh sách ProductQuota từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ProductQuota> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ProductQuota] A "+ condition,  parameters);
				List<ProductQuota> items = new List<ProductQuota>();
				ProductQuota item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ProductQuota();
					if (dr["FK_ServiceQuota"] != null && dr["FK_ServiceQuota"] != DBNull.Value)
					{
						item.FK_ServiceQuota = Convert.ToString(dr["FK_ServiceQuota"]);
					}
					if (dr["FK_ServiceRefer"] != null && dr["FK_ServiceRefer"] != DBNull.Value)
					{
						item.FK_ServiceRefer = Convert.ToString(dr["FK_ServiceRefer"]);
					}
					if (dr["Quota"] != null && dr["Quota"] != DBNull.Value)
					{
						item.Quota = Convert.ToInt32(dr["Quota"]);
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

		public List<ProductQuota> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ProductQuota] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ProductQuota] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ProductQuota>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ProductQuota từ Database
		/// </summary>
		public ProductQuota GetObject(string schema, String FK_ServiceQuota, String FK_ServiceRefer)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ProductQuota] where FK_ServiceQuota=@FK_ServiceQuota and FK_ServiceRefer=@FK_ServiceRefer",
					"@FK_ServiceQuota", FK_ServiceQuota, 
					"@FK_ServiceRefer", FK_ServiceRefer);
				if (ds.Rows.Count > 0)
				{
					ProductQuota item=new ProductQuota();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_ServiceQuota"] != null && dr["FK_ServiceQuota"] != DBNull.Value)
						{
							item.FK_ServiceQuota = Convert.ToString(dr["FK_ServiceQuota"]);
						}
						if (dr["FK_ServiceRefer"] != null && dr["FK_ServiceRefer"] != DBNull.Value)
						{
							item.FK_ServiceRefer = Convert.ToString(dr["FK_ServiceRefer"]);
						}
						if (dr["Quota"] != null && dr["Quota"] != DBNull.Value)
						{
							item.Quota = Convert.ToInt32(dr["Quota"]);
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
		/// Lấy một ProductQuota đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ProductQuota GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ProductQuota] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ProductQuota item=new ProductQuota();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_ServiceQuota"] != null && dr["FK_ServiceQuota"] != DBNull.Value)
						{
							item.FK_ServiceQuota = Convert.ToString(dr["FK_ServiceQuota"]);
						}
						if (dr["FK_ServiceRefer"] != null && dr["FK_ServiceRefer"] != DBNull.Value)
						{
							item.FK_ServiceRefer = Convert.ToString(dr["FK_ServiceRefer"]);
						}
						if (dr["Quota"] != null && dr["Quota"] != DBNull.Value)
						{
							item.Quota = Convert.ToInt32(dr["Quota"]);
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

		public ProductQuota GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ProductQuota] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ProductQuota>(ds);
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
		/// Thêm mới ProductQuota vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ProductQuota _ProductQuota)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ProductQuota](FK_ServiceQuota, FK_ServiceRefer, Quota) VALUES(@FK_ServiceQuota, @FK_ServiceRefer, @Quota)", 
					"@FK_ServiceQuota",  _ProductQuota.FK_ServiceQuota, 
					"@FK_ServiceRefer",  _ProductQuota.FK_ServiceRefer, 
					"@Quota",  _ProductQuota.Quota);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ProductQuota vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ProductQuota> _ProductQuotas)
		{
			foreach (ProductQuota item in _ProductQuotas)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ProductQuota vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ProductQuota _ProductQuota, String FK_ServiceQuota, String FK_ServiceRefer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ProductQuota] SET FK_ServiceQuota=@FK_ServiceQuota, FK_ServiceRefer=@FK_ServiceRefer, Quota=@Quota WHERE FK_ServiceQuota=@FK_ServiceQuota and FK_ServiceRefer=@FK_ServiceRefer", 
					"@FK_ServiceQuota",  _ProductQuota.FK_ServiceQuota, 
					"@FK_ServiceRefer",  _ProductQuota.FK_ServiceRefer, 
					"@Quota",  _ProductQuota.Quota, 
					"@FK_ServiceQuota", FK_ServiceQuota, 
					"@FK_ServiceRefer", FK_ServiceRefer);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ProductQuota vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ProductQuota _ProductQuota)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ProductQuota] SET Quota=@Quota WHERE FK_ServiceQuota=@FK_ServiceQuota and FK_ServiceRefer=@FK_ServiceRefer", 
					"@Quota",  _ProductQuota.Quota, 
					"@FK_ServiceQuota", _ProductQuota.FK_ServiceQuota, 
					"@FK_ServiceRefer", _ProductQuota.FK_ServiceRefer);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ProductQuota vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ProductQuota> _ProductQuotas)
		{
			foreach (ProductQuota item in _ProductQuotas)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ProductQuota vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ProductQuota _ProductQuota, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ProductQuota] SET FK_ServiceQuota=@FK_ServiceQuota, FK_ServiceRefer=@FK_ServiceRefer, Quota=@Quota "+ condition, 
					"@FK_ServiceQuota",  _ProductQuota.FK_ServiceQuota, 
					"@FK_ServiceRefer",  _ProductQuota.FK_ServiceRefer, 
					"@Quota",  _ProductQuota.Quota);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ProductQuota trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_ServiceQuota, String FK_ServiceRefer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ProductQuota] WHERE FK_ServiceQuota=@FK_ServiceQuota and FK_ServiceRefer=@FK_ServiceRefer",
					"@FK_ServiceQuota", FK_ServiceQuota, 
					"@FK_ServiceRefer", FK_ServiceRefer);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ProductQuota trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ProductQuota _ProductQuota)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ProductQuota] WHERE FK_ServiceQuota=@FK_ServiceQuota and FK_ServiceRefer=@FK_ServiceRefer",
					"@FK_ServiceQuota", _ProductQuota.FK_ServiceQuota, 
					"@FK_ServiceRefer", _ProductQuota.FK_ServiceRefer);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ProductQuota trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ProductQuota] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ProductQuota trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ProductQuota> _ProductQuotas)
		{
			foreach (ProductQuota item in _ProductQuotas)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
