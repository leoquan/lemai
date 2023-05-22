using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpdestination:IEXpdestination
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpdestination(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpDestination từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDestination]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpDestination từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDestination] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpDestination từ Database
		/// </summary>
		public List<ExpDestination> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDestination]");
				List<ExpDestination> items = new List<ExpDestination>();
				ExpDestination item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDestination();
					if (dr["ExpId"] != null && dr["ExpId"] != DBNull.Value)
					{
						item.ExpId = Convert.ToString(dr["ExpId"]);
					}
					if (dr["DestinationName"] != null && dr["DestinationName"] != DBNull.Value)
					{
						item.DestinationName = Convert.ToString(dr["DestinationName"]);
					}
					if (dr["Parrent"] != null && dr["Parrent"] != DBNull.Value)
					{
						item.Parrent = Convert.ToString(dr["Parrent"]);
					}
					if (dr["CityCode"] != null && dr["CityCode"] != DBNull.Value)
					{
						item.CityCode = Convert.ToString(dr["CityCode"]);
					}
					if (dr["SubCity"] != null && dr["SubCity"] != DBNull.Value)
					{
						item.SubCity = Convert.ToString(dr["SubCity"]);
					}
					if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
					{
						item.KeyWord = Convert.ToString(dr["KeyWord"]);
					}
					if (dr["ScanCome"] != null && dr["ScanCome"] != DBNull.Value)
					{
						item.ScanCome = Convert.ToBoolean(dr["ScanCome"]);
					}
					if (dr["AccountCode"] != null && dr["AccountCode"] != DBNull.Value)
					{
						item.AccountCode = Convert.ToString(dr["AccountCode"]);
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
		/// Lấy danh sách ExpDestination từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpDestination> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDestination] A "+ condition,  parameters);
				List<ExpDestination> items = new List<ExpDestination>();
				ExpDestination item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDestination();
					if (dr["ExpId"] != null && dr["ExpId"] != DBNull.Value)
					{
						item.ExpId = Convert.ToString(dr["ExpId"]);
					}
					if (dr["DestinationName"] != null && dr["DestinationName"] != DBNull.Value)
					{
						item.DestinationName = Convert.ToString(dr["DestinationName"]);
					}
					if (dr["Parrent"] != null && dr["Parrent"] != DBNull.Value)
					{
						item.Parrent = Convert.ToString(dr["Parrent"]);
					}
					if (dr["CityCode"] != null && dr["CityCode"] != DBNull.Value)
					{
						item.CityCode = Convert.ToString(dr["CityCode"]);
					}
					if (dr["SubCity"] != null && dr["SubCity"] != DBNull.Value)
					{
						item.SubCity = Convert.ToString(dr["SubCity"]);
					}
					if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
					{
						item.KeyWord = Convert.ToString(dr["KeyWord"]);
					}
					if (dr["ScanCome"] != null && dr["ScanCome"] != DBNull.Value)
					{
						item.ScanCome = Convert.ToBoolean(dr["ScanCome"]);
					}
					if (dr["AccountCode"] != null && dr["AccountCode"] != DBNull.Value)
					{
						item.AccountCode = Convert.ToString(dr["AccountCode"]);
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

		public List<ExpDestination> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDestination] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpDestination] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpDestination>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpDestination từ Database
		/// </summary>
		public ExpDestination GetObject(string schema, String ExpId)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDestination] where ExpId=@ExpId",
					"@ExpId", ExpId);
				if (ds.Rows.Count > 0)
				{
					ExpDestination item=new ExpDestination();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ExpId"] != null && dr["ExpId"] != DBNull.Value)
						{
							item.ExpId = Convert.ToString(dr["ExpId"]);
						}
						if (dr["DestinationName"] != null && dr["DestinationName"] != DBNull.Value)
						{
							item.DestinationName = Convert.ToString(dr["DestinationName"]);
						}
						if (dr["Parrent"] != null && dr["Parrent"] != DBNull.Value)
						{
							item.Parrent = Convert.ToString(dr["Parrent"]);
						}
						if (dr["CityCode"] != null && dr["CityCode"] != DBNull.Value)
						{
							item.CityCode = Convert.ToString(dr["CityCode"]);
						}
						if (dr["SubCity"] != null && dr["SubCity"] != DBNull.Value)
						{
							item.SubCity = Convert.ToString(dr["SubCity"]);
						}
						if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
						{
							item.KeyWord = Convert.ToString(dr["KeyWord"]);
						}
						if (dr["ScanCome"] != null && dr["ScanCome"] != DBNull.Value)
						{
							item.ScanCome = Convert.ToBoolean(dr["ScanCome"]);
						}
						if (dr["AccountCode"] != null && dr["AccountCode"] != DBNull.Value)
						{
							item.AccountCode = Convert.ToString(dr["AccountCode"]);
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
		/// Lấy một ExpDestination đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpDestination GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDestination] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpDestination item=new ExpDestination();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ExpId"] != null && dr["ExpId"] != DBNull.Value)
						{
							item.ExpId = Convert.ToString(dr["ExpId"]);
						}
						if (dr["DestinationName"] != null && dr["DestinationName"] != DBNull.Value)
						{
							item.DestinationName = Convert.ToString(dr["DestinationName"]);
						}
						if (dr["Parrent"] != null && dr["Parrent"] != DBNull.Value)
						{
							item.Parrent = Convert.ToString(dr["Parrent"]);
						}
						if (dr["CityCode"] != null && dr["CityCode"] != DBNull.Value)
						{
							item.CityCode = Convert.ToString(dr["CityCode"]);
						}
						if (dr["SubCity"] != null && dr["SubCity"] != DBNull.Value)
						{
							item.SubCity = Convert.ToString(dr["SubCity"]);
						}
						if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
						{
							item.KeyWord = Convert.ToString(dr["KeyWord"]);
						}
						if (dr["ScanCome"] != null && dr["ScanCome"] != DBNull.Value)
						{
							item.ScanCome = Convert.ToBoolean(dr["ScanCome"]);
						}
						if (dr["AccountCode"] != null && dr["AccountCode"] != DBNull.Value)
						{
							item.AccountCode = Convert.ToString(dr["AccountCode"]);
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

		public ExpDestination GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDestination] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpDestination>(ds);
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
		/// Thêm mới ExpDestination vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpDestination _ExpDestination)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpDestination](ExpId, DestinationName, Parrent, CityCode, SubCity, KeyWord, ScanCome, AccountCode) VALUES(@ExpId, @DestinationName, @Parrent, @CityCode, @SubCity, @KeyWord, @ScanCome, @AccountCode)", 
					"@ExpId",  _ExpDestination.ExpId, 
					"@DestinationName",  _ExpDestination.DestinationName, 
					"@Parrent",  _ExpDestination.Parrent, 
					"@CityCode",  _ExpDestination.CityCode, 
					"@SubCity",  _ExpDestination.SubCity, 
					"@KeyWord",  _ExpDestination.KeyWord, 
					"@ScanCome",  _ExpDestination.ScanCome, 
					"@AccountCode",  _ExpDestination.AccountCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpDestination vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpDestination> _ExpDestinations)
		{
			foreach (ExpDestination item in _ExpDestinations)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDestination vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpDestination _ExpDestination, String ExpId)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDestination] SET ExpId=@ExpId, DestinationName=@DestinationName, Parrent=@Parrent, CityCode=@CityCode, SubCity=@SubCity, KeyWord=@KeyWord, ScanCome=@ScanCome, AccountCode=@AccountCode WHERE ExpId=@ExpId", 
					"@ExpId",  _ExpDestination.ExpId, 
					"@DestinationName",  _ExpDestination.DestinationName, 
					"@Parrent",  _ExpDestination.Parrent, 
					"@CityCode",  _ExpDestination.CityCode, 
					"@SubCity",  _ExpDestination.SubCity, 
					"@KeyWord",  _ExpDestination.KeyWord, 
					"@ScanCome",  _ExpDestination.ScanCome, 
					"@AccountCode",  _ExpDestination.AccountCode, 
					"@ExpId", ExpId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpDestination vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpDestination _ExpDestination)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDestination] SET DestinationName=@DestinationName, Parrent=@Parrent, CityCode=@CityCode, SubCity=@SubCity, KeyWord=@KeyWord, ScanCome=@ScanCome, AccountCode=@AccountCode WHERE ExpId=@ExpId", 
					"@DestinationName",  _ExpDestination.DestinationName, 
					"@Parrent",  _ExpDestination.Parrent, 
					"@CityCode",  _ExpDestination.CityCode, 
					"@SubCity",  _ExpDestination.SubCity, 
					"@KeyWord",  _ExpDestination.KeyWord, 
					"@ScanCome",  _ExpDestination.ScanCome, 
					"@AccountCode",  _ExpDestination.AccountCode, 
					"@ExpId", _ExpDestination.ExpId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpDestination vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpDestination> _ExpDestinations)
		{
			foreach (ExpDestination item in _ExpDestinations)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDestination vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpDestination _ExpDestination, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDestination] SET ExpId=@ExpId, DestinationName=@DestinationName, Parrent=@Parrent, CityCode=@CityCode, SubCity=@SubCity, KeyWord=@KeyWord, ScanCome=@ScanCome, AccountCode=@AccountCode "+ condition, 
					"@ExpId",  _ExpDestination.ExpId, 
					"@DestinationName",  _ExpDestination.DestinationName, 
					"@Parrent",  _ExpDestination.Parrent, 
					"@CityCode",  _ExpDestination.CityCode, 
					"@SubCity",  _ExpDestination.SubCity, 
					"@KeyWord",  _ExpDestination.KeyWord, 
					"@ScanCome",  _ExpDestination.ScanCome, 
					"@AccountCode",  _ExpDestination.AccountCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpDestination trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String ExpId)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDestination] WHERE ExpId=@ExpId",
					"@ExpId", ExpId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDestination trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpDestination _ExpDestination)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDestination] WHERE ExpId=@ExpId",
					"@ExpId", _ExpDestination.ExpId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDestination trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDestination] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDestination trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpDestination> _ExpDestinations)
		{
			foreach (ExpDestination item in _ExpDestinations)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
