using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpsalecongno:IEXpsalecongno
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpsalecongno(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpSaleCongNo từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleCongNo]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpSaleCongNo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleCongNo] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpSaleCongNo từ Database
		/// </summary>
		public List<ExpSaleCongNo> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleCongNo]");
				List<ExpSaleCongNo> items = new List<ExpSaleCongNo>();
				ExpSaleCongNo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleCongNo();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["NgayTao"] != null && dr["NgayTao"] != DBNull.Value)
					{
						item.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
					}
					if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
					{
						item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["TenKhacHang"] != null && dr["TenKhacHang"] != DBNull.Value)
					{
						item.TenKhacHang = Convert.ToString(dr["TenKhacHang"]);
					}
					if (dr["NoiDung"] != null && dr["NoiDung"] != DBNull.Value)
					{
						item.NoiDung = Convert.ToString(dr["NoiDung"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToInt32(dr["ThanhTien"]);
					}
					if (dr["IsThanhToan"] != null && dr["IsThanhToan"] != DBNull.Value)
					{
						item.IsThanhToan = Convert.ToBoolean(dr["IsThanhToan"]);
					}
					if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
					{
						item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
					}
					if (dr["HinhThuc"] != null && dr["HinhThuc"] != DBNull.Value)
					{
						item.HinhThuc = Convert.ToString(dr["HinhThuc"]);
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
		/// Lấy danh sách ExpSaleCongNo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpSaleCongNo> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleCongNo] A "+ condition,  parameters);
				List<ExpSaleCongNo> items = new List<ExpSaleCongNo>();
				ExpSaleCongNo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSaleCongNo();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["NgayTao"] != null && dr["NgayTao"] != DBNull.Value)
					{
						item.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
					}
					if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
					{
						item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["TenKhacHang"] != null && dr["TenKhacHang"] != DBNull.Value)
					{
						item.TenKhacHang = Convert.ToString(dr["TenKhacHang"]);
					}
					if (dr["NoiDung"] != null && dr["NoiDung"] != DBNull.Value)
					{
						item.NoiDung = Convert.ToString(dr["NoiDung"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToInt32(dr["ThanhTien"]);
					}
					if (dr["IsThanhToan"] != null && dr["IsThanhToan"] != DBNull.Value)
					{
						item.IsThanhToan = Convert.ToBoolean(dr["IsThanhToan"]);
					}
					if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
					{
						item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
					}
					if (dr["HinhThuc"] != null && dr["HinhThuc"] != DBNull.Value)
					{
						item.HinhThuc = Convert.ToString(dr["HinhThuc"]);
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

		public List<ExpSaleCongNo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleCongNo] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpSaleCongNo] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpSaleCongNo>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpSaleCongNo từ Database
		/// </summary>
		public ExpSaleCongNo GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSaleCongNo] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpSaleCongNo item=new ExpSaleCongNo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["NgayTao"] != null && dr["NgayTao"] != DBNull.Value)
						{
							item.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
						}
						if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
						{
							item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["TenKhacHang"] != null && dr["TenKhacHang"] != DBNull.Value)
						{
							item.TenKhacHang = Convert.ToString(dr["TenKhacHang"]);
						}
						if (dr["NoiDung"] != null && dr["NoiDung"] != DBNull.Value)
						{
							item.NoiDung = Convert.ToString(dr["NoiDung"]);
						}
						if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
						{
							item.ThanhTien = Convert.ToInt32(dr["ThanhTien"]);
						}
						if (dr["IsThanhToan"] != null && dr["IsThanhToan"] != DBNull.Value)
						{
							item.IsThanhToan = Convert.ToBoolean(dr["IsThanhToan"]);
						}
						if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
						{
							item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
						}
						if (dr["HinhThuc"] != null && dr["HinhThuc"] != DBNull.Value)
						{
							item.HinhThuc = Convert.ToString(dr["HinhThuc"]);
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
		/// Lấy một ExpSaleCongNo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpSaleCongNo GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSaleCongNo] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpSaleCongNo item=new ExpSaleCongNo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["NgayTao"] != null && dr["NgayTao"] != DBNull.Value)
						{
							item.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
						}
						if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
						{
							item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["TenKhacHang"] != null && dr["TenKhacHang"] != DBNull.Value)
						{
							item.TenKhacHang = Convert.ToString(dr["TenKhacHang"]);
						}
						if (dr["NoiDung"] != null && dr["NoiDung"] != DBNull.Value)
						{
							item.NoiDung = Convert.ToString(dr["NoiDung"]);
						}
						if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
						{
							item.ThanhTien = Convert.ToInt32(dr["ThanhTien"]);
						}
						if (dr["IsThanhToan"] != null && dr["IsThanhToan"] != DBNull.Value)
						{
							item.IsThanhToan = Convert.ToBoolean(dr["IsThanhToan"]);
						}
						if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
						{
							item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
						}
						if (dr["HinhThuc"] != null && dr["HinhThuc"] != DBNull.Value)
						{
							item.HinhThuc = Convert.ToString(dr["HinhThuc"]);
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

		public ExpSaleCongNo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSaleCongNo] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpSaleCongNo>(ds);
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
		/// Thêm mới ExpSaleCongNo vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpSaleCongNo _ExpSaleCongNo)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpSaleCongNo](Id, NgayTao, NguoiTao, FK_Customer, TenKhacHang, NoiDung, ThanhTien, IsThanhToan, NgayThanhToan, HinhThuc) VALUES(@Id, @NgayTao, @NguoiTao, @FK_Customer, @TenKhacHang, @NoiDung, @ThanhTien, @IsThanhToan, @NgayThanhToan, @HinhThuc)", 
					"@Id",  _ExpSaleCongNo.Id, 
					"@NgayTao", this._dataContext.ConvertDateString( _ExpSaleCongNo.NgayTao), 
					"@NguoiTao",  _ExpSaleCongNo.NguoiTao, 
					"@FK_Customer",  _ExpSaleCongNo.FK_Customer, 
					"@TenKhacHang",  _ExpSaleCongNo.TenKhacHang, 
					"@NoiDung",  _ExpSaleCongNo.NoiDung, 
					"@ThanhTien",  _ExpSaleCongNo.ThanhTien, 
					"@IsThanhToan",  _ExpSaleCongNo.IsThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpSaleCongNo.NgayThanhToan), 
					"@HinhThuc",  _ExpSaleCongNo.HinhThuc);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpSaleCongNo vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpSaleCongNo> _ExpSaleCongNos)
		{
			foreach (ExpSaleCongNo item in _ExpSaleCongNos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleCongNo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpSaleCongNo _ExpSaleCongNo, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleCongNo] SET Id=@Id, NgayTao=@NgayTao, NguoiTao=@NguoiTao, FK_Customer=@FK_Customer, TenKhacHang=@TenKhacHang, NoiDung=@NoiDung, ThanhTien=@ThanhTien, IsThanhToan=@IsThanhToan, NgayThanhToan=@NgayThanhToan, HinhThuc=@HinhThuc WHERE Id=@Id", 
					"@Id",  _ExpSaleCongNo.Id, 
					"@NgayTao", this._dataContext.ConvertDateString( _ExpSaleCongNo.NgayTao), 
					"@NguoiTao",  _ExpSaleCongNo.NguoiTao, 
					"@FK_Customer",  _ExpSaleCongNo.FK_Customer, 
					"@TenKhacHang",  _ExpSaleCongNo.TenKhacHang, 
					"@NoiDung",  _ExpSaleCongNo.NoiDung, 
					"@ThanhTien",  _ExpSaleCongNo.ThanhTien, 
					"@IsThanhToan",  _ExpSaleCongNo.IsThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpSaleCongNo.NgayThanhToan), 
					"@HinhThuc",  _ExpSaleCongNo.HinhThuc, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleCongNo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpSaleCongNo _ExpSaleCongNo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleCongNo] SET NgayTao=@NgayTao, NguoiTao=@NguoiTao, FK_Customer=@FK_Customer, TenKhacHang=@TenKhacHang, NoiDung=@NoiDung, ThanhTien=@ThanhTien, IsThanhToan=@IsThanhToan, NgayThanhToan=@NgayThanhToan, HinhThuc=@HinhThuc WHERE Id=@Id", 
					"@NgayTao", this._dataContext.ConvertDateString( _ExpSaleCongNo.NgayTao), 
					"@NguoiTao",  _ExpSaleCongNo.NguoiTao, 
					"@FK_Customer",  _ExpSaleCongNo.FK_Customer, 
					"@TenKhacHang",  _ExpSaleCongNo.TenKhacHang, 
					"@NoiDung",  _ExpSaleCongNo.NoiDung, 
					"@ThanhTien",  _ExpSaleCongNo.ThanhTien, 
					"@IsThanhToan",  _ExpSaleCongNo.IsThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpSaleCongNo.NgayThanhToan), 
					"@HinhThuc",  _ExpSaleCongNo.HinhThuc, 
					"@Id", _ExpSaleCongNo.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpSaleCongNo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpSaleCongNo> _ExpSaleCongNos)
		{
			foreach (ExpSaleCongNo item in _ExpSaleCongNos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSaleCongNo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpSaleCongNo _ExpSaleCongNo, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSaleCongNo] SET Id=@Id, NgayTao=@NgayTao, NguoiTao=@NguoiTao, FK_Customer=@FK_Customer, TenKhacHang=@TenKhacHang, NoiDung=@NoiDung, ThanhTien=@ThanhTien, IsThanhToan=@IsThanhToan, NgayThanhToan=@NgayThanhToan, HinhThuc=@HinhThuc "+ condition, 
					"@Id",  _ExpSaleCongNo.Id, 
					"@NgayTao", this._dataContext.ConvertDateString( _ExpSaleCongNo.NgayTao), 
					"@NguoiTao",  _ExpSaleCongNo.NguoiTao, 
					"@FK_Customer",  _ExpSaleCongNo.FK_Customer, 
					"@TenKhacHang",  _ExpSaleCongNo.TenKhacHang, 
					"@NoiDung",  _ExpSaleCongNo.NoiDung, 
					"@ThanhTien",  _ExpSaleCongNo.ThanhTien, 
					"@IsThanhToan",  _ExpSaleCongNo.IsThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpSaleCongNo.NgayThanhToan), 
					"@HinhThuc",  _ExpSaleCongNo.HinhThuc);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpSaleCongNo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleCongNo] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleCongNo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpSaleCongNo _ExpSaleCongNo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleCongNo] WHERE Id=@Id",
					"@Id", _ExpSaleCongNo.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleCongNo trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSaleCongNo] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSaleCongNo trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpSaleCongNo> _ExpSaleCongNos)
		{
			foreach (ExpSaleCongNo item in _ExpSaleCongNos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
