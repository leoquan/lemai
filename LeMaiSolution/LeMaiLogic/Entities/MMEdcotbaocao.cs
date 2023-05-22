using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdcotbaocao:IMEdcotbaocao
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdcotbaocao(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedCotBaoCao từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCotBaoCao]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedCotBaoCao từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCotBaoCao] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedCotBaoCao từ Database
		/// </summary>
		public List<MedCotBaoCao> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCotBaoCao]");
				List<MedCotBaoCao> items = new List<MedCotBaoCao>();
				MedCotBaoCao item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedCotBaoCao();
					if (dr["macot"] != null && dr["macot"] != DBNull.Value)
					{
						item.macot = Convert.ToString(dr["macot"]);
					}
					if (dr["tencot"] != null && dr["tencot"] != DBNull.Value)
					{
						item.tencot = Convert.ToString(dr["tencot"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
					}
					if (dr["indexview"] != null && dr["indexview"] != DBNull.Value)
					{
						item.indexview = Convert.ToInt32(dr["indexview"]);
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
		/// Lấy danh sách MedCotBaoCao từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedCotBaoCao> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedCotBaoCao] A "+ condition,  parameters);
				List<MedCotBaoCao> items = new List<MedCotBaoCao>();
				MedCotBaoCao item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedCotBaoCao();
					if (dr["macot"] != null && dr["macot"] != DBNull.Value)
					{
						item.macot = Convert.ToString(dr["macot"]);
					}
					if (dr["tencot"] != null && dr["tencot"] != DBNull.Value)
					{
						item.tencot = Convert.ToString(dr["tencot"]);
					}
					if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
					{
						item.nguoitao = Convert.ToString(dr["nguoitao"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
					}
					if (dr["indexview"] != null && dr["indexview"] != DBNull.Value)
					{
						item.indexview = Convert.ToInt32(dr["indexview"]);
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

		public List<MedCotBaoCao> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedCotBaoCao] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedCotBaoCao] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedCotBaoCao>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedCotBaoCao từ Database
		/// </summary>
		public MedCotBaoCao GetObject(string schema, String macot)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCotBaoCao] where macot=@macot",
					"@macot", macot);
				if (ds.Rows.Count > 0)
				{
					MedCotBaoCao item=new MedCotBaoCao();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["macot"] != null && dr["macot"] != DBNull.Value)
						{
							item.macot = Convert.ToString(dr["macot"]);
						}
						if (dr["tencot"] != null && dr["tencot"] != DBNull.Value)
						{
							item.tencot = Convert.ToString(dr["tencot"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
						}
						if (dr["indexview"] != null && dr["indexview"] != DBNull.Value)
						{
							item.indexview = Convert.ToInt32(dr["indexview"]);
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
		/// Lấy một MedCotBaoCao đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedCotBaoCao GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedCotBaoCao] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedCotBaoCao item=new MedCotBaoCao();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["macot"] != null && dr["macot"] != DBNull.Value)
						{
							item.macot = Convert.ToString(dr["macot"]);
						}
						if (dr["tencot"] != null && dr["tencot"] != DBNull.Value)
						{
							item.tencot = Convert.ToString(dr["tencot"]);
						}
						if (dr["nguoitao"] != null && dr["nguoitao"] != DBNull.Value)
						{
							item.nguoitao = Convert.ToString(dr["nguoitao"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
						}
						if (dr["indexview"] != null && dr["indexview"] != DBNull.Value)
						{
							item.indexview = Convert.ToInt32(dr["indexview"]);
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

		public MedCotBaoCao GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedCotBaoCao] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedCotBaoCao>(ds);
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
		/// Thêm mới MedCotBaoCao vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedCotBaoCao _MedCotBaoCao)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedCotBaoCao](macot, tencot, nguoitao, ngaytao, indexview, macdinh) VALUES(@macot, @tencot, @nguoitao, @ngaytao, @indexview, @macdinh)", 
					"@macot",  _MedCotBaoCao.macot, 
					"@tencot",  _MedCotBaoCao.tencot, 
					"@nguoitao",  _MedCotBaoCao.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedCotBaoCao.ngaytao), 
					"@indexview",  _MedCotBaoCao.indexview, 
					"@macdinh",  _MedCotBaoCao.macdinh);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedCotBaoCao vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedCotBaoCao> _MedCotBaoCaos)
		{
			foreach (MedCotBaoCao item in _MedCotBaoCaos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedCotBaoCao vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedCotBaoCao _MedCotBaoCao, String macot)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedCotBaoCao] SET macot=@macot, tencot=@tencot, nguoitao=@nguoitao, ngaytao=@ngaytao, indexview=@indexview, macdinh=@macdinh WHERE macot=@macot", 
					"@macot",  _MedCotBaoCao.macot, 
					"@tencot",  _MedCotBaoCao.tencot, 
					"@nguoitao",  _MedCotBaoCao.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedCotBaoCao.ngaytao), 
					"@indexview",  _MedCotBaoCao.indexview, 
					"@macdinh",  _MedCotBaoCao.macdinh, 
					"@macot", macot);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedCotBaoCao vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedCotBaoCao _MedCotBaoCao)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedCotBaoCao] SET tencot=@tencot, nguoitao=@nguoitao, ngaytao=@ngaytao, indexview=@indexview, macdinh=@macdinh WHERE macot=@macot", 
					"@tencot",  _MedCotBaoCao.tencot, 
					"@nguoitao",  _MedCotBaoCao.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedCotBaoCao.ngaytao), 
					"@indexview",  _MedCotBaoCao.indexview, 
					"@macdinh",  _MedCotBaoCao.macdinh, 
					"@macot", _MedCotBaoCao.macot);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedCotBaoCao vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedCotBaoCao> _MedCotBaoCaos)
		{
			foreach (MedCotBaoCao item in _MedCotBaoCaos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedCotBaoCao vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedCotBaoCao _MedCotBaoCao, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedCotBaoCao] SET macot=@macot, tencot=@tencot, nguoitao=@nguoitao, ngaytao=@ngaytao, indexview=@indexview, macdinh=@macdinh "+ condition, 
					"@macot",  _MedCotBaoCao.macot, 
					"@tencot",  _MedCotBaoCao.tencot, 
					"@nguoitao",  _MedCotBaoCao.nguoitao, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedCotBaoCao.ngaytao), 
					"@indexview",  _MedCotBaoCao.indexview, 
					"@macdinh",  _MedCotBaoCao.macdinh);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedCotBaoCao trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String macot)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedCotBaoCao] WHERE macot=@macot",
					"@macot", macot);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedCotBaoCao trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedCotBaoCao _MedCotBaoCao)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedCotBaoCao] WHERE macot=@macot",
					"@macot", _MedCotBaoCao.macot);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedCotBaoCao trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedCotBaoCao] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedCotBaoCao trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedCotBaoCao> _MedCotBaoCaos)
		{
			foreach (MedCotBaoCao item in _MedCotBaoCaos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
