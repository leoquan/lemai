using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpsalevattu:IEXpsalevattu
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpsalevattu(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpSaleVatTu từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleVatTu]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpSaleVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleVatTu] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpSaleVatTu từ Database
		/// </summary>
		public List<ExpSaleVatTu> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleVatTu]");
				List<ExpSaleVatTu> items = new List<ExpSaleVatTu>();
				ExpSaleVatTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleVatTu();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenVatTu"] != null && dr["TenVatTu"] != DBNull.Value)
					{
						item.TenVatTu = Convert.ToString(dr["TenVatTu"]);
					}
					if (dr["DVT"] != null && dr["DVT"] != DBNull.Value)
					{
						item.DVT = Convert.ToString(dr["DVT"]);
					}
					if (dr["QuyCach"] != null && dr["QuyCach"] != DBNull.Value)
					{
						item.QuyCach = Convert.ToString(dr["QuyCach"]);
					}
					if (dr["QuyCachDVT"] != null && dr["QuyCachDVT"] != DBNull.Value)
					{
						item.QuyCachDVT = Convert.ToDecimal(dr["QuyCachDVT"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToDecimal(dr["DonGia"]);
					}
					if (dr["SoLuongTonKho"] != null && dr["SoLuongTonKho"] != DBNull.Value)
					{
						item.SoLuongTonKho = Convert.ToDecimal(dr["SoLuongTonKho"]);
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
		/// Lấy danh sách ExpSaleVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpSaleVatTu> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleVatTu] A "+ condition,  parameters);
				List<ExpSaleVatTu> items = new List<ExpSaleVatTu>();
				ExpSaleVatTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleVatTu();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenVatTu"] != null && dr["TenVatTu"] != DBNull.Value)
					{
						item.TenVatTu = Convert.ToString(dr["TenVatTu"]);
					}
					if (dr["DVT"] != null && dr["DVT"] != DBNull.Value)
					{
						item.DVT = Convert.ToString(dr["DVT"]);
					}
					if (dr["QuyCach"] != null && dr["QuyCach"] != DBNull.Value)
					{
						item.QuyCach = Convert.ToString(dr["QuyCach"]);
					}
					if (dr["QuyCachDVT"] != null && dr["QuyCachDVT"] != DBNull.Value)
					{
						item.QuyCachDVT = Convert.ToDecimal(dr["QuyCachDVT"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToDecimal(dr["DonGia"]);
					}
					if (dr["SoLuongTonKho"] != null && dr["SoLuongTonKho"] != DBNull.Value)
					{
						item.SoLuongTonKho = Convert.ToDecimal(dr["SoLuongTonKho"]);
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

		public List<ExpSaleVatTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleVatTu] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpSaleVatTu] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpSaleVatTu>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpSaleVatTu từ Database
		/// </summary>
		public ExpSaleVatTu GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleVatTu] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpSaleVatTu item=new ExpSaleVatTu();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenVatTu"] != null && dr["TenVatTu"] != DBNull.Value)
						{
							item.TenVatTu = Convert.ToString(dr["TenVatTu"]);
						}
						if (dr["DVT"] != null && dr["DVT"] != DBNull.Value)
						{
							item.DVT = Convert.ToString(dr["DVT"]);
						}
						if (dr["QuyCach"] != null && dr["QuyCach"] != DBNull.Value)
						{
							item.QuyCach = Convert.ToString(dr["QuyCach"]);
						}
						if (dr["QuyCachDVT"] != null && dr["QuyCachDVT"] != DBNull.Value)
						{
							item.QuyCachDVT = Convert.ToDecimal(dr["QuyCachDVT"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToDecimal(dr["DonGia"]);
						}
						if (dr["SoLuongTonKho"] != null && dr["SoLuongTonKho"] != DBNull.Value)
						{
							item.SoLuongTonKho = Convert.ToDecimal(dr["SoLuongTonKho"]);
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
		/// Lấy một ExpSaleVatTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpSaleVatTu GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleVatTu] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpSaleVatTu item=new ExpSaleVatTu();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenVatTu"] != null && dr["TenVatTu"] != DBNull.Value)
						{
							item.TenVatTu = Convert.ToString(dr["TenVatTu"]);
						}
						if (dr["DVT"] != null && dr["DVT"] != DBNull.Value)
						{
							item.DVT = Convert.ToString(dr["DVT"]);
						}
						if (dr["QuyCach"] != null && dr["QuyCach"] != DBNull.Value)
						{
							item.QuyCach = Convert.ToString(dr["QuyCach"]);
						}
						if (dr["QuyCachDVT"] != null && dr["QuyCachDVT"] != DBNull.Value)
						{
							item.QuyCachDVT = Convert.ToDecimal(dr["QuyCachDVT"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToDecimal(dr["DonGia"]);
						}
						if (dr["SoLuongTonKho"] != null && dr["SoLuongTonKho"] != DBNull.Value)
						{
							item.SoLuongTonKho = Convert.ToDecimal(dr["SoLuongTonKho"]);
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

		public ExpSaleVatTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleVatTu] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpSaleVatTu>(ds);
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
		/// Thêm mới ExpSaleVatTu vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpSaleVatTu _ExpSaleVatTu)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpSaleVatTu](Id, TenVatTu, DVT, QuyCach, QuyCachDVT, DonGia, SoLuongTonKho) VALUES(@Id, @TenVatTu, @DVT, @QuyCach, @QuyCachDVT, @DonGia, @SoLuongTonKho)", 
					"@Id",  _ExpSaleVatTu.Id, 
					"@TenVatTu",  _ExpSaleVatTu.TenVatTu, 
					"@DVT",  _ExpSaleVatTu.DVT, 
					"@QuyCach",  _ExpSaleVatTu.QuyCach, 
					"@QuyCachDVT",  _ExpSaleVatTu.QuyCachDVT, 
					"@DonGia",  _ExpSaleVatTu.DonGia, 
					"@SoLuongTonKho",  _ExpSaleVatTu.SoLuongTonKho);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpSaleVatTu vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpSaleVatTu> _ExpSaleVatTus)
		{
			foreach (ExpSaleVatTu item in _ExpSaleVatTus)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleVatTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpSaleVatTu _ExpSaleVatTu, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleVatTu] SET Id=@Id, TenVatTu=@TenVatTu, DVT=@DVT, QuyCach=@QuyCach, QuyCachDVT=@QuyCachDVT, DonGia=@DonGia, SoLuongTonKho=@SoLuongTonKho WHERE Id=@Id", 
					"@Id",  _ExpSaleVatTu.Id, 
					"@TenVatTu",  _ExpSaleVatTu.TenVatTu, 
					"@DVT",  _ExpSaleVatTu.DVT, 
					"@QuyCach",  _ExpSaleVatTu.QuyCach, 
					"@QuyCachDVT",  _ExpSaleVatTu.QuyCachDVT, 
					"@DonGia",  _ExpSaleVatTu.DonGia, 
					"@SoLuongTonKho",  _ExpSaleVatTu.SoLuongTonKho, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleVatTu vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpSaleVatTu _ExpSaleVatTu)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleVatTu] SET TenVatTu=@TenVatTu, DVT=@DVT, QuyCach=@QuyCach, QuyCachDVT=@QuyCachDVT, DonGia=@DonGia, SoLuongTonKho=@SoLuongTonKho WHERE Id=@Id", 
					"@TenVatTu",  _ExpSaleVatTu.TenVatTu, 
					"@DVT",  _ExpSaleVatTu.DVT, 
					"@QuyCach",  _ExpSaleVatTu.QuyCach, 
					"@QuyCachDVT",  _ExpSaleVatTu.QuyCachDVT, 
					"@DonGia",  _ExpSaleVatTu.DonGia, 
					"@SoLuongTonKho",  _ExpSaleVatTu.SoLuongTonKho, 
					"@Id", _ExpSaleVatTu.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpSaleVatTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpSaleVatTu> _ExpSaleVatTus)
		{
			foreach (ExpSaleVatTu item in _ExpSaleVatTus)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleVatTu vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpSaleVatTu _ExpSaleVatTu, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleVatTu] SET Id=@Id, TenVatTu=@TenVatTu, DVT=@DVT, QuyCach=@QuyCach, QuyCachDVT=@QuyCachDVT, DonGia=@DonGia, SoLuongTonKho=@SoLuongTonKho "+ condition, 
					"@Id",  _ExpSaleVatTu.Id, 
					"@TenVatTu",  _ExpSaleVatTu.TenVatTu, 
					"@DVT",  _ExpSaleVatTu.DVT, 
					"@QuyCach",  _ExpSaleVatTu.QuyCach, 
					"@QuyCachDVT",  _ExpSaleVatTu.QuyCachDVT, 
					"@DonGia",  _ExpSaleVatTu.DonGia, 
					"@SoLuongTonKho",  _ExpSaleVatTu.SoLuongTonKho);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpSaleVatTu trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleVatTu] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleVatTu trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpSaleVatTu _ExpSaleVatTu)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleVatTu] WHERE Id=@Id",
					"@Id", _ExpSaleVatTu.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleVatTu trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleVatTu] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleVatTu trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpSaleVatTu> _ExpSaleVatTus)
		{
			foreach (ExpSaleVatTu item in _ExpSaleVatTus)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
