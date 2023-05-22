using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpconsigntransit:IVIewexpconsigntransit
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpconsigntransit(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpConsignTransit từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignTransit]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpConsignTransit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignTransit] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpConsignTransit từ Database
		/// </summary>
		public List<view_ExpConsignTransit> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignTransit]");
				List<view_ExpConsignTransit> items = new List<view_ExpConsignTransit>();
				view_ExpConsignTransit item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignTransit();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["FK_ExpPostFrom"] != null && dr["FK_ExpPostFrom"] != DBNull.Value)
					{
						item.FK_ExpPostFrom = Convert.ToString(dr["FK_ExpPostFrom"]);
					}
					if (dr["FK_ExpPostTo"] != null && dr["FK_ExpPostTo"] != DBNull.Value)
					{
						item.FK_ExpPostTo = Convert.ToString(dr["FK_ExpPostTo"]);
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
					if (dr["ImportBy"] != null && dr["ImportBy"] != DBNull.Value)
					{
						item.ImportBy = Convert.ToString(dr["ImportBy"]);
					}
					if (dr["ImportDate"] != null && dr["ImportDate"] != DBNull.Value)
					{
						item.ImportDate = Convert.ToDateTime(dr["ImportDate"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
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
					if (dr["FromPost"] != null && dr["FromPost"] != DBNull.Value)
					{
						item.FromPost = Convert.ToString(dr["FromPost"]);
					}
					if (dr["ToPost"] != null && dr["ToPost"] != DBNull.Value)
					{
						item.ToPost = Convert.ToString(dr["ToPost"]);
					}
					if (dr["TenNguoiGui"] != null && dr["TenNguoiGui"] != DBNull.Value)
					{
						item.TenNguoiGui = Convert.ToString(dr["TenNguoiGui"]);
					}
					if (dr["TenNguoiNhap"] != null && dr["TenNguoiNhap"] != DBNull.Value)
					{
						item.TenNguoiNhap = Convert.ToString(dr["TenNguoiNhap"]);
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
		/// Lấy danh sách view_ExpConsignTransit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpConsignTransit> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignTransit] A "+ condition,  parameters);
				List<view_ExpConsignTransit> items = new List<view_ExpConsignTransit>();
				view_ExpConsignTransit item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignTransit();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["FK_ExpPostFrom"] != null && dr["FK_ExpPostFrom"] != DBNull.Value)
					{
						item.FK_ExpPostFrom = Convert.ToString(dr["FK_ExpPostFrom"]);
					}
					if (dr["FK_ExpPostTo"] != null && dr["FK_ExpPostTo"] != DBNull.Value)
					{
						item.FK_ExpPostTo = Convert.ToString(dr["FK_ExpPostTo"]);
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
					if (dr["ImportBy"] != null && dr["ImportBy"] != DBNull.Value)
					{
						item.ImportBy = Convert.ToString(dr["ImportBy"]);
					}
					if (dr["ImportDate"] != null && dr["ImportDate"] != DBNull.Value)
					{
						item.ImportDate = Convert.ToDateTime(dr["ImportDate"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
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
					if (dr["FromPost"] != null && dr["FromPost"] != DBNull.Value)
					{
						item.FromPost = Convert.ToString(dr["FromPost"]);
					}
					if (dr["ToPost"] != null && dr["ToPost"] != DBNull.Value)
					{
						item.ToPost = Convert.ToString(dr["ToPost"]);
					}
					if (dr["TenNguoiGui"] != null && dr["TenNguoiGui"] != DBNull.Value)
					{
						item.TenNguoiGui = Convert.ToString(dr["TenNguoiGui"]);
					}
					if (dr["TenNguoiNhap"] != null && dr["TenNguoiNhap"] != DBNull.Value)
					{
						item.TenNguoiNhap = Convert.ToString(dr["TenNguoiNhap"]);
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

		public List<view_ExpConsignTransit> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignTransit] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignTransit] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpConsignTransit>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpConsignTransit đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpConsignTransit GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignTransit] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpConsignTransit item=new view_ExpConsignTransit();
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
						if (dr["FK_ExpPostFrom"] != null && dr["FK_ExpPostFrom"] != DBNull.Value)
						{
							item.FK_ExpPostFrom = Convert.ToString(dr["FK_ExpPostFrom"]);
						}
						if (dr["FK_ExpPostTo"] != null && dr["FK_ExpPostTo"] != DBNull.Value)
						{
							item.FK_ExpPostTo = Convert.ToString(dr["FK_ExpPostTo"]);
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
						if (dr["ImportBy"] != null && dr["ImportBy"] != DBNull.Value)
						{
							item.ImportBy = Convert.ToString(dr["ImportBy"]);
						}
						if (dr["ImportDate"] != null && dr["ImportDate"] != DBNull.Value)
						{
							item.ImportDate = Convert.ToDateTime(dr["ImportDate"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
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
						if (dr["FromPost"] != null && dr["FromPost"] != DBNull.Value)
						{
							item.FromPost = Convert.ToString(dr["FromPost"]);
						}
						if (dr["ToPost"] != null && dr["ToPost"] != DBNull.Value)
						{
							item.ToPost = Convert.ToString(dr["ToPost"]);
						}
						if (dr["TenNguoiGui"] != null && dr["TenNguoiGui"] != DBNull.Value)
						{
							item.TenNguoiGui = Convert.ToString(dr["TenNguoiGui"]);
						}
						if (dr["TenNguoiNhap"] != null && dr["TenNguoiNhap"] != DBNull.Value)
						{
							item.TenNguoiNhap = Convert.ToString(dr["TenNguoiNhap"]);
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

		public view_ExpConsignTransit GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignTransit] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpConsignTransit>(ds);
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
