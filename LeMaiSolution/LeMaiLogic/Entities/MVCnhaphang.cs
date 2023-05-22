using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVCnhaphang:IVCnhaphang
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVCnhaphang(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VCNhapHang từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCNhapHang]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VCNhapHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCNhapHang] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VCNhapHang từ Database
		/// </summary>
		public List<VCNhapHang> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCNhapHang]");
				List<VCNhapHang> items = new List<VCNhapHang>();
				VCNhapHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCNhapHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ngay"] != null && dr["Ngay"] != DBNull.Value)
					{
						item.Ngay = Convert.ToDateTime(dr["Ngay"]);
					}
					if (dr["FK_NhaCungCap"] != null && dr["FK_NhaCungCap"] != DBNull.Value)
					{
						item.FK_NhaCungCap = Convert.ToString(dr["FK_NhaCungCap"]);
					}
					if (dr["FK_MatHang"] != null && dr["FK_MatHang"] != DBNull.Value)
					{
						item.FK_MatHang = Convert.ToString(dr["FK_MatHang"]);
					}
					if (dr["LanThu"] != null && dr["LanThu"] != DBNull.Value)
					{
						item.LanThu = Convert.ToInt32(dr["LanThu"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["NgayNhap"] != null && dr["NgayNhap"] != DBNull.Value)
					{
						item.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
					}
					if (dr["Xuat"] != null && dr["Xuat"] != DBNull.Value)
					{
						item.Xuat = Convert.ToDecimal(dr["Xuat"]);
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
		/// Lấy danh sách VCNhapHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VCNhapHang> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCNhapHang] A "+ condition,  parameters);
				List<VCNhapHang> items = new List<VCNhapHang>();
				VCNhapHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCNhapHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ngay"] != null && dr["Ngay"] != DBNull.Value)
					{
						item.Ngay = Convert.ToDateTime(dr["Ngay"]);
					}
					if (dr["FK_NhaCungCap"] != null && dr["FK_NhaCungCap"] != DBNull.Value)
					{
						item.FK_NhaCungCap = Convert.ToString(dr["FK_NhaCungCap"]);
					}
					if (dr["FK_MatHang"] != null && dr["FK_MatHang"] != DBNull.Value)
					{
						item.FK_MatHang = Convert.ToString(dr["FK_MatHang"]);
					}
					if (dr["LanThu"] != null && dr["LanThu"] != DBNull.Value)
					{
						item.LanThu = Convert.ToInt32(dr["LanThu"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["NgayNhap"] != null && dr["NgayNhap"] != DBNull.Value)
					{
						item.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
					}
					if (dr["Xuat"] != null && dr["Xuat"] != DBNull.Value)
					{
						item.Xuat = Convert.ToDecimal(dr["Xuat"]);
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

		public List<VCNhapHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCNhapHang] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VCNhapHang] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VCNhapHang>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VCNhapHang từ Database
		/// </summary>
		public VCNhapHang GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCNhapHang] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					VCNhapHang item=new VCNhapHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Ngay"] != null && dr["Ngay"] != DBNull.Value)
						{
							item.Ngay = Convert.ToDateTime(dr["Ngay"]);
						}
						if (dr["FK_NhaCungCap"] != null && dr["FK_NhaCungCap"] != DBNull.Value)
						{
							item.FK_NhaCungCap = Convert.ToString(dr["FK_NhaCungCap"]);
						}
						if (dr["FK_MatHang"] != null && dr["FK_MatHang"] != DBNull.Value)
						{
							item.FK_MatHang = Convert.ToString(dr["FK_MatHang"]);
						}
						if (dr["LanThu"] != null && dr["LanThu"] != DBNull.Value)
						{
							item.LanThu = Convert.ToInt32(dr["LanThu"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["NgayNhap"] != null && dr["NgayNhap"] != DBNull.Value)
						{
							item.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
						}
						if (dr["Xuat"] != null && dr["Xuat"] != DBNull.Value)
						{
							item.Xuat = Convert.ToDecimal(dr["Xuat"]);
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
		/// Lấy một VCNhapHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VCNhapHang GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCNhapHang] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VCNhapHang item=new VCNhapHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Ngay"] != null && dr["Ngay"] != DBNull.Value)
						{
							item.Ngay = Convert.ToDateTime(dr["Ngay"]);
						}
						if (dr["FK_NhaCungCap"] != null && dr["FK_NhaCungCap"] != DBNull.Value)
						{
							item.FK_NhaCungCap = Convert.ToString(dr["FK_NhaCungCap"]);
						}
						if (dr["FK_MatHang"] != null && dr["FK_MatHang"] != DBNull.Value)
						{
							item.FK_MatHang = Convert.ToString(dr["FK_MatHang"]);
						}
						if (dr["LanThu"] != null && dr["LanThu"] != DBNull.Value)
						{
							item.LanThu = Convert.ToInt32(dr["LanThu"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["NgayNhap"] != null && dr["NgayNhap"] != DBNull.Value)
						{
							item.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
						}
						if (dr["Xuat"] != null && dr["Xuat"] != DBNull.Value)
						{
							item.Xuat = Convert.ToDecimal(dr["Xuat"]);
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

		public VCNhapHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCNhapHang] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VCNhapHang>(ds);
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
		/// Thêm mới VCNhapHang vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VCNhapHang _VCNhapHang)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VCNhapHang](Id, Ngay, FK_NhaCungCap, FK_MatHang, LanThu, SoLuong, FK_Account, NgayNhap, Xuat) VALUES(@Id, @Ngay, @FK_NhaCungCap, @FK_MatHang, @LanThu, @SoLuong, @FK_Account, @NgayNhap, @Xuat)", 
					"@Id",  _VCNhapHang.Id, 
					"@Ngay", this._dataContext.ConvertDateString( _VCNhapHang.Ngay), 
					"@FK_NhaCungCap",  _VCNhapHang.FK_NhaCungCap, 
					"@FK_MatHang",  _VCNhapHang.FK_MatHang, 
					"@LanThu",  _VCNhapHang.LanThu, 
					"@SoLuong",  _VCNhapHang.SoLuong, 
					"@FK_Account",  _VCNhapHang.FK_Account, 
					"@NgayNhap", this._dataContext.ConvertDateString( _VCNhapHang.NgayNhap), 
					"@Xuat",  _VCNhapHang.Xuat);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VCNhapHang vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VCNhapHang> _VCNhapHangs)
		{
			foreach (VCNhapHang item in _VCNhapHangs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCNhapHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VCNhapHang _VCNhapHang, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCNhapHang] SET Id=@Id, Ngay=@Ngay, FK_NhaCungCap=@FK_NhaCungCap, FK_MatHang=@FK_MatHang, LanThu=@LanThu, SoLuong=@SoLuong, FK_Account=@FK_Account, NgayNhap=@NgayNhap, Xuat=@Xuat WHERE Id=@Id", 
					"@Id",  _VCNhapHang.Id, 
					"@Ngay", this._dataContext.ConvertDateString( _VCNhapHang.Ngay), 
					"@FK_NhaCungCap",  _VCNhapHang.FK_NhaCungCap, 
					"@FK_MatHang",  _VCNhapHang.FK_MatHang, 
					"@LanThu",  _VCNhapHang.LanThu, 
					"@SoLuong",  _VCNhapHang.SoLuong, 
					"@FK_Account",  _VCNhapHang.FK_Account, 
					"@NgayNhap", this._dataContext.ConvertDateString( _VCNhapHang.NgayNhap), 
					"@Xuat",  _VCNhapHang.Xuat, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VCNhapHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VCNhapHang _VCNhapHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCNhapHang] SET Ngay=@Ngay, FK_NhaCungCap=@FK_NhaCungCap, FK_MatHang=@FK_MatHang, LanThu=@LanThu, SoLuong=@SoLuong, FK_Account=@FK_Account, NgayNhap=@NgayNhap, Xuat=@Xuat WHERE Id=@Id", 
					"@Ngay", this._dataContext.ConvertDateString( _VCNhapHang.Ngay), 
					"@FK_NhaCungCap",  _VCNhapHang.FK_NhaCungCap, 
					"@FK_MatHang",  _VCNhapHang.FK_MatHang, 
					"@LanThu",  _VCNhapHang.LanThu, 
					"@SoLuong",  _VCNhapHang.SoLuong, 
					"@FK_Account",  _VCNhapHang.FK_Account, 
					"@NgayNhap", this._dataContext.ConvertDateString( _VCNhapHang.NgayNhap), 
					"@Xuat",  _VCNhapHang.Xuat, 
					"@Id", _VCNhapHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VCNhapHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VCNhapHang> _VCNhapHangs)
		{
			foreach (VCNhapHang item in _VCNhapHangs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCNhapHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VCNhapHang _VCNhapHang, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCNhapHang] SET Id=@Id, Ngay=@Ngay, FK_NhaCungCap=@FK_NhaCungCap, FK_MatHang=@FK_MatHang, LanThu=@LanThu, SoLuong=@SoLuong, FK_Account=@FK_Account, NgayNhap=@NgayNhap, Xuat=@Xuat "+ condition, 
					"@Id",  _VCNhapHang.Id, 
					"@Ngay", this._dataContext.ConvertDateString( _VCNhapHang.Ngay), 
					"@FK_NhaCungCap",  _VCNhapHang.FK_NhaCungCap, 
					"@FK_MatHang",  _VCNhapHang.FK_MatHang, 
					"@LanThu",  _VCNhapHang.LanThu, 
					"@SoLuong",  _VCNhapHang.SoLuong, 
					"@FK_Account",  _VCNhapHang.FK_Account, 
					"@NgayNhap", this._dataContext.ConvertDateString( _VCNhapHang.NgayNhap), 
					"@Xuat",  _VCNhapHang.Xuat);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VCNhapHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCNhapHang] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCNhapHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VCNhapHang _VCNhapHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCNhapHang] WHERE Id=@Id",
					"@Id", _VCNhapHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCNhapHang trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCNhapHang] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCNhapHang trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VCNhapHang> _VCNhapHangs)
		{
			foreach (VCNhapHang item in _VCNhapHangs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
