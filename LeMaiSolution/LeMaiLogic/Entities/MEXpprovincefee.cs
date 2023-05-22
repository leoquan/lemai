using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpprovincefee:IEXpprovincefee
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpprovincefee(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpProvinceFee từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvinceFee]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpProvinceFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvinceFee] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpProvinceFee từ Database
		/// </summary>
		public List<ExpProvinceFee> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvinceFee]");
				List<ExpProvinceFee> items = new List<ExpProvinceFee>();
				ExpProvinceFee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpProvinceFee();
					if (dr["FeeID"] != null && dr["FeeID"] != DBNull.Value)
					{
						item.FeeID = Convert.ToString(dr["FeeID"]);
					}
					if (dr["ProvineName"] != null && dr["ProvineName"] != DBNull.Value)
					{
						item.ProvineName = Convert.ToString(dr["ProvineName"]);
					}
					if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
					{
						item.InitWeight = Convert.ToDecimal(dr["InitWeight"]);
					}
					if (dr["NextWeight"] != null && dr["NextWeight"] != DBNull.Value)
					{
						item.NextWeight = Convert.ToDecimal(dr["NextWeight"]);
					}
					if (dr["W05"] != null && dr["W05"] != DBNull.Value)
					{
						item.W05 = Convert.ToInt32(dr["W05"]);
					}
					if (dr["W10"] != null && dr["W10"] != DBNull.Value)
					{
						item.W10 = Convert.ToInt32(dr["W10"]);
					}
					if (dr["W30"] != null && dr["W30"] != DBNull.Value)
					{
						item.W30 = Convert.ToInt32(dr["W30"]);
					}
					if (dr["W50"] != null && dr["W50"] != DBNull.Value)
					{
						item.W50 = Convert.ToInt32(dr["W50"]);
					}
					if (dr["W500"] != null && dr["W500"] != DBNull.Value)
					{
						item.W500 = Convert.ToInt32(dr["W500"]);
					}
					if (dr["Zone"] != null && dr["Zone"] != DBNull.Value)
					{
						item.Zone = Convert.ToString(dr["Zone"]);
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
		/// Lấy danh sách ExpProvinceFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpProvinceFee> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpProvinceFee] A "+ condition,  parameters);
				List<ExpProvinceFee> items = new List<ExpProvinceFee>();
				ExpProvinceFee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpProvinceFee();
					if (dr["FeeID"] != null && dr["FeeID"] != DBNull.Value)
					{
						item.FeeID = Convert.ToString(dr["FeeID"]);
					}
					if (dr["ProvineName"] != null && dr["ProvineName"] != DBNull.Value)
					{
						item.ProvineName = Convert.ToString(dr["ProvineName"]);
					}
					if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
					{
						item.InitWeight = Convert.ToDecimal(dr["InitWeight"]);
					}
					if (dr["NextWeight"] != null && dr["NextWeight"] != DBNull.Value)
					{
						item.NextWeight = Convert.ToDecimal(dr["NextWeight"]);
					}
					if (dr["W05"] != null && dr["W05"] != DBNull.Value)
					{
						item.W05 = Convert.ToInt32(dr["W05"]);
					}
					if (dr["W10"] != null && dr["W10"] != DBNull.Value)
					{
						item.W10 = Convert.ToInt32(dr["W10"]);
					}
					if (dr["W30"] != null && dr["W30"] != DBNull.Value)
					{
						item.W30 = Convert.ToInt32(dr["W30"]);
					}
					if (dr["W50"] != null && dr["W50"] != DBNull.Value)
					{
						item.W50 = Convert.ToInt32(dr["W50"]);
					}
					if (dr["W500"] != null && dr["W500"] != DBNull.Value)
					{
						item.W500 = Convert.ToInt32(dr["W500"]);
					}
					if (dr["Zone"] != null && dr["Zone"] != DBNull.Value)
					{
						item.Zone = Convert.ToString(dr["Zone"]);
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

		public List<ExpProvinceFee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpProvinceFee] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpProvinceFee] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpProvinceFee>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpProvinceFee từ Database
		/// </summary>
		public ExpProvinceFee GetObject(string schema, String FeeID)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvinceFee] where FeeID=@FeeID",
					"@FeeID", FeeID);
				if (ds.Rows.Count > 0)
				{
					ExpProvinceFee item=new ExpProvinceFee();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FeeID"] != null && dr["FeeID"] != DBNull.Value)
						{
							item.FeeID = Convert.ToString(dr["FeeID"]);
						}
						if (dr["ProvineName"] != null && dr["ProvineName"] != DBNull.Value)
						{
							item.ProvineName = Convert.ToString(dr["ProvineName"]);
						}
						if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
						{
							item.InitWeight = Convert.ToDecimal(dr["InitWeight"]);
						}
						if (dr["NextWeight"] != null && dr["NextWeight"] != DBNull.Value)
						{
							item.NextWeight = Convert.ToDecimal(dr["NextWeight"]);
						}
						if (dr["W05"] != null && dr["W05"] != DBNull.Value)
						{
							item.W05 = Convert.ToInt32(dr["W05"]);
						}
						if (dr["W10"] != null && dr["W10"] != DBNull.Value)
						{
							item.W10 = Convert.ToInt32(dr["W10"]);
						}
						if (dr["W30"] != null && dr["W30"] != DBNull.Value)
						{
							item.W30 = Convert.ToInt32(dr["W30"]);
						}
						if (dr["W50"] != null && dr["W50"] != DBNull.Value)
						{
							item.W50 = Convert.ToInt32(dr["W50"]);
						}
						if (dr["W500"] != null && dr["W500"] != DBNull.Value)
						{
							item.W500 = Convert.ToInt32(dr["W500"]);
						}
						if (dr["Zone"] != null && dr["Zone"] != DBNull.Value)
						{
							item.Zone = Convert.ToString(dr["Zone"]);
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
		/// Lấy một ExpProvinceFee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpProvinceFee GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpProvinceFee] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpProvinceFee item=new ExpProvinceFee();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FeeID"] != null && dr["FeeID"] != DBNull.Value)
						{
							item.FeeID = Convert.ToString(dr["FeeID"]);
						}
						if (dr["ProvineName"] != null && dr["ProvineName"] != DBNull.Value)
						{
							item.ProvineName = Convert.ToString(dr["ProvineName"]);
						}
						if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
						{
							item.InitWeight = Convert.ToDecimal(dr["InitWeight"]);
						}
						if (dr["NextWeight"] != null && dr["NextWeight"] != DBNull.Value)
						{
							item.NextWeight = Convert.ToDecimal(dr["NextWeight"]);
						}
						if (dr["W05"] != null && dr["W05"] != DBNull.Value)
						{
							item.W05 = Convert.ToInt32(dr["W05"]);
						}
						if (dr["W10"] != null && dr["W10"] != DBNull.Value)
						{
							item.W10 = Convert.ToInt32(dr["W10"]);
						}
						if (dr["W30"] != null && dr["W30"] != DBNull.Value)
						{
							item.W30 = Convert.ToInt32(dr["W30"]);
						}
						if (dr["W50"] != null && dr["W50"] != DBNull.Value)
						{
							item.W50 = Convert.ToInt32(dr["W50"]);
						}
						if (dr["W500"] != null && dr["W500"] != DBNull.Value)
						{
							item.W500 = Convert.ToInt32(dr["W500"]);
						}
						if (dr["Zone"] != null && dr["Zone"] != DBNull.Value)
						{
							item.Zone = Convert.ToString(dr["Zone"]);
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

		public ExpProvinceFee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpProvinceFee] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpProvinceFee>(ds);
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
		/// Thêm mới ExpProvinceFee vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpProvinceFee _ExpProvinceFee)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpProvinceFee](FeeID, ProvineName, InitWeight, NextWeight, W05, W10, W30, W50, W500, Zone) VALUES(@FeeID, @ProvineName, @InitWeight, @NextWeight, @W05, @W10, @W30, @W50, @W500, @Zone)", 
					"@FeeID",  _ExpProvinceFee.FeeID, 
					"@ProvineName",  _ExpProvinceFee.ProvineName, 
					"@InitWeight",  _ExpProvinceFee.InitWeight, 
					"@NextWeight",  _ExpProvinceFee.NextWeight, 
					"@W05",  _ExpProvinceFee.W05, 
					"@W10",  _ExpProvinceFee.W10, 
					"@W30",  _ExpProvinceFee.W30, 
					"@W50",  _ExpProvinceFee.W50, 
					"@W500",  _ExpProvinceFee.W500, 
					"@Zone",  _ExpProvinceFee.Zone);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpProvinceFee vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpProvinceFee> _ExpProvinceFees)
		{
			foreach (ExpProvinceFee item in _ExpProvinceFees)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpProvinceFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpProvinceFee _ExpProvinceFee, String FeeID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProvinceFee] SET FeeID=@FeeID, ProvineName=@ProvineName, InitWeight=@InitWeight, NextWeight=@NextWeight, W05=@W05, W10=@W10, W30=@W30, W50=@W50, W500=@W500, Zone=@Zone WHERE FeeID=@FeeID", 
					"@FeeID",  _ExpProvinceFee.FeeID, 
					"@ProvineName",  _ExpProvinceFee.ProvineName, 
					"@InitWeight",  _ExpProvinceFee.InitWeight, 
					"@NextWeight",  _ExpProvinceFee.NextWeight, 
					"@W05",  _ExpProvinceFee.W05, 
					"@W10",  _ExpProvinceFee.W10, 
					"@W30",  _ExpProvinceFee.W30, 
					"@W50",  _ExpProvinceFee.W50, 
					"@W500",  _ExpProvinceFee.W500, 
					"@Zone",  _ExpProvinceFee.Zone, 
					"@FeeID", FeeID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpProvinceFee vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpProvinceFee _ExpProvinceFee)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProvinceFee] SET ProvineName=@ProvineName, InitWeight=@InitWeight, NextWeight=@NextWeight, W05=@W05, W10=@W10, W30=@W30, W50=@W50, W500=@W500, Zone=@Zone WHERE FeeID=@FeeID", 
					"@ProvineName",  _ExpProvinceFee.ProvineName, 
					"@InitWeight",  _ExpProvinceFee.InitWeight, 
					"@NextWeight",  _ExpProvinceFee.NextWeight, 
					"@W05",  _ExpProvinceFee.W05, 
					"@W10",  _ExpProvinceFee.W10, 
					"@W30",  _ExpProvinceFee.W30, 
					"@W50",  _ExpProvinceFee.W50, 
					"@W500",  _ExpProvinceFee.W500, 
					"@Zone",  _ExpProvinceFee.Zone, 
					"@FeeID", _ExpProvinceFee.FeeID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpProvinceFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpProvinceFee> _ExpProvinceFees)
		{
			foreach (ExpProvinceFee item in _ExpProvinceFees)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpProvinceFee vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpProvinceFee _ExpProvinceFee, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProvinceFee] SET FeeID=@FeeID, ProvineName=@ProvineName, InitWeight=@InitWeight, NextWeight=@NextWeight, W05=@W05, W10=@W10, W30=@W30, W50=@W50, W500=@W500, Zone=@Zone "+ condition, 
					"@FeeID",  _ExpProvinceFee.FeeID, 
					"@ProvineName",  _ExpProvinceFee.ProvineName, 
					"@InitWeight",  _ExpProvinceFee.InitWeight, 
					"@NextWeight",  _ExpProvinceFee.NextWeight, 
					"@W05",  _ExpProvinceFee.W05, 
					"@W10",  _ExpProvinceFee.W10, 
					"@W30",  _ExpProvinceFee.W30, 
					"@W50",  _ExpProvinceFee.W50, 
					"@W500",  _ExpProvinceFee.W500, 
					"@Zone",  _ExpProvinceFee.Zone);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpProvinceFee trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FeeID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProvinceFee] WHERE FeeID=@FeeID",
					"@FeeID", FeeID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProvinceFee trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpProvinceFee _ExpProvinceFee)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProvinceFee] WHERE FeeID=@FeeID",
					"@FeeID", _ExpProvinceFee.FeeID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProvinceFee trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProvinceFee] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProvinceFee trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpProvinceFee> _ExpProvinceFees)
		{
			foreach (ExpProvinceFee item in _ExpProvinceFees)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
