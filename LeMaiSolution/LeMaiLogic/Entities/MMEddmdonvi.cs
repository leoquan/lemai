using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEddmdonvi:IMEddmdonvi
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEddmdonvi(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedDmDonVi từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmDonVi]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedDmDonVi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmDonVi] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedDmDonVi từ Database
		/// </summary>
		public List<MedDmDonVi> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmDonVi]");
				List<MedDmDonVi> items = new List<MedDmDonVi>();
				MedDmDonVi item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedDmDonVi();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
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
		/// Lấy danh sách MedDmDonVi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedDmDonVi> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedDmDonVi] A "+ condition,  parameters);
				List<MedDmDonVi> items = new List<MedDmDonVi>();
				MedDmDonVi item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedDmDonVi();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
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

		public List<MedDmDonVi> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedDmDonVi] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedDmDonVi] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedDmDonVi>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedDmDonVi từ Database
		/// </summary>
		public MedDmDonVi GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmDonVi] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedDmDonVi item=new MedDmDonVi();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
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
		/// Lấy một MedDmDonVi đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedDmDonVi GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedDmDonVi] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedDmDonVi item=new MedDmDonVi();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
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

		public MedDmDonVi GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedDmDonVi] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedDmDonVi>(ds);
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
		/// Thêm mới MedDmDonVi vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedDmDonVi _MedDmDonVi)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedDmDonVi](id, ma, ten) VALUES(@id, @ma, @ten)", 
					"@id",  _MedDmDonVi.id, 
					"@ma",  _MedDmDonVi.ma, 
					"@ten",  _MedDmDonVi.ten);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedDmDonVi vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedDmDonVi> _MedDmDonVis)
		{
			foreach (MedDmDonVi item in _MedDmDonVis)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedDmDonVi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedDmDonVi _MedDmDonVi, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmDonVi] SET id=@id, ma=@ma, ten=@ten WHERE id=@id", 
					"@id",  _MedDmDonVi.id, 
					"@ma",  _MedDmDonVi.ma, 
					"@ten",  _MedDmDonVi.ten, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedDmDonVi vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedDmDonVi _MedDmDonVi)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmDonVi] SET ma=@ma, ten=@ten WHERE id=@id", 
					"@ma",  _MedDmDonVi.ma, 
					"@ten",  _MedDmDonVi.ten, 
					"@id", _MedDmDonVi.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedDmDonVi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedDmDonVi> _MedDmDonVis)
		{
			foreach (MedDmDonVi item in _MedDmDonVis)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedDmDonVi vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedDmDonVi _MedDmDonVi, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmDonVi] SET id=@id, ma=@ma, ten=@ten "+ condition, 
					"@id",  _MedDmDonVi.id, 
					"@ma",  _MedDmDonVi.ma, 
					"@ten",  _MedDmDonVi.ten);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedDmDonVi trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmDonVi] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmDonVi trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedDmDonVi _MedDmDonVi)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmDonVi] WHERE id=@id",
					"@id", _MedDmDonVi.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmDonVi trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmDonVi] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmDonVi trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedDmDonVi> _MedDmDonVis)
		{
			foreach (MedDmDonVi item in _MedDmDonVis)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
