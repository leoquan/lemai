using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExprequestmoney:IGExprequestmoney
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExprequestmoney(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpRequestMoney từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpRequestMoney]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpRequestMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpRequestMoney] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpRequestMoney từ Database
		/// </summary>
		public List<GExpRequestMoney> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpRequestMoney]");
				List<GExpRequestMoney> items = new List<GExpRequestMoney>();
				GExpRequestMoney item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpRequestMoney();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_RequestAccount"] != null && dr["FK_RequestAccount"] != DBNull.Value)
					{
						item.FK_RequestAccount = Convert.ToString(dr["FK_RequestAccount"]);
					}
					if (dr["FK_PostResponse"] != null && dr["FK_PostResponse"] != DBNull.Value)
					{
						item.FK_PostResponse = Convert.ToString(dr["FK_PostResponse"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToInt32(dr["SoTien"]);
					}
					if (dr["RequestCode"] != null && dr["RequestCode"] != DBNull.Value)
					{
						item.RequestCode = Convert.ToString(dr["RequestCode"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsConfirm"] != null && dr["IsConfirm"] != DBNull.Value)
					{
						item.IsConfirm = Convert.ToBoolean(dr["IsConfirm"]);
					}
					if (dr["BankAccount"] != null && dr["BankAccount"] != DBNull.Value)
					{
						item.BankAccount = Convert.ToString(dr["BankAccount"]);
					}
					if (dr["BankOwner"] != null && dr["BankOwner"] != DBNull.Value)
					{
						item.BankOwner = Convert.ToString(dr["BankOwner"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["ConfirmDate"] != null && dr["ConfirmDate"] != DBNull.Value)
					{
						item.ConfirmDate = Convert.ToDateTime(dr["ConfirmDate"]);
					}
					if (dr["ReSoTien"] != null && dr["ReSoTien"] != DBNull.Value)
					{
						item.ReSoTien = Convert.ToInt32(dr["ReSoTien"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
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
		/// Lấy danh sách GExpRequestMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpRequestMoney> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpRequestMoney] A "+ condition,  parameters);
				List<GExpRequestMoney> items = new List<GExpRequestMoney>();
				GExpRequestMoney item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpRequestMoney();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_RequestAccount"] != null && dr["FK_RequestAccount"] != DBNull.Value)
					{
						item.FK_RequestAccount = Convert.ToString(dr["FK_RequestAccount"]);
					}
					if (dr["FK_PostResponse"] != null && dr["FK_PostResponse"] != DBNull.Value)
					{
						item.FK_PostResponse = Convert.ToString(dr["FK_PostResponse"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToInt32(dr["SoTien"]);
					}
					if (dr["RequestCode"] != null && dr["RequestCode"] != DBNull.Value)
					{
						item.RequestCode = Convert.ToString(dr["RequestCode"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsConfirm"] != null && dr["IsConfirm"] != DBNull.Value)
					{
						item.IsConfirm = Convert.ToBoolean(dr["IsConfirm"]);
					}
					if (dr["BankAccount"] != null && dr["BankAccount"] != DBNull.Value)
					{
						item.BankAccount = Convert.ToString(dr["BankAccount"]);
					}
					if (dr["BankOwner"] != null && dr["BankOwner"] != DBNull.Value)
					{
						item.BankOwner = Convert.ToString(dr["BankOwner"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["ConfirmDate"] != null && dr["ConfirmDate"] != DBNull.Value)
					{
						item.ConfirmDate = Convert.ToDateTime(dr["ConfirmDate"]);
					}
					if (dr["ReSoTien"] != null && dr["ReSoTien"] != DBNull.Value)
					{
						item.ReSoTien = Convert.ToInt32(dr["ReSoTien"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
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

		public List<GExpRequestMoney> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpRequestMoney] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpRequestMoney] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpRequestMoney>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpRequestMoney từ Database
		/// </summary>
		public GExpRequestMoney GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpRequestMoney] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpRequestMoney item=new GExpRequestMoney();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["FK_RequestAccount"] != null && dr["FK_RequestAccount"] != DBNull.Value)
						{
							item.FK_RequestAccount = Convert.ToString(dr["FK_RequestAccount"]);
						}
						if (dr["FK_PostResponse"] != null && dr["FK_PostResponse"] != DBNull.Value)
						{
							item.FK_PostResponse = Convert.ToString(dr["FK_PostResponse"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
						{
							item.SoTien = Convert.ToInt32(dr["SoTien"]);
						}
						if (dr["RequestCode"] != null && dr["RequestCode"] != DBNull.Value)
						{
							item.RequestCode = Convert.ToString(dr["RequestCode"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsConfirm"] != null && dr["IsConfirm"] != DBNull.Value)
						{
							item.IsConfirm = Convert.ToBoolean(dr["IsConfirm"]);
						}
						if (dr["BankAccount"] != null && dr["BankAccount"] != DBNull.Value)
						{
							item.BankAccount = Convert.ToString(dr["BankAccount"]);
						}
						if (dr["BankOwner"] != null && dr["BankOwner"] != DBNull.Value)
						{
							item.BankOwner = Convert.ToString(dr["BankOwner"]);
						}
						if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
						{
							item.BankName = Convert.ToString(dr["BankName"]);
						}
						if (dr["ConfirmDate"] != null && dr["ConfirmDate"] != DBNull.Value)
						{
							item.ConfirmDate = Convert.ToDateTime(dr["ConfirmDate"]);
						}
						if (dr["ReSoTien"] != null && dr["ReSoTien"] != DBNull.Value)
						{
							item.ReSoTien = Convert.ToInt32(dr["ReSoTien"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
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
		/// Lấy một GExpRequestMoney đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpRequestMoney GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpRequestMoney] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpRequestMoney item=new GExpRequestMoney();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["FK_RequestAccount"] != null && dr["FK_RequestAccount"] != DBNull.Value)
						{
							item.FK_RequestAccount = Convert.ToString(dr["FK_RequestAccount"]);
						}
						if (dr["FK_PostResponse"] != null && dr["FK_PostResponse"] != DBNull.Value)
						{
							item.FK_PostResponse = Convert.ToString(dr["FK_PostResponse"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
						{
							item.SoTien = Convert.ToInt32(dr["SoTien"]);
						}
						if (dr["RequestCode"] != null && dr["RequestCode"] != DBNull.Value)
						{
							item.RequestCode = Convert.ToString(dr["RequestCode"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsConfirm"] != null && dr["IsConfirm"] != DBNull.Value)
						{
							item.IsConfirm = Convert.ToBoolean(dr["IsConfirm"]);
						}
						if (dr["BankAccount"] != null && dr["BankAccount"] != DBNull.Value)
						{
							item.BankAccount = Convert.ToString(dr["BankAccount"]);
						}
						if (dr["BankOwner"] != null && dr["BankOwner"] != DBNull.Value)
						{
							item.BankOwner = Convert.ToString(dr["BankOwner"]);
						}
						if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
						{
							item.BankName = Convert.ToString(dr["BankName"]);
						}
						if (dr["ConfirmDate"] != null && dr["ConfirmDate"] != DBNull.Value)
						{
							item.ConfirmDate = Convert.ToDateTime(dr["ConfirmDate"]);
						}
						if (dr["ReSoTien"] != null && dr["ReSoTien"] != DBNull.Value)
						{
							item.ReSoTien = Convert.ToInt32(dr["ReSoTien"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
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

		public GExpRequestMoney GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpRequestMoney] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpRequestMoney>(ds);
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
		/// Thêm mới GExpRequestMoney vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpRequestMoney _GExpRequestMoney)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpRequestMoney](Id, FK_Post, FK_RequestAccount, FK_PostResponse, CreateDate, SoTien, RequestCode, Note, IsConfirm, BankAccount, BankOwner, BankName, ConfirmDate, ReSoTien, FK_Account) VALUES(@Id, @FK_Post, @FK_RequestAccount, @FK_PostResponse, @CreateDate, @SoTien, @RequestCode, @Note, @IsConfirm, @BankAccount, @BankOwner, @BankName, @ConfirmDate, @ReSoTien, @FK_Account)", 
					"@Id",  _GExpRequestMoney.Id, 
					"@FK_Post",  _GExpRequestMoney.FK_Post, 
					"@FK_RequestAccount",  _GExpRequestMoney.FK_RequestAccount, 
					"@FK_PostResponse",  _GExpRequestMoney.FK_PostResponse, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpRequestMoney.CreateDate), 
					"@SoTien",  _GExpRequestMoney.SoTien, 
					"@RequestCode",  _GExpRequestMoney.RequestCode, 
					"@Note",  _GExpRequestMoney.Note, 
					"@IsConfirm",  _GExpRequestMoney.IsConfirm, 
					"@BankAccount",  _GExpRequestMoney.BankAccount, 
					"@BankOwner",  _GExpRequestMoney.BankOwner, 
					"@BankName",  _GExpRequestMoney.BankName, 
					"@ConfirmDate", this._dataContext.ConvertDateString( _GExpRequestMoney.ConfirmDate), 
					"@ReSoTien",  _GExpRequestMoney.ReSoTien, 
					"@FK_Account",  _GExpRequestMoney.FK_Account);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpRequestMoney vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpRequestMoney> _GExpRequestMoneys)
		{
			foreach (GExpRequestMoney item in _GExpRequestMoneys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpRequestMoney vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpRequestMoney _GExpRequestMoney, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpRequestMoney] SET Id=@Id, FK_Post=@FK_Post, FK_RequestAccount=@FK_RequestAccount, FK_PostResponse=@FK_PostResponse, CreateDate=@CreateDate, SoTien=@SoTien, RequestCode=@RequestCode, Note=@Note, IsConfirm=@IsConfirm, BankAccount=@BankAccount, BankOwner=@BankOwner, BankName=@BankName, ConfirmDate=@ConfirmDate, ReSoTien=@ReSoTien, FK_Account=@FK_Account WHERE Id=@Id", 
					"@Id",  _GExpRequestMoney.Id, 
					"@FK_Post",  _GExpRequestMoney.FK_Post, 
					"@FK_RequestAccount",  _GExpRequestMoney.FK_RequestAccount, 
					"@FK_PostResponse",  _GExpRequestMoney.FK_PostResponse, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpRequestMoney.CreateDate), 
					"@SoTien",  _GExpRequestMoney.SoTien, 
					"@RequestCode",  _GExpRequestMoney.RequestCode, 
					"@Note",  _GExpRequestMoney.Note, 
					"@IsConfirm",  _GExpRequestMoney.IsConfirm, 
					"@BankAccount",  _GExpRequestMoney.BankAccount, 
					"@BankOwner",  _GExpRequestMoney.BankOwner, 
					"@BankName",  _GExpRequestMoney.BankName, 
					"@ConfirmDate", this._dataContext.ConvertDateString( _GExpRequestMoney.ConfirmDate), 
					"@ReSoTien",  _GExpRequestMoney.ReSoTien, 
					"@FK_Account",  _GExpRequestMoney.FK_Account, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpRequestMoney vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpRequestMoney _GExpRequestMoney)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpRequestMoney] SET FK_Post=@FK_Post, FK_RequestAccount=@FK_RequestAccount, FK_PostResponse=@FK_PostResponse, CreateDate=@CreateDate, SoTien=@SoTien, RequestCode=@RequestCode, Note=@Note, IsConfirm=@IsConfirm, BankAccount=@BankAccount, BankOwner=@BankOwner, BankName=@BankName, ConfirmDate=@ConfirmDate, ReSoTien=@ReSoTien, FK_Account=@FK_Account WHERE Id=@Id", 
					"@FK_Post",  _GExpRequestMoney.FK_Post, 
					"@FK_RequestAccount",  _GExpRequestMoney.FK_RequestAccount, 
					"@FK_PostResponse",  _GExpRequestMoney.FK_PostResponse, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpRequestMoney.CreateDate), 
					"@SoTien",  _GExpRequestMoney.SoTien, 
					"@RequestCode",  _GExpRequestMoney.RequestCode, 
					"@Note",  _GExpRequestMoney.Note, 
					"@IsConfirm",  _GExpRequestMoney.IsConfirm, 
					"@BankAccount",  _GExpRequestMoney.BankAccount, 
					"@BankOwner",  _GExpRequestMoney.BankOwner, 
					"@BankName",  _GExpRequestMoney.BankName, 
					"@ConfirmDate", this._dataContext.ConvertDateString( _GExpRequestMoney.ConfirmDate), 
					"@ReSoTien",  _GExpRequestMoney.ReSoTien, 
					"@FK_Account",  _GExpRequestMoney.FK_Account, 
					"@Id", _GExpRequestMoney.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpRequestMoney vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpRequestMoney> _GExpRequestMoneys)
		{
			foreach (GExpRequestMoney item in _GExpRequestMoneys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpRequestMoney vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpRequestMoney _GExpRequestMoney, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpRequestMoney] SET Id=@Id, FK_Post=@FK_Post, FK_RequestAccount=@FK_RequestAccount, FK_PostResponse=@FK_PostResponse, CreateDate=@CreateDate, SoTien=@SoTien, RequestCode=@RequestCode, Note=@Note, IsConfirm=@IsConfirm, BankAccount=@BankAccount, BankOwner=@BankOwner, BankName=@BankName, ConfirmDate=@ConfirmDate, ReSoTien=@ReSoTien, FK_Account=@FK_Account "+ condition, 
					"@Id",  _GExpRequestMoney.Id, 
					"@FK_Post",  _GExpRequestMoney.FK_Post, 
					"@FK_RequestAccount",  _GExpRequestMoney.FK_RequestAccount, 
					"@FK_PostResponse",  _GExpRequestMoney.FK_PostResponse, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpRequestMoney.CreateDate), 
					"@SoTien",  _GExpRequestMoney.SoTien, 
					"@RequestCode",  _GExpRequestMoney.RequestCode, 
					"@Note",  _GExpRequestMoney.Note, 
					"@IsConfirm",  _GExpRequestMoney.IsConfirm, 
					"@BankAccount",  _GExpRequestMoney.BankAccount, 
					"@BankOwner",  _GExpRequestMoney.BankOwner, 
					"@BankName",  _GExpRequestMoney.BankName, 
					"@ConfirmDate", this._dataContext.ConvertDateString( _GExpRequestMoney.ConfirmDate), 
					"@ReSoTien",  _GExpRequestMoney.ReSoTien, 
					"@FK_Account",  _GExpRequestMoney.FK_Account);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpRequestMoney trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpRequestMoney] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpRequestMoney trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpRequestMoney _GExpRequestMoney)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpRequestMoney] WHERE Id=@Id",
					"@Id", _GExpRequestMoney.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpRequestMoney trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpRequestMoney] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpRequestMoney trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpRequestMoney> _GExpRequestMoneys)
		{
			foreach (GExpRequestMoney item in _GExpRequestMoneys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
