using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpfeedetail:IGExpfeedetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpfeedetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpFeeDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpFeeDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpFeeDetail từ Database
		/// </summary>
		public List<GExpFeeDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeDetail]");
				List<GExpFeeDetail> items = new List<GExpFeeDetail>();
				GExpFeeDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpFeeDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_GExpFee"] != null && dr["FK_GExpFee"] != DBNull.Value)
					{
						item.FK_GExpFee = Convert.ToString(dr["FK_GExpFee"]);
					}
					if (dr["MinWeightMN"] != null && dr["MinWeightMN"] != DBNull.Value)
					{
						item.MinWeightMN = Convert.ToInt32(dr["MinWeightMN"]);
					}
					if (dr["MinWeightMT"] != null && dr["MinWeightMT"] != DBNull.Value)
					{
						item.MinWeightMT = Convert.ToInt32(dr["MinWeightMT"]);
					}
					if (dr["MinWeightMB"] != null && dr["MinWeightMB"] != DBNull.Value)
					{
						item.MinWeightMB = Convert.ToInt32(dr["MinWeightMB"]);
					}
					if (dr["MinFeeMN"] != null && dr["MinFeeMN"] != DBNull.Value)
					{
						item.MinFeeMN = Convert.ToInt32(dr["MinFeeMN"]);
					}
					if (dr["MinFeeMT"] != null && dr["MinFeeMT"] != DBNull.Value)
					{
						item.MinFeeMT = Convert.ToInt32(dr["MinFeeMT"]);
					}
					if (dr["MinFeeMB"] != null && dr["MinFeeMB"] != DBNull.Value)
					{
						item.MinFeeMB = Convert.ToInt32(dr["MinFeeMB"]);
					}
					if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
					{
						item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
					}
					if (dr["NextFeeMN"] != null && dr["NextFeeMN"] != DBNull.Value)
					{
						item.NextFeeMN = Convert.ToInt32(dr["NextFeeMN"]);
					}
					if (dr["NextFeeMT"] != null && dr["NextFeeMT"] != DBNull.Value)
					{
						item.NextFeeMT = Convert.ToInt32(dr["NextFeeMT"]);
					}
					if (dr["NextFeeMB"] != null && dr["NextFeeMB"] != DBNull.Value)
					{
						item.NextFeeMB = Convert.ToInt32(dr["NextFeeMB"]);
					}
					if (dr["MinWeightInt"] != null && dr["MinWeightInt"] != DBNull.Value)
					{
						item.MinWeightInt = Convert.ToInt32(dr["MinWeightInt"]);
					}
					if (dr["MinFeeInt"] != null && dr["MinFeeInt"] != DBNull.Value)
					{
						item.MinFeeInt = Convert.ToInt32(dr["MinFeeInt"]);
					}
					if (dr["NextFeeInt"] != null && dr["NextFeeInt"] != DBNull.Value)
					{
						item.NextFeeInt = Convert.ToInt32(dr["NextFeeInt"]);
					}
					if (dr["StepWeightInt"] != null && dr["StepWeightInt"] != DBNull.Value)
					{
						item.StepWeightInt = Convert.ToInt32(dr["StepWeightInt"]);
					}
					if (dr["StepWeightMB"] != null && dr["StepWeightMB"] != DBNull.Value)
					{
						item.StepWeightMB = Convert.ToInt32(dr["StepWeightMB"]);
					}
					if (dr["StepWeightMT"] != null && dr["StepWeightMT"] != DBNull.Value)
					{
						item.StepWeightMT = Convert.ToInt32(dr["StepWeightMT"]);
					}
					if (dr["StepWeightMN"] != null && dr["StepWeightMN"] != DBNull.Value)
					{
						item.StepWeightMN = Convert.ToInt32(dr["StepWeightMN"]);
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
		/// Lấy danh sách GExpFeeDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpFeeDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpFeeDetail] A "+ condition,  parameters);
				List<GExpFeeDetail> items = new List<GExpFeeDetail>();
				GExpFeeDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpFeeDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_GExpFee"] != null && dr["FK_GExpFee"] != DBNull.Value)
					{
						item.FK_GExpFee = Convert.ToString(dr["FK_GExpFee"]);
					}
					if (dr["MinWeightMN"] != null && dr["MinWeightMN"] != DBNull.Value)
					{
						item.MinWeightMN = Convert.ToInt32(dr["MinWeightMN"]);
					}
					if (dr["MinWeightMT"] != null && dr["MinWeightMT"] != DBNull.Value)
					{
						item.MinWeightMT = Convert.ToInt32(dr["MinWeightMT"]);
					}
					if (dr["MinWeightMB"] != null && dr["MinWeightMB"] != DBNull.Value)
					{
						item.MinWeightMB = Convert.ToInt32(dr["MinWeightMB"]);
					}
					if (dr["MinFeeMN"] != null && dr["MinFeeMN"] != DBNull.Value)
					{
						item.MinFeeMN = Convert.ToInt32(dr["MinFeeMN"]);
					}
					if (dr["MinFeeMT"] != null && dr["MinFeeMT"] != DBNull.Value)
					{
						item.MinFeeMT = Convert.ToInt32(dr["MinFeeMT"]);
					}
					if (dr["MinFeeMB"] != null && dr["MinFeeMB"] != DBNull.Value)
					{
						item.MinFeeMB = Convert.ToInt32(dr["MinFeeMB"]);
					}
					if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
					{
						item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
					}
					if (dr["NextFeeMN"] != null && dr["NextFeeMN"] != DBNull.Value)
					{
						item.NextFeeMN = Convert.ToInt32(dr["NextFeeMN"]);
					}
					if (dr["NextFeeMT"] != null && dr["NextFeeMT"] != DBNull.Value)
					{
						item.NextFeeMT = Convert.ToInt32(dr["NextFeeMT"]);
					}
					if (dr["NextFeeMB"] != null && dr["NextFeeMB"] != DBNull.Value)
					{
						item.NextFeeMB = Convert.ToInt32(dr["NextFeeMB"]);
					}
					if (dr["MinWeightInt"] != null && dr["MinWeightInt"] != DBNull.Value)
					{
						item.MinWeightInt = Convert.ToInt32(dr["MinWeightInt"]);
					}
					if (dr["MinFeeInt"] != null && dr["MinFeeInt"] != DBNull.Value)
					{
						item.MinFeeInt = Convert.ToInt32(dr["MinFeeInt"]);
					}
					if (dr["NextFeeInt"] != null && dr["NextFeeInt"] != DBNull.Value)
					{
						item.NextFeeInt = Convert.ToInt32(dr["NextFeeInt"]);
					}
					if (dr["StepWeightInt"] != null && dr["StepWeightInt"] != DBNull.Value)
					{
						item.StepWeightInt = Convert.ToInt32(dr["StepWeightInt"]);
					}
					if (dr["StepWeightMB"] != null && dr["StepWeightMB"] != DBNull.Value)
					{
						item.StepWeightMB = Convert.ToInt32(dr["StepWeightMB"]);
					}
					if (dr["StepWeightMT"] != null && dr["StepWeightMT"] != DBNull.Value)
					{
						item.StepWeightMT = Convert.ToInt32(dr["StepWeightMT"]);
					}
					if (dr["StepWeightMN"] != null && dr["StepWeightMN"] != DBNull.Value)
					{
						item.StepWeightMN = Convert.ToInt32(dr["StepWeightMN"]);
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

		public List<GExpFeeDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpFeeDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpFeeDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpFeeDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpFeeDetail từ Database
		/// </summary>
		public GExpFeeDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpFeeDetail item=new GExpFeeDetail();
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
						if (dr["MinWeightMN"] != null && dr["MinWeightMN"] != DBNull.Value)
						{
							item.MinWeightMN = Convert.ToInt32(dr["MinWeightMN"]);
						}
						if (dr["MinWeightMT"] != null && dr["MinWeightMT"] != DBNull.Value)
						{
							item.MinWeightMT = Convert.ToInt32(dr["MinWeightMT"]);
						}
						if (dr["MinWeightMB"] != null && dr["MinWeightMB"] != DBNull.Value)
						{
							item.MinWeightMB = Convert.ToInt32(dr["MinWeightMB"]);
						}
						if (dr["MinFeeMN"] != null && dr["MinFeeMN"] != DBNull.Value)
						{
							item.MinFeeMN = Convert.ToInt32(dr["MinFeeMN"]);
						}
						if (dr["MinFeeMT"] != null && dr["MinFeeMT"] != DBNull.Value)
						{
							item.MinFeeMT = Convert.ToInt32(dr["MinFeeMT"]);
						}
						if (dr["MinFeeMB"] != null && dr["MinFeeMB"] != DBNull.Value)
						{
							item.MinFeeMB = Convert.ToInt32(dr["MinFeeMB"]);
						}
						if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
						{
							item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
						}
						if (dr["NextFeeMN"] != null && dr["NextFeeMN"] != DBNull.Value)
						{
							item.NextFeeMN = Convert.ToInt32(dr["NextFeeMN"]);
						}
						if (dr["NextFeeMT"] != null && dr["NextFeeMT"] != DBNull.Value)
						{
							item.NextFeeMT = Convert.ToInt32(dr["NextFeeMT"]);
						}
						if (dr["NextFeeMB"] != null && dr["NextFeeMB"] != DBNull.Value)
						{
							item.NextFeeMB = Convert.ToInt32(dr["NextFeeMB"]);
						}
						if (dr["MinWeightInt"] != null && dr["MinWeightInt"] != DBNull.Value)
						{
							item.MinWeightInt = Convert.ToInt32(dr["MinWeightInt"]);
						}
						if (dr["MinFeeInt"] != null && dr["MinFeeInt"] != DBNull.Value)
						{
							item.MinFeeInt = Convert.ToInt32(dr["MinFeeInt"]);
						}
						if (dr["NextFeeInt"] != null && dr["NextFeeInt"] != DBNull.Value)
						{
							item.NextFeeInt = Convert.ToInt32(dr["NextFeeInt"]);
						}
						if (dr["StepWeightInt"] != null && dr["StepWeightInt"] != DBNull.Value)
						{
							item.StepWeightInt = Convert.ToInt32(dr["StepWeightInt"]);
						}
						if (dr["StepWeightMB"] != null && dr["StepWeightMB"] != DBNull.Value)
						{
							item.StepWeightMB = Convert.ToInt32(dr["StepWeightMB"]);
						}
						if (dr["StepWeightMT"] != null && dr["StepWeightMT"] != DBNull.Value)
						{
							item.StepWeightMT = Convert.ToInt32(dr["StepWeightMT"]);
						}
						if (dr["StepWeightMN"] != null && dr["StepWeightMN"] != DBNull.Value)
						{
							item.StepWeightMN = Convert.ToInt32(dr["StepWeightMN"]);
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
		/// Lấy một GExpFeeDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpFeeDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpFeeDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpFeeDetail item=new GExpFeeDetail();
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
						if (dr["MinWeightMN"] != null && dr["MinWeightMN"] != DBNull.Value)
						{
							item.MinWeightMN = Convert.ToInt32(dr["MinWeightMN"]);
						}
						if (dr["MinWeightMT"] != null && dr["MinWeightMT"] != DBNull.Value)
						{
							item.MinWeightMT = Convert.ToInt32(dr["MinWeightMT"]);
						}
						if (dr["MinWeightMB"] != null && dr["MinWeightMB"] != DBNull.Value)
						{
							item.MinWeightMB = Convert.ToInt32(dr["MinWeightMB"]);
						}
						if (dr["MinFeeMN"] != null && dr["MinFeeMN"] != DBNull.Value)
						{
							item.MinFeeMN = Convert.ToInt32(dr["MinFeeMN"]);
						}
						if (dr["MinFeeMT"] != null && dr["MinFeeMT"] != DBNull.Value)
						{
							item.MinFeeMT = Convert.ToInt32(dr["MinFeeMT"]);
						}
						if (dr["MinFeeMB"] != null && dr["MinFeeMB"] != DBNull.Value)
						{
							item.MinFeeMB = Convert.ToInt32(dr["MinFeeMB"]);
						}
						if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
						{
							item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
						}
						if (dr["NextFeeMN"] != null && dr["NextFeeMN"] != DBNull.Value)
						{
							item.NextFeeMN = Convert.ToInt32(dr["NextFeeMN"]);
						}
						if (dr["NextFeeMT"] != null && dr["NextFeeMT"] != DBNull.Value)
						{
							item.NextFeeMT = Convert.ToInt32(dr["NextFeeMT"]);
						}
						if (dr["NextFeeMB"] != null && dr["NextFeeMB"] != DBNull.Value)
						{
							item.NextFeeMB = Convert.ToInt32(dr["NextFeeMB"]);
						}
						if (dr["MinWeightInt"] != null && dr["MinWeightInt"] != DBNull.Value)
						{
							item.MinWeightInt = Convert.ToInt32(dr["MinWeightInt"]);
						}
						if (dr["MinFeeInt"] != null && dr["MinFeeInt"] != DBNull.Value)
						{
							item.MinFeeInt = Convert.ToInt32(dr["MinFeeInt"]);
						}
						if (dr["NextFeeInt"] != null && dr["NextFeeInt"] != DBNull.Value)
						{
							item.NextFeeInt = Convert.ToInt32(dr["NextFeeInt"]);
						}
						if (dr["StepWeightInt"] != null && dr["StepWeightInt"] != DBNull.Value)
						{
							item.StepWeightInt = Convert.ToInt32(dr["StepWeightInt"]);
						}
						if (dr["StepWeightMB"] != null && dr["StepWeightMB"] != DBNull.Value)
						{
							item.StepWeightMB = Convert.ToInt32(dr["StepWeightMB"]);
						}
						if (dr["StepWeightMT"] != null && dr["StepWeightMT"] != DBNull.Value)
						{
							item.StepWeightMT = Convert.ToInt32(dr["StepWeightMT"]);
						}
						if (dr["StepWeightMN"] != null && dr["StepWeightMN"] != DBNull.Value)
						{
							item.StepWeightMN = Convert.ToInt32(dr["StepWeightMN"]);
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

		public GExpFeeDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpFeeDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpFeeDetail>(ds);
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
		/// Thêm mới GExpFeeDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpFeeDetail _GExpFeeDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpFeeDetail](Id, FK_GExpFee, MinWeightMN, MinWeightMT, MinWeightMB, MinFeeMN, MinFeeMT, MinFeeMB, StepWeight, NextFeeMN, NextFeeMT, NextFeeMB, MinWeightInt, MinFeeInt, NextFeeInt, StepWeightInt, StepWeightMB, StepWeightMT, StepWeightMN) VALUES(@Id, @FK_GExpFee, @MinWeightMN, @MinWeightMT, @MinWeightMB, @MinFeeMN, @MinFeeMT, @MinFeeMB, @StepWeight, @NextFeeMN, @NextFeeMT, @NextFeeMB, @MinWeightInt, @MinFeeInt, @NextFeeInt, @StepWeightInt, @StepWeightMB, @StepWeightMT, @StepWeightMN)", 
					"@Id",  _GExpFeeDetail.Id, 
					"@FK_GExpFee",  _GExpFeeDetail.FK_GExpFee, 
					"@MinWeightMN",  _GExpFeeDetail.MinWeightMN, 
					"@MinWeightMT",  _GExpFeeDetail.MinWeightMT, 
					"@MinWeightMB",  _GExpFeeDetail.MinWeightMB, 
					"@MinFeeMN",  _GExpFeeDetail.MinFeeMN, 
					"@MinFeeMT",  _GExpFeeDetail.MinFeeMT, 
					"@MinFeeMB",  _GExpFeeDetail.MinFeeMB, 
					"@StepWeight",  _GExpFeeDetail.StepWeight, 
					"@NextFeeMN",  _GExpFeeDetail.NextFeeMN, 
					"@NextFeeMT",  _GExpFeeDetail.NextFeeMT, 
					"@NextFeeMB",  _GExpFeeDetail.NextFeeMB, 
					"@MinWeightInt",  _GExpFeeDetail.MinWeightInt, 
					"@MinFeeInt",  _GExpFeeDetail.MinFeeInt, 
					"@NextFeeInt",  _GExpFeeDetail.NextFeeInt, 
					"@StepWeightInt",  _GExpFeeDetail.StepWeightInt, 
					"@StepWeightMB",  _GExpFeeDetail.StepWeightMB, 
					"@StepWeightMT",  _GExpFeeDetail.StepWeightMT, 
					"@StepWeightMN",  _GExpFeeDetail.StepWeightMN);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpFeeDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpFeeDetail> _GExpFeeDetails)
		{
			foreach (GExpFeeDetail item in _GExpFeeDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpFeeDetail _GExpFeeDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeDetail] SET Id=@Id, FK_GExpFee=@FK_GExpFee, MinWeightMN=@MinWeightMN, MinWeightMT=@MinWeightMT, MinWeightMB=@MinWeightMB, MinFeeMN=@MinFeeMN, MinFeeMT=@MinFeeMT, MinFeeMB=@MinFeeMB, StepWeight=@StepWeight, NextFeeMN=@NextFeeMN, NextFeeMT=@NextFeeMT, NextFeeMB=@NextFeeMB, MinWeightInt=@MinWeightInt, MinFeeInt=@MinFeeInt, NextFeeInt=@NextFeeInt, StepWeightInt=@StepWeightInt, StepWeightMB=@StepWeightMB, StepWeightMT=@StepWeightMT, StepWeightMN=@StepWeightMN WHERE Id=@Id", 
					"@Id",  _GExpFeeDetail.Id, 
					"@FK_GExpFee",  _GExpFeeDetail.FK_GExpFee, 
					"@MinWeightMN",  _GExpFeeDetail.MinWeightMN, 
					"@MinWeightMT",  _GExpFeeDetail.MinWeightMT, 
					"@MinWeightMB",  _GExpFeeDetail.MinWeightMB, 
					"@MinFeeMN",  _GExpFeeDetail.MinFeeMN, 
					"@MinFeeMT",  _GExpFeeDetail.MinFeeMT, 
					"@MinFeeMB",  _GExpFeeDetail.MinFeeMB, 
					"@StepWeight",  _GExpFeeDetail.StepWeight, 
					"@NextFeeMN",  _GExpFeeDetail.NextFeeMN, 
					"@NextFeeMT",  _GExpFeeDetail.NextFeeMT, 
					"@NextFeeMB",  _GExpFeeDetail.NextFeeMB, 
					"@MinWeightInt",  _GExpFeeDetail.MinWeightInt, 
					"@MinFeeInt",  _GExpFeeDetail.MinFeeInt, 
					"@NextFeeInt",  _GExpFeeDetail.NextFeeInt, 
					"@StepWeightInt",  _GExpFeeDetail.StepWeightInt, 
					"@StepWeightMB",  _GExpFeeDetail.StepWeightMB, 
					"@StepWeightMT",  _GExpFeeDetail.StepWeightMT, 
					"@StepWeightMN",  _GExpFeeDetail.StepWeightMN, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpFeeDetail _GExpFeeDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeDetail] SET FK_GExpFee=@FK_GExpFee, MinWeightMN=@MinWeightMN, MinWeightMT=@MinWeightMT, MinWeightMB=@MinWeightMB, MinFeeMN=@MinFeeMN, MinFeeMT=@MinFeeMT, MinFeeMB=@MinFeeMB, StepWeight=@StepWeight, NextFeeMN=@NextFeeMN, NextFeeMT=@NextFeeMT, NextFeeMB=@NextFeeMB, MinWeightInt=@MinWeightInt, MinFeeInt=@MinFeeInt, NextFeeInt=@NextFeeInt, StepWeightInt=@StepWeightInt, StepWeightMB=@StepWeightMB, StepWeightMT=@StepWeightMT, StepWeightMN=@StepWeightMN WHERE Id=@Id", 
					"@FK_GExpFee",  _GExpFeeDetail.FK_GExpFee, 
					"@MinWeightMN",  _GExpFeeDetail.MinWeightMN, 
					"@MinWeightMT",  _GExpFeeDetail.MinWeightMT, 
					"@MinWeightMB",  _GExpFeeDetail.MinWeightMB, 
					"@MinFeeMN",  _GExpFeeDetail.MinFeeMN, 
					"@MinFeeMT",  _GExpFeeDetail.MinFeeMT, 
					"@MinFeeMB",  _GExpFeeDetail.MinFeeMB, 
					"@StepWeight",  _GExpFeeDetail.StepWeight, 
					"@NextFeeMN",  _GExpFeeDetail.NextFeeMN, 
					"@NextFeeMT",  _GExpFeeDetail.NextFeeMT, 
					"@NextFeeMB",  _GExpFeeDetail.NextFeeMB, 
					"@MinWeightInt",  _GExpFeeDetail.MinWeightInt, 
					"@MinFeeInt",  _GExpFeeDetail.MinFeeInt, 
					"@NextFeeInt",  _GExpFeeDetail.NextFeeInt, 
					"@StepWeightInt",  _GExpFeeDetail.StepWeightInt, 
					"@StepWeightMB",  _GExpFeeDetail.StepWeightMB, 
					"@StepWeightMT",  _GExpFeeDetail.StepWeightMT, 
					"@StepWeightMN",  _GExpFeeDetail.StepWeightMN, 
					"@Id", _GExpFeeDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpFeeDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpFeeDetail> _GExpFeeDetails)
		{
			foreach (GExpFeeDetail item in _GExpFeeDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpFeeDetail _GExpFeeDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeDetail] SET Id=@Id, FK_GExpFee=@FK_GExpFee, MinWeightMN=@MinWeightMN, MinWeightMT=@MinWeightMT, MinWeightMB=@MinWeightMB, MinFeeMN=@MinFeeMN, MinFeeMT=@MinFeeMT, MinFeeMB=@MinFeeMB, StepWeight=@StepWeight, NextFeeMN=@NextFeeMN, NextFeeMT=@NextFeeMT, NextFeeMB=@NextFeeMB, MinWeightInt=@MinWeightInt, MinFeeInt=@MinFeeInt, NextFeeInt=@NextFeeInt, StepWeightInt=@StepWeightInt, StepWeightMB=@StepWeightMB, StepWeightMT=@StepWeightMT, StepWeightMN=@StepWeightMN "+ condition, 
					"@Id",  _GExpFeeDetail.Id, 
					"@FK_GExpFee",  _GExpFeeDetail.FK_GExpFee, 
					"@MinWeightMN",  _GExpFeeDetail.MinWeightMN, 
					"@MinWeightMT",  _GExpFeeDetail.MinWeightMT, 
					"@MinWeightMB",  _GExpFeeDetail.MinWeightMB, 
					"@MinFeeMN",  _GExpFeeDetail.MinFeeMN, 
					"@MinFeeMT",  _GExpFeeDetail.MinFeeMT, 
					"@MinFeeMB",  _GExpFeeDetail.MinFeeMB, 
					"@StepWeight",  _GExpFeeDetail.StepWeight, 
					"@NextFeeMN",  _GExpFeeDetail.NextFeeMN, 
					"@NextFeeMT",  _GExpFeeDetail.NextFeeMT, 
					"@NextFeeMB",  _GExpFeeDetail.NextFeeMB, 
					"@MinWeightInt",  _GExpFeeDetail.MinWeightInt, 
					"@MinFeeInt",  _GExpFeeDetail.MinFeeInt, 
					"@NextFeeInt",  _GExpFeeDetail.NextFeeInt, 
					"@StepWeightInt",  _GExpFeeDetail.StepWeightInt, 
					"@StepWeightMB",  _GExpFeeDetail.StepWeightMB, 
					"@StepWeightMT",  _GExpFeeDetail.StepWeightMT, 
					"@StepWeightMN",  _GExpFeeDetail.StepWeightMN);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpFeeDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpFeeDetail _GExpFeeDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeDetail] WHERE Id=@Id",
					"@Id", _GExpFeeDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpFeeDetail> _GExpFeeDetails)
		{
			foreach (GExpFeeDetail item in _GExpFeeDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
