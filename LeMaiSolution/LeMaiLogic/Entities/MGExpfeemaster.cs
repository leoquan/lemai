using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpfeemaster:IGExpfeemaster
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpfeemaster(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpFeeMaster từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeMaster]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpFeeMaster từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeMaster] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpFeeMaster từ Database
		/// </summary>
		public List<GExpFeeMaster> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeMaster]");
				List<GExpFeeMaster> items = new List<GExpFeeMaster>();
				GExpFeeMaster item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpFeeMaster();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_ProviderId"] != null && dr["FK_ProviderId"] != DBNull.Value)
					{
						item.FK_ProviderId = Convert.ToString(dr["FK_ProviderId"]);
					}
					if (dr["MinWeight"] != null && dr["MinWeight"] != DBNull.Value)
					{
						item.MinWeight = Convert.ToInt32(dr["MinWeight"]);
					}
					if (dr["MinFee"] != null && dr["MinFee"] != DBNull.Value)
					{
						item.MinFee = Convert.ToInt32(dr["MinFee"]);
					}
					if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
					{
						item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
					}
					if (dr["NextFee"] != null && dr["NextFee"] != DBNull.Value)
					{
						item.NextFee = Convert.ToInt32(dr["NextFee"]);
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
		/// Lấy danh sách GExpFeeMaster từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpFeeMaster> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpFeeMaster] A "+ condition,  parameters);
				List<GExpFeeMaster> items = new List<GExpFeeMaster>();
				GExpFeeMaster item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpFeeMaster();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_ProviderId"] != null && dr["FK_ProviderId"] != DBNull.Value)
					{
						item.FK_ProviderId = Convert.ToString(dr["FK_ProviderId"]);
					}
					if (dr["MinWeight"] != null && dr["MinWeight"] != DBNull.Value)
					{
						item.MinWeight = Convert.ToInt32(dr["MinWeight"]);
					}
					if (dr["MinFee"] != null && dr["MinFee"] != DBNull.Value)
					{
						item.MinFee = Convert.ToInt32(dr["MinFee"]);
					}
					if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
					{
						item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
					}
					if (dr["NextFee"] != null && dr["NextFee"] != DBNull.Value)
					{
						item.NextFee = Convert.ToInt32(dr["NextFee"]);
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

		public List<GExpFeeMaster> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpFeeMaster] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpFeeMaster] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpFeeMaster>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpFeeMaster từ Database
		/// </summary>
		public GExpFeeMaster GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeMaster] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpFeeMaster item=new GExpFeeMaster();
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
						if (dr["FK_ProviderId"] != null && dr["FK_ProviderId"] != DBNull.Value)
						{
							item.FK_ProviderId = Convert.ToString(dr["FK_ProviderId"]);
						}
						if (dr["MinWeight"] != null && dr["MinWeight"] != DBNull.Value)
						{
							item.MinWeight = Convert.ToInt32(dr["MinWeight"]);
						}
						if (dr["MinFee"] != null && dr["MinFee"] != DBNull.Value)
						{
							item.MinFee = Convert.ToInt32(dr["MinFee"]);
						}
						if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
						{
							item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
						}
						if (dr["NextFee"] != null && dr["NextFee"] != DBNull.Value)
						{
							item.NextFee = Convert.ToInt32(dr["NextFee"]);
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
		/// Lấy một GExpFeeMaster đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpFeeMaster GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpFeeMaster] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpFeeMaster item=new GExpFeeMaster();
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
						if (dr["FK_ProviderId"] != null && dr["FK_ProviderId"] != DBNull.Value)
						{
							item.FK_ProviderId = Convert.ToString(dr["FK_ProviderId"]);
						}
						if (dr["MinWeight"] != null && dr["MinWeight"] != DBNull.Value)
						{
							item.MinWeight = Convert.ToInt32(dr["MinWeight"]);
						}
						if (dr["MinFee"] != null && dr["MinFee"] != DBNull.Value)
						{
							item.MinFee = Convert.ToInt32(dr["MinFee"]);
						}
						if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
						{
							item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
						}
						if (dr["NextFee"] != null && dr["NextFee"] != DBNull.Value)
						{
							item.NextFee = Convert.ToInt32(dr["NextFee"]);
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

		public GExpFeeMaster GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpFeeMaster] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpFeeMaster>(ds);
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
		/// Thêm mới GExpFeeMaster vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpFeeMaster _GExpFeeMaster)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpFeeMaster](Id, FK_Post, FK_ProviderId, MinWeight, MinFee, StepWeight, NextFee) VALUES(@Id, @FK_Post, @FK_ProviderId, @MinWeight, @MinFee, @StepWeight, @NextFee)", 
					"@Id",  _GExpFeeMaster.Id, 
					"@FK_Post",  _GExpFeeMaster.FK_Post, 
					"@FK_ProviderId",  _GExpFeeMaster.FK_ProviderId, 
					"@MinWeight",  _GExpFeeMaster.MinWeight, 
					"@MinFee",  _GExpFeeMaster.MinFee, 
					"@StepWeight",  _GExpFeeMaster.StepWeight, 
					"@NextFee",  _GExpFeeMaster.NextFee);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpFeeMaster vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpFeeMaster> _GExpFeeMasters)
		{
			foreach (GExpFeeMaster item in _GExpFeeMasters)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeMaster vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpFeeMaster _GExpFeeMaster, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeMaster] SET Id=@Id, FK_Post=@FK_Post, FK_ProviderId=@FK_ProviderId, MinWeight=@MinWeight, MinFee=@MinFee, StepWeight=@StepWeight, NextFee=@NextFee WHERE Id=@Id", 
					"@Id",  _GExpFeeMaster.Id, 
					"@FK_Post",  _GExpFeeMaster.FK_Post, 
					"@FK_ProviderId",  _GExpFeeMaster.FK_ProviderId, 
					"@MinWeight",  _GExpFeeMaster.MinWeight, 
					"@MinFee",  _GExpFeeMaster.MinFee, 
					"@StepWeight",  _GExpFeeMaster.StepWeight, 
					"@NextFee",  _GExpFeeMaster.NextFee, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeMaster vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpFeeMaster _GExpFeeMaster)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeMaster] SET FK_Post=@FK_Post, FK_ProviderId=@FK_ProviderId, MinWeight=@MinWeight, MinFee=@MinFee, StepWeight=@StepWeight, NextFee=@NextFee WHERE Id=@Id", 
					"@FK_Post",  _GExpFeeMaster.FK_Post, 
					"@FK_ProviderId",  _GExpFeeMaster.FK_ProviderId, 
					"@MinWeight",  _GExpFeeMaster.MinWeight, 
					"@MinFee",  _GExpFeeMaster.MinFee, 
					"@StepWeight",  _GExpFeeMaster.StepWeight, 
					"@NextFee",  _GExpFeeMaster.NextFee, 
					"@Id", _GExpFeeMaster.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpFeeMaster vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpFeeMaster> _GExpFeeMasters)
		{
			foreach (GExpFeeMaster item in _GExpFeeMasters)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeMaster vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpFeeMaster _GExpFeeMaster, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeMaster] SET Id=@Id, FK_Post=@FK_Post, FK_ProviderId=@FK_ProviderId, MinWeight=@MinWeight, MinFee=@MinFee, StepWeight=@StepWeight, NextFee=@NextFee "+ condition, 
					"@Id",  _GExpFeeMaster.Id, 
					"@FK_Post",  _GExpFeeMaster.FK_Post, 
					"@FK_ProviderId",  _GExpFeeMaster.FK_ProviderId, 
					"@MinWeight",  _GExpFeeMaster.MinWeight, 
					"@MinFee",  _GExpFeeMaster.MinFee, 
					"@StepWeight",  _GExpFeeMaster.StepWeight, 
					"@NextFee",  _GExpFeeMaster.NextFee);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpFeeMaster trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeMaster] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeMaster trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpFeeMaster _GExpFeeMaster)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeMaster] WHERE Id=@Id",
					"@Id", _GExpFeeMaster.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeMaster trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeMaster] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeMaster trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpFeeMaster> _GExpFeeMasters)
		{
			foreach (GExpFeeMaster item in _GExpFeeMasters)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
