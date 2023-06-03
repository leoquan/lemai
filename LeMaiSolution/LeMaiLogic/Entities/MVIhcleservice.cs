using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIhcleservice:IVIhcleservice
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIhcleservice(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VihcleService từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleService]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VihcleService từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleService] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VihcleService từ Database
		/// </summary>
		public List<VihcleService> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleService]");
				List<VihcleService> items = new List<VihcleService>();
				VihcleService item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VihcleService();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ServiceName"] != null && dr["ServiceName"] != DBNull.Value)
					{
						item.ServiceName = Convert.ToString(dr["ServiceName"]);
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
		/// Lấy danh sách VihcleService từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VihcleService> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VihcleService] A "+ condition,  parameters);
				List<VihcleService> items = new List<VihcleService>();
				VihcleService item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VihcleService();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ServiceName"] != null && dr["ServiceName"] != DBNull.Value)
					{
						item.ServiceName = Convert.ToString(dr["ServiceName"]);
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

		public List<VihcleService> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VihcleService] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VihcleService] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VihcleService>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VihcleService từ Database
		/// </summary>
		public VihcleService GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleService] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					VihcleService item=new VihcleService();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ServiceName"] != null && dr["ServiceName"] != DBNull.Value)
						{
							item.ServiceName = Convert.ToString(dr["ServiceName"]);
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
		/// Lấy một VihcleService đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VihcleService GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VihcleService] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VihcleService item=new VihcleService();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ServiceName"] != null && dr["ServiceName"] != DBNull.Value)
						{
							item.ServiceName = Convert.ToString(dr["ServiceName"]);
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

		public VihcleService GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VihcleService] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VihcleService>(ds);
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
		/// Thêm mới VihcleService vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VihcleService _VihcleService)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VihcleService](Id, ServiceName) VALUES(@Id, @ServiceName)", 
					"@Id",  _VihcleService.Id, 
					"@ServiceName",  _VihcleService.ServiceName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VihcleService vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VihcleService> _VihcleServices)
		{
			foreach (VihcleService item in _VihcleServices)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VihcleService vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VihcleService _VihcleService, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleService] SET Id=@Id, ServiceName=@ServiceName WHERE Id=@Id", 
					"@Id",  _VihcleService.Id, 
					"@ServiceName",  _VihcleService.ServiceName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VihcleService vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VihcleService _VihcleService)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleService] SET ServiceName=@ServiceName WHERE Id=@Id", 
					"@ServiceName",  _VihcleService.ServiceName, 
					"@Id", _VihcleService.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VihcleService vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VihcleService> _VihcleServices)
		{
			foreach (VihcleService item in _VihcleServices)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VihcleService vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VihcleService _VihcleService, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleService] SET Id=@Id, ServiceName=@ServiceName "+ condition, 
					"@Id",  _VihcleService.Id, 
					"@ServiceName",  _VihcleService.ServiceName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VihcleService trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleService] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleService trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VihcleService _VihcleService)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleService] WHERE Id=@Id",
					"@Id", _VihcleService.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleService trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleService] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleService trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VihcleService> _VihcleServices)
		{
			foreach (VihcleService item in _VihcleServices)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
