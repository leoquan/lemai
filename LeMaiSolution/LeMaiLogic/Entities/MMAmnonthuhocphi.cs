using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMAmnonthuhocphi:IMAmnonthuhocphi
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMAmnonthuhocphi(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MamNonThuHocPhi từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonThuHocPhi]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MamNonThuHocPhi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonThuHocPhi] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MamNonThuHocPhi từ Database
		/// </summary>
		public List<MamNonThuHocPhi> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonThuHocPhi]");
				List<MamNonThuHocPhi> items = new List<MamNonThuHocPhi>();
				MamNonThuHocPhi item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonThuHocPhi();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_MamNonTruong"] != null && dr["FK_MamNonTruong"] != DBNull.Value)
					{
						item.FK_MamNonTruong = Convert.ToString(dr["FK_MamNonTruong"]);
					}
					if (dr["SoTienDuThu"] != null && dr["SoTienDuThu"] != DBNull.Value)
					{
						item.SoTienDuThu = Convert.ToDecimal(dr["SoTienDuThu"]);
					}
					if (dr["SoTienThucThu"] != null && dr["SoTienThucThu"] != DBNull.Value)
					{
						item.SoTienThucThu = Convert.ToDecimal(dr["SoTienThucThu"]);
					}
					if (dr["TinhTrang"] != null && dr["TinhTrang"] != DBNull.Value)
					{
						item.TinhTrang = Convert.ToInt32(dr["TinhTrang"]);
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
		/// Lấy danh sách MamNonThuHocPhi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MamNonThuHocPhi> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonThuHocPhi] A "+ condition,  parameters);
				List<MamNonThuHocPhi> items = new List<MamNonThuHocPhi>();
				MamNonThuHocPhi item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonThuHocPhi();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_MamNonTruong"] != null && dr["FK_MamNonTruong"] != DBNull.Value)
					{
						item.FK_MamNonTruong = Convert.ToString(dr["FK_MamNonTruong"]);
					}
					if (dr["SoTienDuThu"] != null && dr["SoTienDuThu"] != DBNull.Value)
					{
						item.SoTienDuThu = Convert.ToDecimal(dr["SoTienDuThu"]);
					}
					if (dr["SoTienThucThu"] != null && dr["SoTienThucThu"] != DBNull.Value)
					{
						item.SoTienThucThu = Convert.ToDecimal(dr["SoTienThucThu"]);
					}
					if (dr["TinhTrang"] != null && dr["TinhTrang"] != DBNull.Value)
					{
						item.TinhTrang = Convert.ToInt32(dr["TinhTrang"]);
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

		public List<MamNonThuHocPhi> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonThuHocPhi] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MamNonThuHocPhi] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MamNonThuHocPhi>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MamNonThuHocPhi từ Database
		/// </summary>
		public MamNonThuHocPhi GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonThuHocPhi] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MamNonThuHocPhi item=new MamNonThuHocPhi();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_MamNonTruong"] != null && dr["FK_MamNonTruong"] != DBNull.Value)
						{
							item.FK_MamNonTruong = Convert.ToString(dr["FK_MamNonTruong"]);
						}
						if (dr["SoTienDuThu"] != null && dr["SoTienDuThu"] != DBNull.Value)
						{
							item.SoTienDuThu = Convert.ToDecimal(dr["SoTienDuThu"]);
						}
						if (dr["SoTienThucThu"] != null && dr["SoTienThucThu"] != DBNull.Value)
						{
							item.SoTienThucThu = Convert.ToDecimal(dr["SoTienThucThu"]);
						}
						if (dr["TinhTrang"] != null && dr["TinhTrang"] != DBNull.Value)
						{
							item.TinhTrang = Convert.ToInt32(dr["TinhTrang"]);
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
		/// Lấy một MamNonThuHocPhi đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MamNonThuHocPhi GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonThuHocPhi] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MamNonThuHocPhi item=new MamNonThuHocPhi();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_MamNonTruong"] != null && dr["FK_MamNonTruong"] != DBNull.Value)
						{
							item.FK_MamNonTruong = Convert.ToString(dr["FK_MamNonTruong"]);
						}
						if (dr["SoTienDuThu"] != null && dr["SoTienDuThu"] != DBNull.Value)
						{
							item.SoTienDuThu = Convert.ToDecimal(dr["SoTienDuThu"]);
						}
						if (dr["SoTienThucThu"] != null && dr["SoTienThucThu"] != DBNull.Value)
						{
							item.SoTienThucThu = Convert.ToDecimal(dr["SoTienThucThu"]);
						}
						if (dr["TinhTrang"] != null && dr["TinhTrang"] != DBNull.Value)
						{
							item.TinhTrang = Convert.ToInt32(dr["TinhTrang"]);
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

		public MamNonThuHocPhi GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonThuHocPhi] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MamNonThuHocPhi>(ds);
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
		/// Thêm mới MamNonThuHocPhi vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MamNonThuHocPhi _MamNonThuHocPhi)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MamNonThuHocPhi](Id, FK_MamNonTruong, SoTienDuThu, SoTienThucThu, TinhTrang) VALUES(@Id, @FK_MamNonTruong, @SoTienDuThu, @SoTienThucThu, @TinhTrang)", 
					"@Id",  _MamNonThuHocPhi.Id, 
					"@FK_MamNonTruong",  _MamNonThuHocPhi.FK_MamNonTruong, 
					"@SoTienDuThu",  _MamNonThuHocPhi.SoTienDuThu, 
					"@SoTienThucThu",  _MamNonThuHocPhi.SoTienThucThu, 
					"@TinhTrang",  _MamNonThuHocPhi.TinhTrang);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MamNonThuHocPhi vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MamNonThuHocPhi> _MamNonThuHocPhis)
		{
			foreach (MamNonThuHocPhi item in _MamNonThuHocPhis)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonThuHocPhi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MamNonThuHocPhi _MamNonThuHocPhi, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonThuHocPhi] SET Id=@Id, FK_MamNonTruong=@FK_MamNonTruong, SoTienDuThu=@SoTienDuThu, SoTienThucThu=@SoTienThucThu, TinhTrang=@TinhTrang WHERE Id=@Id", 
					"@Id",  _MamNonThuHocPhi.Id, 
					"@FK_MamNonTruong",  _MamNonThuHocPhi.FK_MamNonTruong, 
					"@SoTienDuThu",  _MamNonThuHocPhi.SoTienDuThu, 
					"@SoTienThucThu",  _MamNonThuHocPhi.SoTienThucThu, 
					"@TinhTrang",  _MamNonThuHocPhi.TinhTrang, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MamNonThuHocPhi vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MamNonThuHocPhi _MamNonThuHocPhi)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonThuHocPhi] SET FK_MamNonTruong=@FK_MamNonTruong, SoTienDuThu=@SoTienDuThu, SoTienThucThu=@SoTienThucThu, TinhTrang=@TinhTrang WHERE Id=@Id", 
					"@FK_MamNonTruong",  _MamNonThuHocPhi.FK_MamNonTruong, 
					"@SoTienDuThu",  _MamNonThuHocPhi.SoTienDuThu, 
					"@SoTienThucThu",  _MamNonThuHocPhi.SoTienThucThu, 
					"@TinhTrang",  _MamNonThuHocPhi.TinhTrang, 
					"@Id", _MamNonThuHocPhi.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MamNonThuHocPhi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MamNonThuHocPhi> _MamNonThuHocPhis)
		{
			foreach (MamNonThuHocPhi item in _MamNonThuHocPhis)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonThuHocPhi vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MamNonThuHocPhi _MamNonThuHocPhi, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonThuHocPhi] SET Id=@Id, FK_MamNonTruong=@FK_MamNonTruong, SoTienDuThu=@SoTienDuThu, SoTienThucThu=@SoTienThucThu, TinhTrang=@TinhTrang "+ condition, 
					"@Id",  _MamNonThuHocPhi.Id, 
					"@FK_MamNonTruong",  _MamNonThuHocPhi.FK_MamNonTruong, 
					"@SoTienDuThu",  _MamNonThuHocPhi.SoTienDuThu, 
					"@SoTienThucThu",  _MamNonThuHocPhi.SoTienThucThu, 
					"@TinhTrang",  _MamNonThuHocPhi.TinhTrang);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MamNonThuHocPhi trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonThuHocPhi] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonThuHocPhi trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MamNonThuHocPhi _MamNonThuHocPhi)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonThuHocPhi] WHERE Id=@Id",
					"@Id", _MamNonThuHocPhi.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonThuHocPhi trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonThuHocPhi] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonThuHocPhi trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MamNonThuHocPhi> _MamNonThuHocPhis)
		{
			foreach (MamNonThuHocPhi item in _MamNonThuHocPhis)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
