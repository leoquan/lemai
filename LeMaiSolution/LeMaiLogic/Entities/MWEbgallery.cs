using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbgallery:IWEbgallery
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbgallery(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebGallery từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebGallery]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebGallery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebGallery] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebGallery từ Database
		/// </summary>
		public List<WebGallery> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebGallery]");
				List<WebGallery> items = new List<WebGallery>();
				WebGallery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebGallery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["GalleryName"] != null && dr["GalleryName"] != DBNull.Value)
					{
						item.GalleryName = Convert.ToString(dr["GalleryName"]);
					}
					if (dr["GalleryGroup"] != null && dr["GalleryGroup"] != DBNull.Value)
					{
						item.GalleryGroup = Convert.ToString(dr["GalleryGroup"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
					{
						item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
					}
					if (dr["Sumary"] != null && dr["Sumary"] != DBNull.Value)
					{
						item.Sumary = Convert.ToString(dr["Sumary"]);
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
		/// Lấy danh sách WebGallery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebGallery> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebGallery] A "+ condition,  parameters);
				List<WebGallery> items = new List<WebGallery>();
				WebGallery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebGallery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["GalleryName"] != null && dr["GalleryName"] != DBNull.Value)
					{
						item.GalleryName = Convert.ToString(dr["GalleryName"]);
					}
					if (dr["GalleryGroup"] != null && dr["GalleryGroup"] != DBNull.Value)
					{
						item.GalleryGroup = Convert.ToString(dr["GalleryGroup"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
					{
						item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
					}
					if (dr["Sumary"] != null && dr["Sumary"] != DBNull.Value)
					{
						item.Sumary = Convert.ToString(dr["Sumary"]);
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

		public List<WebGallery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebGallery] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebGallery] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebGallery>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebGallery từ Database
		/// </summary>
		public WebGallery GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebGallery] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebGallery item=new WebGallery();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["GalleryName"] != null && dr["GalleryName"] != DBNull.Value)
						{
							item.GalleryName = Convert.ToString(dr["GalleryName"]);
						}
						if (dr["GalleryGroup"] != null && dr["GalleryGroup"] != DBNull.Value)
						{
							item.GalleryGroup = Convert.ToString(dr["GalleryGroup"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
						{
							item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
						}
						if (dr["Sumary"] != null && dr["Sumary"] != DBNull.Value)
						{
							item.Sumary = Convert.ToString(dr["Sumary"]);
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
		/// Lấy một WebGallery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebGallery GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebGallery] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebGallery item=new WebGallery();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["GalleryName"] != null && dr["GalleryName"] != DBNull.Value)
						{
							item.GalleryName = Convert.ToString(dr["GalleryName"]);
						}
						if (dr["GalleryGroup"] != null && dr["GalleryGroup"] != DBNull.Value)
						{
							item.GalleryGroup = Convert.ToString(dr["GalleryGroup"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
						{
							item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
						}
						if (dr["Sumary"] != null && dr["Sumary"] != DBNull.Value)
						{
							item.Sumary = Convert.ToString(dr["Sumary"]);
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

		public WebGallery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebGallery] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebGallery>(ds);
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
		/// Thêm mới WebGallery vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebGallery _WebGallery)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebGallery](Id, GalleryName, GalleryGroup, OrderNumber, IsDelete, ImagePath, ShortDescription, Sumary, BranchCode) VALUES(@Id, @GalleryName, @GalleryGroup, @OrderNumber, @IsDelete, @ImagePath, @ShortDescription, @Sumary, @BranchCode)", 
					"@Id",  _WebGallery.Id, 
					"@GalleryName",  _WebGallery.GalleryName, 
					"@GalleryGroup",  _WebGallery.GalleryGroup, 
					"@OrderNumber",  _WebGallery.OrderNumber, 
					"@IsDelete",  _WebGallery.IsDelete, 
					"@ImagePath",  _WebGallery.ImagePath, 
					"@ShortDescription",  _WebGallery.ShortDescription, 
					"@Sumary",  _WebGallery.Sumary, 
					"@BranchCode",  _WebGallery.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebGallery vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebGallery> _WebGallerys)
		{
			foreach (WebGallery item in _WebGallerys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebGallery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebGallery _WebGallery, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebGallery] SET Id=@Id, GalleryName=@GalleryName, GalleryGroup=@GalleryGroup, OrderNumber=@OrderNumber, IsDelete=@IsDelete, ImagePath=@ImagePath, ShortDescription=@ShortDescription, Sumary=@Sumary, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebGallery.Id, 
					"@GalleryName",  _WebGallery.GalleryName, 
					"@GalleryGroup",  _WebGallery.GalleryGroup, 
					"@OrderNumber",  _WebGallery.OrderNumber, 
					"@IsDelete",  _WebGallery.IsDelete, 
					"@ImagePath",  _WebGallery.ImagePath, 
					"@ShortDescription",  _WebGallery.ShortDescription, 
					"@Sumary",  _WebGallery.Sumary, 
					"@BranchCode",  _WebGallery.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebGallery vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebGallery _WebGallery)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebGallery] SET GalleryName=@GalleryName, GalleryGroup=@GalleryGroup, OrderNumber=@OrderNumber, IsDelete=@IsDelete, ImagePath=@ImagePath, ShortDescription=@ShortDescription, Sumary=@Sumary, BranchCode=@BranchCode WHERE Id=@Id", 
					"@GalleryName",  _WebGallery.GalleryName, 
					"@GalleryGroup",  _WebGallery.GalleryGroup, 
					"@OrderNumber",  _WebGallery.OrderNumber, 
					"@IsDelete",  _WebGallery.IsDelete, 
					"@ImagePath",  _WebGallery.ImagePath, 
					"@ShortDescription",  _WebGallery.ShortDescription, 
					"@Sumary",  _WebGallery.Sumary, 
					"@BranchCode",  _WebGallery.BranchCode, 
					"@Id", _WebGallery.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebGallery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebGallery> _WebGallerys)
		{
			foreach (WebGallery item in _WebGallerys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebGallery vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebGallery _WebGallery, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebGallery] SET Id=@Id, GalleryName=@GalleryName, GalleryGroup=@GalleryGroup, OrderNumber=@OrderNumber, IsDelete=@IsDelete, ImagePath=@ImagePath, ShortDescription=@ShortDescription, Sumary=@Sumary, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebGallery.Id, 
					"@GalleryName",  _WebGallery.GalleryName, 
					"@GalleryGroup",  _WebGallery.GalleryGroup, 
					"@OrderNumber",  _WebGallery.OrderNumber, 
					"@IsDelete",  _WebGallery.IsDelete, 
					"@ImagePath",  _WebGallery.ImagePath, 
					"@ShortDescription",  _WebGallery.ShortDescription, 
					"@Sumary",  _WebGallery.Sumary, 
					"@BranchCode",  _WebGallery.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebGallery trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebGallery] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebGallery trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebGallery _WebGallery)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebGallery] WHERE Id=@Id",
					"@Id", _WebGallery.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebGallery trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebGallery] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebGallery trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebGallery> _WebGallerys)
		{
			foreach (WebGallery item in _WebGallerys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
