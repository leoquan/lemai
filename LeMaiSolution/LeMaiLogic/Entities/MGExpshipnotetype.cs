using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpshipnotetype:IGExpshipnotetype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpshipnotetype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpShipNoteType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipNoteType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpShipNoteType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipNoteType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpShipNoteType từ Database
		/// </summary>
		public List<GExpShipNoteType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipNoteType]");
				List<GExpShipNoteType> items = new List<GExpShipNoteType>();
				GExpShipNoteType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipNoteType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ShipNoteType"] != null && dr["ShipNoteType"] != DBNull.Value)
					{
						item.ShipNoteType = Convert.ToString(dr["ShipNoteType"]);
					}
					if (dr["ShipNoteCode"] != null && dr["ShipNoteCode"] != DBNull.Value)
					{
						item.ShipNoteCode = Convert.ToString(dr["ShipNoteCode"]);
					}
					if (dr["ShipNoteCodeGHN"] != null && dr["ShipNoteCodeGHN"] != DBNull.Value)
					{
						item.ShipNoteCodeGHN = Convert.ToString(dr["ShipNoteCodeGHN"]);
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
		/// Lấy danh sách GExpShipNoteType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpShipNoteType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipNoteType] A "+ condition,  parameters);
				List<GExpShipNoteType> items = new List<GExpShipNoteType>();
				GExpShipNoteType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipNoteType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ShipNoteType"] != null && dr["ShipNoteType"] != DBNull.Value)
					{
						item.ShipNoteType = Convert.ToString(dr["ShipNoteType"]);
					}
					if (dr["ShipNoteCode"] != null && dr["ShipNoteCode"] != DBNull.Value)
					{
						item.ShipNoteCode = Convert.ToString(dr["ShipNoteCode"]);
					}
					if (dr["ShipNoteCodeGHN"] != null && dr["ShipNoteCodeGHN"] != DBNull.Value)
					{
						item.ShipNoteCodeGHN = Convert.ToString(dr["ShipNoteCodeGHN"]);
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

		public List<GExpShipNoteType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipNoteType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpShipNoteType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpShipNoteType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpShipNoteType từ Database
		/// </summary>
		public GExpShipNoteType GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipNoteType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpShipNoteType item=new GExpShipNoteType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ShipNoteType"] != null && dr["ShipNoteType"] != DBNull.Value)
						{
							item.ShipNoteType = Convert.ToString(dr["ShipNoteType"]);
						}
						if (dr["ShipNoteCode"] != null && dr["ShipNoteCode"] != DBNull.Value)
						{
							item.ShipNoteCode = Convert.ToString(dr["ShipNoteCode"]);
						}
						if (dr["ShipNoteCodeGHN"] != null && dr["ShipNoteCodeGHN"] != DBNull.Value)
						{
							item.ShipNoteCodeGHN = Convert.ToString(dr["ShipNoteCodeGHN"]);
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
		/// Lấy một GExpShipNoteType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpShipNoteType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipNoteType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpShipNoteType item=new GExpShipNoteType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ShipNoteType"] != null && dr["ShipNoteType"] != DBNull.Value)
						{
							item.ShipNoteType = Convert.ToString(dr["ShipNoteType"]);
						}
						if (dr["ShipNoteCode"] != null && dr["ShipNoteCode"] != DBNull.Value)
						{
							item.ShipNoteCode = Convert.ToString(dr["ShipNoteCode"]);
						}
						if (dr["ShipNoteCodeGHN"] != null && dr["ShipNoteCodeGHN"] != DBNull.Value)
						{
							item.ShipNoteCodeGHN = Convert.ToString(dr["ShipNoteCodeGHN"]);
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

		public GExpShipNoteType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipNoteType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpShipNoteType>(ds);
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
		/// Thêm mới GExpShipNoteType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpShipNoteType _GExpShipNoteType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpShipNoteType](Id, ShipNoteType, ShipNoteCode, ShipNoteCodeGHN) VALUES(@Id, @ShipNoteType, @ShipNoteCode, @ShipNoteCodeGHN)", 
					"@Id",  _GExpShipNoteType.Id, 
					"@ShipNoteType",  _GExpShipNoteType.ShipNoteType, 
					"@ShipNoteCode",  _GExpShipNoteType.ShipNoteCode, 
					"@ShipNoteCodeGHN",  _GExpShipNoteType.ShipNoteCodeGHN);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpShipNoteType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpShipNoteType> _GExpShipNoteTypes)
		{
			foreach (GExpShipNoteType item in _GExpShipNoteTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipNoteType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpShipNoteType _GExpShipNoteType, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipNoteType] SET Id=@Id, ShipNoteType=@ShipNoteType, ShipNoteCode=@ShipNoteCode, ShipNoteCodeGHN=@ShipNoteCodeGHN WHERE Id=@Id", 
					"@Id",  _GExpShipNoteType.Id, 
					"@ShipNoteType",  _GExpShipNoteType.ShipNoteType, 
					"@ShipNoteCode",  _GExpShipNoteType.ShipNoteCode, 
					"@ShipNoteCodeGHN",  _GExpShipNoteType.ShipNoteCodeGHN, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpShipNoteType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpShipNoteType _GExpShipNoteType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipNoteType] SET ShipNoteType=@ShipNoteType, ShipNoteCode=@ShipNoteCode, ShipNoteCodeGHN=@ShipNoteCodeGHN WHERE Id=@Id", 
					"@ShipNoteType",  _GExpShipNoteType.ShipNoteType, 
					"@ShipNoteCode",  _GExpShipNoteType.ShipNoteCode, 
					"@ShipNoteCodeGHN",  _GExpShipNoteType.ShipNoteCodeGHN, 
					"@Id", _GExpShipNoteType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpShipNoteType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpShipNoteType> _GExpShipNoteTypes)
		{
			foreach (GExpShipNoteType item in _GExpShipNoteTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipNoteType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpShipNoteType _GExpShipNoteType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipNoteType] SET Id=@Id, ShipNoteType=@ShipNoteType, ShipNoteCode=@ShipNoteCode, ShipNoteCodeGHN=@ShipNoteCodeGHN "+ condition, 
					"@Id",  _GExpShipNoteType.Id, 
					"@ShipNoteType",  _GExpShipNoteType.ShipNoteType, 
					"@ShipNoteCode",  _GExpShipNoteType.ShipNoteCode, 
					"@ShipNoteCodeGHN",  _GExpShipNoteType.ShipNoteCodeGHN);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpShipNoteType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipNoteType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipNoteType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpShipNoteType _GExpShipNoteType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipNoteType] WHERE Id=@Id",
					"@Id", _GExpShipNoteType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipNoteType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipNoteType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipNoteType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpShipNoteType> _GExpShipNoteTypes)
		{
			foreach (GExpShipNoteType item in _GExpShipNoteTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
