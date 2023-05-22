using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpshipper:IGExpshipper
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpshipper(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpShipper từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipper]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipper] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpShipper từ Database
		/// </summary>
		public List<GExpShipper> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipper]");
				List<GExpShipper> items = new List<GExpShipper>();
				GExpShipper item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipper();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
					}
					if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
					{
						item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
					{
						item.UserName = Convert.ToString(dr["UserName"]);
					}
					if (dr["Password"] != null && dr["Password"] != DBNull.Value)
					{
						item.Password = Convert.ToString(dr["Password"]);
					}
					if (dr["BalanceValue"] != null && dr["BalanceValue"] != DBNull.Value)
					{
						item.BalanceValue = Convert.ToInt32(dr["BalanceValue"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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
		/// Lấy danh sách GExpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpShipper> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipper] A "+ condition,  parameters);
				List<GExpShipper> items = new List<GExpShipper>();
				GExpShipper item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipper();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
					}
					if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
					{
						item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
					{
						item.UserName = Convert.ToString(dr["UserName"]);
					}
					if (dr["Password"] != null && dr["Password"] != DBNull.Value)
					{
						item.Password = Convert.ToString(dr["Password"]);
					}
					if (dr["BalanceValue"] != null && dr["BalanceValue"] != DBNull.Value)
					{
						item.BalanceValue = Convert.ToInt32(dr["BalanceValue"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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

		public List<GExpShipper> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipper] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpShipper] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpShipper>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpShipper từ Database
		/// </summary>
		public GExpShipper GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipper] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpShipper item=new GExpShipper();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
						{
							item.ShipperName = Convert.ToString(dr["ShipperName"]);
						}
						if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
						{
							item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
						{
							item.UserName = Convert.ToString(dr["UserName"]);
						}
						if (dr["Password"] != null && dr["Password"] != DBNull.Value)
						{
							item.Password = Convert.ToString(dr["Password"]);
						}
						if (dr["BalanceValue"] != null && dr["BalanceValue"] != DBNull.Value)
						{
							item.BalanceValue = Convert.ToInt32(dr["BalanceValue"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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
		/// Lấy một GExpShipper đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpShipper GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipper] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpShipper item=new GExpShipper();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
						{
							item.ShipperName = Convert.ToString(dr["ShipperName"]);
						}
						if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
						{
							item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["UserName"] != null && dr["UserName"] != DBNull.Value)
						{
							item.UserName = Convert.ToString(dr["UserName"]);
						}
						if (dr["Password"] != null && dr["Password"] != DBNull.Value)
						{
							item.Password = Convert.ToString(dr["Password"]);
						}
						if (dr["BalanceValue"] != null && dr["BalanceValue"] != DBNull.Value)
						{
							item.BalanceValue = Convert.ToInt32(dr["BalanceValue"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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

		public GExpShipper GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipper] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpShipper>(ds);
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
		/// Thêm mới GExpShipper vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpShipper _GExpShipper)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpShipper](Id, ShipperName, ShipperPhone, FK_Post, UserName, Password, BalanceValue, IsDelete) VALUES(@Id, @ShipperName, @ShipperPhone, @FK_Post, @UserName, @Password, @BalanceValue, @IsDelete)", 
					"@Id",  _GExpShipper.Id, 
					"@ShipperName",  _GExpShipper.ShipperName, 
					"@ShipperPhone",  _GExpShipper.ShipperPhone, 
					"@FK_Post",  _GExpShipper.FK_Post, 
					"@UserName",  _GExpShipper.UserName, 
					"@Password",  _GExpShipper.Password, 
					"@BalanceValue",  _GExpShipper.BalanceValue, 
					"@IsDelete",  _GExpShipper.IsDelete);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpShipper vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpShipper> _GExpShippers)
		{
			foreach (GExpShipper item in _GExpShippers)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipper vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpShipper _GExpShipper, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipper] SET Id=@Id, ShipperName=@ShipperName, ShipperPhone=@ShipperPhone, FK_Post=@FK_Post, UserName=@UserName, Password=@Password, BalanceValue=@BalanceValue, IsDelete=@IsDelete WHERE Id=@Id", 
					"@Id",  _GExpShipper.Id, 
					"@ShipperName",  _GExpShipper.ShipperName, 
					"@ShipperPhone",  _GExpShipper.ShipperPhone, 
					"@FK_Post",  _GExpShipper.FK_Post, 
					"@UserName",  _GExpShipper.UserName, 
					"@Password",  _GExpShipper.Password, 
					"@BalanceValue",  _GExpShipper.BalanceValue, 
					"@IsDelete",  _GExpShipper.IsDelete, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpShipper vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpShipper _GExpShipper)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipper] SET ShipperName=@ShipperName, ShipperPhone=@ShipperPhone, FK_Post=@FK_Post, UserName=@UserName, Password=@Password, BalanceValue=@BalanceValue, IsDelete=@IsDelete WHERE Id=@Id", 
					"@ShipperName",  _GExpShipper.ShipperName, 
					"@ShipperPhone",  _GExpShipper.ShipperPhone, 
					"@FK_Post",  _GExpShipper.FK_Post, 
					"@UserName",  _GExpShipper.UserName, 
					"@Password",  _GExpShipper.Password, 
					"@BalanceValue",  _GExpShipper.BalanceValue, 
					"@IsDelete",  _GExpShipper.IsDelete, 
					"@Id", _GExpShipper.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpShipper vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpShipper> _GExpShippers)
		{
			foreach (GExpShipper item in _GExpShippers)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipper vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpShipper _GExpShipper, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipper] SET Id=@Id, ShipperName=@ShipperName, ShipperPhone=@ShipperPhone, FK_Post=@FK_Post, UserName=@UserName, Password=@Password, BalanceValue=@BalanceValue, IsDelete=@IsDelete "+ condition, 
					"@Id",  _GExpShipper.Id, 
					"@ShipperName",  _GExpShipper.ShipperName, 
					"@ShipperPhone",  _GExpShipper.ShipperPhone, 
					"@FK_Post",  _GExpShipper.FK_Post, 
					"@UserName",  _GExpShipper.UserName, 
					"@Password",  _GExpShipper.Password, 
					"@BalanceValue",  _GExpShipper.BalanceValue, 
					"@IsDelete",  _GExpShipper.IsDelete);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpShipper trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipper] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipper trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpShipper _GExpShipper)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipper] WHERE Id=@Id",
					"@Id", _GExpShipper.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipper trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipper] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipper trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpShipper> _GExpShippers)
		{
			foreach (GExpShipper item in _GExpShippers)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
