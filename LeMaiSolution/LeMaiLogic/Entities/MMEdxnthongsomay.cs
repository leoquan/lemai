using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdxnthongsomay:IMEdxnthongsomay
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdxnthongsomay(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedXNThongSoMay từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNThongSoMay]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedXNThongSoMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNThongSoMay] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedXNThongSoMay từ Database
		/// </summary>
		public List<MedXNThongSoMay> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNThongSoMay]");
				List<MedXNThongSoMay> items = new List<MedXNThongSoMay>();
				MedXNThongSoMay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedXNThongSoMay();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["mayxn"] != null && dr["mayxn"] != DBNull.Value)
					{
						item.mayxn = Convert.ToInt32(dr["mayxn"]);
					}
					if (dr["xetnghiem"] != null && dr["xetnghiem"] != DBNull.Value)
					{
						item.xetnghiem = Convert.ToInt32(dr["xetnghiem"]);
					}
					if (dr["tenfile"] != null && dr["tenfile"] != DBNull.Value)
					{
						item.tenfile = Convert.ToString(dr["tenfile"]);
					}
					if (dr["filepath"] != null && dr["filepath"] != DBNull.Value)
					{
						item.filepath = Convert.ToString(dr["filepath"]);
					}
					if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
					{
						item.mabn = Convert.ToBoolean(dr["mabn"]);
					}
					if (dr["sophieu"] != null && dr["sophieu"] != DBNull.Value)
					{
						item.sophieu = Convert.ToBoolean(dr["sophieu"]);
					}
					if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
					{
						item.sudung = Convert.ToInt32(dr["sudung"]);
					}
					if (dr["ma_test"] != null && dr["ma_test"] != DBNull.Value)
					{
						item.ma_test = Convert.ToString(dr["ma_test"]);
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
		/// Lấy danh sách MedXNThongSoMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedXNThongSoMay> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedXNThongSoMay] A "+ condition,  parameters);
				List<MedXNThongSoMay> items = new List<MedXNThongSoMay>();
				MedXNThongSoMay item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedXNThongSoMay();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["mayxn"] != null && dr["mayxn"] != DBNull.Value)
					{
						item.mayxn = Convert.ToInt32(dr["mayxn"]);
					}
					if (dr["xetnghiem"] != null && dr["xetnghiem"] != DBNull.Value)
					{
						item.xetnghiem = Convert.ToInt32(dr["xetnghiem"]);
					}
					if (dr["tenfile"] != null && dr["tenfile"] != DBNull.Value)
					{
						item.tenfile = Convert.ToString(dr["tenfile"]);
					}
					if (dr["filepath"] != null && dr["filepath"] != DBNull.Value)
					{
						item.filepath = Convert.ToString(dr["filepath"]);
					}
					if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
					{
						item.mabn = Convert.ToBoolean(dr["mabn"]);
					}
					if (dr["sophieu"] != null && dr["sophieu"] != DBNull.Value)
					{
						item.sophieu = Convert.ToBoolean(dr["sophieu"]);
					}
					if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
					{
						item.sudung = Convert.ToInt32(dr["sudung"]);
					}
					if (dr["ma_test"] != null && dr["ma_test"] != DBNull.Value)
					{
						item.ma_test = Convert.ToString(dr["ma_test"]);
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

		public List<MedXNThongSoMay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedXNThongSoMay] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedXNThongSoMay] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedXNThongSoMay>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedXNThongSoMay từ Database
		/// </summary>
		public MedXNThongSoMay GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNThongSoMay] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedXNThongSoMay item=new MedXNThongSoMay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["mayxn"] != null && dr["mayxn"] != DBNull.Value)
						{
							item.mayxn = Convert.ToInt32(dr["mayxn"]);
						}
						if (dr["xetnghiem"] != null && dr["xetnghiem"] != DBNull.Value)
						{
							item.xetnghiem = Convert.ToInt32(dr["xetnghiem"]);
						}
						if (dr["tenfile"] != null && dr["tenfile"] != DBNull.Value)
						{
							item.tenfile = Convert.ToString(dr["tenfile"]);
						}
						if (dr["filepath"] != null && dr["filepath"] != DBNull.Value)
						{
							item.filepath = Convert.ToString(dr["filepath"]);
						}
						if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
						{
							item.mabn = Convert.ToBoolean(dr["mabn"]);
						}
						if (dr["sophieu"] != null && dr["sophieu"] != DBNull.Value)
						{
							item.sophieu = Convert.ToBoolean(dr["sophieu"]);
						}
						if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
						{
							item.sudung = Convert.ToInt32(dr["sudung"]);
						}
						if (dr["ma_test"] != null && dr["ma_test"] != DBNull.Value)
						{
							item.ma_test = Convert.ToString(dr["ma_test"]);
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
		/// Lấy một MedXNThongSoMay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedXNThongSoMay GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedXNThongSoMay] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedXNThongSoMay item=new MedXNThongSoMay();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["mayxn"] != null && dr["mayxn"] != DBNull.Value)
						{
							item.mayxn = Convert.ToInt32(dr["mayxn"]);
						}
						if (dr["xetnghiem"] != null && dr["xetnghiem"] != DBNull.Value)
						{
							item.xetnghiem = Convert.ToInt32(dr["xetnghiem"]);
						}
						if (dr["tenfile"] != null && dr["tenfile"] != DBNull.Value)
						{
							item.tenfile = Convert.ToString(dr["tenfile"]);
						}
						if (dr["filepath"] != null && dr["filepath"] != DBNull.Value)
						{
							item.filepath = Convert.ToString(dr["filepath"]);
						}
						if (dr["mabn"] != null && dr["mabn"] != DBNull.Value)
						{
							item.mabn = Convert.ToBoolean(dr["mabn"]);
						}
						if (dr["sophieu"] != null && dr["sophieu"] != DBNull.Value)
						{
							item.sophieu = Convert.ToBoolean(dr["sophieu"]);
						}
						if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
						{
							item.sudung = Convert.ToInt32(dr["sudung"]);
						}
						if (dr["ma_test"] != null && dr["ma_test"] != DBNull.Value)
						{
							item.ma_test = Convert.ToString(dr["ma_test"]);
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

		public MedXNThongSoMay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedXNThongSoMay] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedXNThongSoMay>(ds);
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
		/// Thêm mới MedXNThongSoMay vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedXNThongSoMay _MedXNThongSoMay)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedXNThongSoMay](id, mayxn, xetnghiem, tenfile, filepath, mabn, sophieu, sudung, ma_test) VALUES(@id, @mayxn, @xetnghiem, @tenfile, @filepath, @mabn, @sophieu, @sudung, @ma_test)", 
					"@id",  _MedXNThongSoMay.id, 
					"@mayxn",  _MedXNThongSoMay.mayxn, 
					"@xetnghiem",  _MedXNThongSoMay.xetnghiem, 
					"@tenfile",  _MedXNThongSoMay.tenfile, 
					"@filepath",  _MedXNThongSoMay.filepath, 
					"@mabn",  _MedXNThongSoMay.mabn, 
					"@sophieu",  _MedXNThongSoMay.sophieu, 
					"@sudung",  _MedXNThongSoMay.sudung, 
					"@ma_test",  _MedXNThongSoMay.ma_test);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedXNThongSoMay vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedXNThongSoMay> _MedXNThongSoMays)
		{
			foreach (MedXNThongSoMay item in _MedXNThongSoMays)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedXNThongSoMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedXNThongSoMay _MedXNThongSoMay, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNThongSoMay] SET id=@id, mayxn=@mayxn, xetnghiem=@xetnghiem, tenfile=@tenfile, filepath=@filepath, mabn=@mabn, sophieu=@sophieu, sudung=@sudung, ma_test=@ma_test WHERE id=@id", 
					"@id",  _MedXNThongSoMay.id, 
					"@mayxn",  _MedXNThongSoMay.mayxn, 
					"@xetnghiem",  _MedXNThongSoMay.xetnghiem, 
					"@tenfile",  _MedXNThongSoMay.tenfile, 
					"@filepath",  _MedXNThongSoMay.filepath, 
					"@mabn",  _MedXNThongSoMay.mabn, 
					"@sophieu",  _MedXNThongSoMay.sophieu, 
					"@sudung",  _MedXNThongSoMay.sudung, 
					"@ma_test",  _MedXNThongSoMay.ma_test, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedXNThongSoMay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedXNThongSoMay _MedXNThongSoMay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNThongSoMay] SET mayxn=@mayxn, xetnghiem=@xetnghiem, tenfile=@tenfile, filepath=@filepath, mabn=@mabn, sophieu=@sophieu, sudung=@sudung, ma_test=@ma_test WHERE id=@id", 
					"@mayxn",  _MedXNThongSoMay.mayxn, 
					"@xetnghiem",  _MedXNThongSoMay.xetnghiem, 
					"@tenfile",  _MedXNThongSoMay.tenfile, 
					"@filepath",  _MedXNThongSoMay.filepath, 
					"@mabn",  _MedXNThongSoMay.mabn, 
					"@sophieu",  _MedXNThongSoMay.sophieu, 
					"@sudung",  _MedXNThongSoMay.sudung, 
					"@ma_test",  _MedXNThongSoMay.ma_test, 
					"@id", _MedXNThongSoMay.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedXNThongSoMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedXNThongSoMay> _MedXNThongSoMays)
		{
			foreach (MedXNThongSoMay item in _MedXNThongSoMays)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedXNThongSoMay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedXNThongSoMay _MedXNThongSoMay, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNThongSoMay] SET id=@id, mayxn=@mayxn, xetnghiem=@xetnghiem, tenfile=@tenfile, filepath=@filepath, mabn=@mabn, sophieu=@sophieu, sudung=@sudung, ma_test=@ma_test "+ condition, 
					"@id",  _MedXNThongSoMay.id, 
					"@mayxn",  _MedXNThongSoMay.mayxn, 
					"@xetnghiem",  _MedXNThongSoMay.xetnghiem, 
					"@tenfile",  _MedXNThongSoMay.tenfile, 
					"@filepath",  _MedXNThongSoMay.filepath, 
					"@mabn",  _MedXNThongSoMay.mabn, 
					"@sophieu",  _MedXNThongSoMay.sophieu, 
					"@sudung",  _MedXNThongSoMay.sudung, 
					"@ma_test",  _MedXNThongSoMay.ma_test);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedXNThongSoMay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNThongSoMay] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNThongSoMay trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedXNThongSoMay _MedXNThongSoMay)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNThongSoMay] WHERE id=@id",
					"@id", _MedXNThongSoMay.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNThongSoMay trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNThongSoMay] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNThongSoMay trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedXNThongSoMay> _MedXNThongSoMays)
		{
			foreach (MedXNThongSoMay item in _MedXNThongSoMays)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
