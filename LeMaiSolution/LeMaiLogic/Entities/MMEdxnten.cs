using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdxnten:IMEdxnten
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdxnten(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedXNTen từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNTen]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedXNTen từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNTen] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedXNTen từ Database
		/// </summary>
		public List<MedXNTen> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNTen]");
				List<MedXNTen> items = new List<MedXNTen>();
				MedXNTen item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedXNTen();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["loai"] != null && dr["loai"] != DBNull.Value)
					{
						item.loai = Convert.ToInt32(dr["loai"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
					}
					if (dr["donvi"] != null && dr["donvi"] != DBNull.Value)
					{
						item.donvi = Convert.ToInt32(dr["donvi"]);
					}
					if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
					{
						item.viettat = Convert.ToString(dr["viettat"]);
					}
					if (dr["minnu"] != null && dr["minnu"] != DBNull.Value)
					{
						item.minnu = Convert.ToString(dr["minnu"]);
					}
					if (dr["nu"] != null && dr["nu"] != DBNull.Value)
					{
						item.nu = Convert.ToString(dr["nu"]);
					}
					if (dr["maxnu"] != null && dr["maxnu"] != DBNull.Value)
					{
						item.maxnu = Convert.ToString(dr["maxnu"]);
					}
					if (dr["minnam"] != null && dr["minnam"] != DBNull.Value)
					{
						item.minnam = Convert.ToString(dr["minnam"]);
					}
					if (dr["nam"] != null && dr["nam"] != DBNull.Value)
					{
						item.nam = Convert.ToString(dr["nam"]);
					}
					if (dr["maxnam"] != null && dr["maxnam"] != DBNull.Value)
					{
						item.maxnam = Convert.ToString(dr["maxnam"]);
					}
					if (dr["state"] != null && dr["state"] != DBNull.Value)
					{
						item.state = Convert.ToBoolean(dr["state"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
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
		/// Lấy danh sách MedXNTen từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedXNTen> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedXNTen] A "+ condition,  parameters);
				List<MedXNTen> items = new List<MedXNTen>();
				MedXNTen item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedXNTen();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["loai"] != null && dr["loai"] != DBNull.Value)
					{
						item.loai = Convert.ToInt32(dr["loai"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
					}
					if (dr["donvi"] != null && dr["donvi"] != DBNull.Value)
					{
						item.donvi = Convert.ToInt32(dr["donvi"]);
					}
					if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
					{
						item.viettat = Convert.ToString(dr["viettat"]);
					}
					if (dr["minnu"] != null && dr["minnu"] != DBNull.Value)
					{
						item.minnu = Convert.ToString(dr["minnu"]);
					}
					if (dr["nu"] != null && dr["nu"] != DBNull.Value)
					{
						item.nu = Convert.ToString(dr["nu"]);
					}
					if (dr["maxnu"] != null && dr["maxnu"] != DBNull.Value)
					{
						item.maxnu = Convert.ToString(dr["maxnu"]);
					}
					if (dr["minnam"] != null && dr["minnam"] != DBNull.Value)
					{
						item.minnam = Convert.ToString(dr["minnam"]);
					}
					if (dr["nam"] != null && dr["nam"] != DBNull.Value)
					{
						item.nam = Convert.ToString(dr["nam"]);
					}
					if (dr["maxnam"] != null && dr["maxnam"] != DBNull.Value)
					{
						item.maxnam = Convert.ToString(dr["maxnam"]);
					}
					if (dr["state"] != null && dr["state"] != DBNull.Value)
					{
						item.state = Convert.ToBoolean(dr["state"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
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

		public List<MedXNTen> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedXNTen] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedXNTen] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedXNTen>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedXNTen từ Database
		/// </summary>
		public MedXNTen GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNTen] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedXNTen item=new MedXNTen();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["loai"] != null && dr["loai"] != DBNull.Value)
						{
							item.loai = Convert.ToInt32(dr["loai"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
						}
						if (dr["donvi"] != null && dr["donvi"] != DBNull.Value)
						{
							item.donvi = Convert.ToInt32(dr["donvi"]);
						}
						if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
						{
							item.viettat = Convert.ToString(dr["viettat"]);
						}
						if (dr["minnu"] != null && dr["minnu"] != DBNull.Value)
						{
							item.minnu = Convert.ToString(dr["minnu"]);
						}
						if (dr["nu"] != null && dr["nu"] != DBNull.Value)
						{
							item.nu = Convert.ToString(dr["nu"]);
						}
						if (dr["maxnu"] != null && dr["maxnu"] != DBNull.Value)
						{
							item.maxnu = Convert.ToString(dr["maxnu"]);
						}
						if (dr["minnam"] != null && dr["minnam"] != DBNull.Value)
						{
							item.minnam = Convert.ToString(dr["minnam"]);
						}
						if (dr["nam"] != null && dr["nam"] != DBNull.Value)
						{
							item.nam = Convert.ToString(dr["nam"]);
						}
						if (dr["maxnam"] != null && dr["maxnam"] != DBNull.Value)
						{
							item.maxnam = Convert.ToString(dr["maxnam"]);
						}
						if (dr["state"] != null && dr["state"] != DBNull.Value)
						{
							item.state = Convert.ToBoolean(dr["state"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
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
		/// Lấy một MedXNTen đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedXNTen GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedXNTen] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedXNTen item=new MedXNTen();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["loai"] != null && dr["loai"] != DBNull.Value)
						{
							item.loai = Convert.ToInt32(dr["loai"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
						}
						if (dr["donvi"] != null && dr["donvi"] != DBNull.Value)
						{
							item.donvi = Convert.ToInt32(dr["donvi"]);
						}
						if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
						{
							item.viettat = Convert.ToString(dr["viettat"]);
						}
						if (dr["minnu"] != null && dr["minnu"] != DBNull.Value)
						{
							item.minnu = Convert.ToString(dr["minnu"]);
						}
						if (dr["nu"] != null && dr["nu"] != DBNull.Value)
						{
							item.nu = Convert.ToString(dr["nu"]);
						}
						if (dr["maxnu"] != null && dr["maxnu"] != DBNull.Value)
						{
							item.maxnu = Convert.ToString(dr["maxnu"]);
						}
						if (dr["minnam"] != null && dr["minnam"] != DBNull.Value)
						{
							item.minnam = Convert.ToString(dr["minnam"]);
						}
						if (dr["nam"] != null && dr["nam"] != DBNull.Value)
						{
							item.nam = Convert.ToString(dr["nam"]);
						}
						if (dr["maxnam"] != null && dr["maxnam"] != DBNull.Value)
						{
							item.maxnam = Convert.ToString(dr["maxnam"]);
						}
						if (dr["state"] != null && dr["state"] != DBNull.Value)
						{
							item.state = Convert.ToBoolean(dr["state"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
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

		public MedXNTen GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedXNTen] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedXNTen>(ds);
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
		/// Thêm mới MedXNTen vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedXNTen _MedXNTen)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedXNTen](id, loai, stt, ma, ten, donvi, viettat, minnu, nu, maxnu, minnam, nam, maxnam, state, ghichu) VALUES(@id, @loai, @stt, @ma, @ten, @donvi, @viettat, @minnu, @nu, @maxnu, @minnam, @nam, @maxnam, @state, @ghichu)", 
					"@id",  _MedXNTen.id, 
					"@loai",  _MedXNTen.loai, 
					"@stt",  _MedXNTen.stt, 
					"@ma",  _MedXNTen.ma, 
					"@ten",  _MedXNTen.ten, 
					"@donvi",  _MedXNTen.donvi, 
					"@viettat",  _MedXNTen.viettat, 
					"@minnu",  _MedXNTen.minnu, 
					"@nu",  _MedXNTen.nu, 
					"@maxnu",  _MedXNTen.maxnu, 
					"@minnam",  _MedXNTen.minnam, 
					"@nam",  _MedXNTen.nam, 
					"@maxnam",  _MedXNTen.maxnam, 
					"@state",  _MedXNTen.state, 
					"@ghichu",  _MedXNTen.ghichu);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedXNTen vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedXNTen> _MedXNTens)
		{
			foreach (MedXNTen item in _MedXNTens)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedXNTen vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedXNTen _MedXNTen, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNTen] SET id=@id, loai=@loai, stt=@stt, ma=@ma, ten=@ten, donvi=@donvi, viettat=@viettat, minnu=@minnu, nu=@nu, maxnu=@maxnu, minnam=@minnam, nam=@nam, maxnam=@maxnam, state=@state, ghichu=@ghichu WHERE id=@id", 
					"@id",  _MedXNTen.id, 
					"@loai",  _MedXNTen.loai, 
					"@stt",  _MedXNTen.stt, 
					"@ma",  _MedXNTen.ma, 
					"@ten",  _MedXNTen.ten, 
					"@donvi",  _MedXNTen.donvi, 
					"@viettat",  _MedXNTen.viettat, 
					"@minnu",  _MedXNTen.minnu, 
					"@nu",  _MedXNTen.nu, 
					"@maxnu",  _MedXNTen.maxnu, 
					"@minnam",  _MedXNTen.minnam, 
					"@nam",  _MedXNTen.nam, 
					"@maxnam",  _MedXNTen.maxnam, 
					"@state",  _MedXNTen.state, 
					"@ghichu",  _MedXNTen.ghichu, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedXNTen vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedXNTen _MedXNTen)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNTen] SET loai=@loai, stt=@stt, ma=@ma, ten=@ten, donvi=@donvi, viettat=@viettat, minnu=@minnu, nu=@nu, maxnu=@maxnu, minnam=@minnam, nam=@nam, maxnam=@maxnam, state=@state, ghichu=@ghichu WHERE id=@id", 
					"@loai",  _MedXNTen.loai, 
					"@stt",  _MedXNTen.stt, 
					"@ma",  _MedXNTen.ma, 
					"@ten",  _MedXNTen.ten, 
					"@donvi",  _MedXNTen.donvi, 
					"@viettat",  _MedXNTen.viettat, 
					"@minnu",  _MedXNTen.minnu, 
					"@nu",  _MedXNTen.nu, 
					"@maxnu",  _MedXNTen.maxnu, 
					"@minnam",  _MedXNTen.minnam, 
					"@nam",  _MedXNTen.nam, 
					"@maxnam",  _MedXNTen.maxnam, 
					"@state",  _MedXNTen.state, 
					"@ghichu",  _MedXNTen.ghichu, 
					"@id", _MedXNTen.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedXNTen vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedXNTen> _MedXNTens)
		{
			foreach (MedXNTen item in _MedXNTens)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedXNTen vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedXNTen _MedXNTen, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNTen] SET id=@id, loai=@loai, stt=@stt, ma=@ma, ten=@ten, donvi=@donvi, viettat=@viettat, minnu=@minnu, nu=@nu, maxnu=@maxnu, minnam=@minnam, nam=@nam, maxnam=@maxnam, state=@state, ghichu=@ghichu "+ condition, 
					"@id",  _MedXNTen.id, 
					"@loai",  _MedXNTen.loai, 
					"@stt",  _MedXNTen.stt, 
					"@ma",  _MedXNTen.ma, 
					"@ten",  _MedXNTen.ten, 
					"@donvi",  _MedXNTen.donvi, 
					"@viettat",  _MedXNTen.viettat, 
					"@minnu",  _MedXNTen.minnu, 
					"@nu",  _MedXNTen.nu, 
					"@maxnu",  _MedXNTen.maxnu, 
					"@minnam",  _MedXNTen.minnam, 
					"@nam",  _MedXNTen.nam, 
					"@maxnam",  _MedXNTen.maxnam, 
					"@state",  _MedXNTen.state, 
					"@ghichu",  _MedXNTen.ghichu);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedXNTen trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNTen] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNTen trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedXNTen _MedXNTen)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNTen] WHERE id=@id",
					"@id", _MedXNTen.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNTen trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNTen] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNTen trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedXNTen> _MedXNTens)
		{
			foreach (MedXNTen item in _MedXNTens)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
