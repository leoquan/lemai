using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSAlebanggia:ISAlebanggia
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSAlebanggia(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SaleBangGia từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBangGia]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SaleBangGia từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBangGia] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SaleBangGia từ Database
		/// </summary>
		public List<SaleBangGia> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBangGia]");
				List<SaleBangGia> items = new List<SaleBangGia>();
				SaleBangGia item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleBangGia();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenBangGia"] != null && dr["TenBangGia"] != DBNull.Value)
					{
						item.TenBangGia = Convert.ToString(dr["TenBangGia"]);
					}
					if (dr["BangGiaMacDinh"] != null && dr["BangGiaMacDinh"] != DBNull.Value)
					{
						item.BangGiaMacDinh = Convert.ToBoolean(dr["BangGiaMacDinh"]);
					}
					if (dr["HienThi"] != null && dr["HienThi"] != DBNull.Value)
					{
						item.HienThi = Convert.ToBoolean(dr["HienThi"]);
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
		/// Lấy danh sách SaleBangGia từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SaleBangGia> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleBangGia] A "+ condition,  parameters);
				List<SaleBangGia> items = new List<SaleBangGia>();
				SaleBangGia item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SaleBangGia();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenBangGia"] != null && dr["TenBangGia"] != DBNull.Value)
					{
						item.TenBangGia = Convert.ToString(dr["TenBangGia"]);
					}
					if (dr["BangGiaMacDinh"] != null && dr["BangGiaMacDinh"] != DBNull.Value)
					{
						item.BangGiaMacDinh = Convert.ToBoolean(dr["BangGiaMacDinh"]);
					}
					if (dr["HienThi"] != null && dr["HienThi"] != DBNull.Value)
					{
						item.HienThi = Convert.ToBoolean(dr["HienThi"]);
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

		public List<SaleBangGia> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleBangGia] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SaleBangGia] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SaleBangGia>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SaleBangGia từ Database
		/// </summary>
		public SaleBangGia GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SaleBangGia] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SaleBangGia item=new SaleBangGia();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenBangGia"] != null && dr["TenBangGia"] != DBNull.Value)
						{
							item.TenBangGia = Convert.ToString(dr["TenBangGia"]);
						}
						if (dr["BangGiaMacDinh"] != null && dr["BangGiaMacDinh"] != DBNull.Value)
						{
							item.BangGiaMacDinh = Convert.ToBoolean(dr["BangGiaMacDinh"]);
						}
						if (dr["HienThi"] != null && dr["HienThi"] != DBNull.Value)
						{
							item.HienThi = Convert.ToBoolean(dr["HienThi"]);
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
		/// Lấy một SaleBangGia đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SaleBangGia GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SaleBangGia] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SaleBangGia item=new SaleBangGia();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenBangGia"] != null && dr["TenBangGia"] != DBNull.Value)
						{
							item.TenBangGia = Convert.ToString(dr["TenBangGia"]);
						}
						if (dr["BangGiaMacDinh"] != null && dr["BangGiaMacDinh"] != DBNull.Value)
						{
							item.BangGiaMacDinh = Convert.ToBoolean(dr["BangGiaMacDinh"]);
						}
						if (dr["HienThi"] != null && dr["HienThi"] != DBNull.Value)
						{
							item.HienThi = Convert.ToBoolean(dr["HienThi"]);
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

		public SaleBangGia GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SaleBangGia] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SaleBangGia>(ds);
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
		/// Thêm mới SaleBangGia vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SaleBangGia _SaleBangGia)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SaleBangGia](Id, TenBangGia, BangGiaMacDinh, HienThi) VALUES(@Id, @TenBangGia, @BangGiaMacDinh, @HienThi)", 
					"@Id",  _SaleBangGia.Id, 
					"@TenBangGia",  _SaleBangGia.TenBangGia, 
					"@BangGiaMacDinh",  _SaleBangGia.BangGiaMacDinh, 
					"@HienThi",  _SaleBangGia.HienThi);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SaleBangGia vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SaleBangGia> _SaleBangGias)
		{
			foreach (SaleBangGia item in _SaleBangGias)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleBangGia vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SaleBangGia _SaleBangGia, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleBangGia] SET Id=@Id, TenBangGia=@TenBangGia, BangGiaMacDinh=@BangGiaMacDinh, HienThi=@HienThi WHERE Id=@Id", 
					"@Id",  _SaleBangGia.Id, 
					"@TenBangGia",  _SaleBangGia.TenBangGia, 
					"@BangGiaMacDinh",  _SaleBangGia.BangGiaMacDinh, 
					"@HienThi",  _SaleBangGia.HienThi, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SaleBangGia vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SaleBangGia _SaleBangGia)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleBangGia] SET TenBangGia=@TenBangGia, BangGiaMacDinh=@BangGiaMacDinh, HienThi=@HienThi WHERE Id=@Id", 
					"@TenBangGia",  _SaleBangGia.TenBangGia, 
					"@BangGiaMacDinh",  _SaleBangGia.BangGiaMacDinh, 
					"@HienThi",  _SaleBangGia.HienThi, 
					"@Id", _SaleBangGia.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SaleBangGia vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SaleBangGia> _SaleBangGias)
		{
			foreach (SaleBangGia item in _SaleBangGias)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SaleBangGia vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SaleBangGia _SaleBangGia, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SaleBangGia] SET Id=@Id, TenBangGia=@TenBangGia, BangGiaMacDinh=@BangGiaMacDinh, HienThi=@HienThi "+ condition, 
					"@Id",  _SaleBangGia.Id, 
					"@TenBangGia",  _SaleBangGia.TenBangGia, 
					"@BangGiaMacDinh",  _SaleBangGia.BangGiaMacDinh, 
					"@HienThi",  _SaleBangGia.HienThi);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SaleBangGia trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleBangGia] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleBangGia trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SaleBangGia _SaleBangGia)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleBangGia] WHERE Id=@Id",
					"@Id", _SaleBangGia.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleBangGia trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SaleBangGia] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SaleBangGia trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SaleBangGia> _SaleBangGias)
		{
			foreach (SaleBangGia item in _SaleBangGias)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
