using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbbranch:IWEbbranch
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbbranch(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebBranch từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebBranch]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebBranch] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebBranch từ Database
		/// </summary>
		public List<WebBranch> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebBranch]");
				List<WebBranch> items = new List<WebBranch>();
				WebBranch item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebBranch();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy danh sách WebBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebBranch> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebBranch] A "+ condition,  parameters);
				List<WebBranch> items = new List<WebBranch>();
				WebBranch item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebBranch();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public List<WebBranch> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebBranch] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebBranch] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebBranch>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebBranch từ Database
		/// </summary>
		public WebBranch GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebBranch] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebBranch item=new WebBranch();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
						{
							item.BranchName = Convert.ToString(dr["BranchName"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy một WebBranch đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebBranch GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebBranch] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebBranch item=new WebBranch();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
						{
							item.BranchName = Convert.ToString(dr["BranchName"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public WebBranch GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebBranch] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebBranch>(ds);
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
		/// Thêm mới WebBranch vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebBranch _WebBranch)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebBranch](Id, BranchName, BranchCode) VALUES(@Id, @BranchName, @BranchCode)", 
					"@Id",  _WebBranch.Id, 
					"@BranchName",  _WebBranch.BranchName, 
					"@BranchCode",  _WebBranch.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebBranch vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebBranch> _WebBranchs)
		{
			foreach (WebBranch item in _WebBranchs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebBranch _WebBranch, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebBranch] SET Id=@Id, BranchName=@BranchName, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebBranch.Id, 
					"@BranchName",  _WebBranch.BranchName, 
					"@BranchCode",  _WebBranch.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebBranch vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebBranch _WebBranch)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebBranch] SET BranchName=@BranchName, BranchCode=@BranchCode WHERE Id=@Id", 
					"@BranchName",  _WebBranch.BranchName, 
					"@BranchCode",  _WebBranch.BranchCode, 
					"@Id", _WebBranch.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebBranch> _WebBranchs)
		{
			foreach (WebBranch item in _WebBranchs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebBranch vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebBranch _WebBranch, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebBranch] SET Id=@Id, BranchName=@BranchName, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebBranch.Id, 
					"@BranchName",  _WebBranch.BranchName, 
					"@BranchCode",  _WebBranch.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebBranch trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebBranch] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebBranch trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebBranch _WebBranch)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebBranch] WHERE Id=@Id",
					"@Id", _WebBranch.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebBranch trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebBranch] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebBranch trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebBranch> _WebBranchs)
		{
			foreach (WebBranch item in _WebBranchs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
