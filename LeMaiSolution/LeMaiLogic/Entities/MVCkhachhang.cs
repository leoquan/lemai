using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVCkhachhang:IVCkhachhang
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVCkhachhang(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VCKhachHang từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCKhachHang]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VCKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCKhachHang] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VCKhachHang từ Database
		/// </summary>
		public List<VCKhachHang> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCKhachHang]");
				List<VCKhachHang> items = new List<VCKhachHang>();
				VCKhachHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCKhachHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaKhachHang"] != null && dr["MaKhachHang"] != DBNull.Value)
					{
						item.MaKhachHang = Convert.ToString(dr["MaKhachHang"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["TenKhachHangKD"] != null && dr["TenKhachHangKD"] != DBNull.Value)
					{
						item.TenKhachHangKD = Convert.ToString(dr["TenKhachHangKD"]);
					}
					if (dr["SoNo"] != null && dr["SoNo"] != DBNull.Value)
					{
						item.SoNo = Convert.ToDecimal(dr["SoNo"]);
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
		/// Lấy danh sách VCKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VCKhachHang> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCKhachHang] A "+ condition,  parameters);
				List<VCKhachHang> items = new List<VCKhachHang>();
				VCKhachHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCKhachHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaKhachHang"] != null && dr["MaKhachHang"] != DBNull.Value)
					{
						item.MaKhachHang = Convert.ToString(dr["MaKhachHang"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["TenKhachHangKD"] != null && dr["TenKhachHangKD"] != DBNull.Value)
					{
						item.TenKhachHangKD = Convert.ToString(dr["TenKhachHangKD"]);
					}
					if (dr["SoNo"] != null && dr["SoNo"] != DBNull.Value)
					{
						item.SoNo = Convert.ToDecimal(dr["SoNo"]);
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

		public List<VCKhachHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCKhachHang] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VCKhachHang] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VCKhachHang>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VCKhachHang từ Database
		/// </summary>
		public VCKhachHang GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCKhachHang] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					VCKhachHang item=new VCKhachHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaKhachHang"] != null && dr["MaKhachHang"] != DBNull.Value)
						{
							item.MaKhachHang = Convert.ToString(dr["MaKhachHang"]);
						}
						if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
						{
							item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
						}
						if (dr["TenKhachHangKD"] != null && dr["TenKhachHangKD"] != DBNull.Value)
						{
							item.TenKhachHangKD = Convert.ToString(dr["TenKhachHangKD"]);
						}
						if (dr["SoNo"] != null && dr["SoNo"] != DBNull.Value)
						{
							item.SoNo = Convert.ToDecimal(dr["SoNo"]);
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
		/// Lấy một VCKhachHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VCKhachHang GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCKhachHang] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VCKhachHang item=new VCKhachHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaKhachHang"] != null && dr["MaKhachHang"] != DBNull.Value)
						{
							item.MaKhachHang = Convert.ToString(dr["MaKhachHang"]);
						}
						if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
						{
							item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
						}
						if (dr["TenKhachHangKD"] != null && dr["TenKhachHangKD"] != DBNull.Value)
						{
							item.TenKhachHangKD = Convert.ToString(dr["TenKhachHangKD"]);
						}
						if (dr["SoNo"] != null && dr["SoNo"] != DBNull.Value)
						{
							item.SoNo = Convert.ToDecimal(dr["SoNo"]);
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

		public VCKhachHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCKhachHang] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VCKhachHang>(ds);
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
		/// Thêm mới VCKhachHang vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VCKhachHang _VCKhachHang)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VCKhachHang](Id, MaKhachHang, TenKhachHang, TenKhachHangKD, SoNo) VALUES(@Id, @MaKhachHang, @TenKhachHang, @TenKhachHangKD, @SoNo)", 
					"@Id",  _VCKhachHang.Id, 
					"@MaKhachHang",  _VCKhachHang.MaKhachHang, 
					"@TenKhachHang",  _VCKhachHang.TenKhachHang, 
					"@TenKhachHangKD",  _VCKhachHang.TenKhachHangKD, 
					"@SoNo",  _VCKhachHang.SoNo);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VCKhachHang vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VCKhachHang> _VCKhachHangs)
		{
			foreach (VCKhachHang item in _VCKhachHangs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCKhachHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VCKhachHang _VCKhachHang, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCKhachHang] SET Id=@Id, MaKhachHang=@MaKhachHang, TenKhachHang=@TenKhachHang, TenKhachHangKD=@TenKhachHangKD, SoNo=@SoNo WHERE Id=@Id", 
					"@Id",  _VCKhachHang.Id, 
					"@MaKhachHang",  _VCKhachHang.MaKhachHang, 
					"@TenKhachHang",  _VCKhachHang.TenKhachHang, 
					"@TenKhachHangKD",  _VCKhachHang.TenKhachHangKD, 
					"@SoNo",  _VCKhachHang.SoNo, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VCKhachHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VCKhachHang _VCKhachHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCKhachHang] SET MaKhachHang=@MaKhachHang, TenKhachHang=@TenKhachHang, TenKhachHangKD=@TenKhachHangKD, SoNo=@SoNo WHERE Id=@Id", 
					"@MaKhachHang",  _VCKhachHang.MaKhachHang, 
					"@TenKhachHang",  _VCKhachHang.TenKhachHang, 
					"@TenKhachHangKD",  _VCKhachHang.TenKhachHangKD, 
					"@SoNo",  _VCKhachHang.SoNo, 
					"@Id", _VCKhachHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VCKhachHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VCKhachHang> _VCKhachHangs)
		{
			foreach (VCKhachHang item in _VCKhachHangs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCKhachHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VCKhachHang _VCKhachHang, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCKhachHang] SET Id=@Id, MaKhachHang=@MaKhachHang, TenKhachHang=@TenKhachHang, TenKhachHangKD=@TenKhachHangKD, SoNo=@SoNo "+ condition, 
					"@Id",  _VCKhachHang.Id, 
					"@MaKhachHang",  _VCKhachHang.MaKhachHang, 
					"@TenKhachHang",  _VCKhachHang.TenKhachHang, 
					"@TenKhachHangKD",  _VCKhachHang.TenKhachHangKD, 
					"@SoNo",  _VCKhachHang.SoNo);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VCKhachHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCKhachHang] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCKhachHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VCKhachHang _VCKhachHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCKhachHang] WHERE Id=@Id",
					"@Id", _VCKhachHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCKhachHang trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCKhachHang] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCKhachHang trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VCKhachHang> _VCKhachHangs)
		{
			foreach (VCKhachHang item in _VCKhachHangs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
