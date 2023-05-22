using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpbillstatusname:IGExpbillstatusname
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpbillstatusname(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpBillStatusName từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillStatusName]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpBillStatusName từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillStatusName] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpBillStatusName từ Database
		/// </summary>
		public List<GExpBillStatusName> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillStatusName]");
				List<GExpBillStatusName> items = new List<GExpBillStatusName>();
				GExpBillStatusName item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBillStatusName();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
					{
						item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["UpdateStatus"] != null && dr["UpdateStatus"] != DBNull.Value)
					{
						item.UpdateStatus = Convert.ToBoolean(dr["UpdateStatus"]);
					}
					if (dr["ScanType"] != null && dr["ScanType"] != DBNull.Value)
					{
						item.ScanType = Convert.ToString(dr["ScanType"]);
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
		/// Lấy danh sách GExpBillStatusName từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpBillStatusName> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBillStatusName] A "+ condition,  parameters);
				List<GExpBillStatusName> items = new List<GExpBillStatusName>();
				GExpBillStatusName item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBillStatusName();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
					{
						item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["UpdateStatus"] != null && dr["UpdateStatus"] != DBNull.Value)
					{
						item.UpdateStatus = Convert.ToBoolean(dr["UpdateStatus"]);
					}
					if (dr["ScanType"] != null && dr["ScanType"] != DBNull.Value)
					{
						item.ScanType = Convert.ToString(dr["ScanType"]);
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

		public List<GExpBillStatusName> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBillStatusName] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpBillStatusName] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpBillStatusName>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpBillStatusName từ Database
		/// </summary>
		public GExpBillStatusName GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillStatusName] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpBillStatusName item=new GExpBillStatusName();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
						{
							item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["UpdateStatus"] != null && dr["UpdateStatus"] != DBNull.Value)
						{
							item.UpdateStatus = Convert.ToBoolean(dr["UpdateStatus"]);
						}
						if (dr["ScanType"] != null && dr["ScanType"] != DBNull.Value)
						{
							item.ScanType = Convert.ToString(dr["ScanType"]);
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
		/// Lấy một GExpBillStatusName đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpBillStatusName GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBillStatusName] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpBillStatusName item=new GExpBillStatusName();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
						{
							item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["UpdateStatus"] != null && dr["UpdateStatus"] != DBNull.Value)
						{
							item.UpdateStatus = Convert.ToBoolean(dr["UpdateStatus"]);
						}
						if (dr["ScanType"] != null && dr["ScanType"] != DBNull.Value)
						{
							item.ScanType = Convert.ToString(dr["ScanType"]);
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

		public GExpBillStatusName GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBillStatusName] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpBillStatusName>(ds);
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
		/// Thêm mới GExpBillStatusName vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpBillStatusName _GExpBillStatusName)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpBillStatusName](Id, StatusName, BillStatus, Note, UpdateStatus, ScanType) VALUES(@Id, @StatusName, @BillStatus, @Note, @UpdateStatus, @ScanType)", 
					"@Id",  _GExpBillStatusName.Id, 
					"@StatusName",  _GExpBillStatusName.StatusName, 
					"@BillStatus",  _GExpBillStatusName.BillStatus, 
					"@Note",  _GExpBillStatusName.Note, 
					"@UpdateStatus",  _GExpBillStatusName.UpdateStatus, 
					"@ScanType",  _GExpBillStatusName.ScanType);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpBillStatusName vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpBillStatusName> _GExpBillStatusNames)
		{
			foreach (GExpBillStatusName item in _GExpBillStatusNames)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBillStatusName vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpBillStatusName _GExpBillStatusName, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBillStatusName] SET Id=@Id, StatusName=@StatusName, BillStatus=@BillStatus, Note=@Note, UpdateStatus=@UpdateStatus, ScanType=@ScanType WHERE Id=@Id", 
					"@Id",  _GExpBillStatusName.Id, 
					"@StatusName",  _GExpBillStatusName.StatusName, 
					"@BillStatus",  _GExpBillStatusName.BillStatus, 
					"@Note",  _GExpBillStatusName.Note, 
					"@UpdateStatus",  _GExpBillStatusName.UpdateStatus, 
					"@ScanType",  _GExpBillStatusName.ScanType, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpBillStatusName vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpBillStatusName _GExpBillStatusName)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBillStatusName] SET StatusName=@StatusName, BillStatus=@BillStatus, Note=@Note, UpdateStatus=@UpdateStatus, ScanType=@ScanType WHERE Id=@Id", 
					"@StatusName",  _GExpBillStatusName.StatusName, 
					"@BillStatus",  _GExpBillStatusName.BillStatus, 
					"@Note",  _GExpBillStatusName.Note, 
					"@UpdateStatus",  _GExpBillStatusName.UpdateStatus, 
					"@ScanType",  _GExpBillStatusName.ScanType, 
					"@Id", _GExpBillStatusName.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpBillStatusName vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpBillStatusName> _GExpBillStatusNames)
		{
			foreach (GExpBillStatusName item in _GExpBillStatusNames)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBillStatusName vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpBillStatusName _GExpBillStatusName, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBillStatusName] SET Id=@Id, StatusName=@StatusName, BillStatus=@BillStatus, Note=@Note, UpdateStatus=@UpdateStatus, ScanType=@ScanType "+ condition, 
					"@Id",  _GExpBillStatusName.Id, 
					"@StatusName",  _GExpBillStatusName.StatusName, 
					"@BillStatus",  _GExpBillStatusName.BillStatus, 
					"@Note",  _GExpBillStatusName.Note, 
					"@UpdateStatus",  _GExpBillStatusName.UpdateStatus, 
					"@ScanType",  _GExpBillStatusName.ScanType);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpBillStatusName trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBillStatusName] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBillStatusName trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpBillStatusName _GExpBillStatusName)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBillStatusName] WHERE Id=@Id",
					"@Id", _GExpBillStatusName.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBillStatusName trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBillStatusName] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBillStatusName trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpBillStatusName> _GExpBillStatusNames)
		{
			foreach (GExpBillStatusName item in _GExpBillStatusNames)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
