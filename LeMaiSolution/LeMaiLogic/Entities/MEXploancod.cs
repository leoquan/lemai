using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXploancod:IEXploancod
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXploancod(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpLoanCod từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoanCod]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpLoanCod từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoanCod] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpLoanCod từ Database
		/// </summary>
		public List<ExpLoanCod> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoanCod]");
				List<ExpLoanCod> items = new List<ExpLoanCod>();
				ExpLoanCod item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpLoanCod();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToDecimal(dr["Value"]);
					}
					if (dr["IsBoiThuong"] != null && dr["IsBoiThuong"] != DBNull.Value)
					{
						item.IsBoiThuong = Convert.ToBoolean(dr["IsBoiThuong"]);
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
		/// Lấy danh sách ExpLoanCod từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpLoanCod> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpLoanCod] A "+ condition,  parameters);
				List<ExpLoanCod> items = new List<ExpLoanCod>();
				ExpLoanCod item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpLoanCod();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToDecimal(dr["Value"]);
					}
					if (dr["IsBoiThuong"] != null && dr["IsBoiThuong"] != DBNull.Value)
					{
						item.IsBoiThuong = Convert.ToBoolean(dr["IsBoiThuong"]);
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

		public List<ExpLoanCod> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpLoanCod] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpLoanCod] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpLoanCod>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpLoanCod từ Database
		/// </summary>
		public ExpLoanCod GetObject(string schema, String BillCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoanCod] where BillCode=@BillCode",
					"@BillCode", BillCode);
				if (ds.Rows.Count > 0)
				{
					ExpLoanCod item=new ExpLoanCod();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToDecimal(dr["Value"]);
						}
						if (dr["IsBoiThuong"] != null && dr["IsBoiThuong"] != DBNull.Value)
						{
							item.IsBoiThuong = Convert.ToBoolean(dr["IsBoiThuong"]);
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
		/// Lấy một ExpLoanCod đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpLoanCod GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpLoanCod] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpLoanCod item=new ExpLoanCod();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToDecimal(dr["Value"]);
						}
						if (dr["IsBoiThuong"] != null && dr["IsBoiThuong"] != DBNull.Value)
						{
							item.IsBoiThuong = Convert.ToBoolean(dr["IsBoiThuong"]);
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

		public ExpLoanCod GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpLoanCod] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpLoanCod>(ds);
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
		/// Thêm mới ExpLoanCod vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpLoanCod _ExpLoanCod)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpLoanCod](BillCode, FK_Account, CreateBy, CreateDate, Value, IsBoiThuong) VALUES(@BillCode, @FK_Account, @CreateBy, @CreateDate, @Value, @IsBoiThuong)", 
					"@BillCode",  _ExpLoanCod.BillCode, 
					"@FK_Account",  _ExpLoanCod.FK_Account, 
					"@CreateBy",  _ExpLoanCod.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpLoanCod.CreateDate), 
					"@Value",  _ExpLoanCod.Value, 
					"@IsBoiThuong",  _ExpLoanCod.IsBoiThuong);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpLoanCod vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpLoanCod> _ExpLoanCods)
		{
			foreach (ExpLoanCod item in _ExpLoanCods)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpLoanCod vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpLoanCod _ExpLoanCod, String BillCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLoanCod] SET BillCode=@BillCode, FK_Account=@FK_Account, CreateBy=@CreateBy, CreateDate=@CreateDate, Value=@Value, IsBoiThuong=@IsBoiThuong WHERE BillCode=@BillCode", 
					"@BillCode",  _ExpLoanCod.BillCode, 
					"@FK_Account",  _ExpLoanCod.FK_Account, 
					"@CreateBy",  _ExpLoanCod.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpLoanCod.CreateDate), 
					"@Value",  _ExpLoanCod.Value, 
					"@IsBoiThuong",  _ExpLoanCod.IsBoiThuong, 
					"@BillCode", BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpLoanCod vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpLoanCod _ExpLoanCod)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLoanCod] SET FK_Account=@FK_Account, CreateBy=@CreateBy, CreateDate=@CreateDate, Value=@Value, IsBoiThuong=@IsBoiThuong WHERE BillCode=@BillCode", 
					"@FK_Account",  _ExpLoanCod.FK_Account, 
					"@CreateBy",  _ExpLoanCod.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpLoanCod.CreateDate), 
					"@Value",  _ExpLoanCod.Value, 
					"@IsBoiThuong",  _ExpLoanCod.IsBoiThuong, 
					"@BillCode", _ExpLoanCod.BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpLoanCod vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpLoanCod> _ExpLoanCods)
		{
			foreach (ExpLoanCod item in _ExpLoanCods)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpLoanCod vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpLoanCod _ExpLoanCod, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLoanCod] SET BillCode=@BillCode, FK_Account=@FK_Account, CreateBy=@CreateBy, CreateDate=@CreateDate, Value=@Value, IsBoiThuong=@IsBoiThuong "+ condition, 
					"@BillCode",  _ExpLoanCod.BillCode, 
					"@FK_Account",  _ExpLoanCod.FK_Account, 
					"@CreateBy",  _ExpLoanCod.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpLoanCod.CreateDate), 
					"@Value",  _ExpLoanCod.Value, 
					"@IsBoiThuong",  _ExpLoanCod.IsBoiThuong);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpLoanCod trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BillCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLoanCod] WHERE BillCode=@BillCode",
					"@BillCode", BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLoanCod trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpLoanCod _ExpLoanCod)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLoanCod] WHERE BillCode=@BillCode",
					"@BillCode", _ExpLoanCod.BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLoanCod trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLoanCod] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLoanCod trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpLoanCod> _ExpLoanCods)
		{
			foreach (ExpLoanCod item in _ExpLoanCods)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
