using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSunit:IGSunit
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSunit(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsUnit từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsUnit]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsUnit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsUnit] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsUnit từ Database
		/// </summary>
		public List<GsUnit> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsUnit]");
				List<GsUnit> items = new List<GsUnit>();
				GsUnit item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsUnit();
					if (dr["ID"] != null && dr["ID"] != DBNull.Value)
					{
						item.ID = Convert.ToString(dr["ID"]);
					}
					if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
					{
						item.UnitName = Convert.ToString(dr["UnitName"]);
					}
					if (dr["IsWeight"] != null && dr["IsWeight"] != DBNull.Value)
					{
						item.IsWeight = Convert.ToBoolean(dr["IsWeight"]);
					}
					if (dr["KgWeightRate"] != null && dr["KgWeightRate"] != DBNull.Value)
					{
						item.KgWeightRate = Convert.ToDecimal(dr["KgWeightRate"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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
		/// Lấy danh sách GsUnit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsUnit> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsUnit] A "+ condition,  parameters);
				List<GsUnit> items = new List<GsUnit>();
				GsUnit item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsUnit();
					if (dr["ID"] != null && dr["ID"] != DBNull.Value)
					{
						item.ID = Convert.ToString(dr["ID"]);
					}
					if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
					{
						item.UnitName = Convert.ToString(dr["UnitName"]);
					}
					if (dr["IsWeight"] != null && dr["IsWeight"] != DBNull.Value)
					{
						item.IsWeight = Convert.ToBoolean(dr["IsWeight"]);
					}
					if (dr["KgWeightRate"] != null && dr["KgWeightRate"] != DBNull.Value)
					{
						item.KgWeightRate = Convert.ToDecimal(dr["KgWeightRate"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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

		public List<GsUnit> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsUnit] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsUnit] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsUnit>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsUnit từ Database
		/// </summary>
		public GsUnit GetObject(string schema, String ID)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsUnit] where ID=@ID",
					"@ID", ID);
				if (ds.Rows.Count > 0)
				{
					GsUnit item=new GsUnit();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ID"] != null && dr["ID"] != DBNull.Value)
						{
							item.ID = Convert.ToString(dr["ID"]);
						}
						if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
						{
							item.UnitName = Convert.ToString(dr["UnitName"]);
						}
						if (dr["IsWeight"] != null && dr["IsWeight"] != DBNull.Value)
						{
							item.IsWeight = Convert.ToBoolean(dr["IsWeight"]);
						}
						if (dr["KgWeightRate"] != null && dr["KgWeightRate"] != DBNull.Value)
						{
							item.KgWeightRate = Convert.ToDecimal(dr["KgWeightRate"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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
		/// Lấy một GsUnit đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsUnit GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsUnit] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsUnit item=new GsUnit();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ID"] != null && dr["ID"] != DBNull.Value)
						{
							item.ID = Convert.ToString(dr["ID"]);
						}
						if (dr["UnitName"] != null && dr["UnitName"] != DBNull.Value)
						{
							item.UnitName = Convert.ToString(dr["UnitName"]);
						}
						if (dr["IsWeight"] != null && dr["IsWeight"] != DBNull.Value)
						{
							item.IsWeight = Convert.ToBoolean(dr["IsWeight"]);
						}
						if (dr["KgWeightRate"] != null && dr["KgWeightRate"] != DBNull.Value)
						{
							item.KgWeightRate = Convert.ToDecimal(dr["KgWeightRate"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
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

		public GsUnit GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsUnit] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsUnit>(ds);
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
		/// Thêm mới GsUnit vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsUnit _GsUnit)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsUnit](ID, UnitName, IsWeight, KgWeightRate, IsDelete) VALUES(@ID, @UnitName, @IsWeight, @KgWeightRate, @IsDelete)", 
					"@ID",  _GsUnit.ID, 
					"@UnitName",  _GsUnit.UnitName, 
					"@IsWeight",  _GsUnit.IsWeight, 
					"@KgWeightRate",  _GsUnit.KgWeightRate, 
					"@IsDelete",  _GsUnit.IsDelete);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsUnit vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsUnit> _GsUnits)
		{
			foreach (GsUnit item in _GsUnits)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsUnit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsUnit _GsUnit, String ID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsUnit] SET ID=@ID, UnitName=@UnitName, IsWeight=@IsWeight, KgWeightRate=@KgWeightRate, IsDelete=@IsDelete WHERE ID=@ID", 
					"@ID",  _GsUnit.ID, 
					"@UnitName",  _GsUnit.UnitName, 
					"@IsWeight",  _GsUnit.IsWeight, 
					"@KgWeightRate",  _GsUnit.KgWeightRate, 
					"@IsDelete",  _GsUnit.IsDelete, 
					"@ID", ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsUnit vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsUnit _GsUnit)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsUnit] SET UnitName=@UnitName, IsWeight=@IsWeight, KgWeightRate=@KgWeightRate, IsDelete=@IsDelete WHERE ID=@ID", 
					"@UnitName",  _GsUnit.UnitName, 
					"@IsWeight",  _GsUnit.IsWeight, 
					"@KgWeightRate",  _GsUnit.KgWeightRate, 
					"@IsDelete",  _GsUnit.IsDelete, 
					"@ID", _GsUnit.ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsUnit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsUnit> _GsUnits)
		{
			foreach (GsUnit item in _GsUnits)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsUnit vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsUnit _GsUnit, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsUnit] SET ID=@ID, UnitName=@UnitName, IsWeight=@IsWeight, KgWeightRate=@KgWeightRate, IsDelete=@IsDelete "+ condition, 
					"@ID",  _GsUnit.ID, 
					"@UnitName",  _GsUnit.UnitName, 
					"@IsWeight",  _GsUnit.IsWeight, 
					"@KgWeightRate",  _GsUnit.KgWeightRate, 
					"@IsDelete",  _GsUnit.IsDelete);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsUnit trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String ID)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsUnit] WHERE ID=@ID",
					"@ID", ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsUnit trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsUnit _GsUnit)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsUnit] WHERE ID=@ID",
					"@ID", _GsUnit.ID);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsUnit trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsUnit] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsUnit trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsUnit> _GsUnits)
		{
			foreach (GsUnit item in _GsUnits)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
