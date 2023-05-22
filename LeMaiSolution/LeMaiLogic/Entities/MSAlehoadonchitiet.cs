using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSAlehoadonchitiet:ISAlehoadonchitiet
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSAlehoadonchitiet(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SaleHoaDonChiTiet từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleHoaDonChiTiet]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SaleHoaDonChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleHoaDonChiTiet] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SaleHoaDonChiTiet từ Database
		/// </summary>
		public List<SaleHoaDonChiTiet> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleHoaDonChiTiet]");
				List<SaleHoaDonChiTiet> items = new List<SaleHoaDonChiTiet>();
				SaleHoaDonChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleHoaDonChiTiet();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
					{
						item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
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
		/// Lấy danh sách SaleHoaDonChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SaleHoaDonChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleHoaDonChiTiet] A "+ condition,  parameters);
				List<SaleHoaDonChiTiet> items = new List<SaleHoaDonChiTiet>();
				SaleHoaDonChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleHoaDonChiTiet();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
					{
						item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
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

		public List<SaleHoaDonChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleHoaDonChiTiet] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SaleHoaDonChiTiet] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SaleHoaDonChiTiet>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SaleHoaDonChiTiet từ Database
		/// </summary>
		public SaleHoaDonChiTiet GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleHoaDonChiTiet] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SaleHoaDonChiTiet item=new SaleHoaDonChiTiet();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
						{
							item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
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
		/// Lấy một SaleHoaDonChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SaleHoaDonChiTiet GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleHoaDonChiTiet] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SaleHoaDonChiTiet item=new SaleHoaDonChiTiet();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
						{
							item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
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

		public SaleHoaDonChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleHoaDonChiTiet] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SaleHoaDonChiTiet>(ds);
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
		/// Thêm mới SaleHoaDonChiTiet vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SaleHoaDonChiTiet _SaleHoaDonChiTiet)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SaleHoaDonChiTiet](Id, FK_SanPham) VALUES(@Id, @FK_SanPham)", 
					"@Id",  _SaleHoaDonChiTiet.Id, 
					"@FK_SanPham",  _SaleHoaDonChiTiet.FK_SanPham);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SaleHoaDonChiTiet vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SaleHoaDonChiTiet> _SaleHoaDonChiTiets)
		{
			foreach (SaleHoaDonChiTiet item in _SaleHoaDonChiTiets)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleHoaDonChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SaleHoaDonChiTiet _SaleHoaDonChiTiet, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleHoaDonChiTiet] SET Id=@Id, FK_SanPham=@FK_SanPham WHERE Id=@Id", 
					"@Id",  _SaleHoaDonChiTiet.Id, 
					"@FK_SanPham",  _SaleHoaDonChiTiet.FK_SanPham, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SaleHoaDonChiTiet vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SaleHoaDonChiTiet _SaleHoaDonChiTiet)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleHoaDonChiTiet] SET FK_SanPham=@FK_SanPham WHERE Id=@Id", 
					"@FK_SanPham",  _SaleHoaDonChiTiet.FK_SanPham, 
					"@Id", _SaleHoaDonChiTiet.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SaleHoaDonChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SaleHoaDonChiTiet> _SaleHoaDonChiTiets)
		{
			foreach (SaleHoaDonChiTiet item in _SaleHoaDonChiTiets)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleHoaDonChiTiet vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SaleHoaDonChiTiet _SaleHoaDonChiTiet, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleHoaDonChiTiet] SET Id=@Id, FK_SanPham=@FK_SanPham "+ condition, 
					"@Id",  _SaleHoaDonChiTiet.Id, 
					"@FK_SanPham",  _SaleHoaDonChiTiet.FK_SanPham);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SaleHoaDonChiTiet trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleHoaDonChiTiet] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleHoaDonChiTiet trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SaleHoaDonChiTiet _SaleHoaDonChiTiet)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleHoaDonChiTiet] WHERE Id=@Id",
					"@Id", _SaleHoaDonChiTiet.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleHoaDonChiTiet trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleHoaDonChiTiet] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleHoaDonChiTiet trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SaleHoaDonChiTiet> _SaleHoaDonChiTiets)
		{
			foreach (SaleHoaDonChiTiet item in _SaleHoaDonChiTiets)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
