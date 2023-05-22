using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdchidinh:IMEdchidinh
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdchidinh(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedChiDinh từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedChiDinh]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedChiDinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedChiDinh] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedChiDinh từ Database
		/// </summary>
		public List<MedChiDinh> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedChiDinh]");
				List<MedChiDinh> items = new List<MedChiDinh>();
				MedChiDinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedChiDinh();
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
					if (dr["id_vp"] != null && dr["id_vp"] != DBNull.Value)
					{
						item.id_vp = Convert.ToInt32(dr["id_vp"]);
					}
					if (dr["soluong"] != null && dr["soluong"] != DBNull.Value)
					{
						item.soluong = Convert.ToInt32(dr["soluong"]);
					}
					if (dr["dongia"] != null && dr["dongia"] != DBNull.Value)
					{
						item.dongia = Convert.ToInt32(dr["dongia"]);
					}
					if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
					{
						item.loaibn = Convert.ToInt32(dr["loaibn"]);
					}
					if (dr["maicd"] != null && dr["maicd"] != DBNull.Value)
					{
						item.maicd = Convert.ToString(dr["maicd"]);
					}
					if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
					{
						item.chandoan = Convert.ToString(dr["chandoan"]);
					}
					if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
					{
						item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
					}
					if (dr["capcuu"] != null && dr["capcuu"] != DBNull.Value)
					{
						item.capcuu = Convert.ToInt32(dr["capcuu"]);
					}
					if (dr["thuchien"] != null && dr["thuchien"] != DBNull.Value)
					{
						item.thuchien = Convert.ToInt32(dr["thuchien"]);
					}
					if (dr["done"] != null && dr["done"] != DBNull.Value)
					{
						item.done = Convert.ToInt32(dr["done"]);
					}
					if (dr["computer"] != null && dr["computer"] != DBNull.Value)
					{
						item.computer = Convert.ToString(dr["computer"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["id_bn_chidinh"] != null && dr["id_bn_chidinh"] != DBNull.Value)
					{
						item.id_bn_chidinh = Convert.ToInt32(dr["id_bn_chidinh"]);
					}
					if (dr["hs_mabn"] != null && dr["hs_mabn"] != DBNull.Value)
					{
						item.hs_mabn = Convert.ToString(dr["hs_mabn"]);
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
		/// Lấy danh sách MedChiDinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedChiDinh> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedChiDinh] A "+ condition,  parameters);
				List<MedChiDinh> items = new List<MedChiDinh>();
				MedChiDinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedChiDinh();
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
					if (dr["id_vp"] != null && dr["id_vp"] != DBNull.Value)
					{
						item.id_vp = Convert.ToInt32(dr["id_vp"]);
					}
					if (dr["soluong"] != null && dr["soluong"] != DBNull.Value)
					{
						item.soluong = Convert.ToInt32(dr["soluong"]);
					}
					if (dr["dongia"] != null && dr["dongia"] != DBNull.Value)
					{
						item.dongia = Convert.ToInt32(dr["dongia"]);
					}
					if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
					{
						item.loaibn = Convert.ToInt32(dr["loaibn"]);
					}
					if (dr["maicd"] != null && dr["maicd"] != DBNull.Value)
					{
						item.maicd = Convert.ToString(dr["maicd"]);
					}
					if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
					{
						item.chandoan = Convert.ToString(dr["chandoan"]);
					}
					if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
					{
						item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
					}
					if (dr["capcuu"] != null && dr["capcuu"] != DBNull.Value)
					{
						item.capcuu = Convert.ToInt32(dr["capcuu"]);
					}
					if (dr["thuchien"] != null && dr["thuchien"] != DBNull.Value)
					{
						item.thuchien = Convert.ToInt32(dr["thuchien"]);
					}
					if (dr["done"] != null && dr["done"] != DBNull.Value)
					{
						item.done = Convert.ToInt32(dr["done"]);
					}
					if (dr["computer"] != null && dr["computer"] != DBNull.Value)
					{
						item.computer = Convert.ToString(dr["computer"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["id_bn_chidinh"] != null && dr["id_bn_chidinh"] != DBNull.Value)
					{
						item.id_bn_chidinh = Convert.ToInt32(dr["id_bn_chidinh"]);
					}
					if (dr["hs_mabn"] != null && dr["hs_mabn"] != DBNull.Value)
					{
						item.hs_mabn = Convert.ToString(dr["hs_mabn"]);
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

		public List<MedChiDinh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedChiDinh] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedChiDinh] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedChiDinh>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedChiDinh từ Database
		/// </summary>
		public MedChiDinh GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedChiDinh] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedChiDinh item=new MedChiDinh();
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
						if (dr["id_vp"] != null && dr["id_vp"] != DBNull.Value)
						{
							item.id_vp = Convert.ToInt32(dr["id_vp"]);
						}
						if (dr["soluong"] != null && dr["soluong"] != DBNull.Value)
						{
							item.soluong = Convert.ToInt32(dr["soluong"]);
						}
						if (dr["dongia"] != null && dr["dongia"] != DBNull.Value)
						{
							item.dongia = Convert.ToInt32(dr["dongia"]);
						}
						if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
						{
							item.loaibn = Convert.ToInt32(dr["loaibn"]);
						}
						if (dr["maicd"] != null && dr["maicd"] != DBNull.Value)
						{
							item.maicd = Convert.ToString(dr["maicd"]);
						}
						if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
						{
							item.chandoan = Convert.ToString(dr["chandoan"]);
						}
						if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
						{
							item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
						}
						if (dr["capcuu"] != null && dr["capcuu"] != DBNull.Value)
						{
							item.capcuu = Convert.ToInt32(dr["capcuu"]);
						}
						if (dr["thuchien"] != null && dr["thuchien"] != DBNull.Value)
						{
							item.thuchien = Convert.ToInt32(dr["thuchien"]);
						}
						if (dr["done"] != null && dr["done"] != DBNull.Value)
						{
							item.done = Convert.ToInt32(dr["done"]);
						}
						if (dr["computer"] != null && dr["computer"] != DBNull.Value)
						{
							item.computer = Convert.ToString(dr["computer"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["id_bn_chidinh"] != null && dr["id_bn_chidinh"] != DBNull.Value)
						{
							item.id_bn_chidinh = Convert.ToInt32(dr["id_bn_chidinh"]);
						}
						if (dr["hs_mabn"] != null && dr["hs_mabn"] != DBNull.Value)
						{
							item.hs_mabn = Convert.ToString(dr["hs_mabn"]);
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
		/// Lấy một MedChiDinh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedChiDinh GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedChiDinh] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedChiDinh item=new MedChiDinh();
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
						if (dr["id_vp"] != null && dr["id_vp"] != DBNull.Value)
						{
							item.id_vp = Convert.ToInt32(dr["id_vp"]);
						}
						if (dr["soluong"] != null && dr["soluong"] != DBNull.Value)
						{
							item.soluong = Convert.ToInt32(dr["soluong"]);
						}
						if (dr["dongia"] != null && dr["dongia"] != DBNull.Value)
						{
							item.dongia = Convert.ToInt32(dr["dongia"]);
						}
						if (dr["loaibn"] != null && dr["loaibn"] != DBNull.Value)
						{
							item.loaibn = Convert.ToInt32(dr["loaibn"]);
						}
						if (dr["maicd"] != null && dr["maicd"] != DBNull.Value)
						{
							item.maicd = Convert.ToString(dr["maicd"]);
						}
						if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
						{
							item.chandoan = Convert.ToString(dr["chandoan"]);
						}
						if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
						{
							item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
						}
						if (dr["capcuu"] != null && dr["capcuu"] != DBNull.Value)
						{
							item.capcuu = Convert.ToInt32(dr["capcuu"]);
						}
						if (dr["thuchien"] != null && dr["thuchien"] != DBNull.Value)
						{
							item.thuchien = Convert.ToInt32(dr["thuchien"]);
						}
						if (dr["done"] != null && dr["done"] != DBNull.Value)
						{
							item.done = Convert.ToInt32(dr["done"]);
						}
						if (dr["computer"] != null && dr["computer"] != DBNull.Value)
						{
							item.computer = Convert.ToString(dr["computer"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["id_bn_chidinh"] != null && dr["id_bn_chidinh"] != DBNull.Value)
						{
							item.id_bn_chidinh = Convert.ToInt32(dr["id_bn_chidinh"]);
						}
						if (dr["hs_mabn"] != null && dr["hs_mabn"] != DBNull.Value)
						{
							item.hs_mabn = Convert.ToString(dr["hs_mabn"]);
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

		public MedChiDinh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedChiDinh] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedChiDinh>(ds);
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
		/// Thêm mới MedChiDinh vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedChiDinh _MedChiDinh)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedChiDinh](id, mabn, mavv, maql, ngay, id_kp, id_doituong, id_vp, soluong, dongia, loaibn, maicd, chandoan, id_bacsi, capcuu, thuchien, done, computer, ghichu, userid, ngayud, id_bn_chidinh, hs_mabn) VALUES(@id, @mabn, @mavv, @maql, @ngay, @id_kp, @id_doituong, @id_vp, @soluong, @dongia, @loaibn, @maicd, @chandoan, @id_bacsi, @capcuu, @thuchien, @done, @computer, @ghichu, @userid, @ngayud, @id_bn_chidinh, @hs_mabn)", 
					"@id",  _MedChiDinh.id, 
					"@mabn",  _MedChiDinh.mabn, 
					"@mavv",  _MedChiDinh.mavv, 
					"@maql",  _MedChiDinh.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedChiDinh.ngay), 
					"@id_kp",  _MedChiDinh.id_kp, 
					"@id_doituong",  _MedChiDinh.id_doituong, 
					"@id_vp",  _MedChiDinh.id_vp, 
					"@soluong",  _MedChiDinh.soluong, 
					"@dongia",  _MedChiDinh.dongia, 
					"@loaibn",  _MedChiDinh.loaibn, 
					"@maicd",  _MedChiDinh.maicd, 
					"@chandoan",  _MedChiDinh.chandoan, 
					"@id_bacsi",  _MedChiDinh.id_bacsi, 
					"@capcuu",  _MedChiDinh.capcuu, 
					"@thuchien",  _MedChiDinh.thuchien, 
					"@done",  _MedChiDinh.done, 
					"@computer",  _MedChiDinh.computer, 
					"@ghichu",  _MedChiDinh.ghichu, 
					"@userid",  _MedChiDinh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedChiDinh.ngayud), 
					"@id_bn_chidinh",  _MedChiDinh.id_bn_chidinh, 
					"@hs_mabn",  _MedChiDinh.hs_mabn);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedChiDinh vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedChiDinh> _MedChiDinhs)
		{
			foreach (MedChiDinh item in _MedChiDinhs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedChiDinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedChiDinh _MedChiDinh, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedChiDinh] SET id=@id, mabn=@mabn, mavv=@mavv, maql=@maql, ngay=@ngay, id_kp=@id_kp, id_doituong=@id_doituong, id_vp=@id_vp, soluong=@soluong, dongia=@dongia, loaibn=@loaibn, maicd=@maicd, chandoan=@chandoan, id_bacsi=@id_bacsi, capcuu=@capcuu, thuchien=@thuchien, done=@done, computer=@computer, ghichu=@ghichu, userid=@userid, ngayud=@ngayud, id_bn_chidinh=@id_bn_chidinh, hs_mabn=@hs_mabn WHERE id=@id", 
					"@id",  _MedChiDinh.id, 
					"@mabn",  _MedChiDinh.mabn, 
					"@mavv",  _MedChiDinh.mavv, 
					"@maql",  _MedChiDinh.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedChiDinh.ngay), 
					"@id_kp",  _MedChiDinh.id_kp, 
					"@id_doituong",  _MedChiDinh.id_doituong, 
					"@id_vp",  _MedChiDinh.id_vp, 
					"@soluong",  _MedChiDinh.soluong, 
					"@dongia",  _MedChiDinh.dongia, 
					"@loaibn",  _MedChiDinh.loaibn, 
					"@maicd",  _MedChiDinh.maicd, 
					"@chandoan",  _MedChiDinh.chandoan, 
					"@id_bacsi",  _MedChiDinh.id_bacsi, 
					"@capcuu",  _MedChiDinh.capcuu, 
					"@thuchien",  _MedChiDinh.thuchien, 
					"@done",  _MedChiDinh.done, 
					"@computer",  _MedChiDinh.computer, 
					"@ghichu",  _MedChiDinh.ghichu, 
					"@userid",  _MedChiDinh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedChiDinh.ngayud), 
					"@id_bn_chidinh",  _MedChiDinh.id_bn_chidinh, 
					"@hs_mabn",  _MedChiDinh.hs_mabn, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedChiDinh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedChiDinh _MedChiDinh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedChiDinh] SET mabn=@mabn, mavv=@mavv, maql=@maql, ngay=@ngay, id_kp=@id_kp, id_doituong=@id_doituong, id_vp=@id_vp, soluong=@soluong, dongia=@dongia, loaibn=@loaibn, maicd=@maicd, chandoan=@chandoan, id_bacsi=@id_bacsi, capcuu=@capcuu, thuchien=@thuchien, done=@done, computer=@computer, ghichu=@ghichu, userid=@userid, ngayud=@ngayud, id_bn_chidinh=@id_bn_chidinh, hs_mabn=@hs_mabn WHERE id=@id", 
					"@mabn",  _MedChiDinh.mabn, 
					"@mavv",  _MedChiDinh.mavv, 
					"@maql",  _MedChiDinh.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedChiDinh.ngay), 
					"@id_kp",  _MedChiDinh.id_kp, 
					"@id_doituong",  _MedChiDinh.id_doituong, 
					"@id_vp",  _MedChiDinh.id_vp, 
					"@soluong",  _MedChiDinh.soluong, 
					"@dongia",  _MedChiDinh.dongia, 
					"@loaibn",  _MedChiDinh.loaibn, 
					"@maicd",  _MedChiDinh.maicd, 
					"@chandoan",  _MedChiDinh.chandoan, 
					"@id_bacsi",  _MedChiDinh.id_bacsi, 
					"@capcuu",  _MedChiDinh.capcuu, 
					"@thuchien",  _MedChiDinh.thuchien, 
					"@done",  _MedChiDinh.done, 
					"@computer",  _MedChiDinh.computer, 
					"@ghichu",  _MedChiDinh.ghichu, 
					"@userid",  _MedChiDinh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedChiDinh.ngayud), 
					"@id_bn_chidinh",  _MedChiDinh.id_bn_chidinh, 
					"@hs_mabn",  _MedChiDinh.hs_mabn, 
					"@id", _MedChiDinh.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedChiDinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedChiDinh> _MedChiDinhs)
		{
			foreach (MedChiDinh item in _MedChiDinhs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedChiDinh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedChiDinh _MedChiDinh, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedChiDinh] SET id=@id, mabn=@mabn, mavv=@mavv, maql=@maql, ngay=@ngay, id_kp=@id_kp, id_doituong=@id_doituong, id_vp=@id_vp, soluong=@soluong, dongia=@dongia, loaibn=@loaibn, maicd=@maicd, chandoan=@chandoan, id_bacsi=@id_bacsi, capcuu=@capcuu, thuchien=@thuchien, done=@done, computer=@computer, ghichu=@ghichu, userid=@userid, ngayud=@ngayud, id_bn_chidinh=@id_bn_chidinh, hs_mabn=@hs_mabn "+ condition, 
					"@id",  _MedChiDinh.id, 
					"@mabn",  _MedChiDinh.mabn, 
					"@mavv",  _MedChiDinh.mavv, 
					"@maql",  _MedChiDinh.maql, 
					"@ngay", this._dataContext.ConvertDateString( _MedChiDinh.ngay), 
					"@id_kp",  _MedChiDinh.id_kp, 
					"@id_doituong",  _MedChiDinh.id_doituong, 
					"@id_vp",  _MedChiDinh.id_vp, 
					"@soluong",  _MedChiDinh.soluong, 
					"@dongia",  _MedChiDinh.dongia, 
					"@loaibn",  _MedChiDinh.loaibn, 
					"@maicd",  _MedChiDinh.maicd, 
					"@chandoan",  _MedChiDinh.chandoan, 
					"@id_bacsi",  _MedChiDinh.id_bacsi, 
					"@capcuu",  _MedChiDinh.capcuu, 
					"@thuchien",  _MedChiDinh.thuchien, 
					"@done",  _MedChiDinh.done, 
					"@computer",  _MedChiDinh.computer, 
					"@ghichu",  _MedChiDinh.ghichu, 
					"@userid",  _MedChiDinh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedChiDinh.ngayud), 
					"@id_bn_chidinh",  _MedChiDinh.id_bn_chidinh, 
					"@hs_mabn",  _MedChiDinh.hs_mabn);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedChiDinh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedChiDinh] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedChiDinh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedChiDinh _MedChiDinh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedChiDinh] WHERE id=@id",
					"@id", _MedChiDinh.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedChiDinh trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedChiDinh] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedChiDinh trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedChiDinh> _MedChiDinhs)
		{
			foreach (MedChiDinh item in _MedChiDinhs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
