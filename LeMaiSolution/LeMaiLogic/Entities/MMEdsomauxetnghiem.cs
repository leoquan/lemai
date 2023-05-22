using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdsomauxetnghiem:IMEdsomauxetnghiem
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdsomauxetnghiem(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedSoMauXetNghiem từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedSoMauXetNghiem]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedSoMauXetNghiem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedSoMauXetNghiem] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedSoMauXetNghiem từ Database
		/// </summary>
		public List<MedSoMauXetNghiem> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedSoMauXetNghiem]");
				List<MedSoMauXetNghiem> items = new List<MedSoMauXetNghiem>();
				MedSoMauXetNghiem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedSoMauXetNghiem();
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
					}
					if (dr["fromsomau"] != null && dr["fromsomau"] != DBNull.Value)
					{
						item.fromsomau = Convert.ToInt32(dr["fromsomau"]);
					}
					if (dr["tosomau"] != null && dr["tosomau"] != DBNull.Value)
					{
						item.tosomau = Convert.ToInt32(dr["tosomau"]);
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
		/// Lấy danh sách MedSoMauXetNghiem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedSoMauXetNghiem> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedSoMauXetNghiem] A "+ condition,  parameters);
				List<MedSoMauXetNghiem> items = new List<MedSoMauXetNghiem>();
				MedSoMauXetNghiem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedSoMauXetNghiem();
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
					}
					if (dr["fromsomau"] != null && dr["fromsomau"] != DBNull.Value)
					{
						item.fromsomau = Convert.ToInt32(dr["fromsomau"]);
					}
					if (dr["tosomau"] != null && dr["tosomau"] != DBNull.Value)
					{
						item.tosomau = Convert.ToInt32(dr["tosomau"]);
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

		public List<MedSoMauXetNghiem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedSoMauXetNghiem] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedSoMauXetNghiem] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedSoMauXetNghiem>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedSoMauXetNghiem từ Database
		/// </summary>
		public MedSoMauXetNghiem GetObject(string schema, String maql)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedSoMauXetNghiem] where maql=@maql",
					"@maql", maql);
				if (ds.Rows.Count > 0)
				{
					MedSoMauXetNghiem item=new MedSoMauXetNghiem();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
						}
						if (dr["fromsomau"] != null && dr["fromsomau"] != DBNull.Value)
						{
							item.fromsomau = Convert.ToInt32(dr["fromsomau"]);
						}
						if (dr["tosomau"] != null && dr["tosomau"] != DBNull.Value)
						{
							item.tosomau = Convert.ToInt32(dr["tosomau"]);
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
		/// Lấy một MedSoMauXetNghiem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedSoMauXetNghiem GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedSoMauXetNghiem] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedSoMauXetNghiem item=new MedSoMauXetNghiem();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
						}
						if (dr["fromsomau"] != null && dr["fromsomau"] != DBNull.Value)
						{
							item.fromsomau = Convert.ToInt32(dr["fromsomau"]);
						}
						if (dr["tosomau"] != null && dr["tosomau"] != DBNull.Value)
						{
							item.tosomau = Convert.ToInt32(dr["tosomau"]);
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

		public MedSoMauXetNghiem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedSoMauXetNghiem] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedSoMauXetNghiem>(ds);
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
		/// Thêm mới MedSoMauXetNghiem vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedSoMauXetNghiem _MedSoMauXetNghiem)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedSoMauXetNghiem](maql, fromsomau, tosomau) VALUES(@maql, @fromsomau, @tosomau)", 
					"@maql",  _MedSoMauXetNghiem.maql, 
					"@fromsomau",  _MedSoMauXetNghiem.fromsomau, 
					"@tosomau",  _MedSoMauXetNghiem.tosomau);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedSoMauXetNghiem vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedSoMauXetNghiem> _MedSoMauXetNghiems)
		{
			foreach (MedSoMauXetNghiem item in _MedSoMauXetNghiems)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedSoMauXetNghiem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedSoMauXetNghiem _MedSoMauXetNghiem, String maql)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedSoMauXetNghiem] SET maql=@maql, fromsomau=@fromsomau, tosomau=@tosomau WHERE maql=@maql", 
					"@maql",  _MedSoMauXetNghiem.maql, 
					"@fromsomau",  _MedSoMauXetNghiem.fromsomau, 
					"@tosomau",  _MedSoMauXetNghiem.tosomau, 
					"@maql", maql);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedSoMauXetNghiem vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedSoMauXetNghiem _MedSoMauXetNghiem)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedSoMauXetNghiem] SET fromsomau=@fromsomau, tosomau=@tosomau WHERE maql=@maql", 
					"@fromsomau",  _MedSoMauXetNghiem.fromsomau, 
					"@tosomau",  _MedSoMauXetNghiem.tosomau, 
					"@maql", _MedSoMauXetNghiem.maql);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedSoMauXetNghiem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedSoMauXetNghiem> _MedSoMauXetNghiems)
		{
			foreach (MedSoMauXetNghiem item in _MedSoMauXetNghiems)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedSoMauXetNghiem vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedSoMauXetNghiem _MedSoMauXetNghiem, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedSoMauXetNghiem] SET maql=@maql, fromsomau=@fromsomau, tosomau=@tosomau "+ condition, 
					"@maql",  _MedSoMauXetNghiem.maql, 
					"@fromsomau",  _MedSoMauXetNghiem.fromsomau, 
					"@tosomau",  _MedSoMauXetNghiem.tosomau);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedSoMauXetNghiem trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String maql)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedSoMauXetNghiem] WHERE maql=@maql",
					"@maql", maql);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedSoMauXetNghiem trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedSoMauXetNghiem _MedSoMauXetNghiem)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedSoMauXetNghiem] WHERE maql=@maql",
					"@maql", _MedSoMauXetNghiem.maql);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedSoMauXetNghiem trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedSoMauXetNghiem] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedSoMauXetNghiem trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedSoMauXetNghiem> _MedSoMauXetNghiems)
		{
			foreach (MedSoMauXetNghiem item in _MedSoMauXetNghiems)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
