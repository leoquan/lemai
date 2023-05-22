using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSChoolgiaotrinhhocphan:ISChoolgiaotrinhhocphan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSChoolgiaotrinhhocphan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SchoolGiaoTrinhHocPhan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolGiaoTrinhHocPhan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SchoolGiaoTrinhHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolGiaoTrinhHocPhan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SchoolGiaoTrinhHocPhan từ Database
		/// </summary>
		public List<SchoolGiaoTrinhHocPhan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolGiaoTrinhHocPhan]");
				List<SchoolGiaoTrinhHocPhan> items = new List<SchoolGiaoTrinhHocPhan>();
				SchoolGiaoTrinhHocPhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolGiaoTrinhHocPhan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_GiaoTrinh"] != null && dr["FK_GiaoTrinh"] != DBNull.Value)
					{
						item.FK_GiaoTrinh = Convert.ToString(dr["FK_GiaoTrinh"]);
					}
					if (dr["BaiHoc"] != null && dr["BaiHoc"] != DBNull.Value)
					{
						item.BaiHoc = Convert.ToString(dr["BaiHoc"]);
					}
					if (dr["Structure"] != null && dr["Structure"] != DBNull.Value)
					{
						item.Structure = Convert.ToString(dr["Structure"]);
					}
					if (dr["Vocabulary"] != null && dr["Vocabulary"] != DBNull.Value)
					{
						item.Vocabulary = Convert.ToString(dr["Vocabulary"]);
					}
					if (dr["Activities"] != null && dr["Activities"] != DBNull.Value)
					{
						item.Activities = Convert.ToString(dr["Activities"]);
					}
					if (dr["Objectives"] != null && dr["Objectives"] != DBNull.Value)
					{
						item.Objectives = Convert.ToString(dr["Objectives"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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
		/// Lấy danh sách SchoolGiaoTrinhHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SchoolGiaoTrinhHocPhan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolGiaoTrinhHocPhan] A "+ condition,  parameters);
				List<SchoolGiaoTrinhHocPhan> items = new List<SchoolGiaoTrinhHocPhan>();
				SchoolGiaoTrinhHocPhan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolGiaoTrinhHocPhan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_GiaoTrinh"] != null && dr["FK_GiaoTrinh"] != DBNull.Value)
					{
						item.FK_GiaoTrinh = Convert.ToString(dr["FK_GiaoTrinh"]);
					}
					if (dr["BaiHoc"] != null && dr["BaiHoc"] != DBNull.Value)
					{
						item.BaiHoc = Convert.ToString(dr["BaiHoc"]);
					}
					if (dr["Structure"] != null && dr["Structure"] != DBNull.Value)
					{
						item.Structure = Convert.ToString(dr["Structure"]);
					}
					if (dr["Vocabulary"] != null && dr["Vocabulary"] != DBNull.Value)
					{
						item.Vocabulary = Convert.ToString(dr["Vocabulary"]);
					}
					if (dr["Activities"] != null && dr["Activities"] != DBNull.Value)
					{
						item.Activities = Convert.ToString(dr["Activities"]);
					}
					if (dr["Objectives"] != null && dr["Objectives"] != DBNull.Value)
					{
						item.Objectives = Convert.ToString(dr["Objectives"]);
					}
					if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
					{
						item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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

		public List<SchoolGiaoTrinhHocPhan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolGiaoTrinhHocPhan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SchoolGiaoTrinhHocPhan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SchoolGiaoTrinhHocPhan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SchoolGiaoTrinhHocPhan từ Database
		/// </summary>
		public SchoolGiaoTrinhHocPhan GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolGiaoTrinhHocPhan] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SchoolGiaoTrinhHocPhan item=new SchoolGiaoTrinhHocPhan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_GiaoTrinh"] != null && dr["FK_GiaoTrinh"] != DBNull.Value)
						{
							item.FK_GiaoTrinh = Convert.ToString(dr["FK_GiaoTrinh"]);
						}
						if (dr["BaiHoc"] != null && dr["BaiHoc"] != DBNull.Value)
						{
							item.BaiHoc = Convert.ToString(dr["BaiHoc"]);
						}
						if (dr["Structure"] != null && dr["Structure"] != DBNull.Value)
						{
							item.Structure = Convert.ToString(dr["Structure"]);
						}
						if (dr["Vocabulary"] != null && dr["Vocabulary"] != DBNull.Value)
						{
							item.Vocabulary = Convert.ToString(dr["Vocabulary"]);
						}
						if (dr["Activities"] != null && dr["Activities"] != DBNull.Value)
						{
							item.Activities = Convert.ToString(dr["Activities"]);
						}
						if (dr["Objectives"] != null && dr["Objectives"] != DBNull.Value)
						{
							item.Objectives = Convert.ToString(dr["Objectives"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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
		/// Lấy một SchoolGiaoTrinhHocPhan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SchoolGiaoTrinhHocPhan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolGiaoTrinhHocPhan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SchoolGiaoTrinhHocPhan item=new SchoolGiaoTrinhHocPhan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_GiaoTrinh"] != null && dr["FK_GiaoTrinh"] != DBNull.Value)
						{
							item.FK_GiaoTrinh = Convert.ToString(dr["FK_GiaoTrinh"]);
						}
						if (dr["BaiHoc"] != null && dr["BaiHoc"] != DBNull.Value)
						{
							item.BaiHoc = Convert.ToString(dr["BaiHoc"]);
						}
						if (dr["Structure"] != null && dr["Structure"] != DBNull.Value)
						{
							item.Structure = Convert.ToString(dr["Structure"]);
						}
						if (dr["Vocabulary"] != null && dr["Vocabulary"] != DBNull.Value)
						{
							item.Vocabulary = Convert.ToString(dr["Vocabulary"]);
						}
						if (dr["Activities"] != null && dr["Activities"] != DBNull.Value)
						{
							item.Activities = Convert.ToString(dr["Activities"]);
						}
						if (dr["Objectives"] != null && dr["Objectives"] != DBNull.Value)
						{
							item.Objectives = Convert.ToString(dr["Objectives"]);
						}
						if (dr["OrderNumber"] != null && dr["OrderNumber"] != DBNull.Value)
						{
							item.OrderNumber = Convert.ToInt32(dr["OrderNumber"]);
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

		public SchoolGiaoTrinhHocPhan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolGiaoTrinhHocPhan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SchoolGiaoTrinhHocPhan>(ds);
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
		/// Thêm mới SchoolGiaoTrinhHocPhan vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SchoolGiaoTrinhHocPhan _SchoolGiaoTrinhHocPhan)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SchoolGiaoTrinhHocPhan](Id, FK_GiaoTrinh, BaiHoc, Structure, Vocabulary, Activities, Objectives, OrderNumber) VALUES(@Id, @FK_GiaoTrinh, @BaiHoc, @Structure, @Vocabulary, @Activities, @Objectives, @OrderNumber)", 
					"@Id",  _SchoolGiaoTrinhHocPhan.Id, 
					"@FK_GiaoTrinh",  _SchoolGiaoTrinhHocPhan.FK_GiaoTrinh, 
					"@BaiHoc",  _SchoolGiaoTrinhHocPhan.BaiHoc, 
					"@Structure",  _SchoolGiaoTrinhHocPhan.Structure, 
					"@Vocabulary",  _SchoolGiaoTrinhHocPhan.Vocabulary, 
					"@Activities",  _SchoolGiaoTrinhHocPhan.Activities, 
					"@Objectives",  _SchoolGiaoTrinhHocPhan.Objectives, 
					"@OrderNumber",  _SchoolGiaoTrinhHocPhan.OrderNumber);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SchoolGiaoTrinhHocPhan vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SchoolGiaoTrinhHocPhan> _SchoolGiaoTrinhHocPhans)
		{
			foreach (SchoolGiaoTrinhHocPhan item in _SchoolGiaoTrinhHocPhans)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolGiaoTrinhHocPhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SchoolGiaoTrinhHocPhan _SchoolGiaoTrinhHocPhan, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolGiaoTrinhHocPhan] SET Id=@Id, FK_GiaoTrinh=@FK_GiaoTrinh, BaiHoc=@BaiHoc, Structure=@Structure, Vocabulary=@Vocabulary, Activities=@Activities, Objectives=@Objectives, OrderNumber=@OrderNumber WHERE Id=@Id", 
					"@Id",  _SchoolGiaoTrinhHocPhan.Id, 
					"@FK_GiaoTrinh",  _SchoolGiaoTrinhHocPhan.FK_GiaoTrinh, 
					"@BaiHoc",  _SchoolGiaoTrinhHocPhan.BaiHoc, 
					"@Structure",  _SchoolGiaoTrinhHocPhan.Structure, 
					"@Vocabulary",  _SchoolGiaoTrinhHocPhan.Vocabulary, 
					"@Activities",  _SchoolGiaoTrinhHocPhan.Activities, 
					"@Objectives",  _SchoolGiaoTrinhHocPhan.Objectives, 
					"@OrderNumber",  _SchoolGiaoTrinhHocPhan.OrderNumber, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SchoolGiaoTrinhHocPhan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SchoolGiaoTrinhHocPhan _SchoolGiaoTrinhHocPhan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolGiaoTrinhHocPhan] SET FK_GiaoTrinh=@FK_GiaoTrinh, BaiHoc=@BaiHoc, Structure=@Structure, Vocabulary=@Vocabulary, Activities=@Activities, Objectives=@Objectives, OrderNumber=@OrderNumber WHERE Id=@Id", 
					"@FK_GiaoTrinh",  _SchoolGiaoTrinhHocPhan.FK_GiaoTrinh, 
					"@BaiHoc",  _SchoolGiaoTrinhHocPhan.BaiHoc, 
					"@Structure",  _SchoolGiaoTrinhHocPhan.Structure, 
					"@Vocabulary",  _SchoolGiaoTrinhHocPhan.Vocabulary, 
					"@Activities",  _SchoolGiaoTrinhHocPhan.Activities, 
					"@Objectives",  _SchoolGiaoTrinhHocPhan.Objectives, 
					"@OrderNumber",  _SchoolGiaoTrinhHocPhan.OrderNumber, 
					"@Id", _SchoolGiaoTrinhHocPhan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SchoolGiaoTrinhHocPhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SchoolGiaoTrinhHocPhan> _SchoolGiaoTrinhHocPhans)
		{
			foreach (SchoolGiaoTrinhHocPhan item in _SchoolGiaoTrinhHocPhans)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolGiaoTrinhHocPhan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SchoolGiaoTrinhHocPhan _SchoolGiaoTrinhHocPhan, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolGiaoTrinhHocPhan] SET Id=@Id, FK_GiaoTrinh=@FK_GiaoTrinh, BaiHoc=@BaiHoc, Structure=@Structure, Vocabulary=@Vocabulary, Activities=@Activities, Objectives=@Objectives, OrderNumber=@OrderNumber "+ condition, 
					"@Id",  _SchoolGiaoTrinhHocPhan.Id, 
					"@FK_GiaoTrinh",  _SchoolGiaoTrinhHocPhan.FK_GiaoTrinh, 
					"@BaiHoc",  _SchoolGiaoTrinhHocPhan.BaiHoc, 
					"@Structure",  _SchoolGiaoTrinhHocPhan.Structure, 
					"@Vocabulary",  _SchoolGiaoTrinhHocPhan.Vocabulary, 
					"@Activities",  _SchoolGiaoTrinhHocPhan.Activities, 
					"@Objectives",  _SchoolGiaoTrinhHocPhan.Objectives, 
					"@OrderNumber",  _SchoolGiaoTrinhHocPhan.OrderNumber);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SchoolGiaoTrinhHocPhan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolGiaoTrinhHocPhan] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolGiaoTrinhHocPhan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SchoolGiaoTrinhHocPhan _SchoolGiaoTrinhHocPhan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolGiaoTrinhHocPhan] WHERE Id=@Id",
					"@Id", _SchoolGiaoTrinhHocPhan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolGiaoTrinhHocPhan trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolGiaoTrinhHocPhan] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolGiaoTrinhHocPhan trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SchoolGiaoTrinhHocPhan> _SchoolGiaoTrinhHocPhans)
		{
			foreach (SchoolGiaoTrinhHocPhan item in _SchoolGiaoTrinhHocPhans)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
