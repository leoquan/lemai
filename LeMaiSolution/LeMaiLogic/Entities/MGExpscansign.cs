using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpscansign:IGExpscansign
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpscansign(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpScanSign từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanSign]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpScanSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanSign] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpScanSign từ Database
		/// </summary>
		public List<GExpScanSign> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanSign]");
				List<GExpScanSign> items = new List<GExpScanSign>();
				GExpScanSign item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanSign();
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
		/// Lấy danh sách GExpScanSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpScanSign> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanSign] A "+ condition,  parameters);
				List<GExpScanSign> items = new List<GExpScanSign>();
				GExpScanSign item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanSign();
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

		public List<GExpScanSign> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanSign] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpScanSign] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpScanSign>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpScanSign từ Database
		/// </summary>
		public GExpScanSign GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanSign] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpScanSign item=new GExpScanSign();
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
		/// Lấy một GExpScanSign đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpScanSign GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanSign] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpScanSign item=new GExpScanSign();
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

		public GExpScanSign GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanSign] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpScanSign>(ds);
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
		/// Thêm mới GExpScanSign vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpScanSign _GExpScanSign)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpScanSign](Id, BillCode, CreateDate, FK_Post, FK_Account, Note) VALUES(@Id, @BillCode, @CreateDate, @FK_Post, @FK_Account, @Note)", 
					"@Id",  _GExpScanSign.Id, 
					"@BillCode",  _GExpScanSign.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanSign.CreateDate), 
					"@FK_Post",  _GExpScanSign.FK_Post, 
					"@FK_Account",  _GExpScanSign.FK_Account, 
					"@Note",  _GExpScanSign.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpScanSign vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpScanSign> _GExpScanSigns)
		{
			foreach (GExpScanSign item in _GExpScanSigns)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanSign vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpScanSign _GExpScanSign, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanSign] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@Id",  _GExpScanSign.Id, 
					"@BillCode",  _GExpScanSign.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanSign.CreateDate), 
					"@FK_Post",  _GExpScanSign.FK_Post, 
					"@FK_Account",  _GExpScanSign.FK_Account, 
					"@Note",  _GExpScanSign.Note, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpScanSign vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpScanSign _GExpScanSign)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanSign] SET BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@BillCode",  _GExpScanSign.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanSign.CreateDate), 
					"@FK_Post",  _GExpScanSign.FK_Post, 
					"@FK_Account",  _GExpScanSign.FK_Account, 
					"@Note",  _GExpScanSign.Note, 
					"@Id", _GExpScanSign.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpScanSign vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpScanSign> _GExpScanSigns)
		{
			foreach (GExpScanSign item in _GExpScanSigns)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanSign vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpScanSign _GExpScanSign, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanSign] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_Account=@FK_Account, Note=@Note "+ condition, 
					"@Id",  _GExpScanSign.Id, 
					"@BillCode",  _GExpScanSign.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanSign.CreateDate), 
					"@FK_Post",  _GExpScanSign.FK_Post, 
					"@FK_Account",  _GExpScanSign.FK_Account, 
					"@Note",  _GExpScanSign.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpScanSign trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanSign] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanSign trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpScanSign _GExpScanSign)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanSign] WHERE Id=@Id",
					"@Id", _GExpScanSign.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanSign trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanSign] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanSign trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpScanSign> _GExpScanSigns)
		{
			foreach (GExpScanSign item in _GExpScanSigns)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
