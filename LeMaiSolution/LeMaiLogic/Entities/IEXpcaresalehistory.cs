using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcaresalehistory
	{
		/// <summary>
		/// Lấy một DataTable ExpCareSaleHistory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCareSaleHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCareSaleHistory từ Database
		/// </summary>
		List<ExpCareSaleHistory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCareSaleHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCareSaleHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCareSaleHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCareSaleHistory từ Database
		/// </summary>
		ExpCareSaleHistory GetObject(string schema, String BillCode);
		/// <summary>
		/// Lấy một ExpCareSaleHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCareSaleHistory GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCareSaleHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCareSaleHistory vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCareSaleHistory _ExpCareSaleHistory);
		/// <summary>
		/// Insert danh sách đối tượng ExpCareSaleHistory vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCareSaleHistory> _ExpCareSaleHistorys);
		/// <summary>
		/// Cập nhật ExpCareSaleHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCareSaleHistory _ExpCareSaleHistory, String BillCode);
		/// <summary>
		/// Cập nhật ExpCareSaleHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCareSaleHistory _ExpCareSaleHistory);
		/// <summary>
		/// Cập nhật danh sách ExpCareSaleHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCareSaleHistory> _ExpCareSaleHistorys);
		/// <summary>
		/// Cập nhật ExpCareSaleHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCareSaleHistory _ExpCareSaleHistory, string condition);
		/// <summary>
		/// Xóa ExpCareSaleHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BillCode);
		/// <summary>
		/// Xóa ExpCareSaleHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCareSaleHistory _ExpCareSaleHistory);
		/// <summary>
		/// Xóa ExpCareSaleHistory trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCareSaleHistory trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCareSaleHistory> _ExpCareSaleHistorys);
	}
}
