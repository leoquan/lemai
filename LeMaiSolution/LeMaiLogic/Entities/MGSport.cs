using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSport:IGSport
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSport(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsPort từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsPort]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsPort từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsPort] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsPort từ Database
		/// </summary>
		public List<GsPort> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsPort]");
				List<GsPort> items = new List<GsPort>();
				GsPort item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsPort();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["PortName"] != null && dr["PortName"] != DBNull.Value)
					{
						item.PortName = Convert.ToString(dr["PortName"]);
					}
					if (dr["PortAddress"] != null && dr["PortAddress"] != DBNull.Value)
					{
						item.PortAddress = Convert.ToString(dr["PortAddress"]);
					}
					if (dr["PortNameUnsign"] != null && dr["PortNameUnsign"] != DBNull.Value)
					{
						item.PortNameUnsign = Convert.ToString(dr["PortNameUnsign"]);
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
		/// Lấy danh sách GsPort từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsPort> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsPort] A "+ condition,  parameters);
				List<GsPort> items = new List<GsPort>();
				GsPort item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsPort();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["PortName"] != null && dr["PortName"] != DBNull.Value)
					{
						item.PortName = Convert.ToString(dr["PortName"]);
					}
					if (dr["PortAddress"] != null && dr["PortAddress"] != DBNull.Value)
					{
						item.PortAddress = Convert.ToString(dr["PortAddress"]);
					}
					if (dr["PortNameUnsign"] != null && dr["PortNameUnsign"] != DBNull.Value)
					{
						item.PortNameUnsign = Convert.ToString(dr["PortNameUnsign"]);
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

		public List<GsPort> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsPort] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsPort] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsPort>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsPort từ Database
		/// </summary>
		public GsPort GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsPort] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsPort item=new GsPort();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["PortName"] != null && dr["PortName"] != DBNull.Value)
						{
							item.PortName = Convert.ToString(dr["PortName"]);
						}
						if (dr["PortAddress"] != null && dr["PortAddress"] != DBNull.Value)
						{
							item.PortAddress = Convert.ToString(dr["PortAddress"]);
						}
						if (dr["PortNameUnsign"] != null && dr["PortNameUnsign"] != DBNull.Value)
						{
							item.PortNameUnsign = Convert.ToString(dr["PortNameUnsign"]);
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
		/// Lấy một GsPort đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsPort GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsPort] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsPort item=new GsPort();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["PortName"] != null && dr["PortName"] != DBNull.Value)
						{
							item.PortName = Convert.ToString(dr["PortName"]);
						}
						if (dr["PortAddress"] != null && dr["PortAddress"] != DBNull.Value)
						{
							item.PortAddress = Convert.ToString(dr["PortAddress"]);
						}
						if (dr["PortNameUnsign"] != null && dr["PortNameUnsign"] != DBNull.Value)
						{
							item.PortNameUnsign = Convert.ToString(dr["PortNameUnsign"]);
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

		public GsPort GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsPort] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsPort>(ds);
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
		/// Thêm mới GsPort vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsPort _GsPort)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsPort](Id, PortName, PortAddress, PortNameUnsign) VALUES(@Id, @PortName, @PortAddress, @PortNameUnsign)", 
					"@Id",  _GsPort.Id, 
					"@PortName",  _GsPort.PortName, 
					"@PortAddress",  _GsPort.PortAddress, 
					"@PortNameUnsign",  _GsPort.PortNameUnsign);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsPort vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsPort> _GsPorts)
		{
			foreach (GsPort item in _GsPorts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsPort vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsPort _GsPort, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsPort] SET Id=@Id, PortName=@PortName, PortAddress=@PortAddress, PortNameUnsign=@PortNameUnsign WHERE Id=@Id", 
					"@Id",  _GsPort.Id, 
					"@PortName",  _GsPort.PortName, 
					"@PortAddress",  _GsPort.PortAddress, 
					"@PortNameUnsign",  _GsPort.PortNameUnsign, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsPort vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsPort _GsPort)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsPort] SET PortName=@PortName, PortAddress=@PortAddress, PortNameUnsign=@PortNameUnsign WHERE Id=@Id", 
					"@PortName",  _GsPort.PortName, 
					"@PortAddress",  _GsPort.PortAddress, 
					"@PortNameUnsign",  _GsPort.PortNameUnsign, 
					"@Id", _GsPort.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsPort vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsPort> _GsPorts)
		{
			foreach (GsPort item in _GsPorts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsPort vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsPort _GsPort, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsPort] SET Id=@Id, PortName=@PortName, PortAddress=@PortAddress, PortNameUnsign=@PortNameUnsign "+ condition, 
					"@Id",  _GsPort.Id, 
					"@PortName",  _GsPort.PortName, 
					"@PortAddress",  _GsPort.PortAddress, 
					"@PortNameUnsign",  _GsPort.PortNameUnsign);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsPort trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsPort] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsPort trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsPort _GsPort)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsPort] WHERE Id=@Id",
					"@Id", _GsPort.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsPort trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsPort] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsPort trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsPort> _GsPorts)
		{
			foreach (GsPort item in _GsPorts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
