using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpsender:IGExpsender
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpsender(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpSender từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpSender]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpSender từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpSender] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpSender từ Database
		/// </summary>
		public List<GExpSender> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpSender]");
				List<GExpSender> items = new List<GExpSender>();
				GExpSender item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpSender();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
					{
						item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
					}
					if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
					{
						item.SendMan = Convert.ToString(dr["SendMan"]);
					}
					if (dr["SendAddress"] != null && dr["SendAddress"] != DBNull.Value)
					{
						item.SendAddress = Convert.ToString(dr["SendAddress"]);
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
		/// Lấy danh sách GExpSender từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpSender> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpSender] A "+ condition,  parameters);
				List<GExpSender> items = new List<GExpSender>();
				GExpSender item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpSender();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
					{
						item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
					}
					if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
					{
						item.SendMan = Convert.ToString(dr["SendMan"]);
					}
					if (dr["SendAddress"] != null && dr["SendAddress"] != DBNull.Value)
					{
						item.SendAddress = Convert.ToString(dr["SendAddress"]);
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

		public List<GExpSender> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpSender] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpSender] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpSender>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpSender từ Database
		/// </summary>
		public GExpSender GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpSender] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpSender item=new GExpSender();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
						{
							item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
						}
						if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
						{
							item.SendMan = Convert.ToString(dr["SendMan"]);
						}
						if (dr["SendAddress"] != null && dr["SendAddress"] != DBNull.Value)
						{
							item.SendAddress = Convert.ToString(dr["SendAddress"]);
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
		/// Lấy một GExpSender đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpSender GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpSender] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpSender item=new GExpSender();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
						{
							item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
						}
						if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
						{
							item.SendMan = Convert.ToString(dr["SendMan"]);
						}
						if (dr["SendAddress"] != null && dr["SendAddress"] != DBNull.Value)
						{
							item.SendAddress = Convert.ToString(dr["SendAddress"]);
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

		public GExpSender GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpSender] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpSender>(ds);
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
		/// Thêm mới GExpSender vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpSender _GExpSender)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpSender](Id, SendManPhone, SendMan, SendAddress) VALUES(@Id, @SendManPhone, @SendMan, @SendAddress)", 
					"@Id",  _GExpSender.Id, 
					"@SendManPhone",  _GExpSender.SendManPhone, 
					"@SendMan",  _GExpSender.SendMan, 
					"@SendAddress",  _GExpSender.SendAddress);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpSender vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpSender> _GExpSenders)
		{
			foreach (GExpSender item in _GExpSenders)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpSender vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpSender _GExpSender, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpSender] SET Id=@Id, SendManPhone=@SendManPhone, SendMan=@SendMan, SendAddress=@SendAddress WHERE Id=@Id", 
					"@Id",  _GExpSender.Id, 
					"@SendManPhone",  _GExpSender.SendManPhone, 
					"@SendMan",  _GExpSender.SendMan, 
					"@SendAddress",  _GExpSender.SendAddress, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpSender vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpSender _GExpSender)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpSender] SET SendManPhone=@SendManPhone, SendMan=@SendMan, SendAddress=@SendAddress WHERE Id=@Id", 
					"@SendManPhone",  _GExpSender.SendManPhone, 
					"@SendMan",  _GExpSender.SendMan, 
					"@SendAddress",  _GExpSender.SendAddress, 
					"@Id", _GExpSender.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpSender vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpSender> _GExpSenders)
		{
			foreach (GExpSender item in _GExpSenders)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpSender vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpSender _GExpSender, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpSender] SET Id=@Id, SendManPhone=@SendManPhone, SendMan=@SendMan, SendAddress=@SendAddress "+ condition, 
					"@Id",  _GExpSender.Id, 
					"@SendManPhone",  _GExpSender.SendManPhone, 
					"@SendMan",  _GExpSender.SendMan, 
					"@SendAddress",  _GExpSender.SendAddress);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpSender trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpSender] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpSender trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpSender _GExpSender)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpSender] WHERE Id=@Id",
					"@Id", _GExpSender.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpSender trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpSender] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpSender trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpSender> _GExpSenders)
		{
			foreach (GExpSender item in _GExpSenders)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
