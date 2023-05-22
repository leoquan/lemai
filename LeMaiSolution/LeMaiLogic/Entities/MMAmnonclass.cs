using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMAmnonclass:IMAmnonclass
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMAmnonclass(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MamNonClass từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonClass]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MamNonClass từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonClass] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MamNonClass từ Database
		/// </summary>
		public List<MamNonClass> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonClass]");
				List<MamNonClass> items = new List<MamNonClass>();
				MamNonClass item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonClass();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaLop"] != null && dr["MaLop"] != DBNull.Value)
					{
						item.MaLop = Convert.ToString(dr["MaLop"]);
					}
					if (dr["TenLop"] != null && dr["TenLop"] != DBNull.Value)
					{
						item.TenLop = Convert.ToString(dr["TenLop"]);
					}
					if (dr["FK_MNTruong"] != null && dr["FK_MNTruong"] != DBNull.Value)
					{
						item.FK_MNTruong = Convert.ToString(dr["FK_MNTruong"]);
					}
					if (dr["NamHoc"] != null && dr["NamHoc"] != DBNull.Value)
					{
						item.NamHoc = Convert.ToString(dr["NamHoc"]);
					}
					if (dr["FK_GiaoTrinh"] != null && dr["FK_GiaoTrinh"] != DBNull.Value)
					{
						item.FK_GiaoTrinh = Convert.ToString(dr["FK_GiaoTrinh"]);
					}
					if (dr["GiaoVienChuNhiem"] != null && dr["GiaoVienChuNhiem"] != DBNull.Value)
					{
						item.GiaoVienChuNhiem = Convert.ToString(dr["GiaoVienChuNhiem"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["HocPhi"] != null && dr["HocPhi"] != DBNull.Value)
					{
						item.HocPhi = Convert.ToInt32(dr["HocPhi"]);
					}
					if (dr["HoaHongTruongPercent"] != null && dr["HoaHongTruongPercent"] != DBNull.Value)
					{
						item.HoaHongTruongPercent = Convert.ToInt32(dr["HoaHongTruongPercent"]);
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
		/// Lấy danh sách MamNonClass từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MamNonClass> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonClass] A "+ condition,  parameters);
				List<MamNonClass> items = new List<MamNonClass>();
				MamNonClass item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonClass();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaLop"] != null && dr["MaLop"] != DBNull.Value)
					{
						item.MaLop = Convert.ToString(dr["MaLop"]);
					}
					if (dr["TenLop"] != null && dr["TenLop"] != DBNull.Value)
					{
						item.TenLop = Convert.ToString(dr["TenLop"]);
					}
					if (dr["FK_MNTruong"] != null && dr["FK_MNTruong"] != DBNull.Value)
					{
						item.FK_MNTruong = Convert.ToString(dr["FK_MNTruong"]);
					}
					if (dr["NamHoc"] != null && dr["NamHoc"] != DBNull.Value)
					{
						item.NamHoc = Convert.ToString(dr["NamHoc"]);
					}
					if (dr["FK_GiaoTrinh"] != null && dr["FK_GiaoTrinh"] != DBNull.Value)
					{
						item.FK_GiaoTrinh = Convert.ToString(dr["FK_GiaoTrinh"]);
					}
					if (dr["GiaoVienChuNhiem"] != null && dr["GiaoVienChuNhiem"] != DBNull.Value)
					{
						item.GiaoVienChuNhiem = Convert.ToString(dr["GiaoVienChuNhiem"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["HocPhi"] != null && dr["HocPhi"] != DBNull.Value)
					{
						item.HocPhi = Convert.ToInt32(dr["HocPhi"]);
					}
					if (dr["HoaHongTruongPercent"] != null && dr["HoaHongTruongPercent"] != DBNull.Value)
					{
						item.HoaHongTruongPercent = Convert.ToInt32(dr["HoaHongTruongPercent"]);
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

		public List<MamNonClass> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonClass] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MamNonClass] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MamNonClass>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MamNonClass từ Database
		/// </summary>
		public MamNonClass GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonClass] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MamNonClass item=new MamNonClass();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaLop"] != null && dr["MaLop"] != DBNull.Value)
						{
							item.MaLop = Convert.ToString(dr["MaLop"]);
						}
						if (dr["TenLop"] != null && dr["TenLop"] != DBNull.Value)
						{
							item.TenLop = Convert.ToString(dr["TenLop"]);
						}
						if (dr["FK_MNTruong"] != null && dr["FK_MNTruong"] != DBNull.Value)
						{
							item.FK_MNTruong = Convert.ToString(dr["FK_MNTruong"]);
						}
						if (dr["NamHoc"] != null && dr["NamHoc"] != DBNull.Value)
						{
							item.NamHoc = Convert.ToString(dr["NamHoc"]);
						}
						if (dr["FK_GiaoTrinh"] != null && dr["FK_GiaoTrinh"] != DBNull.Value)
						{
							item.FK_GiaoTrinh = Convert.ToString(dr["FK_GiaoTrinh"]);
						}
						if (dr["GiaoVienChuNhiem"] != null && dr["GiaoVienChuNhiem"] != DBNull.Value)
						{
							item.GiaoVienChuNhiem = Convert.ToString(dr["GiaoVienChuNhiem"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["HocPhi"] != null && dr["HocPhi"] != DBNull.Value)
						{
							item.HocPhi = Convert.ToInt32(dr["HocPhi"]);
						}
						if (dr["HoaHongTruongPercent"] != null && dr["HoaHongTruongPercent"] != DBNull.Value)
						{
							item.HoaHongTruongPercent = Convert.ToInt32(dr["HoaHongTruongPercent"]);
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
		/// Lấy một MamNonClass đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MamNonClass GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonClass] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MamNonClass item=new MamNonClass();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaLop"] != null && dr["MaLop"] != DBNull.Value)
						{
							item.MaLop = Convert.ToString(dr["MaLop"]);
						}
						if (dr["TenLop"] != null && dr["TenLop"] != DBNull.Value)
						{
							item.TenLop = Convert.ToString(dr["TenLop"]);
						}
						if (dr["FK_MNTruong"] != null && dr["FK_MNTruong"] != DBNull.Value)
						{
							item.FK_MNTruong = Convert.ToString(dr["FK_MNTruong"]);
						}
						if (dr["NamHoc"] != null && dr["NamHoc"] != DBNull.Value)
						{
							item.NamHoc = Convert.ToString(dr["NamHoc"]);
						}
						if (dr["FK_GiaoTrinh"] != null && dr["FK_GiaoTrinh"] != DBNull.Value)
						{
							item.FK_GiaoTrinh = Convert.ToString(dr["FK_GiaoTrinh"]);
						}
						if (dr["GiaoVienChuNhiem"] != null && dr["GiaoVienChuNhiem"] != DBNull.Value)
						{
							item.GiaoVienChuNhiem = Convert.ToString(dr["GiaoVienChuNhiem"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["HocPhi"] != null && dr["HocPhi"] != DBNull.Value)
						{
							item.HocPhi = Convert.ToInt32(dr["HocPhi"]);
						}
						if (dr["HoaHongTruongPercent"] != null && dr["HoaHongTruongPercent"] != DBNull.Value)
						{
							item.HoaHongTruongPercent = Convert.ToInt32(dr["HoaHongTruongPercent"]);
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

		public MamNonClass GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonClass] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MamNonClass>(ds);
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
		/// Thêm mới MamNonClass vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MamNonClass _MamNonClass)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MamNonClass](Id, MaLop, TenLop, FK_MNTruong, NamHoc, FK_GiaoTrinh, GiaoVienChuNhiem, SoDienThoai, HocPhi, HoaHongTruongPercent) VALUES(@Id, @MaLop, @TenLop, @FK_MNTruong, @NamHoc, @FK_GiaoTrinh, @GiaoVienChuNhiem, @SoDienThoai, @HocPhi, @HoaHongTruongPercent)", 
					"@Id",  _MamNonClass.Id, 
					"@MaLop",  _MamNonClass.MaLop, 
					"@TenLop",  _MamNonClass.TenLop, 
					"@FK_MNTruong",  _MamNonClass.FK_MNTruong, 
					"@NamHoc",  _MamNonClass.NamHoc, 
					"@FK_GiaoTrinh",  _MamNonClass.FK_GiaoTrinh, 
					"@GiaoVienChuNhiem",  _MamNonClass.GiaoVienChuNhiem, 
					"@SoDienThoai",  _MamNonClass.SoDienThoai, 
					"@HocPhi",  _MamNonClass.HocPhi, 
					"@HoaHongTruongPercent",  _MamNonClass.HoaHongTruongPercent);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MamNonClass vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MamNonClass> _MamNonClasss)
		{
			foreach (MamNonClass item in _MamNonClasss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonClass vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MamNonClass _MamNonClass, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonClass] SET Id=@Id, MaLop=@MaLop, TenLop=@TenLop, FK_MNTruong=@FK_MNTruong, NamHoc=@NamHoc, FK_GiaoTrinh=@FK_GiaoTrinh, GiaoVienChuNhiem=@GiaoVienChuNhiem, SoDienThoai=@SoDienThoai, HocPhi=@HocPhi, HoaHongTruongPercent=@HoaHongTruongPercent WHERE Id=@Id", 
					"@Id",  _MamNonClass.Id, 
					"@MaLop",  _MamNonClass.MaLop, 
					"@TenLop",  _MamNonClass.TenLop, 
					"@FK_MNTruong",  _MamNonClass.FK_MNTruong, 
					"@NamHoc",  _MamNonClass.NamHoc, 
					"@FK_GiaoTrinh",  _MamNonClass.FK_GiaoTrinh, 
					"@GiaoVienChuNhiem",  _MamNonClass.GiaoVienChuNhiem, 
					"@SoDienThoai",  _MamNonClass.SoDienThoai, 
					"@HocPhi",  _MamNonClass.HocPhi, 
					"@HoaHongTruongPercent",  _MamNonClass.HoaHongTruongPercent, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MamNonClass vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MamNonClass _MamNonClass)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonClass] SET MaLop=@MaLop, TenLop=@TenLop, FK_MNTruong=@FK_MNTruong, NamHoc=@NamHoc, FK_GiaoTrinh=@FK_GiaoTrinh, GiaoVienChuNhiem=@GiaoVienChuNhiem, SoDienThoai=@SoDienThoai, HocPhi=@HocPhi, HoaHongTruongPercent=@HoaHongTruongPercent WHERE Id=@Id", 
					"@MaLop",  _MamNonClass.MaLop, 
					"@TenLop",  _MamNonClass.TenLop, 
					"@FK_MNTruong",  _MamNonClass.FK_MNTruong, 
					"@NamHoc",  _MamNonClass.NamHoc, 
					"@FK_GiaoTrinh",  _MamNonClass.FK_GiaoTrinh, 
					"@GiaoVienChuNhiem",  _MamNonClass.GiaoVienChuNhiem, 
					"@SoDienThoai",  _MamNonClass.SoDienThoai, 
					"@HocPhi",  _MamNonClass.HocPhi, 
					"@HoaHongTruongPercent",  _MamNonClass.HoaHongTruongPercent, 
					"@Id", _MamNonClass.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MamNonClass vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MamNonClass> _MamNonClasss)
		{
			foreach (MamNonClass item in _MamNonClasss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonClass vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MamNonClass _MamNonClass, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonClass] SET Id=@Id, MaLop=@MaLop, TenLop=@TenLop, FK_MNTruong=@FK_MNTruong, NamHoc=@NamHoc, FK_GiaoTrinh=@FK_GiaoTrinh, GiaoVienChuNhiem=@GiaoVienChuNhiem, SoDienThoai=@SoDienThoai, HocPhi=@HocPhi, HoaHongTruongPercent=@HoaHongTruongPercent "+ condition, 
					"@Id",  _MamNonClass.Id, 
					"@MaLop",  _MamNonClass.MaLop, 
					"@TenLop",  _MamNonClass.TenLop, 
					"@FK_MNTruong",  _MamNonClass.FK_MNTruong, 
					"@NamHoc",  _MamNonClass.NamHoc, 
					"@FK_GiaoTrinh",  _MamNonClass.FK_GiaoTrinh, 
					"@GiaoVienChuNhiem",  _MamNonClass.GiaoVienChuNhiem, 
					"@SoDienThoai",  _MamNonClass.SoDienThoai, 
					"@HocPhi",  _MamNonClass.HocPhi, 
					"@HoaHongTruongPercent",  _MamNonClass.HoaHongTruongPercent);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MamNonClass trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonClass] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonClass trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MamNonClass _MamNonClass)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonClass] WHERE Id=@Id",
					"@Id", _MamNonClass.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonClass trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonClass] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonClass trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MamNonClass> _MamNonClasss)
		{
			foreach (MamNonClass item in _MamNonClasss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
