using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpconsigndelivery:IEXpconsigndelivery
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpconsigndelivery(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpConsignDelivery từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignDelivery]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpConsignDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignDelivery] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpConsignDelivery từ Database
		/// </summary>
		public List<ExpConsignDelivery> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignDelivery]");
				List<ExpConsignDelivery> items = new List<ExpConsignDelivery>();
				ExpConsignDelivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignDelivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
					{
						item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["DeliveryDate"] != null && dr["DeliveryDate"] != DBNull.Value)
					{
						item.DeliveryDate = Convert.ToDateTime(dr["DeliveryDate"]);
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
		/// Lấy danh sách ExpConsignDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpConsignDelivery> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignDelivery] A "+ condition,  parameters);
				List<ExpConsignDelivery> items = new List<ExpConsignDelivery>();
				ExpConsignDelivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignDelivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
					{
						item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
					}
					if (dr["DeliveryDate"] != null && dr["DeliveryDate"] != DBNull.Value)
					{
						item.DeliveryDate = Convert.ToDateTime(dr["DeliveryDate"]);
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

		public List<ExpConsignDelivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignDelivery] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpConsignDelivery] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpConsignDelivery>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpConsignDelivery từ Database
		/// </summary>
		public ExpConsignDelivery GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignDelivery] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpConsignDelivery item=new ExpConsignDelivery();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
						{
							item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
						{
							item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
						{
							item.IsDone = Convert.ToBoolean(dr["IsDone"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
						}
						if (dr["DeliveryDate"] != null && dr["DeliveryDate"] != DBNull.Value)
						{
							item.DeliveryDate = Convert.ToDateTime(dr["DeliveryDate"]);
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
		/// Lấy một ExpConsignDelivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpConsignDelivery GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignDelivery] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpConsignDelivery item=new ExpConsignDelivery();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
						{
							item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
						{
							item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
						{
							item.IsDone = Convert.ToBoolean(dr["IsDone"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
						}
						if (dr["DeliveryDate"] != null && dr["DeliveryDate"] != DBNull.Value)
						{
							item.DeliveryDate = Convert.ToDateTime(dr["DeliveryDate"]);
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

		public ExpConsignDelivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignDelivery] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpConsignDelivery>(ds);
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
		/// Thêm mới ExpConsignDelivery vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpConsignDelivery _ExpConsignDelivery)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpConsignDelivery](Id, FK_ExpConsignment, FK_ExpPost, FK_Shipper, CreateBy, CreateDate, Note, IsDone, Type, DeliveryDate) VALUES(@Id, @FK_ExpConsignment, @FK_ExpPost, @FK_Shipper, @CreateBy, @CreateDate, @Note, @IsDone, @Type, @DeliveryDate)", 
					"@Id",  _ExpConsignDelivery.Id, 
					"@FK_ExpConsignment",  _ExpConsignDelivery.FK_ExpConsignment, 
					"@FK_ExpPost",  _ExpConsignDelivery.FK_ExpPost, 
					"@FK_Shipper",  _ExpConsignDelivery.FK_Shipper, 
					"@CreateBy",  _ExpConsignDelivery.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignDelivery.CreateDate), 
					"@Note",  _ExpConsignDelivery.Note, 
					"@IsDone",  _ExpConsignDelivery.IsDone, 
					"@Type",  _ExpConsignDelivery.Type, 
					"@DeliveryDate", this._dataContext.ConvertDateString( _ExpConsignDelivery.DeliveryDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpConsignDelivery vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpConsignDelivery> _ExpConsignDeliverys)
		{
			foreach (ExpConsignDelivery item in _ExpConsignDeliverys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpConsignDelivery _ExpConsignDelivery, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignDelivery] SET Id=@Id, FK_ExpConsignment=@FK_ExpConsignment, FK_ExpPost=@FK_ExpPost, FK_Shipper=@FK_Shipper, CreateBy=@CreateBy, CreateDate=@CreateDate, Note=@Note, IsDone=@IsDone, Type=@Type, DeliveryDate=@DeliveryDate WHERE Id=@Id", 
					"@Id",  _ExpConsignDelivery.Id, 
					"@FK_ExpConsignment",  _ExpConsignDelivery.FK_ExpConsignment, 
					"@FK_ExpPost",  _ExpConsignDelivery.FK_ExpPost, 
					"@FK_Shipper",  _ExpConsignDelivery.FK_Shipper, 
					"@CreateBy",  _ExpConsignDelivery.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignDelivery.CreateDate), 
					"@Note",  _ExpConsignDelivery.Note, 
					"@IsDone",  _ExpConsignDelivery.IsDone, 
					"@Type",  _ExpConsignDelivery.Type, 
					"@DeliveryDate", this._dataContext.ConvertDateString( _ExpConsignDelivery.DeliveryDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignDelivery vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpConsignDelivery _ExpConsignDelivery)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignDelivery] SET FK_ExpConsignment=@FK_ExpConsignment, FK_ExpPost=@FK_ExpPost, FK_Shipper=@FK_Shipper, CreateBy=@CreateBy, CreateDate=@CreateDate, Note=@Note, IsDone=@IsDone, Type=@Type, DeliveryDate=@DeliveryDate WHERE Id=@Id", 
					"@FK_ExpConsignment",  _ExpConsignDelivery.FK_ExpConsignment, 
					"@FK_ExpPost",  _ExpConsignDelivery.FK_ExpPost, 
					"@FK_Shipper",  _ExpConsignDelivery.FK_Shipper, 
					"@CreateBy",  _ExpConsignDelivery.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignDelivery.CreateDate), 
					"@Note",  _ExpConsignDelivery.Note, 
					"@IsDone",  _ExpConsignDelivery.IsDone, 
					"@Type",  _ExpConsignDelivery.Type, 
					"@DeliveryDate", this._dataContext.ConvertDateString( _ExpConsignDelivery.DeliveryDate), 
					"@Id", _ExpConsignDelivery.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpConsignDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpConsignDelivery> _ExpConsignDeliverys)
		{
			foreach (ExpConsignDelivery item in _ExpConsignDeliverys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignDelivery vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpConsignDelivery _ExpConsignDelivery, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignDelivery] SET Id=@Id, FK_ExpConsignment=@FK_ExpConsignment, FK_ExpPost=@FK_ExpPost, FK_Shipper=@FK_Shipper, CreateBy=@CreateBy, CreateDate=@CreateDate, Note=@Note, IsDone=@IsDone, Type=@Type, DeliveryDate=@DeliveryDate "+ condition, 
					"@Id",  _ExpConsignDelivery.Id, 
					"@FK_ExpConsignment",  _ExpConsignDelivery.FK_ExpConsignment, 
					"@FK_ExpPost",  _ExpConsignDelivery.FK_ExpPost, 
					"@FK_Shipper",  _ExpConsignDelivery.FK_Shipper, 
					"@CreateBy",  _ExpConsignDelivery.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignDelivery.CreateDate), 
					"@Note",  _ExpConsignDelivery.Note, 
					"@IsDone",  _ExpConsignDelivery.IsDone, 
					"@Type",  _ExpConsignDelivery.Type, 
					"@DeliveryDate", this._dataContext.ConvertDateString( _ExpConsignDelivery.DeliveryDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpConsignDelivery trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignDelivery] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignDelivery trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpConsignDelivery _ExpConsignDelivery)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignDelivery] WHERE Id=@Id",
					"@Id", _ExpConsignDelivery.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignDelivery trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignDelivery] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignDelivery trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpConsignDelivery> _ExpConsignDeliverys)
		{
			foreach (ExpConsignDelivery item in _ExpConsignDeliverys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
