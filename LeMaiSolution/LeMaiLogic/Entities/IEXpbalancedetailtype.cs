using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpbalancedetailtype
	{
		/// <summary>
		/// Lấy một DataTable ExpBalanceDetailType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpBalanceDetailType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpBalanceDetailType từ Database
		/// </summary>
		List<ExpBalanceDetailType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpBalanceDetailType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpBalanceDetailType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpBalanceDetailType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpBalanceDetailType từ Database
		/// </summary>
		ExpBalanceDetailType GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpBalanceDetailType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpBalanceDetailType GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpBalanceDetailType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpBalanceDetailType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpBalanceDetailType _ExpBalanceDetailType);
		/// <summary>
		/// Insert danh sách đối tượng ExpBalanceDetailType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpBalanceDetailType> _ExpBalanceDetailTypes);
		/// <summary>
		/// Cập nhật ExpBalanceDetailType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpBalanceDetailType _ExpBalanceDetailType, String Id);
		/// <summary>
		/// Cập nhật ExpBalanceDetailType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpBalanceDetailType _ExpBalanceDetailType);
		/// <summary>
		/// Cập nhật danh sách ExpBalanceDetailType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpBalanceDetailType> _ExpBalanceDetailTypes);
		/// <summary>
		/// Cập nhật ExpBalanceDetailType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpBalanceDetailType _ExpBalanceDetailType, string condition);
		/// <summary>
		/// Xóa ExpBalanceDetailType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpBalanceDetailType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpBalanceDetailType _ExpBalanceDetailType);
		/// <summary>
		/// Xóa ExpBalanceDetailType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpBalanceDetailType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpBalanceDetailType> _ExpBalanceDetailTypes);
	}
}
