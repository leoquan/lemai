using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdworkspace:IMEdworkspace
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdworkspace(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedWorkSpace từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedWorkSpace]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedWorkSpace từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedWorkSpace] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedWorkSpace từ Database
		/// </summary>
		public List<MedWorkSpace> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedWorkSpace]");
				List<MedWorkSpace> items = new List<MedWorkSpace>();
				MedWorkSpace item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedWorkSpace();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["WorkSpace"] != null && dr["WorkSpace"] != DBNull.Value)
					{
						item.WorkSpace = Convert.ToString(dr["WorkSpace"]);
					}
					if (dr["IsValid"] != null && dr["IsValid"] != DBNull.Value)
					{
						item.IsValid = Convert.ToBoolean(dr["IsValid"]);
					}
					if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
					{
						item.StartDate = Convert.ToDateTime(dr["StartDate"]);
					}
					if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
					{
						item.EndDate = Convert.ToDateTime(dr["EndDate"]);
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
		/// Lấy danh sách MedWorkSpace từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedWorkSpace> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedWorkSpace] A "+ condition,  parameters);
				List<MedWorkSpace> items = new List<MedWorkSpace>();
				MedWorkSpace item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedWorkSpace();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["WorkSpace"] != null && dr["WorkSpace"] != DBNull.Value)
					{
						item.WorkSpace = Convert.ToString(dr["WorkSpace"]);
					}
					if (dr["IsValid"] != null && dr["IsValid"] != DBNull.Value)
					{
						item.IsValid = Convert.ToBoolean(dr["IsValid"]);
					}
					if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
					{
						item.StartDate = Convert.ToDateTime(dr["StartDate"]);
					}
					if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
					{
						item.EndDate = Convert.ToDateTime(dr["EndDate"]);
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

		public List<MedWorkSpace> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedWorkSpace] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedWorkSpace] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedWorkSpace>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedWorkSpace từ Database
		/// </summary>
		public MedWorkSpace GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedWorkSpace] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MedWorkSpace item=new MedWorkSpace();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["WorkSpace"] != null && dr["WorkSpace"] != DBNull.Value)
						{
							item.WorkSpace = Convert.ToString(dr["WorkSpace"]);
						}
						if (dr["IsValid"] != null && dr["IsValid"] != DBNull.Value)
						{
							item.IsValid = Convert.ToBoolean(dr["IsValid"]);
						}
						if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
						{
							item.StartDate = Convert.ToDateTime(dr["StartDate"]);
						}
						if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
						{
							item.EndDate = Convert.ToDateTime(dr["EndDate"]);
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
		/// Lấy một MedWorkSpace đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedWorkSpace GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedWorkSpace] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedWorkSpace item=new MedWorkSpace();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["WorkSpace"] != null && dr["WorkSpace"] != DBNull.Value)
						{
							item.WorkSpace = Convert.ToString(dr["WorkSpace"]);
						}
						if (dr["IsValid"] != null && dr["IsValid"] != DBNull.Value)
						{
							item.IsValid = Convert.ToBoolean(dr["IsValid"]);
						}
						if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
						{
							item.StartDate = Convert.ToDateTime(dr["StartDate"]);
						}
						if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
						{
							item.EndDate = Convert.ToDateTime(dr["EndDate"]);
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

		public MedWorkSpace GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedWorkSpace] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedWorkSpace>(ds);
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
		/// Thêm mới MedWorkSpace vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedWorkSpace _MedWorkSpace)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedWorkSpace](Id, WorkSpace, IsValid, StartDate, EndDate) VALUES(@Id, @WorkSpace, @IsValid, @StartDate, @EndDate)", 
					"@Id",  _MedWorkSpace.Id, 
					"@WorkSpace",  _MedWorkSpace.WorkSpace, 
					"@IsValid",  _MedWorkSpace.IsValid, 
					"@StartDate", this._dataContext.ConvertDateString( _MedWorkSpace.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _MedWorkSpace.EndDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedWorkSpace vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedWorkSpace> _MedWorkSpaces)
		{
			foreach (MedWorkSpace item in _MedWorkSpaces)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedWorkSpace vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedWorkSpace _MedWorkSpace, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedWorkSpace] SET Id=@Id, WorkSpace=@WorkSpace, IsValid=@IsValid, StartDate=@StartDate, EndDate=@EndDate WHERE Id=@Id", 
					"@Id",  _MedWorkSpace.Id, 
					"@WorkSpace",  _MedWorkSpace.WorkSpace, 
					"@IsValid",  _MedWorkSpace.IsValid, 
					"@StartDate", this._dataContext.ConvertDateString( _MedWorkSpace.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _MedWorkSpace.EndDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedWorkSpace vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedWorkSpace _MedWorkSpace)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedWorkSpace] SET WorkSpace=@WorkSpace, IsValid=@IsValid, StartDate=@StartDate, EndDate=@EndDate WHERE Id=@Id", 
					"@WorkSpace",  _MedWorkSpace.WorkSpace, 
					"@IsValid",  _MedWorkSpace.IsValid, 
					"@StartDate", this._dataContext.ConvertDateString( _MedWorkSpace.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _MedWorkSpace.EndDate), 
					"@Id", _MedWorkSpace.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedWorkSpace vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedWorkSpace> _MedWorkSpaces)
		{
			foreach (MedWorkSpace item in _MedWorkSpaces)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedWorkSpace vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedWorkSpace _MedWorkSpace, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedWorkSpace] SET Id=@Id, WorkSpace=@WorkSpace, IsValid=@IsValid, StartDate=@StartDate, EndDate=@EndDate "+ condition, 
					"@Id",  _MedWorkSpace.Id, 
					"@WorkSpace",  _MedWorkSpace.WorkSpace, 
					"@IsValid",  _MedWorkSpace.IsValid, 
					"@StartDate", this._dataContext.ConvertDateString( _MedWorkSpace.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _MedWorkSpace.EndDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedWorkSpace trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedWorkSpace] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedWorkSpace trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedWorkSpace _MedWorkSpace)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedWorkSpace] WHERE Id=@Id",
					"@Id", _MedWorkSpace.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedWorkSpace trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedWorkSpace] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedWorkSpace trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedWorkSpace> _MedWorkSpaces)
		{
			foreach (MedWorkSpace item in _MedWorkSpaces)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
