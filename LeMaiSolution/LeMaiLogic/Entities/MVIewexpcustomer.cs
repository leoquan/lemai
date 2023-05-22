using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpcustomer:IVIewexpcustomer
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpcustomer(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpCustomer từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpCustomer]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpCustomer] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpCustomer từ Database
		/// </summary>
		public List<view_ExpCustomer> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpCustomer]");
				List<view_ExpCustomer> items = new List<view_ExpCustomer>();
				view_ExpCustomer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpCustomer();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
					{
						item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["AccountName"] != null && dr["AccountName"] != DBNull.Value)
					{
						item.AccountName = Convert.ToString(dr["AccountName"]);
					}
					if (dr["AccountCode"] != null && dr["AccountCode"] != DBNull.Value)
					{
						item.AccountCode = Convert.ToString(dr["AccountCode"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["ContractCustomer"] != null && dr["ContractCustomer"] != DBNull.Value)
					{
						item.ContractCustomer = Convert.ToBoolean(dr["ContractCustomer"]);
					}
					if (dr["UnsigName"] != null && dr["UnsigName"] != DBNull.Value)
					{
						item.UnsigName = Convert.ToString(dr["UnsigName"]);
					}
					if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
					{
						item.FK_Group = Convert.ToString(dr["FK_Group"]);
					}
					if (dr["SoHopDong"] != null && dr["SoHopDong"] != DBNull.Value)
					{
						item.SoHopDong = Convert.ToString(dr["SoHopDong"]);
					}
					if (dr["NgayHopDong"] != null && dr["NgayHopDong"] != DBNull.Value)
					{
						item.NgayHopDong = Convert.ToDateTime(dr["NgayHopDong"]);
					}
					if (dr["TenHopDong"] != null && dr["TenHopDong"] != DBNull.Value)
					{
						item.TenHopDong = Convert.ToString(dr["TenHopDong"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["FK_GiaCuoc"] != null && dr["FK_GiaCuoc"] != DBNull.Value)
					{
						item.FK_GiaCuoc = Convert.ToString(dr["FK_GiaCuoc"]);
					}
					if (dr["DonVi"] != null && dr["DonVi"] != DBNull.Value)
					{
						item.DonVi = Convert.ToString(dr["DonVi"]);
					}
					if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
					{
						item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
					}
					if (dr["CustomerCodePass"] != null && dr["CustomerCodePass"] != DBNull.Value)
					{
						item.CustomerCodePass = Convert.ToString(dr["CustomerCodePass"]);
					}
					if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
					{
						item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
					}
					if (dr["Token"] != null && dr["Token"] != DBNull.Value)
					{
						item.Token = Convert.ToString(dr["Token"]);
					}
					if (dr["ShopIDPickup"] != null && dr["ShopIDPickup"] != DBNull.Value)
					{
						item.ShopIDPickup = Convert.ToString(dr["ShopIDPickup"]);
					}
					if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
					{
						item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
					}
					if (dr["SecrectId"] != null && dr["SecrectId"] != DBNull.Value)
					{
						item.SecrectId = Convert.ToString(dr["SecrectId"]);
					}
					if (dr["ProvinceId"] != null && dr["ProvinceId"] != DBNull.Value)
					{
						item.ProvinceId = Convert.ToInt32(dr["ProvinceId"]);
					}
					if (dr["DistrictId"] != null && dr["DistrictId"] != DBNull.Value)
					{
						item.DistrictId = Convert.ToInt32(dr["DistrictId"]);
					}
					if (dr["WardId"] != null && dr["WardId"] != DBNull.Value)
					{
						item.WardId = Convert.ToString(dr["WardId"]);
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
		/// Lấy danh sách view_ExpCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpCustomer> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpCustomer] A "+ condition,  parameters);
				List<view_ExpCustomer> items = new List<view_ExpCustomer>();
				view_ExpCustomer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpCustomer();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
					{
						item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["AccountName"] != null && dr["AccountName"] != DBNull.Value)
					{
						item.AccountName = Convert.ToString(dr["AccountName"]);
					}
					if (dr["AccountCode"] != null && dr["AccountCode"] != DBNull.Value)
					{
						item.AccountCode = Convert.ToString(dr["AccountCode"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["ContractCustomer"] != null && dr["ContractCustomer"] != DBNull.Value)
					{
						item.ContractCustomer = Convert.ToBoolean(dr["ContractCustomer"]);
					}
					if (dr["UnsigName"] != null && dr["UnsigName"] != DBNull.Value)
					{
						item.UnsigName = Convert.ToString(dr["UnsigName"]);
					}
					if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
					{
						item.FK_Group = Convert.ToString(dr["FK_Group"]);
					}
					if (dr["SoHopDong"] != null && dr["SoHopDong"] != DBNull.Value)
					{
						item.SoHopDong = Convert.ToString(dr["SoHopDong"]);
					}
					if (dr["NgayHopDong"] != null && dr["NgayHopDong"] != DBNull.Value)
					{
						item.NgayHopDong = Convert.ToDateTime(dr["NgayHopDong"]);
					}
					if (dr["TenHopDong"] != null && dr["TenHopDong"] != DBNull.Value)
					{
						item.TenHopDong = Convert.ToString(dr["TenHopDong"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["FK_GiaCuoc"] != null && dr["FK_GiaCuoc"] != DBNull.Value)
					{
						item.FK_GiaCuoc = Convert.ToString(dr["FK_GiaCuoc"]);
					}
					if (dr["DonVi"] != null && dr["DonVi"] != DBNull.Value)
					{
						item.DonVi = Convert.ToString(dr["DonVi"]);
					}
					if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
					{
						item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
					}
					if (dr["CustomerCodePass"] != null && dr["CustomerCodePass"] != DBNull.Value)
					{
						item.CustomerCodePass = Convert.ToString(dr["CustomerCodePass"]);
					}
					if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
					{
						item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
					}
					if (dr["Token"] != null && dr["Token"] != DBNull.Value)
					{
						item.Token = Convert.ToString(dr["Token"]);
					}
					if (dr["ShopIDPickup"] != null && dr["ShopIDPickup"] != DBNull.Value)
					{
						item.ShopIDPickup = Convert.ToString(dr["ShopIDPickup"]);
					}
					if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
					{
						item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
					}
					if (dr["SecrectId"] != null && dr["SecrectId"] != DBNull.Value)
					{
						item.SecrectId = Convert.ToString(dr["SecrectId"]);
					}
					if (dr["ProvinceId"] != null && dr["ProvinceId"] != DBNull.Value)
					{
						item.ProvinceId = Convert.ToInt32(dr["ProvinceId"]);
					}
					if (dr["DistrictId"] != null && dr["DistrictId"] != DBNull.Value)
					{
						item.DistrictId = Convert.ToInt32(dr["DistrictId"]);
					}
					if (dr["WardId"] != null && dr["WardId"] != DBNull.Value)
					{
						item.WardId = Convert.ToString(dr["WardId"]);
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

		public List<view_ExpCustomer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpCustomer] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpCustomer] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpCustomer>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpCustomer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpCustomer GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpCustomer] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpCustomer item=new view_ExpCustomer();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
						{
							item.CustomerName = Convert.ToString(dr["CustomerName"]);
						}
						if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
						{
							item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
						}
						if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
						{
							item.BankName = Convert.ToString(dr["BankName"]);
						}
						if (dr["AccountName"] != null && dr["AccountName"] != DBNull.Value)
						{
							item.AccountName = Convert.ToString(dr["AccountName"]);
						}
						if (dr["AccountCode"] != null && dr["AccountCode"] != DBNull.Value)
						{
							item.AccountCode = Convert.ToString(dr["AccountCode"]);
						}
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
						{
							item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
						}
						if (dr["ContractCustomer"] != null && dr["ContractCustomer"] != DBNull.Value)
						{
							item.ContractCustomer = Convert.ToBoolean(dr["ContractCustomer"]);
						}
						if (dr["UnsigName"] != null && dr["UnsigName"] != DBNull.Value)
						{
							item.UnsigName = Convert.ToString(dr["UnsigName"]);
						}
						if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
						{
							item.FK_Group = Convert.ToString(dr["FK_Group"]);
						}
						if (dr["SoHopDong"] != null && dr["SoHopDong"] != DBNull.Value)
						{
							item.SoHopDong = Convert.ToString(dr["SoHopDong"]);
						}
						if (dr["NgayHopDong"] != null && dr["NgayHopDong"] != DBNull.Value)
						{
							item.NgayHopDong = Convert.ToDateTime(dr["NgayHopDong"]);
						}
						if (dr["TenHopDong"] != null && dr["TenHopDong"] != DBNull.Value)
						{
							item.TenHopDong = Convert.ToString(dr["TenHopDong"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["FK_GiaCuoc"] != null && dr["FK_GiaCuoc"] != DBNull.Value)
						{
							item.FK_GiaCuoc = Convert.ToString(dr["FK_GiaCuoc"]);
						}
						if (dr["DonVi"] != null && dr["DonVi"] != DBNull.Value)
						{
							item.DonVi = Convert.ToString(dr["DonVi"]);
						}
						if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
						{
							item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
						}
						if (dr["CustomerCodePass"] != null && dr["CustomerCodePass"] != DBNull.Value)
						{
							item.CustomerCodePass = Convert.ToString(dr["CustomerCodePass"]);
						}
						if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
						{
							item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
						}
						if (dr["Token"] != null && dr["Token"] != DBNull.Value)
						{
							item.Token = Convert.ToString(dr["Token"]);
						}
						if (dr["ShopIDPickup"] != null && dr["ShopIDPickup"] != DBNull.Value)
						{
							item.ShopIDPickup = Convert.ToString(dr["ShopIDPickup"]);
						}
						if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
						{
							item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
						}
						if (dr["SecrectId"] != null && dr["SecrectId"] != DBNull.Value)
						{
							item.SecrectId = Convert.ToString(dr["SecrectId"]);
						}
						if (dr["ProvinceId"] != null && dr["ProvinceId"] != DBNull.Value)
						{
							item.ProvinceId = Convert.ToInt32(dr["ProvinceId"]);
						}
						if (dr["DistrictId"] != null && dr["DistrictId"] != DBNull.Value)
						{
							item.DistrictId = Convert.ToInt32(dr["DistrictId"]);
						}
						if (dr["WardId"] != null && dr["WardId"] != DBNull.Value)
						{
							item.WardId = Convert.ToString(dr["WardId"]);
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

		public view_ExpCustomer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpCustomer] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpCustomer>(ds);
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
