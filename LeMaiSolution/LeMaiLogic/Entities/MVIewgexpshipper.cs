using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpshipper:IVIewgexpshipper
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpshipper(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GexpShipper từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GexpShipper]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GexpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GexpShipper] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GexpShipper từ Database
		/// </summary>
		public List<view_GexpShipper> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GexpShipper]");
				List<view_GexpShipper> items = new List<view_GexpShipper>();
				view_GexpShipper item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GexpShipper();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
					}
					if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
					{
						item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
					{
						item.UserName = Convert.ToString(dr["UserName"]);
					}
					if (dr["Password"] != null && dr["Password"] != DBNull.Value)
					{
						item.Password = Convert.ToString(dr["Password"]);
					}
					if (dr["BalanceValue"] != null && dr["BalanceValue"] != DBNull.Value)
					{
						item.BalanceValue = Convert.ToInt32(dr["BalanceValue"]);
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
		/// Lấy danh sách view_GexpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GexpShipper> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GexpShipper] A "+ condition,  parameters);
				List<view_GexpShipper> items = new List<view_GexpShipper>();
				view_GexpShipper item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GexpShipper();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
					}
					if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
					{
						item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
					{
						item.UserName = Convert.ToString(dr["UserName"]);
					}
					if (dr["Password"] != null && dr["Password"] != DBNull.Value)
					{
						item.Password = Convert.ToString(dr["Password"]);
					}
					if (dr["BalanceValue"] != null && dr["BalanceValue"] != DBNull.Value)
					{
						item.BalanceValue = Convert.ToInt32(dr["BalanceValue"]);
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

		public List<view_GexpShipper> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GexpShipper] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GexpShipper] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GexpShipper>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GexpShipper đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GexpShipper GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GexpShipper] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GexpShipper item=new view_GexpShipper();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
						{
							item.ShipperName = Convert.ToString(dr["ShipperName"]);
						}
						if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
						{
							item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
						{
							item.UserName = Convert.ToString(dr["UserName"]);
						}
						if (dr["Password"] != null && dr["Password"] != DBNull.Value)
						{
							item.Password = Convert.ToString(dr["Password"]);
						}
						if (dr["BalanceValue"] != null && dr["BalanceValue"] != DBNull.Value)
						{
							item.BalanceValue = Convert.ToInt32(dr["BalanceValue"]);
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

		public view_GexpShipper GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GexpShipper] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GexpShipper>(ds);
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
