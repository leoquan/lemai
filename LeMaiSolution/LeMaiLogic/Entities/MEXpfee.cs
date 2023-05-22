using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpfee:IEXpfee
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpfee(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpFee từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpFee]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpFee] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpFee từ Database
		/// </summary>
		public List<ExpFee> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpFee]");
				List<ExpFee> items = new List<ExpFee>();
				ExpFee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpFee();
					if (dr["MaBG"] != null && dr["MaBG"] != DBNull.Value)
					{
						item.MaBG = Convert.ToString(dr["MaBG"]);
					}
					if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
					{
						item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
					}
					if (dr["InitFee"] != null && dr["InitFee"] != DBNull.Value)
					{
						item.InitFee = Convert.ToInt32(dr["InitFee"]);
					}
					if (dr["FeePerKg"] != null && dr["FeePerKg"] != DBNull.Value)
					{
						item.FeePerKg = Convert.ToInt32(dr["FeePerKg"]);
					}
					if (dr["Less20"] != null && dr["Less20"] != DBNull.Value)
					{
						item.Less20 = Convert.ToInt32(dr["Less20"]);
					}
					if (dr["Less50"] != null && dr["Less50"] != DBNull.Value)
					{
						item.Less50 = Convert.ToInt32(dr["Less50"]);
					}
					if (dr["Less100"] != null && dr["Less100"] != DBNull.Value)
					{
						item.Less100 = Convert.ToInt32(dr["Less100"]);
					}
					if (dr["Less300"] != null && dr["Less300"] != DBNull.Value)
					{
						item.Less300 = Convert.ToInt32(dr["Less300"]);
					}
					if (dr["Less500"] != null && dr["Less500"] != DBNull.Value)
					{
						item.Less500 = Convert.ToInt32(dr["Less500"]);
					}
					if (dr["Less1000"] != null && dr["Less1000"] != DBNull.Value)
					{
						item.Less1000 = Convert.ToInt32(dr["Less1000"]);
					}
					if (dr["ElseFee"] != null && dr["ElseFee"] != DBNull.Value)
					{
						item.ElseFee = Convert.ToInt32(dr["ElseFee"]);
					}
					if (dr["InitFeeFrom"] != null && dr["InitFeeFrom"] != DBNull.Value)
					{
						item.InitFeeFrom = Convert.ToInt32(dr["InitFeeFrom"]);
					}
					if (dr["FeePerKgFrom"] != null && dr["FeePerKgFrom"] != DBNull.Value)
					{
						item.FeePerKgFrom = Convert.ToInt32(dr["FeePerKgFrom"]);
					}
					if (dr["Less20From"] != null && dr["Less20From"] != DBNull.Value)
					{
						item.Less20From = Convert.ToInt32(dr["Less20From"]);
					}
					if (dr["Less50From"] != null && dr["Less50From"] != DBNull.Value)
					{
						item.Less50From = Convert.ToInt32(dr["Less50From"]);
					}
					if (dr["Less100From"] != null && dr["Less100From"] != DBNull.Value)
					{
						item.Less100From = Convert.ToInt32(dr["Less100From"]);
					}
					if (dr["Less300From"] != null && dr["Less300From"] != DBNull.Value)
					{
						item.Less300From = Convert.ToInt32(dr["Less300From"]);
					}
					if (dr["Less500From"] != null && dr["Less500From"] != DBNull.Value)
					{
						item.Less500From = Convert.ToInt32(dr["Less500From"]);
					}
					if (dr["Less1000From"] != null && dr["Less1000From"] != DBNull.Value)
					{
						item.Less1000From = Convert.ToInt32(dr["Less1000From"]);
					}
					if (dr["ElseFeeFrom"] != null && dr["ElseFeeFrom"] != DBNull.Value)
					{
						item.ElseFeeFrom = Convert.ToInt32(dr["ElseFeeFrom"]);
					}
					if (dr["InitFeeTo"] != null && dr["InitFeeTo"] != DBNull.Value)
					{
						item.InitFeeTo = Convert.ToInt32(dr["InitFeeTo"]);
					}
					if (dr["FeePerKgTo"] != null && dr["FeePerKgTo"] != DBNull.Value)
					{
						item.FeePerKgTo = Convert.ToInt32(dr["FeePerKgTo"]);
					}
					if (dr["Less20To"] != null && dr["Less20To"] != DBNull.Value)
					{
						item.Less20To = Convert.ToInt32(dr["Less20To"]);
					}
					if (dr["Less50To"] != null && dr["Less50To"] != DBNull.Value)
					{
						item.Less50To = Convert.ToInt32(dr["Less50To"]);
					}
					if (dr["Less100To"] != null && dr["Less100To"] != DBNull.Value)
					{
						item.Less100To = Convert.ToInt32(dr["Less100To"]);
					}
					if (dr["Less300To"] != null && dr["Less300To"] != DBNull.Value)
					{
						item.Less300To = Convert.ToInt32(dr["Less300To"]);
					}
					if (dr["Less500To"] != null && dr["Less500To"] != DBNull.Value)
					{
						item.Less500To = Convert.ToInt32(dr["Less500To"]);
					}
					if (dr["Less1000To"] != null && dr["Less1000To"] != DBNull.Value)
					{
						item.Less1000To = Convert.ToInt32(dr["Less1000To"]);
					}
					if (dr["ElseFeeTo"] != null && dr["ElseFeeTo"] != DBNull.Value)
					{
						item.ElseFeeTo = Convert.ToInt32(dr["ElseFeeTo"]);
					}
					if (dr["InitFeeSys"] != null && dr["InitFeeSys"] != DBNull.Value)
					{
						item.InitFeeSys = Convert.ToInt32(dr["InitFeeSys"]);
					}
					if (dr["FeePerKgSys"] != null && dr["FeePerKgSys"] != DBNull.Value)
					{
						item.FeePerKgSys = Convert.ToInt32(dr["FeePerKgSys"]);
					}
					if (dr["Less20Sys"] != null && dr["Less20Sys"] != DBNull.Value)
					{
						item.Less20Sys = Convert.ToInt32(dr["Less20Sys"]);
					}
					if (dr["Less50Sys"] != null && dr["Less50Sys"] != DBNull.Value)
					{
						item.Less50Sys = Convert.ToInt32(dr["Less50Sys"]);
					}
					if (dr["Less100Sys"] != null && dr["Less100Sys"] != DBNull.Value)
					{
						item.Less100Sys = Convert.ToInt32(dr["Less100Sys"]);
					}
					if (dr["Less300Sys"] != null && dr["Less300Sys"] != DBNull.Value)
					{
						item.Less300Sys = Convert.ToInt32(dr["Less300Sys"]);
					}
					if (dr["Less500Sys"] != null && dr["Less500Sys"] != DBNull.Value)
					{
						item.Less500Sys = Convert.ToInt32(dr["Less500Sys"]);
					}
					if (dr["Less1000Sys"] != null && dr["Less1000Sys"] != DBNull.Value)
					{
						item.Less1000Sys = Convert.ToInt32(dr["Less1000Sys"]);
					}
					if (dr["ElseFeeSys"] != null && dr["ElseFeeSys"] != DBNull.Value)
					{
						item.ElseFeeSys = Convert.ToInt32(dr["ElseFeeSys"]);
					}
					if (dr["SystemFee"] != null && dr["SystemFee"] != DBNull.Value)
					{
						item.SystemFee = Convert.ToInt32(dr["SystemFee"]);
					}
					if (dr["InternalFee"] != null && dr["InternalFee"] != DBNull.Value)
					{
						item.InternalFee = Convert.ToInt32(dr["InternalFee"]);
					}
					if (dr["ExternalFee"] != null && dr["ExternalFee"] != DBNull.Value)
					{
						item.ExternalFee = Convert.ToInt32(dr["ExternalFee"]);
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
		/// Lấy danh sách ExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpFee> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpFee] A "+ condition,  parameters);
				List<ExpFee> items = new List<ExpFee>();
				ExpFee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpFee();
					if (dr["MaBG"] != null && dr["MaBG"] != DBNull.Value)
					{
						item.MaBG = Convert.ToString(dr["MaBG"]);
					}
					if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
					{
						item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
					}
					if (dr["InitFee"] != null && dr["InitFee"] != DBNull.Value)
					{
						item.InitFee = Convert.ToInt32(dr["InitFee"]);
					}
					if (dr["FeePerKg"] != null && dr["FeePerKg"] != DBNull.Value)
					{
						item.FeePerKg = Convert.ToInt32(dr["FeePerKg"]);
					}
					if (dr["Less20"] != null && dr["Less20"] != DBNull.Value)
					{
						item.Less20 = Convert.ToInt32(dr["Less20"]);
					}
					if (dr["Less50"] != null && dr["Less50"] != DBNull.Value)
					{
						item.Less50 = Convert.ToInt32(dr["Less50"]);
					}
					if (dr["Less100"] != null && dr["Less100"] != DBNull.Value)
					{
						item.Less100 = Convert.ToInt32(dr["Less100"]);
					}
					if (dr["Less300"] != null && dr["Less300"] != DBNull.Value)
					{
						item.Less300 = Convert.ToInt32(dr["Less300"]);
					}
					if (dr["Less500"] != null && dr["Less500"] != DBNull.Value)
					{
						item.Less500 = Convert.ToInt32(dr["Less500"]);
					}
					if (dr["Less1000"] != null && dr["Less1000"] != DBNull.Value)
					{
						item.Less1000 = Convert.ToInt32(dr["Less1000"]);
					}
					if (dr["ElseFee"] != null && dr["ElseFee"] != DBNull.Value)
					{
						item.ElseFee = Convert.ToInt32(dr["ElseFee"]);
					}
					if (dr["InitFeeFrom"] != null && dr["InitFeeFrom"] != DBNull.Value)
					{
						item.InitFeeFrom = Convert.ToInt32(dr["InitFeeFrom"]);
					}
					if (dr["FeePerKgFrom"] != null && dr["FeePerKgFrom"] != DBNull.Value)
					{
						item.FeePerKgFrom = Convert.ToInt32(dr["FeePerKgFrom"]);
					}
					if (dr["Less20From"] != null && dr["Less20From"] != DBNull.Value)
					{
						item.Less20From = Convert.ToInt32(dr["Less20From"]);
					}
					if (dr["Less50From"] != null && dr["Less50From"] != DBNull.Value)
					{
						item.Less50From = Convert.ToInt32(dr["Less50From"]);
					}
					if (dr["Less100From"] != null && dr["Less100From"] != DBNull.Value)
					{
						item.Less100From = Convert.ToInt32(dr["Less100From"]);
					}
					if (dr["Less300From"] != null && dr["Less300From"] != DBNull.Value)
					{
						item.Less300From = Convert.ToInt32(dr["Less300From"]);
					}
					if (dr["Less500From"] != null && dr["Less500From"] != DBNull.Value)
					{
						item.Less500From = Convert.ToInt32(dr["Less500From"]);
					}
					if (dr["Less1000From"] != null && dr["Less1000From"] != DBNull.Value)
					{
						item.Less1000From = Convert.ToInt32(dr["Less1000From"]);
					}
					if (dr["ElseFeeFrom"] != null && dr["ElseFeeFrom"] != DBNull.Value)
					{
						item.ElseFeeFrom = Convert.ToInt32(dr["ElseFeeFrom"]);
					}
					if (dr["InitFeeTo"] != null && dr["InitFeeTo"] != DBNull.Value)
					{
						item.InitFeeTo = Convert.ToInt32(dr["InitFeeTo"]);
					}
					if (dr["FeePerKgTo"] != null && dr["FeePerKgTo"] != DBNull.Value)
					{
						item.FeePerKgTo = Convert.ToInt32(dr["FeePerKgTo"]);
					}
					if (dr["Less20To"] != null && dr["Less20To"] != DBNull.Value)
					{
						item.Less20To = Convert.ToInt32(dr["Less20To"]);
					}
					if (dr["Less50To"] != null && dr["Less50To"] != DBNull.Value)
					{
						item.Less50To = Convert.ToInt32(dr["Less50To"]);
					}
					if (dr["Less100To"] != null && dr["Less100To"] != DBNull.Value)
					{
						item.Less100To = Convert.ToInt32(dr["Less100To"]);
					}
					if (dr["Less300To"] != null && dr["Less300To"] != DBNull.Value)
					{
						item.Less300To = Convert.ToInt32(dr["Less300To"]);
					}
					if (dr["Less500To"] != null && dr["Less500To"] != DBNull.Value)
					{
						item.Less500To = Convert.ToInt32(dr["Less500To"]);
					}
					if (dr["Less1000To"] != null && dr["Less1000To"] != DBNull.Value)
					{
						item.Less1000To = Convert.ToInt32(dr["Less1000To"]);
					}
					if (dr["ElseFeeTo"] != null && dr["ElseFeeTo"] != DBNull.Value)
					{
						item.ElseFeeTo = Convert.ToInt32(dr["ElseFeeTo"]);
					}
					if (dr["InitFeeSys"] != null && dr["InitFeeSys"] != DBNull.Value)
					{
						item.InitFeeSys = Convert.ToInt32(dr["InitFeeSys"]);
					}
					if (dr["FeePerKgSys"] != null && dr["FeePerKgSys"] != DBNull.Value)
					{
						item.FeePerKgSys = Convert.ToInt32(dr["FeePerKgSys"]);
					}
					if (dr["Less20Sys"] != null && dr["Less20Sys"] != DBNull.Value)
					{
						item.Less20Sys = Convert.ToInt32(dr["Less20Sys"]);
					}
					if (dr["Less50Sys"] != null && dr["Less50Sys"] != DBNull.Value)
					{
						item.Less50Sys = Convert.ToInt32(dr["Less50Sys"]);
					}
					if (dr["Less100Sys"] != null && dr["Less100Sys"] != DBNull.Value)
					{
						item.Less100Sys = Convert.ToInt32(dr["Less100Sys"]);
					}
					if (dr["Less300Sys"] != null && dr["Less300Sys"] != DBNull.Value)
					{
						item.Less300Sys = Convert.ToInt32(dr["Less300Sys"]);
					}
					if (dr["Less500Sys"] != null && dr["Less500Sys"] != DBNull.Value)
					{
						item.Less500Sys = Convert.ToInt32(dr["Less500Sys"]);
					}
					if (dr["Less1000Sys"] != null && dr["Less1000Sys"] != DBNull.Value)
					{
						item.Less1000Sys = Convert.ToInt32(dr["Less1000Sys"]);
					}
					if (dr["ElseFeeSys"] != null && dr["ElseFeeSys"] != DBNull.Value)
					{
						item.ElseFeeSys = Convert.ToInt32(dr["ElseFeeSys"]);
					}
					if (dr["SystemFee"] != null && dr["SystemFee"] != DBNull.Value)
					{
						item.SystemFee = Convert.ToInt32(dr["SystemFee"]);
					}
					if (dr["InternalFee"] != null && dr["InternalFee"] != DBNull.Value)
					{
						item.InternalFee = Convert.ToInt32(dr["InternalFee"]);
					}
					if (dr["ExternalFee"] != null && dr["ExternalFee"] != DBNull.Value)
					{
						item.ExternalFee = Convert.ToInt32(dr["ExternalFee"]);
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

		public List<ExpFee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpFee] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpFee] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpFee>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpFee từ Database
		/// </summary>
		public ExpFee GetObject(string schema, String MaBG)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpFee] where MaBG=@MaBG",
					"@MaBG", MaBG);
				if (ds.Rows.Count > 0)
				{
					ExpFee item=new ExpFee();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["MaBG"] != null && dr["MaBG"] != DBNull.Value)
						{
							item.MaBG = Convert.ToString(dr["MaBG"]);
						}
						if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
						{
							item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
						}
						if (dr["InitFee"] != null && dr["InitFee"] != DBNull.Value)
						{
							item.InitFee = Convert.ToInt32(dr["InitFee"]);
						}
						if (dr["FeePerKg"] != null && dr["FeePerKg"] != DBNull.Value)
						{
							item.FeePerKg = Convert.ToInt32(dr["FeePerKg"]);
						}
						if (dr["Less20"] != null && dr["Less20"] != DBNull.Value)
						{
							item.Less20 = Convert.ToInt32(dr["Less20"]);
						}
						if (dr["Less50"] != null && dr["Less50"] != DBNull.Value)
						{
							item.Less50 = Convert.ToInt32(dr["Less50"]);
						}
						if (dr["Less100"] != null && dr["Less100"] != DBNull.Value)
						{
							item.Less100 = Convert.ToInt32(dr["Less100"]);
						}
						if (dr["Less300"] != null && dr["Less300"] != DBNull.Value)
						{
							item.Less300 = Convert.ToInt32(dr["Less300"]);
						}
						if (dr["Less500"] != null && dr["Less500"] != DBNull.Value)
						{
							item.Less500 = Convert.ToInt32(dr["Less500"]);
						}
						if (dr["Less1000"] != null && dr["Less1000"] != DBNull.Value)
						{
							item.Less1000 = Convert.ToInt32(dr["Less1000"]);
						}
						if (dr["ElseFee"] != null && dr["ElseFee"] != DBNull.Value)
						{
							item.ElseFee = Convert.ToInt32(dr["ElseFee"]);
						}
						if (dr["InitFeeFrom"] != null && dr["InitFeeFrom"] != DBNull.Value)
						{
							item.InitFeeFrom = Convert.ToInt32(dr["InitFeeFrom"]);
						}
						if (dr["FeePerKgFrom"] != null && dr["FeePerKgFrom"] != DBNull.Value)
						{
							item.FeePerKgFrom = Convert.ToInt32(dr["FeePerKgFrom"]);
						}
						if (dr["Less20From"] != null && dr["Less20From"] != DBNull.Value)
						{
							item.Less20From = Convert.ToInt32(dr["Less20From"]);
						}
						if (dr["Less50From"] != null && dr["Less50From"] != DBNull.Value)
						{
							item.Less50From = Convert.ToInt32(dr["Less50From"]);
						}
						if (dr["Less100From"] != null && dr["Less100From"] != DBNull.Value)
						{
							item.Less100From = Convert.ToInt32(dr["Less100From"]);
						}
						if (dr["Less300From"] != null && dr["Less300From"] != DBNull.Value)
						{
							item.Less300From = Convert.ToInt32(dr["Less300From"]);
						}
						if (dr["Less500From"] != null && dr["Less500From"] != DBNull.Value)
						{
							item.Less500From = Convert.ToInt32(dr["Less500From"]);
						}
						if (dr["Less1000From"] != null && dr["Less1000From"] != DBNull.Value)
						{
							item.Less1000From = Convert.ToInt32(dr["Less1000From"]);
						}
						if (dr["ElseFeeFrom"] != null && dr["ElseFeeFrom"] != DBNull.Value)
						{
							item.ElseFeeFrom = Convert.ToInt32(dr["ElseFeeFrom"]);
						}
						if (dr["InitFeeTo"] != null && dr["InitFeeTo"] != DBNull.Value)
						{
							item.InitFeeTo = Convert.ToInt32(dr["InitFeeTo"]);
						}
						if (dr["FeePerKgTo"] != null && dr["FeePerKgTo"] != DBNull.Value)
						{
							item.FeePerKgTo = Convert.ToInt32(dr["FeePerKgTo"]);
						}
						if (dr["Less20To"] != null && dr["Less20To"] != DBNull.Value)
						{
							item.Less20To = Convert.ToInt32(dr["Less20To"]);
						}
						if (dr["Less50To"] != null && dr["Less50To"] != DBNull.Value)
						{
							item.Less50To = Convert.ToInt32(dr["Less50To"]);
						}
						if (dr["Less100To"] != null && dr["Less100To"] != DBNull.Value)
						{
							item.Less100To = Convert.ToInt32(dr["Less100To"]);
						}
						if (dr["Less300To"] != null && dr["Less300To"] != DBNull.Value)
						{
							item.Less300To = Convert.ToInt32(dr["Less300To"]);
						}
						if (dr["Less500To"] != null && dr["Less500To"] != DBNull.Value)
						{
							item.Less500To = Convert.ToInt32(dr["Less500To"]);
						}
						if (dr["Less1000To"] != null && dr["Less1000To"] != DBNull.Value)
						{
							item.Less1000To = Convert.ToInt32(dr["Less1000To"]);
						}
						if (dr["ElseFeeTo"] != null && dr["ElseFeeTo"] != DBNull.Value)
						{
							item.ElseFeeTo = Convert.ToInt32(dr["ElseFeeTo"]);
						}
						if (dr["InitFeeSys"] != null && dr["InitFeeSys"] != DBNull.Value)
						{
							item.InitFeeSys = Convert.ToInt32(dr["InitFeeSys"]);
						}
						if (dr["FeePerKgSys"] != null && dr["FeePerKgSys"] != DBNull.Value)
						{
							item.FeePerKgSys = Convert.ToInt32(dr["FeePerKgSys"]);
						}
						if (dr["Less20Sys"] != null && dr["Less20Sys"] != DBNull.Value)
						{
							item.Less20Sys = Convert.ToInt32(dr["Less20Sys"]);
						}
						if (dr["Less50Sys"] != null && dr["Less50Sys"] != DBNull.Value)
						{
							item.Less50Sys = Convert.ToInt32(dr["Less50Sys"]);
						}
						if (dr["Less100Sys"] != null && dr["Less100Sys"] != DBNull.Value)
						{
							item.Less100Sys = Convert.ToInt32(dr["Less100Sys"]);
						}
						if (dr["Less300Sys"] != null && dr["Less300Sys"] != DBNull.Value)
						{
							item.Less300Sys = Convert.ToInt32(dr["Less300Sys"]);
						}
						if (dr["Less500Sys"] != null && dr["Less500Sys"] != DBNull.Value)
						{
							item.Less500Sys = Convert.ToInt32(dr["Less500Sys"]);
						}
						if (dr["Less1000Sys"] != null && dr["Less1000Sys"] != DBNull.Value)
						{
							item.Less1000Sys = Convert.ToInt32(dr["Less1000Sys"]);
						}
						if (dr["ElseFeeSys"] != null && dr["ElseFeeSys"] != DBNull.Value)
						{
							item.ElseFeeSys = Convert.ToInt32(dr["ElseFeeSys"]);
						}
						if (dr["SystemFee"] != null && dr["SystemFee"] != DBNull.Value)
						{
							item.SystemFee = Convert.ToInt32(dr["SystemFee"]);
						}
						if (dr["InternalFee"] != null && dr["InternalFee"] != DBNull.Value)
						{
							item.InternalFee = Convert.ToInt32(dr["InternalFee"]);
						}
						if (dr["ExternalFee"] != null && dr["ExternalFee"] != DBNull.Value)
						{
							item.ExternalFee = Convert.ToInt32(dr["ExternalFee"]);
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
		/// Lấy một ExpFee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpFee GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpFee] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpFee item=new ExpFee();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["MaBG"] != null && dr["MaBG"] != DBNull.Value)
						{
							item.MaBG = Convert.ToString(dr["MaBG"]);
						}
						if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
						{
							item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
						}
						if (dr["InitFee"] != null && dr["InitFee"] != DBNull.Value)
						{
							item.InitFee = Convert.ToInt32(dr["InitFee"]);
						}
						if (dr["FeePerKg"] != null && dr["FeePerKg"] != DBNull.Value)
						{
							item.FeePerKg = Convert.ToInt32(dr["FeePerKg"]);
						}
						if (dr["Less20"] != null && dr["Less20"] != DBNull.Value)
						{
							item.Less20 = Convert.ToInt32(dr["Less20"]);
						}
						if (dr["Less50"] != null && dr["Less50"] != DBNull.Value)
						{
							item.Less50 = Convert.ToInt32(dr["Less50"]);
						}
						if (dr["Less100"] != null && dr["Less100"] != DBNull.Value)
						{
							item.Less100 = Convert.ToInt32(dr["Less100"]);
						}
						if (dr["Less300"] != null && dr["Less300"] != DBNull.Value)
						{
							item.Less300 = Convert.ToInt32(dr["Less300"]);
						}
						if (dr["Less500"] != null && dr["Less500"] != DBNull.Value)
						{
							item.Less500 = Convert.ToInt32(dr["Less500"]);
						}
						if (dr["Less1000"] != null && dr["Less1000"] != DBNull.Value)
						{
							item.Less1000 = Convert.ToInt32(dr["Less1000"]);
						}
						if (dr["ElseFee"] != null && dr["ElseFee"] != DBNull.Value)
						{
							item.ElseFee = Convert.ToInt32(dr["ElseFee"]);
						}
						if (dr["InitFeeFrom"] != null && dr["InitFeeFrom"] != DBNull.Value)
						{
							item.InitFeeFrom = Convert.ToInt32(dr["InitFeeFrom"]);
						}
						if (dr["FeePerKgFrom"] != null && dr["FeePerKgFrom"] != DBNull.Value)
						{
							item.FeePerKgFrom = Convert.ToInt32(dr["FeePerKgFrom"]);
						}
						if (dr["Less20From"] != null && dr["Less20From"] != DBNull.Value)
						{
							item.Less20From = Convert.ToInt32(dr["Less20From"]);
						}
						if (dr["Less50From"] != null && dr["Less50From"] != DBNull.Value)
						{
							item.Less50From = Convert.ToInt32(dr["Less50From"]);
						}
						if (dr["Less100From"] != null && dr["Less100From"] != DBNull.Value)
						{
							item.Less100From = Convert.ToInt32(dr["Less100From"]);
						}
						if (dr["Less300From"] != null && dr["Less300From"] != DBNull.Value)
						{
							item.Less300From = Convert.ToInt32(dr["Less300From"]);
						}
						if (dr["Less500From"] != null && dr["Less500From"] != DBNull.Value)
						{
							item.Less500From = Convert.ToInt32(dr["Less500From"]);
						}
						if (dr["Less1000From"] != null && dr["Less1000From"] != DBNull.Value)
						{
							item.Less1000From = Convert.ToInt32(dr["Less1000From"]);
						}
						if (dr["ElseFeeFrom"] != null && dr["ElseFeeFrom"] != DBNull.Value)
						{
							item.ElseFeeFrom = Convert.ToInt32(dr["ElseFeeFrom"]);
						}
						if (dr["InitFeeTo"] != null && dr["InitFeeTo"] != DBNull.Value)
						{
							item.InitFeeTo = Convert.ToInt32(dr["InitFeeTo"]);
						}
						if (dr["FeePerKgTo"] != null && dr["FeePerKgTo"] != DBNull.Value)
						{
							item.FeePerKgTo = Convert.ToInt32(dr["FeePerKgTo"]);
						}
						if (dr["Less20To"] != null && dr["Less20To"] != DBNull.Value)
						{
							item.Less20To = Convert.ToInt32(dr["Less20To"]);
						}
						if (dr["Less50To"] != null && dr["Less50To"] != DBNull.Value)
						{
							item.Less50To = Convert.ToInt32(dr["Less50To"]);
						}
						if (dr["Less100To"] != null && dr["Less100To"] != DBNull.Value)
						{
							item.Less100To = Convert.ToInt32(dr["Less100To"]);
						}
						if (dr["Less300To"] != null && dr["Less300To"] != DBNull.Value)
						{
							item.Less300To = Convert.ToInt32(dr["Less300To"]);
						}
						if (dr["Less500To"] != null && dr["Less500To"] != DBNull.Value)
						{
							item.Less500To = Convert.ToInt32(dr["Less500To"]);
						}
						if (dr["Less1000To"] != null && dr["Less1000To"] != DBNull.Value)
						{
							item.Less1000To = Convert.ToInt32(dr["Less1000To"]);
						}
						if (dr["ElseFeeTo"] != null && dr["ElseFeeTo"] != DBNull.Value)
						{
							item.ElseFeeTo = Convert.ToInt32(dr["ElseFeeTo"]);
						}
						if (dr["InitFeeSys"] != null && dr["InitFeeSys"] != DBNull.Value)
						{
							item.InitFeeSys = Convert.ToInt32(dr["InitFeeSys"]);
						}
						if (dr["FeePerKgSys"] != null && dr["FeePerKgSys"] != DBNull.Value)
						{
							item.FeePerKgSys = Convert.ToInt32(dr["FeePerKgSys"]);
						}
						if (dr["Less20Sys"] != null && dr["Less20Sys"] != DBNull.Value)
						{
							item.Less20Sys = Convert.ToInt32(dr["Less20Sys"]);
						}
						if (dr["Less50Sys"] != null && dr["Less50Sys"] != DBNull.Value)
						{
							item.Less50Sys = Convert.ToInt32(dr["Less50Sys"]);
						}
						if (dr["Less100Sys"] != null && dr["Less100Sys"] != DBNull.Value)
						{
							item.Less100Sys = Convert.ToInt32(dr["Less100Sys"]);
						}
						if (dr["Less300Sys"] != null && dr["Less300Sys"] != DBNull.Value)
						{
							item.Less300Sys = Convert.ToInt32(dr["Less300Sys"]);
						}
						if (dr["Less500Sys"] != null && dr["Less500Sys"] != DBNull.Value)
						{
							item.Less500Sys = Convert.ToInt32(dr["Less500Sys"]);
						}
						if (dr["Less1000Sys"] != null && dr["Less1000Sys"] != DBNull.Value)
						{
							item.Less1000Sys = Convert.ToInt32(dr["Less1000Sys"]);
						}
						if (dr["ElseFeeSys"] != null && dr["ElseFeeSys"] != DBNull.Value)
						{
							item.ElseFeeSys = Convert.ToInt32(dr["ElseFeeSys"]);
						}
						if (dr["SystemFee"] != null && dr["SystemFee"] != DBNull.Value)
						{
							item.SystemFee = Convert.ToInt32(dr["SystemFee"]);
						}
						if (dr["InternalFee"] != null && dr["InternalFee"] != DBNull.Value)
						{
							item.InternalFee = Convert.ToInt32(dr["InternalFee"]);
						}
						if (dr["ExternalFee"] != null && dr["ExternalFee"] != DBNull.Value)
						{
							item.ExternalFee = Convert.ToInt32(dr["ExternalFee"]);
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

		public ExpFee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpFee] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpFee>(ds);
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
		/// Thêm mới ExpFee vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpFee _ExpFee)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpFee](MaBG, InitWeight, InitFee, FeePerKg, Less20, Less50, Less100, Less300, Less500, Less1000, ElseFee, InitFeeFrom, FeePerKgFrom, Less20From, Less50From, Less100From, Less300From, Less500From, Less1000From, ElseFeeFrom, InitFeeTo, FeePerKgTo, Less20To, Less50To, Less100To, Less300To, Less500To, Less1000To, ElseFeeTo, InitFeeSys, FeePerKgSys, Less20Sys, Less50Sys, Less100Sys, Less300Sys, Less500Sys, Less1000Sys, ElseFeeSys, SystemFee, InternalFee, ExternalFee) VALUES(@MaBG, @InitWeight, @InitFee, @FeePerKg, @Less20, @Less50, @Less100, @Less300, @Less500, @Less1000, @ElseFee, @InitFeeFrom, @FeePerKgFrom, @Less20From, @Less50From, @Less100From, @Less300From, @Less500From, @Less1000From, @ElseFeeFrom, @InitFeeTo, @FeePerKgTo, @Less20To, @Less50To, @Less100To, @Less300To, @Less500To, @Less1000To, @ElseFeeTo, @InitFeeSys, @FeePerKgSys, @Less20Sys, @Less50Sys, @Less100Sys, @Less300Sys, @Less500Sys, @Less1000Sys, @ElseFeeSys, @SystemFee, @InternalFee, @ExternalFee)", 
					"@MaBG",  _ExpFee.MaBG, 
					"@InitWeight",  _ExpFee.InitWeight, 
					"@InitFee",  _ExpFee.InitFee, 
					"@FeePerKg",  _ExpFee.FeePerKg, 
					"@Less20",  _ExpFee.Less20, 
					"@Less50",  _ExpFee.Less50, 
					"@Less100",  _ExpFee.Less100, 
					"@Less300",  _ExpFee.Less300, 
					"@Less500",  _ExpFee.Less500, 
					"@Less1000",  _ExpFee.Less1000, 
					"@ElseFee",  _ExpFee.ElseFee, 
					"@InitFeeFrom",  _ExpFee.InitFeeFrom, 
					"@FeePerKgFrom",  _ExpFee.FeePerKgFrom, 
					"@Less20From",  _ExpFee.Less20From, 
					"@Less50From",  _ExpFee.Less50From, 
					"@Less100From",  _ExpFee.Less100From, 
					"@Less300From",  _ExpFee.Less300From, 
					"@Less500From",  _ExpFee.Less500From, 
					"@Less1000From",  _ExpFee.Less1000From, 
					"@ElseFeeFrom",  _ExpFee.ElseFeeFrom, 
					"@InitFeeTo",  _ExpFee.InitFeeTo, 
					"@FeePerKgTo",  _ExpFee.FeePerKgTo, 
					"@Less20To",  _ExpFee.Less20To, 
					"@Less50To",  _ExpFee.Less50To, 
					"@Less100To",  _ExpFee.Less100To, 
					"@Less300To",  _ExpFee.Less300To, 
					"@Less500To",  _ExpFee.Less500To, 
					"@Less1000To",  _ExpFee.Less1000To, 
					"@ElseFeeTo",  _ExpFee.ElseFeeTo, 
					"@InitFeeSys",  _ExpFee.InitFeeSys, 
					"@FeePerKgSys",  _ExpFee.FeePerKgSys, 
					"@Less20Sys",  _ExpFee.Less20Sys, 
					"@Less50Sys",  _ExpFee.Less50Sys, 
					"@Less100Sys",  _ExpFee.Less100Sys, 
					"@Less300Sys",  _ExpFee.Less300Sys, 
					"@Less500Sys",  _ExpFee.Less500Sys, 
					"@Less1000Sys",  _ExpFee.Less1000Sys, 
					"@ElseFeeSys",  _ExpFee.ElseFeeSys, 
					"@SystemFee",  _ExpFee.SystemFee, 
					"@InternalFee",  _ExpFee.InternalFee, 
					"@ExternalFee",  _ExpFee.ExternalFee);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpFee vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpFee> _ExpFees)
		{
			foreach (ExpFee item in _ExpFees)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpFee _ExpFee, String MaBG)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpFee] SET MaBG=@MaBG, InitWeight=@InitWeight, InitFee=@InitFee, FeePerKg=@FeePerKg, Less20=@Less20, Less50=@Less50, Less100=@Less100, Less300=@Less300, Less500=@Less500, Less1000=@Less1000, ElseFee=@ElseFee, InitFeeFrom=@InitFeeFrom, FeePerKgFrom=@FeePerKgFrom, Less20From=@Less20From, Less50From=@Less50From, Less100From=@Less100From, Less300From=@Less300From, Less500From=@Less500From, Less1000From=@Less1000From, ElseFeeFrom=@ElseFeeFrom, InitFeeTo=@InitFeeTo, FeePerKgTo=@FeePerKgTo, Less20To=@Less20To, Less50To=@Less50To, Less100To=@Less100To, Less300To=@Less300To, Less500To=@Less500To, Less1000To=@Less1000To, ElseFeeTo=@ElseFeeTo, InitFeeSys=@InitFeeSys, FeePerKgSys=@FeePerKgSys, Less20Sys=@Less20Sys, Less50Sys=@Less50Sys, Less100Sys=@Less100Sys, Less300Sys=@Less300Sys, Less500Sys=@Less500Sys, Less1000Sys=@Less1000Sys, ElseFeeSys=@ElseFeeSys, SystemFee=@SystemFee, InternalFee=@InternalFee, ExternalFee=@ExternalFee WHERE MaBG=@MaBG", 
					"@MaBG",  _ExpFee.MaBG, 
					"@InitWeight",  _ExpFee.InitWeight, 
					"@InitFee",  _ExpFee.InitFee, 
					"@FeePerKg",  _ExpFee.FeePerKg, 
					"@Less20",  _ExpFee.Less20, 
					"@Less50",  _ExpFee.Less50, 
					"@Less100",  _ExpFee.Less100, 
					"@Less300",  _ExpFee.Less300, 
					"@Less500",  _ExpFee.Less500, 
					"@Less1000",  _ExpFee.Less1000, 
					"@ElseFee",  _ExpFee.ElseFee, 
					"@InitFeeFrom",  _ExpFee.InitFeeFrom, 
					"@FeePerKgFrom",  _ExpFee.FeePerKgFrom, 
					"@Less20From",  _ExpFee.Less20From, 
					"@Less50From",  _ExpFee.Less50From, 
					"@Less100From",  _ExpFee.Less100From, 
					"@Less300From",  _ExpFee.Less300From, 
					"@Less500From",  _ExpFee.Less500From, 
					"@Less1000From",  _ExpFee.Less1000From, 
					"@ElseFeeFrom",  _ExpFee.ElseFeeFrom, 
					"@InitFeeTo",  _ExpFee.InitFeeTo, 
					"@FeePerKgTo",  _ExpFee.FeePerKgTo, 
					"@Less20To",  _ExpFee.Less20To, 
					"@Less50To",  _ExpFee.Less50To, 
					"@Less100To",  _ExpFee.Less100To, 
					"@Less300To",  _ExpFee.Less300To, 
					"@Less500To",  _ExpFee.Less500To, 
					"@Less1000To",  _ExpFee.Less1000To, 
					"@ElseFeeTo",  _ExpFee.ElseFeeTo, 
					"@InitFeeSys",  _ExpFee.InitFeeSys, 
					"@FeePerKgSys",  _ExpFee.FeePerKgSys, 
					"@Less20Sys",  _ExpFee.Less20Sys, 
					"@Less50Sys",  _ExpFee.Less50Sys, 
					"@Less100Sys",  _ExpFee.Less100Sys, 
					"@Less300Sys",  _ExpFee.Less300Sys, 
					"@Less500Sys",  _ExpFee.Less500Sys, 
					"@Less1000Sys",  _ExpFee.Less1000Sys, 
					"@ElseFeeSys",  _ExpFee.ElseFeeSys, 
					"@SystemFee",  _ExpFee.SystemFee, 
					"@InternalFee",  _ExpFee.InternalFee, 
					"@ExternalFee",  _ExpFee.ExternalFee, 
					"@MaBG", MaBG);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpFee vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpFee _ExpFee)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpFee] SET InitWeight=@InitWeight, InitFee=@InitFee, FeePerKg=@FeePerKg, Less20=@Less20, Less50=@Less50, Less100=@Less100, Less300=@Less300, Less500=@Less500, Less1000=@Less1000, ElseFee=@ElseFee, InitFeeFrom=@InitFeeFrom, FeePerKgFrom=@FeePerKgFrom, Less20From=@Less20From, Less50From=@Less50From, Less100From=@Less100From, Less300From=@Less300From, Less500From=@Less500From, Less1000From=@Less1000From, ElseFeeFrom=@ElseFeeFrom, InitFeeTo=@InitFeeTo, FeePerKgTo=@FeePerKgTo, Less20To=@Less20To, Less50To=@Less50To, Less100To=@Less100To, Less300To=@Less300To, Less500To=@Less500To, Less1000To=@Less1000To, ElseFeeTo=@ElseFeeTo, InitFeeSys=@InitFeeSys, FeePerKgSys=@FeePerKgSys, Less20Sys=@Less20Sys, Less50Sys=@Less50Sys, Less100Sys=@Less100Sys, Less300Sys=@Less300Sys, Less500Sys=@Less500Sys, Less1000Sys=@Less1000Sys, ElseFeeSys=@ElseFeeSys, SystemFee=@SystemFee, InternalFee=@InternalFee, ExternalFee=@ExternalFee WHERE MaBG=@MaBG", 
					"@InitWeight",  _ExpFee.InitWeight, 
					"@InitFee",  _ExpFee.InitFee, 
					"@FeePerKg",  _ExpFee.FeePerKg, 
					"@Less20",  _ExpFee.Less20, 
					"@Less50",  _ExpFee.Less50, 
					"@Less100",  _ExpFee.Less100, 
					"@Less300",  _ExpFee.Less300, 
					"@Less500",  _ExpFee.Less500, 
					"@Less1000",  _ExpFee.Less1000, 
					"@ElseFee",  _ExpFee.ElseFee, 
					"@InitFeeFrom",  _ExpFee.InitFeeFrom, 
					"@FeePerKgFrom",  _ExpFee.FeePerKgFrom, 
					"@Less20From",  _ExpFee.Less20From, 
					"@Less50From",  _ExpFee.Less50From, 
					"@Less100From",  _ExpFee.Less100From, 
					"@Less300From",  _ExpFee.Less300From, 
					"@Less500From",  _ExpFee.Less500From, 
					"@Less1000From",  _ExpFee.Less1000From, 
					"@ElseFeeFrom",  _ExpFee.ElseFeeFrom, 
					"@InitFeeTo",  _ExpFee.InitFeeTo, 
					"@FeePerKgTo",  _ExpFee.FeePerKgTo, 
					"@Less20To",  _ExpFee.Less20To, 
					"@Less50To",  _ExpFee.Less50To, 
					"@Less100To",  _ExpFee.Less100To, 
					"@Less300To",  _ExpFee.Less300To, 
					"@Less500To",  _ExpFee.Less500To, 
					"@Less1000To",  _ExpFee.Less1000To, 
					"@ElseFeeTo",  _ExpFee.ElseFeeTo, 
					"@InitFeeSys",  _ExpFee.InitFeeSys, 
					"@FeePerKgSys",  _ExpFee.FeePerKgSys, 
					"@Less20Sys",  _ExpFee.Less20Sys, 
					"@Less50Sys",  _ExpFee.Less50Sys, 
					"@Less100Sys",  _ExpFee.Less100Sys, 
					"@Less300Sys",  _ExpFee.Less300Sys, 
					"@Less500Sys",  _ExpFee.Less500Sys, 
					"@Less1000Sys",  _ExpFee.Less1000Sys, 
					"@ElseFeeSys",  _ExpFee.ElseFeeSys, 
					"@SystemFee",  _ExpFee.SystemFee, 
					"@InternalFee",  _ExpFee.InternalFee, 
					"@ExternalFee",  _ExpFee.ExternalFee, 
					"@MaBG", _ExpFee.MaBG);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpFee> _ExpFees)
		{
			foreach (ExpFee item in _ExpFees)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpFee vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpFee _ExpFee, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpFee] SET MaBG=@MaBG, InitWeight=@InitWeight, InitFee=@InitFee, FeePerKg=@FeePerKg, Less20=@Less20, Less50=@Less50, Less100=@Less100, Less300=@Less300, Less500=@Less500, Less1000=@Less1000, ElseFee=@ElseFee, InitFeeFrom=@InitFeeFrom, FeePerKgFrom=@FeePerKgFrom, Less20From=@Less20From, Less50From=@Less50From, Less100From=@Less100From, Less300From=@Less300From, Less500From=@Less500From, Less1000From=@Less1000From, ElseFeeFrom=@ElseFeeFrom, InitFeeTo=@InitFeeTo, FeePerKgTo=@FeePerKgTo, Less20To=@Less20To, Less50To=@Less50To, Less100To=@Less100To, Less300To=@Less300To, Less500To=@Less500To, Less1000To=@Less1000To, ElseFeeTo=@ElseFeeTo, InitFeeSys=@InitFeeSys, FeePerKgSys=@FeePerKgSys, Less20Sys=@Less20Sys, Less50Sys=@Less50Sys, Less100Sys=@Less100Sys, Less300Sys=@Less300Sys, Less500Sys=@Less500Sys, Less1000Sys=@Less1000Sys, ElseFeeSys=@ElseFeeSys, SystemFee=@SystemFee, InternalFee=@InternalFee, ExternalFee=@ExternalFee "+ condition, 
					"@MaBG",  _ExpFee.MaBG, 
					"@InitWeight",  _ExpFee.InitWeight, 
					"@InitFee",  _ExpFee.InitFee, 
					"@FeePerKg",  _ExpFee.FeePerKg, 
					"@Less20",  _ExpFee.Less20, 
					"@Less50",  _ExpFee.Less50, 
					"@Less100",  _ExpFee.Less100, 
					"@Less300",  _ExpFee.Less300, 
					"@Less500",  _ExpFee.Less500, 
					"@Less1000",  _ExpFee.Less1000, 
					"@ElseFee",  _ExpFee.ElseFee, 
					"@InitFeeFrom",  _ExpFee.InitFeeFrom, 
					"@FeePerKgFrom",  _ExpFee.FeePerKgFrom, 
					"@Less20From",  _ExpFee.Less20From, 
					"@Less50From",  _ExpFee.Less50From, 
					"@Less100From",  _ExpFee.Less100From, 
					"@Less300From",  _ExpFee.Less300From, 
					"@Less500From",  _ExpFee.Less500From, 
					"@Less1000From",  _ExpFee.Less1000From, 
					"@ElseFeeFrom",  _ExpFee.ElseFeeFrom, 
					"@InitFeeTo",  _ExpFee.InitFeeTo, 
					"@FeePerKgTo",  _ExpFee.FeePerKgTo, 
					"@Less20To",  _ExpFee.Less20To, 
					"@Less50To",  _ExpFee.Less50To, 
					"@Less100To",  _ExpFee.Less100To, 
					"@Less300To",  _ExpFee.Less300To, 
					"@Less500To",  _ExpFee.Less500To, 
					"@Less1000To",  _ExpFee.Less1000To, 
					"@ElseFeeTo",  _ExpFee.ElseFeeTo, 
					"@InitFeeSys",  _ExpFee.InitFeeSys, 
					"@FeePerKgSys",  _ExpFee.FeePerKgSys, 
					"@Less20Sys",  _ExpFee.Less20Sys, 
					"@Less50Sys",  _ExpFee.Less50Sys, 
					"@Less100Sys",  _ExpFee.Less100Sys, 
					"@Less300Sys",  _ExpFee.Less300Sys, 
					"@Less500Sys",  _ExpFee.Less500Sys, 
					"@Less1000Sys",  _ExpFee.Less1000Sys, 
					"@ElseFeeSys",  _ExpFee.ElseFeeSys, 
					"@SystemFee",  _ExpFee.SystemFee, 
					"@InternalFee",  _ExpFee.InternalFee, 
					"@ExternalFee",  _ExpFee.ExternalFee);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpFee trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String MaBG)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpFee] WHERE MaBG=@MaBG",
					"@MaBG", MaBG);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpFee trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpFee _ExpFee)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpFee] WHERE MaBG=@MaBG",
					"@MaBG", _ExpFee.MaBG);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpFee trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpFee] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpFee trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpFee> _ExpFees)
		{
			foreach (ExpFee item in _ExpFees)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
