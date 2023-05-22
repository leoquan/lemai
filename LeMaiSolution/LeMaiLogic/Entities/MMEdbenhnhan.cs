using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdbenhnhan:IMEdbenhnhan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdbenhnhan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedBenhNhan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedBenhNhan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedBenhNhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedBenhNhan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedBenhNhan từ Database
		/// </summary>
		public List<MedBenhNhan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedBenhNhan]");
				List<MedBenhNhan> items = new List<MedBenhNhan>();
				MedBenhNhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedBenhNhan();
					if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
					{
						item.mabn = Convert.ToString(dr["mabn"]);
					}
					if (dr["manhanvien"] != null && dr["manhanvien"] != DBNull.Value)
					{
						item.manhanvien = Convert.ToString(dr["manhanvien"]);
					}
					if (dr["hoten"] != null && dr["hoten"] != DBNull.Value)
					{
						item.hoten = Convert.ToString(dr["hoten"]);
					}
					if (dr["hotenkd"] != null && dr["hotenkd"] != DBNull.Value)
					{
						item.hotenkd = Convert.ToString(dr["hotenkd"]);
					}
					if (dr["ngaysinh"] != null && dr["ngaysinh"] != DBNull.Value)
					{
						item.ngaysinh = Convert.ToString(dr["ngaysinh"]);
					}
					if (dr["namsinh"] != null && dr["namsinh"] != DBNull.Value)
					{
						item.namsinh = Convert.ToInt32(dr["namsinh"]);
					}
					if (dr["gioitinh"] != null && dr["gioitinh"] != DBNull.Value)
					{
						item.gioitinh = Convert.ToInt32(dr["gioitinh"]);
					}
					if (dr["id_bophan"] != null && dr["id_bophan"] != DBNull.Value)
					{
						item.id_bophan = Convert.ToString(dr["id_bophan"]);
					}
					if (dr["id_congty"] != null && dr["id_congty"] != DBNull.Value)
					{
						item.id_congty = Convert.ToString(dr["id_congty"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
					}
					if (dr["nguoicapnhat"] != null && dr["nguoicapnhat"] != DBNull.Value)
					{
						item.nguoicapnhat = Convert.ToString(dr["nguoicapnhat"]);
					}
					if (dr["ngaycapnhat"] != null && dr["ngaycapnhat"] != DBNull.Value)
					{
						item.ngaycapnhat = Convert.ToDateTime(dr["ngaycapnhat"]);
					}
					if (dr["id_nhom"] != null && dr["id_nhom"] != DBNull.Value)
					{
						item.id_nhom = Convert.ToString(dr["id_nhom"]);
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
		/// Lấy danh sách MedBenhNhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedBenhNhan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedBenhNhan] A "+ condition,  parameters);
				List<MedBenhNhan> items = new List<MedBenhNhan>();
				MedBenhNhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedBenhNhan();
					if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
					{
						item.mabn = Convert.ToString(dr["mabn"]);
					}
					if (dr["manhanvien"] != null && dr["manhanvien"] != DBNull.Value)
					{
						item.manhanvien = Convert.ToString(dr["manhanvien"]);
					}
					if (dr["hoten"] != null && dr["hoten"] != DBNull.Value)
					{
						item.hoten = Convert.ToString(dr["hoten"]);
					}
					if (dr["hotenkd"] != null && dr["hotenkd"] != DBNull.Value)
					{
						item.hotenkd = Convert.ToString(dr["hotenkd"]);
					}
					if (dr["ngaysinh"] != null && dr["ngaysinh"] != DBNull.Value)
					{
						item.ngaysinh = Convert.ToString(dr["ngaysinh"]);
					}
					if (dr["namsinh"] != null && dr["namsinh"] != DBNull.Value)
					{
						item.namsinh = Convert.ToInt32(dr["namsinh"]);
					}
					if (dr["gioitinh"] != null && dr["gioitinh"] != DBNull.Value)
					{
						item.gioitinh = Convert.ToInt32(dr["gioitinh"]);
					}
					if (dr["id_bophan"] != null && dr["id_bophan"] != DBNull.Value)
					{
						item.id_bophan = Convert.ToString(dr["id_bophan"]);
					}
					if (dr["id_congty"] != null && dr["id_congty"] != DBNull.Value)
					{
						item.id_congty = Convert.ToString(dr["id_congty"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
					}
					if (dr["nguoicapnhat"] != null && dr["nguoicapnhat"] != DBNull.Value)
					{
						item.nguoicapnhat = Convert.ToString(dr["nguoicapnhat"]);
					}
					if (dr["ngaycapnhat"] != null && dr["ngaycapnhat"] != DBNull.Value)
					{
						item.ngaycapnhat = Convert.ToDateTime(dr["ngaycapnhat"]);
					}
					if (dr["id_nhom"] != null && dr["id_nhom"] != DBNull.Value)
					{
						item.id_nhom = Convert.ToString(dr["id_nhom"]);
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

		public List<MedBenhNhan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedBenhNhan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedBenhNhan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedBenhNhan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedBenhNhan từ Database
		/// </summary>
		public MedBenhNhan GetObject(string schema, String mabn)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedBenhNhan] where mabn=@mabn",
					"@mabn", mabn);
				if (ds.Rows.Count > 0)
				{
					MedBenhNhan item=new MedBenhNhan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
						{
							item.mabn = Convert.ToString(dr["mabn"]);
						}
						if (dr["manhanvien"] != null && dr["manhanvien"] != DBNull.Value)
						{
							item.manhanvien = Convert.ToString(dr["manhanvien"]);
						}
						if (dr["hoten"] != null && dr["hoten"] != DBNull.Value)
						{
							item.hoten = Convert.ToString(dr["hoten"]);
						}
						if (dr["hotenkd"] != null && dr["hotenkd"] != DBNull.Value)
						{
							item.hotenkd = Convert.ToString(dr["hotenkd"]);
						}
						if (dr["ngaysinh"] != null && dr["ngaysinh"] != DBNull.Value)
						{
							item.ngaysinh = Convert.ToString(dr["ngaysinh"]);
						}
						if (dr["namsinh"] != null && dr["namsinh"] != DBNull.Value)
						{
							item.namsinh = Convert.ToInt32(dr["namsinh"]);
						}
						if (dr["gioitinh"] != null && dr["gioitinh"] != DBNull.Value)
						{
							item.gioitinh = Convert.ToInt32(dr["gioitinh"]);
						}
						if (dr["id_bophan"] != null && dr["id_bophan"] != DBNull.Value)
						{
							item.id_bophan = Convert.ToString(dr["id_bophan"]);
						}
						if (dr["id_congty"] != null && dr["id_congty"] != DBNull.Value)
						{
							item.id_congty = Convert.ToString(dr["id_congty"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
						}
						if (dr["nguoicapnhat"] != null && dr["nguoicapnhat"] != DBNull.Value)
						{
							item.nguoicapnhat = Convert.ToString(dr["nguoicapnhat"]);
						}
						if (dr["ngaycapnhat"] != null && dr["ngaycapnhat"] != DBNull.Value)
						{
							item.ngaycapnhat = Convert.ToDateTime(dr["ngaycapnhat"]);
						}
						if (dr["id_nhom"] != null && dr["id_nhom"] != DBNull.Value)
						{
							item.id_nhom = Convert.ToString(dr["id_nhom"]);
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
		/// Lấy một MedBenhNhan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedBenhNhan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedBenhNhan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedBenhNhan item=new MedBenhNhan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
						{
							item.mabn = Convert.ToString(dr["mabn"]);
						}
						if (dr["manhanvien"] != null && dr["manhanvien"] != DBNull.Value)
						{
							item.manhanvien = Convert.ToString(dr["manhanvien"]);
						}
						if (dr["hoten"] != null && dr["hoten"] != DBNull.Value)
						{
							item.hoten = Convert.ToString(dr["hoten"]);
						}
						if (dr["hotenkd"] != null && dr["hotenkd"] != DBNull.Value)
						{
							item.hotenkd = Convert.ToString(dr["hotenkd"]);
						}
						if (dr["ngaysinh"] != null && dr["ngaysinh"] != DBNull.Value)
						{
							item.ngaysinh = Convert.ToString(dr["ngaysinh"]);
						}
						if (dr["namsinh"] != null && dr["namsinh"] != DBNull.Value)
						{
							item.namsinh = Convert.ToInt32(dr["namsinh"]);
						}
						if (dr["gioitinh"] != null && dr["gioitinh"] != DBNull.Value)
						{
							item.gioitinh = Convert.ToInt32(dr["gioitinh"]);
						}
						if (dr["id_bophan"] != null && dr["id_bophan"] != DBNull.Value)
						{
							item.id_bophan = Convert.ToString(dr["id_bophan"]);
						}
						if (dr["id_congty"] != null && dr["id_congty"] != DBNull.Value)
						{
							item.id_congty = Convert.ToString(dr["id_congty"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
						}
						if (dr["nguoicapnhat"] != null && dr["nguoicapnhat"] != DBNull.Value)
						{
							item.nguoicapnhat = Convert.ToString(dr["nguoicapnhat"]);
						}
						if (dr["ngaycapnhat"] != null && dr["ngaycapnhat"] != DBNull.Value)
						{
							item.ngaycapnhat = Convert.ToDateTime(dr["ngaycapnhat"]);
						}
						if (dr["id_nhom"] != null && dr["id_nhom"] != DBNull.Value)
						{
							item.id_nhom = Convert.ToString(dr["id_nhom"]);
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

		public MedBenhNhan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedBenhNhan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedBenhNhan>(ds);
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
		/// Thêm mới MedBenhNhan vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedBenhNhan _MedBenhNhan)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedBenhNhan](mabn, manhanvien, hoten, hotenkd, ngaysinh, namsinh, gioitinh, id_bophan, id_congty, nguoitao, ngaytao, nguoicapnhat, ngaycapnhat, id_nhom) VALUES(@mabn, @manhanvien, @hoten, @hotenkd, @ngaysinh, @namsinh, @gioitinh, @id_bophan, @id_congty, @nguoitao, @ngaytao, @nguoicapnhat, @ngaycapnhat, @id_nhom)", 
					"@mabn",  _MedBenhNhan.mabn, 
					"@manhanvien",  _MedBenhNhan.manhanvien, 
					"@hoten",  _MedBenhNhan.hoten, 
					"@hotenkd",  _MedBenhNhan.hotenkd, 
					"@ngaysinh",  _MedBenhNhan.ngaysinh, 
					"@namsinh",  _MedBenhNhan.namsinh, 
					"@gioitinh",  _MedBenhNhan.gioitinh, 
					"@id_bophan",  _MedBenhNhan.id_bophan, 
					"@id_congty",  _MedBenhNhan.id_congty, 
					"@nguoitao",  _MedBenhNhan.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedBenhNhan.ngaytao), 
					"@nguoicapnhat",  _MedBenhNhan.nguoicapnhat, 
					"@ngaycapnhat", this._dataContext.ConvertDateString( _MedBenhNhan.ngaycapnhat), 
					"@id_nhom",  _MedBenhNhan.id_nhom);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedBenhNhan vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedBenhNhan> _MedBenhNhans)
		{
			foreach (MedBenhNhan item in _MedBenhNhans)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedBenhNhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedBenhNhan _MedBenhNhan, String mabn)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedBenhNhan] SET mabn=@mabn, manhanvien=@manhanvien, hoten=@hoten, hotenkd=@hotenkd, ngaysinh=@ngaysinh, namsinh=@namsinh, gioitinh=@gioitinh, id_bophan=@id_bophan, id_congty=@id_congty, nguoitao=@nguoitao, ngaytao=@ngaytao, nguoicapnhat=@nguoicapnhat, ngaycapnhat=@ngaycapnhat, id_nhom=@id_nhom WHERE mabn=@mabn", 
					"@mabn",  _MedBenhNhan.mabn, 
					"@manhanvien",  _MedBenhNhan.manhanvien, 
					"@hoten",  _MedBenhNhan.hoten, 
					"@hotenkd",  _MedBenhNhan.hotenkd, 
					"@ngaysinh",  _MedBenhNhan.ngaysinh, 
					"@namsinh",  _MedBenhNhan.namsinh, 
					"@gioitinh",  _MedBenhNhan.gioitinh, 
					"@id_bophan",  _MedBenhNhan.id_bophan, 
					"@id_congty",  _MedBenhNhan.id_congty, 
					"@nguoitao",  _MedBenhNhan.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedBenhNhan.ngaytao), 
					"@nguoicapnhat",  _MedBenhNhan.nguoicapnhat, 
					"@ngaycapnhat", this._dataContext.ConvertDateString( _MedBenhNhan.ngaycapnhat), 
					"@id_nhom",  _MedBenhNhan.id_nhom, 
					"@mabn", mabn);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedBenhNhan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedBenhNhan _MedBenhNhan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedBenhNhan] SET manhanvien=@manhanvien, hoten=@hoten, hotenkd=@hotenkd, ngaysinh=@ngaysinh, namsinh=@namsinh, gioitinh=@gioitinh, id_bophan=@id_bophan, id_congty=@id_congty, nguoitao=@nguoitao, ngaytao=@ngaytao, nguoicapnhat=@nguoicapnhat, ngaycapnhat=@ngaycapnhat, id_nhom=@id_nhom WHERE mabn=@mabn", 
					"@manhanvien",  _MedBenhNhan.manhanvien, 
					"@hoten",  _MedBenhNhan.hoten, 
					"@hotenkd",  _MedBenhNhan.hotenkd, 
					"@ngaysinh",  _MedBenhNhan.ngaysinh, 
					"@namsinh",  _MedBenhNhan.namsinh, 
					"@gioitinh",  _MedBenhNhan.gioitinh, 
					"@id_bophan",  _MedBenhNhan.id_bophan, 
					"@id_congty",  _MedBenhNhan.id_congty, 
					"@nguoitao",  _MedBenhNhan.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedBenhNhan.ngaytao), 
					"@nguoicapnhat",  _MedBenhNhan.nguoicapnhat, 
					"@ngaycapnhat", this._dataContext.ConvertDateString( _MedBenhNhan.ngaycapnhat), 
					"@id_nhom",  _MedBenhNhan.id_nhom, 
					"@mabn", _MedBenhNhan.mabn);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedBenhNhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedBenhNhan> _MedBenhNhans)
		{
			foreach (MedBenhNhan item in _MedBenhNhans)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedBenhNhan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedBenhNhan _MedBenhNhan, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedBenhNhan] SET mabn=@mabn, manhanvien=@manhanvien, hoten=@hoten, hotenkd=@hotenkd, ngaysinh=@ngaysinh, namsinh=@namsinh, gioitinh=@gioitinh, id_bophan=@id_bophan, id_congty=@id_congty, nguoitao=@nguoitao, ngaytao=@ngaytao, nguoicapnhat=@nguoicapnhat, ngaycapnhat=@ngaycapnhat, id_nhom=@id_nhom "+ condition, 
					"@mabn",  _MedBenhNhan.mabn, 
					"@manhanvien",  _MedBenhNhan.manhanvien, 
					"@hoten",  _MedBenhNhan.hoten, 
					"@hotenkd",  _MedBenhNhan.hotenkd, 
					"@ngaysinh",  _MedBenhNhan.ngaysinh, 
					"@namsinh",  _MedBenhNhan.namsinh, 
					"@gioitinh",  _MedBenhNhan.gioitinh, 
					"@id_bophan",  _MedBenhNhan.id_bophan, 
					"@id_congty",  _MedBenhNhan.id_congty, 
					"@nguoitao",  _MedBenhNhan.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedBenhNhan.ngaytao), 
					"@nguoicapnhat",  _MedBenhNhan.nguoicapnhat, 
					"@ngaycapnhat", this._dataContext.ConvertDateString( _MedBenhNhan.ngaycapnhat), 
					"@id_nhom",  _MedBenhNhan.id_nhom);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedBenhNhan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String mabn)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedBenhNhan] WHERE mabn=@mabn",
					"@mabn", mabn);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedBenhNhan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedBenhNhan _MedBenhNhan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedBenhNhan] WHERE mabn=@mabn",
					"@mabn", _MedBenhNhan.mabn);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedBenhNhan trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedBenhNhan] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedBenhNhan trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedBenhNhan> _MedBenhNhans)
		{
			foreach (MedBenhNhan item in _MedBenhNhans)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
