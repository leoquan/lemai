using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpkykettoan:IVIewexpkykettoan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpkykettoan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpKyKetToan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpKyKetToan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpKyKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpKyKetToan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpKyKetToan từ Database
		/// </summary>
		public List<view_ExpKyKetToan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpKyKetToan]");
				List<view_ExpKyKetToan> items = new List<view_ExpKyKetToan>();
				view_ExpKyKetToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpKyKetToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenKy"] != null && dr["TenKy"] != DBNull.Value)
					{
						item.TenKy = Convert.ToString(dr["TenKy"]);
					}
					if (dr["SoBangKe"] != null && dr["SoBangKe"] != DBNull.Value)
					{
						item.SoBangKe = Convert.ToInt32(dr["SoBangKe"]);
					}
					if (dr["NgayTao"] != null && dr["NgayTao"] != DBNull.Value)
					{
						item.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
					}
					if (dr["QuyenSoChi"] != null && dr["QuyenSoChi"] != DBNull.Value)
					{
						item.QuyenSoChi = Convert.ToString(dr["QuyenSoChi"]);
					}
					if (dr["QuyenSoThu"] != null && dr["QuyenSoThu"] != DBNull.Value)
					{
						item.QuyenSoThu = Convert.ToString(dr["QuyenSoThu"]);
					}
					if (dr["QuyenSoTongChi"] != null && dr["QuyenSoTongChi"] != DBNull.Value)
					{
						item.QuyenSoTongChi = Convert.ToString(dr["QuyenSoTongChi"]);
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
		/// Lấy danh sách view_ExpKyKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpKyKetToan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpKyKetToan] A "+ condition,  parameters);
				List<view_ExpKyKetToan> items = new List<view_ExpKyKetToan>();
				view_ExpKyKetToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpKyKetToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenKy"] != null && dr["TenKy"] != DBNull.Value)
					{
						item.TenKy = Convert.ToString(dr["TenKy"]);
					}
					if (dr["SoBangKe"] != null && dr["SoBangKe"] != DBNull.Value)
					{
						item.SoBangKe = Convert.ToInt32(dr["SoBangKe"]);
					}
					if (dr["NgayTao"] != null && dr["NgayTao"] != DBNull.Value)
					{
						item.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
					}
					if (dr["QuyenSoChi"] != null && dr["QuyenSoChi"] != DBNull.Value)
					{
						item.QuyenSoChi = Convert.ToString(dr["QuyenSoChi"]);
					}
					if (dr["QuyenSoThu"] != null && dr["QuyenSoThu"] != DBNull.Value)
					{
						item.QuyenSoThu = Convert.ToString(dr["QuyenSoThu"]);
					}
					if (dr["QuyenSoTongChi"] != null && dr["QuyenSoTongChi"] != DBNull.Value)
					{
						item.QuyenSoTongChi = Convert.ToString(dr["QuyenSoTongChi"]);
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

		public List<view_ExpKyKetToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpKyKetToan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpKyKetToan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpKyKetToan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpKyKetToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpKyKetToan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpKyKetToan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpKyKetToan item=new view_ExpKyKetToan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenKy"] != null && dr["TenKy"] != DBNull.Value)
						{
							item.TenKy = Convert.ToString(dr["TenKy"]);
						}
						if (dr["SoBangKe"] != null && dr["SoBangKe"] != DBNull.Value)
						{
							item.SoBangKe = Convert.ToInt32(dr["SoBangKe"]);
						}
						if (dr["NgayTao"] != null && dr["NgayTao"] != DBNull.Value)
						{
							item.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
						}
						if (dr["QuyenSoChi"] != null && dr["QuyenSoChi"] != DBNull.Value)
						{
							item.QuyenSoChi = Convert.ToString(dr["QuyenSoChi"]);
						}
						if (dr["QuyenSoThu"] != null && dr["QuyenSoThu"] != DBNull.Value)
						{
							item.QuyenSoThu = Convert.ToString(dr["QuyenSoThu"]);
						}
						if (dr["QuyenSoTongChi"] != null && dr["QuyenSoTongChi"] != DBNull.Value)
						{
							item.QuyenSoTongChi = Convert.ToString(dr["QuyenSoTongChi"]);
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

		public view_ExpKyKetToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpKyKetToan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpKyKetToan>(ds);
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
