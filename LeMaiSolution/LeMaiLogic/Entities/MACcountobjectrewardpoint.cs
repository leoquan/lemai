using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MACcountobjectrewardpoint:IACcountobjectrewardpoint
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MACcountobjectrewardpoint(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable AccountObjectRewardPoint từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectRewardPoint]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable AccountObjectRewardPoint từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectRewardPoint] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách AccountObjectRewardPoint từ Database
		/// </summary>
		public List<AccountObjectRewardPoint> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectRewardPoint]");
				List<AccountObjectRewardPoint> items = new List<AccountObjectRewardPoint>();
				AccountObjectRewardPoint item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectRewardPoint();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["RewardPoint"] != null && dr["RewardPoint"] != DBNull.Value)
					{
						item.RewardPoint = Convert.ToInt32(dr["RewardPoint"]);
					}
					if (dr["IsWithraw"] != null && dr["IsWithraw"] != DBNull.Value)
					{
						item.IsWithraw = Convert.ToBoolean(dr["IsWithraw"]);
					}
					if (dr["FK_Invoice"] != null && dr["FK_Invoice"] != DBNull.Value)
					{
						item.FK_Invoice = Convert.ToString(dr["FK_Invoice"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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
		/// Lấy danh sách AccountObjectRewardPoint từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<AccountObjectRewardPoint> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectRewardPoint] A "+ condition,  parameters);
				List<AccountObjectRewardPoint> items = new List<AccountObjectRewardPoint>();
				AccountObjectRewardPoint item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectRewardPoint();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["RewardPoint"] != null && dr["RewardPoint"] != DBNull.Value)
					{
						item.RewardPoint = Convert.ToInt32(dr["RewardPoint"]);
					}
					if (dr["IsWithraw"] != null && dr["IsWithraw"] != DBNull.Value)
					{
						item.IsWithraw = Convert.ToBoolean(dr["IsWithraw"]);
					}
					if (dr["FK_Invoice"] != null && dr["FK_Invoice"] != DBNull.Value)
					{
						item.FK_Invoice = Convert.ToString(dr["FK_Invoice"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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

		public List<AccountObjectRewardPoint> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectRewardPoint] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[AccountObjectRewardPoint] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<AccountObjectRewardPoint>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một AccountObjectRewardPoint từ Database
		/// </summary>
		public AccountObjectRewardPoint GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectRewardPoint] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					AccountObjectRewardPoint item=new AccountObjectRewardPoint();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["RewardPoint"] != null && dr["RewardPoint"] != DBNull.Value)
						{
							item.RewardPoint = Convert.ToInt32(dr["RewardPoint"]);
						}
						if (dr["IsWithraw"] != null && dr["IsWithraw"] != DBNull.Value)
						{
							item.IsWithraw = Convert.ToBoolean(dr["IsWithraw"]);
						}
						if (dr["FK_Invoice"] != null && dr["FK_Invoice"] != DBNull.Value)
						{
							item.FK_Invoice = Convert.ToString(dr["FK_Invoice"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
						{
							item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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
		/// Lấy một AccountObjectRewardPoint đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public AccountObjectRewardPoint GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectRewardPoint] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					AccountObjectRewardPoint item=new AccountObjectRewardPoint();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["RewardPoint"] != null && dr["RewardPoint"] != DBNull.Value)
						{
							item.RewardPoint = Convert.ToInt32(dr["RewardPoint"]);
						}
						if (dr["IsWithraw"] != null && dr["IsWithraw"] != DBNull.Value)
						{
							item.IsWithraw = Convert.ToBoolean(dr["IsWithraw"]);
						}
						if (dr["FK_Invoice"] != null && dr["FK_Invoice"] != DBNull.Value)
						{
							item.FK_Invoice = Convert.ToString(dr["FK_Invoice"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
						{
							item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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

		public AccountObjectRewardPoint GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectRewardPoint] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<AccountObjectRewardPoint>(ds);
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
		/// Thêm mới AccountObjectRewardPoint vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, AccountObjectRewardPoint _AccountObjectRewardPoint)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[AccountObjectRewardPoint](Id, RewardPoint, IsWithraw, FK_Invoice, CreateDate, FK_Branch, FK_CreateBy, Note, FK_Customer) VALUES(@Id, @RewardPoint, @IsWithraw, @FK_Invoice, @CreateDate, @FK_Branch, @FK_CreateBy, @Note, @FK_Customer)", 
					"@Id",  _AccountObjectRewardPoint.Id, 
					"@RewardPoint",  _AccountObjectRewardPoint.RewardPoint, 
					"@IsWithraw",  _AccountObjectRewardPoint.IsWithraw, 
					"@FK_Invoice",  _AccountObjectRewardPoint.FK_Invoice, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectRewardPoint.CreateDate), 
					"@FK_Branch",  _AccountObjectRewardPoint.FK_Branch, 
					"@FK_CreateBy",  _AccountObjectRewardPoint.FK_CreateBy, 
					"@Note",  _AccountObjectRewardPoint.Note, 
					"@FK_Customer",  _AccountObjectRewardPoint.FK_Customer);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng AccountObjectRewardPoint vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<AccountObjectRewardPoint> _AccountObjectRewardPoints)
		{
			foreach (AccountObjectRewardPoint item in _AccountObjectRewardPoints)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectRewardPoint vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, AccountObjectRewardPoint _AccountObjectRewardPoint, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectRewardPoint] SET Id=@Id, RewardPoint=@RewardPoint, IsWithraw=@IsWithraw, FK_Invoice=@FK_Invoice, CreateDate=@CreateDate, FK_Branch=@FK_Branch, FK_CreateBy=@FK_CreateBy, Note=@Note, FK_Customer=@FK_Customer WHERE Id=@Id", 
					"@Id",  _AccountObjectRewardPoint.Id, 
					"@RewardPoint",  _AccountObjectRewardPoint.RewardPoint, 
					"@IsWithraw",  _AccountObjectRewardPoint.IsWithraw, 
					"@FK_Invoice",  _AccountObjectRewardPoint.FK_Invoice, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectRewardPoint.CreateDate), 
					"@FK_Branch",  _AccountObjectRewardPoint.FK_Branch, 
					"@FK_CreateBy",  _AccountObjectRewardPoint.FK_CreateBy, 
					"@Note",  _AccountObjectRewardPoint.Note, 
					"@FK_Customer",  _AccountObjectRewardPoint.FK_Customer, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectRewardPoint vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, AccountObjectRewardPoint _AccountObjectRewardPoint)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectRewardPoint] SET RewardPoint=@RewardPoint, IsWithraw=@IsWithraw, FK_Invoice=@FK_Invoice, CreateDate=@CreateDate, FK_Branch=@FK_Branch, FK_CreateBy=@FK_CreateBy, Note=@Note, FK_Customer=@FK_Customer WHERE Id=@Id", 
					"@RewardPoint",  _AccountObjectRewardPoint.RewardPoint, 
					"@IsWithraw",  _AccountObjectRewardPoint.IsWithraw, 
					"@FK_Invoice",  _AccountObjectRewardPoint.FK_Invoice, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectRewardPoint.CreateDate), 
					"@FK_Branch",  _AccountObjectRewardPoint.FK_Branch, 
					"@FK_CreateBy",  _AccountObjectRewardPoint.FK_CreateBy, 
					"@Note",  _AccountObjectRewardPoint.Note, 
					"@FK_Customer",  _AccountObjectRewardPoint.FK_Customer, 
					"@Id", _AccountObjectRewardPoint.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách AccountObjectRewardPoint vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<AccountObjectRewardPoint> _AccountObjectRewardPoints)
		{
			foreach (AccountObjectRewardPoint item in _AccountObjectRewardPoints)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectRewardPoint vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, AccountObjectRewardPoint _AccountObjectRewardPoint, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectRewardPoint] SET Id=@Id, RewardPoint=@RewardPoint, IsWithraw=@IsWithraw, FK_Invoice=@FK_Invoice, CreateDate=@CreateDate, FK_Branch=@FK_Branch, FK_CreateBy=@FK_CreateBy, Note=@Note, FK_Customer=@FK_Customer "+ condition, 
					"@Id",  _AccountObjectRewardPoint.Id, 
					"@RewardPoint",  _AccountObjectRewardPoint.RewardPoint, 
					"@IsWithraw",  _AccountObjectRewardPoint.IsWithraw, 
					"@FK_Invoice",  _AccountObjectRewardPoint.FK_Invoice, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectRewardPoint.CreateDate), 
					"@FK_Branch",  _AccountObjectRewardPoint.FK_Branch, 
					"@FK_CreateBy",  _AccountObjectRewardPoint.FK_CreateBy, 
					"@Note",  _AccountObjectRewardPoint.Note, 
					"@FK_Customer",  _AccountObjectRewardPoint.FK_Customer);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa AccountObjectRewardPoint trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectRewardPoint] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectRewardPoint trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, AccountObjectRewardPoint _AccountObjectRewardPoint)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectRewardPoint] WHERE Id=@Id",
					"@Id", _AccountObjectRewardPoint.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectRewardPoint trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectRewardPoint] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectRewardPoint trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<AccountObjectRewardPoint> _AccountObjectRewardPoints)
		{
			foreach (AccountObjectRewardPoint item in _AccountObjectRewardPoints)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
