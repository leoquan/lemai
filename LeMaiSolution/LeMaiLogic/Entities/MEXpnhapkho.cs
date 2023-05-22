using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpnhapkho:IEXpnhapkho
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpnhapkho(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpNhapKho từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNhapKho]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpNhapKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNhapKho] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpNhapKho từ Database
		/// </summary>
		public List<ExpNhapKho> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNhapKho]");
				List<ExpNhapKho> items = new List<ExpNhapKho>();
				ExpNhapKho item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpNhapKho();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["NgayNhapKho"] != null && dr["NgayNhapKho"] != DBNull.Value)
					{
						item.NgayNhapKho = Convert.ToDateTime(dr["NgayNhapKho"]);
					}
					if (dr["FK_NguoiNhapKho"] != null && dr["FK_NguoiNhapKho"] != DBNull.Value)
					{
						item.FK_NguoiNhapKho = Convert.ToString(dr["FK_NguoiNhapKho"]);
					}
					if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
					{
						item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToDecimal(dr["DonGia"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
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
		/// Lấy danh sách ExpNhapKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpNhapKho> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpNhapKho] A "+ condition,  parameters);
				List<ExpNhapKho> items = new List<ExpNhapKho>();
				ExpNhapKho item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpNhapKho();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["NgayNhapKho"] != null && dr["NgayNhapKho"] != DBNull.Value)
					{
						item.NgayNhapKho = Convert.ToDateTime(dr["NgayNhapKho"]);
					}
					if (dr["FK_NguoiNhapKho"] != null && dr["FK_NguoiNhapKho"] != DBNull.Value)
					{
						item.FK_NguoiNhapKho = Convert.ToString(dr["FK_NguoiNhapKho"]);
					}
					if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
					{
						item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToDecimal(dr["DonGia"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
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

		public List<ExpNhapKho> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpNhapKho] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpNhapKho] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpNhapKho>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpNhapKho từ Database
		/// </summary>
		public ExpNhapKho GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNhapKho] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpNhapKho item=new ExpNhapKho();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["NgayNhapKho"] != null && dr["NgayNhapKho"] != DBNull.Value)
						{
							item.NgayNhapKho = Convert.ToDateTime(dr["NgayNhapKho"]);
						}
						if (dr["FK_NguoiNhapKho"] != null && dr["FK_NguoiNhapKho"] != DBNull.Value)
						{
							item.FK_NguoiNhapKho = Convert.ToString(dr["FK_NguoiNhapKho"]);
						}
						if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
						{
							item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToDecimal(dr["DonGia"]);
						}
						if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
						{
							item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
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
		/// Lấy một ExpNhapKho đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpNhapKho GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpNhapKho] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpNhapKho item=new ExpNhapKho();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["NgayNhapKho"] != null && dr["NgayNhapKho"] != DBNull.Value)
						{
							item.NgayNhapKho = Convert.ToDateTime(dr["NgayNhapKho"]);
						}
						if (dr["FK_NguoiNhapKho"] != null && dr["FK_NguoiNhapKho"] != DBNull.Value)
						{
							item.FK_NguoiNhapKho = Convert.ToString(dr["FK_NguoiNhapKho"]);
						}
						if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
						{
							item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToDecimal(dr["DonGia"]);
						}
						if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
						{
							item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
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

		public ExpNhapKho GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpNhapKho] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpNhapKho>(ds);
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
		/// Thêm mới ExpNhapKho vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpNhapKho _ExpNhapKho)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpNhapKho](Id, NgayNhapKho, FK_NguoiNhapKho, FK_SanPham, SoLuong, DonGia, ThanhTien, GhiChu) VALUES(@Id, @NgayNhapKho, @FK_NguoiNhapKho, @FK_SanPham, @SoLuong, @DonGia, @ThanhTien, @GhiChu)", 
					"@Id",  _ExpNhapKho.Id, 
					"@NgayNhapKho", this._dataContext.ConvertDateString( _ExpNhapKho.NgayNhapKho), 
					"@FK_NguoiNhapKho",  _ExpNhapKho.FK_NguoiNhapKho, 
					"@FK_SanPham",  _ExpNhapKho.FK_SanPham, 
					"@SoLuong",  _ExpNhapKho.SoLuong, 
					"@DonGia",  _ExpNhapKho.DonGia, 
					"@ThanhTien",  _ExpNhapKho.ThanhTien, 
					"@GhiChu",  _ExpNhapKho.GhiChu);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpNhapKho vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpNhapKho> _ExpNhapKhos)
		{
			foreach (ExpNhapKho item in _ExpNhapKhos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpNhapKho vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpNhapKho _ExpNhapKho, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpNhapKho] SET Id=@Id, NgayNhapKho=@NgayNhapKho, FK_NguoiNhapKho=@FK_NguoiNhapKho, FK_SanPham=@FK_SanPham, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, GhiChu=@GhiChu WHERE Id=@Id", 
					"@Id",  _ExpNhapKho.Id, 
					"@NgayNhapKho", this._dataContext.ConvertDateString( _ExpNhapKho.NgayNhapKho), 
					"@FK_NguoiNhapKho",  _ExpNhapKho.FK_NguoiNhapKho, 
					"@FK_SanPham",  _ExpNhapKho.FK_SanPham, 
					"@SoLuong",  _ExpNhapKho.SoLuong, 
					"@DonGia",  _ExpNhapKho.DonGia, 
					"@ThanhTien",  _ExpNhapKho.ThanhTien, 
					"@GhiChu",  _ExpNhapKho.GhiChu, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpNhapKho vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpNhapKho _ExpNhapKho)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpNhapKho] SET NgayNhapKho=@NgayNhapKho, FK_NguoiNhapKho=@FK_NguoiNhapKho, FK_SanPham=@FK_SanPham, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, GhiChu=@GhiChu WHERE Id=@Id", 
					"@NgayNhapKho", this._dataContext.ConvertDateString( _ExpNhapKho.NgayNhapKho), 
					"@FK_NguoiNhapKho",  _ExpNhapKho.FK_NguoiNhapKho, 
					"@FK_SanPham",  _ExpNhapKho.FK_SanPham, 
					"@SoLuong",  _ExpNhapKho.SoLuong, 
					"@DonGia",  _ExpNhapKho.DonGia, 
					"@ThanhTien",  _ExpNhapKho.ThanhTien, 
					"@GhiChu",  _ExpNhapKho.GhiChu, 
					"@Id", _ExpNhapKho.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpNhapKho vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpNhapKho> _ExpNhapKhos)
		{
			foreach (ExpNhapKho item in _ExpNhapKhos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpNhapKho vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpNhapKho _ExpNhapKho, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpNhapKho] SET Id=@Id, NgayNhapKho=@NgayNhapKho, FK_NguoiNhapKho=@FK_NguoiNhapKho, FK_SanPham=@FK_SanPham, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien, GhiChu=@GhiChu "+ condition, 
					"@Id",  _ExpNhapKho.Id, 
					"@NgayNhapKho", this._dataContext.ConvertDateString( _ExpNhapKho.NgayNhapKho), 
					"@FK_NguoiNhapKho",  _ExpNhapKho.FK_NguoiNhapKho, 
					"@FK_SanPham",  _ExpNhapKho.FK_SanPham, 
					"@SoLuong",  _ExpNhapKho.SoLuong, 
					"@DonGia",  _ExpNhapKho.DonGia, 
					"@ThanhTien",  _ExpNhapKho.ThanhTien, 
					"@GhiChu",  _ExpNhapKho.GhiChu);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpNhapKho trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpNhapKho] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpNhapKho trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpNhapKho _ExpNhapKho)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpNhapKho] WHERE Id=@Id",
					"@Id", _ExpNhapKho.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpNhapKho trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpNhapKho] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpNhapKho trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpNhapKho> _ExpNhapKhos)
		{
			foreach (ExpNhapKho item in _ExpNhapKhos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
