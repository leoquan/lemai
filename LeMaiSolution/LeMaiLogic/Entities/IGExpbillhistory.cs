using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpbillhistory
	{
		/// <summary>
		/// Lấy một DataTable GExpBillHistory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpBillHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpBillHistory từ Database
		/// </summary>
		List<GExpBillHistory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpBillHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpBillHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpBillHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpBillHistory từ Database
		/// </summary>
		GExpBillHistory GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpBillHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpBillHistory GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpBillHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpBillHistory vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpBillHistory _GExpBillHistory);
		/// <summary>
		/// Insert danh sách đối tượng GExpBillHistory vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpBillHistory> _GExpBillHistorys);
		/// <summary>
		/// Cập nhật GExpBillHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpBillHistory _GExpBillHistory, String Id);
		/// <summary>
		/// Cập nhật GExpBillHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpBillHistory _GExpBillHistory);
		/// <summary>
		/// Cập nhật danh sách GExpBillHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpBillHistory> _GExpBillHistorys);
		/// <summary>
		/// Cập nhật GExpBillHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpBillHistory _GExpBillHistory, string condition);
		/// <summary>
		/// Xóa GExpBillHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpBillHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpBillHistory _GExpBillHistory);
		/// <summary>
		/// Xóa GExpBillHistory trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpBillHistory trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpBillHistory> _GExpBillHistorys);
	}
}
