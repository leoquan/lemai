using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSChoolhocphan:ISChoolhocphan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSChoolhocphan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SchoolHocPhan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolHocPhan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SchoolHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolHocPhan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SchoolHocPhan từ Database
		/// </summary>
		public List<SchoolHocPhan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolHocPhan]");
				List<SchoolHocPhan> items = new List<SchoolHocPhan>();
				SchoolHocPhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolHocPhan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["HocPhan"] != null && dr["HocPhan"] != DBNull.Value)
					{
						item.HocPhan = Convert.ToString(dr["HocPhan"]);
					}
					if (dr["MinAge"] != null && dr["MinAge"] != DBNull.Value)
					{
						item.MinAge = Convert.ToInt32(dr["MinAge"]);
					}
					if (dr["MaxAge"] != null && dr["MaxAge"] != DBNull.Value)
					{
						item.MaxAge = Convert.ToInt32(dr["MaxAge"]);
					}
					if (dr["NumberMonth"] != null && dr["NumberMonth"] != DBNull.Value)
					{
						item.NumberMonth = Convert.ToDecimal(dr["NumberMonth"]);
					}
					if (dr["SoTiet"] != null && dr["SoTiet"] != DBNull.Value)
					{
						item.SoTiet = Convert.ToInt32(dr["SoTiet"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_SchoolProgram"] != null && dr["FK_SchoolProgram"] != DBNull.Value)
					{
						item.FK_SchoolProgram = Convert.ToString(dr["FK_SchoolProgram"]);
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
		/// Lấy danh sách SchoolHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SchoolHocPhan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolHocPhan] A "+ condition,  parameters);
				List<SchoolHocPhan> items = new List<SchoolHocPhan>();
				SchoolHocPhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolHocPhan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["HocPhan"] != null && dr["HocPhan"] != DBNull.Value)
					{
						item.HocPhan = Convert.ToString(dr["HocPhan"]);
					}
					if (dr["MinAge"] != null && dr["MinAge"] != DBNull.Value)
					{
						item.MinAge = Convert.ToInt32(dr["MinAge"]);
					}
					if (dr["MaxAge"] != null && dr["MaxAge"] != DBNull.Value)
					{
						item.MaxAge = Convert.ToInt32(dr["MaxAge"]);
					}
					if (dr["NumberMonth"] != null && dr["NumberMonth"] != DBNull.Value)
					{
						item.NumberMonth = Convert.ToDecimal(dr["NumberMonth"]);
					}
					if (dr["SoTiet"] != null && dr["SoTiet"] != DBNull.Value)
					{
						item.SoTiet = Convert.ToInt32(dr["SoTiet"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_SchoolProgram"] != null && dr["FK_SchoolProgram"] != DBNull.Value)
					{
						item.FK_SchoolProgram = Convert.ToString(dr["FK_SchoolProgram"]);
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

		public List<SchoolHocPhan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolHocPhan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SchoolHocPhan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SchoolHocPhan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SchoolHocPhan từ Database
		/// </summary>
		public SchoolHocPhan GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolHocPhan] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SchoolHocPhan item=new SchoolHocPhan();
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
						if (dr["HocPhan"] != null && dr["HocPhan"] != DBNull.Value)
						{
							item.HocPhan = Convert.ToString(dr["HocPhan"]);
						}
						if (dr["MinAge"] != null && dr["MinAge"] != DBNull.Value)
						{
							item.MinAge = Convert.ToInt32(dr["MinAge"]);
						}
						if (dr["MaxAge"] != null && dr["MaxAge"] != DBNull.Value)
						{
							item.MaxAge = Convert.ToInt32(dr["MaxAge"]);
						}
						if (dr["NumberMonth"] != null && dr["NumberMonth"] != DBNull.Value)
						{
							item.NumberMonth = Convert.ToDecimal(dr["NumberMonth"]);
						}
						if (dr["SoTiet"] != null && dr["SoTiet"] != DBNull.Value)
						{
							item.SoTiet = Convert.ToInt32(dr["SoTiet"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_SchoolProgram"] != null && dr["FK_SchoolProgram"] != DBNull.Value)
						{
							item.FK_SchoolProgram = Convert.ToString(dr["FK_SchoolProgram"]);
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
		/// Lấy một SchoolHocPhan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SchoolHocPhan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolHocPhan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SchoolHocPhan item=new SchoolHocPhan();
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
						if (dr["HocPhan"] != null && dr["HocPhan"] != DBNull.Value)
						{
							item.HocPhan = Convert.ToString(dr["HocPhan"]);
						}
						if (dr["MinAge"] != null && dr["MinAge"] != DBNull.Value)
						{
							item.MinAge = Convert.ToInt32(dr["MinAge"]);
						}
						if (dr["MaxAge"] != null && dr["MaxAge"] != DBNull.Value)
						{
							item.MaxAge = Convert.ToInt32(dr["MaxAge"]);
						}
						if (dr["NumberMonth"] != null && dr["NumberMonth"] != DBNull.Value)
						{
							item.NumberMonth = Convert.ToDecimal(dr["NumberMonth"]);
						}
						if (dr["SoTiet"] != null && dr["SoTiet"] != DBNull.Value)
						{
							item.SoTiet = Convert.ToInt32(dr["SoTiet"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_SchoolProgram"] != null && dr["FK_SchoolProgram"] != DBNull.Value)
						{
							item.FK_SchoolProgram = Convert.ToString(dr["FK_SchoolProgram"]);
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

		public SchoolHocPhan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolHocPhan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SchoolHocPhan>(ds);
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
		/// Thêm mới SchoolHocPhan vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SchoolHocPhan _SchoolHocPhan)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SchoolHocPhan](Id, Code, HocPhan, MinAge, MaxAge, NumberMonth, SoTiet, OrderNumber, CreateBy, CreateDate, FK_SchoolProgram) VALUES(@Id, @Code, @HocPhan, @MinAge, @MaxAge, @NumberMonth, @SoTiet, @OrderNumber, @CreateBy, @CreateDate, @FK_SchoolProgram)", 
					"@Id",  _SchoolHocPhan.Id, 
					"@Code",  _SchoolHocPhan.Code, 
					"@HocPhan",  _SchoolHocPhan.HocPhan, 
					"@MinAge",  _SchoolHocPhan.MinAge, 
					"@MaxAge",  _SchoolHocPhan.MaxAge, 
					"@NumberMonth",  _SchoolHocPhan.NumberMonth, 
					"@SoTiet",  _SchoolHocPhan.SoTiet, 
					"@OrderNumber",  _SchoolHocPhan.OrderNumber, 
					"@CreateBy",  _SchoolHocPhan.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolHocPhan.CreateDate), 
					"@FK_SchoolProgram",  _SchoolHocPhan.FK_SchoolProgram);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SchoolHocPhan vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SchoolHocPhan> _SchoolHocPhans)
		{
			foreach (SchoolHocPhan item in _SchoolHocPhans)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolHocPhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SchoolHocPhan _SchoolHocPhan, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolHocPhan] SET Id=@Id, Code=@Code, HocPhan=@HocPhan, MinAge=@MinAge, MaxAge=@MaxAge, NumberMonth=@NumberMonth, SoTiet=@SoTiet, OrderNumber=@OrderNumber, CreateBy=@CreateBy, CreateDate=@CreateDate, FK_SchoolProgram=@FK_SchoolProgram WHERE Id=@Id", 
					"@Id",  _SchoolHocPhan.Id, 
					"@Code",  _SchoolHocPhan.Code, 
					"@HocPhan",  _SchoolHocPhan.HocPhan, 
					"@MinAge",  _SchoolHocPhan.MinAge, 
					"@MaxAge",  _SchoolHocPhan.MaxAge, 
					"@NumberMonth",  _SchoolHocPhan.NumberMonth, 
					"@SoTiet",  _SchoolHocPhan.SoTiet, 
					"@OrderNumber",  _SchoolHocPhan.OrderNumber, 
					"@CreateBy",  _SchoolHocPhan.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolHocPhan.CreateDate), 
					"@FK_SchoolProgram",  _SchoolHocPhan.FK_SchoolProgram, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SchoolHocPhan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SchoolHocPhan _SchoolHocPhan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolHocPhan] SET Code=@Code, HocPhan=@HocPhan, MinAge=@MinAge, MaxAge=@MaxAge, NumberMonth=@NumberMonth, SoTiet=@SoTiet, OrderNumber=@OrderNumber, CreateBy=@CreateBy, CreateDate=@CreateDate, FK_SchoolProgram=@FK_SchoolProgram WHERE Id=@Id", 
					"@Code",  _SchoolHocPhan.Code, 
					"@HocPhan",  _SchoolHocPhan.HocPhan, 
					"@MinAge",  _SchoolHocPhan.MinAge, 
					"@MaxAge",  _SchoolHocPhan.MaxAge, 
					"@NumberMonth",  _SchoolHocPhan.NumberMonth, 
					"@SoTiet",  _SchoolHocPhan.SoTiet, 
					"@OrderNumber",  _SchoolHocPhan.OrderNumber, 
					"@CreateBy",  _SchoolHocPhan.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolHocPhan.CreateDate), 
					"@FK_SchoolProgram",  _SchoolHocPhan.FK_SchoolProgram, 
					"@Id", _SchoolHocPhan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SchoolHocPhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SchoolHocPhan> _SchoolHocPhans)
		{
			foreach (SchoolHocPhan item in _SchoolHocPhans)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolHocPhan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SchoolHocPhan _SchoolHocPhan, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolHocPhan] SET Id=@Id, Code=@Code, HocPhan=@HocPhan, MinAge=@MinAge, MaxAge=@MaxAge, NumberMonth=@NumberMonth, SoTiet=@SoTiet, OrderNumber=@OrderNumber, CreateBy=@CreateBy, CreateDate=@CreateDate, FK_SchoolProgram=@FK_SchoolProgram "+ condition, 
					"@Id",  _SchoolHocPhan.Id, 
					"@Code",  _SchoolHocPhan.Code, 
					"@HocPhan",  _SchoolHocPhan.HocPhan, 
					"@MinAge",  _SchoolHocPhan.MinAge, 
					"@MaxAge",  _SchoolHocPhan.MaxAge, 
					"@NumberMonth",  _SchoolHocPhan.NumberMonth, 
					"@SoTiet",  _SchoolHocPhan.SoTiet, 
					"@OrderNumber",  _SchoolHocPhan.OrderNumber, 
					"@CreateBy",  _SchoolHocPhan.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolHocPhan.CreateDate), 
					"@FK_SchoolProgram",  _SchoolHocPhan.FK_SchoolProgram);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SchoolHocPhan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolHocPhan] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolHocPhan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SchoolHocPhan _SchoolHocPhan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolHocPhan] WHERE Id=@Id",
					"@Id", _SchoolHocPhan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolHocPhan trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolHocPhan] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolHocPhan trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SchoolHocPhan> _SchoolHocPhans)
		{
			foreach (SchoolHocPhan item in _SchoolHocPhans)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
