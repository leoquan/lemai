using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSstepdef:IGSstepdef
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSstepdef(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsStepDef từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsStepDef]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsStepDef từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsStepDef] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsStepDef từ Database
		/// </summary>
		public List<GsStepDef> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsStepDef]");
				List<GsStepDef> items = new List<GsStepDef>();
				GsStepDef item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsStepDef();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["StepName"] != null && dr["StepName"] != DBNull.Value)
					{
						item.StepName = Convert.ToString(dr["StepName"]);
					}
					if (dr["FK_WorkFlowDef"] != null && dr["FK_WorkFlowDef"] != DBNull.Value)
					{
						item.FK_WorkFlowDef = Convert.ToString(dr["FK_WorkFlowDef"]);
					}
					if (dr["NextStep"] != null && dr["NextStep"] != DBNull.Value)
					{
						item.NextStep = Convert.ToString(dr["NextStep"]);
					}
					if (dr["BackStep"] != null && dr["BackStep"] != DBNull.Value)
					{
						item.BackStep = Convert.ToString(dr["BackStep"]);
					}
					if (dr["FK_AssignGroup"] != null && dr["FK_AssignGroup"] != DBNull.Value)
					{
						item.FK_AssignGroup = Convert.ToString(dr["FK_AssignGroup"]);
					}
					if (dr["FK_AssignAccount"] != null && dr["FK_AssignAccount"] != DBNull.Value)
					{
						item.FK_AssignAccount = Convert.ToString(dr["FK_AssignAccount"]);
					}
					if (dr["PriotyStep"] != null && dr["PriotyStep"] != DBNull.Value)
					{
						item.PriotyStep = Convert.ToInt32(dr["PriotyStep"]);
					}
					if (dr["FinalStep"] != null && dr["FinalStep"] != DBNull.Value)
					{
						item.FinalStep = Convert.ToBoolean(dr["FinalStep"]);
					}
					if (dr["DenyStep"] != null && dr["DenyStep"] != DBNull.Value)
					{
						item.DenyStep = Convert.ToBoolean(dr["DenyStep"]);
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
		/// Lấy danh sách GsStepDef từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsStepDef> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsStepDef] A "+ condition,  parameters);
				List<GsStepDef> items = new List<GsStepDef>();
				GsStepDef item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsStepDef();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["StepName"] != null && dr["StepName"] != DBNull.Value)
					{
						item.StepName = Convert.ToString(dr["StepName"]);
					}
					if (dr["FK_WorkFlowDef"] != null && dr["FK_WorkFlowDef"] != DBNull.Value)
					{
						item.FK_WorkFlowDef = Convert.ToString(dr["FK_WorkFlowDef"]);
					}
					if (dr["NextStep"] != null && dr["NextStep"] != DBNull.Value)
					{
						item.NextStep = Convert.ToString(dr["NextStep"]);
					}
					if (dr["BackStep"] != null && dr["BackStep"] != DBNull.Value)
					{
						item.BackStep = Convert.ToString(dr["BackStep"]);
					}
					if (dr["FK_AssignGroup"] != null && dr["FK_AssignGroup"] != DBNull.Value)
					{
						item.FK_AssignGroup = Convert.ToString(dr["FK_AssignGroup"]);
					}
					if (dr["FK_AssignAccount"] != null && dr["FK_AssignAccount"] != DBNull.Value)
					{
						item.FK_AssignAccount = Convert.ToString(dr["FK_AssignAccount"]);
					}
					if (dr["PriotyStep"] != null && dr["PriotyStep"] != DBNull.Value)
					{
						item.PriotyStep = Convert.ToInt32(dr["PriotyStep"]);
					}
					if (dr["FinalStep"] != null && dr["FinalStep"] != DBNull.Value)
					{
						item.FinalStep = Convert.ToBoolean(dr["FinalStep"]);
					}
					if (dr["DenyStep"] != null && dr["DenyStep"] != DBNull.Value)
					{
						item.DenyStep = Convert.ToBoolean(dr["DenyStep"]);
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

		public List<GsStepDef> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsStepDef] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsStepDef] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsStepDef>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsStepDef từ Database
		/// </summary>
		public GsStepDef GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsStepDef] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsStepDef item=new GsStepDef();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["StepName"] != null && dr["StepName"] != DBNull.Value)
						{
							item.StepName = Convert.ToString(dr["StepName"]);
						}
						if (dr["FK_WorkFlowDef"] != null && dr["FK_WorkFlowDef"] != DBNull.Value)
						{
							item.FK_WorkFlowDef = Convert.ToString(dr["FK_WorkFlowDef"]);
						}
						if (dr["NextStep"] != null && dr["NextStep"] != DBNull.Value)
						{
							item.NextStep = Convert.ToString(dr["NextStep"]);
						}
						if (dr["BackStep"] != null && dr["BackStep"] != DBNull.Value)
						{
							item.BackStep = Convert.ToString(dr["BackStep"]);
						}
						if (dr["FK_AssignGroup"] != null && dr["FK_AssignGroup"] != DBNull.Value)
						{
							item.FK_AssignGroup = Convert.ToString(dr["FK_AssignGroup"]);
						}
						if (dr["FK_AssignAccount"] != null && dr["FK_AssignAccount"] != DBNull.Value)
						{
							item.FK_AssignAccount = Convert.ToString(dr["FK_AssignAccount"]);
						}
						if (dr["PriotyStep"] != null && dr["PriotyStep"] != DBNull.Value)
						{
							item.PriotyStep = Convert.ToInt32(dr["PriotyStep"]);
						}
						if (dr["FinalStep"] != null && dr["FinalStep"] != DBNull.Value)
						{
							item.FinalStep = Convert.ToBoolean(dr["FinalStep"]);
						}
						if (dr["DenyStep"] != null && dr["DenyStep"] != DBNull.Value)
						{
							item.DenyStep = Convert.ToBoolean(dr["DenyStep"]);
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
		/// Lấy một GsStepDef đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsStepDef GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsStepDef] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsStepDef item=new GsStepDef();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["StepName"] != null && dr["StepName"] != DBNull.Value)
						{
							item.StepName = Convert.ToString(dr["StepName"]);
						}
						if (dr["FK_WorkFlowDef"] != null && dr["FK_WorkFlowDef"] != DBNull.Value)
						{
							item.FK_WorkFlowDef = Convert.ToString(dr["FK_WorkFlowDef"]);
						}
						if (dr["NextStep"] != null && dr["NextStep"] != DBNull.Value)
						{
							item.NextStep = Convert.ToString(dr["NextStep"]);
						}
						if (dr["BackStep"] != null && dr["BackStep"] != DBNull.Value)
						{
							item.BackStep = Convert.ToString(dr["BackStep"]);
						}
						if (dr["FK_AssignGroup"] != null && dr["FK_AssignGroup"] != DBNull.Value)
						{
							item.FK_AssignGroup = Convert.ToString(dr["FK_AssignGroup"]);
						}
						if (dr["FK_AssignAccount"] != null && dr["FK_AssignAccount"] != DBNull.Value)
						{
							item.FK_AssignAccount = Convert.ToString(dr["FK_AssignAccount"]);
						}
						if (dr["PriotyStep"] != null && dr["PriotyStep"] != DBNull.Value)
						{
							item.PriotyStep = Convert.ToInt32(dr["PriotyStep"]);
						}
						if (dr["FinalStep"] != null && dr["FinalStep"] != DBNull.Value)
						{
							item.FinalStep = Convert.ToBoolean(dr["FinalStep"]);
						}
						if (dr["DenyStep"] != null && dr["DenyStep"] != DBNull.Value)
						{
							item.DenyStep = Convert.ToBoolean(dr["DenyStep"]);
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

		public GsStepDef GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsStepDef] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsStepDef>(ds);
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
		/// Thêm mới GsStepDef vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsStepDef _GsStepDef)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsStepDef](Id, StepName, FK_WorkFlowDef, NextStep, BackStep, FK_AssignGroup, FK_AssignAccount, PriotyStep, FinalStep, DenyStep) VALUES(@Id, @StepName, @FK_WorkFlowDef, @NextStep, @BackStep, @FK_AssignGroup, @FK_AssignAccount, @PriotyStep, @FinalStep, @DenyStep)", 
					"@Id",  _GsStepDef.Id, 
					"@StepName",  _GsStepDef.StepName, 
					"@FK_WorkFlowDef",  _GsStepDef.FK_WorkFlowDef, 
					"@NextStep",  _GsStepDef.NextStep, 
					"@BackStep",  _GsStepDef.BackStep, 
					"@FK_AssignGroup",  _GsStepDef.FK_AssignGroup, 
					"@FK_AssignAccount",  _GsStepDef.FK_AssignAccount, 
					"@PriotyStep",  _GsStepDef.PriotyStep, 
					"@FinalStep",  _GsStepDef.FinalStep, 
					"@DenyStep",  _GsStepDef.DenyStep);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsStepDef vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsStepDef> _GsStepDefs)
		{
			foreach (GsStepDef item in _GsStepDefs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsStepDef vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsStepDef _GsStepDef, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsStepDef] SET Id=@Id, StepName=@StepName, FK_WorkFlowDef=@FK_WorkFlowDef, NextStep=@NextStep, BackStep=@BackStep, FK_AssignGroup=@FK_AssignGroup, FK_AssignAccount=@FK_AssignAccount, PriotyStep=@PriotyStep, FinalStep=@FinalStep, DenyStep=@DenyStep WHERE Id=@Id", 
					"@Id",  _GsStepDef.Id, 
					"@StepName",  _GsStepDef.StepName, 
					"@FK_WorkFlowDef",  _GsStepDef.FK_WorkFlowDef, 
					"@NextStep",  _GsStepDef.NextStep, 
					"@BackStep",  _GsStepDef.BackStep, 
					"@FK_AssignGroup",  _GsStepDef.FK_AssignGroup, 
					"@FK_AssignAccount",  _GsStepDef.FK_AssignAccount, 
					"@PriotyStep",  _GsStepDef.PriotyStep, 
					"@FinalStep",  _GsStepDef.FinalStep, 
					"@DenyStep",  _GsStepDef.DenyStep, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsStepDef vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsStepDef _GsStepDef)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsStepDef] SET StepName=@StepName, FK_WorkFlowDef=@FK_WorkFlowDef, NextStep=@NextStep, BackStep=@BackStep, FK_AssignGroup=@FK_AssignGroup, FK_AssignAccount=@FK_AssignAccount, PriotyStep=@PriotyStep, FinalStep=@FinalStep, DenyStep=@DenyStep WHERE Id=@Id", 
					"@StepName",  _GsStepDef.StepName, 
					"@FK_WorkFlowDef",  _GsStepDef.FK_WorkFlowDef, 
					"@NextStep",  _GsStepDef.NextStep, 
					"@BackStep",  _GsStepDef.BackStep, 
					"@FK_AssignGroup",  _GsStepDef.FK_AssignGroup, 
					"@FK_AssignAccount",  _GsStepDef.FK_AssignAccount, 
					"@PriotyStep",  _GsStepDef.PriotyStep, 
					"@FinalStep",  _GsStepDef.FinalStep, 
					"@DenyStep",  _GsStepDef.DenyStep, 
					"@Id", _GsStepDef.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsStepDef vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsStepDef> _GsStepDefs)
		{
			foreach (GsStepDef item in _GsStepDefs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsStepDef vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsStepDef _GsStepDef, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsStepDef] SET Id=@Id, StepName=@StepName, FK_WorkFlowDef=@FK_WorkFlowDef, NextStep=@NextStep, BackStep=@BackStep, FK_AssignGroup=@FK_AssignGroup, FK_AssignAccount=@FK_AssignAccount, PriotyStep=@PriotyStep, FinalStep=@FinalStep, DenyStep=@DenyStep "+ condition, 
					"@Id",  _GsStepDef.Id, 
					"@StepName",  _GsStepDef.StepName, 
					"@FK_WorkFlowDef",  _GsStepDef.FK_WorkFlowDef, 
					"@NextStep",  _GsStepDef.NextStep, 
					"@BackStep",  _GsStepDef.BackStep, 
					"@FK_AssignGroup",  _GsStepDef.FK_AssignGroup, 
					"@FK_AssignAccount",  _GsStepDef.FK_AssignAccount, 
					"@PriotyStep",  _GsStepDef.PriotyStep, 
					"@FinalStep",  _GsStepDef.FinalStep, 
					"@DenyStep",  _GsStepDef.DenyStep);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsStepDef trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsStepDef] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsStepDef trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsStepDef _GsStepDef)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsStepDef] WHERE Id=@Id",
					"@Id", _GsStepDef.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsStepDef trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsStepDef] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsStepDef trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsStepDef> _GsStepDefs)
		{
			foreach (GsStepDef item in _GsStepDefs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
