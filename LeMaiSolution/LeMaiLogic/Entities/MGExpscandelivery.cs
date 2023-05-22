using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpscandelivery:IGExpscandelivery
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpscandelivery(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpScanDelivery từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanDelivery]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpScanDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanDelivery] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpScanDelivery từ Database
		/// </summary>
		public List<GExpScanDelivery> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanDelivery]");
				List<GExpScanDelivery> items = new List<GExpScanDelivery>();
				GExpScanDelivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanDelivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
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
		/// Lấy danh sách GExpScanDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpScanDelivery> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanDelivery] A "+ condition,  parameters);
				List<GExpScanDelivery> items = new List<GExpScanDelivery>();
				GExpScanDelivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanDelivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<GExpScanDelivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanDelivery] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpScanDelivery] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpScanDelivery>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpScanDelivery từ Database
		/// </summary>
		public GExpScanDelivery GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanDelivery] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpScanDelivery item=new GExpScanDelivery();
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
		/// Lấy một GExpScanDelivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpScanDelivery GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanDelivery] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpScanDelivery item=new GExpScanDelivery();
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

		public GExpScanDelivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanDelivery] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpScanDelivery>(ds);
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
		/// Thêm mới GExpScanDelivery vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpScanDelivery _GExpScanDelivery)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpScanDelivery](Id, BillCode, FK_ShipperId, CreateDate, FK_Post, FK_Account, Note) VALUES(@Id, @BillCode, @FK_ShipperId, @CreateDate, @FK_Post, @FK_Account, @Note)", 
					"@Id",  _GExpScanDelivery.Id, 
					"@BillCode",  _GExpScanDelivery.BillCode, 
					"@FK_ShipperId",  _GExpScanDelivery.FK_ShipperId, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanDelivery.CreateDate), 
					"@FK_Post",  _GExpScanDelivery.FK_Post, 
					"@FK_Account",  _GExpScanDelivery.FK_Account, 
					"@Note",  _GExpScanDelivery.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpScanDelivery vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpScanDelivery> _GExpScanDeliverys)
		{
			foreach (GExpScanDelivery item in _GExpScanDeliverys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpScanDelivery _GExpScanDelivery, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanDelivery] SET Id=@Id, BillCode=@BillCode, FK_ShipperId=@FK_ShipperId, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@Id",  _GExpScanDelivery.Id, 
					"@BillCode",  _GExpScanDelivery.BillCode, 
					"@FK_ShipperId",  _GExpScanDelivery.FK_ShipperId, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanDelivery.CreateDate), 
					"@FK_Post",  _GExpScanDelivery.FK_Post, 
					"@FK_Account",  _GExpScanDelivery.FK_Account, 
					"@Note",  _GExpScanDelivery.Note, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpScanDelivery vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpScanDelivery _GExpScanDelivery)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanDelivery] SET BillCode=@BillCode, FK_ShipperId=@FK_ShipperId, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@BillCode",  _GExpScanDelivery.BillCode, 
					"@FK_ShipperId",  _GExpScanDelivery.FK_ShipperId, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanDelivery.CreateDate), 
					"@FK_Post",  _GExpScanDelivery.FK_Post, 
					"@FK_Account",  _GExpScanDelivery.FK_Account, 
					"@Note",  _GExpScanDelivery.Note, 
					"@Id", _GExpScanDelivery.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpScanDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpScanDelivery> _GExpScanDeliverys)
		{
			foreach (GExpScanDelivery item in _GExpScanDeliverys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanDelivery vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpScanDelivery _GExpScanDelivery, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanDelivery] SET Id=@Id, BillCode=@BillCode, FK_ShipperId=@FK_ShipperId, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note "+ condition, 
					"@Id",  _GExpScanDelivery.Id, 
					"@BillCode",  _GExpScanDelivery.BillCode, 
					"@FK_ShipperId",  _GExpScanDelivery.FK_ShipperId, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanDelivery.CreateDate), 
					"@FK_Post",  _GExpScanDelivery.FK_Post, 
					"@FK_Account",  _GExpScanDelivery.FK_Account, 
					"@Note",  _GExpScanDelivery.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpScanDelivery trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanDelivery] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanDelivery trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpScanDelivery _GExpScanDelivery)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanDelivery] WHERE Id=@Id",
					"@Id", _GExpScanDelivery.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanDelivery trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanDelivery] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanDelivery trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpScanDelivery> _GExpScanDeliverys)
		{
			foreach (GExpScanDelivery item in _GExpScanDeliverys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
