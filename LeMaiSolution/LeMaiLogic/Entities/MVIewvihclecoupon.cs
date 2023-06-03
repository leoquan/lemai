using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewvihclecoupon:IVIewvihclecoupon
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewvihclecoupon(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_VihcleCoupon từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VihcleCoupon]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_VihcleCoupon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VihcleCoupon] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_VihcleCoupon từ Database
		/// </summary>
		public List<view_VihcleCoupon> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VihcleCoupon]");
				List<view_VihcleCoupon> items = new List<view_VihcleCoupon>();
				view_VihcleCoupon item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VihcleCoupon();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Vihcle"] != null && dr["FK_Vihcle"] != DBNull.Value)
					{
						item.FK_Vihcle = Convert.ToString(dr["FK_Vihcle"]);
					}
					if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
					{
						item.TotalFee = Convert.ToInt32(dr["TotalFee"]);
					}
					if (dr["Date"] != null && dr["Date"] != DBNull.Value)
					{
						item.Date = Convert.ToDateTime(dr["Date"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["SoKM"] != null && dr["SoKM"] != DBNull.Value)
					{
						item.SoKM = Convert.ToInt32(dr["SoKM"]);
					}
					if (dr["BienSo"] != null && dr["BienSo"] != DBNull.Value)
					{
						item.BienSo = Convert.ToString(dr["BienSo"]);
					}
					if (dr["TenXe"] != null && dr["TenXe"] != DBNull.Value)
					{
						item.TenXe = Convert.ToString(dr["TenXe"]);
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
		/// Lấy danh sách view_VihcleCoupon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_VihcleCoupon> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VihcleCoupon] A "+ condition,  parameters);
				List<view_VihcleCoupon> items = new List<view_VihcleCoupon>();
				view_VihcleCoupon item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VihcleCoupon();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Vihcle"] != null && dr["FK_Vihcle"] != DBNull.Value)
					{
						item.FK_Vihcle = Convert.ToString(dr["FK_Vihcle"]);
					}
					if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
					{
						item.TotalFee = Convert.ToInt32(dr["TotalFee"]);
					}
					if (dr["Date"] != null && dr["Date"] != DBNull.Value)
					{
						item.Date = Convert.ToDateTime(dr["Date"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["SoKM"] != null && dr["SoKM"] != DBNull.Value)
					{
						item.SoKM = Convert.ToInt32(dr["SoKM"]);
					}
					if (dr["BienSo"] != null && dr["BienSo"] != DBNull.Value)
					{
						item.BienSo = Convert.ToString(dr["BienSo"]);
					}
					if (dr["TenXe"] != null && dr["TenXe"] != DBNull.Value)
					{
						item.TenXe = Convert.ToString(dr["TenXe"]);
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

		public List<view_VihcleCoupon> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VihcleCoupon] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_VihcleCoupon] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_VihcleCoupon>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_VihcleCoupon đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_VihcleCoupon GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VihcleCoupon] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_VihcleCoupon item=new view_VihcleCoupon();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Vihcle"] != null && dr["FK_Vihcle"] != DBNull.Value)
						{
							item.FK_Vihcle = Convert.ToString(dr["FK_Vihcle"]);
						}
						if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
						{
							item.TotalFee = Convert.ToInt32(dr["TotalFee"]);
						}
						if (dr["Date"] != null && dr["Date"] != DBNull.Value)
						{
							item.Date = Convert.ToDateTime(dr["Date"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["SoKM"] != null && dr["SoKM"] != DBNull.Value)
						{
							item.SoKM = Convert.ToInt32(dr["SoKM"]);
						}
						if (dr["BienSo"] != null && dr["BienSo"] != DBNull.Value)
						{
							item.BienSo = Convert.ToString(dr["BienSo"]);
						}
						if (dr["TenXe"] != null && dr["TenXe"] != DBNull.Value)
						{
							item.TenXe = Convert.ToString(dr["TenXe"]);
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

		public view_VihcleCoupon GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VihcleCoupon] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_VihcleCoupon>(ds);
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
