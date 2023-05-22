using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpscansend:IGExpscansend
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpscansend(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpScanSend từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanSend]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpScanSend từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanSend] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpScanSend từ Database
		/// </summary>
		public List<GExpScanSend> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanSend]");
				List<GExpScanSend> items = new List<GExpScanSend>();
				GExpScanSend item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanSend();
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
					if (dr["FK_SendToPost"] != null && dr["FK_SendToPost"] != DBNull.Value)
					{
						item.FK_SendToPost = Convert.ToString(dr["FK_SendToPost"]);
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
		/// Lấy danh sách GExpScanSend từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpScanSend> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanSend] A "+ condition,  parameters);
				List<GExpScanSend> items = new List<GExpScanSend>();
				GExpScanSend item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanSend();
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
					if (dr["FK_SendToPost"] != null && dr["FK_SendToPost"] != DBNull.Value)
					{
						item.FK_SendToPost = Convert.ToString(dr["FK_SendToPost"]);
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

		public List<GExpScanSend> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanSend] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpScanSend] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpScanSend>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpScanSend từ Database
		/// </summary>
		public GExpScanSend GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanSend] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpScanSend item=new GExpScanSend();
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
						if (dr["FK_SendToPost"] != null && dr["FK_SendToPost"] != DBNull.Value)
						{
							item.FK_SendToPost = Convert.ToString(dr["FK_SendToPost"]);
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
		/// Lấy một GExpScanSend đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpScanSend GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanSend] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpScanSend item=new GExpScanSend();
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
						if (dr["FK_SendToPost"] != null && dr["FK_SendToPost"] != DBNull.Value)
						{
							item.FK_SendToPost = Convert.ToString(dr["FK_SendToPost"]);
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

		public GExpScanSend GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanSend] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpScanSend>(ds);
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
		/// Thêm mới GExpScanSend vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpScanSend _GExpScanSend)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpScanSend](Id, BillCode, CreateDate, FK_Post, FK_SendToPost, FK_Account, Note) VALUES(@Id, @BillCode, @CreateDate, @FK_Post, @FK_SendToPost, @FK_Account, @Note)", 
					"@Id",  _GExpScanSend.Id, 
					"@BillCode",  _GExpScanSend.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanSend.CreateDate), 
					"@FK_Post",  _GExpScanSend.FK_Post, 
					"@FK_SendToPost",  _GExpScanSend.FK_SendToPost, 
					"@FK_Account",  _GExpScanSend.FK_Account, 
					"@Note",  _GExpScanSend.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpScanSend vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpScanSend> _GExpScanSends)
		{
			foreach (GExpScanSend item in _GExpScanSends)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanSend vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpScanSend _GExpScanSend, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanSend] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_SendToPost=@FK_SendToPost, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@Id",  _GExpScanSend.Id, 
					"@BillCode",  _GExpScanSend.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanSend.CreateDate), 
					"@FK_Post",  _GExpScanSend.FK_Post, 
					"@FK_SendToPost",  _GExpScanSend.FK_SendToPost, 
					"@FK_Account",  _GExpScanSend.FK_Account, 
					"@Note",  _GExpScanSend.Note, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpScanSend vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpScanSend _GExpScanSend)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanSend] SET BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_SendToPost=@FK_SendToPost, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@BillCode",  _GExpScanSend.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanSend.CreateDate), 
					"@FK_Post",  _GExpScanSend.FK_Post, 
					"@FK_SendToPost",  _GExpScanSend.FK_SendToPost, 
					"@FK_Account",  _GExpScanSend.FK_Account, 
					"@Note",  _GExpScanSend.Note, 
					"@Id", _GExpScanSend.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpScanSend vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpScanSend> _GExpScanSends)
		{
			foreach (GExpScanSend item in _GExpScanSends)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanSend vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpScanSend _GExpScanSend, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanSend] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_SendToPost=@FK_SendToPost, FK_Account=@FK_Account, Note=@Note "+ condition, 
					"@Id",  _GExpScanSend.Id, 
					"@BillCode",  _GExpScanSend.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanSend.CreateDate), 
					"@FK_Post",  _GExpScanSend.FK_Post, 
					"@FK_SendToPost",  _GExpScanSend.FK_SendToPost, 
					"@FK_Account",  _GExpScanSend.FK_Account, 
					"@Note",  _GExpScanSend.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpScanSend trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanSend] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanSend trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpScanSend _GExpScanSend)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanSend] WHERE Id=@Id",
					"@Id", _GExpScanSend.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanSend trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanSend] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanSend trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpScanSend> _GExpScanSends)
		{
			foreach (GExpScanSend item in _GExpScanSends)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
