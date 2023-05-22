using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpwithdrawrequest
	{
		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequest từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequest từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpWithdrawRequest từ Database
		/// </summary>
		List<ExpWithdrawRequest> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpWithdrawRequest từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpWithdrawRequest> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpWithdrawRequest> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpWithdrawRequest từ Database
		/// </summary>
		ExpWithdrawRequest GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpWithdrawRequest đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpWithdrawRequest GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpWithdrawRequest GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpWithdrawRequest vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpWithdrawRequest _ExpWithdrawRequest);
		/// <summary>
		/// Insert danh sách đối tượng ExpWithdrawRequest vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpWithdrawRequest> _ExpWithdrawRequests);
		/// <summary>
		/// Cập nhật ExpWithdrawRequest vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpWithdrawRequest _ExpWithdrawRequest, String Id);
		/// <summary>
		/// Cập nhật ExpWithdrawRequest vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpWithdrawRequest _ExpWithdrawRequest);
		/// <summary>
		/// Cập nhật danh sách ExpWithdrawRequest vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpWithdrawRequest> _ExpWithdrawRequests);
		/// <summary>
		/// Cập nhật ExpWithdrawRequest vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpWithdrawRequest _ExpWithdrawRequest, string condition);
		/// <summary>
		/// Xóa ExpWithdrawRequest trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpWithdrawRequest trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpWithdrawRequest _ExpWithdrawRequest);
		/// <summary>
		/// Xóa ExpWithdrawRequest trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpWithdrawRequest trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpWithdrawRequest> _ExpWithdrawRequests);
	}
}
