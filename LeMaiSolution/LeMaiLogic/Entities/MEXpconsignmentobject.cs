using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpconsignmentobject:IEXpconsignmentobject
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpconsignmentobject(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpConsignmentObject từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentObject]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpConsignmentObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentObject] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpConsignmentObject từ Database
		/// </summary>
		public List<ExpConsignmentObject> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentObject]");
				List<ExpConsignmentObject> items = new List<ExpConsignmentObject>();
				ExpConsignmentObject item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentObject();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["FK_DonViHC"] != null && dr["FK_DonViHC"] != DBNull.Value)
					{
						item.FK_DonViHC = Convert.ToString(dr["FK_DonViHC"]);
					}
					if (dr["SoNha"] != null && dr["SoNha"] != DBNull.Value)
					{
						item.SoNha = Convert.ToString(dr["SoNha"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["IsProvider"] != null && dr["IsProvider"] != DBNull.Value)
					{
						item.IsProvider = Convert.ToBoolean(dr["IsProvider"]);
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
		/// Lấy danh sách ExpConsignmentObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpConsignmentObject> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentObject] A "+ condition,  parameters);
				List<ExpConsignmentObject> items = new List<ExpConsignmentObject>();
				ExpConsignmentObject item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentObject();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["FK_DonViHC"] != null && dr["FK_DonViHC"] != DBNull.Value)
					{
						item.FK_DonViHC = Convert.ToString(dr["FK_DonViHC"]);
					}
					if (dr["SoNha"] != null && dr["SoNha"] != DBNull.Value)
					{
						item.SoNha = Convert.ToString(dr["SoNha"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["IsProvider"] != null && dr["IsProvider"] != DBNull.Value)
					{
						item.IsProvider = Convert.ToBoolean(dr["IsProvider"]);
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

		public List<ExpConsignmentObject> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentObject] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentObject] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpConsignmentObject>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpConsignmentObject từ Database
		/// </summary>
		public ExpConsignmentObject GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentObject] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentObject item=new ExpConsignmentObject();
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
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["FK_DonViHC"] != null && dr["FK_DonViHC"] != DBNull.Value)
						{
							item.FK_DonViHC = Convert.ToString(dr["FK_DonViHC"]);
						}
						if (dr["SoNha"] != null && dr["SoNha"] != DBNull.Value)
						{
							item.SoNha = Convert.ToString(dr["SoNha"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["IsProvider"] != null && dr["IsProvider"] != DBNull.Value)
						{
							item.IsProvider = Convert.ToBoolean(dr["IsProvider"]);
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
		/// Lấy một ExpConsignmentObject đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpConsignmentObject GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentObject] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentObject item=new ExpConsignmentObject();
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
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["FK_DonViHC"] != null && dr["FK_DonViHC"] != DBNull.Value)
						{
							item.FK_DonViHC = Convert.ToString(dr["FK_DonViHC"]);
						}
						if (dr["SoNha"] != null && dr["SoNha"] != DBNull.Value)
						{
							item.SoNha = Convert.ToString(dr["SoNha"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["IsProvider"] != null && dr["IsProvider"] != DBNull.Value)
						{
							item.IsProvider = Convert.ToBoolean(dr["IsProvider"]);
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

		public ExpConsignmentObject GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentObject] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpConsignmentObject>(ds);
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
		/// Thêm mới ExpConsignmentObject vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpConsignmentObject _ExpConsignmentObject)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpConsignmentObject](Id, FullName, SoDienThoai, FK_DonViHC, SoNha, DiaChi, IsProvider) VALUES(@Id, @FullName, @SoDienThoai, @FK_DonViHC, @SoNha, @DiaChi, @IsProvider)", 
					"@Id",  _ExpConsignmentObject.Id, 
					"@FullName",  _ExpConsignmentObject.FullName, 
					"@SoDienThoai",  _ExpConsignmentObject.SoDienThoai, 
					"@FK_DonViHC",  _ExpConsignmentObject.FK_DonViHC, 
					"@SoNha",  _ExpConsignmentObject.SoNha, 
					"@DiaChi",  _ExpConsignmentObject.DiaChi, 
					"@IsProvider",  _ExpConsignmentObject.IsProvider);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentObject vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpConsignmentObject> _ExpConsignmentObjects)
		{
			foreach (ExpConsignmentObject item in _ExpConsignmentObjects)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpConsignmentObject _ExpConsignmentObject, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentObject] SET Id=@Id, FullName=@FullName, SoDienThoai=@SoDienThoai, FK_DonViHC=@FK_DonViHC, SoNha=@SoNha, DiaChi=@DiaChi, IsProvider=@IsProvider WHERE Id=@Id", 
					"@Id",  _ExpConsignmentObject.Id, 
					"@FullName",  _ExpConsignmentObject.FullName, 
					"@SoDienThoai",  _ExpConsignmentObject.SoDienThoai, 
					"@FK_DonViHC",  _ExpConsignmentObject.FK_DonViHC, 
					"@SoNha",  _ExpConsignmentObject.SoNha, 
					"@DiaChi",  _ExpConsignmentObject.DiaChi, 
					"@IsProvider",  _ExpConsignmentObject.IsProvider, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentObject vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpConsignmentObject _ExpConsignmentObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentObject] SET FullName=@FullName, SoDienThoai=@SoDienThoai, FK_DonViHC=@FK_DonViHC, SoNha=@SoNha, DiaChi=@DiaChi, IsProvider=@IsProvider WHERE Id=@Id", 
					"@FullName",  _ExpConsignmentObject.FullName, 
					"@SoDienThoai",  _ExpConsignmentObject.SoDienThoai, 
					"@FK_DonViHC",  _ExpConsignmentObject.FK_DonViHC, 
					"@SoNha",  _ExpConsignmentObject.SoNha, 
					"@DiaChi",  _ExpConsignmentObject.DiaChi, 
					"@IsProvider",  _ExpConsignmentObject.IsProvider, 
					"@Id", _ExpConsignmentObject.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpConsignmentObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpConsignmentObject> _ExpConsignmentObjects)
		{
			foreach (ExpConsignmentObject item in _ExpConsignmentObjects)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentObject vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpConsignmentObject _ExpConsignmentObject, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentObject] SET Id=@Id, FullName=@FullName, SoDienThoai=@SoDienThoai, FK_DonViHC=@FK_DonViHC, SoNha=@SoNha, DiaChi=@DiaChi, IsProvider=@IsProvider "+ condition, 
					"@Id",  _ExpConsignmentObject.Id, 
					"@FullName",  _ExpConsignmentObject.FullName, 
					"@SoDienThoai",  _ExpConsignmentObject.SoDienThoai, 
					"@FK_DonViHC",  _ExpConsignmentObject.FK_DonViHC, 
					"@SoNha",  _ExpConsignmentObject.SoNha, 
					"@DiaChi",  _ExpConsignmentObject.DiaChi, 
					"@IsProvider",  _ExpConsignmentObject.IsProvider);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpConsignmentObject trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentObject] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentObject trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpConsignmentObject _ExpConsignmentObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentObject] WHERE Id=@Id",
					"@Id", _ExpConsignmentObject.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentObject trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentObject] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentObject trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpConsignmentObject> _ExpConsignmentObjects)
		{
			foreach (ExpConsignmentObject item in _ExpConsignmentObjects)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
