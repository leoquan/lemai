using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpconsigntransit:IEXpconsigntransit
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpconsigntransit(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpConsignTransit từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignTransit]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpConsignTransit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignTransit] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpConsignTransit từ Database
		/// </summary>
		public List<ExpConsignTransit> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignTransit]");
				List<ExpConsignTransit> items = new List<ExpConsignTransit>();
				ExpConsignTransit item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignTransit();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["FK_ExpPostFrom"] != null && dr["FK_ExpPostFrom"] != DBNull.Value)
					{
						item.FK_ExpPostFrom = Convert.ToString(dr["FK_ExpPostFrom"]);
					}
					if (dr["FK_ExpPostTo"] != null && dr["FK_ExpPostTo"] != DBNull.Value)
					{
						item.FK_ExpPostTo = Convert.ToString(dr["FK_ExpPostTo"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
					}
					if (dr["ImportBy"] != null && dr["ImportBy"] != DBNull.Value)
					{
						item.ImportBy = Convert.ToString(dr["ImportBy"]);
					}
					if (dr["ImportDate"] != null && dr["ImportDate"] != DBNull.Value)
					{
						item.ImportDate = Convert.ToDateTime(dr["ImportDate"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
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
		/// Lấy danh sách ExpConsignTransit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpConsignTransit> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignTransit] A "+ condition,  parameters);
				List<ExpConsignTransit> items = new List<ExpConsignTransit>();
				ExpConsignTransit item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignTransit();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["FK_ExpPostFrom"] != null && dr["FK_ExpPostFrom"] != DBNull.Value)
					{
						item.FK_ExpPostFrom = Convert.ToString(dr["FK_ExpPostFrom"]);
					}
					if (dr["FK_ExpPostTo"] != null && dr["FK_ExpPostTo"] != DBNull.Value)
					{
						item.FK_ExpPostTo = Convert.ToString(dr["FK_ExpPostTo"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
					}
					if (dr["ImportBy"] != null && dr["ImportBy"] != DBNull.Value)
					{
						item.ImportBy = Convert.ToString(dr["ImportBy"]);
					}
					if (dr["ImportDate"] != null && dr["ImportDate"] != DBNull.Value)
					{
						item.ImportDate = Convert.ToDateTime(dr["ImportDate"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToString(dr["Type"]);
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

		public List<ExpConsignTransit> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignTransit] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpConsignTransit] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpConsignTransit>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpConsignTransit từ Database
		/// </summary>
		public ExpConsignTransit GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignTransit] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpConsignTransit item=new ExpConsignTransit();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
						{
							item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
						}
						if (dr["FK_ExpPostFrom"] != null && dr["FK_ExpPostFrom"] != DBNull.Value)
						{
							item.FK_ExpPostFrom = Convert.ToString(dr["FK_ExpPostFrom"]);
						}
						if (dr["FK_ExpPostTo"] != null && dr["FK_ExpPostTo"] != DBNull.Value)
						{
							item.FK_ExpPostTo = Convert.ToString(dr["FK_ExpPostTo"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
						{
							item.IsDone = Convert.ToBoolean(dr["IsDone"]);
						}
						if (dr["ImportBy"] != null && dr["ImportBy"] != DBNull.Value)
						{
							item.ImportBy = Convert.ToString(dr["ImportBy"]);
						}
						if (dr["ImportDate"] != null && dr["ImportDate"] != DBNull.Value)
						{
							item.ImportDate = Convert.ToDateTime(dr["ImportDate"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
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
		/// Lấy một ExpConsignTransit đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpConsignTransit GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignTransit] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpConsignTransit item=new ExpConsignTransit();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
						{
							item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
						}
						if (dr["FK_ExpPostFrom"] != null && dr["FK_ExpPostFrom"] != DBNull.Value)
						{
							item.FK_ExpPostFrom = Convert.ToString(dr["FK_ExpPostFrom"]);
						}
						if (dr["FK_ExpPostTo"] != null && dr["FK_ExpPostTo"] != DBNull.Value)
						{
							item.FK_ExpPostTo = Convert.ToString(dr["FK_ExpPostTo"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
						{
							item.IsDone = Convert.ToBoolean(dr["IsDone"]);
						}
						if (dr["ImportBy"] != null && dr["ImportBy"] != DBNull.Value)
						{
							item.ImportBy = Convert.ToString(dr["ImportBy"]);
						}
						if (dr["ImportDate"] != null && dr["ImportDate"] != DBNull.Value)
						{
							item.ImportDate = Convert.ToDateTime(dr["ImportDate"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToString(dr["Type"]);
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

		public ExpConsignTransit GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignTransit] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpConsignTransit>(ds);
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
		/// Thêm mới ExpConsignTransit vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpConsignTransit _ExpConsignTransit)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpConsignTransit](Id, FK_ExpConsignment, FK_ExpPostFrom, FK_ExpPostTo, CreateBy, CreateDate, Note, IsDone, ImportBy, ImportDate, Type) VALUES(@Id, @FK_ExpConsignment, @FK_ExpPostFrom, @FK_ExpPostTo, @CreateBy, @CreateDate, @Note, @IsDone, @ImportBy, @ImportDate, @Type)", 
					"@Id",  _ExpConsignTransit.Id, 
					"@FK_ExpConsignment",  _ExpConsignTransit.FK_ExpConsignment, 
					"@FK_ExpPostFrom",  _ExpConsignTransit.FK_ExpPostFrom, 
					"@FK_ExpPostTo",  _ExpConsignTransit.FK_ExpPostTo, 
					"@CreateBy",  _ExpConsignTransit.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignTransit.CreateDate), 
					"@Note",  _ExpConsignTransit.Note, 
					"@IsDone",  _ExpConsignTransit.IsDone, 
					"@ImportBy",  _ExpConsignTransit.ImportBy, 
					"@ImportDate", this._dataContext.ConvertDateString( _ExpConsignTransit.ImportDate), 
					"@Type",  _ExpConsignTransit.Type);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpConsignTransit vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpConsignTransit> _ExpConsignTransits)
		{
			foreach (ExpConsignTransit item in _ExpConsignTransits)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignTransit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpConsignTransit _ExpConsignTransit, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignTransit] SET Id=@Id, FK_ExpConsignment=@FK_ExpConsignment, FK_ExpPostFrom=@FK_ExpPostFrom, FK_ExpPostTo=@FK_ExpPostTo, CreateBy=@CreateBy, CreateDate=@CreateDate, Note=@Note, IsDone=@IsDone, ImportBy=@ImportBy, ImportDate=@ImportDate, Type=@Type WHERE Id=@Id", 
					"@Id",  _ExpConsignTransit.Id, 
					"@FK_ExpConsignment",  _ExpConsignTransit.FK_ExpConsignment, 
					"@FK_ExpPostFrom",  _ExpConsignTransit.FK_ExpPostFrom, 
					"@FK_ExpPostTo",  _ExpConsignTransit.FK_ExpPostTo, 
					"@CreateBy",  _ExpConsignTransit.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignTransit.CreateDate), 
					"@Note",  _ExpConsignTransit.Note, 
					"@IsDone",  _ExpConsignTransit.IsDone, 
					"@ImportBy",  _ExpConsignTransit.ImportBy, 
					"@ImportDate", this._dataContext.ConvertDateString( _ExpConsignTransit.ImportDate), 
					"@Type",  _ExpConsignTransit.Type, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignTransit vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpConsignTransit _ExpConsignTransit)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignTransit] SET FK_ExpConsignment=@FK_ExpConsignment, FK_ExpPostFrom=@FK_ExpPostFrom, FK_ExpPostTo=@FK_ExpPostTo, CreateBy=@CreateBy, CreateDate=@CreateDate, Note=@Note, IsDone=@IsDone, ImportBy=@ImportBy, ImportDate=@ImportDate, Type=@Type WHERE Id=@Id", 
					"@FK_ExpConsignment",  _ExpConsignTransit.FK_ExpConsignment, 
					"@FK_ExpPostFrom",  _ExpConsignTransit.FK_ExpPostFrom, 
					"@FK_ExpPostTo",  _ExpConsignTransit.FK_ExpPostTo, 
					"@CreateBy",  _ExpConsignTransit.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignTransit.CreateDate), 
					"@Note",  _ExpConsignTransit.Note, 
					"@IsDone",  _ExpConsignTransit.IsDone, 
					"@ImportBy",  _ExpConsignTransit.ImportBy, 
					"@ImportDate", this._dataContext.ConvertDateString( _ExpConsignTransit.ImportDate), 
					"@Type",  _ExpConsignTransit.Type, 
					"@Id", _ExpConsignTransit.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpConsignTransit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpConsignTransit> _ExpConsignTransits)
		{
			foreach (ExpConsignTransit item in _ExpConsignTransits)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignTransit vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpConsignTransit _ExpConsignTransit, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignTransit] SET Id=@Id, FK_ExpConsignment=@FK_ExpConsignment, FK_ExpPostFrom=@FK_ExpPostFrom, FK_ExpPostTo=@FK_ExpPostTo, CreateBy=@CreateBy, CreateDate=@CreateDate, Note=@Note, IsDone=@IsDone, ImportBy=@ImportBy, ImportDate=@ImportDate, Type=@Type "+ condition, 
					"@Id",  _ExpConsignTransit.Id, 
					"@FK_ExpConsignment",  _ExpConsignTransit.FK_ExpConsignment, 
					"@FK_ExpPostFrom",  _ExpConsignTransit.FK_ExpPostFrom, 
					"@FK_ExpPostTo",  _ExpConsignTransit.FK_ExpPostTo, 
					"@CreateBy",  _ExpConsignTransit.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignTransit.CreateDate), 
					"@Note",  _ExpConsignTransit.Note, 
					"@IsDone",  _ExpConsignTransit.IsDone, 
					"@ImportBy",  _ExpConsignTransit.ImportBy, 
					"@ImportDate", this._dataContext.ConvertDateString( _ExpConsignTransit.ImportDate), 
					"@Type",  _ExpConsignTransit.Type);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpConsignTransit trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignTransit] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignTransit trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpConsignTransit _ExpConsignTransit)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignTransit] WHERE Id=@Id",
					"@Id", _ExpConsignTransit.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignTransit trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignTransit] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignTransit trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpConsignTransit> _ExpConsignTransits)
		{
			foreach (ExpConsignTransit item in _ExpConsignTransits)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
