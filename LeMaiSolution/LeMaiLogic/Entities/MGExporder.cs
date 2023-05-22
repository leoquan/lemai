using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExporder:IGExporder
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExporder(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpOrder từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpOrder]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpOrder từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpOrder] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpOrder từ Database
		/// </summary>
		public List<GExpOrder> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpOrder]");
				List<GExpOrder> items = new List<GExpOrder>();
				GExpOrder item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpOrder();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["OrderCode"] != null && dr["OrderCode"] != DBNull.Value)
					{
						item.OrderCode = Convert.ToString(dr["OrderCode"]);
					}
					if (dr["AcceptName"] != null && dr["AcceptName"] != DBNull.Value)
					{
						item.AcceptName = Convert.ToString(dr["AcceptName"]);
					}
					if (dr["AcceptPhone"] != null && dr["AcceptPhone"] != DBNull.Value)
					{
						item.AcceptPhone = Convert.ToString(dr["AcceptPhone"]);
					}
					if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
					{
						item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
					}
					if (dr["GoodsName"] != null && dr["GoodsName"] != DBNull.Value)
					{
						item.GoodsName = Convert.ToString(dr["GoodsName"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
					{
						item.Weight = Convert.ToInt32(dr["Weight"]);
					}
					if (dr["IsShopPay"] != null && dr["IsShopPay"] != DBNull.Value)
					{
						item.IsShopPay = Convert.ToBoolean(dr["IsShopPay"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
					{
						item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
					}
					if (dr["StatusOrder"] != null && dr["StatusOrder"] != DBNull.Value)
					{
						item.StatusOrder = Convert.ToInt32(dr["StatusOrder"]);
					}
					if (dr["PickupUser"] != null && dr["PickupUser"] != DBNull.Value)
					{
						item.PickupUser = Convert.ToString(dr["PickupUser"]);
					}
					if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
					{
						item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
					}
					if (dr["TransferCode"] != null && dr["TransferCode"] != DBNull.Value)
					{
						item.TransferCode = Convert.ToString(dr["TransferCode"]);
					}
					if (dr["ProvinceCode"] != null && dr["ProvinceCode"] != DBNull.Value)
					{
						item.ProvinceCode = Convert.ToInt32(dr["ProvinceCode"]);
					}
					if (dr["DistrictCode"] != null && dr["DistrictCode"] != DBNull.Value)
					{
						item.DistrictCode = Convert.ToInt32(dr["DistrictCode"]);
					}
					if (dr["DistrictWard"] != null && dr["DistrictWard"] != DBNull.Value)
					{
						item.DistrictWard = Convert.ToString(dr["DistrictWard"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToInt32(dr["Freight"]);
					}
					if (dr["FK_ShipperNot"] != null && dr["FK_ShipperNot"] != DBNull.Value)
					{
						item.FK_ShipperNot = Convert.ToString(dr["FK_ShipperNot"]);
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
		/// Lấy danh sách GExpOrder từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpOrder> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpOrder] A "+ condition,  parameters);
				List<GExpOrder> items = new List<GExpOrder>();
				GExpOrder item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpOrder();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["OrderCode"] != null && dr["OrderCode"] != DBNull.Value)
					{
						item.OrderCode = Convert.ToString(dr["OrderCode"]);
					}
					if (dr["AcceptName"] != null && dr["AcceptName"] != DBNull.Value)
					{
						item.AcceptName = Convert.ToString(dr["AcceptName"]);
					}
					if (dr["AcceptPhone"] != null && dr["AcceptPhone"] != DBNull.Value)
					{
						item.AcceptPhone = Convert.ToString(dr["AcceptPhone"]);
					}
					if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
					{
						item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
					}
					if (dr["GoodsName"] != null && dr["GoodsName"] != DBNull.Value)
					{
						item.GoodsName = Convert.ToString(dr["GoodsName"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
					{
						item.Weight = Convert.ToInt32(dr["Weight"]);
					}
					if (dr["IsShopPay"] != null && dr["IsShopPay"] != DBNull.Value)
					{
						item.IsShopPay = Convert.ToBoolean(dr["IsShopPay"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
					{
						item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
					}
					if (dr["StatusOrder"] != null && dr["StatusOrder"] != DBNull.Value)
					{
						item.StatusOrder = Convert.ToInt32(dr["StatusOrder"]);
					}
					if (dr["PickupUser"] != null && dr["PickupUser"] != DBNull.Value)
					{
						item.PickupUser = Convert.ToString(dr["PickupUser"]);
					}
					if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
					{
						item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
					}
					if (dr["TransferCode"] != null && dr["TransferCode"] != DBNull.Value)
					{
						item.TransferCode = Convert.ToString(dr["TransferCode"]);
					}
					if (dr["ProvinceCode"] != null && dr["ProvinceCode"] != DBNull.Value)
					{
						item.ProvinceCode = Convert.ToInt32(dr["ProvinceCode"]);
					}
					if (dr["DistrictCode"] != null && dr["DistrictCode"] != DBNull.Value)
					{
						item.DistrictCode = Convert.ToInt32(dr["DistrictCode"]);
					}
					if (dr["DistrictWard"] != null && dr["DistrictWard"] != DBNull.Value)
					{
						item.DistrictWard = Convert.ToString(dr["DistrictWard"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToInt32(dr["Freight"]);
					}
					if (dr["FK_ShipperNot"] != null && dr["FK_ShipperNot"] != DBNull.Value)
					{
						item.FK_ShipperNot = Convert.ToString(dr["FK_ShipperNot"]);
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

		public List<GExpOrder> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpOrder] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpOrder] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpOrder>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpOrder từ Database
		/// </summary>
		public GExpOrder GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpOrder] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpOrder item=new GExpOrder();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["OrderCode"] != null && dr["OrderCode"] != DBNull.Value)
						{
							item.OrderCode = Convert.ToString(dr["OrderCode"]);
						}
						if (dr["AcceptName"] != null && dr["AcceptName"] != DBNull.Value)
						{
							item.AcceptName = Convert.ToString(dr["AcceptName"]);
						}
						if (dr["AcceptPhone"] != null && dr["AcceptPhone"] != DBNull.Value)
						{
							item.AcceptPhone = Convert.ToString(dr["AcceptPhone"]);
						}
						if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
						{
							item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
						}
						if (dr["GoodsName"] != null && dr["GoodsName"] != DBNull.Value)
						{
							item.GoodsName = Convert.ToString(dr["GoodsName"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
						{
							item.Weight = Convert.ToInt32(dr["Weight"]);
						}
						if (dr["IsShopPay"] != null && dr["IsShopPay"] != DBNull.Value)
						{
							item.IsShopPay = Convert.ToBoolean(dr["IsShopPay"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
						{
							item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
						}
						if (dr["StatusOrder"] != null && dr["StatusOrder"] != DBNull.Value)
						{
							item.StatusOrder = Convert.ToInt32(dr["StatusOrder"]);
						}
						if (dr["PickupUser"] != null && dr["PickupUser"] != DBNull.Value)
						{
							item.PickupUser = Convert.ToString(dr["PickupUser"]);
						}
						if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
						{
							item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
						}
						if (dr["TransferCode"] != null && dr["TransferCode"] != DBNull.Value)
						{
							item.TransferCode = Convert.ToString(dr["TransferCode"]);
						}
						if (dr["ProvinceCode"] != null && dr["ProvinceCode"] != DBNull.Value)
						{
							item.ProvinceCode = Convert.ToInt32(dr["ProvinceCode"]);
						}
						if (dr["DistrictCode"] != null && dr["DistrictCode"] != DBNull.Value)
						{
							item.DistrictCode = Convert.ToInt32(dr["DistrictCode"]);
						}
						if (dr["DistrictWard"] != null && dr["DistrictWard"] != DBNull.Value)
						{
							item.DistrictWard = Convert.ToString(dr["DistrictWard"]);
						}
						if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
						{
							item.Freight = Convert.ToInt32(dr["Freight"]);
						}
						if (dr["FK_ShipperNot"] != null && dr["FK_ShipperNot"] != DBNull.Value)
						{
							item.FK_ShipperNot = Convert.ToString(dr["FK_ShipperNot"]);
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

		/// <summary>
		/// Lấy một GExpOrder đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpOrder GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpOrder] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpOrder item=new GExpOrder();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["OrderCode"] != null && dr["OrderCode"] != DBNull.Value)
						{
							item.OrderCode = Convert.ToString(dr["OrderCode"]);
						}
						if (dr["AcceptName"] != null && dr["AcceptName"] != DBNull.Value)
						{
							item.AcceptName = Convert.ToString(dr["AcceptName"]);
						}
						if (dr["AcceptPhone"] != null && dr["AcceptPhone"] != DBNull.Value)
						{
							item.AcceptPhone = Convert.ToString(dr["AcceptPhone"]);
						}
						if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
						{
							item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
						}
						if (dr["GoodsName"] != null && dr["GoodsName"] != DBNull.Value)
						{
							item.GoodsName = Convert.ToString(dr["GoodsName"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
						{
							item.Weight = Convert.ToInt32(dr["Weight"]);
						}
						if (dr["IsShopPay"] != null && dr["IsShopPay"] != DBNull.Value)
						{
							item.IsShopPay = Convert.ToBoolean(dr["IsShopPay"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
						{
							item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
						}
						if (dr["StatusOrder"] != null && dr["StatusOrder"] != DBNull.Value)
						{
							item.StatusOrder = Convert.ToInt32(dr["StatusOrder"]);
						}
						if (dr["PickupUser"] != null && dr["PickupUser"] != DBNull.Value)
						{
							item.PickupUser = Convert.ToString(dr["PickupUser"]);
						}
						if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
						{
							item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
						}
						if (dr["TransferCode"] != null && dr["TransferCode"] != DBNull.Value)
						{
							item.TransferCode = Convert.ToString(dr["TransferCode"]);
						}
						if (dr["ProvinceCode"] != null && dr["ProvinceCode"] != DBNull.Value)
						{
							item.ProvinceCode = Convert.ToInt32(dr["ProvinceCode"]);
						}
						if (dr["DistrictCode"] != null && dr["DistrictCode"] != DBNull.Value)
						{
							item.DistrictCode = Convert.ToInt32(dr["DistrictCode"]);
						}
						if (dr["DistrictWard"] != null && dr["DistrictWard"] != DBNull.Value)
						{
							item.DistrictWard = Convert.ToString(dr["DistrictWard"]);
						}
						if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
						{
							item.Freight = Convert.ToInt32(dr["Freight"]);
						}
						if (dr["FK_ShipperNot"] != null && dr["FK_ShipperNot"] != DBNull.Value)
						{
							item.FK_ShipperNot = Convert.ToString(dr["FK_ShipperNot"]);
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

		public GExpOrder GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpOrder] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpOrder>(ds);
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
		/// <summary>
		/// Thêm mới GExpOrder vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpOrder _GExpOrder)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpOrder](Id, OrderCode, AcceptName, AcceptPhone, AcceptAddress, GoodsName, COD, Weight, IsShopPay, Note, CreateDate, FK_CustomerId, StatusOrder, PickupUser, PickupDate, TransferCode, ProvinceCode, DistrictCode, DistrictWard, Freight, FK_ShipperNot) VALUES(@Id, @OrderCode, @AcceptName, @AcceptPhone, @AcceptAddress, @GoodsName, @COD, @Weight, @IsShopPay, @Note, @CreateDate, @FK_CustomerId, @StatusOrder, @PickupUser, @PickupDate, @TransferCode, @ProvinceCode, @DistrictCode, @DistrictWard, @Freight, @FK_ShipperNot)", 
					"@Id",  _GExpOrder.Id, 
					"@OrderCode",  _GExpOrder.OrderCode, 
					"@AcceptName",  _GExpOrder.AcceptName, 
					"@AcceptPhone",  _GExpOrder.AcceptPhone, 
					"@AcceptAddress",  _GExpOrder.AcceptAddress, 
					"@GoodsName",  _GExpOrder.GoodsName, 
					"@COD",  _GExpOrder.COD, 
					"@Weight",  _GExpOrder.Weight, 
					"@IsShopPay",  _GExpOrder.IsShopPay, 
					"@Note",  _GExpOrder.Note, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpOrder.CreateDate), 
					"@FK_CustomerId",  _GExpOrder.FK_CustomerId, 
					"@StatusOrder",  _GExpOrder.StatusOrder, 
					"@PickupUser",  _GExpOrder.PickupUser, 
					"@PickupDate", this._dataContext.ConvertDateString( _GExpOrder.PickupDate), 
					"@TransferCode",  _GExpOrder.TransferCode, 
					"@ProvinceCode",  _GExpOrder.ProvinceCode, 
					"@DistrictCode",  _GExpOrder.DistrictCode, 
					"@DistrictWard",  _GExpOrder.DistrictWard, 
					"@Freight",  _GExpOrder.Freight, 
					"@FK_ShipperNot",  _GExpOrder.FK_ShipperNot);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpOrder vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpOrder> _GExpOrders)
		{
			foreach (GExpOrder item in _GExpOrders)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpOrder vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpOrder _GExpOrder, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpOrder] SET Id=@Id, OrderCode=@OrderCode, AcceptName=@AcceptName, AcceptPhone=@AcceptPhone, AcceptAddress=@AcceptAddress, GoodsName=@GoodsName, COD=@COD, Weight=@Weight, IsShopPay=@IsShopPay, Note=@Note, CreateDate=@CreateDate, FK_CustomerId=@FK_CustomerId, StatusOrder=@StatusOrder, PickupUser=@PickupUser, PickupDate=@PickupDate, TransferCode=@TransferCode, ProvinceCode=@ProvinceCode, DistrictCode=@DistrictCode, DistrictWard=@DistrictWard, Freight=@Freight, FK_ShipperNot=@FK_ShipperNot WHERE Id=@Id", 
					"@Id",  _GExpOrder.Id, 
					"@OrderCode",  _GExpOrder.OrderCode, 
					"@AcceptName",  _GExpOrder.AcceptName, 
					"@AcceptPhone",  _GExpOrder.AcceptPhone, 
					"@AcceptAddress",  _GExpOrder.AcceptAddress, 
					"@GoodsName",  _GExpOrder.GoodsName, 
					"@COD",  _GExpOrder.COD, 
					"@Weight",  _GExpOrder.Weight, 
					"@IsShopPay",  _GExpOrder.IsShopPay, 
					"@Note",  _GExpOrder.Note, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpOrder.CreateDate), 
					"@FK_CustomerId",  _GExpOrder.FK_CustomerId, 
					"@StatusOrder",  _GExpOrder.StatusOrder, 
					"@PickupUser",  _GExpOrder.PickupUser, 
					"@PickupDate", this._dataContext.ConvertDateString( _GExpOrder.PickupDate), 
					"@TransferCode",  _GExpOrder.TransferCode, 
					"@ProvinceCode",  _GExpOrder.ProvinceCode, 
					"@DistrictCode",  _GExpOrder.DistrictCode, 
					"@DistrictWard",  _GExpOrder.DistrictWard, 
					"@Freight",  _GExpOrder.Freight, 
					"@FK_ShipperNot",  _GExpOrder.FK_ShipperNot, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpOrder vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpOrder _GExpOrder)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpOrder] SET OrderCode=@OrderCode, AcceptName=@AcceptName, AcceptPhone=@AcceptPhone, AcceptAddress=@AcceptAddress, GoodsName=@GoodsName, COD=@COD, Weight=@Weight, IsShopPay=@IsShopPay, Note=@Note, CreateDate=@CreateDate, FK_CustomerId=@FK_CustomerId, StatusOrder=@StatusOrder, PickupUser=@PickupUser, PickupDate=@PickupDate, TransferCode=@TransferCode, ProvinceCode=@ProvinceCode, DistrictCode=@DistrictCode, DistrictWard=@DistrictWard, Freight=@Freight, FK_ShipperNot=@FK_ShipperNot WHERE Id=@Id", 
					"@OrderCode",  _GExpOrder.OrderCode, 
					"@AcceptName",  _GExpOrder.AcceptName, 
					"@AcceptPhone",  _GExpOrder.AcceptPhone, 
					"@AcceptAddress",  _GExpOrder.AcceptAddress, 
					"@GoodsName",  _GExpOrder.GoodsName, 
					"@COD",  _GExpOrder.COD, 
					"@Weight",  _GExpOrder.Weight, 
					"@IsShopPay",  _GExpOrder.IsShopPay, 
					"@Note",  _GExpOrder.Note, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpOrder.CreateDate), 
					"@FK_CustomerId",  _GExpOrder.FK_CustomerId, 
					"@StatusOrder",  _GExpOrder.StatusOrder, 
					"@PickupUser",  _GExpOrder.PickupUser, 
					"@PickupDate", this._dataContext.ConvertDateString( _GExpOrder.PickupDate), 
					"@TransferCode",  _GExpOrder.TransferCode, 
					"@ProvinceCode",  _GExpOrder.ProvinceCode, 
					"@DistrictCode",  _GExpOrder.DistrictCode, 
					"@DistrictWard",  _GExpOrder.DistrictWard, 
					"@Freight",  _GExpOrder.Freight, 
					"@FK_ShipperNot",  _GExpOrder.FK_ShipperNot, 
					"@Id", _GExpOrder.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpOrder vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpOrder> _GExpOrders)
		{
			foreach (GExpOrder item in _GExpOrders)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpOrder vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpOrder _GExpOrder, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpOrder] SET Id=@Id, OrderCode=@OrderCode, AcceptName=@AcceptName, AcceptPhone=@AcceptPhone, AcceptAddress=@AcceptAddress, GoodsName=@GoodsName, COD=@COD, Weight=@Weight, IsShopPay=@IsShopPay, Note=@Note, CreateDate=@CreateDate, FK_CustomerId=@FK_CustomerId, StatusOrder=@StatusOrder, PickupUser=@PickupUser, PickupDate=@PickupDate, TransferCode=@TransferCode, ProvinceCode=@ProvinceCode, DistrictCode=@DistrictCode, DistrictWard=@DistrictWard, Freight=@Freight, FK_ShipperNot=@FK_ShipperNot "+ condition, 
					"@Id",  _GExpOrder.Id, 
					"@OrderCode",  _GExpOrder.OrderCode, 
					"@AcceptName",  _GExpOrder.AcceptName, 
					"@AcceptPhone",  _GExpOrder.AcceptPhone, 
					"@AcceptAddress",  _GExpOrder.AcceptAddress, 
					"@GoodsName",  _GExpOrder.GoodsName, 
					"@COD",  _GExpOrder.COD, 
					"@Weight",  _GExpOrder.Weight, 
					"@IsShopPay",  _GExpOrder.IsShopPay, 
					"@Note",  _GExpOrder.Note, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpOrder.CreateDate), 
					"@FK_CustomerId",  _GExpOrder.FK_CustomerId, 
					"@StatusOrder",  _GExpOrder.StatusOrder, 
					"@PickupUser",  _GExpOrder.PickupUser, 
					"@PickupDate", this._dataContext.ConvertDateString( _GExpOrder.PickupDate), 
					"@TransferCode",  _GExpOrder.TransferCode, 
					"@ProvinceCode",  _GExpOrder.ProvinceCode, 
					"@DistrictCode",  _GExpOrder.DistrictCode, 
					"@DistrictWard",  _GExpOrder.DistrictWard, 
					"@Freight",  _GExpOrder.Freight, 
					"@FK_ShipperNot",  _GExpOrder.FK_ShipperNot);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpOrder trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpOrder] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpOrder trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpOrder _GExpOrder)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpOrder] WHERE Id=@Id",
					"@Id", _GExpOrder.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpOrder trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpOrder] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpOrder trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpOrder> _GExpOrders)
		{
			foreach (GExpOrder item in _GExpOrders)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
