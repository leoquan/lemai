using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXphoadondoisoat:IEXphoadondoisoat
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXphoadondoisoat(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpHoaDonDoiSoat từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpHoaDonDoiSoat]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpHoaDonDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpHoaDonDoiSoat] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpHoaDonDoiSoat từ Database
		/// </summary>
		public List<ExpHoaDonDoiSoat> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpHoaDonDoiSoat]");
				List<ExpHoaDonDoiSoat> items = new List<ExpHoaDonDoiSoat>();
				ExpHoaDonDoiSoat item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpHoaDonDoiSoat();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["HoaDon"] != null && dr["HoaDon"] != DBNull.Value)
					{
						item.HoaDon = Convert.ToString(dr["HoaDon"]);
					}
					if (dr["CreateHd"] != null && dr["CreateHd"] != DBNull.Value)
					{
						item.CreateHd = Convert.ToDateTime(dr["CreateHd"]);
					}
					if (dr["SoTienDoiSoat"] != null && dr["SoTienDoiSoat"] != DBNull.Value)
					{
						item.SoTienDoiSoat = Convert.ToDecimal(dr["SoTienDoiSoat"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["AccountName"] != null && dr["AccountName"] != DBNull.Value)
					{
						item.AccountName = Convert.ToString(dr["AccountName"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["GiaoThanhCong"] != null && dr["GiaoThanhCong"] != DBNull.Value)
					{
						item.GiaoThanhCong = Convert.ToString(dr["GiaoThanhCong"]);
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
		/// Lấy danh sách ExpHoaDonDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpHoaDonDoiSoat> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpHoaDonDoiSoat] A "+ condition,  parameters);
				List<ExpHoaDonDoiSoat> items = new List<ExpHoaDonDoiSoat>();
				ExpHoaDonDoiSoat item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpHoaDonDoiSoat();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["HoaDon"] != null && dr["HoaDon"] != DBNull.Value)
					{
						item.HoaDon = Convert.ToString(dr["HoaDon"]);
					}
					if (dr["CreateHd"] != null && dr["CreateHd"] != DBNull.Value)
					{
						item.CreateHd = Convert.ToDateTime(dr["CreateHd"]);
					}
					if (dr["SoTienDoiSoat"] != null && dr["SoTienDoiSoat"] != DBNull.Value)
					{
						item.SoTienDoiSoat = Convert.ToDecimal(dr["SoTienDoiSoat"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["AccountName"] != null && dr["AccountName"] != DBNull.Value)
					{
						item.AccountName = Convert.ToString(dr["AccountName"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["GiaoThanhCong"] != null && dr["GiaoThanhCong"] != DBNull.Value)
					{
						item.GiaoThanhCong = Convert.ToString(dr["GiaoThanhCong"]);
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

		public List<ExpHoaDonDoiSoat> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpHoaDonDoiSoat] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpHoaDonDoiSoat] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpHoaDonDoiSoat>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpHoaDonDoiSoat từ Database
		/// </summary>
		public ExpHoaDonDoiSoat GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpHoaDonDoiSoat] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpHoaDonDoiSoat item=new ExpHoaDonDoiSoat();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["HoaDon"] != null && dr["HoaDon"] != DBNull.Value)
						{
							item.HoaDon = Convert.ToString(dr["HoaDon"]);
						}
						if (dr["CreateHd"] != null && dr["CreateHd"] != DBNull.Value)
						{
							item.CreateHd = Convert.ToDateTime(dr["CreateHd"]);
						}
						if (dr["SoTienDoiSoat"] != null && dr["SoTienDoiSoat"] != DBNull.Value)
						{
							item.SoTienDoiSoat = Convert.ToDecimal(dr["SoTienDoiSoat"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["AccountName"] != null && dr["AccountName"] != DBNull.Value)
						{
							item.AccountName = Convert.ToString(dr["AccountName"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["GiaoThanhCong"] != null && dr["GiaoThanhCong"] != DBNull.Value)
						{
							item.GiaoThanhCong = Convert.ToString(dr["GiaoThanhCong"]);
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
		/// Lấy một ExpHoaDonDoiSoat đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpHoaDonDoiSoat GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpHoaDonDoiSoat] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpHoaDonDoiSoat item=new ExpHoaDonDoiSoat();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["HoaDon"] != null && dr["HoaDon"] != DBNull.Value)
						{
							item.HoaDon = Convert.ToString(dr["HoaDon"]);
						}
						if (dr["CreateHd"] != null && dr["CreateHd"] != DBNull.Value)
						{
							item.CreateHd = Convert.ToDateTime(dr["CreateHd"]);
						}
						if (dr["SoTienDoiSoat"] != null && dr["SoTienDoiSoat"] != DBNull.Value)
						{
							item.SoTienDoiSoat = Convert.ToDecimal(dr["SoTienDoiSoat"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["AccountName"] != null && dr["AccountName"] != DBNull.Value)
						{
							item.AccountName = Convert.ToString(dr["AccountName"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["GiaoThanhCong"] != null && dr["GiaoThanhCong"] != DBNull.Value)
						{
							item.GiaoThanhCong = Convert.ToString(dr["GiaoThanhCong"]);
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

		public ExpHoaDonDoiSoat GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpHoaDonDoiSoat] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpHoaDonDoiSoat>(ds);
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
		/// Thêm mới ExpHoaDonDoiSoat vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpHoaDonDoiSoat _ExpHoaDonDoiSoat)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpHoaDonDoiSoat](Id, HoaDon, CreateHd, SoTienDoiSoat, FK_Account, AccountName, FK_Post, GiaoThanhCong) VALUES(@Id, @HoaDon, @CreateHd, @SoTienDoiSoat, @FK_Account, @AccountName, @FK_Post, @GiaoThanhCong)", 
					"@Id",  _ExpHoaDonDoiSoat.Id, 
					"@HoaDon",  _ExpHoaDonDoiSoat.HoaDon, 
					"@CreateHd", this._dataContext.ConvertDateString( _ExpHoaDonDoiSoat.CreateHd), 
					"@SoTienDoiSoat",  _ExpHoaDonDoiSoat.SoTienDoiSoat, 
					"@FK_Account",  _ExpHoaDonDoiSoat.FK_Account, 
					"@AccountName",  _ExpHoaDonDoiSoat.AccountName, 
					"@FK_Post",  _ExpHoaDonDoiSoat.FK_Post, 
					"@GiaoThanhCong",  _ExpHoaDonDoiSoat.GiaoThanhCong);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpHoaDonDoiSoat vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpHoaDonDoiSoat> _ExpHoaDonDoiSoats)
		{
			foreach (ExpHoaDonDoiSoat item in _ExpHoaDonDoiSoats)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpHoaDonDoiSoat _ExpHoaDonDoiSoat, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpHoaDonDoiSoat] SET Id=@Id, HoaDon=@HoaDon, CreateHd=@CreateHd, SoTienDoiSoat=@SoTienDoiSoat, FK_Account=@FK_Account, AccountName=@AccountName, FK_Post=@FK_Post, GiaoThanhCong=@GiaoThanhCong WHERE Id=@Id", 
					"@Id",  _ExpHoaDonDoiSoat.Id, 
					"@HoaDon",  _ExpHoaDonDoiSoat.HoaDon, 
					"@CreateHd", this._dataContext.ConvertDateString( _ExpHoaDonDoiSoat.CreateHd), 
					"@SoTienDoiSoat",  _ExpHoaDonDoiSoat.SoTienDoiSoat, 
					"@FK_Account",  _ExpHoaDonDoiSoat.FK_Account, 
					"@AccountName",  _ExpHoaDonDoiSoat.AccountName, 
					"@FK_Post",  _ExpHoaDonDoiSoat.FK_Post, 
					"@GiaoThanhCong",  _ExpHoaDonDoiSoat.GiaoThanhCong, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoat vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpHoaDonDoiSoat _ExpHoaDonDoiSoat)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpHoaDonDoiSoat] SET HoaDon=@HoaDon, CreateHd=@CreateHd, SoTienDoiSoat=@SoTienDoiSoat, FK_Account=@FK_Account, AccountName=@AccountName, FK_Post=@FK_Post, GiaoThanhCong=@GiaoThanhCong WHERE Id=@Id", 
					"@HoaDon",  _ExpHoaDonDoiSoat.HoaDon, 
					"@CreateHd", this._dataContext.ConvertDateString( _ExpHoaDonDoiSoat.CreateHd), 
					"@SoTienDoiSoat",  _ExpHoaDonDoiSoat.SoTienDoiSoat, 
					"@FK_Account",  _ExpHoaDonDoiSoat.FK_Account, 
					"@AccountName",  _ExpHoaDonDoiSoat.AccountName, 
					"@FK_Post",  _ExpHoaDonDoiSoat.FK_Post, 
					"@GiaoThanhCong",  _ExpHoaDonDoiSoat.GiaoThanhCong, 
					"@Id", _ExpHoaDonDoiSoat.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpHoaDonDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpHoaDonDoiSoat> _ExpHoaDonDoiSoats)
		{
			foreach (ExpHoaDonDoiSoat item in _ExpHoaDonDoiSoats)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoat vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpHoaDonDoiSoat _ExpHoaDonDoiSoat, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpHoaDonDoiSoat] SET Id=@Id, HoaDon=@HoaDon, CreateHd=@CreateHd, SoTienDoiSoat=@SoTienDoiSoat, FK_Account=@FK_Account, AccountName=@AccountName, FK_Post=@FK_Post, GiaoThanhCong=@GiaoThanhCong "+ condition, 
					"@Id",  _ExpHoaDonDoiSoat.Id, 
					"@HoaDon",  _ExpHoaDonDoiSoat.HoaDon, 
					"@CreateHd", this._dataContext.ConvertDateString( _ExpHoaDonDoiSoat.CreateHd), 
					"@SoTienDoiSoat",  _ExpHoaDonDoiSoat.SoTienDoiSoat, 
					"@FK_Account",  _ExpHoaDonDoiSoat.FK_Account, 
					"@AccountName",  _ExpHoaDonDoiSoat.AccountName, 
					"@FK_Post",  _ExpHoaDonDoiSoat.FK_Post, 
					"@GiaoThanhCong",  _ExpHoaDonDoiSoat.GiaoThanhCong);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpHoaDonDoiSoat trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpHoaDonDoiSoat] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpHoaDonDoiSoat trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpHoaDonDoiSoat _ExpHoaDonDoiSoat)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpHoaDonDoiSoat] WHERE Id=@Id",
					"@Id", _ExpHoaDonDoiSoat.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpHoaDonDoiSoat trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpHoaDonDoiSoat] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpHoaDonDoiSoat trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpHoaDonDoiSoat> _ExpHoaDonDoiSoats)
		{
			foreach (ExpHoaDonDoiSoat item in _ExpHoaDonDoiSoats)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
