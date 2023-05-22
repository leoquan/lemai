using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSAlehoadon:ISAlehoadon
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSAlehoadon(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SaleHoaDon từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleHoaDon]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SaleHoaDon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleHoaDon] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SaleHoaDon từ Database
		/// </summary>
		public List<SaleHoaDon> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleHoaDon]");
				List<SaleHoaDon> items = new List<SaleHoaDon>();
				SaleHoaDon item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleHoaDon();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
					{
						item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
					}
					if (dr["NgayBan"] != null && dr["NgayBan"] != DBNull.Value)
					{
						item.NgayBan = Convert.ToDateTime(dr["NgayBan"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
					}
					if (dr["TongTien"] != null && dr["TongTien"] != DBNull.Value)
					{
						item.TongTien = Convert.ToInt32(dr["TongTien"]);
					}
					if (dr["ThanhToan"] != null && dr["ThanhToan"] != DBNull.Value)
					{
						item.ThanhToan = Convert.ToInt32(dr["ThanhToan"]);
					}
					if (dr["CongNo"] != null && dr["CongNo"] != DBNull.Value)
					{
						item.CongNo = Convert.ToInt32(dr["CongNo"]);
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
		/// Lấy danh sách SaleHoaDon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SaleHoaDon> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleHoaDon] A "+ condition,  parameters);
				List<SaleHoaDon> items = new List<SaleHoaDon>();
				SaleHoaDon item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleHoaDon();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
					{
						item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
					}
					if (dr["NgayBan"] != null && dr["NgayBan"] != DBNull.Value)
					{
						item.NgayBan = Convert.ToDateTime(dr["NgayBan"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
					}
					if (dr["TongTien"] != null && dr["TongTien"] != DBNull.Value)
					{
						item.TongTien = Convert.ToInt32(dr["TongTien"]);
					}
					if (dr["ThanhToan"] != null && dr["ThanhToan"] != DBNull.Value)
					{
						item.ThanhToan = Convert.ToInt32(dr["ThanhToan"]);
					}
					if (dr["CongNo"] != null && dr["CongNo"] != DBNull.Value)
					{
						item.CongNo = Convert.ToInt32(dr["CongNo"]);
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

		public List<SaleHoaDon> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleHoaDon] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SaleHoaDon] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SaleHoaDon>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SaleHoaDon từ Database
		/// </summary>
		public SaleHoaDon GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleHoaDon] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SaleHoaDon item=new SaleHoaDon();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
						{
							item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
						}
						if (dr["NgayBan"] != null && dr["NgayBan"] != DBNull.Value)
						{
							item.NgayBan = Convert.ToDateTime(dr["NgayBan"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
						{
							item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
						}
						if (dr["TongTien"] != null && dr["TongTien"] != DBNull.Value)
						{
							item.TongTien = Convert.ToInt32(dr["TongTien"]);
						}
						if (dr["ThanhToan"] != null && dr["ThanhToan"] != DBNull.Value)
						{
							item.ThanhToan = Convert.ToInt32(dr["ThanhToan"]);
						}
						if (dr["CongNo"] != null && dr["CongNo"] != DBNull.Value)
						{
							item.CongNo = Convert.ToInt32(dr["CongNo"]);
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
		/// Lấy một SaleHoaDon đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SaleHoaDon GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleHoaDon] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SaleHoaDon item=new SaleHoaDon();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
						{
							item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
						}
						if (dr["NgayBan"] != null && dr["NgayBan"] != DBNull.Value)
						{
							item.NgayBan = Convert.ToDateTime(dr["NgayBan"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
						{
							item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
						}
						if (dr["TongTien"] != null && dr["TongTien"] != DBNull.Value)
						{
							item.TongTien = Convert.ToInt32(dr["TongTien"]);
						}
						if (dr["ThanhToan"] != null && dr["ThanhToan"] != DBNull.Value)
						{
							item.ThanhToan = Convert.ToInt32(dr["ThanhToan"]);
						}
						if (dr["CongNo"] != null && dr["CongNo"] != DBNull.Value)
						{
							item.CongNo = Convert.ToInt32(dr["CongNo"]);
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

		public SaleHoaDon GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleHoaDon] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SaleHoaDon>(ds);
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
		/// Thêm mới SaleHoaDon vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SaleHoaDon _SaleHoaDon)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SaleHoaDon](Id, SoHoaDon, NgayBan, Note, FK_KhachHang, TongTien, ThanhToan, CongNo) VALUES(@Id, @SoHoaDon, @NgayBan, @Note, @FK_KhachHang, @TongTien, @ThanhToan, @CongNo)", 
					"@Id",  _SaleHoaDon.Id, 
					"@SoHoaDon",  _SaleHoaDon.SoHoaDon, 
					"@NgayBan", this._dataContext.ConvertDateString( _SaleHoaDon.NgayBan), 
					"@Note",  _SaleHoaDon.Note, 
					"@FK_KhachHang",  _SaleHoaDon.FK_KhachHang, 
					"@TongTien",  _SaleHoaDon.TongTien, 
					"@ThanhToan",  _SaleHoaDon.ThanhToan, 
					"@CongNo",  _SaleHoaDon.CongNo);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SaleHoaDon vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SaleHoaDon> _SaleHoaDons)
		{
			foreach (SaleHoaDon item in _SaleHoaDons)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleHoaDon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SaleHoaDon _SaleHoaDon, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleHoaDon] SET Id=@Id, SoHoaDon=@SoHoaDon, NgayBan=@NgayBan, Note=@Note, FK_KhachHang=@FK_KhachHang, TongTien=@TongTien, ThanhToan=@ThanhToan, CongNo=@CongNo WHERE Id=@Id", 
					"@Id",  _SaleHoaDon.Id, 
					"@SoHoaDon",  _SaleHoaDon.SoHoaDon, 
					"@NgayBan", this._dataContext.ConvertDateString( _SaleHoaDon.NgayBan), 
					"@Note",  _SaleHoaDon.Note, 
					"@FK_KhachHang",  _SaleHoaDon.FK_KhachHang, 
					"@TongTien",  _SaleHoaDon.TongTien, 
					"@ThanhToan",  _SaleHoaDon.ThanhToan, 
					"@CongNo",  _SaleHoaDon.CongNo, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SaleHoaDon vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SaleHoaDon _SaleHoaDon)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleHoaDon] SET SoHoaDon=@SoHoaDon, NgayBan=@NgayBan, Note=@Note, FK_KhachHang=@FK_KhachHang, TongTien=@TongTien, ThanhToan=@ThanhToan, CongNo=@CongNo WHERE Id=@Id", 
					"@SoHoaDon",  _SaleHoaDon.SoHoaDon, 
					"@NgayBan", this._dataContext.ConvertDateString( _SaleHoaDon.NgayBan), 
					"@Note",  _SaleHoaDon.Note, 
					"@FK_KhachHang",  _SaleHoaDon.FK_KhachHang, 
					"@TongTien",  _SaleHoaDon.TongTien, 
					"@ThanhToan",  _SaleHoaDon.ThanhToan, 
					"@CongNo",  _SaleHoaDon.CongNo, 
					"@Id", _SaleHoaDon.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SaleHoaDon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SaleHoaDon> _SaleHoaDons)
		{
			foreach (SaleHoaDon item in _SaleHoaDons)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleHoaDon vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SaleHoaDon _SaleHoaDon, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleHoaDon] SET Id=@Id, SoHoaDon=@SoHoaDon, NgayBan=@NgayBan, Note=@Note, FK_KhachHang=@FK_KhachHang, TongTien=@TongTien, ThanhToan=@ThanhToan, CongNo=@CongNo "+ condition, 
					"@Id",  _SaleHoaDon.Id, 
					"@SoHoaDon",  _SaleHoaDon.SoHoaDon, 
					"@NgayBan", this._dataContext.ConvertDateString( _SaleHoaDon.NgayBan), 
					"@Note",  _SaleHoaDon.Note, 
					"@FK_KhachHang",  _SaleHoaDon.FK_KhachHang, 
					"@TongTien",  _SaleHoaDon.TongTien, 
					"@ThanhToan",  _SaleHoaDon.ThanhToan, 
					"@CongNo",  _SaleHoaDon.CongNo);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SaleHoaDon trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleHoaDon] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleHoaDon trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SaleHoaDon _SaleHoaDon)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleHoaDon] WHERE Id=@Id",
					"@Id", _SaleHoaDon.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleHoaDon trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleHoaDon] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleHoaDon trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SaleHoaDon> _SaleHoaDons)
		{
			foreach (SaleHoaDon item in _SaleHoaDons)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
