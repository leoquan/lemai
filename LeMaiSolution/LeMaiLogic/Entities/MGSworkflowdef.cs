using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSworkflowdef:IGSworkflowdef
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSworkflowdef(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsWorkFlowDef từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsWorkFlowDef]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsWorkFlowDef từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsWorkFlowDef] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsWorkFlowDef từ Database
		/// </summary>
		public List<GsWorkFlowDef> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsWorkFlowDef]");
				List<GsWorkFlowDef> items = new List<GsWorkFlowDef>();
				GsWorkFlowDef item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsWorkFlowDef();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["WorkFlowDefName"] != null && dr["WorkFlowDefName"] != DBNull.Value)
					{
						item.WorkFlowDefName = Convert.ToString(dr["WorkFlowDefName"]);
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
		/// Lấy danh sách GsWorkFlowDef từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsWorkFlowDef> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsWorkFlowDef] A "+ condition,  parameters);
				List<GsWorkFlowDef> items = new List<GsWorkFlowDef>();
				GsWorkFlowDef item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsWorkFlowDef();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["WorkFlowDefName"] != null && dr["WorkFlowDefName"] != DBNull.Value)
					{
						item.WorkFlowDefName = Convert.ToString(dr["WorkFlowDefName"]);
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

		public List<GsWorkFlowDef> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsWorkFlowDef] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsWorkFlowDef] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsWorkFlowDef>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsWorkFlowDef từ Database
		/// </summary>
		public GsWorkFlowDef GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsWorkFlowDef] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsWorkFlowDef item=new GsWorkFlowDef();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["WorkFlowDefName"] != null && dr["WorkFlowDefName"] != DBNull.Value)
						{
							item.WorkFlowDefName = Convert.ToString(dr["WorkFlowDefName"]);
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
		/// Lấy một GsWorkFlowDef đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsWorkFlowDef GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsWorkFlowDef] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsWorkFlowDef item=new GsWorkFlowDef();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["WorkFlowDefName"] != null && dr["WorkFlowDefName"] != DBNull.Value)
						{
							item.WorkFlowDefName = Convert.ToString(dr["WorkFlowDefName"]);
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

		public GsWorkFlowDef GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsWorkFlowDef] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsWorkFlowDef>(ds);
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
		/// Thêm mới GsWorkFlowDef vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsWorkFlowDef _GsWorkFlowDef)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsWorkFlowDef](Id, WorkFlowDefName) VALUES(@Id, @WorkFlowDefName)", 
					"@Id",  _GsWorkFlowDef.Id, 
					"@WorkFlowDefName",  _GsWorkFlowDef.WorkFlowDefName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsWorkFlowDef vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsWorkFlowDef> _GsWorkFlowDefs)
		{
			foreach (GsWorkFlowDef item in _GsWorkFlowDefs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsWorkFlowDef vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsWorkFlowDef _GsWorkFlowDef, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsWorkFlowDef] SET Id=@Id, WorkFlowDefName=@WorkFlowDefName WHERE Id=@Id", 
					"@Id",  _GsWorkFlowDef.Id, 
					"@WorkFlowDefName",  _GsWorkFlowDef.WorkFlowDefName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsWorkFlowDef vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsWorkFlowDef _GsWorkFlowDef)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsWorkFlowDef] SET WorkFlowDefName=@WorkFlowDefName WHERE Id=@Id", 
					"@WorkFlowDefName",  _GsWorkFlowDef.WorkFlowDefName, 
					"@Id", _GsWorkFlowDef.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsWorkFlowDef vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsWorkFlowDef> _GsWorkFlowDefs)
		{
			foreach (GsWorkFlowDef item in _GsWorkFlowDefs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsWorkFlowDef vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsWorkFlowDef _GsWorkFlowDef, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsWorkFlowDef] SET Id=@Id, WorkFlowDefName=@WorkFlowDefName "+ condition, 
					"@Id",  _GsWorkFlowDef.Id, 
					"@WorkFlowDefName",  _GsWorkFlowDef.WorkFlowDefName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsWorkFlowDef trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsWorkFlowDef] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsWorkFlowDef trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsWorkFlowDef _GsWorkFlowDef)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsWorkFlowDef] WHERE Id=@Id",
					"@Id", _GsWorkFlowDef.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsWorkFlowDef trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsWorkFlowDef] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsWorkFlowDef trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsWorkFlowDef> _GsWorkFlowDefs)
		{
			foreach (GsWorkFlowDef item in _GsWorkFlowDefs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
