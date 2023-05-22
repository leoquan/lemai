using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpconsignmentcashpaytype
	{
		/// <summary>
		/// Lấy một DataTable ExpConsignmentCashPayType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpConsignmentCashPayType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpConsignmentCashPayType từ Database
		/// </summary>
		List<ExpConsignmentCashPayType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpConsignmentCashPayType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpConsignmentCashPayType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpConsignmentCashPayType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpConsignmentCashPayType từ Database
		/// </summary>
		ExpConsignmentCashPayType GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpConsignmentCashPayType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpConsignmentCashPayType GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpConsignmentCashPayType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpConsignmentCashPayType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpConsignmentCashPayType _ExpConsignmentCashPayType);
		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentCashPayType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpConsignmentCashPayType> _ExpConsignmentCashPayTypes);
		/// <summary>
		/// Cập nhật ExpConsignmentCashPayType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpConsignmentCashPayType _ExpConsignmentCashPayType, String Id);
		/// <summary>
		/// Cập nhật ExpConsignmentCashPayType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpConsignmentCashPayType _ExpConsignmentCashPayType);
		/// <summary>
		/// Cập nhật danh sách ExpConsignmentCashPayType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpConsignmentCashPayType> _ExpConsignmentCashPayTypes);
		/// <summary>
		/// Cập nhật ExpConsignmentCashPayType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpConsignmentCashPayType _ExpConsignmentCashPayType, string condition);
		/// <summary>
		/// Xóa ExpConsignmentCashPayType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpConsignmentCashPayType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpConsignmentCashPayType _ExpConsignmentCashPayType);
		/// <summary>
		/// Xóa ExpConsignmentCashPayType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpConsignmentCashPayType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpConsignmentCashPayType> _ExpConsignmentCashPayTypes);
	}
}
