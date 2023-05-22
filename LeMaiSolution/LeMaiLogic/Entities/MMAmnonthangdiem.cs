using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMAmnonthangdiem:IMAmnonthangdiem
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMAmnonthangdiem(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MamNonThangDiem từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonThangDiem]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MamNonThangDiem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonThangDiem] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MamNonThangDiem từ Database
		/// </summary>
		public List<MamNonThangDiem> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonThangDiem]");
				List<MamNonThangDiem> items = new List<MamNonThangDiem>();
				MamNonThangDiem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonThangDiem();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["TenThangDiem"] != null && dr["TenThangDiem"] != DBNull.Value)
					{
						item.TenThangDiem = Convert.ToString(dr["TenThangDiem"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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
		/// Lấy danh sách MamNonThangDiem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MamNonThangDiem> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonThangDiem] A "+ condition,  parameters);
				List<MamNonThangDiem> items = new List<MamNonThangDiem>();
				MamNonThangDiem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonThangDiem();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["TenThangDiem"] != null && dr["TenThangDiem"] != DBNull.Value)
					{
						item.TenThangDiem = Convert.ToString(dr["TenThangDiem"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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

		public List<MamNonThangDiem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonThangDiem] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MamNonThangDiem] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MamNonThangDiem>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MamNonThangDiem từ Database
		/// </summary>
		public MamNonThangDiem GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonThangDiem] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MamNonThangDiem item=new MamNonThangDiem();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["TenThangDiem"] != null && dr["TenThangDiem"] != DBNull.Value)
						{
							item.TenThangDiem = Convert.ToString(dr["TenThangDiem"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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
		/// Lấy một MamNonThangDiem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MamNonThangDiem GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonThangDiem] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MamNonThangDiem item=new MamNonThangDiem();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["TenThangDiem"] != null && dr["TenThangDiem"] != DBNull.Value)
						{
							item.TenThangDiem = Convert.ToString(dr["TenThangDiem"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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

		public MamNonThangDiem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonThangDiem] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MamNonThangDiem>(ds);
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
		/// Thêm mới MamNonThangDiem vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MamNonThangDiem _MamNonThangDiem)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MamNonThangDiem](Id, TenThangDiem, OrderNumber) VALUES(@Id, @TenThangDiem, @OrderNumber)", 
					"@Id",  _MamNonThangDiem.Id, 
					"@TenThangDiem",  _MamNonThangDiem.TenThangDiem, 
					"@OrderNumber",  _MamNonThangDiem.OrderNumber);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MamNonThangDiem vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MamNonThangDiem> _MamNonThangDiems)
		{
			foreach (MamNonThangDiem item in _MamNonThangDiems)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonThangDiem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MamNonThangDiem _MamNonThangDiem, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonThangDiem] SET Id=@Id, TenThangDiem=@TenThangDiem, OrderNumber=@OrderNumber WHERE Id=@Id", 
					"@Id",  _MamNonThangDiem.Id, 
					"@TenThangDiem",  _MamNonThangDiem.TenThangDiem, 
					"@OrderNumber",  _MamNonThangDiem.OrderNumber, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MamNonThangDiem vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MamNonThangDiem _MamNonThangDiem)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonThangDiem] SET TenThangDiem=@TenThangDiem, OrderNumber=@OrderNumber WHERE Id=@Id", 
					"@TenThangDiem",  _MamNonThangDiem.TenThangDiem, 
					"@OrderNumber",  _MamNonThangDiem.OrderNumber, 
					"@Id", _MamNonThangDiem.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MamNonThangDiem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MamNonThangDiem> _MamNonThangDiems)
		{
			foreach (MamNonThangDiem item in _MamNonThangDiems)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonThangDiem vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MamNonThangDiem _MamNonThangDiem, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonThangDiem] SET Id=@Id, TenThangDiem=@TenThangDiem, OrderNumber=@OrderNumber "+ condition, 
					"@Id",  _MamNonThangDiem.Id, 
					"@TenThangDiem",  _MamNonThangDiem.TenThangDiem, 
					"@OrderNumber",  _MamNonThangDiem.OrderNumber);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MamNonThangDiem trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonThangDiem] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonThangDiem trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MamNonThangDiem _MamNonThangDiem)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonThangDiem] WHERE Id=@Id",
					"@Id", _MamNonThangDiem.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonThangDiem trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonThangDiem] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonThangDiem trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MamNonThangDiem> _MamNonThangDiems)
		{
			foreach (MamNonThangDiem item in _MamNonThangDiems)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
