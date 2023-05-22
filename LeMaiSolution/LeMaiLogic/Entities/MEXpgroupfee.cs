using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpgroupfee:IEXpgroupfee
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpgroupfee(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpGroupFee từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpGroupFee]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpGroupFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpGroupFee] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpGroupFee từ Database
		/// </summary>
		public List<ExpGroupFee> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpGroupFee]");
				List<ExpGroupFee> items = new List<ExpGroupFee>();
				ExpGroupFee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpGroupFee();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
					{
						item.Ten = Convert.ToString(dr["Ten"]);
					}
					if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
					{
						item.KeyWord = Convert.ToString(dr["KeyWord"]);
					}
					if (dr["GroupFeeVal"] != null && dr["GroupFeeVal"] != DBNull.Value)
					{
						item.GroupFeeVal = Convert.ToInt32(dr["GroupFeeVal"]);
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
		/// Lấy danh sách ExpGroupFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpGroupFee> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpGroupFee] A "+ condition,  parameters);
				List<ExpGroupFee> items = new List<ExpGroupFee>();
				ExpGroupFee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpGroupFee();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
					{
						item.Ten = Convert.ToString(dr["Ten"]);
					}
					if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
					{
						item.KeyWord = Convert.ToString(dr["KeyWord"]);
					}
					if (dr["GroupFeeVal"] != null && dr["GroupFeeVal"] != DBNull.Value)
					{
						item.GroupFeeVal = Convert.ToInt32(dr["GroupFeeVal"]);
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

		public List<ExpGroupFee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpGroupFee] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpGroupFee] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpGroupFee>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpGroupFee từ Database
		/// </summary>
		public ExpGroupFee GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpGroupFee] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpGroupFee item=new ExpGroupFee();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
						{
							item.Ten = Convert.ToString(dr["Ten"]);
						}
						if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
						{
							item.KeyWord = Convert.ToString(dr["KeyWord"]);
						}
						if (dr["GroupFeeVal"] != null && dr["GroupFeeVal"] != DBNull.Value)
						{
							item.GroupFeeVal = Convert.ToInt32(dr["GroupFeeVal"]);
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
		/// Lấy một ExpGroupFee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpGroupFee GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpGroupFee] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpGroupFee item=new ExpGroupFee();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Ten"] != null && dr["Ten"] != DBNull.Value)
						{
							item.Ten = Convert.ToString(dr["Ten"]);
						}
						if (dr["KeyWord"] != null && dr["KeyWord"] != DBNull.Value)
						{
							item.KeyWord = Convert.ToString(dr["KeyWord"]);
						}
						if (dr["GroupFeeVal"] != null && dr["GroupFeeVal"] != DBNull.Value)
						{
							item.GroupFeeVal = Convert.ToInt32(dr["GroupFeeVal"]);
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

		public ExpGroupFee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpGroupFee] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpGroupFee>(ds);
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
		/// Thêm mới ExpGroupFee vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpGroupFee _ExpGroupFee)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpGroupFee](Id, Ten, KeyWord, GroupFeeVal) VALUES(@Id, @Ten, @KeyWord, @GroupFeeVal)", 
					"@Id",  _ExpGroupFee.Id, 
					"@Ten",  _ExpGroupFee.Ten, 
					"@KeyWord",  _ExpGroupFee.KeyWord, 
					"@GroupFeeVal",  _ExpGroupFee.GroupFeeVal);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpGroupFee vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpGroupFee> _ExpGroupFees)
		{
			foreach (ExpGroupFee item in _ExpGroupFees)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpGroupFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpGroupFee _ExpGroupFee, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpGroupFee] SET Id=@Id, Ten=@Ten, KeyWord=@KeyWord, GroupFeeVal=@GroupFeeVal WHERE Id=@Id", 
					"@Id",  _ExpGroupFee.Id, 
					"@Ten",  _ExpGroupFee.Ten, 
					"@KeyWord",  _ExpGroupFee.KeyWord, 
					"@GroupFeeVal",  _ExpGroupFee.GroupFeeVal, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpGroupFee vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpGroupFee _ExpGroupFee)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpGroupFee] SET Ten=@Ten, KeyWord=@KeyWord, GroupFeeVal=@GroupFeeVal WHERE Id=@Id", 
					"@Ten",  _ExpGroupFee.Ten, 
					"@KeyWord",  _ExpGroupFee.KeyWord, 
					"@GroupFeeVal",  _ExpGroupFee.GroupFeeVal, 
					"@Id", _ExpGroupFee.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpGroupFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpGroupFee> _ExpGroupFees)
		{
			foreach (ExpGroupFee item in _ExpGroupFees)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpGroupFee vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpGroupFee _ExpGroupFee, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpGroupFee] SET Id=@Id, Ten=@Ten, KeyWord=@KeyWord, GroupFeeVal=@GroupFeeVal "+ condition, 
					"@Id",  _ExpGroupFee.Id, 
					"@Ten",  _ExpGroupFee.Ten, 
					"@KeyWord",  _ExpGroupFee.KeyWord, 
					"@GroupFeeVal",  _ExpGroupFee.GroupFeeVal);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpGroupFee trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpGroupFee] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpGroupFee trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpGroupFee _ExpGroupFee)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpGroupFee] WHERE Id=@Id",
					"@Id", _ExpGroupFee.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpGroupFee trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpGroupFee] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpGroupFee trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpGroupFee> _ExpGroupFees)
		{
			foreach (ExpGroupFee item in _ExpGroupFees)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
