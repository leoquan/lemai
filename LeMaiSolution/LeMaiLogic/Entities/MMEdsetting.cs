using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdsetting:IMEdsetting
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdsetting(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedSetting từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedSetting]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedSetting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedSetting] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedSetting từ Database
		/// </summary>
		public List<MedSetting> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedSetting]");
				List<MedSetting> items = new List<MedSetting>();
				MedSetting item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedSetting();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["giatri"] != null && dr["giatri"] != DBNull.Value)
					{
						item.giatri = Convert.ToString(dr["giatri"]);
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
		/// Lấy danh sách MedSetting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedSetting> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedSetting] A "+ condition,  parameters);
				List<MedSetting> items = new List<MedSetting>();
				MedSetting item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedSetting();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["giatri"] != null && dr["giatri"] != DBNull.Value)
					{
						item.giatri = Convert.ToString(dr["giatri"]);
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

		public List<MedSetting> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedSetting] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedSetting] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedSetting>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedSetting từ Database
		/// </summary>
		public MedSetting GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedSetting] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedSetting item=new MedSetting();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["giatri"] != null && dr["giatri"] != DBNull.Value)
						{
							item.giatri = Convert.ToString(dr["giatri"]);
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
		/// Lấy một MedSetting đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedSetting GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedSetting] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedSetting item=new MedSetting();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["giatri"] != null && dr["giatri"] != DBNull.Value)
						{
							item.giatri = Convert.ToString(dr["giatri"]);
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

		public MedSetting GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedSetting] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedSetting>(ds);
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
		/// Thêm mới MedSetting vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedSetting _MedSetting)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedSetting](id, giatri) VALUES(@id, @giatri)", 
					"@id",  _MedSetting.id, 
					"@giatri",  _MedSetting.giatri);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedSetting vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedSetting> _MedSettings)
		{
			foreach (MedSetting item in _MedSettings)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedSetting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedSetting _MedSetting, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedSetting] SET id=@id, giatri=@giatri WHERE id=@id", 
					"@id",  _MedSetting.id, 
					"@giatri",  _MedSetting.giatri, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedSetting vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedSetting _MedSetting)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedSetting] SET giatri=@giatri WHERE id=@id", 
					"@giatri",  _MedSetting.giatri, 
					"@id", _MedSetting.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedSetting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedSetting> _MedSettings)
		{
			foreach (MedSetting item in _MedSettings)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedSetting vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedSetting _MedSetting, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedSetting] SET id=@id, giatri=@giatri "+ condition, 
					"@id",  _MedSetting.id, 
					"@giatri",  _MedSetting.giatri);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedSetting trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedSetting] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedSetting trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedSetting _MedSetting)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedSetting] WHERE id=@id",
					"@id", _MedSetting.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedSetting trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedSetting] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedSetting trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedSetting> _MedSettings)
		{
			foreach (MedSetting item in _MedSettings)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
