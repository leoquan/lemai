using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpwithdrawrequest:IEXpwithdrawrequest
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpwithdrawrequest(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequest từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequest]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequest từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequest] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpWithdrawRequest từ Database
		/// </summary>
		public List<ExpWithdrawRequest> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequest]");
				List<ExpWithdrawRequest> items = new List<ExpWithdrawRequest>();
				ExpWithdrawRequest item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpWithdrawRequest();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_PostRequest"] != null && dr["FK_PostRequest"] != DBNull.Value)
					{
						item.FK_PostRequest = Convert.ToString(dr["FK_PostRequest"]);
					}
					if (dr["WithdrawType"] != null && dr["WithdrawType"] != DBNull.Value)
					{
						item.WithdrawType = Convert.ToString(dr["WithdrawType"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToString(dr["Status"]);
					}
					if (dr["ApproveBy"] != null && dr["ApproveBy"] != DBNull.Value)
					{
						item.ApproveBy = Convert.ToString(dr["ApproveBy"]);
					}
					if (dr["ApproveDate"] != null && dr["ApproveDate"] != DBNull.Value)
					{
						item.ApproveDate = Convert.ToDateTime(dr["ApproveDate"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
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
		/// Lấy danh sách ExpWithdrawRequest từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpWithdrawRequest> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpWithdrawRequest] A "+ condition,  parameters);
				List<ExpWithdrawRequest> items = new List<ExpWithdrawRequest>();
				ExpWithdrawRequest item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpWithdrawRequest();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_PostRequest"] != null && dr["FK_PostRequest"] != DBNull.Value)
					{
						item.FK_PostRequest = Convert.ToString(dr["FK_PostRequest"]);
					}
					if (dr["WithdrawType"] != null && dr["WithdrawType"] != DBNull.Value)
					{
						item.WithdrawType = Convert.ToString(dr["WithdrawType"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToString(dr["Status"]);
					}
					if (dr["ApproveBy"] != null && dr["ApproveBy"] != DBNull.Value)
					{
						item.ApproveBy = Convert.ToString(dr["ApproveBy"]);
					}
					if (dr["ApproveDate"] != null && dr["ApproveDate"] != DBNull.Value)
					{
						item.ApproveDate = Convert.ToDateTime(dr["ApproveDate"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
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

		public List<ExpWithdrawRequest> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpWithdrawRequest] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpWithdrawRequest] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpWithdrawRequest>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpWithdrawRequest từ Database
		/// </summary>
		public ExpWithdrawRequest GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequest] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpWithdrawRequest item=new ExpWithdrawRequest();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_PostRequest"] != null && dr["FK_PostRequest"] != DBNull.Value)
						{
							item.FK_PostRequest = Convert.ToString(dr["FK_PostRequest"]);
						}
						if (dr["WithdrawType"] != null && dr["WithdrawType"] != DBNull.Value)
						{
							item.WithdrawType = Convert.ToString(dr["WithdrawType"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
						{
							item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToString(dr["Status"]);
						}
						if (dr["ApproveBy"] != null && dr["ApproveBy"] != DBNull.Value)
						{
							item.ApproveBy = Convert.ToString(dr["ApproveBy"]);
						}
						if (dr["ApproveDate"] != null && dr["ApproveDate"] != DBNull.Value)
						{
							item.ApproveDate = Convert.ToDateTime(dr["ApproveDate"]);
						}
						if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
						{
							item.Reason = Convert.ToString(dr["Reason"]);
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
		/// Lấy một ExpWithdrawRequest đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpWithdrawRequest GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpWithdrawRequest] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpWithdrawRequest item=new ExpWithdrawRequest();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_PostRequest"] != null && dr["FK_PostRequest"] != DBNull.Value)
						{
							item.FK_PostRequest = Convert.ToString(dr["FK_PostRequest"]);
						}
						if (dr["WithdrawType"] != null && dr["WithdrawType"] != DBNull.Value)
						{
							item.WithdrawType = Convert.ToString(dr["WithdrawType"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
						{
							item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToString(dr["Status"]);
						}
						if (dr["ApproveBy"] != null && dr["ApproveBy"] != DBNull.Value)
						{
							item.ApproveBy = Convert.ToString(dr["ApproveBy"]);
						}
						if (dr["ApproveDate"] != null && dr["ApproveDate"] != DBNull.Value)
						{
							item.ApproveDate = Convert.ToDateTime(dr["ApproveDate"]);
						}
						if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
						{
							item.Reason = Convert.ToString(dr["Reason"]);
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

		public ExpWithdrawRequest GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpWithdrawRequest] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpWithdrawRequest>(ds);
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
		/// Thêm mới ExpWithdrawRequest vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpWithdrawRequest _ExpWithdrawRequest)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpWithdrawRequest](Id, CreateBy, CreateDate, FK_PostRequest, WithdrawType, Value, CurrentValue, Note, Status, ApproveBy, ApproveDate, Reason) VALUES(@Id, @CreateBy, @CreateDate, @FK_PostRequest, @WithdrawType, @Value, @CurrentValue, @Note, @Status, @ApproveBy, @ApproveDate, @Reason)", 
					"@Id",  _ExpWithdrawRequest.Id, 
					"@CreateBy",  _ExpWithdrawRequest.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpWithdrawRequest.CreateDate), 
					"@FK_PostRequest",  _ExpWithdrawRequest.FK_PostRequest, 
					"@WithdrawType",  _ExpWithdrawRequest.WithdrawType, 
					"@Value",  _ExpWithdrawRequest.Value, 
					"@CurrentValue",  _ExpWithdrawRequest.CurrentValue, 
					"@Note",  _ExpWithdrawRequest.Note, 
					"@Status",  _ExpWithdrawRequest.Status, 
					"@ApproveBy",  _ExpWithdrawRequest.ApproveBy, 
					"@ApproveDate", this._dataContext.ConvertDateString( _ExpWithdrawRequest.ApproveDate), 
					"@Reason",  _ExpWithdrawRequest.Reason);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpWithdrawRequest vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpWithdrawRequest> _ExpWithdrawRequests)
		{
			foreach (ExpWithdrawRequest item in _ExpWithdrawRequests)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpWithdrawRequest vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpWithdrawRequest _ExpWithdrawRequest, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithdrawRequest] SET Id=@Id, CreateBy=@CreateBy, CreateDate=@CreateDate, FK_PostRequest=@FK_PostRequest, WithdrawType=@WithdrawType, Value=@Value, CurrentValue=@CurrentValue, Note=@Note, Status=@Status, ApproveBy=@ApproveBy, ApproveDate=@ApproveDate, Reason=@Reason WHERE Id=@Id", 
					"@Id",  _ExpWithdrawRequest.Id, 
					"@CreateBy",  _ExpWithdrawRequest.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpWithdrawRequest.CreateDate), 
					"@FK_PostRequest",  _ExpWithdrawRequest.FK_PostRequest, 
					"@WithdrawType",  _ExpWithdrawRequest.WithdrawType, 
					"@Value",  _ExpWithdrawRequest.Value, 
					"@CurrentValue",  _ExpWithdrawRequest.CurrentValue, 
					"@Note",  _ExpWithdrawRequest.Note, 
					"@Status",  _ExpWithdrawRequest.Status, 
					"@ApproveBy",  _ExpWithdrawRequest.ApproveBy, 
					"@ApproveDate", this._dataContext.ConvertDateString( _ExpWithdrawRequest.ApproveDate), 
					"@Reason",  _ExpWithdrawRequest.Reason, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpWithdrawRequest vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpWithdrawRequest _ExpWithdrawRequest)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithdrawRequest] SET CreateBy=@CreateBy, CreateDate=@CreateDate, FK_PostRequest=@FK_PostRequest, WithdrawType=@WithdrawType, Value=@Value, CurrentValue=@CurrentValue, Note=@Note, Status=@Status, ApproveBy=@ApproveBy, ApproveDate=@ApproveDate, Reason=@Reason WHERE Id=@Id", 
					"@CreateBy",  _ExpWithdrawRequest.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpWithdrawRequest.CreateDate), 
					"@FK_PostRequest",  _ExpWithdrawRequest.FK_PostRequest, 
					"@WithdrawType",  _ExpWithdrawRequest.WithdrawType, 
					"@Value",  _ExpWithdrawRequest.Value, 
					"@CurrentValue",  _ExpWithdrawRequest.CurrentValue, 
					"@Note",  _ExpWithdrawRequest.Note, 
					"@Status",  _ExpWithdrawRequest.Status, 
					"@ApproveBy",  _ExpWithdrawRequest.ApproveBy, 
					"@ApproveDate", this._dataContext.ConvertDateString( _ExpWithdrawRequest.ApproveDate), 
					"@Reason",  _ExpWithdrawRequest.Reason, 
					"@Id", _ExpWithdrawRequest.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpWithdrawRequest vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpWithdrawRequest> _ExpWithdrawRequests)
		{
			foreach (ExpWithdrawRequest item in _ExpWithdrawRequests)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpWithdrawRequest vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpWithdrawRequest _ExpWithdrawRequest, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithdrawRequest] SET Id=@Id, CreateBy=@CreateBy, CreateDate=@CreateDate, FK_PostRequest=@FK_PostRequest, WithdrawType=@WithdrawType, Value=@Value, CurrentValue=@CurrentValue, Note=@Note, Status=@Status, ApproveBy=@ApproveBy, ApproveDate=@ApproveDate, Reason=@Reason "+ condition, 
					"@Id",  _ExpWithdrawRequest.Id, 
					"@CreateBy",  _ExpWithdrawRequest.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpWithdrawRequest.CreateDate), 
					"@FK_PostRequest",  _ExpWithdrawRequest.FK_PostRequest, 
					"@WithdrawType",  _ExpWithdrawRequest.WithdrawType, 
					"@Value",  _ExpWithdrawRequest.Value, 
					"@CurrentValue",  _ExpWithdrawRequest.CurrentValue, 
					"@Note",  _ExpWithdrawRequest.Note, 
					"@Status",  _ExpWithdrawRequest.Status, 
					"@ApproveBy",  _ExpWithdrawRequest.ApproveBy, 
					"@ApproveDate", this._dataContext.ConvertDateString( _ExpWithdrawRequest.ApproveDate), 
					"@Reason",  _ExpWithdrawRequest.Reason);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpWithdrawRequest trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithdrawRequest] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithdrawRequest trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpWithdrawRequest _ExpWithdrawRequest)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithdrawRequest] WHERE Id=@Id",
					"@Id", _ExpWithdrawRequest.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithdrawRequest trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithdrawRequest] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithdrawRequest trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpWithdrawRequest> _ExpWithdrawRequests)
		{
			foreach (ExpWithdrawRequest item in _ExpWithdrawRequests)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
