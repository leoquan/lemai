using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewservice:IVIewservice
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewservice(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_Service từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_Service]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_Service từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_Service] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_Service từ Database
		/// </summary>
		public List<view_Service> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_Service]");
				List<view_Service> items = new List<view_Service>();
				view_Service item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_Service();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Price"] != null && dr["Price"] != DBNull.Value)
					{
						item.Price = Convert.ToInt32(dr["Price"]);
					}
					if (dr["PriceMotion"] != null && dr["PriceMotion"] != DBNull.Value)
					{
						item.PriceMotion = Convert.ToInt32(dr["PriceMotion"]);
					}
					if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
					{
						item.FK_Group = Convert.ToString(dr["FK_Group"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["IsPublicBranch"] != null && dr["IsPublicBranch"] != DBNull.Value)
					{
						item.IsPublicBranch = Convert.ToBoolean(dr["IsPublicBranch"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["IsService"] != null && dr["IsService"] != DBNull.Value)
					{
						item.IsService = Convert.ToBoolean(dr["IsService"]);
					}
					if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
					{
						item.UnitName = Convert.ToString(dr["UnitName"]);
					}
					if (dr["Barcode"] != null && dr["Barcode"] != DBNull.Value)
					{
						item.Barcode = Convert.ToString(dr["Barcode"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
					{
						item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
					{
						item.ContentBody = Convert.ToString(dr["ContentBody"]);
					}
					if (dr["IsBooking"] != null && dr["IsBooking"] != DBNull.Value)
					{
						item.IsBooking = Convert.ToBoolean(dr["IsBooking"]);
					}
					if (dr["IsCombo"] != null && dr["IsCombo"] != DBNull.Value)
					{
						item.IsCombo = Convert.ToBoolean(dr["IsCombo"]);
					}
					if (dr["ValidDate"] != null && dr["ValidDate"] != DBNull.Value)
					{
						item.ValidDate = Convert.ToDateTime(dr["ValidDate"]);
					}
					if (dr["ExpriedDate"] != null && dr["ExpriedDate"] != DBNull.Value)
					{
						item.ExpriedDate = Convert.ToDateTime(dr["ExpriedDate"]);
					}
					if (dr["InventoryCount"] != null && dr["InventoryCount"] != DBNull.Value)
					{
						item.InventoryCount = Convert.ToInt32(dr["InventoryCount"]);
					}
					if (dr["TradeMark"] != null && dr["TradeMark"] != DBNull.Value)
					{
						item.TradeMark = Convert.ToString(dr["TradeMark"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["PercentComission"] != null && dr["PercentComission"] != DBNull.Value)
					{
						item.PercentComission = Convert.ToInt32(dr["PercentComission"]);
					}
					if (dr["IsDynamicPrice"] != null && dr["IsDynamicPrice"] != DBNull.Value)
					{
						item.IsDynamicPrice = Convert.ToBoolean(dr["IsDynamicPrice"]);
					}
					if (dr["IsShowOnWeb"] != null && dr["IsShowOnWeb"] != DBNull.Value)
					{
						item.IsShowOnWeb = Convert.ToBoolean(dr["IsShowOnWeb"]);
					}
					if (dr["Unsign"] != null && dr["Unsign"] != DBNull.Value)
					{
						item.Unsign = Convert.ToString(dr["Unsign"]);
					}
					if (dr["Rating"] != null && dr["Rating"] != DBNull.Value)
					{
						item.Rating = (System.Double)dr["Rating"];
					}
					if (dr["ShortUnsign"] != null && dr["ShortUnsign"] != DBNull.Value)
					{
						item.ShortUnsign = Convert.ToString(dr["ShortUnsign"]);
					}
					if (dr["AtRowVersion"] != null && dr["AtRowVersion"] != DBNull.Value)
					{
						item.AtRowVersion = (System.Byte[])dr["AtRowVersion"];
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
					}
					if (dr["GroupId"] != null && dr["GroupId"] != DBNull.Value)
					{
						item.GroupId = Convert.ToString(dr["GroupId"]);
					}
					if (dr["IsDeleteGroup"] != null && dr["IsDeleteGroup"] != DBNull.Value)
					{
						item.IsDeleteGroup = Convert.ToBoolean(dr["IsDeleteGroup"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["BranchId"] != null && dr["BranchId"] != DBNull.Value)
					{
						item.BranchId = Convert.ToString(dr["BranchId"]);
					}
					if (dr["CreateByName"] != null && dr["CreateByName"] != DBNull.Value)
					{
						item.CreateByName = Convert.ToString(dr["CreateByName"]);
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
		/// Lấy danh sách view_Service từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_Service> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_Service] A "+ condition,  parameters);
				List<view_Service> items = new List<view_Service>();
				view_Service item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_Service();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Price"] != null && dr["Price"] != DBNull.Value)
					{
						item.Price = Convert.ToInt32(dr["Price"]);
					}
					if (dr["PriceMotion"] != null && dr["PriceMotion"] != DBNull.Value)
					{
						item.PriceMotion = Convert.ToInt32(dr["PriceMotion"]);
					}
					if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
					{
						item.FK_Group = Convert.ToString(dr["FK_Group"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["IsPublicBranch"] != null && dr["IsPublicBranch"] != DBNull.Value)
					{
						item.IsPublicBranch = Convert.ToBoolean(dr["IsPublicBranch"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["IsService"] != null && dr["IsService"] != DBNull.Value)
					{
						item.IsService = Convert.ToBoolean(dr["IsService"]);
					}
					if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
					{
						item.UnitName = Convert.ToString(dr["UnitName"]);
					}
					if (dr["Barcode"] != null && dr["Barcode"] != DBNull.Value)
					{
						item.Barcode = Convert.ToString(dr["Barcode"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
					{
						item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
					{
						item.ContentBody = Convert.ToString(dr["ContentBody"]);
					}
					if (dr["IsBooking"] != null && dr["IsBooking"] != DBNull.Value)
					{
						item.IsBooking = Convert.ToBoolean(dr["IsBooking"]);
					}
					if (dr["IsCombo"] != null && dr["IsCombo"] != DBNull.Value)
					{
						item.IsCombo = Convert.ToBoolean(dr["IsCombo"]);
					}
					if (dr["ValidDate"] != null && dr["ValidDate"] != DBNull.Value)
					{
						item.ValidDate = Convert.ToDateTime(dr["ValidDate"]);
					}
					if (dr["ExpriedDate"] != null && dr["ExpriedDate"] != DBNull.Value)
					{
						item.ExpriedDate = Convert.ToDateTime(dr["ExpriedDate"]);
					}
					if (dr["InventoryCount"] != null && dr["InventoryCount"] != DBNull.Value)
					{
						item.InventoryCount = Convert.ToInt32(dr["InventoryCount"]);
					}
					if (dr["TradeMark"] != null && dr["TradeMark"] != DBNull.Value)
					{
						item.TradeMark = Convert.ToString(dr["TradeMark"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["PercentComission"] != null && dr["PercentComission"] != DBNull.Value)
					{
						item.PercentComission = Convert.ToInt32(dr["PercentComission"]);
					}
					if (dr["IsDynamicPrice"] != null && dr["IsDynamicPrice"] != DBNull.Value)
					{
						item.IsDynamicPrice = Convert.ToBoolean(dr["IsDynamicPrice"]);
					}
					if (dr["IsShowOnWeb"] != null && dr["IsShowOnWeb"] != DBNull.Value)
					{
						item.IsShowOnWeb = Convert.ToBoolean(dr["IsShowOnWeb"]);
					}
					if (dr["Unsign"] != null && dr["Unsign"] != DBNull.Value)
					{
						item.Unsign = Convert.ToString(dr["Unsign"]);
					}
					if (dr["Rating"] != null && dr["Rating"] != DBNull.Value)
					{
						item.Rating = (System.Double)dr["Rating"];
					}
					if (dr["ShortUnsign"] != null && dr["ShortUnsign"] != DBNull.Value)
					{
						item.ShortUnsign = Convert.ToString(dr["ShortUnsign"]);
					}
					if (dr["AtRowVersion"] != null && dr["AtRowVersion"] != DBNull.Value)
					{
						item.AtRowVersion = (System.Byte[])dr["AtRowVersion"];
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
					}
					if (dr["GroupId"] != null && dr["GroupId"] != DBNull.Value)
					{
						item.GroupId = Convert.ToString(dr["GroupId"]);
					}
					if (dr["IsDeleteGroup"] != null && dr["IsDeleteGroup"] != DBNull.Value)
					{
						item.IsDeleteGroup = Convert.ToBoolean(dr["IsDeleteGroup"]);
					}
					if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
					{
						item.BranchName = Convert.ToString(dr["BranchName"]);
					}
					if (dr["BranchId"] != null && dr["BranchId"] != DBNull.Value)
					{
						item.BranchId = Convert.ToString(dr["BranchId"]);
					}
					if (dr["CreateByName"] != null && dr["CreateByName"] != DBNull.Value)
					{
						item.CreateByName = Convert.ToString(dr["CreateByName"]);
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

		public List<view_Service> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_Service] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_Service] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_Service>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_Service đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_Service GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_Service] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_Service item=new view_Service();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Price"] != null && dr["Price"] != DBNull.Value)
						{
							item.Price = Convert.ToInt32(dr["Price"]);
						}
						if (dr["PriceMotion"] != null && dr["PriceMotion"] != DBNull.Value)
						{
							item.PriceMotion = Convert.ToInt32(dr["PriceMotion"]);
						}
						if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
						{
							item.FK_Group = Convert.ToString(dr["FK_Group"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["IsPublicBranch"] != null && dr["IsPublicBranch"] != DBNull.Value)
						{
							item.IsPublicBranch = Convert.ToBoolean(dr["IsPublicBranch"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["IsService"] != null && dr["IsService"] != DBNull.Value)
						{
							item.IsService = Convert.ToBoolean(dr["IsService"]);
						}
						if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
						{
							item.UnitName = Convert.ToString(dr["UnitName"]);
						}
						if (dr["Barcode"] != null && dr["Barcode"] != DBNull.Value)
						{
							item.Barcode = Convert.ToString(dr["Barcode"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
						{
							item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
						{
							item.ContentBody = Convert.ToString(dr["ContentBody"]);
						}
						if (dr["IsBooking"] != null && dr["IsBooking"] != DBNull.Value)
						{
							item.IsBooking = Convert.ToBoolean(dr["IsBooking"]);
						}
						if (dr["IsCombo"] != null && dr["IsCombo"] != DBNull.Value)
						{
							item.IsCombo = Convert.ToBoolean(dr["IsCombo"]);
						}
						if (dr["ValidDate"] != null && dr["ValidDate"] != DBNull.Value)
						{
							item.ValidDate = Convert.ToDateTime(dr["ValidDate"]);
						}
						if (dr["ExpriedDate"] != null && dr["ExpriedDate"] != DBNull.Value)
						{
							item.ExpriedDate = Convert.ToDateTime(dr["ExpriedDate"]);
						}
						if (dr["InventoryCount"] != null && dr["InventoryCount"] != DBNull.Value)
						{
							item.InventoryCount = Convert.ToInt32(dr["InventoryCount"]);
						}
						if (dr["TradeMark"] != null && dr["TradeMark"] != DBNull.Value)
						{
							item.TradeMark = Convert.ToString(dr["TradeMark"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["PercentComission"] != null && dr["PercentComission"] != DBNull.Value)
						{
							item.PercentComission = Convert.ToInt32(dr["PercentComission"]);
						}
						if (dr["IsDynamicPrice"] != null && dr["IsDynamicPrice"] != DBNull.Value)
						{
							item.IsDynamicPrice = Convert.ToBoolean(dr["IsDynamicPrice"]);
						}
						if (dr["IsShowOnWeb"] != null && dr["IsShowOnWeb"] != DBNull.Value)
						{
							item.IsShowOnWeb = Convert.ToBoolean(dr["IsShowOnWeb"]);
						}
						if (dr["Unsign"] != null && dr["Unsign"] != DBNull.Value)
						{
							item.Unsign = Convert.ToString(dr["Unsign"]);
						}
						if (dr["Rating"] != null && dr["Rating"] != DBNull.Value)
						{
							item.Rating = (System.Double)dr["Rating"];
						}
						if (dr["ShortUnsign"] != null && dr["ShortUnsign"] != DBNull.Value)
						{
							item.ShortUnsign = Convert.ToString(dr["ShortUnsign"]);
						}
						if (dr["AtRowVersion"] != null && dr["AtRowVersion"] != DBNull.Value)
						{
							item.AtRowVersion = (System.Byte[])dr["AtRowVersion"];
						}
						if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
						{
							item.Icon = Convert.ToString(dr["Icon"]);
						}
						if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
						{
							item.GroupName = Convert.ToString(dr["GroupName"]);
						}
						if (dr["GroupId"] != null && dr["GroupId"] != DBNull.Value)
						{
							item.GroupId = Convert.ToString(dr["GroupId"]);
						}
						if (dr["IsDeleteGroup"] != null && dr["IsDeleteGroup"] != DBNull.Value)
						{
							item.IsDeleteGroup = Convert.ToBoolean(dr["IsDeleteGroup"]);
						}
						if (dr["BranchName"] != null && dr["BranchName"] != DBNull.Value)
						{
							item.BranchName = Convert.ToString(dr["BranchName"]);
						}
						if (dr["BranchId"] != null && dr["BranchId"] != DBNull.Value)
						{
							item.BranchId = Convert.ToString(dr["BranchId"]);
						}
						if (dr["CreateByName"] != null && dr["CreateByName"] != DBNull.Value)
						{
							item.CreateByName = Convert.ToString(dr["CreateByName"]);
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

		public view_Service GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_Service] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_Service>(ds);
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
