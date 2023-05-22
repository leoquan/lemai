using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbgalleryimage:IWEbgalleryimage
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbgalleryimage(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebGalleryImage từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebGalleryImage]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebGalleryImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebGalleryImage] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebGalleryImage từ Database
		/// </summary>
		public List<WebGalleryImage> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebGalleryImage]");
				List<WebGalleryImage> items = new List<WebGalleryImage>();
				WebGalleryImage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebGalleryImage();
					if (dr["FK_WebGallery"] != null && dr["FK_WebGallery"] != DBNull.Value)
					{
						item.FK_WebGallery = Convert.ToString(dr["FK_WebGallery"]);
					}
					if (dr["FK_WebImage"] != null && dr["FK_WebImage"] != DBNull.Value)
					{
						item.FK_WebImage = Convert.ToString(dr["FK_WebImage"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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
		/// Lấy danh sách WebGalleryImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebGalleryImage> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebGalleryImage] A "+ condition,  parameters);
				List<WebGalleryImage> items = new List<WebGalleryImage>();
				WebGalleryImage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebGalleryImage();
					if (dr["FK_WebGallery"] != null && dr["FK_WebGallery"] != DBNull.Value)
					{
						item.FK_WebGallery = Convert.ToString(dr["FK_WebGallery"]);
					}
					if (dr["FK_WebImage"] != null && dr["FK_WebImage"] != DBNull.Value)
					{
						item.FK_WebImage = Convert.ToString(dr["FK_WebImage"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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

		public List<WebGalleryImage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebGalleryImage] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebGalleryImage] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebGalleryImage>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebGalleryImage từ Database
		/// </summary>
		public WebGalleryImage GetObject(string schema, String FK_WebGallery, String FK_WebImage)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebGalleryImage] where FK_WebGallery=@FK_WebGallery and FK_WebImage=@FK_WebImage",
					"@FK_WebGallery", FK_WebGallery, 
					"@FK_WebImage", FK_WebImage);
				if (ds.Rows.Count > 0)
				{
					WebGalleryImage item=new WebGalleryImage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_WebGallery"] != null && dr["FK_WebGallery"] != DBNull.Value)
						{
							item.FK_WebGallery = Convert.ToString(dr["FK_WebGallery"]);
						}
						if (dr["FK_WebImage"] != null && dr["FK_WebImage"] != DBNull.Value)
						{
							item.FK_WebImage = Convert.ToString(dr["FK_WebImage"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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
		/// Lấy một WebGalleryImage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebGalleryImage GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebGalleryImage] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebGalleryImage item=new WebGalleryImage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_WebGallery"] != null && dr["FK_WebGallery"] != DBNull.Value)
						{
							item.FK_WebGallery = Convert.ToString(dr["FK_WebGallery"]);
						}
						if (dr["FK_WebImage"] != null && dr["FK_WebImage"] != DBNull.Value)
						{
							item.FK_WebImage = Convert.ToString(dr["FK_WebImage"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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

		public WebGalleryImage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebGalleryImage] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebGalleryImage>(ds);
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
		/// Thêm mới WebGalleryImage vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebGalleryImage _WebGalleryImage)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebGalleryImage](FK_WebGallery, FK_WebImage, OrderNumber) VALUES(@FK_WebGallery, @FK_WebImage, @OrderNumber)", 
					"@FK_WebGallery",  _WebGalleryImage.FK_WebGallery, 
					"@FK_WebImage",  _WebGalleryImage.FK_WebImage, 
					"@OrderNumber",  _WebGalleryImage.OrderNumber);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebGalleryImage vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebGalleryImage> _WebGalleryImages)
		{
			foreach (WebGalleryImage item in _WebGalleryImages)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebGalleryImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebGalleryImage _WebGalleryImage, String FK_WebGallery, String FK_WebImage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebGalleryImage] SET FK_WebGallery=@FK_WebGallery, FK_WebImage=@FK_WebImage, OrderNumber=@OrderNumber WHERE FK_WebGallery=@FK_WebGallery and FK_WebImage=@FK_WebImage", 
					"@FK_WebGallery",  _WebGalleryImage.FK_WebGallery, 
					"@FK_WebImage",  _WebGalleryImage.FK_WebImage, 
					"@OrderNumber",  _WebGalleryImage.OrderNumber, 
					"@FK_WebGallery", FK_WebGallery, 
					"@FK_WebImage", FK_WebImage);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebGalleryImage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebGalleryImage _WebGalleryImage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebGalleryImage] SET OrderNumber=@OrderNumber WHERE FK_WebGallery=@FK_WebGallery and FK_WebImage=@FK_WebImage", 
					"@OrderNumber",  _WebGalleryImage.OrderNumber, 
					"@FK_WebGallery", _WebGalleryImage.FK_WebGallery, 
					"@FK_WebImage", _WebGalleryImage.FK_WebImage);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebGalleryImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebGalleryImage> _WebGalleryImages)
		{
			foreach (WebGalleryImage item in _WebGalleryImages)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebGalleryImage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebGalleryImage _WebGalleryImage, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebGalleryImage] SET FK_WebGallery=@FK_WebGallery, FK_WebImage=@FK_WebImage, OrderNumber=@OrderNumber "+ condition, 
					"@FK_WebGallery",  _WebGalleryImage.FK_WebGallery, 
					"@FK_WebImage",  _WebGalleryImage.FK_WebImage, 
					"@OrderNumber",  _WebGalleryImage.OrderNumber);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebGalleryImage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_WebGallery, String FK_WebImage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebGalleryImage] WHERE FK_WebGallery=@FK_WebGallery and FK_WebImage=@FK_WebImage",
					"@FK_WebGallery", FK_WebGallery, 
					"@FK_WebImage", FK_WebImage);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebGalleryImage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebGalleryImage _WebGalleryImage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebGalleryImage] WHERE FK_WebGallery=@FK_WebGallery and FK_WebImage=@FK_WebImage",
					"@FK_WebGallery", _WebGalleryImage.FK_WebGallery, 
					"@FK_WebImage", _WebGalleryImage.FK_WebImage);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebGalleryImage trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebGalleryImage] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebGalleryImage trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebGalleryImage> _WebGalleryImages)
		{
			foreach (WebGalleryImage item in _WebGalleryImages)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
