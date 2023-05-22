using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdgiavp:IMEdgiavp
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdgiavp(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedGiaVp từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedGiaVp]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedGiaVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedGiaVp] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedGiaVp từ Database
		/// </summary>
		public List<MedGiaVp> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedGiaVp]");
				List<MedGiaVp> items = new List<MedGiaVp>();
				MedGiaVp item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedGiaVp();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["id_loai"] != null && dr["id_loai"] != DBNull.Value)
					{
						item.id_loai = Convert.ToInt32(dr["id_loai"]);
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
					if (dr["bhyt"] != null && dr["bhyt"] != DBNull.Value)
					{
						item.bhyt = Convert.ToInt32(dr["bhyt"]);
					}
					if (dr["gia_th"] != null && dr["gia_th"] != DBNull.Value)
					{
						item.gia_th = Convert.ToInt32(dr["gia_th"]);
					}
					if (dr["gia_bh"] != null && dr["gia_bh"] != DBNull.Value)
					{
						item.gia_bh = Convert.ToInt32(dr["gia_bh"]);
					}
					if (dr["gia_yc"] != null && dr["gia_yc"] != DBNull.Value)
					{
						item.gia_yc = Convert.ToInt32(dr["gia_yc"]);
					}
					if (dr["gia_nn"] != null && dr["gia_nn"] != DBNull.Value)
					{
						item.gia_nn = Convert.ToInt32(dr["gia_nn"]);
					}
					if (dr["chenhlech"] != null && dr["chenhlech"] != DBNull.Value)
					{
						item.chenhlech = Convert.ToInt32(dr["chenhlech"]);
					}
					if (dr["goi"] != null && dr["goi"] != DBNull.Value)
					{
						item.goi = Convert.ToString(dr["goi"]);
					}
					if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
					{
						item.sudung = Convert.ToInt32(dr["sudung"]);
					}
					if (dr["ktc"] != null && dr["ktc"] != DBNull.Value)
					{
						item.ktc = Convert.ToInt32(dr["ktc"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["phuthu"] != null && dr["phuthu"] != DBNull.Value)
					{
						item.phuthu = Convert.ToInt32(dr["phuthu"]);
					}
					if (dr["boiduong"] != null && dr["boiduong"] != DBNull.Value)
					{
						item.boiduong = Convert.ToInt32(dr["boiduong"]);
					}
					if (dr["gia_byt"] != null && dr["gia_byt"] != DBNull.Value)
					{
						item.gia_byt = Convert.ToInt32(dr["gia_byt"]);
					}
					if (dr["stt_03"] != null && dr["stt_03"] != DBNull.Value)
					{
						item.stt_03 = Convert.ToString(dr["stt_03"]);
					}
					if (dr["stt_04"] != null && dr["stt_04"] != DBNull.Value)
					{
						item.stt_04 = Convert.ToString(dr["stt_04"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToString(dr["stt"]);
					}
					if (dr["ten_cu"] != null && dr["ten_cu"] != DBNull.Value)
					{
						item.ten_cu = Convert.ToString(dr["ten_cu"]);
					}
					if (dr["thutu"] != null && dr["thutu"] != DBNull.Value)
					{
						item.thutu = Convert.ToString(dr["thutu"]);
					}
					if (dr["id_nhombc"] != null && dr["id_nhombc"] != DBNull.Value)
					{
						item.id_nhombc = Convert.ToInt32(dr["id_nhombc"]);
					}
					if (dr["tenkhongdau"] != null && dr["tenkhongdau"] != DBNull.Value)
					{
						item.tenkhongdau = Convert.ToString(dr["tenkhongdau"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["id_loaipt"] != null && dr["id_loaipt"] != DBNull.Value)
					{
						item.id_loaipt = Convert.ToInt32(dr["id_loaipt"]);
					}
					if (dr["hoichan"] != null && dr["hoichan"] != DBNull.Value)
					{
						item.hoichan = Convert.ToInt32(dr["hoichan"]);
					}
					if (dr["lienket"] != null && dr["lienket"] != DBNull.Value)
					{
						item.lienket = Convert.ToInt32(dr["lienket"]);
					}
					if (dr["ma_icd"] != null && dr["ma_icd"] != DBNull.Value)
					{
						item.ma_icd = Convert.ToString(dr["ma_icd"]);
					}
					if (dr["id_nhomkt"] != null && dr["id_nhomkt"] != DBNull.Value)
					{
						item.id_nhomkt = Convert.ToString(dr["id_nhomkt"]);
					}
					if (dr["cls"] != null && dr["cls"] != DBNull.Value)
					{
						item.cls = Convert.ToString(dr["cls"]);
					}
					if (dr["covid"] != null && dr["covid"] != DBNull.Value)
					{
						item.covid = Convert.ToString(dr["covid"]);
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
		/// Lấy danh sách MedGiaVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedGiaVp> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedGiaVp] A "+ condition,  parameters);
				List<MedGiaVp> items = new List<MedGiaVp>();
				MedGiaVp item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedGiaVp();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["id_loai"] != null && dr["id_loai"] != DBNull.Value)
					{
						item.id_loai = Convert.ToInt32(dr["id_loai"]);
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
					if (dr["bhyt"] != null && dr["bhyt"] != DBNull.Value)
					{
						item.bhyt = Convert.ToInt32(dr["bhyt"]);
					}
					if (dr["gia_th"] != null && dr["gia_th"] != DBNull.Value)
					{
						item.gia_th = Convert.ToInt32(dr["gia_th"]);
					}
					if (dr["gia_bh"] != null && dr["gia_bh"] != DBNull.Value)
					{
						item.gia_bh = Convert.ToInt32(dr["gia_bh"]);
					}
					if (dr["gia_yc"] != null && dr["gia_yc"] != DBNull.Value)
					{
						item.gia_yc = Convert.ToInt32(dr["gia_yc"]);
					}
					if (dr["gia_nn"] != null && dr["gia_nn"] != DBNull.Value)
					{
						item.gia_nn = Convert.ToInt32(dr["gia_nn"]);
					}
					if (dr["chenhlech"] != null && dr["chenhlech"] != DBNull.Value)
					{
						item.chenhlech = Convert.ToInt32(dr["chenhlech"]);
					}
					if (dr["goi"] != null && dr["goi"] != DBNull.Value)
					{
						item.goi = Convert.ToString(dr["goi"]);
					}
					if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
					{
						item.sudung = Convert.ToInt32(dr["sudung"]);
					}
					if (dr["ktc"] != null && dr["ktc"] != DBNull.Value)
					{
						item.ktc = Convert.ToInt32(dr["ktc"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["phuthu"] != null && dr["phuthu"] != DBNull.Value)
					{
						item.phuthu = Convert.ToInt32(dr["phuthu"]);
					}
					if (dr["boiduong"] != null && dr["boiduong"] != DBNull.Value)
					{
						item.boiduong = Convert.ToInt32(dr["boiduong"]);
					}
					if (dr["gia_byt"] != null && dr["gia_byt"] != DBNull.Value)
					{
						item.gia_byt = Convert.ToInt32(dr["gia_byt"]);
					}
					if (dr["stt_03"] != null && dr["stt_03"] != DBNull.Value)
					{
						item.stt_03 = Convert.ToString(dr["stt_03"]);
					}
					if (dr["stt_04"] != null && dr["stt_04"] != DBNull.Value)
					{
						item.stt_04 = Convert.ToString(dr["stt_04"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToString(dr["stt"]);
					}
					if (dr["ten_cu"] != null && dr["ten_cu"] != DBNull.Value)
					{
						item.ten_cu = Convert.ToString(dr["ten_cu"]);
					}
					if (dr["thutu"] != null && dr["thutu"] != DBNull.Value)
					{
						item.thutu = Convert.ToString(dr["thutu"]);
					}
					if (dr["id_nhombc"] != null && dr["id_nhombc"] != DBNull.Value)
					{
						item.id_nhombc = Convert.ToInt32(dr["id_nhombc"]);
					}
					if (dr["tenkhongdau"] != null && dr["tenkhongdau"] != DBNull.Value)
					{
						item.tenkhongdau = Convert.ToString(dr["tenkhongdau"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["id_loaipt"] != null && dr["id_loaipt"] != DBNull.Value)
					{
						item.id_loaipt = Convert.ToInt32(dr["id_loaipt"]);
					}
					if (dr["hoichan"] != null && dr["hoichan"] != DBNull.Value)
					{
						item.hoichan = Convert.ToInt32(dr["hoichan"]);
					}
					if (dr["lienket"] != null && dr["lienket"] != DBNull.Value)
					{
						item.lienket = Convert.ToInt32(dr["lienket"]);
					}
					if (dr["ma_icd"] != null && dr["ma_icd"] != DBNull.Value)
					{
						item.ma_icd = Convert.ToString(dr["ma_icd"]);
					}
					if (dr["id_nhomkt"] != null && dr["id_nhomkt"] != DBNull.Value)
					{
						item.id_nhomkt = Convert.ToString(dr["id_nhomkt"]);
					}
					if (dr["cls"] != null && dr["cls"] != DBNull.Value)
					{
						item.cls = Convert.ToString(dr["cls"]);
					}
					if (dr["covid"] != null && dr["covid"] != DBNull.Value)
					{
						item.covid = Convert.ToString(dr["covid"]);
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

		public List<MedGiaVp> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedGiaVp] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedGiaVp] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedGiaVp>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedGiaVp từ Database
		/// </summary>
		public MedGiaVp GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedGiaVp] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedGiaVp item=new MedGiaVp();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["id_loai"] != null && dr["id_loai"] != DBNull.Value)
						{
							item.id_loai = Convert.ToInt32(dr["id_loai"]);
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
						if (dr["bhyt"] != null && dr["bhyt"] != DBNull.Value)
						{
							item.bhyt = Convert.ToInt32(dr["bhyt"]);
						}
						if (dr["gia_th"] != null && dr["gia_th"] != DBNull.Value)
						{
							item.gia_th = Convert.ToInt32(dr["gia_th"]);
						}
						if (dr["gia_bh"] != null && dr["gia_bh"] != DBNull.Value)
						{
							item.gia_bh = Convert.ToInt32(dr["gia_bh"]);
						}
						if (dr["gia_yc"] != null && dr["gia_yc"] != DBNull.Value)
						{
							item.gia_yc = Convert.ToInt32(dr["gia_yc"]);
						}
						if (dr["gia_nn"] != null && dr["gia_nn"] != DBNull.Value)
						{
							item.gia_nn = Convert.ToInt32(dr["gia_nn"]);
						}
						if (dr["chenhlech"] != null && dr["chenhlech"] != DBNull.Value)
						{
							item.chenhlech = Convert.ToInt32(dr["chenhlech"]);
						}
						if (dr["goi"] != null && dr["goi"] != DBNull.Value)
						{
							item.goi = Convert.ToString(dr["goi"]);
						}
						if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
						{
							item.sudung = Convert.ToInt32(dr["sudung"]);
						}
						if (dr["ktc"] != null && dr["ktc"] != DBNull.Value)
						{
							item.ktc = Convert.ToInt32(dr["ktc"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["phuthu"] != null && dr["phuthu"] != DBNull.Value)
						{
							item.phuthu = Convert.ToInt32(dr["phuthu"]);
						}
						if (dr["boiduong"] != null && dr["boiduong"] != DBNull.Value)
						{
							item.boiduong = Convert.ToInt32(dr["boiduong"]);
						}
						if (dr["gia_byt"] != null && dr["gia_byt"] != DBNull.Value)
						{
							item.gia_byt = Convert.ToInt32(dr["gia_byt"]);
						}
						if (dr["stt_03"] != null && dr["stt_03"] != DBNull.Value)
						{
							item.stt_03 = Convert.ToString(dr["stt_03"]);
						}
						if (dr["stt_04"] != null && dr["stt_04"] != DBNull.Value)
						{
							item.stt_04 = Convert.ToString(dr["stt_04"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToString(dr["stt"]);
						}
						if (dr["ten_cu"] != null && dr["ten_cu"] != DBNull.Value)
						{
							item.ten_cu = Convert.ToString(dr["ten_cu"]);
						}
						if (dr["thutu"] != null && dr["thutu"] != DBNull.Value)
						{
							item.thutu = Convert.ToString(dr["thutu"]);
						}
						if (dr["id_nhombc"] != null && dr["id_nhombc"] != DBNull.Value)
						{
							item.id_nhombc = Convert.ToInt32(dr["id_nhombc"]);
						}
						if (dr["tenkhongdau"] != null && dr["tenkhongdau"] != DBNull.Value)
						{
							item.tenkhongdau = Convert.ToString(dr["tenkhongdau"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["id_loaipt"] != null && dr["id_loaipt"] != DBNull.Value)
						{
							item.id_loaipt = Convert.ToInt32(dr["id_loaipt"]);
						}
						if (dr["hoichan"] != null && dr["hoichan"] != DBNull.Value)
						{
							item.hoichan = Convert.ToInt32(dr["hoichan"]);
						}
						if (dr["lienket"] != null && dr["lienket"] != DBNull.Value)
						{
							item.lienket = Convert.ToInt32(dr["lienket"]);
						}
						if (dr["ma_icd"] != null && dr["ma_icd"] != DBNull.Value)
						{
							item.ma_icd = Convert.ToString(dr["ma_icd"]);
						}
						if (dr["id_nhomkt"] != null && dr["id_nhomkt"] != DBNull.Value)
						{
							item.id_nhomkt = Convert.ToString(dr["id_nhomkt"]);
						}
						if (dr["cls"] != null && dr["cls"] != DBNull.Value)
						{
							item.cls = Convert.ToString(dr["cls"]);
						}
						if (dr["covid"] != null && dr["covid"] != DBNull.Value)
						{
							item.covid = Convert.ToString(dr["covid"]);
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
		/// Lấy một MedGiaVp đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedGiaVp GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedGiaVp] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedGiaVp item=new MedGiaVp();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["id_loai"] != null && dr["id_loai"] != DBNull.Value)
						{
							item.id_loai = Convert.ToInt32(dr["id_loai"]);
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
						if (dr["bhyt"] != null && dr["bhyt"] != DBNull.Value)
						{
							item.bhyt = Convert.ToInt32(dr["bhyt"]);
						}
						if (dr["gia_th"] != null && dr["gia_th"] != DBNull.Value)
						{
							item.gia_th = Convert.ToInt32(dr["gia_th"]);
						}
						if (dr["gia_bh"] != null && dr["gia_bh"] != DBNull.Value)
						{
							item.gia_bh = Convert.ToInt32(dr["gia_bh"]);
						}
						if (dr["gia_yc"] != null && dr["gia_yc"] != DBNull.Value)
						{
							item.gia_yc = Convert.ToInt32(dr["gia_yc"]);
						}
						if (dr["gia_nn"] != null && dr["gia_nn"] != DBNull.Value)
						{
							item.gia_nn = Convert.ToInt32(dr["gia_nn"]);
						}
						if (dr["chenhlech"] != null && dr["chenhlech"] != DBNull.Value)
						{
							item.chenhlech = Convert.ToInt32(dr["chenhlech"]);
						}
						if (dr["goi"] != null && dr["goi"] != DBNull.Value)
						{
							item.goi = Convert.ToString(dr["goi"]);
						}
						if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
						{
							item.sudung = Convert.ToInt32(dr["sudung"]);
						}
						if (dr["ktc"] != null && dr["ktc"] != DBNull.Value)
						{
							item.ktc = Convert.ToInt32(dr["ktc"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["phuthu"] != null && dr["phuthu"] != DBNull.Value)
						{
							item.phuthu = Convert.ToInt32(dr["phuthu"]);
						}
						if (dr["boiduong"] != null && dr["boiduong"] != DBNull.Value)
						{
							item.boiduong = Convert.ToInt32(dr["boiduong"]);
						}
						if (dr["gia_byt"] != null && dr["gia_byt"] != DBNull.Value)
						{
							item.gia_byt = Convert.ToInt32(dr["gia_byt"]);
						}
						if (dr["stt_03"] != null && dr["stt_03"] != DBNull.Value)
						{
							item.stt_03 = Convert.ToString(dr["stt_03"]);
						}
						if (dr["stt_04"] != null && dr["stt_04"] != DBNull.Value)
						{
							item.stt_04 = Convert.ToString(dr["stt_04"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToString(dr["stt"]);
						}
						if (dr["ten_cu"] != null && dr["ten_cu"] != DBNull.Value)
						{
							item.ten_cu = Convert.ToString(dr["ten_cu"]);
						}
						if (dr["thutu"] != null && dr["thutu"] != DBNull.Value)
						{
							item.thutu = Convert.ToString(dr["thutu"]);
						}
						if (dr["id_nhombc"] != null && dr["id_nhombc"] != DBNull.Value)
						{
							item.id_nhombc = Convert.ToInt32(dr["id_nhombc"]);
						}
						if (dr["tenkhongdau"] != null && dr["tenkhongdau"] != DBNull.Value)
						{
							item.tenkhongdau = Convert.ToString(dr["tenkhongdau"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["id_loaipt"] != null && dr["id_loaipt"] != DBNull.Value)
						{
							item.id_loaipt = Convert.ToInt32(dr["id_loaipt"]);
						}
						if (dr["hoichan"] != null && dr["hoichan"] != DBNull.Value)
						{
							item.hoichan = Convert.ToInt32(dr["hoichan"]);
						}
						if (dr["lienket"] != null && dr["lienket"] != DBNull.Value)
						{
							item.lienket = Convert.ToInt32(dr["lienket"]);
						}
						if (dr["ma_icd"] != null && dr["ma_icd"] != DBNull.Value)
						{
							item.ma_icd = Convert.ToString(dr["ma_icd"]);
						}
						if (dr["id_nhomkt"] != null && dr["id_nhomkt"] != DBNull.Value)
						{
							item.id_nhomkt = Convert.ToString(dr["id_nhomkt"]);
						}
						if (dr["cls"] != null && dr["cls"] != DBNull.Value)
						{
							item.cls = Convert.ToString(dr["cls"]);
						}
						if (dr["covid"] != null && dr["covid"] != DBNull.Value)
						{
							item.covid = Convert.ToString(dr["covid"]);
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

		public MedGiaVp GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedGiaVp] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedGiaVp>(ds);
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
		/// Thêm mới MedGiaVp vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedGiaVp _MedGiaVp)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedGiaVp](id, id_loai, ma, ten, dvt, bhyt, gia_th, gia_bh, gia_yc, gia_nn, chenhlech, goi, sudung, ktc, userid, ngayud, phuthu, boiduong, gia_byt, stt_03, stt_04, stt, ten_cu, thutu, id_nhombc, tenkhongdau, ghichu, id_loaipt, hoichan, lienket, ma_icd, id_nhomkt, cls, covid) VALUES(@id, @id_loai, @ma, @ten, @dvt, @bhyt, @gia_th, @gia_bh, @gia_yc, @gia_nn, @chenhlech, @goi, @sudung, @ktc, @userid, @ngayud, @phuthu, @boiduong, @gia_byt, @stt_03, @stt_04, @stt, @ten_cu, @thutu, @id_nhombc, @tenkhongdau, @ghichu, @id_loaipt, @hoichan, @lienket, @ma_icd, @id_nhomkt, @cls, @covid)", 
					"@id",  _MedGiaVp.id, 
					"@id_loai",  _MedGiaVp.id_loai, 
					"@ma",  _MedGiaVp.ma, 
					"@ten",  _MedGiaVp.ten, 
					"@dvt",  _MedGiaVp.dvt, 
					"@bhyt",  _MedGiaVp.bhyt, 
					"@gia_th",  _MedGiaVp.gia_th, 
					"@gia_bh",  _MedGiaVp.gia_bh, 
					"@gia_yc",  _MedGiaVp.gia_yc, 
					"@gia_nn",  _MedGiaVp.gia_nn, 
					"@chenhlech",  _MedGiaVp.chenhlech, 
					"@goi",  _MedGiaVp.goi, 
					"@sudung",  _MedGiaVp.sudung, 
					"@ktc",  _MedGiaVp.ktc, 
					"@userid",  _MedGiaVp.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedGiaVp.ngayud), 
					"@phuthu",  _MedGiaVp.phuthu, 
					"@boiduong",  _MedGiaVp.boiduong, 
					"@gia_byt",  _MedGiaVp.gia_byt, 
					"@stt_03",  _MedGiaVp.stt_03, 
					"@stt_04",  _MedGiaVp.stt_04, 
					"@stt",  _MedGiaVp.stt, 
					"@ten_cu",  _MedGiaVp.ten_cu, 
					"@thutu",  _MedGiaVp.thutu, 
					"@id_nhombc",  _MedGiaVp.id_nhombc, 
					"@tenkhongdau",  _MedGiaVp.tenkhongdau, 
					"@ghichu",  _MedGiaVp.ghichu, 
					"@id_loaipt",  _MedGiaVp.id_loaipt, 
					"@hoichan",  _MedGiaVp.hoichan, 
					"@lienket",  _MedGiaVp.lienket, 
					"@ma_icd",  _MedGiaVp.ma_icd, 
					"@id_nhomkt",  _MedGiaVp.id_nhomkt, 
					"@cls",  _MedGiaVp.cls, 
					"@covid",  _MedGiaVp.covid);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedGiaVp vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedGiaVp> _MedGiaVps)
		{
			foreach (MedGiaVp item in _MedGiaVps)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedGiaVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedGiaVp _MedGiaVp, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedGiaVp] SET id=@id, id_loai=@id_loai, ma=@ma, ten=@ten, dvt=@dvt, bhyt=@bhyt, gia_th=@gia_th, gia_bh=@gia_bh, gia_yc=@gia_yc, gia_nn=@gia_nn, chenhlech=@chenhlech, goi=@goi, sudung=@sudung, ktc=@ktc, userid=@userid, ngayud=@ngayud, phuthu=@phuthu, boiduong=@boiduong, gia_byt=@gia_byt, stt_03=@stt_03, stt_04=@stt_04, stt=@stt, ten_cu=@ten_cu, thutu=@thutu, id_nhombc=@id_nhombc, tenkhongdau=@tenkhongdau, ghichu=@ghichu, id_loaipt=@id_loaipt, hoichan=@hoichan, lienket=@lienket, ma_icd=@ma_icd, id_nhomkt=@id_nhomkt, cls=@cls, covid=@covid WHERE id=@id", 
					"@id",  _MedGiaVp.id, 
					"@id_loai",  _MedGiaVp.id_loai, 
					"@ma",  _MedGiaVp.ma, 
					"@ten",  _MedGiaVp.ten, 
					"@dvt",  _MedGiaVp.dvt, 
					"@bhyt",  _MedGiaVp.bhyt, 
					"@gia_th",  _MedGiaVp.gia_th, 
					"@gia_bh",  _MedGiaVp.gia_bh, 
					"@gia_yc",  _MedGiaVp.gia_yc, 
					"@gia_nn",  _MedGiaVp.gia_nn, 
					"@chenhlech",  _MedGiaVp.chenhlech, 
					"@goi",  _MedGiaVp.goi, 
					"@sudung",  _MedGiaVp.sudung, 
					"@ktc",  _MedGiaVp.ktc, 
					"@userid",  _MedGiaVp.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedGiaVp.ngayud), 
					"@phuthu",  _MedGiaVp.phuthu, 
					"@boiduong",  _MedGiaVp.boiduong, 
					"@gia_byt",  _MedGiaVp.gia_byt, 
					"@stt_03",  _MedGiaVp.stt_03, 
					"@stt_04",  _MedGiaVp.stt_04, 
					"@stt",  _MedGiaVp.stt, 
					"@ten_cu",  _MedGiaVp.ten_cu, 
					"@thutu",  _MedGiaVp.thutu, 
					"@id_nhombc",  _MedGiaVp.id_nhombc, 
					"@tenkhongdau",  _MedGiaVp.tenkhongdau, 
					"@ghichu",  _MedGiaVp.ghichu, 
					"@id_loaipt",  _MedGiaVp.id_loaipt, 
					"@hoichan",  _MedGiaVp.hoichan, 
					"@lienket",  _MedGiaVp.lienket, 
					"@ma_icd",  _MedGiaVp.ma_icd, 
					"@id_nhomkt",  _MedGiaVp.id_nhomkt, 
					"@cls",  _MedGiaVp.cls, 
					"@covid",  _MedGiaVp.covid, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedGiaVp vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedGiaVp _MedGiaVp)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedGiaVp] SET id_loai=@id_loai, ma=@ma, ten=@ten, dvt=@dvt, bhyt=@bhyt, gia_th=@gia_th, gia_bh=@gia_bh, gia_yc=@gia_yc, gia_nn=@gia_nn, chenhlech=@chenhlech, goi=@goi, sudung=@sudung, ktc=@ktc, userid=@userid, ngayud=@ngayud, phuthu=@phuthu, boiduong=@boiduong, gia_byt=@gia_byt, stt_03=@stt_03, stt_04=@stt_04, stt=@stt, ten_cu=@ten_cu, thutu=@thutu, id_nhombc=@id_nhombc, tenkhongdau=@tenkhongdau, ghichu=@ghichu, id_loaipt=@id_loaipt, hoichan=@hoichan, lienket=@lienket, ma_icd=@ma_icd, id_nhomkt=@id_nhomkt, cls=@cls, covid=@covid WHERE id=@id", 
					"@id_loai",  _MedGiaVp.id_loai, 
					"@ma",  _MedGiaVp.ma, 
					"@ten",  _MedGiaVp.ten, 
					"@dvt",  _MedGiaVp.dvt, 
					"@bhyt",  _MedGiaVp.bhyt, 
					"@gia_th",  _MedGiaVp.gia_th, 
					"@gia_bh",  _MedGiaVp.gia_bh, 
					"@gia_yc",  _MedGiaVp.gia_yc, 
					"@gia_nn",  _MedGiaVp.gia_nn, 
					"@chenhlech",  _MedGiaVp.chenhlech, 
					"@goi",  _MedGiaVp.goi, 
					"@sudung",  _MedGiaVp.sudung, 
					"@ktc",  _MedGiaVp.ktc, 
					"@userid",  _MedGiaVp.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedGiaVp.ngayud), 
					"@phuthu",  _MedGiaVp.phuthu, 
					"@boiduong",  _MedGiaVp.boiduong, 
					"@gia_byt",  _MedGiaVp.gia_byt, 
					"@stt_03",  _MedGiaVp.stt_03, 
					"@stt_04",  _MedGiaVp.stt_04, 
					"@stt",  _MedGiaVp.stt, 
					"@ten_cu",  _MedGiaVp.ten_cu, 
					"@thutu",  _MedGiaVp.thutu, 
					"@id_nhombc",  _MedGiaVp.id_nhombc, 
					"@tenkhongdau",  _MedGiaVp.tenkhongdau, 
					"@ghichu",  _MedGiaVp.ghichu, 
					"@id_loaipt",  _MedGiaVp.id_loaipt, 
					"@hoichan",  _MedGiaVp.hoichan, 
					"@lienket",  _MedGiaVp.lienket, 
					"@ma_icd",  _MedGiaVp.ma_icd, 
					"@id_nhomkt",  _MedGiaVp.id_nhomkt, 
					"@cls",  _MedGiaVp.cls, 
					"@covid",  _MedGiaVp.covid, 
					"@id", _MedGiaVp.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedGiaVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedGiaVp> _MedGiaVps)
		{
			foreach (MedGiaVp item in _MedGiaVps)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedGiaVp vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedGiaVp _MedGiaVp, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedGiaVp] SET id=@id, id_loai=@id_loai, ma=@ma, ten=@ten, dvt=@dvt, bhyt=@bhyt, gia_th=@gia_th, gia_bh=@gia_bh, gia_yc=@gia_yc, gia_nn=@gia_nn, chenhlech=@chenhlech, goi=@goi, sudung=@sudung, ktc=@ktc, userid=@userid, ngayud=@ngayud, phuthu=@phuthu, boiduong=@boiduong, gia_byt=@gia_byt, stt_03=@stt_03, stt_04=@stt_04, stt=@stt, ten_cu=@ten_cu, thutu=@thutu, id_nhombc=@id_nhombc, tenkhongdau=@tenkhongdau, ghichu=@ghichu, id_loaipt=@id_loaipt, hoichan=@hoichan, lienket=@lienket, ma_icd=@ma_icd, id_nhomkt=@id_nhomkt, cls=@cls, covid=@covid "+ condition, 
					"@id",  _MedGiaVp.id, 
					"@id_loai",  _MedGiaVp.id_loai, 
					"@ma",  _MedGiaVp.ma, 
					"@ten",  _MedGiaVp.ten, 
					"@dvt",  _MedGiaVp.dvt, 
					"@bhyt",  _MedGiaVp.bhyt, 
					"@gia_th",  _MedGiaVp.gia_th, 
					"@gia_bh",  _MedGiaVp.gia_bh, 
					"@gia_yc",  _MedGiaVp.gia_yc, 
					"@gia_nn",  _MedGiaVp.gia_nn, 
					"@chenhlech",  _MedGiaVp.chenhlech, 
					"@goi",  _MedGiaVp.goi, 
					"@sudung",  _MedGiaVp.sudung, 
					"@ktc",  _MedGiaVp.ktc, 
					"@userid",  _MedGiaVp.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedGiaVp.ngayud), 
					"@phuthu",  _MedGiaVp.phuthu, 
					"@boiduong",  _MedGiaVp.boiduong, 
					"@gia_byt",  _MedGiaVp.gia_byt, 
					"@stt_03",  _MedGiaVp.stt_03, 
					"@stt_04",  _MedGiaVp.stt_04, 
					"@stt",  _MedGiaVp.stt, 
					"@ten_cu",  _MedGiaVp.ten_cu, 
					"@thutu",  _MedGiaVp.thutu, 
					"@id_nhombc",  _MedGiaVp.id_nhombc, 
					"@tenkhongdau",  _MedGiaVp.tenkhongdau, 
					"@ghichu",  _MedGiaVp.ghichu, 
					"@id_loaipt",  _MedGiaVp.id_loaipt, 
					"@hoichan",  _MedGiaVp.hoichan, 
					"@lienket",  _MedGiaVp.lienket, 
					"@ma_icd",  _MedGiaVp.ma_icd, 
					"@id_nhomkt",  _MedGiaVp.id_nhomkt, 
					"@cls",  _MedGiaVp.cls, 
					"@covid",  _MedGiaVp.covid);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedGiaVp trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedGiaVp] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedGiaVp trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedGiaVp _MedGiaVp)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedGiaVp] WHERE id=@id",
					"@id", _MedGiaVp.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedGiaVp trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedGiaVp] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedGiaVp trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedGiaVp> _MedGiaVps)
		{
			foreach (MedGiaVp item in _MedGiaVps)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
