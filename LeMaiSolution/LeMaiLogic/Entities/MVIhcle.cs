using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIhcle:IVIhcle
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIhcle(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable Vihcle từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Vihcle]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable Vihcle từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Vihcle] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách Vihcle từ Database
		/// </summary>
		public List<Vihcle> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Vihcle]");
				List<Vihcle> items = new List<Vihcle>();
				Vihcle item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Vihcle();
					if (dr["BienSo"] != null && dr["BienSo"] != DBNull.Value)
					{
						item.BienSo = Convert.ToString(dr["BienSo"]);
					}
					if (dr["TenXe"] != null && dr["TenXe"] != DBNull.Value)
					{
						item.TenXe = Convert.ToString(dr["TenXe"]);
					}
					if (dr["NgayMua"] != null && dr["NgayMua"] != DBNull.Value)
					{
						item.NgayMua = Convert.ToDateTime(dr["NgayMua"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["SoLuongNhot"] != null && dr["SoLuongNhot"] != DBNull.Value)
					{
						item.SoLuongNhot = Convert.ToDecimal(dr["SoLuongNhot"]);
					}
					if (dr["SoLuongNhotLoc"] != null && dr["SoLuongNhotLoc"] != DBNull.Value)
					{
						item.SoLuongNhotLoc = Convert.ToDecimal(dr["SoLuongNhotLoc"]);
					}
					if (dr["MaLocNhot"] != null && dr["MaLocNhot"] != DBNull.Value)
					{
						item.MaLocNhot = Convert.ToString(dr["MaLocNhot"]);
					}
					if (dr["MaLocDau"] != null && dr["MaLocDau"] != DBNull.Value)
					{
						item.MaLocDau = Convert.ToString(dr["MaLocDau"]);
					}
					if (dr["MaMay"] != null && dr["MaMay"] != DBNull.Value)
					{
						item.MaMay = Convert.ToString(dr["MaMay"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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
		/// Lấy danh sách Vihcle từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<Vihcle> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Vihcle] A "+ condition,  parameters);
				List<Vihcle> items = new List<Vihcle>();
				Vihcle item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Vihcle();
					if (dr["BienSo"] != null && dr["BienSo"] != DBNull.Value)
					{
						item.BienSo = Convert.ToString(dr["BienSo"]);
					}
					if (dr["TenXe"] != null && dr["TenXe"] != DBNull.Value)
					{
						item.TenXe = Convert.ToString(dr["TenXe"]);
					}
					if (dr["NgayMua"] != null && dr["NgayMua"] != DBNull.Value)
					{
						item.NgayMua = Convert.ToDateTime(dr["NgayMua"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["SoLuongNhot"] != null && dr["SoLuongNhot"] != DBNull.Value)
					{
						item.SoLuongNhot = Convert.ToDecimal(dr["SoLuongNhot"]);
					}
					if (dr["SoLuongNhotLoc"] != null && dr["SoLuongNhotLoc"] != DBNull.Value)
					{
						item.SoLuongNhotLoc = Convert.ToDecimal(dr["SoLuongNhotLoc"]);
					}
					if (dr["MaLocNhot"] != null && dr["MaLocNhot"] != DBNull.Value)
					{
						item.MaLocNhot = Convert.ToString(dr["MaLocNhot"]);
					}
					if (dr["MaLocDau"] != null && dr["MaLocDau"] != DBNull.Value)
					{
						item.MaLocDau = Convert.ToString(dr["MaLocDau"]);
					}
					if (dr["MaMay"] != null && dr["MaMay"] != DBNull.Value)
					{
						item.MaMay = Convert.ToString(dr["MaMay"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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

		public List<Vihcle> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Vihcle] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[Vihcle] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<Vihcle>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một Vihcle từ Database
		/// </summary>
		public Vihcle GetObject(string schema, String BienSo)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Vihcle] where BienSo=@BienSo",
					"@BienSo", BienSo);
				if (ds.Rows.Count > 0)
				{
					Vihcle item=new Vihcle();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BienSo"] != null && dr["BienSo"] != DBNull.Value)
						{
							item.BienSo = Convert.ToString(dr["BienSo"]);
						}
						if (dr["TenXe"] != null && dr["TenXe"] != DBNull.Value)
						{
							item.TenXe = Convert.ToString(dr["TenXe"]);
						}
						if (dr["NgayMua"] != null && dr["NgayMua"] != DBNull.Value)
						{
							item.NgayMua = Convert.ToDateTime(dr["NgayMua"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["SoLuongNhot"] != null && dr["SoLuongNhot"] != DBNull.Value)
						{
							item.SoLuongNhot = Convert.ToDecimal(dr["SoLuongNhot"]);
						}
						if (dr["SoLuongNhotLoc"] != null && dr["SoLuongNhotLoc"] != DBNull.Value)
						{
							item.SoLuongNhotLoc = Convert.ToDecimal(dr["SoLuongNhotLoc"]);
						}
						if (dr["MaLocNhot"] != null && dr["MaLocNhot"] != DBNull.Value)
						{
							item.MaLocNhot = Convert.ToString(dr["MaLocNhot"]);
						}
						if (dr["MaLocDau"] != null && dr["MaLocDau"] != DBNull.Value)
						{
							item.MaLocDau = Convert.ToString(dr["MaLocDau"]);
						}
						if (dr["MaMay"] != null && dr["MaMay"] != DBNull.Value)
						{
							item.MaMay = Convert.ToString(dr["MaMay"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
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
		/// Lấy một Vihcle đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public Vihcle GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Vihcle] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					Vihcle item=new Vihcle();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BienSo"] != null && dr["BienSo"] != DBNull.Value)
						{
							item.BienSo = Convert.ToString(dr["BienSo"]);
						}
						if (dr["TenXe"] != null && dr["TenXe"] != DBNull.Value)
						{
							item.TenXe = Convert.ToString(dr["TenXe"]);
						}
						if (dr["NgayMua"] != null && dr["NgayMua"] != DBNull.Value)
						{
							item.NgayMua = Convert.ToDateTime(dr["NgayMua"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["SoLuongNhot"] != null && dr["SoLuongNhot"] != DBNull.Value)
						{
							item.SoLuongNhot = Convert.ToDecimal(dr["SoLuongNhot"]);
						}
						if (dr["SoLuongNhotLoc"] != null && dr["SoLuongNhotLoc"] != DBNull.Value)
						{
							item.SoLuongNhotLoc = Convert.ToDecimal(dr["SoLuongNhotLoc"]);
						}
						if (dr["MaLocNhot"] != null && dr["MaLocNhot"] != DBNull.Value)
						{
							item.MaLocNhot = Convert.ToString(dr["MaLocNhot"]);
						}
						if (dr["MaLocDau"] != null && dr["MaLocDau"] != DBNull.Value)
						{
							item.MaLocDau = Convert.ToString(dr["MaLocDau"]);
						}
						if (dr["MaMay"] != null && dr["MaMay"] != DBNull.Value)
						{
							item.MaMay = Convert.ToString(dr["MaMay"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
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

		public Vihcle GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Vihcle] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<Vihcle>(ds);
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
		/// Thêm mới Vihcle vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, Vihcle _Vihcle)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[Vihcle](BienSo, TenXe, NgayMua, Note, SoLuongNhot, SoLuongNhotLoc, MaLocNhot, MaLocDau, MaMay, FK_Post) VALUES(@BienSo, @TenXe, @NgayMua, @Note, @SoLuongNhot, @SoLuongNhotLoc, @MaLocNhot, @MaLocDau, @MaMay, @FK_Post)", 
					"@BienSo",  _Vihcle.BienSo, 
					"@TenXe",  _Vihcle.TenXe, 
					"@NgayMua", this._dataContext.ConvertDateString( _Vihcle.NgayMua), 
					"@Note",  _Vihcle.Note, 
					"@SoLuongNhot",  _Vihcle.SoLuongNhot, 
					"@SoLuongNhotLoc",  _Vihcle.SoLuongNhotLoc, 
					"@MaLocNhot",  _Vihcle.MaLocNhot, 
					"@MaLocDau",  _Vihcle.MaLocDau, 
					"@MaMay",  _Vihcle.MaMay, 
					"@FK_Post",  _Vihcle.FK_Post);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng Vihcle vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<Vihcle> _Vihcles)
		{
			foreach (Vihcle item in _Vihcles)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Vihcle vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, Vihcle _Vihcle, String BienSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Vihcle] SET BienSo=@BienSo, TenXe=@TenXe, NgayMua=@NgayMua, Note=@Note, SoLuongNhot=@SoLuongNhot, SoLuongNhotLoc=@SoLuongNhotLoc, MaLocNhot=@MaLocNhot, MaLocDau=@MaLocDau, MaMay=@MaMay, FK_Post=@FK_Post WHERE BienSo=@BienSo", 
					"@BienSo",  _Vihcle.BienSo, 
					"@TenXe",  _Vihcle.TenXe, 
					"@NgayMua", this._dataContext.ConvertDateString( _Vihcle.NgayMua), 
					"@Note",  _Vihcle.Note, 
					"@SoLuongNhot",  _Vihcle.SoLuongNhot, 
					"@SoLuongNhotLoc",  _Vihcle.SoLuongNhotLoc, 
					"@MaLocNhot",  _Vihcle.MaLocNhot, 
					"@MaLocDau",  _Vihcle.MaLocDau, 
					"@MaMay",  _Vihcle.MaMay, 
					"@FK_Post",  _Vihcle.FK_Post, 
					"@BienSo", BienSo);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật Vihcle vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, Vihcle _Vihcle)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Vihcle] SET TenXe=@TenXe, NgayMua=@NgayMua, Note=@Note, SoLuongNhot=@SoLuongNhot, SoLuongNhotLoc=@SoLuongNhotLoc, MaLocNhot=@MaLocNhot, MaLocDau=@MaLocDau, MaMay=@MaMay, FK_Post=@FK_Post WHERE BienSo=@BienSo", 
					"@TenXe",  _Vihcle.TenXe, 
					"@NgayMua", this._dataContext.ConvertDateString( _Vihcle.NgayMua), 
					"@Note",  _Vihcle.Note, 
					"@SoLuongNhot",  _Vihcle.SoLuongNhot, 
					"@SoLuongNhotLoc",  _Vihcle.SoLuongNhotLoc, 
					"@MaLocNhot",  _Vihcle.MaLocNhot, 
					"@MaLocDau",  _Vihcle.MaLocDau, 
					"@MaMay",  _Vihcle.MaMay, 
					"@FK_Post",  _Vihcle.FK_Post, 
					"@BienSo", _Vihcle.BienSo);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách Vihcle vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<Vihcle> _Vihcles)
		{
			foreach (Vihcle item in _Vihcles)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Vihcle vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, Vihcle _Vihcle, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Vihcle] SET BienSo=@BienSo, TenXe=@TenXe, NgayMua=@NgayMua, Note=@Note, SoLuongNhot=@SoLuongNhot, SoLuongNhotLoc=@SoLuongNhotLoc, MaLocNhot=@MaLocNhot, MaLocDau=@MaLocDau, MaMay=@MaMay, FK_Post=@FK_Post "+ condition, 
					"@BienSo",  _Vihcle.BienSo, 
					"@TenXe",  _Vihcle.TenXe, 
					"@NgayMua", this._dataContext.ConvertDateString( _Vihcle.NgayMua), 
					"@Note",  _Vihcle.Note, 
					"@SoLuongNhot",  _Vihcle.SoLuongNhot, 
					"@SoLuongNhotLoc",  _Vihcle.SoLuongNhotLoc, 
					"@MaLocNhot",  _Vihcle.MaLocNhot, 
					"@MaLocDau",  _Vihcle.MaLocDau, 
					"@MaMay",  _Vihcle.MaMay, 
					"@FK_Post",  _Vihcle.FK_Post);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa Vihcle trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BienSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Vihcle] WHERE BienSo=@BienSo",
					"@BienSo", BienSo);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Vihcle trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Vihcle _Vihcle)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Vihcle] WHERE BienSo=@BienSo",
					"@BienSo", _Vihcle.BienSo);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Vihcle trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Vihcle] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Vihcle trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<Vihcle> _Vihcles)
		{
			foreach (Vihcle item in _Vihcles)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
