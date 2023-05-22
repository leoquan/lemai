using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXplogerrorcheck:IEXplogerrorcheck
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXplogerrorcheck(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpLogErrorCheck từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLogErrorCheck]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpLogErrorCheck từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLogErrorCheck] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpLogErrorCheck từ Database
		/// </summary>
		public List<ExpLogErrorCheck> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLogErrorCheck]");
				List<ExpLogErrorCheck> items = new List<ExpLogErrorCheck>();
				ExpLogErrorCheck item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpLogErrorCheck();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["HuyenCode"] != null && dr["HuyenCode"] != DBNull.Value)
					{
						item.HuyenCode = Convert.ToString(dr["HuyenCode"]);
					}
					if (dr["SiteCode"] != null && dr["SiteCode"] != DBNull.Value)
					{
						item.SiteCode = Convert.ToString(dr["SiteCode"]);
					}
					if (dr["CreateSite"] != null && dr["CreateSite"] != DBNull.Value)
					{
						item.CreateSite = Convert.ToString(dr["CreateSite"]);
					}
					if (dr["ManCode"] != null && dr["ManCode"] != DBNull.Value)
					{
						item.ManCode = Convert.ToString(dr["ManCode"]);
					}
					if (dr["ResultCheck"] != null && dr["ResultCheck"] != DBNull.Value)
					{
						item.ResultCheck = Convert.ToInt32(dr["ResultCheck"]);
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
		/// Lấy danh sách ExpLogErrorCheck từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpLogErrorCheck> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpLogErrorCheck] A "+ condition,  parameters);
				List<ExpLogErrorCheck> items = new List<ExpLogErrorCheck>();
				ExpLogErrorCheck item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpLogErrorCheck();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["HuyenCode"] != null && dr["HuyenCode"] != DBNull.Value)
					{
						item.HuyenCode = Convert.ToString(dr["HuyenCode"]);
					}
					if (dr["SiteCode"] != null && dr["SiteCode"] != DBNull.Value)
					{
						item.SiteCode = Convert.ToString(dr["SiteCode"]);
					}
					if (dr["CreateSite"] != null && dr["CreateSite"] != DBNull.Value)
					{
						item.CreateSite = Convert.ToString(dr["CreateSite"]);
					}
					if (dr["ManCode"] != null && dr["ManCode"] != DBNull.Value)
					{
						item.ManCode = Convert.ToString(dr["ManCode"]);
					}
					if (dr["ResultCheck"] != null && dr["ResultCheck"] != DBNull.Value)
					{
						item.ResultCheck = Convert.ToInt32(dr["ResultCheck"]);
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

		public List<ExpLogErrorCheck> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpLogErrorCheck] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpLogErrorCheck] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpLogErrorCheck>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpLogErrorCheck từ Database
		/// </summary>
		public ExpLogErrorCheck GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLogErrorCheck] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpLogErrorCheck item=new ExpLogErrorCheck();
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
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["HuyenCode"] != null && dr["HuyenCode"] != DBNull.Value)
						{
							item.HuyenCode = Convert.ToString(dr["HuyenCode"]);
						}
						if (dr["SiteCode"] != null && dr["SiteCode"] != DBNull.Value)
						{
							item.SiteCode = Convert.ToString(dr["SiteCode"]);
						}
						if (dr["CreateSite"] != null && dr["CreateSite"] != DBNull.Value)
						{
							item.CreateSite = Convert.ToString(dr["CreateSite"]);
						}
						if (dr["ManCode"] != null && dr["ManCode"] != DBNull.Value)
						{
							item.ManCode = Convert.ToString(dr["ManCode"]);
						}
						if (dr["ResultCheck"] != null && dr["ResultCheck"] != DBNull.Value)
						{
							item.ResultCheck = Convert.ToInt32(dr["ResultCheck"]);
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
		/// Lấy một ExpLogErrorCheck đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpLogErrorCheck GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpLogErrorCheck] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpLogErrorCheck item=new ExpLogErrorCheck();
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
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["HuyenCode"] != null && dr["HuyenCode"] != DBNull.Value)
						{
							item.HuyenCode = Convert.ToString(dr["HuyenCode"]);
						}
						if (dr["SiteCode"] != null && dr["SiteCode"] != DBNull.Value)
						{
							item.SiteCode = Convert.ToString(dr["SiteCode"]);
						}
						if (dr["CreateSite"] != null && dr["CreateSite"] != DBNull.Value)
						{
							item.CreateSite = Convert.ToString(dr["CreateSite"]);
						}
						if (dr["ManCode"] != null && dr["ManCode"] != DBNull.Value)
						{
							item.ManCode = Convert.ToString(dr["ManCode"]);
						}
						if (dr["ResultCheck"] != null && dr["ResultCheck"] != DBNull.Value)
						{
							item.ResultCheck = Convert.ToInt32(dr["ResultCheck"]);
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

		public ExpLogErrorCheck GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpLogErrorCheck] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpLogErrorCheck>(ds);
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
		/// Thêm mới ExpLogErrorCheck vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpLogErrorCheck _ExpLogErrorCheck)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpLogErrorCheck](Id, BillCode, Address, HuyenCode, SiteCode, CreateSite, ManCode, ResultCheck) VALUES(@Id, @BillCode, @Address, @HuyenCode, @SiteCode, @CreateSite, @ManCode, @ResultCheck)", 
					"@Id",  _ExpLogErrorCheck.Id, 
					"@BillCode",  _ExpLogErrorCheck.BillCode, 
					"@Address",  _ExpLogErrorCheck.Address, 
					"@HuyenCode",  _ExpLogErrorCheck.HuyenCode, 
					"@SiteCode",  _ExpLogErrorCheck.SiteCode, 
					"@CreateSite",  _ExpLogErrorCheck.CreateSite, 
					"@ManCode",  _ExpLogErrorCheck.ManCode, 
					"@ResultCheck",  _ExpLogErrorCheck.ResultCheck);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpLogErrorCheck vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpLogErrorCheck> _ExpLogErrorChecks)
		{
			foreach (ExpLogErrorCheck item in _ExpLogErrorChecks)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpLogErrorCheck vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpLogErrorCheck _ExpLogErrorCheck, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLogErrorCheck] SET Id=@Id, BillCode=@BillCode, Address=@Address, HuyenCode=@HuyenCode, SiteCode=@SiteCode, CreateSite=@CreateSite, ManCode=@ManCode, ResultCheck=@ResultCheck WHERE Id=@Id", 
					"@Id",  _ExpLogErrorCheck.Id, 
					"@BillCode",  _ExpLogErrorCheck.BillCode, 
					"@Address",  _ExpLogErrorCheck.Address, 
					"@HuyenCode",  _ExpLogErrorCheck.HuyenCode, 
					"@SiteCode",  _ExpLogErrorCheck.SiteCode, 
					"@CreateSite",  _ExpLogErrorCheck.CreateSite, 
					"@ManCode",  _ExpLogErrorCheck.ManCode, 
					"@ResultCheck",  _ExpLogErrorCheck.ResultCheck, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpLogErrorCheck vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpLogErrorCheck _ExpLogErrorCheck)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLogErrorCheck] SET BillCode=@BillCode, Address=@Address, HuyenCode=@HuyenCode, SiteCode=@SiteCode, CreateSite=@CreateSite, ManCode=@ManCode, ResultCheck=@ResultCheck WHERE Id=@Id", 
					"@BillCode",  _ExpLogErrorCheck.BillCode, 
					"@Address",  _ExpLogErrorCheck.Address, 
					"@HuyenCode",  _ExpLogErrorCheck.HuyenCode, 
					"@SiteCode",  _ExpLogErrorCheck.SiteCode, 
					"@CreateSite",  _ExpLogErrorCheck.CreateSite, 
					"@ManCode",  _ExpLogErrorCheck.ManCode, 
					"@ResultCheck",  _ExpLogErrorCheck.ResultCheck, 
					"@Id", _ExpLogErrorCheck.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpLogErrorCheck vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpLogErrorCheck> _ExpLogErrorChecks)
		{
			foreach (ExpLogErrorCheck item in _ExpLogErrorChecks)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpLogErrorCheck vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpLogErrorCheck _ExpLogErrorCheck, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLogErrorCheck] SET Id=@Id, BillCode=@BillCode, Address=@Address, HuyenCode=@HuyenCode, SiteCode=@SiteCode, CreateSite=@CreateSite, ManCode=@ManCode, ResultCheck=@ResultCheck "+ condition, 
					"@Id",  _ExpLogErrorCheck.Id, 
					"@BillCode",  _ExpLogErrorCheck.BillCode, 
					"@Address",  _ExpLogErrorCheck.Address, 
					"@HuyenCode",  _ExpLogErrorCheck.HuyenCode, 
					"@SiteCode",  _ExpLogErrorCheck.SiteCode, 
					"@CreateSite",  _ExpLogErrorCheck.CreateSite, 
					"@ManCode",  _ExpLogErrorCheck.ManCode, 
					"@ResultCheck",  _ExpLogErrorCheck.ResultCheck);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpLogErrorCheck trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLogErrorCheck] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLogErrorCheck trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpLogErrorCheck _ExpLogErrorCheck)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLogErrorCheck] WHERE Id=@Id",
					"@Id", _ExpLogErrorCheck.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLogErrorCheck trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLogErrorCheck] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLogErrorCheck trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpLogErrorCheck> _ExpLogErrorChecks)
		{
			foreach (ExpLogErrorCheck item in _ExpLogErrorChecks)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
