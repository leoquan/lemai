using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSErviceimage:ISErviceimage
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSErviceimage(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ServiceImage từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceImage]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ServiceImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceImage] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ServiceImage từ Database
		/// </summary>
		public List<ServiceImage> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceImage]");
				List<ServiceImage> items = new List<ServiceImage>();
				ServiceImage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ServiceImage();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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
		/// Lấy danh sách ServiceImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ServiceImage> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ServiceImage] A "+ condition,  parameters);
				List<ServiceImage> items = new List<ServiceImage>();
				ServiceImage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ServiceImage();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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

		public List<ServiceImage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ServiceImage] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ServiceImage] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ServiceImage>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ServiceImage từ Database
		/// </summary>
		public ServiceImage GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceImage] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ServiceImage item=new ServiceImage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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
		/// Lấy một ServiceImage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ServiceImage GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ServiceImage] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ServiceImage item=new ServiceImage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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

		public ServiceImage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ServiceImage] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ServiceImage>(ds);
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
		/// Thêm mới ServiceImage vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ServiceImage _ServiceImage)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ServiceImage](Id, FK_Service, ImagePath, SortIndex) VALUES(@Id, @FK_Service, @ImagePath, @SortIndex)", 
					"@Id",  _ServiceImage.Id, 
					"@FK_Service",  _ServiceImage.FK_Service, 
					"@ImagePath",  _ServiceImage.ImagePath, 
					"@SortIndex",  _ServiceImage.SortIndex);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ServiceImage vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ServiceImage> _ServiceImages)
		{
			foreach (ServiceImage item in _ServiceImages)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ServiceImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ServiceImage _ServiceImage, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ServiceImage] SET Id=@Id, FK_Service=@FK_Service, ImagePath=@ImagePath, SortIndex=@SortIndex WHERE Id=@Id", 
					"@Id",  _ServiceImage.Id, 
					"@FK_Service",  _ServiceImage.FK_Service, 
					"@ImagePath",  _ServiceImage.ImagePath, 
					"@SortIndex",  _ServiceImage.SortIndex, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ServiceImage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ServiceImage _ServiceImage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ServiceImage] SET FK_Service=@FK_Service, ImagePath=@ImagePath, SortIndex=@SortIndex WHERE Id=@Id", 
					"@FK_Service",  _ServiceImage.FK_Service, 
					"@ImagePath",  _ServiceImage.ImagePath, 
					"@SortIndex",  _ServiceImage.SortIndex, 
					"@Id", _ServiceImage.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ServiceImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ServiceImage> _ServiceImages)
		{
			foreach (ServiceImage item in _ServiceImages)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ServiceImage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ServiceImage _ServiceImage, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ServiceImage] SET Id=@Id, FK_Service=@FK_Service, ImagePath=@ImagePath, SortIndex=@SortIndex "+ condition, 
					"@Id",  _ServiceImage.Id, 
					"@FK_Service",  _ServiceImage.FK_Service, 
					"@ImagePath",  _ServiceImage.ImagePath, 
					"@SortIndex",  _ServiceImage.SortIndex);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ServiceImage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ServiceImage] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ServiceImage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ServiceImage _ServiceImage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ServiceImage] WHERE Id=@Id",
					"@Id", _ServiceImage.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ServiceImage trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ServiceImage] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ServiceImage trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ServiceImage> _ServiceImages)
		{
			foreach (ServiceImage item in _ServiceImages)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
