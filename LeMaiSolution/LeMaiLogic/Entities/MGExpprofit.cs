using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprofit:IGExpprofit
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprofit(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProfit từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProfit]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProfit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProfit] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProfit từ Database
		/// </summary>
		public List<GExpProfit> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProfit]");
				List<GExpProfit> items = new List<GExpProfit>();
				GExpProfit item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProfit();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["DateComfirm"] != null && dr["DateComfirm"] != DBNull.Value)
					{
						item.DateComfirm = Convert.ToDateTime(dr["DateComfirm"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["FeeConfirm"] != null && dr["FeeConfirm"] != DBNull.Value)
					{
						item.FeeConfirm = Convert.ToDecimal(dr["FeeConfirm"]);
					}
					if (dr["FeeTotal"] != null && dr["FeeTotal"] != DBNull.Value)
					{
						item.FeeTotal = Convert.ToDecimal(dr["FeeTotal"]);
					}
					if (dr["Profit"] != null && dr["Profit"] != DBNull.Value)
					{
						item.Profit = Convert.ToDecimal(dr["Profit"]);
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
		/// Lấy danh sách GExpProfit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProfit> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProfit] A "+ condition,  parameters);
				List<GExpProfit> items = new List<GExpProfit>();
				GExpProfit item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProfit();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["DateComfirm"] != null && dr["DateComfirm"] != DBNull.Value)
					{
						item.DateComfirm = Convert.ToDateTime(dr["DateComfirm"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["FeeConfirm"] != null && dr["FeeConfirm"] != DBNull.Value)
					{
						item.FeeConfirm = Convert.ToDecimal(dr["FeeConfirm"]);
					}
					if (dr["FeeTotal"] != null && dr["FeeTotal"] != DBNull.Value)
					{
						item.FeeTotal = Convert.ToDecimal(dr["FeeTotal"]);
					}
					if (dr["Profit"] != null && dr["Profit"] != DBNull.Value)
					{
						item.Profit = Convert.ToDecimal(dr["Profit"]);
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

		public List<GExpProfit> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProfit] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProfit] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProfit>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProfit từ Database
		/// </summary>
		public GExpProfit GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProfit] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpProfit item=new GExpProfit();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["DateComfirm"] != null && dr["DateComfirm"] != DBNull.Value)
						{
							item.DateComfirm = Convert.ToDateTime(dr["DateComfirm"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["FeeConfirm"] != null && dr["FeeConfirm"] != DBNull.Value)
						{
							item.FeeConfirm = Convert.ToDecimal(dr["FeeConfirm"]);
						}
						if (dr["FeeTotal"] != null && dr["FeeTotal"] != DBNull.Value)
						{
							item.FeeTotal = Convert.ToDecimal(dr["FeeTotal"]);
						}
						if (dr["Profit"] != null && dr["Profit"] != DBNull.Value)
						{
							item.Profit = Convert.ToDecimal(dr["Profit"]);
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
		/// Lấy một GExpProfit đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProfit GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProfit] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProfit item=new GExpProfit();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["DateComfirm"] != null && dr["DateComfirm"] != DBNull.Value)
						{
							item.DateComfirm = Convert.ToDateTime(dr["DateComfirm"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["FeeConfirm"] != null && dr["FeeConfirm"] != DBNull.Value)
						{
							item.FeeConfirm = Convert.ToDecimal(dr["FeeConfirm"]);
						}
						if (dr["FeeTotal"] != null && dr["FeeTotal"] != DBNull.Value)
						{
							item.FeeTotal = Convert.ToDecimal(dr["FeeTotal"]);
						}
						if (dr["Profit"] != null && dr["Profit"] != DBNull.Value)
						{
							item.Profit = Convert.ToDecimal(dr["Profit"]);
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

		public GExpProfit GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProfit] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProfit>(ds);
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
		/// Thêm mới GExpProfit vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProfit _GExpProfit)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProfit](Id, DateComfirm, BT3Code, StatusName, FeeConfirm, FeeTotal, Profit) VALUES(@Id, @DateComfirm, @BT3Code, @StatusName, @FeeConfirm, @FeeTotal, @Profit)", 
					"@Id",  _GExpProfit.Id, 
					"@DateComfirm", this._dataContext.ConvertDateString( _GExpProfit.DateComfirm), 
					"@BT3Code",  _GExpProfit.BT3Code, 
					"@StatusName",  _GExpProfit.StatusName, 
					"@FeeConfirm",  _GExpProfit.FeeConfirm, 
					"@FeeTotal",  _GExpProfit.FeeTotal, 
					"@Profit",  _GExpProfit.Profit);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProfit vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProfit> _GExpProfits)
		{
			foreach (GExpProfit item in _GExpProfits)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProfit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProfit _GExpProfit, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProfit] SET Id=@Id, DateComfirm=@DateComfirm, BT3Code=@BT3Code, StatusName=@StatusName, FeeConfirm=@FeeConfirm, FeeTotal=@FeeTotal, Profit=@Profit WHERE Id=@Id", 
					"@Id",  _GExpProfit.Id, 
					"@DateComfirm", this._dataContext.ConvertDateString( _GExpProfit.DateComfirm), 
					"@BT3Code",  _GExpProfit.BT3Code, 
					"@StatusName",  _GExpProfit.StatusName, 
					"@FeeConfirm",  _GExpProfit.FeeConfirm, 
					"@FeeTotal",  _GExpProfit.FeeTotal, 
					"@Profit",  _GExpProfit.Profit, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProfit vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProfit _GExpProfit)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProfit] SET DateComfirm=@DateComfirm, BT3Code=@BT3Code, StatusName=@StatusName, FeeConfirm=@FeeConfirm, FeeTotal=@FeeTotal, Profit=@Profit WHERE Id=@Id", 
					"@DateComfirm", this._dataContext.ConvertDateString( _GExpProfit.DateComfirm), 
					"@BT3Code",  _GExpProfit.BT3Code, 
					"@StatusName",  _GExpProfit.StatusName, 
					"@FeeConfirm",  _GExpProfit.FeeConfirm, 
					"@FeeTotal",  _GExpProfit.FeeTotal, 
					"@Profit",  _GExpProfit.Profit, 
					"@Id", _GExpProfit.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProfit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProfit> _GExpProfits)
		{
			foreach (GExpProfit item in _GExpProfits)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProfit vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProfit _GExpProfit, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProfit] SET Id=@Id, DateComfirm=@DateComfirm, BT3Code=@BT3Code, StatusName=@StatusName, FeeConfirm=@FeeConfirm, FeeTotal=@FeeTotal, Profit=@Profit "+ condition, 
					"@Id",  _GExpProfit.Id, 
					"@DateComfirm", this._dataContext.ConvertDateString( _GExpProfit.DateComfirm), 
					"@BT3Code",  _GExpProfit.BT3Code, 
					"@StatusName",  _GExpProfit.StatusName, 
					"@FeeConfirm",  _GExpProfit.FeeConfirm, 
					"@FeeTotal",  _GExpProfit.FeeTotal, 
					"@Profit",  _GExpProfit.Profit);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProfit trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProfit] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProfit trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProfit _GExpProfit)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProfit] WHERE Id=@Id",
					"@Id", _GExpProfit.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProfit trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProfit] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProfit trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProfit> _GExpProfits)
		{
			foreach (GExpProfit item in _GExpProfits)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
