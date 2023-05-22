using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MINventory:IINventory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MINventory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable Inventory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Inventory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable Inventory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[Inventory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách Inventory từ Database
		/// </summary>
		public List<Inventory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Inventory]");
				List<Inventory> items = new List<Inventory>();
				Inventory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Inventory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Stock"] != null && dr["FK_Stock"] != DBNull.Value)
					{
						item.FK_Stock = Convert.ToString(dr["FK_Stock"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["RealityAmount"] != null && dr["RealityAmount"] != DBNull.Value)
					{
						item.RealityAmount = Convert.ToDecimal(dr["RealityAmount"]);
					}
					if (dr["ImportAmount"] != null && dr["ImportAmount"] != DBNull.Value)
					{
						item.ImportAmount = Convert.ToDecimal(dr["ImportAmount"]);
					}
					if (dr["ExportAmount"] != null && dr["ExportAmount"] != DBNull.Value)
					{
						item.ExportAmount = Convert.ToDecimal(dr["ExportAmount"]);
					}
					if (dr["InitAmount"] != null && dr["InitAmount"] != DBNull.Value)
					{
						item.InitAmount = Convert.ToDecimal(dr["InitAmount"]);
					}
					if (dr["Lot"] != null && dr["Lot"] != DBNull.Value)
					{
						item.Lot = Convert.ToString(dr["Lot"]);
					}
					if (dr["ExperiedDate"] != null && dr["ExperiedDate"] != DBNull.Value)
					{
						item.ExperiedDate = Convert.ToDateTime(dr["ExperiedDate"]);
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
		/// Lấy danh sách Inventory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<Inventory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Inventory] A "+ condition,  parameters);
				List<Inventory> items = new List<Inventory>();
				Inventory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new Inventory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Stock"] != null && dr["FK_Stock"] != DBNull.Value)
					{
						item.FK_Stock = Convert.ToString(dr["FK_Stock"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["RealityAmount"] != null && dr["RealityAmount"] != DBNull.Value)
					{
						item.RealityAmount = Convert.ToDecimal(dr["RealityAmount"]);
					}
					if (dr["ImportAmount"] != null && dr["ImportAmount"] != DBNull.Value)
					{
						item.ImportAmount = Convert.ToDecimal(dr["ImportAmount"]);
					}
					if (dr["ExportAmount"] != null && dr["ExportAmount"] != DBNull.Value)
					{
						item.ExportAmount = Convert.ToDecimal(dr["ExportAmount"]);
					}
					if (dr["InitAmount"] != null && dr["InitAmount"] != DBNull.Value)
					{
						item.InitAmount = Convert.ToDecimal(dr["InitAmount"]);
					}
					if (dr["Lot"] != null && dr["Lot"] != DBNull.Value)
					{
						item.Lot = Convert.ToString(dr["Lot"]);
					}
					if (dr["ExperiedDate"] != null && dr["ExperiedDate"] != DBNull.Value)
					{
						item.ExperiedDate = Convert.ToDateTime(dr["ExperiedDate"]);
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

		public List<Inventory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Inventory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[Inventory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<Inventory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một Inventory từ Database
		/// </summary>
		public Inventory GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[Inventory] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					Inventory item=new Inventory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Stock"] != null && dr["FK_Stock"] != DBNull.Value)
						{
							item.FK_Stock = Convert.ToString(dr["FK_Stock"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["RealityAmount"] != null && dr["RealityAmount"] != DBNull.Value)
						{
							item.RealityAmount = Convert.ToDecimal(dr["RealityAmount"]);
						}
						if (dr["ImportAmount"] != null && dr["ImportAmount"] != DBNull.Value)
						{
							item.ImportAmount = Convert.ToDecimal(dr["ImportAmount"]);
						}
						if (dr["ExportAmount"] != null && dr["ExportAmount"] != DBNull.Value)
						{
							item.ExportAmount = Convert.ToDecimal(dr["ExportAmount"]);
						}
						if (dr["InitAmount"] != null && dr["InitAmount"] != DBNull.Value)
						{
							item.InitAmount = Convert.ToDecimal(dr["InitAmount"]);
						}
						if (dr["Lot"] != null && dr["Lot"] != DBNull.Value)
						{
							item.Lot = Convert.ToString(dr["Lot"]);
						}
						if (dr["ExperiedDate"] != null && dr["ExperiedDate"] != DBNull.Value)
						{
							item.ExperiedDate = Convert.ToDateTime(dr["ExperiedDate"]);
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
		/// Lấy một Inventory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public Inventory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[Inventory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					Inventory item=new Inventory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Stock"] != null && dr["FK_Stock"] != DBNull.Value)
						{
							item.FK_Stock = Convert.ToString(dr["FK_Stock"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["RealityAmount"] != null && dr["RealityAmount"] != DBNull.Value)
						{
							item.RealityAmount = Convert.ToDecimal(dr["RealityAmount"]);
						}
						if (dr["ImportAmount"] != null && dr["ImportAmount"] != DBNull.Value)
						{
							item.ImportAmount = Convert.ToDecimal(dr["ImportAmount"]);
						}
						if (dr["ExportAmount"] != null && dr["ExportAmount"] != DBNull.Value)
						{
							item.ExportAmount = Convert.ToDecimal(dr["ExportAmount"]);
						}
						if (dr["InitAmount"] != null && dr["InitAmount"] != DBNull.Value)
						{
							item.InitAmount = Convert.ToDecimal(dr["InitAmount"]);
						}
						if (dr["Lot"] != null && dr["Lot"] != DBNull.Value)
						{
							item.Lot = Convert.ToString(dr["Lot"]);
						}
						if (dr["ExperiedDate"] != null && dr["ExperiedDate"] != DBNull.Value)
						{
							item.ExperiedDate = Convert.ToDateTime(dr["ExperiedDate"]);
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

		public Inventory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[Inventory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<Inventory>(ds);
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
		/// Thêm mới Inventory vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, Inventory _Inventory)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[Inventory](Id, FK_Stock, FK_Service, RealityAmount, ImportAmount, ExportAmount, InitAmount, Lot, ExperiedDate) VALUES(@Id, @FK_Stock, @FK_Service, @RealityAmount, @ImportAmount, @ExportAmount, @InitAmount, @Lot, @ExperiedDate)", 
					"@Id",  _Inventory.Id, 
					"@FK_Stock",  _Inventory.FK_Stock, 
					"@FK_Service",  _Inventory.FK_Service, 
					"@RealityAmount",  _Inventory.RealityAmount, 
					"@ImportAmount",  _Inventory.ImportAmount, 
					"@ExportAmount",  _Inventory.ExportAmount, 
					"@InitAmount",  _Inventory.InitAmount, 
					"@Lot",  _Inventory.Lot, 
					"@ExperiedDate", this._dataContext.ConvertDateString( _Inventory.ExperiedDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng Inventory vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<Inventory> _Inventorys)
		{
			foreach (Inventory item in _Inventorys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Inventory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, Inventory _Inventory, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Inventory] SET Id=@Id, FK_Stock=@FK_Stock, FK_Service=@FK_Service, RealityAmount=@RealityAmount, ImportAmount=@ImportAmount, ExportAmount=@ExportAmount, InitAmount=@InitAmount, Lot=@Lot, ExperiedDate=@ExperiedDate WHERE Id=@Id", 
					"@Id",  _Inventory.Id, 
					"@FK_Stock",  _Inventory.FK_Stock, 
					"@FK_Service",  _Inventory.FK_Service, 
					"@RealityAmount",  _Inventory.RealityAmount, 
					"@ImportAmount",  _Inventory.ImportAmount, 
					"@ExportAmount",  _Inventory.ExportAmount, 
					"@InitAmount",  _Inventory.InitAmount, 
					"@Lot",  _Inventory.Lot, 
					"@ExperiedDate", this._dataContext.ConvertDateString( _Inventory.ExperiedDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật Inventory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, Inventory _Inventory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Inventory] SET FK_Stock=@FK_Stock, FK_Service=@FK_Service, RealityAmount=@RealityAmount, ImportAmount=@ImportAmount, ExportAmount=@ExportAmount, InitAmount=@InitAmount, Lot=@Lot, ExperiedDate=@ExperiedDate WHERE Id=@Id", 
					"@FK_Stock",  _Inventory.FK_Stock, 
					"@FK_Service",  _Inventory.FK_Service, 
					"@RealityAmount",  _Inventory.RealityAmount, 
					"@ImportAmount",  _Inventory.ImportAmount, 
					"@ExportAmount",  _Inventory.ExportAmount, 
					"@InitAmount",  _Inventory.InitAmount, 
					"@Lot",  _Inventory.Lot, 
					"@ExperiedDate", this._dataContext.ConvertDateString( _Inventory.ExperiedDate), 
					"@Id", _Inventory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách Inventory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<Inventory> _Inventorys)
		{
			foreach (Inventory item in _Inventorys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật Inventory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, Inventory _Inventory, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[Inventory] SET Id=@Id, FK_Stock=@FK_Stock, FK_Service=@FK_Service, RealityAmount=@RealityAmount, ImportAmount=@ImportAmount, ExportAmount=@ExportAmount, InitAmount=@InitAmount, Lot=@Lot, ExperiedDate=@ExperiedDate "+ condition, 
					"@Id",  _Inventory.Id, 
					"@FK_Stock",  _Inventory.FK_Stock, 
					"@FK_Service",  _Inventory.FK_Service, 
					"@RealityAmount",  _Inventory.RealityAmount, 
					"@ImportAmount",  _Inventory.ImportAmount, 
					"@ExportAmount",  _Inventory.ExportAmount, 
					"@InitAmount",  _Inventory.InitAmount, 
					"@Lot",  _Inventory.Lot, 
					"@ExperiedDate", this._dataContext.ConvertDateString( _Inventory.ExperiedDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa Inventory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Inventory] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Inventory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Inventory _Inventory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Inventory] WHERE Id=@Id",
					"@Id", _Inventory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Inventory trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[Inventory] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa Inventory trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<Inventory> _Inventorys)
		{
			foreach (Inventory item in _Inventorys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
