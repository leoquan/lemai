using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpmistake:IEXpmistake
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpmistake(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpMistake từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpMistake]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpMistake từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpMistake] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpMistake từ Database
		/// </summary>
		public List<ExpMistake> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpMistake]");
				List<ExpMistake> items = new List<ExpMistake>();
				ExpMistake item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpMistake();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MistakeComment"] != null && dr["MistakeComment"] != DBNull.Value)
					{
						item.MistakeComment = Convert.ToString(dr["MistakeComment"]);
					}
					if (dr["FK_MistakeOn"] != null && dr["FK_MistakeOn"] != DBNull.Value)
					{
						item.FK_MistakeOn = Convert.ToString(dr["FK_MistakeOn"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
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
		/// Lấy danh sách ExpMistake từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpMistake> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpMistake] A "+ condition,  parameters);
				List<ExpMistake> items = new List<ExpMistake>();
				ExpMistake item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpMistake();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MistakeComment"] != null && dr["MistakeComment"] != DBNull.Value)
					{
						item.MistakeComment = Convert.ToString(dr["MistakeComment"]);
					}
					if (dr["FK_MistakeOn"] != null && dr["FK_MistakeOn"] != DBNull.Value)
					{
						item.FK_MistakeOn = Convert.ToString(dr["FK_MistakeOn"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
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

		public List<ExpMistake> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpMistake] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpMistake] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpMistake>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpMistake từ Database
		/// </summary>
		public ExpMistake GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpMistake] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpMistake item=new ExpMistake();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MistakeComment"] != null && dr["MistakeComment"] != DBNull.Value)
						{
							item.MistakeComment = Convert.ToString(dr["MistakeComment"]);
						}
						if (dr["FK_MistakeOn"] != null && dr["FK_MistakeOn"] != DBNull.Value)
						{
							item.FK_MistakeOn = Convert.ToString(dr["FK_MistakeOn"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
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
		/// Lấy một ExpMistake đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpMistake GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpMistake] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpMistake item=new ExpMistake();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MistakeComment"] != null && dr["MistakeComment"] != DBNull.Value)
						{
							item.MistakeComment = Convert.ToString(dr["MistakeComment"]);
						}
						if (dr["FK_MistakeOn"] != null && dr["FK_MistakeOn"] != DBNull.Value)
						{
							item.FK_MistakeOn = Convert.ToString(dr["FK_MistakeOn"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
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

		public ExpMistake GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpMistake] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpMistake>(ds);
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
		/// Thêm mới ExpMistake vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpMistake _ExpMistake)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpMistake](Id, MistakeComment, FK_MistakeOn, CreateDate, CreateBy) VALUES(@Id, @MistakeComment, @FK_MistakeOn, @CreateDate, @CreateBy)", 
					"@Id",  _ExpMistake.Id, 
					"@MistakeComment",  _ExpMistake.MistakeComment, 
					"@FK_MistakeOn",  _ExpMistake.FK_MistakeOn, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpMistake.CreateDate), 
					"@CreateBy",  _ExpMistake.CreateBy);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpMistake vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpMistake> _ExpMistakes)
		{
			foreach (ExpMistake item in _ExpMistakes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpMistake vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpMistake _ExpMistake, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpMistake] SET Id=@Id, MistakeComment=@MistakeComment, FK_MistakeOn=@FK_MistakeOn, CreateDate=@CreateDate, CreateBy=@CreateBy WHERE Id=@Id", 
					"@Id",  _ExpMistake.Id, 
					"@MistakeComment",  _ExpMistake.MistakeComment, 
					"@FK_MistakeOn",  _ExpMistake.FK_MistakeOn, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpMistake.CreateDate), 
					"@CreateBy",  _ExpMistake.CreateBy, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpMistake vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpMistake _ExpMistake)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpMistake] SET MistakeComment=@MistakeComment, FK_MistakeOn=@FK_MistakeOn, CreateDate=@CreateDate, CreateBy=@CreateBy WHERE Id=@Id", 
					"@MistakeComment",  _ExpMistake.MistakeComment, 
					"@FK_MistakeOn",  _ExpMistake.FK_MistakeOn, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpMistake.CreateDate), 
					"@CreateBy",  _ExpMistake.CreateBy, 
					"@Id", _ExpMistake.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpMistake vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpMistake> _ExpMistakes)
		{
			foreach (ExpMistake item in _ExpMistakes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpMistake vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpMistake _ExpMistake, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpMistake] SET Id=@Id, MistakeComment=@MistakeComment, FK_MistakeOn=@FK_MistakeOn, CreateDate=@CreateDate, CreateBy=@CreateBy "+ condition, 
					"@Id",  _ExpMistake.Id, 
					"@MistakeComment",  _ExpMistake.MistakeComment, 
					"@FK_MistakeOn",  _ExpMistake.FK_MistakeOn, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpMistake.CreateDate), 
					"@CreateBy",  _ExpMistake.CreateBy);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpMistake trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpMistake] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpMistake trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpMistake _ExpMistake)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpMistake] WHERE Id=@Id",
					"@Id", _ExpMistake.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpMistake trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpMistake] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpMistake trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpMistake> _ExpMistakes)
		{
			foreach (ExpMistake item in _ExpMistakes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
