using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpconsignmentcashpay:IEXpconsignmentcashpay
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpconsignmentcashpay(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpConsignmentCashPay từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentCashPay]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpConsignmentCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentCashPay] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpConsignmentCashPay từ Database
		/// </summary>
		public List<ExpConsignmentCashPay> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentCashPay]");
				List<ExpConsignmentCashPay> items = new List<ExpConsignmentCashPay>();
				ExpConsignmentCashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentCashPay();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExtPostFrom"] != null && dr["FK_ExtPostFrom"] != DBNull.Value)
					{
						item.FK_ExtPostFrom = Convert.ToString(dr["FK_ExtPostFrom"]);
					}
					if (dr["CurrentExtPostFrom"] != null && dr["CurrentExtPostFrom"] != DBNull.Value)
					{
						item.CurrentExtPostFrom = Convert.ToInt32(dr["CurrentExtPostFrom"]);
					}
					if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
					{
						item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
					}
					if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
					{
						item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
					{
						item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
					}
					if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
					{
						item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["RequestId"] != null && dr["RequestId"] != DBNull.Value)
					{
						item.RequestId = Convert.ToString(dr["RequestId"]);
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
		/// Lấy danh sách ExpConsignmentCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpConsignmentCashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentCashPay] A "+ condition,  parameters);
				List<ExpConsignmentCashPay> items = new List<ExpConsignmentCashPay>();
				ExpConsignmentCashPay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentCashPay();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExtPostFrom"] != null && dr["FK_ExtPostFrom"] != DBNull.Value)
					{
						item.FK_ExtPostFrom = Convert.ToString(dr["FK_ExtPostFrom"]);
					}
					if (dr["CurrentExtPostFrom"] != null && dr["CurrentExtPostFrom"] != DBNull.Value)
					{
						item.CurrentExtPostFrom = Convert.ToInt32(dr["CurrentExtPostFrom"]);
					}
					if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
					{
						item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
					}
					if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
					{
						item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
					{
						item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
					}
					if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
					{
						item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
					}
					if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
					{
						item.Reason = Convert.ToString(dr["Reason"]);
					}
					if (dr["RequestId"] != null && dr["RequestId"] != DBNull.Value)
					{
						item.RequestId = Convert.ToString(dr["RequestId"]);
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

		public List<ExpConsignmentCashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentCashPay] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentCashPay] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpConsignmentCashPay>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpConsignmentCashPay từ Database
		/// </summary>
		public ExpConsignmentCashPay GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentCashPay] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentCashPay item=new ExpConsignmentCashPay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExtPostFrom"] != null && dr["FK_ExtPostFrom"] != DBNull.Value)
						{
							item.FK_ExtPostFrom = Convert.ToString(dr["FK_ExtPostFrom"]);
						}
						if (dr["CurrentExtPostFrom"] != null && dr["CurrentExtPostFrom"] != DBNull.Value)
						{
							item.CurrentExtPostFrom = Convert.ToInt32(dr["CurrentExtPostFrom"]);
						}
						if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
						{
							item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
						}
						if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
						{
							item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
						{
							item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
						{
							item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
						}
						if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
						{
							item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
						}
						if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
						{
							item.Reason = Convert.ToString(dr["Reason"]);
						}
						if (dr["RequestId"] != null && dr["RequestId"] != DBNull.Value)
						{
							item.RequestId = Convert.ToString(dr["RequestId"]);
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
		/// Lấy một ExpConsignmentCashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpConsignmentCashPay GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentCashPay] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentCashPay item=new ExpConsignmentCashPay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExtPostFrom"] != null && dr["FK_ExtPostFrom"] != DBNull.Value)
						{
							item.FK_ExtPostFrom = Convert.ToString(dr["FK_ExtPostFrom"]);
						}
						if (dr["CurrentExtPostFrom"] != null && dr["CurrentExtPostFrom"] != DBNull.Value)
						{
							item.CurrentExtPostFrom = Convert.ToInt32(dr["CurrentExtPostFrom"]);
						}
						if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
						{
							item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
						}
						if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
						{
							item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
						{
							item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["FK_AccountDelete"] != null && dr["FK_AccountDelete"] != DBNull.Value)
						{
							item.FK_AccountDelete = Convert.ToString(dr["FK_AccountDelete"]);
						}
						if (dr["CreateDelete"] != null && dr["CreateDelete"] != DBNull.Value)
						{
							item.CreateDelete = Convert.ToDateTime(dr["CreateDelete"]);
						}
						if (dr["Reason"] != null && dr["Reason"] != DBNull.Value)
						{
							item.Reason = Convert.ToString(dr["Reason"]);
						}
						if (dr["RequestId"] != null && dr["RequestId"] != DBNull.Value)
						{
							item.RequestId = Convert.ToString(dr["RequestId"]);
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

		public ExpConsignmentCashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentCashPay] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpConsignmentCashPay>(ds);
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
		/// Thêm mới ExpConsignmentCashPay vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpConsignmentCashPay _ExpConsignmentCashPay)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpConsignmentCashPay](Id, FK_ExtPostFrom, CurrentExtPostFrom, FK_ExtPostTo, CurrentExtPostTo, Value, CreateDate, CreateBy, FK_ExpConsignment, Type, Note, IsDelete, FK_AccountDelete, CreateDelete, Reason, RequestId) VALUES(@Id, @FK_ExtPostFrom, @CurrentExtPostFrom, @FK_ExtPostTo, @CurrentExtPostTo, @Value, @CreateDate, @CreateBy, @FK_ExpConsignment, @Type, @Note, @IsDelete, @FK_AccountDelete, @CreateDelete, @Reason, @RequestId)", 
					"@Id",  _ExpConsignmentCashPay.Id, 
					"@FK_ExtPostFrom",  _ExpConsignmentCashPay.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _ExpConsignmentCashPay.CurrentExtPostFrom, 
					"@FK_ExtPostTo",  _ExpConsignmentCashPay.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _ExpConsignmentCashPay.CurrentExtPostTo, 
					"@Value",  _ExpConsignmentCashPay.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignmentCashPay.CreateDate), 
					"@CreateBy",  _ExpConsignmentCashPay.CreateBy, 
					"@FK_ExpConsignment",  _ExpConsignmentCashPay.FK_ExpConsignment, 
					"@Type",  _ExpConsignmentCashPay.Type, 
					"@Note",  _ExpConsignmentCashPay.Note, 
					"@IsDelete",  _ExpConsignmentCashPay.IsDelete, 
					"@FK_AccountDelete",  _ExpConsignmentCashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _ExpConsignmentCashPay.CreateDelete), 
					"@Reason",  _ExpConsignmentCashPay.Reason, 
					"@RequestId",  _ExpConsignmentCashPay.RequestId);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentCashPay vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpConsignmentCashPay> _ExpConsignmentCashPays)
		{
			foreach (ExpConsignmentCashPay item in _ExpConsignmentCashPays)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentCashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpConsignmentCashPay _ExpConsignmentCashPay, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentCashPay] SET Id=@Id, FK_ExtPostFrom=@FK_ExtPostFrom, CurrentExtPostFrom=@CurrentExtPostFrom, FK_ExtPostTo=@FK_ExtPostTo, CurrentExtPostTo=@CurrentExtPostTo, Value=@Value, CreateDate=@CreateDate, CreateBy=@CreateBy, FK_ExpConsignment=@FK_ExpConsignment, Type=@Type, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, RequestId=@RequestId WHERE Id=@Id", 
					"@Id",  _ExpConsignmentCashPay.Id, 
					"@FK_ExtPostFrom",  _ExpConsignmentCashPay.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _ExpConsignmentCashPay.CurrentExtPostFrom, 
					"@FK_ExtPostTo",  _ExpConsignmentCashPay.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _ExpConsignmentCashPay.CurrentExtPostTo, 
					"@Value",  _ExpConsignmentCashPay.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignmentCashPay.CreateDate), 
					"@CreateBy",  _ExpConsignmentCashPay.CreateBy, 
					"@FK_ExpConsignment",  _ExpConsignmentCashPay.FK_ExpConsignment, 
					"@Type",  _ExpConsignmentCashPay.Type, 
					"@Note",  _ExpConsignmentCashPay.Note, 
					"@IsDelete",  _ExpConsignmentCashPay.IsDelete, 
					"@FK_AccountDelete",  _ExpConsignmentCashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _ExpConsignmentCashPay.CreateDelete), 
					"@Reason",  _ExpConsignmentCashPay.Reason, 
					"@RequestId",  _ExpConsignmentCashPay.RequestId, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentCashPay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpConsignmentCashPay _ExpConsignmentCashPay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentCashPay] SET FK_ExtPostFrom=@FK_ExtPostFrom, CurrentExtPostFrom=@CurrentExtPostFrom, FK_ExtPostTo=@FK_ExtPostTo, CurrentExtPostTo=@CurrentExtPostTo, Value=@Value, CreateDate=@CreateDate, CreateBy=@CreateBy, FK_ExpConsignment=@FK_ExpConsignment, Type=@Type, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, RequestId=@RequestId WHERE Id=@Id", 
					"@FK_ExtPostFrom",  _ExpConsignmentCashPay.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _ExpConsignmentCashPay.CurrentExtPostFrom, 
					"@FK_ExtPostTo",  _ExpConsignmentCashPay.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _ExpConsignmentCashPay.CurrentExtPostTo, 
					"@Value",  _ExpConsignmentCashPay.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignmentCashPay.CreateDate), 
					"@CreateBy",  _ExpConsignmentCashPay.CreateBy, 
					"@FK_ExpConsignment",  _ExpConsignmentCashPay.FK_ExpConsignment, 
					"@Type",  _ExpConsignmentCashPay.Type, 
					"@Note",  _ExpConsignmentCashPay.Note, 
					"@IsDelete",  _ExpConsignmentCashPay.IsDelete, 
					"@FK_AccountDelete",  _ExpConsignmentCashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _ExpConsignmentCashPay.CreateDelete), 
					"@Reason",  _ExpConsignmentCashPay.Reason, 
					"@RequestId",  _ExpConsignmentCashPay.RequestId, 
					"@Id", _ExpConsignmentCashPay.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpConsignmentCashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpConsignmentCashPay> _ExpConsignmentCashPays)
		{
			foreach (ExpConsignmentCashPay item in _ExpConsignmentCashPays)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentCashPay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpConsignmentCashPay _ExpConsignmentCashPay, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentCashPay] SET Id=@Id, FK_ExtPostFrom=@FK_ExtPostFrom, CurrentExtPostFrom=@CurrentExtPostFrom, FK_ExtPostTo=@FK_ExtPostTo, CurrentExtPostTo=@CurrentExtPostTo, Value=@Value, CreateDate=@CreateDate, CreateBy=@CreateBy, FK_ExpConsignment=@FK_ExpConsignment, Type=@Type, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, RequestId=@RequestId "+ condition, 
					"@Id",  _ExpConsignmentCashPay.Id, 
					"@FK_ExtPostFrom",  _ExpConsignmentCashPay.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _ExpConsignmentCashPay.CurrentExtPostFrom, 
					"@FK_ExtPostTo",  _ExpConsignmentCashPay.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _ExpConsignmentCashPay.CurrentExtPostTo, 
					"@Value",  _ExpConsignmentCashPay.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignmentCashPay.CreateDate), 
					"@CreateBy",  _ExpConsignmentCashPay.CreateBy, 
					"@FK_ExpConsignment",  _ExpConsignmentCashPay.FK_ExpConsignment, 
					"@Type",  _ExpConsignmentCashPay.Type, 
					"@Note",  _ExpConsignmentCashPay.Note, 
					"@IsDelete",  _ExpConsignmentCashPay.IsDelete, 
					"@FK_AccountDelete",  _ExpConsignmentCashPay.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _ExpConsignmentCashPay.CreateDelete), 
					"@Reason",  _ExpConsignmentCashPay.Reason, 
					"@RequestId",  _ExpConsignmentCashPay.RequestId);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpConsignmentCashPay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentCashPay] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentCashPay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpConsignmentCashPay _ExpConsignmentCashPay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentCashPay] WHERE Id=@Id",
					"@Id", _ExpConsignmentCashPay.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentCashPay trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentCashPay] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentCashPay trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpConsignmentCashPay> _ExpConsignmentCashPays)
		{
			foreach (ExpConsignmentCashPay item in _ExpConsignmentCashPays)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
