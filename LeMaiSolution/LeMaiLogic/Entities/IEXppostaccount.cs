using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXppostaccount
	{
		/// <summary>
		/// Lấy một DataTable ExpPostAccount từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpPostAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpPostAccount từ Database
		/// </summary>
		List<ExpPostAccount> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpPostAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpPostAccount> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpPostAccount> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpPostAccount từ Database
		/// </summary>
		ExpPostAccount GetObject(string schema, String FK_AccountId, String FK_ExpPost);
		/// <summary>
		/// Lấy một ExpPostAccount đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpPostAccount GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpPostAccount GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpPostAccount vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpPostAccount _ExpPostAccount);
		/// <summary>
		/// Insert danh sách đối tượng ExpPostAccount vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpPostAccount> _ExpPostAccounts);
		/// <summary>
		/// Cập nhật ExpPostAccount vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpPostAccount _ExpPostAccount, String FK_AccountId, String FK_ExpPost);
		/// <summary>
		/// Cập nhật ExpPostAccount vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpPostAccount _ExpPostAccount);
		/// <summary>
		/// Cập nhật danh sách ExpPostAccount vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpPostAccount> _ExpPostAccounts);
		/// <summary>
		/// Cập nhật ExpPostAccount vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpPostAccount _ExpPostAccount, string condition);
		/// <summary>
		/// Xóa ExpPostAccount trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_AccountId, String FK_ExpPost);
		/// <summary>
		/// Xóa ExpPostAccount trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpPostAccount _ExpPostAccount);
		/// <summary>
		/// Xóa ExpPostAccount trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpPostAccount trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpPostAccount> _ExpPostAccounts);
	}
}
