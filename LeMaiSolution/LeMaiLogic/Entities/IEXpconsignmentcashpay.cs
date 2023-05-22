using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpconsignmentcashpay
	{
		/// <summary>
		/// Lấy một DataTable ExpConsignmentCashPay từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpConsignmentCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpConsignmentCashPay từ Database
		/// </summary>
		List<ExpConsignmentCashPay> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpConsignmentCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpConsignmentCashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpConsignmentCashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpConsignmentCashPay từ Database
		/// </summary>
		ExpConsignmentCashPay GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpConsignmentCashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpConsignmentCashPay GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpConsignmentCashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpConsignmentCashPay vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpConsignmentCashPay _ExpConsignmentCashPay);
		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentCashPay vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpConsignmentCashPay> _ExpConsignmentCashPays);
		/// <summary>
		/// Cập nhật ExpConsignmentCashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpConsignmentCashPay _ExpConsignmentCashPay, String Id);
		/// <summary>
		/// Cập nhật ExpConsignmentCashPay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpConsignmentCashPay _ExpConsignmentCashPay);
		/// <summary>
		/// Cập nhật danh sách ExpConsignmentCashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpConsignmentCashPay> _ExpConsignmentCashPays);
		/// <summary>
		/// Cập nhật ExpConsignmentCashPay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpConsignmentCashPay _ExpConsignmentCashPay, string condition);
		/// <summary>
		/// Xóa ExpConsignmentCashPay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpConsignmentCashPay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpConsignmentCashPay _ExpConsignmentCashPay);
		/// <summary>
		/// Xóa ExpConsignmentCashPay trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpConsignmentCashPay trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpConsignmentCashPay> _ExpConsignmentCashPays);
	}
}
