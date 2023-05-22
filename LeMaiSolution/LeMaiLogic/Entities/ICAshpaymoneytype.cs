using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ICAshpaymoneytype
	{
		/// <summary>
		/// Lấy một DataTable CashPayMoneyType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable CashPayMoneyType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách CashPayMoneyType từ Database
		/// </summary>
		List<CashPayMoneyType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách CashPayMoneyType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<CashPayMoneyType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<CashPayMoneyType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một CashPayMoneyType từ Database
		/// </summary>
		CashPayMoneyType GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một CashPayMoneyType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		CashPayMoneyType GetObjectCon(string schema, string condition, params Object[] parameters);
		CashPayMoneyType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới CashPayMoneyType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, CashPayMoneyType _CashPayMoneyType);
		/// <summary>
		/// Insert danh sách đối tượng CashPayMoneyType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<CashPayMoneyType> _CashPayMoneyTypes);
		/// <summary>
		/// Cập nhật CashPayMoneyType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, CashPayMoneyType _CashPayMoneyType, Int32 Id);
		/// <summary>
		/// Cập nhật CashPayMoneyType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, CashPayMoneyType _CashPayMoneyType);
		/// <summary>
		/// Cập nhật danh sách CashPayMoneyType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<CashPayMoneyType> _CashPayMoneyTypes);
		/// <summary>
		/// Cập nhật CashPayMoneyType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, CashPayMoneyType _CashPayMoneyType, string condition);
		/// <summary>
		/// Xóa CashPayMoneyType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa CashPayMoneyType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, CashPayMoneyType _CashPayMoneyType);
		/// <summary>
		/// Xóa CashPayMoneyType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa CashPayMoneyType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<CashPayMoneyType> _CashPayMoneyTypes);
	}
}
