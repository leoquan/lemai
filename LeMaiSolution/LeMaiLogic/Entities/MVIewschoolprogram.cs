using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewschoolprogram:IVIewschoolprogram
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewschoolprogram(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_SchoolProgram từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolProgram]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_SchoolProgram từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolProgram] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_SchoolProgram từ Database
		/// </summary>
		public List<view_SchoolProgram> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolProgram]");
				List<view_SchoolProgram> items = new List<view_SchoolProgram>();
				view_SchoolProgram item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolProgram();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["ProgramName"] != null && dr["ProgramName"] != DBNull.Value)
					{
						item.ProgramName = Convert.ToString(dr["ProgramName"]);
					}
					if (dr["ClassName"] != null && dr["ClassName"] != DBNull.Value)
					{
						item.ClassName = Convert.ToString(dr["ClassName"]);
					}
					if (dr["CambridgeStandar"] != null && dr["CambridgeStandar"] != DBNull.Value)
					{
						item.CambridgeStandar = Convert.ToString(dr["CambridgeStandar"]);
					}
					if (dr["CEFRStandar"] != null && dr["CEFRStandar"] != DBNull.Value)
					{
						item.CEFRStandar = Convert.ToString(dr["CEFRStandar"]);
					}
					if (dr["NumberPart"] != null && dr["NumberPart"] != DBNull.Value)
					{
						item.NumberPart = Convert.ToInt32(dr["NumberPart"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy danh sách view_SchoolProgram từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_SchoolProgram> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolProgram] A "+ condition,  parameters);
				List<view_SchoolProgram> items = new List<view_SchoolProgram>();
				view_SchoolProgram item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolProgram();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["ProgramName"] != null && dr["ProgramName"] != DBNull.Value)
					{
						item.ProgramName = Convert.ToString(dr["ProgramName"]);
					}
					if (dr["ClassName"] != null && dr["ClassName"] != DBNull.Value)
					{
						item.ClassName = Convert.ToString(dr["ClassName"]);
					}
					if (dr["CambridgeStandar"] != null && dr["CambridgeStandar"] != DBNull.Value)
					{
						item.CambridgeStandar = Convert.ToString(dr["CambridgeStandar"]);
					}
					if (dr["CEFRStandar"] != null && dr["CEFRStandar"] != DBNull.Value)
					{
						item.CEFRStandar = Convert.ToString(dr["CEFRStandar"]);
					}
					if (dr["NumberPart"] != null && dr["NumberPart"] != DBNull.Value)
					{
						item.NumberPart = Convert.ToInt32(dr["NumberPart"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public List<view_SchoolProgram> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolProgram] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_SchoolProgram] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_SchoolProgram>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_SchoolProgram đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_SchoolProgram GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolProgram] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_SchoolProgram item=new view_SchoolProgram();
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
						if (dr["ProgramName"] != null && dr["ProgramName"] != DBNull.Value)
						{
							item.ProgramName = Convert.ToString(dr["ProgramName"]);
						}
						if (dr["ClassName"] != null && dr["ClassName"] != DBNull.Value)
						{
							item.ClassName = Convert.ToString(dr["ClassName"]);
						}
						if (dr["CambridgeStandar"] != null && dr["CambridgeStandar"] != DBNull.Value)
						{
							item.CambridgeStandar = Convert.ToString(dr["CambridgeStandar"]);
						}
						if (dr["CEFRStandar"] != null && dr["CEFRStandar"] != DBNull.Value)
						{
							item.CEFRStandar = Convert.ToString(dr["CEFRStandar"]);
						}
						if (dr["NumberPart"] != null && dr["NumberPart"] != DBNull.Value)
						{
							item.NumberPart = Convert.ToInt32(dr["NumberPart"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public view_SchoolProgram GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolProgram] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_SchoolProgram>(ds);
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
