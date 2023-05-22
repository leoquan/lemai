using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbshopingdetail:IWEbshopingdetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbshopingdetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebShopingDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebShopingDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebShopingDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebShopingDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebShopingDetail từ Database
		/// </summary>
		public List<WebShopingDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebShopingDetail]");
				List<WebShopingDetail> items = new List<WebShopingDetail>();
				WebShopingDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebShopingDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["FK_Shoping"] != null && dr["FK_Shoping"] != DBNull.Value)
					{
						item.FK_Shoping = Convert.ToString(dr["FK_Shoping"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToInt32(dr["Quantity"]);
					}
					if (dr["Price"] != null && dr["Price"] != DBNull.Value)
					{
						item.Price = Convert.ToInt32(dr["Price"]);
					}
					if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
					{
						item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy danh sách WebShopingDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebShopingDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebShopingDetail] A "+ condition,  parameters);
				List<WebShopingDetail> items = new List<WebShopingDetail>();
				WebShopingDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebShopingDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["FK_Shoping"] != null && dr["FK_Shoping"] != DBNull.Value)
					{
						item.FK_Shoping = Convert.ToString(dr["FK_Shoping"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToInt32(dr["Quantity"]);
					}
					if (dr["Price"] != null && dr["Price"] != DBNull.Value)
					{
						item.Price = Convert.ToInt32(dr["Price"]);
					}
					if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
					{
						item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public List<WebShopingDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebShopingDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebShopingDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebShopingDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebShopingDetail từ Database
		/// </summary>
		public WebShopingDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebShopingDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebShopingDetail item=new WebShopingDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["FK_Shoping"] != null && dr["FK_Shoping"] != DBNull.Value)
						{
							item.FK_Shoping = Convert.ToString(dr["FK_Shoping"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
						{
							item.Quantity = Convert.ToInt32(dr["Quantity"]);
						}
						if (dr["Price"] != null && dr["Price"] != DBNull.Value)
						{
							item.Price = Convert.ToInt32(dr["Price"]);
						}
						if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
						{
							item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy một WebShopingDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebShopingDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebShopingDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebShopingDetail item=new WebShopingDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["FK_Shoping"] != null && dr["FK_Shoping"] != DBNull.Value)
						{
							item.FK_Shoping = Convert.ToString(dr["FK_Shoping"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
						{
							item.Quantity = Convert.ToInt32(dr["Quantity"]);
						}
						if (dr["Price"] != null && dr["Price"] != DBNull.Value)
						{
							item.Price = Convert.ToInt32(dr["Price"]);
						}
						if (dr["TotalPrice"] != null && dr["TotalPrice"] != DBNull.Value)
						{
							item.TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public WebShopingDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebShopingDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebShopingDetail>(ds);
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
		/// Thêm mới WebShopingDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebShopingDetail _WebShopingDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebShopingDetail](Id, SortIndex, FK_Shoping, FK_Service, Quantity, Price, TotalPrice, Status, BranchCode) VALUES(@Id, @SortIndex, @FK_Shoping, @FK_Service, @Quantity, @Price, @TotalPrice, @Status, @BranchCode)", 
					"@Id",  _WebShopingDetail.Id, 
					"@SortIndex",  _WebShopingDetail.SortIndex, 
					"@FK_Shoping",  _WebShopingDetail.FK_Shoping, 
					"@FK_Service",  _WebShopingDetail.FK_Service, 
					"@Quantity",  _WebShopingDetail.Quantity, 
					"@Price",  _WebShopingDetail.Price, 
					"@TotalPrice",  _WebShopingDetail.TotalPrice, 
					"@Status",  _WebShopingDetail.Status, 
					"@BranchCode",  _WebShopingDetail.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebShopingDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebShopingDetail> _WebShopingDetails)
		{
			foreach (WebShopingDetail item in _WebShopingDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebShopingDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebShopingDetail _WebShopingDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebShopingDetail] SET Id=@Id, SortIndex=@SortIndex, FK_Shoping=@FK_Shoping, FK_Service=@FK_Service, Quantity=@Quantity, Price=@Price, TotalPrice=@TotalPrice, Status=@Status, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebShopingDetail.Id, 
					"@SortIndex",  _WebShopingDetail.SortIndex, 
					"@FK_Shoping",  _WebShopingDetail.FK_Shoping, 
					"@FK_Service",  _WebShopingDetail.FK_Service, 
					"@Quantity",  _WebShopingDetail.Quantity, 
					"@Price",  _WebShopingDetail.Price, 
					"@TotalPrice",  _WebShopingDetail.TotalPrice, 
					"@Status",  _WebShopingDetail.Status, 
					"@BranchCode",  _WebShopingDetail.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebShopingDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebShopingDetail _WebShopingDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebShopingDetail] SET SortIndex=@SortIndex, FK_Shoping=@FK_Shoping, FK_Service=@FK_Service, Quantity=@Quantity, Price=@Price, TotalPrice=@TotalPrice, Status=@Status, BranchCode=@BranchCode WHERE Id=@Id", 
					"@SortIndex",  _WebShopingDetail.SortIndex, 
					"@FK_Shoping",  _WebShopingDetail.FK_Shoping, 
					"@FK_Service",  _WebShopingDetail.FK_Service, 
					"@Quantity",  _WebShopingDetail.Quantity, 
					"@Price",  _WebShopingDetail.Price, 
					"@TotalPrice",  _WebShopingDetail.TotalPrice, 
					"@Status",  _WebShopingDetail.Status, 
					"@BranchCode",  _WebShopingDetail.BranchCode, 
					"@Id", _WebShopingDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebShopingDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebShopingDetail> _WebShopingDetails)
		{
			foreach (WebShopingDetail item in _WebShopingDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebShopingDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebShopingDetail _WebShopingDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebShopingDetail] SET Id=@Id, SortIndex=@SortIndex, FK_Shoping=@FK_Shoping, FK_Service=@FK_Service, Quantity=@Quantity, Price=@Price, TotalPrice=@TotalPrice, Status=@Status, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebShopingDetail.Id, 
					"@SortIndex",  _WebShopingDetail.SortIndex, 
					"@FK_Shoping",  _WebShopingDetail.FK_Shoping, 
					"@FK_Service",  _WebShopingDetail.FK_Service, 
					"@Quantity",  _WebShopingDetail.Quantity, 
					"@Price",  _WebShopingDetail.Price, 
					"@TotalPrice",  _WebShopingDetail.TotalPrice, 
					"@Status",  _WebShopingDetail.Status, 
					"@BranchCode",  _WebShopingDetail.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebShopingDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebShopingDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebShopingDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebShopingDetail _WebShopingDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebShopingDetail] WHERE Id=@Id",
					"@Id", _WebShopingDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebShopingDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebShopingDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebShopingDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebShopingDetail> _WebShopingDetails)
		{
			foreach (WebShopingDetail item in _WebShopingDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
