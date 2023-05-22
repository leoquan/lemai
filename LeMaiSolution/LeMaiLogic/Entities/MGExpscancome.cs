using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpscancome:IGExpscancome
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpscancome(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpScanCome từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanCome]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpScanCome từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanCome] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpScanCome từ Database
		/// </summary>
		public List<GExpScanCome> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanCome]");
				List<GExpScanCome> items = new List<GExpScanCome>();
				GExpScanCome item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanCome();
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
					if (dr["FK_ComeFromPost"] != null && dr["FK_ComeFromPost"] != DBNull.Value)
					{
						item.FK_ComeFromPost = Convert.ToString(dr["FK_ComeFromPost"]);
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
		/// Lấy danh sách GExpScanCome từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpScanCome> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanCome] A "+ condition,  parameters);
				List<GExpScanCome> items = new List<GExpScanCome>();
				GExpScanCome item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpScanCome();
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
					if (dr["FK_ComeFromPost"] != null && dr["FK_ComeFromPost"] != DBNull.Value)
					{
						item.FK_ComeFromPost = Convert.ToString(dr["FK_ComeFromPost"]);
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

		public List<GExpScanCome> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanCome] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpScanCome] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpScanCome>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpScanCome từ Database
		/// </summary>
		public GExpScanCome GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpScanCome] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpScanCome item=new GExpScanCome();
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
						if (dr["FK_ComeFromPost"] != null && dr["FK_ComeFromPost"] != DBNull.Value)
						{
							item.FK_ComeFromPost = Convert.ToString(dr["FK_ComeFromPost"]);
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
		/// Lấy một GExpScanCome đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpScanCome GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpScanCome] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpScanCome item=new GExpScanCome();
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
						if (dr["FK_ComeFromPost"] != null && dr["FK_ComeFromPost"] != DBNull.Value)
						{
							item.FK_ComeFromPost = Convert.ToString(dr["FK_ComeFromPost"]);
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

		public GExpScanCome GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpScanCome] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpScanCome>(ds);
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
		/// Thêm mới GExpScanCome vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpScanCome _GExpScanCome)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpScanCome](Id, BillCode, CreateDate, FK_Post, FK_ComeFromPost, FK_Account, Note) VALUES(@Id, @BillCode, @CreateDate, @FK_Post, @FK_ComeFromPost, @FK_Account, @Note)", 
					"@Id",  _GExpScanCome.Id, 
					"@BillCode",  _GExpScanCome.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanCome.CreateDate), 
					"@FK_Post",  _GExpScanCome.FK_Post, 
					"@FK_ComeFromPost",  _GExpScanCome.FK_ComeFromPost, 
					"@FK_Account",  _GExpScanCome.FK_Account, 
					"@Note",  _GExpScanCome.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpScanCome vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpScanCome> _GExpScanComes)
		{
			foreach (GExpScanCome item in _GExpScanComes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanCome vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpScanCome _GExpScanCome, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanCome] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_ComeFromPost=@FK_ComeFromPost, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@Id",  _GExpScanCome.Id, 
					"@BillCode",  _GExpScanCome.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanCome.CreateDate), 
					"@FK_Post",  _GExpScanCome.FK_Post, 
					"@FK_ComeFromPost",  _GExpScanCome.FK_ComeFromPost, 
					"@FK_Account",  _GExpScanCome.FK_Account, 
					"@Note",  _GExpScanCome.Note, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpScanCome vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpScanCome _GExpScanCome)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanCome] SET BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_ComeFromPost=@FK_ComeFromPost, FK_Account=@FK_Account, Note=@Note WHERE Id=@Id", 
					"@BillCode",  _GExpScanCome.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanCome.CreateDate), 
					"@FK_Post",  _GExpScanCome.FK_Post, 
					"@FK_ComeFromPost",  _GExpScanCome.FK_ComeFromPost, 
					"@FK_Account",  _GExpScanCome.FK_Account, 
					"@Note",  _GExpScanCome.Note, 
					"@Id", _GExpScanCome.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpScanCome vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpScanCome> _GExpScanComes)
		{
			foreach (GExpScanCome item in _GExpScanComes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpScanCome vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpScanCome _GExpScanCome, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpScanCome] SET Id=@Id, BillCode=@BillCode, CreateDate=@CreateDate, FK_Post=@FK_Post, FK_ComeFromPost=@FK_ComeFromPost, FK_Account=@FK_Account, Note=@Note "+ condition, 
					"@Id",  _GExpScanCome.Id, 
					"@BillCode",  _GExpScanCome.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpScanCome.CreateDate), 
					"@FK_Post",  _GExpScanCome.FK_Post, 
					"@FK_ComeFromPost",  _GExpScanCome.FK_ComeFromPost, 
					"@FK_Account",  _GExpScanCome.FK_Account, 
					"@Note",  _GExpScanCome.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpScanCome trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanCome] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanCome trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpScanCome _GExpScanCome)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanCome] WHERE Id=@Id",
					"@Id", _GExpScanCome.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanCome trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpScanCome] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpScanCome trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpScanCome> _GExpScanComes)
		{
			foreach (GExpScanCome item in _GExpScanComes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
