using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MQUeuenumber:IQUeuenumber
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MQUeuenumber(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable QueueNumber từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[QueueNumber]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable QueueNumber từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[QueueNumber] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách QueueNumber từ Database
		/// </summary>
		public List<QueueNumber> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[QueueNumber]");
				List<QueueNumber> items = new List<QueueNumber>();
				QueueNumber item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new QueueNumber();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["KeyValue"] != null && dr["KeyValue"] != DBNull.Value)
					{
						item.KeyValue = Convert.ToString(dr["KeyValue"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
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
		/// Lấy danh sách QueueNumber từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<QueueNumber> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[QueueNumber] A "+ condition,  parameters);
				List<QueueNumber> items = new List<QueueNumber>();
				QueueNumber item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new QueueNumber();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["KeyValue"] != null && dr["KeyValue"] != DBNull.Value)
					{
						item.KeyValue = Convert.ToString(dr["KeyValue"]);
					}
					if (dr["Value"] != null && dr["Value"] != DBNull.Value)
					{
						item.Value = Convert.ToInt32(dr["Value"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
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

		public List<QueueNumber> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[QueueNumber] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[QueueNumber] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<QueueNumber>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một QueueNumber từ Database
		/// </summary>
		public QueueNumber GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[QueueNumber] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					QueueNumber item=new QueueNumber();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["KeyValue"] != null && dr["KeyValue"] != DBNull.Value)
						{
							item.KeyValue = Convert.ToString(dr["KeyValue"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
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
		/// Lấy một QueueNumber đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public QueueNumber GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[QueueNumber] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					QueueNumber item=new QueueNumber();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["KeyValue"] != null && dr["KeyValue"] != DBNull.Value)
						{
							item.KeyValue = Convert.ToString(dr["KeyValue"]);
						}
						if (dr["Value"] != null && dr["Value"] != DBNull.Value)
						{
							item.Value = Convert.ToInt32(dr["Value"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
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

		public QueueNumber GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[QueueNumber] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<QueueNumber>(ds);
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
		/// Thêm mới QueueNumber vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, QueueNumber _QueueNumber)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[QueueNumber](Id, KeyValue, Value, FK_Branch) VALUES(@Id, @KeyValue, @Value, @FK_Branch)", 
					"@Id",  _QueueNumber.Id, 
					"@KeyValue",  _QueueNumber.KeyValue, 
					"@Value",  _QueueNumber.Value, 
					"@FK_Branch",  _QueueNumber.FK_Branch);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng QueueNumber vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<QueueNumber> _QueueNumbers)
		{
			foreach (QueueNumber item in _QueueNumbers)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật QueueNumber vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, QueueNumber _QueueNumber, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[QueueNumber] SET Id=@Id, KeyValue=@KeyValue, Value=@Value, FK_Branch=@FK_Branch WHERE Id=@Id", 
					"@Id",  _QueueNumber.Id, 
					"@KeyValue",  _QueueNumber.KeyValue, 
					"@Value",  _QueueNumber.Value, 
					"@FK_Branch",  _QueueNumber.FK_Branch, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật QueueNumber vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, QueueNumber _QueueNumber)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[QueueNumber] SET KeyValue=@KeyValue, Value=@Value, FK_Branch=@FK_Branch WHERE Id=@Id", 
					"@KeyValue",  _QueueNumber.KeyValue, 
					"@Value",  _QueueNumber.Value, 
					"@FK_Branch",  _QueueNumber.FK_Branch, 
					"@Id", _QueueNumber.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách QueueNumber vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<QueueNumber> _QueueNumbers)
		{
			foreach (QueueNumber item in _QueueNumbers)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật QueueNumber vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, QueueNumber _QueueNumber, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[QueueNumber] SET Id=@Id, KeyValue=@KeyValue, Value=@Value, FK_Branch=@FK_Branch "+ condition, 
					"@Id",  _QueueNumber.Id, 
					"@KeyValue",  _QueueNumber.KeyValue, 
					"@Value",  _QueueNumber.Value, 
					"@FK_Branch",  _QueueNumber.FK_Branch);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa QueueNumber trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[QueueNumber] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa QueueNumber trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, QueueNumber _QueueNumber)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[QueueNumber] WHERE Id=@Id",
					"@Id", _QueueNumber.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa QueueNumber trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[QueueNumber] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa QueueNumber trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<QueueNumber> _QueueNumbers)
		{
			foreach (QueueNumber item in _QueueNumbers)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
