using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdketquachandoan:IMEdketquachandoan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdketquachandoan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKetQuaChanDoan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaChanDoan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKetQuaChanDoan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaChanDoan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKetQuaChanDoan từ Database
		/// </summary>
		public List<MedKetQuaChanDoan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaChanDoan]");
				List<MedKetQuaChanDoan> items = new List<MedKetQuaChanDoan>();
				MedKetQuaChanDoan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaChanDoan();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
					{
						item.id_vienphi = Convert.ToInt32(dr["id_vienphi"]);
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
					if (dr["id_kp"] != null && dr["id_kp"] != DBNull.Value)
					{
						item.id_kp = Convert.ToInt32(dr["id_kp"]);
					}
					if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
					{
						item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
					}
					if (dr["id_chidinh"] != null && dr["id_chidinh"] != DBNull.Value)
					{
						item.id_chidinh = Convert.ToString(dr["id_chidinh"]);
					}
					if (dr["id_maumota"] != null && dr["id_maumota"] != DBNull.Value)
					{
						item.id_maumota = Convert.ToString(dr["id_maumota"]);
					}
					if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
					{
						item.ngay = Convert.ToDateTime(dr["ngay"]);
					}
					if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
					{
						item.chandoan = Convert.ToString(dr["chandoan"]);
					}
					if (dr["mota"] != null && dr["mota"] != DBNull.Value)
					{
						item.mota = Convert.ToString(dr["mota"]);
					}
					if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
					{
						item.ketluan = Convert.ToString(dr["ketluan"]);
					}
					if (dr["ketluanmau"] != null && dr["ketluanmau"] != DBNull.Value)
					{
						item.ketluanmau = Convert.ToString(dr["ketluanmau"]);
					}
					if (dr["ngaychidinh"] != null && dr["ngaychidinh"] != DBNull.Value)
					{
						item.ngaychidinh = Convert.ToDateTime(dr["ngaychidinh"]);
					}
					if (dr["lanin"] != null && dr["lanin"] != DBNull.Value)
					{
						item.lanin = Convert.ToInt32(dr["lanin"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
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
		/// Lấy danh sách MedKetQuaChanDoan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKetQuaChanDoan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaChanDoan] A "+ condition,  parameters);
				List<MedKetQuaChanDoan> items = new List<MedKetQuaChanDoan>();
				MedKetQuaChanDoan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaChanDoan();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
					{
						item.id_vienphi = Convert.ToInt32(dr["id_vienphi"]);
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
					if (dr["id_kp"] != null && dr["id_kp"] != DBNull.Value)
					{
						item.id_kp = Convert.ToInt32(dr["id_kp"]);
					}
					if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
					{
						item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
					}
					if (dr["id_chidinh"] != null && dr["id_chidinh"] != DBNull.Value)
					{
						item.id_chidinh = Convert.ToString(dr["id_chidinh"]);
					}
					if (dr["id_maumota"] != null && dr["id_maumota"] != DBNull.Value)
					{
						item.id_maumota = Convert.ToString(dr["id_maumota"]);
					}
					if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
					{
						item.ngay = Convert.ToDateTime(dr["ngay"]);
					}
					if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
					{
						item.chandoan = Convert.ToString(dr["chandoan"]);
					}
					if (dr["mota"] != null && dr["mota"] != DBNull.Value)
					{
						item.mota = Convert.ToString(dr["mota"]);
					}
					if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
					{
						item.ketluan = Convert.ToString(dr["ketluan"]);
					}
					if (dr["ketluanmau"] != null && dr["ketluanmau"] != DBNull.Value)
					{
						item.ketluanmau = Convert.ToString(dr["ketluanmau"]);
					}
					if (dr["ngaychidinh"] != null && dr["ngaychidinh"] != DBNull.Value)
					{
						item.ngaychidinh = Convert.ToDateTime(dr["ngaychidinh"]);
					}
					if (dr["lanin"] != null && dr["lanin"] != DBNull.Value)
					{
						item.lanin = Convert.ToInt32(dr["lanin"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
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

		public List<MedKetQuaChanDoan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaChanDoan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKetQuaChanDoan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKetQuaChanDoan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKetQuaChanDoan từ Database
		/// </summary>
		public MedKetQuaChanDoan GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaChanDoan] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaChanDoan item=new MedKetQuaChanDoan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
						{
							item.id_vienphi = Convert.ToInt32(dr["id_vienphi"]);
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
						if (dr["id_kp"] != null && dr["id_kp"] != DBNull.Value)
						{
							item.id_kp = Convert.ToInt32(dr["id_kp"]);
						}
						if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
						{
							item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
						}
						if (dr["id_chidinh"] != null && dr["id_chidinh"] != DBNull.Value)
						{
							item.id_chidinh = Convert.ToString(dr["id_chidinh"]);
						}
						if (dr["id_maumota"] != null && dr["id_maumota"] != DBNull.Value)
						{
							item.id_maumota = Convert.ToString(dr["id_maumota"]);
						}
						if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
						{
							item.ngay = Convert.ToDateTime(dr["ngay"]);
						}
						if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
						{
							item.chandoan = Convert.ToString(dr["chandoan"]);
						}
						if (dr["mota"] != null && dr["mota"] != DBNull.Value)
						{
							item.mota = Convert.ToString(dr["mota"]);
						}
						if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
						{
							item.ketluan = Convert.ToString(dr["ketluan"]);
						}
						if (dr["ketluanmau"] != null && dr["ketluanmau"] != DBNull.Value)
						{
							item.ketluanmau = Convert.ToString(dr["ketluanmau"]);
						}
						if (dr["ngaychidinh"] != null && dr["ngaychidinh"] != DBNull.Value)
						{
							item.ngaychidinh = Convert.ToDateTime(dr["ngaychidinh"]);
						}
						if (dr["lanin"] != null && dr["lanin"] != DBNull.Value)
						{
							item.lanin = Convert.ToInt32(dr["lanin"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
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
		/// Lấy một MedKetQuaChanDoan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKetQuaChanDoan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaChanDoan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaChanDoan item=new MedKetQuaChanDoan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
						{
							item.id_vienphi = Convert.ToInt32(dr["id_vienphi"]);
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
						if (dr["id_kp"] != null && dr["id_kp"] != DBNull.Value)
						{
							item.id_kp = Convert.ToInt32(dr["id_kp"]);
						}
						if (dr["id_bacsi"] != null && dr["id_bacsi"] != DBNull.Value)
						{
							item.id_bacsi = Convert.ToInt32(dr["id_bacsi"]);
						}
						if (dr["id_chidinh"] != null && dr["id_chidinh"] != DBNull.Value)
						{
							item.id_chidinh = Convert.ToString(dr["id_chidinh"]);
						}
						if (dr["id_maumota"] != null && dr["id_maumota"] != DBNull.Value)
						{
							item.id_maumota = Convert.ToString(dr["id_maumota"]);
						}
						if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
						{
							item.ngay = Convert.ToDateTime(dr["ngay"]);
						}
						if (dr["chandoan"] != null && dr["chandoan"] != DBNull.Value)
						{
							item.chandoan = Convert.ToString(dr["chandoan"]);
						}
						if (dr["mota"] != null && dr["mota"] != DBNull.Value)
						{
							item.mota = Convert.ToString(dr["mota"]);
						}
						if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
						{
							item.ketluan = Convert.ToString(dr["ketluan"]);
						}
						if (dr["ketluanmau"] != null && dr["ketluanmau"] != DBNull.Value)
						{
							item.ketluanmau = Convert.ToString(dr["ketluanmau"]);
						}
						if (dr["ngaychidinh"] != null && dr["ngaychidinh"] != DBNull.Value)
						{
							item.ngaychidinh = Convert.ToDateTime(dr["ngaychidinh"]);
						}
						if (dr["lanin"] != null && dr["lanin"] != DBNull.Value)
						{
							item.lanin = Convert.ToInt32(dr["lanin"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
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

		public MedKetQuaChanDoan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaChanDoan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKetQuaChanDoan>(ds);
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
		/// Thêm mới MedKetQuaChanDoan vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKetQuaChanDoan _MedKetQuaChanDoan)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKetQuaChanDoan](id, id_vienphi, mabn, mavv, maql, id_kp, id_bacsi, id_chidinh, id_maumota, ngay, chandoan, mota, ketluan, ketluanmau, ngaychidinh, lanin, nguoitao, ngayud) VALUES(@id, @id_vienphi, @mabn, @mavv, @maql, @id_kp, @id_bacsi, @id_chidinh, @id_maumota, @ngay, @chandoan, @mota, @ketluan, @ketluanmau, @ngaychidinh, @lanin, @nguoitao, @ngayud)", 
					"@id",  _MedKetQuaChanDoan.id, 
					"@id_vienphi",  _MedKetQuaChanDoan.id_vienphi, 
					"@mabn",  _MedKetQuaChanDoan.mabn, 
					"@mavv",  _MedKetQuaChanDoan.mavv, 
					"@maql",  _MedKetQuaChanDoan.maql, 
					"@id_kp",  _MedKetQuaChanDoan.id_kp, 
					"@id_bacsi",  _MedKetQuaChanDoan.id_bacsi, 
					"@id_chidinh",  _MedKetQuaChanDoan.id_chidinh, 
					"@id_maumota",  _MedKetQuaChanDoan.id_maumota, 
					"@ngay", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngay), 
					"@chandoan",  _MedKetQuaChanDoan.chandoan, 
					"@mota",  _MedKetQuaChanDoan.mota, 
					"@ketluan",  _MedKetQuaChanDoan.ketluan, 
					"@ketluanmau",  _MedKetQuaChanDoan.ketluanmau, 
					"@ngaychidinh", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngaychidinh), 
					"@lanin",  _MedKetQuaChanDoan.lanin, 
					"@nguoitao",  _MedKetQuaChanDoan.nguoitao, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngayud));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaChanDoan vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKetQuaChanDoan> _MedKetQuaChanDoans)
		{
			foreach (MedKetQuaChanDoan item in _MedKetQuaChanDoans)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaChanDoan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKetQuaChanDoan _MedKetQuaChanDoan, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaChanDoan] SET id=@id, id_vienphi=@id_vienphi, mabn=@mabn, mavv=@mavv, maql=@maql, id_kp=@id_kp, id_bacsi=@id_bacsi, id_chidinh=@id_chidinh, id_maumota=@id_maumota, ngay=@ngay, chandoan=@chandoan, mota=@mota, ketluan=@ketluan, ketluanmau=@ketluanmau, ngaychidinh=@ngaychidinh, lanin=@lanin, nguoitao=@nguoitao, ngayud=@ngayud WHERE id=@id", 
					"@id",  _MedKetQuaChanDoan.id, 
					"@id_vienphi",  _MedKetQuaChanDoan.id_vienphi, 
					"@mabn",  _MedKetQuaChanDoan.mabn, 
					"@mavv",  _MedKetQuaChanDoan.mavv, 
					"@maql",  _MedKetQuaChanDoan.maql, 
					"@id_kp",  _MedKetQuaChanDoan.id_kp, 
					"@id_bacsi",  _MedKetQuaChanDoan.id_bacsi, 
					"@id_chidinh",  _MedKetQuaChanDoan.id_chidinh, 
					"@id_maumota",  _MedKetQuaChanDoan.id_maumota, 
					"@ngay", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngay), 
					"@chandoan",  _MedKetQuaChanDoan.chandoan, 
					"@mota",  _MedKetQuaChanDoan.mota, 
					"@ketluan",  _MedKetQuaChanDoan.ketluan, 
					"@ketluanmau",  _MedKetQuaChanDoan.ketluanmau, 
					"@ngaychidinh", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngaychidinh), 
					"@lanin",  _MedKetQuaChanDoan.lanin, 
					"@nguoitao",  _MedKetQuaChanDoan.nguoitao, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngayud), 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaChanDoan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKetQuaChanDoan _MedKetQuaChanDoan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaChanDoan] SET id_vienphi=@id_vienphi, mabn=@mabn, mavv=@mavv, maql=@maql, id_kp=@id_kp, id_bacsi=@id_bacsi, id_chidinh=@id_chidinh, id_maumota=@id_maumota, ngay=@ngay, chandoan=@chandoan, mota=@mota, ketluan=@ketluan, ketluanmau=@ketluanmau, ngaychidinh=@ngaychidinh, lanin=@lanin, nguoitao=@nguoitao, ngayud=@ngayud WHERE id=@id", 
					"@id_vienphi",  _MedKetQuaChanDoan.id_vienphi, 
					"@mabn",  _MedKetQuaChanDoan.mabn, 
					"@mavv",  _MedKetQuaChanDoan.mavv, 
					"@maql",  _MedKetQuaChanDoan.maql, 
					"@id_kp",  _MedKetQuaChanDoan.id_kp, 
					"@id_bacsi",  _MedKetQuaChanDoan.id_bacsi, 
					"@id_chidinh",  _MedKetQuaChanDoan.id_chidinh, 
					"@id_maumota",  _MedKetQuaChanDoan.id_maumota, 
					"@ngay", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngay), 
					"@chandoan",  _MedKetQuaChanDoan.chandoan, 
					"@mota",  _MedKetQuaChanDoan.mota, 
					"@ketluan",  _MedKetQuaChanDoan.ketluan, 
					"@ketluanmau",  _MedKetQuaChanDoan.ketluanmau, 
					"@ngaychidinh", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngaychidinh), 
					"@lanin",  _MedKetQuaChanDoan.lanin, 
					"@nguoitao",  _MedKetQuaChanDoan.nguoitao, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngayud), 
					"@id", _MedKetQuaChanDoan.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKetQuaChanDoan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKetQuaChanDoan> _MedKetQuaChanDoans)
		{
			foreach (MedKetQuaChanDoan item in _MedKetQuaChanDoans)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaChanDoan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKetQuaChanDoan _MedKetQuaChanDoan, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaChanDoan] SET id=@id, id_vienphi=@id_vienphi, mabn=@mabn, mavv=@mavv, maql=@maql, id_kp=@id_kp, id_bacsi=@id_bacsi, id_chidinh=@id_chidinh, id_maumota=@id_maumota, ngay=@ngay, chandoan=@chandoan, mota=@mota, ketluan=@ketluan, ketluanmau=@ketluanmau, ngaychidinh=@ngaychidinh, lanin=@lanin, nguoitao=@nguoitao, ngayud=@ngayud "+ condition, 
					"@id",  _MedKetQuaChanDoan.id, 
					"@id_vienphi",  _MedKetQuaChanDoan.id_vienphi, 
					"@mabn",  _MedKetQuaChanDoan.mabn, 
					"@mavv",  _MedKetQuaChanDoan.mavv, 
					"@maql",  _MedKetQuaChanDoan.maql, 
					"@id_kp",  _MedKetQuaChanDoan.id_kp, 
					"@id_bacsi",  _MedKetQuaChanDoan.id_bacsi, 
					"@id_chidinh",  _MedKetQuaChanDoan.id_chidinh, 
					"@id_maumota",  _MedKetQuaChanDoan.id_maumota, 
					"@ngay", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngay), 
					"@chandoan",  _MedKetQuaChanDoan.chandoan, 
					"@mota",  _MedKetQuaChanDoan.mota, 
					"@ketluan",  _MedKetQuaChanDoan.ketluan, 
					"@ketluanmau",  _MedKetQuaChanDoan.ketluanmau, 
					"@ngaychidinh", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngaychidinh), 
					"@lanin",  _MedKetQuaChanDoan.lanin, 
					"@nguoitao",  _MedKetQuaChanDoan.nguoitao, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQuaChanDoan.ngayud));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKetQuaChanDoan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaChanDoan] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaChanDoan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKetQuaChanDoan _MedKetQuaChanDoan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaChanDoan] WHERE id=@id",
					"@id", _MedKetQuaChanDoan.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaChanDoan trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaChanDoan] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaChanDoan trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKetQuaChanDoan> _MedKetQuaChanDoans)
		{
			foreach (MedKetQuaChanDoan item in _MedKetQuaChanDoans)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
