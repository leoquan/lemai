using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpconsignmentondelivery:IEXpconsignmentondelivery
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpconsignmentondelivery(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpConsignmentOnDelivery từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentOnDelivery]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpConsignmentOnDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentOnDelivery] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpConsignmentOnDelivery từ Database
		/// </summary>
		public List<ExpConsignmentOnDelivery> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentOnDelivery]");
				List<ExpConsignmentOnDelivery> items = new List<ExpConsignmentOnDelivery>();
				ExpConsignmentOnDelivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentOnDelivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["YeuCauGiao"] != null && dr["YeuCauGiao"] != DBNull.Value)
					{
						item.YeuCauGiao = Convert.ToString(dr["YeuCauGiao"]);
					}
					if (dr["OrderId"] != null && dr["OrderId"] != DBNull.Value)
					{
						item.OrderId = Convert.ToInt32(dr["OrderId"]);
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
		/// Lấy danh sách ExpConsignmentOnDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpConsignmentOnDelivery> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentOnDelivery] A "+ condition,  parameters);
				List<ExpConsignmentOnDelivery> items = new List<ExpConsignmentOnDelivery>();
				ExpConsignmentOnDelivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentOnDelivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["YeuCauGiao"] != null && dr["YeuCauGiao"] != DBNull.Value)
					{
						item.YeuCauGiao = Convert.ToString(dr["YeuCauGiao"]);
					}
					if (dr["OrderId"] != null && dr["OrderId"] != DBNull.Value)
					{
						item.OrderId = Convert.ToInt32(dr["OrderId"]);
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

		public List<ExpConsignmentOnDelivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentOnDelivery] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentOnDelivery] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpConsignmentOnDelivery>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpConsignmentOnDelivery từ Database
		/// </summary>
		public ExpConsignmentOnDelivery GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentOnDelivery] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentOnDelivery item=new ExpConsignmentOnDelivery();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["YeuCauGiao"] != null && dr["YeuCauGiao"] != DBNull.Value)
						{
							item.YeuCauGiao = Convert.ToString(dr["YeuCauGiao"]);
						}
						if (dr["OrderId"] != null && dr["OrderId"] != DBNull.Value)
						{
							item.OrderId = Convert.ToInt32(dr["OrderId"]);
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
		/// Lấy một ExpConsignmentOnDelivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpConsignmentOnDelivery GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentOnDelivery] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentOnDelivery item=new ExpConsignmentOnDelivery();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["YeuCauGiao"] != null && dr["YeuCauGiao"] != DBNull.Value)
						{
							item.YeuCauGiao = Convert.ToString(dr["YeuCauGiao"]);
						}
						if (dr["OrderId"] != null && dr["OrderId"] != DBNull.Value)
						{
							item.OrderId = Convert.ToInt32(dr["OrderId"]);
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

		public ExpConsignmentOnDelivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentOnDelivery] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpConsignmentOnDelivery>(ds);
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
		/// Thêm mới ExpConsignmentOnDelivery vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpConsignmentOnDelivery _ExpConsignmentOnDelivery)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpConsignmentOnDelivery](Id, YeuCauGiao, OrderId) VALUES(@Id, @YeuCauGiao, @OrderId)", 
					"@Id",  _ExpConsignmentOnDelivery.Id, 
					"@YeuCauGiao",  _ExpConsignmentOnDelivery.YeuCauGiao, 
					"@OrderId",  _ExpConsignmentOnDelivery.OrderId);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentOnDelivery vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpConsignmentOnDelivery> _ExpConsignmentOnDeliverys)
		{
			foreach (ExpConsignmentOnDelivery item in _ExpConsignmentOnDeliverys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentOnDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpConsignmentOnDelivery _ExpConsignmentOnDelivery, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentOnDelivery] SET Id=@Id, YeuCauGiao=@YeuCauGiao, OrderId=@OrderId WHERE Id=@Id", 
					"@Id",  _ExpConsignmentOnDelivery.Id, 
					"@YeuCauGiao",  _ExpConsignmentOnDelivery.YeuCauGiao, 
					"@OrderId",  _ExpConsignmentOnDelivery.OrderId, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentOnDelivery vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpConsignmentOnDelivery _ExpConsignmentOnDelivery)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentOnDelivery] SET YeuCauGiao=@YeuCauGiao, OrderId=@OrderId WHERE Id=@Id", 
					"@YeuCauGiao",  _ExpConsignmentOnDelivery.YeuCauGiao, 
					"@OrderId",  _ExpConsignmentOnDelivery.OrderId, 
					"@Id", _ExpConsignmentOnDelivery.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpConsignmentOnDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpConsignmentOnDelivery> _ExpConsignmentOnDeliverys)
		{
			foreach (ExpConsignmentOnDelivery item in _ExpConsignmentOnDeliverys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentOnDelivery vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpConsignmentOnDelivery _ExpConsignmentOnDelivery, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentOnDelivery] SET Id=@Id, YeuCauGiao=@YeuCauGiao, OrderId=@OrderId "+ condition, 
					"@Id",  _ExpConsignmentOnDelivery.Id, 
					"@YeuCauGiao",  _ExpConsignmentOnDelivery.YeuCauGiao, 
					"@OrderId",  _ExpConsignmentOnDelivery.OrderId);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpConsignmentOnDelivery trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentOnDelivery] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentOnDelivery trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpConsignmentOnDelivery _ExpConsignmentOnDelivery)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentOnDelivery] WHERE Id=@Id",
					"@Id", _ExpConsignmentOnDelivery.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentOnDelivery trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentOnDelivery] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentOnDelivery trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpConsignmentOnDelivery> _ExpConsignmentOnDeliverys)
		{
			foreach (ExpConsignmentOnDelivery item in _ExpConsignmentOnDeliverys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
