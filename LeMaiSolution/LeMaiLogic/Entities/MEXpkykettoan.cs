using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpkykettoan:IEXpkykettoan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpkykettoan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpKyKetToan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpKyKetToan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpKyKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpKyKetToan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpKyKetToan từ Database
		/// </summary>
		public List<ExpKyKetToan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpKyKetToan]");
				List<ExpKyKetToan> items = new List<ExpKyKetToan>();
				ExpKyKetToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpKyKetToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenKy"] != null && dr["TenKy"] != DBNull.Value)
					{
						item.TenKy = Convert.ToString(dr["TenKy"]);
					}
					if (dr["SoBangKe"] != null && dr["SoBangKe"] != DBNull.Value)
					{
						item.SoBangKe = Convert.ToInt32(dr["SoBangKe"]);
					}
					if (dr["NgayTao"] != null && dr["NgayTao"] != DBNull.Value)
					{
						item.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
					}
					if (dr["QuyenSoChi"] != null && dr["QuyenSoChi"] != DBNull.Value)
					{
						item.QuyenSoChi = Convert.ToString(dr["QuyenSoChi"]);
					}
					if (dr["QuyenSoThu"] != null && dr["QuyenSoThu"] != DBNull.Value)
					{
						item.QuyenSoThu = Convert.ToString(dr["QuyenSoThu"]);
					}
					if (dr["QuyenSoTongChi"] != null && dr["QuyenSoTongChi"] != DBNull.Value)
					{
						item.QuyenSoTongChi = Convert.ToString(dr["QuyenSoTongChi"]);
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
		/// Lấy danh sách ExpKyKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpKyKetToan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpKyKetToan] A "+ condition,  parameters);
				List<ExpKyKetToan> items = new List<ExpKyKetToan>();
				ExpKyKetToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpKyKetToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenKy"] != null && dr["TenKy"] != DBNull.Value)
					{
						item.TenKy = Convert.ToString(dr["TenKy"]);
					}
					if (dr["SoBangKe"] != null && dr["SoBangKe"] != DBNull.Value)
					{
						item.SoBangKe = Convert.ToInt32(dr["SoBangKe"]);
					}
					if (dr["NgayTao"] != null && dr["NgayTao"] != DBNull.Value)
					{
						item.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
					}
					if (dr["QuyenSoChi"] != null && dr["QuyenSoChi"] != DBNull.Value)
					{
						item.QuyenSoChi = Convert.ToString(dr["QuyenSoChi"]);
					}
					if (dr["QuyenSoThu"] != null && dr["QuyenSoThu"] != DBNull.Value)
					{
						item.QuyenSoThu = Convert.ToString(dr["QuyenSoThu"]);
					}
					if (dr["QuyenSoTongChi"] != null && dr["QuyenSoTongChi"] != DBNull.Value)
					{
						item.QuyenSoTongChi = Convert.ToString(dr["QuyenSoTongChi"]);
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

		public List<ExpKyKetToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpKyKetToan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpKyKetToan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpKyKetToan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpKyKetToan từ Database
		/// </summary>
		public ExpKyKetToan GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpKyKetToan] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpKyKetToan item=new ExpKyKetToan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenKy"] != null && dr["TenKy"] != DBNull.Value)
						{
							item.TenKy = Convert.ToString(dr["TenKy"]);
						}
						if (dr["SoBangKe"] != null && dr["SoBangKe"] != DBNull.Value)
						{
							item.SoBangKe = Convert.ToInt32(dr["SoBangKe"]);
						}
						if (dr["NgayTao"] != null && dr["NgayTao"] != DBNull.Value)
						{
							item.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
						}
						if (dr["QuyenSoChi"] != null && dr["QuyenSoChi"] != DBNull.Value)
						{
							item.QuyenSoChi = Convert.ToString(dr["QuyenSoChi"]);
						}
						if (dr["QuyenSoThu"] != null && dr["QuyenSoThu"] != DBNull.Value)
						{
							item.QuyenSoThu = Convert.ToString(dr["QuyenSoThu"]);
						}
						if (dr["QuyenSoTongChi"] != null && dr["QuyenSoTongChi"] != DBNull.Value)
						{
							item.QuyenSoTongChi = Convert.ToString(dr["QuyenSoTongChi"]);
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
		/// Lấy một ExpKyKetToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpKyKetToan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpKyKetToan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpKyKetToan item=new ExpKyKetToan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenKy"] != null && dr["TenKy"] != DBNull.Value)
						{
							item.TenKy = Convert.ToString(dr["TenKy"]);
						}
						if (dr["SoBangKe"] != null && dr["SoBangKe"] != DBNull.Value)
						{
							item.SoBangKe = Convert.ToInt32(dr["SoBangKe"]);
						}
						if (dr["NgayTao"] != null && dr["NgayTao"] != DBNull.Value)
						{
							item.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
						}
						if (dr["QuyenSoChi"] != null && dr["QuyenSoChi"] != DBNull.Value)
						{
							item.QuyenSoChi = Convert.ToString(dr["QuyenSoChi"]);
						}
						if (dr["QuyenSoThu"] != null && dr["QuyenSoThu"] != DBNull.Value)
						{
							item.QuyenSoThu = Convert.ToString(dr["QuyenSoThu"]);
						}
						if (dr["QuyenSoTongChi"] != null && dr["QuyenSoTongChi"] != DBNull.Value)
						{
							item.QuyenSoTongChi = Convert.ToString(dr["QuyenSoTongChi"]);
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

		public ExpKyKetToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpKyKetToan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpKyKetToan>(ds);
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
		/// Thêm mới ExpKyKetToan vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpKyKetToan _ExpKyKetToan)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpKyKetToan](Id, TenKy, SoBangKe, NgayTao, QuyenSoChi, QuyenSoThu, QuyenSoTongChi) VALUES(@Id, @TenKy, @SoBangKe, @NgayTao, @QuyenSoChi, @QuyenSoThu, @QuyenSoTongChi)", 
					"@Id",  _ExpKyKetToan.Id, 
					"@TenKy",  _ExpKyKetToan.TenKy, 
					"@SoBangKe",  _ExpKyKetToan.SoBangKe, 
					"@NgayTao", this._dataContext.ConvertDateString( _ExpKyKetToan.NgayTao), 
					"@QuyenSoChi",  _ExpKyKetToan.QuyenSoChi, 
					"@QuyenSoThu",  _ExpKyKetToan.QuyenSoThu, 
					"@QuyenSoTongChi",  _ExpKyKetToan.QuyenSoTongChi);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpKyKetToan vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpKyKetToan> _ExpKyKetToans)
		{
			foreach (ExpKyKetToan item in _ExpKyKetToans)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpKyKetToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpKyKetToan _ExpKyKetToan, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpKyKetToan] SET Id=@Id, TenKy=@TenKy, SoBangKe=@SoBangKe, NgayTao=@NgayTao, QuyenSoChi=@QuyenSoChi, QuyenSoThu=@QuyenSoThu, QuyenSoTongChi=@QuyenSoTongChi WHERE Id=@Id", 
					"@Id",  _ExpKyKetToan.Id, 
					"@TenKy",  _ExpKyKetToan.TenKy, 
					"@SoBangKe",  _ExpKyKetToan.SoBangKe, 
					"@NgayTao", this._dataContext.ConvertDateString( _ExpKyKetToan.NgayTao), 
					"@QuyenSoChi",  _ExpKyKetToan.QuyenSoChi, 
					"@QuyenSoThu",  _ExpKyKetToan.QuyenSoThu, 
					"@QuyenSoTongChi",  _ExpKyKetToan.QuyenSoTongChi, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpKyKetToan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpKyKetToan _ExpKyKetToan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpKyKetToan] SET TenKy=@TenKy, SoBangKe=@SoBangKe, NgayTao=@NgayTao, QuyenSoChi=@QuyenSoChi, QuyenSoThu=@QuyenSoThu, QuyenSoTongChi=@QuyenSoTongChi WHERE Id=@Id", 
					"@TenKy",  _ExpKyKetToan.TenKy, 
					"@SoBangKe",  _ExpKyKetToan.SoBangKe, 
					"@NgayTao", this._dataContext.ConvertDateString( _ExpKyKetToan.NgayTao), 
					"@QuyenSoChi",  _ExpKyKetToan.QuyenSoChi, 
					"@QuyenSoThu",  _ExpKyKetToan.QuyenSoThu, 
					"@QuyenSoTongChi",  _ExpKyKetToan.QuyenSoTongChi, 
					"@Id", _ExpKyKetToan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpKyKetToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpKyKetToan> _ExpKyKetToans)
		{
			foreach (ExpKyKetToan item in _ExpKyKetToans)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpKyKetToan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpKyKetToan _ExpKyKetToan, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpKyKetToan] SET Id=@Id, TenKy=@TenKy, SoBangKe=@SoBangKe, NgayTao=@NgayTao, QuyenSoChi=@QuyenSoChi, QuyenSoThu=@QuyenSoThu, QuyenSoTongChi=@QuyenSoTongChi "+ condition, 
					"@Id",  _ExpKyKetToan.Id, 
					"@TenKy",  _ExpKyKetToan.TenKy, 
					"@SoBangKe",  _ExpKyKetToan.SoBangKe, 
					"@NgayTao", this._dataContext.ConvertDateString( _ExpKyKetToan.NgayTao), 
					"@QuyenSoChi",  _ExpKyKetToan.QuyenSoChi, 
					"@QuyenSoThu",  _ExpKyKetToan.QuyenSoThu, 
					"@QuyenSoTongChi",  _ExpKyKetToan.QuyenSoTongChi);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpKyKetToan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpKyKetToan] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpKyKetToan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpKyKetToan _ExpKyKetToan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpKyKetToan] WHERE Id=@Id",
					"@Id", _ExpKyKetToan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpKyKetToan trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpKyKetToan] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpKyKetToan trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpKyKetToan> _ExpKyKetToans)
		{
			foreach (ExpKyKetToan item in _ExpKyKetToans)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
