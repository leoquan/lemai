using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdphieunhanbenhchitiet:IMEdphieunhanbenhchitiet
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdphieunhanbenhchitiet(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedPhieuNhanBenhChiTiet từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedPhieuNhanBenhChiTiet]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedPhieuNhanBenhChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedPhieuNhanBenhChiTiet] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedPhieuNhanBenhChiTiet từ Database
		/// </summary>
		public List<MedPhieuNhanBenhChiTiet> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedPhieuNhanBenhChiTiet]");
				List<MedPhieuNhanBenhChiTiet> items = new List<MedPhieuNhanBenhChiTiet>();
				MedPhieuNhanBenhChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedPhieuNhanBenhChiTiet();
					if (dr["id_phieunhanbenh"] != null && dr["id_phieunhanbenh"] != DBNull.Value)
					{
						item.id_phieunhanbenh = Convert.ToString(dr["id_phieunhanbenh"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
					{
						item.id_vienphi = Convert.ToDecimal(dr["id_vienphi"]);
					}
					if (dr["mavienphi"] != null && dr["mavienphi"] != DBNull.Value)
					{
						item.mavienphi = Convert.ToString(dr["mavienphi"]);
					}
					if (dr["tenvienphi"] != null && dr["tenvienphi"] != DBNull.Value)
					{
						item.tenvienphi = Convert.ToString(dr["tenvienphi"]);
					}
					if (dr["dvttinh"] != null && dr["dvttinh"] != DBNull.Value)
					{
						item.dvttinh = Convert.ToString(dr["dvttinh"]);
					}
					if (dr["dongia"] != null && dr["dongia"] != DBNull.Value)
					{
						item.dongia = Convert.ToInt32(dr["dongia"]);
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
		/// Lấy danh sách MedPhieuNhanBenhChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedPhieuNhanBenhChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedPhieuNhanBenhChiTiet] A "+ condition,  parameters);
				List<MedPhieuNhanBenhChiTiet> items = new List<MedPhieuNhanBenhChiTiet>();
				MedPhieuNhanBenhChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedPhieuNhanBenhChiTiet();
					if (dr["id_phieunhanbenh"] != null && dr["id_phieunhanbenh"] != DBNull.Value)
					{
						item.id_phieunhanbenh = Convert.ToString(dr["id_phieunhanbenh"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
					{
						item.id_vienphi = Convert.ToDecimal(dr["id_vienphi"]);
					}
					if (dr["mavienphi"] != null && dr["mavienphi"] != DBNull.Value)
					{
						item.mavienphi = Convert.ToString(dr["mavienphi"]);
					}
					if (dr["tenvienphi"] != null && dr["tenvienphi"] != DBNull.Value)
					{
						item.tenvienphi = Convert.ToString(dr["tenvienphi"]);
					}
					if (dr["dvttinh"] != null && dr["dvttinh"] != DBNull.Value)
					{
						item.dvttinh = Convert.ToString(dr["dvttinh"]);
					}
					if (dr["dongia"] != null && dr["dongia"] != DBNull.Value)
					{
						item.dongia = Convert.ToInt32(dr["dongia"]);
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

		public List<MedPhieuNhanBenhChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedPhieuNhanBenhChiTiet] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedPhieuNhanBenhChiTiet] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedPhieuNhanBenhChiTiet>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedPhieuNhanBenhChiTiet từ Database
		/// </summary>
		public MedPhieuNhanBenhChiTiet GetObject(string schema, String id_phieunhanbenh, Int32 stt)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedPhieuNhanBenhChiTiet] where id_phieunhanbenh=@id_phieunhanbenh and stt=@stt",
					"@id_phieunhanbenh", id_phieunhanbenh, 
					"@stt", stt);
				if (ds.Rows.Count > 0)
				{
					MedPhieuNhanBenhChiTiet item=new MedPhieuNhanBenhChiTiet();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id_phieunhanbenh"] != null && dr["id_phieunhanbenh"] != DBNull.Value)
						{
							item.id_phieunhanbenh = Convert.ToString(dr["id_phieunhanbenh"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
						{
							item.id_vienphi = Convert.ToDecimal(dr["id_vienphi"]);
						}
						if (dr["mavienphi"] != null && dr["mavienphi"] != DBNull.Value)
						{
							item.mavienphi = Convert.ToString(dr["mavienphi"]);
						}
						if (dr["tenvienphi"] != null && dr["tenvienphi"] != DBNull.Value)
						{
							item.tenvienphi = Convert.ToString(dr["tenvienphi"]);
						}
						if (dr["dvttinh"] != null && dr["dvttinh"] != DBNull.Value)
						{
							item.dvttinh = Convert.ToString(dr["dvttinh"]);
						}
						if (dr["dongia"] != null && dr["dongia"] != DBNull.Value)
						{
							item.dongia = Convert.ToInt32(dr["dongia"]);
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
		/// Lấy một MedPhieuNhanBenhChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedPhieuNhanBenhChiTiet GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedPhieuNhanBenhChiTiet] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedPhieuNhanBenhChiTiet item=new MedPhieuNhanBenhChiTiet();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id_phieunhanbenh"] != null && dr["id_phieunhanbenh"] != DBNull.Value)
						{
							item.id_phieunhanbenh = Convert.ToString(dr["id_phieunhanbenh"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
						{
							item.id_vienphi = Convert.ToDecimal(dr["id_vienphi"]);
						}
						if (dr["mavienphi"] != null && dr["mavienphi"] != DBNull.Value)
						{
							item.mavienphi = Convert.ToString(dr["mavienphi"]);
						}
						if (dr["tenvienphi"] != null && dr["tenvienphi"] != DBNull.Value)
						{
							item.tenvienphi = Convert.ToString(dr["tenvienphi"]);
						}
						if (dr["dvttinh"] != null && dr["dvttinh"] != DBNull.Value)
						{
							item.dvttinh = Convert.ToString(dr["dvttinh"]);
						}
						if (dr["dongia"] != null && dr["dongia"] != DBNull.Value)
						{
							item.dongia = Convert.ToInt32(dr["dongia"]);
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

		public MedPhieuNhanBenhChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedPhieuNhanBenhChiTiet] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedPhieuNhanBenhChiTiet>(ds);
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
		/// Thêm mới MedPhieuNhanBenhChiTiet vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedPhieuNhanBenhChiTiet _MedPhieuNhanBenhChiTiet)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedPhieuNhanBenhChiTiet](id_phieunhanbenh, stt, id_vienphi, mavienphi, tenvienphi, dvttinh, dongia) VALUES(@id_phieunhanbenh, @stt, @id_vienphi, @mavienphi, @tenvienphi, @dvttinh, @dongia)", 
					"@id_phieunhanbenh",  _MedPhieuNhanBenhChiTiet.id_phieunhanbenh, 
					"@stt",  _MedPhieuNhanBenhChiTiet.stt, 
					"@id_vienphi",  _MedPhieuNhanBenhChiTiet.id_vienphi, 
					"@mavienphi",  _MedPhieuNhanBenhChiTiet.mavienphi, 
					"@tenvienphi",  _MedPhieuNhanBenhChiTiet.tenvienphi, 
					"@dvttinh",  _MedPhieuNhanBenhChiTiet.dvttinh, 
					"@dongia",  _MedPhieuNhanBenhChiTiet.dongia);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedPhieuNhanBenhChiTiet vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedPhieuNhanBenhChiTiet> _MedPhieuNhanBenhChiTiets)
		{
			foreach (MedPhieuNhanBenhChiTiet item in _MedPhieuNhanBenhChiTiets)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedPhieuNhanBenhChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedPhieuNhanBenhChiTiet _MedPhieuNhanBenhChiTiet, String id_phieunhanbenh, Int32 stt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedPhieuNhanBenhChiTiet] SET id_phieunhanbenh=@id_phieunhanbenh, stt=@stt, id_vienphi=@id_vienphi, mavienphi=@mavienphi, tenvienphi=@tenvienphi, dvttinh=@dvttinh, dongia=@dongia WHERE id_phieunhanbenh=@id_phieunhanbenh and stt=@stt", 
					"@id_phieunhanbenh",  _MedPhieuNhanBenhChiTiet.id_phieunhanbenh, 
					"@stt",  _MedPhieuNhanBenhChiTiet.stt, 
					"@id_vienphi",  _MedPhieuNhanBenhChiTiet.id_vienphi, 
					"@mavienphi",  _MedPhieuNhanBenhChiTiet.mavienphi, 
					"@tenvienphi",  _MedPhieuNhanBenhChiTiet.tenvienphi, 
					"@dvttinh",  _MedPhieuNhanBenhChiTiet.dvttinh, 
					"@dongia",  _MedPhieuNhanBenhChiTiet.dongia, 
					"@id_phieunhanbenh", id_phieunhanbenh, 
					"@stt", stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedPhieuNhanBenhChiTiet vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedPhieuNhanBenhChiTiet _MedPhieuNhanBenhChiTiet)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedPhieuNhanBenhChiTiet] SET id_vienphi=@id_vienphi, mavienphi=@mavienphi, tenvienphi=@tenvienphi, dvttinh=@dvttinh, dongia=@dongia WHERE id_phieunhanbenh=@id_phieunhanbenh and stt=@stt", 
					"@id_vienphi",  _MedPhieuNhanBenhChiTiet.id_vienphi, 
					"@mavienphi",  _MedPhieuNhanBenhChiTiet.mavienphi, 
					"@tenvienphi",  _MedPhieuNhanBenhChiTiet.tenvienphi, 
					"@dvttinh",  _MedPhieuNhanBenhChiTiet.dvttinh, 
					"@dongia",  _MedPhieuNhanBenhChiTiet.dongia, 
					"@id_phieunhanbenh", _MedPhieuNhanBenhChiTiet.id_phieunhanbenh, 
					"@stt", _MedPhieuNhanBenhChiTiet.stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedPhieuNhanBenhChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedPhieuNhanBenhChiTiet> _MedPhieuNhanBenhChiTiets)
		{
			foreach (MedPhieuNhanBenhChiTiet item in _MedPhieuNhanBenhChiTiets)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedPhieuNhanBenhChiTiet vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedPhieuNhanBenhChiTiet _MedPhieuNhanBenhChiTiet, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedPhieuNhanBenhChiTiet] SET id_phieunhanbenh=@id_phieunhanbenh, stt=@stt, id_vienphi=@id_vienphi, mavienphi=@mavienphi, tenvienphi=@tenvienphi, dvttinh=@dvttinh, dongia=@dongia "+ condition, 
					"@id_phieunhanbenh",  _MedPhieuNhanBenhChiTiet.id_phieunhanbenh, 
					"@stt",  _MedPhieuNhanBenhChiTiet.stt, 
					"@id_vienphi",  _MedPhieuNhanBenhChiTiet.id_vienphi, 
					"@mavienphi",  _MedPhieuNhanBenhChiTiet.mavienphi, 
					"@tenvienphi",  _MedPhieuNhanBenhChiTiet.tenvienphi, 
					"@dvttinh",  _MedPhieuNhanBenhChiTiet.dvttinh, 
					"@dongia",  _MedPhieuNhanBenhChiTiet.dongia);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedPhieuNhanBenhChiTiet trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id_phieunhanbenh, Int32 stt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedPhieuNhanBenhChiTiet] WHERE id_phieunhanbenh=@id_phieunhanbenh and stt=@stt",
					"@id_phieunhanbenh", id_phieunhanbenh, 
					"@stt", stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedPhieuNhanBenhChiTiet trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedPhieuNhanBenhChiTiet _MedPhieuNhanBenhChiTiet)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedPhieuNhanBenhChiTiet] WHERE id_phieunhanbenh=@id_phieunhanbenh and stt=@stt",
					"@id_phieunhanbenh", _MedPhieuNhanBenhChiTiet.id_phieunhanbenh, 
					"@stt", _MedPhieuNhanBenhChiTiet.stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedPhieuNhanBenhChiTiet trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedPhieuNhanBenhChiTiet] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedPhieuNhanBenhChiTiet trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedPhieuNhanBenhChiTiet> _MedPhieuNhanBenhChiTiets)
		{
			foreach (MedPhieuNhanBenhChiTiet item in _MedPhieuNhanBenhChiTiets)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
