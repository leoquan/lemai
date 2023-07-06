using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpfeedebitsession:IGExpfeedebitsession
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpfeedebitsession(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpFeeDebitSession từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeDebitSession]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpFeeDebitSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeDebitSession] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpFeeDebitSession từ Database
		/// </summary>
		public List<GExpFeeDebitSession> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeDebitSession]");
				List<GExpFeeDebitSession> items = new List<GExpFeeDebitSession>();
				GExpFeeDebitSession item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpFeeDebitSession();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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
					if (dr["ReturnFee"] != null && dr["ReturnFee"] != DBNull.Value)
					{
						item.ReturnFee = Convert.ToBoolean(dr["ReturnFee"]);
					}
					if (dr["Insurance"] != null && dr["Insurance"] != DBNull.Value)
					{
						item.Insurance = Convert.ToInt32(dr["Insurance"]);
					}
					if (dr["CODFee"] != null && dr["CODFee"] != DBNull.Value)
					{
						item.CODFee = Convert.ToInt32(dr["CODFee"]);
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
		/// Lấy danh sách GExpFeeDebitSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpFeeDebitSession> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpFeeDebitSession] A "+ condition,  parameters);
				List<GExpFeeDebitSession> items = new List<GExpFeeDebitSession>();
				GExpFeeDebitSession item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpFeeDebitSession();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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
					if (dr["ReturnFee"] != null && dr["ReturnFee"] != DBNull.Value)
					{
						item.ReturnFee = Convert.ToBoolean(dr["ReturnFee"]);
					}
					if (dr["Insurance"] != null && dr["Insurance"] != DBNull.Value)
					{
						item.Insurance = Convert.ToInt32(dr["Insurance"]);
					}
					if (dr["CODFee"] != null && dr["CODFee"] != DBNull.Value)
					{
						item.CODFee = Convert.ToInt32(dr["CODFee"]);
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

		public List<GExpFeeDebitSession> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpFeeDebitSession] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpFeeDebitSession] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpFeeDebitSession>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpFeeDebitSession từ Database
		/// </summary>
		public GExpFeeDebitSession GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpFeeDebitSession] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpFeeDebitSession item=new GExpFeeDebitSession();
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
						if (dr["ReturnFee"] != null && dr["ReturnFee"] != DBNull.Value)
						{
							item.ReturnFee = Convert.ToBoolean(dr["ReturnFee"]);
						}
						if (dr["Insurance"] != null && dr["Insurance"] != DBNull.Value)
						{
							item.Insurance = Convert.ToInt32(dr["Insurance"]);
						}
						if (dr["CODFee"] != null && dr["CODFee"] != DBNull.Value)
						{
							item.CODFee = Convert.ToInt32(dr["CODFee"]);
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
		/// Lấy một GExpFeeDebitSession đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpFeeDebitSession GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpFeeDebitSession] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpFeeDebitSession item=new GExpFeeDebitSession();
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
						if (dr["ReturnFee"] != null && dr["ReturnFee"] != DBNull.Value)
						{
							item.ReturnFee = Convert.ToBoolean(dr["ReturnFee"]);
						}
						if (dr["Insurance"] != null && dr["Insurance"] != DBNull.Value)
						{
							item.Insurance = Convert.ToInt32(dr["Insurance"]);
						}
						if (dr["CODFee"] != null && dr["CODFee"] != DBNull.Value)
						{
							item.CODFee = Convert.ToInt32(dr["CODFee"]);
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

		public GExpFeeDebitSession GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpFeeDebitSession] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpFeeDebitSession>(ds);
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
		/// Thêm mới GExpFeeDebitSession vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpFeeDebitSession _GExpFeeDebitSession)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpFeeDebitSession](Id, FK_Post, MinWeightMN, MinWeightMT, MinWeightMB, MinFeeMN, MinFeeMT, MinFeeMB, NextFeeMN, NextFeeMT, NextFeeMB, MinWeightInt, MinFeeInt, NextFeeInt, StepWeightInt, StepWeightMB, StepWeightMT, StepWeightMN, ReturnFee, Insurance, CODFee) VALUES(@Id, @FK_Post, @MinWeightMN, @MinWeightMT, @MinWeightMB, @MinFeeMN, @MinFeeMT, @MinFeeMB, @NextFeeMN, @NextFeeMT, @NextFeeMB, @MinWeightInt, @MinFeeInt, @NextFeeInt, @StepWeightInt, @StepWeightMB, @StepWeightMT, @StepWeightMN, @ReturnFee, @Insurance, @CODFee)", 
					"@Id",  _GExpFeeDebitSession.Id, 
					"@FK_Post",  _GExpFeeDebitSession.FK_Post, 
					"@MinWeightMN",  _GExpFeeDebitSession.MinWeightMN, 
					"@MinWeightMT",  _GExpFeeDebitSession.MinWeightMT, 
					"@MinWeightMB",  _GExpFeeDebitSession.MinWeightMB, 
					"@MinFeeMN",  _GExpFeeDebitSession.MinFeeMN, 
					"@MinFeeMT",  _GExpFeeDebitSession.MinFeeMT, 
					"@MinFeeMB",  _GExpFeeDebitSession.MinFeeMB, 
					"@NextFeeMN",  _GExpFeeDebitSession.NextFeeMN, 
					"@NextFeeMT",  _GExpFeeDebitSession.NextFeeMT, 
					"@NextFeeMB",  _GExpFeeDebitSession.NextFeeMB, 
					"@MinWeightInt",  _GExpFeeDebitSession.MinWeightInt, 
					"@MinFeeInt",  _GExpFeeDebitSession.MinFeeInt, 
					"@NextFeeInt",  _GExpFeeDebitSession.NextFeeInt, 
					"@StepWeightInt",  _GExpFeeDebitSession.StepWeightInt, 
					"@StepWeightMB",  _GExpFeeDebitSession.StepWeightMB, 
					"@StepWeightMT",  _GExpFeeDebitSession.StepWeightMT, 
					"@StepWeightMN",  _GExpFeeDebitSession.StepWeightMN, 
					"@ReturnFee",  _GExpFeeDebitSession.ReturnFee, 
					"@Insurance",  _GExpFeeDebitSession.Insurance, 
					"@CODFee",  _GExpFeeDebitSession.CODFee);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpFeeDebitSession vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpFeeDebitSession> _GExpFeeDebitSessions)
		{
			foreach (GExpFeeDebitSession item in _GExpFeeDebitSessions)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeDebitSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpFeeDebitSession _GExpFeeDebitSession, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeDebitSession] SET Id=@Id, FK_Post=@FK_Post, MinWeightMN=@MinWeightMN, MinWeightMT=@MinWeightMT, MinWeightMB=@MinWeightMB, MinFeeMN=@MinFeeMN, MinFeeMT=@MinFeeMT, MinFeeMB=@MinFeeMB, NextFeeMN=@NextFeeMN, NextFeeMT=@NextFeeMT, NextFeeMB=@NextFeeMB, MinWeightInt=@MinWeightInt, MinFeeInt=@MinFeeInt, NextFeeInt=@NextFeeInt, StepWeightInt=@StepWeightInt, StepWeightMB=@StepWeightMB, StepWeightMT=@StepWeightMT, StepWeightMN=@StepWeightMN, ReturnFee=@ReturnFee, Insurance=@Insurance, CODFee=@CODFee WHERE Id=@Id", 
					"@Id",  _GExpFeeDebitSession.Id, 
					"@FK_Post",  _GExpFeeDebitSession.FK_Post, 
					"@MinWeightMN",  _GExpFeeDebitSession.MinWeightMN, 
					"@MinWeightMT",  _GExpFeeDebitSession.MinWeightMT, 
					"@MinWeightMB",  _GExpFeeDebitSession.MinWeightMB, 
					"@MinFeeMN",  _GExpFeeDebitSession.MinFeeMN, 
					"@MinFeeMT",  _GExpFeeDebitSession.MinFeeMT, 
					"@MinFeeMB",  _GExpFeeDebitSession.MinFeeMB, 
					"@NextFeeMN",  _GExpFeeDebitSession.NextFeeMN, 
					"@NextFeeMT",  _GExpFeeDebitSession.NextFeeMT, 
					"@NextFeeMB",  _GExpFeeDebitSession.NextFeeMB, 
					"@MinWeightInt",  _GExpFeeDebitSession.MinWeightInt, 
					"@MinFeeInt",  _GExpFeeDebitSession.MinFeeInt, 
					"@NextFeeInt",  _GExpFeeDebitSession.NextFeeInt, 
					"@StepWeightInt",  _GExpFeeDebitSession.StepWeightInt, 
					"@StepWeightMB",  _GExpFeeDebitSession.StepWeightMB, 
					"@StepWeightMT",  _GExpFeeDebitSession.StepWeightMT, 
					"@StepWeightMN",  _GExpFeeDebitSession.StepWeightMN, 
					"@ReturnFee",  _GExpFeeDebitSession.ReturnFee, 
					"@Insurance",  _GExpFeeDebitSession.Insurance, 
					"@CODFee",  _GExpFeeDebitSession.CODFee, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeDebitSession vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpFeeDebitSession _GExpFeeDebitSession)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeDebitSession] SET FK_Post=@FK_Post, MinWeightMN=@MinWeightMN, MinWeightMT=@MinWeightMT, MinWeightMB=@MinWeightMB, MinFeeMN=@MinFeeMN, MinFeeMT=@MinFeeMT, MinFeeMB=@MinFeeMB, NextFeeMN=@NextFeeMN, NextFeeMT=@NextFeeMT, NextFeeMB=@NextFeeMB, MinWeightInt=@MinWeightInt, MinFeeInt=@MinFeeInt, NextFeeInt=@NextFeeInt, StepWeightInt=@StepWeightInt, StepWeightMB=@StepWeightMB, StepWeightMT=@StepWeightMT, StepWeightMN=@StepWeightMN, ReturnFee=@ReturnFee, Insurance=@Insurance, CODFee=@CODFee WHERE Id=@Id", 
					"@FK_Post",  _GExpFeeDebitSession.FK_Post, 
					"@MinWeightMN",  _GExpFeeDebitSession.MinWeightMN, 
					"@MinWeightMT",  _GExpFeeDebitSession.MinWeightMT, 
					"@MinWeightMB",  _GExpFeeDebitSession.MinWeightMB, 
					"@MinFeeMN",  _GExpFeeDebitSession.MinFeeMN, 
					"@MinFeeMT",  _GExpFeeDebitSession.MinFeeMT, 
					"@MinFeeMB",  _GExpFeeDebitSession.MinFeeMB, 
					"@NextFeeMN",  _GExpFeeDebitSession.NextFeeMN, 
					"@NextFeeMT",  _GExpFeeDebitSession.NextFeeMT, 
					"@NextFeeMB",  _GExpFeeDebitSession.NextFeeMB, 
					"@MinWeightInt",  _GExpFeeDebitSession.MinWeightInt, 
					"@MinFeeInt",  _GExpFeeDebitSession.MinFeeInt, 
					"@NextFeeInt",  _GExpFeeDebitSession.NextFeeInt, 
					"@StepWeightInt",  _GExpFeeDebitSession.StepWeightInt, 
					"@StepWeightMB",  _GExpFeeDebitSession.StepWeightMB, 
					"@StepWeightMT",  _GExpFeeDebitSession.StepWeightMT, 
					"@StepWeightMN",  _GExpFeeDebitSession.StepWeightMN, 
					"@ReturnFee",  _GExpFeeDebitSession.ReturnFee, 
					"@Insurance",  _GExpFeeDebitSession.Insurance, 
					"@CODFee",  _GExpFeeDebitSession.CODFee, 
					"@Id", _GExpFeeDebitSession.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpFeeDebitSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpFeeDebitSession> _GExpFeeDebitSessions)
		{
			foreach (GExpFeeDebitSession item in _GExpFeeDebitSessions)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpFeeDebitSession vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpFeeDebitSession _GExpFeeDebitSession, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpFeeDebitSession] SET Id=@Id, FK_Post=@FK_Post, MinWeightMN=@MinWeightMN, MinWeightMT=@MinWeightMT, MinWeightMB=@MinWeightMB, MinFeeMN=@MinFeeMN, MinFeeMT=@MinFeeMT, MinFeeMB=@MinFeeMB, NextFeeMN=@NextFeeMN, NextFeeMT=@NextFeeMT, NextFeeMB=@NextFeeMB, MinWeightInt=@MinWeightInt, MinFeeInt=@MinFeeInt, NextFeeInt=@NextFeeInt, StepWeightInt=@StepWeightInt, StepWeightMB=@StepWeightMB, StepWeightMT=@StepWeightMT, StepWeightMN=@StepWeightMN, ReturnFee=@ReturnFee, Insurance=@Insurance, CODFee=@CODFee "+ condition, 
					"@Id",  _GExpFeeDebitSession.Id, 
					"@FK_Post",  _GExpFeeDebitSession.FK_Post, 
					"@MinWeightMN",  _GExpFeeDebitSession.MinWeightMN, 
					"@MinWeightMT",  _GExpFeeDebitSession.MinWeightMT, 
					"@MinWeightMB",  _GExpFeeDebitSession.MinWeightMB, 
					"@MinFeeMN",  _GExpFeeDebitSession.MinFeeMN, 
					"@MinFeeMT",  _GExpFeeDebitSession.MinFeeMT, 
					"@MinFeeMB",  _GExpFeeDebitSession.MinFeeMB, 
					"@NextFeeMN",  _GExpFeeDebitSession.NextFeeMN, 
					"@NextFeeMT",  _GExpFeeDebitSession.NextFeeMT, 
					"@NextFeeMB",  _GExpFeeDebitSession.NextFeeMB, 
					"@MinWeightInt",  _GExpFeeDebitSession.MinWeightInt, 
					"@MinFeeInt",  _GExpFeeDebitSession.MinFeeInt, 
					"@NextFeeInt",  _GExpFeeDebitSession.NextFeeInt, 
					"@StepWeightInt",  _GExpFeeDebitSession.StepWeightInt, 
					"@StepWeightMB",  _GExpFeeDebitSession.StepWeightMB, 
					"@StepWeightMT",  _GExpFeeDebitSession.StepWeightMT, 
					"@StepWeightMN",  _GExpFeeDebitSession.StepWeightMN, 
					"@ReturnFee",  _GExpFeeDebitSession.ReturnFee, 
					"@Insurance",  _GExpFeeDebitSession.Insurance, 
					"@CODFee",  _GExpFeeDebitSession.CODFee);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpFeeDebitSession trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeDebitSession] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeDebitSession trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpFeeDebitSession _GExpFeeDebitSession)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeDebitSession] WHERE Id=@Id",
					"@Id", _GExpFeeDebitSession.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeDebitSession trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpFeeDebitSession] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpFeeDebitSession trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpFeeDebitSession> _GExpFeeDebitSessions)
		{
			foreach (GExpFeeDebitSession item in _GExpFeeDebitSessions)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
