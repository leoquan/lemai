using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSAlebalancedetail:ISAlebalancedetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSAlebalancedetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SaleBalanceDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBalanceDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SaleBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBalanceDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SaleBalanceDetail từ Database
		/// </summary>
		public List<SaleBalanceDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBalanceDetail]");
				List<SaleBalanceDetail> items = new List<SaleBalanceDetail>();
				SaleBalanceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleBalanceDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaHoaDon"] != null && dr["MaHoaDon"] != DBNull.Value)
					{
						item.MaHoaDon = Convert.ToString(dr["MaHoaDon"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToInt32(dr["SoTien"]);
					}
					if (dr["GiaTriTruoc"] != null && dr["GiaTriTruoc"] != DBNull.Value)
					{
						item.GiaTriTruoc = Convert.ToInt32(dr["GiaTriTruoc"]);
					}
					if (dr["GiaTriSau"] != null && dr["GiaTriSau"] != DBNull.Value)
					{
						item.GiaTriSau = Convert.ToInt32(dr["GiaTriSau"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
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
		/// Lấy danh sách SaleBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SaleBalanceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleBalanceDetail] A "+ condition,  parameters);
				List<SaleBalanceDetail> items = new List<SaleBalanceDetail>();
				SaleBalanceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleBalanceDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaHoaDon"] != null && dr["MaHoaDon"] != DBNull.Value)
					{
						item.MaHoaDon = Convert.ToString(dr["MaHoaDon"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToInt32(dr["SoTien"]);
					}
					if (dr["GiaTriTruoc"] != null && dr["GiaTriTruoc"] != DBNull.Value)
					{
						item.GiaTriTruoc = Convert.ToInt32(dr["GiaTriTruoc"]);
					}
					if (dr["GiaTriSau"] != null && dr["GiaTriSau"] != DBNull.Value)
					{
						item.GiaTriSau = Convert.ToInt32(dr["GiaTriSau"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
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

		public List<SaleBalanceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleBalanceDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SaleBalanceDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SaleBalanceDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SaleBalanceDetail từ Database
		/// </summary>
		public SaleBalanceDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBalanceDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SaleBalanceDetail item=new SaleBalanceDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaHoaDon"] != null && dr["MaHoaDon"] != DBNull.Value)
						{
							item.MaHoaDon = Convert.ToString(dr["MaHoaDon"]);
						}
						if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
						{
							item.SoTien = Convert.ToInt32(dr["SoTien"]);
						}
						if (dr["GiaTriTruoc"] != null && dr["GiaTriTruoc"] != DBNull.Value)
						{
							item.GiaTriTruoc = Convert.ToInt32(dr["GiaTriTruoc"]);
						}
						if (dr["GiaTriSau"] != null && dr["GiaTriSau"] != DBNull.Value)
						{
							item.GiaTriSau = Convert.ToInt32(dr["GiaTriSau"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
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
		/// Lấy một SaleBalanceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SaleBalanceDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleBalanceDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SaleBalanceDetail item=new SaleBalanceDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaHoaDon"] != null && dr["MaHoaDon"] != DBNull.Value)
						{
							item.MaHoaDon = Convert.ToString(dr["MaHoaDon"]);
						}
						if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
						{
							item.SoTien = Convert.ToInt32(dr["SoTien"]);
						}
						if (dr["GiaTriTruoc"] != null && dr["GiaTriTruoc"] != DBNull.Value)
						{
							item.GiaTriTruoc = Convert.ToInt32(dr["GiaTriTruoc"]);
						}
						if (dr["GiaTriSau"] != null && dr["GiaTriSau"] != DBNull.Value)
						{
							item.GiaTriSau = Convert.ToInt32(dr["GiaTriSau"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
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

		public SaleBalanceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleBalanceDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SaleBalanceDetail>(ds);
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
		/// Thêm mới SaleBalanceDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SaleBalanceDetail _SaleBalanceDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SaleBalanceDetail](Id, MaHoaDon, SoTien, GiaTriTruoc, GiaTriSau, GhiChu) VALUES(@Id, @MaHoaDon, @SoTien, @GiaTriTruoc, @GiaTriSau, @GhiChu)", 
					"@Id",  _SaleBalanceDetail.Id, 
					"@MaHoaDon",  _SaleBalanceDetail.MaHoaDon, 
					"@SoTien",  _SaleBalanceDetail.SoTien, 
					"@GiaTriTruoc",  _SaleBalanceDetail.GiaTriTruoc, 
					"@GiaTriSau",  _SaleBalanceDetail.GiaTriSau, 
					"@GhiChu",  _SaleBalanceDetail.GhiChu);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SaleBalanceDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SaleBalanceDetail> _SaleBalanceDetails)
		{
			foreach (SaleBalanceDetail item in _SaleBalanceDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SaleBalanceDetail _SaleBalanceDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleBalanceDetail] SET Id=@Id, MaHoaDon=@MaHoaDon, SoTien=@SoTien, GiaTriTruoc=@GiaTriTruoc, GiaTriSau=@GiaTriSau, GhiChu=@GhiChu WHERE Id=@Id", 
					"@Id",  _SaleBalanceDetail.Id, 
					"@MaHoaDon",  _SaleBalanceDetail.MaHoaDon, 
					"@SoTien",  _SaleBalanceDetail.SoTien, 
					"@GiaTriTruoc",  _SaleBalanceDetail.GiaTriTruoc, 
					"@GiaTriSau",  _SaleBalanceDetail.GiaTriSau, 
					"@GhiChu",  _SaleBalanceDetail.GhiChu, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SaleBalanceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SaleBalanceDetail _SaleBalanceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleBalanceDetail] SET MaHoaDon=@MaHoaDon, SoTien=@SoTien, GiaTriTruoc=@GiaTriTruoc, GiaTriSau=@GiaTriSau, GhiChu=@GhiChu WHERE Id=@Id", 
					"@MaHoaDon",  _SaleBalanceDetail.MaHoaDon, 
					"@SoTien",  _SaleBalanceDetail.SoTien, 
					"@GiaTriTruoc",  _SaleBalanceDetail.GiaTriTruoc, 
					"@GiaTriSau",  _SaleBalanceDetail.GiaTriSau, 
					"@GhiChu",  _SaleBalanceDetail.GhiChu, 
					"@Id", _SaleBalanceDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SaleBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SaleBalanceDetail> _SaleBalanceDetails)
		{
			foreach (SaleBalanceDetail item in _SaleBalanceDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleBalanceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SaleBalanceDetail _SaleBalanceDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleBalanceDetail] SET Id=@Id, MaHoaDon=@MaHoaDon, SoTien=@SoTien, GiaTriTruoc=@GiaTriTruoc, GiaTriSau=@GiaTriSau, GhiChu=@GhiChu "+ condition, 
					"@Id",  _SaleBalanceDetail.Id, 
					"@MaHoaDon",  _SaleBalanceDetail.MaHoaDon, 
					"@SoTien",  _SaleBalanceDetail.SoTien, 
					"@GiaTriTruoc",  _SaleBalanceDetail.GiaTriTruoc, 
					"@GiaTriSau",  _SaleBalanceDetail.GiaTriSau, 
					"@GhiChu",  _SaleBalanceDetail.GhiChu);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SaleBalanceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleBalanceDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleBalanceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SaleBalanceDetail _SaleBalanceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleBalanceDetail] WHERE Id=@Id",
					"@Id", _SaleBalanceDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleBalanceDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleBalanceDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleBalanceDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SaleBalanceDetail> _SaleBalanceDetails)
		{
			foreach (SaleBalanceDetail item in _SaleBalanceDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
