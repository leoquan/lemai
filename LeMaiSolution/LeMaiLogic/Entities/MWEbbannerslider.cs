using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbbannerslider:IWEbbannerslider
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbbannerslider(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebBannerSlider từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebBannerSlider]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebBannerSlider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebBannerSlider] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebBannerSlider từ Database
		/// </summary>
		public List<WebBannerSlider> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebBannerSlider]");
				List<WebBannerSlider> items = new List<WebBannerSlider>();
				WebBannerSlider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebBannerSlider();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BannerName"] != null && dr["BannerName"] != DBNull.Value)
					{
						item.BannerName = Convert.ToString(dr["BannerName"]);
					}
					if (dr["BannerTitle"] != null && dr["BannerTitle"] != DBNull.Value)
					{
						item.BannerTitle = Convert.ToString(dr["BannerTitle"]);
					}
					if (dr["BannerDescription"] != null && dr["BannerDescription"] != DBNull.Value)
					{
						item.BannerDescription = Convert.ToString(dr["BannerDescription"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["LinkDetail"] != null && dr["LinkDetail"] != DBNull.Value)
					{
						item.LinkDetail = Convert.ToString(dr["LinkDetail"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
					}
					if (dr["PostValidDate"] != null && dr["PostValidDate"] != DBNull.Value)
					{
						item.PostValidDate = Convert.ToDateTime(dr["PostValidDate"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["typeDisplay"] != null && dr["typeDisplay"] != DBNull.Value)
					{
						item.typeDisplay = Convert.ToInt32(dr["typeDisplay"]);
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
		/// Lấy danh sách WebBannerSlider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebBannerSlider> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebBannerSlider] A "+ condition,  parameters);
				List<WebBannerSlider> items = new List<WebBannerSlider>();
				WebBannerSlider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebBannerSlider();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BannerName"] != null && dr["BannerName"] != DBNull.Value)
					{
						item.BannerName = Convert.ToString(dr["BannerName"]);
					}
					if (dr["BannerTitle"] != null && dr["BannerTitle"] != DBNull.Value)
					{
						item.BannerTitle = Convert.ToString(dr["BannerTitle"]);
					}
					if (dr["BannerDescription"] != null && dr["BannerDescription"] != DBNull.Value)
					{
						item.BannerDescription = Convert.ToString(dr["BannerDescription"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["LinkDetail"] != null && dr["LinkDetail"] != DBNull.Value)
					{
						item.LinkDetail = Convert.ToString(dr["LinkDetail"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
					}
					if (dr["PostValidDate"] != null && dr["PostValidDate"] != DBNull.Value)
					{
						item.PostValidDate = Convert.ToDateTime(dr["PostValidDate"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["typeDisplay"] != null && dr["typeDisplay"] != DBNull.Value)
					{
						item.typeDisplay = Convert.ToInt32(dr["typeDisplay"]);
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

		public List<WebBannerSlider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebBannerSlider] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebBannerSlider] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebBannerSlider>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebBannerSlider từ Database
		/// </summary>
		public WebBannerSlider GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebBannerSlider] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebBannerSlider item=new WebBannerSlider();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BannerName"] != null && dr["BannerName"] != DBNull.Value)
						{
							item.BannerName = Convert.ToString(dr["BannerName"]);
						}
						if (dr["BannerTitle"] != null && dr["BannerTitle"] != DBNull.Value)
						{
							item.BannerTitle = Convert.ToString(dr["BannerTitle"]);
						}
						if (dr["BannerDescription"] != null && dr["BannerDescription"] != DBNull.Value)
						{
							item.BannerDescription = Convert.ToString(dr["BannerDescription"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["LinkDetail"] != null && dr["LinkDetail"] != DBNull.Value)
						{
							item.LinkDetail = Convert.ToString(dr["LinkDetail"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
						{
							item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
						}
						if (dr["PostValidDate"] != null && dr["PostValidDate"] != DBNull.Value)
						{
							item.PostValidDate = Convert.ToDateTime(dr["PostValidDate"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToInt32(dr["Type"]);
						}
						if (dr["typeDisplay"] != null && dr["typeDisplay"] != DBNull.Value)
						{
							item.typeDisplay = Convert.ToInt32(dr["typeDisplay"]);
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
		/// Lấy một WebBannerSlider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebBannerSlider GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebBannerSlider] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebBannerSlider item=new WebBannerSlider();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BannerName"] != null && dr["BannerName"] != DBNull.Value)
						{
							item.BannerName = Convert.ToString(dr["BannerName"]);
						}
						if (dr["BannerTitle"] != null && dr["BannerTitle"] != DBNull.Value)
						{
							item.BannerTitle = Convert.ToString(dr["BannerTitle"]);
						}
						if (dr["BannerDescription"] != null && dr["BannerDescription"] != DBNull.Value)
						{
							item.BannerDescription = Convert.ToString(dr["BannerDescription"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["LinkDetail"] != null && dr["LinkDetail"] != DBNull.Value)
						{
							item.LinkDetail = Convert.ToString(dr["LinkDetail"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
						{
							item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
						}
						if (dr["PostValidDate"] != null && dr["PostValidDate"] != DBNull.Value)
						{
							item.PostValidDate = Convert.ToDateTime(dr["PostValidDate"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToInt32(dr["Type"]);
						}
						if (dr["typeDisplay"] != null && dr["typeDisplay"] != DBNull.Value)
						{
							item.typeDisplay = Convert.ToInt32(dr["typeDisplay"]);
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

		public WebBannerSlider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebBannerSlider] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebBannerSlider>(ds);
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
		/// Thêm mới WebBannerSlider vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebBannerSlider _WebBannerSlider)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebBannerSlider](Id, BannerName, BannerTitle, BannerDescription, ImagePath, LinkDetail, CreateDate, FK_CreateBy, PostValidDate, IsDelete, Type, typeDisplay, BranchCode) VALUES(@Id, @BannerName, @BannerTitle, @BannerDescription, @ImagePath, @LinkDetail, @CreateDate, @FK_CreateBy, @PostValidDate, @IsDelete, @Type, @typeDisplay, @BranchCode)", 
					"@Id",  _WebBannerSlider.Id, 
					"@BannerName",  _WebBannerSlider.BannerName, 
					"@BannerTitle",  _WebBannerSlider.BannerTitle, 
					"@BannerDescription",  _WebBannerSlider.BannerDescription, 
					"@ImagePath",  _WebBannerSlider.ImagePath, 
					"@LinkDetail",  _WebBannerSlider.LinkDetail, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebBannerSlider.CreateDate), 
					"@FK_CreateBy",  _WebBannerSlider.FK_CreateBy, 
					"@PostValidDate", this._dataContext.ConvertDateString( _WebBannerSlider.PostValidDate), 
					"@IsDelete",  _WebBannerSlider.IsDelete, 
					"@Type",  _WebBannerSlider.Type, 
					"@typeDisplay",  _WebBannerSlider.typeDisplay, 
					"@BranchCode",  _WebBannerSlider.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebBannerSlider vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebBannerSlider> _WebBannerSliders)
		{
			foreach (WebBannerSlider item in _WebBannerSliders)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebBannerSlider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebBannerSlider _WebBannerSlider, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebBannerSlider] SET Id=@Id, BannerName=@BannerName, BannerTitle=@BannerTitle, BannerDescription=@BannerDescription, ImagePath=@ImagePath, LinkDetail=@LinkDetail, CreateDate=@CreateDate, FK_CreateBy=@FK_CreateBy, PostValidDate=@PostValidDate, IsDelete=@IsDelete, Type=@Type, typeDisplay=@typeDisplay, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebBannerSlider.Id, 
					"@BannerName",  _WebBannerSlider.BannerName, 
					"@BannerTitle",  _WebBannerSlider.BannerTitle, 
					"@BannerDescription",  _WebBannerSlider.BannerDescription, 
					"@ImagePath",  _WebBannerSlider.ImagePath, 
					"@LinkDetail",  _WebBannerSlider.LinkDetail, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebBannerSlider.CreateDate), 
					"@FK_CreateBy",  _WebBannerSlider.FK_CreateBy, 
					"@PostValidDate", this._dataContext.ConvertDateString( _WebBannerSlider.PostValidDate), 
					"@IsDelete",  _WebBannerSlider.IsDelete, 
					"@Type",  _WebBannerSlider.Type, 
					"@typeDisplay",  _WebBannerSlider.typeDisplay, 
					"@BranchCode",  _WebBannerSlider.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebBannerSlider vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebBannerSlider _WebBannerSlider)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebBannerSlider] SET BannerName=@BannerName, BannerTitle=@BannerTitle, BannerDescription=@BannerDescription, ImagePath=@ImagePath, LinkDetail=@LinkDetail, CreateDate=@CreateDate, FK_CreateBy=@FK_CreateBy, PostValidDate=@PostValidDate, IsDelete=@IsDelete, Type=@Type, typeDisplay=@typeDisplay, BranchCode=@BranchCode WHERE Id=@Id", 
					"@BannerName",  _WebBannerSlider.BannerName, 
					"@BannerTitle",  _WebBannerSlider.BannerTitle, 
					"@BannerDescription",  _WebBannerSlider.BannerDescription, 
					"@ImagePath",  _WebBannerSlider.ImagePath, 
					"@LinkDetail",  _WebBannerSlider.LinkDetail, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebBannerSlider.CreateDate), 
					"@FK_CreateBy",  _WebBannerSlider.FK_CreateBy, 
					"@PostValidDate", this._dataContext.ConvertDateString( _WebBannerSlider.PostValidDate), 
					"@IsDelete",  _WebBannerSlider.IsDelete, 
					"@Type",  _WebBannerSlider.Type, 
					"@typeDisplay",  _WebBannerSlider.typeDisplay, 
					"@BranchCode",  _WebBannerSlider.BranchCode, 
					"@Id", _WebBannerSlider.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebBannerSlider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebBannerSlider> _WebBannerSliders)
		{
			foreach (WebBannerSlider item in _WebBannerSliders)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebBannerSlider vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebBannerSlider _WebBannerSlider, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebBannerSlider] SET Id=@Id, BannerName=@BannerName, BannerTitle=@BannerTitle, BannerDescription=@BannerDescription, ImagePath=@ImagePath, LinkDetail=@LinkDetail, CreateDate=@CreateDate, FK_CreateBy=@FK_CreateBy, PostValidDate=@PostValidDate, IsDelete=@IsDelete, Type=@Type, typeDisplay=@typeDisplay, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebBannerSlider.Id, 
					"@BannerName",  _WebBannerSlider.BannerName, 
					"@BannerTitle",  _WebBannerSlider.BannerTitle, 
					"@BannerDescription",  _WebBannerSlider.BannerDescription, 
					"@ImagePath",  _WebBannerSlider.ImagePath, 
					"@LinkDetail",  _WebBannerSlider.LinkDetail, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebBannerSlider.CreateDate), 
					"@FK_CreateBy",  _WebBannerSlider.FK_CreateBy, 
					"@PostValidDate", this._dataContext.ConvertDateString( _WebBannerSlider.PostValidDate), 
					"@IsDelete",  _WebBannerSlider.IsDelete, 
					"@Type",  _WebBannerSlider.Type, 
					"@typeDisplay",  _WebBannerSlider.typeDisplay, 
					"@BranchCode",  _WebBannerSlider.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebBannerSlider trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebBannerSlider] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebBannerSlider trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebBannerSlider _WebBannerSlider)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebBannerSlider] WHERE Id=@Id",
					"@Id", _WebBannerSlider.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebBannerSlider trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebBannerSlider] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebBannerSlider trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebBannerSlider> _WebBannerSliders)
		{
			foreach (WebBannerSlider item in _WebBannerSliders)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
