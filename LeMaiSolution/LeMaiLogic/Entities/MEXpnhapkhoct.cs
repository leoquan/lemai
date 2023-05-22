using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpnhapkhoct:IEXpnhapkhoct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpnhapkhoct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpNhapKhoCt từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNhapKhoCt]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpNhapKhoCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNhapKhoCt] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpNhapKhoCt từ Database
		/// </summary>
		public List<ExpNhapKhoCt> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNhapKhoCt]");
				List<ExpNhapKhoCt> items = new List<ExpNhapKhoCt>();
				ExpNhapKhoCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpNhapKhoCt();
					if (dr["FK_NhapKho"] != null && dr["FK_NhapKho"] != DBNull.Value)
					{
						item.FK_NhapKho = Convert.ToString(dr["FK_NhapKho"]);
					}
					if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
					{
						item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToDecimal(dr["DonGia"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
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
		/// Lấy danh sách ExpNhapKhoCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpNhapKhoCt> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpNhapKhoCt] A "+ condition,  parameters);
				List<ExpNhapKhoCt> items = new List<ExpNhapKhoCt>();
				ExpNhapKhoCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpNhapKhoCt();
					if (dr["FK_NhapKho"] != null && dr["FK_NhapKho"] != DBNull.Value)
					{
						item.FK_NhapKho = Convert.ToString(dr["FK_NhapKho"]);
					}
					if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
					{
						item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToDecimal(dr["DonGia"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
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

		public List<ExpNhapKhoCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpNhapKhoCt] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpNhapKhoCt] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpNhapKhoCt>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpNhapKhoCt từ Database
		/// </summary>
		public ExpNhapKhoCt GetObject(string schema, String FK_NhapKho, String FK_VatTu)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpNhapKhoCt] where FK_NhapKho=@FK_NhapKho and FK_VatTu=@FK_VatTu",
					"@FK_NhapKho", FK_NhapKho, 
					"@FK_VatTu", FK_VatTu);
				if (ds.Rows.Count > 0)
				{
					ExpNhapKhoCt item=new ExpNhapKhoCt();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_NhapKho"] != null && dr["FK_NhapKho"] != DBNull.Value)
						{
							item.FK_NhapKho = Convert.ToString(dr["FK_NhapKho"]);
						}
						if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
						{
							item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToDecimal(dr["DonGia"]);
						}
						if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
						{
							item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
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
		/// Lấy một ExpNhapKhoCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpNhapKhoCt GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpNhapKhoCt] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpNhapKhoCt item=new ExpNhapKhoCt();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_NhapKho"] != null && dr["FK_NhapKho"] != DBNull.Value)
						{
							item.FK_NhapKho = Convert.ToString(dr["FK_NhapKho"]);
						}
						if (dr["FK_VatTu"] != null && dr["FK_VatTu"] != DBNull.Value)
						{
							item.FK_VatTu = Convert.ToString(dr["FK_VatTu"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToDecimal(dr["DonGia"]);
						}
						if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
						{
							item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
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

		public ExpNhapKhoCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpNhapKhoCt] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpNhapKhoCt>(ds);
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
		/// Thêm mới ExpNhapKhoCt vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpNhapKhoCt _ExpNhapKhoCt)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpNhapKhoCt](FK_NhapKho, FK_VatTu, SoLuong, DonGia, ThanhTien) VALUES(@FK_NhapKho, @FK_VatTu, @SoLuong, @DonGia, @ThanhTien)", 
					"@FK_NhapKho",  _ExpNhapKhoCt.FK_NhapKho, 
					"@FK_VatTu",  _ExpNhapKhoCt.FK_VatTu, 
					"@SoLuong",  _ExpNhapKhoCt.SoLuong, 
					"@DonGia",  _ExpNhapKhoCt.DonGia, 
					"@ThanhTien",  _ExpNhapKhoCt.ThanhTien);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpNhapKhoCt vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpNhapKhoCt> _ExpNhapKhoCts)
		{
			foreach (ExpNhapKhoCt item in _ExpNhapKhoCts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpNhapKhoCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpNhapKhoCt _ExpNhapKhoCt, String FK_NhapKho, String FK_VatTu)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpNhapKhoCt] SET FK_NhapKho=@FK_NhapKho, FK_VatTu=@FK_VatTu, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien WHERE FK_NhapKho=@FK_NhapKho and FK_VatTu=@FK_VatTu", 
					"@FK_NhapKho",  _ExpNhapKhoCt.FK_NhapKho, 
					"@FK_VatTu",  _ExpNhapKhoCt.FK_VatTu, 
					"@SoLuong",  _ExpNhapKhoCt.SoLuong, 
					"@DonGia",  _ExpNhapKhoCt.DonGia, 
					"@ThanhTien",  _ExpNhapKhoCt.ThanhTien, 
					"@FK_NhapKho", FK_NhapKho, 
					"@FK_VatTu", FK_VatTu);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpNhapKhoCt vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpNhapKhoCt _ExpNhapKhoCt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpNhapKhoCt] SET SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien WHERE FK_NhapKho=@FK_NhapKho and FK_VatTu=@FK_VatTu", 
					"@SoLuong",  _ExpNhapKhoCt.SoLuong, 
					"@DonGia",  _ExpNhapKhoCt.DonGia, 
					"@ThanhTien",  _ExpNhapKhoCt.ThanhTien, 
					"@FK_NhapKho", _ExpNhapKhoCt.FK_NhapKho, 
					"@FK_VatTu", _ExpNhapKhoCt.FK_VatTu);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpNhapKhoCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpNhapKhoCt> _ExpNhapKhoCts)
		{
			foreach (ExpNhapKhoCt item in _ExpNhapKhoCts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpNhapKhoCt vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpNhapKhoCt _ExpNhapKhoCt, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpNhapKhoCt] SET FK_NhapKho=@FK_NhapKho, FK_VatTu=@FK_VatTu, SoLuong=@SoLuong, DonGia=@DonGia, ThanhTien=@ThanhTien "+ condition, 
					"@FK_NhapKho",  _ExpNhapKhoCt.FK_NhapKho, 
					"@FK_VatTu",  _ExpNhapKhoCt.FK_VatTu, 
					"@SoLuong",  _ExpNhapKhoCt.SoLuong, 
					"@DonGia",  _ExpNhapKhoCt.DonGia, 
					"@ThanhTien",  _ExpNhapKhoCt.ThanhTien);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpNhapKhoCt trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_NhapKho, String FK_VatTu)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpNhapKhoCt] WHERE FK_NhapKho=@FK_NhapKho and FK_VatTu=@FK_VatTu",
					"@FK_NhapKho", FK_NhapKho, 
					"@FK_VatTu", FK_VatTu);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpNhapKhoCt trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpNhapKhoCt _ExpNhapKhoCt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpNhapKhoCt] WHERE FK_NhapKho=@FK_NhapKho and FK_VatTu=@FK_VatTu",
					"@FK_NhapKho", _ExpNhapKhoCt.FK_NhapKho, 
					"@FK_VatTu", _ExpNhapKhoCt.FK_VatTu);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpNhapKhoCt trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpNhapKhoCt] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpNhapKhoCt trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpNhapKhoCt> _ExpNhapKhoCts)
		{
			foreach (ExpNhapKhoCt item in _ExpNhapKhoCts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
