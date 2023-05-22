using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpbalancedetailpost:IGExpbalancedetailpost
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpbalancedetailpost(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpBalanceDetailPost từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetailPost]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpBalanceDetailPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetailPost] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpBalanceDetailPost từ Database
		/// </summary>
		public List<GExpBalanceDetailPost> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetailPost]");
				List<GExpBalanceDetailPost> items = new List<GExpBalanceDetailPost>();
				GExpBalanceDetailPost item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBalanceDetailPost();
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
					if (dr["EpochTime"] != null && dr["EpochTime"] != DBNull.Value)
					{
						item.EpochTime = (System.Int64)dr["EpochTime"];
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
		/// Lấy danh sách GExpBalanceDetailPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpBalanceDetailPost> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBalanceDetailPost] A "+ condition,  parameters);
				List<GExpBalanceDetailPost> items = new List<GExpBalanceDetailPost>();
				GExpBalanceDetailPost item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBalanceDetailPost();
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
					if (dr["EpochTime"] != null && dr["EpochTime"] != DBNull.Value)
					{
						item.EpochTime = (System.Int64)dr["EpochTime"];
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

		public List<GExpBalanceDetailPost> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBalanceDetailPost] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpBalanceDetailPost] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpBalanceDetailPost>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpBalanceDetailPost từ Database
		/// </summary>
		public GExpBalanceDetailPost GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBalanceDetailPost] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpBalanceDetailPost item=new GExpBalanceDetailPost();
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
						if (dr["EpochTime"] != null && dr["EpochTime"] != DBNull.Value)
						{
							item.EpochTime = (System.Int64)dr["EpochTime"];
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
		/// Lấy một GExpBalanceDetailPost đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpBalanceDetailPost GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBalanceDetailPost] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpBalanceDetailPost item=new GExpBalanceDetailPost();
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
						if (dr["EpochTime"] != null && dr["EpochTime"] != DBNull.Value)
						{
							item.EpochTime = (System.Int64)dr["EpochTime"];
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

		public GExpBalanceDetailPost GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBalanceDetailPost] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpBalanceDetailPost>(ds);
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
		/// Thêm mới GExpBalanceDetailPost vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpBalanceDetailPost _GExpBalanceDetailPost)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpBalanceDetailPost](Id, FK_ExtPostFrom, CurrentExtPostFrom, AfterPostFrom, FK_ExtPostTo, CurrentExtPostTo, AfterPostTo, Value, CreateDate, CreateBy, BillCode, Type, Note, EpochTime) VALUES(@Id, @FK_ExtPostFrom, @CurrentExtPostFrom, @AfterPostFrom, @FK_ExtPostTo, @CurrentExtPostTo, @AfterPostTo, @Value, @CreateDate, @CreateBy, @BillCode, @Type, @Note, @EpochTime)", 
					"@Id",  _GExpBalanceDetailPost.Id, 
					"@FK_ExtPostFrom",  _GExpBalanceDetailPost.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _GExpBalanceDetailPost.CurrentExtPostFrom, 
					"@AfterPostFrom",  _GExpBalanceDetailPost.AfterPostFrom, 
					"@FK_ExtPostTo",  _GExpBalanceDetailPost.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _GExpBalanceDetailPost.CurrentExtPostTo, 
					"@AfterPostTo",  _GExpBalanceDetailPost.AfterPostTo, 
					"@Value",  _GExpBalanceDetailPost.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpBalanceDetailPost.CreateDate), 
					"@CreateBy",  _GExpBalanceDetailPost.CreateBy, 
					"@BillCode",  _GExpBalanceDetailPost.BillCode, 
					"@Type",  _GExpBalanceDetailPost.Type, 
					"@Note",  _GExpBalanceDetailPost.Note, 
					"@EpochTime",  _GExpBalanceDetailPost.EpochTime);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpBalanceDetailPost vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpBalanceDetailPost> _GExpBalanceDetailPosts)
		{
			foreach (GExpBalanceDetailPost item in _GExpBalanceDetailPosts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBalanceDetailPost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpBalanceDetailPost _GExpBalanceDetailPost, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBalanceDetailPost] SET Id=@Id, FK_ExtPostFrom=@FK_ExtPostFrom, CurrentExtPostFrom=@CurrentExtPostFrom, AfterPostFrom=@AfterPostFrom, FK_ExtPostTo=@FK_ExtPostTo, CurrentExtPostTo=@CurrentExtPostTo, AfterPostTo=@AfterPostTo, Value=@Value, CreateDate=@CreateDate, CreateBy=@CreateBy, BillCode=@BillCode, Type=@Type, Note=@Note, EpochTime=@EpochTime WHERE Id=@Id", 
					"@Id",  _GExpBalanceDetailPost.Id, 
					"@FK_ExtPostFrom",  _GExpBalanceDetailPost.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _GExpBalanceDetailPost.CurrentExtPostFrom, 
					"@AfterPostFrom",  _GExpBalanceDetailPost.AfterPostFrom, 
					"@FK_ExtPostTo",  _GExpBalanceDetailPost.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _GExpBalanceDetailPost.CurrentExtPostTo, 
					"@AfterPostTo",  _GExpBalanceDetailPost.AfterPostTo, 
					"@Value",  _GExpBalanceDetailPost.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpBalanceDetailPost.CreateDate), 
					"@CreateBy",  _GExpBalanceDetailPost.CreateBy, 
					"@BillCode",  _GExpBalanceDetailPost.BillCode, 
					"@Type",  _GExpBalanceDetailPost.Type, 
					"@Note",  _GExpBalanceDetailPost.Note, 
					"@EpochTime",  _GExpBalanceDetailPost.EpochTime, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpBalanceDetailPost vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpBalanceDetailPost _GExpBalanceDetailPost)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBalanceDetailPost] SET FK_ExtPostFrom=@FK_ExtPostFrom, CurrentExtPostFrom=@CurrentExtPostFrom, AfterPostFrom=@AfterPostFrom, FK_ExtPostTo=@FK_ExtPostTo, CurrentExtPostTo=@CurrentExtPostTo, AfterPostTo=@AfterPostTo, Value=@Value, CreateDate=@CreateDate, CreateBy=@CreateBy, BillCode=@BillCode, Type=@Type, Note=@Note, EpochTime=@EpochTime WHERE Id=@Id", 
					"@FK_ExtPostFrom",  _GExpBalanceDetailPost.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _GExpBalanceDetailPost.CurrentExtPostFrom, 
					"@AfterPostFrom",  _GExpBalanceDetailPost.AfterPostFrom, 
					"@FK_ExtPostTo",  _GExpBalanceDetailPost.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _GExpBalanceDetailPost.CurrentExtPostTo, 
					"@AfterPostTo",  _GExpBalanceDetailPost.AfterPostTo, 
					"@Value",  _GExpBalanceDetailPost.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpBalanceDetailPost.CreateDate), 
					"@CreateBy",  _GExpBalanceDetailPost.CreateBy, 
					"@BillCode",  _GExpBalanceDetailPost.BillCode, 
					"@Type",  _GExpBalanceDetailPost.Type, 
					"@Note",  _GExpBalanceDetailPost.Note, 
					"@EpochTime",  _GExpBalanceDetailPost.EpochTime, 
					"@Id", _GExpBalanceDetailPost.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpBalanceDetailPost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpBalanceDetailPost> _GExpBalanceDetailPosts)
		{
			foreach (GExpBalanceDetailPost item in _GExpBalanceDetailPosts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBalanceDetailPost vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpBalanceDetailPost _GExpBalanceDetailPost, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBalanceDetailPost] SET Id=@Id, FK_ExtPostFrom=@FK_ExtPostFrom, CurrentExtPostFrom=@CurrentExtPostFrom, AfterPostFrom=@AfterPostFrom, FK_ExtPostTo=@FK_ExtPostTo, CurrentExtPostTo=@CurrentExtPostTo, AfterPostTo=@AfterPostTo, Value=@Value, CreateDate=@CreateDate, CreateBy=@CreateBy, BillCode=@BillCode, Type=@Type, Note=@Note, EpochTime=@EpochTime "+ condition, 
					"@Id",  _GExpBalanceDetailPost.Id, 
					"@FK_ExtPostFrom",  _GExpBalanceDetailPost.FK_ExtPostFrom, 
					"@CurrentExtPostFrom",  _GExpBalanceDetailPost.CurrentExtPostFrom, 
					"@AfterPostFrom",  _GExpBalanceDetailPost.AfterPostFrom, 
					"@FK_ExtPostTo",  _GExpBalanceDetailPost.FK_ExtPostTo, 
					"@CurrentExtPostTo",  _GExpBalanceDetailPost.CurrentExtPostTo, 
					"@AfterPostTo",  _GExpBalanceDetailPost.AfterPostTo, 
					"@Value",  _GExpBalanceDetailPost.Value, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpBalanceDetailPost.CreateDate), 
					"@CreateBy",  _GExpBalanceDetailPost.CreateBy, 
					"@BillCode",  _GExpBalanceDetailPost.BillCode, 
					"@Type",  _GExpBalanceDetailPost.Type, 
					"@Note",  _GExpBalanceDetailPost.Note, 
					"@EpochTime",  _GExpBalanceDetailPost.EpochTime);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpBalanceDetailPost trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBalanceDetailPost] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBalanceDetailPost trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpBalanceDetailPost _GExpBalanceDetailPost)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBalanceDetailPost] WHERE Id=@Id",
					"@Id", _GExpBalanceDetailPost.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBalanceDetailPost trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBalanceDetailPost] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBalanceDetailPost trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpBalanceDetailPost> _GExpBalanceDetailPosts)
		{
			foreach (GExpBalanceDetailPost item in _GExpBalanceDetailPosts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
