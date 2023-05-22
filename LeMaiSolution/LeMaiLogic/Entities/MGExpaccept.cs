using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpaccept:IGExpaccept
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpaccept(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpAccept từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpAccept]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpAccept từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpAccept] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpAccept từ Database
		/// </summary>
		public List<GExpAccept> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpAccept]");
				List<GExpAccept> items = new List<GExpAccept>();
				GExpAccept item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpAccept();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
					}
					if (dr["AcceptPhone"] != null && dr["AcceptPhone"] != DBNull.Value)
					{
						item.AcceptPhone = Convert.ToString(dr["AcceptPhone"]);
					}
					if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
					{
						item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
					}
					if (dr["AcceptAddressFull"] != null && dr["AcceptAddressFull"] != DBNull.Value)
					{
						item.AcceptAddressFull = Convert.ToString(dr["AcceptAddressFull"]);
					}
					if (dr["AcceptProvince"] != null && dr["AcceptProvince"] != DBNull.Value)
					{
						item.AcceptProvince = Convert.ToInt32(dr["AcceptProvince"]);
					}
					if (dr["AcceptDistrict"] != null && dr["AcceptDistrict"] != DBNull.Value)
					{
						item.AcceptDistrict = Convert.ToInt32(dr["AcceptDistrict"]);
					}
					if (dr["AcceptWard"] != null && dr["AcceptWard"] != DBNull.Value)
					{
						item.AcceptWard = Convert.ToString(dr["AcceptWard"]);
					}
					if (dr["AcceptLevel"] != null && dr["AcceptLevel"] != DBNull.Value)
					{
						item.AcceptLevel = Convert.ToInt32(dr["AcceptLevel"]);
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
		/// Lấy danh sách GExpAccept từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpAccept> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpAccept] A "+ condition,  parameters);
				List<GExpAccept> items = new List<GExpAccept>();
				GExpAccept item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpAccept();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
					}
					if (dr["AcceptPhone"] != null && dr["AcceptPhone"] != DBNull.Value)
					{
						item.AcceptPhone = Convert.ToString(dr["AcceptPhone"]);
					}
					if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
					{
						item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
					}
					if (dr["AcceptAddressFull"] != null && dr["AcceptAddressFull"] != DBNull.Value)
					{
						item.AcceptAddressFull = Convert.ToString(dr["AcceptAddressFull"]);
					}
					if (dr["AcceptProvince"] != null && dr["AcceptProvince"] != DBNull.Value)
					{
						item.AcceptProvince = Convert.ToInt32(dr["AcceptProvince"]);
					}
					if (dr["AcceptDistrict"] != null && dr["AcceptDistrict"] != DBNull.Value)
					{
						item.AcceptDistrict = Convert.ToInt32(dr["AcceptDistrict"]);
					}
					if (dr["AcceptWard"] != null && dr["AcceptWard"] != DBNull.Value)
					{
						item.AcceptWard = Convert.ToString(dr["AcceptWard"]);
					}
					if (dr["AcceptLevel"] != null && dr["AcceptLevel"] != DBNull.Value)
					{
						item.AcceptLevel = Convert.ToInt32(dr["AcceptLevel"]);
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

		public List<GExpAccept> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpAccept] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpAccept] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpAccept>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpAccept từ Database
		/// </summary>
		public GExpAccept GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpAccept] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpAccept item=new GExpAccept();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
						{
							item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
						}
						if (dr["AcceptPhone"] != null && dr["AcceptPhone"] != DBNull.Value)
						{
							item.AcceptPhone = Convert.ToString(dr["AcceptPhone"]);
						}
						if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
						{
							item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
						}
						if (dr["AcceptAddressFull"] != null && dr["AcceptAddressFull"] != DBNull.Value)
						{
							item.AcceptAddressFull = Convert.ToString(dr["AcceptAddressFull"]);
						}
						if (dr["AcceptProvince"] != null && dr["AcceptProvince"] != DBNull.Value)
						{
							item.AcceptProvince = Convert.ToInt32(dr["AcceptProvince"]);
						}
						if (dr["AcceptDistrict"] != null && dr["AcceptDistrict"] != DBNull.Value)
						{
							item.AcceptDistrict = Convert.ToInt32(dr["AcceptDistrict"]);
						}
						if (dr["AcceptWard"] != null && dr["AcceptWard"] != DBNull.Value)
						{
							item.AcceptWard = Convert.ToString(dr["AcceptWard"]);
						}
						if (dr["AcceptLevel"] != null && dr["AcceptLevel"] != DBNull.Value)
						{
							item.AcceptLevel = Convert.ToInt32(dr["AcceptLevel"]);
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
		/// Lấy một GExpAccept đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpAccept GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpAccept] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpAccept item=new GExpAccept();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
						{
							item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
						}
						if (dr["AcceptPhone"] != null && dr["AcceptPhone"] != DBNull.Value)
						{
							item.AcceptPhone = Convert.ToString(dr["AcceptPhone"]);
						}
						if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
						{
							item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
						}
						if (dr["AcceptAddressFull"] != null && dr["AcceptAddressFull"] != DBNull.Value)
						{
							item.AcceptAddressFull = Convert.ToString(dr["AcceptAddressFull"]);
						}
						if (dr["AcceptProvince"] != null && dr["AcceptProvince"] != DBNull.Value)
						{
							item.AcceptProvince = Convert.ToInt32(dr["AcceptProvince"]);
						}
						if (dr["AcceptDistrict"] != null && dr["AcceptDistrict"] != DBNull.Value)
						{
							item.AcceptDistrict = Convert.ToInt32(dr["AcceptDistrict"]);
						}
						if (dr["AcceptWard"] != null && dr["AcceptWard"] != DBNull.Value)
						{
							item.AcceptWard = Convert.ToString(dr["AcceptWard"]);
						}
						if (dr["AcceptLevel"] != null && dr["AcceptLevel"] != DBNull.Value)
						{
							item.AcceptLevel = Convert.ToInt32(dr["AcceptLevel"]);
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

		public GExpAccept GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpAccept] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpAccept>(ds);
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
		/// Thêm mới GExpAccept vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpAccept _GExpAccept)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpAccept](Id, AcceptMan, AcceptPhone, AcceptAddress, AcceptAddressFull, AcceptProvince, AcceptDistrict, AcceptWard, AcceptLevel) VALUES(@Id, @AcceptMan, @AcceptPhone, @AcceptAddress, @AcceptAddressFull, @AcceptProvince, @AcceptDistrict, @AcceptWard, @AcceptLevel)", 
					"@Id",  _GExpAccept.Id, 
					"@AcceptMan",  _GExpAccept.AcceptMan, 
					"@AcceptPhone",  _GExpAccept.AcceptPhone, 
					"@AcceptAddress",  _GExpAccept.AcceptAddress, 
					"@AcceptAddressFull",  _GExpAccept.AcceptAddressFull, 
					"@AcceptProvince",  _GExpAccept.AcceptProvince, 
					"@AcceptDistrict",  _GExpAccept.AcceptDistrict, 
					"@AcceptWard",  _GExpAccept.AcceptWard, 
					"@AcceptLevel",  _GExpAccept.AcceptLevel);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpAccept vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpAccept> _GExpAccepts)
		{
			foreach (GExpAccept item in _GExpAccepts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpAccept vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpAccept _GExpAccept, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpAccept] SET Id=@Id, AcceptMan=@AcceptMan, AcceptPhone=@AcceptPhone, AcceptAddress=@AcceptAddress, AcceptAddressFull=@AcceptAddressFull, AcceptProvince=@AcceptProvince, AcceptDistrict=@AcceptDistrict, AcceptWard=@AcceptWard, AcceptLevel=@AcceptLevel WHERE Id=@Id", 
					"@Id",  _GExpAccept.Id, 
					"@AcceptMan",  _GExpAccept.AcceptMan, 
					"@AcceptPhone",  _GExpAccept.AcceptPhone, 
					"@AcceptAddress",  _GExpAccept.AcceptAddress, 
					"@AcceptAddressFull",  _GExpAccept.AcceptAddressFull, 
					"@AcceptProvince",  _GExpAccept.AcceptProvince, 
					"@AcceptDistrict",  _GExpAccept.AcceptDistrict, 
					"@AcceptWard",  _GExpAccept.AcceptWard, 
					"@AcceptLevel",  _GExpAccept.AcceptLevel, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpAccept vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpAccept _GExpAccept)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpAccept] SET AcceptMan=@AcceptMan, AcceptPhone=@AcceptPhone, AcceptAddress=@AcceptAddress, AcceptAddressFull=@AcceptAddressFull, AcceptProvince=@AcceptProvince, AcceptDistrict=@AcceptDistrict, AcceptWard=@AcceptWard, AcceptLevel=@AcceptLevel WHERE Id=@Id", 
					"@AcceptMan",  _GExpAccept.AcceptMan, 
					"@AcceptPhone",  _GExpAccept.AcceptPhone, 
					"@AcceptAddress",  _GExpAccept.AcceptAddress, 
					"@AcceptAddressFull",  _GExpAccept.AcceptAddressFull, 
					"@AcceptProvince",  _GExpAccept.AcceptProvince, 
					"@AcceptDistrict",  _GExpAccept.AcceptDistrict, 
					"@AcceptWard",  _GExpAccept.AcceptWard, 
					"@AcceptLevel",  _GExpAccept.AcceptLevel, 
					"@Id", _GExpAccept.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpAccept vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpAccept> _GExpAccepts)
		{
			foreach (GExpAccept item in _GExpAccepts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpAccept vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpAccept _GExpAccept, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpAccept] SET Id=@Id, AcceptMan=@AcceptMan, AcceptPhone=@AcceptPhone, AcceptAddress=@AcceptAddress, AcceptAddressFull=@AcceptAddressFull, AcceptProvince=@AcceptProvince, AcceptDistrict=@AcceptDistrict, AcceptWard=@AcceptWard, AcceptLevel=@AcceptLevel "+ condition, 
					"@Id",  _GExpAccept.Id, 
					"@AcceptMan",  _GExpAccept.AcceptMan, 
					"@AcceptPhone",  _GExpAccept.AcceptPhone, 
					"@AcceptAddress",  _GExpAccept.AcceptAddress, 
					"@AcceptAddressFull",  _GExpAccept.AcceptAddressFull, 
					"@AcceptProvince",  _GExpAccept.AcceptProvince, 
					"@AcceptDistrict",  _GExpAccept.AcceptDistrict, 
					"@AcceptWard",  _GExpAccept.AcceptWard, 
					"@AcceptLevel",  _GExpAccept.AcceptLevel);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpAccept trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpAccept] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpAccept trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpAccept _GExpAccept)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpAccept] WHERE Id=@Id",
					"@Id", _GExpAccept.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpAccept trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpAccept] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpAccept trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpAccept> _GExpAccepts)
		{
			foreach (GExpAccept item in _GExpAccepts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
