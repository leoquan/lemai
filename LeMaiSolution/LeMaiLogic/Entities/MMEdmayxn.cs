using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdmayxn:IMEdmayxn
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdmayxn(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedMayXN từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMayXN]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMayXN] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedMayXN từ Database
		/// </summary>
		public List<MedMayXN> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMayXN]");
				List<MedMayXN> items = new List<MedMayXN>();
				MedMayXN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedMayXN();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["comport"] != null && dr["comport"] != DBNull.Value)
					{
						item.comport = Convert.ToString(dr["comport"]);
					}
					if (dr["baudrate"] != null && dr["baudrate"] != DBNull.Value)
					{
						item.baudrate = Convert.ToDecimal(dr["baudrate"]);
					}
					if (dr["databits"] != null && dr["databits"] != DBNull.Value)
					{
						item.databits = Convert.ToString(dr["databits"]);
					}
					if (dr["parity"] != null && dr["parity"] != DBNull.Value)
					{
						item.parity = Convert.ToString(dr["parity"]);
					}
					if (dr["stopbits"] != null && dr["stopbits"] != DBNull.Value)
					{
						item.stopbits = Convert.ToString(dr["stopbits"]);
					}
					if (dr["handshake"] != null && dr["handshake"] != DBNull.Value)
					{
						item.handshake = Convert.ToString(dr["handshake"]);
					}
					if (dr["phuongthuc"] != null && dr["phuongthuc"] != DBNull.Value)
					{
						item.phuongthuc = Convert.ToString(dr["phuongthuc"]);
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
		/// Lấy danh sách MedMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedMayXN> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedMayXN] A "+ condition,  parameters);
				List<MedMayXN> items = new List<MedMayXN>();
				MedMayXN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedMayXN();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["comport"] != null && dr["comport"] != DBNull.Value)
					{
						item.comport = Convert.ToString(dr["comport"]);
					}
					if (dr["baudrate"] != null && dr["baudrate"] != DBNull.Value)
					{
						item.baudrate = Convert.ToDecimal(dr["baudrate"]);
					}
					if (dr["databits"] != null && dr["databits"] != DBNull.Value)
					{
						item.databits = Convert.ToString(dr["databits"]);
					}
					if (dr["parity"] != null && dr["parity"] != DBNull.Value)
					{
						item.parity = Convert.ToString(dr["parity"]);
					}
					if (dr["stopbits"] != null && dr["stopbits"] != DBNull.Value)
					{
						item.stopbits = Convert.ToString(dr["stopbits"]);
					}
					if (dr["handshake"] != null && dr["handshake"] != DBNull.Value)
					{
						item.handshake = Convert.ToString(dr["handshake"]);
					}
					if (dr["phuongthuc"] != null && dr["phuongthuc"] != DBNull.Value)
					{
						item.phuongthuc = Convert.ToString(dr["phuongthuc"]);
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

		public List<MedMayXN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedMayXN] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedMayXN] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedMayXN>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedMayXN từ Database
		/// </summary>
		public MedMayXN GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMayXN] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedMayXN item=new MedMayXN();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["comport"] != null && dr["comport"] != DBNull.Value)
						{
							item.comport = Convert.ToString(dr["comport"]);
						}
						if (dr["baudrate"] != null && dr["baudrate"] != DBNull.Value)
						{
							item.baudrate = Convert.ToDecimal(dr["baudrate"]);
						}
						if (dr["databits"] != null && dr["databits"] != DBNull.Value)
						{
							item.databits = Convert.ToString(dr["databits"]);
						}
						if (dr["parity"] != null && dr["parity"] != DBNull.Value)
						{
							item.parity = Convert.ToString(dr["parity"]);
						}
						if (dr["stopbits"] != null && dr["stopbits"] != DBNull.Value)
						{
							item.stopbits = Convert.ToString(dr["stopbits"]);
						}
						if (dr["handshake"] != null && dr["handshake"] != DBNull.Value)
						{
							item.handshake = Convert.ToString(dr["handshake"]);
						}
						if (dr["phuongthuc"] != null && dr["phuongthuc"] != DBNull.Value)
						{
							item.phuongthuc = Convert.ToString(dr["phuongthuc"]);
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
		/// Lấy một MedMayXN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedMayXN GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedMayXN] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedMayXN item=new MedMayXN();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["comport"] != null && dr["comport"] != DBNull.Value)
						{
							item.comport = Convert.ToString(dr["comport"]);
						}
						if (dr["baudrate"] != null && dr["baudrate"] != DBNull.Value)
						{
							item.baudrate = Convert.ToDecimal(dr["baudrate"]);
						}
						if (dr["databits"] != null && dr["databits"] != DBNull.Value)
						{
							item.databits = Convert.ToString(dr["databits"]);
						}
						if (dr["parity"] != null && dr["parity"] != DBNull.Value)
						{
							item.parity = Convert.ToString(dr["parity"]);
						}
						if (dr["stopbits"] != null && dr["stopbits"] != DBNull.Value)
						{
							item.stopbits = Convert.ToString(dr["stopbits"]);
						}
						if (dr["handshake"] != null && dr["handshake"] != DBNull.Value)
						{
							item.handshake = Convert.ToString(dr["handshake"]);
						}
						if (dr["phuongthuc"] != null && dr["phuongthuc"] != DBNull.Value)
						{
							item.phuongthuc = Convert.ToString(dr["phuongthuc"]);
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

		public MedMayXN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedMayXN] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedMayXN>(ds);
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
		/// Thêm mới MedMayXN vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedMayXN _MedMayXN)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedMayXN](id, comport, baudrate, databits, parity, stopbits, handshake, phuongthuc) VALUES(@id, @comport, @baudrate, @databits, @parity, @stopbits, @handshake, @phuongthuc)", 
					"@id",  _MedMayXN.id, 
					"@comport",  _MedMayXN.comport, 
					"@baudrate",  _MedMayXN.baudrate, 
					"@databits",  _MedMayXN.databits, 
					"@parity",  _MedMayXN.parity, 
					"@stopbits",  _MedMayXN.stopbits, 
					"@handshake",  _MedMayXN.handshake, 
					"@phuongthuc",  _MedMayXN.phuongthuc);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedMayXN vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedMayXN> _MedMayXNs)
		{
			foreach (MedMayXN item in _MedMayXNs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedMayXN _MedMayXN, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMayXN] SET id=@id, comport=@comport, baudrate=@baudrate, databits=@databits, parity=@parity, stopbits=@stopbits, handshake=@handshake, phuongthuc=@phuongthuc WHERE id=@id", 
					"@id",  _MedMayXN.id, 
					"@comport",  _MedMayXN.comport, 
					"@baudrate",  _MedMayXN.baudrate, 
					"@databits",  _MedMayXN.databits, 
					"@parity",  _MedMayXN.parity, 
					"@stopbits",  _MedMayXN.stopbits, 
					"@handshake",  _MedMayXN.handshake, 
					"@phuongthuc",  _MedMayXN.phuongthuc, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedMayXN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedMayXN _MedMayXN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMayXN] SET comport=@comport, baudrate=@baudrate, databits=@databits, parity=@parity, stopbits=@stopbits, handshake=@handshake, phuongthuc=@phuongthuc WHERE id=@id", 
					"@comport",  _MedMayXN.comport, 
					"@baudrate",  _MedMayXN.baudrate, 
					"@databits",  _MedMayXN.databits, 
					"@parity",  _MedMayXN.parity, 
					"@stopbits",  _MedMayXN.stopbits, 
					"@handshake",  _MedMayXN.handshake, 
					"@phuongthuc",  _MedMayXN.phuongthuc, 
					"@id", _MedMayXN.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedMayXN> _MedMayXNs)
		{
			foreach (MedMayXN item in _MedMayXNs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedMayXN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedMayXN _MedMayXN, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMayXN] SET id=@id, comport=@comport, baudrate=@baudrate, databits=@databits, parity=@parity, stopbits=@stopbits, handshake=@handshake, phuongthuc=@phuongthuc "+ condition, 
					"@id",  _MedMayXN.id, 
					"@comport",  _MedMayXN.comport, 
					"@baudrate",  _MedMayXN.baudrate, 
					"@databits",  _MedMayXN.databits, 
					"@parity",  _MedMayXN.parity, 
					"@stopbits",  _MedMayXN.stopbits, 
					"@handshake",  _MedMayXN.handshake, 
					"@phuongthuc",  _MedMayXN.phuongthuc);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedMayXN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMayXN] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMayXN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedMayXN _MedMayXN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMayXN] WHERE id=@id",
					"@id", _MedMayXN.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMayXN trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMayXN] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMayXN trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedMayXN> _MedMayXNs)
		{
			foreach (MedMayXN item in _MedMayXNs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
