using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMAmnontruonghoc:IMAmnontruonghoc
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMAmnontruonghoc(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MamNonTruongHoc từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonTruongHoc]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MamNonTruongHoc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonTruongHoc] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MamNonTruongHoc từ Database
		/// </summary>
		public List<MamNonTruongHoc> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonTruongHoc]");
				List<MamNonTruongHoc> items = new List<MamNonTruongHoc>();
				MamNonTruongHoc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonTruongHoc();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenTruong"] != null && dr["TenTruong"] != DBNull.Value)
					{
						item.TenTruong = Convert.ToString(dr["TenTruong"]);
					}
					if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
					{
						item.EnglishName = Convert.ToString(dr["EnglishName"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["HieuTruong"] != null && dr["HieuTruong"] != DBNull.Value)
					{
						item.HieuTruong = Convert.ToString(dr["HieuTruong"]);
					}
					if (dr["SoDienThoaiHieuTruong"] != null && dr["SoDienThoaiHieuTruong"] != DBNull.Value)
					{
						item.SoDienThoaiHieuTruong = Convert.ToString(dr["SoDienThoaiHieuTruong"]);
					}
					if (dr["DauMoiLienHe"] != null && dr["DauMoiLienHe"] != DBNull.Value)
					{
						item.DauMoiLienHe = Convert.ToString(dr["DauMoiLienHe"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["HieuPho1"] != null && dr["HieuPho1"] != DBNull.Value)
					{
						item.HieuPho1 = Convert.ToString(dr["HieuPho1"]);
					}
					if (dr["SoDienThoaiHP1"] != null && dr["SoDienThoaiHP1"] != DBNull.Value)
					{
						item.SoDienThoaiHP1 = Convert.ToString(dr["SoDienThoaiHP1"]);
					}
					if (dr["HieuPho2"] != null && dr["HieuPho2"] != DBNull.Value)
					{
						item.HieuPho2 = Convert.ToString(dr["HieuPho2"]);
					}
					if (dr["SoDienThoaiHP2"] != null && dr["SoDienThoaiHP2"] != DBNull.Value)
					{
						item.SoDienThoaiHP2 = Convert.ToString(dr["SoDienThoaiHP2"]);
					}
					if (dr["FK_NhanVien"] != null && dr["FK_NhanVien"] != DBNull.Value)
					{
						item.FK_NhanVien = Convert.ToString(dr["FK_NhanVien"]);
					}
					if (dr["FK_PhongGiaoDuc"] != null && dr["FK_PhongGiaoDuc"] != DBNull.Value)
					{
						item.FK_PhongGiaoDuc = Convert.ToString(dr["FK_PhongGiaoDuc"]);
					}
					if (dr["FK_TrungTam"] != null && dr["FK_TrungTam"] != DBNull.Value)
					{
						item.FK_TrungTam = Convert.ToString(dr["FK_TrungTam"]);
					}
					if (dr["FK_CapBac"] != null && dr["FK_CapBac"] != DBNull.Value)
					{
						item.FK_CapBac = Convert.ToString(dr["FK_CapBac"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["GoogleMap1"] != null && dr["GoogleMap1"] != DBNull.Value)
					{
						item.GoogleMap1 = Convert.ToString(dr["GoogleMap1"]);
					}
					if (dr["GoogleMap2"] != null && dr["GoogleMap2"] != DBNull.Value)
					{
						item.GoogleMap2 = Convert.ToString(dr["GoogleMap2"]);
					}
					if (dr["GoogleMap3"] != null && dr["GoogleMap3"] != DBNull.Value)
					{
						item.GoogleMap3 = Convert.ToString(dr["GoogleMap3"]);
					}
					if (dr["GoogleMap4"] != null && dr["GoogleMap4"] != DBNull.Value)
					{
						item.GoogleMap4 = Convert.ToString(dr["GoogleMap4"]);
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
		/// Lấy danh sách MamNonTruongHoc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MamNonTruongHoc> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonTruongHoc] A "+ condition,  parameters);
				List<MamNonTruongHoc> items = new List<MamNonTruongHoc>();
				MamNonTruongHoc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonTruongHoc();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenTruong"] != null && dr["TenTruong"] != DBNull.Value)
					{
						item.TenTruong = Convert.ToString(dr["TenTruong"]);
					}
					if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
					{
						item.EnglishName = Convert.ToString(dr["EnglishName"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["HieuTruong"] != null && dr["HieuTruong"] != DBNull.Value)
					{
						item.HieuTruong = Convert.ToString(dr["HieuTruong"]);
					}
					if (dr["SoDienThoaiHieuTruong"] != null && dr["SoDienThoaiHieuTruong"] != DBNull.Value)
					{
						item.SoDienThoaiHieuTruong = Convert.ToString(dr["SoDienThoaiHieuTruong"]);
					}
					if (dr["DauMoiLienHe"] != null && dr["DauMoiLienHe"] != DBNull.Value)
					{
						item.DauMoiLienHe = Convert.ToString(dr["DauMoiLienHe"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["HieuPho1"] != null && dr["HieuPho1"] != DBNull.Value)
					{
						item.HieuPho1 = Convert.ToString(dr["HieuPho1"]);
					}
					if (dr["SoDienThoaiHP1"] != null && dr["SoDienThoaiHP1"] != DBNull.Value)
					{
						item.SoDienThoaiHP1 = Convert.ToString(dr["SoDienThoaiHP1"]);
					}
					if (dr["HieuPho2"] != null && dr["HieuPho2"] != DBNull.Value)
					{
						item.HieuPho2 = Convert.ToString(dr["HieuPho2"]);
					}
					if (dr["SoDienThoaiHP2"] != null && dr["SoDienThoaiHP2"] != DBNull.Value)
					{
						item.SoDienThoaiHP2 = Convert.ToString(dr["SoDienThoaiHP2"]);
					}
					if (dr["FK_NhanVien"] != null && dr["FK_NhanVien"] != DBNull.Value)
					{
						item.FK_NhanVien = Convert.ToString(dr["FK_NhanVien"]);
					}
					if (dr["FK_PhongGiaoDuc"] != null && dr["FK_PhongGiaoDuc"] != DBNull.Value)
					{
						item.FK_PhongGiaoDuc = Convert.ToString(dr["FK_PhongGiaoDuc"]);
					}
					if (dr["FK_TrungTam"] != null && dr["FK_TrungTam"] != DBNull.Value)
					{
						item.FK_TrungTam = Convert.ToString(dr["FK_TrungTam"]);
					}
					if (dr["FK_CapBac"] != null && dr["FK_CapBac"] != DBNull.Value)
					{
						item.FK_CapBac = Convert.ToString(dr["FK_CapBac"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["GoogleMap1"] != null && dr["GoogleMap1"] != DBNull.Value)
					{
						item.GoogleMap1 = Convert.ToString(dr["GoogleMap1"]);
					}
					if (dr["GoogleMap2"] != null && dr["GoogleMap2"] != DBNull.Value)
					{
						item.GoogleMap2 = Convert.ToString(dr["GoogleMap2"]);
					}
					if (dr["GoogleMap3"] != null && dr["GoogleMap3"] != DBNull.Value)
					{
						item.GoogleMap3 = Convert.ToString(dr["GoogleMap3"]);
					}
					if (dr["GoogleMap4"] != null && dr["GoogleMap4"] != DBNull.Value)
					{
						item.GoogleMap4 = Convert.ToString(dr["GoogleMap4"]);
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

		public List<MamNonTruongHoc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonTruongHoc] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MamNonTruongHoc] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MamNonTruongHoc>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MamNonTruongHoc từ Database
		/// </summary>
		public MamNonTruongHoc GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonTruongHoc] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MamNonTruongHoc item=new MamNonTruongHoc();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["TenTruong"] != null && dr["TenTruong"] != DBNull.Value)
						{
							item.TenTruong = Convert.ToString(dr["TenTruong"]);
						}
						if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
						{
							item.EnglishName = Convert.ToString(dr["EnglishName"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["HieuTruong"] != null && dr["HieuTruong"] != DBNull.Value)
						{
							item.HieuTruong = Convert.ToString(dr["HieuTruong"]);
						}
						if (dr["SoDienThoaiHieuTruong"] != null && dr["SoDienThoaiHieuTruong"] != DBNull.Value)
						{
							item.SoDienThoaiHieuTruong = Convert.ToString(dr["SoDienThoaiHieuTruong"]);
						}
						if (dr["DauMoiLienHe"] != null && dr["DauMoiLienHe"] != DBNull.Value)
						{
							item.DauMoiLienHe = Convert.ToString(dr["DauMoiLienHe"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["HieuPho1"] != null && dr["HieuPho1"] != DBNull.Value)
						{
							item.HieuPho1 = Convert.ToString(dr["HieuPho1"]);
						}
						if (dr["SoDienThoaiHP1"] != null && dr["SoDienThoaiHP1"] != DBNull.Value)
						{
							item.SoDienThoaiHP1 = Convert.ToString(dr["SoDienThoaiHP1"]);
						}
						if (dr["HieuPho2"] != null && dr["HieuPho2"] != DBNull.Value)
						{
							item.HieuPho2 = Convert.ToString(dr["HieuPho2"]);
						}
						if (dr["SoDienThoaiHP2"] != null && dr["SoDienThoaiHP2"] != DBNull.Value)
						{
							item.SoDienThoaiHP2 = Convert.ToString(dr["SoDienThoaiHP2"]);
						}
						if (dr["FK_NhanVien"] != null && dr["FK_NhanVien"] != DBNull.Value)
						{
							item.FK_NhanVien = Convert.ToString(dr["FK_NhanVien"]);
						}
						if (dr["FK_PhongGiaoDuc"] != null && dr["FK_PhongGiaoDuc"] != DBNull.Value)
						{
							item.FK_PhongGiaoDuc = Convert.ToString(dr["FK_PhongGiaoDuc"]);
						}
						if (dr["FK_TrungTam"] != null && dr["FK_TrungTam"] != DBNull.Value)
						{
							item.FK_TrungTam = Convert.ToString(dr["FK_TrungTam"]);
						}
						if (dr["FK_CapBac"] != null && dr["FK_CapBac"] != DBNull.Value)
						{
							item.FK_CapBac = Convert.ToString(dr["FK_CapBac"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
						}
						if (dr["GoogleMap1"] != null && dr["GoogleMap1"] != DBNull.Value)
						{
							item.GoogleMap1 = Convert.ToString(dr["GoogleMap1"]);
						}
						if (dr["GoogleMap2"] != null && dr["GoogleMap2"] != DBNull.Value)
						{
							item.GoogleMap2 = Convert.ToString(dr["GoogleMap2"]);
						}
						if (dr["GoogleMap3"] != null && dr["GoogleMap3"] != DBNull.Value)
						{
							item.GoogleMap3 = Convert.ToString(dr["GoogleMap3"]);
						}
						if (dr["GoogleMap4"] != null && dr["GoogleMap4"] != DBNull.Value)
						{
							item.GoogleMap4 = Convert.ToString(dr["GoogleMap4"]);
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
		/// Lấy một MamNonTruongHoc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MamNonTruongHoc GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonTruongHoc] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MamNonTruongHoc item=new MamNonTruongHoc();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["TenTruong"] != null && dr["TenTruong"] != DBNull.Value)
						{
							item.TenTruong = Convert.ToString(dr["TenTruong"]);
						}
						if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
						{
							item.EnglishName = Convert.ToString(dr["EnglishName"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["HieuTruong"] != null && dr["HieuTruong"] != DBNull.Value)
						{
							item.HieuTruong = Convert.ToString(dr["HieuTruong"]);
						}
						if (dr["SoDienThoaiHieuTruong"] != null && dr["SoDienThoaiHieuTruong"] != DBNull.Value)
						{
							item.SoDienThoaiHieuTruong = Convert.ToString(dr["SoDienThoaiHieuTruong"]);
						}
						if (dr["DauMoiLienHe"] != null && dr["DauMoiLienHe"] != DBNull.Value)
						{
							item.DauMoiLienHe = Convert.ToString(dr["DauMoiLienHe"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["HieuPho1"] != null && dr["HieuPho1"] != DBNull.Value)
						{
							item.HieuPho1 = Convert.ToString(dr["HieuPho1"]);
						}
						if (dr["SoDienThoaiHP1"] != null && dr["SoDienThoaiHP1"] != DBNull.Value)
						{
							item.SoDienThoaiHP1 = Convert.ToString(dr["SoDienThoaiHP1"]);
						}
						if (dr["HieuPho2"] != null && dr["HieuPho2"] != DBNull.Value)
						{
							item.HieuPho2 = Convert.ToString(dr["HieuPho2"]);
						}
						if (dr["SoDienThoaiHP2"] != null && dr["SoDienThoaiHP2"] != DBNull.Value)
						{
							item.SoDienThoaiHP2 = Convert.ToString(dr["SoDienThoaiHP2"]);
						}
						if (dr["FK_NhanVien"] != null && dr["FK_NhanVien"] != DBNull.Value)
						{
							item.FK_NhanVien = Convert.ToString(dr["FK_NhanVien"]);
						}
						if (dr["FK_PhongGiaoDuc"] != null && dr["FK_PhongGiaoDuc"] != DBNull.Value)
						{
							item.FK_PhongGiaoDuc = Convert.ToString(dr["FK_PhongGiaoDuc"]);
						}
						if (dr["FK_TrungTam"] != null && dr["FK_TrungTam"] != DBNull.Value)
						{
							item.FK_TrungTam = Convert.ToString(dr["FK_TrungTam"]);
						}
						if (dr["FK_CapBac"] != null && dr["FK_CapBac"] != DBNull.Value)
						{
							item.FK_CapBac = Convert.ToString(dr["FK_CapBac"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
						}
						if (dr["GoogleMap1"] != null && dr["GoogleMap1"] != DBNull.Value)
						{
							item.GoogleMap1 = Convert.ToString(dr["GoogleMap1"]);
						}
						if (dr["GoogleMap2"] != null && dr["GoogleMap2"] != DBNull.Value)
						{
							item.GoogleMap2 = Convert.ToString(dr["GoogleMap2"]);
						}
						if (dr["GoogleMap3"] != null && dr["GoogleMap3"] != DBNull.Value)
						{
							item.GoogleMap3 = Convert.ToString(dr["GoogleMap3"]);
						}
						if (dr["GoogleMap4"] != null && dr["GoogleMap4"] != DBNull.Value)
						{
							item.GoogleMap4 = Convert.ToString(dr["GoogleMap4"]);
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

		public MamNonTruongHoc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonTruongHoc] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MamNonTruongHoc>(ds);
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
		/// Thêm mới MamNonTruongHoc vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MamNonTruongHoc _MamNonTruongHoc)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MamNonTruongHoc](Id, Code, TenTruong, EnglishName, Phone, DiaChi, Email, HieuTruong, SoDienThoaiHieuTruong, DauMoiLienHe, SoDienThoai, HieuPho1, SoDienThoaiHP1, HieuPho2, SoDienThoaiHP2, FK_NhanVien, FK_PhongGiaoDuc, FK_TrungTam, FK_CapBac, CreateBy, CreateDate, GoogleMap, GoogleMap1, GoogleMap2, GoogleMap3, GoogleMap4) VALUES(@Id, @Code, @TenTruong, @EnglishName, @Phone, @DiaChi, @Email, @HieuTruong, @SoDienThoaiHieuTruong, @DauMoiLienHe, @SoDienThoai, @HieuPho1, @SoDienThoaiHP1, @HieuPho2, @SoDienThoaiHP2, @FK_NhanVien, @FK_PhongGiaoDuc, @FK_TrungTam, @FK_CapBac, @CreateBy, @CreateDate, @GoogleMap, @GoogleMap1, @GoogleMap2, @GoogleMap3, @GoogleMap4)", 
					"@Id",  _MamNonTruongHoc.Id, 
					"@Code",  _MamNonTruongHoc.Code, 
					"@TenTruong",  _MamNonTruongHoc.TenTruong, 
					"@EnglishName",  _MamNonTruongHoc.EnglishName, 
					"@Phone",  _MamNonTruongHoc.Phone, 
					"@DiaChi",  _MamNonTruongHoc.DiaChi, 
					"@Email",  _MamNonTruongHoc.Email, 
					"@HieuTruong",  _MamNonTruongHoc.HieuTruong, 
					"@SoDienThoaiHieuTruong",  _MamNonTruongHoc.SoDienThoaiHieuTruong, 
					"@DauMoiLienHe",  _MamNonTruongHoc.DauMoiLienHe, 
					"@SoDienThoai",  _MamNonTruongHoc.SoDienThoai, 
					"@HieuPho1",  _MamNonTruongHoc.HieuPho1, 
					"@SoDienThoaiHP1",  _MamNonTruongHoc.SoDienThoaiHP1, 
					"@HieuPho2",  _MamNonTruongHoc.HieuPho2, 
					"@SoDienThoaiHP2",  _MamNonTruongHoc.SoDienThoaiHP2, 
					"@FK_NhanVien",  _MamNonTruongHoc.FK_NhanVien, 
					"@FK_PhongGiaoDuc",  _MamNonTruongHoc.FK_PhongGiaoDuc, 
					"@FK_TrungTam",  _MamNonTruongHoc.FK_TrungTam, 
					"@FK_CapBac",  _MamNonTruongHoc.FK_CapBac, 
					"@CreateBy",  _MamNonTruongHoc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _MamNonTruongHoc.CreateDate), 
					"@GoogleMap",  _MamNonTruongHoc.GoogleMap, 
					"@GoogleMap1",  _MamNonTruongHoc.GoogleMap1, 
					"@GoogleMap2",  _MamNonTruongHoc.GoogleMap2, 
					"@GoogleMap3",  _MamNonTruongHoc.GoogleMap3, 
					"@GoogleMap4",  _MamNonTruongHoc.GoogleMap4);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MamNonTruongHoc vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MamNonTruongHoc> _MamNonTruongHocs)
		{
			foreach (MamNonTruongHoc item in _MamNonTruongHocs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonTruongHoc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MamNonTruongHoc _MamNonTruongHoc, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonTruongHoc] SET Id=@Id, Code=@Code, TenTruong=@TenTruong, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, HieuTruong=@HieuTruong, SoDienThoaiHieuTruong=@SoDienThoaiHieuTruong, DauMoiLienHe=@DauMoiLienHe, SoDienThoai=@SoDienThoai, HieuPho1=@HieuPho1, SoDienThoaiHP1=@SoDienThoaiHP1, HieuPho2=@HieuPho2, SoDienThoaiHP2=@SoDienThoaiHP2, FK_NhanVien=@FK_NhanVien, FK_PhongGiaoDuc=@FK_PhongGiaoDuc, FK_TrungTam=@FK_TrungTam, FK_CapBac=@FK_CapBac, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, GoogleMap1=@GoogleMap1, GoogleMap2=@GoogleMap2, GoogleMap3=@GoogleMap3, GoogleMap4=@GoogleMap4 WHERE Id=@Id", 
					"@Id",  _MamNonTruongHoc.Id, 
					"@Code",  _MamNonTruongHoc.Code, 
					"@TenTruong",  _MamNonTruongHoc.TenTruong, 
					"@EnglishName",  _MamNonTruongHoc.EnglishName, 
					"@Phone",  _MamNonTruongHoc.Phone, 
					"@DiaChi",  _MamNonTruongHoc.DiaChi, 
					"@Email",  _MamNonTruongHoc.Email, 
					"@HieuTruong",  _MamNonTruongHoc.HieuTruong, 
					"@SoDienThoaiHieuTruong",  _MamNonTruongHoc.SoDienThoaiHieuTruong, 
					"@DauMoiLienHe",  _MamNonTruongHoc.DauMoiLienHe, 
					"@SoDienThoai",  _MamNonTruongHoc.SoDienThoai, 
					"@HieuPho1",  _MamNonTruongHoc.HieuPho1, 
					"@SoDienThoaiHP1",  _MamNonTruongHoc.SoDienThoaiHP1, 
					"@HieuPho2",  _MamNonTruongHoc.HieuPho2, 
					"@SoDienThoaiHP2",  _MamNonTruongHoc.SoDienThoaiHP2, 
					"@FK_NhanVien",  _MamNonTruongHoc.FK_NhanVien, 
					"@FK_PhongGiaoDuc",  _MamNonTruongHoc.FK_PhongGiaoDuc, 
					"@FK_TrungTam",  _MamNonTruongHoc.FK_TrungTam, 
					"@FK_CapBac",  _MamNonTruongHoc.FK_CapBac, 
					"@CreateBy",  _MamNonTruongHoc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _MamNonTruongHoc.CreateDate), 
					"@GoogleMap",  _MamNonTruongHoc.GoogleMap, 
					"@GoogleMap1",  _MamNonTruongHoc.GoogleMap1, 
					"@GoogleMap2",  _MamNonTruongHoc.GoogleMap2, 
					"@GoogleMap3",  _MamNonTruongHoc.GoogleMap3, 
					"@GoogleMap4",  _MamNonTruongHoc.GoogleMap4, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MamNonTruongHoc vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MamNonTruongHoc _MamNonTruongHoc)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonTruongHoc] SET Code=@Code, TenTruong=@TenTruong, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, HieuTruong=@HieuTruong, SoDienThoaiHieuTruong=@SoDienThoaiHieuTruong, DauMoiLienHe=@DauMoiLienHe, SoDienThoai=@SoDienThoai, HieuPho1=@HieuPho1, SoDienThoaiHP1=@SoDienThoaiHP1, HieuPho2=@HieuPho2, SoDienThoaiHP2=@SoDienThoaiHP2, FK_NhanVien=@FK_NhanVien, FK_PhongGiaoDuc=@FK_PhongGiaoDuc, FK_TrungTam=@FK_TrungTam, FK_CapBac=@FK_CapBac, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, GoogleMap1=@GoogleMap1, GoogleMap2=@GoogleMap2, GoogleMap3=@GoogleMap3, GoogleMap4=@GoogleMap4 WHERE Id=@Id", 
					"@Code",  _MamNonTruongHoc.Code, 
					"@TenTruong",  _MamNonTruongHoc.TenTruong, 
					"@EnglishName",  _MamNonTruongHoc.EnglishName, 
					"@Phone",  _MamNonTruongHoc.Phone, 
					"@DiaChi",  _MamNonTruongHoc.DiaChi, 
					"@Email",  _MamNonTruongHoc.Email, 
					"@HieuTruong",  _MamNonTruongHoc.HieuTruong, 
					"@SoDienThoaiHieuTruong",  _MamNonTruongHoc.SoDienThoaiHieuTruong, 
					"@DauMoiLienHe",  _MamNonTruongHoc.DauMoiLienHe, 
					"@SoDienThoai",  _MamNonTruongHoc.SoDienThoai, 
					"@HieuPho1",  _MamNonTruongHoc.HieuPho1, 
					"@SoDienThoaiHP1",  _MamNonTruongHoc.SoDienThoaiHP1, 
					"@HieuPho2",  _MamNonTruongHoc.HieuPho2, 
					"@SoDienThoaiHP2",  _MamNonTruongHoc.SoDienThoaiHP2, 
					"@FK_NhanVien",  _MamNonTruongHoc.FK_NhanVien, 
					"@FK_PhongGiaoDuc",  _MamNonTruongHoc.FK_PhongGiaoDuc, 
					"@FK_TrungTam",  _MamNonTruongHoc.FK_TrungTam, 
					"@FK_CapBac",  _MamNonTruongHoc.FK_CapBac, 
					"@CreateBy",  _MamNonTruongHoc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _MamNonTruongHoc.CreateDate), 
					"@GoogleMap",  _MamNonTruongHoc.GoogleMap, 
					"@GoogleMap1",  _MamNonTruongHoc.GoogleMap1, 
					"@GoogleMap2",  _MamNonTruongHoc.GoogleMap2, 
					"@GoogleMap3",  _MamNonTruongHoc.GoogleMap3, 
					"@GoogleMap4",  _MamNonTruongHoc.GoogleMap4, 
					"@Id", _MamNonTruongHoc.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MamNonTruongHoc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MamNonTruongHoc> _MamNonTruongHocs)
		{
			foreach (MamNonTruongHoc item in _MamNonTruongHocs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonTruongHoc vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MamNonTruongHoc _MamNonTruongHoc, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonTruongHoc] SET Id=@Id, Code=@Code, TenTruong=@TenTruong, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, HieuTruong=@HieuTruong, SoDienThoaiHieuTruong=@SoDienThoaiHieuTruong, DauMoiLienHe=@DauMoiLienHe, SoDienThoai=@SoDienThoai, HieuPho1=@HieuPho1, SoDienThoaiHP1=@SoDienThoaiHP1, HieuPho2=@HieuPho2, SoDienThoaiHP2=@SoDienThoaiHP2, FK_NhanVien=@FK_NhanVien, FK_PhongGiaoDuc=@FK_PhongGiaoDuc, FK_TrungTam=@FK_TrungTam, FK_CapBac=@FK_CapBac, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, GoogleMap1=@GoogleMap1, GoogleMap2=@GoogleMap2, GoogleMap3=@GoogleMap3, GoogleMap4=@GoogleMap4 "+ condition, 
					"@Id",  _MamNonTruongHoc.Id, 
					"@Code",  _MamNonTruongHoc.Code, 
					"@TenTruong",  _MamNonTruongHoc.TenTruong, 
					"@EnglishName",  _MamNonTruongHoc.EnglishName, 
					"@Phone",  _MamNonTruongHoc.Phone, 
					"@DiaChi",  _MamNonTruongHoc.DiaChi, 
					"@Email",  _MamNonTruongHoc.Email, 
					"@HieuTruong",  _MamNonTruongHoc.HieuTruong, 
					"@SoDienThoaiHieuTruong",  _MamNonTruongHoc.SoDienThoaiHieuTruong, 
					"@DauMoiLienHe",  _MamNonTruongHoc.DauMoiLienHe, 
					"@SoDienThoai",  _MamNonTruongHoc.SoDienThoai, 
					"@HieuPho1",  _MamNonTruongHoc.HieuPho1, 
					"@SoDienThoaiHP1",  _MamNonTruongHoc.SoDienThoaiHP1, 
					"@HieuPho2",  _MamNonTruongHoc.HieuPho2, 
					"@SoDienThoaiHP2",  _MamNonTruongHoc.SoDienThoaiHP2, 
					"@FK_NhanVien",  _MamNonTruongHoc.FK_NhanVien, 
					"@FK_PhongGiaoDuc",  _MamNonTruongHoc.FK_PhongGiaoDuc, 
					"@FK_TrungTam",  _MamNonTruongHoc.FK_TrungTam, 
					"@FK_CapBac",  _MamNonTruongHoc.FK_CapBac, 
					"@CreateBy",  _MamNonTruongHoc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _MamNonTruongHoc.CreateDate), 
					"@GoogleMap",  _MamNonTruongHoc.GoogleMap, 
					"@GoogleMap1",  _MamNonTruongHoc.GoogleMap1, 
					"@GoogleMap2",  _MamNonTruongHoc.GoogleMap2, 
					"@GoogleMap3",  _MamNonTruongHoc.GoogleMap3, 
					"@GoogleMap4",  _MamNonTruongHoc.GoogleMap4);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MamNonTruongHoc trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonTruongHoc] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonTruongHoc trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MamNonTruongHoc _MamNonTruongHoc)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonTruongHoc] WHERE Id=@Id",
					"@Id", _MamNonTruongHoc.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonTruongHoc trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonTruongHoc] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonTruongHoc trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MamNonTruongHoc> _MamNonTruongHocs)
		{
			foreach (MamNonTruongHoc item in _MamNonTruongHocs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
