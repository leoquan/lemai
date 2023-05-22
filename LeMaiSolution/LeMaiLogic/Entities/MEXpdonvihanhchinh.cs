using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpdonvihanhchinh:IEXpdonvihanhchinh
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpdonvihanhchinh(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpDonViHanhChinh từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDonViHanhChinh]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpDonViHanhChinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDonViHanhChinh] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpDonViHanhChinh từ Database
		/// </summary>
		public List<ExpDonViHanhChinh> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDonViHanhChinh]");
				List<ExpDonViHanhChinh> items = new List<ExpDonViHanhChinh>();
				ExpDonViHanhChinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDonViHanhChinh();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
					{
						item.Ten = Convert.ToString(dr["Ten"]);
					}
					if (dr["Cap"] != null && dr["Cap"] != DBNull.Value)
					{
						item.Cap = Convert.ToString(dr["Cap"]);
					}
					if (dr["CapTren"] != null && dr["CapTren"] != DBNull.Value)
					{
						item.CapTren = Convert.ToString(dr["CapTren"]);
					}
					if (dr["InternalPost"] != null && dr["InternalPost"] != DBNull.Value)
					{
						item.InternalPost = Convert.ToBoolean(dr["InternalPost"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["PostCode"] != null && dr["PostCode"] != DBNull.Value)
					{
						item.PostCode = Convert.ToString(dr["PostCode"]);
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
		/// Lấy danh sách ExpDonViHanhChinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpDonViHanhChinh> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDonViHanhChinh] A "+ condition,  parameters);
				List<ExpDonViHanhChinh> items = new List<ExpDonViHanhChinh>();
				ExpDonViHanhChinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDonViHanhChinh();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
					{
						item.Ten = Convert.ToString(dr["Ten"]);
					}
					if (dr["Cap"] != null && dr["Cap"] != DBNull.Value)
					{
						item.Cap = Convert.ToString(dr["Cap"]);
					}
					if (dr["CapTren"] != null && dr["CapTren"] != DBNull.Value)
					{
						item.CapTren = Convert.ToString(dr["CapTren"]);
					}
					if (dr["InternalPost"] != null && dr["InternalPost"] != DBNull.Value)
					{
						item.InternalPost = Convert.ToBoolean(dr["InternalPost"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["PostCode"] != null && dr["PostCode"] != DBNull.Value)
					{
						item.PostCode = Convert.ToString(dr["PostCode"]);
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

		public List<ExpDonViHanhChinh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDonViHanhChinh] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpDonViHanhChinh] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpDonViHanhChinh>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpDonViHanhChinh từ Database
		/// </summary>
		public ExpDonViHanhChinh GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDonViHanhChinh] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpDonViHanhChinh item=new ExpDonViHanhChinh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
						{
							item.Ten = Convert.ToString(dr["Ten"]);
						}
						if (dr["Cap"] != null && dr["Cap"] != DBNull.Value)
						{
							item.Cap = Convert.ToString(dr["Cap"]);
						}
						if (dr["CapTren"] != null && dr["CapTren"] != DBNull.Value)
						{
							item.CapTren = Convert.ToString(dr["CapTren"]);
						}
						if (dr["InternalPost"] != null && dr["InternalPost"] != DBNull.Value)
						{
							item.InternalPost = Convert.ToBoolean(dr["InternalPost"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["PostCode"] != null && dr["PostCode"] != DBNull.Value)
						{
							item.PostCode = Convert.ToString(dr["PostCode"]);
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
		/// Lấy một ExpDonViHanhChinh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpDonViHanhChinh GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDonViHanhChinh] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpDonViHanhChinh item=new ExpDonViHanhChinh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
						{
							item.Ten = Convert.ToString(dr["Ten"]);
						}
						if (dr["Cap"] != null && dr["Cap"] != DBNull.Value)
						{
							item.Cap = Convert.ToString(dr["Cap"]);
						}
						if (dr["CapTren"] != null && dr["CapTren"] != DBNull.Value)
						{
							item.CapTren = Convert.ToString(dr["CapTren"]);
						}
						if (dr["InternalPost"] != null && dr["InternalPost"] != DBNull.Value)
						{
							item.InternalPost = Convert.ToBoolean(dr["InternalPost"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["PostCode"] != null && dr["PostCode"] != DBNull.Value)
						{
							item.PostCode = Convert.ToString(dr["PostCode"]);
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

		public ExpDonViHanhChinh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDonViHanhChinh] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpDonViHanhChinh>(ds);
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
		/// Thêm mới ExpDonViHanhChinh vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpDonViHanhChinh _ExpDonViHanhChinh)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpDonViHanhChinh](Id, Ten, Cap, CapTren, InternalPost, Note, PostCode) VALUES(@Id, @Ten, @Cap, @CapTren, @InternalPost, @Note, @PostCode)", 
					"@Id",  _ExpDonViHanhChinh.Id, 
					"@Ten",  _ExpDonViHanhChinh.Ten, 
					"@Cap",  _ExpDonViHanhChinh.Cap, 
					"@CapTren",  _ExpDonViHanhChinh.CapTren, 
					"@InternalPost",  _ExpDonViHanhChinh.InternalPost, 
					"@Note",  _ExpDonViHanhChinh.Note, 
					"@PostCode",  _ExpDonViHanhChinh.PostCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpDonViHanhChinh vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpDonViHanhChinh> _ExpDonViHanhChinhs)
		{
			foreach (ExpDonViHanhChinh item in _ExpDonViHanhChinhs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDonViHanhChinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpDonViHanhChinh _ExpDonViHanhChinh, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDonViHanhChinh] SET Id=@Id, Ten=@Ten, Cap=@Cap, CapTren=@CapTren, InternalPost=@InternalPost, Note=@Note, PostCode=@PostCode WHERE Id=@Id", 
					"@Id",  _ExpDonViHanhChinh.Id, 
					"@Ten",  _ExpDonViHanhChinh.Ten, 
					"@Cap",  _ExpDonViHanhChinh.Cap, 
					"@CapTren",  _ExpDonViHanhChinh.CapTren, 
					"@InternalPost",  _ExpDonViHanhChinh.InternalPost, 
					"@Note",  _ExpDonViHanhChinh.Note, 
					"@PostCode",  _ExpDonViHanhChinh.PostCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpDonViHanhChinh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpDonViHanhChinh _ExpDonViHanhChinh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDonViHanhChinh] SET Ten=@Ten, Cap=@Cap, CapTren=@CapTren, InternalPost=@InternalPost, Note=@Note, PostCode=@PostCode WHERE Id=@Id", 
					"@Ten",  _ExpDonViHanhChinh.Ten, 
					"@Cap",  _ExpDonViHanhChinh.Cap, 
					"@CapTren",  _ExpDonViHanhChinh.CapTren, 
					"@InternalPost",  _ExpDonViHanhChinh.InternalPost, 
					"@Note",  _ExpDonViHanhChinh.Note, 
					"@PostCode",  _ExpDonViHanhChinh.PostCode, 
					"@Id", _ExpDonViHanhChinh.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpDonViHanhChinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpDonViHanhChinh> _ExpDonViHanhChinhs)
		{
			foreach (ExpDonViHanhChinh item in _ExpDonViHanhChinhs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDonViHanhChinh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpDonViHanhChinh _ExpDonViHanhChinh, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDonViHanhChinh] SET Id=@Id, Ten=@Ten, Cap=@Cap, CapTren=@CapTren, InternalPost=@InternalPost, Note=@Note, PostCode=@PostCode "+ condition, 
					"@Id",  _ExpDonViHanhChinh.Id, 
					"@Ten",  _ExpDonViHanhChinh.Ten, 
					"@Cap",  _ExpDonViHanhChinh.Cap, 
					"@CapTren",  _ExpDonViHanhChinh.CapTren, 
					"@InternalPost",  _ExpDonViHanhChinh.InternalPost, 
					"@Note",  _ExpDonViHanhChinh.Note, 
					"@PostCode",  _ExpDonViHanhChinh.PostCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpDonViHanhChinh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDonViHanhChinh] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDonViHanhChinh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpDonViHanhChinh _ExpDonViHanhChinh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDonViHanhChinh] WHERE Id=@Id",
					"@Id", _ExpDonViHanhChinh.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDonViHanhChinh trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDonViHanhChinh] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDonViHanhChinh trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpDonViHanhChinh> _ExpDonViHanhChinhs)
		{
			foreach (ExpDonViHanhChinh item in _ExpDonViHanhChinhs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
