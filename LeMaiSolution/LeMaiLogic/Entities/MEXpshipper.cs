using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpshipper:IEXpshipper
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpshipper(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpShipper từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpShipper]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpShipper] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpShipper từ Database
		/// </summary>
		public List<ExpShipper> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpShipper]");
				List<ExpShipper> items = new List<ExpShipper>();
				ExpShipper item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpShipper();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["Shipper"] != null && dr["Shipper"] != DBNull.Value)
					{
						item.Shipper = Convert.ToString(dr["Shipper"]);
					}
					if (dr["PayDate"] != null && dr["PayDate"] != DBNull.Value)
					{
						item.PayDate = Convert.ToDateTime(dr["PayDate"]);
					}
					if (dr["RequestMoney"] != null && dr["RequestMoney"] != DBNull.Value)
					{
						item.RequestMoney = Convert.ToDecimal(dr["RequestMoney"]);
					}
					if (dr["RealPay"] != null && dr["RealPay"] != DBNull.Value)
					{
						item.RealPay = Convert.ToDecimal(dr["RealPay"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
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
		/// Lấy danh sách ExpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpShipper> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpShipper] A "+ condition,  parameters);
				List<ExpShipper> items = new List<ExpShipper>();
				ExpShipper item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpShipper();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["Shipper"] != null && dr["Shipper"] != DBNull.Value)
					{
						item.Shipper = Convert.ToString(dr["Shipper"]);
					}
					if (dr["PayDate"] != null && dr["PayDate"] != DBNull.Value)
					{
						item.PayDate = Convert.ToDateTime(dr["PayDate"]);
					}
					if (dr["RequestMoney"] != null && dr["RequestMoney"] != DBNull.Value)
					{
						item.RequestMoney = Convert.ToDecimal(dr["RequestMoney"]);
					}
					if (dr["RealPay"] != null && dr["RealPay"] != DBNull.Value)
					{
						item.RealPay = Convert.ToDecimal(dr["RealPay"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
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

		public List<ExpShipper> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpShipper] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpShipper] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpShipper>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpShipper từ Database
		/// </summary>
		public ExpShipper GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpShipper] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpShipper item=new ExpShipper();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["Shipper"] != null && dr["Shipper"] != DBNull.Value)
						{
							item.Shipper = Convert.ToString(dr["Shipper"]);
						}
						if (dr["PayDate"] != null && dr["PayDate"] != DBNull.Value)
						{
							item.PayDate = Convert.ToDateTime(dr["PayDate"]);
						}
						if (dr["RequestMoney"] != null && dr["RequestMoney"] != DBNull.Value)
						{
							item.RequestMoney = Convert.ToDecimal(dr["RequestMoney"]);
						}
						if (dr["RealPay"] != null && dr["RealPay"] != DBNull.Value)
						{
							item.RealPay = Convert.ToDecimal(dr["RealPay"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
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
		/// Lấy một ExpShipper đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpShipper GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpShipper] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpShipper item=new ExpShipper();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["Shipper"] != null && dr["Shipper"] != DBNull.Value)
						{
							item.Shipper = Convert.ToString(dr["Shipper"]);
						}
						if (dr["PayDate"] != null && dr["PayDate"] != DBNull.Value)
						{
							item.PayDate = Convert.ToDateTime(dr["PayDate"]);
						}
						if (dr["RequestMoney"] != null && dr["RequestMoney"] != DBNull.Value)
						{
							item.RequestMoney = Convert.ToDecimal(dr["RequestMoney"]);
						}
						if (dr["RealPay"] != null && dr["RealPay"] != DBNull.Value)
						{
							item.RealPay = Convert.ToDecimal(dr["RealPay"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
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

		public ExpShipper GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpShipper] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpShipper>(ds);
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
		/// Thêm mới ExpShipper vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpShipper _ExpShipper)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpShipper](Id, BillCode, Shipper, PayDate, RequestMoney, RealPay, Note) VALUES(@Id, @BillCode, @Shipper, @PayDate, @RequestMoney, @RealPay, @Note)", 
					"@Id",  _ExpShipper.Id, 
					"@BillCode",  _ExpShipper.BillCode, 
					"@Shipper",  _ExpShipper.Shipper, 
					"@PayDate", this._dataContext.ConvertDateString( _ExpShipper.PayDate), 
					"@RequestMoney",  _ExpShipper.RequestMoney, 
					"@RealPay",  _ExpShipper.RealPay, 
					"@Note",  _ExpShipper.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpShipper vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpShipper> _ExpShippers)
		{
			foreach (ExpShipper item in _ExpShippers)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpShipper vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpShipper _ExpShipper, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpShipper] SET Id=@Id, BillCode=@BillCode, Shipper=@Shipper, PayDate=@PayDate, RequestMoney=@RequestMoney, RealPay=@RealPay, Note=@Note WHERE Id=@Id", 
					"@Id",  _ExpShipper.Id, 
					"@BillCode",  _ExpShipper.BillCode, 
					"@Shipper",  _ExpShipper.Shipper, 
					"@PayDate", this._dataContext.ConvertDateString( _ExpShipper.PayDate), 
					"@RequestMoney",  _ExpShipper.RequestMoney, 
					"@RealPay",  _ExpShipper.RealPay, 
					"@Note",  _ExpShipper.Note, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpShipper vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpShipper _ExpShipper)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpShipper] SET BillCode=@BillCode, Shipper=@Shipper, PayDate=@PayDate, RequestMoney=@RequestMoney, RealPay=@RealPay, Note=@Note WHERE Id=@Id", 
					"@BillCode",  _ExpShipper.BillCode, 
					"@Shipper",  _ExpShipper.Shipper, 
					"@PayDate", this._dataContext.ConvertDateString( _ExpShipper.PayDate), 
					"@RequestMoney",  _ExpShipper.RequestMoney, 
					"@RealPay",  _ExpShipper.RealPay, 
					"@Note",  _ExpShipper.Note, 
					"@Id", _ExpShipper.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpShipper vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpShipper> _ExpShippers)
		{
			foreach (ExpShipper item in _ExpShippers)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpShipper vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpShipper _ExpShipper, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpShipper] SET Id=@Id, BillCode=@BillCode, Shipper=@Shipper, PayDate=@PayDate, RequestMoney=@RequestMoney, RealPay=@RealPay, Note=@Note "+ condition, 
					"@Id",  _ExpShipper.Id, 
					"@BillCode",  _ExpShipper.BillCode, 
					"@Shipper",  _ExpShipper.Shipper, 
					"@PayDate", this._dataContext.ConvertDateString( _ExpShipper.PayDate), 
					"@RequestMoney",  _ExpShipper.RequestMoney, 
					"@RealPay",  _ExpShipper.RealPay, 
					"@Note",  _ExpShipper.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpShipper trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpShipper] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpShipper trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpShipper _ExpShipper)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpShipper] WHERE Id=@Id",
					"@Id", _ExpShipper.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpShipper trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpShipper] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpShipper trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpShipper> _ExpShippers)
		{
			foreach (ExpShipper item in _ExpShippers)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
