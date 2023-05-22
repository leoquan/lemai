using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEddmmay:IMEddmmay
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEddmmay(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedDmMay từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmMay]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedDmMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmMay] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedDmMay từ Database
		/// </summary>
		public List<MedDmMay> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmMay]");
				List<MedDmMay> items = new List<MedDmMay>();
				MedDmMay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedDmMay();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
					}
					if (dr["tinhtrang"] != null && dr["tinhtrang"] != DBNull.Value)
					{
						item.tinhtrang = Convert.ToBoolean(dr["tinhtrang"]);
					}
					if (dr["iddmso"] != null && dr["iddmso"] != DBNull.Value)
					{
						item.iddmso = Convert.ToInt32(dr["iddmso"]);
					}
					if (dr["idloaimay"] != null && dr["idloaimay"] != DBNull.Value)
					{
						item.idloaimay = Convert.ToInt32(dr["idloaimay"]);
					}
					if (dr["comport"] != null && dr["comport"] != DBNull.Value)
					{
						item.comport = Convert.ToString(dr["comport"]);
					}
					if (dr["baudrate"] != null && dr["baudrate"] != DBNull.Value)
					{
						item.baudrate = Convert.ToInt32(dr["baudrate"]);
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
					if (dr["computername"] != null && dr["computername"] != DBNull.Value)
					{
						item.computername = Convert.ToString(dr["computername"]);
					}
					if (dr["quytrinh"] != null && dr["quytrinh"] != DBNull.Value)
					{
						item.quytrinh = Convert.ToString(dr["quytrinh"]);
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
		/// Lấy danh sách MedDmMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedDmMay> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedDmMay] A "+ condition,  parameters);
				List<MedDmMay> items = new List<MedDmMay>();
				MedDmMay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedDmMay();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
					}
					if (dr["tinhtrang"] != null && dr["tinhtrang"] != DBNull.Value)
					{
						item.tinhtrang = Convert.ToBoolean(dr["tinhtrang"]);
					}
					if (dr["iddmso"] != null && dr["iddmso"] != DBNull.Value)
					{
						item.iddmso = Convert.ToInt32(dr["iddmso"]);
					}
					if (dr["idloaimay"] != null && dr["idloaimay"] != DBNull.Value)
					{
						item.idloaimay = Convert.ToInt32(dr["idloaimay"]);
					}
					if (dr["comport"] != null && dr["comport"] != DBNull.Value)
					{
						item.comport = Convert.ToString(dr["comport"]);
					}
					if (dr["baudrate"] != null && dr["baudrate"] != DBNull.Value)
					{
						item.baudrate = Convert.ToInt32(dr["baudrate"]);
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
					if (dr["computername"] != null && dr["computername"] != DBNull.Value)
					{
						item.computername = Convert.ToString(dr["computername"]);
					}
					if (dr["quytrinh"] != null && dr["quytrinh"] != DBNull.Value)
					{
						item.quytrinh = Convert.ToString(dr["quytrinh"]);
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

		public List<MedDmMay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedDmMay] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedDmMay] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedDmMay>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedDmMay từ Database
		/// </summary>
		public MedDmMay GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmMay] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedDmMay item=new MedDmMay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
						}
						if (dr["tinhtrang"] != null && dr["tinhtrang"] != DBNull.Value)
						{
							item.tinhtrang = Convert.ToBoolean(dr["tinhtrang"]);
						}
						if (dr["iddmso"] != null && dr["iddmso"] != DBNull.Value)
						{
							item.iddmso = Convert.ToInt32(dr["iddmso"]);
						}
						if (dr["idloaimay"] != null && dr["idloaimay"] != DBNull.Value)
						{
							item.idloaimay = Convert.ToInt32(dr["idloaimay"]);
						}
						if (dr["comport"] != null && dr["comport"] != DBNull.Value)
						{
							item.comport = Convert.ToString(dr["comport"]);
						}
						if (dr["baudrate"] != null && dr["baudrate"] != DBNull.Value)
						{
							item.baudrate = Convert.ToInt32(dr["baudrate"]);
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
						if (dr["computername"] != null && dr["computername"] != DBNull.Value)
						{
							item.computername = Convert.ToString(dr["computername"]);
						}
						if (dr["quytrinh"] != null && dr["quytrinh"] != DBNull.Value)
						{
							item.quytrinh = Convert.ToString(dr["quytrinh"]);
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
		/// Lấy một MedDmMay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedDmMay GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedDmMay] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedDmMay item=new MedDmMay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
						}
						if (dr["tinhtrang"] != null && dr["tinhtrang"] != DBNull.Value)
						{
							item.tinhtrang = Convert.ToBoolean(dr["tinhtrang"]);
						}
						if (dr["iddmso"] != null && dr["iddmso"] != DBNull.Value)
						{
							item.iddmso = Convert.ToInt32(dr["iddmso"]);
						}
						if (dr["idloaimay"] != null && dr["idloaimay"] != DBNull.Value)
						{
							item.idloaimay = Convert.ToInt32(dr["idloaimay"]);
						}
						if (dr["comport"] != null && dr["comport"] != DBNull.Value)
						{
							item.comport = Convert.ToString(dr["comport"]);
						}
						if (dr["baudrate"] != null && dr["baudrate"] != DBNull.Value)
						{
							item.baudrate = Convert.ToInt32(dr["baudrate"]);
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
						if (dr["computername"] != null && dr["computername"] != DBNull.Value)
						{
							item.computername = Convert.ToString(dr["computername"]);
						}
						if (dr["quytrinh"] != null && dr["quytrinh"] != DBNull.Value)
						{
							item.quytrinh = Convert.ToString(dr["quytrinh"]);
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

		public MedDmMay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedDmMay] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedDmMay>(ds);
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
		/// Thêm mới MedDmMay vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedDmMay _MedDmMay)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedDmMay](id, stt, ma, ten, tinhtrang, iddmso, idloaimay, comport, baudrate, databits, parity, stopbits, handshake, phuongthuc, computername, quytrinh) VALUES(@id, @stt, @ma, @ten, @tinhtrang, @iddmso, @idloaimay, @comport, @baudrate, @databits, @parity, @stopbits, @handshake, @phuongthuc, @computername, @quytrinh)", 
					"@id",  _MedDmMay.id, 
					"@stt",  _MedDmMay.stt, 
					"@ma",  _MedDmMay.ma, 
					"@ten",  _MedDmMay.ten, 
					"@tinhtrang",  _MedDmMay.tinhtrang, 
					"@iddmso",  _MedDmMay.iddmso, 
					"@idloaimay",  _MedDmMay.idloaimay, 
					"@comport",  _MedDmMay.comport, 
					"@baudrate",  _MedDmMay.baudrate, 
					"@databits",  _MedDmMay.databits, 
					"@parity",  _MedDmMay.parity, 
					"@stopbits",  _MedDmMay.stopbits, 
					"@handshake",  _MedDmMay.handshake, 
					"@phuongthuc",  _MedDmMay.phuongthuc, 
					"@computername",  _MedDmMay.computername, 
					"@quytrinh",  _MedDmMay.quytrinh);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedDmMay vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedDmMay> _MedDmMays)
		{
			foreach (MedDmMay item in _MedDmMays)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedDmMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedDmMay _MedDmMay, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmMay] SET id=@id, stt=@stt, ma=@ma, ten=@ten, tinhtrang=@tinhtrang, iddmso=@iddmso, idloaimay=@idloaimay, comport=@comport, baudrate=@baudrate, databits=@databits, parity=@parity, stopbits=@stopbits, handshake=@handshake, phuongthuc=@phuongthuc, computername=@computername, quytrinh=@quytrinh WHERE id=@id", 
					"@id",  _MedDmMay.id, 
					"@stt",  _MedDmMay.stt, 
					"@ma",  _MedDmMay.ma, 
					"@ten",  _MedDmMay.ten, 
					"@tinhtrang",  _MedDmMay.tinhtrang, 
					"@iddmso",  _MedDmMay.iddmso, 
					"@idloaimay",  _MedDmMay.idloaimay, 
					"@comport",  _MedDmMay.comport, 
					"@baudrate",  _MedDmMay.baudrate, 
					"@databits",  _MedDmMay.databits, 
					"@parity",  _MedDmMay.parity, 
					"@stopbits",  _MedDmMay.stopbits, 
					"@handshake",  _MedDmMay.handshake, 
					"@phuongthuc",  _MedDmMay.phuongthuc, 
					"@computername",  _MedDmMay.computername, 
					"@quytrinh",  _MedDmMay.quytrinh, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedDmMay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedDmMay _MedDmMay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmMay] SET stt=@stt, ma=@ma, ten=@ten, tinhtrang=@tinhtrang, iddmso=@iddmso, idloaimay=@idloaimay, comport=@comport, baudrate=@baudrate, databits=@databits, parity=@parity, stopbits=@stopbits, handshake=@handshake, phuongthuc=@phuongthuc, computername=@computername, quytrinh=@quytrinh WHERE id=@id", 
					"@stt",  _MedDmMay.stt, 
					"@ma",  _MedDmMay.ma, 
					"@ten",  _MedDmMay.ten, 
					"@tinhtrang",  _MedDmMay.tinhtrang, 
					"@iddmso",  _MedDmMay.iddmso, 
					"@idloaimay",  _MedDmMay.idloaimay, 
					"@comport",  _MedDmMay.comport, 
					"@baudrate",  _MedDmMay.baudrate, 
					"@databits",  _MedDmMay.databits, 
					"@parity",  _MedDmMay.parity, 
					"@stopbits",  _MedDmMay.stopbits, 
					"@handshake",  _MedDmMay.handshake, 
					"@phuongthuc",  _MedDmMay.phuongthuc, 
					"@computername",  _MedDmMay.computername, 
					"@quytrinh",  _MedDmMay.quytrinh, 
					"@id", _MedDmMay.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedDmMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedDmMay> _MedDmMays)
		{
			foreach (MedDmMay item in _MedDmMays)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedDmMay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedDmMay _MedDmMay, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmMay] SET id=@id, stt=@stt, ma=@ma, ten=@ten, tinhtrang=@tinhtrang, iddmso=@iddmso, idloaimay=@idloaimay, comport=@comport, baudrate=@baudrate, databits=@databits, parity=@parity, stopbits=@stopbits, handshake=@handshake, phuongthuc=@phuongthuc, computername=@computername, quytrinh=@quytrinh "+ condition, 
					"@id",  _MedDmMay.id, 
					"@stt",  _MedDmMay.stt, 
					"@ma",  _MedDmMay.ma, 
					"@ten",  _MedDmMay.ten, 
					"@tinhtrang",  _MedDmMay.tinhtrang, 
					"@iddmso",  _MedDmMay.iddmso, 
					"@idloaimay",  _MedDmMay.idloaimay, 
					"@comport",  _MedDmMay.comport, 
					"@baudrate",  _MedDmMay.baudrate, 
					"@databits",  _MedDmMay.databits, 
					"@parity",  _MedDmMay.parity, 
					"@stopbits",  _MedDmMay.stopbits, 
					"@handshake",  _MedDmMay.handshake, 
					"@phuongthuc",  _MedDmMay.phuongthuc, 
					"@computername",  _MedDmMay.computername, 
					"@quytrinh",  _MedDmMay.quytrinh);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedDmMay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmMay] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmMay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedDmMay _MedDmMay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmMay] WHERE id=@id",
					"@id", _MedDmMay.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmMay trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmMay] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmMay trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedDmMay> _MedDmMays)
		{
			foreach (MedDmMay item in _MedDmMays)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
