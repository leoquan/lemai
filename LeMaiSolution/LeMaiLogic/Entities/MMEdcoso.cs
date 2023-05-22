using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdcoso:IMEdcoso
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdcoso(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedCoSo từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCoSo]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedCoSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCoSo] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedCoSo từ Database
		/// </summary>
		public List<MedCoSo> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCoSo]");
				List<MedCoSo> items = new List<MedCoSo>();
				MedCoSo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedCoSo();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["tencoso"] != null && dr["tencoso"] != DBNull.Value)
					{
						item.tencoso = Convert.ToString(dr["tencoso"]);
					}
					if (dr["diachicoso"] != null && dr["diachicoso"] != DBNull.Value)
					{
						item.diachicoso = Convert.ToString(dr["diachicoso"]);
					}
					if (dr["sodienthoai"] != null && dr["sodienthoai"] != DBNull.Value)
					{
						item.sodienthoai = Convert.ToString(dr["sodienthoai"]);
					}
					if (dr["sofax"] != null && dr["sofax"] != DBNull.Value)
					{
						item.sofax = Convert.ToString(dr["sofax"]);
					}
					if (dr["email"] != null && dr["email"] != DBNull.Value)
					{
						item.email = Convert.ToString(dr["email"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
					{
						item.createuser = Convert.ToString(dr["createuser"]);
					}
					if (dr["schemaused"] != null && dr["schemaused"] != DBNull.Value)
					{
						item.schemaused = Convert.ToString(dr["schemaused"]);
					}
					if (dr["subfixreport"] != null && dr["subfixreport"] != DBNull.Value)
					{
						item.subfixreport = Convert.ToString(dr["subfixreport"]);
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
		/// Lấy danh sách MedCoSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedCoSo> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedCoSo] A "+ condition,  parameters);
				List<MedCoSo> items = new List<MedCoSo>();
				MedCoSo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedCoSo();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["tencoso"] != null && dr["tencoso"] != DBNull.Value)
					{
						item.tencoso = Convert.ToString(dr["tencoso"]);
					}
					if (dr["diachicoso"] != null && dr["diachicoso"] != DBNull.Value)
					{
						item.diachicoso = Convert.ToString(dr["diachicoso"]);
					}
					if (dr["sodienthoai"] != null && dr["sodienthoai"] != DBNull.Value)
					{
						item.sodienthoai = Convert.ToString(dr["sodienthoai"]);
					}
					if (dr["sofax"] != null && dr["sofax"] != DBNull.Value)
					{
						item.sofax = Convert.ToString(dr["sofax"]);
					}
					if (dr["email"] != null && dr["email"] != DBNull.Value)
					{
						item.email = Convert.ToString(dr["email"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
					{
						item.createuser = Convert.ToString(dr["createuser"]);
					}
					if (dr["schemaused"] != null && dr["schemaused"] != DBNull.Value)
					{
						item.schemaused = Convert.ToString(dr["schemaused"]);
					}
					if (dr["subfixreport"] != null && dr["subfixreport"] != DBNull.Value)
					{
						item.subfixreport = Convert.ToString(dr["subfixreport"]);
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

		public List<MedCoSo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedCoSo] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedCoSo] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedCoSo>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedCoSo từ Database
		/// </summary>
		public MedCoSo GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCoSo] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedCoSo item=new MedCoSo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["tencoso"] != null && dr["tencoso"] != DBNull.Value)
						{
							item.tencoso = Convert.ToString(dr["tencoso"]);
						}
						if (dr["diachicoso"] != null && dr["diachicoso"] != DBNull.Value)
						{
							item.diachicoso = Convert.ToString(dr["diachicoso"]);
						}
						if (dr["sodienthoai"] != null && dr["sodienthoai"] != DBNull.Value)
						{
							item.sodienthoai = Convert.ToString(dr["sodienthoai"]);
						}
						if (dr["sofax"] != null && dr["sofax"] != DBNull.Value)
						{
							item.sofax = Convert.ToString(dr["sofax"]);
						}
						if (dr["email"] != null && dr["email"] != DBNull.Value)
						{
							item.email = Convert.ToString(dr["email"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
						{
							item.createuser = Convert.ToString(dr["createuser"]);
						}
						if (dr["schemaused"] != null && dr["schemaused"] != DBNull.Value)
						{
							item.schemaused = Convert.ToString(dr["schemaused"]);
						}
						if (dr["subfixreport"] != null && dr["subfixreport"] != DBNull.Value)
						{
							item.subfixreport = Convert.ToString(dr["subfixreport"]);
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
		/// Lấy một MedCoSo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedCoSo GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedCoSo] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedCoSo item=new MedCoSo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["tencoso"] != null && dr["tencoso"] != DBNull.Value)
						{
							item.tencoso = Convert.ToString(dr["tencoso"]);
						}
						if (dr["diachicoso"] != null && dr["diachicoso"] != DBNull.Value)
						{
							item.diachicoso = Convert.ToString(dr["diachicoso"]);
						}
						if (dr["sodienthoai"] != null && dr["sodienthoai"] != DBNull.Value)
						{
							item.sodienthoai = Convert.ToString(dr["sodienthoai"]);
						}
						if (dr["sofax"] != null && dr["sofax"] != DBNull.Value)
						{
							item.sofax = Convert.ToString(dr["sofax"]);
						}
						if (dr["email"] != null && dr["email"] != DBNull.Value)
						{
							item.email = Convert.ToString(dr["email"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
						{
							item.createuser = Convert.ToString(dr["createuser"]);
						}
						if (dr["schemaused"] != null && dr["schemaused"] != DBNull.Value)
						{
							item.schemaused = Convert.ToString(dr["schemaused"]);
						}
						if (dr["subfixreport"] != null && dr["subfixreport"] != DBNull.Value)
						{
							item.subfixreport = Convert.ToString(dr["subfixreport"]);
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

		public MedCoSo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedCoSo] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedCoSo>(ds);
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
		/// Thêm mới MedCoSo vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedCoSo _MedCoSo)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedCoSo](id, tencoso, diachicoso, sodienthoai, sofax, email, createdate, createuser, schemaused, subfixreport) VALUES(@id, @tencoso, @diachicoso, @sodienthoai, @sofax, @email, @createdate, @createuser, @schemaused, @subfixreport)", 
					"@id",  _MedCoSo.id, 
					"@tencoso",  _MedCoSo.tencoso, 
					"@diachicoso",  _MedCoSo.diachicoso, 
					"@sodienthoai",  _MedCoSo.sodienthoai, 
					"@sofax",  _MedCoSo.sofax, 
					"@email",  _MedCoSo.email, 
					"@createdate", this._dataContext.ConvertDateString( _MedCoSo.createdate), 
					"@createuser",  _MedCoSo.createuser, 
					"@schemaused",  _MedCoSo.schemaused, 
					"@subfixreport",  _MedCoSo.subfixreport);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedCoSo vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedCoSo> _MedCoSos)
		{
			foreach (MedCoSo item in _MedCoSos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedCoSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedCoSo _MedCoSo, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedCoSo] SET id=@id, tencoso=@tencoso, diachicoso=@diachicoso, sodienthoai=@sodienthoai, sofax=@sofax, email=@email, createdate=@createdate, createuser=@createuser, schemaused=@schemaused, subfixreport=@subfixreport WHERE id=@id", 
					"@id",  _MedCoSo.id, 
					"@tencoso",  _MedCoSo.tencoso, 
					"@diachicoso",  _MedCoSo.diachicoso, 
					"@sodienthoai",  _MedCoSo.sodienthoai, 
					"@sofax",  _MedCoSo.sofax, 
					"@email",  _MedCoSo.email, 
					"@createdate", this._dataContext.ConvertDateString( _MedCoSo.createdate), 
					"@createuser",  _MedCoSo.createuser, 
					"@schemaused",  _MedCoSo.schemaused, 
					"@subfixreport",  _MedCoSo.subfixreport, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedCoSo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedCoSo _MedCoSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedCoSo] SET tencoso=@tencoso, diachicoso=@diachicoso, sodienthoai=@sodienthoai, sofax=@sofax, email=@email, createdate=@createdate, createuser=@createuser, schemaused=@schemaused, subfixreport=@subfixreport WHERE id=@id", 
					"@tencoso",  _MedCoSo.tencoso, 
					"@diachicoso",  _MedCoSo.diachicoso, 
					"@sodienthoai",  _MedCoSo.sodienthoai, 
					"@sofax",  _MedCoSo.sofax, 
					"@email",  _MedCoSo.email, 
					"@createdate", this._dataContext.ConvertDateString( _MedCoSo.createdate), 
					"@createuser",  _MedCoSo.createuser, 
					"@schemaused",  _MedCoSo.schemaused, 
					"@subfixreport",  _MedCoSo.subfixreport, 
					"@id", _MedCoSo.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedCoSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedCoSo> _MedCoSos)
		{
			foreach (MedCoSo item in _MedCoSos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedCoSo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedCoSo _MedCoSo, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedCoSo] SET id=@id, tencoso=@tencoso, diachicoso=@diachicoso, sodienthoai=@sodienthoai, sofax=@sofax, email=@email, createdate=@createdate, createuser=@createuser, schemaused=@schemaused, subfixreport=@subfixreport "+ condition, 
					"@id",  _MedCoSo.id, 
					"@tencoso",  _MedCoSo.tencoso, 
					"@diachicoso",  _MedCoSo.diachicoso, 
					"@sodienthoai",  _MedCoSo.sodienthoai, 
					"@sofax",  _MedCoSo.sofax, 
					"@email",  _MedCoSo.email, 
					"@createdate", this._dataContext.ConvertDateString( _MedCoSo.createdate), 
					"@createuser",  _MedCoSo.createuser, 
					"@schemaused",  _MedCoSo.schemaused, 
					"@subfixreport",  _MedCoSo.subfixreport);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedCoSo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedCoSo] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedCoSo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedCoSo _MedCoSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedCoSo] WHERE id=@id",
					"@id", _MedCoSo.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedCoSo trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedCoSo] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedCoSo trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedCoSo> _MedCoSos)
		{
			foreach (MedCoSo item in _MedCoSos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
