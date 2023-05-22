using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpconsignmentqueuenumber:IEXpconsignmentqueuenumber
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpconsignmentqueuenumber(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpConsignmentQueueNumber từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentQueueNumber]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpConsignmentQueueNumber từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentQueueNumber] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpConsignmentQueueNumber từ Database
		/// </summary>
		public List<ExpConsignmentQueueNumber> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentQueueNumber]");
				List<ExpConsignmentQueueNumber> items = new List<ExpConsignmentQueueNumber>();
				ExpConsignmentQueueNumber item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentQueueNumber();
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["KeyValue"] != null && dr["KeyValue"] != DBNull.Value)
					{
						item.KeyValue = Convert.ToString(dr["KeyValue"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
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
		/// Lấy danh sách ExpConsignmentQueueNumber từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpConsignmentQueueNumber> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentQueueNumber] A "+ condition,  parameters);
				List<ExpConsignmentQueueNumber> items = new List<ExpConsignmentQueueNumber>();
				ExpConsignmentQueueNumber item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentQueueNumber();
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["KeyValue"] != null && dr["KeyValue"] != DBNull.Value)
					{
						item.KeyValue = Convert.ToString(dr["KeyValue"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
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

		public List<ExpConsignmentQueueNumber> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentQueueNumber] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentQueueNumber] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpConsignmentQueueNumber>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpConsignmentQueueNumber từ Database
		/// </summary>
		public ExpConsignmentQueueNumber GetObject(string schema, String FK_ExpPost, String KeyValue)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentQueueNumber] where FK_ExpPost=@FK_ExpPost and KeyValue=@KeyValue",
					"@FK_ExpPost", FK_ExpPost, 
					"@KeyValue", KeyValue);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentQueueNumber item=new ExpConsignmentQueueNumber();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["KeyValue"] != null && dr["KeyValue"] != DBNull.Value)
						{
							item.KeyValue = Convert.ToString(dr["KeyValue"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
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
		/// Lấy một ExpConsignmentQueueNumber đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpConsignmentQueueNumber GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentQueueNumber] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentQueueNumber item=new ExpConsignmentQueueNumber();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["KeyValue"] != null && dr["KeyValue"] != DBNull.Value)
						{
							item.KeyValue = Convert.ToString(dr["KeyValue"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
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

		public ExpConsignmentQueueNumber GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentQueueNumber] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpConsignmentQueueNumber>(ds);
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
		/// Thêm mới ExpConsignmentQueueNumber vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpConsignmentQueueNumber _ExpConsignmentQueueNumber)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpConsignmentQueueNumber](FK_ExpPost, KeyValue, Value) VALUES(@FK_ExpPost, @KeyValue, @Value)", 
					"@FK_ExpPost",  _ExpConsignmentQueueNumber.FK_ExpPost, 
					"@KeyValue",  _ExpConsignmentQueueNumber.KeyValue, 
					"@Value",  _ExpConsignmentQueueNumber.Value);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentQueueNumber vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpConsignmentQueueNumber> _ExpConsignmentQueueNumbers)
		{
			foreach (ExpConsignmentQueueNumber item in _ExpConsignmentQueueNumbers)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentQueueNumber vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpConsignmentQueueNumber _ExpConsignmentQueueNumber, String FK_ExpPost, String KeyValue)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentQueueNumber] SET FK_ExpPost=@FK_ExpPost, KeyValue=@KeyValue, Value=@Value WHERE FK_ExpPost=@FK_ExpPost and KeyValue=@KeyValue", 
					"@FK_ExpPost",  _ExpConsignmentQueueNumber.FK_ExpPost, 
					"@KeyValue",  _ExpConsignmentQueueNumber.KeyValue, 
					"@Value",  _ExpConsignmentQueueNumber.Value, 
					"@FK_ExpPost", FK_ExpPost, 
					"@KeyValue", KeyValue);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentQueueNumber vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpConsignmentQueueNumber _ExpConsignmentQueueNumber)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentQueueNumber] SET Value=@Value WHERE FK_ExpPost=@FK_ExpPost and KeyValue=@KeyValue", 
					"@Value",  _ExpConsignmentQueueNumber.Value, 
					"@FK_ExpPost", _ExpConsignmentQueueNumber.FK_ExpPost, 
					"@KeyValue", _ExpConsignmentQueueNumber.KeyValue);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpConsignmentQueueNumber vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpConsignmentQueueNumber> _ExpConsignmentQueueNumbers)
		{
			foreach (ExpConsignmentQueueNumber item in _ExpConsignmentQueueNumbers)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentQueueNumber vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpConsignmentQueueNumber _ExpConsignmentQueueNumber, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentQueueNumber] SET FK_ExpPost=@FK_ExpPost, KeyValue=@KeyValue, Value=@Value "+ condition, 
					"@FK_ExpPost",  _ExpConsignmentQueueNumber.FK_ExpPost, 
					"@KeyValue",  _ExpConsignmentQueueNumber.KeyValue, 
					"@Value",  _ExpConsignmentQueueNumber.Value);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpConsignmentQueueNumber trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_ExpPost, String KeyValue)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentQueueNumber] WHERE FK_ExpPost=@FK_ExpPost and KeyValue=@KeyValue",
					"@FK_ExpPost", FK_ExpPost, 
					"@KeyValue", KeyValue);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentQueueNumber trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpConsignmentQueueNumber _ExpConsignmentQueueNumber)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentQueueNumber] WHERE FK_ExpPost=@FK_ExpPost and KeyValue=@KeyValue",
					"@FK_ExpPost", _ExpConsignmentQueueNumber.FK_ExpPost, 
					"@KeyValue", _ExpConsignmentQueueNumber.KeyValue);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentQueueNumber trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentQueueNumber] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentQueueNumber trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpConsignmentQueueNumber> _ExpConsignmentQueueNumbers)
		{
			foreach (ExpConsignmentQueueNumber item in _ExpConsignmentQueueNumbers)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
