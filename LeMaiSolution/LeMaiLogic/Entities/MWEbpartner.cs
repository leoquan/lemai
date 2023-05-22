using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbpartner:IWEbpartner
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbpartner(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebPartner từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebPartner]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebPartner từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebPartner] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebPartner từ Database
		/// </summary>
		public List<WebPartner> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebPartner]");
				List<WebPartner> items = new List<WebPartner>();
				WebPartner item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebPartner();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["PartnerName"] != null && dr["PartnerName"] != DBNull.Value)
					{
						item.PartnerName = Convert.ToString(dr["PartnerName"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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
		/// Lấy danh sách WebPartner từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebPartner> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebPartner] A "+ condition,  parameters);
				List<WebPartner> items = new List<WebPartner>();
				WebPartner item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebPartner();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["PartnerName"] != null && dr["PartnerName"] != DBNull.Value)
					{
						item.PartnerName = Convert.ToString(dr["PartnerName"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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

		public List<WebPartner> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebPartner] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebPartner] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebPartner>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebPartner từ Database
		/// </summary>
		public WebPartner GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebPartner] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebPartner item=new WebPartner();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["PartnerName"] != null && dr["PartnerName"] != DBNull.Value)
						{
							item.PartnerName = Convert.ToString(dr["PartnerName"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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
		/// Lấy một WebPartner đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebPartner GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebPartner] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebPartner item=new WebPartner();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["PartnerName"] != null && dr["PartnerName"] != DBNull.Value)
						{
							item.PartnerName = Convert.ToString(dr["PartnerName"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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

		public WebPartner GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebPartner] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebPartner>(ds);
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
		/// Thêm mới WebPartner vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebPartner _WebPartner)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebPartner](Id, PartnerName, ImagePath, Description, OrderNumber, BranchCode) VALUES(@Id, @PartnerName, @ImagePath, @Description, @OrderNumber, @BranchCode)", 
					"@Id",  _WebPartner.Id, 
					"@PartnerName",  _WebPartner.PartnerName, 
					"@ImagePath",  _WebPartner.ImagePath, 
					"@Description",  _WebPartner.Description, 
					"@OrderNumber",  _WebPartner.OrderNumber, 
					"@BranchCode",  _WebPartner.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebPartner vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebPartner> _WebPartners)
		{
			foreach (WebPartner item in _WebPartners)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebPartner vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebPartner _WebPartner, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebPartner] SET Id=@Id, PartnerName=@PartnerName, ImagePath=@ImagePath, Description=@Description, OrderNumber=@OrderNumber, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebPartner.Id, 
					"@PartnerName",  _WebPartner.PartnerName, 
					"@ImagePath",  _WebPartner.ImagePath, 
					"@Description",  _WebPartner.Description, 
					"@OrderNumber",  _WebPartner.OrderNumber, 
					"@BranchCode",  _WebPartner.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebPartner vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebPartner _WebPartner)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebPartner] SET PartnerName=@PartnerName, ImagePath=@ImagePath, Description=@Description, OrderNumber=@OrderNumber, BranchCode=@BranchCode WHERE Id=@Id", 
					"@PartnerName",  _WebPartner.PartnerName, 
					"@ImagePath",  _WebPartner.ImagePath, 
					"@Description",  _WebPartner.Description, 
					"@OrderNumber",  _WebPartner.OrderNumber, 
					"@BranchCode",  _WebPartner.BranchCode, 
					"@Id", _WebPartner.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebPartner vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebPartner> _WebPartners)
		{
			foreach (WebPartner item in _WebPartners)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebPartner vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebPartner _WebPartner, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebPartner] SET Id=@Id, PartnerName=@PartnerName, ImagePath=@ImagePath, Description=@Description, OrderNumber=@OrderNumber, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebPartner.Id, 
					"@PartnerName",  _WebPartner.PartnerName, 
					"@ImagePath",  _WebPartner.ImagePath, 
					"@Description",  _WebPartner.Description, 
					"@OrderNumber",  _WebPartner.OrderNumber, 
					"@BranchCode",  _WebPartner.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebPartner trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebPartner] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebPartner trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebPartner _WebPartner)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebPartner] WHERE Id=@Id",
					"@Id", _WebPartner.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebPartner trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebPartner] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebPartner trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebPartner> _WebPartners)
		{
			foreach (WebPartner item in _WebPartners)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
