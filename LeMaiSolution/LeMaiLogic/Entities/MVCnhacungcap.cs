using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVCnhacungcap:IVCnhacungcap
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVCnhacungcap(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VCNhaCungCap từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCNhaCungCap]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VCNhaCungCap từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCNhaCungCap] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VCNhaCungCap từ Database
		/// </summary>
		public List<VCNhaCungCap> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCNhaCungCap]");
				List<VCNhaCungCap> items = new List<VCNhaCungCap>();
				VCNhaCungCap item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCNhaCungCap();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaNCC"] != null && dr["MaNCC"] != DBNull.Value)
					{
						item.MaNCC = Convert.ToString(dr["MaNCC"]);
					}
					if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
					{
						item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
					}
					if (dr["TenNhaCungCapKD"] != null && dr["TenNhaCungCapKD"] != DBNull.Value)
					{
						item.TenNhaCungCapKD = Convert.ToString(dr["TenNhaCungCapKD"]);
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
		/// Lấy danh sách VCNhaCungCap từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VCNhaCungCap> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCNhaCungCap] A "+ condition,  parameters);
				List<VCNhaCungCap> items = new List<VCNhaCungCap>();
				VCNhaCungCap item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCNhaCungCap();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaNCC"] != null && dr["MaNCC"] != DBNull.Value)
					{
						item.MaNCC = Convert.ToString(dr["MaNCC"]);
					}
					if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
					{
						item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
					}
					if (dr["TenNhaCungCapKD"] != null && dr["TenNhaCungCapKD"] != DBNull.Value)
					{
						item.TenNhaCungCapKD = Convert.ToString(dr["TenNhaCungCapKD"]);
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

		public List<VCNhaCungCap> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCNhaCungCap] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VCNhaCungCap] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VCNhaCungCap>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VCNhaCungCap từ Database
		/// </summary>
		public VCNhaCungCap GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCNhaCungCap] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					VCNhaCungCap item=new VCNhaCungCap();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaNCC"] != null && dr["MaNCC"] != DBNull.Value)
						{
							item.MaNCC = Convert.ToString(dr["MaNCC"]);
						}
						if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
						{
							item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
						}
						if (dr["TenNhaCungCapKD"] != null && dr["TenNhaCungCapKD"] != DBNull.Value)
						{
							item.TenNhaCungCapKD = Convert.ToString(dr["TenNhaCungCapKD"]);
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
		/// Lấy một VCNhaCungCap đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VCNhaCungCap GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCNhaCungCap] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VCNhaCungCap item=new VCNhaCungCap();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaNCC"] != null && dr["MaNCC"] != DBNull.Value)
						{
							item.MaNCC = Convert.ToString(dr["MaNCC"]);
						}
						if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
						{
							item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
						}
						if (dr["TenNhaCungCapKD"] != null && dr["TenNhaCungCapKD"] != DBNull.Value)
						{
							item.TenNhaCungCapKD = Convert.ToString(dr["TenNhaCungCapKD"]);
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

		public VCNhaCungCap GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCNhaCungCap] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VCNhaCungCap>(ds);
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
		/// Thêm mới VCNhaCungCap vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VCNhaCungCap _VCNhaCungCap)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VCNhaCungCap](Id, MaNCC, TenNhaCungCap, TenNhaCungCapKD) VALUES(@Id, @MaNCC, @TenNhaCungCap, @TenNhaCungCapKD)", 
					"@Id",  _VCNhaCungCap.Id, 
					"@MaNCC",  _VCNhaCungCap.MaNCC, 
					"@TenNhaCungCap",  _VCNhaCungCap.TenNhaCungCap, 
					"@TenNhaCungCapKD",  _VCNhaCungCap.TenNhaCungCapKD);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VCNhaCungCap vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VCNhaCungCap> _VCNhaCungCaps)
		{
			foreach (VCNhaCungCap item in _VCNhaCungCaps)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCNhaCungCap vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VCNhaCungCap _VCNhaCungCap, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCNhaCungCap] SET Id=@Id, MaNCC=@MaNCC, TenNhaCungCap=@TenNhaCungCap, TenNhaCungCapKD=@TenNhaCungCapKD WHERE Id=@Id", 
					"@Id",  _VCNhaCungCap.Id, 
					"@MaNCC",  _VCNhaCungCap.MaNCC, 
					"@TenNhaCungCap",  _VCNhaCungCap.TenNhaCungCap, 
					"@TenNhaCungCapKD",  _VCNhaCungCap.TenNhaCungCapKD, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VCNhaCungCap vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VCNhaCungCap _VCNhaCungCap)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCNhaCungCap] SET MaNCC=@MaNCC, TenNhaCungCap=@TenNhaCungCap, TenNhaCungCapKD=@TenNhaCungCapKD WHERE Id=@Id", 
					"@MaNCC",  _VCNhaCungCap.MaNCC, 
					"@TenNhaCungCap",  _VCNhaCungCap.TenNhaCungCap, 
					"@TenNhaCungCapKD",  _VCNhaCungCap.TenNhaCungCapKD, 
					"@Id", _VCNhaCungCap.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VCNhaCungCap vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VCNhaCungCap> _VCNhaCungCaps)
		{
			foreach (VCNhaCungCap item in _VCNhaCungCaps)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCNhaCungCap vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VCNhaCungCap _VCNhaCungCap, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCNhaCungCap] SET Id=@Id, MaNCC=@MaNCC, TenNhaCungCap=@TenNhaCungCap, TenNhaCungCapKD=@TenNhaCungCapKD "+ condition, 
					"@Id",  _VCNhaCungCap.Id, 
					"@MaNCC",  _VCNhaCungCap.MaNCC, 
					"@TenNhaCungCap",  _VCNhaCungCap.TenNhaCungCap, 
					"@TenNhaCungCapKD",  _VCNhaCungCap.TenNhaCungCapKD);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VCNhaCungCap trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCNhaCungCap] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCNhaCungCap trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VCNhaCungCap _VCNhaCungCap)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCNhaCungCap] WHERE Id=@Id",
					"@Id", _VCNhaCungCap.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCNhaCungCap trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCNhaCungCap] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCNhaCungCap trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VCNhaCungCap> _VCNhaCungCaps)
		{
			foreach (VCNhaCungCap item in _VCNhaCungCaps)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
