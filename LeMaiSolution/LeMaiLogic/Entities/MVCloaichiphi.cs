using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVCloaichiphi:IVCloaichiphi
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVCloaichiphi(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VCLoaiChiPhi từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCLoaiChiPhi]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VCLoaiChiPhi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VCLoaiChiPhi] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VCLoaiChiPhi từ Database
		/// </summary>
		public List<VCLoaiChiPhi> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCLoaiChiPhi]");
				List<VCLoaiChiPhi> items = new List<VCLoaiChiPhi>();
				VCLoaiChiPhi item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCLoaiChiPhi();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenChiPhi"] != null && dr["TenChiPhi"] != DBNull.Value)
					{
						item.TenChiPhi = Convert.ToString(dr["TenChiPhi"]);
					}
					if (dr["TypeCP"] != null && dr["TypeCP"] != DBNull.Value)
					{
						item.TypeCP = Convert.ToInt32(dr["TypeCP"]);
					}
					if (dr["Rate"] != null && dr["Rate"] != DBNull.Value)
					{
						item.Rate = Convert.ToDecimal(dr["Rate"]);
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
		/// Lấy danh sách VCLoaiChiPhi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VCLoaiChiPhi> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCLoaiChiPhi] A "+ condition,  parameters);
				List<VCLoaiChiPhi> items = new List<VCLoaiChiPhi>();
				VCLoaiChiPhi item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VCLoaiChiPhi();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenChiPhi"] != null && dr["TenChiPhi"] != DBNull.Value)
					{
						item.TenChiPhi = Convert.ToString(dr["TenChiPhi"]);
					}
					if (dr["TypeCP"] != null && dr["TypeCP"] != DBNull.Value)
					{
						item.TypeCP = Convert.ToInt32(dr["TypeCP"]);
					}
					if (dr["Rate"] != null && dr["Rate"] != DBNull.Value)
					{
						item.Rate = Convert.ToDecimal(dr["Rate"]);
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

		public List<VCLoaiChiPhi> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCLoaiChiPhi] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VCLoaiChiPhi] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VCLoaiChiPhi>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VCLoaiChiPhi từ Database
		/// </summary>
		public VCLoaiChiPhi GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VCLoaiChiPhi] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					VCLoaiChiPhi item=new VCLoaiChiPhi();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenChiPhi"] != null && dr["TenChiPhi"] != DBNull.Value)
						{
							item.TenChiPhi = Convert.ToString(dr["TenChiPhi"]);
						}
						if (dr["TypeCP"] != null && dr["TypeCP"] != DBNull.Value)
						{
							item.TypeCP = Convert.ToInt32(dr["TypeCP"]);
						}
						if (dr["Rate"] != null && dr["Rate"] != DBNull.Value)
						{
							item.Rate = Convert.ToDecimal(dr["Rate"]);
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
		/// Lấy một VCLoaiChiPhi đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VCLoaiChiPhi GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VCLoaiChiPhi] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VCLoaiChiPhi item=new VCLoaiChiPhi();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenChiPhi"] != null && dr["TenChiPhi"] != DBNull.Value)
						{
							item.TenChiPhi = Convert.ToString(dr["TenChiPhi"]);
						}
						if (dr["TypeCP"] != null && dr["TypeCP"] != DBNull.Value)
						{
							item.TypeCP = Convert.ToInt32(dr["TypeCP"]);
						}
						if (dr["Rate"] != null && dr["Rate"] != DBNull.Value)
						{
							item.Rate = Convert.ToDecimal(dr["Rate"]);
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

		public VCLoaiChiPhi GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VCLoaiChiPhi] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VCLoaiChiPhi>(ds);
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
		/// Thêm mới VCLoaiChiPhi vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VCLoaiChiPhi _VCLoaiChiPhi)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VCLoaiChiPhi](Id, TenChiPhi, TypeCP, Rate) VALUES(@Id, @TenChiPhi, @TypeCP, @Rate)", 
					"@Id",  _VCLoaiChiPhi.Id, 
					"@TenChiPhi",  _VCLoaiChiPhi.TenChiPhi, 
					"@TypeCP",  _VCLoaiChiPhi.TypeCP, 
					"@Rate",  _VCLoaiChiPhi.Rate);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VCLoaiChiPhi vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VCLoaiChiPhi> _VCLoaiChiPhis)
		{
			foreach (VCLoaiChiPhi item in _VCLoaiChiPhis)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCLoaiChiPhi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VCLoaiChiPhi _VCLoaiChiPhi, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCLoaiChiPhi] SET Id=@Id, TenChiPhi=@TenChiPhi, TypeCP=@TypeCP, Rate=@Rate WHERE Id=@Id", 
					"@Id",  _VCLoaiChiPhi.Id, 
					"@TenChiPhi",  _VCLoaiChiPhi.TenChiPhi, 
					"@TypeCP",  _VCLoaiChiPhi.TypeCP, 
					"@Rate",  _VCLoaiChiPhi.Rate, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VCLoaiChiPhi vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VCLoaiChiPhi _VCLoaiChiPhi)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCLoaiChiPhi] SET TenChiPhi=@TenChiPhi, TypeCP=@TypeCP, Rate=@Rate WHERE Id=@Id", 
					"@TenChiPhi",  _VCLoaiChiPhi.TenChiPhi, 
					"@TypeCP",  _VCLoaiChiPhi.TypeCP, 
					"@Rate",  _VCLoaiChiPhi.Rate, 
					"@Id", _VCLoaiChiPhi.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VCLoaiChiPhi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VCLoaiChiPhi> _VCLoaiChiPhis)
		{
			foreach (VCLoaiChiPhi item in _VCLoaiChiPhis)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VCLoaiChiPhi vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VCLoaiChiPhi _VCLoaiChiPhi, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VCLoaiChiPhi] SET Id=@Id, TenChiPhi=@TenChiPhi, TypeCP=@TypeCP, Rate=@Rate "+ condition, 
					"@Id",  _VCLoaiChiPhi.Id, 
					"@TenChiPhi",  _VCLoaiChiPhi.TenChiPhi, 
					"@TypeCP",  _VCLoaiChiPhi.TypeCP, 
					"@Rate",  _VCLoaiChiPhi.Rate);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VCLoaiChiPhi trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCLoaiChiPhi] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCLoaiChiPhi trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VCLoaiChiPhi _VCLoaiChiPhi)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCLoaiChiPhi] WHERE Id=@Id",
					"@Id", _VCLoaiChiPhi.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCLoaiChiPhi trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VCLoaiChiPhi] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VCLoaiChiPhi trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VCLoaiChiPhi> _VCLoaiChiPhis)
		{
			foreach (VCLoaiChiPhi item in _VCLoaiChiPhis)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
