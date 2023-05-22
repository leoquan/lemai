using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpproviceproblem:IEXpproviceproblem
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpproviceproblem(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpProviceProblem từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProviceProblem]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpProviceProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProviceProblem] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpProviceProblem từ Database
		/// </summary>
		public List<ExpProviceProblem> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProviceProblem]");
				List<ExpProviceProblem> items = new List<ExpProviceProblem>();
				ExpProviceProblem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpProviceProblem();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
					{
						item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
					}
					if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
					{
						item.KeyWord = Convert.ToString(dr["KeyWord"]);
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
		/// Lấy danh sách ExpProviceProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpProviceProblem> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpProviceProblem] A "+ condition,  parameters);
				List<ExpProviceProblem> items = new List<ExpProviceProblem>();
				ExpProviceProblem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpProviceProblem();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
					{
						item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
					}
					if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
					{
						item.KeyWord = Convert.ToString(dr["KeyWord"]);
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

		public List<ExpProviceProblem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpProviceProblem] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpProviceProblem] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpProviceProblem>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpProviceProblem từ Database
		/// </summary>
		public ExpProviceProblem GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProviceProblem] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpProviceProblem item=new ExpProviceProblem();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
						{
							item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
						}
						if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
						{
							item.KeyWord = Convert.ToString(dr["KeyWord"]);
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
		/// Lấy một ExpProviceProblem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpProviceProblem GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpProviceProblem] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpProviceProblem item=new ExpProviceProblem();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
						{
							item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
						}
						if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
						{
							item.KeyWord = Convert.ToString(dr["KeyWord"]);
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

		public ExpProviceProblem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpProviceProblem] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpProviceProblem>(ds);
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
		/// Thêm mới ExpProviceProblem vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpProviceProblem _ExpProviceProblem)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpProviceProblem](Id, ProvinceName, KeyWord) VALUES(@Id, @ProvinceName, @KeyWord)", 
					"@Id",  _ExpProviceProblem.Id, 
					"@ProvinceName",  _ExpProviceProblem.ProvinceName, 
					"@KeyWord",  _ExpProviceProblem.KeyWord);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpProviceProblem vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpProviceProblem> _ExpProviceProblems)
		{
			foreach (ExpProviceProblem item in _ExpProviceProblems)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpProviceProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpProviceProblem _ExpProviceProblem, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProviceProblem] SET Id=@Id, ProvinceName=@ProvinceName, KeyWord=@KeyWord WHERE Id=@Id", 
					"@Id",  _ExpProviceProblem.Id, 
					"@ProvinceName",  _ExpProviceProblem.ProvinceName, 
					"@KeyWord",  _ExpProviceProblem.KeyWord, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpProviceProblem vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpProviceProblem _ExpProviceProblem)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProviceProblem] SET ProvinceName=@ProvinceName, KeyWord=@KeyWord WHERE Id=@Id", 
					"@ProvinceName",  _ExpProviceProblem.ProvinceName, 
					"@KeyWord",  _ExpProviceProblem.KeyWord, 
					"@Id", _ExpProviceProblem.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpProviceProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpProviceProblem> _ExpProviceProblems)
		{
			foreach (ExpProviceProblem item in _ExpProviceProblems)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpProviceProblem vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpProviceProblem _ExpProviceProblem, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProviceProblem] SET Id=@Id, ProvinceName=@ProvinceName, KeyWord=@KeyWord "+ condition, 
					"@Id",  _ExpProviceProblem.Id, 
					"@ProvinceName",  _ExpProviceProblem.ProvinceName, 
					"@KeyWord",  _ExpProviceProblem.KeyWord);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpProviceProblem trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProviceProblem] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProviceProblem trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpProviceProblem _ExpProviceProblem)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProviceProblem] WHERE Id=@Id",
					"@Id", _ExpProviceProblem.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProviceProblem trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProviceProblem] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProviceProblem trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpProviceProblem> _ExpProviceProblems)
		{
			foreach (ExpProviceProblem item in _ExpProviceProblems)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
