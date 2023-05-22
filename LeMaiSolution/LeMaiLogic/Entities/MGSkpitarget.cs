using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSkpitarget:IGSkpitarget
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSkpitarget(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsKPITarget từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPITarget]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsKPITarget từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPITarget] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsKPITarget từ Database
		/// </summary>
		public List<GsKPITarget> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPITarget]");
				List<GsKPITarget> items = new List<GsKPITarget>();
				GsKPITarget item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsKPITarget();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TargetCode"] != null && dr["TargetCode"] != DBNull.Value)
					{
						item.TargetCode = Convert.ToString(dr["TargetCode"]);
					}
					if (dr["TargetName"] != null && dr["TargetName"] != DBNull.Value)
					{
						item.TargetName = Convert.ToString(dr["TargetName"]);
					}
					if (dr["FK_TargetType"] != null && dr["FK_TargetType"] != DBNull.Value)
					{
						item.FK_TargetType = Convert.ToString(dr["FK_TargetType"]);
					}
					if (dr["ValidFrom"] != null && dr["ValidFrom"] != DBNull.Value)
					{
						item.ValidFrom = Convert.ToDateTime(dr["ValidFrom"]);
					}
					if (dr["FK_AccountObjectType"] != null && dr["FK_AccountObjectType"] != DBNull.Value)
					{
						item.FK_AccountObjectType = Convert.ToString(dr["FK_AccountObjectType"]);
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
		/// Lấy danh sách GsKPITarget từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsKPITarget> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsKPITarget] A "+ condition,  parameters);
				List<GsKPITarget> items = new List<GsKPITarget>();
				GsKPITarget item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsKPITarget();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TargetCode"] != null && dr["TargetCode"] != DBNull.Value)
					{
						item.TargetCode = Convert.ToString(dr["TargetCode"]);
					}
					if (dr["TargetName"] != null && dr["TargetName"] != DBNull.Value)
					{
						item.TargetName = Convert.ToString(dr["TargetName"]);
					}
					if (dr["FK_TargetType"] != null && dr["FK_TargetType"] != DBNull.Value)
					{
						item.FK_TargetType = Convert.ToString(dr["FK_TargetType"]);
					}
					if (dr["ValidFrom"] != null && dr["ValidFrom"] != DBNull.Value)
					{
						item.ValidFrom = Convert.ToDateTime(dr["ValidFrom"]);
					}
					if (dr["FK_AccountObjectType"] != null && dr["FK_AccountObjectType"] != DBNull.Value)
					{
						item.FK_AccountObjectType = Convert.ToString(dr["FK_AccountObjectType"]);
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

		public List<GsKPITarget> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsKPITarget] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsKPITarget] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsKPITarget>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsKPITarget từ Database
		/// </summary>
		public GsKPITarget GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsKPITarget] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsKPITarget item=new GsKPITarget();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TargetCode"] != null && dr["TargetCode"] != DBNull.Value)
						{
							item.TargetCode = Convert.ToString(dr["TargetCode"]);
						}
						if (dr["TargetName"] != null && dr["TargetName"] != DBNull.Value)
						{
							item.TargetName = Convert.ToString(dr["TargetName"]);
						}
						if (dr["FK_TargetType"] != null && dr["FK_TargetType"] != DBNull.Value)
						{
							item.FK_TargetType = Convert.ToString(dr["FK_TargetType"]);
						}
						if (dr["ValidFrom"] != null && dr["ValidFrom"] != DBNull.Value)
						{
							item.ValidFrom = Convert.ToDateTime(dr["ValidFrom"]);
						}
						if (dr["FK_AccountObjectType"] != null && dr["FK_AccountObjectType"] != DBNull.Value)
						{
							item.FK_AccountObjectType = Convert.ToString(dr["FK_AccountObjectType"]);
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
		/// Lấy một GsKPITarget đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsKPITarget GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsKPITarget] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsKPITarget item=new GsKPITarget();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TargetCode"] != null && dr["TargetCode"] != DBNull.Value)
						{
							item.TargetCode = Convert.ToString(dr["TargetCode"]);
						}
						if (dr["TargetName"] != null && dr["TargetName"] != DBNull.Value)
						{
							item.TargetName = Convert.ToString(dr["TargetName"]);
						}
						if (dr["FK_TargetType"] != null && dr["FK_TargetType"] != DBNull.Value)
						{
							item.FK_TargetType = Convert.ToString(dr["FK_TargetType"]);
						}
						if (dr["ValidFrom"] != null && dr["ValidFrom"] != DBNull.Value)
						{
							item.ValidFrom = Convert.ToDateTime(dr["ValidFrom"]);
						}
						if (dr["FK_AccountObjectType"] != null && dr["FK_AccountObjectType"] != DBNull.Value)
						{
							item.FK_AccountObjectType = Convert.ToString(dr["FK_AccountObjectType"]);
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

		public GsKPITarget GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsKPITarget] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsKPITarget>(ds);
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
		/// Thêm mới GsKPITarget vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsKPITarget _GsKPITarget)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsKPITarget](Id, TargetCode, TargetName, FK_TargetType, ValidFrom, FK_AccountObjectType) VALUES(@Id, @TargetCode, @TargetName, @FK_TargetType, @ValidFrom, @FK_AccountObjectType)", 
					"@Id",  _GsKPITarget.Id, 
					"@TargetCode",  _GsKPITarget.TargetCode, 
					"@TargetName",  _GsKPITarget.TargetName, 
					"@FK_TargetType",  _GsKPITarget.FK_TargetType, 
					"@ValidFrom", this._dataContext.ConvertDateString( _GsKPITarget.ValidFrom), 
					"@FK_AccountObjectType",  _GsKPITarget.FK_AccountObjectType);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsKPITarget vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsKPITarget> _GsKPITargets)
		{
			foreach (GsKPITarget item in _GsKPITargets)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsKPITarget vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsKPITarget _GsKPITarget, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPITarget] SET Id=@Id, TargetCode=@TargetCode, TargetName=@TargetName, FK_TargetType=@FK_TargetType, ValidFrom=@ValidFrom, FK_AccountObjectType=@FK_AccountObjectType WHERE Id=@Id", 
					"@Id",  _GsKPITarget.Id, 
					"@TargetCode",  _GsKPITarget.TargetCode, 
					"@TargetName",  _GsKPITarget.TargetName, 
					"@FK_TargetType",  _GsKPITarget.FK_TargetType, 
					"@ValidFrom", this._dataContext.ConvertDateString( _GsKPITarget.ValidFrom), 
					"@FK_AccountObjectType",  _GsKPITarget.FK_AccountObjectType, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsKPITarget vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsKPITarget _GsKPITarget)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPITarget] SET TargetCode=@TargetCode, TargetName=@TargetName, FK_TargetType=@FK_TargetType, ValidFrom=@ValidFrom, FK_AccountObjectType=@FK_AccountObjectType WHERE Id=@Id", 
					"@TargetCode",  _GsKPITarget.TargetCode, 
					"@TargetName",  _GsKPITarget.TargetName, 
					"@FK_TargetType",  _GsKPITarget.FK_TargetType, 
					"@ValidFrom", this._dataContext.ConvertDateString( _GsKPITarget.ValidFrom), 
					"@FK_AccountObjectType",  _GsKPITarget.FK_AccountObjectType, 
					"@Id", _GsKPITarget.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsKPITarget vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsKPITarget> _GsKPITargets)
		{
			foreach (GsKPITarget item in _GsKPITargets)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsKPITarget vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsKPITarget _GsKPITarget, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsKPITarget] SET Id=@Id, TargetCode=@TargetCode, TargetName=@TargetName, FK_TargetType=@FK_TargetType, ValidFrom=@ValidFrom, FK_AccountObjectType=@FK_AccountObjectType "+ condition, 
					"@Id",  _GsKPITarget.Id, 
					"@TargetCode",  _GsKPITarget.TargetCode, 
					"@TargetName",  _GsKPITarget.TargetName, 
					"@FK_TargetType",  _GsKPITarget.FK_TargetType, 
					"@ValidFrom", this._dataContext.ConvertDateString( _GsKPITarget.ValidFrom), 
					"@FK_AccountObjectType",  _GsKPITarget.FK_AccountObjectType);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsKPITarget trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPITarget] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPITarget trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsKPITarget _GsKPITarget)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPITarget] WHERE Id=@Id",
					"@Id", _GsKPITarget.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPITarget trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsKPITarget] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsKPITarget trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsKPITarget> _GsKPITargets)
		{
			foreach (GsKPITarget item in _GsKPITargets)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
