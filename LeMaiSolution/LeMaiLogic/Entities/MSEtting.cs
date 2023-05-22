using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSEtting:ISEtting
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSEtting(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable Setting từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Setting]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable Setting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Setting] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách Setting từ Database
		/// </summary>
		public List<Setting> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Setting]");
				List<Setting> items = new List<Setting>();
				Setting item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Setting();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToString(dr["Value"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["IsManual"] != null && dr["IsManual"] != DBNull.Value)
					{
						item.IsManual = Convert.ToBoolean(dr["IsManual"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
					}
					if (dr["RowVersion"] != null && dr["RowVersion"] != DBNull.Value)
					{
						item.RowVersion = (System.Byte[])dr["RowVersion"];
					}
					if (dr["ImageSlug"] != null && dr["ImageSlug"] != DBNull.Value)
					{
						item.ImageSlug = Convert.ToString(dr["ImageSlug"]);
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
		/// Lấy danh sách Setting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<Setting> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Setting] A "+ condition,  parameters);
				List<Setting> items = new List<Setting>();
				Setting item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Setting();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToString(dr["Value"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["IsManual"] != null && dr["IsManual"] != DBNull.Value)
					{
						item.IsManual = Convert.ToBoolean(dr["IsManual"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
					}
					if (dr["RowVersion"] != null && dr["RowVersion"] != DBNull.Value)
					{
						item.RowVersion = (System.Byte[])dr["RowVersion"];
					}
					if (dr["ImageSlug"] != null && dr["ImageSlug"] != DBNull.Value)
					{
						item.ImageSlug = Convert.ToString(dr["ImageSlug"]);
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

		public List<Setting> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Setting] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[Setting] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<Setting>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một Setting từ Database
		/// </summary>
		public Setting GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Setting] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					Setting item=new Setting();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToString(dr["Value"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["IsManual"] != null && dr["IsManual"] != DBNull.Value)
						{
							item.IsManual = Convert.ToBoolean(dr["IsManual"]);
						}
						if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
						{
							item.GroupName = Convert.ToString(dr["GroupName"]);
						}
						if (dr["RowVersion"] != null && dr["RowVersion"] != DBNull.Value)
						{
							item.RowVersion = (System.Byte[])dr["RowVersion"];
						}
						if (dr["ImageSlug"] != null && dr["ImageSlug"] != DBNull.Value)
						{
							item.ImageSlug = Convert.ToString(dr["ImageSlug"]);
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
		/// Lấy một Setting đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public Setting GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Setting] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					Setting item=new Setting();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToString(dr["Value"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["IsManual"] != null && dr["IsManual"] != DBNull.Value)
						{
							item.IsManual = Convert.ToBoolean(dr["IsManual"]);
						}
						if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
						{
							item.GroupName = Convert.ToString(dr["GroupName"]);
						}
						if (dr["RowVersion"] != null && dr["RowVersion"] != DBNull.Value)
						{
							item.RowVersion = (System.Byte[])dr["RowVersion"];
						}
						if (dr["ImageSlug"] != null && dr["ImageSlug"] != DBNull.Value)
						{
							item.ImageSlug = Convert.ToString(dr["ImageSlug"]);
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

		public Setting GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Setting] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<Setting>(ds);
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
		/// Thêm mới Setting vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, Setting _Setting)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[Setting](Id, Value, Description, IsManual, GroupName, ImageSlug) VALUES(@Id, @Value, @Description, @IsManual, @GroupName, @ImageSlug)", 
					"@Id",  _Setting.Id, 
					"@Value",  _Setting.Value, 
					"@Description",  _Setting.Description, 
					"@IsManual",  _Setting.IsManual, 
					"@GroupName",  _Setting.GroupName, 
					"@ImageSlug",  _Setting.ImageSlug);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng Setting vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<Setting> _Settings)
		{
			foreach (Setting item in _Settings)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Thêm mới Setting vào Database kết quả trả về là giá trị của cột tự động tăng
		/// </summary>
		public int InsertReturnAutonumber(string schema, Setting _Setting)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("INSERT INTO " + schema + ".[Setting](Id, Value, Description, IsManual, GroupName, ImageSlug) VALUES(@Id, @Value, @Description, @IsManual, @GroupName, @ImageSlug)  returning RowVersion", 
					"@Id",  _Setting.Id, 
					"@Value",  _Setting.Value, 
					"@Description",  _Setting.Description, 
					"@IsManual",  _Setting.IsManual, 
					"@GroupName",  _Setting.GroupName, 
					"@ImageSlug",  _Setting.ImageSlug);
				return Int32.Parse(ds.Rows[0][0].ToString());
			}
			catch
			{
				return -1;
			}
		}
		/// <summary>
		/// Cập nhật Setting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, Setting _Setting, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Setting] SET Id=@Id, Value=@Value, Description=@Description, IsManual=@IsManual, GroupName=@GroupName, ImageSlug=@ImageSlug WHERE Id=@Id", 
					"@Id",  _Setting.Id, 
					"@Value",  _Setting.Value, 
					"@Description",  _Setting.Description, 
					"@IsManual",  _Setting.IsManual, 
					"@GroupName",  _Setting.GroupName, 
					"@ImageSlug",  _Setting.ImageSlug, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật Setting vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, Setting _Setting)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Setting] SET Value=@Value, Description=@Description, IsManual=@IsManual, GroupName=@GroupName, ImageSlug=@ImageSlug WHERE Id=@Id", 
					"@Value",  _Setting.Value, 
					"@Description",  _Setting.Description, 
					"@IsManual",  _Setting.IsManual, 
					"@GroupName",  _Setting.GroupName, 
					"@ImageSlug",  _Setting.ImageSlug, 
					"@Id", _Setting.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách Setting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<Setting> _Settings)
		{
			foreach (Setting item in _Settings)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Setting vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, Setting _Setting, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Setting] SET Id=@Id, Value=@Value, Description=@Description, IsManual=@IsManual, GroupName=@GroupName, ImageSlug=@ImageSlug "+ condition, 
					"@Id",  _Setting.Id, 
					"@Value",  _Setting.Value, 
					"@Description",  _Setting.Description, 
					"@IsManual",  _Setting.IsManual, 
					"@GroupName",  _Setting.GroupName, 
					"@ImageSlug",  _Setting.ImageSlug);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa Setting trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Setting] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Setting trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Setting _Setting)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Setting] WHERE Id=@Id",
					"@Id", _Setting.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Setting trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Setting] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Setting trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<Setting> _Settings)
		{
			foreach (Setting item in _Settings)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
