using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpscan:IEXpscan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpscan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpScan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpScan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpScan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpScan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpScan từ Database
		/// </summary>
		public List<ExpScan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpScan]");
				List<ExpScan> items = new List<ExpScan>();
				ExpScan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpScan();
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
					if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
					{
						item.Weight = Convert.ToDecimal(dr["Weight"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["TypeScan"] != null && dr["TypeScan"] != DBNull.Value)
					{
						item.TypeScan = Convert.ToString(dr["TypeScan"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
					{
						item.KeyDate = Convert.ToString(dr["KeyDate"]);
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
		/// Lấy danh sách ExpScan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpScan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpScan] A "+ condition,  parameters);
				List<ExpScan> items = new List<ExpScan>();
				ExpScan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpScan();
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
					if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
					{
						item.Weight = Convert.ToDecimal(dr["Weight"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["TypeScan"] != null && dr["TypeScan"] != DBNull.Value)
					{
						item.TypeScan = Convert.ToString(dr["TypeScan"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
					{
						item.KeyDate = Convert.ToString(dr["KeyDate"]);
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

		public List<ExpScan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpScan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpScan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpScan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpScan từ Database
		/// </summary>
		public ExpScan GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpScan] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpScan item=new ExpScan();
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
						if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
						{
							item.Weight = Convert.ToDecimal(dr["Weight"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["TypeScan"] != null && dr["TypeScan"] != DBNull.Value)
						{
							item.TypeScan = Convert.ToString(dr["TypeScan"]);
						}
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
						{
							item.KeyDate = Convert.ToString(dr["KeyDate"]);
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
		/// Lấy một ExpScan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpScan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpScan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpScan item=new ExpScan();
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
						if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
						{
							item.Weight = Convert.ToDecimal(dr["Weight"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["TypeScan"] != null && dr["TypeScan"] != DBNull.Value)
						{
							item.TypeScan = Convert.ToString(dr["TypeScan"]);
						}
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
						{
							item.KeyDate = Convert.ToString(dr["KeyDate"]);
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

		public ExpScan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpScan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpScan>(ds);
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
		/// Thêm mới ExpScan vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpScan _ExpScan)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpScan](Id, Post, CreateDate, Weight, Note, TypeScan, BILL_CODE, KeyDate) VALUES(@Id, @Post, @CreateDate, @Weight, @Note, @TypeScan, @BILL_CODE, @KeyDate)", 
					"@Id",  _ExpScan.Id, 
					"@Post",  _ExpScan.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpScan.CreateDate), 
					"@Weight",  _ExpScan.Weight, 
					"@Note",  _ExpScan.Note, 
					"@TypeScan",  _ExpScan.TypeScan, 
					"@BILL_CODE",  _ExpScan.BILL_CODE, 
					"@KeyDate",  _ExpScan.KeyDate);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpScan vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpScan> _ExpScans)
		{
			foreach (ExpScan item in _ExpScans)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpScan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpScan _ExpScan, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpScan] SET Id=@Id, Post=@Post, CreateDate=@CreateDate, Weight=@Weight, Note=@Note, TypeScan=@TypeScan, BILL_CODE=@BILL_CODE, KeyDate=@KeyDate WHERE Id=@Id", 
					"@Id",  _ExpScan.Id, 
					"@Post",  _ExpScan.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpScan.CreateDate), 
					"@Weight",  _ExpScan.Weight, 
					"@Note",  _ExpScan.Note, 
					"@TypeScan",  _ExpScan.TypeScan, 
					"@BILL_CODE",  _ExpScan.BILL_CODE, 
					"@KeyDate",  _ExpScan.KeyDate, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpScan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpScan _ExpScan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpScan] SET Post=@Post, CreateDate=@CreateDate, Weight=@Weight, Note=@Note, TypeScan=@TypeScan, BILL_CODE=@BILL_CODE, KeyDate=@KeyDate WHERE Id=@Id", 
					"@Post",  _ExpScan.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpScan.CreateDate), 
					"@Weight",  _ExpScan.Weight, 
					"@Note",  _ExpScan.Note, 
					"@TypeScan",  _ExpScan.TypeScan, 
					"@BILL_CODE",  _ExpScan.BILL_CODE, 
					"@KeyDate",  _ExpScan.KeyDate, 
					"@Id", _ExpScan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpScan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpScan> _ExpScans)
		{
			foreach (ExpScan item in _ExpScans)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpScan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpScan _ExpScan, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpScan] SET Id=@Id, Post=@Post, CreateDate=@CreateDate, Weight=@Weight, Note=@Note, TypeScan=@TypeScan, BILL_CODE=@BILL_CODE, KeyDate=@KeyDate "+ condition, 
					"@Id",  _ExpScan.Id, 
					"@Post",  _ExpScan.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpScan.CreateDate), 
					"@Weight",  _ExpScan.Weight, 
					"@Note",  _ExpScan.Note, 
					"@TypeScan",  _ExpScan.TypeScan, 
					"@BILL_CODE",  _ExpScan.BILL_CODE, 
					"@KeyDate",  _ExpScan.KeyDate);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpScan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpScan] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpScan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpScan _ExpScan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpScan] WHERE Id=@Id",
					"@Id", _ExpScan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpScan trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpScan] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpScan trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpScan> _ExpScans)
		{
			foreach (ExpScan item in _ExpScans)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
