using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdxnloaimay:IMEdxnloaimay
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdxnloaimay(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedXNLoaiMay từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNLoaiMay]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedXNLoaiMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNLoaiMay] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedXNLoaiMay từ Database
		/// </summary>
		public List<MedXNLoaiMay> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNLoaiMay]");
				List<MedXNLoaiMay> items = new List<MedXNLoaiMay>();
				MedXNLoaiMay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedXNLoaiMay();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
					}
					if (dr["nhom"] != null && dr["nhom"] != DBNull.Value)
					{
						item.nhom = Convert.ToInt32(dr["nhom"]);
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
		/// Lấy danh sách MedXNLoaiMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedXNLoaiMay> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedXNLoaiMay] A "+ condition,  parameters);
				List<MedXNLoaiMay> items = new List<MedXNLoaiMay>();
				MedXNLoaiMay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedXNLoaiMay();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
					}
					if (dr["nhom"] != null && dr["nhom"] != DBNull.Value)
					{
						item.nhom = Convert.ToInt32(dr["nhom"]);
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

		public List<MedXNLoaiMay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedXNLoaiMay] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedXNLoaiMay] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedXNLoaiMay>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedXNLoaiMay từ Database
		/// </summary>
		public MedXNLoaiMay GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNLoaiMay] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedXNLoaiMay item=new MedXNLoaiMay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
						}
						if (dr["nhom"] != null && dr["nhom"] != DBNull.Value)
						{
							item.nhom = Convert.ToInt32(dr["nhom"]);
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
		/// Lấy một MedXNLoaiMay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedXNLoaiMay GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedXNLoaiMay] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedXNLoaiMay item=new MedXNLoaiMay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
						}
						if (dr["nhom"] != null && dr["nhom"] != DBNull.Value)
						{
							item.nhom = Convert.ToInt32(dr["nhom"]);
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

		public MedXNLoaiMay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedXNLoaiMay] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedXNLoaiMay>(ds);
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
		/// Thêm mới MedXNLoaiMay vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedXNLoaiMay _MedXNLoaiMay)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedXNLoaiMay](id, ten, nhom) VALUES(@id, @ten, @nhom)", 
					"@id",  _MedXNLoaiMay.id, 
					"@ten",  _MedXNLoaiMay.ten, 
					"@nhom",  _MedXNLoaiMay.nhom);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedXNLoaiMay vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedXNLoaiMay> _MedXNLoaiMays)
		{
			foreach (MedXNLoaiMay item in _MedXNLoaiMays)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedXNLoaiMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedXNLoaiMay _MedXNLoaiMay, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNLoaiMay] SET id=@id, ten=@ten, nhom=@nhom WHERE id=@id", 
					"@id",  _MedXNLoaiMay.id, 
					"@ten",  _MedXNLoaiMay.ten, 
					"@nhom",  _MedXNLoaiMay.nhom, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedXNLoaiMay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedXNLoaiMay _MedXNLoaiMay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNLoaiMay] SET ten=@ten, nhom=@nhom WHERE id=@id", 
					"@ten",  _MedXNLoaiMay.ten, 
					"@nhom",  _MedXNLoaiMay.nhom, 
					"@id", _MedXNLoaiMay.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedXNLoaiMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedXNLoaiMay> _MedXNLoaiMays)
		{
			foreach (MedXNLoaiMay item in _MedXNLoaiMays)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedXNLoaiMay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedXNLoaiMay _MedXNLoaiMay, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNLoaiMay] SET id=@id, ten=@ten, nhom=@nhom "+ condition, 
					"@id",  _MedXNLoaiMay.id, 
					"@ten",  _MedXNLoaiMay.ten, 
					"@nhom",  _MedXNLoaiMay.nhom);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedXNLoaiMay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNLoaiMay] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNLoaiMay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedXNLoaiMay _MedXNLoaiMay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNLoaiMay] WHERE id=@id",
					"@id", _MedXNLoaiMay.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNLoaiMay trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNLoaiMay] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNLoaiMay trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedXNLoaiMay> _MedXNLoaiMays)
		{
			foreach (MedXNLoaiMay item in _MedXNLoaiMays)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
