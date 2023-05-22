using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcheckbalancedetail
	{
		/// <summary>
		/// Lấy một DataTable ExpCheckBalanceDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCheckBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCheckBalanceDetail từ Database
		/// </summary>
		List<ExpCheckBalanceDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCheckBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCheckBalanceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCheckBalanceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCheckBalanceDetail từ Database
		/// </summary>
		ExpCheckBalanceDetail GetObject(string schema, String BalanceType, String FK_CheckBalance);
		/// <summary>
		/// Lấy một ExpCheckBalanceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCheckBalanceDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCheckBalanceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCheckBalanceDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCheckBalanceDetail _ExpCheckBalanceDetail);
		/// <summary>
		/// Insert danh sách đối tượng ExpCheckBalanceDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCheckBalanceDetail> _ExpCheckBalanceDetails);
		/// <summary>
		/// Cập nhật ExpCheckBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCheckBalanceDetail _ExpCheckBalanceDetail, String BalanceType, String FK_CheckBalance);
		/// <summary>
		/// Cập nhật ExpCheckBalanceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCheckBalanceDetail _ExpCheckBalanceDetail);
		/// <summary>
		/// Cập nhật danh sách ExpCheckBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCheckBalanceDetail> _ExpCheckBalanceDetails);
		/// <summary>
		/// Cập nhật ExpCheckBalanceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCheckBalanceDetail _ExpCheckBalanceDetail, string condition);
		/// <summary>
		/// Xóa ExpCheckBalanceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BalanceType, String FK_CheckBalance);
		/// <summary>
		/// Xóa ExpCheckBalanceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCheckBalanceDetail _ExpCheckBalanceDetail);
		/// <summary>
		/// Xóa ExpCheckBalanceDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCheckBalanceDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCheckBalanceDetail> _ExpCheckBalanceDetails);
	}
}
