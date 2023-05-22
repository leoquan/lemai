using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprovincefeez:IGExpprovincefeez
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprovincefeez(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProvinceFeeZ từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceFeeZ]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProvinceFeeZ từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceFeeZ] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProvinceFeeZ từ Database
		/// </summary>
		public List<GExpProvinceFeeZ> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceFeeZ]");
				List<GExpProvinceFeeZ> items = new List<GExpProvinceFeeZ>();
				GExpProvinceFeeZ item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceFeeZ();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["IdProvince"] != null && dr["IdProvince"] != DBNull.Value)
					{
						item.IdProvince = Convert.ToInt32(dr["IdProvince"]);
					}
					if (dr["MinRangeWeight"] != null && dr["MinRangeWeight"] != DBNull.Value)
					{
						item.MinRangeWeight = Convert.ToInt32(dr["MinRangeWeight"]);
					}
					if (dr["MaxRangeWeight"] != null && dr["MaxRangeWeight"] != DBNull.Value)
					{
						item.MaxRangeWeight = Convert.ToInt32(dr["MaxRangeWeight"]);
					}
					if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
					{
						item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
					}
					if (dr["CostFee"] != null && dr["CostFee"] != DBNull.Value)
					{
						item.CostFee = Convert.ToInt32(dr["CostFee"]);
					}
					if (dr["Fee"] != null && dr["Fee"] != DBNull.Value)
					{
						item.Fee = Convert.ToInt32(dr["Fee"]);
					}
					if (dr["MaxWeight"] != null && dr["MaxWeight"] != DBNull.Value)
					{
						item.MaxWeight = Convert.ToInt32(dr["MaxWeight"]);
					}
					if (dr["Step"] != null && dr["Step"] != DBNull.Value)
					{
						item.Step = Convert.ToInt32(dr["Step"]);
					}
					if (dr["NextWeightFee"] != null && dr["NextWeightFee"] != DBNull.Value)
					{
						item.NextWeightFee = Convert.ToInt32(dr["NextWeightFee"]);
					}
					if (dr["IsRangeOnly"] != null && dr["IsRangeOnly"] != DBNull.Value)
					{
						item.IsRangeOnly = Convert.ToBoolean(dr["IsRangeOnly"]);
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
		/// Lấy danh sách GExpProvinceFeeZ từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProvinceFeeZ> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceFeeZ] A "+ condition,  parameters);
				List<GExpProvinceFeeZ> items = new List<GExpProvinceFeeZ>();
				GExpProvinceFeeZ item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvinceFeeZ();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["IdProvince"] != null && dr["IdProvince"] != DBNull.Value)
					{
						item.IdProvince = Convert.ToInt32(dr["IdProvince"]);
					}
					if (dr["MinRangeWeight"] != null && dr["MinRangeWeight"] != DBNull.Value)
					{
						item.MinRangeWeight = Convert.ToInt32(dr["MinRangeWeight"]);
					}
					if (dr["MaxRangeWeight"] != null && dr["MaxRangeWeight"] != DBNull.Value)
					{
						item.MaxRangeWeight = Convert.ToInt32(dr["MaxRangeWeight"]);
					}
					if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
					{
						item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
					}
					if (dr["CostFee"] != null && dr["CostFee"] != DBNull.Value)
					{
						item.CostFee = Convert.ToInt32(dr["CostFee"]);
					}
					if (dr["Fee"] != null && dr["Fee"] != DBNull.Value)
					{
						item.Fee = Convert.ToInt32(dr["Fee"]);
					}
					if (dr["MaxWeight"] != null && dr["MaxWeight"] != DBNull.Value)
					{
						item.MaxWeight = Convert.ToInt32(dr["MaxWeight"]);
					}
					if (dr["Step"] != null && dr["Step"] != DBNull.Value)
					{
						item.Step = Convert.ToInt32(dr["Step"]);
					}
					if (dr["NextWeightFee"] != null && dr["NextWeightFee"] != DBNull.Value)
					{
						item.NextWeightFee = Convert.ToInt32(dr["NextWeightFee"]);
					}
					if (dr["IsRangeOnly"] != null && dr["IsRangeOnly"] != DBNull.Value)
					{
						item.IsRangeOnly = Convert.ToBoolean(dr["IsRangeOnly"]);
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

		public List<GExpProvinceFeeZ> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceFeeZ] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProvinceFeeZ] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProvinceFeeZ>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProvinceFeeZ từ Database
		/// </summary>
		public GExpProvinceFeeZ GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvinceFeeZ] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceFeeZ item=new GExpProvinceFeeZ();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["IdProvince"] != null && dr["IdProvince"] != DBNull.Value)
						{
							item.IdProvince = Convert.ToInt32(dr["IdProvince"]);
						}
						if (dr["MinRangeWeight"] != null && dr["MinRangeWeight"] != DBNull.Value)
						{
							item.MinRangeWeight = Convert.ToInt32(dr["MinRangeWeight"]);
						}
						if (dr["MaxRangeWeight"] != null && dr["MaxRangeWeight"] != DBNull.Value)
						{
							item.MaxRangeWeight = Convert.ToInt32(dr["MaxRangeWeight"]);
						}
						if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
						{
							item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
						}
						if (dr["CostFee"] != null && dr["CostFee"] != DBNull.Value)
						{
							item.CostFee = Convert.ToInt32(dr["CostFee"]);
						}
						if (dr["Fee"] != null && dr["Fee"] != DBNull.Value)
						{
							item.Fee = Convert.ToInt32(dr["Fee"]);
						}
						if (dr["MaxWeight"] != null && dr["MaxWeight"] != DBNull.Value)
						{
							item.MaxWeight = Convert.ToInt32(dr["MaxWeight"]);
						}
						if (dr["Step"] != null && dr["Step"] != DBNull.Value)
						{
							item.Step = Convert.ToInt32(dr["Step"]);
						}
						if (dr["NextWeightFee"] != null && dr["NextWeightFee"] != DBNull.Value)
						{
							item.NextWeightFee = Convert.ToInt32(dr["NextWeightFee"]);
						}
						if (dr["IsRangeOnly"] != null && dr["IsRangeOnly"] != DBNull.Value)
						{
							item.IsRangeOnly = Convert.ToBoolean(dr["IsRangeOnly"]);
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
		/// Lấy một GExpProvinceFeeZ đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProvinceFeeZ GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvinceFeeZ] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProvinceFeeZ item=new GExpProvinceFeeZ();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["IdProvince"] != null && dr["IdProvince"] != DBNull.Value)
						{
							item.IdProvince = Convert.ToInt32(dr["IdProvince"]);
						}
						if (dr["MinRangeWeight"] != null && dr["MinRangeWeight"] != DBNull.Value)
						{
							item.MinRangeWeight = Convert.ToInt32(dr["MinRangeWeight"]);
						}
						if (dr["MaxRangeWeight"] != null && dr["MaxRangeWeight"] != DBNull.Value)
						{
							item.MaxRangeWeight = Convert.ToInt32(dr["MaxRangeWeight"]);
						}
						if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
						{
							item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
						}
						if (dr["CostFee"] != null && dr["CostFee"] != DBNull.Value)
						{
							item.CostFee = Convert.ToInt32(dr["CostFee"]);
						}
						if (dr["Fee"] != null && dr["Fee"] != DBNull.Value)
						{
							item.Fee = Convert.ToInt32(dr["Fee"]);
						}
						if (dr["MaxWeight"] != null && dr["MaxWeight"] != DBNull.Value)
						{
							item.MaxWeight = Convert.ToInt32(dr["MaxWeight"]);
						}
						if (dr["Step"] != null && dr["Step"] != DBNull.Value)
						{
							item.Step = Convert.ToInt32(dr["Step"]);
						}
						if (dr["NextWeightFee"] != null && dr["NextWeightFee"] != DBNull.Value)
						{
							item.NextWeightFee = Convert.ToInt32(dr["NextWeightFee"]);
						}
						if (dr["IsRangeOnly"] != null && dr["IsRangeOnly"] != DBNull.Value)
						{
							item.IsRangeOnly = Convert.ToBoolean(dr["IsRangeOnly"]);
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

		public GExpProvinceFeeZ GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvinceFeeZ] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProvinceFeeZ>(ds);
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
		/// Thêm mới GExpProvinceFeeZ vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProvinceFeeZ _GExpProvinceFeeZ)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProvinceFeeZ](Id, IdProvince, MinRangeWeight, MaxRangeWeight, InitWeight, CostFee, Fee, MaxWeight, Step, NextWeightFee, IsRangeOnly) VALUES(@Id, @IdProvince, @MinRangeWeight, @MaxRangeWeight, @InitWeight, @CostFee, @Fee, @MaxWeight, @Step, @NextWeightFee, @IsRangeOnly)", 
					"@Id",  _GExpProvinceFeeZ.Id, 
					"@IdProvince",  _GExpProvinceFeeZ.IdProvince, 
					"@MinRangeWeight",  _GExpProvinceFeeZ.MinRangeWeight, 
					"@MaxRangeWeight",  _GExpProvinceFeeZ.MaxRangeWeight, 
					"@InitWeight",  _GExpProvinceFeeZ.InitWeight, 
					"@CostFee",  _GExpProvinceFeeZ.CostFee, 
					"@Fee",  _GExpProvinceFeeZ.Fee, 
					"@MaxWeight",  _GExpProvinceFeeZ.MaxWeight, 
					"@Step",  _GExpProvinceFeeZ.Step, 
					"@NextWeightFee",  _GExpProvinceFeeZ.NextWeightFee, 
					"@IsRangeOnly",  _GExpProvinceFeeZ.IsRangeOnly);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceFeeZ vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProvinceFeeZ> _GExpProvinceFeeZs)
		{
			foreach (GExpProvinceFeeZ item in _GExpProvinceFeeZs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceFeeZ vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProvinceFeeZ _GExpProvinceFeeZ, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceFeeZ] SET Id=@Id, IdProvince=@IdProvince, MinRangeWeight=@MinRangeWeight, MaxRangeWeight=@MaxRangeWeight, InitWeight=@InitWeight, CostFee=@CostFee, Fee=@Fee, MaxWeight=@MaxWeight, Step=@Step, NextWeightFee=@NextWeightFee, IsRangeOnly=@IsRangeOnly WHERE Id=@Id", 
					"@Id",  _GExpProvinceFeeZ.Id, 
					"@IdProvince",  _GExpProvinceFeeZ.IdProvince, 
					"@MinRangeWeight",  _GExpProvinceFeeZ.MinRangeWeight, 
					"@MaxRangeWeight",  _GExpProvinceFeeZ.MaxRangeWeight, 
					"@InitWeight",  _GExpProvinceFeeZ.InitWeight, 
					"@CostFee",  _GExpProvinceFeeZ.CostFee, 
					"@Fee",  _GExpProvinceFeeZ.Fee, 
					"@MaxWeight",  _GExpProvinceFeeZ.MaxWeight, 
					"@Step",  _GExpProvinceFeeZ.Step, 
					"@NextWeightFee",  _GExpProvinceFeeZ.NextWeightFee, 
					"@IsRangeOnly",  _GExpProvinceFeeZ.IsRangeOnly, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceFeeZ vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProvinceFeeZ _GExpProvinceFeeZ)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceFeeZ] SET IdProvince=@IdProvince, MinRangeWeight=@MinRangeWeight, MaxRangeWeight=@MaxRangeWeight, InitWeight=@InitWeight, CostFee=@CostFee, Fee=@Fee, MaxWeight=@MaxWeight, Step=@Step, NextWeightFee=@NextWeightFee, IsRangeOnly=@IsRangeOnly WHERE Id=@Id", 
					"@IdProvince",  _GExpProvinceFeeZ.IdProvince, 
					"@MinRangeWeight",  _GExpProvinceFeeZ.MinRangeWeight, 
					"@MaxRangeWeight",  _GExpProvinceFeeZ.MaxRangeWeight, 
					"@InitWeight",  _GExpProvinceFeeZ.InitWeight, 
					"@CostFee",  _GExpProvinceFeeZ.CostFee, 
					"@Fee",  _GExpProvinceFeeZ.Fee, 
					"@MaxWeight",  _GExpProvinceFeeZ.MaxWeight, 
					"@Step",  _GExpProvinceFeeZ.Step, 
					"@NextWeightFee",  _GExpProvinceFeeZ.NextWeightFee, 
					"@IsRangeOnly",  _GExpProvinceFeeZ.IsRangeOnly, 
					"@Id", _GExpProvinceFeeZ.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProvinceFeeZ vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProvinceFeeZ> _GExpProvinceFeeZs)
		{
			foreach (GExpProvinceFeeZ item in _GExpProvinceFeeZs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvinceFeeZ vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProvinceFeeZ _GExpProvinceFeeZ, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvinceFeeZ] SET Id=@Id, IdProvince=@IdProvince, MinRangeWeight=@MinRangeWeight, MaxRangeWeight=@MaxRangeWeight, InitWeight=@InitWeight, CostFee=@CostFee, Fee=@Fee, MaxWeight=@MaxWeight, Step=@Step, NextWeightFee=@NextWeightFee, IsRangeOnly=@IsRangeOnly "+ condition, 
					"@Id",  _GExpProvinceFeeZ.Id, 
					"@IdProvince",  _GExpProvinceFeeZ.IdProvince, 
					"@MinRangeWeight",  _GExpProvinceFeeZ.MinRangeWeight, 
					"@MaxRangeWeight",  _GExpProvinceFeeZ.MaxRangeWeight, 
					"@InitWeight",  _GExpProvinceFeeZ.InitWeight, 
					"@CostFee",  _GExpProvinceFeeZ.CostFee, 
					"@Fee",  _GExpProvinceFeeZ.Fee, 
					"@MaxWeight",  _GExpProvinceFeeZ.MaxWeight, 
					"@Step",  _GExpProvinceFeeZ.Step, 
					"@NextWeightFee",  _GExpProvinceFeeZ.NextWeightFee, 
					"@IsRangeOnly",  _GExpProvinceFeeZ.IsRangeOnly);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProvinceFeeZ trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceFeeZ] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceFeeZ trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProvinceFeeZ _GExpProvinceFeeZ)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceFeeZ] WHERE Id=@Id",
					"@Id", _GExpProvinceFeeZ.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceFeeZ trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvinceFeeZ] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvinceFeeZ trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProvinceFeeZ> _GExpProvinceFeeZs)
		{
			foreach (GExpProvinceFeeZ item in _GExpProvinceFeeZs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
