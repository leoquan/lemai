using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpautosign:IGExpautosign
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpautosign(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpAutoSign từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpAutoSign]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpAutoSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpAutoSign] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpAutoSign từ Database
		/// </summary>
		public List<GExpAutoSign> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpAutoSign]");
				List<GExpAutoSign> items = new List<GExpAutoSign>();
				GExpAutoSign item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpAutoSign();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ApplyForShipper"] != null && dr["ApplyForShipper"] != DBNull.Value)
					{
						item.ApplyForShipper = Convert.ToBoolean(dr["ApplyForShipper"]);
					}
					if (dr["FK_ShipperOrPost"] != null && dr["FK_ShipperOrPost"] != DBNull.Value)
					{
						item.FK_ShipperOrPost = Convert.ToString(dr["FK_ShipperOrPost"]);
					}
					if (dr["MinuteSign"] != null && dr["MinuteSign"] != DBNull.Value)
					{
						item.MinuteSign = Convert.ToInt32(dr["MinuteSign"]);
					}
					if (dr["ActiveFrom"] != null && dr["ActiveFrom"] != DBNull.Value)
					{
						item.ActiveFrom = Convert.ToDateTime(dr["ActiveFrom"]);
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
		/// Lấy danh sách GExpAutoSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpAutoSign> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpAutoSign] A "+ condition,  parameters);
				List<GExpAutoSign> items = new List<GExpAutoSign>();
				GExpAutoSign item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpAutoSign();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ApplyForShipper"] != null && dr["ApplyForShipper"] != DBNull.Value)
					{
						item.ApplyForShipper = Convert.ToBoolean(dr["ApplyForShipper"]);
					}
					if (dr["FK_ShipperOrPost"] != null && dr["FK_ShipperOrPost"] != DBNull.Value)
					{
						item.FK_ShipperOrPost = Convert.ToString(dr["FK_ShipperOrPost"]);
					}
					if (dr["MinuteSign"] != null && dr["MinuteSign"] != DBNull.Value)
					{
						item.MinuteSign = Convert.ToInt32(dr["MinuteSign"]);
					}
					if (dr["ActiveFrom"] != null && dr["ActiveFrom"] != DBNull.Value)
					{
						item.ActiveFrom = Convert.ToDateTime(dr["ActiveFrom"]);
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

		public List<GExpAutoSign> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpAutoSign] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpAutoSign] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpAutoSign>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpAutoSign từ Database
		/// </summary>
		public GExpAutoSign GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpAutoSign] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpAutoSign item=new GExpAutoSign();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ApplyForShipper"] != null && dr["ApplyForShipper"] != DBNull.Value)
						{
							item.ApplyForShipper = Convert.ToBoolean(dr["ApplyForShipper"]);
						}
						if (dr["FK_ShipperOrPost"] != null && dr["FK_ShipperOrPost"] != DBNull.Value)
						{
							item.FK_ShipperOrPost = Convert.ToString(dr["FK_ShipperOrPost"]);
						}
						if (dr["MinuteSign"] != null && dr["MinuteSign"] != DBNull.Value)
						{
							item.MinuteSign = Convert.ToInt32(dr["MinuteSign"]);
						}
						if (dr["ActiveFrom"] != null && dr["ActiveFrom"] != DBNull.Value)
						{
							item.ActiveFrom = Convert.ToDateTime(dr["ActiveFrom"]);
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
		/// Lấy một GExpAutoSign đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpAutoSign GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpAutoSign] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpAutoSign item=new GExpAutoSign();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ApplyForShipper"] != null && dr["ApplyForShipper"] != DBNull.Value)
						{
							item.ApplyForShipper = Convert.ToBoolean(dr["ApplyForShipper"]);
						}
						if (dr["FK_ShipperOrPost"] != null && dr["FK_ShipperOrPost"] != DBNull.Value)
						{
							item.FK_ShipperOrPost = Convert.ToString(dr["FK_ShipperOrPost"]);
						}
						if (dr["MinuteSign"] != null && dr["MinuteSign"] != DBNull.Value)
						{
							item.MinuteSign = Convert.ToInt32(dr["MinuteSign"]);
						}
						if (dr["ActiveFrom"] != null && dr["ActiveFrom"] != DBNull.Value)
						{
							item.ActiveFrom = Convert.ToDateTime(dr["ActiveFrom"]);
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

		public GExpAutoSign GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpAutoSign] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpAutoSign>(ds);
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
		/// Thêm mới GExpAutoSign vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpAutoSign _GExpAutoSign)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpAutoSign](Id, ApplyForShipper, FK_ShipperOrPost, MinuteSign, ActiveFrom) VALUES(@Id, @ApplyForShipper, @FK_ShipperOrPost, @MinuteSign, @ActiveFrom)", 
					"@Id",  _GExpAutoSign.Id, 
					"@ApplyForShipper",  _GExpAutoSign.ApplyForShipper, 
					"@FK_ShipperOrPost",  _GExpAutoSign.FK_ShipperOrPost, 
					"@MinuteSign",  _GExpAutoSign.MinuteSign, 
					"@ActiveFrom", this._dataContext.ConvertDateString( _GExpAutoSign.ActiveFrom));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpAutoSign vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpAutoSign> _GExpAutoSigns)
		{
			foreach (GExpAutoSign item in _GExpAutoSigns)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpAutoSign vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpAutoSign _GExpAutoSign, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpAutoSign] SET Id=@Id, ApplyForShipper=@ApplyForShipper, FK_ShipperOrPost=@FK_ShipperOrPost, MinuteSign=@MinuteSign, ActiveFrom=@ActiveFrom WHERE Id=@Id", 
					"@Id",  _GExpAutoSign.Id, 
					"@ApplyForShipper",  _GExpAutoSign.ApplyForShipper, 
					"@FK_ShipperOrPost",  _GExpAutoSign.FK_ShipperOrPost, 
					"@MinuteSign",  _GExpAutoSign.MinuteSign, 
					"@ActiveFrom", this._dataContext.ConvertDateString( _GExpAutoSign.ActiveFrom), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpAutoSign vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpAutoSign _GExpAutoSign)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpAutoSign] SET ApplyForShipper=@ApplyForShipper, FK_ShipperOrPost=@FK_ShipperOrPost, MinuteSign=@MinuteSign, ActiveFrom=@ActiveFrom WHERE Id=@Id", 
					"@ApplyForShipper",  _GExpAutoSign.ApplyForShipper, 
					"@FK_ShipperOrPost",  _GExpAutoSign.FK_ShipperOrPost, 
					"@MinuteSign",  _GExpAutoSign.MinuteSign, 
					"@ActiveFrom", this._dataContext.ConvertDateString( _GExpAutoSign.ActiveFrom), 
					"@Id", _GExpAutoSign.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpAutoSign vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpAutoSign> _GExpAutoSigns)
		{
			foreach (GExpAutoSign item in _GExpAutoSigns)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpAutoSign vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpAutoSign _GExpAutoSign, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpAutoSign] SET Id=@Id, ApplyForShipper=@ApplyForShipper, FK_ShipperOrPost=@FK_ShipperOrPost, MinuteSign=@MinuteSign, ActiveFrom=@ActiveFrom "+ condition, 
					"@Id",  _GExpAutoSign.Id, 
					"@ApplyForShipper",  _GExpAutoSign.ApplyForShipper, 
					"@FK_ShipperOrPost",  _GExpAutoSign.FK_ShipperOrPost, 
					"@MinuteSign",  _GExpAutoSign.MinuteSign, 
					"@ActiveFrom", this._dataContext.ConvertDateString( _GExpAutoSign.ActiveFrom));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpAutoSign trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpAutoSign] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpAutoSign trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpAutoSign _GExpAutoSign)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpAutoSign] WHERE Id=@Id",
					"@Id", _GExpAutoSign.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpAutoSign trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpAutoSign] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpAutoSign trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpAutoSign> _GExpAutoSigns)
		{
			foreach (GExpAutoSign item in _GExpAutoSigns)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
