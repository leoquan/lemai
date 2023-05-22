using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXprecharge:IEXprecharge
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXprecharge(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpRecharge từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpRecharge]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpRecharge từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpRecharge] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpRecharge từ Database
		/// </summary>
		public List<ExpRecharge> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpRecharge]");
				List<ExpRecharge> items = new List<ExpRecharge>();
				ExpRecharge item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpRecharge();
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
		/// Lấy danh sách ExpRecharge từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpRecharge> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpRecharge] A "+ condition,  parameters);
				List<ExpRecharge> items = new List<ExpRecharge>();
				ExpRecharge item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpRecharge();
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<ExpRecharge> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpRecharge] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpRecharge] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpRecharge>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpRecharge từ Database
		/// </summary>
		public ExpRecharge GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpRecharge] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpRecharge item=new ExpRecharge();
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
		/// Lấy một ExpRecharge đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpRecharge GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpRecharge] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpRecharge item=new ExpRecharge();
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

		public ExpRecharge GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpRecharge] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpRecharge>(ds);
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
		/// Thêm mới ExpRecharge vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpRecharge _ExpRecharge)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpRecharge](Id, CreateBy, CreateDate, FK_PostRequest, WithdrawType, Value, CurrentValue, Note) VALUES(@Id, @CreateBy, @CreateDate, @FK_PostRequest, @WithdrawType, @Value, @CurrentValue, @Note)", 
					"@Id",  _ExpRecharge.Id, 
					"@CreateBy",  _ExpRecharge.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpRecharge.CreateDate), 
					"@FK_PostRequest",  _ExpRecharge.FK_PostRequest, 
					"@WithdrawType",  _ExpRecharge.WithdrawType, 
					"@Value",  _ExpRecharge.Value, 
					"@CurrentValue",  _ExpRecharge.CurrentValue, 
					"@Note",  _ExpRecharge.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpRecharge vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpRecharge> _ExpRecharges)
		{
			foreach (ExpRecharge item in _ExpRecharges)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpRecharge vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpRecharge _ExpRecharge, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpRecharge] SET Id=@Id, CreateBy=@CreateBy, CreateDate=@CreateDate, FK_PostRequest=@FK_PostRequest, WithdrawType=@WithdrawType, Value=@Value, CurrentValue=@CurrentValue, Note=@Note WHERE Id=@Id", 
					"@Id",  _ExpRecharge.Id, 
					"@CreateBy",  _ExpRecharge.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpRecharge.CreateDate), 
					"@FK_PostRequest",  _ExpRecharge.FK_PostRequest, 
					"@WithdrawType",  _ExpRecharge.WithdrawType, 
					"@Value",  _ExpRecharge.Value, 
					"@CurrentValue",  _ExpRecharge.CurrentValue, 
					"@Note",  _ExpRecharge.Note, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpRecharge vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpRecharge _ExpRecharge)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpRecharge] SET CreateBy=@CreateBy, CreateDate=@CreateDate, FK_PostRequest=@FK_PostRequest, WithdrawType=@WithdrawType, Value=@Value, CurrentValue=@CurrentValue, Note=@Note WHERE Id=@Id", 
					"@CreateBy",  _ExpRecharge.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpRecharge.CreateDate), 
					"@FK_PostRequest",  _ExpRecharge.FK_PostRequest, 
					"@WithdrawType",  _ExpRecharge.WithdrawType, 
					"@Value",  _ExpRecharge.Value, 
					"@CurrentValue",  _ExpRecharge.CurrentValue, 
					"@Note",  _ExpRecharge.Note, 
					"@Id", _ExpRecharge.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpRecharge vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpRecharge> _ExpRecharges)
		{
			foreach (ExpRecharge item in _ExpRecharges)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpRecharge vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpRecharge _ExpRecharge, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpRecharge] SET Id=@Id, CreateBy=@CreateBy, CreateDate=@CreateDate, FK_PostRequest=@FK_PostRequest, WithdrawType=@WithdrawType, Value=@Value, CurrentValue=@CurrentValue, Note=@Note "+ condition, 
					"@Id",  _ExpRecharge.Id, 
					"@CreateBy",  _ExpRecharge.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpRecharge.CreateDate), 
					"@FK_PostRequest",  _ExpRecharge.FK_PostRequest, 
					"@WithdrawType",  _ExpRecharge.WithdrawType, 
					"@Value",  _ExpRecharge.Value, 
					"@CurrentValue",  _ExpRecharge.CurrentValue, 
					"@Note",  _ExpRecharge.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpRecharge trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpRecharge] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpRecharge trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpRecharge _ExpRecharge)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpRecharge] WHERE Id=@Id",
					"@Id", _ExpRecharge.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpRecharge trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpRecharge] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpRecharge trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpRecharge> _ExpRecharges)
		{
			foreach (ExpRecharge item in _ExpRecharges)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
