using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpfeedetails:IVIewgexpfeedetails
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpfeedetails(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpFeeDetails từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpFeeDetails]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpFeeDetails từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpFeeDetails] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpFeeDetails từ Database
		/// </summary>
		public List<view_GExpFeeDetails> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpFeeDetails]");
				List<view_GExpFeeDetails> items = new List<view_GExpFeeDetails>();
				view_GExpFeeDetails item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpFeeDetails();
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
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
					{
						item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
					}
					if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
					{
						item.FeeName = Convert.ToString(dr["FeeName"]);
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
		/// Lấy danh sách view_GExpFeeDetails từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpFeeDetails> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpFeeDetails] A "+ condition,  parameters);
				List<view_GExpFeeDetails> items = new List<view_GExpFeeDetails>();
				view_GExpFeeDetails item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpFeeDetails();
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
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
					{
						item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
					}
					if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
					{
						item.FeeName = Convert.ToString(dr["FeeName"]);
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

		public List<view_GExpFeeDetails> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpFeeDetails] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpFeeDetails] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpFeeDetails>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpFeeDetails đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpFeeDetails GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpFeeDetails] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpFeeDetails item=new view_GExpFeeDetails();
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
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
						{
							item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
						}
						if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
						{
							item.FeeName = Convert.ToString(dr["FeeName"]);
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

		public view_GExpFeeDetails GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpFeeDetails] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpFeeDetails>(ds);
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
	}
}
