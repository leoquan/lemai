using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpreceivetask:IVIewgexpreceivetask
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpreceivetask(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpReceiveTask từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpReceiveTask]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpReceiveTask từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpReceiveTask] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpReceiveTask từ Database
		/// </summary>
		public List<view_GExpReceiveTask> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpReceiveTask]");
				List<view_GExpReceiveTask> items = new List<view_GExpReceiveTask>();
				view_GExpReceiveTask item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpReceiveTask();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
					{
						item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
					}
					if (dr["FK_ShipperId"] != null && dr["FK_ShipperId"] != DBNull.Value)
					{
						item.FK_ShipperId = Convert.ToString(dr["FK_ShipperId"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
					}
					if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
					{
						item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
					{
						item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["NVGiao"] != null && dr["NVGiao"] != DBNull.Value)
					{
						item.NVGiao = Convert.ToString(dr["NVGiao"]);
					}
					if (dr["StatusReceiveName"] != null && dr["StatusReceiveName"] != DBNull.Value)
					{
						item.StatusReceiveName = Convert.ToString(dr["StatusReceiveName"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["FK_PickupShipper"] != null && dr["FK_PickupShipper"] != DBNull.Value)
					{
						item.FK_PickupShipper = Convert.ToString(dr["FK_PickupShipper"]);
					}
					if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
					{
						item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
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
		/// Lấy danh sách view_GExpReceiveTask từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpReceiveTask> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpReceiveTask] A "+ condition,  parameters);
				List<view_GExpReceiveTask> items = new List<view_GExpReceiveTask>();
				view_GExpReceiveTask item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpReceiveTask();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
					{
						item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
					}
					if (dr["FK_ShipperId"] != null && dr["FK_ShipperId"] != DBNull.Value)
					{
						item.FK_ShipperId = Convert.ToString(dr["FK_ShipperId"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
					}
					if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
					{
						item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
					{
						item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["NVGiao"] != null && dr["NVGiao"] != DBNull.Value)
					{
						item.NVGiao = Convert.ToString(dr["NVGiao"]);
					}
					if (dr["StatusReceiveName"] != null && dr["StatusReceiveName"] != DBNull.Value)
					{
						item.StatusReceiveName = Convert.ToString(dr["StatusReceiveName"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["FK_PickupShipper"] != null && dr["FK_PickupShipper"] != DBNull.Value)
					{
						item.FK_PickupShipper = Convert.ToString(dr["FK_PickupShipper"]);
					}
					if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
					{
						item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
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

		public List<view_GExpReceiveTask> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpReceiveTask] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpReceiveTask] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpReceiveTask>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpReceiveTask đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpReceiveTask GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpReceiveTask] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpReceiveTask item=new view_GExpReceiveTask();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
						{
							item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
						}
						if (dr["FK_ShipperId"] != null && dr["FK_ShipperId"] != DBNull.Value)
						{
							item.FK_ShipperId = Convert.ToString(dr["FK_ShipperId"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
						{
							item.ShipperName = Convert.ToString(dr["ShipperName"]);
						}
						if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
						{
							item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
						}
						if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
						{
							item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
						}
						if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
						{
							item.CustomerName = Convert.ToString(dr["CustomerName"]);
						}
						if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
						{
							item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
						}
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["NVGiao"] != null && dr["NVGiao"] != DBNull.Value)
						{
							item.NVGiao = Convert.ToString(dr["NVGiao"]);
						}
						if (dr["StatusReceiveName"] != null && dr["StatusReceiveName"] != DBNull.Value)
						{
							item.StatusReceiveName = Convert.ToString(dr["StatusReceiveName"]);
						}
						if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
						{
							item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
						}
						if (dr["FK_PickupShipper"] != null && dr["FK_PickupShipper"] != DBNull.Value)
						{
							item.FK_PickupShipper = Convert.ToString(dr["FK_PickupShipper"]);
						}
						if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
						{
							item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
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

		public view_GExpReceiveTask GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpReceiveTask] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpReceiveTask>(ds);
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
