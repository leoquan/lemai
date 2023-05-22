using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbfaqtopic:IWEbfaqtopic
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbfaqtopic(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebFaqTopic từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebFaqTopic]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebFaqTopic từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebFaqTopic] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebFaqTopic từ Database
		/// </summary>
		public List<WebFaqTopic> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebFaqTopic]");
				List<WebFaqTopic> items = new List<WebFaqTopic>();
				WebFaqTopic item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebFaqTopic();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TopicName"] != null && dr["TopicName"] != DBNull.Value)
					{
						item.TopicName = Convert.ToString(dr["TopicName"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy danh sách WebFaqTopic từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebFaqTopic> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebFaqTopic] A "+ condition,  parameters);
				List<WebFaqTopic> items = new List<WebFaqTopic>();
				WebFaqTopic item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebFaqTopic();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TopicName"] != null && dr["TopicName"] != DBNull.Value)
					{
						item.TopicName = Convert.ToString(dr["TopicName"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public List<WebFaqTopic> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebFaqTopic] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebFaqTopic] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebFaqTopic>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebFaqTopic từ Database
		/// </summary>
		public WebFaqTopic GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebFaqTopic] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebFaqTopic item=new WebFaqTopic();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TopicName"] != null && dr["TopicName"] != DBNull.Value)
						{
							item.TopicName = Convert.ToString(dr["TopicName"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy một WebFaqTopic đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebFaqTopic GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebFaqTopic] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebFaqTopic item=new WebFaqTopic();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TopicName"] != null && dr["TopicName"] != DBNull.Value)
						{
							item.TopicName = Convert.ToString(dr["TopicName"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public WebFaqTopic GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebFaqTopic] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebFaqTopic>(ds);
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
		/// Thêm mới WebFaqTopic vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebFaqTopic _WebFaqTopic)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebFaqTopic](Id, TopicName, OrderNumber, BranchCode) VALUES(@Id, @TopicName, @OrderNumber, @BranchCode)", 
					"@Id",  _WebFaqTopic.Id, 
					"@TopicName",  _WebFaqTopic.TopicName, 
					"@OrderNumber",  _WebFaqTopic.OrderNumber, 
					"@BranchCode",  _WebFaqTopic.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebFaqTopic vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebFaqTopic> _WebFaqTopics)
		{
			foreach (WebFaqTopic item in _WebFaqTopics)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebFaqTopic vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebFaqTopic _WebFaqTopic, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebFaqTopic] SET Id=@Id, TopicName=@TopicName, OrderNumber=@OrderNumber, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebFaqTopic.Id, 
					"@TopicName",  _WebFaqTopic.TopicName, 
					"@OrderNumber",  _WebFaqTopic.OrderNumber, 
					"@BranchCode",  _WebFaqTopic.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebFaqTopic vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebFaqTopic _WebFaqTopic)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebFaqTopic] SET TopicName=@TopicName, OrderNumber=@OrderNumber, BranchCode=@BranchCode WHERE Id=@Id", 
					"@TopicName",  _WebFaqTopic.TopicName, 
					"@OrderNumber",  _WebFaqTopic.OrderNumber, 
					"@BranchCode",  _WebFaqTopic.BranchCode, 
					"@Id", _WebFaqTopic.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebFaqTopic vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebFaqTopic> _WebFaqTopics)
		{
			foreach (WebFaqTopic item in _WebFaqTopics)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebFaqTopic vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebFaqTopic _WebFaqTopic, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebFaqTopic] SET Id=@Id, TopicName=@TopicName, OrderNumber=@OrderNumber, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebFaqTopic.Id, 
					"@TopicName",  _WebFaqTopic.TopicName, 
					"@OrderNumber",  _WebFaqTopic.OrderNumber, 
					"@BranchCode",  _WebFaqTopic.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebFaqTopic trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebFaqTopic] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebFaqTopic trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebFaqTopic _WebFaqTopic)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebFaqTopic] WHERE Id=@Id",
					"@Id", _WebFaqTopic.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebFaqTopic trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebFaqTopic] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebFaqTopic trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebFaqTopic> _WebFaqTopics)
		{
			foreach (WebFaqTopic item in _WebFaqTopics)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
