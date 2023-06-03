using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIhclecoupondetail:IVIhclecoupondetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIhclecoupondetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable VihcleCouponDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleCouponDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable VihcleCouponDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleCouponDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách VihcleCouponDetail từ Database
		/// </summary>
		public List<VihcleCouponDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleCouponDetail]");
				List<VihcleCouponDetail> items = new List<VihcleCouponDetail>();
				VihcleCouponDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VihcleCouponDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["FK_VihcleCoupon"] != null && dr["FK_VihcleCoupon"] != DBNull.Value)
					{
						item.FK_VihcleCoupon = Convert.ToString(dr["FK_VihcleCoupon"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["ServiceDate"] != null && dr["ServiceDate"] != DBNull.Value)
					{
						item.ServiceDate = Convert.ToDateTime(dr["ServiceDate"]);
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
		/// Lấy danh sách VihcleCouponDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<VihcleCouponDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VihcleCouponDetail] A "+ condition,  parameters);
				List<VihcleCouponDetail> items = new List<VihcleCouponDetail>();
				VihcleCouponDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new VihcleCouponDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["FK_VihcleCoupon"] != null && dr["FK_VihcleCoupon"] != DBNull.Value)
					{
						item.FK_VihcleCoupon = Convert.ToString(dr["FK_VihcleCoupon"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["ServiceDate"] != null && dr["ServiceDate"] != DBNull.Value)
					{
						item.ServiceDate = Convert.ToDateTime(dr["ServiceDate"]);
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

		public List<VihcleCouponDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VihcleCouponDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[VihcleCouponDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<VihcleCouponDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một VihcleCouponDetail từ Database
		/// </summary>
		public VihcleCouponDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[VihcleCouponDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					VihcleCouponDetail item=new VihcleCouponDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["FK_VihcleCoupon"] != null && dr["FK_VihcleCoupon"] != DBNull.Value)
						{
							item.FK_VihcleCoupon = Convert.ToString(dr["FK_VihcleCoupon"]);
						}
						if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
						{
							item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
						}
						if (dr["ServiceDate"] != null && dr["ServiceDate"] != DBNull.Value)
						{
							item.ServiceDate = Convert.ToDateTime(dr["ServiceDate"]);
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
		/// Lấy một VihcleCouponDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public VihcleCouponDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[VihcleCouponDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					VihcleCouponDetail item=new VihcleCouponDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["FK_VihcleCoupon"] != null && dr["FK_VihcleCoupon"] != DBNull.Value)
						{
							item.FK_VihcleCoupon = Convert.ToString(dr["FK_VihcleCoupon"]);
						}
						if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
						{
							item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
						}
						if (dr["ServiceDate"] != null && dr["ServiceDate"] != DBNull.Value)
						{
							item.ServiceDate = Convert.ToDateTime(dr["ServiceDate"]);
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

		public VihcleCouponDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[VihcleCouponDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<VihcleCouponDetail>(ds);
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
		/// Thêm mới VihcleCouponDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, VihcleCouponDetail _VihcleCouponDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[VihcleCouponDetail](Id, FK_Service, FK_VihcleCoupon, CurrentValue, ServiceDate) VALUES(@Id, @FK_Service, @FK_VihcleCoupon, @CurrentValue, @ServiceDate)", 
					"@Id",  _VihcleCouponDetail.Id, 
					"@FK_Service",  _VihcleCouponDetail.FK_Service, 
					"@FK_VihcleCoupon",  _VihcleCouponDetail.FK_VihcleCoupon, 
					"@CurrentValue",  _VihcleCouponDetail.CurrentValue, 
					"@ServiceDate", this._dataContext.ConvertDateString( _VihcleCouponDetail.ServiceDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng VihcleCouponDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<VihcleCouponDetail> _VihcleCouponDetails)
		{
			foreach (VihcleCouponDetail item in _VihcleCouponDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VihcleCouponDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, VihcleCouponDetail _VihcleCouponDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleCouponDetail] SET Id=@Id, FK_Service=@FK_Service, FK_VihcleCoupon=@FK_VihcleCoupon, CurrentValue=@CurrentValue, ServiceDate=@ServiceDate WHERE Id=@Id", 
					"@Id",  _VihcleCouponDetail.Id, 
					"@FK_Service",  _VihcleCouponDetail.FK_Service, 
					"@FK_VihcleCoupon",  _VihcleCouponDetail.FK_VihcleCoupon, 
					"@CurrentValue",  _VihcleCouponDetail.CurrentValue, 
					"@ServiceDate", this._dataContext.ConvertDateString( _VihcleCouponDetail.ServiceDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật VihcleCouponDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, VihcleCouponDetail _VihcleCouponDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleCouponDetail] SET FK_Service=@FK_Service, FK_VihcleCoupon=@FK_VihcleCoupon, CurrentValue=@CurrentValue, ServiceDate=@ServiceDate WHERE Id=@Id", 
					"@FK_Service",  _VihcleCouponDetail.FK_Service, 
					"@FK_VihcleCoupon",  _VihcleCouponDetail.FK_VihcleCoupon, 
					"@CurrentValue",  _VihcleCouponDetail.CurrentValue, 
					"@ServiceDate", this._dataContext.ConvertDateString( _VihcleCouponDetail.ServiceDate), 
					"@Id", _VihcleCouponDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách VihcleCouponDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<VihcleCouponDetail> _VihcleCouponDetails)
		{
			foreach (VihcleCouponDetail item in _VihcleCouponDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật VihcleCouponDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, VihcleCouponDetail _VihcleCouponDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[VihcleCouponDetail] SET Id=@Id, FK_Service=@FK_Service, FK_VihcleCoupon=@FK_VihcleCoupon, CurrentValue=@CurrentValue, ServiceDate=@ServiceDate "+ condition, 
					"@Id",  _VihcleCouponDetail.Id, 
					"@FK_Service",  _VihcleCouponDetail.FK_Service, 
					"@FK_VihcleCoupon",  _VihcleCouponDetail.FK_VihcleCoupon, 
					"@CurrentValue",  _VihcleCouponDetail.CurrentValue, 
					"@ServiceDate", this._dataContext.ConvertDateString( _VihcleCouponDetail.ServiceDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa VihcleCouponDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleCouponDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleCouponDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, VihcleCouponDetail _VihcleCouponDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleCouponDetail] WHERE Id=@Id",
					"@Id", _VihcleCouponDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleCouponDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[VihcleCouponDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa VihcleCouponDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<VihcleCouponDetail> _VihcleCouponDetails)
		{
			foreach (VihcleCouponDetail item in _VihcleCouponDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
