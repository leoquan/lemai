using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVCmathang:IVCmathang
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVCmathang(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VCMatHang từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCMatHang]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VCMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCMatHang] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VCMatHang từ Database
		/// </summary>
		public List<VCMatHang> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCMatHang]");
				List<VCMatHang> items = new List<VCMatHang>();
				VCMatHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCMatHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaHang"] != null && dr["MaHang"] != DBNull.Value)
					{
						item.MaHang = Convert.ToString(dr["MaHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["TenHangKD"] != null && dr["TenHangKD"] != DBNull.Value)
					{
						item.TenHangKD = Convert.ToString(dr["TenHangKD"]);
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
		/// Lấy danh sách VCMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VCMatHang> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCMatHang] A "+ condition,  parameters);
				List<VCMatHang> items = new List<VCMatHang>();
				VCMatHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCMatHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaHang"] != null && dr["MaHang"] != DBNull.Value)
					{
						item.MaHang = Convert.ToString(dr["MaHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["TenHangKD"] != null && dr["TenHangKD"] != DBNull.Value)
					{
						item.TenHangKD = Convert.ToString(dr["TenHangKD"]);
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

		public List<VCMatHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCMatHang] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VCMatHang] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VCMatHang>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VCMatHang từ Database
		/// </summary>
		public VCMatHang GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCMatHang] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					VCMatHang item=new VCMatHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaHang"] != null && dr["MaHang"] != DBNull.Value)
						{
							item.MaHang = Convert.ToString(dr["MaHang"]);
						}
						if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
						{
							item.TenHang = Convert.ToString(dr["TenHang"]);
						}
						if (dr["TenHangKD"] != null && dr["TenHangKD"] != DBNull.Value)
						{
							item.TenHangKD = Convert.ToString(dr["TenHangKD"]);
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
		/// Lấy một VCMatHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VCMatHang GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCMatHang] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VCMatHang item=new VCMatHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaHang"] != null && dr["MaHang"] != DBNull.Value)
						{
							item.MaHang = Convert.ToString(dr["MaHang"]);
						}
						if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
						{
							item.TenHang = Convert.ToString(dr["TenHang"]);
						}
						if (dr["TenHangKD"] != null && dr["TenHangKD"] != DBNull.Value)
						{
							item.TenHangKD = Convert.ToString(dr["TenHangKD"]);
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

		public VCMatHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCMatHang] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VCMatHang>(ds);
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
		/// Thêm mới VCMatHang vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VCMatHang _VCMatHang)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VCMatHang](Id, MaHang, TenHang, TenHangKD) VALUES(@Id, @MaHang, @TenHang, @TenHangKD)", 
					"@Id",  _VCMatHang.Id, 
					"@MaHang",  _VCMatHang.MaHang, 
					"@TenHang",  _VCMatHang.TenHang, 
					"@TenHangKD",  _VCMatHang.TenHangKD);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VCMatHang vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VCMatHang> _VCMatHangs)
		{
			foreach (VCMatHang item in _VCMatHangs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCMatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VCMatHang _VCMatHang, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCMatHang] SET Id=@Id, MaHang=@MaHang, TenHang=@TenHang, TenHangKD=@TenHangKD WHERE Id=@Id", 
					"@Id",  _VCMatHang.Id, 
					"@MaHang",  _VCMatHang.MaHang, 
					"@TenHang",  _VCMatHang.TenHang, 
					"@TenHangKD",  _VCMatHang.TenHangKD, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VCMatHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VCMatHang _VCMatHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCMatHang] SET MaHang=@MaHang, TenHang=@TenHang, TenHangKD=@TenHangKD WHERE Id=@Id", 
					"@MaHang",  _VCMatHang.MaHang, 
					"@TenHang",  _VCMatHang.TenHang, 
					"@TenHangKD",  _VCMatHang.TenHangKD, 
					"@Id", _VCMatHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VCMatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VCMatHang> _VCMatHangs)
		{
			foreach (VCMatHang item in _VCMatHangs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCMatHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VCMatHang _VCMatHang, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCMatHang] SET Id=@Id, MaHang=@MaHang, TenHang=@TenHang, TenHangKD=@TenHangKD "+ condition, 
					"@Id",  _VCMatHang.Id, 
					"@MaHang",  _VCMatHang.MaHang, 
					"@TenHang",  _VCMatHang.TenHang, 
					"@TenHangKD",  _VCMatHang.TenHangKD);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VCMatHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCMatHang] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCMatHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VCMatHang _VCMatHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCMatHang] WHERE Id=@Id",
					"@Id", _VCMatHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCMatHang trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCMatHang] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCMatHang trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VCMatHang> _VCMatHangs)
		{
			foreach (VCMatHang item in _VCMatHangs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
