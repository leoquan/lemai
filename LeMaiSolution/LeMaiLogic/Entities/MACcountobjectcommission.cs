using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MACcountobjectcommission:IACcountobjectcommission
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MACcountobjectcommission(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable AccountObjectCommission từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectCommission]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable AccountObjectCommission từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectCommission] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách AccountObjectCommission từ Database
		/// </summary>
		public List<AccountObjectCommission> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectCommission]");
				List<AccountObjectCommission> items = new List<AccountObjectCommission>();
				AccountObjectCommission item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectCommission();
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
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
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
					if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
					{
						item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
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
		/// Lấy danh sách AccountObjectCommission từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<AccountObjectCommission> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectCommission] A "+ condition,  parameters);
				List<AccountObjectCommission> items = new List<AccountObjectCommission>();
				AccountObjectCommission item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new AccountObjectCommission();
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
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
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
					if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
					{
						item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
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

		public List<AccountObjectCommission> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectCommission] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[AccountObjectCommission] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<AccountObjectCommission>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một AccountObjectCommission từ Database
		/// </summary>
		public AccountObjectCommission GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[AccountObjectCommission] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					AccountObjectCommission item=new AccountObjectCommission();
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
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
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
						if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
						{
							item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
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
		/// Lấy một AccountObjectCommission đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public AccountObjectCommission GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[AccountObjectCommission] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					AccountObjectCommission item=new AccountObjectCommission();
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
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
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
						if (dr["FK_Employee"] != null && dr["FK_Employee"] != DBNull.Value)
						{
							item.FK_Employee = Convert.ToString(dr["FK_Employee"]);
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

		public AccountObjectCommission GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[AccountObjectCommission] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<AccountObjectCommission>(ds);
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
		/// Thêm mới AccountObjectCommission vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, AccountObjectCommission _AccountObjectCommission)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[AccountObjectCommission](Id, RewardPoint, IsWithraw, FK_Service, CreateDate, FK_Branch, FK_CreateBy, Note, FK_Employee) VALUES(@Id, @RewardPoint, @IsWithraw, @FK_Service, @CreateDate, @FK_Branch, @FK_CreateBy, @Note, @FK_Employee)", 
					"@Id",  _AccountObjectCommission.Id, 
					"@RewardPoint",  _AccountObjectCommission.RewardPoint, 
					"@IsWithraw",  _AccountObjectCommission.IsWithraw, 
					"@FK_Service",  _AccountObjectCommission.FK_Service, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectCommission.CreateDate), 
					"@FK_Branch",  _AccountObjectCommission.FK_Branch, 
					"@FK_CreateBy",  _AccountObjectCommission.FK_CreateBy, 
					"@Note",  _AccountObjectCommission.Note, 
					"@FK_Employee",  _AccountObjectCommission.FK_Employee);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng AccountObjectCommission vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<AccountObjectCommission> _AccountObjectCommissions)
		{
			foreach (AccountObjectCommission item in _AccountObjectCommissions)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectCommission vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, AccountObjectCommission _AccountObjectCommission, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectCommission] SET Id=@Id, RewardPoint=@RewardPoint, IsWithraw=@IsWithraw, FK_Service=@FK_Service, CreateDate=@CreateDate, FK_Branch=@FK_Branch, FK_CreateBy=@FK_CreateBy, Note=@Note, FK_Employee=@FK_Employee WHERE Id=@Id", 
					"@Id",  _AccountObjectCommission.Id, 
					"@RewardPoint",  _AccountObjectCommission.RewardPoint, 
					"@IsWithraw",  _AccountObjectCommission.IsWithraw, 
					"@FK_Service",  _AccountObjectCommission.FK_Service, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectCommission.CreateDate), 
					"@FK_Branch",  _AccountObjectCommission.FK_Branch, 
					"@FK_CreateBy",  _AccountObjectCommission.FK_CreateBy, 
					"@Note",  _AccountObjectCommission.Note, 
					"@FK_Employee",  _AccountObjectCommission.FK_Employee, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectCommission vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, AccountObjectCommission _AccountObjectCommission)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectCommission] SET RewardPoint=@RewardPoint, IsWithraw=@IsWithraw, FK_Service=@FK_Service, CreateDate=@CreateDate, FK_Branch=@FK_Branch, FK_CreateBy=@FK_CreateBy, Note=@Note, FK_Employee=@FK_Employee WHERE Id=@Id", 
					"@RewardPoint",  _AccountObjectCommission.RewardPoint, 
					"@IsWithraw",  _AccountObjectCommission.IsWithraw, 
					"@FK_Service",  _AccountObjectCommission.FK_Service, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectCommission.CreateDate), 
					"@FK_Branch",  _AccountObjectCommission.FK_Branch, 
					"@FK_CreateBy",  _AccountObjectCommission.FK_CreateBy, 
					"@Note",  _AccountObjectCommission.Note, 
					"@FK_Employee",  _AccountObjectCommission.FK_Employee, 
					"@Id", _AccountObjectCommission.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách AccountObjectCommission vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<AccountObjectCommission> _AccountObjectCommissions)
		{
			foreach (AccountObjectCommission item in _AccountObjectCommissions)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật AccountObjectCommission vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, AccountObjectCommission _AccountObjectCommission, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[AccountObjectCommission] SET Id=@Id, RewardPoint=@RewardPoint, IsWithraw=@IsWithraw, FK_Service=@FK_Service, CreateDate=@CreateDate, FK_Branch=@FK_Branch, FK_CreateBy=@FK_CreateBy, Note=@Note, FK_Employee=@FK_Employee "+ condition, 
					"@Id",  _AccountObjectCommission.Id, 
					"@RewardPoint",  _AccountObjectCommission.RewardPoint, 
					"@IsWithraw",  _AccountObjectCommission.IsWithraw, 
					"@FK_Service",  _AccountObjectCommission.FK_Service, 
					"@CreateDate", this._dataContext.ConvertDateString( _AccountObjectCommission.CreateDate), 
					"@FK_Branch",  _AccountObjectCommission.FK_Branch, 
					"@FK_CreateBy",  _AccountObjectCommission.FK_CreateBy, 
					"@Note",  _AccountObjectCommission.Note, 
					"@FK_Employee",  _AccountObjectCommission.FK_Employee);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa AccountObjectCommission trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectCommission] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectCommission trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, AccountObjectCommission _AccountObjectCommission)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectCommission] WHERE Id=@Id",
					"@Id", _AccountObjectCommission.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectCommission trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[AccountObjectCommission] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa AccountObjectCommission trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<AccountObjectCommission> _AccountObjectCommissions)
		{
			foreach (AccountObjectCommission item in _AccountObjectCommissions)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
