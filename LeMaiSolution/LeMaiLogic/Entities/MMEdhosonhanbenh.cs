using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdhosonhanbenh:IMEdhosonhanbenh
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdhosonhanbenh(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedHoSoNhanBenh từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHoSoNhanBenh]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedHoSoNhanBenh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHoSoNhanBenh] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedHoSoNhanBenh từ Database
		/// </summary>
		public List<MedHoSoNhanBenh> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHoSoNhanBenh]");
				List<MedHoSoNhanBenh> items = new List<MedHoSoNhanBenh>();
				MedHoSoNhanBenh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedHoSoNhanBenh();
					if (dr["mavv"] != null && dr["mavv"] != DBNull.Value)
					{
						item.mavv = Convert.ToString(dr["mavv"]);
					}
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
					}
					if (dr["sttxetnghiem"] != null && dr["sttxetnghiem"] != DBNull.Value)
					{
						item.sttxetnghiem = Convert.ToInt32(dr["sttxetnghiem"]);
					}
					if (dr["sttnhanhs"] != null && dr["sttnhanhs"] != DBNull.Value)
					{
						item.sttnhanhs = Convert.ToInt32(dr["sttnhanhs"]);
					}
					if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
					{
						item.mabn = Convert.ToString(dr["mabn"]);
					}
					if (dr["ngaynhan"] != null && dr["ngaynhan"] != DBNull.Value)
					{
						item.ngaynhan = Convert.ToDateTime(dr["ngaynhan"]);
					}
					if (dr["huyetap"] != null && dr["huyetap"] != DBNull.Value)
					{
						item.huyetap = Convert.ToString(dr["huyetap"]);
					}
					if (dr["chieucao"] != null && dr["chieucao"] != DBNull.Value)
					{
						item.chieucao = Convert.ToInt32(dr["chieucao"]);
					}
					if (dr["cannang"] != null && dr["cannang"] != DBNull.Value)
					{
						item.cannang = Convert.ToInt32(dr["cannang"]);
					}
					if (dr["chisobmi"] != null && dr["chisobmi"] != DBNull.Value)
					{
						item.chisobmi = Convert.ToDecimal(dr["chisobmi"]);
					}
					if (dr["tuanhoan"] != null && dr["tuanhoan"] != DBNull.Value)
					{
						item.tuanhoan = Convert.ToString(dr["tuanhoan"]);
					}
					if (dr["hohap"] != null && dr["hohap"] != DBNull.Value)
					{
						item.hohap = Convert.ToString(dr["hohap"]);
					}
					if (dr["tieuhoa"] != null && dr["tieuhoa"] != DBNull.Value)
					{
						item.tieuhoa = Convert.ToString(dr["tieuhoa"]);
					}
					if (dr["thantietnieu"] != null && dr["thantietnieu"] != DBNull.Value)
					{
						item.thantietnieu = Convert.ToString(dr["thantietnieu"]);
					}
					if (dr["coxuongkhop"] != null && dr["coxuongkhop"] != DBNull.Value)
					{
						item.coxuongkhop = Convert.ToString(dr["coxuongkhop"]);
					}
					if (dr["thankinh"] != null && dr["thankinh"] != DBNull.Value)
					{
						item.thankinh = Convert.ToString(dr["thankinh"]);
					}
					if (dr["tamthan"] != null && dr["tamthan"] != DBNull.Value)
					{
						item.tamthan = Convert.ToString(dr["tamthan"]);
					}
					if (dr["ngoaikhoa"] != null && dr["ngoaikhoa"] != DBNull.Value)
					{
						item.ngoaikhoa = Convert.ToString(dr["ngoaikhoa"]);
					}
					if (dr["sanphukhoa"] != null && dr["sanphukhoa"] != DBNull.Value)
					{
						item.sanphukhoa = Convert.ToString(dr["sanphukhoa"]);
					}
					if (dr["mat"] != null && dr["mat"] != DBNull.Value)
					{
						item.mat = Convert.ToString(dr["mat"]);
					}
					if (dr["taimuihong"] != null && dr["taimuihong"] != DBNull.Value)
					{
						item.taimuihong = Convert.ToString(dr["taimuihong"]);
					}
					if (dr["ranghammat"] != null && dr["ranghammat"] != DBNull.Value)
					{
						item.ranghammat = Convert.ToString(dr["ranghammat"]);
					}
					if (dr["dalieu"] != null && dr["dalieu"] != DBNull.Value)
					{
						item.dalieu = Convert.ToString(dr["dalieu"]);
					}
					if (dr["phanloai"] != null && dr["phanloai"] != DBNull.Value)
					{
						item.phanloai = Convert.ToInt32(dr["phanloai"]);
					}
					if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
					{
						item.ketluan = Convert.ToString(dr["ketluan"]);
					}
					if (dr["ngaykham"] != null && dr["ngaykham"] != DBNull.Value)
					{
						item.ngaykham = Convert.ToDateTime(dr["ngaykham"]);
					}
					if (dr["icd10code"] != null && dr["icd10code"] != DBNull.Value)
					{
						item.icd10code = Convert.ToString(dr["icd10code"]);
					}
					if (dr["icd10name"] != null && dr["icd10name"] != DBNull.Value)
					{
						item.icd10name = Convert.ToString(dr["icd10name"]);
					}
					if (dr["trangthai"] != null && dr["trangthai"] != DBNull.Value)
					{
						item.trangthai = Convert.ToInt32(dr["trangthai"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
					{
						item.createuser = Convert.ToString(dr["createuser"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["ngaykls"] != null && dr["ngaykls"] != DBNull.Value)
					{
						item.ngaykls = Convert.ToDateTime(dr["ngaykls"]);
					}
					if (dr["userkls"] != null && dr["userkls"] != DBNull.Value)
					{
						item.userkls = Convert.ToString(dr["userkls"]);
					}
					if (dr["historychange"] != null && dr["historychange"] != DBNull.Value)
					{
						item.historychange = Convert.ToString(dr["historychange"]);
					}
					if (dr["noitiet"] != null && dr["noitiet"] != DBNull.Value)
					{
						item.noitiet = Convert.ToString(dr["noitiet"]);
					}
					if (dr["mach"] != null && dr["mach"] != DBNull.Value)
					{
						item.mach = Convert.ToInt32(dr["mach"]);
					}
					if (dr["hs_idvvienphi"] != null && dr["hs_idvvienphi"] != DBNull.Value)
					{
						item.hs_idvvienphi = Convert.ToInt32(dr["hs_idvvienphi"]);
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
		/// Lấy danh sách MedHoSoNhanBenh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedHoSoNhanBenh> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedHoSoNhanBenh] A "+ condition,  parameters);
				List<MedHoSoNhanBenh> items = new List<MedHoSoNhanBenh>();
				MedHoSoNhanBenh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedHoSoNhanBenh();
					if (dr["mavv"] != null && dr["mavv"] != DBNull.Value)
					{
						item.mavv = Convert.ToString(dr["mavv"]);
					}
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
					}
					if (dr["sttxetnghiem"] != null && dr["sttxetnghiem"] != DBNull.Value)
					{
						item.sttxetnghiem = Convert.ToInt32(dr["sttxetnghiem"]);
					}
					if (dr["sttnhanhs"] != null && dr["sttnhanhs"] != DBNull.Value)
					{
						item.sttnhanhs = Convert.ToInt32(dr["sttnhanhs"]);
					}
					if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
					{
						item.mabn = Convert.ToString(dr["mabn"]);
					}
					if (dr["ngaynhan"] != null && dr["ngaynhan"] != DBNull.Value)
					{
						item.ngaynhan = Convert.ToDateTime(dr["ngaynhan"]);
					}
					if (dr["huyetap"] != null && dr["huyetap"] != DBNull.Value)
					{
						item.huyetap = Convert.ToString(dr["huyetap"]);
					}
					if (dr["chieucao"] != null && dr["chieucao"] != DBNull.Value)
					{
						item.chieucao = Convert.ToInt32(dr["chieucao"]);
					}
					if (dr["cannang"] != null && dr["cannang"] != DBNull.Value)
					{
						item.cannang = Convert.ToInt32(dr["cannang"]);
					}
					if (dr["chisobmi"] != null && dr["chisobmi"] != DBNull.Value)
					{
						item.chisobmi = Convert.ToDecimal(dr["chisobmi"]);
					}
					if (dr["tuanhoan"] != null && dr["tuanhoan"] != DBNull.Value)
					{
						item.tuanhoan = Convert.ToString(dr["tuanhoan"]);
					}
					if (dr["hohap"] != null && dr["hohap"] != DBNull.Value)
					{
						item.hohap = Convert.ToString(dr["hohap"]);
					}
					if (dr["tieuhoa"] != null && dr["tieuhoa"] != DBNull.Value)
					{
						item.tieuhoa = Convert.ToString(dr["tieuhoa"]);
					}
					if (dr["thantietnieu"] != null && dr["thantietnieu"] != DBNull.Value)
					{
						item.thantietnieu = Convert.ToString(dr["thantietnieu"]);
					}
					if (dr["coxuongkhop"] != null && dr["coxuongkhop"] != DBNull.Value)
					{
						item.coxuongkhop = Convert.ToString(dr["coxuongkhop"]);
					}
					if (dr["thankinh"] != null && dr["thankinh"] != DBNull.Value)
					{
						item.thankinh = Convert.ToString(dr["thankinh"]);
					}
					if (dr["tamthan"] != null && dr["tamthan"] != DBNull.Value)
					{
						item.tamthan = Convert.ToString(dr["tamthan"]);
					}
					if (dr["ngoaikhoa"] != null && dr["ngoaikhoa"] != DBNull.Value)
					{
						item.ngoaikhoa = Convert.ToString(dr["ngoaikhoa"]);
					}
					if (dr["sanphukhoa"] != null && dr["sanphukhoa"] != DBNull.Value)
					{
						item.sanphukhoa = Convert.ToString(dr["sanphukhoa"]);
					}
					if (dr["mat"] != null && dr["mat"] != DBNull.Value)
					{
						item.mat = Convert.ToString(dr["mat"]);
					}
					if (dr["taimuihong"] != null && dr["taimuihong"] != DBNull.Value)
					{
						item.taimuihong = Convert.ToString(dr["taimuihong"]);
					}
					if (dr["ranghammat"] != null && dr["ranghammat"] != DBNull.Value)
					{
						item.ranghammat = Convert.ToString(dr["ranghammat"]);
					}
					if (dr["dalieu"] != null && dr["dalieu"] != DBNull.Value)
					{
						item.dalieu = Convert.ToString(dr["dalieu"]);
					}
					if (dr["phanloai"] != null && dr["phanloai"] != DBNull.Value)
					{
						item.phanloai = Convert.ToInt32(dr["phanloai"]);
					}
					if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
					{
						item.ketluan = Convert.ToString(dr["ketluan"]);
					}
					if (dr["ngaykham"] != null && dr["ngaykham"] != DBNull.Value)
					{
						item.ngaykham = Convert.ToDateTime(dr["ngaykham"]);
					}
					if (dr["icd10code"] != null && dr["icd10code"] != DBNull.Value)
					{
						item.icd10code = Convert.ToString(dr["icd10code"]);
					}
					if (dr["icd10name"] != null && dr["icd10name"] != DBNull.Value)
					{
						item.icd10name = Convert.ToString(dr["icd10name"]);
					}
					if (dr["trangthai"] != null && dr["trangthai"] != DBNull.Value)
					{
						item.trangthai = Convert.ToInt32(dr["trangthai"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
					{
						item.createuser = Convert.ToString(dr["createuser"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["ngaykls"] != null && dr["ngaykls"] != DBNull.Value)
					{
						item.ngaykls = Convert.ToDateTime(dr["ngaykls"]);
					}
					if (dr["userkls"] != null && dr["userkls"] != DBNull.Value)
					{
						item.userkls = Convert.ToString(dr["userkls"]);
					}
					if (dr["historychange"] != null && dr["historychange"] != DBNull.Value)
					{
						item.historychange = Convert.ToString(dr["historychange"]);
					}
					if (dr["noitiet"] != null && dr["noitiet"] != DBNull.Value)
					{
						item.noitiet = Convert.ToString(dr["noitiet"]);
					}
					if (dr["mach"] != null && dr["mach"] != DBNull.Value)
					{
						item.mach = Convert.ToInt32(dr["mach"]);
					}
					if (dr["hs_idvvienphi"] != null && dr["hs_idvvienphi"] != DBNull.Value)
					{
						item.hs_idvvienphi = Convert.ToInt32(dr["hs_idvvienphi"]);
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

		public List<MedHoSoNhanBenh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedHoSoNhanBenh] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedHoSoNhanBenh] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedHoSoNhanBenh>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedHoSoNhanBenh từ Database
		/// </summary>
		public MedHoSoNhanBenh GetObject(string schema, String mavv)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHoSoNhanBenh] where mavv=@mavv",
					"@mavv", mavv);
				if (ds.Rows.Count > 0)
				{
					MedHoSoNhanBenh item=new MedHoSoNhanBenh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["mavv"] != null && dr["mavv"] != DBNull.Value)
						{
							item.mavv = Convert.ToString(dr["mavv"]);
						}
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
						}
						if (dr["sttxetnghiem"] != null && dr["sttxetnghiem"] != DBNull.Value)
						{
							item.sttxetnghiem = Convert.ToInt32(dr["sttxetnghiem"]);
						}
						if (dr["sttnhanhs"] != null && dr["sttnhanhs"] != DBNull.Value)
						{
							item.sttnhanhs = Convert.ToInt32(dr["sttnhanhs"]);
						}
						if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
						{
							item.mabn = Convert.ToString(dr["mabn"]);
						}
						if (dr["ngaynhan"] != null && dr["ngaynhan"] != DBNull.Value)
						{
							item.ngaynhan = Convert.ToDateTime(dr["ngaynhan"]);
						}
						if (dr["huyetap"] != null && dr["huyetap"] != DBNull.Value)
						{
							item.huyetap = Convert.ToString(dr["huyetap"]);
						}
						if (dr["chieucao"] != null && dr["chieucao"] != DBNull.Value)
						{
							item.chieucao = Convert.ToInt32(dr["chieucao"]);
						}
						if (dr["cannang"] != null && dr["cannang"] != DBNull.Value)
						{
							item.cannang = Convert.ToInt32(dr["cannang"]);
						}
						if (dr["chisobmi"] != null && dr["chisobmi"] != DBNull.Value)
						{
							item.chisobmi = Convert.ToDecimal(dr["chisobmi"]);
						}
						if (dr["tuanhoan"] != null && dr["tuanhoan"] != DBNull.Value)
						{
							item.tuanhoan = Convert.ToString(dr["tuanhoan"]);
						}
						if (dr["hohap"] != null && dr["hohap"] != DBNull.Value)
						{
							item.hohap = Convert.ToString(dr["hohap"]);
						}
						if (dr["tieuhoa"] != null && dr["tieuhoa"] != DBNull.Value)
						{
							item.tieuhoa = Convert.ToString(dr["tieuhoa"]);
						}
						if (dr["thantietnieu"] != null && dr["thantietnieu"] != DBNull.Value)
						{
							item.thantietnieu = Convert.ToString(dr["thantietnieu"]);
						}
						if (dr["coxuongkhop"] != null && dr["coxuongkhop"] != DBNull.Value)
						{
							item.coxuongkhop = Convert.ToString(dr["coxuongkhop"]);
						}
						if (dr["thankinh"] != null && dr["thankinh"] != DBNull.Value)
						{
							item.thankinh = Convert.ToString(dr["thankinh"]);
						}
						if (dr["tamthan"] != null && dr["tamthan"] != DBNull.Value)
						{
							item.tamthan = Convert.ToString(dr["tamthan"]);
						}
						if (dr["ngoaikhoa"] != null && dr["ngoaikhoa"] != DBNull.Value)
						{
							item.ngoaikhoa = Convert.ToString(dr["ngoaikhoa"]);
						}
						if (dr["sanphukhoa"] != null && dr["sanphukhoa"] != DBNull.Value)
						{
							item.sanphukhoa = Convert.ToString(dr["sanphukhoa"]);
						}
						if (dr["mat"] != null && dr["mat"] != DBNull.Value)
						{
							item.mat = Convert.ToString(dr["mat"]);
						}
						if (dr["taimuihong"] != null && dr["taimuihong"] != DBNull.Value)
						{
							item.taimuihong = Convert.ToString(dr["taimuihong"]);
						}
						if (dr["ranghammat"] != null && dr["ranghammat"] != DBNull.Value)
						{
							item.ranghammat = Convert.ToString(dr["ranghammat"]);
						}
						if (dr["dalieu"] != null && dr["dalieu"] != DBNull.Value)
						{
							item.dalieu = Convert.ToString(dr["dalieu"]);
						}
						if (dr["phanloai"] != null && dr["phanloai"] != DBNull.Value)
						{
							item.phanloai = Convert.ToInt32(dr["phanloai"]);
						}
						if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
						{
							item.ketluan = Convert.ToString(dr["ketluan"]);
						}
						if (dr["ngaykham"] != null && dr["ngaykham"] != DBNull.Value)
						{
							item.ngaykham = Convert.ToDateTime(dr["ngaykham"]);
						}
						if (dr["icd10code"] != null && dr["icd10code"] != DBNull.Value)
						{
							item.icd10code = Convert.ToString(dr["icd10code"]);
						}
						if (dr["icd10name"] != null && dr["icd10name"] != DBNull.Value)
						{
							item.icd10name = Convert.ToString(dr["icd10name"]);
						}
						if (dr["trangthai"] != null && dr["trangthai"] != DBNull.Value)
						{
							item.trangthai = Convert.ToInt32(dr["trangthai"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
						{
							item.createuser = Convert.ToString(dr["createuser"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["ngaykls"] != null && dr["ngaykls"] != DBNull.Value)
						{
							item.ngaykls = Convert.ToDateTime(dr["ngaykls"]);
						}
						if (dr["userkls"] != null && dr["userkls"] != DBNull.Value)
						{
							item.userkls = Convert.ToString(dr["userkls"]);
						}
						if (dr["historychange"] != null && dr["historychange"] != DBNull.Value)
						{
							item.historychange = Convert.ToString(dr["historychange"]);
						}
						if (dr["noitiet"] != null && dr["noitiet"] != DBNull.Value)
						{
							item.noitiet = Convert.ToString(dr["noitiet"]);
						}
						if (dr["mach"] != null && dr["mach"] != DBNull.Value)
						{
							item.mach = Convert.ToInt32(dr["mach"]);
						}
						if (dr["hs_idvvienphi"] != null && dr["hs_idvvienphi"] != DBNull.Value)
						{
							item.hs_idvvienphi = Convert.ToInt32(dr["hs_idvvienphi"]);
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
		/// Lấy một MedHoSoNhanBenh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedHoSoNhanBenh GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedHoSoNhanBenh] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedHoSoNhanBenh item=new MedHoSoNhanBenh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["mavv"] != null && dr["mavv"] != DBNull.Value)
						{
							item.mavv = Convert.ToString(dr["mavv"]);
						}
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
						}
						if (dr["sttxetnghiem"] != null && dr["sttxetnghiem"] != DBNull.Value)
						{
							item.sttxetnghiem = Convert.ToInt32(dr["sttxetnghiem"]);
						}
						if (dr["sttnhanhs"] != null && dr["sttnhanhs"] != DBNull.Value)
						{
							item.sttnhanhs = Convert.ToInt32(dr["sttnhanhs"]);
						}
						if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
						{
							item.mabn = Convert.ToString(dr["mabn"]);
						}
						if (dr["ngaynhan"] != null && dr["ngaynhan"] != DBNull.Value)
						{
							item.ngaynhan = Convert.ToDateTime(dr["ngaynhan"]);
						}
						if (dr["huyetap"] != null && dr["huyetap"] != DBNull.Value)
						{
							item.huyetap = Convert.ToString(dr["huyetap"]);
						}
						if (dr["chieucao"] != null && dr["chieucao"] != DBNull.Value)
						{
							item.chieucao = Convert.ToInt32(dr["chieucao"]);
						}
						if (dr["cannang"] != null && dr["cannang"] != DBNull.Value)
						{
							item.cannang = Convert.ToInt32(dr["cannang"]);
						}
						if (dr["chisobmi"] != null && dr["chisobmi"] != DBNull.Value)
						{
							item.chisobmi = Convert.ToDecimal(dr["chisobmi"]);
						}
						if (dr["tuanhoan"] != null && dr["tuanhoan"] != DBNull.Value)
						{
							item.tuanhoan = Convert.ToString(dr["tuanhoan"]);
						}
						if (dr["hohap"] != null && dr["hohap"] != DBNull.Value)
						{
							item.hohap = Convert.ToString(dr["hohap"]);
						}
						if (dr["tieuhoa"] != null && dr["tieuhoa"] != DBNull.Value)
						{
							item.tieuhoa = Convert.ToString(dr["tieuhoa"]);
						}
						if (dr["thantietnieu"] != null && dr["thantietnieu"] != DBNull.Value)
						{
							item.thantietnieu = Convert.ToString(dr["thantietnieu"]);
						}
						if (dr["coxuongkhop"] != null && dr["coxuongkhop"] != DBNull.Value)
						{
							item.coxuongkhop = Convert.ToString(dr["coxuongkhop"]);
						}
						if (dr["thankinh"] != null && dr["thankinh"] != DBNull.Value)
						{
							item.thankinh = Convert.ToString(dr["thankinh"]);
						}
						if (dr["tamthan"] != null && dr["tamthan"] != DBNull.Value)
						{
							item.tamthan = Convert.ToString(dr["tamthan"]);
						}
						if (dr["ngoaikhoa"] != null && dr["ngoaikhoa"] != DBNull.Value)
						{
							item.ngoaikhoa = Convert.ToString(dr["ngoaikhoa"]);
						}
						if (dr["sanphukhoa"] != null && dr["sanphukhoa"] != DBNull.Value)
						{
							item.sanphukhoa = Convert.ToString(dr["sanphukhoa"]);
						}
						if (dr["mat"] != null && dr["mat"] != DBNull.Value)
						{
							item.mat = Convert.ToString(dr["mat"]);
						}
						if (dr["taimuihong"] != null && dr["taimuihong"] != DBNull.Value)
						{
							item.taimuihong = Convert.ToString(dr["taimuihong"]);
						}
						if (dr["ranghammat"] != null && dr["ranghammat"] != DBNull.Value)
						{
							item.ranghammat = Convert.ToString(dr["ranghammat"]);
						}
						if (dr["dalieu"] != null && dr["dalieu"] != DBNull.Value)
						{
							item.dalieu = Convert.ToString(dr["dalieu"]);
						}
						if (dr["phanloai"] != null && dr["phanloai"] != DBNull.Value)
						{
							item.phanloai = Convert.ToInt32(dr["phanloai"]);
						}
						if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
						{
							item.ketluan = Convert.ToString(dr["ketluan"]);
						}
						if (dr["ngaykham"] != null && dr["ngaykham"] != DBNull.Value)
						{
							item.ngaykham = Convert.ToDateTime(dr["ngaykham"]);
						}
						if (dr["icd10code"] != null && dr["icd10code"] != DBNull.Value)
						{
							item.icd10code = Convert.ToString(dr["icd10code"]);
						}
						if (dr["icd10name"] != null && dr["icd10name"] != DBNull.Value)
						{
							item.icd10name = Convert.ToString(dr["icd10name"]);
						}
						if (dr["trangthai"] != null && dr["trangthai"] != DBNull.Value)
						{
							item.trangthai = Convert.ToInt32(dr["trangthai"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
						{
							item.createuser = Convert.ToString(dr["createuser"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["ngaykls"] != null && dr["ngaykls"] != DBNull.Value)
						{
							item.ngaykls = Convert.ToDateTime(dr["ngaykls"]);
						}
						if (dr["userkls"] != null && dr["userkls"] != DBNull.Value)
						{
							item.userkls = Convert.ToString(dr["userkls"]);
						}
						if (dr["historychange"] != null && dr["historychange"] != DBNull.Value)
						{
							item.historychange = Convert.ToString(dr["historychange"]);
						}
						if (dr["noitiet"] != null && dr["noitiet"] != DBNull.Value)
						{
							item.noitiet = Convert.ToString(dr["noitiet"]);
						}
						if (dr["mach"] != null && dr["mach"] != DBNull.Value)
						{
							item.mach = Convert.ToInt32(dr["mach"]);
						}
						if (dr["hs_idvvienphi"] != null && dr["hs_idvvienphi"] != DBNull.Value)
						{
							item.hs_idvvienphi = Convert.ToInt32(dr["hs_idvvienphi"]);
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

		public MedHoSoNhanBenh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedHoSoNhanBenh] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedHoSoNhanBenh>(ds);
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
		/// Thêm mới MedHoSoNhanBenh vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedHoSoNhanBenh _MedHoSoNhanBenh)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedHoSoNhanBenh](mavv, maql, sttxetnghiem, sttnhanhs, mabn, ngaynhan, huyetap, chieucao, cannang, chisobmi, tuanhoan, hohap, tieuhoa, thantietnieu, coxuongkhop, thankinh, tamthan, ngoaikhoa, sanphukhoa, mat, taimuihong, ranghammat, dalieu, phanloai, ketluan, ngaykham, icd10code, icd10name, trangthai, ghichu, createuser, createdate, userid, ngayud, ngaykls, userkls, historychange, noitiet, mach, hs_idvvienphi) VALUES(@mavv, @maql, @sttxetnghiem, @sttnhanhs, @mabn, @ngaynhan, @huyetap, @chieucao, @cannang, @chisobmi, @tuanhoan, @hohap, @tieuhoa, @thantietnieu, @coxuongkhop, @thankinh, @tamthan, @ngoaikhoa, @sanphukhoa, @mat, @taimuihong, @ranghammat, @dalieu, @phanloai, @ketluan, @ngaykham, @icd10code, @icd10name, @trangthai, @ghichu, @createuser, @createdate, @userid, @ngayud, @ngaykls, @userkls, @historychange, @noitiet, @mach, @hs_idvvienphi)", 
					"@mavv",  _MedHoSoNhanBenh.mavv, 
					"@maql",  _MedHoSoNhanBenh.maql, 
					"@sttxetnghiem",  _MedHoSoNhanBenh.sttxetnghiem, 
					"@sttnhanhs",  _MedHoSoNhanBenh.sttnhanhs, 
					"@mabn",  _MedHoSoNhanBenh.mabn, 
					"@ngaynhan", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaynhan), 
					"@huyetap",  _MedHoSoNhanBenh.huyetap, 
					"@chieucao",  _MedHoSoNhanBenh.chieucao, 
					"@cannang",  _MedHoSoNhanBenh.cannang, 
					"@chisobmi",  _MedHoSoNhanBenh.chisobmi, 
					"@tuanhoan",  _MedHoSoNhanBenh.tuanhoan, 
					"@hohap",  _MedHoSoNhanBenh.hohap, 
					"@tieuhoa",  _MedHoSoNhanBenh.tieuhoa, 
					"@thantietnieu",  _MedHoSoNhanBenh.thantietnieu, 
					"@coxuongkhop",  _MedHoSoNhanBenh.coxuongkhop, 
					"@thankinh",  _MedHoSoNhanBenh.thankinh, 
					"@tamthan",  _MedHoSoNhanBenh.tamthan, 
					"@ngoaikhoa",  _MedHoSoNhanBenh.ngoaikhoa, 
					"@sanphukhoa",  _MedHoSoNhanBenh.sanphukhoa, 
					"@mat",  _MedHoSoNhanBenh.mat, 
					"@taimuihong",  _MedHoSoNhanBenh.taimuihong, 
					"@ranghammat",  _MedHoSoNhanBenh.ranghammat, 
					"@dalieu",  _MedHoSoNhanBenh.dalieu, 
					"@phanloai",  _MedHoSoNhanBenh.phanloai, 
					"@ketluan",  _MedHoSoNhanBenh.ketluan, 
					"@ngaykham", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaykham), 
					"@icd10code",  _MedHoSoNhanBenh.icd10code, 
					"@icd10name",  _MedHoSoNhanBenh.icd10name, 
					"@trangthai",  _MedHoSoNhanBenh.trangthai, 
					"@ghichu",  _MedHoSoNhanBenh.ghichu, 
					"@createuser",  _MedHoSoNhanBenh.createuser, 
					"@createdate", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.createdate), 
					"@userid",  _MedHoSoNhanBenh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngayud), 
					"@ngaykls", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaykls), 
					"@userkls",  _MedHoSoNhanBenh.userkls, 
					"@historychange",  _MedHoSoNhanBenh.historychange, 
					"@noitiet",  _MedHoSoNhanBenh.noitiet, 
					"@mach",  _MedHoSoNhanBenh.mach, 
					"@hs_idvvienphi",  _MedHoSoNhanBenh.hs_idvvienphi);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedHoSoNhanBenh vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedHoSoNhanBenh> _MedHoSoNhanBenhs)
		{
			foreach (MedHoSoNhanBenh item in _MedHoSoNhanBenhs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedHoSoNhanBenh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedHoSoNhanBenh _MedHoSoNhanBenh, String mavv)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedHoSoNhanBenh] SET mavv=@mavv, maql=@maql, sttxetnghiem=@sttxetnghiem, sttnhanhs=@sttnhanhs, mabn=@mabn, ngaynhan=@ngaynhan, huyetap=@huyetap, chieucao=@chieucao, cannang=@cannang, chisobmi=@chisobmi, tuanhoan=@tuanhoan, hohap=@hohap, tieuhoa=@tieuhoa, thantietnieu=@thantietnieu, coxuongkhop=@coxuongkhop, thankinh=@thankinh, tamthan=@tamthan, ngoaikhoa=@ngoaikhoa, sanphukhoa=@sanphukhoa, mat=@mat, taimuihong=@taimuihong, ranghammat=@ranghammat, dalieu=@dalieu, phanloai=@phanloai, ketluan=@ketluan, ngaykham=@ngaykham, icd10code=@icd10code, icd10name=@icd10name, trangthai=@trangthai, ghichu=@ghichu, createuser=@createuser, createdate=@createdate, userid=@userid, ngayud=@ngayud, ngaykls=@ngaykls, userkls=@userkls, historychange=@historychange, noitiet=@noitiet, mach=@mach, hs_idvvienphi=@hs_idvvienphi WHERE mavv=@mavv", 
					"@mavv",  _MedHoSoNhanBenh.mavv, 
					"@maql",  _MedHoSoNhanBenh.maql, 
					"@sttxetnghiem",  _MedHoSoNhanBenh.sttxetnghiem, 
					"@sttnhanhs",  _MedHoSoNhanBenh.sttnhanhs, 
					"@mabn",  _MedHoSoNhanBenh.mabn, 
					"@ngaynhan", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaynhan), 
					"@huyetap",  _MedHoSoNhanBenh.huyetap, 
					"@chieucao",  _MedHoSoNhanBenh.chieucao, 
					"@cannang",  _MedHoSoNhanBenh.cannang, 
					"@chisobmi",  _MedHoSoNhanBenh.chisobmi, 
					"@tuanhoan",  _MedHoSoNhanBenh.tuanhoan, 
					"@hohap",  _MedHoSoNhanBenh.hohap, 
					"@tieuhoa",  _MedHoSoNhanBenh.tieuhoa, 
					"@thantietnieu",  _MedHoSoNhanBenh.thantietnieu, 
					"@coxuongkhop",  _MedHoSoNhanBenh.coxuongkhop, 
					"@thankinh",  _MedHoSoNhanBenh.thankinh, 
					"@tamthan",  _MedHoSoNhanBenh.tamthan, 
					"@ngoaikhoa",  _MedHoSoNhanBenh.ngoaikhoa, 
					"@sanphukhoa",  _MedHoSoNhanBenh.sanphukhoa, 
					"@mat",  _MedHoSoNhanBenh.mat, 
					"@taimuihong",  _MedHoSoNhanBenh.taimuihong, 
					"@ranghammat",  _MedHoSoNhanBenh.ranghammat, 
					"@dalieu",  _MedHoSoNhanBenh.dalieu, 
					"@phanloai",  _MedHoSoNhanBenh.phanloai, 
					"@ketluan",  _MedHoSoNhanBenh.ketluan, 
					"@ngaykham", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaykham), 
					"@icd10code",  _MedHoSoNhanBenh.icd10code, 
					"@icd10name",  _MedHoSoNhanBenh.icd10name, 
					"@trangthai",  _MedHoSoNhanBenh.trangthai, 
					"@ghichu",  _MedHoSoNhanBenh.ghichu, 
					"@createuser",  _MedHoSoNhanBenh.createuser, 
					"@createdate", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.createdate), 
					"@userid",  _MedHoSoNhanBenh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngayud), 
					"@ngaykls", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaykls), 
					"@userkls",  _MedHoSoNhanBenh.userkls, 
					"@historychange",  _MedHoSoNhanBenh.historychange, 
					"@noitiet",  _MedHoSoNhanBenh.noitiet, 
					"@mach",  _MedHoSoNhanBenh.mach, 
					"@hs_idvvienphi",  _MedHoSoNhanBenh.hs_idvvienphi, 
					"@mavv", mavv);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedHoSoNhanBenh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedHoSoNhanBenh _MedHoSoNhanBenh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedHoSoNhanBenh] SET maql=@maql, sttxetnghiem=@sttxetnghiem, sttnhanhs=@sttnhanhs, mabn=@mabn, ngaynhan=@ngaynhan, huyetap=@huyetap, chieucao=@chieucao, cannang=@cannang, chisobmi=@chisobmi, tuanhoan=@tuanhoan, hohap=@hohap, tieuhoa=@tieuhoa, thantietnieu=@thantietnieu, coxuongkhop=@coxuongkhop, thankinh=@thankinh, tamthan=@tamthan, ngoaikhoa=@ngoaikhoa, sanphukhoa=@sanphukhoa, mat=@mat, taimuihong=@taimuihong, ranghammat=@ranghammat, dalieu=@dalieu, phanloai=@phanloai, ketluan=@ketluan, ngaykham=@ngaykham, icd10code=@icd10code, icd10name=@icd10name, trangthai=@trangthai, ghichu=@ghichu, createuser=@createuser, createdate=@createdate, userid=@userid, ngayud=@ngayud, ngaykls=@ngaykls, userkls=@userkls, historychange=@historychange, noitiet=@noitiet, mach=@mach, hs_idvvienphi=@hs_idvvienphi WHERE mavv=@mavv", 
					"@maql",  _MedHoSoNhanBenh.maql, 
					"@sttxetnghiem",  _MedHoSoNhanBenh.sttxetnghiem, 
					"@sttnhanhs",  _MedHoSoNhanBenh.sttnhanhs, 
					"@mabn",  _MedHoSoNhanBenh.mabn, 
					"@ngaynhan", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaynhan), 
					"@huyetap",  _MedHoSoNhanBenh.huyetap, 
					"@chieucao",  _MedHoSoNhanBenh.chieucao, 
					"@cannang",  _MedHoSoNhanBenh.cannang, 
					"@chisobmi",  _MedHoSoNhanBenh.chisobmi, 
					"@tuanhoan",  _MedHoSoNhanBenh.tuanhoan, 
					"@hohap",  _MedHoSoNhanBenh.hohap, 
					"@tieuhoa",  _MedHoSoNhanBenh.tieuhoa, 
					"@thantietnieu",  _MedHoSoNhanBenh.thantietnieu, 
					"@coxuongkhop",  _MedHoSoNhanBenh.coxuongkhop, 
					"@thankinh",  _MedHoSoNhanBenh.thankinh, 
					"@tamthan",  _MedHoSoNhanBenh.tamthan, 
					"@ngoaikhoa",  _MedHoSoNhanBenh.ngoaikhoa, 
					"@sanphukhoa",  _MedHoSoNhanBenh.sanphukhoa, 
					"@mat",  _MedHoSoNhanBenh.mat, 
					"@taimuihong",  _MedHoSoNhanBenh.taimuihong, 
					"@ranghammat",  _MedHoSoNhanBenh.ranghammat, 
					"@dalieu",  _MedHoSoNhanBenh.dalieu, 
					"@phanloai",  _MedHoSoNhanBenh.phanloai, 
					"@ketluan",  _MedHoSoNhanBenh.ketluan, 
					"@ngaykham", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaykham), 
					"@icd10code",  _MedHoSoNhanBenh.icd10code, 
					"@icd10name",  _MedHoSoNhanBenh.icd10name, 
					"@trangthai",  _MedHoSoNhanBenh.trangthai, 
					"@ghichu",  _MedHoSoNhanBenh.ghichu, 
					"@createuser",  _MedHoSoNhanBenh.createuser, 
					"@createdate", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.createdate), 
					"@userid",  _MedHoSoNhanBenh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngayud), 
					"@ngaykls", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaykls), 
					"@userkls",  _MedHoSoNhanBenh.userkls, 
					"@historychange",  _MedHoSoNhanBenh.historychange, 
					"@noitiet",  _MedHoSoNhanBenh.noitiet, 
					"@mach",  _MedHoSoNhanBenh.mach, 
					"@hs_idvvienphi",  _MedHoSoNhanBenh.hs_idvvienphi, 
					"@mavv", _MedHoSoNhanBenh.mavv);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedHoSoNhanBenh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedHoSoNhanBenh> _MedHoSoNhanBenhs)
		{
			foreach (MedHoSoNhanBenh item in _MedHoSoNhanBenhs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedHoSoNhanBenh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedHoSoNhanBenh _MedHoSoNhanBenh, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedHoSoNhanBenh] SET mavv=@mavv, maql=@maql, sttxetnghiem=@sttxetnghiem, sttnhanhs=@sttnhanhs, mabn=@mabn, ngaynhan=@ngaynhan, huyetap=@huyetap, chieucao=@chieucao, cannang=@cannang, chisobmi=@chisobmi, tuanhoan=@tuanhoan, hohap=@hohap, tieuhoa=@tieuhoa, thantietnieu=@thantietnieu, coxuongkhop=@coxuongkhop, thankinh=@thankinh, tamthan=@tamthan, ngoaikhoa=@ngoaikhoa, sanphukhoa=@sanphukhoa, mat=@mat, taimuihong=@taimuihong, ranghammat=@ranghammat, dalieu=@dalieu, phanloai=@phanloai, ketluan=@ketluan, ngaykham=@ngaykham, icd10code=@icd10code, icd10name=@icd10name, trangthai=@trangthai, ghichu=@ghichu, createuser=@createuser, createdate=@createdate, userid=@userid, ngayud=@ngayud, ngaykls=@ngaykls, userkls=@userkls, historychange=@historychange, noitiet=@noitiet, mach=@mach, hs_idvvienphi=@hs_idvvienphi "+ condition, 
					"@mavv",  _MedHoSoNhanBenh.mavv, 
					"@maql",  _MedHoSoNhanBenh.maql, 
					"@sttxetnghiem",  _MedHoSoNhanBenh.sttxetnghiem, 
					"@sttnhanhs",  _MedHoSoNhanBenh.sttnhanhs, 
					"@mabn",  _MedHoSoNhanBenh.mabn, 
					"@ngaynhan", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaynhan), 
					"@huyetap",  _MedHoSoNhanBenh.huyetap, 
					"@chieucao",  _MedHoSoNhanBenh.chieucao, 
					"@cannang",  _MedHoSoNhanBenh.cannang, 
					"@chisobmi",  _MedHoSoNhanBenh.chisobmi, 
					"@tuanhoan",  _MedHoSoNhanBenh.tuanhoan, 
					"@hohap",  _MedHoSoNhanBenh.hohap, 
					"@tieuhoa",  _MedHoSoNhanBenh.tieuhoa, 
					"@thantietnieu",  _MedHoSoNhanBenh.thantietnieu, 
					"@coxuongkhop",  _MedHoSoNhanBenh.coxuongkhop, 
					"@thankinh",  _MedHoSoNhanBenh.thankinh, 
					"@tamthan",  _MedHoSoNhanBenh.tamthan, 
					"@ngoaikhoa",  _MedHoSoNhanBenh.ngoaikhoa, 
					"@sanphukhoa",  _MedHoSoNhanBenh.sanphukhoa, 
					"@mat",  _MedHoSoNhanBenh.mat, 
					"@taimuihong",  _MedHoSoNhanBenh.taimuihong, 
					"@ranghammat",  _MedHoSoNhanBenh.ranghammat, 
					"@dalieu",  _MedHoSoNhanBenh.dalieu, 
					"@phanloai",  _MedHoSoNhanBenh.phanloai, 
					"@ketluan",  _MedHoSoNhanBenh.ketluan, 
					"@ngaykham", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaykham), 
					"@icd10code",  _MedHoSoNhanBenh.icd10code, 
					"@icd10name",  _MedHoSoNhanBenh.icd10name, 
					"@trangthai",  _MedHoSoNhanBenh.trangthai, 
					"@ghichu",  _MedHoSoNhanBenh.ghichu, 
					"@createuser",  _MedHoSoNhanBenh.createuser, 
					"@createdate", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.createdate), 
					"@userid",  _MedHoSoNhanBenh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngayud), 
					"@ngaykls", this._dataContext.ConvertDateString( _MedHoSoNhanBenh.ngaykls), 
					"@userkls",  _MedHoSoNhanBenh.userkls, 
					"@historychange",  _MedHoSoNhanBenh.historychange, 
					"@noitiet",  _MedHoSoNhanBenh.noitiet, 
					"@mach",  _MedHoSoNhanBenh.mach, 
					"@hs_idvvienphi",  _MedHoSoNhanBenh.hs_idvvienphi);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedHoSoNhanBenh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String mavv)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedHoSoNhanBenh] WHERE mavv=@mavv",
					"@mavv", mavv);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedHoSoNhanBenh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedHoSoNhanBenh _MedHoSoNhanBenh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedHoSoNhanBenh] WHERE mavv=@mavv",
					"@mavv", _MedHoSoNhanBenh.mavv);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedHoSoNhanBenh trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedHoSoNhanBenh] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedHoSoNhanBenh trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedHoSoNhanBenh> _MedHoSoNhanBenhs)
		{
			foreach (MedHoSoNhanBenh item in _MedHoSoNhanBenhs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
