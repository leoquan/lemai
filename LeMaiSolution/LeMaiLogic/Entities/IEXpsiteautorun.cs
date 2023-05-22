using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpsiteautorun
	{
		/// <summary>
		/// Lấy một DataTable ExpSiteAutoRun từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpSiteAutoRun từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpSiteAutoRun từ Database
		/// </summary>
		List<ExpSiteAutoRun> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpSiteAutoRun từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpSiteAutoRun> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpSiteAutoRun> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpSiteAutoRun từ Database
		/// </summary>
		ExpSiteAutoRun GetObject(string schema, String SiteId);
		/// <summary>
		/// Lấy một ExpSiteAutoRun đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpSiteAutoRun GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpSiteAutoRun GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpSiteAutoRun vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpSiteAutoRun _ExpSiteAutoRun);
		/// <summary>
		/// Insert danh sách đối tượng ExpSiteAutoRun vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpSiteAutoRun> _ExpSiteAutoRuns);
		/// <summary>
		/// Cập nhật ExpSiteAutoRun vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpSiteAutoRun _ExpSiteAutoRun, String SiteId);
		/// <summary>
		/// Cập nhật ExpSiteAutoRun vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpSiteAutoRun _ExpSiteAutoRun);
		/// <summary>
		/// Cập nhật danh sách ExpSiteAutoRun vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpSiteAutoRun> _ExpSiteAutoRuns);
		/// <summary>
		/// Cập nhật ExpSiteAutoRun vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpSiteAutoRun _ExpSiteAutoRun, string condition);
		/// <summary>
		/// Xóa ExpSiteAutoRun trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String SiteId);
		/// <summary>
		/// Xóa ExpSiteAutoRun trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpSiteAutoRun _ExpSiteAutoRun);
		/// <summary>
		/// Xóa ExpSiteAutoRun trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpSiteAutoRun trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpSiteAutoRun> _ExpSiteAutoRuns);
	}
}
