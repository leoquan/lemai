using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSErvice:ISErvice
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSErvice(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable Service từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Service]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable Service từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Service] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách Service từ Database
		/// </summary>
		public List<Service> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Service]");
				List<Service> items = new List<Service>();
				Service item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Service();
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
		/// Lấy danh sách Service từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<Service> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Service] A "+ condition,  parameters);
				List<Service> items = new List<Service>();
				Service item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Service();
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<Service> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Service] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[Service] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<Service>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một Service từ Database
		/// </summary>
		public Service GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Service] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					Service item=new Service();
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
		/// Lấy một Service đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public Service GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Service] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					Service item=new Service();
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

		public Service GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Service] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<Service>(ds);
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
		/// Thêm mới Service vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, Service _Service)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[Service](Id, Code, Name, Price, PriceMotion, FK_Group, FK_Branch, IsPublicBranch, CreateDate, CreateBy, IsService, UnitName, Barcode, ImagePath, ShortDescription, Description, ContentBody, IsBooking, IsCombo, ValidDate, ExpriedDate, InventoryCount, TradeMark, IsDelete, PercentComission, IsDynamicPrice, IsShowOnWeb, Unsign, Rating, ShortUnsign, Icon) VALUES(@Id, @Code, @Name, @Price, @PriceMotion, @FK_Group, @FK_Branch, @IsPublicBranch, @CreateDate, @CreateBy, @IsService, @UnitName, @Barcode, @ImagePath, @ShortDescription, @Description, @ContentBody, @IsBooking, @IsCombo, @ValidDate, @ExpriedDate, @InventoryCount, @TradeMark, @IsDelete, @PercentComission, @IsDynamicPrice, @IsShowOnWeb, @Unsign, @Rating, @ShortUnsign, @Icon)", 
					"@Id",  _Service.Id, 
					"@Code",  _Service.Code, 
					"@Name",  _Service.Name, 
					"@Price",  _Service.Price, 
					"@PriceMotion",  _Service.PriceMotion, 
					"@FK_Group",  _Service.FK_Group, 
					"@FK_Branch",  _Service.FK_Branch, 
					"@IsPublicBranch",  _Service.IsPublicBranch, 
					"@CreateDate", this._dataContext.ConvertDateString( _Service.CreateDate), 
					"@CreateBy",  _Service.CreateBy, 
					"@IsService",  _Service.IsService, 
					"@UnitName",  _Service.UnitName, 
					"@Barcode",  _Service.Barcode, 
					"@ImagePath",  _Service.ImagePath, 
					"@ShortDescription",  _Service.ShortDescription, 
					"@Description",  _Service.Description, 
					"@ContentBody",  _Service.ContentBody, 
					"@IsBooking",  _Service.IsBooking, 
					"@IsCombo",  _Service.IsCombo, 
					"@ValidDate", this._dataContext.ConvertDateString( _Service.ValidDate), 
					"@ExpriedDate", this._dataContext.ConvertDateString( _Service.ExpriedDate), 
					"@InventoryCount",  _Service.InventoryCount, 
					"@TradeMark",  _Service.TradeMark, 
					"@IsDelete",  _Service.IsDelete, 
					"@PercentComission",  _Service.PercentComission, 
					"@IsDynamicPrice",  _Service.IsDynamicPrice, 
					"@IsShowOnWeb",  _Service.IsShowOnWeb, 
					"@Unsign",  _Service.Unsign, 
					"@Rating",  _Service.Rating, 
					"@ShortUnsign",  _Service.ShortUnsign, 
					"@Icon",  _Service.Icon);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng Service vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<Service> _Services)
		{
			foreach (Service item in _Services)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Thêm mới Service vào Database kết quả trả về là giá trị của cột tự động tăng
		/// </summary>
		public int InsertReturnAutonumber(string schema, Service _Service)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("INSERT INTO " + schema + ".[Service](Id, Code, Name, Price, PriceMotion, FK_Group, FK_Branch, IsPublicBranch, CreateDate, CreateBy, IsService, UnitName, Barcode, ImagePath, ShortDescription, Description, ContentBody, IsBooking, IsCombo, ValidDate, ExpriedDate, InventoryCount, TradeMark, IsDelete, PercentComission, IsDynamicPrice, IsShowOnWeb, Unsign, Rating, ShortUnsign, Icon) VALUES(@Id, @Code, @Name, @Price, @PriceMotion, @FK_Group, @FK_Branch, @IsPublicBranch, @CreateDate, @CreateBy, @IsService, @UnitName, @Barcode, @ImagePath, @ShortDescription, @Description, @ContentBody, @IsBooking, @IsCombo, @ValidDate, @ExpriedDate, @InventoryCount, @TradeMark, @IsDelete, @PercentComission, @IsDynamicPrice, @IsShowOnWeb, @Unsign, @Rating, @ShortUnsign, @Icon)  returning AtRowVersion", 
					"@Id",  _Service.Id, 
					"@Code",  _Service.Code, 
					"@Name",  _Service.Name, 
					"@Price",  _Service.Price, 
					"@PriceMotion",  _Service.PriceMotion, 
					"@FK_Group",  _Service.FK_Group, 
					"@FK_Branch",  _Service.FK_Branch, 
					"@IsPublicBranch",  _Service.IsPublicBranch, 
					"@CreateDate", this._dataContext.ConvertDateString( _Service.CreateDate), 
					"@CreateBy",  _Service.CreateBy, 
					"@IsService",  _Service.IsService, 
					"@UnitName",  _Service.UnitName, 
					"@Barcode",  _Service.Barcode, 
					"@ImagePath",  _Service.ImagePath, 
					"@ShortDescription",  _Service.ShortDescription, 
					"@Description",  _Service.Description, 
					"@ContentBody",  _Service.ContentBody, 
					"@IsBooking",  _Service.IsBooking, 
					"@IsCombo",  _Service.IsCombo, 
					"@ValidDate", this._dataContext.ConvertDateString( _Service.ValidDate), 
					"@ExpriedDate", this._dataContext.ConvertDateString( _Service.ExpriedDate), 
					"@InventoryCount",  _Service.InventoryCount, 
					"@TradeMark",  _Service.TradeMark, 
					"@IsDelete",  _Service.IsDelete, 
					"@PercentComission",  _Service.PercentComission, 
					"@IsDynamicPrice",  _Service.IsDynamicPrice, 
					"@IsShowOnWeb",  _Service.IsShowOnWeb, 
					"@Unsign",  _Service.Unsign, 
					"@Rating",  _Service.Rating, 
					"@ShortUnsign",  _Service.ShortUnsign, 
					"@Icon",  _Service.Icon);
				return Int32.Parse(ds.Rows[0][0].ToString());
			}
			catch
			{
				return -1;
			}
		}
		/// <summary>
		/// Cập nhật Service vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, Service _Service, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Service] SET Id=@Id, Code=@Code, Name=@Name, Price=@Price, PriceMotion=@PriceMotion, FK_Group=@FK_Group, FK_Branch=@FK_Branch, IsPublicBranch=@IsPublicBranch, CreateDate=@CreateDate, CreateBy=@CreateBy, IsService=@IsService, UnitName=@UnitName, Barcode=@Barcode, ImagePath=@ImagePath, ShortDescription=@ShortDescription, Description=@Description, ContentBody=@ContentBody, IsBooking=@IsBooking, IsCombo=@IsCombo, ValidDate=@ValidDate, ExpriedDate=@ExpriedDate, InventoryCount=@InventoryCount, TradeMark=@TradeMark, IsDelete=@IsDelete, PercentComission=@PercentComission, IsDynamicPrice=@IsDynamicPrice, IsShowOnWeb=@IsShowOnWeb, Unsign=@Unsign, Rating=@Rating, ShortUnsign=@ShortUnsign, Icon=@Icon WHERE Id=@Id", 
					"@Id",  _Service.Id, 
					"@Code",  _Service.Code, 
					"@Name",  _Service.Name, 
					"@Price",  _Service.Price, 
					"@PriceMotion",  _Service.PriceMotion, 
					"@FK_Group",  _Service.FK_Group, 
					"@FK_Branch",  _Service.FK_Branch, 
					"@IsPublicBranch",  _Service.IsPublicBranch, 
					"@CreateDate", this._dataContext.ConvertDateString( _Service.CreateDate), 
					"@CreateBy",  _Service.CreateBy, 
					"@IsService",  _Service.IsService, 
					"@UnitName",  _Service.UnitName, 
					"@Barcode",  _Service.Barcode, 
					"@ImagePath",  _Service.ImagePath, 
					"@ShortDescription",  _Service.ShortDescription, 
					"@Description",  _Service.Description, 
					"@ContentBody",  _Service.ContentBody, 
					"@IsBooking",  _Service.IsBooking, 
					"@IsCombo",  _Service.IsCombo, 
					"@ValidDate", this._dataContext.ConvertDateString( _Service.ValidDate), 
					"@ExpriedDate", this._dataContext.ConvertDateString( _Service.ExpriedDate), 
					"@InventoryCount",  _Service.InventoryCount, 
					"@TradeMark",  _Service.TradeMark, 
					"@IsDelete",  _Service.IsDelete, 
					"@PercentComission",  _Service.PercentComission, 
					"@IsDynamicPrice",  _Service.IsDynamicPrice, 
					"@IsShowOnWeb",  _Service.IsShowOnWeb, 
					"@Unsign",  _Service.Unsign, 
					"@Rating",  _Service.Rating, 
					"@ShortUnsign",  _Service.ShortUnsign, 
					"@Icon",  _Service.Icon, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật Service vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, Service _Service)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Service] SET Code=@Code, Name=@Name, Price=@Price, PriceMotion=@PriceMotion, FK_Group=@FK_Group, FK_Branch=@FK_Branch, IsPublicBranch=@IsPublicBranch, CreateDate=@CreateDate, CreateBy=@CreateBy, IsService=@IsService, UnitName=@UnitName, Barcode=@Barcode, ImagePath=@ImagePath, ShortDescription=@ShortDescription, Description=@Description, ContentBody=@ContentBody, IsBooking=@IsBooking, IsCombo=@IsCombo, ValidDate=@ValidDate, ExpriedDate=@ExpriedDate, InventoryCount=@InventoryCount, TradeMark=@TradeMark, IsDelete=@IsDelete, PercentComission=@PercentComission, IsDynamicPrice=@IsDynamicPrice, IsShowOnWeb=@IsShowOnWeb, Unsign=@Unsign, Rating=@Rating, ShortUnsign=@ShortUnsign, Icon=@Icon WHERE Id=@Id", 
					"@Code",  _Service.Code, 
					"@Name",  _Service.Name, 
					"@Price",  _Service.Price, 
					"@PriceMotion",  _Service.PriceMotion, 
					"@FK_Group",  _Service.FK_Group, 
					"@FK_Branch",  _Service.FK_Branch, 
					"@IsPublicBranch",  _Service.IsPublicBranch, 
					"@CreateDate", this._dataContext.ConvertDateString( _Service.CreateDate), 
					"@CreateBy",  _Service.CreateBy, 
					"@IsService",  _Service.IsService, 
					"@UnitName",  _Service.UnitName, 
					"@Barcode",  _Service.Barcode, 
					"@ImagePath",  _Service.ImagePath, 
					"@ShortDescription",  _Service.ShortDescription, 
					"@Description",  _Service.Description, 
					"@ContentBody",  _Service.ContentBody, 
					"@IsBooking",  _Service.IsBooking, 
					"@IsCombo",  _Service.IsCombo, 
					"@ValidDate", this._dataContext.ConvertDateString( _Service.ValidDate), 
					"@ExpriedDate", this._dataContext.ConvertDateString( _Service.ExpriedDate), 
					"@InventoryCount",  _Service.InventoryCount, 
					"@TradeMark",  _Service.TradeMark, 
					"@IsDelete",  _Service.IsDelete, 
					"@PercentComission",  _Service.PercentComission, 
					"@IsDynamicPrice",  _Service.IsDynamicPrice, 
					"@IsShowOnWeb",  _Service.IsShowOnWeb, 
					"@Unsign",  _Service.Unsign, 
					"@Rating",  _Service.Rating, 
					"@ShortUnsign",  _Service.ShortUnsign, 
					"@Icon",  _Service.Icon, 
					"@Id", _Service.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách Service vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<Service> _Services)
		{
			foreach (Service item in _Services)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Service vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, Service _Service, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Service] SET Id=@Id, Code=@Code, Name=@Name, Price=@Price, PriceMotion=@PriceMotion, FK_Group=@FK_Group, FK_Branch=@FK_Branch, IsPublicBranch=@IsPublicBranch, CreateDate=@CreateDate, CreateBy=@CreateBy, IsService=@IsService, UnitName=@UnitName, Barcode=@Barcode, ImagePath=@ImagePath, ShortDescription=@ShortDescription, Description=@Description, ContentBody=@ContentBody, IsBooking=@IsBooking, IsCombo=@IsCombo, ValidDate=@ValidDate, ExpriedDate=@ExpriedDate, InventoryCount=@InventoryCount, TradeMark=@TradeMark, IsDelete=@IsDelete, PercentComission=@PercentComission, IsDynamicPrice=@IsDynamicPrice, IsShowOnWeb=@IsShowOnWeb, Unsign=@Unsign, Rating=@Rating, ShortUnsign=@ShortUnsign, Icon=@Icon "+ condition, 
					"@Id",  _Service.Id, 
					"@Code",  _Service.Code, 
					"@Name",  _Service.Name, 
					"@Price",  _Service.Price, 
					"@PriceMotion",  _Service.PriceMotion, 
					"@FK_Group",  _Service.FK_Group, 
					"@FK_Branch",  _Service.FK_Branch, 
					"@IsPublicBranch",  _Service.IsPublicBranch, 
					"@CreateDate", this._dataContext.ConvertDateString( _Service.CreateDate), 
					"@CreateBy",  _Service.CreateBy, 
					"@IsService",  _Service.IsService, 
					"@UnitName",  _Service.UnitName, 
					"@Barcode",  _Service.Barcode, 
					"@ImagePath",  _Service.ImagePath, 
					"@ShortDescription",  _Service.ShortDescription, 
					"@Description",  _Service.Description, 
					"@ContentBody",  _Service.ContentBody, 
					"@IsBooking",  _Service.IsBooking, 
					"@IsCombo",  _Service.IsCombo, 
					"@ValidDate", this._dataContext.ConvertDateString( _Service.ValidDate), 
					"@ExpriedDate", this._dataContext.ConvertDateString( _Service.ExpriedDate), 
					"@InventoryCount",  _Service.InventoryCount, 
					"@TradeMark",  _Service.TradeMark, 
					"@IsDelete",  _Service.IsDelete, 
					"@PercentComission",  _Service.PercentComission, 
					"@IsDynamicPrice",  _Service.IsDynamicPrice, 
					"@IsShowOnWeb",  _Service.IsShowOnWeb, 
					"@Unsign",  _Service.Unsign, 
					"@Rating",  _Service.Rating, 
					"@ShortUnsign",  _Service.ShortUnsign, 
					"@Icon",  _Service.Icon);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa Service trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Service] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Service trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Service _Service)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Service] WHERE Id=@Id",
					"@Id", _Service.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Service trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Service] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Service trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<Service> _Services)
		{
			foreach (Service item in _Services)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
