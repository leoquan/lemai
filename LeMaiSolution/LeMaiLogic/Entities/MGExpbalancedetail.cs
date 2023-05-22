using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpbalancedetail:IGExpbalancedetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpbalancedetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpBalanceDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpBalanceDetail từ Database
		/// </summary>
		public List<GExpBalanceDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetail]");
				List<GExpBalanceDetail> items = new List<GExpBalanceDetail>();
				GExpBalanceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBalanceDetail();
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
					if (dr["AfterPostFrom"] != null && dr["AfterPostFrom"] != DBNull.Value)
					{
						item.AfterPostFrom = Convert.ToInt32(dr["AfterPostFrom"]);
					}
					if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
					{
						item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
					}
					if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
					{
						item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
					}
					if (dr["AfterPostTo"] != null && dr["AfterPostTo"] != DBNull.Value)
					{
						item.AfterPostTo = Convert.ToInt32(dr["AfterPostTo"]);
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
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
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
		/// Lấy danh sách GExpBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpBalanceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBalanceDetail] A "+ condition,  parameters);
				List<GExpBalanceDetail> items = new List<GExpBalanceDetail>();
				GExpBalanceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBalanceDetail();
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
					if (dr["AfterPostFrom"] != null && dr["AfterPostFrom"] != DBNull.Value)
					{
						item.AfterPostFrom = Convert.ToInt32(dr["AfterPostFrom"]);
					}
					if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
					{
						item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
					}
					if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
					{
						item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
					}
					if (dr["AfterPostTo"] != null && dr["AfterPostTo"] != DBNull.Value)
					{
						item.AfterPostTo = Convert.ToInt32(dr["AfterPostTo"]);
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
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
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

		public List<GExpBalanceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBalanceDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpBalanceDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpBalanceDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpBalanceDetail từ Database
		/// </summary>
		public GExpBalanceDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpBalanceDetail item=new GExpBalanceDetail();
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
						if (dr["AfterPostFrom"] != null && dr["AfterPostFrom"] != DBNull.Value)
						{
							item.AfterPostFrom = Convert.ToInt32(dr["AfterPostFrom"]);
						}
						if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
						{
							item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
						}
						if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
						{
							item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
						}
						if (dr["AfterPostTo"] != null && dr["AfterPostTo"] != DBNull.Value)
						{
							item.AfterPostTo = Convert.ToInt32(dr["AfterPostTo"]);
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
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
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
		/// Lấy một GExpBalanceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpBalanceDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBalanceDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpBalanceDetail item=new GExpBalanceDetail();
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
						if (dr["AfterPostFrom"] != null && dr["AfterPostFrom"] != DBNull.Value)
						{
							item.AfterPostFrom = Convert.ToInt32(dr["AfterPostFrom"]);
						}
						if (dr["FK_ExtPostTo"] != null && dr["FK_ExtPostTo"] != DBNull.Value)
						{
							item.FK_ExtPostTo = Convert.ToString(dr["FK_ExtPostTo"]);
						}
						if (dr["CurrentExtPostTo"] != null && dr["CurrentExtPostTo"] != DBNull.Value)
						{
							item.CurrentExtPostTo = Convert.ToInt32(dr["CurrentExtPostTo"]);
						}
						if (dr["AfterPostTo"] != null && dr["AfterPostTo"] != DBNull.Value)
						{
							item.AfterPostTo = Convert.ToInt32(dr["AfterPostTo"]);
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
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
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

		public GExpBalanceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBalanceDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpBalanceDetail>(ds);
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
		/// Thêm mới GExpBalanceDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpBalanceDetail _GExpBalanceDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpBalanceDetail](Id, FK_ExtPostFrom, CurrentExtPostFrom, AfterPostFrom, FK_ExtPostTo, CurrentExtPostTo, AfterPostTo, Value, CreateDate, CreateBy, BillCode, Type, Note, IsDelete, FK_AccountDelete, CreateDelete, Reason, RequestId) VALUES(@Id, @FK_ExtPostFrom, @CurrentExtPostFrom, @AfterPostFrom, @FK_ExtPostTo, @CurrentExtPostTo, @AfterPostTo, @Value, @CreateDate, @CreateBy, @BillCode, @Type, @Note, @IsDelete, @FK_AccountDelete, @CreateDelete, @Reason, @RequestId)", 
					"@Id",  _GExpBalanceDetail.Id, 
					"@FK_ExtPostFrom",  _GExpBalanceDetail.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _GExpBalanceDetail.CurrentExtPostFrom, 
					"@AfterPostFrom",  _GExpBalanceDetail.AfterPostFrom, 
					"@FK_ExtPostTo",  _GExpBalanceDetail.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _GExpBalanceDetail.CurrentExtPostTo, 
					"@AfterPostTo",  _GExpBalanceDetail.AfterPostTo, 
					"@Value",  _GExpBalanceDetail.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpBalanceDetail.CreateDate), 
					"@CreateBy",  _GExpBalanceDetail.CreateBy, 
					"@BillCode",  _GExpBalanceDetail.BillCode, 
					"@Type",  _GExpBalanceDetail.Type, 
					"@Note",  _GExpBalanceDetail.Note, 
					"@IsDelete",  _GExpBalanceDetail.IsDelete, 
					"@FK_AccountDelete",  _GExpBalanceDetail.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _GExpBalanceDetail.CreateDelete), 
					"@Reason",  _GExpBalanceDetail.Reason, 
					"@RequestId",  _GExpBalanceDetail.RequestId);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpBalanceDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpBalanceDetail> _GExpBalanceDetails)
		{
			foreach (GExpBalanceDetail item in _GExpBalanceDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpBalanceDetail _GExpBalanceDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBalanceDetail] SET Id=@Id, FK_ExtPostFrom=@FK_ExtPostFrom, CurrentExtPostFrom=@CurrentExtPostFrom, AfterPostFrom=@AfterPostFrom, FK_ExtPostTo=@FK_ExtPostTo, CurrentExtPostTo=@CurrentExtPostTo, AfterPostTo=@AfterPostTo, Value=@Value, CreateDate=@CreateDate, CreateBy=@CreateBy, BillCode=@BillCode, Type=@Type, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, RequestId=@RequestId WHERE Id=@Id", 
					"@Id",  _GExpBalanceDetail.Id, 
					"@FK_ExtPostFrom",  _GExpBalanceDetail.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _GExpBalanceDetail.CurrentExtPostFrom, 
					"@AfterPostFrom",  _GExpBalanceDetail.AfterPostFrom, 
					"@FK_ExtPostTo",  _GExpBalanceDetail.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _GExpBalanceDetail.CurrentExtPostTo, 
					"@AfterPostTo",  _GExpBalanceDetail.AfterPostTo, 
					"@Value",  _GExpBalanceDetail.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpBalanceDetail.CreateDate), 
					"@CreateBy",  _GExpBalanceDetail.CreateBy, 
					"@BillCode",  _GExpBalanceDetail.BillCode, 
					"@Type",  _GExpBalanceDetail.Type, 
					"@Note",  _GExpBalanceDetail.Note, 
					"@IsDelete",  _GExpBalanceDetail.IsDelete, 
					"@FK_AccountDelete",  _GExpBalanceDetail.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _GExpBalanceDetail.CreateDelete), 
					"@Reason",  _GExpBalanceDetail.Reason, 
					"@RequestId",  _GExpBalanceDetail.RequestId, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpBalanceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpBalanceDetail _GExpBalanceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBalanceDetail] SET FK_ExtPostFrom=@FK_ExtPostFrom, CurrentExtPostFrom=@CurrentExtPostFrom, AfterPostFrom=@AfterPostFrom, FK_ExtPostTo=@FK_ExtPostTo, CurrentExtPostTo=@CurrentExtPostTo, AfterPostTo=@AfterPostTo, Value=@Value, CreateDate=@CreateDate, CreateBy=@CreateBy, BillCode=@BillCode, Type=@Type, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, RequestId=@RequestId WHERE Id=@Id", 
					"@FK_ExtPostFrom",  _GExpBalanceDetail.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _GExpBalanceDetail.CurrentExtPostFrom, 
					"@AfterPostFrom",  _GExpBalanceDetail.AfterPostFrom, 
					"@FK_ExtPostTo",  _GExpBalanceDetail.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _GExpBalanceDetail.CurrentExtPostTo, 
					"@AfterPostTo",  _GExpBalanceDetail.AfterPostTo, 
					"@Value",  _GExpBalanceDetail.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpBalanceDetail.CreateDate), 
					"@CreateBy",  _GExpBalanceDetail.CreateBy, 
					"@BillCode",  _GExpBalanceDetail.BillCode, 
					"@Type",  _GExpBalanceDetail.Type, 
					"@Note",  _GExpBalanceDetail.Note, 
					"@IsDelete",  _GExpBalanceDetail.IsDelete, 
					"@FK_AccountDelete",  _GExpBalanceDetail.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _GExpBalanceDetail.CreateDelete), 
					"@Reason",  _GExpBalanceDetail.Reason, 
					"@RequestId",  _GExpBalanceDetail.RequestId, 
					"@Id", _GExpBalanceDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpBalanceDetail> _GExpBalanceDetails)
		{
			foreach (GExpBalanceDetail item in _GExpBalanceDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBalanceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpBalanceDetail _GExpBalanceDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBalanceDetail] SET Id=@Id, FK_ExtPostFrom=@FK_ExtPostFrom, CurrentExtPostFrom=@CurrentExtPostFrom, AfterPostFrom=@AfterPostFrom, FK_ExtPostTo=@FK_ExtPostTo, CurrentExtPostTo=@CurrentExtPostTo, AfterPostTo=@AfterPostTo, Value=@Value, CreateDate=@CreateDate, CreateBy=@CreateBy, BillCode=@BillCode, Type=@Type, Note=@Note, IsDelete=@IsDelete, FK_AccountDelete=@FK_AccountDelete, CreateDelete=@CreateDelete, Reason=@Reason, RequestId=@RequestId "+ condition, 
					"@Id",  _GExpBalanceDetail.Id, 
					"@FK_ExtPostFrom",  _GExpBalanceDetail.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _GExpBalanceDetail.CurrentExtPostFrom, 
					"@AfterPostFrom",  _GExpBalanceDetail.AfterPostFrom, 
					"@FK_ExtPostTo",  _GExpBalanceDetail.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _GExpBalanceDetail.CurrentExtPostTo, 
					"@AfterPostTo",  _GExpBalanceDetail.AfterPostTo, 
					"@Value",  _GExpBalanceDetail.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpBalanceDetail.CreateDate), 
					"@CreateBy",  _GExpBalanceDetail.CreateBy, 
					"@BillCode",  _GExpBalanceDetail.BillCode, 
					"@Type",  _GExpBalanceDetail.Type, 
					"@Note",  _GExpBalanceDetail.Note, 
					"@IsDelete",  _GExpBalanceDetail.IsDelete, 
					"@FK_AccountDelete",  _GExpBalanceDetail.FK_AccountDelete, 
					"@CreateDelete", this._dataContext.ConvertDateString( _GExpBalanceDetail.CreateDelete), 
					"@Reason",  _GExpBalanceDetail.Reason, 
					"@RequestId",  _GExpBalanceDetail.RequestId);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpBalanceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBalanceDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBalanceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpBalanceDetail _GExpBalanceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBalanceDetail] WHERE Id=@Id",
					"@Id", _GExpBalanceDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBalanceDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBalanceDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBalanceDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpBalanceDetail> _GExpBalanceDetails)
		{
			foreach (GExpBalanceDetail item in _GExpBalanceDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
