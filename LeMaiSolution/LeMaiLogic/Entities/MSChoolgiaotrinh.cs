using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSChoolgiaotrinh:ISChoolgiaotrinh
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSChoolgiaotrinh(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SchoolGiaoTrinh từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolGiaoTrinh]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SchoolGiaoTrinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolGiaoTrinh] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SchoolGiaoTrinh từ Database
		/// </summary>
		public List<SchoolGiaoTrinh> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolGiaoTrinh]");
				List<SchoolGiaoTrinh> items = new List<SchoolGiaoTrinh>();
				SchoolGiaoTrinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolGiaoTrinh();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaGiaoTrinh"] != null && dr["MaGiaoTrinh"] != DBNull.Value)
					{
						item.MaGiaoTrinh = Convert.ToString(dr["MaGiaoTrinh"]);
					}
					if (dr["TenGiaoTrinh"] != null && dr["TenGiaoTrinh"] != DBNull.Value)
					{
						item.TenGiaoTrinh = Convert.ToString(dr["TenGiaoTrinh"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToInt32(dr["DonGia"]);
					}
					if (dr["GiaBan"] != null && dr["GiaBan"] != DBNull.Value)
					{
						item.GiaBan = Convert.ToInt32(dr["GiaBan"]);
					}
					if (dr["HoaHongPercent"] != null && dr["HoaHongPercent"] != DBNull.Value)
					{
						item.HoaHongPercent = Convert.ToInt32(dr["HoaHongPercent"]);
					}
					if (dr["FK_HocPhan"] != null && dr["FK_HocPhan"] != DBNull.Value)
					{
						item.FK_HocPhan = Convert.ToString(dr["FK_HocPhan"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy danh sách SchoolGiaoTrinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SchoolGiaoTrinh> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolGiaoTrinh] A "+ condition,  parameters);
				List<SchoolGiaoTrinh> items = new List<SchoolGiaoTrinh>();
				SchoolGiaoTrinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolGiaoTrinh();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaGiaoTrinh"] != null && dr["MaGiaoTrinh"] != DBNull.Value)
					{
						item.MaGiaoTrinh = Convert.ToString(dr["MaGiaoTrinh"]);
					}
					if (dr["TenGiaoTrinh"] != null && dr["TenGiaoTrinh"] != DBNull.Value)
					{
						item.TenGiaoTrinh = Convert.ToString(dr["TenGiaoTrinh"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToInt32(dr["DonGia"]);
					}
					if (dr["GiaBan"] != null && dr["GiaBan"] != DBNull.Value)
					{
						item.GiaBan = Convert.ToInt32(dr["GiaBan"]);
					}
					if (dr["HoaHongPercent"] != null && dr["HoaHongPercent"] != DBNull.Value)
					{
						item.HoaHongPercent = Convert.ToInt32(dr["HoaHongPercent"]);
					}
					if (dr["FK_HocPhan"] != null && dr["FK_HocPhan"] != DBNull.Value)
					{
						item.FK_HocPhan = Convert.ToString(dr["FK_HocPhan"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public List<SchoolGiaoTrinh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolGiaoTrinh] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SchoolGiaoTrinh] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SchoolGiaoTrinh>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SchoolGiaoTrinh từ Database
		/// </summary>
		public SchoolGiaoTrinh GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolGiaoTrinh] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SchoolGiaoTrinh item=new SchoolGiaoTrinh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaGiaoTrinh"] != null && dr["MaGiaoTrinh"] != DBNull.Value)
						{
							item.MaGiaoTrinh = Convert.ToString(dr["MaGiaoTrinh"]);
						}
						if (dr["TenGiaoTrinh"] != null && dr["TenGiaoTrinh"] != DBNull.Value)
						{
							item.TenGiaoTrinh = Convert.ToString(dr["TenGiaoTrinh"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToInt32(dr["DonGia"]);
						}
						if (dr["GiaBan"] != null && dr["GiaBan"] != DBNull.Value)
						{
							item.GiaBan = Convert.ToInt32(dr["GiaBan"]);
						}
						if (dr["HoaHongPercent"] != null && dr["HoaHongPercent"] != DBNull.Value)
						{
							item.HoaHongPercent = Convert.ToInt32(dr["HoaHongPercent"]);
						}
						if (dr["FK_HocPhan"] != null && dr["FK_HocPhan"] != DBNull.Value)
						{
							item.FK_HocPhan = Convert.ToString(dr["FK_HocPhan"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy một SchoolGiaoTrinh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SchoolGiaoTrinh GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolGiaoTrinh] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SchoolGiaoTrinh item=new SchoolGiaoTrinh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaGiaoTrinh"] != null && dr["MaGiaoTrinh"] != DBNull.Value)
						{
							item.MaGiaoTrinh = Convert.ToString(dr["MaGiaoTrinh"]);
						}
						if (dr["TenGiaoTrinh"] != null && dr["TenGiaoTrinh"] != DBNull.Value)
						{
							item.TenGiaoTrinh = Convert.ToString(dr["TenGiaoTrinh"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToInt32(dr["DonGia"]);
						}
						if (dr["GiaBan"] != null && dr["GiaBan"] != DBNull.Value)
						{
							item.GiaBan = Convert.ToInt32(dr["GiaBan"]);
						}
						if (dr["HoaHongPercent"] != null && dr["HoaHongPercent"] != DBNull.Value)
						{
							item.HoaHongPercent = Convert.ToInt32(dr["HoaHongPercent"]);
						}
						if (dr["FK_HocPhan"] != null && dr["FK_HocPhan"] != DBNull.Value)
						{
							item.FK_HocPhan = Convert.ToString(dr["FK_HocPhan"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public SchoolGiaoTrinh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolGiaoTrinh] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SchoolGiaoTrinh>(ds);
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
		/// Thêm mới SchoolGiaoTrinh vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SchoolGiaoTrinh _SchoolGiaoTrinh)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SchoolGiaoTrinh](Id, MaGiaoTrinh, TenGiaoTrinh, DonGia, GiaBan, HoaHongPercent, FK_HocPhan, CreateBy, CreateDate) VALUES(@Id, @MaGiaoTrinh, @TenGiaoTrinh, @DonGia, @GiaBan, @HoaHongPercent, @FK_HocPhan, @CreateBy, @CreateDate)", 
					"@Id",  _SchoolGiaoTrinh.Id, 
					"@MaGiaoTrinh",  _SchoolGiaoTrinh.MaGiaoTrinh, 
					"@TenGiaoTrinh",  _SchoolGiaoTrinh.TenGiaoTrinh, 
					"@DonGia",  _SchoolGiaoTrinh.DonGia, 
					"@GiaBan",  _SchoolGiaoTrinh.GiaBan, 
					"@HoaHongPercent",  _SchoolGiaoTrinh.HoaHongPercent, 
					"@FK_HocPhan",  _SchoolGiaoTrinh.FK_HocPhan, 
					"@CreateBy",  _SchoolGiaoTrinh.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolGiaoTrinh.CreateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SchoolGiaoTrinh vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SchoolGiaoTrinh> _SchoolGiaoTrinhs)
		{
			foreach (SchoolGiaoTrinh item in _SchoolGiaoTrinhs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolGiaoTrinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SchoolGiaoTrinh _SchoolGiaoTrinh, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolGiaoTrinh] SET Id=@Id, MaGiaoTrinh=@MaGiaoTrinh, TenGiaoTrinh=@TenGiaoTrinh, DonGia=@DonGia, GiaBan=@GiaBan, HoaHongPercent=@HoaHongPercent, FK_HocPhan=@FK_HocPhan, CreateBy=@CreateBy, CreateDate=@CreateDate WHERE Id=@Id", 
					"@Id",  _SchoolGiaoTrinh.Id, 
					"@MaGiaoTrinh",  _SchoolGiaoTrinh.MaGiaoTrinh, 
					"@TenGiaoTrinh",  _SchoolGiaoTrinh.TenGiaoTrinh, 
					"@DonGia",  _SchoolGiaoTrinh.DonGia, 
					"@GiaBan",  _SchoolGiaoTrinh.GiaBan, 
					"@HoaHongPercent",  _SchoolGiaoTrinh.HoaHongPercent, 
					"@FK_HocPhan",  _SchoolGiaoTrinh.FK_HocPhan, 
					"@CreateBy",  _SchoolGiaoTrinh.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolGiaoTrinh.CreateDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SchoolGiaoTrinh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SchoolGiaoTrinh _SchoolGiaoTrinh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolGiaoTrinh] SET MaGiaoTrinh=@MaGiaoTrinh, TenGiaoTrinh=@TenGiaoTrinh, DonGia=@DonGia, GiaBan=@GiaBan, HoaHongPercent=@HoaHongPercent, FK_HocPhan=@FK_HocPhan, CreateBy=@CreateBy, CreateDate=@CreateDate WHERE Id=@Id", 
					"@MaGiaoTrinh",  _SchoolGiaoTrinh.MaGiaoTrinh, 
					"@TenGiaoTrinh",  _SchoolGiaoTrinh.TenGiaoTrinh, 
					"@DonGia",  _SchoolGiaoTrinh.DonGia, 
					"@GiaBan",  _SchoolGiaoTrinh.GiaBan, 
					"@HoaHongPercent",  _SchoolGiaoTrinh.HoaHongPercent, 
					"@FK_HocPhan",  _SchoolGiaoTrinh.FK_HocPhan, 
					"@CreateBy",  _SchoolGiaoTrinh.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolGiaoTrinh.CreateDate), 
					"@Id", _SchoolGiaoTrinh.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SchoolGiaoTrinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SchoolGiaoTrinh> _SchoolGiaoTrinhs)
		{
			foreach (SchoolGiaoTrinh item in _SchoolGiaoTrinhs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolGiaoTrinh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SchoolGiaoTrinh _SchoolGiaoTrinh, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolGiaoTrinh] SET Id=@Id, MaGiaoTrinh=@MaGiaoTrinh, TenGiaoTrinh=@TenGiaoTrinh, DonGia=@DonGia, GiaBan=@GiaBan, HoaHongPercent=@HoaHongPercent, FK_HocPhan=@FK_HocPhan, CreateBy=@CreateBy, CreateDate=@CreateDate "+ condition, 
					"@Id",  _SchoolGiaoTrinh.Id, 
					"@MaGiaoTrinh",  _SchoolGiaoTrinh.MaGiaoTrinh, 
					"@TenGiaoTrinh",  _SchoolGiaoTrinh.TenGiaoTrinh, 
					"@DonGia",  _SchoolGiaoTrinh.DonGia, 
					"@GiaBan",  _SchoolGiaoTrinh.GiaBan, 
					"@HoaHongPercent",  _SchoolGiaoTrinh.HoaHongPercent, 
					"@FK_HocPhan",  _SchoolGiaoTrinh.FK_HocPhan, 
					"@CreateBy",  _SchoolGiaoTrinh.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolGiaoTrinh.CreateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SchoolGiaoTrinh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolGiaoTrinh] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolGiaoTrinh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SchoolGiaoTrinh _SchoolGiaoTrinh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolGiaoTrinh] WHERE Id=@Id",
					"@Id", _SchoolGiaoTrinh.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolGiaoTrinh trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolGiaoTrinh] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolGiaoTrinh trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SchoolGiaoTrinh> _SchoolGiaoTrinhs)
		{
			foreach (SchoolGiaoTrinh item in _SchoolGiaoTrinhs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
