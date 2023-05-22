using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpwithdrawrequesttype
	{
		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequestType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequestType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpWithdrawRequestType từ Database
		/// </summary>
		List<ExpWithdrawRequestType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpWithdrawRequestType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpWithdrawRequestType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpWithdrawRequestType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpWithdrawRequestType từ Database
		/// </summary>
		ExpWithdrawRequestType GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpWithdrawRequestType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpWithdrawRequestType GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpWithdrawRequestType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpWithdrawRequestType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpWithdrawRequestType _ExpWithdrawRequestType);
		/// <summary>
		/// Insert danh sách đối tượng ExpWithdrawRequestType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpWithdrawRequestType> _ExpWithdrawRequestTypes);
		/// <summary>
		/// Cập nhật ExpWithdrawRequestType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpWithdrawRequestType _ExpWithdrawRequestType, String Id);
		/// <summary>
		/// Cập nhật ExpWithdrawRequestType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpWithdrawRequestType _ExpWithdrawRequestType);
		/// <summary>
		/// Cập nhật danh sách ExpWithdrawRequestType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpWithdrawRequestType> _ExpWithdrawRequestTypes);
		/// <summary>
		/// Cập nhật ExpWithdrawRequestType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpWithdrawRequestType _ExpWithdrawRequestType, string condition);
		/// <summary>
		/// Xóa ExpWithdrawRequestType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpWithdrawRequestType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpWithdrawRequestType _ExpWithdrawRequestType);
		/// <summary>
		/// Xóa ExpWithdrawRequestType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpWithdrawRequestType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpWithdrawRequestType> _ExpWithdrawRequestTypes);
	}
}
