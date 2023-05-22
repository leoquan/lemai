using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGScategory:IGScategory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGScategory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsCategory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCategory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsCategory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCategory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsCategory từ Database
		/// </summary>
		public List<GsCategory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCategory]");
				List<GsCategory> items = new List<GsCategory>();
				GsCategory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsCategory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["CategoryName"] != null && dr["CategoryName"] != DBNull.Value)
					{
						item.CategoryName = Convert.ToString(dr["CategoryName"]);
					}
					if (dr["Slug_Name"] != null && dr["Slug_Name"] != DBNull.Value)
					{
						item.Slug_Name = Convert.ToString(dr["Slug_Name"]);
					}
					if (dr["AutoSlug"] != null && dr["AutoSlug"] != DBNull.Value)
					{
						item.AutoSlug = Convert.ToBoolean(dr["AutoSlug"]);
					}
					if (dr["FK_CategoryId"] != null && dr["FK_CategoryId"] != DBNull.Value)
					{
						item.FK_CategoryId = Convert.ToString(dr["FK_CategoryId"]);
					}
					if (dr["RankIndex"] != null && dr["RankIndex"] != DBNull.Value)
					{
						item.RankIndex = Convert.ToInt32(dr["RankIndex"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["Tags"] != null && dr["Tags"] != DBNull.Value)
					{
						item.Tags = Convert.ToString(dr["Tags"]);
					}
					if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
					{
						item.KeyWord = Convert.ToString(dr["KeyWord"]);
					}
					if (dr["MetaData"] != null && dr["MetaData"] != DBNull.Value)
					{
						item.MetaData = Convert.ToString(dr["MetaData"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["CreatedBy"] != null && dr["CreatedBy"] != DBNull.Value)
					{
						item.CreatedBy = Convert.ToString(dr["CreatedBy"]);
					}
					if (dr["CreatedDate"] != null && dr["CreatedDate"] != DBNull.Value)
					{
						item.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
					}
					if (dr["UpdatedBy"] != null && dr["UpdatedBy"] != DBNull.Value)
					{
						item.UpdatedBy = Convert.ToString(dr["UpdatedBy"]);
					}
					if (dr["UpdatedDate"] != null && dr["UpdatedDate"] != DBNull.Value)
					{
						item.UpdatedDate = Convert.ToDateTime(dr["UpdatedDate"]);
					}
					if (dr["RowStatus"] != null && dr["RowStatus"] != DBNull.Value)
					{
						item.RowStatus = Convert.ToInt32(dr["RowStatus"]);
					}
					if (dr["CountChild"] != null && dr["CountChild"] != DBNull.Value)
					{
						item.CountChild = Convert.ToInt32(dr["CountChild"]);
					}
					if (dr["CountProduct"] != null && dr["CountProduct"] != DBNull.Value)
					{
						item.CountProduct = Convert.ToInt32(dr["CountProduct"]);
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
		/// Lấy danh sách GsCategory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsCategory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsCategory] A "+ condition,  parameters);
				List<GsCategory> items = new List<GsCategory>();
				GsCategory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsCategory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["CategoryName"] != null && dr["CategoryName"] != DBNull.Value)
					{
						item.CategoryName = Convert.ToString(dr["CategoryName"]);
					}
					if (dr["Slug_Name"] != null && dr["Slug_Name"] != DBNull.Value)
					{
						item.Slug_Name = Convert.ToString(dr["Slug_Name"]);
					}
					if (dr["AutoSlug"] != null && dr["AutoSlug"] != DBNull.Value)
					{
						item.AutoSlug = Convert.ToBoolean(dr["AutoSlug"]);
					}
					if (dr["FK_CategoryId"] != null && dr["FK_CategoryId"] != DBNull.Value)
					{
						item.FK_CategoryId = Convert.ToString(dr["FK_CategoryId"]);
					}
					if (dr["RankIndex"] != null && dr["RankIndex"] != DBNull.Value)
					{
						item.RankIndex = Convert.ToInt32(dr["RankIndex"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
					}
					if (dr["Tags"] != null && dr["Tags"] != DBNull.Value)
					{
						item.Tags = Convert.ToString(dr["Tags"]);
					}
					if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
					{
						item.KeyWord = Convert.ToString(dr["KeyWord"]);
					}
					if (dr["MetaData"] != null && dr["MetaData"] != DBNull.Value)
					{
						item.MetaData = Convert.ToString(dr["MetaData"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["CreatedBy"] != null && dr["CreatedBy"] != DBNull.Value)
					{
						item.CreatedBy = Convert.ToString(dr["CreatedBy"]);
					}
					if (dr["CreatedDate"] != null && dr["CreatedDate"] != DBNull.Value)
					{
						item.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
					}
					if (dr["UpdatedBy"] != null && dr["UpdatedBy"] != DBNull.Value)
					{
						item.UpdatedBy = Convert.ToString(dr["UpdatedBy"]);
					}
					if (dr["UpdatedDate"] != null && dr["UpdatedDate"] != DBNull.Value)
					{
						item.UpdatedDate = Convert.ToDateTime(dr["UpdatedDate"]);
					}
					if (dr["RowStatus"] != null && dr["RowStatus"] != DBNull.Value)
					{
						item.RowStatus = Convert.ToInt32(dr["RowStatus"]);
					}
					if (dr["CountChild"] != null && dr["CountChild"] != DBNull.Value)
					{
						item.CountChild = Convert.ToInt32(dr["CountChild"]);
					}
					if (dr["CountProduct"] != null && dr["CountProduct"] != DBNull.Value)
					{
						item.CountProduct = Convert.ToInt32(dr["CountProduct"]);
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

		public List<GsCategory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsCategory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsCategory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsCategory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsCategory từ Database
		/// </summary>
		public GsCategory GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsCategory] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsCategory item=new GsCategory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["CategoryName"] != null && dr["CategoryName"] != DBNull.Value)
						{
							item.CategoryName = Convert.ToString(dr["CategoryName"]);
						}
						if (dr["Slug_Name"] != null && dr["Slug_Name"] != DBNull.Value)
						{
							item.Slug_Name = Convert.ToString(dr["Slug_Name"]);
						}
						if (dr["AutoSlug"] != null && dr["AutoSlug"] != DBNull.Value)
						{
							item.AutoSlug = Convert.ToBoolean(dr["AutoSlug"]);
						}
						if (dr["FK_CategoryId"] != null && dr["FK_CategoryId"] != DBNull.Value)
						{
							item.FK_CategoryId = Convert.ToString(dr["FK_CategoryId"]);
						}
						if (dr["RankIndex"] != null && dr["RankIndex"] != DBNull.Value)
						{
							item.RankIndex = Convert.ToInt32(dr["RankIndex"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["Tags"] != null && dr["Tags"] != DBNull.Value)
						{
							item.Tags = Convert.ToString(dr["Tags"]);
						}
						if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
						{
							item.KeyWord = Convert.ToString(dr["KeyWord"]);
						}
						if (dr["MetaData"] != null && dr["MetaData"] != DBNull.Value)
						{
							item.MetaData = Convert.ToString(dr["MetaData"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["CreatedBy"] != null && dr["CreatedBy"] != DBNull.Value)
						{
							item.CreatedBy = Convert.ToString(dr["CreatedBy"]);
						}
						if (dr["CreatedDate"] != null && dr["CreatedDate"] != DBNull.Value)
						{
							item.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
						}
						if (dr["UpdatedBy"] != null && dr["UpdatedBy"] != DBNull.Value)
						{
							item.UpdatedBy = Convert.ToString(dr["UpdatedBy"]);
						}
						if (dr["UpdatedDate"] != null && dr["UpdatedDate"] != DBNull.Value)
						{
							item.UpdatedDate = Convert.ToDateTime(dr["UpdatedDate"]);
						}
						if (dr["RowStatus"] != null && dr["RowStatus"] != DBNull.Value)
						{
							item.RowStatus = Convert.ToInt32(dr["RowStatus"]);
						}
						if (dr["CountChild"] != null && dr["CountChild"] != DBNull.Value)
						{
							item.CountChild = Convert.ToInt32(dr["CountChild"]);
						}
						if (dr["CountProduct"] != null && dr["CountProduct"] != DBNull.Value)
						{
							item.CountProduct = Convert.ToInt32(dr["CountProduct"]);
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
		/// Lấy một GsCategory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsCategory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsCategory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsCategory item=new GsCategory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["CategoryName"] != null && dr["CategoryName"] != DBNull.Value)
						{
							item.CategoryName = Convert.ToString(dr["CategoryName"]);
						}
						if (dr["Slug_Name"] != null && dr["Slug_Name"] != DBNull.Value)
						{
							item.Slug_Name = Convert.ToString(dr["Slug_Name"]);
						}
						if (dr["AutoSlug"] != null && dr["AutoSlug"] != DBNull.Value)
						{
							item.AutoSlug = Convert.ToBoolean(dr["AutoSlug"]);
						}
						if (dr["FK_CategoryId"] != null && dr["FK_CategoryId"] != DBNull.Value)
						{
							item.FK_CategoryId = Convert.ToString(dr["FK_CategoryId"]);
						}
						if (dr["RankIndex"] != null && dr["RankIndex"] != DBNull.Value)
						{
							item.RankIndex = Convert.ToInt32(dr["RankIndex"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
						}
						if (dr["Tags"] != null && dr["Tags"] != DBNull.Value)
						{
							item.Tags = Convert.ToString(dr["Tags"]);
						}
						if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
						{
							item.KeyWord = Convert.ToString(dr["KeyWord"]);
						}
						if (dr["MetaData"] != null && dr["MetaData"] != DBNull.Value)
						{
							item.MetaData = Convert.ToString(dr["MetaData"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["CreatedBy"] != null && dr["CreatedBy"] != DBNull.Value)
						{
							item.CreatedBy = Convert.ToString(dr["CreatedBy"]);
						}
						if (dr["CreatedDate"] != null && dr["CreatedDate"] != DBNull.Value)
						{
							item.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
						}
						if (dr["UpdatedBy"] != null && dr["UpdatedBy"] != DBNull.Value)
						{
							item.UpdatedBy = Convert.ToString(dr["UpdatedBy"]);
						}
						if (dr["UpdatedDate"] != null && dr["UpdatedDate"] != DBNull.Value)
						{
							item.UpdatedDate = Convert.ToDateTime(dr["UpdatedDate"]);
						}
						if (dr["RowStatus"] != null && dr["RowStatus"] != DBNull.Value)
						{
							item.RowStatus = Convert.ToInt32(dr["RowStatus"]);
						}
						if (dr["CountChild"] != null && dr["CountChild"] != DBNull.Value)
						{
							item.CountChild = Convert.ToInt32(dr["CountChild"]);
						}
						if (dr["CountProduct"] != null && dr["CountProduct"] != DBNull.Value)
						{
							item.CountProduct = Convert.ToInt32(dr["CountProduct"]);
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

		public GsCategory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsCategory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsCategory>(ds);
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
		/// Thêm mới GsCategory vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsCategory _GsCategory)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsCategory](Id, Code, CategoryName, Slug_Name, AutoSlug, FK_CategoryId, RankIndex, SortIndex, Tags, KeyWord, MetaData, Note, CreatedBy, CreatedDate, UpdatedBy, UpdatedDate, RowStatus, CountChild, CountProduct) VALUES(@Id, @Code, @CategoryName, @Slug_Name, @AutoSlug, @FK_CategoryId, @RankIndex, @SortIndex, @Tags, @KeyWord, @MetaData, @Note, @CreatedBy, @CreatedDate, @UpdatedBy, @UpdatedDate, @RowStatus, @CountChild, @CountProduct)", 
					"@Id",  _GsCategory.Id, 
					"@Code",  _GsCategory.Code, 
					"@CategoryName",  _GsCategory.CategoryName, 
					"@Slug_Name",  _GsCategory.Slug_Name, 
					"@AutoSlug",  _GsCategory.AutoSlug, 
					"@FK_CategoryId",  _GsCategory.FK_CategoryId, 
					"@RankIndex",  _GsCategory.RankIndex, 
					"@SortIndex",  _GsCategory.SortIndex, 
					"@Tags",  _GsCategory.Tags, 
					"@KeyWord",  _GsCategory.KeyWord, 
					"@MetaData",  _GsCategory.MetaData, 
					"@Note",  _GsCategory.Note, 
					"@CreatedBy",  _GsCategory.CreatedBy, 
					"@CreatedDate", this._dataContext.ConvertDateString( _GsCategory.CreatedDate), 
					"@UpdatedBy",  _GsCategory.UpdatedBy, 
					"@UpdatedDate", this._dataContext.ConvertDateString( _GsCategory.UpdatedDate), 
					"@RowStatus",  _GsCategory.RowStatus, 
					"@CountChild",  _GsCategory.CountChild, 
					"@CountProduct",  _GsCategory.CountProduct);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsCategory vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsCategory> _GsCategorys)
		{
			foreach (GsCategory item in _GsCategorys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsCategory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsCategory _GsCategory, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCategory] SET Id=@Id, Code=@Code, CategoryName=@CategoryName, Slug_Name=@Slug_Name, AutoSlug=@AutoSlug, FK_CategoryId=@FK_CategoryId, RankIndex=@RankIndex, SortIndex=@SortIndex, Tags=@Tags, KeyWord=@KeyWord, MetaData=@MetaData, Note=@Note, CreatedBy=@CreatedBy, CreatedDate=@CreatedDate, UpdatedBy=@UpdatedBy, UpdatedDate=@UpdatedDate, RowStatus=@RowStatus, CountChild=@CountChild, CountProduct=@CountProduct WHERE Id=@Id", 
					"@Id",  _GsCategory.Id, 
					"@Code",  _GsCategory.Code, 
					"@CategoryName",  _GsCategory.CategoryName, 
					"@Slug_Name",  _GsCategory.Slug_Name, 
					"@AutoSlug",  _GsCategory.AutoSlug, 
					"@FK_CategoryId",  _GsCategory.FK_CategoryId, 
					"@RankIndex",  _GsCategory.RankIndex, 
					"@SortIndex",  _GsCategory.SortIndex, 
					"@Tags",  _GsCategory.Tags, 
					"@KeyWord",  _GsCategory.KeyWord, 
					"@MetaData",  _GsCategory.MetaData, 
					"@Note",  _GsCategory.Note, 
					"@CreatedBy",  _GsCategory.CreatedBy, 
					"@CreatedDate", this._dataContext.ConvertDateString( _GsCategory.CreatedDate), 
					"@UpdatedBy",  _GsCategory.UpdatedBy, 
					"@UpdatedDate", this._dataContext.ConvertDateString( _GsCategory.UpdatedDate), 
					"@RowStatus",  _GsCategory.RowStatus, 
					"@CountChild",  _GsCategory.CountChild, 
					"@CountProduct",  _GsCategory.CountProduct, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsCategory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsCategory _GsCategory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCategory] SET Code=@Code, CategoryName=@CategoryName, Slug_Name=@Slug_Name, AutoSlug=@AutoSlug, FK_CategoryId=@FK_CategoryId, RankIndex=@RankIndex, SortIndex=@SortIndex, Tags=@Tags, KeyWord=@KeyWord, MetaData=@MetaData, Note=@Note, CreatedBy=@CreatedBy, CreatedDate=@CreatedDate, UpdatedBy=@UpdatedBy, UpdatedDate=@UpdatedDate, RowStatus=@RowStatus, CountChild=@CountChild, CountProduct=@CountProduct WHERE Id=@Id", 
					"@Code",  _GsCategory.Code, 
					"@CategoryName",  _GsCategory.CategoryName, 
					"@Slug_Name",  _GsCategory.Slug_Name, 
					"@AutoSlug",  _GsCategory.AutoSlug, 
					"@FK_CategoryId",  _GsCategory.FK_CategoryId, 
					"@RankIndex",  _GsCategory.RankIndex, 
					"@SortIndex",  _GsCategory.SortIndex, 
					"@Tags",  _GsCategory.Tags, 
					"@KeyWord",  _GsCategory.KeyWord, 
					"@MetaData",  _GsCategory.MetaData, 
					"@Note",  _GsCategory.Note, 
					"@CreatedBy",  _GsCategory.CreatedBy, 
					"@CreatedDate", this._dataContext.ConvertDateString( _GsCategory.CreatedDate), 
					"@UpdatedBy",  _GsCategory.UpdatedBy, 
					"@UpdatedDate", this._dataContext.ConvertDateString( _GsCategory.UpdatedDate), 
					"@RowStatus",  _GsCategory.RowStatus, 
					"@CountChild",  _GsCategory.CountChild, 
					"@CountProduct",  _GsCategory.CountProduct, 
					"@Id", _GsCategory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsCategory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsCategory> _GsCategorys)
		{
			foreach (GsCategory item in _GsCategorys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsCategory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsCategory _GsCategory, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsCategory] SET Id=@Id, Code=@Code, CategoryName=@CategoryName, Slug_Name=@Slug_Name, AutoSlug=@AutoSlug, FK_CategoryId=@FK_CategoryId, RankIndex=@RankIndex, SortIndex=@SortIndex, Tags=@Tags, KeyWord=@KeyWord, MetaData=@MetaData, Note=@Note, CreatedBy=@CreatedBy, CreatedDate=@CreatedDate, UpdatedBy=@UpdatedBy, UpdatedDate=@UpdatedDate, RowStatus=@RowStatus, CountChild=@CountChild, CountProduct=@CountProduct "+ condition, 
					"@Id",  _GsCategory.Id, 
					"@Code",  _GsCategory.Code, 
					"@CategoryName",  _GsCategory.CategoryName, 
					"@Slug_Name",  _GsCategory.Slug_Name, 
					"@AutoSlug",  _GsCategory.AutoSlug, 
					"@FK_CategoryId",  _GsCategory.FK_CategoryId, 
					"@RankIndex",  _GsCategory.RankIndex, 
					"@SortIndex",  _GsCategory.SortIndex, 
					"@Tags",  _GsCategory.Tags, 
					"@KeyWord",  _GsCategory.KeyWord, 
					"@MetaData",  _GsCategory.MetaData, 
					"@Note",  _GsCategory.Note, 
					"@CreatedBy",  _GsCategory.CreatedBy, 
					"@CreatedDate", this._dataContext.ConvertDateString( _GsCategory.CreatedDate), 
					"@UpdatedBy",  _GsCategory.UpdatedBy, 
					"@UpdatedDate", this._dataContext.ConvertDateString( _GsCategory.UpdatedDate), 
					"@RowStatus",  _GsCategory.RowStatus, 
					"@CountChild",  _GsCategory.CountChild, 
					"@CountProduct",  _GsCategory.CountProduct);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsCategory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCategory] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCategory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsCategory _GsCategory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCategory] WHERE Id=@Id",
					"@Id", _GsCategory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCategory trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsCategory] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsCategory trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsCategory> _GsCategorys)
		{
			foreach (GsCategory item in _GsCategorys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
