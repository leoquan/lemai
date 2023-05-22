using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpconsignmenthistory:IVIewexpconsignmenthistory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpconsignmenthistory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentHistory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignmentHistory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignmentHistory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpConsignmentHistory từ Database
		/// </summary>
		public List<view_ExpConsignmentHistory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignmentHistory]");
				List<view_ExpConsignmentHistory> items = new List<view_ExpConsignmentHistory>();
				view_ExpConsignmentHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignmentHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_ExpStatus"] != null && dr["FK_ExpStatus"] != DBNull.Value)
					{
						item.FK_ExpStatus = Convert.ToString(dr["FK_ExpStatus"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
					{
						item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
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
		/// Lấy danh sách view_ExpConsignmentHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpConsignmentHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignmentHistory] A "+ condition,  parameters);
				List<view_ExpConsignmentHistory> items = new List<view_ExpConsignmentHistory>();
				view_ExpConsignmentHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignmentHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_ExpStatus"] != null && dr["FK_ExpStatus"] != DBNull.Value)
					{
						item.FK_ExpStatus = Convert.ToString(dr["FK_ExpStatus"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
					{
						item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
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

		public List<view_ExpConsignmentHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignmentHistory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignmentHistory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpConsignmentHistory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpConsignmentHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpConsignmentHistory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignmentHistory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpConsignmentHistory item=new view_ExpConsignmentHistory();
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
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_ExpStatus"] != null && dr["FK_ExpStatus"] != DBNull.Value)
						{
							item.FK_ExpStatus = Convert.ToString(dr["FK_ExpStatus"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
						{
							item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
						}
						if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
						{
							item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
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

		public view_ExpConsignmentHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignmentHistory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpConsignmentHistory>(ds);
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
