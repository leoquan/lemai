using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpwithdrawal:IEXpwithdrawal
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpwithdrawal(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpWithDrawal từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithDrawal]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpWithDrawal từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithDrawal] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpWithDrawal từ Database
		/// </summary>
		public List<ExpWithDrawal> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithDrawal]");
				List<ExpWithDrawal> items = new List<ExpWithDrawal>();
				ExpWithDrawal item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpWithDrawal();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["NoiDung"] != null && dr["NoiDung"] != DBNull.Value)
					{
						item.NoiDung = Convert.ToString(dr["NoiDung"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
					}
					if (dr["IsWithDrawal"] != null && dr["IsWithDrawal"] != DBNull.Value)
					{
						item.IsWithDrawal = Convert.ToBoolean(dr["IsWithDrawal"]);
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
		/// Lấy danh sách ExpWithDrawal từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpWithDrawal> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpWithDrawal] A "+ condition,  parameters);
				List<ExpWithDrawal> items = new List<ExpWithDrawal>();
				ExpWithDrawal item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpWithDrawal();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["NoiDung"] != null && dr["NoiDung"] != DBNull.Value)
					{
						item.NoiDung = Convert.ToString(dr["NoiDung"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
					}
					if (dr["IsWithDrawal"] != null && dr["IsWithDrawal"] != DBNull.Value)
					{
						item.IsWithDrawal = Convert.ToBoolean(dr["IsWithDrawal"]);
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

		public List<ExpWithDrawal> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpWithDrawal] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpWithDrawal] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpWithDrawal>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpWithDrawal từ Database
		/// </summary>
		public ExpWithDrawal GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithDrawal] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpWithDrawal item=new ExpWithDrawal();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["NoiDung"] != null && dr["NoiDung"] != DBNull.Value)
						{
							item.NoiDung = Convert.ToString(dr["NoiDung"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
						{
							item.IsDone = Convert.ToBoolean(dr["IsDone"]);
						}
						if (dr["IsWithDrawal"] != null && dr["IsWithDrawal"] != DBNull.Value)
						{
							item.IsWithDrawal = Convert.ToBoolean(dr["IsWithDrawal"]);
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
		/// Lấy một ExpWithDrawal đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpWithDrawal GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpWithDrawal] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpWithDrawal item=new ExpWithDrawal();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["NoiDung"] != null && dr["NoiDung"] != DBNull.Value)
						{
							item.NoiDung = Convert.ToString(dr["NoiDung"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
						{
							item.IsDone = Convert.ToBoolean(dr["IsDone"]);
						}
						if (dr["IsWithDrawal"] != null && dr["IsWithDrawal"] != DBNull.Value)
						{
							item.IsWithDrawal = Convert.ToBoolean(dr["IsWithDrawal"]);
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

		public ExpWithDrawal GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpWithDrawal] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpWithDrawal>(ds);
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
		/// Thêm mới ExpWithDrawal vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpWithDrawal _ExpWithDrawal)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpWithDrawal](Id, FK_ExpPost, Value, NoiDung, CreateDate, CreateBy, IsDone, IsWithDrawal) VALUES(@Id, @FK_ExpPost, @Value, @NoiDung, @CreateDate, @CreateBy, @IsDone, @IsWithDrawal)", 
					"@Id",  _ExpWithDrawal.Id, 
					"@FK_ExpPost",  _ExpWithDrawal.FK_ExpPost, 
					"@Value",  _ExpWithDrawal.Value, 
					"@NoiDung",  _ExpWithDrawal.NoiDung, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpWithDrawal.CreateDate), 
					"@CreateBy",  _ExpWithDrawal.CreateBy, 
					"@IsDone",  _ExpWithDrawal.IsDone, 
					"@IsWithDrawal",  _ExpWithDrawal.IsWithDrawal);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpWithDrawal vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpWithDrawal> _ExpWithDrawals)
		{
			foreach (ExpWithDrawal item in _ExpWithDrawals)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpWithDrawal vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpWithDrawal _ExpWithDrawal, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithDrawal] SET Id=@Id, FK_ExpPost=@FK_ExpPost, Value=@Value, NoiDung=@NoiDung, CreateDate=@CreateDate, CreateBy=@CreateBy, IsDone=@IsDone, IsWithDrawal=@IsWithDrawal WHERE Id=@Id", 
					"@Id",  _ExpWithDrawal.Id, 
					"@FK_ExpPost",  _ExpWithDrawal.FK_ExpPost, 
					"@Value",  _ExpWithDrawal.Value, 
					"@NoiDung",  _ExpWithDrawal.NoiDung, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpWithDrawal.CreateDate), 
					"@CreateBy",  _ExpWithDrawal.CreateBy, 
					"@IsDone",  _ExpWithDrawal.IsDone, 
					"@IsWithDrawal",  _ExpWithDrawal.IsWithDrawal, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpWithDrawal vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpWithDrawal _ExpWithDrawal)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithDrawal] SET FK_ExpPost=@FK_ExpPost, Value=@Value, NoiDung=@NoiDung, CreateDate=@CreateDate, CreateBy=@CreateBy, IsDone=@IsDone, IsWithDrawal=@IsWithDrawal WHERE Id=@Id", 
					"@FK_ExpPost",  _ExpWithDrawal.FK_ExpPost, 
					"@Value",  _ExpWithDrawal.Value, 
					"@NoiDung",  _ExpWithDrawal.NoiDung, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpWithDrawal.CreateDate), 
					"@CreateBy",  _ExpWithDrawal.CreateBy, 
					"@IsDone",  _ExpWithDrawal.IsDone, 
					"@IsWithDrawal",  _ExpWithDrawal.IsWithDrawal, 
					"@Id", _ExpWithDrawal.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpWithDrawal vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpWithDrawal> _ExpWithDrawals)
		{
			foreach (ExpWithDrawal item in _ExpWithDrawals)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpWithDrawal vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpWithDrawal _ExpWithDrawal, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithDrawal] SET Id=@Id, FK_ExpPost=@FK_ExpPost, Value=@Value, NoiDung=@NoiDung, CreateDate=@CreateDate, CreateBy=@CreateBy, IsDone=@IsDone, IsWithDrawal=@IsWithDrawal "+ condition, 
					"@Id",  _ExpWithDrawal.Id, 
					"@FK_ExpPost",  _ExpWithDrawal.FK_ExpPost, 
					"@Value",  _ExpWithDrawal.Value, 
					"@NoiDung",  _ExpWithDrawal.NoiDung, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpWithDrawal.CreateDate), 
					"@CreateBy",  _ExpWithDrawal.CreateBy, 
					"@IsDone",  _ExpWithDrawal.IsDone, 
					"@IsWithDrawal",  _ExpWithDrawal.IsWithDrawal);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpWithDrawal trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithDrawal] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithDrawal trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpWithDrawal _ExpWithDrawal)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithDrawal] WHERE Id=@Id",
					"@Id", _ExpWithDrawal.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithDrawal trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithDrawal] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithDrawal trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpWithDrawal> _ExpWithDrawals)
		{
			foreach (ExpWithDrawal item in _ExpWithDrawals)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
