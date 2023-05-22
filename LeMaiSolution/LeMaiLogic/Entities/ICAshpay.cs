using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ICAshpay
	{
		/// <summary>
		/// Lấy một DataTable CashPay từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable CashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách CashPay từ Database
		/// </summary>
		List<CashPay> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách CashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<CashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<CashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một CashPay từ Database
		/// </summary>
		CashPay GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một CashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		CashPay GetObjectCon(string schema, string condition, params Object[] parameters);
		CashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới CashPay vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, CashPay _CashPay);
		/// <summary>
		/// Insert danh sách đối tượng CashPay vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<CashPay> _CashPays);
		/// <summary>
		/// Cập nhật CashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, CashPay _CashPay, String Id);
		/// <summary>
		/// Cập nhật CashPay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, CashPay _CashPay);
		/// <summary>
		/// Cập nhật danh sách CashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<CashPay> _CashPays);
		/// <summary>
		/// Cập nhật CashPay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, CashPay _CashPay, string condition);
		/// <summary>
		/// Xóa CashPay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa CashPay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, CashPay _CashPay);
		/// <summary>
		/// Xóa CashPay trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa CashPay trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<CashPay> _CashPays);
	}
}
