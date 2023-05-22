using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXphoadondoisoatkl:IEXphoadondoisoatkl
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXphoadondoisoatkl(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpHoaDonDoiSoatKL từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpHoaDonDoiSoatKL]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpHoaDonDoiSoatKL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpHoaDonDoiSoatKL] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpHoaDonDoiSoatKL từ Database
		/// </summary>
		public List<ExpHoaDonDoiSoatKL> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpHoaDonDoiSoatKL]");
				List<ExpHoaDonDoiSoatKL> items = new List<ExpHoaDonDoiSoatKL>();
				ExpHoaDonDoiSoatKL item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpHoaDonDoiSoatKL();
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
		/// Lấy danh sách ExpHoaDonDoiSoatKL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpHoaDonDoiSoatKL> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpHoaDonDoiSoatKL] A "+ condition,  parameters);
				List<ExpHoaDonDoiSoatKL> items = new List<ExpHoaDonDoiSoatKL>();
				ExpHoaDonDoiSoatKL item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpHoaDonDoiSoatKL();
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

		public List<ExpHoaDonDoiSoatKL> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpHoaDonDoiSoatKL] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpHoaDonDoiSoatKL] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpHoaDonDoiSoatKL>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpHoaDonDoiSoatKL từ Database
		/// </summary>
		public ExpHoaDonDoiSoatKL GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpHoaDonDoiSoatKL] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpHoaDonDoiSoatKL item=new ExpHoaDonDoiSoatKL();
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
		/// Lấy một ExpHoaDonDoiSoatKL đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpHoaDonDoiSoatKL GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpHoaDonDoiSoatKL] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpHoaDonDoiSoatKL item=new ExpHoaDonDoiSoatKL();
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

		public ExpHoaDonDoiSoatKL GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpHoaDonDoiSoatKL] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpHoaDonDoiSoatKL>(ds);
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
		/// Thêm mới ExpHoaDonDoiSoatKL vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpHoaDonDoiSoatKL _ExpHoaDonDoiSoatKL)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpHoaDonDoiSoatKL](Id, HoaDon, CreateHd, SoTienDoiSoat, FK_Account, AccountName, FK_Post, GiaoThanhCong) VALUES(@Id, @HoaDon, @CreateHd, @SoTienDoiSoat, @FK_Account, @AccountName, @FK_Post, @GiaoThanhCong)", 
					"@Id",  _ExpHoaDonDoiSoatKL.Id, 
					"@HoaDon",  _ExpHoaDonDoiSoatKL.HoaDon, 
					"@CreateHd", this._dataContext.ConvertDateString( _ExpHoaDonDoiSoatKL.CreateHd), 
					"@SoTienDoiSoat",  _ExpHoaDonDoiSoatKL.SoTienDoiSoat, 
					"@FK_Account",  _ExpHoaDonDoiSoatKL.FK_Account, 
					"@AccountName",  _ExpHoaDonDoiSoatKL.AccountName, 
					"@FK_Post",  _ExpHoaDonDoiSoatKL.FK_Post, 
					"@GiaoThanhCong",  _ExpHoaDonDoiSoatKL.GiaoThanhCong);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpHoaDonDoiSoatKL vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpHoaDonDoiSoatKL> _ExpHoaDonDoiSoatKLs)
		{
			foreach (ExpHoaDonDoiSoatKL item in _ExpHoaDonDoiSoatKLs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoatKL vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpHoaDonDoiSoatKL _ExpHoaDonDoiSoatKL, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpHoaDonDoiSoatKL] SET Id=@Id, HoaDon=@HoaDon, CreateHd=@CreateHd, SoTienDoiSoat=@SoTienDoiSoat, FK_Account=@FK_Account, AccountName=@AccountName, FK_Post=@FK_Post, GiaoThanhCong=@GiaoThanhCong WHERE Id=@Id", 
					"@Id",  _ExpHoaDonDoiSoatKL.Id, 
					"@HoaDon",  _ExpHoaDonDoiSoatKL.HoaDon, 
					"@CreateHd", this._dataContext.ConvertDateString( _ExpHoaDonDoiSoatKL.CreateHd), 
					"@SoTienDoiSoat",  _ExpHoaDonDoiSoatKL.SoTienDoiSoat, 
					"@FK_Account",  _ExpHoaDonDoiSoatKL.FK_Account, 
					"@AccountName",  _ExpHoaDonDoiSoatKL.AccountName, 
					"@FK_Post",  _ExpHoaDonDoiSoatKL.FK_Post, 
					"@GiaoThanhCong",  _ExpHoaDonDoiSoatKL.GiaoThanhCong, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoatKL vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpHoaDonDoiSoatKL _ExpHoaDonDoiSoatKL)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpHoaDonDoiSoatKL] SET HoaDon=@HoaDon, CreateHd=@CreateHd, SoTienDoiSoat=@SoTienDoiSoat, FK_Account=@FK_Account, AccountName=@AccountName, FK_Post=@FK_Post, GiaoThanhCong=@GiaoThanhCong WHERE Id=@Id", 
					"@HoaDon",  _ExpHoaDonDoiSoatKL.HoaDon, 
					"@CreateHd", this._dataContext.ConvertDateString( _ExpHoaDonDoiSoatKL.CreateHd), 
					"@SoTienDoiSoat",  _ExpHoaDonDoiSoatKL.SoTienDoiSoat, 
					"@FK_Account",  _ExpHoaDonDoiSoatKL.FK_Account, 
					"@AccountName",  _ExpHoaDonDoiSoatKL.AccountName, 
					"@FK_Post",  _ExpHoaDonDoiSoatKL.FK_Post, 
					"@GiaoThanhCong",  _ExpHoaDonDoiSoatKL.GiaoThanhCong, 
					"@Id", _ExpHoaDonDoiSoatKL.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpHoaDonDoiSoatKL vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpHoaDonDoiSoatKL> _ExpHoaDonDoiSoatKLs)
		{
			foreach (ExpHoaDonDoiSoatKL item in _ExpHoaDonDoiSoatKLs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoatKL vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpHoaDonDoiSoatKL _ExpHoaDonDoiSoatKL, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpHoaDonDoiSoatKL] SET Id=@Id, HoaDon=@HoaDon, CreateHd=@CreateHd, SoTienDoiSoat=@SoTienDoiSoat, FK_Account=@FK_Account, AccountName=@AccountName, FK_Post=@FK_Post, GiaoThanhCong=@GiaoThanhCong "+ condition, 
					"@Id",  _ExpHoaDonDoiSoatKL.Id, 
					"@HoaDon",  _ExpHoaDonDoiSoatKL.HoaDon, 
					"@CreateHd", this._dataContext.ConvertDateString( _ExpHoaDonDoiSoatKL.CreateHd), 
					"@SoTienDoiSoat",  _ExpHoaDonDoiSoatKL.SoTienDoiSoat, 
					"@FK_Account",  _ExpHoaDonDoiSoatKL.FK_Account, 
					"@AccountName",  _ExpHoaDonDoiSoatKL.AccountName, 
					"@FK_Post",  _ExpHoaDonDoiSoatKL.FK_Post, 
					"@GiaoThanhCong",  _ExpHoaDonDoiSoatKL.GiaoThanhCong);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpHoaDonDoiSoatKL trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpHoaDonDoiSoatKL] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpHoaDonDoiSoatKL trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpHoaDonDoiSoatKL _ExpHoaDonDoiSoatKL)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpHoaDonDoiSoatKL] WHERE Id=@Id",
					"@Id", _ExpHoaDonDoiSoatKL.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpHoaDonDoiSoatKL trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpHoaDonDoiSoatKL] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpHoaDonDoiSoatKL trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpHoaDonDoiSoatKL> _ExpHoaDonDoiSoatKLs)
		{
			foreach (ExpHoaDonDoiSoatKL item in _ExpHoaDonDoiSoatKLs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
