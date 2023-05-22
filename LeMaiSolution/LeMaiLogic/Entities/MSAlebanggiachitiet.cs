using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSAlebanggiachitiet:ISAlebanggiachitiet
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSAlebanggiachitiet(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SaleBangGiaChiTiet từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBangGiaChiTiet]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SaleBangGiaChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBangGiaChiTiet] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SaleBangGiaChiTiet từ Database
		/// </summary>
		public List<SaleBangGiaChiTiet> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBangGiaChiTiet]");
				List<SaleBangGiaChiTiet> items = new List<SaleBangGiaChiTiet>();
				SaleBangGiaChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleBangGiaChiTiet();
					if (dr["FK_BangGia"] != null && dr["FK_BangGia"] != DBNull.Value)
					{
						item.FK_BangGia = Convert.ToString(dr["FK_BangGia"]);
					}
					if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
					{
						item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
					}
					if (dr["GiaBan"] != null && dr["GiaBan"] != DBNull.Value)
					{
						item.GiaBan = Convert.ToInt32(dr["GiaBan"]);
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
		/// Lấy danh sách SaleBangGiaChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SaleBangGiaChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleBangGiaChiTiet] A "+ condition,  parameters);
				List<SaleBangGiaChiTiet> items = new List<SaleBangGiaChiTiet>();
				SaleBangGiaChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleBangGiaChiTiet();
					if (dr["FK_BangGia"] != null && dr["FK_BangGia"] != DBNull.Value)
					{
						item.FK_BangGia = Convert.ToString(dr["FK_BangGia"]);
					}
					if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
					{
						item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
					}
					if (dr["GiaBan"] != null && dr["GiaBan"] != DBNull.Value)
					{
						item.GiaBan = Convert.ToInt32(dr["GiaBan"]);
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

		public List<SaleBangGiaChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleBangGiaChiTiet] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SaleBangGiaChiTiet] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SaleBangGiaChiTiet>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SaleBangGiaChiTiet từ Database
		/// </summary>
		public SaleBangGiaChiTiet GetObject(string schema, String FK_BangGia, String FK_SanPham)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBangGiaChiTiet] where FK_BangGia=@FK_BangGia and FK_SanPham=@FK_SanPham",
					"@FK_BangGia", FK_BangGia, 
					"@FK_SanPham", FK_SanPham);
				if (ds.Rows.Count > 0)
				{
					SaleBangGiaChiTiet item=new SaleBangGiaChiTiet();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_BangGia"] != null && dr["FK_BangGia"] != DBNull.Value)
						{
							item.FK_BangGia = Convert.ToString(dr["FK_BangGia"]);
						}
						if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
						{
							item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
						}
						if (dr["GiaBan"] != null && dr["GiaBan"] != DBNull.Value)
						{
							item.GiaBan = Convert.ToInt32(dr["GiaBan"]);
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
		/// Lấy một SaleBangGiaChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SaleBangGiaChiTiet GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleBangGiaChiTiet] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SaleBangGiaChiTiet item=new SaleBangGiaChiTiet();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_BangGia"] != null && dr["FK_BangGia"] != DBNull.Value)
						{
							item.FK_BangGia = Convert.ToString(dr["FK_BangGia"]);
						}
						if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
						{
							item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
						}
						if (dr["GiaBan"] != null && dr["GiaBan"] != DBNull.Value)
						{
							item.GiaBan = Convert.ToInt32(dr["GiaBan"]);
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

		public SaleBangGiaChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleBangGiaChiTiet] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SaleBangGiaChiTiet>(ds);
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
		/// Thêm mới SaleBangGiaChiTiet vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SaleBangGiaChiTiet _SaleBangGiaChiTiet)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SaleBangGiaChiTiet](FK_BangGia, FK_SanPham, GiaBan) VALUES(@FK_BangGia, @FK_SanPham, @GiaBan)", 
					"@FK_BangGia",  _SaleBangGiaChiTiet.FK_BangGia, 
					"@FK_SanPham",  _SaleBangGiaChiTiet.FK_SanPham, 
					"@GiaBan",  _SaleBangGiaChiTiet.GiaBan);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SaleBangGiaChiTiet vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SaleBangGiaChiTiet> _SaleBangGiaChiTiets)
		{
			foreach (SaleBangGiaChiTiet item in _SaleBangGiaChiTiets)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleBangGiaChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SaleBangGiaChiTiet _SaleBangGiaChiTiet, String FK_BangGia, String FK_SanPham)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleBangGiaChiTiet] SET FK_BangGia=@FK_BangGia, FK_SanPham=@FK_SanPham, GiaBan=@GiaBan WHERE FK_BangGia=@FK_BangGia and FK_SanPham=@FK_SanPham", 
					"@FK_BangGia",  _SaleBangGiaChiTiet.FK_BangGia, 
					"@FK_SanPham",  _SaleBangGiaChiTiet.FK_SanPham, 
					"@GiaBan",  _SaleBangGiaChiTiet.GiaBan, 
					"@FK_BangGia", FK_BangGia, 
					"@FK_SanPham", FK_SanPham);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SaleBangGiaChiTiet vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SaleBangGiaChiTiet _SaleBangGiaChiTiet)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleBangGiaChiTiet] SET GiaBan=@GiaBan WHERE FK_BangGia=@FK_BangGia and FK_SanPham=@FK_SanPham", 
					"@GiaBan",  _SaleBangGiaChiTiet.GiaBan, 
					"@FK_BangGia", _SaleBangGiaChiTiet.FK_BangGia, 
					"@FK_SanPham", _SaleBangGiaChiTiet.FK_SanPham);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SaleBangGiaChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SaleBangGiaChiTiet> _SaleBangGiaChiTiets)
		{
			foreach (SaleBangGiaChiTiet item in _SaleBangGiaChiTiets)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleBangGiaChiTiet vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SaleBangGiaChiTiet _SaleBangGiaChiTiet, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleBangGiaChiTiet] SET FK_BangGia=@FK_BangGia, FK_SanPham=@FK_SanPham, GiaBan=@GiaBan "+ condition, 
					"@FK_BangGia",  _SaleBangGiaChiTiet.FK_BangGia, 
					"@FK_SanPham",  _SaleBangGiaChiTiet.FK_SanPham, 
					"@GiaBan",  _SaleBangGiaChiTiet.GiaBan);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SaleBangGiaChiTiet trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_BangGia, String FK_SanPham)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleBangGiaChiTiet] WHERE FK_BangGia=@FK_BangGia and FK_SanPham=@FK_SanPham",
					"@FK_BangGia", FK_BangGia, 
					"@FK_SanPham", FK_SanPham);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleBangGiaChiTiet trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SaleBangGiaChiTiet _SaleBangGiaChiTiet)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleBangGiaChiTiet] WHERE FK_BangGia=@FK_BangGia and FK_SanPham=@FK_SanPham",
					"@FK_BangGia", _SaleBangGiaChiTiet.FK_BangGia, 
					"@FK_SanPham", _SaleBangGiaChiTiet.FK_SanPham);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleBangGiaChiTiet trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleBangGiaChiTiet] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleBangGiaChiTiet trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SaleBangGiaChiTiet> _SaleBangGiaChiTiets)
		{
			foreach (SaleBangGiaChiTiet item in _SaleBangGiaChiTiets)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
