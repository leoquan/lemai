using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdlaymau:IMEdlaymau
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdlaymau(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedLayMau từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLayMau]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedLayMau từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLayMau] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedLayMau từ Database
		/// </summary>
		public List<MedLayMau> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLayMau]");
				List<MedLayMau> items = new List<MedLayMau>();
				MedLayMau item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedLayMau();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
					{
						item.mabn = Convert.ToString(dr["mabn"]);
					}
					if (dr["mavv"] != null && dr["mavv"] != DBNull.Value)
					{
						item.mavv = Convert.ToString(dr["mavv"]);
					}
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
					}
					if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
					{
						item.ngay = Convert.ToDateTime(dr["ngay"]);
					}
					if (dr["id_kp"] != null && dr["id_kp"] != DBNull.Value)
					{
						item.id_kp = Convert.ToInt32(dr["id_kp"]);
					}
					if (dr["id_doituong"] != null && dr["id_doituong"] != DBNull.Value)
					{
						item.id_doituong = Convert.ToInt32(dr["id_doituong"]);
					}
					if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
					{
						item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
					}
					if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
					{
						item.chandoan = Convert.ToString(dr["chandoan"]);
					}
					if (dr["somau"] != null && dr["somau"] != DBNull.Value)
					{
						item.somau = Convert.ToInt32(dr["somau"]);
					}
					if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
					{
						item.loaibn = Convert.ToInt32(dr["loaibn"]);
					}
					if (dr["done"] != null && dr["done"] != DBNull.Value)
					{
						item.done = Convert.ToInt32(dr["done"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
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
		/// Lấy danh sách MedLayMau từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedLayMau> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedLayMau] A "+ condition,  parameters);
				List<MedLayMau> items = new List<MedLayMau>();
				MedLayMau item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedLayMau();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
					{
						item.mabn = Convert.ToString(dr["mabn"]);
					}
					if (dr["mavv"] != null && dr["mavv"] != DBNull.Value)
					{
						item.mavv = Convert.ToString(dr["mavv"]);
					}
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
					}
					if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
					{
						item.ngay = Convert.ToDateTime(dr["ngay"]);
					}
					if (dr["id_kp"] != null && dr["id_kp"] != DBNull.Value)
					{
						item.id_kp = Convert.ToInt32(dr["id_kp"]);
					}
					if (dr["id_doituong"] != null && dr["id_doituong"] != DBNull.Value)
					{
						item.id_doituong = Convert.ToInt32(dr["id_doituong"]);
					}
					if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
					{
						item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
					}
					if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
					{
						item.chandoan = Convert.ToString(dr["chandoan"]);
					}
					if (dr["somau"] != null && dr["somau"] != DBNull.Value)
					{
						item.somau = Convert.ToInt32(dr["somau"]);
					}
					if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
					{
						item.loaibn = Convert.ToInt32(dr["loaibn"]);
					}
					if (dr["done"] != null && dr["done"] != DBNull.Value)
					{
						item.done = Convert.ToInt32(dr["done"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
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

		public List<MedLayMau> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedLayMau] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedLayMau] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedLayMau>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedLayMau từ Database
		/// </summary>
		public MedLayMau GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLayMau] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedLayMau item=new MedLayMau();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
						{
							item.mabn = Convert.ToString(dr["mabn"]);
						}
						if (dr["mavv"] != null && dr["mavv"] != DBNull.Value)
						{
							item.mavv = Convert.ToString(dr["mavv"]);
						}
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
						}
						if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
						{
							item.ngay = Convert.ToDateTime(dr["ngay"]);
						}
						if (dr["id_kp"] != null && dr["id_kp"] != DBNull.Value)
						{
							item.id_kp = Convert.ToInt32(dr["id_kp"]);
						}
						if (dr["id_doituong"] != null && dr["id_doituong"] != DBNull.Value)
						{
							item.id_doituong = Convert.ToInt32(dr["id_doituong"]);
						}
						if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
						{
							item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
						}
						if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
						{
							item.chandoan = Convert.ToString(dr["chandoan"]);
						}
						if (dr["somau"] != null && dr["somau"] != DBNull.Value)
						{
							item.somau = Convert.ToInt32(dr["somau"]);
						}
						if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
						{
							item.loaibn = Convert.ToInt32(dr["loaibn"]);
						}
						if (dr["done"] != null && dr["done"] != DBNull.Value)
						{
							item.done = Convert.ToInt32(dr["done"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
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
		/// Lấy một MedLayMau đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedLayMau GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedLayMau] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedLayMau item=new MedLayMau();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
						{
							item.mabn = Convert.ToString(dr["mabn"]);
						}
						if (dr["mavv"] != null && dr["mavv"] != DBNull.Value)
						{
							item.mavv = Convert.ToString(dr["mavv"]);
						}
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
						}
						if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
						{
							item.ngay = Convert.ToDateTime(dr["ngay"]);
						}
						if (dr["id_kp"] != null && dr["id_kp"] != DBNull.Value)
						{
							item.id_kp = Convert.ToInt32(dr["id_kp"]);
						}
						if (dr["id_doituong"] != null && dr["id_doituong"] != DBNull.Value)
						{
							item.id_doituong = Convert.ToInt32(dr["id_doituong"]);
						}
						if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
						{
							item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
						}
						if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
						{
							item.chandoan = Convert.ToString(dr["chandoan"]);
						}
						if (dr["somau"] != null && dr["somau"] != DBNull.Value)
						{
							item.somau = Convert.ToInt32(dr["somau"]);
						}
						if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
						{
							item.loaibn = Convert.ToInt32(dr["loaibn"]);
						}
						if (dr["done"] != null && dr["done"] != DBNull.Value)
						{
							item.done = Convert.ToInt32(dr["done"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
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

		public MedLayMau GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedLayMau] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedLayMau>(ds);
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
		/// Thêm mới MedLayMau vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedLayMau _MedLayMau)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedLayMau](id, mabn, mavv, maql, ngay, id_kp, id_doituong, id_bacsi, chandoan, somau, loaibn, done, userid, ngayud) VALUES(@id, @mabn, @mavv, @maql, @ngay, @id_kp, @id_doituong, @id_bacsi, @chandoan, @somau, @loaibn, @done, @userid, @ngayud)", 
					"@id",  _MedLayMau.id, 
					"@mabn",  _MedLayMau.mabn, 
					"@mavv",  _MedLayMau.mavv, 
					"@maql",  _MedLayMau.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedLayMau.ngay), 
					"@id_kp",  _MedLayMau.id_kp, 
					"@id_doituong",  _MedLayMau.id_doituong, 
					"@id_bacsi",  _MedLayMau.id_bacsi, 
					"@chandoan",  _MedLayMau.chandoan, 
					"@somau",  _MedLayMau.somau, 
					"@loaibn",  _MedLayMau.loaibn, 
					"@done",  _MedLayMau.done, 
					"@userid",  _MedLayMau.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedLayMau.ngayud));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedLayMau vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedLayMau> _MedLayMaus)
		{
			foreach (MedLayMau item in _MedLayMaus)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedLayMau vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedLayMau _MedLayMau, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLayMau] SET id=@id, mabn=@mabn, mavv=@mavv, maql=@maql, ngay=@ngay, id_kp=@id_kp, id_doituong=@id_doituong, id_bacsi=@id_bacsi, chandoan=@chandoan, somau=@somau, loaibn=@loaibn, done=@done, userid=@userid, ngayud=@ngayud WHERE id=@id", 
					"@id",  _MedLayMau.id, 
					"@mabn",  _MedLayMau.mabn, 
					"@mavv",  _MedLayMau.mavv, 
					"@maql",  _MedLayMau.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedLayMau.ngay), 
					"@id_kp",  _MedLayMau.id_kp, 
					"@id_doituong",  _MedLayMau.id_doituong, 
					"@id_bacsi",  _MedLayMau.id_bacsi, 
					"@chandoan",  _MedLayMau.chandoan, 
					"@somau",  _MedLayMau.somau, 
					"@loaibn",  _MedLayMau.loaibn, 
					"@done",  _MedLayMau.done, 
					"@userid",  _MedLayMau.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedLayMau.ngayud), 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedLayMau vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedLayMau _MedLayMau)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLayMau] SET mabn=@mabn, mavv=@mavv, maql=@maql, ngay=@ngay, id_kp=@id_kp, id_doituong=@id_doituong, id_bacsi=@id_bacsi, chandoan=@chandoan, somau=@somau, loaibn=@loaibn, done=@done, userid=@userid, ngayud=@ngayud WHERE id=@id", 
					"@mabn",  _MedLayMau.mabn, 
					"@mavv",  _MedLayMau.mavv, 
					"@maql",  _MedLayMau.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedLayMau.ngay), 
					"@id_kp",  _MedLayMau.id_kp, 
					"@id_doituong",  _MedLayMau.id_doituong, 
					"@id_bacsi",  _MedLayMau.id_bacsi, 
					"@chandoan",  _MedLayMau.chandoan, 
					"@somau",  _MedLayMau.somau, 
					"@loaibn",  _MedLayMau.loaibn, 
					"@done",  _MedLayMau.done, 
					"@userid",  _MedLayMau.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedLayMau.ngayud), 
					"@id", _MedLayMau.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedLayMau vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedLayMau> _MedLayMaus)
		{
			foreach (MedLayMau item in _MedLayMaus)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedLayMau vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedLayMau _MedLayMau, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLayMau] SET id=@id, mabn=@mabn, mavv=@mavv, maql=@maql, ngay=@ngay, id_kp=@id_kp, id_doituong=@id_doituong, id_bacsi=@id_bacsi, chandoan=@chandoan, somau=@somau, loaibn=@loaibn, done=@done, userid=@userid, ngayud=@ngayud "+ condition, 
					"@id",  _MedLayMau.id, 
					"@mabn",  _MedLayMau.mabn, 
					"@mavv",  _MedLayMau.mavv, 
					"@maql",  _MedLayMau.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedLayMau.ngay), 
					"@id_kp",  _MedLayMau.id_kp, 
					"@id_doituong",  _MedLayMau.id_doituong, 
					"@id_bacsi",  _MedLayMau.id_bacsi, 
					"@chandoan",  _MedLayMau.chandoan, 
					"@somau",  _MedLayMau.somau, 
					"@loaibn",  _MedLayMau.loaibn, 
					"@done",  _MedLayMau.done, 
					"@userid",  _MedLayMau.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedLayMau.ngayud));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedLayMau trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLayMau] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLayMau trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedLayMau _MedLayMau)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLayMau] WHERE id=@id",
					"@id", _MedLayMau.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLayMau trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLayMau] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLayMau trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedLayMau> _MedLayMaus)
		{
			foreach (MedLayMau item in _MedLayMaus)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
