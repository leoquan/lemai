using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ITAskactionhistory
	{
		/// <summary>
		/// Lấy một DataTable TaskActionHistory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable TaskActionHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách TaskActionHistory từ Database
		/// </summary>
		List<TaskActionHistory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách TaskActionHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<TaskActionHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<TaskActionHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một TaskActionHistory từ Database
		/// </summary>
		TaskActionHistory GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một TaskActionHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		TaskActionHistory GetObjectCon(string schema, string condition, params Object[] parameters);
		TaskActionHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới TaskActionHistory vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, TaskActionHistory _TaskActionHistory);
		/// <summary>
		/// Insert danh sách đối tượng TaskActionHistory vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<TaskActionHistory> _TaskActionHistorys);
		/// <summary>
		/// Cập nhật TaskActionHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, TaskActionHistory _TaskActionHistory, String Id);
		/// <summary>
		/// Cập nhật TaskActionHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, TaskActionHistory _TaskActionHistory);
		/// <summary>
		/// Cập nhật danh sách TaskActionHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<TaskActionHistory> _TaskActionHistorys);
		/// <summary>
		/// Cập nhật TaskActionHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, TaskActionHistory _TaskActionHistory, string condition);
		/// <summary>
		/// Xóa TaskActionHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa TaskActionHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, TaskActionHistory _TaskActionHistory);
		/// <summary>
		/// Xóa TaskActionHistory trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa TaskActionHistory trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<TaskActionHistory> _TaskActionHistorys);
	}
}
