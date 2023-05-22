using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewmamnontruonghoc:IVIewmamnontruonghoc
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewmamnontruonghoc(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_MamNonTruongHoc từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_MamNonTruongHoc]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_MamNonTruongHoc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_MamNonTruongHoc] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_MamNonTruongHoc từ Database
		/// </summary>
		public List<view_MamNonTruongHoc> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_MamNonTruongHoc]");
				List<view_MamNonTruongHoc> items = new List<view_MamNonTruongHoc>();
				view_MamNonTruongHoc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_MamNonTruongHoc();
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
					if (dr["NhanVienFullName"] != null && dr["NhanVienFullName"] != DBNull.Value)
					{
						item.NhanVienFullName = Convert.ToString(dr["NhanVienFullName"]);
					}
					if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
					{
						item.TenPhong = Convert.ToString(dr["TenPhong"]);
					}
					if (dr["TrungTam"] != null && dr["TrungTam"] != DBNull.Value)
					{
						item.TrungTam = Convert.ToString(dr["TrungTam"]);
					}
					if (dr["CapBac"] != null && dr["CapBac"] != DBNull.Value)
					{
						item.CapBac = Convert.ToString(dr["CapBac"]);
					}
					if (dr["CreateName"] != null && dr["CreateName"] != DBNull.Value)
					{
						item.CreateName = Convert.ToString(dr["CreateName"]);
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
		/// Lấy danh sách view_MamNonTruongHoc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_MamNonTruongHoc> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_MamNonTruongHoc] A "+ condition,  parameters);
				List<view_MamNonTruongHoc> items = new List<view_MamNonTruongHoc>();
				view_MamNonTruongHoc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_MamNonTruongHoc();
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
					if (dr["NhanVienFullName"] != null && dr["NhanVienFullName"] != DBNull.Value)
					{
						item.NhanVienFullName = Convert.ToString(dr["NhanVienFullName"]);
					}
					if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
					{
						item.TenPhong = Convert.ToString(dr["TenPhong"]);
					}
					if (dr["TrungTam"] != null && dr["TrungTam"] != DBNull.Value)
					{
						item.TrungTam = Convert.ToString(dr["TrungTam"]);
					}
					if (dr["CapBac"] != null && dr["CapBac"] != DBNull.Value)
					{
						item.CapBac = Convert.ToString(dr["CapBac"]);
					}
					if (dr["CreateName"] != null && dr["CreateName"] != DBNull.Value)
					{
						item.CreateName = Convert.ToString(dr["CreateName"]);
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

		public List<view_MamNonTruongHoc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_MamNonTruongHoc] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_MamNonTruongHoc] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_MamNonTruongHoc>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_MamNonTruongHoc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_MamNonTruongHoc GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_MamNonTruongHoc] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_MamNonTruongHoc item=new view_MamNonTruongHoc();
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
						if (dr["NhanVienFullName"] != null && dr["NhanVienFullName"] != DBNull.Value)
						{
							item.NhanVienFullName = Convert.ToString(dr["NhanVienFullName"]);
						}
						if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
						{
							item.TenPhong = Convert.ToString(dr["TenPhong"]);
						}
						if (dr["TrungTam"] != null && dr["TrungTam"] != DBNull.Value)
						{
							item.TrungTam = Convert.ToString(dr["TrungTam"]);
						}
						if (dr["CapBac"] != null && dr["CapBac"] != DBNull.Value)
						{
							item.CapBac = Convert.ToString(dr["CapBac"]);
						}
						if (dr["CreateName"] != null && dr["CreateName"] != DBNull.Value)
						{
							item.CreateName = Convert.ToString(dr["CreateName"]);
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

		public view_MamNonTruongHoc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_MamNonTruongHoc] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_MamNonTruongHoc>(ds);
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
	}
}
