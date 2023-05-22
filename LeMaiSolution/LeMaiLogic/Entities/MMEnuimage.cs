using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEnuimage:IMEnuimage
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEnuimage(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MenuImage từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuImage]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MenuImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuImage] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MenuImage từ Database
		/// </summary>
		public List<MenuImage> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuImage]");
				List<MenuImage> items = new List<MenuImage>();
				MenuImage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuImage();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["ImageString"] != null && dr["ImageString"] != DBNull.Value)
					{
						item.ImageString = Convert.ToString(dr["ImageString"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
					{
						item.CreateUser = Convert.ToString(dr["CreateUser"]);
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
		/// Lấy danh sách MenuImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MenuImage> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuImage] A "+ condition,  parameters);
				List<MenuImage> items = new List<MenuImage>();
				MenuImage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MenuImage();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["ImageString"] != null && dr["ImageString"] != DBNull.Value)
					{
						item.ImageString = Convert.ToString(dr["ImageString"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
					{
						item.CreateUser = Convert.ToString(dr["CreateUser"]);
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

		public List<MenuImage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuImage] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MenuImage] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MenuImage>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MenuImage từ Database
		/// </summary>
		public MenuImage GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MenuImage] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MenuImage item=new MenuImage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["ImageString"] != null && dr["ImageString"] != DBNull.Value)
						{
							item.ImageString = Convert.ToString(dr["ImageString"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
						{
							item.CreateUser = Convert.ToString(dr["CreateUser"]);
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
		/// Lấy một MenuImage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MenuImage GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MenuImage] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MenuImage item=new MenuImage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["ImageString"] != null && dr["ImageString"] != DBNull.Value)
						{
							item.ImageString = Convert.ToString(dr["ImageString"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateUser"] != null && dr["CreateUser"] != DBNull.Value)
						{
							item.CreateUser = Convert.ToString(dr["CreateUser"]);
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

		public MenuImage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MenuImage] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MenuImage>(ds);
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
		/// Thêm mới MenuImage vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MenuImage _MenuImage)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MenuImage](Id, FullName, ImageString, CreateDate, CreateUser) VALUES(@Id, @FullName, @ImageString, @CreateDate, @CreateUser)", 
					"@Id",  _MenuImage.Id, 
					"@FullName",  _MenuImage.FullName, 
					"@ImageString",  _MenuImage.ImageString, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuImage.CreateDate), 
					"@CreateUser",  _MenuImage.CreateUser);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MenuImage vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MenuImage> _MenuImages)
		{
			foreach (MenuImage item in _MenuImages)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MenuImage _MenuImage, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuImage] SET Id=@Id, FullName=@FullName, ImageString=@ImageString, CreateDate=@CreateDate, CreateUser=@CreateUser WHERE Id=@Id", 
					"@Id",  _MenuImage.Id, 
					"@FullName",  _MenuImage.FullName, 
					"@ImageString",  _MenuImage.ImageString, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuImage.CreateDate), 
					"@CreateUser",  _MenuImage.CreateUser, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MenuImage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MenuImage _MenuImage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuImage] SET FullName=@FullName, ImageString=@ImageString, CreateDate=@CreateDate, CreateUser=@CreateUser WHERE Id=@Id", 
					"@FullName",  _MenuImage.FullName, 
					"@ImageString",  _MenuImage.ImageString, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuImage.CreateDate), 
					"@CreateUser",  _MenuImage.CreateUser, 
					"@Id", _MenuImage.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MenuImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MenuImage> _MenuImages)
		{
			foreach (MenuImage item in _MenuImages)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MenuImage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MenuImage _MenuImage, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MenuImage] SET Id=@Id, FullName=@FullName, ImageString=@ImageString, CreateDate=@CreateDate, CreateUser=@CreateUser "+ condition, 
					"@Id",  _MenuImage.Id, 
					"@FullName",  _MenuImage.FullName, 
					"@ImageString",  _MenuImage.ImageString, 
					"@CreateDate", this._dataContext.ConvertDateString( _MenuImage.CreateDate), 
					"@CreateUser",  _MenuImage.CreateUser);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MenuImage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuImage] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuImage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MenuImage _MenuImage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuImage] WHERE Id=@Id",
					"@Id", _MenuImage.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuImage trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MenuImage] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MenuImage trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MenuImage> _MenuImages)
		{
			foreach (MenuImage item in _MenuImages)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
