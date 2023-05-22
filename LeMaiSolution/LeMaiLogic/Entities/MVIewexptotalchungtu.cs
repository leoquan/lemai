using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexptotalchungtu:IVIewexptotalchungtu
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexptotalchungtu(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpTotalChungTu từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpTotalChungTu]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpTotalChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpTotalChungTu] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpTotalChungTu từ Database
		/// </summary>
		public List<view_ExpTotalChungTu> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpTotalChungTu]");
				List<view_ExpTotalChungTu> items = new List<view_ExpTotalChungTu>();
				view_ExpTotalChungTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpTotalChungTu();
					if (dr["FK_KyKetToan"] != null && dr["FK_KyKetToan"] != DBNull.Value)
					{
						item.FK_KyKetToan = Convert.ToString(dr["FK_KyKetToan"]);
					}
					if (dr["THUEVAT_DAPH"] != null && dr["THUEVAT_DAPH"] != DBNull.Value)
					{
						item.THUEVAT_DAPH = Convert.ToDecimal(dr["THUEVAT_DAPH"]);
					}
					if (dr["THUEVAT_CHUA_PH"] != null && dr["THUEVAT_CHUA_PH"] != DBNull.Value)
					{
						item.THUEVAT_CHUA_PH = Convert.ToDecimal(dr["THUEVAT_CHUA_PH"]);
					}
					if (dr["PHIVC_DAPH"] != null && dr["PHIVC_DAPH"] != DBNull.Value)
					{
						item.PHIVC_DAPH = Convert.ToDecimal(dr["PHIVC_DAPH"]);
					}
					if (dr["PHIVC_CHUA_PH"] != null && dr["PHIVC_CHUA_PH"] != DBNull.Value)
					{
						item.PHIVC_CHUA_PH = Convert.ToDecimal(dr["PHIVC_CHUA_PH"]);
					}
					if (dr["COD_DAPH"] != null && dr["COD_DAPH"] != DBNull.Value)
					{
						item.COD_DAPH = Convert.ToDecimal(dr["COD_DAPH"]);
					}
					if (dr["COD_CHUA_PH"] != null && dr["COD_CHUA_PH"] != DBNull.Value)
					{
						item.COD_CHUA_PH = Convert.ToDecimal(dr["COD_CHUA_PH"]);
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
		/// Lấy danh sách view_ExpTotalChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpTotalChungTu> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpTotalChungTu] A "+ condition,  parameters);
				List<view_ExpTotalChungTu> items = new List<view_ExpTotalChungTu>();
				view_ExpTotalChungTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpTotalChungTu();
					if (dr["FK_KyKetToan"] != null && dr["FK_KyKetToan"] != DBNull.Value)
					{
						item.FK_KyKetToan = Convert.ToString(dr["FK_KyKetToan"]);
					}
					if (dr["THUEVAT_DAPH"] != null && dr["THUEVAT_DAPH"] != DBNull.Value)
					{
						item.THUEVAT_DAPH = Convert.ToDecimal(dr["THUEVAT_DAPH"]);
					}
					if (dr["THUEVAT_CHUA_PH"] != null && dr["THUEVAT_CHUA_PH"] != DBNull.Value)
					{
						item.THUEVAT_CHUA_PH = Convert.ToDecimal(dr["THUEVAT_CHUA_PH"]);
					}
					if (dr["PHIVC_DAPH"] != null && dr["PHIVC_DAPH"] != DBNull.Value)
					{
						item.PHIVC_DAPH = Convert.ToDecimal(dr["PHIVC_DAPH"]);
					}
					if (dr["PHIVC_CHUA_PH"] != null && dr["PHIVC_CHUA_PH"] != DBNull.Value)
					{
						item.PHIVC_CHUA_PH = Convert.ToDecimal(dr["PHIVC_CHUA_PH"]);
					}
					if (dr["COD_DAPH"] != null && dr["COD_DAPH"] != DBNull.Value)
					{
						item.COD_DAPH = Convert.ToDecimal(dr["COD_DAPH"]);
					}
					if (dr["COD_CHUA_PH"] != null && dr["COD_CHUA_PH"] != DBNull.Value)
					{
						item.COD_CHUA_PH = Convert.ToDecimal(dr["COD_CHUA_PH"]);
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

		public List<view_ExpTotalChungTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpTotalChungTu] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpTotalChungTu] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpTotalChungTu>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpTotalChungTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpTotalChungTu GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpTotalChungTu] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpTotalChungTu item=new view_ExpTotalChungTu();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_KyKetToan"] != null && dr["FK_KyKetToan"] != DBNull.Value)
						{
							item.FK_KyKetToan = Convert.ToString(dr["FK_KyKetToan"]);
						}
						if (dr["THUEVAT_DAPH"] != null && dr["THUEVAT_DAPH"] != DBNull.Value)
						{
							item.THUEVAT_DAPH = Convert.ToDecimal(dr["THUEVAT_DAPH"]);
						}
						if (dr["THUEVAT_CHUA_PH"] != null && dr["THUEVAT_CHUA_PH"] != DBNull.Value)
						{
							item.THUEVAT_CHUA_PH = Convert.ToDecimal(dr["THUEVAT_CHUA_PH"]);
						}
						if (dr["PHIVC_DAPH"] != null && dr["PHIVC_DAPH"] != DBNull.Value)
						{
							item.PHIVC_DAPH = Convert.ToDecimal(dr["PHIVC_DAPH"]);
						}
						if (dr["PHIVC_CHUA_PH"] != null && dr["PHIVC_CHUA_PH"] != DBNull.Value)
						{
							item.PHIVC_CHUA_PH = Convert.ToDecimal(dr["PHIVC_CHUA_PH"]);
						}
						if (dr["COD_DAPH"] != null && dr["COD_DAPH"] != DBNull.Value)
						{
							item.COD_DAPH = Convert.ToDecimal(dr["COD_DAPH"]);
						}
						if (dr["COD_CHUA_PH"] != null && dr["COD_CHUA_PH"] != DBNull.Value)
						{
							item.COD_CHUA_PH = Convert.ToDecimal(dr["COD_CHUA_PH"]);
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

		public view_ExpTotalChungTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpTotalChungTu] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpTotalChungTu>(ds);
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
	}
}
