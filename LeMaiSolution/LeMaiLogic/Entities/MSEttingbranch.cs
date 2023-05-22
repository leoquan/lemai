using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSEttingbranch:ISEttingbranch
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSEttingbranch(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SettingBranch từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SettingBranch]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SettingBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SettingBranch] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SettingBranch từ Database
		/// </summary>
		public List<SettingBranch> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SettingBranch]");
				List<SettingBranch> items = new List<SettingBranch>();
				SettingBranch item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SettingBranch();
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
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
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
		/// Lấy danh sách SettingBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SettingBranch> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SettingBranch] A "+ condition,  parameters);
				List<SettingBranch> items = new List<SettingBranch>();
				SettingBranch item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SettingBranch();
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
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
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

		public List<SettingBranch> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SettingBranch] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SettingBranch] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SettingBranch>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SettingBranch từ Database
		/// </summary>
		public SettingBranch GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SettingBranch] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SettingBranch item=new SettingBranch();
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
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
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
		/// Lấy một SettingBranch đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SettingBranch GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SettingBranch] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SettingBranch item=new SettingBranch();
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
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
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

		public SettingBranch GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SettingBranch] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SettingBranch>(ds);
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
		/// Thêm mới SettingBranch vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SettingBranch _SettingBranch)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SettingBranch](Id, Value, Description, IsManual, GroupName, ImageSlug, FK_Branch) VALUES(@Id, @Value, @Description, @IsManual, @GroupName, @ImageSlug, @FK_Branch)", 
					"@Id",  _SettingBranch.Id, 
					"@Value",  _SettingBranch.Value, 
					"@Description",  _SettingBranch.Description, 
					"@IsManual",  _SettingBranch.IsManual, 
					"@GroupName",  _SettingBranch.GroupName, 
					"@ImageSlug",  _SettingBranch.ImageSlug, 
					"@FK_Branch",  _SettingBranch.FK_Branch);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SettingBranch vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SettingBranch> _SettingBranchs)
		{
			foreach (SettingBranch item in _SettingBranchs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Thêm mới SettingBranch vào Database kết quả trả về là giá trị của cột tự động tăng
		/// </summary>
		public int InsertReturnAutonumber(string schema, SettingBranch _SettingBranch)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("INSERT INTO " + schema + ".[SettingBranch](Id, Value, Description, IsManual, GroupName, ImageSlug, FK_Branch) VALUES(@Id, @Value, @Description, @IsManual, @GroupName, @ImageSlug, @FK_Branch)  returning RowVersion", 
					"@Id",  _SettingBranch.Id, 
					"@Value",  _SettingBranch.Value, 
					"@Description",  _SettingBranch.Description, 
					"@IsManual",  _SettingBranch.IsManual, 
					"@GroupName",  _SettingBranch.GroupName, 
					"@ImageSlug",  _SettingBranch.ImageSlug, 
					"@FK_Branch",  _SettingBranch.FK_Branch);
				return Int32.Parse(ds.Rows[0][0].ToString());
			}
			catch
			{
				return -1;
			}
		}
		/// <summary>
		/// Cập nhật SettingBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SettingBranch _SettingBranch, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SettingBranch] SET Id=@Id, Value=@Value, Description=@Description, IsManual=@IsManual, GroupName=@GroupName, ImageSlug=@ImageSlug, FK_Branch=@FK_Branch WHERE Id=@Id", 
					"@Id",  _SettingBranch.Id, 
					"@Value",  _SettingBranch.Value, 
					"@Description",  _SettingBranch.Description, 
					"@IsManual",  _SettingBranch.IsManual, 
					"@GroupName",  _SettingBranch.GroupName, 
					"@ImageSlug",  _SettingBranch.ImageSlug, 
					"@FK_Branch",  _SettingBranch.FK_Branch, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SettingBranch vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SettingBranch _SettingBranch)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SettingBranch] SET Value=@Value, Description=@Description, IsManual=@IsManual, GroupName=@GroupName, ImageSlug=@ImageSlug, FK_Branch=@FK_Branch WHERE Id=@Id", 
					"@Value",  _SettingBranch.Value, 
					"@Description",  _SettingBranch.Description, 
					"@IsManual",  _SettingBranch.IsManual, 
					"@GroupName",  _SettingBranch.GroupName, 
					"@ImageSlug",  _SettingBranch.ImageSlug, 
					"@FK_Branch",  _SettingBranch.FK_Branch, 
					"@Id", _SettingBranch.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SettingBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SettingBranch> _SettingBranchs)
		{
			foreach (SettingBranch item in _SettingBranchs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SettingBranch vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SettingBranch _SettingBranch, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SettingBranch] SET Id=@Id, Value=@Value, Description=@Description, IsManual=@IsManual, GroupName=@GroupName, ImageSlug=@ImageSlug, FK_Branch=@FK_Branch "+ condition, 
					"@Id",  _SettingBranch.Id, 
					"@Value",  _SettingBranch.Value, 
					"@Description",  _SettingBranch.Description, 
					"@IsManual",  _SettingBranch.IsManual, 
					"@GroupName",  _SettingBranch.GroupName, 
					"@ImageSlug",  _SettingBranch.ImageSlug, 
					"@FK_Branch",  _SettingBranch.FK_Branch);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SettingBranch trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SettingBranch] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SettingBranch trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SettingBranch _SettingBranch)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SettingBranch] WHERE Id=@Id",
					"@Id", _SettingBranch.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SettingBranch trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SettingBranch] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SettingBranch trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SettingBranch> _SettingBranchs)
		{
			foreach (SettingBranch item in _SettingBranchs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
