using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprovidersub:IGExpprovidersub
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprovidersub(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProviderSub từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderSub]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProviderSub từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderSub] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProviderSub từ Database
		/// </summary>
		public List<GExpProviderSub> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderSub]");
				List<GExpProviderSub> items = new List<GExpProviderSub>();
				GExpProviderSub item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProviderSub();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
					{
						item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["SubProviderName"] != null && dr["SubProviderName"] != DBNull.Value)
					{
						item.SubProviderName = Convert.ToString(dr["SubProviderName"]);
					}
					if (dr["Token"] != null && dr["Token"] != DBNull.Value)
					{
						item.Token = Convert.ToString(dr["Token"]);
					}
					if (dr["ShopId"] != null && dr["ShopId"] != DBNull.Value)
					{
						item.ShopId = Convert.ToString(dr["ShopId"]);
					}
					if (dr["ClientId"] != null && dr["ClientId"] != DBNull.Value)
					{
						item.ClientId = Convert.ToString(dr["ClientId"]);
					}
					if (dr["MinWeight"] != null && dr["MinWeight"] != DBNull.Value)
					{
						item.MinWeight = Convert.ToInt32(dr["MinWeight"]);
					}
					if (dr["MaxWeight"] != null && dr["MaxWeight"] != DBNull.Value)
					{
						item.MaxWeight = Convert.ToInt32(dr["MaxWeight"]);
					}
					if (dr["TypeCode"] != null && dr["TypeCode"] != DBNull.Value)
					{
						item.TypeCode = Convert.ToString(dr["TypeCode"]);
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
		/// Lấy danh sách GExpProviderSub từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProviderSub> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProviderSub] A "+ condition,  parameters);
				List<GExpProviderSub> items = new List<GExpProviderSub>();
				GExpProviderSub item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProviderSub();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
					{
						item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["SubProviderName"] != null && dr["SubProviderName"] != DBNull.Value)
					{
						item.SubProviderName = Convert.ToString(dr["SubProviderName"]);
					}
					if (dr["Token"] != null && dr["Token"] != DBNull.Value)
					{
						item.Token = Convert.ToString(dr["Token"]);
					}
					if (dr["ShopId"] != null && dr["ShopId"] != DBNull.Value)
					{
						item.ShopId = Convert.ToString(dr["ShopId"]);
					}
					if (dr["ClientId"] != null && dr["ClientId"] != DBNull.Value)
					{
						item.ClientId = Convert.ToString(dr["ClientId"]);
					}
					if (dr["MinWeight"] != null && dr["MinWeight"] != DBNull.Value)
					{
						item.MinWeight = Convert.ToInt32(dr["MinWeight"]);
					}
					if (dr["MaxWeight"] != null && dr["MaxWeight"] != DBNull.Value)
					{
						item.MaxWeight = Convert.ToInt32(dr["MaxWeight"]);
					}
					if (dr["TypeCode"] != null && dr["TypeCode"] != DBNull.Value)
					{
						item.TypeCode = Convert.ToString(dr["TypeCode"]);
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

		public List<GExpProviderSub> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProviderSub] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProviderSub] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProviderSub>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProviderSub từ Database
		/// </summary>
		public GExpProviderSub GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderSub] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpProviderSub item=new GExpProviderSub();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
						{
							item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
						}
						if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
						{
							item.ProviderName = Convert.ToString(dr["ProviderName"]);
						}
						if (dr["SubProviderName"] != null && dr["SubProviderName"] != DBNull.Value)
						{
							item.SubProviderName = Convert.ToString(dr["SubProviderName"]);
						}
						if (dr["Token"] != null && dr["Token"] != DBNull.Value)
						{
							item.Token = Convert.ToString(dr["Token"]);
						}
						if (dr["ShopId"] != null && dr["ShopId"] != DBNull.Value)
						{
							item.ShopId = Convert.ToString(dr["ShopId"]);
						}
						if (dr["ClientId"] != null && dr["ClientId"] != DBNull.Value)
						{
							item.ClientId = Convert.ToString(dr["ClientId"]);
						}
						if (dr["MinWeight"] != null && dr["MinWeight"] != DBNull.Value)
						{
							item.MinWeight = Convert.ToInt32(dr["MinWeight"]);
						}
						if (dr["MaxWeight"] != null && dr["MaxWeight"] != DBNull.Value)
						{
							item.MaxWeight = Convert.ToInt32(dr["MaxWeight"]);
						}
						if (dr["TypeCode"] != null && dr["TypeCode"] != DBNull.Value)
						{
							item.TypeCode = Convert.ToString(dr["TypeCode"]);
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
		/// Lấy một GExpProviderSub đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProviderSub GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProviderSub] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProviderSub item=new GExpProviderSub();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
						{
							item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
						}
						if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
						{
							item.ProviderName = Convert.ToString(dr["ProviderName"]);
						}
						if (dr["SubProviderName"] != null && dr["SubProviderName"] != DBNull.Value)
						{
							item.SubProviderName = Convert.ToString(dr["SubProviderName"]);
						}
						if (dr["Token"] != null && dr["Token"] != DBNull.Value)
						{
							item.Token = Convert.ToString(dr["Token"]);
						}
						if (dr["ShopId"] != null && dr["ShopId"] != DBNull.Value)
						{
							item.ShopId = Convert.ToString(dr["ShopId"]);
						}
						if (dr["ClientId"] != null && dr["ClientId"] != DBNull.Value)
						{
							item.ClientId = Convert.ToString(dr["ClientId"]);
						}
						if (dr["MinWeight"] != null && dr["MinWeight"] != DBNull.Value)
						{
							item.MinWeight = Convert.ToInt32(dr["MinWeight"]);
						}
						if (dr["MaxWeight"] != null && dr["MaxWeight"] != DBNull.Value)
						{
							item.MaxWeight = Convert.ToInt32(dr["MaxWeight"]);
						}
						if (dr["TypeCode"] != null && dr["TypeCode"] != DBNull.Value)
						{
							item.TypeCode = Convert.ToString(dr["TypeCode"]);
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

		public GExpProviderSub GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProviderSub] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProviderSub>(ds);
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
		/// Thêm mới GExpProviderSub vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProviderSub _GExpProviderSub)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProviderSub](Id, FK_Provider, ProviderName, SubProviderName, Token, ShopId, ClientId, MinWeight, MaxWeight, TypeCode) VALUES(@Id, @FK_Provider, @ProviderName, @SubProviderName, @Token, @ShopId, @ClientId, @MinWeight, @MaxWeight, @TypeCode)", 
					"@Id",  _GExpProviderSub.Id, 
					"@FK_Provider",  _GExpProviderSub.FK_Provider, 
					"@ProviderName",  _GExpProviderSub.ProviderName, 
					"@SubProviderName",  _GExpProviderSub.SubProviderName, 
					"@Token",  _GExpProviderSub.Token, 
					"@ShopId",  _GExpProviderSub.ShopId, 
					"@ClientId",  _GExpProviderSub.ClientId, 
					"@MinWeight",  _GExpProviderSub.MinWeight, 
					"@MaxWeight",  _GExpProviderSub.MaxWeight, 
					"@TypeCode",  _GExpProviderSub.TypeCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProviderSub vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProviderSub> _GExpProviderSubs)
		{
			foreach (GExpProviderSub item in _GExpProviderSubs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderSub vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProviderSub _GExpProviderSub, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderSub] SET Id=@Id, FK_Provider=@FK_Provider, ProviderName=@ProviderName, SubProviderName=@SubProviderName, Token=@Token, ShopId=@ShopId, ClientId=@ClientId, MinWeight=@MinWeight, MaxWeight=@MaxWeight, TypeCode=@TypeCode WHERE Id=@Id", 
					"@Id",  _GExpProviderSub.Id, 
					"@FK_Provider",  _GExpProviderSub.FK_Provider, 
					"@ProviderName",  _GExpProviderSub.ProviderName, 
					"@SubProviderName",  _GExpProviderSub.SubProviderName, 
					"@Token",  _GExpProviderSub.Token, 
					"@ShopId",  _GExpProviderSub.ShopId, 
					"@ClientId",  _GExpProviderSub.ClientId, 
					"@MinWeight",  _GExpProviderSub.MinWeight, 
					"@MaxWeight",  _GExpProviderSub.MaxWeight, 
					"@TypeCode",  _GExpProviderSub.TypeCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderSub vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProviderSub _GExpProviderSub)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderSub] SET FK_Provider=@FK_Provider, ProviderName=@ProviderName, SubProviderName=@SubProviderName, Token=@Token, ShopId=@ShopId, ClientId=@ClientId, MinWeight=@MinWeight, MaxWeight=@MaxWeight, TypeCode=@TypeCode WHERE Id=@Id", 
					"@FK_Provider",  _GExpProviderSub.FK_Provider, 
					"@ProviderName",  _GExpProviderSub.ProviderName, 
					"@SubProviderName",  _GExpProviderSub.SubProviderName, 
					"@Token",  _GExpProviderSub.Token, 
					"@ShopId",  _GExpProviderSub.ShopId, 
					"@ClientId",  _GExpProviderSub.ClientId, 
					"@MinWeight",  _GExpProviderSub.MinWeight, 
					"@MaxWeight",  _GExpProviderSub.MaxWeight, 
					"@TypeCode",  _GExpProviderSub.TypeCode, 
					"@Id", _GExpProviderSub.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProviderSub vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProviderSub> _GExpProviderSubs)
		{
			foreach (GExpProviderSub item in _GExpProviderSubs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderSub vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProviderSub _GExpProviderSub, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderSub] SET Id=@Id, FK_Provider=@FK_Provider, ProviderName=@ProviderName, SubProviderName=@SubProviderName, Token=@Token, ShopId=@ShopId, ClientId=@ClientId, MinWeight=@MinWeight, MaxWeight=@MaxWeight, TypeCode=@TypeCode "+ condition, 
					"@Id",  _GExpProviderSub.Id, 
					"@FK_Provider",  _GExpProviderSub.FK_Provider, 
					"@ProviderName",  _GExpProviderSub.ProviderName, 
					"@SubProviderName",  _GExpProviderSub.SubProviderName, 
					"@Token",  _GExpProviderSub.Token, 
					"@ShopId",  _GExpProviderSub.ShopId, 
					"@ClientId",  _GExpProviderSub.ClientId, 
					"@MinWeight",  _GExpProviderSub.MinWeight, 
					"@MaxWeight",  _GExpProviderSub.MaxWeight, 
					"@TypeCode",  _GExpProviderSub.TypeCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProviderSub trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderSub] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderSub trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProviderSub _GExpProviderSub)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderSub] WHERE Id=@Id",
					"@Id", _GExpProviderSub.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderSub trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderSub] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderSub trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProviderSub> _GExpProviderSubs)
		{
			foreach (GExpProviderSub item in _GExpProviderSubs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
