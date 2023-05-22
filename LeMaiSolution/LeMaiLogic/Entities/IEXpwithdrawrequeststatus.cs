using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpwithdrawrequeststatus
	{
		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequestStatus từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequestStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpWithdrawRequestStatus từ Database
		/// </summary>
		List<ExpWithdrawRequestStatus> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpWithdrawRequestStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpWithdrawRequestStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpWithdrawRequestStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpWithdrawRequestStatus từ Database
		/// </summary>
		ExpWithdrawRequestStatus GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpWithdrawRequestStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpWithdrawRequestStatus GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpWithdrawRequestStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpWithdrawRequestStatus vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpWithdrawRequestStatus _ExpWithdrawRequestStatus);
		/// <summary>
		/// Insert danh sách đối tượng ExpWithdrawRequestStatus vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpWithdrawRequestStatus> _ExpWithdrawRequestStatuss);
		/// <summary>
		/// Cập nhật ExpWithdrawRequestStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpWithdrawRequestStatus _ExpWithdrawRequestStatus, String Id);
		/// <summary>
		/// Cập nhật ExpWithdrawRequestStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpWithdrawRequestStatus _ExpWithdrawRequestStatus);
		/// <summary>
		/// Cập nhật danh sách ExpWithdrawRequestStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpWithdrawRequestStatus> _ExpWithdrawRequestStatuss);
		/// <summary>
		/// Cập nhật ExpWithdrawRequestStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpWithdrawRequestStatus _ExpWithdrawRequestStatus, string condition);
		/// <summary>
		/// Xóa ExpWithdrawRequestStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpWithdrawRequestStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpWithdrawRequestStatus _ExpWithdrawRequestStatus);
		/// <summary>
		/// Xóa ExpWithdrawRequestStatus trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpWithdrawRequestStatus trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpWithdrawRequestStatus> _ExpWithdrawRequestStatuss);
	}
}
