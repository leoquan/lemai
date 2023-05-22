using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdmauketqua:IMEdmauketqua
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdmauketqua(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedMauKetQua từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMauKetQua]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedMauKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMauKetQua] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedMauKetQua từ Database
		/// </summary>
		public List<MedMauKetQua> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMauKetQua]");
				List<MedMauKetQua> items = new List<MedMauKetQua>();
				MedMauKetQua item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedMauKetQua();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["tenmaumota"] != null && dr["tenmaumota"] != DBNull.Value)
					{
						item.tenmaumota = Convert.ToString(dr["tenmaumota"]);
					}
					if (dr["tenmaumotakd"] != null && dr["tenmaumotakd"] != DBNull.Value)
					{
						item.tenmaumotakd = Convert.ToString(dr["tenmaumotakd"]);
					}
					if (dr["maumota"] != null && dr["maumota"] != DBNull.Value)
					{
						item.maumota = Convert.ToString(dr["maumota"]);
					}
					if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
					{
						item.ketluan = Convert.ToString(dr["ketluan"]);
					}
					if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
					{
						item.id_vienphi = Convert.ToDecimal(dr["id_vienphi"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["tieudereport"] != null && dr["tieudereport"] != DBNull.Value)
					{
						item.tieudereport = Convert.ToString(dr["tieudereport"]);
					}
					if (dr["filereport"] != null && dr["filereport"] != DBNull.Value)
					{
						item.filereport = Convert.ToString(dr["filereport"]);
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
		/// Lấy danh sách MedMauKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedMauKetQua> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedMauKetQua] A "+ condition,  parameters);
				List<MedMauKetQua> items = new List<MedMauKetQua>();
				MedMauKetQua item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedMauKetQua();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["tenmaumota"] != null && dr["tenmaumota"] != DBNull.Value)
					{
						item.tenmaumota = Convert.ToString(dr["tenmaumota"]);
					}
					if (dr["tenmaumotakd"] != null && dr["tenmaumotakd"] != DBNull.Value)
					{
						item.tenmaumotakd = Convert.ToString(dr["tenmaumotakd"]);
					}
					if (dr["maumota"] != null && dr["maumota"] != DBNull.Value)
					{
						item.maumota = Convert.ToString(dr["maumota"]);
					}
					if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
					{
						item.ketluan = Convert.ToString(dr["ketluan"]);
					}
					if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
					{
						item.id_vienphi = Convert.ToDecimal(dr["id_vienphi"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["tieudereport"] != null && dr["tieudereport"] != DBNull.Value)
					{
						item.tieudereport = Convert.ToString(dr["tieudereport"]);
					}
					if (dr["filereport"] != null && dr["filereport"] != DBNull.Value)
					{
						item.filereport = Convert.ToString(dr["filereport"]);
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

		public List<MedMauKetQua> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedMauKetQua] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedMauKetQua] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedMauKetQua>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedMauKetQua từ Database
		/// </summary>
		public MedMauKetQua GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMauKetQua] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedMauKetQua item=new MedMauKetQua();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["tenmaumota"] != null && dr["tenmaumota"] != DBNull.Value)
						{
							item.tenmaumota = Convert.ToString(dr["tenmaumota"]);
						}
						if (dr["tenmaumotakd"] != null && dr["tenmaumotakd"] != DBNull.Value)
						{
							item.tenmaumotakd = Convert.ToString(dr["tenmaumotakd"]);
						}
						if (dr["maumota"] != null && dr["maumota"] != DBNull.Value)
						{
							item.maumota = Convert.ToString(dr["maumota"]);
						}
						if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
						{
							item.ketluan = Convert.ToString(dr["ketluan"]);
						}
						if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
						{
							item.id_vienphi = Convert.ToDecimal(dr["id_vienphi"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["tieudereport"] != null && dr["tieudereport"] != DBNull.Value)
						{
							item.tieudereport = Convert.ToString(dr["tieudereport"]);
						}
						if (dr["filereport"] != null && dr["filereport"] != DBNull.Value)
						{
							item.filereport = Convert.ToString(dr["filereport"]);
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
		/// Lấy một MedMauKetQua đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedMauKetQua GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedMauKetQua] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedMauKetQua item=new MedMauKetQua();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["tenmaumota"] != null && dr["tenmaumota"] != DBNull.Value)
						{
							item.tenmaumota = Convert.ToString(dr["tenmaumota"]);
						}
						if (dr["tenmaumotakd"] != null && dr["tenmaumotakd"] != DBNull.Value)
						{
							item.tenmaumotakd = Convert.ToString(dr["tenmaumotakd"]);
						}
						if (dr["maumota"] != null && dr["maumota"] != DBNull.Value)
						{
							item.maumota = Convert.ToString(dr["maumota"]);
						}
						if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
						{
							item.ketluan = Convert.ToString(dr["ketluan"]);
						}
						if (dr["id_vienphi"] != null && dr["id_vienphi"] != DBNull.Value)
						{
							item.id_vienphi = Convert.ToDecimal(dr["id_vienphi"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["tieudereport"] != null && dr["tieudereport"] != DBNull.Value)
						{
							item.tieudereport = Convert.ToString(dr["tieudereport"]);
						}
						if (dr["filereport"] != null && dr["filereport"] != DBNull.Value)
						{
							item.filereport = Convert.ToString(dr["filereport"]);
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

		public MedMauKetQua GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedMauKetQua] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedMauKetQua>(ds);
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
		/// Thêm mới MedMauKetQua vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedMauKetQua _MedMauKetQua)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedMauKetQua](id, tenmaumota, tenmaumotakd, maumota, ketluan, id_vienphi, ngaytao, nguoitao, tieudereport, filereport) VALUES(@id, @tenmaumota, @tenmaumotakd, @maumota, @ketluan, @id_vienphi, @ngaytao, @nguoitao, @tieudereport, @filereport)", 
					"@id",  _MedMauKetQua.id, 
					"@tenmaumota",  _MedMauKetQua.tenmaumota, 
					"@tenmaumotakd",  _MedMauKetQua.tenmaumotakd, 
					"@maumota",  _MedMauKetQua.maumota, 
					"@ketluan",  _MedMauKetQua.ketluan, 
					"@id_vienphi",  _MedMauKetQua.id_vienphi, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedMauKetQua.ngaytao), 
					"@nguoitao",  _MedMauKetQua.nguoitao, 
					"@tieudereport",  _MedMauKetQua.tieudereport, 
					"@filereport",  _MedMauKetQua.filereport);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedMauKetQua vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedMauKetQua> _MedMauKetQuas)
		{
			foreach (MedMauKetQua item in _MedMauKetQuas)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedMauKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedMauKetQua _MedMauKetQua, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMauKetQua] SET id=@id, tenmaumota=@tenmaumota, tenmaumotakd=@tenmaumotakd, maumota=@maumota, ketluan=@ketluan, id_vienphi=@id_vienphi, ngaytao=@ngaytao, nguoitao=@nguoitao, tieudereport=@tieudereport, filereport=@filereport WHERE id=@id", 
					"@id",  _MedMauKetQua.id, 
					"@tenmaumota",  _MedMauKetQua.tenmaumota, 
					"@tenmaumotakd",  _MedMauKetQua.tenmaumotakd, 
					"@maumota",  _MedMauKetQua.maumota, 
					"@ketluan",  _MedMauKetQua.ketluan, 
					"@id_vienphi",  _MedMauKetQua.id_vienphi, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedMauKetQua.ngaytao), 
					"@nguoitao",  _MedMauKetQua.nguoitao, 
					"@tieudereport",  _MedMauKetQua.tieudereport, 
					"@filereport",  _MedMauKetQua.filereport, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedMauKetQua vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedMauKetQua _MedMauKetQua)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMauKetQua] SET tenmaumota=@tenmaumota, tenmaumotakd=@tenmaumotakd, maumota=@maumota, ketluan=@ketluan, id_vienphi=@id_vienphi, ngaytao=@ngaytao, nguoitao=@nguoitao, tieudereport=@tieudereport, filereport=@filereport WHERE id=@id", 
					"@tenmaumota",  _MedMauKetQua.tenmaumota, 
					"@tenmaumotakd",  _MedMauKetQua.tenmaumotakd, 
					"@maumota",  _MedMauKetQua.maumota, 
					"@ketluan",  _MedMauKetQua.ketluan, 
					"@id_vienphi",  _MedMauKetQua.id_vienphi, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedMauKetQua.ngaytao), 
					"@nguoitao",  _MedMauKetQua.nguoitao, 
					"@tieudereport",  _MedMauKetQua.tieudereport, 
					"@filereport",  _MedMauKetQua.filereport, 
					"@id", _MedMauKetQua.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedMauKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedMauKetQua> _MedMauKetQuas)
		{
			foreach (MedMauKetQua item in _MedMauKetQuas)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedMauKetQua vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedMauKetQua _MedMauKetQua, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMauKetQua] SET id=@id, tenmaumota=@tenmaumota, tenmaumotakd=@tenmaumotakd, maumota=@maumota, ketluan=@ketluan, id_vienphi=@id_vienphi, ngaytao=@ngaytao, nguoitao=@nguoitao, tieudereport=@tieudereport, filereport=@filereport "+ condition, 
					"@id",  _MedMauKetQua.id, 
					"@tenmaumota",  _MedMauKetQua.tenmaumota, 
					"@tenmaumotakd",  _MedMauKetQua.tenmaumotakd, 
					"@maumota",  _MedMauKetQua.maumota, 
					"@ketluan",  _MedMauKetQua.ketluan, 
					"@id_vienphi",  _MedMauKetQua.id_vienphi, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedMauKetQua.ngaytao), 
					"@nguoitao",  _MedMauKetQua.nguoitao, 
					"@tieudereport",  _MedMauKetQua.tieudereport, 
					"@filereport",  _MedMauKetQua.filereport);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedMauKetQua trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMauKetQua] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMauKetQua trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedMauKetQua _MedMauKetQua)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMauKetQua] WHERE id=@id",
					"@id", _MedMauKetQua.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMauKetQua trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMauKetQua] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMauKetQua trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedMauKetQua> _MedMauKetQuas)
		{
			foreach (MedMauKetQua item in _MedMauKetQuas)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
