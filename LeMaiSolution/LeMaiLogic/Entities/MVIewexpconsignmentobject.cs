using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpconsignmentobject:IVIewexpconsignmentobject
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpconsignmentobject(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentObject từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignmentObject]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignmentObject] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpConsignmentObject từ Database
		/// </summary>
		public List<view_ExpConsignmentObject> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignmentObject]");
				List<view_ExpConsignmentObject> items = new List<view_ExpConsignmentObject>();
				view_ExpConsignmentObject item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignmentObject();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["FK_DonViHC"] != null && dr["FK_DonViHC"] != DBNull.Value)
					{
						item.FK_DonViHC = Convert.ToString(dr["FK_DonViHC"]);
					}
					if (dr["SoNha"] != null && dr["SoNha"] != DBNull.Value)
					{
						item.SoNha = Convert.ToString(dr["SoNha"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["IsProvider"] != null && dr["IsProvider"] != DBNull.Value)
					{
						item.IsProvider = Convert.ToBoolean(dr["IsProvider"]);
					}
					if (dr["Xa"] != null && dr["Xa"] != DBNull.Value)
					{
						item.Xa = Convert.ToString(dr["Xa"]);
					}
					if (dr["XaId"] != null && dr["XaId"] != DBNull.Value)
					{
						item.XaId = Convert.ToString(dr["XaId"]);
					}
					if (dr["Huyen"] != null && dr["Huyen"] != DBNull.Value)
					{
						item.Huyen = Convert.ToString(dr["Huyen"]);
					}
					if (dr["HuyenId"] != null && dr["HuyenId"] != DBNull.Value)
					{
						item.HuyenId = Convert.ToString(dr["HuyenId"]);
					}
					if (dr["Tinh"] != null && dr["Tinh"] != DBNull.Value)
					{
						item.Tinh = Convert.ToString(dr["Tinh"]);
					}
					if (dr["TinhId"] != null && dr["TinhId"] != DBNull.Value)
					{
						item.TinhId = Convert.ToString(dr["TinhId"]);
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
		/// Lấy danh sách view_ExpConsignmentObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpConsignmentObject> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignmentObject] A "+ condition,  parameters);
				List<view_ExpConsignmentObject> items = new List<view_ExpConsignmentObject>();
				view_ExpConsignmentObject item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignmentObject();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["FK_DonViHC"] != null && dr["FK_DonViHC"] != DBNull.Value)
					{
						item.FK_DonViHC = Convert.ToString(dr["FK_DonViHC"]);
					}
					if (dr["SoNha"] != null && dr["SoNha"] != DBNull.Value)
					{
						item.SoNha = Convert.ToString(dr["SoNha"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["IsProvider"] != null && dr["IsProvider"] != DBNull.Value)
					{
						item.IsProvider = Convert.ToBoolean(dr["IsProvider"]);
					}
					if (dr["Xa"] != null && dr["Xa"] != DBNull.Value)
					{
						item.Xa = Convert.ToString(dr["Xa"]);
					}
					if (dr["XaId"] != null && dr["XaId"] != DBNull.Value)
					{
						item.XaId = Convert.ToString(dr["XaId"]);
					}
					if (dr["Huyen"] != null && dr["Huyen"] != DBNull.Value)
					{
						item.Huyen = Convert.ToString(dr["Huyen"]);
					}
					if (dr["HuyenId"] != null && dr["HuyenId"] != DBNull.Value)
					{
						item.HuyenId = Convert.ToString(dr["HuyenId"]);
					}
					if (dr["Tinh"] != null && dr["Tinh"] != DBNull.Value)
					{
						item.Tinh = Convert.ToString(dr["Tinh"]);
					}
					if (dr["TinhId"] != null && dr["TinhId"] != DBNull.Value)
					{
						item.TinhId = Convert.ToString(dr["TinhId"]);
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

		public List<view_ExpConsignmentObject> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignmentObject] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignmentObject] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpConsignmentObject>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpConsignmentObject đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpConsignmentObject GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignmentObject] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpConsignmentObject item=new view_ExpConsignmentObject();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["FK_DonViHC"] != null && dr["FK_DonViHC"] != DBNull.Value)
						{
							item.FK_DonViHC = Convert.ToString(dr["FK_DonViHC"]);
						}
						if (dr["SoNha"] != null && dr["SoNha"] != DBNull.Value)
						{
							item.SoNha = Convert.ToString(dr["SoNha"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["IsProvider"] != null && dr["IsProvider"] != DBNull.Value)
						{
							item.IsProvider = Convert.ToBoolean(dr["IsProvider"]);
						}
						if (dr["Xa"] != null && dr["Xa"] != DBNull.Value)
						{
							item.Xa = Convert.ToString(dr["Xa"]);
						}
						if (dr["XaId"] != null && dr["XaId"] != DBNull.Value)
						{
							item.XaId = Convert.ToString(dr["XaId"]);
						}
						if (dr["Huyen"] != null && dr["Huyen"] != DBNull.Value)
						{
							item.Huyen = Convert.ToString(dr["Huyen"]);
						}
						if (dr["HuyenId"] != null && dr["HuyenId"] != DBNull.Value)
						{
							item.HuyenId = Convert.ToString(dr["HuyenId"]);
						}
						if (dr["Tinh"] != null && dr["Tinh"] != DBNull.Value)
						{
							item.Tinh = Convert.ToString(dr["Tinh"]);
						}
						if (dr["TinhId"] != null && dr["TinhId"] != DBNull.Value)
						{
							item.TinhId = Convert.ToString(dr["TinhId"]);
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

		public view_ExpConsignmentObject GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignmentObject] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpConsignmentObject>(ds);
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
