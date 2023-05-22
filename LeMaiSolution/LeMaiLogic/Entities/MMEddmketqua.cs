using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEddmketqua:IMEddmketqua
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEddmketqua(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedDmKetQua từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmKetQua]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedDmKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmKetQua] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedDmKetQua từ Database
		/// </summary>
		public List<MedDmKetQua> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmKetQua]");
				List<MedDmKetQua> items = new List<MedDmKetQua>();
				MedDmKetQua item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedDmKetQua();
					if (dr["dmten"] != null && dr["dmten"] != DBNull.Value)
					{
						item.dmten = Convert.ToInt32(dr["dmten"]);
					}
					if (dr["idten"] != null && dr["idten"] != DBNull.Value)
					{
						item.idten = Convert.ToInt32(dr["idten"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
					{
						item.viettat = Convert.ToString(dr["viettat"]);
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
		/// Lấy danh sách MedDmKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedDmKetQua> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedDmKetQua] A "+ condition,  parameters);
				List<MedDmKetQua> items = new List<MedDmKetQua>();
				MedDmKetQua item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedDmKetQua();
					if (dr["dmten"] != null && dr["dmten"] != DBNull.Value)
					{
						item.dmten = Convert.ToInt32(dr["dmten"]);
					}
					if (dr["idten"] != null && dr["idten"] != DBNull.Value)
					{
						item.idten = Convert.ToInt32(dr["idten"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
					{
						item.viettat = Convert.ToString(dr["viettat"]);
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

		public List<MedDmKetQua> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedDmKetQua] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedDmKetQua] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedDmKetQua>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedDmKetQua từ Database
		/// </summary>
		public MedDmKetQua GetObject(string schema, Int32 dmten, Int32 idten)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmKetQua] where dmten=@dmten and idten=@idten",
					"@dmten", dmten, 
					"@idten", idten);
				if (ds.Rows.Count > 0)
				{
					MedDmKetQua item=new MedDmKetQua();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["dmten"] != null && dr["dmten"] != DBNull.Value)
						{
							item.dmten = Convert.ToInt32(dr["dmten"]);
						}
						if (dr["idten"] != null && dr["idten"] != DBNull.Value)
						{
							item.idten = Convert.ToInt32(dr["idten"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
						{
							item.viettat = Convert.ToString(dr["viettat"]);
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
		/// Lấy một MedDmKetQua đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedDmKetQua GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedDmKetQua] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedDmKetQua item=new MedDmKetQua();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["dmten"] != null && dr["dmten"] != DBNull.Value)
						{
							item.dmten = Convert.ToInt32(dr["dmten"]);
						}
						if (dr["idten"] != null && dr["idten"] != DBNull.Value)
						{
							item.idten = Convert.ToInt32(dr["idten"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
						{
							item.viettat = Convert.ToString(dr["viettat"]);
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

		public MedDmKetQua GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedDmKetQua] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedDmKetQua>(ds);
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
		/// Thêm mới MedDmKetQua vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedDmKetQua _MedDmKetQua)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedDmKetQua](dmten, idten, stt, viettat) VALUES(@dmten, @idten, @stt, @viettat)", 
					"@dmten",  _MedDmKetQua.dmten, 
					"@idten",  _MedDmKetQua.idten, 
					"@stt",  _MedDmKetQua.stt, 
					"@viettat",  _MedDmKetQua.viettat);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedDmKetQua vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedDmKetQua> _MedDmKetQuas)
		{
			foreach (MedDmKetQua item in _MedDmKetQuas)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedDmKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedDmKetQua _MedDmKetQua, Int32 dmten, Int32 idten)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmKetQua] SET dmten=@dmten, idten=@idten, stt=@stt, viettat=@viettat WHERE dmten=@dmten and idten=@idten", 
					"@dmten",  _MedDmKetQua.dmten, 
					"@idten",  _MedDmKetQua.idten, 
					"@stt",  _MedDmKetQua.stt, 
					"@viettat",  _MedDmKetQua.viettat, 
					"@dmten", dmten, 
					"@idten", idten);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedDmKetQua vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedDmKetQua _MedDmKetQua)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmKetQua] SET stt=@stt, viettat=@viettat WHERE dmten=@dmten and idten=@idten", 
					"@stt",  _MedDmKetQua.stt, 
					"@viettat",  _MedDmKetQua.viettat, 
					"@dmten", _MedDmKetQua.dmten, 
					"@idten", _MedDmKetQua.idten);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedDmKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedDmKetQua> _MedDmKetQuas)
		{
			foreach (MedDmKetQua item in _MedDmKetQuas)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedDmKetQua vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedDmKetQua _MedDmKetQua, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmKetQua] SET dmten=@dmten, idten=@idten, stt=@stt, viettat=@viettat "+ condition, 
					"@dmten",  _MedDmKetQua.dmten, 
					"@idten",  _MedDmKetQua.idten, 
					"@stt",  _MedDmKetQua.stt, 
					"@viettat",  _MedDmKetQua.viettat);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedDmKetQua trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 dmten, Int32 idten)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmKetQua] WHERE dmten=@dmten and idten=@idten",
					"@dmten", dmten, 
					"@idten", idten);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmKetQua trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedDmKetQua _MedDmKetQua)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmKetQua] WHERE dmten=@dmten and idten=@idten",
					"@dmten", _MedDmKetQua.dmten, 
					"@idten", _MedDmKetQua.idten);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmKetQua trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmKetQua] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmKetQua trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedDmKetQua> _MedDmKetQuas)
		{
			foreach (MedDmKetQua item in _MedDmKetQuas)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
