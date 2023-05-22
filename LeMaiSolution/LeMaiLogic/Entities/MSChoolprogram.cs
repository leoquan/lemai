using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSChoolprogram:ISChoolprogram
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSChoolprogram(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SchoolProgram từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolProgram]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SchoolProgram từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolProgram] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SchoolProgram từ Database
		/// </summary>
		public List<SchoolProgram> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolProgram]");
				List<SchoolProgram> items = new List<SchoolProgram>();
				SchoolProgram item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolProgram();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["ProgramName"] != null && dr["ProgramName"] != DBNull.Value)
					{
						item.ProgramName = Convert.ToString(dr["ProgramName"]);
					}
					if (dr["ClassName"] != null && dr["ClassName"] != DBNull.Value)
					{
						item.ClassName = Convert.ToString(dr["ClassName"]);
					}
					if (dr["CambridgeStandar"] != null && dr["CambridgeStandar"] != DBNull.Value)
					{
						item.CambridgeStandar = Convert.ToString(dr["CambridgeStandar"]);
					}
					if (dr["CEFRStandar"] != null && dr["CEFRStandar"] != DBNull.Value)
					{
						item.CEFRStandar = Convert.ToString(dr["CEFRStandar"]);
					}
					if (dr["NumberPart"] != null && dr["NumberPart"] != DBNull.Value)
					{
						item.NumberPart = Convert.ToInt32(dr["NumberPart"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy danh sách SchoolProgram từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SchoolProgram> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolProgram] A "+ condition,  parameters);
				List<SchoolProgram> items = new List<SchoolProgram>();
				SchoolProgram item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolProgram();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["ProgramName"] != null && dr["ProgramName"] != DBNull.Value)
					{
						item.ProgramName = Convert.ToString(dr["ProgramName"]);
					}
					if (dr["ClassName"] != null && dr["ClassName"] != DBNull.Value)
					{
						item.ClassName = Convert.ToString(dr["ClassName"]);
					}
					if (dr["CambridgeStandar"] != null && dr["CambridgeStandar"] != DBNull.Value)
					{
						item.CambridgeStandar = Convert.ToString(dr["CambridgeStandar"]);
					}
					if (dr["CEFRStandar"] != null && dr["CEFRStandar"] != DBNull.Value)
					{
						item.CEFRStandar = Convert.ToString(dr["CEFRStandar"]);
					}
					if (dr["NumberPart"] != null && dr["NumberPart"] != DBNull.Value)
					{
						item.NumberPart = Convert.ToInt32(dr["NumberPart"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public List<SchoolProgram> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolProgram] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SchoolProgram] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SchoolProgram>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SchoolProgram từ Database
		/// </summary>
		public SchoolProgram GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolProgram] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SchoolProgram item=new SchoolProgram();
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
						if (dr["ProgramName"] != null && dr["ProgramName"] != DBNull.Value)
						{
							item.ProgramName = Convert.ToString(dr["ProgramName"]);
						}
						if (dr["ClassName"] != null && dr["ClassName"] != DBNull.Value)
						{
							item.ClassName = Convert.ToString(dr["ClassName"]);
						}
						if (dr["CambridgeStandar"] != null && dr["CambridgeStandar"] != DBNull.Value)
						{
							item.CambridgeStandar = Convert.ToString(dr["CambridgeStandar"]);
						}
						if (dr["CEFRStandar"] != null && dr["CEFRStandar"] != DBNull.Value)
						{
							item.CEFRStandar = Convert.ToString(dr["CEFRStandar"]);
						}
						if (dr["NumberPart"] != null && dr["NumberPart"] != DBNull.Value)
						{
							item.NumberPart = Convert.ToInt32(dr["NumberPart"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy một SchoolProgram đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SchoolProgram GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolProgram] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SchoolProgram item=new SchoolProgram();
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
						if (dr["ProgramName"] != null && dr["ProgramName"] != DBNull.Value)
						{
							item.ProgramName = Convert.ToString(dr["ProgramName"]);
						}
						if (dr["ClassName"] != null && dr["ClassName"] != DBNull.Value)
						{
							item.ClassName = Convert.ToString(dr["ClassName"]);
						}
						if (dr["CambridgeStandar"] != null && dr["CambridgeStandar"] != DBNull.Value)
						{
							item.CambridgeStandar = Convert.ToString(dr["CambridgeStandar"]);
						}
						if (dr["CEFRStandar"] != null && dr["CEFRStandar"] != DBNull.Value)
						{
							item.CEFRStandar = Convert.ToString(dr["CEFRStandar"]);
						}
						if (dr["NumberPart"] != null && dr["NumberPart"] != DBNull.Value)
						{
							item.NumberPart = Convert.ToInt32(dr["NumberPart"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public SchoolProgram GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolProgram] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SchoolProgram>(ds);
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
		/// Thêm mới SchoolProgram vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SchoolProgram _SchoolProgram)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SchoolProgram](Id, Code, ProgramName, ClassName, CambridgeStandar, CEFRStandar, NumberPart, CreateBy, CreateDate) VALUES(@Id, @Code, @ProgramName, @ClassName, @CambridgeStandar, @CEFRStandar, @NumberPart, @CreateBy, @CreateDate)", 
					"@Id",  _SchoolProgram.Id, 
					"@Code",  _SchoolProgram.Code, 
					"@ProgramName",  _SchoolProgram.ProgramName, 
					"@ClassName",  _SchoolProgram.ClassName, 
					"@CambridgeStandar",  _SchoolProgram.CambridgeStandar, 
					"@CEFRStandar",  _SchoolProgram.CEFRStandar, 
					"@NumberPart",  _SchoolProgram.NumberPart, 
					"@CreateBy",  _SchoolProgram.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolProgram.CreateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SchoolProgram vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SchoolProgram> _SchoolPrograms)
		{
			foreach (SchoolProgram item in _SchoolPrograms)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolProgram vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SchoolProgram _SchoolProgram, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolProgram] SET Id=@Id, Code=@Code, ProgramName=@ProgramName, ClassName=@ClassName, CambridgeStandar=@CambridgeStandar, CEFRStandar=@CEFRStandar, NumberPart=@NumberPart, CreateBy=@CreateBy, CreateDate=@CreateDate WHERE Id=@Id", 
					"@Id",  _SchoolProgram.Id, 
					"@Code",  _SchoolProgram.Code, 
					"@ProgramName",  _SchoolProgram.ProgramName, 
					"@ClassName",  _SchoolProgram.ClassName, 
					"@CambridgeStandar",  _SchoolProgram.CambridgeStandar, 
					"@CEFRStandar",  _SchoolProgram.CEFRStandar, 
					"@NumberPart",  _SchoolProgram.NumberPart, 
					"@CreateBy",  _SchoolProgram.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolProgram.CreateDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SchoolProgram vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SchoolProgram _SchoolProgram)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolProgram] SET Code=@Code, ProgramName=@ProgramName, ClassName=@ClassName, CambridgeStandar=@CambridgeStandar, CEFRStandar=@CEFRStandar, NumberPart=@NumberPart, CreateBy=@CreateBy, CreateDate=@CreateDate WHERE Id=@Id", 
					"@Code",  _SchoolProgram.Code, 
					"@ProgramName",  _SchoolProgram.ProgramName, 
					"@ClassName",  _SchoolProgram.ClassName, 
					"@CambridgeStandar",  _SchoolProgram.CambridgeStandar, 
					"@CEFRStandar",  _SchoolProgram.CEFRStandar, 
					"@NumberPart",  _SchoolProgram.NumberPart, 
					"@CreateBy",  _SchoolProgram.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolProgram.CreateDate), 
					"@Id", _SchoolProgram.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SchoolProgram vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SchoolProgram> _SchoolPrograms)
		{
			foreach (SchoolProgram item in _SchoolPrograms)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolProgram vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SchoolProgram _SchoolProgram, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolProgram] SET Id=@Id, Code=@Code, ProgramName=@ProgramName, ClassName=@ClassName, CambridgeStandar=@CambridgeStandar, CEFRStandar=@CEFRStandar, NumberPart=@NumberPart, CreateBy=@CreateBy, CreateDate=@CreateDate "+ condition, 
					"@Id",  _SchoolProgram.Id, 
					"@Code",  _SchoolProgram.Code, 
					"@ProgramName",  _SchoolProgram.ProgramName, 
					"@ClassName",  _SchoolProgram.ClassName, 
					"@CambridgeStandar",  _SchoolProgram.CambridgeStandar, 
					"@CEFRStandar",  _SchoolProgram.CEFRStandar, 
					"@NumberPart",  _SchoolProgram.NumberPart, 
					"@CreateBy",  _SchoolProgram.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolProgram.CreateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SchoolProgram trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolProgram] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolProgram trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SchoolProgram _SchoolProgram)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolProgram] WHERE Id=@Id",
					"@Id", _SchoolProgram.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolProgram trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolProgram] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolProgram trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SchoolProgram> _SchoolPrograms)
		{
			foreach (SchoolProgram item in _SchoolPrograms)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
