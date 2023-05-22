using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSccy:IGSccy
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSccy(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsCCY từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCCY]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsCCY từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCCY] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsCCY từ Database
		/// </summary>
		public List<GsCCY> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCCY]");
				List<GsCCY> items = new List<GsCCY>();
				GsCCY item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsCCY();
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["CCYName"] != null && dr["CCYName"] != DBNull.Value)
					{
						item.CCYName = Convert.ToString(dr["CCYName"]);
					}
					if (dr["DefaultCCY"] != null && dr["DefaultCCY"] != DBNull.Value)
					{
						item.DefaultCCY = Convert.ToBoolean(dr["DefaultCCY"]);
					}
					if (dr["TradeCCY"] != null && dr["TradeCCY"] != DBNull.Value)
					{
						item.TradeCCY = Convert.ToBoolean(dr["TradeCCY"]);
					}
					if (dr["ExchangeRate"] != null && dr["ExchangeRate"] != DBNull.Value)
					{
						item.ExchangeRate = Convert.ToDecimal(dr["ExchangeRate"]);
					}
					if (dr["ExchangeRateBuy"] != null && dr["ExchangeRateBuy"] != DBNull.Value)
					{
						item.ExchangeRateBuy = Convert.ToDecimal(dr["ExchangeRateBuy"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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
		/// Lấy danh sách GsCCY từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsCCY> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsCCY] A "+ condition,  parameters);
				List<GsCCY> items = new List<GsCCY>();
				GsCCY item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsCCY();
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["CCYName"] != null && dr["CCYName"] != DBNull.Value)
					{
						item.CCYName = Convert.ToString(dr["CCYName"]);
					}
					if (dr["DefaultCCY"] != null && dr["DefaultCCY"] != DBNull.Value)
					{
						item.DefaultCCY = Convert.ToBoolean(dr["DefaultCCY"]);
					}
					if (dr["TradeCCY"] != null && dr["TradeCCY"] != DBNull.Value)
					{
						item.TradeCCY = Convert.ToBoolean(dr["TradeCCY"]);
					}
					if (dr["ExchangeRate"] != null && dr["ExchangeRate"] != DBNull.Value)
					{
						item.ExchangeRate = Convert.ToDecimal(dr["ExchangeRate"]);
					}
					if (dr["ExchangeRateBuy"] != null && dr["ExchangeRateBuy"] != DBNull.Value)
					{
						item.ExchangeRateBuy = Convert.ToDecimal(dr["ExchangeRateBuy"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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

		public List<GsCCY> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsCCY] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsCCY] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsCCY>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsCCY từ Database
		/// </summary>
		public GsCCY GetObject(string schema, String Code)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCCY] where Code=@Code",
					"@Code", Code);
				if (ds.Rows.Count > 0)
				{
					GsCCY item=new GsCCY();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["CCYName"] != null && dr["CCYName"] != DBNull.Value)
						{
							item.CCYName = Convert.ToString(dr["CCYName"]);
						}
						if (dr["DefaultCCY"] != null && dr["DefaultCCY"] != DBNull.Value)
						{
							item.DefaultCCY = Convert.ToBoolean(dr["DefaultCCY"]);
						}
						if (dr["TradeCCY"] != null && dr["TradeCCY"] != DBNull.Value)
						{
							item.TradeCCY = Convert.ToBoolean(dr["TradeCCY"]);
						}
						if (dr["ExchangeRate"] != null && dr["ExchangeRate"] != DBNull.Value)
						{
							item.ExchangeRate = Convert.ToDecimal(dr["ExchangeRate"]);
						}
						if (dr["ExchangeRateBuy"] != null && dr["ExchangeRateBuy"] != DBNull.Value)
						{
							item.ExchangeRateBuy = Convert.ToDecimal(dr["ExchangeRateBuy"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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
		/// Lấy một GsCCY đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsCCY GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsCCY] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsCCY item=new GsCCY();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["CCYName"] != null && dr["CCYName"] != DBNull.Value)
						{
							item.CCYName = Convert.ToString(dr["CCYName"]);
						}
						if (dr["DefaultCCY"] != null && dr["DefaultCCY"] != DBNull.Value)
						{
							item.DefaultCCY = Convert.ToBoolean(dr["DefaultCCY"]);
						}
						if (dr["TradeCCY"] != null && dr["TradeCCY"] != DBNull.Value)
						{
							item.TradeCCY = Convert.ToBoolean(dr["TradeCCY"]);
						}
						if (dr["ExchangeRate"] != null && dr["ExchangeRate"] != DBNull.Value)
						{
							item.ExchangeRate = Convert.ToDecimal(dr["ExchangeRate"]);
						}
						if (dr["ExchangeRateBuy"] != null && dr["ExchangeRateBuy"] != DBNull.Value)
						{
							item.ExchangeRateBuy = Convert.ToDecimal(dr["ExchangeRateBuy"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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

		public GsCCY GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsCCY] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsCCY>(ds);
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
		/// Thêm mới GsCCY vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsCCY _GsCCY)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsCCY](Code, CCYName, DefaultCCY, TradeCCY, ExchangeRate, ExchangeRateBuy, IsDelete, SortIndex) VALUES(@Code, @CCYName, @DefaultCCY, @TradeCCY, @ExchangeRate, @ExchangeRateBuy, @IsDelete, @SortIndex)", 
					"@Code",  _GsCCY.Code, 
					"@CCYName",  _GsCCY.CCYName, 
					"@DefaultCCY",  _GsCCY.DefaultCCY, 
					"@TradeCCY",  _GsCCY.TradeCCY, 
					"@ExchangeRate",  _GsCCY.ExchangeRate, 
					"@ExchangeRateBuy",  _GsCCY.ExchangeRateBuy, 
					"@IsDelete",  _GsCCY.IsDelete, 
					"@SortIndex",  _GsCCY.SortIndex);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsCCY vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsCCY> _GsCCYs)
		{
			foreach (GsCCY item in _GsCCYs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsCCY vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsCCY _GsCCY, String Code)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCCY] SET Code=@Code, CCYName=@CCYName, DefaultCCY=@DefaultCCY, TradeCCY=@TradeCCY, ExchangeRate=@ExchangeRate, ExchangeRateBuy=@ExchangeRateBuy, IsDelete=@IsDelete, SortIndex=@SortIndex WHERE Code=@Code", 
					"@Code",  _GsCCY.Code, 
					"@CCYName",  _GsCCY.CCYName, 
					"@DefaultCCY",  _GsCCY.DefaultCCY, 
					"@TradeCCY",  _GsCCY.TradeCCY, 
					"@ExchangeRate",  _GsCCY.ExchangeRate, 
					"@ExchangeRateBuy",  _GsCCY.ExchangeRateBuy, 
					"@IsDelete",  _GsCCY.IsDelete, 
					"@SortIndex",  _GsCCY.SortIndex, 
					"@Code", Code);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsCCY vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsCCY _GsCCY)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCCY] SET CCYName=@CCYName, DefaultCCY=@DefaultCCY, TradeCCY=@TradeCCY, ExchangeRate=@ExchangeRate, ExchangeRateBuy=@ExchangeRateBuy, IsDelete=@IsDelete, SortIndex=@SortIndex WHERE Code=@Code", 
					"@CCYName",  _GsCCY.CCYName, 
					"@DefaultCCY",  _GsCCY.DefaultCCY, 
					"@TradeCCY",  _GsCCY.TradeCCY, 
					"@ExchangeRate",  _GsCCY.ExchangeRate, 
					"@ExchangeRateBuy",  _GsCCY.ExchangeRateBuy, 
					"@IsDelete",  _GsCCY.IsDelete, 
					"@SortIndex",  _GsCCY.SortIndex, 
					"@Code", _GsCCY.Code);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsCCY vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsCCY> _GsCCYs)
		{
			foreach (GsCCY item in _GsCCYs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsCCY vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsCCY _GsCCY, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCCY] SET Code=@Code, CCYName=@CCYName, DefaultCCY=@DefaultCCY, TradeCCY=@TradeCCY, ExchangeRate=@ExchangeRate, ExchangeRateBuy=@ExchangeRateBuy, IsDelete=@IsDelete, SortIndex=@SortIndex "+ condition, 
					"@Code",  _GsCCY.Code, 
					"@CCYName",  _GsCCY.CCYName, 
					"@DefaultCCY",  _GsCCY.DefaultCCY, 
					"@TradeCCY",  _GsCCY.TradeCCY, 
					"@ExchangeRate",  _GsCCY.ExchangeRate, 
					"@ExchangeRateBuy",  _GsCCY.ExchangeRateBuy, 
					"@IsDelete",  _GsCCY.IsDelete, 
					"@SortIndex",  _GsCCY.SortIndex);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsCCY trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Code)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCCY] WHERE Code=@Code",
					"@Code", Code);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCCY trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsCCY _GsCCY)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCCY] WHERE Code=@Code",
					"@Code", _GsCCY.Code);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCCY trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCCY] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCCY trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsCCY> _GsCCYs)
		{
			foreach (GsCCY item in _GsCCYs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
