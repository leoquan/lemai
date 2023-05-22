using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpnote:IEXpnote
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpnote(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpNote từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNote]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpNote từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNote] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpNote từ Database
		/// </summary>
		public List<ExpNote> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNote]");
				List<ExpNote> items = new List<ExpNote>();
				ExpNote item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpNote();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["Comment"] != null && dr["Comment"] != DBNull.Value)
					{
						item.Comment = Convert.ToString(dr["Comment"]);
					}
					if (dr["Author"] != null && dr["Author"] != DBNull.Value)
					{
						item.Author = Convert.ToString(dr["Author"]);
					}
					if (dr["Color"] != null && dr["Color"] != DBNull.Value)
					{
						item.Color = Convert.ToString(dr["Color"]);
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
		/// Lấy danh sách ExpNote từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpNote> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpNote] A "+ condition,  parameters);
				List<ExpNote> items = new List<ExpNote>();
				ExpNote item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpNote();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["Comment"] != null && dr["Comment"] != DBNull.Value)
					{
						item.Comment = Convert.ToString(dr["Comment"]);
					}
					if (dr["Author"] != null && dr["Author"] != DBNull.Value)
					{
						item.Author = Convert.ToString(dr["Author"]);
					}
					if (dr["Color"] != null && dr["Color"] != DBNull.Value)
					{
						item.Color = Convert.ToString(dr["Color"]);
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

		public List<ExpNote> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpNote] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpNote] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpNote>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpNote từ Database
		/// </summary>
		public ExpNote GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNote] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpNote item=new ExpNote();
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
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
						}
						if (dr["Comment"] != null && dr["Comment"] != DBNull.Value)
						{
							item.Comment = Convert.ToString(dr["Comment"]);
						}
						if (dr["Author"] != null && dr["Author"] != DBNull.Value)
						{
							item.Author = Convert.ToString(dr["Author"]);
						}
						if (dr["Color"] != null && dr["Color"] != DBNull.Value)
						{
							item.Color = Convert.ToString(dr["Color"]);
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
		/// Lấy một ExpNote đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpNote GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpNote] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpNote item=new ExpNote();
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
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
						}
						if (dr["Comment"] != null && dr["Comment"] != DBNull.Value)
						{
							item.Comment = Convert.ToString(dr["Comment"]);
						}
						if (dr["Author"] != null && dr["Author"] != DBNull.Value)
						{
							item.Author = Convert.ToString(dr["Author"]);
						}
						if (dr["Color"] != null && dr["Color"] != DBNull.Value)
						{
							item.Color = Convert.ToString(dr["Color"]);
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

		public ExpNote GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpNote] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpNote>(ds);
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
		/// Thêm mới ExpNote vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpNote _ExpNote)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpNote](Id, BillCode, UpdateDate, Comment, Author, Color) VALUES(@Id, @BillCode, @UpdateDate, @Comment, @Author, @Color)", 
					"@Id",  _ExpNote.Id, 
					"@BillCode",  _ExpNote.BillCode, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpNote.UpdateDate), 
					"@Comment",  _ExpNote.Comment, 
					"@Author",  _ExpNote.Author, 
					"@Color",  _ExpNote.Color);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpNote vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpNote> _ExpNotes)
		{
			foreach (ExpNote item in _ExpNotes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpNote vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpNote _ExpNote, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpNote] SET Id=@Id, BillCode=@BillCode, UpdateDate=@UpdateDate, Comment=@Comment, Author=@Author, Color=@Color WHERE Id=@Id", 
					"@Id",  _ExpNote.Id, 
					"@BillCode",  _ExpNote.BillCode, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpNote.UpdateDate), 
					"@Comment",  _ExpNote.Comment, 
					"@Author",  _ExpNote.Author, 
					"@Color",  _ExpNote.Color, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpNote vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpNote _ExpNote)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpNote] SET BillCode=@BillCode, UpdateDate=@UpdateDate, Comment=@Comment, Author=@Author, Color=@Color WHERE Id=@Id", 
					"@BillCode",  _ExpNote.BillCode, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpNote.UpdateDate), 
					"@Comment",  _ExpNote.Comment, 
					"@Author",  _ExpNote.Author, 
					"@Color",  _ExpNote.Color, 
					"@Id", _ExpNote.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpNote vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpNote> _ExpNotes)
		{
			foreach (ExpNote item in _ExpNotes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpNote vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpNote _ExpNote, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpNote] SET Id=@Id, BillCode=@BillCode, UpdateDate=@UpdateDate, Comment=@Comment, Author=@Author, Color=@Color "+ condition, 
					"@Id",  _ExpNote.Id, 
					"@BillCode",  _ExpNote.BillCode, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpNote.UpdateDate), 
					"@Comment",  _ExpNote.Comment, 
					"@Author",  _ExpNote.Author, 
					"@Color",  _ExpNote.Color);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpNote trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpNote] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpNote trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpNote _ExpNote)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpNote] WHERE Id=@Id",
					"@Id", _ExpNote.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpNote trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpNote] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpNote trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpNote> _ExpNotes)
		{
			foreach (ExpNote item in _ExpNotes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
