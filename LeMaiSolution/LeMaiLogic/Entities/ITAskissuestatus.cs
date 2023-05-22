using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ITAskissuestatus
	{
		/// <summary>
		/// Lấy một DataTable TaskIssueStatus từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable TaskIssueStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách TaskIssueStatus từ Database
		/// </summary>
		List<TaskIssueStatus> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách TaskIssueStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<TaskIssueStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<TaskIssueStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một TaskIssueStatus từ Database
		/// </summary>
		TaskIssueStatus GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một TaskIssueStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		TaskIssueStatus GetObjectCon(string schema, string condition, params Object[] parameters);
		TaskIssueStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới TaskIssueStatus vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, TaskIssueStatus _TaskIssueStatus);
		/// <summary>
		/// Insert danh sách đối tượng TaskIssueStatus vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<TaskIssueStatus> _TaskIssueStatuss);
		/// <summary>
		/// Cập nhật TaskIssueStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, TaskIssueStatus _TaskIssueStatus, Int32 Id);
		/// <summary>
		/// Cập nhật TaskIssueStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, TaskIssueStatus _TaskIssueStatus);
		/// <summary>
		/// Cập nhật danh sách TaskIssueStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<TaskIssueStatus> _TaskIssueStatuss);
		/// <summary>
		/// Cập nhật TaskIssueStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, TaskIssueStatus _TaskIssueStatus, string condition);
		/// <summary>
		/// Xóa TaskIssueStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa TaskIssueStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, TaskIssueStatus _TaskIssueStatus);
		/// <summary>
		/// Xóa TaskIssueStatus trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa TaskIssueStatus trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<TaskIssueStatus> _TaskIssueStatuss);
	}
}
