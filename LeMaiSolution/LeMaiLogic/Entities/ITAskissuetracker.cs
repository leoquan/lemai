using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ITAskissuetracker
	{
		/// <summary>
		/// Lấy một DataTable TaskIssueTracker từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable TaskIssueTracker từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách TaskIssueTracker từ Database
		/// </summary>
		List<TaskIssueTracker> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách TaskIssueTracker từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<TaskIssueTracker> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<TaskIssueTracker> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một TaskIssueTracker từ Database
		/// </summary>
		TaskIssueTracker GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một TaskIssueTracker đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		TaskIssueTracker GetObjectCon(string schema, string condition, params Object[] parameters);
		TaskIssueTracker GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới TaskIssueTracker vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, TaskIssueTracker _TaskIssueTracker);
		/// <summary>
		/// Insert danh sách đối tượng TaskIssueTracker vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<TaskIssueTracker> _TaskIssueTrackers);
		/// <summary>
		/// Cập nhật TaskIssueTracker vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, TaskIssueTracker _TaskIssueTracker, Int32 Id);
		/// <summary>
		/// Cập nhật TaskIssueTracker vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, TaskIssueTracker _TaskIssueTracker);
		/// <summary>
		/// Cập nhật danh sách TaskIssueTracker vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<TaskIssueTracker> _TaskIssueTrackers);
		/// <summary>
		/// Cập nhật TaskIssueTracker vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, TaskIssueTracker _TaskIssueTracker, string condition);
		/// <summary>
		/// Xóa TaskIssueTracker trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa TaskIssueTracker trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, TaskIssueTracker _TaskIssueTracker);
		/// <summary>
		/// Xóa TaskIssueTracker trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa TaskIssueTracker trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<TaskIssueTracker> _TaskIssueTrackers);
	}
}
