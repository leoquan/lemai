using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdloaikhoaphong:IMEdloaikhoaphong
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdloaikhoaphong(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedLoaiKhoaPhong từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLoaiKhoaPhong]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedLoaiKhoaPhong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLoaiKhoaPhong] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedLoaiKhoaPhong từ Database
		/// </summary>
		public List<MedLoaiKhoaPhong> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLoaiKhoaPhong]");
				List<MedLoaiKhoaPhong> items = new List<MedLoaiKhoaPhong>();
				MedLoaiKhoaPhong item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedLoaiKhoaPhong();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["tenloai"] != null && dr["tenloai"] != DBNull.Value)
					{
						item.tenloai = Convert.ToString(dr["tenloai"]);
					}
					if (dr["sudungauto"] != null && dr["sudungauto"] != DBNull.Value)
					{
						item.sudungauto = Convert.ToBoolean(dr["sudungauto"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
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
		/// Lấy danh sách MedLoaiKhoaPhong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedLoaiKhoaPhong> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedLoaiKhoaPhong] A "+ condition,  parameters);
				List<MedLoaiKhoaPhong> items = new List<MedLoaiKhoaPhong>();
				MedLoaiKhoaPhong item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedLoaiKhoaPhong();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["tenloai"] != null && dr["tenloai"] != DBNull.Value)
					{
						item.tenloai = Convert.ToString(dr["tenloai"]);
					}
					if (dr["sudungauto"] != null && dr["sudungauto"] != DBNull.Value)
					{
						item.sudungauto = Convert.ToBoolean(dr["sudungauto"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
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

		public List<MedLoaiKhoaPhong> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedLoaiKhoaPhong] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedLoaiKhoaPhong] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedLoaiKhoaPhong>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedLoaiKhoaPhong từ Database
		/// </summary>
		public MedLoaiKhoaPhong GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLoaiKhoaPhong] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedLoaiKhoaPhong item=new MedLoaiKhoaPhong();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["tenloai"] != null && dr["tenloai"] != DBNull.Value)
						{
							item.tenloai = Convert.ToString(dr["tenloai"]);
						}
						if (dr["sudungauto"] != null && dr["sudungauto"] != DBNull.Value)
						{
							item.sudungauto = Convert.ToBoolean(dr["sudungauto"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
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
		/// Lấy một MedLoaiKhoaPhong đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedLoaiKhoaPhong GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedLoaiKhoaPhong] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedLoaiKhoaPhong item=new MedLoaiKhoaPhong();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["tenloai"] != null && dr["tenloai"] != DBNull.Value)
						{
							item.tenloai = Convert.ToString(dr["tenloai"]);
						}
						if (dr["sudungauto"] != null && dr["sudungauto"] != DBNull.Value)
						{
							item.sudungauto = Convert.ToBoolean(dr["sudungauto"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
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

		public MedLoaiKhoaPhong GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedLoaiKhoaPhong] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedLoaiKhoaPhong>(ds);
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
		/// Thêm mới MedLoaiKhoaPhong vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedLoaiKhoaPhong _MedLoaiKhoaPhong)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedLoaiKhoaPhong](id, tenloai, sudungauto, nguoitao, ngaytao) VALUES(@id, @tenloai, @sudungauto, @nguoitao, @ngaytao)", 
					"@id",  _MedLoaiKhoaPhong.id, 
					"@tenloai",  _MedLoaiKhoaPhong.tenloai, 
					"@sudungauto",  _MedLoaiKhoaPhong.sudungauto, 
					"@nguoitao",  _MedLoaiKhoaPhong.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedLoaiKhoaPhong.ngaytao));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedLoaiKhoaPhong vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedLoaiKhoaPhong> _MedLoaiKhoaPhongs)
		{
			foreach (MedLoaiKhoaPhong item in _MedLoaiKhoaPhongs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedLoaiKhoaPhong vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedLoaiKhoaPhong _MedLoaiKhoaPhong, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLoaiKhoaPhong] SET id=@id, tenloai=@tenloai, sudungauto=@sudungauto, nguoitao=@nguoitao, ngaytao=@ngaytao WHERE id=@id", 
					"@id",  _MedLoaiKhoaPhong.id, 
					"@tenloai",  _MedLoaiKhoaPhong.tenloai, 
					"@sudungauto",  _MedLoaiKhoaPhong.sudungauto, 
					"@nguoitao",  _MedLoaiKhoaPhong.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedLoaiKhoaPhong.ngaytao), 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedLoaiKhoaPhong vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedLoaiKhoaPhong _MedLoaiKhoaPhong)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLoaiKhoaPhong] SET tenloai=@tenloai, sudungauto=@sudungauto, nguoitao=@nguoitao, ngaytao=@ngaytao WHERE id=@id", 
					"@tenloai",  _MedLoaiKhoaPhong.tenloai, 
					"@sudungauto",  _MedLoaiKhoaPhong.sudungauto, 
					"@nguoitao",  _MedLoaiKhoaPhong.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedLoaiKhoaPhong.ngaytao), 
					"@id", _MedLoaiKhoaPhong.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedLoaiKhoaPhong vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedLoaiKhoaPhong> _MedLoaiKhoaPhongs)
		{
			foreach (MedLoaiKhoaPhong item in _MedLoaiKhoaPhongs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedLoaiKhoaPhong vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedLoaiKhoaPhong _MedLoaiKhoaPhong, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLoaiKhoaPhong] SET id=@id, tenloai=@tenloai, sudungauto=@sudungauto, nguoitao=@nguoitao, ngaytao=@ngaytao "+ condition, 
					"@id",  _MedLoaiKhoaPhong.id, 
					"@tenloai",  _MedLoaiKhoaPhong.tenloai, 
					"@sudungauto",  _MedLoaiKhoaPhong.sudungauto, 
					"@nguoitao",  _MedLoaiKhoaPhong.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedLoaiKhoaPhong.ngaytao));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedLoaiKhoaPhong trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLoaiKhoaPhong] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLoaiKhoaPhong trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedLoaiKhoaPhong _MedLoaiKhoaPhong)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLoaiKhoaPhong] WHERE id=@id",
					"@id", _MedLoaiKhoaPhong.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLoaiKhoaPhong trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLoaiKhoaPhong] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLoaiKhoaPhong trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedLoaiKhoaPhong> _MedLoaiKhoaPhongs)
		{
			foreach (MedLoaiKhoaPhong item in _MedLoaiKhoaPhongs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
