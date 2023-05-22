using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpfee:IGExpfee
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpfee(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpFee từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFee]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFee] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpFee từ Database
		/// </summary>
		public List<GExpFee> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFee]");
				List<GExpFee> items = new List<GExpFee>();
				GExpFee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpFee();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
					{
						item.FeeName = Convert.ToString(dr["FeeName"]);
					}
					if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
					{
						item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
					}
					if (dr["ProvinceApply"] != null && dr["ProvinceApply"] != DBNull.Value)
					{
						item.ProvinceApply = Convert.ToString(dr["ProvinceApply"]);
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
		/// Lấy danh sách GExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpFee> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpFee] A "+ condition,  parameters);
				List<GExpFee> items = new List<GExpFee>();
				GExpFee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpFee();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
					{
						item.FeeName = Convert.ToString(dr["FeeName"]);
					}
					if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
					{
						item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
					}
					if (dr["ProvinceApply"] != null && dr["ProvinceApply"] != DBNull.Value)
					{
						item.ProvinceApply = Convert.ToString(dr["ProvinceApply"]);
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

		public List<GExpFee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpFee] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpFee] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpFee>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpFee từ Database
		/// </summary>
		public GExpFee GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFee] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpFee item=new GExpFee();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
						{
							item.FeeName = Convert.ToString(dr["FeeName"]);
						}
						if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
						{
							item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
						}
						if (dr["ProvinceApply"] != null && dr["ProvinceApply"] != DBNull.Value)
						{
							item.ProvinceApply = Convert.ToString(dr["ProvinceApply"]);
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
		/// Lấy một GExpFee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpFee GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpFee] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpFee item=new GExpFee();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
						{
							item.FeeName = Convert.ToString(dr["FeeName"]);
						}
						if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
						{
							item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
						}
						if (dr["ProvinceApply"] != null && dr["ProvinceApply"] != DBNull.Value)
						{
							item.ProvinceApply = Convert.ToString(dr["ProvinceApply"]);
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

		public GExpFee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpFee] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpFee>(ds);
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
		/// Thêm mới GExpFee vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpFee _GExpFee)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpFee](Id, FK_Post, FeeName, DefaultFee, ProvinceApply) VALUES(@Id, @FK_Post, @FeeName, @DefaultFee, @ProvinceApply)", 
					"@Id",  _GExpFee.Id, 
					"@FK_Post",  _GExpFee.FK_Post, 
					"@FeeName",  _GExpFee.FeeName, 
					"@DefaultFee",  _GExpFee.DefaultFee, 
					"@ProvinceApply",  _GExpFee.ProvinceApply);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpFee vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpFee> _GExpFees)
		{
			foreach (GExpFee item in _GExpFees)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpFee _GExpFee, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFee] SET Id=@Id, FK_Post=@FK_Post, FeeName=@FeeName, DefaultFee=@DefaultFee, ProvinceApply=@ProvinceApply WHERE Id=@Id", 
					"@Id",  _GExpFee.Id, 
					"@FK_Post",  _GExpFee.FK_Post, 
					"@FeeName",  _GExpFee.FeeName, 
					"@DefaultFee",  _GExpFee.DefaultFee, 
					"@ProvinceApply",  _GExpFee.ProvinceApply, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpFee vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpFee _GExpFee)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFee] SET FK_Post=@FK_Post, FeeName=@FeeName, DefaultFee=@DefaultFee, ProvinceApply=@ProvinceApply WHERE Id=@Id", 
					"@FK_Post",  _GExpFee.FK_Post, 
					"@FeeName",  _GExpFee.FeeName, 
					"@DefaultFee",  _GExpFee.DefaultFee, 
					"@ProvinceApply",  _GExpFee.ProvinceApply, 
					"@Id", _GExpFee.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpFee> _GExpFees)
		{
			foreach (GExpFee item in _GExpFees)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpFee vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpFee _GExpFee, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFee] SET Id=@Id, FK_Post=@FK_Post, FeeName=@FeeName, DefaultFee=@DefaultFee, ProvinceApply=@ProvinceApply "+ condition, 
					"@Id",  _GExpFee.Id, 
					"@FK_Post",  _GExpFee.FK_Post, 
					"@FeeName",  _GExpFee.FeeName, 
					"@DefaultFee",  _GExpFee.DefaultFee, 
					"@ProvinceApply",  _GExpFee.ProvinceApply);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpFee trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFee] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFee trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpFee _GExpFee)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFee] WHERE Id=@Id",
					"@Id", _GExpFee.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFee trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFee] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFee trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpFee> _GExpFees)
		{
			foreach (GExpFee item in _GExpFees)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
