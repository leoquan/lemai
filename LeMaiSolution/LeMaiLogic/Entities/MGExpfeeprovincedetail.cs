using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpfeeprovincedetail:IGExpfeeprovincedetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpfeeprovincedetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpFeeProvinceDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeProvinceDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpFeeProvinceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeProvinceDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpFeeProvinceDetail từ Database
		/// </summary>
		public List<GExpFeeProvinceDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeProvinceDetail]");
				List<GExpFeeProvinceDetail> items = new List<GExpFeeProvinceDetail>();
				GExpFeeProvinceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpFeeProvinceDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_GExpFee"] != null && dr["FK_GExpFee"] != DBNull.Value)
					{
						item.FK_GExpFee = Convert.ToString(dr["FK_GExpFee"]);
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
					if (dr["ProvineId"] != null && dr["ProvineId"] != DBNull.Value)
					{
						item.ProvineId = Convert.ToInt32(dr["ProvineId"]);
					}
					if (dr["District"] != null && dr["District"] != DBNull.Value)
					{
						item.District = Convert.ToString(dr["District"]);
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
		/// Lấy danh sách GExpFeeProvinceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpFeeProvinceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpFeeProvinceDetail] A "+ condition,  parameters);
				List<GExpFeeProvinceDetail> items = new List<GExpFeeProvinceDetail>();
				GExpFeeProvinceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpFeeProvinceDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_GExpFee"] != null && dr["FK_GExpFee"] != DBNull.Value)
					{
						item.FK_GExpFee = Convert.ToString(dr["FK_GExpFee"]);
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
					if (dr["ProvineId"] != null && dr["ProvineId"] != DBNull.Value)
					{
						item.ProvineId = Convert.ToInt32(dr["ProvineId"]);
					}
					if (dr["District"] != null && dr["District"] != DBNull.Value)
					{
						item.District = Convert.ToString(dr["District"]);
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

		public List<GExpFeeProvinceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpFeeProvinceDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpFeeProvinceDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpFeeProvinceDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpFeeProvinceDetail từ Database
		/// </summary>
		public GExpFeeProvinceDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeProvinceDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpFeeProvinceDetail item=new GExpFeeProvinceDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_GExpFee"] != null && dr["FK_GExpFee"] != DBNull.Value)
						{
							item.FK_GExpFee = Convert.ToString(dr["FK_GExpFee"]);
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
						if (dr["ProvineId"] != null && dr["ProvineId"] != DBNull.Value)
						{
							item.ProvineId = Convert.ToInt32(dr["ProvineId"]);
						}
						if (dr["District"] != null && dr["District"] != DBNull.Value)
						{
							item.District = Convert.ToString(dr["District"]);
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
		/// Lấy một GExpFeeProvinceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpFeeProvinceDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpFeeProvinceDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpFeeProvinceDetail item=new GExpFeeProvinceDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_GExpFee"] != null && dr["FK_GExpFee"] != DBNull.Value)
						{
							item.FK_GExpFee = Convert.ToString(dr["FK_GExpFee"]);
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
						if (dr["ProvineId"] != null && dr["ProvineId"] != DBNull.Value)
						{
							item.ProvineId = Convert.ToInt32(dr["ProvineId"]);
						}
						if (dr["District"] != null && dr["District"] != DBNull.Value)
						{
							item.District = Convert.ToString(dr["District"]);
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

		public GExpFeeProvinceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpFeeProvinceDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpFeeProvinceDetail>(ds);
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
		/// Thêm mới GExpFeeProvinceDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpFeeProvinceDetail _GExpFeeProvinceDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpFeeProvinceDetail](Id, FK_GExpFee, MinWeight, MinFee, StepWeight, NextFee, ProvineId, District) VALUES(@Id, @FK_GExpFee, @MinWeight, @MinFee, @StepWeight, @NextFee, @ProvineId, @District)", 
					"@Id",  _GExpFeeProvinceDetail.Id, 
					"@FK_GExpFee",  _GExpFeeProvinceDetail.FK_GExpFee, 
					"@MinWeight",  _GExpFeeProvinceDetail.MinWeight, 
					"@MinFee",  _GExpFeeProvinceDetail.MinFee, 
					"@StepWeight",  _GExpFeeProvinceDetail.StepWeight, 
					"@NextFee",  _GExpFeeProvinceDetail.NextFee, 
					"@ProvineId",  _GExpFeeProvinceDetail.ProvineId, 
					"@District",  _GExpFeeProvinceDetail.District);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpFeeProvinceDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpFeeProvinceDetail> _GExpFeeProvinceDetails)
		{
			foreach (GExpFeeProvinceDetail item in _GExpFeeProvinceDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeProvinceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpFeeProvinceDetail _GExpFeeProvinceDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeProvinceDetail] SET Id=@Id, FK_GExpFee=@FK_GExpFee, MinWeight=@MinWeight, MinFee=@MinFee, StepWeight=@StepWeight, NextFee=@NextFee, ProvineId=@ProvineId, District=@District WHERE Id=@Id", 
					"@Id",  _GExpFeeProvinceDetail.Id, 
					"@FK_GExpFee",  _GExpFeeProvinceDetail.FK_GExpFee, 
					"@MinWeight",  _GExpFeeProvinceDetail.MinWeight, 
					"@MinFee",  _GExpFeeProvinceDetail.MinFee, 
					"@StepWeight",  _GExpFeeProvinceDetail.StepWeight, 
					"@NextFee",  _GExpFeeProvinceDetail.NextFee, 
					"@ProvineId",  _GExpFeeProvinceDetail.ProvineId, 
					"@District",  _GExpFeeProvinceDetail.District, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeProvinceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpFeeProvinceDetail _GExpFeeProvinceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeProvinceDetail] SET FK_GExpFee=@FK_GExpFee, MinWeight=@MinWeight, MinFee=@MinFee, StepWeight=@StepWeight, NextFee=@NextFee, ProvineId=@ProvineId, District=@District WHERE Id=@Id", 
					"@FK_GExpFee",  _GExpFeeProvinceDetail.FK_GExpFee, 
					"@MinWeight",  _GExpFeeProvinceDetail.MinWeight, 
					"@MinFee",  _GExpFeeProvinceDetail.MinFee, 
					"@StepWeight",  _GExpFeeProvinceDetail.StepWeight, 
					"@NextFee",  _GExpFeeProvinceDetail.NextFee, 
					"@ProvineId",  _GExpFeeProvinceDetail.ProvineId, 
					"@District",  _GExpFeeProvinceDetail.District, 
					"@Id", _GExpFeeProvinceDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpFeeProvinceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpFeeProvinceDetail> _GExpFeeProvinceDetails)
		{
			foreach (GExpFeeProvinceDetail item in _GExpFeeProvinceDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeProvinceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpFeeProvinceDetail _GExpFeeProvinceDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeProvinceDetail] SET Id=@Id, FK_GExpFee=@FK_GExpFee, MinWeight=@MinWeight, MinFee=@MinFee, StepWeight=@StepWeight, NextFee=@NextFee, ProvineId=@ProvineId, District=@District "+ condition, 
					"@Id",  _GExpFeeProvinceDetail.Id, 
					"@FK_GExpFee",  _GExpFeeProvinceDetail.FK_GExpFee, 
					"@MinWeight",  _GExpFeeProvinceDetail.MinWeight, 
					"@MinFee",  _GExpFeeProvinceDetail.MinFee, 
					"@StepWeight",  _GExpFeeProvinceDetail.StepWeight, 
					"@NextFee",  _GExpFeeProvinceDetail.NextFee, 
					"@ProvineId",  _GExpFeeProvinceDetail.ProvineId, 
					"@District",  _GExpFeeProvinceDetail.District);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpFeeProvinceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeProvinceDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeProvinceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpFeeProvinceDetail _GExpFeeProvinceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeProvinceDetail] WHERE Id=@Id",
					"@Id", _GExpFeeProvinceDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeProvinceDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeProvinceDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeProvinceDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpFeeProvinceDetail> _GExpFeeProvinceDetails)
		{
			foreach (GExpFeeProvinceDetail item in _GExpFeeProvinceDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
