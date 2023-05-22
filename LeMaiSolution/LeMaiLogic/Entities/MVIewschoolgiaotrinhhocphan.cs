using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewschoolgiaotrinhhocphan:IVIewschoolgiaotrinhhocphan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewschoolgiaotrinhhocphan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_SchoolGiaoTrinhHocPhan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolGiaoTrinhHocPhan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_SchoolGiaoTrinhHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolGiaoTrinhHocPhan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_SchoolGiaoTrinhHocPhan từ Database
		/// </summary>
		public List<view_SchoolGiaoTrinhHocPhan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolGiaoTrinhHocPhan]");
				List<view_SchoolGiaoTrinhHocPhan> items = new List<view_SchoolGiaoTrinhHocPhan>();
				view_SchoolGiaoTrinhHocPhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolGiaoTrinhHocPhan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_GiaoTrinh"] != null && dr["FK_GiaoTrinh"] != DBNull.Value)
					{
						item.FK_GiaoTrinh = Convert.ToString(dr["FK_GiaoTrinh"]);
					}
					if (dr["BaiHoc"] != null && dr["BaiHoc"] != DBNull.Value)
					{
						item.BaiHoc = Convert.ToString(dr["BaiHoc"]);
					}
					if (dr["Structure"] != null && dr["Structure"] != DBNull.Value)
					{
						item.Structure = Convert.ToString(dr["Structure"]);
					}
					if (dr["Vocabulary"] != null && dr["Vocabulary"] != DBNull.Value)
					{
						item.Vocabulary = Convert.ToString(dr["Vocabulary"]);
					}
					if (dr["Activities"] != null && dr["Activities"] != DBNull.Value)
					{
						item.Activities = Convert.ToString(dr["Activities"]);
					}
					if (dr["Objectives"] != null && dr["Objectives"] != DBNull.Value)
					{
						item.Objectives = Convert.ToString(dr["Objectives"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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
		/// Lấy danh sách view_SchoolGiaoTrinhHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_SchoolGiaoTrinhHocPhan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolGiaoTrinhHocPhan] A "+ condition,  parameters);
				List<view_SchoolGiaoTrinhHocPhan> items = new List<view_SchoolGiaoTrinhHocPhan>();
				view_SchoolGiaoTrinhHocPhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolGiaoTrinhHocPhan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_GiaoTrinh"] != null && dr["FK_GiaoTrinh"] != DBNull.Value)
					{
						item.FK_GiaoTrinh = Convert.ToString(dr["FK_GiaoTrinh"]);
					}
					if (dr["BaiHoc"] != null && dr["BaiHoc"] != DBNull.Value)
					{
						item.BaiHoc = Convert.ToString(dr["BaiHoc"]);
					}
					if (dr["Structure"] != null && dr["Structure"] != DBNull.Value)
					{
						item.Structure = Convert.ToString(dr["Structure"]);
					}
					if (dr["Vocabulary"] != null && dr["Vocabulary"] != DBNull.Value)
					{
						item.Vocabulary = Convert.ToString(dr["Vocabulary"]);
					}
					if (dr["Activities"] != null && dr["Activities"] != DBNull.Value)
					{
						item.Activities = Convert.ToString(dr["Activities"]);
					}
					if (dr["Objectives"] != null && dr["Objectives"] != DBNull.Value)
					{
						item.Objectives = Convert.ToString(dr["Objectives"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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

		public List<view_SchoolGiaoTrinhHocPhan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolGiaoTrinhHocPhan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_SchoolGiaoTrinhHocPhan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_SchoolGiaoTrinhHocPhan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_SchoolGiaoTrinhHocPhan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_SchoolGiaoTrinhHocPhan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolGiaoTrinhHocPhan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_SchoolGiaoTrinhHocPhan item=new view_SchoolGiaoTrinhHocPhan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_GiaoTrinh"] != null && dr["FK_GiaoTrinh"] != DBNull.Value)
						{
							item.FK_GiaoTrinh = Convert.ToString(dr["FK_GiaoTrinh"]);
						}
						if (dr["BaiHoc"] != null && dr["BaiHoc"] != DBNull.Value)
						{
							item.BaiHoc = Convert.ToString(dr["BaiHoc"]);
						}
						if (dr["Structure"] != null && dr["Structure"] != DBNull.Value)
						{
							item.Structure = Convert.ToString(dr["Structure"]);
						}
						if (dr["Vocabulary"] != null && dr["Vocabulary"] != DBNull.Value)
						{
							item.Vocabulary = Convert.ToString(dr["Vocabulary"]);
						}
						if (dr["Activities"] != null && dr["Activities"] != DBNull.Value)
						{
							item.Activities = Convert.ToString(dr["Activities"]);
						}
						if (dr["Objectives"] != null && dr["Objectives"] != DBNull.Value)
						{
							item.Objectives = Convert.ToString(dr["Objectives"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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

		public view_SchoolGiaoTrinhHocPhan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolGiaoTrinhHocPhan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_SchoolGiaoTrinhHocPhan>(ds);
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
