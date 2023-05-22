using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEddmten:IMEddmten
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEddmten(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedDmTen từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmTen]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedDmTen từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmTen] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedDmTen từ Database
		/// </summary>
		public List<MedDmTen> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmTen]");
				List<MedDmTen> items = new List<MedDmTen>();
				MedDmTen item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedDmTen();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["dmso"] != null && dr["dmso"] != DBNull.Value)
					{
						item.dmso = Convert.ToInt32(dr["dmso"]);
					}
					if (dr["vienphi"] != null && dr["vienphi"] != DBNull.Value)
					{
						item.vienphi = Convert.ToInt32(dr["vienphi"]);
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
					if (dr["dvt"] != null && dr["dvt"] != DBNull.Value)
					{
						item.dvt = Convert.ToString(dr["dvt"]);
					}
					if (dr["tieuban"] != null && dr["tieuban"] != DBNull.Value)
					{
						item.tieuban = Convert.ToInt32(dr["tieuban"]);
					}
					if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
					{
						item.viettat = Convert.ToString(dr["viettat"]);
					}
					if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
					{
						item.sudung = Convert.ToInt32(dr["sudung"]);
					}
					if (dr["report"] != null && dr["report"] != DBNull.Value)
					{
						item.report = Convert.ToString(dr["report"]);
					}
					if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
					{
						item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
					}
					if (dr["tuongduong"] != null && dr["tuongduong"] != DBNull.Value)
					{
						item.tuongduong = Convert.ToInt32(dr["tuongduong"]);
					}
					if (dr["hiv"] != null && dr["hiv"] != DBNull.Value)
					{
						item.hiv = Convert.ToInt32(dr["hiv"]);
					}
					if (dr["thoigiantra"] != null && dr["thoigiantra"] != DBNull.Value)
					{
						item.thoigiantra = Convert.ToInt32(dr["thoigiantra"]);
					}
					if (dr["thoigiantra_cc"] != null && dr["thoigiantra_cc"] != DBNull.Value)
					{
						item.thoigiantra_cc = Convert.ToInt32(dr["thoigiantra_cc"]);
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
		/// Lấy danh sách MedDmTen từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedDmTen> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedDmTen] A "+ condition,  parameters);
				List<MedDmTen> items = new List<MedDmTen>();
				MedDmTen item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedDmTen();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["dmso"] != null && dr["dmso"] != DBNull.Value)
					{
						item.dmso = Convert.ToInt32(dr["dmso"]);
					}
					if (dr["vienphi"] != null && dr["vienphi"] != DBNull.Value)
					{
						item.vienphi = Convert.ToInt32(dr["vienphi"]);
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
					if (dr["dvt"] != null && dr["dvt"] != DBNull.Value)
					{
						item.dvt = Convert.ToString(dr["dvt"]);
					}
					if (dr["tieuban"] != null && dr["tieuban"] != DBNull.Value)
					{
						item.tieuban = Convert.ToInt32(dr["tieuban"]);
					}
					if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
					{
						item.viettat = Convert.ToString(dr["viettat"]);
					}
					if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
					{
						item.sudung = Convert.ToInt32(dr["sudung"]);
					}
					if (dr["report"] != null && dr["report"] != DBNull.Value)
					{
						item.report = Convert.ToString(dr["report"]);
					}
					if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
					{
						item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
					}
					if (dr["tuongduong"] != null && dr["tuongduong"] != DBNull.Value)
					{
						item.tuongduong = Convert.ToInt32(dr["tuongduong"]);
					}
					if (dr["hiv"] != null && dr["hiv"] != DBNull.Value)
					{
						item.hiv = Convert.ToInt32(dr["hiv"]);
					}
					if (dr["thoigiantra"] != null && dr["thoigiantra"] != DBNull.Value)
					{
						item.thoigiantra = Convert.ToInt32(dr["thoigiantra"]);
					}
					if (dr["thoigiantra_cc"] != null && dr["thoigiantra_cc"] != DBNull.Value)
					{
						item.thoigiantra_cc = Convert.ToInt32(dr["thoigiantra_cc"]);
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

		public List<MedDmTen> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedDmTen] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedDmTen] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedDmTen>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedDmTen từ Database
		/// </summary>
		public MedDmTen GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmTen] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedDmTen item=new MedDmTen();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["dmso"] != null && dr["dmso"] != DBNull.Value)
						{
							item.dmso = Convert.ToInt32(dr["dmso"]);
						}
						if (dr["vienphi"] != null && dr["vienphi"] != DBNull.Value)
						{
							item.vienphi = Convert.ToInt32(dr["vienphi"]);
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
						if (dr["dvt"] != null && dr["dvt"] != DBNull.Value)
						{
							item.dvt = Convert.ToString(dr["dvt"]);
						}
						if (dr["tieuban"] != null && dr["tieuban"] != DBNull.Value)
						{
							item.tieuban = Convert.ToInt32(dr["tieuban"]);
						}
						if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
						{
							item.viettat = Convert.ToString(dr["viettat"]);
						}
						if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
						{
							item.sudung = Convert.ToInt32(dr["sudung"]);
						}
						if (dr["report"] != null && dr["report"] != DBNull.Value)
						{
							item.report = Convert.ToString(dr["report"]);
						}
						if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
						{
							item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
						}
						if (dr["tuongduong"] != null && dr["tuongduong"] != DBNull.Value)
						{
							item.tuongduong = Convert.ToInt32(dr["tuongduong"]);
						}
						if (dr["hiv"] != null && dr["hiv"] != DBNull.Value)
						{
							item.hiv = Convert.ToInt32(dr["hiv"]);
						}
						if (dr["thoigiantra"] != null && dr["thoigiantra"] != DBNull.Value)
						{
							item.thoigiantra = Convert.ToInt32(dr["thoigiantra"]);
						}
						if (dr["thoigiantra_cc"] != null && dr["thoigiantra_cc"] != DBNull.Value)
						{
							item.thoigiantra_cc = Convert.ToInt32(dr["thoigiantra_cc"]);
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
		/// Lấy một MedDmTen đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedDmTen GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedDmTen] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedDmTen item=new MedDmTen();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["dmso"] != null && dr["dmso"] != DBNull.Value)
						{
							item.dmso = Convert.ToInt32(dr["dmso"]);
						}
						if (dr["vienphi"] != null && dr["vienphi"] != DBNull.Value)
						{
							item.vienphi = Convert.ToInt32(dr["vienphi"]);
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
						if (dr["dvt"] != null && dr["dvt"] != DBNull.Value)
						{
							item.dvt = Convert.ToString(dr["dvt"]);
						}
						if (dr["tieuban"] != null && dr["tieuban"] != DBNull.Value)
						{
							item.tieuban = Convert.ToInt32(dr["tieuban"]);
						}
						if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
						{
							item.viettat = Convert.ToString(dr["viettat"]);
						}
						if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
						{
							item.sudung = Convert.ToInt32(dr["sudung"]);
						}
						if (dr["report"] != null && dr["report"] != DBNull.Value)
						{
							item.report = Convert.ToString(dr["report"]);
						}
						if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
						{
							item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
						}
						if (dr["tuongduong"] != null && dr["tuongduong"] != DBNull.Value)
						{
							item.tuongduong = Convert.ToInt32(dr["tuongduong"]);
						}
						if (dr["hiv"] != null && dr["hiv"] != DBNull.Value)
						{
							item.hiv = Convert.ToInt32(dr["hiv"]);
						}
						if (dr["thoigiantra"] != null && dr["thoigiantra"] != DBNull.Value)
						{
							item.thoigiantra = Convert.ToInt32(dr["thoigiantra"]);
						}
						if (dr["thoigiantra_cc"] != null && dr["thoigiantra_cc"] != DBNull.Value)
						{
							item.thoigiantra_cc = Convert.ToInt32(dr["thoigiantra_cc"]);
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

		public MedDmTen GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedDmTen] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedDmTen>(ds);
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
		/// Thêm mới MedDmTen vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedDmTen _MedDmTen)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedDmTen](id, dmso, vienphi, stt, ma, ten, dvt, tieuban, viettat, sudung, report, id_mayxn, tuongduong, hiv, thoigiantra, thoigiantra_cc) VALUES(@id, @dmso, @vienphi, @stt, @ma, @ten, @dvt, @tieuban, @viettat, @sudung, @report, @id_mayxn, @tuongduong, @hiv, @thoigiantra, @thoigiantra_cc)", 
					"@id",  _MedDmTen.id, 
					"@dmso",  _MedDmTen.dmso, 
					"@vienphi",  _MedDmTen.vienphi, 
					"@stt",  _MedDmTen.stt, 
					"@ma",  _MedDmTen.ma, 
					"@ten",  _MedDmTen.ten, 
					"@dvt",  _MedDmTen.dvt, 
					"@tieuban",  _MedDmTen.tieuban, 
					"@viettat",  _MedDmTen.viettat, 
					"@sudung",  _MedDmTen.sudung, 
					"@report",  _MedDmTen.report, 
					"@id_mayxn",  _MedDmTen.id_mayxn, 
					"@tuongduong",  _MedDmTen.tuongduong, 
					"@hiv",  _MedDmTen.hiv, 
					"@thoigiantra",  _MedDmTen.thoigiantra, 
					"@thoigiantra_cc",  _MedDmTen.thoigiantra_cc);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedDmTen vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedDmTen> _MedDmTens)
		{
			foreach (MedDmTen item in _MedDmTens)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedDmTen vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedDmTen _MedDmTen, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmTen] SET id=@id, dmso=@dmso, vienphi=@vienphi, stt=@stt, ma=@ma, ten=@ten, dvt=@dvt, tieuban=@tieuban, viettat=@viettat, sudung=@sudung, report=@report, id_mayxn=@id_mayxn, tuongduong=@tuongduong, hiv=@hiv, thoigiantra=@thoigiantra, thoigiantra_cc=@thoigiantra_cc WHERE id=@id", 
					"@id",  _MedDmTen.id, 
					"@dmso",  _MedDmTen.dmso, 
					"@vienphi",  _MedDmTen.vienphi, 
					"@stt",  _MedDmTen.stt, 
					"@ma",  _MedDmTen.ma, 
					"@ten",  _MedDmTen.ten, 
					"@dvt",  _MedDmTen.dvt, 
					"@tieuban",  _MedDmTen.tieuban, 
					"@viettat",  _MedDmTen.viettat, 
					"@sudung",  _MedDmTen.sudung, 
					"@report",  _MedDmTen.report, 
					"@id_mayxn",  _MedDmTen.id_mayxn, 
					"@tuongduong",  _MedDmTen.tuongduong, 
					"@hiv",  _MedDmTen.hiv, 
					"@thoigiantra",  _MedDmTen.thoigiantra, 
					"@thoigiantra_cc",  _MedDmTen.thoigiantra_cc, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedDmTen vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedDmTen _MedDmTen)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmTen] SET dmso=@dmso, vienphi=@vienphi, stt=@stt, ma=@ma, ten=@ten, dvt=@dvt, tieuban=@tieuban, viettat=@viettat, sudung=@sudung, report=@report, id_mayxn=@id_mayxn, tuongduong=@tuongduong, hiv=@hiv, thoigiantra=@thoigiantra, thoigiantra_cc=@thoigiantra_cc WHERE id=@id", 
					"@dmso",  _MedDmTen.dmso, 
					"@vienphi",  _MedDmTen.vienphi, 
					"@stt",  _MedDmTen.stt, 
					"@ma",  _MedDmTen.ma, 
					"@ten",  _MedDmTen.ten, 
					"@dvt",  _MedDmTen.dvt, 
					"@tieuban",  _MedDmTen.tieuban, 
					"@viettat",  _MedDmTen.viettat, 
					"@sudung",  _MedDmTen.sudung, 
					"@report",  _MedDmTen.report, 
					"@id_mayxn",  _MedDmTen.id_mayxn, 
					"@tuongduong",  _MedDmTen.tuongduong, 
					"@hiv",  _MedDmTen.hiv, 
					"@thoigiantra",  _MedDmTen.thoigiantra, 
					"@thoigiantra_cc",  _MedDmTen.thoigiantra_cc, 
					"@id", _MedDmTen.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedDmTen vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedDmTen> _MedDmTens)
		{
			foreach (MedDmTen item in _MedDmTens)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedDmTen vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedDmTen _MedDmTen, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmTen] SET id=@id, dmso=@dmso, vienphi=@vienphi, stt=@stt, ma=@ma, ten=@ten, dvt=@dvt, tieuban=@tieuban, viettat=@viettat, sudung=@sudung, report=@report, id_mayxn=@id_mayxn, tuongduong=@tuongduong, hiv=@hiv, thoigiantra=@thoigiantra, thoigiantra_cc=@thoigiantra_cc "+ condition, 
					"@id",  _MedDmTen.id, 
					"@dmso",  _MedDmTen.dmso, 
					"@vienphi",  _MedDmTen.vienphi, 
					"@stt",  _MedDmTen.stt, 
					"@ma",  _MedDmTen.ma, 
					"@ten",  _MedDmTen.ten, 
					"@dvt",  _MedDmTen.dvt, 
					"@tieuban",  _MedDmTen.tieuban, 
					"@viettat",  _MedDmTen.viettat, 
					"@sudung",  _MedDmTen.sudung, 
					"@report",  _MedDmTen.report, 
					"@id_mayxn",  _MedDmTen.id_mayxn, 
					"@tuongduong",  _MedDmTen.tuongduong, 
					"@hiv",  _MedDmTen.hiv, 
					"@thoigiantra",  _MedDmTen.thoigiantra, 
					"@thoigiantra_cc",  _MedDmTen.thoigiantra_cc);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedDmTen trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmTen] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmTen trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedDmTen _MedDmTen)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmTen] WHERE id=@id",
					"@id", _MedDmTen.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmTen trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmTen] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmTen trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedDmTen> _MedDmTens)
		{
			foreach (MedDmTen item in _MedDmTens)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
