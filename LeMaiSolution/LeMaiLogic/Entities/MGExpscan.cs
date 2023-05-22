using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpscan:IGExpscan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpscan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpScan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpScan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpScan từ Database
		/// </summary>
		public List<GExpScan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScan]");
				List<GExpScan> items = new List<GExpScan>();
				GExpScan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["TypeScan"] != null && dr["TypeScan"] != DBNull.Value)
					{
						item.TypeScan = Convert.ToString(dr["TypeScan"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
					{
						item.KeyDate = Convert.ToString(dr["KeyDate"]);
					}
					if (dr["UserCreate"] != null && dr["UserCreate"] != DBNull.Value)
					{
						item.UserCreate = Convert.ToString(dr["UserCreate"]);
					}
					if (dr["NameCreate"] != null && dr["NameCreate"] != DBNull.Value)
					{
						item.NameCreate = Convert.ToString(dr["NameCreate"]);
					}
					if (dr["ProblemType"] != null && dr["ProblemType"] != DBNull.Value)
					{
						item.ProblemType = Convert.ToInt32(dr["ProblemType"]);
					}
					if (dr["IsRead"] != null && dr["IsRead"] != DBNull.Value)
					{
						item.IsRead = Convert.ToBoolean(dr["IsRead"]);
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
		/// Lấy danh sách GExpScan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpScan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScan] A "+ condition,  parameters);
				List<GExpScan> items = new List<GExpScan>();
				GExpScan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["TypeScan"] != null && dr["TypeScan"] != DBNull.Value)
					{
						item.TypeScan = Convert.ToString(dr["TypeScan"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
					{
						item.KeyDate = Convert.ToString(dr["KeyDate"]);
					}
					if (dr["UserCreate"] != null && dr["UserCreate"] != DBNull.Value)
					{
						item.UserCreate = Convert.ToString(dr["UserCreate"]);
					}
					if (dr["NameCreate"] != null && dr["NameCreate"] != DBNull.Value)
					{
						item.NameCreate = Convert.ToString(dr["NameCreate"]);
					}
					if (dr["ProblemType"] != null && dr["ProblemType"] != DBNull.Value)
					{
						item.ProblemType = Convert.ToInt32(dr["ProblemType"]);
					}
					if (dr["IsRead"] != null && dr["IsRead"] != DBNull.Value)
					{
						item.IsRead = Convert.ToBoolean(dr["IsRead"]);
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

		public List<GExpScan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpScan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpScan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpScan từ Database
		/// </summary>
		public GExpScan GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScan] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpScan item=new GExpScan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["TypeScan"] != null && dr["TypeScan"] != DBNull.Value)
						{
							item.TypeScan = Convert.ToString(dr["TypeScan"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
						{
							item.KeyDate = Convert.ToString(dr["KeyDate"]);
						}
						if (dr["UserCreate"] != null && dr["UserCreate"] != DBNull.Value)
						{
							item.UserCreate = Convert.ToString(dr["UserCreate"]);
						}
						if (dr["NameCreate"] != null && dr["NameCreate"] != DBNull.Value)
						{
							item.NameCreate = Convert.ToString(dr["NameCreate"]);
						}
						if (dr["ProblemType"] != null && dr["ProblemType"] != DBNull.Value)
						{
							item.ProblemType = Convert.ToInt32(dr["ProblemType"]);
						}
						if (dr["IsRead"] != null && dr["IsRead"] != DBNull.Value)
						{
							item.IsRead = Convert.ToBoolean(dr["IsRead"]);
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
		/// Lấy một GExpScan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpScan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpScan item=new GExpScan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["TypeScan"] != null && dr["TypeScan"] != DBNull.Value)
						{
							item.TypeScan = Convert.ToString(dr["TypeScan"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
						{
							item.KeyDate = Convert.ToString(dr["KeyDate"]);
						}
						if (dr["UserCreate"] != null && dr["UserCreate"] != DBNull.Value)
						{
							item.UserCreate = Convert.ToString(dr["UserCreate"]);
						}
						if (dr["NameCreate"] != null && dr["NameCreate"] != DBNull.Value)
						{
							item.NameCreate = Convert.ToString(dr["NameCreate"]);
						}
						if (dr["ProblemType"] != null && dr["ProblemType"] != DBNull.Value)
						{
							item.ProblemType = Convert.ToInt32(dr["ProblemType"]);
						}
						if (dr["IsRead"] != null && dr["IsRead"] != DBNull.Value)
						{
							item.IsRead = Convert.ToBoolean(dr["IsRead"]);
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

		public GExpScan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpScan>(ds);
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
		/// Thêm mới GExpScan vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpScan _GExpScan)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpScan](Id, Post, CreateDate, Note, TypeScan, BillCode, KeyDate, UserCreate, NameCreate, ProblemType, IsRead) VALUES(@Id, @Post, @CreateDate, @Note, @TypeScan, @BillCode, @KeyDate, @UserCreate, @NameCreate, @ProblemType, @IsRead)", 
					"@Id",  _GExpScan.Id, 
					"@Post",  _GExpScan.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScan.CreateDate), 
					"@Note",  _GExpScan.Note, 
					"@TypeScan",  _GExpScan.TypeScan, 
					"@BillCode",  _GExpScan.BillCode, 
					"@KeyDate",  _GExpScan.KeyDate, 
					"@UserCreate",  _GExpScan.UserCreate, 
					"@NameCreate",  _GExpScan.NameCreate, 
					"@ProblemType",  _GExpScan.ProblemType, 
					"@IsRead",  _GExpScan.IsRead);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpScan vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpScan> _GExpScans)
		{
			foreach (GExpScan item in _GExpScans)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpScan _GExpScan, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScan] SET Id=@Id, Post=@Post, CreateDate=@CreateDate, Note=@Note, TypeScan=@TypeScan, BillCode=@BillCode, KeyDate=@KeyDate, UserCreate=@UserCreate, NameCreate=@NameCreate, ProblemType=@ProblemType, IsRead=@IsRead WHERE Id=@Id", 
					"@Id",  _GExpScan.Id, 
					"@Post",  _GExpScan.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScan.CreateDate), 
					"@Note",  _GExpScan.Note, 
					"@TypeScan",  _GExpScan.TypeScan, 
					"@BillCode",  _GExpScan.BillCode, 
					"@KeyDate",  _GExpScan.KeyDate, 
					"@UserCreate",  _GExpScan.UserCreate, 
					"@NameCreate",  _GExpScan.NameCreate, 
					"@ProblemType",  _GExpScan.ProblemType, 
					"@IsRead",  _GExpScan.IsRead, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpScan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpScan _GExpScan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScan] SET Post=@Post, CreateDate=@CreateDate, Note=@Note, TypeScan=@TypeScan, BillCode=@BillCode, KeyDate=@KeyDate, UserCreate=@UserCreate, NameCreate=@NameCreate, ProblemType=@ProblemType, IsRead=@IsRead WHERE Id=@Id", 
					"@Post",  _GExpScan.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScan.CreateDate), 
					"@Note",  _GExpScan.Note, 
					"@TypeScan",  _GExpScan.TypeScan, 
					"@BillCode",  _GExpScan.BillCode, 
					"@KeyDate",  _GExpScan.KeyDate, 
					"@UserCreate",  _GExpScan.UserCreate, 
					"@NameCreate",  _GExpScan.NameCreate, 
					"@ProblemType",  _GExpScan.ProblemType, 
					"@IsRead",  _GExpScan.IsRead, 
					"@Id", _GExpScan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpScan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpScan> _GExpScans)
		{
			foreach (GExpScan item in _GExpScans)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpScan _GExpScan, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScan] SET Id=@Id, Post=@Post, CreateDate=@CreateDate, Note=@Note, TypeScan=@TypeScan, BillCode=@BillCode, KeyDate=@KeyDate, UserCreate=@UserCreate, NameCreate=@NameCreate, ProblemType=@ProblemType, IsRead=@IsRead "+ condition, 
					"@Id",  _GExpScan.Id, 
					"@Post",  _GExpScan.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScan.CreateDate), 
					"@Note",  _GExpScan.Note, 
					"@TypeScan",  _GExpScan.TypeScan, 
					"@BillCode",  _GExpScan.BillCode, 
					"@KeyDate",  _GExpScan.KeyDate, 
					"@UserCreate",  _GExpScan.UserCreate, 
					"@NameCreate",  _GExpScan.NameCreate, 
					"@ProblemType",  _GExpScan.ProblemType, 
					"@IsRead",  _GExpScan.IsRead);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpScan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScan] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpScan _GExpScan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScan] WHERE Id=@Id",
					"@Id", _GExpScan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScan trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScan] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScan trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpScan> _GExpScans)
		{
			foreach (GExpScan item in _GExpScans)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
