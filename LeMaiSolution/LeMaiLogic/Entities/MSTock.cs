using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSTock:ISTock
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSTock(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable Stock từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Stock]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable Stock từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Stock] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách Stock từ Database
		/// </summary>
		public List<Stock> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Stock]");
				List<Stock> items = new List<Stock>();
				Stock item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Stock();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["IsMatter"] != null && dr["IsMatter"] != DBNull.Value)
					{
						item.IsMatter = Convert.ToBoolean(dr["IsMatter"]);
					}
					if (dr["FK_Owner"] != null && dr["FK_Owner"] != DBNull.Value)
					{
						item.FK_Owner = Convert.ToString(dr["FK_Owner"]);
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
		/// Lấy danh sách Stock từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<Stock> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Stock] A "+ condition,  parameters);
				List<Stock> items = new List<Stock>();
				Stock item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Stock();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["IsMatter"] != null && dr["IsMatter"] != DBNull.Value)
					{
						item.IsMatter = Convert.ToBoolean(dr["IsMatter"]);
					}
					if (dr["FK_Owner"] != null && dr["FK_Owner"] != DBNull.Value)
					{
						item.FK_Owner = Convert.ToString(dr["FK_Owner"]);
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

		public List<Stock> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Stock] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[Stock] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<Stock>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một Stock từ Database
		/// </summary>
		public Stock GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Stock] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					Stock item=new Stock();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["IsMatter"] != null && dr["IsMatter"] != DBNull.Value)
						{
							item.IsMatter = Convert.ToBoolean(dr["IsMatter"]);
						}
						if (dr["FK_Owner"] != null && dr["FK_Owner"] != DBNull.Value)
						{
							item.FK_Owner = Convert.ToString(dr["FK_Owner"]);
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
		/// Lấy một Stock đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public Stock GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Stock] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					Stock item=new Stock();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["IsMatter"] != null && dr["IsMatter"] != DBNull.Value)
						{
							item.IsMatter = Convert.ToBoolean(dr["IsMatter"]);
						}
						if (dr["FK_Owner"] != null && dr["FK_Owner"] != DBNull.Value)
						{
							item.FK_Owner = Convert.ToString(dr["FK_Owner"]);
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

		public Stock GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Stock] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<Stock>(ds);
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
		/// Thêm mới Stock vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, Stock _Stock)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[Stock](Id, Name, FK_Branch, IsMatter, FK_Owner) VALUES(@Id, @Name, @FK_Branch, @IsMatter, @FK_Owner)", 
					"@Id",  _Stock.Id, 
					"@Name",  _Stock.Name, 
					"@FK_Branch",  _Stock.FK_Branch, 
					"@IsMatter",  _Stock.IsMatter, 
					"@FK_Owner",  _Stock.FK_Owner);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng Stock vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<Stock> _Stocks)
		{
			foreach (Stock item in _Stocks)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Stock vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, Stock _Stock, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Stock] SET Id=@Id, Name=@Name, FK_Branch=@FK_Branch, IsMatter=@IsMatter, FK_Owner=@FK_Owner WHERE Id=@Id", 
					"@Id",  _Stock.Id, 
					"@Name",  _Stock.Name, 
					"@FK_Branch",  _Stock.FK_Branch, 
					"@IsMatter",  _Stock.IsMatter, 
					"@FK_Owner",  _Stock.FK_Owner, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật Stock vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, Stock _Stock)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Stock] SET Name=@Name, FK_Branch=@FK_Branch, IsMatter=@IsMatter, FK_Owner=@FK_Owner WHERE Id=@Id", 
					"@Name",  _Stock.Name, 
					"@FK_Branch",  _Stock.FK_Branch, 
					"@IsMatter",  _Stock.IsMatter, 
					"@FK_Owner",  _Stock.FK_Owner, 
					"@Id", _Stock.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách Stock vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<Stock> _Stocks)
		{
			foreach (Stock item in _Stocks)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Stock vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, Stock _Stock, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Stock] SET Id=@Id, Name=@Name, FK_Branch=@FK_Branch, IsMatter=@IsMatter, FK_Owner=@FK_Owner "+ condition, 
					"@Id",  _Stock.Id, 
					"@Name",  _Stock.Name, 
					"@FK_Branch",  _Stock.FK_Branch, 
					"@IsMatter",  _Stock.IsMatter, 
					"@FK_Owner",  _Stock.FK_Owner);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa Stock trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Stock] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Stock trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Stock _Stock)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Stock] WHERE Id=@Id",
					"@Id", _Stock.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Stock trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Stock] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Stock trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<Stock> _Stocks)
		{
			foreach (Stock item in _Stocks)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
