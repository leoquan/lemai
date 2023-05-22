using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdketquamacdinh:IMEdketquamacdinh
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdketquamacdinh(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKetQuaMacDinh từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaMacDinh]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKetQuaMacDinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaMacDinh] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKetQuaMacDinh từ Database
		/// </summary>
		public List<MedKetQuaMacDinh> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaMacDinh]");
				List<MedKetQuaMacDinh> items = new List<MedKetQuaMacDinh>();
				MedKetQuaMacDinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaMacDinh();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["tuanhoan"] != null && dr["tuanhoan"] != DBNull.Value)
					{
						item.tuanhoan = Convert.ToString(dr["tuanhoan"]);
					}
					if (dr["hohap"] != null && dr["hohap"] != DBNull.Value)
					{
						item.hohap = Convert.ToString(dr["hohap"]);
					}
					if (dr["tieuhoa"] != null && dr["tieuhoa"] != DBNull.Value)
					{
						item.tieuhoa = Convert.ToString(dr["tieuhoa"]);
					}
					if (dr["thantietnieu"] != null && dr["thantietnieu"] != DBNull.Value)
					{
						item.thantietnieu = Convert.ToString(dr["thantietnieu"]);
					}
					if (dr["coxuongkhop"] != null && dr["coxuongkhop"] != DBNull.Value)
					{
						item.coxuongkhop = Convert.ToString(dr["coxuongkhop"]);
					}
					if (dr["thankinh"] != null && dr["thankinh"] != DBNull.Value)
					{
						item.thankinh = Convert.ToString(dr["thankinh"]);
					}
					if (dr["tamthan"] != null && dr["tamthan"] != DBNull.Value)
					{
						item.tamthan = Convert.ToString(dr["tamthan"]);
					}
					if (dr["ngoaikhoa"] != null && dr["ngoaikhoa"] != DBNull.Value)
					{
						item.ngoaikhoa = Convert.ToString(dr["ngoaikhoa"]);
					}
					if (dr["sanphukhoa"] != null && dr["sanphukhoa"] != DBNull.Value)
					{
						item.sanphukhoa = Convert.ToString(dr["sanphukhoa"]);
					}
					if (dr["mat"] != null && dr["mat"] != DBNull.Value)
					{
						item.mat = Convert.ToString(dr["mat"]);
					}
					if (dr["taimuihong"] != null && dr["taimuihong"] != DBNull.Value)
					{
						item.taimuihong = Convert.ToString(dr["taimuihong"]);
					}
					if (dr["ranghammat"] != null && dr["ranghammat"] != DBNull.Value)
					{
						item.ranghammat = Convert.ToString(dr["ranghammat"]);
					}
					if (dr["dalieu"] != null && dr["dalieu"] != DBNull.Value)
					{
						item.dalieu = Convert.ToString(dr["dalieu"]);
					}
					if (dr["phanloai"] != null && dr["phanloai"] != DBNull.Value)
					{
						item.phanloai = Convert.ToInt32(dr["phanloai"]);
					}
					if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
					{
						item.ketluan = Convert.ToString(dr["ketluan"]);
					}
					if (dr["noitiet"] != null && dr["noitiet"] != DBNull.Value)
					{
						item.noitiet = Convert.ToString(dr["noitiet"]);
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
		/// Lấy danh sách MedKetQuaMacDinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKetQuaMacDinh> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaMacDinh] A "+ condition,  parameters);
				List<MedKetQuaMacDinh> items = new List<MedKetQuaMacDinh>();
				MedKetQuaMacDinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaMacDinh();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["tuanhoan"] != null && dr["tuanhoan"] != DBNull.Value)
					{
						item.tuanhoan = Convert.ToString(dr["tuanhoan"]);
					}
					if (dr["hohap"] != null && dr["hohap"] != DBNull.Value)
					{
						item.hohap = Convert.ToString(dr["hohap"]);
					}
					if (dr["tieuhoa"] != null && dr["tieuhoa"] != DBNull.Value)
					{
						item.tieuhoa = Convert.ToString(dr["tieuhoa"]);
					}
					if (dr["thantietnieu"] != null && dr["thantietnieu"] != DBNull.Value)
					{
						item.thantietnieu = Convert.ToString(dr["thantietnieu"]);
					}
					if (dr["coxuongkhop"] != null && dr["coxuongkhop"] != DBNull.Value)
					{
						item.coxuongkhop = Convert.ToString(dr["coxuongkhop"]);
					}
					if (dr["thankinh"] != null && dr["thankinh"] != DBNull.Value)
					{
						item.thankinh = Convert.ToString(dr["thankinh"]);
					}
					if (dr["tamthan"] != null && dr["tamthan"] != DBNull.Value)
					{
						item.tamthan = Convert.ToString(dr["tamthan"]);
					}
					if (dr["ngoaikhoa"] != null && dr["ngoaikhoa"] != DBNull.Value)
					{
						item.ngoaikhoa = Convert.ToString(dr["ngoaikhoa"]);
					}
					if (dr["sanphukhoa"] != null && dr["sanphukhoa"] != DBNull.Value)
					{
						item.sanphukhoa = Convert.ToString(dr["sanphukhoa"]);
					}
					if (dr["mat"] != null && dr["mat"] != DBNull.Value)
					{
						item.mat = Convert.ToString(dr["mat"]);
					}
					if (dr["taimuihong"] != null && dr["taimuihong"] != DBNull.Value)
					{
						item.taimuihong = Convert.ToString(dr["taimuihong"]);
					}
					if (dr["ranghammat"] != null && dr["ranghammat"] != DBNull.Value)
					{
						item.ranghammat = Convert.ToString(dr["ranghammat"]);
					}
					if (dr["dalieu"] != null && dr["dalieu"] != DBNull.Value)
					{
						item.dalieu = Convert.ToString(dr["dalieu"]);
					}
					if (dr["phanloai"] != null && dr["phanloai"] != DBNull.Value)
					{
						item.phanloai = Convert.ToInt32(dr["phanloai"]);
					}
					if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
					{
						item.ketluan = Convert.ToString(dr["ketluan"]);
					}
					if (dr["noitiet"] != null && dr["noitiet"] != DBNull.Value)
					{
						item.noitiet = Convert.ToString(dr["noitiet"]);
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

		public List<MedKetQuaMacDinh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaMacDinh] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKetQuaMacDinh] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKetQuaMacDinh>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKetQuaMacDinh từ Database
		/// </summary>
		public MedKetQuaMacDinh GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaMacDinh] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaMacDinh item=new MedKetQuaMacDinh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["tuanhoan"] != null && dr["tuanhoan"] != DBNull.Value)
						{
							item.tuanhoan = Convert.ToString(dr["tuanhoan"]);
						}
						if (dr["hohap"] != null && dr["hohap"] != DBNull.Value)
						{
							item.hohap = Convert.ToString(dr["hohap"]);
						}
						if (dr["tieuhoa"] != null && dr["tieuhoa"] != DBNull.Value)
						{
							item.tieuhoa = Convert.ToString(dr["tieuhoa"]);
						}
						if (dr["thantietnieu"] != null && dr["thantietnieu"] != DBNull.Value)
						{
							item.thantietnieu = Convert.ToString(dr["thantietnieu"]);
						}
						if (dr["coxuongkhop"] != null && dr["coxuongkhop"] != DBNull.Value)
						{
							item.coxuongkhop = Convert.ToString(dr["coxuongkhop"]);
						}
						if (dr["thankinh"] != null && dr["thankinh"] != DBNull.Value)
						{
							item.thankinh = Convert.ToString(dr["thankinh"]);
						}
						if (dr["tamthan"] != null && dr["tamthan"] != DBNull.Value)
						{
							item.tamthan = Convert.ToString(dr["tamthan"]);
						}
						if (dr["ngoaikhoa"] != null && dr["ngoaikhoa"] != DBNull.Value)
						{
							item.ngoaikhoa = Convert.ToString(dr["ngoaikhoa"]);
						}
						if (dr["sanphukhoa"] != null && dr["sanphukhoa"] != DBNull.Value)
						{
							item.sanphukhoa = Convert.ToString(dr["sanphukhoa"]);
						}
						if (dr["mat"] != null && dr["mat"] != DBNull.Value)
						{
							item.mat = Convert.ToString(dr["mat"]);
						}
						if (dr["taimuihong"] != null && dr["taimuihong"] != DBNull.Value)
						{
							item.taimuihong = Convert.ToString(dr["taimuihong"]);
						}
						if (dr["ranghammat"] != null && dr["ranghammat"] != DBNull.Value)
						{
							item.ranghammat = Convert.ToString(dr["ranghammat"]);
						}
						if (dr["dalieu"] != null && dr["dalieu"] != DBNull.Value)
						{
							item.dalieu = Convert.ToString(dr["dalieu"]);
						}
						if (dr["phanloai"] != null && dr["phanloai"] != DBNull.Value)
						{
							item.phanloai = Convert.ToInt32(dr["phanloai"]);
						}
						if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
						{
							item.ketluan = Convert.ToString(dr["ketluan"]);
						}
						if (dr["noitiet"] != null && dr["noitiet"] != DBNull.Value)
						{
							item.noitiet = Convert.ToString(dr["noitiet"]);
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
		/// Lấy một MedKetQuaMacDinh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKetQuaMacDinh GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaMacDinh] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaMacDinh item=new MedKetQuaMacDinh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["tuanhoan"] != null && dr["tuanhoan"] != DBNull.Value)
						{
							item.tuanhoan = Convert.ToString(dr["tuanhoan"]);
						}
						if (dr["hohap"] != null && dr["hohap"] != DBNull.Value)
						{
							item.hohap = Convert.ToString(dr["hohap"]);
						}
						if (dr["tieuhoa"] != null && dr["tieuhoa"] != DBNull.Value)
						{
							item.tieuhoa = Convert.ToString(dr["tieuhoa"]);
						}
						if (dr["thantietnieu"] != null && dr["thantietnieu"] != DBNull.Value)
						{
							item.thantietnieu = Convert.ToString(dr["thantietnieu"]);
						}
						if (dr["coxuongkhop"] != null && dr["coxuongkhop"] != DBNull.Value)
						{
							item.coxuongkhop = Convert.ToString(dr["coxuongkhop"]);
						}
						if (dr["thankinh"] != null && dr["thankinh"] != DBNull.Value)
						{
							item.thankinh = Convert.ToString(dr["thankinh"]);
						}
						if (dr["tamthan"] != null && dr["tamthan"] != DBNull.Value)
						{
							item.tamthan = Convert.ToString(dr["tamthan"]);
						}
						if (dr["ngoaikhoa"] != null && dr["ngoaikhoa"] != DBNull.Value)
						{
							item.ngoaikhoa = Convert.ToString(dr["ngoaikhoa"]);
						}
						if (dr["sanphukhoa"] != null && dr["sanphukhoa"] != DBNull.Value)
						{
							item.sanphukhoa = Convert.ToString(dr["sanphukhoa"]);
						}
						if (dr["mat"] != null && dr["mat"] != DBNull.Value)
						{
							item.mat = Convert.ToString(dr["mat"]);
						}
						if (dr["taimuihong"] != null && dr["taimuihong"] != DBNull.Value)
						{
							item.taimuihong = Convert.ToString(dr["taimuihong"]);
						}
						if (dr["ranghammat"] != null && dr["ranghammat"] != DBNull.Value)
						{
							item.ranghammat = Convert.ToString(dr["ranghammat"]);
						}
						if (dr["dalieu"] != null && dr["dalieu"] != DBNull.Value)
						{
							item.dalieu = Convert.ToString(dr["dalieu"]);
						}
						if (dr["phanloai"] != null && dr["phanloai"] != DBNull.Value)
						{
							item.phanloai = Convert.ToInt32(dr["phanloai"]);
						}
						if (dr["ketluan"] != null && dr["ketluan"] != DBNull.Value)
						{
							item.ketluan = Convert.ToString(dr["ketluan"]);
						}
						if (dr["noitiet"] != null && dr["noitiet"] != DBNull.Value)
						{
							item.noitiet = Convert.ToString(dr["noitiet"]);
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

		public MedKetQuaMacDinh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaMacDinh] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKetQuaMacDinh>(ds);
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
		/// Thêm mới MedKetQuaMacDinh vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKetQuaMacDinh _MedKetQuaMacDinh)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKetQuaMacDinh](id, tuanhoan, hohap, tieuhoa, thantietnieu, coxuongkhop, thankinh, tamthan, ngoaikhoa, sanphukhoa, mat, taimuihong, ranghammat, dalieu, phanloai, ketluan, noitiet) VALUES(@id, @tuanhoan, @hohap, @tieuhoa, @thantietnieu, @coxuongkhop, @thankinh, @tamthan, @ngoaikhoa, @sanphukhoa, @mat, @taimuihong, @ranghammat, @dalieu, @phanloai, @ketluan, @noitiet)", 
					"@id",  _MedKetQuaMacDinh.id, 
					"@tuanhoan",  _MedKetQuaMacDinh.tuanhoan, 
					"@hohap",  _MedKetQuaMacDinh.hohap, 
					"@tieuhoa",  _MedKetQuaMacDinh.tieuhoa, 
					"@thantietnieu",  _MedKetQuaMacDinh.thantietnieu, 
					"@coxuongkhop",  _MedKetQuaMacDinh.coxuongkhop, 
					"@thankinh",  _MedKetQuaMacDinh.thankinh, 
					"@tamthan",  _MedKetQuaMacDinh.tamthan, 
					"@ngoaikhoa",  _MedKetQuaMacDinh.ngoaikhoa, 
					"@sanphukhoa",  _MedKetQuaMacDinh.sanphukhoa, 
					"@mat",  _MedKetQuaMacDinh.mat, 
					"@taimuihong",  _MedKetQuaMacDinh.taimuihong, 
					"@ranghammat",  _MedKetQuaMacDinh.ranghammat, 
					"@dalieu",  _MedKetQuaMacDinh.dalieu, 
					"@phanloai",  _MedKetQuaMacDinh.phanloai, 
					"@ketluan",  _MedKetQuaMacDinh.ketluan, 
					"@noitiet",  _MedKetQuaMacDinh.noitiet);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaMacDinh vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKetQuaMacDinh> _MedKetQuaMacDinhs)
		{
			foreach (MedKetQuaMacDinh item in _MedKetQuaMacDinhs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaMacDinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKetQuaMacDinh _MedKetQuaMacDinh, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaMacDinh] SET id=@id, tuanhoan=@tuanhoan, hohap=@hohap, tieuhoa=@tieuhoa, thantietnieu=@thantietnieu, coxuongkhop=@coxuongkhop, thankinh=@thankinh, tamthan=@tamthan, ngoaikhoa=@ngoaikhoa, sanphukhoa=@sanphukhoa, mat=@mat, taimuihong=@taimuihong, ranghammat=@ranghammat, dalieu=@dalieu, phanloai=@phanloai, ketluan=@ketluan, noitiet=@noitiet WHERE id=@id", 
					"@id",  _MedKetQuaMacDinh.id, 
					"@tuanhoan",  _MedKetQuaMacDinh.tuanhoan, 
					"@hohap",  _MedKetQuaMacDinh.hohap, 
					"@tieuhoa",  _MedKetQuaMacDinh.tieuhoa, 
					"@thantietnieu",  _MedKetQuaMacDinh.thantietnieu, 
					"@coxuongkhop",  _MedKetQuaMacDinh.coxuongkhop, 
					"@thankinh",  _MedKetQuaMacDinh.thankinh, 
					"@tamthan",  _MedKetQuaMacDinh.tamthan, 
					"@ngoaikhoa",  _MedKetQuaMacDinh.ngoaikhoa, 
					"@sanphukhoa",  _MedKetQuaMacDinh.sanphukhoa, 
					"@mat",  _MedKetQuaMacDinh.mat, 
					"@taimuihong",  _MedKetQuaMacDinh.taimuihong, 
					"@ranghammat",  _MedKetQuaMacDinh.ranghammat, 
					"@dalieu",  _MedKetQuaMacDinh.dalieu, 
					"@phanloai",  _MedKetQuaMacDinh.phanloai, 
					"@ketluan",  _MedKetQuaMacDinh.ketluan, 
					"@noitiet",  _MedKetQuaMacDinh.noitiet, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaMacDinh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKetQuaMacDinh _MedKetQuaMacDinh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaMacDinh] SET tuanhoan=@tuanhoan, hohap=@hohap, tieuhoa=@tieuhoa, thantietnieu=@thantietnieu, coxuongkhop=@coxuongkhop, thankinh=@thankinh, tamthan=@tamthan, ngoaikhoa=@ngoaikhoa, sanphukhoa=@sanphukhoa, mat=@mat, taimuihong=@taimuihong, ranghammat=@ranghammat, dalieu=@dalieu, phanloai=@phanloai, ketluan=@ketluan, noitiet=@noitiet WHERE id=@id", 
					"@tuanhoan",  _MedKetQuaMacDinh.tuanhoan, 
					"@hohap",  _MedKetQuaMacDinh.hohap, 
					"@tieuhoa",  _MedKetQuaMacDinh.tieuhoa, 
					"@thantietnieu",  _MedKetQuaMacDinh.thantietnieu, 
					"@coxuongkhop",  _MedKetQuaMacDinh.coxuongkhop, 
					"@thankinh",  _MedKetQuaMacDinh.thankinh, 
					"@tamthan",  _MedKetQuaMacDinh.tamthan, 
					"@ngoaikhoa",  _MedKetQuaMacDinh.ngoaikhoa, 
					"@sanphukhoa",  _MedKetQuaMacDinh.sanphukhoa, 
					"@mat",  _MedKetQuaMacDinh.mat, 
					"@taimuihong",  _MedKetQuaMacDinh.taimuihong, 
					"@ranghammat",  _MedKetQuaMacDinh.ranghammat, 
					"@dalieu",  _MedKetQuaMacDinh.dalieu, 
					"@phanloai",  _MedKetQuaMacDinh.phanloai, 
					"@ketluan",  _MedKetQuaMacDinh.ketluan, 
					"@noitiet",  _MedKetQuaMacDinh.noitiet, 
					"@id", _MedKetQuaMacDinh.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKetQuaMacDinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKetQuaMacDinh> _MedKetQuaMacDinhs)
		{
			foreach (MedKetQuaMacDinh item in _MedKetQuaMacDinhs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaMacDinh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKetQuaMacDinh _MedKetQuaMacDinh, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaMacDinh] SET id=@id, tuanhoan=@tuanhoan, hohap=@hohap, tieuhoa=@tieuhoa, thantietnieu=@thantietnieu, coxuongkhop=@coxuongkhop, thankinh=@thankinh, tamthan=@tamthan, ngoaikhoa=@ngoaikhoa, sanphukhoa=@sanphukhoa, mat=@mat, taimuihong=@taimuihong, ranghammat=@ranghammat, dalieu=@dalieu, phanloai=@phanloai, ketluan=@ketluan, noitiet=@noitiet "+ condition, 
					"@id",  _MedKetQuaMacDinh.id, 
					"@tuanhoan",  _MedKetQuaMacDinh.tuanhoan, 
					"@hohap",  _MedKetQuaMacDinh.hohap, 
					"@tieuhoa",  _MedKetQuaMacDinh.tieuhoa, 
					"@thantietnieu",  _MedKetQuaMacDinh.thantietnieu, 
					"@coxuongkhop",  _MedKetQuaMacDinh.coxuongkhop, 
					"@thankinh",  _MedKetQuaMacDinh.thankinh, 
					"@tamthan",  _MedKetQuaMacDinh.tamthan, 
					"@ngoaikhoa",  _MedKetQuaMacDinh.ngoaikhoa, 
					"@sanphukhoa",  _MedKetQuaMacDinh.sanphukhoa, 
					"@mat",  _MedKetQuaMacDinh.mat, 
					"@taimuihong",  _MedKetQuaMacDinh.taimuihong, 
					"@ranghammat",  _MedKetQuaMacDinh.ranghammat, 
					"@dalieu",  _MedKetQuaMacDinh.dalieu, 
					"@phanloai",  _MedKetQuaMacDinh.phanloai, 
					"@ketluan",  _MedKetQuaMacDinh.ketluan, 
					"@noitiet",  _MedKetQuaMacDinh.noitiet);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKetQuaMacDinh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaMacDinh] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaMacDinh trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKetQuaMacDinh _MedKetQuaMacDinh)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaMacDinh] WHERE id=@id",
					"@id", _MedKetQuaMacDinh.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaMacDinh trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaMacDinh] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaMacDinh trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKetQuaMacDinh> _MedKetQuaMacDinhs)
		{
			foreach (MedKetQuaMacDinh item in _MedKetQuaMacDinhs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
