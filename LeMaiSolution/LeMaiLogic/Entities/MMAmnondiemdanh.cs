using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMAmnondiemdanh:IMAmnondiemdanh
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMAmnondiemdanh(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MamNonDiemDanh từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonDiemDanh]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MamNonDiemDanh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonDiemDanh] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MamNonDiemDanh từ Database
		/// </summary>
		public List<MamNonDiemDanh> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonDiemDanh]");
				List<MamNonDiemDanh> items = new List<MamNonDiemDanh>();
				MamNonDiemDanh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonDiemDanh();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_SoDauBai"] != null && dr["FK_SoDauBai"] != DBNull.Value)
					{
						item.FK_SoDauBai = Convert.ToString(dr["FK_SoDauBai"]);
					}
					if (dr["FK_HocVien"] != null && dr["FK_HocVien"] != DBNull.Value)
					{
						item.FK_HocVien = Convert.ToString(dr["FK_HocVien"]);
					}
					if (dr["CoMat"] != null && dr["CoMat"] != DBNull.Value)
					{
						item.CoMat = Convert.ToBoolean(dr["CoMat"]);
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
		/// Lấy danh sách MamNonDiemDanh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MamNonDiemDanh> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonDiemDanh] A "+ condition,  parameters);
				List<MamNonDiemDanh> items = new List<MamNonDiemDanh>();
				MamNonDiemDanh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonDiemDanh();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_SoDauBai"] != null && dr["FK_SoDauBai"] != DBNull.Value)
					{
						item.FK_SoDauBai = Convert.ToString(dr["FK_SoDauBai"]);
					}
					if (dr["FK_HocVien"] != null && dr["FK_HocVien"] != DBNull.Value)
					{
						item.FK_HocVien = Convert.ToString(dr["FK_HocVien"]);
					}
					if (dr["CoMat"] != null && dr["CoMat"] != DBNull.Value)
					{
						item.CoMat = Convert.ToBoolean(dr["CoMat"]);
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

		public List<MamNonDiemDanh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonDiemDanh] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MamNonDiemDanh] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MamNonDiemDanh>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MamNonDiemDanh từ Database
		/// </summary>
		public MamNonDiemDanh GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonDiemDanh] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MamNonDiemDanh item=new MamNonDiemDanh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_SoDauBai"] != null && dr["FK_SoDauBai"] != DBNull.Value)
						{
							item.FK_SoDauBai = Convert.ToString(dr["FK_SoDauBai"]);
						}
						if (dr["FK_HocVien"] != null && dr["FK_HocVien"] != DBNull.Value)
						{
							item.FK_HocVien = Convert.ToString(dr["FK_HocVien"]);
						}
						if (dr["CoMat"] != null && dr["CoMat"] != DBNull.Value)
						{
							item.CoMat = Convert.ToBoolean(dr["CoMat"]);
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
		/// Lấy một MamNonDiemDanh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MamNonDiemDanh GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonDiemDanh] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MamNonDiemDanh item=new MamNonDiemDanh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_SoDauBai"] != null && dr["FK_SoDauBai"] != DBNull.Value)
						{
							item.FK_SoDauBai = Convert.ToString(dr["FK_SoDauBai"]);
						}
						if (dr["FK_HocVien"] != null && dr["FK_HocVien"] != DBNull.Value)
						{
							item.FK_HocVien = Convert.ToString(dr["FK_HocVien"]);
						}
						if (dr["CoMat"] != null && dr["CoMat"] != DBNull.Value)
						{
							item.CoMat = Convert.ToBoolean(dr["CoMat"]);
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

		public MamNonDiemDanh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonDiemDanh] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MamNonDiemDanh>(ds);
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
		/// Thêm mới MamNonDiemDanh vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MamNonDiemDanh _MamNonDiemDanh)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MamNonDiemDanh](Id, FK_SoDauBai, FK_HocVien, CoMat) VALUES(@Id, @FK_SoDauBai, @FK_HocVien, @CoMat)", 
					"@Id",  _MamNonDiemDanh.Id, 
					"@FK_SoDauBai",  _MamNonDiemDanh.FK_SoDauBai, 
					"@FK_HocVien",  _MamNonDiemDanh.FK_HocVien, 
					"@CoMat",  _MamNonDiemDanh.CoMat);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MamNonDiemDanh vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MamNonDiemDanh> _MamNonDiemDanhs)
		{
			foreach (MamNonDiemDanh item in _MamNonDiemDanhs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonDiemDanh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MamNonDiemDanh _MamNonDiemDanh, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonDiemDanh] SET Id=@Id, FK_SoDauBai=@FK_SoDauBai, FK_HocVien=@FK_HocVien, CoMat=@CoMat WHERE Id=@Id", 
					"@Id",  _MamNonDiemDanh.Id, 
					"@FK_SoDauBai",  _MamNonDiemDanh.FK_SoDauBai, 
					"@FK_HocVien",  _MamNonDiemDanh.FK_HocVien, 
					"@CoMat",  _MamNonDiemDanh.CoMat, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MamNonDiemDanh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MamNonDiemDanh _MamNonDiemDanh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonDiemDanh] SET FK_SoDauBai=@FK_SoDauBai, FK_HocVien=@FK_HocVien, CoMat=@CoMat WHERE Id=@Id", 
					"@FK_SoDauBai",  _MamNonDiemDanh.FK_SoDauBai, 
					"@FK_HocVien",  _MamNonDiemDanh.FK_HocVien, 
					"@CoMat",  _MamNonDiemDanh.CoMat, 
					"@Id", _MamNonDiemDanh.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MamNonDiemDanh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MamNonDiemDanh> _MamNonDiemDanhs)
		{
			foreach (MamNonDiemDanh item in _MamNonDiemDanhs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonDiemDanh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MamNonDiemDanh _MamNonDiemDanh, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonDiemDanh] SET Id=@Id, FK_SoDauBai=@FK_SoDauBai, FK_HocVien=@FK_HocVien, CoMat=@CoMat "+ condition, 
					"@Id",  _MamNonDiemDanh.Id, 
					"@FK_SoDauBai",  _MamNonDiemDanh.FK_SoDauBai, 
					"@FK_HocVien",  _MamNonDiemDanh.FK_HocVien, 
					"@CoMat",  _MamNonDiemDanh.CoMat);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MamNonDiemDanh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonDiemDanh] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonDiemDanh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MamNonDiemDanh _MamNonDiemDanh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonDiemDanh] WHERE Id=@Id",
					"@Id", _MamNonDiemDanh.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonDiemDanh trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonDiemDanh] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonDiemDanh trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MamNonDiemDanh> _MamNonDiemDanhs)
		{
			foreach (MamNonDiemDanh item in _MamNonDiemDanhs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
