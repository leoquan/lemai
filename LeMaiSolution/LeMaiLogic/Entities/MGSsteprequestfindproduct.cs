using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSsteprequestfindproduct:IGSsteprequestfindproduct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSsteprequestfindproduct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsStepRequestFindProduct từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsStepRequestFindProduct]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsStepRequestFindProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsStepRequestFindProduct] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsStepRequestFindProduct từ Database
		/// </summary>
		public List<GsStepRequestFindProduct> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsStepRequestFindProduct]");
				List<GsStepRequestFindProduct> items = new List<GsStepRequestFindProduct>();
				GsStepRequestFindProduct item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsStepRequestFindProduct();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_RequestFindProduct"] != null && dr["FK_RequestFindProduct"] != DBNull.Value)
					{
						item.FK_RequestFindProduct = Convert.ToString(dr["FK_RequestFindProduct"]);
					}
					if (dr["FK_StepDef"] != null && dr["FK_StepDef"] != DBNull.Value)
					{
						item.FK_StepDef = Convert.ToString(dr["FK_StepDef"]);
					}
					if (dr["FK_AccountUser"] != null && dr["FK_AccountUser"] != DBNull.Value)
					{
						item.FK_AccountUser = Convert.ToString(dr["FK_AccountUser"]);
					}
					if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
					{
						item.FK_Group = Convert.ToString(dr["FK_Group"]);
					}
					if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
					{
						item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
					{
						item.StartDate = Convert.ToDateTime(dr["StartDate"]);
					}
					if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
					{
						item.EndDate = Convert.ToDateTime(dr["EndDate"]);
					}
					if (dr["DuringMinute"] != null && dr["DuringMinute"] != DBNull.Value)
					{
						item.DuringMinute = Convert.ToInt32(dr["DuringMinute"]);
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
		/// Lấy danh sách GsStepRequestFindProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsStepRequestFindProduct> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsStepRequestFindProduct] A "+ condition,  parameters);
				List<GsStepRequestFindProduct> items = new List<GsStepRequestFindProduct>();
				GsStepRequestFindProduct item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsStepRequestFindProduct();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_RequestFindProduct"] != null && dr["FK_RequestFindProduct"] != DBNull.Value)
					{
						item.FK_RequestFindProduct = Convert.ToString(dr["FK_RequestFindProduct"]);
					}
					if (dr["FK_StepDef"] != null && dr["FK_StepDef"] != DBNull.Value)
					{
						item.FK_StepDef = Convert.ToString(dr["FK_StepDef"]);
					}
					if (dr["FK_AccountUser"] != null && dr["FK_AccountUser"] != DBNull.Value)
					{
						item.FK_AccountUser = Convert.ToString(dr["FK_AccountUser"]);
					}
					if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
					{
						item.FK_Group = Convert.ToString(dr["FK_Group"]);
					}
					if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
					{
						item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
					{
						item.StartDate = Convert.ToDateTime(dr["StartDate"]);
					}
					if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
					{
						item.EndDate = Convert.ToDateTime(dr["EndDate"]);
					}
					if (dr["DuringMinute"] != null && dr["DuringMinute"] != DBNull.Value)
					{
						item.DuringMinute = Convert.ToInt32(dr["DuringMinute"]);
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

		public List<GsStepRequestFindProduct> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsStepRequestFindProduct] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsStepRequestFindProduct] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsStepRequestFindProduct>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsStepRequestFindProduct từ Database
		/// </summary>
		public GsStepRequestFindProduct GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsStepRequestFindProduct] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsStepRequestFindProduct item=new GsStepRequestFindProduct();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_RequestFindProduct"] != null && dr["FK_RequestFindProduct"] != DBNull.Value)
						{
							item.FK_RequestFindProduct = Convert.ToString(dr["FK_RequestFindProduct"]);
						}
						if (dr["FK_StepDef"] != null && dr["FK_StepDef"] != DBNull.Value)
						{
							item.FK_StepDef = Convert.ToString(dr["FK_StepDef"]);
						}
						if (dr["FK_AccountUser"] != null && dr["FK_AccountUser"] != DBNull.Value)
						{
							item.FK_AccountUser = Convert.ToString(dr["FK_AccountUser"]);
						}
						if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
						{
							item.FK_Group = Convert.ToString(dr["FK_Group"]);
						}
						if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
						{
							item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
						{
							item.StartDate = Convert.ToDateTime(dr["StartDate"]);
						}
						if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
						{
							item.EndDate = Convert.ToDateTime(dr["EndDate"]);
						}
						if (dr["DuringMinute"] != null && dr["DuringMinute"] != DBNull.Value)
						{
							item.DuringMinute = Convert.ToInt32(dr["DuringMinute"]);
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
		/// Lấy một GsStepRequestFindProduct đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsStepRequestFindProduct GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsStepRequestFindProduct] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsStepRequestFindProduct item=new GsStepRequestFindProduct();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_RequestFindProduct"] != null && dr["FK_RequestFindProduct"] != DBNull.Value)
						{
							item.FK_RequestFindProduct = Convert.ToString(dr["FK_RequestFindProduct"]);
						}
						if (dr["FK_StepDef"] != null && dr["FK_StepDef"] != DBNull.Value)
						{
							item.FK_StepDef = Convert.ToString(dr["FK_StepDef"]);
						}
						if (dr["FK_AccountUser"] != null && dr["FK_AccountUser"] != DBNull.Value)
						{
							item.FK_AccountUser = Convert.ToString(dr["FK_AccountUser"]);
						}
						if (dr["FK_Group"] != null && dr["FK_Group"] != DBNull.Value)
						{
							item.FK_Group = Convert.ToString(dr["FK_Group"]);
						}
						if (dr["ProcessDate"] != null && dr["ProcessDate"] != DBNull.Value)
						{
							item.ProcessDate = Convert.ToDateTime(dr["ProcessDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
						{
							item.StartDate = Convert.ToDateTime(dr["StartDate"]);
						}
						if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
						{
							item.EndDate = Convert.ToDateTime(dr["EndDate"]);
						}
						if (dr["DuringMinute"] != null && dr["DuringMinute"] != DBNull.Value)
						{
							item.DuringMinute = Convert.ToInt32(dr["DuringMinute"]);
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

		public GsStepRequestFindProduct GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsStepRequestFindProduct] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsStepRequestFindProduct>(ds);
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
		/// Thêm mới GsStepRequestFindProduct vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsStepRequestFindProduct _GsStepRequestFindProduct)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsStepRequestFindProduct](Id, FK_RequestFindProduct, FK_StepDef, FK_AccountUser, FK_Group, ProcessDate, Note, StartDate, EndDate, DuringMinute) VALUES(@Id, @FK_RequestFindProduct, @FK_StepDef, @FK_AccountUser, @FK_Group, @ProcessDate, @Note, @StartDate, @EndDate, @DuringMinute)", 
					"@Id",  _GsStepRequestFindProduct.Id, 
					"@FK_RequestFindProduct",  _GsStepRequestFindProduct.FK_RequestFindProduct, 
					"@FK_StepDef",  _GsStepRequestFindProduct.FK_StepDef, 
					"@FK_AccountUser",  _GsStepRequestFindProduct.FK_AccountUser, 
					"@FK_Group",  _GsStepRequestFindProduct.FK_Group, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.ProcessDate), 
					"@Note",  _GsStepRequestFindProduct.Note, 
					"@StartDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.EndDate), 
					"@DuringMinute",  _GsStepRequestFindProduct.DuringMinute);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsStepRequestFindProduct vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsStepRequestFindProduct> _GsStepRequestFindProducts)
		{
			foreach (GsStepRequestFindProduct item in _GsStepRequestFindProducts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsStepRequestFindProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsStepRequestFindProduct _GsStepRequestFindProduct, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsStepRequestFindProduct] SET Id=@Id, FK_RequestFindProduct=@FK_RequestFindProduct, FK_StepDef=@FK_StepDef, FK_AccountUser=@FK_AccountUser, FK_Group=@FK_Group, ProcessDate=@ProcessDate, Note=@Note, StartDate=@StartDate, EndDate=@EndDate, DuringMinute=@DuringMinute WHERE Id=@Id", 
					"@Id",  _GsStepRequestFindProduct.Id, 
					"@FK_RequestFindProduct",  _GsStepRequestFindProduct.FK_RequestFindProduct, 
					"@FK_StepDef",  _GsStepRequestFindProduct.FK_StepDef, 
					"@FK_AccountUser",  _GsStepRequestFindProduct.FK_AccountUser, 
					"@FK_Group",  _GsStepRequestFindProduct.FK_Group, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.ProcessDate), 
					"@Note",  _GsStepRequestFindProduct.Note, 
					"@StartDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.EndDate), 
					"@DuringMinute",  _GsStepRequestFindProduct.DuringMinute, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsStepRequestFindProduct vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsStepRequestFindProduct _GsStepRequestFindProduct)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsStepRequestFindProduct] SET FK_RequestFindProduct=@FK_RequestFindProduct, FK_StepDef=@FK_StepDef, FK_AccountUser=@FK_AccountUser, FK_Group=@FK_Group, ProcessDate=@ProcessDate, Note=@Note, StartDate=@StartDate, EndDate=@EndDate, DuringMinute=@DuringMinute WHERE Id=@Id", 
					"@FK_RequestFindProduct",  _GsStepRequestFindProduct.FK_RequestFindProduct, 
					"@FK_StepDef",  _GsStepRequestFindProduct.FK_StepDef, 
					"@FK_AccountUser",  _GsStepRequestFindProduct.FK_AccountUser, 
					"@FK_Group",  _GsStepRequestFindProduct.FK_Group, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.ProcessDate), 
					"@Note",  _GsStepRequestFindProduct.Note, 
					"@StartDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.EndDate), 
					"@DuringMinute",  _GsStepRequestFindProduct.DuringMinute, 
					"@Id", _GsStepRequestFindProduct.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsStepRequestFindProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsStepRequestFindProduct> _GsStepRequestFindProducts)
		{
			foreach (GsStepRequestFindProduct item in _GsStepRequestFindProducts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsStepRequestFindProduct vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsStepRequestFindProduct _GsStepRequestFindProduct, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsStepRequestFindProduct] SET Id=@Id, FK_RequestFindProduct=@FK_RequestFindProduct, FK_StepDef=@FK_StepDef, FK_AccountUser=@FK_AccountUser, FK_Group=@FK_Group, ProcessDate=@ProcessDate, Note=@Note, StartDate=@StartDate, EndDate=@EndDate, DuringMinute=@DuringMinute "+ condition, 
					"@Id",  _GsStepRequestFindProduct.Id, 
					"@FK_RequestFindProduct",  _GsStepRequestFindProduct.FK_RequestFindProduct, 
					"@FK_StepDef",  _GsStepRequestFindProduct.FK_StepDef, 
					"@FK_AccountUser",  _GsStepRequestFindProduct.FK_AccountUser, 
					"@FK_Group",  _GsStepRequestFindProduct.FK_Group, 
					"@ProcessDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.ProcessDate), 
					"@Note",  _GsStepRequestFindProduct.Note, 
					"@StartDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _GsStepRequestFindProduct.EndDate), 
					"@DuringMinute",  _GsStepRequestFindProduct.DuringMinute);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsStepRequestFindProduct trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsStepRequestFindProduct] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsStepRequestFindProduct trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsStepRequestFindProduct _GsStepRequestFindProduct)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsStepRequestFindProduct] WHERE Id=@Id",
					"@Id", _GsStepRequestFindProduct.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsStepRequestFindProduct trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsStepRequestFindProduct] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsStepRequestFindProduct trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsStepRequestFindProduct> _GsStepRequestFindProducts)
		{
			foreach (GsStepRequestFindProduct item in _GsStepRequestFindProducts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
