using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpprovincefeecustomer:IEXpprovincefeecustomer
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpprovincefeecustomer(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpProvinceFeeCustomer từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvinceFeeCustomer]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpProvinceFeeCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvinceFeeCustomer] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpProvinceFeeCustomer từ Database
		/// </summary>
		public List<ExpProvinceFeeCustomer> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvinceFeeCustomer]");
				List<ExpProvinceFeeCustomer> items = new List<ExpProvinceFeeCustomer>();
				ExpProvinceFeeCustomer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpProvinceFeeCustomer();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Less1MN"] != null && dr["Less1MN"] != DBNull.Value)
					{
						item.Less1MN = Convert.ToInt32(dr["Less1MN"]);
					}
					if (dr["Less1MT"] != null && dr["Less1MT"] != DBNull.Value)
					{
						item.Less1MT = Convert.ToInt32(dr["Less1MT"]);
					}
					if (dr["Less1MB"] != null && dr["Less1MB"] != DBNull.Value)
					{
						item.Less1MB = Convert.ToInt32(dr["Less1MB"]);
					}
					if (dr["Less2MN"] != null && dr["Less2MN"] != DBNull.Value)
					{
						item.Less2MN = Convert.ToInt32(dr["Less2MN"]);
					}
					if (dr["Less2MT"] != null && dr["Less2MT"] != DBNull.Value)
					{
						item.Less2MT = Convert.ToInt32(dr["Less2MT"]);
					}
					if (dr["Less2MB"] != null && dr["Less2MB"] != DBNull.Value)
					{
						item.Less2MB = Convert.ToInt32(dr["Less2MB"]);
					}
					if (dr["Less3MN"] != null && dr["Less3MN"] != DBNull.Value)
					{
						item.Less3MN = Convert.ToInt32(dr["Less3MN"]);
					}
					if (dr["Less3MT"] != null && dr["Less3MT"] != DBNull.Value)
					{
						item.Less3MT = Convert.ToInt32(dr["Less3MT"]);
					}
					if (dr["Less3MB"] != null && dr["Less3MB"] != DBNull.Value)
					{
						item.Less3MB = Convert.ToInt32(dr["Less3MB"]);
					}
					if (dr["Less4MN"] != null && dr["Less4MN"] != DBNull.Value)
					{
						item.Less4MN = Convert.ToInt32(dr["Less4MN"]);
					}
					if (dr["Less4MT"] != null && dr["Less4MT"] != DBNull.Value)
					{
						item.Less4MT = Convert.ToInt32(dr["Less4MT"]);
					}
					if (dr["Less4MB"] != null && dr["Less4MB"] != DBNull.Value)
					{
						item.Less4MB = Convert.ToInt32(dr["Less4MB"]);
					}
					if (dr["Less5MN"] != null && dr["Less5MN"] != DBNull.Value)
					{
						item.Less5MN = Convert.ToInt32(dr["Less5MN"]);
					}
					if (dr["Less5MT"] != null && dr["Less5MT"] != DBNull.Value)
					{
						item.Less5MT = Convert.ToInt32(dr["Less5MT"]);
					}
					if (dr["Less5MB"] != null && dr["Less5MB"] != DBNull.Value)
					{
						item.Less5MB = Convert.ToInt32(dr["Less5MB"]);
					}
					if (dr["InitAll"] != null && dr["InitAll"] != DBNull.Value)
					{
						item.InitAll = Convert.ToInt32(dr["InitAll"]);
					}
					if (dr["InitMN"] != null && dr["InitMN"] != DBNull.Value)
					{
						item.InitMN = Convert.ToInt32(dr["InitMN"]);
					}
					if (dr["InitMT"] != null && dr["InitMT"] != DBNull.Value)
					{
						item.InitMT = Convert.ToInt32(dr["InitMT"]);
					}
					if (dr["InitMB"] != null && dr["InitMB"] != DBNull.Value)
					{
						item.InitMB = Convert.ToInt32(dr["InitMB"]);
					}
					if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
					{
						item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
					}
					if (dr["NextWeightAll"] != null && dr["NextWeightAll"] != DBNull.Value)
					{
						item.NextWeightAll = Convert.ToInt32(dr["NextWeightAll"]);
					}
					if (dr["NextWeightMN"] != null && dr["NextWeightMN"] != DBNull.Value)
					{
						item.NextWeightMN = Convert.ToInt32(dr["NextWeightMN"]);
					}
					if (dr["NextWeightMT"] != null && dr["NextWeightMT"] != DBNull.Value)
					{
						item.NextWeightMT = Convert.ToInt32(dr["NextWeightMT"]);
					}
					if (dr["NextWeightMB"] != null && dr["NextWeightMB"] != DBNull.Value)
					{
						item.NextWeightMB = Convert.ToInt32(dr["NextWeightMB"]);
					}
					if (dr["UsingLess"] != null && dr["UsingLess"] != DBNull.Value)
					{
						item.UsingLess = Convert.ToBoolean(dr["UsingLess"]);
					}
					if (dr["UsingZone"] != null && dr["UsingZone"] != DBNull.Value)
					{
						item.UsingZone = Convert.ToBoolean(dr["UsingZone"]);
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
		/// Lấy danh sách ExpProvinceFeeCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpProvinceFeeCustomer> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpProvinceFeeCustomer] A "+ condition,  parameters);
				List<ExpProvinceFeeCustomer> items = new List<ExpProvinceFeeCustomer>();
				ExpProvinceFeeCustomer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpProvinceFeeCustomer();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Less1MN"] != null && dr["Less1MN"] != DBNull.Value)
					{
						item.Less1MN = Convert.ToInt32(dr["Less1MN"]);
					}
					if (dr["Less1MT"] != null && dr["Less1MT"] != DBNull.Value)
					{
						item.Less1MT = Convert.ToInt32(dr["Less1MT"]);
					}
					if (dr["Less1MB"] != null && dr["Less1MB"] != DBNull.Value)
					{
						item.Less1MB = Convert.ToInt32(dr["Less1MB"]);
					}
					if (dr["Less2MN"] != null && dr["Less2MN"] != DBNull.Value)
					{
						item.Less2MN = Convert.ToInt32(dr["Less2MN"]);
					}
					if (dr["Less2MT"] != null && dr["Less2MT"] != DBNull.Value)
					{
						item.Less2MT = Convert.ToInt32(dr["Less2MT"]);
					}
					if (dr["Less2MB"] != null && dr["Less2MB"] != DBNull.Value)
					{
						item.Less2MB = Convert.ToInt32(dr["Less2MB"]);
					}
					if (dr["Less3MN"] != null && dr["Less3MN"] != DBNull.Value)
					{
						item.Less3MN = Convert.ToInt32(dr["Less3MN"]);
					}
					if (dr["Less3MT"] != null && dr["Less3MT"] != DBNull.Value)
					{
						item.Less3MT = Convert.ToInt32(dr["Less3MT"]);
					}
					if (dr["Less3MB"] != null && dr["Less3MB"] != DBNull.Value)
					{
						item.Less3MB = Convert.ToInt32(dr["Less3MB"]);
					}
					if (dr["Less4MN"] != null && dr["Less4MN"] != DBNull.Value)
					{
						item.Less4MN = Convert.ToInt32(dr["Less4MN"]);
					}
					if (dr["Less4MT"] != null && dr["Less4MT"] != DBNull.Value)
					{
						item.Less4MT = Convert.ToInt32(dr["Less4MT"]);
					}
					if (dr["Less4MB"] != null && dr["Less4MB"] != DBNull.Value)
					{
						item.Less4MB = Convert.ToInt32(dr["Less4MB"]);
					}
					if (dr["Less5MN"] != null && dr["Less5MN"] != DBNull.Value)
					{
						item.Less5MN = Convert.ToInt32(dr["Less5MN"]);
					}
					if (dr["Less5MT"] != null && dr["Less5MT"] != DBNull.Value)
					{
						item.Less5MT = Convert.ToInt32(dr["Less5MT"]);
					}
					if (dr["Less5MB"] != null && dr["Less5MB"] != DBNull.Value)
					{
						item.Less5MB = Convert.ToInt32(dr["Less5MB"]);
					}
					if (dr["InitAll"] != null && dr["InitAll"] != DBNull.Value)
					{
						item.InitAll = Convert.ToInt32(dr["InitAll"]);
					}
					if (dr["InitMN"] != null && dr["InitMN"] != DBNull.Value)
					{
						item.InitMN = Convert.ToInt32(dr["InitMN"]);
					}
					if (dr["InitMT"] != null && dr["InitMT"] != DBNull.Value)
					{
						item.InitMT = Convert.ToInt32(dr["InitMT"]);
					}
					if (dr["InitMB"] != null && dr["InitMB"] != DBNull.Value)
					{
						item.InitMB = Convert.ToInt32(dr["InitMB"]);
					}
					if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
					{
						item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
					}
					if (dr["NextWeightAll"] != null && dr["NextWeightAll"] != DBNull.Value)
					{
						item.NextWeightAll = Convert.ToInt32(dr["NextWeightAll"]);
					}
					if (dr["NextWeightMN"] != null && dr["NextWeightMN"] != DBNull.Value)
					{
						item.NextWeightMN = Convert.ToInt32(dr["NextWeightMN"]);
					}
					if (dr["NextWeightMT"] != null && dr["NextWeightMT"] != DBNull.Value)
					{
						item.NextWeightMT = Convert.ToInt32(dr["NextWeightMT"]);
					}
					if (dr["NextWeightMB"] != null && dr["NextWeightMB"] != DBNull.Value)
					{
						item.NextWeightMB = Convert.ToInt32(dr["NextWeightMB"]);
					}
					if (dr["UsingLess"] != null && dr["UsingLess"] != DBNull.Value)
					{
						item.UsingLess = Convert.ToBoolean(dr["UsingLess"]);
					}
					if (dr["UsingZone"] != null && dr["UsingZone"] != DBNull.Value)
					{
						item.UsingZone = Convert.ToBoolean(dr["UsingZone"]);
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

		public List<ExpProvinceFeeCustomer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpProvinceFeeCustomer] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpProvinceFeeCustomer] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpProvinceFeeCustomer>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpProvinceFeeCustomer từ Database
		/// </summary>
		public ExpProvinceFeeCustomer GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvinceFeeCustomer] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpProvinceFeeCustomer item=new ExpProvinceFeeCustomer();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Less1MN"] != null && dr["Less1MN"] != DBNull.Value)
						{
							item.Less1MN = Convert.ToInt32(dr["Less1MN"]);
						}
						if (dr["Less1MT"] != null && dr["Less1MT"] != DBNull.Value)
						{
							item.Less1MT = Convert.ToInt32(dr["Less1MT"]);
						}
						if (dr["Less1MB"] != null && dr["Less1MB"] != DBNull.Value)
						{
							item.Less1MB = Convert.ToInt32(dr["Less1MB"]);
						}
						if (dr["Less2MN"] != null && dr["Less2MN"] != DBNull.Value)
						{
							item.Less2MN = Convert.ToInt32(dr["Less2MN"]);
						}
						if (dr["Less2MT"] != null && dr["Less2MT"] != DBNull.Value)
						{
							item.Less2MT = Convert.ToInt32(dr["Less2MT"]);
						}
						if (dr["Less2MB"] != null && dr["Less2MB"] != DBNull.Value)
						{
							item.Less2MB = Convert.ToInt32(dr["Less2MB"]);
						}
						if (dr["Less3MN"] != null && dr["Less3MN"] != DBNull.Value)
						{
							item.Less3MN = Convert.ToInt32(dr["Less3MN"]);
						}
						if (dr["Less3MT"] != null && dr["Less3MT"] != DBNull.Value)
						{
							item.Less3MT = Convert.ToInt32(dr["Less3MT"]);
						}
						if (dr["Less3MB"] != null && dr["Less3MB"] != DBNull.Value)
						{
							item.Less3MB = Convert.ToInt32(dr["Less3MB"]);
						}
						if (dr["Less4MN"] != null && dr["Less4MN"] != DBNull.Value)
						{
							item.Less4MN = Convert.ToInt32(dr["Less4MN"]);
						}
						if (dr["Less4MT"] != null && dr["Less4MT"] != DBNull.Value)
						{
							item.Less4MT = Convert.ToInt32(dr["Less4MT"]);
						}
						if (dr["Less4MB"] != null && dr["Less4MB"] != DBNull.Value)
						{
							item.Less4MB = Convert.ToInt32(dr["Less4MB"]);
						}
						if (dr["Less5MN"] != null && dr["Less5MN"] != DBNull.Value)
						{
							item.Less5MN = Convert.ToInt32(dr["Less5MN"]);
						}
						if (dr["Less5MT"] != null && dr["Less5MT"] != DBNull.Value)
						{
							item.Less5MT = Convert.ToInt32(dr["Less5MT"]);
						}
						if (dr["Less5MB"] != null && dr["Less5MB"] != DBNull.Value)
						{
							item.Less5MB = Convert.ToInt32(dr["Less5MB"]);
						}
						if (dr["InitAll"] != null && dr["InitAll"] != DBNull.Value)
						{
							item.InitAll = Convert.ToInt32(dr["InitAll"]);
						}
						if (dr["InitMN"] != null && dr["InitMN"] != DBNull.Value)
						{
							item.InitMN = Convert.ToInt32(dr["InitMN"]);
						}
						if (dr["InitMT"] != null && dr["InitMT"] != DBNull.Value)
						{
							item.InitMT = Convert.ToInt32(dr["InitMT"]);
						}
						if (dr["InitMB"] != null && dr["InitMB"] != DBNull.Value)
						{
							item.InitMB = Convert.ToInt32(dr["InitMB"]);
						}
						if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
						{
							item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
						}
						if (dr["NextWeightAll"] != null && dr["NextWeightAll"] != DBNull.Value)
						{
							item.NextWeightAll = Convert.ToInt32(dr["NextWeightAll"]);
						}
						if (dr["NextWeightMN"] != null && dr["NextWeightMN"] != DBNull.Value)
						{
							item.NextWeightMN = Convert.ToInt32(dr["NextWeightMN"]);
						}
						if (dr["NextWeightMT"] != null && dr["NextWeightMT"] != DBNull.Value)
						{
							item.NextWeightMT = Convert.ToInt32(dr["NextWeightMT"]);
						}
						if (dr["NextWeightMB"] != null && dr["NextWeightMB"] != DBNull.Value)
						{
							item.NextWeightMB = Convert.ToInt32(dr["NextWeightMB"]);
						}
						if (dr["UsingLess"] != null && dr["UsingLess"] != DBNull.Value)
						{
							item.UsingLess = Convert.ToBoolean(dr["UsingLess"]);
						}
						if (dr["UsingZone"] != null && dr["UsingZone"] != DBNull.Value)
						{
							item.UsingZone = Convert.ToBoolean(dr["UsingZone"]);
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
		/// Lấy một ExpProvinceFeeCustomer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpProvinceFeeCustomer GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpProvinceFeeCustomer] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpProvinceFeeCustomer item=new ExpProvinceFeeCustomer();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Less1MN"] != null && dr["Less1MN"] != DBNull.Value)
						{
							item.Less1MN = Convert.ToInt32(dr["Less1MN"]);
						}
						if (dr["Less1MT"] != null && dr["Less1MT"] != DBNull.Value)
						{
							item.Less1MT = Convert.ToInt32(dr["Less1MT"]);
						}
						if (dr["Less1MB"] != null && dr["Less1MB"] != DBNull.Value)
						{
							item.Less1MB = Convert.ToInt32(dr["Less1MB"]);
						}
						if (dr["Less2MN"] != null && dr["Less2MN"] != DBNull.Value)
						{
							item.Less2MN = Convert.ToInt32(dr["Less2MN"]);
						}
						if (dr["Less2MT"] != null && dr["Less2MT"] != DBNull.Value)
						{
							item.Less2MT = Convert.ToInt32(dr["Less2MT"]);
						}
						if (dr["Less2MB"] != null && dr["Less2MB"] != DBNull.Value)
						{
							item.Less2MB = Convert.ToInt32(dr["Less2MB"]);
						}
						if (dr["Less3MN"] != null && dr["Less3MN"] != DBNull.Value)
						{
							item.Less3MN = Convert.ToInt32(dr["Less3MN"]);
						}
						if (dr["Less3MT"] != null && dr["Less3MT"] != DBNull.Value)
						{
							item.Less3MT = Convert.ToInt32(dr["Less3MT"]);
						}
						if (dr["Less3MB"] != null && dr["Less3MB"] != DBNull.Value)
						{
							item.Less3MB = Convert.ToInt32(dr["Less3MB"]);
						}
						if (dr["Less4MN"] != null && dr["Less4MN"] != DBNull.Value)
						{
							item.Less4MN = Convert.ToInt32(dr["Less4MN"]);
						}
						if (dr["Less4MT"] != null && dr["Less4MT"] != DBNull.Value)
						{
							item.Less4MT = Convert.ToInt32(dr["Less4MT"]);
						}
						if (dr["Less4MB"] != null && dr["Less4MB"] != DBNull.Value)
						{
							item.Less4MB = Convert.ToInt32(dr["Less4MB"]);
						}
						if (dr["Less5MN"] != null && dr["Less5MN"] != DBNull.Value)
						{
							item.Less5MN = Convert.ToInt32(dr["Less5MN"]);
						}
						if (dr["Less5MT"] != null && dr["Less5MT"] != DBNull.Value)
						{
							item.Less5MT = Convert.ToInt32(dr["Less5MT"]);
						}
						if (dr["Less5MB"] != null && dr["Less5MB"] != DBNull.Value)
						{
							item.Less5MB = Convert.ToInt32(dr["Less5MB"]);
						}
						if (dr["InitAll"] != null && dr["InitAll"] != DBNull.Value)
						{
							item.InitAll = Convert.ToInt32(dr["InitAll"]);
						}
						if (dr["InitMN"] != null && dr["InitMN"] != DBNull.Value)
						{
							item.InitMN = Convert.ToInt32(dr["InitMN"]);
						}
						if (dr["InitMT"] != null && dr["InitMT"] != DBNull.Value)
						{
							item.InitMT = Convert.ToInt32(dr["InitMT"]);
						}
						if (dr["InitMB"] != null && dr["InitMB"] != DBNull.Value)
						{
							item.InitMB = Convert.ToInt32(dr["InitMB"]);
						}
						if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
						{
							item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
						}
						if (dr["NextWeightAll"] != null && dr["NextWeightAll"] != DBNull.Value)
						{
							item.NextWeightAll = Convert.ToInt32(dr["NextWeightAll"]);
						}
						if (dr["NextWeightMN"] != null && dr["NextWeightMN"] != DBNull.Value)
						{
							item.NextWeightMN = Convert.ToInt32(dr["NextWeightMN"]);
						}
						if (dr["NextWeightMT"] != null && dr["NextWeightMT"] != DBNull.Value)
						{
							item.NextWeightMT = Convert.ToInt32(dr["NextWeightMT"]);
						}
						if (dr["NextWeightMB"] != null && dr["NextWeightMB"] != DBNull.Value)
						{
							item.NextWeightMB = Convert.ToInt32(dr["NextWeightMB"]);
						}
						if (dr["UsingLess"] != null && dr["UsingLess"] != DBNull.Value)
						{
							item.UsingLess = Convert.ToBoolean(dr["UsingLess"]);
						}
						if (dr["UsingZone"] != null && dr["UsingZone"] != DBNull.Value)
						{
							item.UsingZone = Convert.ToBoolean(dr["UsingZone"]);
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

		public ExpProvinceFeeCustomer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpProvinceFeeCustomer] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpProvinceFeeCustomer>(ds);
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
		/// Thêm mới ExpProvinceFeeCustomer vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpProvinceFeeCustomer _ExpProvinceFeeCustomer)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpProvinceFeeCustomer](Id, Name, Less1MN, Less1MT, Less1MB, Less2MN, Less2MT, Less2MB, Less3MN, Less3MT, Less3MB, Less4MN, Less4MT, Less4MB, Less5MN, Less5MT, Less5MB, InitAll, InitMN, InitMT, InitMB, InitWeight, NextWeightAll, NextWeightMN, NextWeightMT, NextWeightMB, UsingLess, UsingZone) VALUES(@Id, @Name, @Less1MN, @Less1MT, @Less1MB, @Less2MN, @Less2MT, @Less2MB, @Less3MN, @Less3MT, @Less3MB, @Less4MN, @Less4MT, @Less4MB, @Less5MN, @Less5MT, @Less5MB, @InitAll, @InitMN, @InitMT, @InitMB, @InitWeight, @NextWeightAll, @NextWeightMN, @NextWeightMT, @NextWeightMB, @UsingLess, @UsingZone)", 
					"@Id",  _ExpProvinceFeeCustomer.Id, 
					"@Name",  _ExpProvinceFeeCustomer.Name, 
					"@Less1MN",  _ExpProvinceFeeCustomer.Less1MN, 
					"@Less1MT",  _ExpProvinceFeeCustomer.Less1MT, 
					"@Less1MB",  _ExpProvinceFeeCustomer.Less1MB, 
					"@Less2MN",  _ExpProvinceFeeCustomer.Less2MN, 
					"@Less2MT",  _ExpProvinceFeeCustomer.Less2MT, 
					"@Less2MB",  _ExpProvinceFeeCustomer.Less2MB, 
					"@Less3MN",  _ExpProvinceFeeCustomer.Less3MN, 
					"@Less3MT",  _ExpProvinceFeeCustomer.Less3MT, 
					"@Less3MB",  _ExpProvinceFeeCustomer.Less3MB, 
					"@Less4MN",  _ExpProvinceFeeCustomer.Less4MN, 
					"@Less4MT",  _ExpProvinceFeeCustomer.Less4MT, 
					"@Less4MB",  _ExpProvinceFeeCustomer.Less4MB, 
					"@Less5MN",  _ExpProvinceFeeCustomer.Less5MN, 
					"@Less5MT",  _ExpProvinceFeeCustomer.Less5MT, 
					"@Less5MB",  _ExpProvinceFeeCustomer.Less5MB, 
					"@InitAll",  _ExpProvinceFeeCustomer.InitAll, 
					"@InitMN",  _ExpProvinceFeeCustomer.InitMN, 
					"@InitMT",  _ExpProvinceFeeCustomer.InitMT, 
					"@InitMB",  _ExpProvinceFeeCustomer.InitMB, 
					"@InitWeight",  _ExpProvinceFeeCustomer.InitWeight, 
					"@NextWeightAll",  _ExpProvinceFeeCustomer.NextWeightAll, 
					"@NextWeightMN",  _ExpProvinceFeeCustomer.NextWeightMN, 
					"@NextWeightMT",  _ExpProvinceFeeCustomer.NextWeightMT, 
					"@NextWeightMB",  _ExpProvinceFeeCustomer.NextWeightMB, 
					"@UsingLess",  _ExpProvinceFeeCustomer.UsingLess, 
					"@UsingZone",  _ExpProvinceFeeCustomer.UsingZone);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpProvinceFeeCustomer vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpProvinceFeeCustomer> _ExpProvinceFeeCustomers)
		{
			foreach (ExpProvinceFeeCustomer item in _ExpProvinceFeeCustomers)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpProvinceFeeCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpProvinceFeeCustomer _ExpProvinceFeeCustomer, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProvinceFeeCustomer] SET Id=@Id, Name=@Name, Less1MN=@Less1MN, Less1MT=@Less1MT, Less1MB=@Less1MB, Less2MN=@Less2MN, Less2MT=@Less2MT, Less2MB=@Less2MB, Less3MN=@Less3MN, Less3MT=@Less3MT, Less3MB=@Less3MB, Less4MN=@Less4MN, Less4MT=@Less4MT, Less4MB=@Less4MB, Less5MN=@Less5MN, Less5MT=@Less5MT, Less5MB=@Less5MB, InitAll=@InitAll, InitMN=@InitMN, InitMT=@InitMT, InitMB=@InitMB, InitWeight=@InitWeight, NextWeightAll=@NextWeightAll, NextWeightMN=@NextWeightMN, NextWeightMT=@NextWeightMT, NextWeightMB=@NextWeightMB, UsingLess=@UsingLess, UsingZone=@UsingZone WHERE Id=@Id", 
					"@Id",  _ExpProvinceFeeCustomer.Id, 
					"@Name",  _ExpProvinceFeeCustomer.Name, 
					"@Less1MN",  _ExpProvinceFeeCustomer.Less1MN, 
					"@Less1MT",  _ExpProvinceFeeCustomer.Less1MT, 
					"@Less1MB",  _ExpProvinceFeeCustomer.Less1MB, 
					"@Less2MN",  _ExpProvinceFeeCustomer.Less2MN, 
					"@Less2MT",  _ExpProvinceFeeCustomer.Less2MT, 
					"@Less2MB",  _ExpProvinceFeeCustomer.Less2MB, 
					"@Less3MN",  _ExpProvinceFeeCustomer.Less3MN, 
					"@Less3MT",  _ExpProvinceFeeCustomer.Less3MT, 
					"@Less3MB",  _ExpProvinceFeeCustomer.Less3MB, 
					"@Less4MN",  _ExpProvinceFeeCustomer.Less4MN, 
					"@Less4MT",  _ExpProvinceFeeCustomer.Less4MT, 
					"@Less4MB",  _ExpProvinceFeeCustomer.Less4MB, 
					"@Less5MN",  _ExpProvinceFeeCustomer.Less5MN, 
					"@Less5MT",  _ExpProvinceFeeCustomer.Less5MT, 
					"@Less5MB",  _ExpProvinceFeeCustomer.Less5MB, 
					"@InitAll",  _ExpProvinceFeeCustomer.InitAll, 
					"@InitMN",  _ExpProvinceFeeCustomer.InitMN, 
					"@InitMT",  _ExpProvinceFeeCustomer.InitMT, 
					"@InitMB",  _ExpProvinceFeeCustomer.InitMB, 
					"@InitWeight",  _ExpProvinceFeeCustomer.InitWeight, 
					"@NextWeightAll",  _ExpProvinceFeeCustomer.NextWeightAll, 
					"@NextWeightMN",  _ExpProvinceFeeCustomer.NextWeightMN, 
					"@NextWeightMT",  _ExpProvinceFeeCustomer.NextWeightMT, 
					"@NextWeightMB",  _ExpProvinceFeeCustomer.NextWeightMB, 
					"@UsingLess",  _ExpProvinceFeeCustomer.UsingLess, 
					"@UsingZone",  _ExpProvinceFeeCustomer.UsingZone, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpProvinceFeeCustomer vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpProvinceFeeCustomer _ExpProvinceFeeCustomer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProvinceFeeCustomer] SET Name=@Name, Less1MN=@Less1MN, Less1MT=@Less1MT, Less1MB=@Less1MB, Less2MN=@Less2MN, Less2MT=@Less2MT, Less2MB=@Less2MB, Less3MN=@Less3MN, Less3MT=@Less3MT, Less3MB=@Less3MB, Less4MN=@Less4MN, Less4MT=@Less4MT, Less4MB=@Less4MB, Less5MN=@Less5MN, Less5MT=@Less5MT, Less5MB=@Less5MB, InitAll=@InitAll, InitMN=@InitMN, InitMT=@InitMT, InitMB=@InitMB, InitWeight=@InitWeight, NextWeightAll=@NextWeightAll, NextWeightMN=@NextWeightMN, NextWeightMT=@NextWeightMT, NextWeightMB=@NextWeightMB, UsingLess=@UsingLess, UsingZone=@UsingZone WHERE Id=@Id", 
					"@Name",  _ExpProvinceFeeCustomer.Name, 
					"@Less1MN",  _ExpProvinceFeeCustomer.Less1MN, 
					"@Less1MT",  _ExpProvinceFeeCustomer.Less1MT, 
					"@Less1MB",  _ExpProvinceFeeCustomer.Less1MB, 
					"@Less2MN",  _ExpProvinceFeeCustomer.Less2MN, 
					"@Less2MT",  _ExpProvinceFeeCustomer.Less2MT, 
					"@Less2MB",  _ExpProvinceFeeCustomer.Less2MB, 
					"@Less3MN",  _ExpProvinceFeeCustomer.Less3MN, 
					"@Less3MT",  _ExpProvinceFeeCustomer.Less3MT, 
					"@Less3MB",  _ExpProvinceFeeCustomer.Less3MB, 
					"@Less4MN",  _ExpProvinceFeeCustomer.Less4MN, 
					"@Less4MT",  _ExpProvinceFeeCustomer.Less4MT, 
					"@Less4MB",  _ExpProvinceFeeCustomer.Less4MB, 
					"@Less5MN",  _ExpProvinceFeeCustomer.Less5MN, 
					"@Less5MT",  _ExpProvinceFeeCustomer.Less5MT, 
					"@Less5MB",  _ExpProvinceFeeCustomer.Less5MB, 
					"@InitAll",  _ExpProvinceFeeCustomer.InitAll, 
					"@InitMN",  _ExpProvinceFeeCustomer.InitMN, 
					"@InitMT",  _ExpProvinceFeeCustomer.InitMT, 
					"@InitMB",  _ExpProvinceFeeCustomer.InitMB, 
					"@InitWeight",  _ExpProvinceFeeCustomer.InitWeight, 
					"@NextWeightAll",  _ExpProvinceFeeCustomer.NextWeightAll, 
					"@NextWeightMN",  _ExpProvinceFeeCustomer.NextWeightMN, 
					"@NextWeightMT",  _ExpProvinceFeeCustomer.NextWeightMT, 
					"@NextWeightMB",  _ExpProvinceFeeCustomer.NextWeightMB, 
					"@UsingLess",  _ExpProvinceFeeCustomer.UsingLess, 
					"@UsingZone",  _ExpProvinceFeeCustomer.UsingZone, 
					"@Id", _ExpProvinceFeeCustomer.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpProvinceFeeCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpProvinceFeeCustomer> _ExpProvinceFeeCustomers)
		{
			foreach (ExpProvinceFeeCustomer item in _ExpProvinceFeeCustomers)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpProvinceFeeCustomer vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpProvinceFeeCustomer _ExpProvinceFeeCustomer, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProvinceFeeCustomer] SET Id=@Id, Name=@Name, Less1MN=@Less1MN, Less1MT=@Less1MT, Less1MB=@Less1MB, Less2MN=@Less2MN, Less2MT=@Less2MT, Less2MB=@Less2MB, Less3MN=@Less3MN, Less3MT=@Less3MT, Less3MB=@Less3MB, Less4MN=@Less4MN, Less4MT=@Less4MT, Less4MB=@Less4MB, Less5MN=@Less5MN, Less5MT=@Less5MT, Less5MB=@Less5MB, InitAll=@InitAll, InitMN=@InitMN, InitMT=@InitMT, InitMB=@InitMB, InitWeight=@InitWeight, NextWeightAll=@NextWeightAll, NextWeightMN=@NextWeightMN, NextWeightMT=@NextWeightMT, NextWeightMB=@NextWeightMB, UsingLess=@UsingLess, UsingZone=@UsingZone "+ condition, 
					"@Id",  _ExpProvinceFeeCustomer.Id, 
					"@Name",  _ExpProvinceFeeCustomer.Name, 
					"@Less1MN",  _ExpProvinceFeeCustomer.Less1MN, 
					"@Less1MT",  _ExpProvinceFeeCustomer.Less1MT, 
					"@Less1MB",  _ExpProvinceFeeCustomer.Less1MB, 
					"@Less2MN",  _ExpProvinceFeeCustomer.Less2MN, 
					"@Less2MT",  _ExpProvinceFeeCustomer.Less2MT, 
					"@Less2MB",  _ExpProvinceFeeCustomer.Less2MB, 
					"@Less3MN",  _ExpProvinceFeeCustomer.Less3MN, 
					"@Less3MT",  _ExpProvinceFeeCustomer.Less3MT, 
					"@Less3MB",  _ExpProvinceFeeCustomer.Less3MB, 
					"@Less4MN",  _ExpProvinceFeeCustomer.Less4MN, 
					"@Less4MT",  _ExpProvinceFeeCustomer.Less4MT, 
					"@Less4MB",  _ExpProvinceFeeCustomer.Less4MB, 
					"@Less5MN",  _ExpProvinceFeeCustomer.Less5MN, 
					"@Less5MT",  _ExpProvinceFeeCustomer.Less5MT, 
					"@Less5MB",  _ExpProvinceFeeCustomer.Less5MB, 
					"@InitAll",  _ExpProvinceFeeCustomer.InitAll, 
					"@InitMN",  _ExpProvinceFeeCustomer.InitMN, 
					"@InitMT",  _ExpProvinceFeeCustomer.InitMT, 
					"@InitMB",  _ExpProvinceFeeCustomer.InitMB, 
					"@InitWeight",  _ExpProvinceFeeCustomer.InitWeight, 
					"@NextWeightAll",  _ExpProvinceFeeCustomer.NextWeightAll, 
					"@NextWeightMN",  _ExpProvinceFeeCustomer.NextWeightMN, 
					"@NextWeightMT",  _ExpProvinceFeeCustomer.NextWeightMT, 
					"@NextWeightMB",  _ExpProvinceFeeCustomer.NextWeightMB, 
					"@UsingLess",  _ExpProvinceFeeCustomer.UsingLess, 
					"@UsingZone",  _ExpProvinceFeeCustomer.UsingZone);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpProvinceFeeCustomer trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProvinceFeeCustomer] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProvinceFeeCustomer trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpProvinceFeeCustomer _ExpProvinceFeeCustomer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProvinceFeeCustomer] WHERE Id=@Id",
					"@Id", _ExpProvinceFeeCustomer.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProvinceFeeCustomer trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProvinceFeeCustomer] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProvinceFeeCustomer trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpProvinceFeeCustomer> _ExpProvinceFeeCustomers)
		{
			foreach (ExpProvinceFeeCustomer item in _ExpProvinceFeeCustomers)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
