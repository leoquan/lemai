using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpproblem:IEXpproblem
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpproblem(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpProblem từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProblem]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProblem] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpProblem từ Database
		/// </summary>
		public List<ExpProblem> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProblem]");
				List<ExpProblem> items = new List<ExpProblem>();
				ExpProblem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpProblem();
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
					if (dr["TypeC1"] != null && dr["TypeC1"] != DBNull.Value)
					{
						item.TypeC1 = Convert.ToString(dr["TypeC1"]);
					}
					if (dr["TypeC2"] != null && dr["TypeC2"] != DBNull.Value)
					{
						item.TypeC2 = Convert.ToString(dr["TypeC2"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["Replay"] != null && dr["Replay"] != DBNull.Value)
					{
						item.Replay = Convert.ToString(dr["Replay"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["KEY_DATE"] != null && dr["KEY_DATE"] != DBNull.Value)
					{
						item.KEY_DATE = Convert.ToString(dr["KEY_DATE"]);
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
		/// Lấy danh sách ExpProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpProblem> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpProblem] A "+ condition,  parameters);
				List<ExpProblem> items = new List<ExpProblem>();
				ExpProblem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpProblem();
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
					if (dr["TypeC1"] != null && dr["TypeC1"] != DBNull.Value)
					{
						item.TypeC1 = Convert.ToString(dr["TypeC1"]);
					}
					if (dr["TypeC2"] != null && dr["TypeC2"] != DBNull.Value)
					{
						item.TypeC2 = Convert.ToString(dr["TypeC2"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["Replay"] != null && dr["Replay"] != DBNull.Value)
					{
						item.Replay = Convert.ToString(dr["Replay"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["KEY_DATE"] != null && dr["KEY_DATE"] != DBNull.Value)
					{
						item.KEY_DATE = Convert.ToString(dr["KEY_DATE"]);
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

		public List<ExpProblem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpProblem] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpProblem] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpProblem>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpProblem từ Database
		/// </summary>
		public ExpProblem GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProblem] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpProblem item=new ExpProblem();
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
						if (dr["TypeC1"] != null && dr["TypeC1"] != DBNull.Value)
						{
							item.TypeC1 = Convert.ToString(dr["TypeC1"]);
						}
						if (dr["TypeC2"] != null && dr["TypeC2"] != DBNull.Value)
						{
							item.TypeC2 = Convert.ToString(dr["TypeC2"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["Replay"] != null && dr["Replay"] != DBNull.Value)
						{
							item.Replay = Convert.ToString(dr["Replay"]);
						}
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["KEY_DATE"] != null && dr["KEY_DATE"] != DBNull.Value)
						{
							item.KEY_DATE = Convert.ToString(dr["KEY_DATE"]);
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
		/// Lấy một ExpProblem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpProblem GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpProblem] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpProblem item=new ExpProblem();
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
						if (dr["TypeC1"] != null && dr["TypeC1"] != DBNull.Value)
						{
							item.TypeC1 = Convert.ToString(dr["TypeC1"]);
						}
						if (dr["TypeC2"] != null && dr["TypeC2"] != DBNull.Value)
						{
							item.TypeC2 = Convert.ToString(dr["TypeC2"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["Replay"] != null && dr["Replay"] != DBNull.Value)
						{
							item.Replay = Convert.ToString(dr["Replay"]);
						}
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["KEY_DATE"] != null && dr["KEY_DATE"] != DBNull.Value)
						{
							item.KEY_DATE = Convert.ToString(dr["KEY_DATE"]);
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

		public ExpProblem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpProblem] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpProblem>(ds);
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
		/// Thêm mới ExpProblem vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpProblem _ExpProblem)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpProblem](Id, Post, CreateDate, TypeC1, TypeC2, Note, Replay, BILL_CODE, KEY_DATE) VALUES(@Id, @Post, @CreateDate, @TypeC1, @TypeC2, @Note, @Replay, @BILL_CODE, @KEY_DATE)", 
					"@Id",  _ExpProblem.Id, 
					"@Post",  _ExpProblem.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpProblem.CreateDate), 
					"@TypeC1",  _ExpProblem.TypeC1, 
					"@TypeC2",  _ExpProblem.TypeC2, 
					"@Note",  _ExpProblem.Note, 
					"@Replay",  _ExpProblem.Replay, 
					"@BILL_CODE",  _ExpProblem.BILL_CODE, 
					"@KEY_DATE",  _ExpProblem.KEY_DATE);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpProblem vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpProblem> _ExpProblems)
		{
			foreach (ExpProblem item in _ExpProblems)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpProblem _ExpProblem, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProblem] SET Id=@Id, Post=@Post, CreateDate=@CreateDate, TypeC1=@TypeC1, TypeC2=@TypeC2, Note=@Note, Replay=@Replay, BILL_CODE=@BILL_CODE, KEY_DATE=@KEY_DATE WHERE Id=@Id", 
					"@Id",  _ExpProblem.Id, 
					"@Post",  _ExpProblem.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpProblem.CreateDate), 
					"@TypeC1",  _ExpProblem.TypeC1, 
					"@TypeC2",  _ExpProblem.TypeC2, 
					"@Note",  _ExpProblem.Note, 
					"@Replay",  _ExpProblem.Replay, 
					"@BILL_CODE",  _ExpProblem.BILL_CODE, 
					"@KEY_DATE",  _ExpProblem.KEY_DATE, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpProblem vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpProblem _ExpProblem)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProblem] SET Post=@Post, CreateDate=@CreateDate, TypeC1=@TypeC1, TypeC2=@TypeC2, Note=@Note, Replay=@Replay, BILL_CODE=@BILL_CODE, KEY_DATE=@KEY_DATE WHERE Id=@Id", 
					"@Post",  _ExpProblem.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpProblem.CreateDate), 
					"@TypeC1",  _ExpProblem.TypeC1, 
					"@TypeC2",  _ExpProblem.TypeC2, 
					"@Note",  _ExpProblem.Note, 
					"@Replay",  _ExpProblem.Replay, 
					"@BILL_CODE",  _ExpProblem.BILL_CODE, 
					"@KEY_DATE",  _ExpProblem.KEY_DATE, 
					"@Id", _ExpProblem.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpProblem> _ExpProblems)
		{
			foreach (ExpProblem item in _ExpProblems)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpProblem vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpProblem _ExpProblem, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProblem] SET Id=@Id, Post=@Post, CreateDate=@CreateDate, TypeC1=@TypeC1, TypeC2=@TypeC2, Note=@Note, Replay=@Replay, BILL_CODE=@BILL_CODE, KEY_DATE=@KEY_DATE "+ condition, 
					"@Id",  _ExpProblem.Id, 
					"@Post",  _ExpProblem.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpProblem.CreateDate), 
					"@TypeC1",  _ExpProblem.TypeC1, 
					"@TypeC2",  _ExpProblem.TypeC2, 
					"@Note",  _ExpProblem.Note, 
					"@Replay",  _ExpProblem.Replay, 
					"@BILL_CODE",  _ExpProblem.BILL_CODE, 
					"@KEY_DATE",  _ExpProblem.KEY_DATE);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpProblem trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProblem] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProblem trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpProblem _ExpProblem)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProblem] WHERE Id=@Id",
					"@Id", _ExpProblem.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProblem trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProblem] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProblem trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpProblem> _ExpProblems)
		{
			foreach (ExpProblem item in _ExpProblems)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
