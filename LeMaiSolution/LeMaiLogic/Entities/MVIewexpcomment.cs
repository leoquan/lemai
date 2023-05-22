using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpcomment:IVIewexpcomment
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpcomment(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpComment từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpComment]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpComment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpComment] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpComment từ Database
		/// </summary>
		public List<view_ExpComment> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpComment]");
				List<view_ExpComment> items = new List<view_ExpComment>();
				view_ExpComment item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpComment();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["Comment"] != null && dr["Comment"] != DBNull.Value)
					{
						item.Comment = Convert.ToString(dr["Comment"]);
					}
					if (dr["Author"] != null && dr["Author"] != DBNull.Value)
					{
						item.Author = Convert.ToString(dr["Author"]);
					}
					if (dr["CommentType"] != null && dr["CommentType"] != DBNull.Value)
					{
						item.CommentType = Convert.ToString(dr["CommentType"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
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
		/// Lấy danh sách view_ExpComment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpComment> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpComment] A "+ condition,  parameters);
				List<view_ExpComment> items = new List<view_ExpComment>();
				view_ExpComment item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpComment();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["Comment"] != null && dr["Comment"] != DBNull.Value)
					{
						item.Comment = Convert.ToString(dr["Comment"]);
					}
					if (dr["Author"] != null && dr["Author"] != DBNull.Value)
					{
						item.Author = Convert.ToString(dr["Author"]);
					}
					if (dr["CommentType"] != null && dr["CommentType"] != DBNull.Value)
					{
						item.CommentType = Convert.ToString(dr["CommentType"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
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

		public List<view_ExpComment> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpComment] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpComment] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpComment>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpComment đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpComment GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpComment] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpComment item=new view_ExpComment();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
						}
						if (dr["Comment"] != null && dr["Comment"] != DBNull.Value)
						{
							item.Comment = Convert.ToString(dr["Comment"]);
						}
						if (dr["Author"] != null && dr["Author"] != DBNull.Value)
						{
							item.Author = Convert.ToString(dr["Author"]);
						}
						if (dr["CommentType"] != null && dr["CommentType"] != DBNull.Value)
						{
							item.CommentType = Convert.ToString(dr["CommentType"]);
						}
						if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
						{
							item.TypeName = Convert.ToString(dr["TypeName"]);
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

		public view_ExpComment GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpComment] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpComment>(ds);
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
