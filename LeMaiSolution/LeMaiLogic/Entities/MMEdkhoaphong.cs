using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdkhoaphong:IMEdkhoaphong
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdkhoaphong(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKhoaPhong từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKhoaPhong]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKhoaPhong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKhoaPhong] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKhoaPhong từ Database
		/// </summary>
		public List<MedKhoaPhong> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKhoaPhong]");
				List<MedKhoaPhong> items = new List<MedKhoaPhong>();
				MedKhoaPhong item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKhoaPhong();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["tenkhoaphong"] != null && dr["tenkhoaphong"] != DBNull.Value)
					{
						item.tenkhoaphong = Convert.ToString(dr["tenkhoaphong"]);
					}
					if (dr["id_coso"] != null && dr["id_coso"] != DBNull.Value)
					{
						item.id_coso = Convert.ToString(dr["id_coso"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
					}
					if (dr["id_loaikhoaphong"] != null && dr["id_loaikhoaphong"] != DBNull.Value)
					{
						item.id_loaikhoaphong = Convert.ToString(dr["id_loaikhoaphong"]);
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
		/// Lấy danh sách MedKhoaPhong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKhoaPhong> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKhoaPhong] A "+ condition,  parameters);
				List<MedKhoaPhong> items = new List<MedKhoaPhong>();
				MedKhoaPhong item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKhoaPhong();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["tenkhoaphong"] != null && dr["tenkhoaphong"] != DBNull.Value)
					{
						item.tenkhoaphong = Convert.ToString(dr["tenkhoaphong"]);
					}
					if (dr["id_coso"] != null && dr["id_coso"] != DBNull.Value)
					{
						item.id_coso = Convert.ToString(dr["id_coso"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
					}
					if (dr["id_loaikhoaphong"] != null && dr["id_loaikhoaphong"] != DBNull.Value)
					{
						item.id_loaikhoaphong = Convert.ToString(dr["id_loaikhoaphong"]);
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

		public List<MedKhoaPhong> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKhoaPhong] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKhoaPhong] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKhoaPhong>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKhoaPhong từ Database
		/// </summary>
		public MedKhoaPhong GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKhoaPhong] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedKhoaPhong item=new MedKhoaPhong();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["tenkhoaphong"] != null && dr["tenkhoaphong"] != DBNull.Value)
						{
							item.tenkhoaphong = Convert.ToString(dr["tenkhoaphong"]);
						}
						if (dr["id_coso"] != null && dr["id_coso"] != DBNull.Value)
						{
							item.id_coso = Convert.ToString(dr["id_coso"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
						}
						if (dr["id_loaikhoaphong"] != null && dr["id_loaikhoaphong"] != DBNull.Value)
						{
							item.id_loaikhoaphong = Convert.ToString(dr["id_loaikhoaphong"]);
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
		/// Lấy một MedKhoaPhong đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKhoaPhong GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKhoaPhong] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKhoaPhong item=new MedKhoaPhong();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["tenkhoaphong"] != null && dr["tenkhoaphong"] != DBNull.Value)
						{
							item.tenkhoaphong = Convert.ToString(dr["tenkhoaphong"]);
						}
						if (dr["id_coso"] != null && dr["id_coso"] != DBNull.Value)
						{
							item.id_coso = Convert.ToString(dr["id_coso"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
						}
						if (dr["id_loaikhoaphong"] != null && dr["id_loaikhoaphong"] != DBNull.Value)
						{
							item.id_loaikhoaphong = Convert.ToString(dr["id_loaikhoaphong"]);
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

		public MedKhoaPhong GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKhoaPhong] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKhoaPhong>(ds);
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
		/// Thêm mới MedKhoaPhong vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKhoaPhong _MedKhoaPhong)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKhoaPhong](id, ma, tenkhoaphong, id_coso, nguoitao, ngaytao, id_loaikhoaphong) VALUES(@id, @ma, @tenkhoaphong, @id_coso, @nguoitao, @ngaytao, @id_loaikhoaphong)", 
					"@id",  _MedKhoaPhong.id, 
					"@ma",  _MedKhoaPhong.ma, 
					"@tenkhoaphong",  _MedKhoaPhong.tenkhoaphong, 
					"@id_coso",  _MedKhoaPhong.id_coso, 
					"@nguoitao",  _MedKhoaPhong.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedKhoaPhong.ngaytao), 
					"@id_loaikhoaphong",  _MedKhoaPhong.id_loaikhoaphong);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKhoaPhong vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKhoaPhong> _MedKhoaPhongs)
		{
			foreach (MedKhoaPhong item in _MedKhoaPhongs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKhoaPhong vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKhoaPhong _MedKhoaPhong, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKhoaPhong] SET id=@id, ma=@ma, tenkhoaphong=@tenkhoaphong, id_coso=@id_coso, nguoitao=@nguoitao, ngaytao=@ngaytao, id_loaikhoaphong=@id_loaikhoaphong WHERE id=@id", 
					"@id",  _MedKhoaPhong.id, 
					"@ma",  _MedKhoaPhong.ma, 
					"@tenkhoaphong",  _MedKhoaPhong.tenkhoaphong, 
					"@id_coso",  _MedKhoaPhong.id_coso, 
					"@nguoitao",  _MedKhoaPhong.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedKhoaPhong.ngaytao), 
					"@id_loaikhoaphong",  _MedKhoaPhong.id_loaikhoaphong, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKhoaPhong vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKhoaPhong _MedKhoaPhong)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKhoaPhong] SET ma=@ma, tenkhoaphong=@tenkhoaphong, id_coso=@id_coso, nguoitao=@nguoitao, ngaytao=@ngaytao, id_loaikhoaphong=@id_loaikhoaphong WHERE id=@id", 
					"@ma",  _MedKhoaPhong.ma, 
					"@tenkhoaphong",  _MedKhoaPhong.tenkhoaphong, 
					"@id_coso",  _MedKhoaPhong.id_coso, 
					"@nguoitao",  _MedKhoaPhong.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedKhoaPhong.ngaytao), 
					"@id_loaikhoaphong",  _MedKhoaPhong.id_loaikhoaphong, 
					"@id", _MedKhoaPhong.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKhoaPhong vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKhoaPhong> _MedKhoaPhongs)
		{
			foreach (MedKhoaPhong item in _MedKhoaPhongs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKhoaPhong vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKhoaPhong _MedKhoaPhong, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKhoaPhong] SET id=@id, ma=@ma, tenkhoaphong=@tenkhoaphong, id_coso=@id_coso, nguoitao=@nguoitao, ngaytao=@ngaytao, id_loaikhoaphong=@id_loaikhoaphong "+ condition, 
					"@id",  _MedKhoaPhong.id, 
					"@ma",  _MedKhoaPhong.ma, 
					"@tenkhoaphong",  _MedKhoaPhong.tenkhoaphong, 
					"@id_coso",  _MedKhoaPhong.id_coso, 
					"@nguoitao",  _MedKhoaPhong.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedKhoaPhong.ngaytao), 
					"@id_loaikhoaphong",  _MedKhoaPhong.id_loaikhoaphong);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKhoaPhong trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKhoaPhong] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKhoaPhong trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKhoaPhong _MedKhoaPhong)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKhoaPhong] WHERE id=@id",
					"@id", _MedKhoaPhong.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKhoaPhong trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKhoaPhong] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKhoaPhong trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKhoaPhong> _MedKhoaPhongs)
		{
			foreach (MedKhoaPhong item in _MedKhoaPhongs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
