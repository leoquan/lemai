using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdebitsessiondetail:IGExpdebitsessiondetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdebitsessiondetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDebitSessionDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitSessionDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDebitSessionDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitSessionDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDebitSessionDetail từ Database
		/// </summary>
		public List<GExpDebitSessionDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitSessionDetail]");
				List<GExpDebitSessionDetail> items = new List<GExpDebitSessionDetail>();
				GExpDebitSessionDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDebitSessionDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DebitSession"] != null && dr["FK_DebitSession"] != DBNull.Value)
					{
						item.FK_DebitSession = Convert.ToString(dr["FK_DebitSession"]);
					}
					if (dr["TotalCost"] != null && dr["TotalCost"] != DBNull.Value)
					{
						item.TotalCost = Convert.ToDecimal(dr["TotalCost"]);
					}
					if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
					{
						item.TotalFee = Convert.ToDecimal(dr["TotalFee"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["ReturnCODMaster"] != null && dr["ReturnCODMaster"] != DBNull.Value)
					{
						item.ReturnCODMaster = Convert.ToDecimal(dr["ReturnCODMaster"]);
					}
					if (dr["ReturnCODSlave"] != null && dr["ReturnCODSlave"] != DBNull.Value)
					{
						item.ReturnCODSlave = Convert.ToDecimal(dr["ReturnCODSlave"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["FK_DebitComparisonDetail"] != null && dr["FK_DebitComparisonDetail"] != DBNull.Value)
					{
						item.FK_DebitComparisonDetail = Convert.ToString(dr["FK_DebitComparisonDetail"]);
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
		/// Lấy danh sách GExpDebitSessionDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDebitSessionDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDebitSessionDetail] A "+ condition,  parameters);
				List<GExpDebitSessionDetail> items = new List<GExpDebitSessionDetail>();
				GExpDebitSessionDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDebitSessionDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DebitSession"] != null && dr["FK_DebitSession"] != DBNull.Value)
					{
						item.FK_DebitSession = Convert.ToString(dr["FK_DebitSession"]);
					}
					if (dr["TotalCost"] != null && dr["TotalCost"] != DBNull.Value)
					{
						item.TotalCost = Convert.ToDecimal(dr["TotalCost"]);
					}
					if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
					{
						item.TotalFee = Convert.ToDecimal(dr["TotalFee"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["ReturnCODMaster"] != null && dr["ReturnCODMaster"] != DBNull.Value)
					{
						item.ReturnCODMaster = Convert.ToDecimal(dr["ReturnCODMaster"]);
					}
					if (dr["ReturnCODSlave"] != null && dr["ReturnCODSlave"] != DBNull.Value)
					{
						item.ReturnCODSlave = Convert.ToDecimal(dr["ReturnCODSlave"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["FK_DebitComparisonDetail"] != null && dr["FK_DebitComparisonDetail"] != DBNull.Value)
					{
						item.FK_DebitComparisonDetail = Convert.ToString(dr["FK_DebitComparisonDetail"]);
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

		public List<GExpDebitSessionDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDebitSessionDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDebitSessionDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDebitSessionDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDebitSessionDetail từ Database
		/// </summary>
		public GExpDebitSessionDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitSessionDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpDebitSessionDetail item=new GExpDebitSessionDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DebitSession"] != null && dr["FK_DebitSession"] != DBNull.Value)
						{
							item.FK_DebitSession = Convert.ToString(dr["FK_DebitSession"]);
						}
						if (dr["TotalCost"] != null && dr["TotalCost"] != DBNull.Value)
						{
							item.TotalCost = Convert.ToDecimal(dr["TotalCost"]);
						}
						if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
						{
							item.TotalFee = Convert.ToDecimal(dr["TotalFee"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["ReturnCODMaster"] != null && dr["ReturnCODMaster"] != DBNull.Value)
						{
							item.ReturnCODMaster = Convert.ToDecimal(dr["ReturnCODMaster"]);
						}
						if (dr["ReturnCODSlave"] != null && dr["ReturnCODSlave"] != DBNull.Value)
						{
							item.ReturnCODSlave = Convert.ToDecimal(dr["ReturnCODSlave"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["FK_DebitComparisonDetail"] != null && dr["FK_DebitComparisonDetail"] != DBNull.Value)
						{
							item.FK_DebitComparisonDetail = Convert.ToString(dr["FK_DebitComparisonDetail"]);
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
		/// Lấy một GExpDebitSessionDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDebitSessionDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDebitSessionDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDebitSessionDetail item=new GExpDebitSessionDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DebitSession"] != null && dr["FK_DebitSession"] != DBNull.Value)
						{
							item.FK_DebitSession = Convert.ToString(dr["FK_DebitSession"]);
						}
						if (dr["TotalCost"] != null && dr["TotalCost"] != DBNull.Value)
						{
							item.TotalCost = Convert.ToDecimal(dr["TotalCost"]);
						}
						if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
						{
							item.TotalFee = Convert.ToDecimal(dr["TotalFee"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["ReturnCODMaster"] != null && dr["ReturnCODMaster"] != DBNull.Value)
						{
							item.ReturnCODMaster = Convert.ToDecimal(dr["ReturnCODMaster"]);
						}
						if (dr["ReturnCODSlave"] != null && dr["ReturnCODSlave"] != DBNull.Value)
						{
							item.ReturnCODSlave = Convert.ToDecimal(dr["ReturnCODSlave"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["FK_DebitComparisonDetail"] != null && dr["FK_DebitComparisonDetail"] != DBNull.Value)
						{
							item.FK_DebitComparisonDetail = Convert.ToString(dr["FK_DebitComparisonDetail"]);
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

		public GExpDebitSessionDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDebitSessionDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDebitSessionDetail>(ds);
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
		/// Thêm mới GExpDebitSessionDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDebitSessionDetail _GExpDebitSessionDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDebitSessionDetail](Id, FK_DebitSession, TotalCost, TotalFee, COD, ReturnCODMaster, ReturnCODSlave, BillCode, BT3Code, FK_DebitComparisonDetail) VALUES(@Id, @FK_DebitSession, @TotalCost, @TotalFee, @COD, @ReturnCODMaster, @ReturnCODSlave, @BillCode, @BT3Code, @FK_DebitComparisonDetail)", 
					"@Id",  _GExpDebitSessionDetail.Id, 
					"@FK_DebitSession",  _GExpDebitSessionDetail.FK_DebitSession, 
					"@TotalCost",  _GExpDebitSessionDetail.TotalCost, 
					"@TotalFee",  _GExpDebitSessionDetail.TotalFee, 
					"@COD",  _GExpDebitSessionDetail.COD, 
					"@ReturnCODMaster",  _GExpDebitSessionDetail.ReturnCODMaster, 
					"@ReturnCODSlave",  _GExpDebitSessionDetail.ReturnCODSlave, 
					"@BillCode",  _GExpDebitSessionDetail.BillCode, 
					"@BT3Code",  _GExpDebitSessionDetail.BT3Code, 
					"@FK_DebitComparisonDetail",  _GExpDebitSessionDetail.FK_DebitComparisonDetail);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDebitSessionDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDebitSessionDetail> _GExpDebitSessionDetails)
		{
			foreach (GExpDebitSessionDetail item in _GExpDebitSessionDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitSessionDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDebitSessionDetail _GExpDebitSessionDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitSessionDetail] SET Id=@Id, FK_DebitSession=@FK_DebitSession, TotalCost=@TotalCost, TotalFee=@TotalFee, COD=@COD, ReturnCODMaster=@ReturnCODMaster, ReturnCODSlave=@ReturnCODSlave, BillCode=@BillCode, BT3Code=@BT3Code, FK_DebitComparisonDetail=@FK_DebitComparisonDetail WHERE Id=@Id", 
					"@Id",  _GExpDebitSessionDetail.Id, 
					"@FK_DebitSession",  _GExpDebitSessionDetail.FK_DebitSession, 
					"@TotalCost",  _GExpDebitSessionDetail.TotalCost, 
					"@TotalFee",  _GExpDebitSessionDetail.TotalFee, 
					"@COD",  _GExpDebitSessionDetail.COD, 
					"@ReturnCODMaster",  _GExpDebitSessionDetail.ReturnCODMaster, 
					"@ReturnCODSlave",  _GExpDebitSessionDetail.ReturnCODSlave, 
					"@BillCode",  _GExpDebitSessionDetail.BillCode, 
					"@BT3Code",  _GExpDebitSessionDetail.BT3Code, 
					"@FK_DebitComparisonDetail",  _GExpDebitSessionDetail.FK_DebitComparisonDetail, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitSessionDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDebitSessionDetail _GExpDebitSessionDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitSessionDetail] SET FK_DebitSession=@FK_DebitSession, TotalCost=@TotalCost, TotalFee=@TotalFee, COD=@COD, ReturnCODMaster=@ReturnCODMaster, ReturnCODSlave=@ReturnCODSlave, BillCode=@BillCode, BT3Code=@BT3Code, FK_DebitComparisonDetail=@FK_DebitComparisonDetail WHERE Id=@Id", 
					"@FK_DebitSession",  _GExpDebitSessionDetail.FK_DebitSession, 
					"@TotalCost",  _GExpDebitSessionDetail.TotalCost, 
					"@TotalFee",  _GExpDebitSessionDetail.TotalFee, 
					"@COD",  _GExpDebitSessionDetail.COD, 
					"@ReturnCODMaster",  _GExpDebitSessionDetail.ReturnCODMaster, 
					"@ReturnCODSlave",  _GExpDebitSessionDetail.ReturnCODSlave, 
					"@BillCode",  _GExpDebitSessionDetail.BillCode, 
					"@BT3Code",  _GExpDebitSessionDetail.BT3Code, 
					"@FK_DebitComparisonDetail",  _GExpDebitSessionDetail.FK_DebitComparisonDetail, 
					"@Id", _GExpDebitSessionDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDebitSessionDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDebitSessionDetail> _GExpDebitSessionDetails)
		{
			foreach (GExpDebitSessionDetail item in _GExpDebitSessionDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitSessionDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDebitSessionDetail _GExpDebitSessionDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitSessionDetail] SET Id=@Id, FK_DebitSession=@FK_DebitSession, TotalCost=@TotalCost, TotalFee=@TotalFee, COD=@COD, ReturnCODMaster=@ReturnCODMaster, ReturnCODSlave=@ReturnCODSlave, BillCode=@BillCode, BT3Code=@BT3Code, FK_DebitComparisonDetail=@FK_DebitComparisonDetail "+ condition, 
					"@Id",  _GExpDebitSessionDetail.Id, 
					"@FK_DebitSession",  _GExpDebitSessionDetail.FK_DebitSession, 
					"@TotalCost",  _GExpDebitSessionDetail.TotalCost, 
					"@TotalFee",  _GExpDebitSessionDetail.TotalFee, 
					"@COD",  _GExpDebitSessionDetail.COD, 
					"@ReturnCODMaster",  _GExpDebitSessionDetail.ReturnCODMaster, 
					"@ReturnCODSlave",  _GExpDebitSessionDetail.ReturnCODSlave, 
					"@BillCode",  _GExpDebitSessionDetail.BillCode, 
					"@BT3Code",  _GExpDebitSessionDetail.BT3Code, 
					"@FK_DebitComparisonDetail",  _GExpDebitSessionDetail.FK_DebitComparisonDetail);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDebitSessionDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitSessionDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitSessionDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDebitSessionDetail _GExpDebitSessionDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitSessionDetail] WHERE Id=@Id",
					"@Id", _GExpDebitSessionDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitSessionDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitSessionDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitSessionDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDebitSessionDetail> _GExpDebitSessionDetails)
		{
			foreach (GExpDebitSessionDetail item in _GExpDebitSessionDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
