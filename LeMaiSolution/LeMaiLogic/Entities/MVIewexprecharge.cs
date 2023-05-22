using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexprecharge:IVIewexprecharge
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexprecharge(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpRecharge từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpRecharge]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpRecharge từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpRecharge] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpRecharge từ Database
		/// </summary>
		public List<view_ExpRecharge> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpRecharge]");
				List<view_ExpRecharge> items = new List<view_ExpRecharge>();
				view_ExpRecharge item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpRecharge();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_PostRequest"] != null && dr["FK_PostRequest"] != DBNull.Value)
					{
						item.FK_PostRequest = Convert.ToString(dr["FK_PostRequest"]);
					}
					if (dr["WithdrawType"] != null && dr["WithdrawType"] != DBNull.Value)
					{
						item.WithdrawType = Convert.ToString(dr["WithdrawType"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
					{
						item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
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
		/// Lấy danh sách view_ExpRecharge từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpRecharge> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpRecharge] A "+ condition,  parameters);
				List<view_ExpRecharge> items = new List<view_ExpRecharge>();
				view_ExpRecharge item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpRecharge();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_PostRequest"] != null && dr["FK_PostRequest"] != DBNull.Value)
					{
						item.FK_PostRequest = Convert.ToString(dr["FK_PostRequest"]);
					}
					if (dr["WithdrawType"] != null && dr["WithdrawType"] != DBNull.Value)
					{
						item.WithdrawType = Convert.ToString(dr["WithdrawType"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
					{
						item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
					{
						item.TypeName = Convert.ToString(dr["TypeName"]);
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

		public List<view_ExpRecharge> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpRecharge] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpRecharge] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpRecharge>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpRecharge đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpRecharge GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpRecharge] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpRecharge item=new view_ExpRecharge();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_PostRequest"] != null && dr["FK_PostRequest"] != DBNull.Value)
						{
							item.FK_PostRequest = Convert.ToString(dr["FK_PostRequest"]);
						}
						if (dr["WithdrawType"] != null && dr["WithdrawType"] != DBNull.Value)
						{
							item.WithdrawType = Convert.ToString(dr["WithdrawType"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
						{
							item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["NguoiTao"] != null && dr["NguoiTao"] != DBNull.Value)
						{
							item.NguoiTao = Convert.ToString(dr["NguoiTao"]);
						}
						if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
						{
							item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
						}
						if (dr["TypeName"] != null && dr["TypeName"] != DBNull.Value)
						{
							item.TypeName = Convert.ToString(dr["TypeName"]);
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

		public view_ExpRecharge GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpRecharge] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpRecharge>(ds);
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
