using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpscanreceive:IGExpscanreceive
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpscanreceive(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpScanReceive từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanReceive]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpScanReceive từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanReceive] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpScanReceive từ Database
		/// </summary>
		public List<GExpScanReceive> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanReceive]");
				List<GExpScanReceive> items = new List<GExpScanReceive>();
				GExpScanReceive item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanReceive();
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
		/// Lấy danh sách GExpScanReceive từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpScanReceive> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanReceive] A "+ condition,  parameters);
				List<GExpScanReceive> items = new List<GExpScanReceive>();
				GExpScanReceive item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanReceive();
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

		public List<GExpScanReceive> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanReceive] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpScanReceive] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpScanReceive>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpScanReceive từ Database
		/// </summary>
		public GExpScanReceive GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanReceive] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpScanReceive item=new GExpScanReceive();
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
		/// Lấy một GExpScanReceive đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpScanReceive GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanReceive] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpScanReceive item=new GExpScanReceive();
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

		public GExpScanReceive GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanReceive] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpScanReceive>(ds);
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
		/// Thêm mới GExpScanReceive vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpScanReceive _GExpScanReceive)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpScanReceive](Id, BillCode, CreateDate, FK_Post, FK_Account, Note) VALUES(@Id, @BillCode, @CreateDate, @FK_Post, @FK_Account, @Note)", 
					"@Id",  _GExpScanReceive.Id, 
					"@BillCode",  _GExpScanReceive.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanReceive.CreateDate), 
					"@FK_Post",  _GExpScanReceive.FK_Post, 
					"@FK_Account",  _GExpScanReceive.FK_Account, 
					"@Note",  _GExpScanReceive.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpScanReceive vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpScanReceive> _GExpScanReceives)
		{
			foreach (GExpScanReceive item in _GExpScanReceives)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanReceive vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpScanReceive _GExpScanReceive, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanReceive] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@Id",  _GExpScanReceive.Id, 
					"@BillCode",  _GExpScanReceive.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanReceive.CreateDate), 
					"@FK_Post",  _GExpScanReceive.FK_Post, 
					"@FK_Account",  _GExpScanReceive.FK_Account, 
					"@Note",  _GExpScanReceive.Note, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpScanReceive vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpScanReceive _GExpScanReceive)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanReceive] SET BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@BillCode",  _GExpScanReceive.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanReceive.CreateDate), 
					"@FK_Post",  _GExpScanReceive.FK_Post, 
					"@FK_Account",  _GExpScanReceive.FK_Account, 
					"@Note",  _GExpScanReceive.Note, 
					"@Id", _GExpScanReceive.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpScanReceive vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpScanReceive> _GExpScanReceives)
		{
			foreach (GExpScanReceive item in _GExpScanReceives)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanReceive vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpScanReceive _GExpScanReceive, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanReceive] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note "+ condition, 
					"@Id",  _GExpScanReceive.Id, 
					"@BillCode",  _GExpScanReceive.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanReceive.CreateDate), 
					"@FK_Post",  _GExpScanReceive.FK_Post, 
					"@FK_Account",  _GExpScanReceive.FK_Account, 
					"@Note",  _GExpScanReceive.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpScanReceive trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanReceive] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanReceive trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpScanReceive _GExpScanReceive)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanReceive] WHERE Id=@Id",
					"@Id", _GExpScanReceive.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanReceive trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanReceive] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanReceive trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpScanReceive> _GExpScanReceives)
		{
			foreach (GExpScanReceive item in _GExpScanReceives)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
