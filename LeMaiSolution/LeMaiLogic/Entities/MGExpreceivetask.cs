using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpreceivetask:IGExpreceivetask
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpreceivetask(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpReceiveTask từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpReceiveTask]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpReceiveTask từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpReceiveTask] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpReceiveTask từ Database
		/// </summary>
		public List<GExpReceiveTask> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpReceiveTask]");
				List<GExpReceiveTask> items = new List<GExpReceiveTask>();
				GExpReceiveTask item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpReceiveTask();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
					{
						item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
					}
					if (dr["FK_ShipperId"] != null && dr["FK_ShipperId"] != DBNull.Value)
					{
						item.FK_ShipperId = Convert.ToString(dr["FK_ShipperId"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["ReceiveStatus"] != null && dr["ReceiveStatus"] != DBNull.Value)
					{
						item.ReceiveStatus = Convert.ToInt32(dr["ReceiveStatus"]);
					}
					if (dr["FK_PickupShipper"] != null && dr["FK_PickupShipper"] != DBNull.Value)
					{
						item.FK_PickupShipper = Convert.ToString(dr["FK_PickupShipper"]);
					}
					if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
					{
						item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
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
		/// Lấy danh sách GExpReceiveTask từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpReceiveTask> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpReceiveTask] A "+ condition,  parameters);
				List<GExpReceiveTask> items = new List<GExpReceiveTask>();
				GExpReceiveTask item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpReceiveTask();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
					{
						item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
					}
					if (dr["FK_ShipperId"] != null && dr["FK_ShipperId"] != DBNull.Value)
					{
						item.FK_ShipperId = Convert.ToString(dr["FK_ShipperId"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["ReceiveStatus"] != null && dr["ReceiveStatus"] != DBNull.Value)
					{
						item.ReceiveStatus = Convert.ToInt32(dr["ReceiveStatus"]);
					}
					if (dr["FK_PickupShipper"] != null && dr["FK_PickupShipper"] != DBNull.Value)
					{
						item.FK_PickupShipper = Convert.ToString(dr["FK_PickupShipper"]);
					}
					if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
					{
						item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
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

		public List<GExpReceiveTask> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpReceiveTask] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpReceiveTask] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpReceiveTask>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpReceiveTask từ Database
		/// </summary>
		public GExpReceiveTask GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpReceiveTask] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpReceiveTask item=new GExpReceiveTask();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
						{
							item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
						}
						if (dr["FK_ShipperId"] != null && dr["FK_ShipperId"] != DBNull.Value)
						{
							item.FK_ShipperId = Convert.ToString(dr["FK_ShipperId"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["ReceiveStatus"] != null && dr["ReceiveStatus"] != DBNull.Value)
						{
							item.ReceiveStatus = Convert.ToInt32(dr["ReceiveStatus"]);
						}
						if (dr["FK_PickupShipper"] != null && dr["FK_PickupShipper"] != DBNull.Value)
						{
							item.FK_PickupShipper = Convert.ToString(dr["FK_PickupShipper"]);
						}
						if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
						{
							item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
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
		/// Lấy một GExpReceiveTask đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpReceiveTask GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpReceiveTask] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpReceiveTask item=new GExpReceiveTask();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
						{
							item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
						}
						if (dr["FK_ShipperId"] != null && dr["FK_ShipperId"] != DBNull.Value)
						{
							item.FK_ShipperId = Convert.ToString(dr["FK_ShipperId"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["ReceiveStatus"] != null && dr["ReceiveStatus"] != DBNull.Value)
						{
							item.ReceiveStatus = Convert.ToInt32(dr["ReceiveStatus"]);
						}
						if (dr["FK_PickupShipper"] != null && dr["FK_PickupShipper"] != DBNull.Value)
						{
							item.FK_PickupShipper = Convert.ToString(dr["FK_PickupShipper"]);
						}
						if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
						{
							item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
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

		public GExpReceiveTask GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpReceiveTask] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpReceiveTask>(ds);
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
		/// Thêm mới GExpReceiveTask vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpReceiveTask _GExpReceiveTask)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpReceiveTask](Id, FK_CustomerId, FK_ShipperId, CreateDate, FK_Post, FK_Account, Note, ReceiveStatus, FK_PickupShipper, PickupDate) VALUES(@Id, @FK_CustomerId, @FK_ShipperId, @CreateDate, @FK_Post, @FK_Account, @Note, @ReceiveStatus, @FK_PickupShipper, @PickupDate)", 
					"@Id",  _GExpReceiveTask.Id, 
					"@FK_CustomerId",  _GExpReceiveTask.FK_CustomerId, 
					"@FK_ShipperId",  _GExpReceiveTask.FK_ShipperId, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpReceiveTask.CreateDate), 
					"@FK_Post",  _GExpReceiveTask.FK_Post, 
					"@FK_Account",  _GExpReceiveTask.FK_Account, 
					"@Note",  _GExpReceiveTask.Note, 
					"@ReceiveStatus",  _GExpReceiveTask.ReceiveStatus, 
					"@FK_PickupShipper",  _GExpReceiveTask.FK_PickupShipper, 
					"@PickupDate", this._dataContext.ConvertDateString( _GExpReceiveTask.PickupDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpReceiveTask vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpReceiveTask> _GExpReceiveTasks)
		{
			foreach (GExpReceiveTask item in _GExpReceiveTasks)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpReceiveTask vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpReceiveTask _GExpReceiveTask, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpReceiveTask] SET Id=@Id, FK_CustomerId=@FK_CustomerId, FK_ShipperId=@FK_ShipperId, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note, ReceiveStatus=@ReceiveStatus, FK_PickupShipper=@FK_PickupShipper, PickupDate=@PickupDate WHERE Id=@Id", 
					"@Id",  _GExpReceiveTask.Id, 
					"@FK_CustomerId",  _GExpReceiveTask.FK_CustomerId, 
					"@FK_ShipperId",  _GExpReceiveTask.FK_ShipperId, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpReceiveTask.CreateDate), 
					"@FK_Post",  _GExpReceiveTask.FK_Post, 
					"@FK_Account",  _GExpReceiveTask.FK_Account, 
					"@Note",  _GExpReceiveTask.Note, 
					"@ReceiveStatus",  _GExpReceiveTask.ReceiveStatus, 
					"@FK_PickupShipper",  _GExpReceiveTask.FK_PickupShipper, 
					"@PickupDate", this._dataContext.ConvertDateString( _GExpReceiveTask.PickupDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpReceiveTask vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpReceiveTask _GExpReceiveTask)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpReceiveTask] SET FK_CustomerId=@FK_CustomerId, FK_ShipperId=@FK_ShipperId, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note, ReceiveStatus=@ReceiveStatus, FK_PickupShipper=@FK_PickupShipper, PickupDate=@PickupDate WHERE Id=@Id", 
					"@FK_CustomerId",  _GExpReceiveTask.FK_CustomerId, 
					"@FK_ShipperId",  _GExpReceiveTask.FK_ShipperId, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpReceiveTask.CreateDate), 
					"@FK_Post",  _GExpReceiveTask.FK_Post, 
					"@FK_Account",  _GExpReceiveTask.FK_Account, 
					"@Note",  _GExpReceiveTask.Note, 
					"@ReceiveStatus",  _GExpReceiveTask.ReceiveStatus, 
					"@FK_PickupShipper",  _GExpReceiveTask.FK_PickupShipper, 
					"@PickupDate", this._dataContext.ConvertDateString( _GExpReceiveTask.PickupDate), 
					"@Id", _GExpReceiveTask.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpReceiveTask vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpReceiveTask> _GExpReceiveTasks)
		{
			foreach (GExpReceiveTask item in _GExpReceiveTasks)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpReceiveTask vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpReceiveTask _GExpReceiveTask, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpReceiveTask] SET Id=@Id, FK_CustomerId=@FK_CustomerId, FK_ShipperId=@FK_ShipperId, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note, ReceiveStatus=@ReceiveStatus, FK_PickupShipper=@FK_PickupShipper, PickupDate=@PickupDate "+ condition, 
					"@Id",  _GExpReceiveTask.Id, 
					"@FK_CustomerId",  _GExpReceiveTask.FK_CustomerId, 
					"@FK_ShipperId",  _GExpReceiveTask.FK_ShipperId, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpReceiveTask.CreateDate), 
					"@FK_Post",  _GExpReceiveTask.FK_Post, 
					"@FK_Account",  _GExpReceiveTask.FK_Account, 
					"@Note",  _GExpReceiveTask.Note, 
					"@ReceiveStatus",  _GExpReceiveTask.ReceiveStatus, 
					"@FK_PickupShipper",  _GExpReceiveTask.FK_PickupShipper, 
					"@PickupDate", this._dataContext.ConvertDateString( _GExpReceiveTask.PickupDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpReceiveTask trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpReceiveTask] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpReceiveTask trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpReceiveTask _GExpReceiveTask)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpReceiveTask] WHERE Id=@Id",
					"@Id", _GExpReceiveTask.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpReceiveTask trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpReceiveTask] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpReceiveTask trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpReceiveTask> _GExpReceiveTasks)
		{
			foreach (GExpReceiveTask item in _GExpReceiveTasks)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
