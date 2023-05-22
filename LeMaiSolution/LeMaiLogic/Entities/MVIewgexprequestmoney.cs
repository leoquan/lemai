using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexprequestmoney:IVIewgexprequestmoney
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexprequestmoney(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpRequestMoney từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpRequestMoney]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpRequestMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpRequestMoney] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpRequestMoney từ Database
		/// </summary>
		public List<view_GExpRequestMoney> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpRequestMoney]");
				List<view_GExpRequestMoney> items = new List<view_GExpRequestMoney>();
				view_GExpRequestMoney item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpRequestMoney();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_RequestAccount"] != null && dr["FK_RequestAccount"] != DBNull.Value)
					{
						item.FK_RequestAccount = Convert.ToString(dr["FK_RequestAccount"]);
					}
					if (dr["FK_PostResponse"] != null && dr["FK_PostResponse"] != DBNull.Value)
					{
						item.FK_PostResponse = Convert.ToString(dr["FK_PostResponse"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToInt32(dr["SoTien"]);
					}
					if (dr["RequestCode"] != null && dr["RequestCode"] != DBNull.Value)
					{
						item.RequestCode = Convert.ToString(dr["RequestCode"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsConfirm"] != null && dr["IsConfirm"] != DBNull.Value)
					{
						item.IsConfirm = Convert.ToBoolean(dr["IsConfirm"]);
					}
					if (dr["BankAccount"] != null && dr["BankAccount"] != DBNull.Value)
					{
						item.BankAccount = Convert.ToString(dr["BankAccount"]);
					}
					if (dr["BankOwner"] != null && dr["BankOwner"] != DBNull.Value)
					{
						item.BankOwner = Convert.ToString(dr["BankOwner"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["ConfirmDate"] != null && dr["ConfirmDate"] != DBNull.Value)
					{
						item.ConfirmDate = Convert.ToDateTime(dr["ConfirmDate"]);
					}
					if (dr["ReSoTien"] != null && dr["ReSoTien"] != DBNull.Value)
					{
						item.ReSoTien = Convert.ToInt32(dr["ReSoTien"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["DaiLyYeuCau"] != null && dr["DaiLyYeuCau"] != DBNull.Value)
					{
						item.DaiLyYeuCau = Convert.ToString(dr["DaiLyYeuCau"]);
					}
					if (dr["NguoiYeuCau"] != null && dr["NguoiYeuCau"] != DBNull.Value)
					{
						item.NguoiYeuCau = Convert.ToString(dr["NguoiYeuCau"]);
					}
					if (dr["NguoiXuLy"] != null && dr["NguoiXuLy"] != DBNull.Value)
					{
						item.NguoiXuLy = Convert.ToString(dr["NguoiXuLy"]);
					}
					if (dr["DaiLyXuLy"] != null && dr["DaiLyXuLy"] != DBNull.Value)
					{
						item.DaiLyXuLy = Convert.ToString(dr["DaiLyXuLy"]);
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
		/// Lấy danh sách view_GExpRequestMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpRequestMoney> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpRequestMoney] A "+ condition,  parameters);
				List<view_GExpRequestMoney> items = new List<view_GExpRequestMoney>();
				view_GExpRequestMoney item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpRequestMoney();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_RequestAccount"] != null && dr["FK_RequestAccount"] != DBNull.Value)
					{
						item.FK_RequestAccount = Convert.ToString(dr["FK_RequestAccount"]);
					}
					if (dr["FK_PostResponse"] != null && dr["FK_PostResponse"] != DBNull.Value)
					{
						item.FK_PostResponse = Convert.ToString(dr["FK_PostResponse"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToInt32(dr["SoTien"]);
					}
					if (dr["RequestCode"] != null && dr["RequestCode"] != DBNull.Value)
					{
						item.RequestCode = Convert.ToString(dr["RequestCode"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["IsConfirm"] != null && dr["IsConfirm"] != DBNull.Value)
					{
						item.IsConfirm = Convert.ToBoolean(dr["IsConfirm"]);
					}
					if (dr["BankAccount"] != null && dr["BankAccount"] != DBNull.Value)
					{
						item.BankAccount = Convert.ToString(dr["BankAccount"]);
					}
					if (dr["BankOwner"] != null && dr["BankOwner"] != DBNull.Value)
					{
						item.BankOwner = Convert.ToString(dr["BankOwner"]);
					}
					if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
					{
						item.BankName = Convert.ToString(dr["BankName"]);
					}
					if (dr["ConfirmDate"] != null && dr["ConfirmDate"] != DBNull.Value)
					{
						item.ConfirmDate = Convert.ToDateTime(dr["ConfirmDate"]);
					}
					if (dr["ReSoTien"] != null && dr["ReSoTien"] != DBNull.Value)
					{
						item.ReSoTien = Convert.ToInt32(dr["ReSoTien"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["DaiLyYeuCau"] != null && dr["DaiLyYeuCau"] != DBNull.Value)
					{
						item.DaiLyYeuCau = Convert.ToString(dr["DaiLyYeuCau"]);
					}
					if (dr["NguoiYeuCau"] != null && dr["NguoiYeuCau"] != DBNull.Value)
					{
						item.NguoiYeuCau = Convert.ToString(dr["NguoiYeuCau"]);
					}
					if (dr["NguoiXuLy"] != null && dr["NguoiXuLy"] != DBNull.Value)
					{
						item.NguoiXuLy = Convert.ToString(dr["NguoiXuLy"]);
					}
					if (dr["DaiLyXuLy"] != null && dr["DaiLyXuLy"] != DBNull.Value)
					{
						item.DaiLyXuLy = Convert.ToString(dr["DaiLyXuLy"]);
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

		public List<view_GExpRequestMoney> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpRequestMoney] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpRequestMoney] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpRequestMoney>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpRequestMoney đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpRequestMoney GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpRequestMoney] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpRequestMoney item=new view_GExpRequestMoney();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["FK_RequestAccount"] != null && dr["FK_RequestAccount"] != DBNull.Value)
						{
							item.FK_RequestAccount = Convert.ToString(dr["FK_RequestAccount"]);
						}
						if (dr["FK_PostResponse"] != null && dr["FK_PostResponse"] != DBNull.Value)
						{
							item.FK_PostResponse = Convert.ToString(dr["FK_PostResponse"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
						{
							item.SoTien = Convert.ToInt32(dr["SoTien"]);
						}
						if (dr["RequestCode"] != null && dr["RequestCode"] != DBNull.Value)
						{
							item.RequestCode = Convert.ToString(dr["RequestCode"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["IsConfirm"] != null && dr["IsConfirm"] != DBNull.Value)
						{
							item.IsConfirm = Convert.ToBoolean(dr["IsConfirm"]);
						}
						if (dr["BankAccount"] != null && dr["BankAccount"] != DBNull.Value)
						{
							item.BankAccount = Convert.ToString(dr["BankAccount"]);
						}
						if (dr["BankOwner"] != null && dr["BankOwner"] != DBNull.Value)
						{
							item.BankOwner = Convert.ToString(dr["BankOwner"]);
						}
						if (dr["BankName"] != null && dr["BankName"] != DBNull.Value)
						{
							item.BankName = Convert.ToString(dr["BankName"]);
						}
						if (dr["ConfirmDate"] != null && dr["ConfirmDate"] != DBNull.Value)
						{
							item.ConfirmDate = Convert.ToDateTime(dr["ConfirmDate"]);
						}
						if (dr["ReSoTien"] != null && dr["ReSoTien"] != DBNull.Value)
						{
							item.ReSoTien = Convert.ToInt32(dr["ReSoTien"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["DaiLyYeuCau"] != null && dr["DaiLyYeuCau"] != DBNull.Value)
						{
							item.DaiLyYeuCau = Convert.ToString(dr["DaiLyYeuCau"]);
						}
						if (dr["NguoiYeuCau"] != null && dr["NguoiYeuCau"] != DBNull.Value)
						{
							item.NguoiYeuCau = Convert.ToString(dr["NguoiYeuCau"]);
						}
						if (dr["NguoiXuLy"] != null && dr["NguoiXuLy"] != DBNull.Value)
						{
							item.NguoiXuLy = Convert.ToString(dr["NguoiXuLy"]);
						}
						if (dr["DaiLyXuLy"] != null && dr["DaiLyXuLy"] != DBNull.Value)
						{
							item.DaiLyXuLy = Convert.ToString(dr["DaiLyXuLy"]);
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

		public view_GExpRequestMoney GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpRequestMoney] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpRequestMoney>(ds);
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
	}
}
