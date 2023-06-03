using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIhclecoupon:IVIhclecoupon
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIhclecoupon(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VihcleCoupon từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleCoupon]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VihcleCoupon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleCoupon] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VihcleCoupon từ Database
		/// </summary>
		public List<VihcleCoupon> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleCoupon]");
				List<VihcleCoupon> items = new List<VihcleCoupon>();
				VihcleCoupon item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VihcleCoupon();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Vihcle"] != null && dr["FK_Vihcle"] != DBNull.Value)
					{
						item.FK_Vihcle = Convert.ToString(dr["FK_Vihcle"]);
					}
					if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
					{
						item.TotalFee = Convert.ToInt32(dr["TotalFee"]);
					}
					if (dr["Date"] != null && dr["Date"] != DBNull.Value)
					{
						item.Date = Convert.ToDateTime(dr["Date"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["SoKM"] != null && dr["SoKM"] != DBNull.Value)
					{
						item.SoKM = Convert.ToInt32(dr["SoKM"]);
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
		/// Lấy danh sách VihcleCoupon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VihcleCoupon> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VihcleCoupon] A "+ condition,  parameters);
				List<VihcleCoupon> items = new List<VihcleCoupon>();
				VihcleCoupon item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VihcleCoupon();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Vihcle"] != null && dr["FK_Vihcle"] != DBNull.Value)
					{
						item.FK_Vihcle = Convert.ToString(dr["FK_Vihcle"]);
					}
					if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
					{
						item.TotalFee = Convert.ToInt32(dr["TotalFee"]);
					}
					if (dr["Date"] != null && dr["Date"] != DBNull.Value)
					{
						item.Date = Convert.ToDateTime(dr["Date"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["SoKM"] != null && dr["SoKM"] != DBNull.Value)
					{
						item.SoKM = Convert.ToInt32(dr["SoKM"]);
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

		public List<VihcleCoupon> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VihcleCoupon] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VihcleCoupon] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VihcleCoupon>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VihcleCoupon từ Database
		/// </summary>
		public VihcleCoupon GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleCoupon] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					VihcleCoupon item=new VihcleCoupon();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Vihcle"] != null && dr["FK_Vihcle"] != DBNull.Value)
						{
							item.FK_Vihcle = Convert.ToString(dr["FK_Vihcle"]);
						}
						if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
						{
							item.TotalFee = Convert.ToInt32(dr["TotalFee"]);
						}
						if (dr["Date"] != null && dr["Date"] != DBNull.Value)
						{
							item.Date = Convert.ToDateTime(dr["Date"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["SoKM"] != null && dr["SoKM"] != DBNull.Value)
						{
							item.SoKM = Convert.ToInt32(dr["SoKM"]);
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
		/// Lấy một VihcleCoupon đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VihcleCoupon GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VihcleCoupon] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VihcleCoupon item=new VihcleCoupon();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Vihcle"] != null && dr["FK_Vihcle"] != DBNull.Value)
						{
							item.FK_Vihcle = Convert.ToString(dr["FK_Vihcle"]);
						}
						if (dr["TotalFee"] != null && dr["TotalFee"] != DBNull.Value)
						{
							item.TotalFee = Convert.ToInt32(dr["TotalFee"]);
						}
						if (dr["Date"] != null && dr["Date"] != DBNull.Value)
						{
							item.Date = Convert.ToDateTime(dr["Date"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["SoKM"] != null && dr["SoKM"] != DBNull.Value)
						{
							item.SoKM = Convert.ToInt32(dr["SoKM"]);
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

		public VihcleCoupon GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VihcleCoupon] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VihcleCoupon>(ds);
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
		/// Thêm mới VihcleCoupon vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VihcleCoupon _VihcleCoupon)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VihcleCoupon](Id, FK_Vihcle, TotalFee, Date, Note, SoKM) VALUES(@Id, @FK_Vihcle, @TotalFee, @Date, @Note, @SoKM)", 
					"@Id",  _VihcleCoupon.Id, 
					"@FK_Vihcle",  _VihcleCoupon.FK_Vihcle, 
					"@TotalFee",  _VihcleCoupon.TotalFee, 
					"@Date", this._dataContext.ConvertDateString( _VihcleCoupon.Date), 
					"@Note",  _VihcleCoupon.Note, 
					"@SoKM",  _VihcleCoupon.SoKM);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VihcleCoupon vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VihcleCoupon> _VihcleCoupons)
		{
			foreach (VihcleCoupon item in _VihcleCoupons)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VihcleCoupon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VihcleCoupon _VihcleCoupon, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleCoupon] SET Id=@Id, FK_Vihcle=@FK_Vihcle, TotalFee=@TotalFee, Date=@Date, Note=@Note, SoKM=@SoKM WHERE Id=@Id", 
					"@Id",  _VihcleCoupon.Id, 
					"@FK_Vihcle",  _VihcleCoupon.FK_Vihcle, 
					"@TotalFee",  _VihcleCoupon.TotalFee, 
					"@Date", this._dataContext.ConvertDateString( _VihcleCoupon.Date), 
					"@Note",  _VihcleCoupon.Note, 
					"@SoKM",  _VihcleCoupon.SoKM, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VihcleCoupon vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VihcleCoupon _VihcleCoupon)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleCoupon] SET FK_Vihcle=@FK_Vihcle, TotalFee=@TotalFee, Date=@Date, Note=@Note, SoKM=@SoKM WHERE Id=@Id", 
					"@FK_Vihcle",  _VihcleCoupon.FK_Vihcle, 
					"@TotalFee",  _VihcleCoupon.TotalFee, 
					"@Date", this._dataContext.ConvertDateString( _VihcleCoupon.Date), 
					"@Note",  _VihcleCoupon.Note, 
					"@SoKM",  _VihcleCoupon.SoKM, 
					"@Id", _VihcleCoupon.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VihcleCoupon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VihcleCoupon> _VihcleCoupons)
		{
			foreach (VihcleCoupon item in _VihcleCoupons)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VihcleCoupon vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VihcleCoupon _VihcleCoupon, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleCoupon] SET Id=@Id, FK_Vihcle=@FK_Vihcle, TotalFee=@TotalFee, Date=@Date, Note=@Note, SoKM=@SoKM "+ condition, 
					"@Id",  _VihcleCoupon.Id, 
					"@FK_Vihcle",  _VihcleCoupon.FK_Vihcle, 
					"@TotalFee",  _VihcleCoupon.TotalFee, 
					"@Date", this._dataContext.ConvertDateString( _VihcleCoupon.Date), 
					"@Note",  _VihcleCoupon.Note, 
					"@SoKM",  _VihcleCoupon.SoKM);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VihcleCoupon trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleCoupon] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleCoupon trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VihcleCoupon _VihcleCoupon)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleCoupon] WHERE Id=@Id",
					"@Id", _VihcleCoupon.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleCoupon trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleCoupon] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleCoupon trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VihcleCoupon> _VihcleCoupons)
		{
			foreach (VihcleCoupon item in _VihcleCoupons)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
