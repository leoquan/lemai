using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMAmnonclasshocvien:IMAmnonclasshocvien
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMAmnonclasshocvien(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MamNonClassHocVien từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonClassHocVien]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MamNonClassHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonClassHocVien] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MamNonClassHocVien từ Database
		/// </summary>
		public List<MamNonClassHocVien> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonClassHocVien]");
				List<MamNonClassHocVien> items = new List<MamNonClassHocVien>();
				MamNonClassHocVien item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonClassHocVien();
					if (dr["FK_MamNonClass"] != null && dr["FK_MamNonClass"] != DBNull.Value)
					{
						item.FK_MamNonClass = Convert.ToString(dr["FK_MamNonClass"]);
					}
					if (dr["FK_MamNonHocVien"] != null && dr["FK_MamNonHocVien"] != DBNull.Value)
					{
						item.FK_MamNonHocVien = Convert.ToString(dr["FK_MamNonHocVien"]);
					}
					if (dr["NgayThamGia"] != null && dr["NgayThamGia"] != DBNull.Value)
					{
						item.NgayThamGia = Convert.ToDateTime(dr["NgayThamGia"]);
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
		/// Lấy danh sách MamNonClassHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MamNonClassHocVien> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonClassHocVien] A "+ condition,  parameters);
				List<MamNonClassHocVien> items = new List<MamNonClassHocVien>();
				MamNonClassHocVien item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonClassHocVien();
					if (dr["FK_MamNonClass"] != null && dr["FK_MamNonClass"] != DBNull.Value)
					{
						item.FK_MamNonClass = Convert.ToString(dr["FK_MamNonClass"]);
					}
					if (dr["FK_MamNonHocVien"] != null && dr["FK_MamNonHocVien"] != DBNull.Value)
					{
						item.FK_MamNonHocVien = Convert.ToString(dr["FK_MamNonHocVien"]);
					}
					if (dr["NgayThamGia"] != null && dr["NgayThamGia"] != DBNull.Value)
					{
						item.NgayThamGia = Convert.ToDateTime(dr["NgayThamGia"]);
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

		public List<MamNonClassHocVien> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonClassHocVien] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MamNonClassHocVien] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MamNonClassHocVien>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MamNonClassHocVien từ Database
		/// </summary>
		public MamNonClassHocVien GetObject(string schema, String FK_MamNonClass, String FK_MamNonHocVien)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonClassHocVien] where FK_MamNonClass=@FK_MamNonClass and FK_MamNonHocVien=@FK_MamNonHocVien",
					"@FK_MamNonClass", FK_MamNonClass, 
					"@FK_MamNonHocVien", FK_MamNonHocVien);
				if (ds.Rows.Count > 0)
				{
					MamNonClassHocVien item=new MamNonClassHocVien();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_MamNonClass"] != null && dr["FK_MamNonClass"] != DBNull.Value)
						{
							item.FK_MamNonClass = Convert.ToString(dr["FK_MamNonClass"]);
						}
						if (dr["FK_MamNonHocVien"] != null && dr["FK_MamNonHocVien"] != DBNull.Value)
						{
							item.FK_MamNonHocVien = Convert.ToString(dr["FK_MamNonHocVien"]);
						}
						if (dr["NgayThamGia"] != null && dr["NgayThamGia"] != DBNull.Value)
						{
							item.NgayThamGia = Convert.ToDateTime(dr["NgayThamGia"]);
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
		/// Lấy một MamNonClassHocVien đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MamNonClassHocVien GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonClassHocVien] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MamNonClassHocVien item=new MamNonClassHocVien();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_MamNonClass"] != null && dr["FK_MamNonClass"] != DBNull.Value)
						{
							item.FK_MamNonClass = Convert.ToString(dr["FK_MamNonClass"]);
						}
						if (dr["FK_MamNonHocVien"] != null && dr["FK_MamNonHocVien"] != DBNull.Value)
						{
							item.FK_MamNonHocVien = Convert.ToString(dr["FK_MamNonHocVien"]);
						}
						if (dr["NgayThamGia"] != null && dr["NgayThamGia"] != DBNull.Value)
						{
							item.NgayThamGia = Convert.ToDateTime(dr["NgayThamGia"]);
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

		public MamNonClassHocVien GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonClassHocVien] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MamNonClassHocVien>(ds);
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
		/// Thêm mới MamNonClassHocVien vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MamNonClassHocVien _MamNonClassHocVien)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MamNonClassHocVien](FK_MamNonClass, FK_MamNonHocVien, NgayThamGia) VALUES(@FK_MamNonClass, @FK_MamNonHocVien, @NgayThamGia)", 
					"@FK_MamNonClass",  _MamNonClassHocVien.FK_MamNonClass, 
					"@FK_MamNonHocVien",  _MamNonClassHocVien.FK_MamNonHocVien, 
					"@NgayThamGia", this._dataContext.ConvertDateString( _MamNonClassHocVien.NgayThamGia));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MamNonClassHocVien vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MamNonClassHocVien> _MamNonClassHocViens)
		{
			foreach (MamNonClassHocVien item in _MamNonClassHocViens)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonClassHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MamNonClassHocVien _MamNonClassHocVien, String FK_MamNonClass, String FK_MamNonHocVien)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonClassHocVien] SET FK_MamNonClass=@FK_MamNonClass, FK_MamNonHocVien=@FK_MamNonHocVien, NgayThamGia=@NgayThamGia WHERE FK_MamNonClass=@FK_MamNonClass and FK_MamNonHocVien=@FK_MamNonHocVien", 
					"@FK_MamNonClass",  _MamNonClassHocVien.FK_MamNonClass, 
					"@FK_MamNonHocVien",  _MamNonClassHocVien.FK_MamNonHocVien, 
					"@NgayThamGia", this._dataContext.ConvertDateString( _MamNonClassHocVien.NgayThamGia), 
					"@FK_MamNonClass", FK_MamNonClass, 
					"@FK_MamNonHocVien", FK_MamNonHocVien);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MamNonClassHocVien vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MamNonClassHocVien _MamNonClassHocVien)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonClassHocVien] SET NgayThamGia=@NgayThamGia WHERE FK_MamNonClass=@FK_MamNonClass and FK_MamNonHocVien=@FK_MamNonHocVien", 
					"@NgayThamGia", this._dataContext.ConvertDateString( _MamNonClassHocVien.NgayThamGia), 
					"@FK_MamNonClass", _MamNonClassHocVien.FK_MamNonClass, 
					"@FK_MamNonHocVien", _MamNonClassHocVien.FK_MamNonHocVien);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MamNonClassHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MamNonClassHocVien> _MamNonClassHocViens)
		{
			foreach (MamNonClassHocVien item in _MamNonClassHocViens)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonClassHocVien vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MamNonClassHocVien _MamNonClassHocVien, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonClassHocVien] SET FK_MamNonClass=@FK_MamNonClass, FK_MamNonHocVien=@FK_MamNonHocVien, NgayThamGia=@NgayThamGia "+ condition, 
					"@FK_MamNonClass",  _MamNonClassHocVien.FK_MamNonClass, 
					"@FK_MamNonHocVien",  _MamNonClassHocVien.FK_MamNonHocVien, 
					"@NgayThamGia", this._dataContext.ConvertDateString( _MamNonClassHocVien.NgayThamGia));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MamNonClassHocVien trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_MamNonClass, String FK_MamNonHocVien)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonClassHocVien] WHERE FK_MamNonClass=@FK_MamNonClass and FK_MamNonHocVien=@FK_MamNonHocVien",
					"@FK_MamNonClass", FK_MamNonClass, 
					"@FK_MamNonHocVien", FK_MamNonHocVien);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonClassHocVien trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MamNonClassHocVien _MamNonClassHocVien)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonClassHocVien] WHERE FK_MamNonClass=@FK_MamNonClass and FK_MamNonHocVien=@FK_MamNonHocVien",
					"@FK_MamNonClass", _MamNonClassHocVien.FK_MamNonClass, 
					"@FK_MamNonHocVien", _MamNonClassHocVien.FK_MamNonHocVien);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonClassHocVien trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonClassHocVien] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonClassHocVien trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MamNonClassHocVien> _MamNonClassHocViens)
		{
			foreach (MamNonClassHocVien item in _MamNonClassHocViens)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
