using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdketquamayxn:IMEdketquamayxn
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdketquamayxn(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKetQuaMayXN từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaMayXN]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKetQuaMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaMayXN] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKetQuaMayXN từ Database
		/// </summary>
		public List<MedKetQuaMayXN> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaMayXN]");
				List<MedKetQuaMayXN> items = new List<MedKetQuaMayXN>();
				MedKetQuaMayXN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaMayXN();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["sttlm"] != null && dr["sttlm"] != DBNull.Value)
					{
						item.sttlm = Convert.ToInt32(dr["sttlm"]);
					}
					if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
					{
						item.ngay = Convert.ToString(dr["ngay"]);
					}
					if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
					{
						item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
					}
					if (dr["ketqua"] != null && dr["ketqua"] != DBNull.Value)
					{
						item.ketqua = Convert.ToString(dr["ketqua"]);
					}
					if (dr["ketquabd1"] != null && dr["ketquabd1"] != DBNull.Value)
					{
						item.ketquabd1 = Convert.ToString(dr["ketquabd1"]);
					}
					if (dr["ketquabd2"] != null && dr["ketquabd2"] != DBNull.Value)
					{
						item.ketquabd2 = Convert.ToString(dr["ketquabd2"]);
					}
					if (dr["ketquabd3"] != null && dr["ketquabd3"] != DBNull.Value)
					{
						item.ketquabd3 = Convert.ToString(dr["ketquabd3"]);
					}
					if (dr["ketquabd4"] != null && dr["ketquabd4"] != DBNull.Value)
					{
						item.ketquabd4 = Convert.ToString(dr["ketquabd4"]);
					}
					if (dr["ketquabd5"] != null && dr["ketquabd5"] != DBNull.Value)
					{
						item.ketquabd5 = Convert.ToString(dr["ketquabd5"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["isvalid"] != null && dr["isvalid"] != DBNull.Value)
					{
						item.isvalid = Convert.ToInt32(dr["isvalid"]);
					}
					if (dr["user_valid"] != null && dr["user_valid"] != DBNull.Value)
					{
						item.user_valid = Convert.ToString(dr["user_valid"]);
					}
					if (dr["date_valid"] != null && dr["date_valid"] != DBNull.Value)
					{
						item.date_valid = Convert.ToDateTime(dr["date_valid"]);
					}
					if (dr["note_valid"] != null && dr["note_valid"] != DBNull.Value)
					{
						item.note_valid = Convert.ToString(dr["note_valid"]);
					}
					if (dr["fk_workspace"] != null && dr["fk_workspace"] != DBNull.Value)
					{
						item.fk_workspace = Convert.ToString(dr["fk_workspace"]);
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
		/// Lấy danh sách MedKetQuaMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKetQuaMayXN> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaMayXN] A "+ condition,  parameters);
				List<MedKetQuaMayXN> items = new List<MedKetQuaMayXN>();
				MedKetQuaMayXN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaMayXN();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["sttlm"] != null && dr["sttlm"] != DBNull.Value)
					{
						item.sttlm = Convert.ToInt32(dr["sttlm"]);
					}
					if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
					{
						item.ngay = Convert.ToString(dr["ngay"]);
					}
					if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
					{
						item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
					}
					if (dr["ketqua"] != null && dr["ketqua"] != DBNull.Value)
					{
						item.ketqua = Convert.ToString(dr["ketqua"]);
					}
					if (dr["ketquabd1"] != null && dr["ketquabd1"] != DBNull.Value)
					{
						item.ketquabd1 = Convert.ToString(dr["ketquabd1"]);
					}
					if (dr["ketquabd2"] != null && dr["ketquabd2"] != DBNull.Value)
					{
						item.ketquabd2 = Convert.ToString(dr["ketquabd2"]);
					}
					if (dr["ketquabd3"] != null && dr["ketquabd3"] != DBNull.Value)
					{
						item.ketquabd3 = Convert.ToString(dr["ketquabd3"]);
					}
					if (dr["ketquabd4"] != null && dr["ketquabd4"] != DBNull.Value)
					{
						item.ketquabd4 = Convert.ToString(dr["ketquabd4"]);
					}
					if (dr["ketquabd5"] != null && dr["ketquabd5"] != DBNull.Value)
					{
						item.ketquabd5 = Convert.ToString(dr["ketquabd5"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["isvalid"] != null && dr["isvalid"] != DBNull.Value)
					{
						item.isvalid = Convert.ToInt32(dr["isvalid"]);
					}
					if (dr["user_valid"] != null && dr["user_valid"] != DBNull.Value)
					{
						item.user_valid = Convert.ToString(dr["user_valid"]);
					}
					if (dr["date_valid"] != null && dr["date_valid"] != DBNull.Value)
					{
						item.date_valid = Convert.ToDateTime(dr["date_valid"]);
					}
					if (dr["note_valid"] != null && dr["note_valid"] != DBNull.Value)
					{
						item.note_valid = Convert.ToString(dr["note_valid"]);
					}
					if (dr["fk_workspace"] != null && dr["fk_workspace"] != DBNull.Value)
					{
						item.fk_workspace = Convert.ToString(dr["fk_workspace"]);
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

		public List<MedKetQuaMayXN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaMayXN] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKetQuaMayXN] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKetQuaMayXN>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKetQuaMayXN từ Database
		/// </summary>
		public MedKetQuaMayXN GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaMayXN] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaMayXN item=new MedKetQuaMayXN();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["sttlm"] != null && dr["sttlm"] != DBNull.Value)
						{
							item.sttlm = Convert.ToInt32(dr["sttlm"]);
						}
						if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
						{
							item.ngay = Convert.ToString(dr["ngay"]);
						}
						if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
						{
							item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
						}
						if (dr["ketqua"] != null && dr["ketqua"] != DBNull.Value)
						{
							item.ketqua = Convert.ToString(dr["ketqua"]);
						}
						if (dr["ketquabd1"] != null && dr["ketquabd1"] != DBNull.Value)
						{
							item.ketquabd1 = Convert.ToString(dr["ketquabd1"]);
						}
						if (dr["ketquabd2"] != null && dr["ketquabd2"] != DBNull.Value)
						{
							item.ketquabd2 = Convert.ToString(dr["ketquabd2"]);
						}
						if (dr["ketquabd3"] != null && dr["ketquabd3"] != DBNull.Value)
						{
							item.ketquabd3 = Convert.ToString(dr["ketquabd3"]);
						}
						if (dr["ketquabd4"] != null && dr["ketquabd4"] != DBNull.Value)
						{
							item.ketquabd4 = Convert.ToString(dr["ketquabd4"]);
						}
						if (dr["ketquabd5"] != null && dr["ketquabd5"] != DBNull.Value)
						{
							item.ketquabd5 = Convert.ToString(dr["ketquabd5"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["isvalid"] != null && dr["isvalid"] != DBNull.Value)
						{
							item.isvalid = Convert.ToInt32(dr["isvalid"]);
						}
						if (dr["user_valid"] != null && dr["user_valid"] != DBNull.Value)
						{
							item.user_valid = Convert.ToString(dr["user_valid"]);
						}
						if (dr["date_valid"] != null && dr["date_valid"] != DBNull.Value)
						{
							item.date_valid = Convert.ToDateTime(dr["date_valid"]);
						}
						if (dr["note_valid"] != null && dr["note_valid"] != DBNull.Value)
						{
							item.note_valid = Convert.ToString(dr["note_valid"]);
						}
						if (dr["fk_workspace"] != null && dr["fk_workspace"] != DBNull.Value)
						{
							item.fk_workspace = Convert.ToString(dr["fk_workspace"]);
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
		/// Lấy một MedKetQuaMayXN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKetQuaMayXN GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaMayXN] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaMayXN item=new MedKetQuaMayXN();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["sttlm"] != null && dr["sttlm"] != DBNull.Value)
						{
							item.sttlm = Convert.ToInt32(dr["sttlm"]);
						}
						if (dr["ngay"] != null && dr["ngay"] != DBNull.Value)
						{
							item.ngay = Convert.ToString(dr["ngay"]);
						}
						if (dr["id_mayxn"] != null && dr["id_mayxn"] != DBNull.Value)
						{
							item.id_mayxn = Convert.ToInt32(dr["id_mayxn"]);
						}
						if (dr["ketqua"] != null && dr["ketqua"] != DBNull.Value)
						{
							item.ketqua = Convert.ToString(dr["ketqua"]);
						}
						if (dr["ketquabd1"] != null && dr["ketquabd1"] != DBNull.Value)
						{
							item.ketquabd1 = Convert.ToString(dr["ketquabd1"]);
						}
						if (dr["ketquabd2"] != null && dr["ketquabd2"] != DBNull.Value)
						{
							item.ketquabd2 = Convert.ToString(dr["ketquabd2"]);
						}
						if (dr["ketquabd3"] != null && dr["ketquabd3"] != DBNull.Value)
						{
							item.ketquabd3 = Convert.ToString(dr["ketquabd3"]);
						}
						if (dr["ketquabd4"] != null && dr["ketquabd4"] != DBNull.Value)
						{
							item.ketquabd4 = Convert.ToString(dr["ketquabd4"]);
						}
						if (dr["ketquabd5"] != null && dr["ketquabd5"] != DBNull.Value)
						{
							item.ketquabd5 = Convert.ToString(dr["ketquabd5"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["isvalid"] != null && dr["isvalid"] != DBNull.Value)
						{
							item.isvalid = Convert.ToInt32(dr["isvalid"]);
						}
						if (dr["user_valid"] != null && dr["user_valid"] != DBNull.Value)
						{
							item.user_valid = Convert.ToString(dr["user_valid"]);
						}
						if (dr["date_valid"] != null && dr["date_valid"] != DBNull.Value)
						{
							item.date_valid = Convert.ToDateTime(dr["date_valid"]);
						}
						if (dr["note_valid"] != null && dr["note_valid"] != DBNull.Value)
						{
							item.note_valid = Convert.ToString(dr["note_valid"]);
						}
						if (dr["fk_workspace"] != null && dr["fk_workspace"] != DBNull.Value)
						{
							item.fk_workspace = Convert.ToString(dr["fk_workspace"]);
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

		public MedKetQuaMayXN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaMayXN] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKetQuaMayXN>(ds);
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
		/// Thêm mới MedKetQuaMayXN vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKetQuaMayXN _MedKetQuaMayXN)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKetQuaMayXN](id, sttlm, ngay, id_mayxn, ketqua, ketquabd1, ketquabd2, ketquabd3, ketquabd4, ketquabd5, ghichu, ngayud, isvalid, user_valid, date_valid, note_valid, fk_workspace) VALUES(@id, @sttlm, @ngay, @id_mayxn, @ketqua, @ketquabd1, @ketquabd2, @ketquabd3, @ketquabd4, @ketquabd5, @ghichu, @ngayud, @isvalid, @user_valid, @date_valid, @note_valid, @fk_workspace)", 
					"@id",  _MedKetQuaMayXN.id, 
					"@sttlm",  _MedKetQuaMayXN.sttlm, 
					"@ngay",  _MedKetQuaMayXN.ngay, 
					"@id_mayxn",  _MedKetQuaMayXN.id_mayxn, 
					"@ketqua",  _MedKetQuaMayXN.ketqua, 
					"@ketquabd1",  _MedKetQuaMayXN.ketquabd1, 
					"@ketquabd2",  _MedKetQuaMayXN.ketquabd2, 
					"@ketquabd3",  _MedKetQuaMayXN.ketquabd3, 
					"@ketquabd4",  _MedKetQuaMayXN.ketquabd4, 
					"@ketquabd5",  _MedKetQuaMayXN.ketquabd5, 
					"@ghichu",  _MedKetQuaMayXN.ghichu, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQuaMayXN.ngayud), 
					"@isvalid",  _MedKetQuaMayXN.isvalid, 
					"@user_valid",  _MedKetQuaMayXN.user_valid, 
					"@date_valid", this._dataContext.ConvertDateString( _MedKetQuaMayXN.date_valid), 
					"@note_valid",  _MedKetQuaMayXN.note_valid, 
					"@fk_workspace",  _MedKetQuaMayXN.fk_workspace);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaMayXN vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKetQuaMayXN> _MedKetQuaMayXNs)
		{
			foreach (MedKetQuaMayXN item in _MedKetQuaMayXNs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKetQuaMayXN _MedKetQuaMayXN, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaMayXN] SET id=@id, sttlm=@sttlm, ngay=@ngay, id_mayxn=@id_mayxn, ketqua=@ketqua, ketquabd1=@ketquabd1, ketquabd2=@ketquabd2, ketquabd3=@ketquabd3, ketquabd4=@ketquabd4, ketquabd5=@ketquabd5, ghichu=@ghichu, ngayud=@ngayud, isvalid=@isvalid, user_valid=@user_valid, date_valid=@date_valid, note_valid=@note_valid, fk_workspace=@fk_workspace WHERE id=@id", 
					"@id",  _MedKetQuaMayXN.id, 
					"@sttlm",  _MedKetQuaMayXN.sttlm, 
					"@ngay",  _MedKetQuaMayXN.ngay, 
					"@id_mayxn",  _MedKetQuaMayXN.id_mayxn, 
					"@ketqua",  _MedKetQuaMayXN.ketqua, 
					"@ketquabd1",  _MedKetQuaMayXN.ketquabd1, 
					"@ketquabd2",  _MedKetQuaMayXN.ketquabd2, 
					"@ketquabd3",  _MedKetQuaMayXN.ketquabd3, 
					"@ketquabd4",  _MedKetQuaMayXN.ketquabd4, 
					"@ketquabd5",  _MedKetQuaMayXN.ketquabd5, 
					"@ghichu",  _MedKetQuaMayXN.ghichu, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQuaMayXN.ngayud), 
					"@isvalid",  _MedKetQuaMayXN.isvalid, 
					"@user_valid",  _MedKetQuaMayXN.user_valid, 
					"@date_valid", this._dataContext.ConvertDateString( _MedKetQuaMayXN.date_valid), 
					"@note_valid",  _MedKetQuaMayXN.note_valid, 
					"@fk_workspace",  _MedKetQuaMayXN.fk_workspace, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaMayXN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKetQuaMayXN _MedKetQuaMayXN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaMayXN] SET sttlm=@sttlm, ngay=@ngay, id_mayxn=@id_mayxn, ketqua=@ketqua, ketquabd1=@ketquabd1, ketquabd2=@ketquabd2, ketquabd3=@ketquabd3, ketquabd4=@ketquabd4, ketquabd5=@ketquabd5, ghichu=@ghichu, ngayud=@ngayud, isvalid=@isvalid, user_valid=@user_valid, date_valid=@date_valid, note_valid=@note_valid, fk_workspace=@fk_workspace WHERE id=@id", 
					"@sttlm",  _MedKetQuaMayXN.sttlm, 
					"@ngay",  _MedKetQuaMayXN.ngay, 
					"@id_mayxn",  _MedKetQuaMayXN.id_mayxn, 
					"@ketqua",  _MedKetQuaMayXN.ketqua, 
					"@ketquabd1",  _MedKetQuaMayXN.ketquabd1, 
					"@ketquabd2",  _MedKetQuaMayXN.ketquabd2, 
					"@ketquabd3",  _MedKetQuaMayXN.ketquabd3, 
					"@ketquabd4",  _MedKetQuaMayXN.ketquabd4, 
					"@ketquabd5",  _MedKetQuaMayXN.ketquabd5, 
					"@ghichu",  _MedKetQuaMayXN.ghichu, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQuaMayXN.ngayud), 
					"@isvalid",  _MedKetQuaMayXN.isvalid, 
					"@user_valid",  _MedKetQuaMayXN.user_valid, 
					"@date_valid", this._dataContext.ConvertDateString( _MedKetQuaMayXN.date_valid), 
					"@note_valid",  _MedKetQuaMayXN.note_valid, 
					"@fk_workspace",  _MedKetQuaMayXN.fk_workspace, 
					"@id", _MedKetQuaMayXN.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKetQuaMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKetQuaMayXN> _MedKetQuaMayXNs)
		{
			foreach (MedKetQuaMayXN item in _MedKetQuaMayXNs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaMayXN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKetQuaMayXN _MedKetQuaMayXN, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaMayXN] SET id=@id, sttlm=@sttlm, ngay=@ngay, id_mayxn=@id_mayxn, ketqua=@ketqua, ketquabd1=@ketquabd1, ketquabd2=@ketquabd2, ketquabd3=@ketquabd3, ketquabd4=@ketquabd4, ketquabd5=@ketquabd5, ghichu=@ghichu, ngayud=@ngayud, isvalid=@isvalid, user_valid=@user_valid, date_valid=@date_valid, note_valid=@note_valid, fk_workspace=@fk_workspace "+ condition, 
					"@id",  _MedKetQuaMayXN.id, 
					"@sttlm",  _MedKetQuaMayXN.sttlm, 
					"@ngay",  _MedKetQuaMayXN.ngay, 
					"@id_mayxn",  _MedKetQuaMayXN.id_mayxn, 
					"@ketqua",  _MedKetQuaMayXN.ketqua, 
					"@ketquabd1",  _MedKetQuaMayXN.ketquabd1, 
					"@ketquabd2",  _MedKetQuaMayXN.ketquabd2, 
					"@ketquabd3",  _MedKetQuaMayXN.ketquabd3, 
					"@ketquabd4",  _MedKetQuaMayXN.ketquabd4, 
					"@ketquabd5",  _MedKetQuaMayXN.ketquabd5, 
					"@ghichu",  _MedKetQuaMayXN.ghichu, 
					"@ngayud", this._dataContext.ConvertDateString( _MedKetQuaMayXN.ngayud), 
					"@isvalid",  _MedKetQuaMayXN.isvalid, 
					"@user_valid",  _MedKetQuaMayXN.user_valid, 
					"@date_valid", this._dataContext.ConvertDateString( _MedKetQuaMayXN.date_valid), 
					"@note_valid",  _MedKetQuaMayXN.note_valid, 
					"@fk_workspace",  _MedKetQuaMayXN.fk_workspace);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKetQuaMayXN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaMayXN] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaMayXN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKetQuaMayXN _MedKetQuaMayXN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaMayXN] WHERE id=@id",
					"@id", _MedKetQuaMayXN.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaMayXN trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaMayXN] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaMayXN trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKetQuaMayXN> _MedKetQuaMayXNs)
		{
			foreach (MedKetQuaMayXN item in _MedKetQuaMayXNs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
