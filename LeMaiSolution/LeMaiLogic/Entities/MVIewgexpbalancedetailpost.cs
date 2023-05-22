using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpbalancedetailpost:IVIewgexpbalancedetailpost
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpbalancedetailpost(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpBalanceDetailPost từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpBalanceDetailPost]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpBalanceDetailPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpBalanceDetailPost] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpBalanceDetailPost từ Database
		/// </summary>
		public List<view_GExpBalanceDetailPost> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpBalanceDetailPost]");
				List<view_GExpBalanceDetailPost> items = new List<view_GExpBalanceDetailPost>();
				view_GExpBalanceDetailPost item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpBalanceDetailPost();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExtPostFrom"] != null && dr["FK_ExtPostFrom"] != DBNull.Value)
					{
						item.FK_ExtPostFrom = Convert.ToString(dr["FK_ExtPostFrom"]);
					}
					if (dr["CurrentExtPostFrom"] != null && dr["CurrentExtPostFrom"] != DBNull.Value)
					{
						item.CurrentExtPostFrom = Convert.ToInt32(dr["CurrentExtPostFrom"]);
					}
					if (dr["AfterPostFrom"] != null && dr["AfterPostFrom"] != DBNull.Value)
					{
						item.AfterPostFrom = Convert.ToInt32(dr["AfterPostFrom"]);
					}
					if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
					{
						item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
					}
					if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
					{
						item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
					}
					if (dr["AfterPostTo"] != null && dr["AfterPostTo"] != DBNull.Value)
					{
						item.AfterPostTo = Convert.ToInt32(dr["AfterPostTo"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["EpochTime"] != null && dr["EpochTime"] != DBNull.Value)
					{
						item.EpochTime = (System.Int64)dr["EpochTime"];
					}
					if (dr["FQuanLy"] != null && dr["FQuanLy"] != DBNull.Value)
					{
						item.FQuanLy = Convert.ToString(dr["FQuanLy"]);
					}
					if (dr["FSoDienThoai"] != null && dr["FSoDienThoai"] != DBNull.Value)
					{
						item.FSoDienThoai = Convert.ToString(dr["FSoDienThoai"]);
					}
					if (dr["FTenDaiLy"] != null && dr["FTenDaiLy"] != DBNull.Value)
					{
						item.FTenDaiLy = Convert.ToString(dr["FTenDaiLy"]);
					}
					if (dr["TQuanLy"] != null && dr["TQuanLy"] != DBNull.Value)
					{
						item.TQuanLy = Convert.ToString(dr["TQuanLy"]);
					}
					if (dr["TSoDienThoai"] != null && dr["TSoDienThoai"] != DBNull.Value)
					{
						item.TSoDienThoai = Convert.ToString(dr["TSoDienThoai"]);
					}
					if (dr["TTenDaiLy"] != null && dr["TTenDaiLy"] != DBNull.Value)
					{
						item.TTenDaiLy = Convert.ToString(dr["TTenDaiLy"]);
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
		/// Lấy danh sách view_GExpBalanceDetailPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpBalanceDetailPost> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpBalanceDetailPost] A "+ condition,  parameters);
				List<view_GExpBalanceDetailPost> items = new List<view_GExpBalanceDetailPost>();
				view_GExpBalanceDetailPost item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpBalanceDetailPost();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExtPostFrom"] != null && dr["FK_ExtPostFrom"] != DBNull.Value)
					{
						item.FK_ExtPostFrom = Convert.ToString(dr["FK_ExtPostFrom"]);
					}
					if (dr["CurrentExtPostFrom"] != null && dr["CurrentExtPostFrom"] != DBNull.Value)
					{
						item.CurrentExtPostFrom = Convert.ToInt32(dr["CurrentExtPostFrom"]);
					}
					if (dr["AfterPostFrom"] != null && dr["AfterPostFrom"] != DBNull.Value)
					{
						item.AfterPostFrom = Convert.ToInt32(dr["AfterPostFrom"]);
					}
					if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
					{
						item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
					}
					if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
					{
						item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
					}
					if (dr["AfterPostTo"] != null && dr["AfterPostTo"] != DBNull.Value)
					{
						item.AfterPostTo = Convert.ToInt32(dr["AfterPostTo"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["EpochTime"] != null && dr["EpochTime"] != DBNull.Value)
					{
						item.EpochTime = (System.Int64)dr["EpochTime"];
					}
					if (dr["FQuanLy"] != null && dr["FQuanLy"] != DBNull.Value)
					{
						item.FQuanLy = Convert.ToString(dr["FQuanLy"]);
					}
					if (dr["FSoDienThoai"] != null && dr["FSoDienThoai"] != DBNull.Value)
					{
						item.FSoDienThoai = Convert.ToString(dr["FSoDienThoai"]);
					}
					if (dr["FTenDaiLy"] != null && dr["FTenDaiLy"] != DBNull.Value)
					{
						item.FTenDaiLy = Convert.ToString(dr["FTenDaiLy"]);
					}
					if (dr["TQuanLy"] != null && dr["TQuanLy"] != DBNull.Value)
					{
						item.TQuanLy = Convert.ToString(dr["TQuanLy"]);
					}
					if (dr["TSoDienThoai"] != null && dr["TSoDienThoai"] != DBNull.Value)
					{
						item.TSoDienThoai = Convert.ToString(dr["TSoDienThoai"]);
					}
					if (dr["TTenDaiLy"] != null && dr["TTenDaiLy"] != DBNull.Value)
					{
						item.TTenDaiLy = Convert.ToString(dr["TTenDaiLy"]);
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

		public List<view_GExpBalanceDetailPost> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpBalanceDetailPost] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpBalanceDetailPost] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpBalanceDetailPost>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpBalanceDetailPost đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpBalanceDetailPost GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpBalanceDetailPost] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpBalanceDetailPost item=new view_GExpBalanceDetailPost();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExtPostFrom"] != null && dr["FK_ExtPostFrom"] != DBNull.Value)
						{
							item.FK_ExtPostFrom = Convert.ToString(dr["FK_ExtPostFrom"]);
						}
						if (dr["CurrentExtPostFrom"] != null && dr["CurrentExtPostFrom"] != DBNull.Value)
						{
							item.CurrentExtPostFrom = Convert.ToInt32(dr["CurrentExtPostFrom"]);
						}
						if (dr["AfterPostFrom"] != null && dr["AfterPostFrom"] != DBNull.Value)
						{
							item.AfterPostFrom = Convert.ToInt32(dr["AfterPostFrom"]);
						}
						if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
						{
							item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
						}
						if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
						{
							item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
						}
						if (dr["AfterPostTo"] != null && dr["AfterPostTo"] != DBNull.Value)
						{
							item.AfterPostTo = Convert.ToInt32(dr["AfterPostTo"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["EpochTime"] != null && dr["EpochTime"] != DBNull.Value)
						{
							item.EpochTime = (System.Int64)dr["EpochTime"];
						}
						if (dr["FQuanLy"] != null && dr["FQuanLy"] != DBNull.Value)
						{
							item.FQuanLy = Convert.ToString(dr["FQuanLy"]);
						}
						if (dr["FSoDienThoai"] != null && dr["FSoDienThoai"] != DBNull.Value)
						{
							item.FSoDienThoai = Convert.ToString(dr["FSoDienThoai"]);
						}
						if (dr["FTenDaiLy"] != null && dr["FTenDaiLy"] != DBNull.Value)
						{
							item.FTenDaiLy = Convert.ToString(dr["FTenDaiLy"]);
						}
						if (dr["TQuanLy"] != null && dr["TQuanLy"] != DBNull.Value)
						{
							item.TQuanLy = Convert.ToString(dr["TQuanLy"]);
						}
						if (dr["TSoDienThoai"] != null && dr["TSoDienThoai"] != DBNull.Value)
						{
							item.TSoDienThoai = Convert.ToString(dr["TSoDienThoai"]);
						}
						if (dr["TTenDaiLy"] != null && dr["TTenDaiLy"] != DBNull.Value)
						{
							item.TTenDaiLy = Convert.ToString(dr["TTenDaiLy"]);
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

		public view_GExpBalanceDetailPost GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpBalanceDetailPost] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpBalanceDetailPost>(ds);
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
