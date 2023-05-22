using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcustomer:IEXpcustomer
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcustomer(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCustomer từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomer]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomer] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCustomer từ Database
		/// </summary>
		public List<ExpCustomer> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomer]");
				List<ExpCustomer> items = new List<ExpCustomer>();
				ExpCustomer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCustomer();
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
		/// Lấy danh sách ExpCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCustomer> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCustomer] A "+ condition,  parameters);
				List<ExpCustomer> items = new List<ExpCustomer>();
				ExpCustomer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCustomer();
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

		public List<ExpCustomer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCustomer] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCustomer] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCustomer>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCustomer từ Database
		/// </summary>
		public ExpCustomer GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomer] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpCustomer item=new ExpCustomer();
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

		/// <summary>
		/// Lấy một ExpCustomer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCustomer GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCustomer] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCustomer item=new ExpCustomer();
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

		public ExpCustomer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCustomer] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCustomer>(ds);
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
		/// Thêm mới ExpCustomer vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCustomer _ExpCustomer)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCustomer](Id, CustomerName, CustomerPhone, BankName, AccountName, AccountCode, GoogleMap, FK_Post, CustomerCode, ContractCustomer, UnsigName, FK_Group, SoHopDong, NgayHopDong, TenHopDong, DiaChi, FK_GiaCuoc, DonVi, MaSoThue, CustomerCodePass, TenSanPham, Token, ShopIDPickup, IsPickup, SecrectId, ProvinceId, DistrictId, WardId) VALUES(@Id, @CustomerName, @CustomerPhone, @BankName, @AccountName, @AccountCode, @GoogleMap, @FK_Post, @CustomerCode, @ContractCustomer, @UnsigName, @FK_Group, @SoHopDong, @NgayHopDong, @TenHopDong, @DiaChi, @FK_GiaCuoc, @DonVi, @MaSoThue, @CustomerCodePass, @TenSanPham, @Token, @ShopIDPickup, @IsPickup, @SecrectId, @ProvinceId, @DistrictId, @WardId)", 
					"@Id",  _ExpCustomer.Id, 
					"@CustomerName",  _ExpCustomer.CustomerName, 
					"@CustomerPhone",  _ExpCustomer.CustomerPhone, 
					"@BankName",  _ExpCustomer.BankName, 
					"@AccountName",  _ExpCustomer.AccountName, 
					"@AccountCode",  _ExpCustomer.AccountCode, 
					"@GoogleMap",  _ExpCustomer.GoogleMap, 
					"@FK_Post",  _ExpCustomer.FK_Post, 
					"@CustomerCode",  _ExpCustomer.CustomerCode, 
					"@ContractCustomer",  _ExpCustomer.ContractCustomer, 
					"@UnsigName",  _ExpCustomer.UnsigName, 
					"@FK_Group",  _ExpCustomer.FK_Group, 
					"@SoHopDong",  _ExpCustomer.SoHopDong, 
					"@NgayHopDong", this._dataContext.ConvertDateString( _ExpCustomer.NgayHopDong), 
					"@TenHopDong",  _ExpCustomer.TenHopDong, 
					"@DiaChi",  _ExpCustomer.DiaChi, 
					"@FK_GiaCuoc",  _ExpCustomer.FK_GiaCuoc, 
					"@DonVi",  _ExpCustomer.DonVi, 
					"@MaSoThue",  _ExpCustomer.MaSoThue, 
					"@CustomerCodePass",  _ExpCustomer.CustomerCodePass, 
					"@TenSanPham",  _ExpCustomer.TenSanPham, 
					"@Token",  _ExpCustomer.Token, 
					"@ShopIDPickup",  _ExpCustomer.ShopIDPickup, 
					"@IsPickup",  _ExpCustomer.IsPickup, 
					"@SecrectId",  _ExpCustomer.SecrectId, 
					"@ProvinceId",  _ExpCustomer.ProvinceId, 
					"@DistrictId",  _ExpCustomer.DistrictId, 
					"@WardId",  _ExpCustomer.WardId);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCustomer vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCustomer> _ExpCustomers)
		{
			foreach (ExpCustomer item in _ExpCustomers)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCustomer _ExpCustomer, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCustomer] SET Id=@Id, CustomerName=@CustomerName, CustomerPhone=@CustomerPhone, BankName=@BankName, AccountName=@AccountName, AccountCode=@AccountCode, GoogleMap=@GoogleMap, FK_Post=@FK_Post, CustomerCode=@CustomerCode, ContractCustomer=@ContractCustomer, UnsigName=@UnsigName, FK_Group=@FK_Group, SoHopDong=@SoHopDong, NgayHopDong=@NgayHopDong, TenHopDong=@TenHopDong, DiaChi=@DiaChi, FK_GiaCuoc=@FK_GiaCuoc, DonVi=@DonVi, MaSoThue=@MaSoThue, CustomerCodePass=@CustomerCodePass, TenSanPham=@TenSanPham, Token=@Token, ShopIDPickup=@ShopIDPickup, IsPickup=@IsPickup, SecrectId=@SecrectId, ProvinceId=@ProvinceId, DistrictId=@DistrictId, WardId=@WardId WHERE Id=@Id", 
					"@Id",  _ExpCustomer.Id, 
					"@CustomerName",  _ExpCustomer.CustomerName, 
					"@CustomerPhone",  _ExpCustomer.CustomerPhone, 
					"@BankName",  _ExpCustomer.BankName, 
					"@AccountName",  _ExpCustomer.AccountName, 
					"@AccountCode",  _ExpCustomer.AccountCode, 
					"@GoogleMap",  _ExpCustomer.GoogleMap, 
					"@FK_Post",  _ExpCustomer.FK_Post, 
					"@CustomerCode",  _ExpCustomer.CustomerCode, 
					"@ContractCustomer",  _ExpCustomer.ContractCustomer, 
					"@UnsigName",  _ExpCustomer.UnsigName, 
					"@FK_Group",  _ExpCustomer.FK_Group, 
					"@SoHopDong",  _ExpCustomer.SoHopDong, 
					"@NgayHopDong", this._dataContext.ConvertDateString( _ExpCustomer.NgayHopDong), 
					"@TenHopDong",  _ExpCustomer.TenHopDong, 
					"@DiaChi",  _ExpCustomer.DiaChi, 
					"@FK_GiaCuoc",  _ExpCustomer.FK_GiaCuoc, 
					"@DonVi",  _ExpCustomer.DonVi, 
					"@MaSoThue",  _ExpCustomer.MaSoThue, 
					"@CustomerCodePass",  _ExpCustomer.CustomerCodePass, 
					"@TenSanPham",  _ExpCustomer.TenSanPham, 
					"@Token",  _ExpCustomer.Token, 
					"@ShopIDPickup",  _ExpCustomer.ShopIDPickup, 
					"@IsPickup",  _ExpCustomer.IsPickup, 
					"@SecrectId",  _ExpCustomer.SecrectId, 
					"@ProvinceId",  _ExpCustomer.ProvinceId, 
					"@DistrictId",  _ExpCustomer.DistrictId, 
					"@WardId",  _ExpCustomer.WardId, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCustomer vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCustomer _ExpCustomer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCustomer] SET CustomerName=@CustomerName, CustomerPhone=@CustomerPhone, BankName=@BankName, AccountName=@AccountName, AccountCode=@AccountCode, GoogleMap=@GoogleMap, FK_Post=@FK_Post, CustomerCode=@CustomerCode, ContractCustomer=@ContractCustomer, UnsigName=@UnsigName, FK_Group=@FK_Group, SoHopDong=@SoHopDong, NgayHopDong=@NgayHopDong, TenHopDong=@TenHopDong, DiaChi=@DiaChi, FK_GiaCuoc=@FK_GiaCuoc, DonVi=@DonVi, MaSoThue=@MaSoThue, CustomerCodePass=@CustomerCodePass, TenSanPham=@TenSanPham, Token=@Token, ShopIDPickup=@ShopIDPickup, IsPickup=@IsPickup, SecrectId=@SecrectId, ProvinceId=@ProvinceId, DistrictId=@DistrictId, WardId=@WardId WHERE Id=@Id", 
					"@CustomerName",  _ExpCustomer.CustomerName, 
					"@CustomerPhone",  _ExpCustomer.CustomerPhone, 
					"@BankName",  _ExpCustomer.BankName, 
					"@AccountName",  _ExpCustomer.AccountName, 
					"@AccountCode",  _ExpCustomer.AccountCode, 
					"@GoogleMap",  _ExpCustomer.GoogleMap, 
					"@FK_Post",  _ExpCustomer.FK_Post, 
					"@CustomerCode",  _ExpCustomer.CustomerCode, 
					"@ContractCustomer",  _ExpCustomer.ContractCustomer, 
					"@UnsigName",  _ExpCustomer.UnsigName, 
					"@FK_Group",  _ExpCustomer.FK_Group, 
					"@SoHopDong",  _ExpCustomer.SoHopDong, 
					"@NgayHopDong", this._dataContext.ConvertDateString( _ExpCustomer.NgayHopDong), 
					"@TenHopDong",  _ExpCustomer.TenHopDong, 
					"@DiaChi",  _ExpCustomer.DiaChi, 
					"@FK_GiaCuoc",  _ExpCustomer.FK_GiaCuoc, 
					"@DonVi",  _ExpCustomer.DonVi, 
					"@MaSoThue",  _ExpCustomer.MaSoThue, 
					"@CustomerCodePass",  _ExpCustomer.CustomerCodePass, 
					"@TenSanPham",  _ExpCustomer.TenSanPham, 
					"@Token",  _ExpCustomer.Token, 
					"@ShopIDPickup",  _ExpCustomer.ShopIDPickup, 
					"@IsPickup",  _ExpCustomer.IsPickup, 
					"@SecrectId",  _ExpCustomer.SecrectId, 
					"@ProvinceId",  _ExpCustomer.ProvinceId, 
					"@DistrictId",  _ExpCustomer.DistrictId, 
					"@WardId",  _ExpCustomer.WardId, 
					"@Id", _ExpCustomer.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCustomer> _ExpCustomers)
		{
			foreach (ExpCustomer item in _ExpCustomers)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCustomer vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCustomer _ExpCustomer, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCustomer] SET Id=@Id, CustomerName=@CustomerName, CustomerPhone=@CustomerPhone, BankName=@BankName, AccountName=@AccountName, AccountCode=@AccountCode, GoogleMap=@GoogleMap, FK_Post=@FK_Post, CustomerCode=@CustomerCode, ContractCustomer=@ContractCustomer, UnsigName=@UnsigName, FK_Group=@FK_Group, SoHopDong=@SoHopDong, NgayHopDong=@NgayHopDong, TenHopDong=@TenHopDong, DiaChi=@DiaChi, FK_GiaCuoc=@FK_GiaCuoc, DonVi=@DonVi, MaSoThue=@MaSoThue, CustomerCodePass=@CustomerCodePass, TenSanPham=@TenSanPham, Token=@Token, ShopIDPickup=@ShopIDPickup, IsPickup=@IsPickup, SecrectId=@SecrectId, ProvinceId=@ProvinceId, DistrictId=@DistrictId, WardId=@WardId "+ condition, 
					"@Id",  _ExpCustomer.Id, 
					"@CustomerName",  _ExpCustomer.CustomerName, 
					"@CustomerPhone",  _ExpCustomer.CustomerPhone, 
					"@BankName",  _ExpCustomer.BankName, 
					"@AccountName",  _ExpCustomer.AccountName, 
					"@AccountCode",  _ExpCustomer.AccountCode, 
					"@GoogleMap",  _ExpCustomer.GoogleMap, 
					"@FK_Post",  _ExpCustomer.FK_Post, 
					"@CustomerCode",  _ExpCustomer.CustomerCode, 
					"@ContractCustomer",  _ExpCustomer.ContractCustomer, 
					"@UnsigName",  _ExpCustomer.UnsigName, 
					"@FK_Group",  _ExpCustomer.FK_Group, 
					"@SoHopDong",  _ExpCustomer.SoHopDong, 
					"@NgayHopDong", this._dataContext.ConvertDateString( _ExpCustomer.NgayHopDong), 
					"@TenHopDong",  _ExpCustomer.TenHopDong, 
					"@DiaChi",  _ExpCustomer.DiaChi, 
					"@FK_GiaCuoc",  _ExpCustomer.FK_GiaCuoc, 
					"@DonVi",  _ExpCustomer.DonVi, 
					"@MaSoThue",  _ExpCustomer.MaSoThue, 
					"@CustomerCodePass",  _ExpCustomer.CustomerCodePass, 
					"@TenSanPham",  _ExpCustomer.TenSanPham, 
					"@Token",  _ExpCustomer.Token, 
					"@ShopIDPickup",  _ExpCustomer.ShopIDPickup, 
					"@IsPickup",  _ExpCustomer.IsPickup, 
					"@SecrectId",  _ExpCustomer.SecrectId, 
					"@ProvinceId",  _ExpCustomer.ProvinceId, 
					"@DistrictId",  _ExpCustomer.DistrictId, 
					"@WardId",  _ExpCustomer.WardId);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCustomer trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCustomer] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCustomer trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCustomer _ExpCustomer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCustomer] WHERE Id=@Id",
					"@Id", _ExpCustomer.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCustomer trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCustomer] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCustomer trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCustomer> _ExpCustomers)
		{
			foreach (ExpCustomer item in _ExpCustomers)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
