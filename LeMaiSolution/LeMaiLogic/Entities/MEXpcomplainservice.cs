using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcomplainservice:IEXpcomplainservice
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcomplainservice(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpComplainService từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpComplainService]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpComplainService từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpComplainService] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpComplainService từ Database
		/// </summary>
		public List<ExpComplainService> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpComplainService]");
				List<ExpComplainService> items = new List<ExpComplainService>();
				ExpComplainService item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpComplainService();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["TypeService"] != null && dr["TypeService"] != DBNull.Value)
					{
						item.TypeService = Convert.ToString(dr["TypeService"]);
					}
					if (dr["ContentComplain"] != null && dr["ContentComplain"] != DBNull.Value)
					{
						item.ContentComplain = Convert.ToString(dr["ContentComplain"]);
					}
					if (dr["DestinationComplain"] != null && dr["DestinationComplain"] != DBNull.Value)
					{
						item.DestinationComplain = Convert.ToString(dr["DestinationComplain"]);
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
		/// Lấy danh sách ExpComplainService từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpComplainService> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpComplainService] A "+ condition,  parameters);
				List<ExpComplainService> items = new List<ExpComplainService>();
				ExpComplainService item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpComplainService();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["TypeService"] != null && dr["TypeService"] != DBNull.Value)
					{
						item.TypeService = Convert.ToString(dr["TypeService"]);
					}
					if (dr["ContentComplain"] != null && dr["ContentComplain"] != DBNull.Value)
					{
						item.ContentComplain = Convert.ToString(dr["ContentComplain"]);
					}
					if (dr["DestinationComplain"] != null && dr["DestinationComplain"] != DBNull.Value)
					{
						item.DestinationComplain = Convert.ToString(dr["DestinationComplain"]);
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

		public List<ExpComplainService> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpComplainService] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpComplainService] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpComplainService>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpComplainService từ Database
		/// </summary>
		public ExpComplainService GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpComplainService] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpComplainService item=new ExpComplainService();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["TypeService"] != null && dr["TypeService"] != DBNull.Value)
						{
							item.TypeService = Convert.ToString(dr["TypeService"]);
						}
						if (dr["ContentComplain"] != null && dr["ContentComplain"] != DBNull.Value)
						{
							item.ContentComplain = Convert.ToString(dr["ContentComplain"]);
						}
						if (dr["DestinationComplain"] != null && dr["DestinationComplain"] != DBNull.Value)
						{
							item.DestinationComplain = Convert.ToString(dr["DestinationComplain"]);
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
		/// Lấy một ExpComplainService đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpComplainService GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpComplainService] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpComplainService item=new ExpComplainService();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["TypeService"] != null && dr["TypeService"] != DBNull.Value)
						{
							item.TypeService = Convert.ToString(dr["TypeService"]);
						}
						if (dr["ContentComplain"] != null && dr["ContentComplain"] != DBNull.Value)
						{
							item.ContentComplain = Convert.ToString(dr["ContentComplain"]);
						}
						if (dr["DestinationComplain"] != null && dr["DestinationComplain"] != DBNull.Value)
						{
							item.DestinationComplain = Convert.ToString(dr["DestinationComplain"]);
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

		public ExpComplainService GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpComplainService] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpComplainService>(ds);
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
		/// Thêm mới ExpComplainService vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpComplainService _ExpComplainService)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpComplainService](Id, BillCode, CreateDate, CreateBy, TypeService, ContentComplain, DestinationComplain) VALUES(@Id, @BillCode, @CreateDate, @CreateBy, @TypeService, @ContentComplain, @DestinationComplain)", 
					"@Id",  _ExpComplainService.Id, 
					"@BillCode",  _ExpComplainService.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpComplainService.CreateDate), 
					"@CreateBy",  _ExpComplainService.CreateBy, 
					"@TypeService",  _ExpComplainService.TypeService, 
					"@ContentComplain",  _ExpComplainService.ContentComplain, 
					"@DestinationComplain",  _ExpComplainService.DestinationComplain);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpComplainService vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpComplainService> _ExpComplainServices)
		{
			foreach (ExpComplainService item in _ExpComplainServices)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpComplainService vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpComplainService _ExpComplainService, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpComplainService] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, CreateBy=@CreateBy, TypeService=@TypeService, ContentComplain=@ContentComplain, DestinationComplain=@DestinationComplain WHERE Id=@Id", 
					"@Id",  _ExpComplainService.Id, 
					"@BillCode",  _ExpComplainService.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpComplainService.CreateDate), 
					"@CreateBy",  _ExpComplainService.CreateBy, 
					"@TypeService",  _ExpComplainService.TypeService, 
					"@ContentComplain",  _ExpComplainService.ContentComplain, 
					"@DestinationComplain",  _ExpComplainService.DestinationComplain, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpComplainService vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpComplainService _ExpComplainService)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpComplainService] SET BillCode=@BillCode, CreateDate=@CreateDate, CreateBy=@CreateBy, TypeService=@TypeService, ContentComplain=@ContentComplain, DestinationComplain=@DestinationComplain WHERE Id=@Id", 
					"@BillCode",  _ExpComplainService.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpComplainService.CreateDate), 
					"@CreateBy",  _ExpComplainService.CreateBy, 
					"@TypeService",  _ExpComplainService.TypeService, 
					"@ContentComplain",  _ExpComplainService.ContentComplain, 
					"@DestinationComplain",  _ExpComplainService.DestinationComplain, 
					"@Id", _ExpComplainService.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpComplainService vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpComplainService> _ExpComplainServices)
		{
			foreach (ExpComplainService item in _ExpComplainServices)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpComplainService vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpComplainService _ExpComplainService, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpComplainService] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, CreateBy=@CreateBy, TypeService=@TypeService, ContentComplain=@ContentComplain, DestinationComplain=@DestinationComplain "+ condition, 
					"@Id",  _ExpComplainService.Id, 
					"@BillCode",  _ExpComplainService.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpComplainService.CreateDate), 
					"@CreateBy",  _ExpComplainService.CreateBy, 
					"@TypeService",  _ExpComplainService.TypeService, 
					"@ContentComplain",  _ExpComplainService.ContentComplain, 
					"@DestinationComplain",  _ExpComplainService.DestinationComplain);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpComplainService trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpComplainService] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpComplainService trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpComplainService _ExpComplainService)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpComplainService] WHERE Id=@Id",
					"@Id", _ExpComplainService.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpComplainService trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpComplainService] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpComplainService trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpComplainService> _ExpComplainServices)
		{
			foreach (ExpComplainService item in _ExpComplainServices)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
