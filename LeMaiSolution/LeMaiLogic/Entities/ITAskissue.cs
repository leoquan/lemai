using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ITAskissue
	{
		/// <summary>
		/// Lấy một DataTable TaskIssue từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable TaskIssue từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách TaskIssue từ Database
		/// </summary>
		List<TaskIssue> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách TaskIssue từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<TaskIssue> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<TaskIssue> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một TaskIssue từ Database
		/// </summary>
		TaskIssue GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một TaskIssue đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		TaskIssue GetObjectCon(string schema, string condition, params Object[] parameters);
		TaskIssue GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới TaskIssue vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, TaskIssue _TaskIssue);
		/// <summary>
		/// Insert danh sách đối tượng TaskIssue vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<TaskIssue> _TaskIssues);
		/// <summary>
		/// Cập nhật TaskIssue vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, TaskIssue _TaskIssue, String Id);
		/// <summary>
		/// Cập nhật TaskIssue vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, TaskIssue _TaskIssue);
		/// <summary>
		/// Cập nhật danh sách TaskIssue vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<TaskIssue> _TaskIssues);
		/// <summary>
		/// Cập nhật TaskIssue vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, TaskIssue _TaskIssue, string condition);
		/// <summary>
		/// Xóa TaskIssue trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa TaskIssue trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, TaskIssue _TaskIssue);
		/// <summary>
		/// Xóa TaskIssue trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa TaskIssue trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<TaskIssue> _TaskIssues);
	}
}
