using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMAmnonsodaubai:IMAmnonsodaubai
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMAmnonsodaubai(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MamNonSoDauBai từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonSoDauBai]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MamNonSoDauBai từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonSoDauBai] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MamNonSoDauBai từ Database
		/// </summary>
		public List<MamNonSoDauBai> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonSoDauBai]");
				List<MamNonSoDauBai> items = new List<MamNonSoDauBai>();
				MamNonSoDauBai item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonSoDauBai();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["NgayGhiSo"] != null && dr["NgayGhiSo"] != DBNull.Value)
					{
						item.NgayGhiSo = Convert.ToDateTime(dr["NgayGhiSo"]);
					}
					if (dr["FK_GiaoVien"] != null && dr["FK_GiaoVien"] != DBNull.Value)
					{
						item.FK_GiaoVien = Convert.ToString(dr["FK_GiaoVien"]);
					}
					if (dr["FK_PhaPhoiChuongTrinh"] != null && dr["FK_PhaPhoiChuongTrinh"] != DBNull.Value)
					{
						item.FK_PhaPhoiChuongTrinh = Convert.ToString(dr["FK_PhaPhoiChuongTrinh"]);
					}
					if (dr["FK_MamNonClass"] != null && dr["FK_MamNonClass"] != DBNull.Value)
					{
						item.FK_MamNonClass = Convert.ToString(dr["FK_MamNonClass"]);
					}
					if (dr["SoTiet"] != null && dr["SoTiet"] != DBNull.Value)
					{
						item.SoTiet = Convert.ToInt32(dr["SoTiet"]);
					}
					if (dr["IsHocBu"] != null && dr["IsHocBu"] != DBNull.Value)
					{
						item.IsHocBu = Convert.ToBoolean(dr["IsHocBu"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
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
		/// Lấy danh sách MamNonSoDauBai từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MamNonSoDauBai> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonSoDauBai] A "+ condition,  parameters);
				List<MamNonSoDauBai> items = new List<MamNonSoDauBai>();
				MamNonSoDauBai item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonSoDauBai();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["NgayGhiSo"] != null && dr["NgayGhiSo"] != DBNull.Value)
					{
						item.NgayGhiSo = Convert.ToDateTime(dr["NgayGhiSo"]);
					}
					if (dr["FK_GiaoVien"] != null && dr["FK_GiaoVien"] != DBNull.Value)
					{
						item.FK_GiaoVien = Convert.ToString(dr["FK_GiaoVien"]);
					}
					if (dr["FK_PhaPhoiChuongTrinh"] != null && dr["FK_PhaPhoiChuongTrinh"] != DBNull.Value)
					{
						item.FK_PhaPhoiChuongTrinh = Convert.ToString(dr["FK_PhaPhoiChuongTrinh"]);
					}
					if (dr["FK_MamNonClass"] != null && dr["FK_MamNonClass"] != DBNull.Value)
					{
						item.FK_MamNonClass = Convert.ToString(dr["FK_MamNonClass"]);
					}
					if (dr["SoTiet"] != null && dr["SoTiet"] != DBNull.Value)
					{
						item.SoTiet = Convert.ToInt32(dr["SoTiet"]);
					}
					if (dr["IsHocBu"] != null && dr["IsHocBu"] != DBNull.Value)
					{
						item.IsHocBu = Convert.ToBoolean(dr["IsHocBu"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
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

		public List<MamNonSoDauBai> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonSoDauBai] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MamNonSoDauBai] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MamNonSoDauBai>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MamNonSoDauBai từ Database
		/// </summary>
		public MamNonSoDauBai GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonSoDauBai] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MamNonSoDauBai item=new MamNonSoDauBai();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["NgayGhiSo"] != null && dr["NgayGhiSo"] != DBNull.Value)
						{
							item.NgayGhiSo = Convert.ToDateTime(dr["NgayGhiSo"]);
						}
						if (dr["FK_GiaoVien"] != null && dr["FK_GiaoVien"] != DBNull.Value)
						{
							item.FK_GiaoVien = Convert.ToString(dr["FK_GiaoVien"]);
						}
						if (dr["FK_PhaPhoiChuongTrinh"] != null && dr["FK_PhaPhoiChuongTrinh"] != DBNull.Value)
						{
							item.FK_PhaPhoiChuongTrinh = Convert.ToString(dr["FK_PhaPhoiChuongTrinh"]);
						}
						if (dr["FK_MamNonClass"] != null && dr["FK_MamNonClass"] != DBNull.Value)
						{
							item.FK_MamNonClass = Convert.ToString(dr["FK_MamNonClass"]);
						}
						if (dr["SoTiet"] != null && dr["SoTiet"] != DBNull.Value)
						{
							item.SoTiet = Convert.ToInt32(dr["SoTiet"]);
						}
						if (dr["IsHocBu"] != null && dr["IsHocBu"] != DBNull.Value)
						{
							item.IsHocBu = Convert.ToBoolean(dr["IsHocBu"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
						}
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
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
		/// Lấy một MamNonSoDauBai đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MamNonSoDauBai GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonSoDauBai] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MamNonSoDauBai item=new MamNonSoDauBai();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["NgayGhiSo"] != null && dr["NgayGhiSo"] != DBNull.Value)
						{
							item.NgayGhiSo = Convert.ToDateTime(dr["NgayGhiSo"]);
						}
						if (dr["FK_GiaoVien"] != null && dr["FK_GiaoVien"] != DBNull.Value)
						{
							item.FK_GiaoVien = Convert.ToString(dr["FK_GiaoVien"]);
						}
						if (dr["FK_PhaPhoiChuongTrinh"] != null && dr["FK_PhaPhoiChuongTrinh"] != DBNull.Value)
						{
							item.FK_PhaPhoiChuongTrinh = Convert.ToString(dr["FK_PhaPhoiChuongTrinh"]);
						}
						if (dr["FK_MamNonClass"] != null && dr["FK_MamNonClass"] != DBNull.Value)
						{
							item.FK_MamNonClass = Convert.ToString(dr["FK_MamNonClass"]);
						}
						if (dr["SoTiet"] != null && dr["SoTiet"] != DBNull.Value)
						{
							item.SoTiet = Convert.ToInt32(dr["SoTiet"]);
						}
						if (dr["IsHocBu"] != null && dr["IsHocBu"] != DBNull.Value)
						{
							item.IsHocBu = Convert.ToBoolean(dr["IsHocBu"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
						}
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
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

		public MamNonSoDauBai GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonSoDauBai] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MamNonSoDauBai>(ds);
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
		/// Thêm mới MamNonSoDauBai vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MamNonSoDauBai _MamNonSoDauBai)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MamNonSoDauBai](Id, NgayGhiSo, FK_GiaoVien, FK_PhaPhoiChuongTrinh, FK_MamNonClass, SoTiet, IsHocBu, GhiChu, GoogleMap) VALUES(@Id, @NgayGhiSo, @FK_GiaoVien, @FK_PhaPhoiChuongTrinh, @FK_MamNonClass, @SoTiet, @IsHocBu, @GhiChu, @GoogleMap)", 
					"@Id",  _MamNonSoDauBai.Id, 
					"@NgayGhiSo", this._dataContext.ConvertDateString( _MamNonSoDauBai.NgayGhiSo), 
					"@FK_GiaoVien",  _MamNonSoDauBai.FK_GiaoVien, 
					"@FK_PhaPhoiChuongTrinh",  _MamNonSoDauBai.FK_PhaPhoiChuongTrinh, 
					"@FK_MamNonClass",  _MamNonSoDauBai.FK_MamNonClass, 
					"@SoTiet",  _MamNonSoDauBai.SoTiet, 
					"@IsHocBu",  _MamNonSoDauBai.IsHocBu, 
					"@GhiChu",  _MamNonSoDauBai.GhiChu, 
					"@GoogleMap",  _MamNonSoDauBai.GoogleMap);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MamNonSoDauBai vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MamNonSoDauBai> _MamNonSoDauBais)
		{
			foreach (MamNonSoDauBai item in _MamNonSoDauBais)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonSoDauBai vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MamNonSoDauBai _MamNonSoDauBai, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonSoDauBai] SET Id=@Id, NgayGhiSo=@NgayGhiSo, FK_GiaoVien=@FK_GiaoVien, FK_PhaPhoiChuongTrinh=@FK_PhaPhoiChuongTrinh, FK_MamNonClass=@FK_MamNonClass, SoTiet=@SoTiet, IsHocBu=@IsHocBu, GhiChu=@GhiChu, GoogleMap=@GoogleMap WHERE Id=@Id", 
					"@Id",  _MamNonSoDauBai.Id, 
					"@NgayGhiSo", this._dataContext.ConvertDateString( _MamNonSoDauBai.NgayGhiSo), 
					"@FK_GiaoVien",  _MamNonSoDauBai.FK_GiaoVien, 
					"@FK_PhaPhoiChuongTrinh",  _MamNonSoDauBai.FK_PhaPhoiChuongTrinh, 
					"@FK_MamNonClass",  _MamNonSoDauBai.FK_MamNonClass, 
					"@SoTiet",  _MamNonSoDauBai.SoTiet, 
					"@IsHocBu",  _MamNonSoDauBai.IsHocBu, 
					"@GhiChu",  _MamNonSoDauBai.GhiChu, 
					"@GoogleMap",  _MamNonSoDauBai.GoogleMap, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MamNonSoDauBai vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MamNonSoDauBai _MamNonSoDauBai)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonSoDauBai] SET NgayGhiSo=@NgayGhiSo, FK_GiaoVien=@FK_GiaoVien, FK_PhaPhoiChuongTrinh=@FK_PhaPhoiChuongTrinh, FK_MamNonClass=@FK_MamNonClass, SoTiet=@SoTiet, IsHocBu=@IsHocBu, GhiChu=@GhiChu, GoogleMap=@GoogleMap WHERE Id=@Id", 
					"@NgayGhiSo", this._dataContext.ConvertDateString( _MamNonSoDauBai.NgayGhiSo), 
					"@FK_GiaoVien",  _MamNonSoDauBai.FK_GiaoVien, 
					"@FK_PhaPhoiChuongTrinh",  _MamNonSoDauBai.FK_PhaPhoiChuongTrinh, 
					"@FK_MamNonClass",  _MamNonSoDauBai.FK_MamNonClass, 
					"@SoTiet",  _MamNonSoDauBai.SoTiet, 
					"@IsHocBu",  _MamNonSoDauBai.IsHocBu, 
					"@GhiChu",  _MamNonSoDauBai.GhiChu, 
					"@GoogleMap",  _MamNonSoDauBai.GoogleMap, 
					"@Id", _MamNonSoDauBai.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MamNonSoDauBai vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MamNonSoDauBai> _MamNonSoDauBais)
		{
			foreach (MamNonSoDauBai item in _MamNonSoDauBais)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonSoDauBai vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MamNonSoDauBai _MamNonSoDauBai, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonSoDauBai] SET Id=@Id, NgayGhiSo=@NgayGhiSo, FK_GiaoVien=@FK_GiaoVien, FK_PhaPhoiChuongTrinh=@FK_PhaPhoiChuongTrinh, FK_MamNonClass=@FK_MamNonClass, SoTiet=@SoTiet, IsHocBu=@IsHocBu, GhiChu=@GhiChu, GoogleMap=@GoogleMap "+ condition, 
					"@Id",  _MamNonSoDauBai.Id, 
					"@NgayGhiSo", this._dataContext.ConvertDateString( _MamNonSoDauBai.NgayGhiSo), 
					"@FK_GiaoVien",  _MamNonSoDauBai.FK_GiaoVien, 
					"@FK_PhaPhoiChuongTrinh",  _MamNonSoDauBai.FK_PhaPhoiChuongTrinh, 
					"@FK_MamNonClass",  _MamNonSoDauBai.FK_MamNonClass, 
					"@SoTiet",  _MamNonSoDauBai.SoTiet, 
					"@IsHocBu",  _MamNonSoDauBai.IsHocBu, 
					"@GhiChu",  _MamNonSoDauBai.GhiChu, 
					"@GoogleMap",  _MamNonSoDauBai.GoogleMap);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MamNonSoDauBai trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonSoDauBai] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonSoDauBai trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MamNonSoDauBai _MamNonSoDauBai)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonSoDauBai] WHERE Id=@Id",
					"@Id", _MamNonSoDauBai.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonSoDauBai trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonSoDauBai] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonSoDauBai trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MamNonSoDauBai> _MamNonSoDauBais)
		{
			foreach (MamNonSoDauBai item in _MamNonSoDauBais)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
