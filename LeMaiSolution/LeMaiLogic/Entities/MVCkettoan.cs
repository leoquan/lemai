using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVCkettoan:IVCkettoan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVCkettoan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VCKetToan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCKetToan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VCKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCKetToan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VCKetToan từ Database
		/// </summary>
		public List<VCKetToan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCKetToan]");
				List<VCKetToan> items = new List<VCKetToan>();
				VCKetToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCKetToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_BillCode"] != null && dr["FK_BillCode"] != DBNull.Value)
					{
						item.FK_BillCode = Convert.ToString(dr["FK_BillCode"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
					}
					if (dr["MaChiPhi"] != null && dr["MaChiPhi"] != DBNull.Value)
					{
						item.MaChiPhi = Convert.ToString(dr["MaChiPhi"]);
					}
					if (dr["SoDuTruoc"] != null && dr["SoDuTruoc"] != DBNull.Value)
					{
						item.SoDuTruoc = Convert.ToDecimal(dr["SoDuTruoc"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToDecimal(dr["SoTien"]);
					}
					if (dr["SoDuSau"] != null && dr["SoDuSau"] != DBNull.Value)
					{
						item.SoDuSau = Convert.ToDecimal(dr["SoDuSau"]);
					}
					if (dr["NgayKetToan"] != null && dr["NgayKetToan"] != DBNull.Value)
					{
						item.NgayKetToan = Convert.ToDateTime(dr["NgayKetToan"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
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
		/// Lấy danh sách VCKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VCKetToan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCKetToan] A "+ condition,  parameters);
				List<VCKetToan> items = new List<VCKetToan>();
				VCKetToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCKetToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_BillCode"] != null && dr["FK_BillCode"] != DBNull.Value)
					{
						item.FK_BillCode = Convert.ToString(dr["FK_BillCode"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
					}
					if (dr["MaChiPhi"] != null && dr["MaChiPhi"] != DBNull.Value)
					{
						item.MaChiPhi = Convert.ToString(dr["MaChiPhi"]);
					}
					if (dr["SoDuTruoc"] != null && dr["SoDuTruoc"] != DBNull.Value)
					{
						item.SoDuTruoc = Convert.ToDecimal(dr["SoDuTruoc"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToDecimal(dr["SoTien"]);
					}
					if (dr["SoDuSau"] != null && dr["SoDuSau"] != DBNull.Value)
					{
						item.SoDuSau = Convert.ToDecimal(dr["SoDuSau"]);
					}
					if (dr["NgayKetToan"] != null && dr["NgayKetToan"] != DBNull.Value)
					{
						item.NgayKetToan = Convert.ToDateTime(dr["NgayKetToan"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
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

		public List<VCKetToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCKetToan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VCKetToan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VCKetToan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VCKetToan từ Database
		/// </summary>
		public VCKetToan GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCKetToan] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					VCKetToan item=new VCKetToan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_BillCode"] != null && dr["FK_BillCode"] != DBNull.Value)
						{
							item.FK_BillCode = Convert.ToString(dr["FK_BillCode"]);
						}
						if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
						{
							item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
						}
						if (dr["MaChiPhi"] != null && dr["MaChiPhi"] != DBNull.Value)
						{
							item.MaChiPhi = Convert.ToString(dr["MaChiPhi"]);
						}
						if (dr["SoDuTruoc"] != null && dr["SoDuTruoc"] != DBNull.Value)
						{
							item.SoDuTruoc = Convert.ToDecimal(dr["SoDuTruoc"]);
						}
						if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
						{
							item.SoTien = Convert.ToDecimal(dr["SoTien"]);
						}
						if (dr["SoDuSau"] != null && dr["SoDuSau"] != DBNull.Value)
						{
							item.SoDuSau = Convert.ToDecimal(dr["SoDuSau"]);
						}
						if (dr["NgayKetToan"] != null && dr["NgayKetToan"] != DBNull.Value)
						{
							item.NgayKetToan = Convert.ToDateTime(dr["NgayKetToan"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
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
		/// Lấy một VCKetToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VCKetToan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCKetToan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VCKetToan item=new VCKetToan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_BillCode"] != null && dr["FK_BillCode"] != DBNull.Value)
						{
							item.FK_BillCode = Convert.ToString(dr["FK_BillCode"]);
						}
						if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
						{
							item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
						}
						if (dr["MaChiPhi"] != null && dr["MaChiPhi"] != DBNull.Value)
						{
							item.MaChiPhi = Convert.ToString(dr["MaChiPhi"]);
						}
						if (dr["SoDuTruoc"] != null && dr["SoDuTruoc"] != DBNull.Value)
						{
							item.SoDuTruoc = Convert.ToDecimal(dr["SoDuTruoc"]);
						}
						if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
						{
							item.SoTien = Convert.ToDecimal(dr["SoTien"]);
						}
						if (dr["SoDuSau"] != null && dr["SoDuSau"] != DBNull.Value)
						{
							item.SoDuSau = Convert.ToDecimal(dr["SoDuSau"]);
						}
						if (dr["NgayKetToan"] != null && dr["NgayKetToan"] != DBNull.Value)
						{
							item.NgayKetToan = Convert.ToDateTime(dr["NgayKetToan"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
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

		public VCKetToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCKetToan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VCKetToan>(ds);
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
		/// Thêm mới VCKetToan vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VCKetToan _VCKetToan)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VCKetToan](Id, FK_BillCode, FK_KhachHang, MaChiPhi, SoDuTruoc, SoTien, SoDuSau, NgayKetToan, FK_Account) VALUES(@Id, @FK_BillCode, @FK_KhachHang, @MaChiPhi, @SoDuTruoc, @SoTien, @SoDuSau, @NgayKetToan, @FK_Account)", 
					"@Id",  _VCKetToan.Id, 
					"@FK_BillCode",  _VCKetToan.FK_BillCode, 
					"@FK_KhachHang",  _VCKetToan.FK_KhachHang, 
					"@MaChiPhi",  _VCKetToan.MaChiPhi, 
					"@SoDuTruoc",  _VCKetToan.SoDuTruoc, 
					"@SoTien",  _VCKetToan.SoTien, 
					"@SoDuSau",  _VCKetToan.SoDuSau, 
					"@NgayKetToan", this._dataContext.ConvertDateString( _VCKetToan.NgayKetToan), 
					"@FK_Account",  _VCKetToan.FK_Account);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VCKetToan vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VCKetToan> _VCKetToans)
		{
			foreach (VCKetToan item in _VCKetToans)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCKetToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VCKetToan _VCKetToan, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCKetToan] SET Id=@Id, FK_BillCode=@FK_BillCode, FK_KhachHang=@FK_KhachHang, MaChiPhi=@MaChiPhi, SoDuTruoc=@SoDuTruoc, SoTien=@SoTien, SoDuSau=@SoDuSau, NgayKetToan=@NgayKetToan, FK_Account=@FK_Account WHERE Id=@Id", 
					"@Id",  _VCKetToan.Id, 
					"@FK_BillCode",  _VCKetToan.FK_BillCode, 
					"@FK_KhachHang",  _VCKetToan.FK_KhachHang, 
					"@MaChiPhi",  _VCKetToan.MaChiPhi, 
					"@SoDuTruoc",  _VCKetToan.SoDuTruoc, 
					"@SoTien",  _VCKetToan.SoTien, 
					"@SoDuSau",  _VCKetToan.SoDuSau, 
					"@NgayKetToan", this._dataContext.ConvertDateString( _VCKetToan.NgayKetToan), 
					"@FK_Account",  _VCKetToan.FK_Account, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VCKetToan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VCKetToan _VCKetToan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCKetToan] SET FK_BillCode=@FK_BillCode, FK_KhachHang=@FK_KhachHang, MaChiPhi=@MaChiPhi, SoDuTruoc=@SoDuTruoc, SoTien=@SoTien, SoDuSau=@SoDuSau, NgayKetToan=@NgayKetToan, FK_Account=@FK_Account WHERE Id=@Id", 
					"@FK_BillCode",  _VCKetToan.FK_BillCode, 
					"@FK_KhachHang",  _VCKetToan.FK_KhachHang, 
					"@MaChiPhi",  _VCKetToan.MaChiPhi, 
					"@SoDuTruoc",  _VCKetToan.SoDuTruoc, 
					"@SoTien",  _VCKetToan.SoTien, 
					"@SoDuSau",  _VCKetToan.SoDuSau, 
					"@NgayKetToan", this._dataContext.ConvertDateString( _VCKetToan.NgayKetToan), 
					"@FK_Account",  _VCKetToan.FK_Account, 
					"@Id", _VCKetToan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VCKetToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VCKetToan> _VCKetToans)
		{
			foreach (VCKetToan item in _VCKetToans)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCKetToan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VCKetToan _VCKetToan, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCKetToan] SET Id=@Id, FK_BillCode=@FK_BillCode, FK_KhachHang=@FK_KhachHang, MaChiPhi=@MaChiPhi, SoDuTruoc=@SoDuTruoc, SoTien=@SoTien, SoDuSau=@SoDuSau, NgayKetToan=@NgayKetToan, FK_Account=@FK_Account "+ condition, 
					"@Id",  _VCKetToan.Id, 
					"@FK_BillCode",  _VCKetToan.FK_BillCode, 
					"@FK_KhachHang",  _VCKetToan.FK_KhachHang, 
					"@MaChiPhi",  _VCKetToan.MaChiPhi, 
					"@SoDuTruoc",  _VCKetToan.SoDuTruoc, 
					"@SoTien",  _VCKetToan.SoTien, 
					"@SoDuSau",  _VCKetToan.SoDuSau, 
					"@NgayKetToan", this._dataContext.ConvertDateString( _VCKetToan.NgayKetToan), 
					"@FK_Account",  _VCKetToan.FK_Account);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VCKetToan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCKetToan] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCKetToan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VCKetToan _VCKetToan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCKetToan] WHERE Id=@Id",
					"@Id", _VCKetToan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCKetToan trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCKetToan] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCKetToan trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VCKetToan> _VCKetToans)
		{
			foreach (VCKetToan item in _VCKetToans)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
