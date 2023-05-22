using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcustomeraccount
	{
		/// <summary>
		/// Lấy một DataTable ExpCustomerAccount từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCustomerAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCustomerAccount từ Database
		/// </summary>
		List<ExpCustomerAccount> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCustomerAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCustomerAccount> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCustomerAccount> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCustomerAccount từ Database
		/// </summary>
		ExpCustomerAccount GetObject(string schema, String FK_CustomerID, String FK_AccountObject);
		/// <summary>
		/// Lấy một ExpCustomerAccount đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCustomerAccount GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCustomerAccount GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCustomerAccount vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCustomerAccount _ExpCustomerAccount);
		/// <summary>
		/// Insert danh sách đối tượng ExpCustomerAccount vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCustomerAccount> _ExpCustomerAccounts);
		/// <summary>
		/// Cập nhật ExpCustomerAccount vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCustomerAccount _ExpCustomerAccount, String FK_CustomerID, String FK_AccountObject);
		/// <summary>
		/// Cập nhật ExpCustomerAccount vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCustomerAccount _ExpCustomerAccount);
		/// <summary>
		/// Cập nhật danh sách ExpCustomerAccount vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCustomerAccount> _ExpCustomerAccounts);
		/// <summary>
		/// Cập nhật ExpCustomerAccount vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCustomerAccount _ExpCustomerAccount, string condition);
		/// <summary>
		/// Xóa ExpCustomerAccount trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_CustomerID, String FK_AccountObject);
		/// <summary>
		/// Xóa ExpCustomerAccount trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCustomerAccount _ExpCustomerAccount);
		/// <summary>
		/// Xóa ExpCustomerAccount trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCustomerAccount trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCustomerAccount> _ExpCustomerAccounts);
	}
}
