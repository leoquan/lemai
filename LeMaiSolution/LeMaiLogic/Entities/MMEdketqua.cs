using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdketqua:IMEdketqua
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdketqua(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKetQua từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQua]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQua] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKetQua từ Database
		/// </summary>
		public List<MedKetQua> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQua]");
				List<MedKetQua> items = new List<MedKetQua>();
				MedKetQua item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQua();
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
					if (dr["sophieu"] != null && dr["sophieu"] != DBNull.Value)
					{
						item.sophieu = Convert.ToDecimal(dr["sophieu"]);
					}
					if (dr["ngaylm"] != null && dr["ngaylm"] != DBNull.Value)
					{
						item.ngaylm = Convert.ToDateTime(dr["ngaylm"]);
					}
					if (dr["id_ktv"] != null && dr["id_ktv"] != DBNull.Value)
					{
						item.id_ktv = Convert.ToDecimal(dr["id_ktv"]);
					}
					if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
					{
						item.loaibn = Convert.ToDecimal(dr["loaibn"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["id_laymau"] != null && dr["id_laymau"] != DBNull.Value)
					{
						item.id_laymau = Convert.ToString(dr["id_laymau"]);
					}
					if (dr["mmyy_laymau"] != null && dr["mmyy_laymau"] != DBNull.Value)
					{
						item.mmyy_laymau = Convert.ToString(dr["mmyy_laymau"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["ngayin"] != null && dr["ngayin"] != DBNull.Value)
					{
						item.ngayin = Convert.ToDateTime(dr["ngayin"]);
					}
					if (dr["lanin"] != null && dr["lanin"] != DBNull.Value)
					{
						item.lanin = Convert.ToInt32(dr["lanin"]);
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
		/// Lấy danh sách MedKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKetQua> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQua] A "+ condition,  parameters);
				List<MedKetQua> items = new List<MedKetQua>();
				MedKetQua item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQua();
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
					if (dr["sophieu"] != null && dr["sophieu"] != DBNull.Value)
					{
						item.sophieu = Convert.ToDecimal(dr["sophieu"]);
					}
					if (dr["ngaylm"] != null && dr["ngaylm"] != DBNull.Value)
					{
						item.ngaylm = Convert.ToDateTime(dr["ngaylm"]);
					}
					if (dr["id_ktv"] != null && dr["id_ktv"] != DBNull.Value)
					{
						item.id_ktv = Convert.ToDecimal(dr["id_ktv"]);
					}
					if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
					{
						item.loaibn = Convert.ToDecimal(dr["loaibn"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["id_laymau"] != null && dr["id_laymau"] != DBNull.Value)
					{
						item.id_laymau = Convert.ToString(dr["id_laymau"]);
					}
					if (dr["mmyy_laymau"] != null && dr["mmyy_laymau"] != DBNull.Value)
					{
						item.mmyy_laymau = Convert.ToString(dr["mmyy_laymau"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["ngayin"] != null && dr["ngayin"] != DBNull.Value)
					{
						item.ngayin = Convert.ToDateTime(dr["ngayin"]);
					}
					if (dr["lanin"] != null && dr["lanin"] != DBNull.Value)
					{
						item.lanin = Convert.ToInt32(dr["lanin"]);
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

		public List<MedKetQua> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQua] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKetQua] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKetQua>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKetQua từ Database
		/// </summary>
		public MedKetQua GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQua] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedKetQua item=new MedKetQua();
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
						if (dr["sophieu"] != null && dr["sophieu"] != DBNull.Value)
						{
							item.sophieu = Convert.ToDecimal(dr["sophieu"]);
						}
						if (dr["ngaylm"] != null && dr["ngaylm"] != DBNull.Value)
						{
							item.ngaylm = Convert.ToDateTime(dr["ngaylm"]);
						}
						if (dr["id_ktv"] != null && dr["id_ktv"] != DBNull.Value)
						{
							item.id_ktv = Convert.ToDecimal(dr["id_ktv"]);
						}
						if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
						{
							item.loaibn = Convert.ToDecimal(dr["loaibn"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["id_laymau"] != null && dr["id_laymau"] != DBNull.Value)
						{
							item.id_laymau = Convert.ToString(dr["id_laymau"]);
						}
						if (dr["mmyy_laymau"] != null && dr["mmyy_laymau"] != DBNull.Value)
						{
							item.mmyy_laymau = Convert.ToString(dr["mmyy_laymau"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["ngayin"] != null && dr["ngayin"] != DBNull.Value)
						{
							item.ngayin = Convert.ToDateTime(dr["ngayin"]);
						}
						if (dr["lanin"] != null && dr["lanin"] != DBNull.Value)
						{
							item.lanin = Convert.ToInt32(dr["lanin"]);
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
		/// Lấy một MedKetQua đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKetQua GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQua] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKetQua item=new MedKetQua();
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
						if (dr["sophieu"] != null && dr["sophieu"] != DBNull.Value)
						{
							item.sophieu = Convert.ToDecimal(dr["sophieu"]);
						}
						if (dr["ngaylm"] != null && dr["ngaylm"] != DBNull.Value)
						{
							item.ngaylm = Convert.ToDateTime(dr["ngaylm"]);
						}
						if (dr["id_ktv"] != null && dr["id_ktv"] != DBNull.Value)
						{
							item.id_ktv = Convert.ToDecimal(dr["id_ktv"]);
						}
						if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
						{
							item.loaibn = Convert.ToDecimal(dr["loaibn"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["id_laymau"] != null && dr["id_laymau"] != DBNull.Value)
						{
							item.id_laymau = Convert.ToString(dr["id_laymau"]);
						}
						if (dr["mmyy_laymau"] != null && dr["mmyy_laymau"] != DBNull.Value)
						{
							item.mmyy_laymau = Convert.ToString(dr["mmyy_laymau"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["ngayin"] != null && dr["ngayin"] != DBNull.Value)
						{
							item.ngayin = Convert.ToDateTime(dr["ngayin"]);
						}
						if (dr["lanin"] != null && dr["lanin"] != DBNull.Value)
						{
							item.lanin = Convert.ToInt32(dr["lanin"]);
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

		public MedKetQua GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQua] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKetQua>(ds);
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
		/// Thêm mới MedKetQua vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKetQua _MedKetQua)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKetQua](id, mabn, mavv, maql, ngay, id_kp, id_doituong, id_bacsi, chandoan, somau, sophieu, ngaylm, id_ktv, loaibn, ghichu, id_laymau, mmyy_laymau, userid, ngayud, ngayin, lanin) VALUES(@id, @mabn, @mavv, @maql, @ngay, @id_kp, @id_doituong, @id_bacsi, @chandoan, @somau, @sophieu, @ngaylm, @id_ktv, @loaibn, @ghichu, @id_laymau, @mmyy_laymau, @userid, @ngayud, @ngayin, @lanin)", 
					"@id",  _MedKetQua.id, 
					"@mabn",  _MedKetQua.mabn, 
					"@mavv",  _MedKetQua.mavv, 
					"@maql",  _MedKetQua.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedKetQua.ngay), 
					"@id_kp",  _MedKetQua.id_kp, 
					"@id_doituong",  _MedKetQua.id_doituong, 
					"@id_bacsi",  _MedKetQua.id_bacsi, 
					"@chandoan",  _MedKetQua.chandoan, 
					"@somau",  _MedKetQua.somau, 
					"@sophieu",  _MedKetQua.sophieu, 
					"@ngaylm", this._dataContext.ConvertDateString( _MedKetQua.ngaylm), 
					"@id_ktv",  _MedKetQua.id_ktv, 
					"@loaibn",  _MedKetQua.loaibn, 
					"@ghichu",  _MedKetQua.ghichu, 
					"@id_laymau",  _MedKetQua.id_laymau, 
					"@mmyy_laymau",  _MedKetQua.mmyy_laymau, 
					"@userid",  _MedKetQua.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQua.ngayud), 
					"@ngayin", this._dataContext.ConvertDateString( _MedKetQua.ngayin), 
					"@lanin",  _MedKetQua.lanin);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKetQua vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKetQua> _MedKetQuas)
		{
			foreach (MedKetQua item in _MedKetQuas)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKetQua _MedKetQua, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQua] SET id=@id, mabn=@mabn, mavv=@mavv, maql=@maql, ngay=@ngay, id_kp=@id_kp, id_doituong=@id_doituong, id_bacsi=@id_bacsi, chandoan=@chandoan, somau=@somau, sophieu=@sophieu, ngaylm=@ngaylm, id_ktv=@id_ktv, loaibn=@loaibn, ghichu=@ghichu, id_laymau=@id_laymau, mmyy_laymau=@mmyy_laymau, userid=@userid, ngayud=@ngayud, ngayin=@ngayin, lanin=@lanin WHERE id=@id", 
					"@id",  _MedKetQua.id, 
					"@mabn",  _MedKetQua.mabn, 
					"@mavv",  _MedKetQua.mavv, 
					"@maql",  _MedKetQua.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedKetQua.ngay), 
					"@id_kp",  _MedKetQua.id_kp, 
					"@id_doituong",  _MedKetQua.id_doituong, 
					"@id_bacsi",  _MedKetQua.id_bacsi, 
					"@chandoan",  _MedKetQua.chandoan, 
					"@somau",  _MedKetQua.somau, 
					"@sophieu",  _MedKetQua.sophieu, 
					"@ngaylm", this._dataContext.ConvertDateString( _MedKetQua.ngaylm), 
					"@id_ktv",  _MedKetQua.id_ktv, 
					"@loaibn",  _MedKetQua.loaibn, 
					"@ghichu",  _MedKetQua.ghichu, 
					"@id_laymau",  _MedKetQua.id_laymau, 
					"@mmyy_laymau",  _MedKetQua.mmyy_laymau, 
					"@userid",  _MedKetQua.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQua.ngayud), 
					"@ngayin", this._dataContext.ConvertDateString( _MedKetQua.ngayin), 
					"@lanin",  _MedKetQua.lanin, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKetQua vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKetQua _MedKetQua)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQua] SET mabn=@mabn, mavv=@mavv, maql=@maql, ngay=@ngay, id_kp=@id_kp, id_doituong=@id_doituong, id_bacsi=@id_bacsi, chandoan=@chandoan, somau=@somau, sophieu=@sophieu, ngaylm=@ngaylm, id_ktv=@id_ktv, loaibn=@loaibn, ghichu=@ghichu, id_laymau=@id_laymau, mmyy_laymau=@mmyy_laymau, userid=@userid, ngayud=@ngayud, ngayin=@ngayin, lanin=@lanin WHERE id=@id", 
					"@mabn",  _MedKetQua.mabn, 
					"@mavv",  _MedKetQua.mavv, 
					"@maql",  _MedKetQua.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedKetQua.ngay), 
					"@id_kp",  _MedKetQua.id_kp, 
					"@id_doituong",  _MedKetQua.id_doituong, 
					"@id_bacsi",  _MedKetQua.id_bacsi, 
					"@chandoan",  _MedKetQua.chandoan, 
					"@somau",  _MedKetQua.somau, 
					"@sophieu",  _MedKetQua.sophieu, 
					"@ngaylm", this._dataContext.ConvertDateString( _MedKetQua.ngaylm), 
					"@id_ktv",  _MedKetQua.id_ktv, 
					"@loaibn",  _MedKetQua.loaibn, 
					"@ghichu",  _MedKetQua.ghichu, 
					"@id_laymau",  _MedKetQua.id_laymau, 
					"@mmyy_laymau",  _MedKetQua.mmyy_laymau, 
					"@userid",  _MedKetQua.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQua.ngayud), 
					"@ngayin", this._dataContext.ConvertDateString( _MedKetQua.ngayin), 
					"@lanin",  _MedKetQua.lanin, 
					"@id", _MedKetQua.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKetQua> _MedKetQuas)
		{
			foreach (MedKetQua item in _MedKetQuas)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQua vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKetQua _MedKetQua, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQua] SET id=@id, mabn=@mabn, mavv=@mavv, maql=@maql, ngay=@ngay, id_kp=@id_kp, id_doituong=@id_doituong, id_bacsi=@id_bacsi, chandoan=@chandoan, somau=@somau, sophieu=@sophieu, ngaylm=@ngaylm, id_ktv=@id_ktv, loaibn=@loaibn, ghichu=@ghichu, id_laymau=@id_laymau, mmyy_laymau=@mmyy_laymau, userid=@userid, ngayud=@ngayud, ngayin=@ngayin, lanin=@lanin "+ condition, 
					"@id",  _MedKetQua.id, 
					"@mabn",  _MedKetQua.mabn, 
					"@mavv",  _MedKetQua.mavv, 
					"@maql",  _MedKetQua.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedKetQua.ngay), 
					"@id_kp",  _MedKetQua.id_kp, 
					"@id_doituong",  _MedKetQua.id_doituong, 
					"@id_bacsi",  _MedKetQua.id_bacsi, 
					"@chandoan",  _MedKetQua.chandoan, 
					"@somau",  _MedKetQua.somau, 
					"@sophieu",  _MedKetQua.sophieu, 
					"@ngaylm", this._dataContext.ConvertDateString( _MedKetQua.ngaylm), 
					"@id_ktv",  _MedKetQua.id_ktv, 
					"@loaibn",  _MedKetQua.loaibn, 
					"@ghichu",  _MedKetQua.ghichu, 
					"@id_laymau",  _MedKetQua.id_laymau, 
					"@mmyy_laymau",  _MedKetQua.mmyy_laymau, 
					"@userid",  _MedKetQua.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQua.ngayud), 
					"@ngayin", this._dataContext.ConvertDateString( _MedKetQua.ngayin), 
					"@lanin",  _MedKetQua.lanin);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKetQua trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQua] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQua trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKetQua _MedKetQua)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQua] WHERE id=@id",
					"@id", _MedKetQua.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQua trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQua] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQua trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKetQua> _MedKetQuas)
		{
			foreach (MedKetQua item in _MedKetQuas)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
