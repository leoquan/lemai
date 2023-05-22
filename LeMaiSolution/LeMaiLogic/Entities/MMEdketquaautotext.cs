using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdketquaautotext:IMEdketquaautotext
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdketquaautotext(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKetQuaAutoText từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaAutoText]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKetQuaAutoText từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaAutoText] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKetQuaAutoText từ Database
		/// </summary>
		public List<MedKetQuaAutoText> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaAutoText]");
				List<MedKetQuaAutoText> items = new List<MedKetQuaAutoText>();
				MedKetQuaAutoText item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaAutoText();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["loai"] != null && dr["loai"] != DBNull.Value)
					{
						item.loai = Convert.ToString(dr["loai"]);
					}
					if (dr["macdinh"] != null && dr["macdinh"] != DBNull.Value)
					{
						item.macdinh = Convert.ToString(dr["macdinh"]);
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
		/// Lấy danh sách MedKetQuaAutoText từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKetQuaAutoText> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaAutoText] A "+ condition,  parameters);
				List<MedKetQuaAutoText> items = new List<MedKetQuaAutoText>();
				MedKetQuaAutoText item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaAutoText();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["loai"] != null && dr["loai"] != DBNull.Value)
					{
						item.loai = Convert.ToString(dr["loai"]);
					}
					if (dr["macdinh"] != null && dr["macdinh"] != DBNull.Value)
					{
						item.macdinh = Convert.ToString(dr["macdinh"]);
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

		public List<MedKetQuaAutoText> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaAutoText] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKetQuaAutoText] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKetQuaAutoText>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKetQuaAutoText từ Database
		/// </summary>
		public MedKetQuaAutoText GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaAutoText] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaAutoText item=new MedKetQuaAutoText();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["loai"] != null && dr["loai"] != DBNull.Value)
						{
							item.loai = Convert.ToString(dr["loai"]);
						}
						if (dr["macdinh"] != null && dr["macdinh"] != DBNull.Value)
						{
							item.macdinh = Convert.ToString(dr["macdinh"]);
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
		/// Lấy một MedKetQuaAutoText đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKetQuaAutoText GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaAutoText] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaAutoText item=new MedKetQuaAutoText();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["loai"] != null && dr["loai"] != DBNull.Value)
						{
							item.loai = Convert.ToString(dr["loai"]);
						}
						if (dr["macdinh"] != null && dr["macdinh"] != DBNull.Value)
						{
							item.macdinh = Convert.ToString(dr["macdinh"]);
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

		public MedKetQuaAutoText GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaAutoText] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKetQuaAutoText>(ds);
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
		/// Thêm mới MedKetQuaAutoText vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKetQuaAutoText _MedKetQuaAutoText)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKetQuaAutoText](id, loai, macdinh) VALUES(@id, @loai, @macdinh)", 
					"@id",  _MedKetQuaAutoText.id, 
					"@loai",  _MedKetQuaAutoText.loai, 
					"@macdinh",  _MedKetQuaAutoText.macdinh);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaAutoText vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKetQuaAutoText> _MedKetQuaAutoTexts)
		{
			foreach (MedKetQuaAutoText item in _MedKetQuaAutoTexts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaAutoText vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKetQuaAutoText _MedKetQuaAutoText, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaAutoText] SET id=@id, loai=@loai, macdinh=@macdinh WHERE id=@id", 
					"@id",  _MedKetQuaAutoText.id, 
					"@loai",  _MedKetQuaAutoText.loai, 
					"@macdinh",  _MedKetQuaAutoText.macdinh, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaAutoText vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKetQuaAutoText _MedKetQuaAutoText)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaAutoText] SET loai=@loai, macdinh=@macdinh WHERE id=@id", 
					"@loai",  _MedKetQuaAutoText.loai, 
					"@macdinh",  _MedKetQuaAutoText.macdinh, 
					"@id", _MedKetQuaAutoText.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKetQuaAutoText vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKetQuaAutoText> _MedKetQuaAutoTexts)
		{
			foreach (MedKetQuaAutoText item in _MedKetQuaAutoTexts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaAutoText vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKetQuaAutoText _MedKetQuaAutoText, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaAutoText] SET id=@id, loai=@loai, macdinh=@macdinh "+ condition, 
					"@id",  _MedKetQuaAutoText.id, 
					"@loai",  _MedKetQuaAutoText.loai, 
					"@macdinh",  _MedKetQuaAutoText.macdinh);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKetQuaAutoText trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaAutoText] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaAutoText trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKetQuaAutoText _MedKetQuaAutoText)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaAutoText] WHERE id=@id",
					"@id", _MedKetQuaAutoText.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaAutoText trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaAutoText] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaAutoText trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKetQuaAutoText> _MedKetQuaAutoTexts)
		{
			foreach (MedKetQuaAutoText item in _MedKetQuaAutoTexts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
