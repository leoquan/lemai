using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpconsignmenthistory
	{
		/// <summary>
		/// Lấy một DataTable ExpConsignmentHistory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpConsignmentHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpConsignmentHistory từ Database
		/// </summary>
		List<ExpConsignmentHistory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpConsignmentHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpConsignmentHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpConsignmentHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpConsignmentHistory từ Database
		/// </summary>
		ExpConsignmentHistory GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpConsignmentHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpConsignmentHistory GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpConsignmentHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpConsignmentHistory vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpConsignmentHistory _ExpConsignmentHistory);
		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentHistory vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpConsignmentHistory> _ExpConsignmentHistorys);
		/// <summary>
		/// Cập nhật ExpConsignmentHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpConsignmentHistory _ExpConsignmentHistory, String Id);
		/// <summary>
		/// Cập nhật ExpConsignmentHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpConsignmentHistory _ExpConsignmentHistory);
		/// <summary>
		/// Cập nhật danh sách ExpConsignmentHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpConsignmentHistory> _ExpConsignmentHistorys);
		/// <summary>
		/// Cập nhật ExpConsignmentHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpConsignmentHistory _ExpConsignmentHistory, string condition);
		/// <summary>
		/// Xóa ExpConsignmentHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpConsignmentHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpConsignmentHistory _ExpConsignmentHistory);
		/// <summary>
		/// Xóa ExpConsignmentHistory trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpConsignmentHistory trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpConsignmentHistory> _ExpConsignmentHistorys);
	}
}
