using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcashpay
	{
		/// <summary>
		/// Lấy một DataTable ExpCashPay từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCashPay từ Database
		/// </summary>
		List<ExpCashPay> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCashPay từ Database
		/// </summary>
		ExpCashPay GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpCashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCashPay GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCashPay vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCashPay _ExpCashPay);
		/// <summary>
		/// Insert danh sách đối tượng ExpCashPay vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCashPay> _ExpCashPays);
		/// <summary>
		/// Cập nhật ExpCashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCashPay _ExpCashPay, String Id);
		/// <summary>
		/// Cập nhật ExpCashPay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCashPay _ExpCashPay);
		/// <summary>
		/// Cập nhật danh sách ExpCashPay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCashPay> _ExpCashPays);
		/// <summary>
		/// Cập nhật ExpCashPay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCashPay _ExpCashPay, string condition);
		/// <summary>
		/// Xóa ExpCashPay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpCashPay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCashPay _ExpCashPay);
		/// <summary>
		/// Xóa ExpCashPay trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCashPay trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCashPay> _ExpCashPays);
	}
}
