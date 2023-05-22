using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ICAshpaytype
	{
		/// <summary>
		/// Lấy một DataTable CashPayType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable CashPayType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách CashPayType từ Database
		/// </summary>
		List<CashPayType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách CashPayType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<CashPayType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<CashPayType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một CashPayType từ Database
		/// </summary>
		CashPayType GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một CashPayType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		CashPayType GetObjectCon(string schema, string condition, params Object[] parameters);
		CashPayType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới CashPayType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, CashPayType _CashPayType);
		/// <summary>
		/// Insert danh sách đối tượng CashPayType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<CashPayType> _CashPayTypes);
		/// <summary>
		/// Cập nhật CashPayType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, CashPayType _CashPayType, Int32 Id);
		/// <summary>
		/// Cập nhật CashPayType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, CashPayType _CashPayType);
		/// <summary>
		/// Cập nhật danh sách CashPayType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<CashPayType> _CashPayTypes);
		/// <summary>
		/// Cập nhật CashPayType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, CashPayType _CashPayType, string condition);
		/// <summary>
		/// Xóa CashPayType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa CashPayType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, CashPayType _CashPayType);
		/// <summary>
		/// Xóa CashPayType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa CashPayType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<CashPayType> _CashPayTypes);
	}
}
