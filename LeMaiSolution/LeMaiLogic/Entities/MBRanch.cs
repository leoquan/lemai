using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MBRanch:IBRanch
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MBRanch(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable Branch từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Branch]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable Branch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Branch] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách Branch từ Database
		/// </summary>
		public List<Branch> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Branch]");
				List<Branch> items = new List<Branch>();
				Branch item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Branch();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["TaxCode"] != null && dr["TaxCode"] != DBNull.Value)
					{
						item.TaxCode = Convert.ToString(dr["TaxCode"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
					{
						item.BankCode = Convert.ToString(dr["BankCode"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["BankOwner"] != null && dr["BankOwner"] != DBNull.Value)
					{
						item.BankOwner = Convert.ToString(dr["BankOwner"]);
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
		/// Lấy danh sách Branch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<Branch> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Branch] A "+ condition,  parameters);
				List<Branch> items = new List<Branch>();
				Branch item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Branch();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["TaxCode"] != null && dr["TaxCode"] != DBNull.Value)
					{
						item.TaxCode = Convert.ToString(dr["TaxCode"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
					{
						item.BankCode = Convert.ToString(dr["BankCode"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["BankOwner"] != null && dr["BankOwner"] != DBNull.Value)
					{
						item.BankOwner = Convert.ToString(dr["BankOwner"]);
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

		public List<Branch> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Branch] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[Branch] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<Branch>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một Branch từ Database
		/// </summary>
		public Branch GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Branch] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					Branch item=new Branch();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
						{
							item.BranchName = Convert.ToString(dr["BranchName"]);
						}
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["TaxCode"] != null && dr["TaxCode"] != DBNull.Value)
						{
							item.TaxCode = Convert.ToString(dr["TaxCode"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
						{
							item.BankCode = Convert.ToString(dr["BankCode"]);
						}
						if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
						{
							item.BankName = Convert.ToString(dr["BankName"]);
						}
						if (dr["BankOwner"] != null && dr["BankOwner"] != DBNull.Value)
						{
							item.BankOwner = Convert.ToString(dr["BankOwner"]);
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
		/// Lấy một Branch đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public Branch GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Branch] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					Branch item=new Branch();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
						{
							item.BranchName = Convert.ToString(dr["BranchName"]);
						}
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["TaxCode"] != null && dr["TaxCode"] != DBNull.Value)
						{
							item.TaxCode = Convert.ToString(dr["TaxCode"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["BankCode"] != null && dr["BankCode"] != DBNull.Value)
						{
							item.BankCode = Convert.ToString(dr["BankCode"]);
						}
						if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
						{
							item.BankName = Convert.ToString(dr["BankName"]);
						}
						if (dr["BankOwner"] != null && dr["BankOwner"] != DBNull.Value)
						{
							item.BankOwner = Convert.ToString(dr["BankOwner"]);
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

		public Branch GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Branch] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<Branch>(ds);
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
		/// Thêm mới Branch vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, Branch _Branch)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[Branch](Id, BranchName, Address, TaxCode, Phone, Email, IsDelete, ImagePath, BankCode, BankName, BankOwner) VALUES(@Id, @BranchName, @Address, @TaxCode, @Phone, @Email, @IsDelete, @ImagePath, @BankCode, @BankName, @BankOwner)", 
					"@Id",  _Branch.Id, 
					"@BranchName",  _Branch.BranchName, 
					"@Address",  _Branch.Address, 
					"@TaxCode",  _Branch.TaxCode, 
					"@Phone",  _Branch.Phone, 
					"@Email",  _Branch.Email, 
					"@IsDelete",  _Branch.IsDelete, 
					"@ImagePath",  _Branch.ImagePath, 
					"@BankCode",  _Branch.BankCode, 
					"@BankName",  _Branch.BankName, 
					"@BankOwner",  _Branch.BankOwner);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng Branch vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<Branch> _Branchs)
		{
			foreach (Branch item in _Branchs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Branch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, Branch _Branch, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Branch] SET Id=@Id, BranchName=@BranchName, Address=@Address, TaxCode=@TaxCode, Phone=@Phone, Email=@Email, IsDelete=@IsDelete, ImagePath=@ImagePath, BankCode=@BankCode, BankName=@BankName, BankOwner=@BankOwner WHERE Id=@Id", 
					"@Id",  _Branch.Id, 
					"@BranchName",  _Branch.BranchName, 
					"@Address",  _Branch.Address, 
					"@TaxCode",  _Branch.TaxCode, 
					"@Phone",  _Branch.Phone, 
					"@Email",  _Branch.Email, 
					"@IsDelete",  _Branch.IsDelete, 
					"@ImagePath",  _Branch.ImagePath, 
					"@BankCode",  _Branch.BankCode, 
					"@BankName",  _Branch.BankName, 
					"@BankOwner",  _Branch.BankOwner, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật Branch vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, Branch _Branch)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Branch] SET BranchName=@BranchName, Address=@Address, TaxCode=@TaxCode, Phone=@Phone, Email=@Email, IsDelete=@IsDelete, ImagePath=@ImagePath, BankCode=@BankCode, BankName=@BankName, BankOwner=@BankOwner WHERE Id=@Id", 
					"@BranchName",  _Branch.BranchName, 
					"@Address",  _Branch.Address, 
					"@TaxCode",  _Branch.TaxCode, 
					"@Phone",  _Branch.Phone, 
					"@Email",  _Branch.Email, 
					"@IsDelete",  _Branch.IsDelete, 
					"@ImagePath",  _Branch.ImagePath, 
					"@BankCode",  _Branch.BankCode, 
					"@BankName",  _Branch.BankName, 
					"@BankOwner",  _Branch.BankOwner, 
					"@Id", _Branch.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách Branch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<Branch> _Branchs)
		{
			foreach (Branch item in _Branchs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Branch vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, Branch _Branch, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Branch] SET Id=@Id, BranchName=@BranchName, Address=@Address, TaxCode=@TaxCode, Phone=@Phone, Email=@Email, IsDelete=@IsDelete, ImagePath=@ImagePath, BankCode=@BankCode, BankName=@BankName, BankOwner=@BankOwner "+ condition, 
					"@Id",  _Branch.Id, 
					"@BranchName",  _Branch.BranchName, 
					"@Address",  _Branch.Address, 
					"@TaxCode",  _Branch.TaxCode, 
					"@Phone",  _Branch.Phone, 
					"@Email",  _Branch.Email, 
					"@IsDelete",  _Branch.IsDelete, 
					"@ImagePath",  _Branch.ImagePath, 
					"@BankCode",  _Branch.BankCode, 
					"@BankName",  _Branch.BankName, 
					"@BankOwner",  _Branch.BankOwner);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa Branch trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Branch] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Branch trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Branch _Branch)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Branch] WHERE Id=@Id",
					"@Id", _Branch.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Branch trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Branch] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Branch trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<Branch> _Branchs)
		{
			foreach (Branch item in _Branchs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
