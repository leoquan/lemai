using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpbillprocess:IEXpbillprocess
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpbillprocess(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpBillProcess từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBillProcess]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpBillProcess từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBillProcess] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpBillProcess từ Database
		/// </summary>
		public List<ExpBillProcess> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBillProcess]");
				List<ExpBillProcess> items = new List<ExpBillProcess>();
				ExpBillProcess item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpBillProcess();
					if (dr["Bill_Code"] != null && dr["Bill_Code"] != DBNull.Value)
					{
						item.Bill_Code = Convert.ToString(dr["Bill_Code"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["DateCreate"] != null && dr["DateCreate"] != DBNull.Value)
					{
						item.DateCreate = Convert.ToDateTime(dr["DateCreate"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
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
		/// Lấy danh sách ExpBillProcess từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpBillProcess> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpBillProcess] A "+ condition,  parameters);
				List<ExpBillProcess> items = new List<ExpBillProcess>();
				ExpBillProcess item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpBillProcess();
					if (dr["Bill_Code"] != null && dr["Bill_Code"] != DBNull.Value)
					{
						item.Bill_Code = Convert.ToString(dr["Bill_Code"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["DateCreate"] != null && dr["DateCreate"] != DBNull.Value)
					{
						item.DateCreate = Convert.ToDateTime(dr["DateCreate"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
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

		public List<ExpBillProcess> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpBillProcess] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpBillProcess] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpBillProcess>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpBillProcess từ Database
		/// </summary>
		public ExpBillProcess GetObject(string schema, String Bill_Code, Int32 Type)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBillProcess] where Bill_Code=@Bill_Code and Type=@Type",
					"@Bill_Code", Bill_Code, 
					"@Type", Type);
				if (ds.Rows.Count > 0)
				{
					ExpBillProcess item=new ExpBillProcess();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Bill_Code"] != null && dr["Bill_Code"] != DBNull.Value)
						{
							item.Bill_Code = Convert.ToString(dr["Bill_Code"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToInt32(dr["Type"]);
						}
						if (dr["DateCreate"] != null && dr["DateCreate"] != DBNull.Value)
						{
							item.DateCreate = Convert.ToDateTime(dr["DateCreate"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
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
		/// Lấy một ExpBillProcess đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpBillProcess GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpBillProcess] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpBillProcess item=new ExpBillProcess();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Bill_Code"] != null && dr["Bill_Code"] != DBNull.Value)
						{
							item.Bill_Code = Convert.ToString(dr["Bill_Code"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToInt32(dr["Type"]);
						}
						if (dr["DateCreate"] != null && dr["DateCreate"] != DBNull.Value)
						{
							item.DateCreate = Convert.ToDateTime(dr["DateCreate"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
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

		public ExpBillProcess GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpBillProcess] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpBillProcess>(ds);
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
		/// Thêm mới ExpBillProcess vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpBillProcess _ExpBillProcess)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpBillProcess](Bill_Code, Type, DateCreate, Value) VALUES(@Bill_Code, @Type, @DateCreate, @Value)", 
					"@Bill_Code",  _ExpBillProcess.Bill_Code, 
					"@Type",  _ExpBillProcess.Type, 
					"@DateCreate", this._dataContext.ConvertDateString( _ExpBillProcess.DateCreate), 
					"@Value",  _ExpBillProcess.Value);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpBillProcess vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpBillProcess> _ExpBillProcesss)
		{
			foreach (ExpBillProcess item in _ExpBillProcesss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpBillProcess vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpBillProcess _ExpBillProcess, String Bill_Code, Int32 Type)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBillProcess] SET Bill_Code=@Bill_Code, Type=@Type, DateCreate=@DateCreate, Value=@Value WHERE Bill_Code=@Bill_Code and Type=@Type", 
					"@Bill_Code",  _ExpBillProcess.Bill_Code, 
					"@Type",  _ExpBillProcess.Type, 
					"@DateCreate", this._dataContext.ConvertDateString( _ExpBillProcess.DateCreate), 
					"@Value",  _ExpBillProcess.Value, 
					"@Bill_Code", Bill_Code, 
					"@Type", Type);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpBillProcess vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpBillProcess _ExpBillProcess)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBillProcess] SET DateCreate=@DateCreate, Value=@Value WHERE Bill_Code=@Bill_Code and Type=@Type", 
					"@DateCreate", this._dataContext.ConvertDateString( _ExpBillProcess.DateCreate), 
					"@Value",  _ExpBillProcess.Value, 
					"@Bill_Code", _ExpBillProcess.Bill_Code, 
					"@Type", _ExpBillProcess.Type);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpBillProcess vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpBillProcess> _ExpBillProcesss)
		{
			foreach (ExpBillProcess item in _ExpBillProcesss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpBillProcess vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpBillProcess _ExpBillProcess, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBillProcess] SET Bill_Code=@Bill_Code, Type=@Type, DateCreate=@DateCreate, Value=@Value "+ condition, 
					"@Bill_Code",  _ExpBillProcess.Bill_Code, 
					"@Type",  _ExpBillProcess.Type, 
					"@DateCreate", this._dataContext.ConvertDateString( _ExpBillProcess.DateCreate), 
					"@Value",  _ExpBillProcess.Value);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpBillProcess trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Bill_Code, Int32 Type)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBillProcess] WHERE Bill_Code=@Bill_Code and Type=@Type",
					"@Bill_Code", Bill_Code, 
					"@Type", Type);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBillProcess trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpBillProcess _ExpBillProcess)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBillProcess] WHERE Bill_Code=@Bill_Code and Type=@Type",
					"@Bill_Code", _ExpBillProcess.Bill_Code, 
					"@Type", _ExpBillProcess.Type);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBillProcess trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBillProcess] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBillProcess trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpBillProcess> _ExpBillProcesss)
		{
			foreach (ExpBillProcess item in _ExpBillProcesss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
