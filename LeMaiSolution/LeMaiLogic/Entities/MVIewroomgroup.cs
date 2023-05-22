using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewroomgroup:IVIewroomgroup
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewroomgroup(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_RoomGroup từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_RoomGroup]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_RoomGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_RoomGroup] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_RoomGroup từ Database
		/// </summary>
		public List<view_RoomGroup> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_RoomGroup]");
				List<view_RoomGroup> items = new List<view_RoomGroup>();
				view_RoomGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_RoomGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["BranchId"] != null && dr["BranchId"] != DBNull.Value)
					{
						item.BranchId = Convert.ToString(dr["BranchId"]);
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
		/// Lấy danh sách view_RoomGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_RoomGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_RoomGroup] A "+ condition,  parameters);
				List<view_RoomGroup> items = new List<view_RoomGroup>();
				view_RoomGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_RoomGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["BranchId"] != null && dr["BranchId"] != DBNull.Value)
					{
						item.BranchId = Convert.ToString(dr["BranchId"]);
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

		public List<view_RoomGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_RoomGroup] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_RoomGroup] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_RoomGroup>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_RoomGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_RoomGroup GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_RoomGroup] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_RoomGroup item=new view_RoomGroup();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
						{
							item.BranchName = Convert.ToString(dr["BranchName"]);
						}
						if (dr["BranchId"] != null && dr["BranchId"] != DBNull.Value)
						{
							item.BranchId = Convert.ToString(dr["BranchId"]);
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

		public view_RoomGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_RoomGroup] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_RoomGroup>(ds);
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
