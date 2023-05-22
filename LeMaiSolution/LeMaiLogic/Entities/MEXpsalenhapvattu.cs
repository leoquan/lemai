using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpsalenhapvattu:IEXpsalenhapvattu
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpsalenhapvattu(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpSaleNhapVatTu từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleNhapVatTu]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpSaleNhapVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleNhapVatTu] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpSaleNhapVatTu từ Database
		/// </summary>
		public List<ExpSaleNhapVatTu> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleNhapVatTu]");
				List<ExpSaleNhapVatTu> items = new List<ExpSaleNhapVatTu>();
				ExpSaleNhapVatTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleNhapVatTu();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
					{
						item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
					}
					if (dr["NgayNhap"] != null && dr["NgayNhap"] != DBNull.Value)
					{
						item.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
					}
					if (dr["NguoiNhap"] != null && dr["NguoiNhap"] != DBNull.Value)
					{
						item.NguoiNhap = Convert.ToString(dr["NguoiNhap"]);
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
		/// Lấy danh sách ExpSaleNhapVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpSaleNhapVatTu> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleNhapVatTu] A "+ condition,  parameters);
				List<ExpSaleNhapVatTu> items = new List<ExpSaleNhapVatTu>();
				ExpSaleNhapVatTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleNhapVatTu();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
					{
						item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
					}
					if (dr["NgayNhap"] != null && dr["NgayNhap"] != DBNull.Value)
					{
						item.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
					}
					if (dr["NguoiNhap"] != null && dr["NguoiNhap"] != DBNull.Value)
					{
						item.NguoiNhap = Convert.ToString(dr["NguoiNhap"]);
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<ExpSaleNhapVatTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleNhapVatTu] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpSaleNhapVatTu] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpSaleNhapVatTu>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpSaleNhapVatTu từ Database
		/// </summary>
		public ExpSaleNhapVatTu GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleNhapVatTu] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpSaleNhapVatTu item=new ExpSaleNhapVatTu();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
						{
							item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
						}
						if (dr["NgayNhap"] != null && dr["NgayNhap"] != DBNull.Value)
						{
							item.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
						}
						if (dr["NguoiNhap"] != null && dr["NguoiNhap"] != DBNull.Value)
						{
							item.NguoiNhap = Convert.ToString(dr["NguoiNhap"]);
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
		/// Lấy một ExpSaleNhapVatTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpSaleNhapVatTu GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleNhapVatTu] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpSaleNhapVatTu item=new ExpSaleNhapVatTu();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
						{
							item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
						}
						if (dr["NgayNhap"] != null && dr["NgayNhap"] != DBNull.Value)
						{
							item.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
						}
						if (dr["NguoiNhap"] != null && dr["NguoiNhap"] != DBNull.Value)
						{
							item.NguoiNhap = Convert.ToString(dr["NguoiNhap"]);
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

		public ExpSaleNhapVatTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleNhapVatTu] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpSaleNhapVatTu>(ds);
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
		/// Thêm mới ExpSaleNhapVatTu vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpSaleNhapVatTu _ExpSaleNhapVatTu)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpSaleNhapVatTu](Id, FK_VatTu, NgayNhap, NguoiNhap, SoLuong, DonGia, ThanhTien) VALUES(@Id, @FK_VatTu, @NgayNhap, @NguoiNhap, @SoLuong, @DonGia, @ThanhTien)", 
					"@Id",  _ExpSaleNhapVatTu.Id, 
					"@FK_VatTu",  _ExpSaleNhapVatTu.FK_VatTu, 
					"@NgayNhap", this._dataContext.ConvertDateString( _ExpSaleNhapVatTu.NgayNhap), 
					"@NguoiNhap",  _ExpSaleNhapVatTu.NguoiNhap, 
					"@SoLuong",  _ExpSaleNhapVatTu.SoLuong, 
					"@DonGia",  _ExpSaleNhapVatTu.DonGia, 
					"@ThanhTien",  _ExpSaleNhapVatTu.ThanhTien);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpSaleNhapVatTu vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpSaleNhapVatTu> _ExpSaleNhapVatTus)
		{
			foreach (ExpSaleNhapVatTu item in _ExpSaleNhapVatTus)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleNhapVatTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpSaleNhapVatTu _ExpSaleNhapVatTu, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleNhapVatTu] SET Id=@Id, FK_VatTu=@FK_VatTu, NgayNhap=@NgayNhap, NguoiNhap=@NguoiNhap, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien WHERE Id=@Id", 
					"@Id",  _ExpSaleNhapVatTu.Id, 
					"@FK_VatTu",  _ExpSaleNhapVatTu.FK_VatTu, 
					"@NgayNhap", this._dataContext.ConvertDateString( _ExpSaleNhapVatTu.NgayNhap), 
					"@NguoiNhap",  _ExpSaleNhapVatTu.NguoiNhap, 
					"@SoLuong",  _ExpSaleNhapVatTu.SoLuong, 
					"@DonGia",  _ExpSaleNhapVatTu.DonGia, 
					"@ThanhTien",  _ExpSaleNhapVatTu.ThanhTien, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleNhapVatTu vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpSaleNhapVatTu _ExpSaleNhapVatTu)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleNhapVatTu] SET FK_VatTu=@FK_VatTu, NgayNhap=@NgayNhap, NguoiNhap=@NguoiNhap, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien WHERE Id=@Id", 
					"@FK_VatTu",  _ExpSaleNhapVatTu.FK_VatTu, 
					"@NgayNhap", this._dataContext.ConvertDateString( _ExpSaleNhapVatTu.NgayNhap), 
					"@NguoiNhap",  _ExpSaleNhapVatTu.NguoiNhap, 
					"@SoLuong",  _ExpSaleNhapVatTu.SoLuong, 
					"@DonGia",  _ExpSaleNhapVatTu.DonGia, 
					"@ThanhTien",  _ExpSaleNhapVatTu.ThanhTien, 
					"@Id", _ExpSaleNhapVatTu.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpSaleNhapVatTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpSaleNhapVatTu> _ExpSaleNhapVatTus)
		{
			foreach (ExpSaleNhapVatTu item in _ExpSaleNhapVatTus)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleNhapVatTu vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpSaleNhapVatTu _ExpSaleNhapVatTu, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleNhapVatTu] SET Id=@Id, FK_VatTu=@FK_VatTu, NgayNhap=@NgayNhap, NguoiNhap=@NguoiNhap, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien "+ condition, 
					"@Id",  _ExpSaleNhapVatTu.Id, 
					"@FK_VatTu",  _ExpSaleNhapVatTu.FK_VatTu, 
					"@NgayNhap", this._dataContext.ConvertDateString( _ExpSaleNhapVatTu.NgayNhap), 
					"@NguoiNhap",  _ExpSaleNhapVatTu.NguoiNhap, 
					"@SoLuong",  _ExpSaleNhapVatTu.SoLuong, 
					"@DonGia",  _ExpSaleNhapVatTu.DonGia, 
					"@ThanhTien",  _ExpSaleNhapVatTu.ThanhTien);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpSaleNhapVatTu trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleNhapVatTu] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleNhapVatTu trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpSaleNhapVatTu _ExpSaleNhapVatTu)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleNhapVatTu] WHERE Id=@Id",
					"@Id", _ExpSaleNhapVatTu.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleNhapVatTu trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleNhapVatTu] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleNhapVatTu trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpSaleNhapVatTu> _ExpSaleNhapVatTus)
		{
			foreach (ExpSaleNhapVatTu item in _ExpSaleNhapVatTus)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
