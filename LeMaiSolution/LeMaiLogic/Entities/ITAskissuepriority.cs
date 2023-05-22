using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ITAskissuepriority
	{
		/// <summary>
		/// Lấy một DataTable TaskIssuePriority từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable TaskIssuePriority từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách TaskIssuePriority từ Database
		/// </summary>
		List<TaskIssuePriority> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách TaskIssuePriority từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<TaskIssuePriority> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<TaskIssuePriority> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một TaskIssuePriority từ Database
		/// </summary>
		TaskIssuePriority GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một TaskIssuePriority đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		TaskIssuePriority GetObjectCon(string schema, string condition, params Object[] parameters);
		TaskIssuePriority GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới TaskIssuePriority vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, TaskIssuePriority _TaskIssuePriority);
		/// <summary>
		/// Insert danh sách đối tượng TaskIssuePriority vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<TaskIssuePriority> _TaskIssuePrioritys);
		/// <summary>
		/// Cập nhật TaskIssuePriority vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, TaskIssuePriority _TaskIssuePriority, Int32 Id);
		/// <summary>
		/// Cập nhật TaskIssuePriority vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, TaskIssuePriority _TaskIssuePriority);
		/// <summary>
		/// Cập nhật danh sách TaskIssuePriority vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<TaskIssuePriority> _TaskIssuePrioritys);
		/// <summary>
		/// Cập nhật TaskIssuePriority vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, TaskIssuePriority _TaskIssuePriority, string condition);
		/// <summary>
		/// Xóa TaskIssuePriority trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa TaskIssuePriority trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, TaskIssuePriority _TaskIssuePriority);
		/// <summary>
		/// Xóa TaskIssuePriority trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa TaskIssuePriority trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<TaskIssuePriority> _TaskIssuePrioritys);
	}
}
