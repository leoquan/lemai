using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpconsigndelivery:IVIewexpconsigndelivery
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpconsigndelivery(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpConsignDelivery từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignDelivery]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpConsignDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignDelivery] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpConsignDelivery từ Database
		/// </summary>
		public List<view_ExpConsignDelivery> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignDelivery]");
				List<view_ExpConsignDelivery> items = new List<view_ExpConsignDelivery>();
				view_ExpConsignDelivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignDelivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
					{
						item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["DeliveryDate"] != null && dr["DeliveryDate"] != DBNull.Value)
					{
						item.DeliveryDate = Convert.ToDateTime(dr["DeliveryDate"]);
					}
					if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
					{
						item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
					{
						item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
					}
					if (dr["SoDienThoaiNguoiGui"] != null && dr["SoDienThoaiNguoiGui"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiGui = Convert.ToString(dr["SoDienThoaiNguoiGui"]);
					}
					if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
					{
						item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
					}
					if (dr["SoDienThoaiNguoiNhan"] != null && dr["SoDienThoaiNguoiNhan"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiNhan = Convert.ToString(dr["SoDienThoaiNguoiNhan"]);
					}
					if (dr["DiaChiNguoiNhan"] != null && dr["DiaChiNguoiNhan"] != DBNull.Value)
					{
						item.DiaChiNguoiNhan = Convert.ToString(dr["DiaChiNguoiNhan"]);
					}
					if (dr["TongCuoc"] != null && dr["TongCuoc"] != DBNull.Value)
					{
						item.TongCuoc = Convert.ToInt32(dr["TongCuoc"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
					}
					if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
					{
						item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
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
		/// Lấy danh sách view_ExpConsignDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpConsignDelivery> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignDelivery] A "+ condition,  parameters);
				List<view_ExpConsignDelivery> items = new List<view_ExpConsignDelivery>();
				view_ExpConsignDelivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignDelivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
					{
						item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["DeliveryDate"] != null && dr["DeliveryDate"] != DBNull.Value)
					{
						item.DeliveryDate = Convert.ToDateTime(dr["DeliveryDate"]);
					}
					if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
					{
						item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
					{
						item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
					}
					if (dr["SoDienThoaiNguoiGui"] != null && dr["SoDienThoaiNguoiGui"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiGui = Convert.ToString(dr["SoDienThoaiNguoiGui"]);
					}
					if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
					{
						item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
					}
					if (dr["SoDienThoaiNguoiNhan"] != null && dr["SoDienThoaiNguoiNhan"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiNhan = Convert.ToString(dr["SoDienThoaiNguoiNhan"]);
					}
					if (dr["DiaChiNguoiNhan"] != null && dr["DiaChiNguoiNhan"] != DBNull.Value)
					{
						item.DiaChiNguoiNhan = Convert.ToString(dr["DiaChiNguoiNhan"]);
					}
					if (dr["TongCuoc"] != null && dr["TongCuoc"] != DBNull.Value)
					{
						item.TongCuoc = Convert.ToInt32(dr["TongCuoc"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
					}
					if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
					{
						item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
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

		public List<view_ExpConsignDelivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignDelivery] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignDelivery] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpConsignDelivery>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpConsignDelivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpConsignDelivery GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignDelivery] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpConsignDelivery item=new view_ExpConsignDelivery();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
						{
							item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
						{
							item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
						{
							item.IsDone = Convert.ToBoolean(dr["IsDone"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
						}
						if (dr["DeliveryDate"] != null && dr["DeliveryDate"] != DBNull.Value)
						{
							item.DeliveryDate = Convert.ToDateTime(dr["DeliveryDate"]);
						}
						if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
						{
							item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
						}
						if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
						{
							item.TenHang = Convert.ToString(dr["TenHang"]);
						}
						if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
						{
							item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
						}
						if (dr["SoDienThoaiNguoiGui"] != null && dr["SoDienThoaiNguoiGui"] != DBNull.Value)
						{
							item.SoDienThoaiNguoiGui = Convert.ToString(dr["SoDienThoaiNguoiGui"]);
						}
						if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
						{
							item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
						}
						if (dr["SoDienThoaiNguoiNhan"] != null && dr["SoDienThoaiNguoiNhan"] != DBNull.Value)
						{
							item.SoDienThoaiNguoiNhan = Convert.ToString(dr["SoDienThoaiNguoiNhan"]);
						}
						if (dr["DiaChiNguoiNhan"] != null && dr["DiaChiNguoiNhan"] != DBNull.Value)
						{
							item.DiaChiNguoiNhan = Convert.ToString(dr["DiaChiNguoiNhan"]);
						}
						if (dr["TongCuoc"] != null && dr["TongCuoc"] != DBNull.Value)
						{
							item.TongCuoc = Convert.ToInt32(dr["TongCuoc"]);
						}
						if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
						{
							item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
						}
						if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
						{
							item.ShipperName = Convert.ToString(dr["ShipperName"]);
						}
						if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
						{
							item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
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

		public view_ExpConsignDelivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignDelivery] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpConsignDelivery>(ds);
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
