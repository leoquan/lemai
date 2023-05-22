using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdphieunhanbenh:IMEdphieunhanbenh
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdphieunhanbenh(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedPhieuNhanBenh từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedPhieuNhanBenh]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedPhieuNhanBenh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedPhieuNhanBenh] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedPhieuNhanBenh từ Database
		/// </summary>
		public List<MedPhieuNhanBenh> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedPhieuNhanBenh]");
				List<MedPhieuNhanBenh> items = new List<MedPhieuNhanBenh>();
				MedPhieuNhanBenh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedPhieuNhanBenh();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_congty"] != null && dr["id_congty"] != DBNull.Value)
					{
						item.id_congty = Convert.ToString(dr["id_congty"]);
					}
					if (dr["tenphieu"] != null && dr["tenphieu"] != DBNull.Value)
					{
						item.tenphieu = Convert.ToString(dr["tenphieu"]);
					}
					if (dr["tungay"] != null && dr["tungay"] != DBNull.Value)
					{
						item.tungay = Convert.ToDateTime(dr["tungay"]);
					}
					if (dr["denngay"] != null && dr["denngay"] != DBNull.Value)
					{
						item.denngay = Convert.ToDateTime(dr["denngay"]);
					}
					if (dr["trangthai"] != null && dr["trangthai"] != DBNull.Value)
					{
						item.trangthai = Convert.ToInt32(dr["trangthai"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["schemaused"] != null && dr["schemaused"] != DBNull.Value)
					{
						item.schemaused = Convert.ToString(dr["schemaused"]);
					}
					if (dr["fk_source"] != null && dr["fk_source"] != DBNull.Value)
					{
						item.fk_source = Convert.ToString(dr["fk_source"]);
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
		/// Lấy danh sách MedPhieuNhanBenh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedPhieuNhanBenh> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedPhieuNhanBenh] A "+ condition,  parameters);
				List<MedPhieuNhanBenh> items = new List<MedPhieuNhanBenh>();
				MedPhieuNhanBenh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedPhieuNhanBenh();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_congty"] != null && dr["id_congty"] != DBNull.Value)
					{
						item.id_congty = Convert.ToString(dr["id_congty"]);
					}
					if (dr["tenphieu"] != null && dr["tenphieu"] != DBNull.Value)
					{
						item.tenphieu = Convert.ToString(dr["tenphieu"]);
					}
					if (dr["tungay"] != null && dr["tungay"] != DBNull.Value)
					{
						item.tungay = Convert.ToDateTime(dr["tungay"]);
					}
					if (dr["denngay"] != null && dr["denngay"] != DBNull.Value)
					{
						item.denngay = Convert.ToDateTime(dr["denngay"]);
					}
					if (dr["trangthai"] != null && dr["trangthai"] != DBNull.Value)
					{
						item.trangthai = Convert.ToInt32(dr["trangthai"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
					{
						item.ngayud = Convert.ToDateTime(dr["ngayud"]);
					}
					if (dr["schemaused"] != null && dr["schemaused"] != DBNull.Value)
					{
						item.schemaused = Convert.ToString(dr["schemaused"]);
					}
					if (dr["fk_source"] != null && dr["fk_source"] != DBNull.Value)
					{
						item.fk_source = Convert.ToString(dr["fk_source"]);
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

		public List<MedPhieuNhanBenh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedPhieuNhanBenh] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedPhieuNhanBenh] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedPhieuNhanBenh>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedPhieuNhanBenh từ Database
		/// </summary>
		public MedPhieuNhanBenh GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedPhieuNhanBenh] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedPhieuNhanBenh item=new MedPhieuNhanBenh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_congty"] != null && dr["id_congty"] != DBNull.Value)
						{
							item.id_congty = Convert.ToString(dr["id_congty"]);
						}
						if (dr["tenphieu"] != null && dr["tenphieu"] != DBNull.Value)
						{
							item.tenphieu = Convert.ToString(dr["tenphieu"]);
						}
						if (dr["tungay"] != null && dr["tungay"] != DBNull.Value)
						{
							item.tungay = Convert.ToDateTime(dr["tungay"]);
						}
						if (dr["denngay"] != null && dr["denngay"] != DBNull.Value)
						{
							item.denngay = Convert.ToDateTime(dr["denngay"]);
						}
						if (dr["trangthai"] != null && dr["trangthai"] != DBNull.Value)
						{
							item.trangthai = Convert.ToInt32(dr["trangthai"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["schemaused"] != null && dr["schemaused"] != DBNull.Value)
						{
							item.schemaused = Convert.ToString(dr["schemaused"]);
						}
						if (dr["fk_source"] != null && dr["fk_source"] != DBNull.Value)
						{
							item.fk_source = Convert.ToString(dr["fk_source"]);
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
		/// Lấy một MedPhieuNhanBenh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedPhieuNhanBenh GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedPhieuNhanBenh] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedPhieuNhanBenh item=new MedPhieuNhanBenh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_congty"] != null && dr["id_congty"] != DBNull.Value)
						{
							item.id_congty = Convert.ToString(dr["id_congty"]);
						}
						if (dr["tenphieu"] != null && dr["tenphieu"] != DBNull.Value)
						{
							item.tenphieu = Convert.ToString(dr["tenphieu"]);
						}
						if (dr["tungay"] != null && dr["tungay"] != DBNull.Value)
						{
							item.tungay = Convert.ToDateTime(dr["tungay"]);
						}
						if (dr["denngay"] != null && dr["denngay"] != DBNull.Value)
						{
							item.denngay = Convert.ToDateTime(dr["denngay"]);
						}
						if (dr["trangthai"] != null && dr["trangthai"] != DBNull.Value)
						{
							item.trangthai = Convert.ToInt32(dr["trangthai"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["ngayud"] != null && dr["ngayud"] != DBNull.Value)
						{
							item.ngayud = Convert.ToDateTime(dr["ngayud"]);
						}
						if (dr["schemaused"] != null && dr["schemaused"] != DBNull.Value)
						{
							item.schemaused = Convert.ToString(dr["schemaused"]);
						}
						if (dr["fk_source"] != null && dr["fk_source"] != DBNull.Value)
						{
							item.fk_source = Convert.ToString(dr["fk_source"]);
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

		public MedPhieuNhanBenh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedPhieuNhanBenh] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedPhieuNhanBenh>(ds);
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
		/// Thêm mới MedPhieuNhanBenh vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedPhieuNhanBenh _MedPhieuNhanBenh)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedPhieuNhanBenh](id, id_congty, tenphieu, tungay, denngay, trangthai, ghichu, userid, ngayud, schemaused, fk_source) VALUES(@id, @id_congty, @tenphieu, @tungay, @denngay, @trangthai, @ghichu, @userid, @ngayud, @schemaused, @fk_source)", 
					"@id",  _MedPhieuNhanBenh.id, 
					"@id_congty",  _MedPhieuNhanBenh.id_congty, 
					"@tenphieu",  _MedPhieuNhanBenh.tenphieu, 
					"@tungay", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.tungay), 
					"@denngay", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.denngay), 
					"@trangthai",  _MedPhieuNhanBenh.trangthai, 
					"@ghichu",  _MedPhieuNhanBenh.ghichu, 
					"@userid",  _MedPhieuNhanBenh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.ngayud), 
					"@schemaused",  _MedPhieuNhanBenh.schemaused, 
					"@fk_source",  _MedPhieuNhanBenh.fk_source);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedPhieuNhanBenh vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedPhieuNhanBenh> _MedPhieuNhanBenhs)
		{
			foreach (MedPhieuNhanBenh item in _MedPhieuNhanBenhs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedPhieuNhanBenh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedPhieuNhanBenh _MedPhieuNhanBenh, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedPhieuNhanBenh] SET id=@id, id_congty=@id_congty, tenphieu=@tenphieu, tungay=@tungay, denngay=@denngay, trangthai=@trangthai, ghichu=@ghichu, userid=@userid, ngayud=@ngayud, schemaused=@schemaused, fk_source=@fk_source WHERE id=@id", 
					"@id",  _MedPhieuNhanBenh.id, 
					"@id_congty",  _MedPhieuNhanBenh.id_congty, 
					"@tenphieu",  _MedPhieuNhanBenh.tenphieu, 
					"@tungay", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.tungay), 
					"@denngay", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.denngay), 
					"@trangthai",  _MedPhieuNhanBenh.trangthai, 
					"@ghichu",  _MedPhieuNhanBenh.ghichu, 
					"@userid",  _MedPhieuNhanBenh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.ngayud), 
					"@schemaused",  _MedPhieuNhanBenh.schemaused, 
					"@fk_source",  _MedPhieuNhanBenh.fk_source, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedPhieuNhanBenh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedPhieuNhanBenh _MedPhieuNhanBenh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedPhieuNhanBenh] SET id_congty=@id_congty, tenphieu=@tenphieu, tungay=@tungay, denngay=@denngay, trangthai=@trangthai, ghichu=@ghichu, userid=@userid, ngayud=@ngayud, schemaused=@schemaused, fk_source=@fk_source WHERE id=@id", 
					"@id_congty",  _MedPhieuNhanBenh.id_congty, 
					"@tenphieu",  _MedPhieuNhanBenh.tenphieu, 
					"@tungay", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.tungay), 
					"@denngay", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.denngay), 
					"@trangthai",  _MedPhieuNhanBenh.trangthai, 
					"@ghichu",  _MedPhieuNhanBenh.ghichu, 
					"@userid",  _MedPhieuNhanBenh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.ngayud), 
					"@schemaused",  _MedPhieuNhanBenh.schemaused, 
					"@fk_source",  _MedPhieuNhanBenh.fk_source, 
					"@id", _MedPhieuNhanBenh.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedPhieuNhanBenh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedPhieuNhanBenh> _MedPhieuNhanBenhs)
		{
			foreach (MedPhieuNhanBenh item in _MedPhieuNhanBenhs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedPhieuNhanBenh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedPhieuNhanBenh _MedPhieuNhanBenh, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedPhieuNhanBenh] SET id=@id, id_congty=@id_congty, tenphieu=@tenphieu, tungay=@tungay, denngay=@denngay, trangthai=@trangthai, ghichu=@ghichu, userid=@userid, ngayud=@ngayud, schemaused=@schemaused, fk_source=@fk_source "+ condition, 
					"@id",  _MedPhieuNhanBenh.id, 
					"@id_congty",  _MedPhieuNhanBenh.id_congty, 
					"@tenphieu",  _MedPhieuNhanBenh.tenphieu, 
					"@tungay", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.tungay), 
					"@denngay", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.denngay), 
					"@trangthai",  _MedPhieuNhanBenh.trangthai, 
					"@ghichu",  _MedPhieuNhanBenh.ghichu, 
					"@userid",  _MedPhieuNhanBenh.userid, 
					"@ngayud", this._dataContext.ConvertDateString( _MedPhieuNhanBenh.ngayud), 
					"@schemaused",  _MedPhieuNhanBenh.schemaused, 
					"@fk_source",  _MedPhieuNhanBenh.fk_source);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedPhieuNhanBenh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedPhieuNhanBenh] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedPhieuNhanBenh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedPhieuNhanBenh _MedPhieuNhanBenh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedPhieuNhanBenh] WHERE id=@id",
					"@id", _MedPhieuNhanBenh.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedPhieuNhanBenh trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedPhieuNhanBenh] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedPhieuNhanBenh trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedPhieuNhanBenh> _MedPhieuNhanBenhs)
		{
			foreach (MedPhieuNhanBenh item in _MedPhieuNhanBenhs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
