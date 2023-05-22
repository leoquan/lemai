using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSrequestfindproducthistory:IGSrequestfindproducthistory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSrequestfindproducthistory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsRequestFindProductHistory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestFindProductHistory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsRequestFindProductHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestFindProductHistory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsRequestFindProductHistory từ Database
		/// </summary>
		public List<GsRequestFindProductHistory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestFindProductHistory]");
				List<GsRequestFindProductHistory> items = new List<GsRequestFindProductHistory>();
				GsRequestFindProductHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsRequestFindProductHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_RequestFindProduct"] != null && dr["FK_RequestFindProduct"] != DBNull.Value)
					{
						item.FK_RequestFindProduct = Convert.ToString(dr["FK_RequestFindProduct"]);
					}
					if (dr["FK_UserProcess"] != null && dr["FK_UserProcess"] != DBNull.Value)
					{
						item.FK_UserProcess = Convert.ToString(dr["FK_UserProcess"]);
					}
					if (dr["ProcessNote"] != null && dr["ProcessNote"] != DBNull.Value)
					{
						item.ProcessNote = Convert.ToString(dr["ProcessNote"]);
					}
					if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
					{
						item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
					}
					if (dr["ProcessType"] != null && dr["ProcessType"] != DBNull.Value)
					{
						item.ProcessType = Convert.ToString(dr["ProcessType"]);
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
		/// Lấy danh sách GsRequestFindProductHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsRequestFindProductHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsRequestFindProductHistory] A "+ condition,  parameters);
				List<GsRequestFindProductHistory> items = new List<GsRequestFindProductHistory>();
				GsRequestFindProductHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsRequestFindProductHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_RequestFindProduct"] != null && dr["FK_RequestFindProduct"] != DBNull.Value)
					{
						item.FK_RequestFindProduct = Convert.ToString(dr["FK_RequestFindProduct"]);
					}
					if (dr["FK_UserProcess"] != null && dr["FK_UserProcess"] != DBNull.Value)
					{
						item.FK_UserProcess = Convert.ToString(dr["FK_UserProcess"]);
					}
					if (dr["ProcessNote"] != null && dr["ProcessNote"] != DBNull.Value)
					{
						item.ProcessNote = Convert.ToString(dr["ProcessNote"]);
					}
					if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
					{
						item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
					}
					if (dr["ProcessType"] != null && dr["ProcessType"] != DBNull.Value)
					{
						item.ProcessType = Convert.ToString(dr["ProcessType"]);
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

		public List<GsRequestFindProductHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsRequestFindProductHistory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsRequestFindProductHistory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsRequestFindProductHistory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsRequestFindProductHistory từ Database
		/// </summary>
		public GsRequestFindProductHistory GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestFindProductHistory] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsRequestFindProductHistory item=new GsRequestFindProductHistory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_RequestFindProduct"] != null && dr["FK_RequestFindProduct"] != DBNull.Value)
						{
							item.FK_RequestFindProduct = Convert.ToString(dr["FK_RequestFindProduct"]);
						}
						if (dr["FK_UserProcess"] != null && dr["FK_UserProcess"] != DBNull.Value)
						{
							item.FK_UserProcess = Convert.ToString(dr["FK_UserProcess"]);
						}
						if (dr["ProcessNote"] != null && dr["ProcessNote"] != DBNull.Value)
						{
							item.ProcessNote = Convert.ToString(dr["ProcessNote"]);
						}
						if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
						{
							item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
						}
						if (dr["ProcessType"] != null && dr["ProcessType"] != DBNull.Value)
						{
							item.ProcessType = Convert.ToString(dr["ProcessType"]);
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
		/// Lấy một GsRequestFindProductHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsRequestFindProductHistory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsRequestFindProductHistory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsRequestFindProductHistory item=new GsRequestFindProductHistory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_RequestFindProduct"] != null && dr["FK_RequestFindProduct"] != DBNull.Value)
						{
							item.FK_RequestFindProduct = Convert.ToString(dr["FK_RequestFindProduct"]);
						}
						if (dr["FK_UserProcess"] != null && dr["FK_UserProcess"] != DBNull.Value)
						{
							item.FK_UserProcess = Convert.ToString(dr["FK_UserProcess"]);
						}
						if (dr["ProcessNote"] != null && dr["ProcessNote"] != DBNull.Value)
						{
							item.ProcessNote = Convert.ToString(dr["ProcessNote"]);
						}
						if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
						{
							item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
						}
						if (dr["ProcessType"] != null && dr["ProcessType"] != DBNull.Value)
						{
							item.ProcessType = Convert.ToString(dr["ProcessType"]);
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

		public GsRequestFindProductHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsRequestFindProductHistory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsRequestFindProductHistory>(ds);
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
		/// Thêm mới GsRequestFindProductHistory vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsRequestFindProductHistory _GsRequestFindProductHistory)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsRequestFindProductHistory](Id, FK_RequestFindProduct, FK_UserProcess, ProcessNote, ProcessDate, ProcessType) VALUES(@Id, @FK_RequestFindProduct, @FK_UserProcess, @ProcessNote, @ProcessDate, @ProcessType)", 
					"@Id",  _GsRequestFindProductHistory.Id, 
					"@FK_RequestFindProduct",  _GsRequestFindProductHistory.FK_RequestFindProduct, 
					"@FK_UserProcess",  _GsRequestFindProductHistory.FK_UserProcess, 
					"@ProcessNote",  _GsRequestFindProductHistory.ProcessNote, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProductHistory.ProcessDate), 
					"@ProcessType",  _GsRequestFindProductHistory.ProcessType);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsRequestFindProductHistory vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsRequestFindProductHistory> _GsRequestFindProductHistorys)
		{
			foreach (GsRequestFindProductHistory item in _GsRequestFindProductHistorys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsRequestFindProductHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsRequestFindProductHistory _GsRequestFindProductHistory, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsRequestFindProductHistory] SET Id=@Id, FK_RequestFindProduct=@FK_RequestFindProduct, FK_UserProcess=@FK_UserProcess, ProcessNote=@ProcessNote, ProcessDate=@ProcessDate, ProcessType=@ProcessType WHERE Id=@Id", 
					"@Id",  _GsRequestFindProductHistory.Id, 
					"@FK_RequestFindProduct",  _GsRequestFindProductHistory.FK_RequestFindProduct, 
					"@FK_UserProcess",  _GsRequestFindProductHistory.FK_UserProcess, 
					"@ProcessNote",  _GsRequestFindProductHistory.ProcessNote, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProductHistory.ProcessDate), 
					"@ProcessType",  _GsRequestFindProductHistory.ProcessType, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsRequestFindProductHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsRequestFindProductHistory _GsRequestFindProductHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsRequestFindProductHistory] SET FK_RequestFindProduct=@FK_RequestFindProduct, FK_UserProcess=@FK_UserProcess, ProcessNote=@ProcessNote, ProcessDate=@ProcessDate, ProcessType=@ProcessType WHERE Id=@Id", 
					"@FK_RequestFindProduct",  _GsRequestFindProductHistory.FK_RequestFindProduct, 
					"@FK_UserProcess",  _GsRequestFindProductHistory.FK_UserProcess, 
					"@ProcessNote",  _GsRequestFindProductHistory.ProcessNote, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProductHistory.ProcessDate), 
					"@ProcessType",  _GsRequestFindProductHistory.ProcessType, 
					"@Id", _GsRequestFindProductHistory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsRequestFindProductHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsRequestFindProductHistory> _GsRequestFindProductHistorys)
		{
			foreach (GsRequestFindProductHistory item in _GsRequestFindProductHistorys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsRequestFindProductHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsRequestFindProductHistory _GsRequestFindProductHistory, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsRequestFindProductHistory] SET Id=@Id, FK_RequestFindProduct=@FK_RequestFindProduct, FK_UserProcess=@FK_UserProcess, ProcessNote=@ProcessNote, ProcessDate=@ProcessDate, ProcessType=@ProcessType "+ condition, 
					"@Id",  _GsRequestFindProductHistory.Id, 
					"@FK_RequestFindProduct",  _GsRequestFindProductHistory.FK_RequestFindProduct, 
					"@FK_UserProcess",  _GsRequestFindProductHistory.FK_UserProcess, 
					"@ProcessNote",  _GsRequestFindProductHistory.ProcessNote, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProductHistory.ProcessDate), 
					"@ProcessType",  _GsRequestFindProductHistory.ProcessType);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsRequestFindProductHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsRequestFindProductHistory] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsRequestFindProductHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsRequestFindProductHistory _GsRequestFindProductHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsRequestFindProductHistory] WHERE Id=@Id",
					"@Id", _GsRequestFindProductHistory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsRequestFindProductHistory trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsRequestFindProductHistory] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsRequestFindProductHistory trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsRequestFindProductHistory> _GsRequestFindProductHistorys)
		{
			foreach (GsRequestFindProductHistory item in _GsRequestFindProductHistorys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
