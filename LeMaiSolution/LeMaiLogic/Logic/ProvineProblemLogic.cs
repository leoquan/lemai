using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
	public partial class ProvineProblemLogic : BaseLogic
	{
		public ProvineProblemLogic(BaseLogicConnectionData data) : base(data)
		{
		}
		/// <summary>
		/// Get all view_ExpProviceProblem List
		/// </summary>
		/// <returns></returns>
		public async Task<List<view_ExpProviceProblem>> GetList()
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				return dc.VIewexpproviceproblem.GetListObject(base.ConnectionData.Schema);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				dc.Close();
			}
		}
		/// <summary>
		/// Tìm view_ExpProviceProblem theo keyword
		/// </summary>
		/// <returns></returns>
		public async Task<List<view_ExpProviceProblem>> GetList(string keyword)
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				// Search
				string condition = string.Empty;
				if (!string.IsNullOrEmpty(keyword))
				{
					condition += " WHERE ProvinceName like N'%" + keyword + "%' | KeyWord like N'%" + keyword + "%' | ";
				}
				condition = condition.Trim();
				condition = condition.TrimEnd('|');
				condition = condition.Replace("|", "OR");
				condition = condition + " ORDER BY ProvinceName asc";
				return dc.VIewexpproviceproblem.GetListObjectCon(base.ConnectionData.Schema, condition);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				dc.Close();
			}
		}
		/// <summary>
		/// Danh sách view_ExpProviceProblem theo giới hạn keyword và page
		/// </summary>
		/// <param name="keyword">Search Keyword</param>
		/// <param name="page">Số trang hiển thị</param>
		/// <returns></returns>
		public async Task<List<view_ExpProviceProblem>> GetPage(string keyword, int? page)
		{
			try
			{
				int take = 10;
				int skip = 0;
				// Có tham số phân trang
				if (page != null)
				{
					skip = ((int)page - 1) * take;
					skip = skip < 0 ? 0 : skip;
				}
				return await GetPage(keyword, take, skip);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		/// <summary>
		/// Danh sách view_ExpProviceProblem theo giới hạn keyword, Take, Skip
		/// </summary>
		/// <param name="keyword">Search Keyword</param>
		/// <param name="Take">Số dòng lấy dữ liệu</param>
		/// <param name="Skip">Số dòng bỏ qua</param>
		/// <returns></returns>
		public async Task<List<view_ExpProviceProblem>> GetPage(string keyword, int Take, int Skip)
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				// Search
				string condition = string.Empty;
				if (!string.IsNullOrEmpty(keyword))
				{
					condition += " WHERE ProvinceName like N'%" + keyword + "%' | KeyWord like N'%" + keyword + "%' | ";
				}
				condition = condition.Trim();
				condition = condition.TrimEnd('|');
				condition = condition.Replace("|", "OR");
				condition = condition + " ORDER BY ProvinceName asc";
				return dc.VIewexpproviceproblem.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				dc.Close();
			}
		}
		/// <summary>
		/// Tuple Danh sách view_ExpProviceProblem theo giới hạn keyword, Take, Skip và số dòng dữ liệu
		/// </summary>
		/// <param name="keyword">Search Keyword</param>
		/// <param name="Take">Số dòng lấy dữ liệu</param>
		/// <param name="Skip">Số dòng bỏ qua</param>
		/// <returns></returns>
		public async Task<Tuple<List<view_ExpProviceProblem>, int>> GetTuplePage(string keyword, int Take, int Skip)
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				var list = dc.VIewexpproviceproblem.GetListObject(base.ConnectionData.Schema);
				var data = await GetPage(keyword, Take, Skip);
				return new Tuple<List<view_ExpProviceProblem>, int>(data, list.Count);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				dc.Close();
			}
		}
		/// <summary>
		/// Get List of SameProvineProblemLogic
		/// </summary>
		/// <param name="Id">Id Of ExpProviceProblem</param>
		/// <returns></returns>
		public async Task<List<view_ExpProviceProblem>> GetSameList(String Id)
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				int take = 10;
				return dc.VIewexpproviceproblem.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				dc.Close();
			}
		}
		/// <summary>
		/// Get view_ExpProviceProblem Object
		/// </summary>
		/// <param name="Id">Id Of ExpProviceProblem</param>
		/// <returns></returns>
		public async Task<view_ExpProviceProblem> GetDetails(String Id)
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				return dc.VIewexpproviceproblem.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id );
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				dc.Close();
			}
		}
		/// <summary>
		/// Create a ExpProviceProblem Object into Database
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task<ExpProviceProblem> Create(ProvineProblemLogicInputDto input)
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				ExpProviceProblem item = new ExpProviceProblem();
				
				// Mapping Prop
				item.Id = Guid.NewGuid().ToString();
			item.ProvinceName = input.ProvinceName;
			item.KeyWord = input.KeyWord;

				//Change Database
				dc.EXpproviceproblem.InsertOnSubmit(base.ConnectionData.Schema, item);
				dc.SubmitChanges();
				return item;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				dc.Close();
			}
		}
		/// <summary>
		/// Update ExpProviceProblem 
		/// </summary>
		/// <returns></returns>
		public async Task<bool> Update(String Id, ProvineProblemLogicInputDto input)
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				ExpProviceProblem item = dc.EXpproviceproblem.GetObject(base.ConnectionData.Schema, Id);
				if (item != null)
				{
					// Mapping Prop
			item.ProvinceName = input.ProvinceName;
			item.KeyWord = input.KeyWord;

					//Change Database
					dc.EXpproviceproblem.Update(base.ConnectionData.Schema, item);
					dc.SubmitChanges();
					return true;
				}
				else
				{
					return false;
				}	
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				dc.Close();
			}
		}
		/// <summary>
		/// Delete ExpProviceProblem
		/// </summary>
		public async Task<bool> Delete(String Id)
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				ExpProviceProblem item = dc.EXpproviceproblem.GetObject(base.ConnectionData.Schema, Id);
				if (item != null)
				{
					//Delete master
					dc.EXpproviceproblem.DeleteOnSubmit(base.ConnectionData.Schema, Id);
					dc.SubmitChanges();
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				dc.Close();
			}
		}
		/// <summary>
		/// Create Or Update Master Only
		/// </summary>
		/// <param name="input"></param>
		/// <returns>view_ExpProviceProblem</returns>
		public async Task<view_ExpProviceProblem> CreateOrUpdateMasterOnly(String Id, ProvineProblemLogicInputDto input)
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				bool insert = false;
				ExpProviceProblem item = dc.EXpproviceproblem.GetObject(base.ConnectionData.Schema, Id);
				if (item == null)
				{
					insert = true;
					item = new ExpProviceProblem();
					item.Id = Guid.NewGuid().ToString();
				}
				// Update Value
				item.ProvinceName = input.ProvinceName;
				item.KeyWord = input.KeyWord;
				if (insert)
				{
					dc.EXpproviceproblem.InsertOnSubmit(base.ConnectionData.Schema, item);
				}
				else
				{
					dc.EXpproviceproblem.Update(base.ConnectionData.Schema, item);
				}

				// Get lại giá trị của Master
				view_ExpProviceProblem returnItem  = dc.VIewexpproviceproblem.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id );
				// Change database
				dc.SubmitChanges();
				return returnItem;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				dc.Close();
			}
		}
	}
}

