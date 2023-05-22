using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdthongsokqmayxn:IMEdthongsokqmayxn
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdthongsokqmayxn(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedThongSoKQMayXN từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedThongSoKQMayXN]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedThongSoKQMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedThongSoKQMayXN] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedThongSoKQMayXN từ Database
		/// </summary>
		public List<MedThongSoKQMayXN> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedThongSoKQMayXN]");
				List<MedThongSoKQMayXN> items = new List<MedThongSoKQMayXN>();
				MedThongSoKQMayXN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedThongSoKQMayXN();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
					{
						item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
					}
					if (dr["makqmay"] != null && dr["makqmay"] != DBNull.Value)
					{
						item.makqmay = Convert.ToString(dr["makqmay"]);
					}
					if (dr["tenkqmay"] != null && dr["tenkqmay"] != DBNull.Value)
					{
						item.tenkqmay = Convert.ToString(dr["tenkqmay"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["isreadonly"] != null && dr["isreadonly"] != DBNull.Value)
					{
						item.isreadonly = Convert.ToDecimal(dr["isreadonly"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["heso"] != null && dr["heso"] != DBNull.Value)
					{
						item.heso = Convert.ToDecimal(dr["heso"]);
					}
					if (dr["morong"] != null && dr["morong"] != DBNull.Value)
					{
						item.morong = Convert.ToDecimal(dr["morong"]);
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
		/// Lấy danh sách MedThongSoKQMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedThongSoKQMayXN> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedThongSoKQMayXN] A "+ condition,  parameters);
				List<MedThongSoKQMayXN> items = new List<MedThongSoKQMayXN>();
				MedThongSoKQMayXN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedThongSoKQMayXN();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
					{
						item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
					}
					if (dr["makqmay"] != null && dr["makqmay"] != DBNull.Value)
					{
						item.makqmay = Convert.ToString(dr["makqmay"]);
					}
					if (dr["tenkqmay"] != null && dr["tenkqmay"] != DBNull.Value)
					{
						item.tenkqmay = Convert.ToString(dr["tenkqmay"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["isreadonly"] != null && dr["isreadonly"] != DBNull.Value)
					{
						item.isreadonly = Convert.ToDecimal(dr["isreadonly"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["heso"] != null && dr["heso"] != DBNull.Value)
					{
						item.heso = Convert.ToDecimal(dr["heso"]);
					}
					if (dr["morong"] != null && dr["morong"] != DBNull.Value)
					{
						item.morong = Convert.ToDecimal(dr["morong"]);
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

		public List<MedThongSoKQMayXN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedThongSoKQMayXN] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedThongSoKQMayXN] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedThongSoKQMayXN>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedThongSoKQMayXN từ Database
		/// </summary>
		public MedThongSoKQMayXN GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedThongSoKQMayXN] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedThongSoKQMayXN item=new MedThongSoKQMayXN();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
						{
							item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
						}
						if (dr["makqmay"] != null && dr["makqmay"] != DBNull.Value)
						{
							item.makqmay = Convert.ToString(dr["makqmay"]);
						}
						if (dr["tenkqmay"] != null && dr["tenkqmay"] != DBNull.Value)
						{
							item.tenkqmay = Convert.ToString(dr["tenkqmay"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["isreadonly"] != null && dr["isreadonly"] != DBNull.Value)
						{
							item.isreadonly = Convert.ToDecimal(dr["isreadonly"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["heso"] != null && dr["heso"] != DBNull.Value)
						{
							item.heso = Convert.ToDecimal(dr["heso"]);
						}
						if (dr["morong"] != null && dr["morong"] != DBNull.Value)
						{
							item.morong = Convert.ToDecimal(dr["morong"]);
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
		/// Lấy một MedThongSoKQMayXN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedThongSoKQMayXN GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedThongSoKQMayXN] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedThongSoKQMayXN item=new MedThongSoKQMayXN();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
						{
							item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
						}
						if (dr["makqmay"] != null && dr["makqmay"] != DBNull.Value)
						{
							item.makqmay = Convert.ToString(dr["makqmay"]);
						}
						if (dr["tenkqmay"] != null && dr["tenkqmay"] != DBNull.Value)
						{
							item.tenkqmay = Convert.ToString(dr["tenkqmay"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["isreadonly"] != null && dr["isreadonly"] != DBNull.Value)
						{
							item.isreadonly = Convert.ToDecimal(dr["isreadonly"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["heso"] != null && dr["heso"] != DBNull.Value)
						{
							item.heso = Convert.ToDecimal(dr["heso"]);
						}
						if (dr["morong"] != null && dr["morong"] != DBNull.Value)
						{
							item.morong = Convert.ToDecimal(dr["morong"]);
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

		public MedThongSoKQMayXN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedThongSoKQMayXN] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedThongSoKQMayXN>(ds);
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
		/// Thêm mới MedThongSoKQMayXN vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedThongSoKQMayXN _MedThongSoKQMayXN)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedThongSoKQMayXN](id, stt, id_mayxn, makqmay, tenkqmay, ghichu, isreadonly, userid, ngayud, heso, morong) VALUES(@id, @stt, @id_mayxn, @makqmay, @tenkqmay, @ghichu, @isreadonly, @userid, @ngayud, @heso, @morong)", 
					"@id",  _MedThongSoKQMayXN.id, 
					"@stt",  _MedThongSoKQMayXN.stt, 
					"@id_mayxn",  _MedThongSoKQMayXN.id_mayxn, 
					"@makqmay",  _MedThongSoKQMayXN.makqmay, 
					"@tenkqmay",  _MedThongSoKQMayXN.tenkqmay, 
					"@ghichu",  _MedThongSoKQMayXN.ghichu, 
					"@isreadonly",  _MedThongSoKQMayXN.isreadonly, 
					"@userid",  _MedThongSoKQMayXN.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedThongSoKQMayXN.ngayud), 
					"@heso",  _MedThongSoKQMayXN.heso, 
					"@morong",  _MedThongSoKQMayXN.morong);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedThongSoKQMayXN vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedThongSoKQMayXN> _MedThongSoKQMayXNs)
		{
			foreach (MedThongSoKQMayXN item in _MedThongSoKQMayXNs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedThongSoKQMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedThongSoKQMayXN _MedThongSoKQMayXN, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedThongSoKQMayXN] SET id=@id, stt=@stt, id_mayxn=@id_mayxn, makqmay=@makqmay, tenkqmay=@tenkqmay, ghichu=@ghichu, isreadonly=@isreadonly, userid=@userid, ngayud=@ngayud, heso=@heso, morong=@morong WHERE id=@id", 
					"@id",  _MedThongSoKQMayXN.id, 
					"@stt",  _MedThongSoKQMayXN.stt, 
					"@id_mayxn",  _MedThongSoKQMayXN.id_mayxn, 
					"@makqmay",  _MedThongSoKQMayXN.makqmay, 
					"@tenkqmay",  _MedThongSoKQMayXN.tenkqmay, 
					"@ghichu",  _MedThongSoKQMayXN.ghichu, 
					"@isreadonly",  _MedThongSoKQMayXN.isreadonly, 
					"@userid",  _MedThongSoKQMayXN.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedThongSoKQMayXN.ngayud), 
					"@heso",  _MedThongSoKQMayXN.heso, 
					"@morong",  _MedThongSoKQMayXN.morong, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedThongSoKQMayXN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedThongSoKQMayXN _MedThongSoKQMayXN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedThongSoKQMayXN] SET stt=@stt, id_mayxn=@id_mayxn, makqmay=@makqmay, tenkqmay=@tenkqmay, ghichu=@ghichu, isreadonly=@isreadonly, userid=@userid, ngayud=@ngayud, heso=@heso, morong=@morong WHERE id=@id", 
					"@stt",  _MedThongSoKQMayXN.stt, 
					"@id_mayxn",  _MedThongSoKQMayXN.id_mayxn, 
					"@makqmay",  _MedThongSoKQMayXN.makqmay, 
					"@tenkqmay",  _MedThongSoKQMayXN.tenkqmay, 
					"@ghichu",  _MedThongSoKQMayXN.ghichu, 
					"@isreadonly",  _MedThongSoKQMayXN.isreadonly, 
					"@userid",  _MedThongSoKQMayXN.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedThongSoKQMayXN.ngayud), 
					"@heso",  _MedThongSoKQMayXN.heso, 
					"@morong",  _MedThongSoKQMayXN.morong, 
					"@id", _MedThongSoKQMayXN.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedThongSoKQMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedThongSoKQMayXN> _MedThongSoKQMayXNs)
		{
			foreach (MedThongSoKQMayXN item in _MedThongSoKQMayXNs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedThongSoKQMayXN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedThongSoKQMayXN _MedThongSoKQMayXN, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedThongSoKQMayXN] SET id=@id, stt=@stt, id_mayxn=@id_mayxn, makqmay=@makqmay, tenkqmay=@tenkqmay, ghichu=@ghichu, isreadonly=@isreadonly, userid=@userid, ngayud=@ngayud, heso=@heso, morong=@morong "+ condition, 
					"@id",  _MedThongSoKQMayXN.id, 
					"@stt",  _MedThongSoKQMayXN.stt, 
					"@id_mayxn",  _MedThongSoKQMayXN.id_mayxn, 
					"@makqmay",  _MedThongSoKQMayXN.makqmay, 
					"@tenkqmay",  _MedThongSoKQMayXN.tenkqmay, 
					"@ghichu",  _MedThongSoKQMayXN.ghichu, 
					"@isreadonly",  _MedThongSoKQMayXN.isreadonly, 
					"@userid",  _MedThongSoKQMayXN.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedThongSoKQMayXN.ngayud), 
					"@heso",  _MedThongSoKQMayXN.heso, 
					"@morong",  _MedThongSoKQMayXN.morong);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedThongSoKQMayXN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedThongSoKQMayXN] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedThongSoKQMayXN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedThongSoKQMayXN _MedThongSoKQMayXN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedThongSoKQMayXN] WHERE id=@id",
					"@id", _MedThongSoKQMayXN.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedThongSoKQMayXN trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedThongSoKQMayXN] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedThongSoKQMayXN trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedThongSoKQMayXN> _MedThongSoKQMayXNs)
		{
			foreach (MedThongSoKQMayXN item in _MedThongSoKQMayXNs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
