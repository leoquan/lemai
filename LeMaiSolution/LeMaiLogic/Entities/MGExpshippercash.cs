using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpshippercash:IGExpshippercash
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpshippercash(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpShipperCash từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperCash]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpShipperCash từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperCash] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpShipperCash từ Database
		/// </summary>
		public List<GExpShipperCash> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperCash]");
				List<GExpShipperCash> items = new List<GExpShipperCash>();
				GExpShipperCash item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipperCash();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
					{
						item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["TotalCash"] != null && dr["TotalCash"] != DBNull.Value)
					{
						item.TotalCash = Convert.ToDecimal(dr["TotalCash"]);
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
		/// Lấy danh sách GExpShipperCash từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpShipperCash> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipperCash] A "+ condition,  parameters);
				List<GExpShipperCash> items = new List<GExpShipperCash>();
				GExpShipperCash item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipperCash();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
					{
						item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["TotalCash"] != null && dr["TotalCash"] != DBNull.Value)
					{
						item.TotalCash = Convert.ToDecimal(dr["TotalCash"]);
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

		public List<GExpShipperCash> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipperCash] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpShipperCash] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpShipperCash>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpShipperCash từ Database
		/// </summary>
		public GExpShipperCash GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperCash] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpShipperCash item=new GExpShipperCash();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
						{
							item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["TotalCash"] != null && dr["TotalCash"] != DBNull.Value)
						{
							item.TotalCash = Convert.ToDecimal(dr["TotalCash"]);
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
		/// Lấy một GExpShipperCash đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpShipperCash GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipperCash] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpShipperCash item=new GExpShipperCash();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
						{
							item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["TotalCash"] != null && dr["TotalCash"] != DBNull.Value)
						{
							item.TotalCash = Convert.ToDecimal(dr["TotalCash"]);
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

		public GExpShipperCash GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipperCash] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpShipperCash>(ds);
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
		/// Thêm mới GExpShipperCash vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpShipperCash _GExpShipperCash)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpShipperCash](Id, FK_Shipper, CreateDate, FK_Account, TotalCash) VALUES(@Id, @FK_Shipper, @CreateDate, @FK_Account, @TotalCash)", 
					"@Id",  _GExpShipperCash.Id, 
					"@FK_Shipper",  _GExpShipperCash.FK_Shipper, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpShipperCash.CreateDate), 
					"@FK_Account",  _GExpShipperCash.FK_Account, 
					"@TotalCash",  _GExpShipperCash.TotalCash);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpShipperCash vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpShipperCash> _GExpShipperCashs)
		{
			foreach (GExpShipperCash item in _GExpShipperCashs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperCash vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpShipperCash _GExpShipperCash, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperCash] SET Id=@Id, FK_Shipper=@FK_Shipper, CreateDate=@CreateDate, FK_Account=@FK_Account, TotalCash=@TotalCash WHERE Id=@Id", 
					"@Id",  _GExpShipperCash.Id, 
					"@FK_Shipper",  _GExpShipperCash.FK_Shipper, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpShipperCash.CreateDate), 
					"@FK_Account",  _GExpShipperCash.FK_Account, 
					"@TotalCash",  _GExpShipperCash.TotalCash, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperCash vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpShipperCash _GExpShipperCash)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperCash] SET FK_Shipper=@FK_Shipper, CreateDate=@CreateDate, FK_Account=@FK_Account, TotalCash=@TotalCash WHERE Id=@Id", 
					"@FK_Shipper",  _GExpShipperCash.FK_Shipper, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpShipperCash.CreateDate), 
					"@FK_Account",  _GExpShipperCash.FK_Account, 
					"@TotalCash",  _GExpShipperCash.TotalCash, 
					"@Id", _GExpShipperCash.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpShipperCash vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpShipperCash> _GExpShipperCashs)
		{
			foreach (GExpShipperCash item in _GExpShipperCashs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperCash vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpShipperCash _GExpShipperCash, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperCash] SET Id=@Id, FK_Shipper=@FK_Shipper, CreateDate=@CreateDate, FK_Account=@FK_Account, TotalCash=@TotalCash "+ condition, 
					"@Id",  _GExpShipperCash.Id, 
					"@FK_Shipper",  _GExpShipperCash.FK_Shipper, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpShipperCash.CreateDate), 
					"@FK_Account",  _GExpShipperCash.FK_Account, 
					"@TotalCash",  _GExpShipperCash.TotalCash);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpShipperCash trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperCash] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperCash trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpShipperCash _GExpShipperCash)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperCash] WHERE Id=@Id",
					"@Id", _GExpShipperCash.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperCash trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperCash] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperCash trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpShipperCash> _GExpShipperCashs)
		{
			foreach (GExpShipperCash item in _GExpShipperCashs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
