using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdmauin:IMEdmauin
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdmauin(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedMauIn từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMauIn]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedMauIn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMauIn] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedMauIn từ Database
		/// </summary>
		public List<MedMauIn> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMauIn]");
				List<MedMauIn> items = new List<MedMauIn>();
				MedMauIn item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedMauIn();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenMauIn"] != null && dr["TenMauIn"] != DBNull.Value)
					{
						item.TenMauIn = Convert.ToString(dr["TenMauIn"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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
		/// Lấy danh sách MedMauIn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedMauIn> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedMauIn] A "+ condition,  parameters);
				List<MedMauIn> items = new List<MedMauIn>();
				MedMauIn item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedMauIn();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenMauIn"] != null && dr["TenMauIn"] != DBNull.Value)
					{
						item.TenMauIn = Convert.ToString(dr["TenMauIn"]);
					}
					if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
					{
						item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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

		public List<MedMauIn> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedMauIn] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedMauIn] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedMauIn>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedMauIn từ Database
		/// </summary>
		public MedMauIn GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMauIn] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MedMauIn item=new MedMauIn();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["TenMauIn"] != null && dr["TenMauIn"] != DBNull.Value)
						{
							item.TenMauIn = Convert.ToString(dr["TenMauIn"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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
		/// Lấy một MedMauIn đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedMauIn GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedMauIn] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedMauIn item=new MedMauIn();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["TenMauIn"] != null && dr["TenMauIn"] != DBNull.Value)
						{
							item.TenMauIn = Convert.ToString(dr["TenMauIn"]);
						}
						if (dr["SortIndex"] != null && dr["SortIndex"] != DBNull.Value)
						{
							item.SortIndex = Convert.ToInt32(dr["SortIndex"]);
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

		public MedMauIn GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedMauIn] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedMauIn>(ds);
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
		/// Thêm mới MedMauIn vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedMauIn _MedMauIn)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedMauIn](Id, Code, TenMauIn, SortIndex) VALUES(@Id, @Code, @TenMauIn, @SortIndex)", 
					"@Id",  _MedMauIn.Id, 
					"@Code",  _MedMauIn.Code, 
					"@TenMauIn",  _MedMauIn.TenMauIn, 
					"@SortIndex",  _MedMauIn.SortIndex);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedMauIn vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedMauIn> _MedMauIns)
		{
			foreach (MedMauIn item in _MedMauIns)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedMauIn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedMauIn _MedMauIn, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMauIn] SET Id=@Id, Code=@Code, TenMauIn=@TenMauIn, SortIndex=@SortIndex WHERE Id=@Id", 
					"@Id",  _MedMauIn.Id, 
					"@Code",  _MedMauIn.Code, 
					"@TenMauIn",  _MedMauIn.TenMauIn, 
					"@SortIndex",  _MedMauIn.SortIndex, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedMauIn vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedMauIn _MedMauIn)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMauIn] SET Code=@Code, TenMauIn=@TenMauIn, SortIndex=@SortIndex WHERE Id=@Id", 
					"@Code",  _MedMauIn.Code, 
					"@TenMauIn",  _MedMauIn.TenMauIn, 
					"@SortIndex",  _MedMauIn.SortIndex, 
					"@Id", _MedMauIn.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedMauIn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedMauIn> _MedMauIns)
		{
			foreach (MedMauIn item in _MedMauIns)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedMauIn vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedMauIn _MedMauIn, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMauIn] SET Id=@Id, Code=@Code, TenMauIn=@TenMauIn, SortIndex=@SortIndex "+ condition, 
					"@Id",  _MedMauIn.Id, 
					"@Code",  _MedMauIn.Code, 
					"@TenMauIn",  _MedMauIn.TenMauIn, 
					"@SortIndex",  _MedMauIn.SortIndex);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedMauIn trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMauIn] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMauIn trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedMauIn _MedMauIn)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMauIn] WHERE Id=@Id",
					"@Id", _MedMauIn.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMauIn trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMauIn] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMauIn trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedMauIn> _MedMauIns)
		{
			foreach (MedMauIn item in _MedMauIns)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
