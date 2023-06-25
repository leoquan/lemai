using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpproviderconfig:IGExpproviderconfig
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpproviderconfig(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProviderConfig từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderConfig]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProviderConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderConfig] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProviderConfig từ Database
		/// </summary>
		public List<GExpProviderConfig> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderConfig]");
				List<GExpProviderConfig> items = new List<GExpProviderConfig>();
				GExpProviderConfig item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProviderConfig();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_FromPost"] != null && dr["FK_FromPost"] != DBNull.Value)
					{
						item.FK_FromPost = Convert.ToString(dr["FK_FromPost"]);
					}
					if (dr["FK_ToPost"] != null && dr["FK_ToPost"] != DBNull.Value)
					{
						item.FK_ToPost = Convert.ToString(dr["FK_ToPost"]);
					}
					if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
					{
						item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
					}
					if (dr["DeliveryInitPrice"] != null && dr["DeliveryInitPrice"] != DBNull.Value)
					{
						item.DeliveryInitPrice = Convert.ToInt32(dr["DeliveryInitPrice"]);
					}
					if (dr["DeliveryInitWeight"] != null && dr["DeliveryInitWeight"] != DBNull.Value)
					{
						item.DeliveryInitWeight = Convert.ToInt32(dr["DeliveryInitWeight"]);
					}
					if (dr["DeliveryStepWeight"] != null && dr["DeliveryStepWeight"] != DBNull.Value)
					{
						item.DeliveryStepWeight = Convert.ToInt32(dr["DeliveryStepWeight"]);
					}
					if (dr["DeliveryStepPrice"] != null && dr["DeliveryStepPrice"] != DBNull.Value)
					{
						item.DeliveryStepPrice = Convert.ToInt32(dr["DeliveryStepPrice"]);
					}
					if (dr["SysInitPrice"] != null && dr["SysInitPrice"] != DBNull.Value)
					{
						item.SysInitPrice = Convert.ToInt32(dr["SysInitPrice"]);
					}
					if (dr["SysInitWeight"] != null && dr["SysInitWeight"] != DBNull.Value)
					{
						item.SysInitWeight = Convert.ToInt32(dr["SysInitWeight"]);
					}
					if (dr["SysStepWeight"] != null && dr["SysStepWeight"] != DBNull.Value)
					{
						item.SysStepWeight = Convert.ToInt32(dr["SysStepWeight"]);
					}
					if (dr["SysStepPrice"] != null && dr["SysStepPrice"] != DBNull.Value)
					{
						item.SysStepPrice = Convert.ToInt32(dr["SysStepPrice"]);
					}
					if (dr["TranInitPrice"] != null && dr["TranInitPrice"] != DBNull.Value)
					{
						item.TranInitPrice = Convert.ToInt32(dr["TranInitPrice"]);
					}
					if (dr["TranInitWeight"] != null && dr["TranInitWeight"] != DBNull.Value)
					{
						item.TranInitWeight = Convert.ToInt32(dr["TranInitWeight"]);
					}
					if (dr["TranStepWeight"] != null && dr["TranStepWeight"] != DBNull.Value)
					{
						item.TranStepWeight = Convert.ToInt32(dr["TranStepWeight"]);
					}
					if (dr["TranStepPrice"] != null && dr["TranStepPrice"] != DBNull.Value)
					{
						item.TranStepPrice = Convert.ToInt32(dr["TranStepPrice"]);
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
		/// Lấy danh sách GExpProviderConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProviderConfig> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProviderConfig] A "+ condition,  parameters);
				List<GExpProviderConfig> items = new List<GExpProviderConfig>();
				GExpProviderConfig item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProviderConfig();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_FromPost"] != null && dr["FK_FromPost"] != DBNull.Value)
					{
						item.FK_FromPost = Convert.ToString(dr["FK_FromPost"]);
					}
					if (dr["FK_ToPost"] != null && dr["FK_ToPost"] != DBNull.Value)
					{
						item.FK_ToPost = Convert.ToString(dr["FK_ToPost"]);
					}
					if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
					{
						item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
					}
					if (dr["DeliveryInitPrice"] != null && dr["DeliveryInitPrice"] != DBNull.Value)
					{
						item.DeliveryInitPrice = Convert.ToInt32(dr["DeliveryInitPrice"]);
					}
					if (dr["DeliveryInitWeight"] != null && dr["DeliveryInitWeight"] != DBNull.Value)
					{
						item.DeliveryInitWeight = Convert.ToInt32(dr["DeliveryInitWeight"]);
					}
					if (dr["DeliveryStepWeight"] != null && dr["DeliveryStepWeight"] != DBNull.Value)
					{
						item.DeliveryStepWeight = Convert.ToInt32(dr["DeliveryStepWeight"]);
					}
					if (dr["DeliveryStepPrice"] != null && dr["DeliveryStepPrice"] != DBNull.Value)
					{
						item.DeliveryStepPrice = Convert.ToInt32(dr["DeliveryStepPrice"]);
					}
					if (dr["SysInitPrice"] != null && dr["SysInitPrice"] != DBNull.Value)
					{
						item.SysInitPrice = Convert.ToInt32(dr["SysInitPrice"]);
					}
					if (dr["SysInitWeight"] != null && dr["SysInitWeight"] != DBNull.Value)
					{
						item.SysInitWeight = Convert.ToInt32(dr["SysInitWeight"]);
					}
					if (dr["SysStepWeight"] != null && dr["SysStepWeight"] != DBNull.Value)
					{
						item.SysStepWeight = Convert.ToInt32(dr["SysStepWeight"]);
					}
					if (dr["SysStepPrice"] != null && dr["SysStepPrice"] != DBNull.Value)
					{
						item.SysStepPrice = Convert.ToInt32(dr["SysStepPrice"]);
					}
					if (dr["TranInitPrice"] != null && dr["TranInitPrice"] != DBNull.Value)
					{
						item.TranInitPrice = Convert.ToInt32(dr["TranInitPrice"]);
					}
					if (dr["TranInitWeight"] != null && dr["TranInitWeight"] != DBNull.Value)
					{
						item.TranInitWeight = Convert.ToInt32(dr["TranInitWeight"]);
					}
					if (dr["TranStepWeight"] != null && dr["TranStepWeight"] != DBNull.Value)
					{
						item.TranStepWeight = Convert.ToInt32(dr["TranStepWeight"]);
					}
					if (dr["TranStepPrice"] != null && dr["TranStepPrice"] != DBNull.Value)
					{
						item.TranStepPrice = Convert.ToInt32(dr["TranStepPrice"]);
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

		public List<GExpProviderConfig> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProviderConfig] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProviderConfig] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProviderConfig>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProviderConfig từ Database
		/// </summary>
		public GExpProviderConfig GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderConfig] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpProviderConfig item=new GExpProviderConfig();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_FromPost"] != null && dr["FK_FromPost"] != DBNull.Value)
						{
							item.FK_FromPost = Convert.ToString(dr["FK_FromPost"]);
						}
						if (dr["FK_ToPost"] != null && dr["FK_ToPost"] != DBNull.Value)
						{
							item.FK_ToPost = Convert.ToString(dr["FK_ToPost"]);
						}
						if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
						{
							item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
						}
						if (dr["DeliveryInitPrice"] != null && dr["DeliveryInitPrice"] != DBNull.Value)
						{
							item.DeliveryInitPrice = Convert.ToInt32(dr["DeliveryInitPrice"]);
						}
						if (dr["DeliveryInitWeight"] != null && dr["DeliveryInitWeight"] != DBNull.Value)
						{
							item.DeliveryInitWeight = Convert.ToInt32(dr["DeliveryInitWeight"]);
						}
						if (dr["DeliveryStepWeight"] != null && dr["DeliveryStepWeight"] != DBNull.Value)
						{
							item.DeliveryStepWeight = Convert.ToInt32(dr["DeliveryStepWeight"]);
						}
						if (dr["DeliveryStepPrice"] != null && dr["DeliveryStepPrice"] != DBNull.Value)
						{
							item.DeliveryStepPrice = Convert.ToInt32(dr["DeliveryStepPrice"]);
						}
						if (dr["SysInitPrice"] != null && dr["SysInitPrice"] != DBNull.Value)
						{
							item.SysInitPrice = Convert.ToInt32(dr["SysInitPrice"]);
						}
						if (dr["SysInitWeight"] != null && dr["SysInitWeight"] != DBNull.Value)
						{
							item.SysInitWeight = Convert.ToInt32(dr["SysInitWeight"]);
						}
						if (dr["SysStepWeight"] != null && dr["SysStepWeight"] != DBNull.Value)
						{
							item.SysStepWeight = Convert.ToInt32(dr["SysStepWeight"]);
						}
						if (dr["SysStepPrice"] != null && dr["SysStepPrice"] != DBNull.Value)
						{
							item.SysStepPrice = Convert.ToInt32(dr["SysStepPrice"]);
						}
						if (dr["TranInitPrice"] != null && dr["TranInitPrice"] != DBNull.Value)
						{
							item.TranInitPrice = Convert.ToInt32(dr["TranInitPrice"]);
						}
						if (dr["TranInitWeight"] != null && dr["TranInitWeight"] != DBNull.Value)
						{
							item.TranInitWeight = Convert.ToInt32(dr["TranInitWeight"]);
						}
						if (dr["TranStepWeight"] != null && dr["TranStepWeight"] != DBNull.Value)
						{
							item.TranStepWeight = Convert.ToInt32(dr["TranStepWeight"]);
						}
						if (dr["TranStepPrice"] != null && dr["TranStepPrice"] != DBNull.Value)
						{
							item.TranStepPrice = Convert.ToInt32(dr["TranStepPrice"]);
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
		/// Lấy một GExpProviderConfig đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProviderConfig GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProviderConfig] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProviderConfig item=new GExpProviderConfig();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_FromPost"] != null && dr["FK_FromPost"] != DBNull.Value)
						{
							item.FK_FromPost = Convert.ToString(dr["FK_FromPost"]);
						}
						if (dr["FK_ToPost"] != null && dr["FK_ToPost"] != DBNull.Value)
						{
							item.FK_ToPost = Convert.ToString(dr["FK_ToPost"]);
						}
						if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
						{
							item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
						}
						if (dr["DeliveryInitPrice"] != null && dr["DeliveryInitPrice"] != DBNull.Value)
						{
							item.DeliveryInitPrice = Convert.ToInt32(dr["DeliveryInitPrice"]);
						}
						if (dr["DeliveryInitWeight"] != null && dr["DeliveryInitWeight"] != DBNull.Value)
						{
							item.DeliveryInitWeight = Convert.ToInt32(dr["DeliveryInitWeight"]);
						}
						if (dr["DeliveryStepWeight"] != null && dr["DeliveryStepWeight"] != DBNull.Value)
						{
							item.DeliveryStepWeight = Convert.ToInt32(dr["DeliveryStepWeight"]);
						}
						if (dr["DeliveryStepPrice"] != null && dr["DeliveryStepPrice"] != DBNull.Value)
						{
							item.DeliveryStepPrice = Convert.ToInt32(dr["DeliveryStepPrice"]);
						}
						if (dr["SysInitPrice"] != null && dr["SysInitPrice"] != DBNull.Value)
						{
							item.SysInitPrice = Convert.ToInt32(dr["SysInitPrice"]);
						}
						if (dr["SysInitWeight"] != null && dr["SysInitWeight"] != DBNull.Value)
						{
							item.SysInitWeight = Convert.ToInt32(dr["SysInitWeight"]);
						}
						if (dr["SysStepWeight"] != null && dr["SysStepWeight"] != DBNull.Value)
						{
							item.SysStepWeight = Convert.ToInt32(dr["SysStepWeight"]);
						}
						if (dr["SysStepPrice"] != null && dr["SysStepPrice"] != DBNull.Value)
						{
							item.SysStepPrice = Convert.ToInt32(dr["SysStepPrice"]);
						}
						if (dr["TranInitPrice"] != null && dr["TranInitPrice"] != DBNull.Value)
						{
							item.TranInitPrice = Convert.ToInt32(dr["TranInitPrice"]);
						}
						if (dr["TranInitWeight"] != null && dr["TranInitWeight"] != DBNull.Value)
						{
							item.TranInitWeight = Convert.ToInt32(dr["TranInitWeight"]);
						}
						if (dr["TranStepWeight"] != null && dr["TranStepWeight"] != DBNull.Value)
						{
							item.TranStepWeight = Convert.ToInt32(dr["TranStepWeight"]);
						}
						if (dr["TranStepPrice"] != null && dr["TranStepPrice"] != DBNull.Value)
						{
							item.TranStepPrice = Convert.ToInt32(dr["TranStepPrice"]);
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

		public GExpProviderConfig GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProviderConfig] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProviderConfig>(ds);
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
		/// Thêm mới GExpProviderConfig vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProviderConfig _GExpProviderConfig)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProviderConfig](Id, FK_FromPost, FK_ToPost, FK_Provider, DeliveryInitPrice, DeliveryInitWeight, DeliveryStepWeight, DeliveryStepPrice, SysInitPrice, SysInitWeight, SysStepWeight, SysStepPrice, TranInitPrice, TranInitWeight, TranStepWeight, TranStepPrice) VALUES(@Id, @FK_FromPost, @FK_ToPost, @FK_Provider, @DeliveryInitPrice, @DeliveryInitWeight, @DeliveryStepWeight, @DeliveryStepPrice, @SysInitPrice, @SysInitWeight, @SysStepWeight, @SysStepPrice, @TranInitPrice, @TranInitWeight, @TranStepWeight, @TranStepPrice)", 
					"@Id",  _GExpProviderConfig.Id, 
					"@FK_FromPost",  _GExpProviderConfig.FK_FromPost, 
					"@FK_ToPost",  _GExpProviderConfig.FK_ToPost, 
					"@FK_Provider",  _GExpProviderConfig.FK_Provider, 
					"@DeliveryInitPrice",  _GExpProviderConfig.DeliveryInitPrice, 
					"@DeliveryInitWeight",  _GExpProviderConfig.DeliveryInitWeight, 
					"@DeliveryStepWeight",  _GExpProviderConfig.DeliveryStepWeight, 
					"@DeliveryStepPrice",  _GExpProviderConfig.DeliveryStepPrice, 
					"@SysInitPrice",  _GExpProviderConfig.SysInitPrice, 
					"@SysInitWeight",  _GExpProviderConfig.SysInitWeight, 
					"@SysStepWeight",  _GExpProviderConfig.SysStepWeight, 
					"@SysStepPrice",  _GExpProviderConfig.SysStepPrice, 
					"@TranInitPrice",  _GExpProviderConfig.TranInitPrice, 
					"@TranInitWeight",  _GExpProviderConfig.TranInitWeight, 
					"@TranStepWeight",  _GExpProviderConfig.TranStepWeight, 
					"@TranStepPrice",  _GExpProviderConfig.TranStepPrice);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProviderConfig vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProviderConfig> _GExpProviderConfigs)
		{
			foreach (GExpProviderConfig item in _GExpProviderConfigs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProviderConfig _GExpProviderConfig, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderConfig] SET Id=@Id, FK_FromPost=@FK_FromPost, FK_ToPost=@FK_ToPost, FK_Provider=@FK_Provider, DeliveryInitPrice=@DeliveryInitPrice, DeliveryInitWeight=@DeliveryInitWeight, DeliveryStepWeight=@DeliveryStepWeight, DeliveryStepPrice=@DeliveryStepPrice, SysInitPrice=@SysInitPrice, SysInitWeight=@SysInitWeight, SysStepWeight=@SysStepWeight, SysStepPrice=@SysStepPrice, TranInitPrice=@TranInitPrice, TranInitWeight=@TranInitWeight, TranStepWeight=@TranStepWeight, TranStepPrice=@TranStepPrice WHERE Id=@Id", 
					"@Id",  _GExpProviderConfig.Id, 
					"@FK_FromPost",  _GExpProviderConfig.FK_FromPost, 
					"@FK_ToPost",  _GExpProviderConfig.FK_ToPost, 
					"@FK_Provider",  _GExpProviderConfig.FK_Provider, 
					"@DeliveryInitPrice",  _GExpProviderConfig.DeliveryInitPrice, 
					"@DeliveryInitWeight",  _GExpProviderConfig.DeliveryInitWeight, 
					"@DeliveryStepWeight",  _GExpProviderConfig.DeliveryStepWeight, 
					"@DeliveryStepPrice",  _GExpProviderConfig.DeliveryStepPrice, 
					"@SysInitPrice",  _GExpProviderConfig.SysInitPrice, 
					"@SysInitWeight",  _GExpProviderConfig.SysInitWeight, 
					"@SysStepWeight",  _GExpProviderConfig.SysStepWeight, 
					"@SysStepPrice",  _GExpProviderConfig.SysStepPrice, 
					"@TranInitPrice",  _GExpProviderConfig.TranInitPrice, 
					"@TranInitWeight",  _GExpProviderConfig.TranInitWeight, 
					"@TranStepWeight",  _GExpProviderConfig.TranStepWeight, 
					"@TranStepPrice",  _GExpProviderConfig.TranStepPrice, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderConfig vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProviderConfig _GExpProviderConfig)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderConfig] SET FK_FromPost=@FK_FromPost, FK_ToPost=@FK_ToPost, FK_Provider=@FK_Provider, DeliveryInitPrice=@DeliveryInitPrice, DeliveryInitWeight=@DeliveryInitWeight, DeliveryStepWeight=@DeliveryStepWeight, DeliveryStepPrice=@DeliveryStepPrice, SysInitPrice=@SysInitPrice, SysInitWeight=@SysInitWeight, SysStepWeight=@SysStepWeight, SysStepPrice=@SysStepPrice, TranInitPrice=@TranInitPrice, TranInitWeight=@TranInitWeight, TranStepWeight=@TranStepWeight, TranStepPrice=@TranStepPrice WHERE Id=@Id", 
					"@FK_FromPost",  _GExpProviderConfig.FK_FromPost, 
					"@FK_ToPost",  _GExpProviderConfig.FK_ToPost, 
					"@FK_Provider",  _GExpProviderConfig.FK_Provider, 
					"@DeliveryInitPrice",  _GExpProviderConfig.DeliveryInitPrice, 
					"@DeliveryInitWeight",  _GExpProviderConfig.DeliveryInitWeight, 
					"@DeliveryStepWeight",  _GExpProviderConfig.DeliveryStepWeight, 
					"@DeliveryStepPrice",  _GExpProviderConfig.DeliveryStepPrice, 
					"@SysInitPrice",  _GExpProviderConfig.SysInitPrice, 
					"@SysInitWeight",  _GExpProviderConfig.SysInitWeight, 
					"@SysStepWeight",  _GExpProviderConfig.SysStepWeight, 
					"@SysStepPrice",  _GExpProviderConfig.SysStepPrice, 
					"@TranInitPrice",  _GExpProviderConfig.TranInitPrice, 
					"@TranInitWeight",  _GExpProviderConfig.TranInitWeight, 
					"@TranStepWeight",  _GExpProviderConfig.TranStepWeight, 
					"@TranStepPrice",  _GExpProviderConfig.TranStepPrice, 
					"@Id", _GExpProviderConfig.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProviderConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProviderConfig> _GExpProviderConfigs)
		{
			foreach (GExpProviderConfig item in _GExpProviderConfigs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderConfig vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProviderConfig _GExpProviderConfig, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderConfig] SET Id=@Id, FK_FromPost=@FK_FromPost, FK_ToPost=@FK_ToPost, FK_Provider=@FK_Provider, DeliveryInitPrice=@DeliveryInitPrice, DeliveryInitWeight=@DeliveryInitWeight, DeliveryStepWeight=@DeliveryStepWeight, DeliveryStepPrice=@DeliveryStepPrice, SysInitPrice=@SysInitPrice, SysInitWeight=@SysInitWeight, SysStepWeight=@SysStepWeight, SysStepPrice=@SysStepPrice, TranInitPrice=@TranInitPrice, TranInitWeight=@TranInitWeight, TranStepWeight=@TranStepWeight, TranStepPrice=@TranStepPrice "+ condition, 
					"@Id",  _GExpProviderConfig.Id, 
					"@FK_FromPost",  _GExpProviderConfig.FK_FromPost, 
					"@FK_ToPost",  _GExpProviderConfig.FK_ToPost, 
					"@FK_Provider",  _GExpProviderConfig.FK_Provider, 
					"@DeliveryInitPrice",  _GExpProviderConfig.DeliveryInitPrice, 
					"@DeliveryInitWeight",  _GExpProviderConfig.DeliveryInitWeight, 
					"@DeliveryStepWeight",  _GExpProviderConfig.DeliveryStepWeight, 
					"@DeliveryStepPrice",  _GExpProviderConfig.DeliveryStepPrice, 
					"@SysInitPrice",  _GExpProviderConfig.SysInitPrice, 
					"@SysInitWeight",  _GExpProviderConfig.SysInitWeight, 
					"@SysStepWeight",  _GExpProviderConfig.SysStepWeight, 
					"@SysStepPrice",  _GExpProviderConfig.SysStepPrice, 
					"@TranInitPrice",  _GExpProviderConfig.TranInitPrice, 
					"@TranInitWeight",  _GExpProviderConfig.TranInitWeight, 
					"@TranStepWeight",  _GExpProviderConfig.TranStepWeight, 
					"@TranStepPrice",  _GExpProviderConfig.TranStepPrice);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProviderConfig trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderConfig] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderConfig trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProviderConfig _GExpProviderConfig)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderConfig] WHERE Id=@Id",
					"@Id", _GExpProviderConfig.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderConfig trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderConfig] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderConfig trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProviderConfig> _GExpProviderConfigs)
		{
			foreach (GExpProviderConfig item in _GExpProviderConfigs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
