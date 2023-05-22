using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewschoolhocphan:IVIewschoolhocphan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewschoolhocphan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_SchoolHocPhan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolHocPhan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_SchoolHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolHocPhan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_SchoolHocPhan từ Database
		/// </summary>
		public List<view_SchoolHocPhan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolHocPhan]");
				List<view_SchoolHocPhan> items = new List<view_SchoolHocPhan>();
				view_SchoolHocPhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolHocPhan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["HocPhan"] != null && dr["HocPhan"] != DBNull.Value)
					{
						item.HocPhan = Convert.ToString(dr["HocPhan"]);
					}
					if (dr["MinAge"] != null && dr["MinAge"] != DBNull.Value)
					{
						item.MinAge = Convert.ToInt32(dr["MinAge"]);
					}
					if (dr["MaxAge"] != null && dr["MaxAge"] != DBNull.Value)
					{
						item.MaxAge = Convert.ToInt32(dr["MaxAge"]);
					}
					if (dr["NumberMonth"] != null && dr["NumberMonth"] != DBNull.Value)
					{
						item.NumberMonth = Convert.ToDecimal(dr["NumberMonth"]);
					}
					if (dr["SoTiet"] != null && dr["SoTiet"] != DBNull.Value)
					{
						item.SoTiet = Convert.ToInt32(dr["SoTiet"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_SchoolProgram"] != null && dr["FK_SchoolProgram"] != DBNull.Value)
					{
						item.FK_SchoolProgram = Convert.ToString(dr["FK_SchoolProgram"]);
					}
					if (dr["ProgramName"] != null && dr["ProgramName"] != DBNull.Value)
					{
						item.ProgramName = Convert.ToString(dr["ProgramName"]);
					}
					if (dr["ProgramCode"] != null && dr["ProgramCode"] != DBNull.Value)
					{
						item.ProgramCode = Convert.ToString(dr["ProgramCode"]);
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
		/// Lấy danh sách view_SchoolHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_SchoolHocPhan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolHocPhan] A "+ condition,  parameters);
				List<view_SchoolHocPhan> items = new List<view_SchoolHocPhan>();
				view_SchoolHocPhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolHocPhan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["HocPhan"] != null && dr["HocPhan"] != DBNull.Value)
					{
						item.HocPhan = Convert.ToString(dr["HocPhan"]);
					}
					if (dr["MinAge"] != null && dr["MinAge"] != DBNull.Value)
					{
						item.MinAge = Convert.ToInt32(dr["MinAge"]);
					}
					if (dr["MaxAge"] != null && dr["MaxAge"] != DBNull.Value)
					{
						item.MaxAge = Convert.ToInt32(dr["MaxAge"]);
					}
					if (dr["NumberMonth"] != null && dr["NumberMonth"] != DBNull.Value)
					{
						item.NumberMonth = Convert.ToDecimal(dr["NumberMonth"]);
					}
					if (dr["SoTiet"] != null && dr["SoTiet"] != DBNull.Value)
					{
						item.SoTiet = Convert.ToInt32(dr["SoTiet"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_SchoolProgram"] != null && dr["FK_SchoolProgram"] != DBNull.Value)
					{
						item.FK_SchoolProgram = Convert.ToString(dr["FK_SchoolProgram"]);
					}
					if (dr["ProgramName"] != null && dr["ProgramName"] != DBNull.Value)
					{
						item.ProgramName = Convert.ToString(dr["ProgramName"]);
					}
					if (dr["ProgramCode"] != null && dr["ProgramCode"] != DBNull.Value)
					{
						item.ProgramCode = Convert.ToString(dr["ProgramCode"]);
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

		public List<view_SchoolHocPhan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolHocPhan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_SchoolHocPhan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_SchoolHocPhan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_SchoolHocPhan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_SchoolHocPhan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolHocPhan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_SchoolHocPhan item=new view_SchoolHocPhan();
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
						if (dr["HocPhan"] != null && dr["HocPhan"] != DBNull.Value)
						{
							item.HocPhan = Convert.ToString(dr["HocPhan"]);
						}
						if (dr["MinAge"] != null && dr["MinAge"] != DBNull.Value)
						{
							item.MinAge = Convert.ToInt32(dr["MinAge"]);
						}
						if (dr["MaxAge"] != null && dr["MaxAge"] != DBNull.Value)
						{
							item.MaxAge = Convert.ToInt32(dr["MaxAge"]);
						}
						if (dr["NumberMonth"] != null && dr["NumberMonth"] != DBNull.Value)
						{
							item.NumberMonth = Convert.ToDecimal(dr["NumberMonth"]);
						}
						if (dr["SoTiet"] != null && dr["SoTiet"] != DBNull.Value)
						{
							item.SoTiet = Convert.ToInt32(dr["SoTiet"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_SchoolProgram"] != null && dr["FK_SchoolProgram"] != DBNull.Value)
						{
							item.FK_SchoolProgram = Convert.ToString(dr["FK_SchoolProgram"]);
						}
						if (dr["ProgramName"] != null && dr["ProgramName"] != DBNull.Value)
						{
							item.ProgramName = Convert.ToString(dr["ProgramName"]);
						}
						if (dr["ProgramCode"] != null && dr["ProgramCode"] != DBNull.Value)
						{
							item.ProgramCode = Convert.ToString(dr["ProgramCode"]);
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

		public view_SchoolHocPhan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolHocPhan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_SchoolHocPhan>(ds);
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
