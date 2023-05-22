using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MACcountobjectimage:IACcountobjectimage
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MACcountobjectimage(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable AccountObjectImage từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectImage]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable AccountObjectImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectImage] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách AccountObjectImage từ Database
		/// </summary>
		public List<AccountObjectImage> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectImage]");
				List<AccountObjectImage> items = new List<AccountObjectImage>();
				AccountObjectImage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectImage();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["SessionId"] != null && dr["SessionId"] != DBNull.Value)
					{
						item.SessionId = Convert.ToString(dr["SessionId"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
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
		/// Lấy danh sách AccountObjectImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<AccountObjectImage> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectImage] A "+ condition,  parameters);
				List<AccountObjectImage> items = new List<AccountObjectImage>();
				AccountObjectImage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectImage();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["SessionId"] != null && dr["SessionId"] != DBNull.Value)
					{
						item.SessionId = Convert.ToString(dr["SessionId"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
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

		public List<AccountObjectImage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectImage] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[AccountObjectImage] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<AccountObjectImage>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một AccountObjectImage từ Database
		/// </summary>
		public AccountObjectImage GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectImage] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					AccountObjectImage item=new AccountObjectImage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["SessionId"] != null && dr["SessionId"] != DBNull.Value)
						{
							item.SessionId = Convert.ToString(dr["SessionId"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
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
		/// Lấy một AccountObjectImage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public AccountObjectImage GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectImage] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					AccountObjectImage item=new AccountObjectImage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["SessionId"] != null && dr["SessionId"] != DBNull.Value)
						{
							item.SessionId = Convert.ToString(dr["SessionId"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
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

		public AccountObjectImage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectImage] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<AccountObjectImage>(ds);
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
		/// Thêm mới AccountObjectImage vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, AccountObjectImage _AccountObjectImage)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[AccountObjectImage](Id, FK_AccountObject, SessionId, ImagePath, CreateDate, CreateBy) VALUES(@Id, @FK_AccountObject, @SessionId, @ImagePath, @CreateDate, @CreateBy)", 
					"@Id",  _AccountObjectImage.Id, 
					"@FK_AccountObject",  _AccountObjectImage.FK_AccountObject, 
					"@SessionId",  _AccountObjectImage.SessionId, 
					"@ImagePath",  _AccountObjectImage.ImagePath, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectImage.CreateDate), 
					"@CreateBy",  _AccountObjectImage.CreateBy);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng AccountObjectImage vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<AccountObjectImage> _AccountObjectImages)
		{
			foreach (AccountObjectImage item in _AccountObjectImages)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, AccountObjectImage _AccountObjectImage, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectImage] SET Id=@Id, FK_AccountObject=@FK_AccountObject, SessionId=@SessionId, ImagePath=@ImagePath, CreateDate=@CreateDate, CreateBy=@CreateBy WHERE Id=@Id", 
					"@Id",  _AccountObjectImage.Id, 
					"@FK_AccountObject",  _AccountObjectImage.FK_AccountObject, 
					"@SessionId",  _AccountObjectImage.SessionId, 
					"@ImagePath",  _AccountObjectImage.ImagePath, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectImage.CreateDate), 
					"@CreateBy",  _AccountObjectImage.CreateBy, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectImage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, AccountObjectImage _AccountObjectImage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectImage] SET FK_AccountObject=@FK_AccountObject, SessionId=@SessionId, ImagePath=@ImagePath, CreateDate=@CreateDate, CreateBy=@CreateBy WHERE Id=@Id", 
					"@FK_AccountObject",  _AccountObjectImage.FK_AccountObject, 
					"@SessionId",  _AccountObjectImage.SessionId, 
					"@ImagePath",  _AccountObjectImage.ImagePath, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectImage.CreateDate), 
					"@CreateBy",  _AccountObjectImage.CreateBy, 
					"@Id", _AccountObjectImage.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách AccountObjectImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<AccountObjectImage> _AccountObjectImages)
		{
			foreach (AccountObjectImage item in _AccountObjectImages)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectImage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, AccountObjectImage _AccountObjectImage, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectImage] SET Id=@Id, FK_AccountObject=@FK_AccountObject, SessionId=@SessionId, ImagePath=@ImagePath, CreateDate=@CreateDate, CreateBy=@CreateBy "+ condition, 
					"@Id",  _AccountObjectImage.Id, 
					"@FK_AccountObject",  _AccountObjectImage.FK_AccountObject, 
					"@SessionId",  _AccountObjectImage.SessionId, 
					"@ImagePath",  _AccountObjectImage.ImagePath, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectImage.CreateDate), 
					"@CreateBy",  _AccountObjectImage.CreateBy);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa AccountObjectImage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectImage] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectImage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, AccountObjectImage _AccountObjectImage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectImage] WHERE Id=@Id",
					"@Id", _AccountObjectImage.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectImage trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectImage] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectImage trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<AccountObjectImage> _AccountObjectImages)
		{
			foreach (AccountObjectImage item in _AccountObjectImages)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
