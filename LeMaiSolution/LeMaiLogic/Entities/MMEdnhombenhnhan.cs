using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdnhombenhnhan:IMEdnhombenhnhan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdnhombenhnhan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedNhomBenhNhan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedNhomBenhNhan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedNhomBenhNhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedNhomBenhNhan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedNhomBenhNhan từ Database
		/// </summary>
		public List<MedNhomBenhNhan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedNhomBenhNhan]");
				List<MedNhomBenhNhan> items = new List<MedNhomBenhNhan>();
				MedNhomBenhNhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedNhomBenhNhan();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["tennhom"] != null && dr["tennhom"] != DBNull.Value)
					{
						item.tennhom = Convert.ToString(dr["tennhom"]);
					}
					if (dr["id_coso"] != null && dr["id_coso"] != DBNull.Value)
					{
						item.id_coso = Convert.ToString(dr["id_coso"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
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
		/// Lấy danh sách MedNhomBenhNhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedNhomBenhNhan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedNhomBenhNhan] A "+ condition,  parameters);
				List<MedNhomBenhNhan> items = new List<MedNhomBenhNhan>();
				MedNhomBenhNhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedNhomBenhNhan();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["tennhom"] != null && dr["tennhom"] != DBNull.Value)
					{
						item.tennhom = Convert.ToString(dr["tennhom"]);
					}
					if (dr["id_coso"] != null && dr["id_coso"] != DBNull.Value)
					{
						item.id_coso = Convert.ToString(dr["id_coso"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
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

		public List<MedNhomBenhNhan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedNhomBenhNhan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedNhomBenhNhan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedNhomBenhNhan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedNhomBenhNhan từ Database
		/// </summary>
		public MedNhomBenhNhan GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedNhomBenhNhan] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedNhomBenhNhan item=new MedNhomBenhNhan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["tennhom"] != null && dr["tennhom"] != DBNull.Value)
						{
							item.tennhom = Convert.ToString(dr["tennhom"]);
						}
						if (dr["id_coso"] != null && dr["id_coso"] != DBNull.Value)
						{
							item.id_coso = Convert.ToString(dr["id_coso"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
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
		/// Lấy một MedNhomBenhNhan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedNhomBenhNhan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedNhomBenhNhan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedNhomBenhNhan item=new MedNhomBenhNhan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["tennhom"] != null && dr["tennhom"] != DBNull.Value)
						{
							item.tennhom = Convert.ToString(dr["tennhom"]);
						}
						if (dr["id_coso"] != null && dr["id_coso"] != DBNull.Value)
						{
							item.id_coso = Convert.ToString(dr["id_coso"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
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

		public MedNhomBenhNhan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedNhomBenhNhan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedNhomBenhNhan>(ds);
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
		/// Thêm mới MedNhomBenhNhan vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedNhomBenhNhan _MedNhomBenhNhan)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedNhomBenhNhan](id, tennhom, id_coso, nguoitao, ngaytao) VALUES(@id, @tennhom, @id_coso, @nguoitao, @ngaytao)", 
					"@id",  _MedNhomBenhNhan.id, 
					"@tennhom",  _MedNhomBenhNhan.tennhom, 
					"@id_coso",  _MedNhomBenhNhan.id_coso, 
					"@nguoitao",  _MedNhomBenhNhan.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedNhomBenhNhan.ngaytao));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedNhomBenhNhan vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedNhomBenhNhan> _MedNhomBenhNhans)
		{
			foreach (MedNhomBenhNhan item in _MedNhomBenhNhans)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedNhomBenhNhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedNhomBenhNhan _MedNhomBenhNhan, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedNhomBenhNhan] SET id=@id, tennhom=@tennhom, id_coso=@id_coso, nguoitao=@nguoitao, ngaytao=@ngaytao WHERE id=@id", 
					"@id",  _MedNhomBenhNhan.id, 
					"@tennhom",  _MedNhomBenhNhan.tennhom, 
					"@id_coso",  _MedNhomBenhNhan.id_coso, 
					"@nguoitao",  _MedNhomBenhNhan.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedNhomBenhNhan.ngaytao), 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedNhomBenhNhan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedNhomBenhNhan _MedNhomBenhNhan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedNhomBenhNhan] SET tennhom=@tennhom, id_coso=@id_coso, nguoitao=@nguoitao, ngaytao=@ngaytao WHERE id=@id", 
					"@tennhom",  _MedNhomBenhNhan.tennhom, 
					"@id_coso",  _MedNhomBenhNhan.id_coso, 
					"@nguoitao",  _MedNhomBenhNhan.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedNhomBenhNhan.ngaytao), 
					"@id", _MedNhomBenhNhan.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedNhomBenhNhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedNhomBenhNhan> _MedNhomBenhNhans)
		{
			foreach (MedNhomBenhNhan item in _MedNhomBenhNhans)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedNhomBenhNhan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedNhomBenhNhan _MedNhomBenhNhan, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedNhomBenhNhan] SET id=@id, tennhom=@tennhom, id_coso=@id_coso, nguoitao=@nguoitao, ngaytao=@ngaytao "+ condition, 
					"@id",  _MedNhomBenhNhan.id, 
					"@tennhom",  _MedNhomBenhNhan.tennhom, 
					"@id_coso",  _MedNhomBenhNhan.id_coso, 
					"@nguoitao",  _MedNhomBenhNhan.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedNhomBenhNhan.ngaytao));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedNhomBenhNhan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedNhomBenhNhan] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedNhomBenhNhan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedNhomBenhNhan _MedNhomBenhNhan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedNhomBenhNhan] WHERE id=@id",
					"@id", _MedNhomBenhNhan.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedNhomBenhNhan trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedNhomBenhNhan] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedNhomBenhNhan trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedNhomBenhNhan> _MedNhomBenhNhans)
		{
			foreach (MedNhomBenhNhan item in _MedNhomBenhNhans)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
