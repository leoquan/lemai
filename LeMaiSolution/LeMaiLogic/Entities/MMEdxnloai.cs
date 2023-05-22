using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdxnloai:IMEdxnloai
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdxnloai(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedXNLoai từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNLoai]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedXNLoai từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNLoai] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedXNLoai từ Database
		/// </summary>
		public List<MedXNLoai> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNLoai]");
				List<MedXNLoai> items = new List<MedXNLoai>();
				MedXNLoai item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedXNLoai();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["nhom"] != null && dr["nhom"] != DBNull.Value)
					{
						item.nhom = Convert.ToInt32(dr["nhom"]);
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
					if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
					{
						item.viettat = Convert.ToString(dr["viettat"]);
					}
					if (dr["state"] != null && dr["state"] != DBNull.Value)
					{
						item.state = Convert.ToBoolean(dr["state"]);
					}
					if (dr["tieuban"] != null && dr["tieuban"] != DBNull.Value)
					{
						item.tieuban = Convert.ToDecimal(dr["tieuban"]);
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
		/// Lấy danh sách MedXNLoai từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedXNLoai> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedXNLoai] A "+ condition,  parameters);
				List<MedXNLoai> items = new List<MedXNLoai>();
				MedXNLoai item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedXNLoai();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["nhom"] != null && dr["nhom"] != DBNull.Value)
					{
						item.nhom = Convert.ToInt32(dr["nhom"]);
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
					if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
					{
						item.viettat = Convert.ToString(dr["viettat"]);
					}
					if (dr["state"] != null && dr["state"] != DBNull.Value)
					{
						item.state = Convert.ToBoolean(dr["state"]);
					}
					if (dr["tieuban"] != null && dr["tieuban"] != DBNull.Value)
					{
						item.tieuban = Convert.ToDecimal(dr["tieuban"]);
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

		public List<MedXNLoai> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedXNLoai] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedXNLoai] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedXNLoai>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedXNLoai từ Database
		/// </summary>
		public MedXNLoai GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNLoai] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedXNLoai item=new MedXNLoai();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["nhom"] != null && dr["nhom"] != DBNull.Value)
						{
							item.nhom = Convert.ToInt32(dr["nhom"]);
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
						if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
						{
							item.viettat = Convert.ToString(dr["viettat"]);
						}
						if (dr["state"] != null && dr["state"] != DBNull.Value)
						{
							item.state = Convert.ToBoolean(dr["state"]);
						}
						if (dr["tieuban"] != null && dr["tieuban"] != DBNull.Value)
						{
							item.tieuban = Convert.ToDecimal(dr["tieuban"]);
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
		/// Lấy một MedXNLoai đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedXNLoai GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedXNLoai] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedXNLoai item=new MedXNLoai();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["nhom"] != null && dr["nhom"] != DBNull.Value)
						{
							item.nhom = Convert.ToInt32(dr["nhom"]);
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
						if (dr["viettat"] != null && dr["viettat"] != DBNull.Value)
						{
							item.viettat = Convert.ToString(dr["viettat"]);
						}
						if (dr["state"] != null && dr["state"] != DBNull.Value)
						{
							item.state = Convert.ToBoolean(dr["state"]);
						}
						if (dr["tieuban"] != null && dr["tieuban"] != DBNull.Value)
						{
							item.tieuban = Convert.ToDecimal(dr["tieuban"]);
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

		public MedXNLoai GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedXNLoai] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedXNLoai>(ds);
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
		/// Thêm mới MedXNLoai vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedXNLoai _MedXNLoai)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedXNLoai](id, nhom, stt, ma, ten, viettat, state, tieuban) VALUES(@id, @nhom, @stt, @ma, @ten, @viettat, @state, @tieuban)", 
					"@id",  _MedXNLoai.id, 
					"@nhom",  _MedXNLoai.nhom, 
					"@stt",  _MedXNLoai.stt, 
					"@ma",  _MedXNLoai.ma, 
					"@ten",  _MedXNLoai.ten, 
					"@viettat",  _MedXNLoai.viettat, 
					"@state",  _MedXNLoai.state, 
					"@tieuban",  _MedXNLoai.tieuban);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedXNLoai vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedXNLoai> _MedXNLoais)
		{
			foreach (MedXNLoai item in _MedXNLoais)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedXNLoai vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedXNLoai _MedXNLoai, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNLoai] SET id=@id, nhom=@nhom, stt=@stt, ma=@ma, ten=@ten, viettat=@viettat, state=@state, tieuban=@tieuban WHERE id=@id", 
					"@id",  _MedXNLoai.id, 
					"@nhom",  _MedXNLoai.nhom, 
					"@stt",  _MedXNLoai.stt, 
					"@ma",  _MedXNLoai.ma, 
					"@ten",  _MedXNLoai.ten, 
					"@viettat",  _MedXNLoai.viettat, 
					"@state",  _MedXNLoai.state, 
					"@tieuban",  _MedXNLoai.tieuban, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedXNLoai vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedXNLoai _MedXNLoai)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNLoai] SET nhom=@nhom, stt=@stt, ma=@ma, ten=@ten, viettat=@viettat, state=@state, tieuban=@tieuban WHERE id=@id", 
					"@nhom",  _MedXNLoai.nhom, 
					"@stt",  _MedXNLoai.stt, 
					"@ma",  _MedXNLoai.ma, 
					"@ten",  _MedXNLoai.ten, 
					"@viettat",  _MedXNLoai.viettat, 
					"@state",  _MedXNLoai.state, 
					"@tieuban",  _MedXNLoai.tieuban, 
					"@id", _MedXNLoai.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedXNLoai vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedXNLoai> _MedXNLoais)
		{
			foreach (MedXNLoai item in _MedXNLoais)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedXNLoai vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedXNLoai _MedXNLoai, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNLoai] SET id=@id, nhom=@nhom, stt=@stt, ma=@ma, ten=@ten, viettat=@viettat, state=@state, tieuban=@tieuban "+ condition, 
					"@id",  _MedXNLoai.id, 
					"@nhom",  _MedXNLoai.nhom, 
					"@stt",  _MedXNLoai.stt, 
					"@ma",  _MedXNLoai.ma, 
					"@ten",  _MedXNLoai.ten, 
					"@viettat",  _MedXNLoai.viettat, 
					"@state",  _MedXNLoai.state, 
					"@tieuban",  _MedXNLoai.tieuban);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedXNLoai trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNLoai] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNLoai trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedXNLoai _MedXNLoai)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNLoai] WHERE id=@id",
					"@id", _MedXNLoai.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNLoai trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNLoai] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNLoai trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedXNLoai> _MedXNLoais)
		{
			foreach (MedXNLoai item in _MedXNLoais)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
