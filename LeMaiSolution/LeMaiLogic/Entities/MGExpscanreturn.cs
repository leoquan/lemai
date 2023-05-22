using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpscanreturn:IGExpscanreturn
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpscanreturn(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpScanReturn từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanReturn]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpScanReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanReturn] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpScanReturn từ Database
		/// </summary>
		public List<GExpScanReturn> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanReturn]");
				List<GExpScanReturn> items = new List<GExpScanReturn>();
				GExpScanReturn item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanReturn();
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
					if (dr["FK_ReturnToPost"] != null && dr["FK_ReturnToPost"] != DBNull.Value)
					{
						item.FK_ReturnToPost = Convert.ToString(dr["FK_ReturnToPost"]);
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
		/// Lấy danh sách GExpScanReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpScanReturn> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanReturn] A "+ condition,  parameters);
				List<GExpScanReturn> items = new List<GExpScanReturn>();
				GExpScanReturn item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanReturn();
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
					if (dr["FK_ReturnToPost"] != null && dr["FK_ReturnToPost"] != DBNull.Value)
					{
						item.FK_ReturnToPost = Convert.ToString(dr["FK_ReturnToPost"]);
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

		public List<GExpScanReturn> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanReturn] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpScanReturn] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpScanReturn>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpScanReturn từ Database
		/// </summary>
		public GExpScanReturn GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanReturn] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpScanReturn item=new GExpScanReturn();
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
						if (dr["FK_ReturnToPost"] != null && dr["FK_ReturnToPost"] != DBNull.Value)
						{
							item.FK_ReturnToPost = Convert.ToString(dr["FK_ReturnToPost"]);
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
		/// Lấy một GExpScanReturn đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpScanReturn GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanReturn] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpScanReturn item=new GExpScanReturn();
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
						if (dr["FK_ReturnToPost"] != null && dr["FK_ReturnToPost"] != DBNull.Value)
						{
							item.FK_ReturnToPost = Convert.ToString(dr["FK_ReturnToPost"]);
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

		public GExpScanReturn GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanReturn] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpScanReturn>(ds);
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
		/// Thêm mới GExpScanReturn vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpScanReturn _GExpScanReturn)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpScanReturn](Id, BillCode, CreateDate, FK_Post, FK_ReturnToPost, FK_Account, Note) VALUES(@Id, @BillCode, @CreateDate, @FK_Post, @FK_ReturnToPost, @FK_Account, @Note)", 
					"@Id",  _GExpScanReturn.Id, 
					"@BillCode",  _GExpScanReturn.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanReturn.CreateDate), 
					"@FK_Post",  _GExpScanReturn.FK_Post, 
					"@FK_ReturnToPost",  _GExpScanReturn.FK_ReturnToPost, 
					"@FK_Account",  _GExpScanReturn.FK_Account, 
					"@Note",  _GExpScanReturn.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpScanReturn vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpScanReturn> _GExpScanReturns)
		{
			foreach (GExpScanReturn item in _GExpScanReturns)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanReturn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpScanReturn _GExpScanReturn, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanReturn] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_ReturnToPost=@FK_ReturnToPost, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@Id",  _GExpScanReturn.Id, 
					"@BillCode",  _GExpScanReturn.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanReturn.CreateDate), 
					"@FK_Post",  _GExpScanReturn.FK_Post, 
					"@FK_ReturnToPost",  _GExpScanReturn.FK_ReturnToPost, 
					"@FK_Account",  _GExpScanReturn.FK_Account, 
					"@Note",  _GExpScanReturn.Note, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpScanReturn vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpScanReturn _GExpScanReturn)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanReturn] SET BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_ReturnToPost=@FK_ReturnToPost, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@BillCode",  _GExpScanReturn.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanReturn.CreateDate), 
					"@FK_Post",  _GExpScanReturn.FK_Post, 
					"@FK_ReturnToPost",  _GExpScanReturn.FK_ReturnToPost, 
					"@FK_Account",  _GExpScanReturn.FK_Account, 
					"@Note",  _GExpScanReturn.Note, 
					"@Id", _GExpScanReturn.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpScanReturn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpScanReturn> _GExpScanReturns)
		{
			foreach (GExpScanReturn item in _GExpScanReturns)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanReturn vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpScanReturn _GExpScanReturn, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanReturn] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_ReturnToPost=@FK_ReturnToPost, FK_Account=@FK_Account, Note=@Note "+ condition, 
					"@Id",  _GExpScanReturn.Id, 
					"@BillCode",  _GExpScanReturn.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanReturn.CreateDate), 
					"@FK_Post",  _GExpScanReturn.FK_Post, 
					"@FK_ReturnToPost",  _GExpScanReturn.FK_ReturnToPost, 
					"@FK_Account",  _GExpScanReturn.FK_Account, 
					"@Note",  _GExpScanReturn.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpScanReturn trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanReturn] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanReturn trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpScanReturn _GExpScanReturn)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanReturn] WHERE Id=@Id",
					"@Id", _GExpScanReturn.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanReturn trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanReturn] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanReturn trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpScanReturn> _GExpScanReturns)
		{
			foreach (GExpScanReturn item in _GExpScanReturns)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
