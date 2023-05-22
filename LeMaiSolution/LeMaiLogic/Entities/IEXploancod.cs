using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXploancod
	{
		/// <summary>
		/// Lấy một DataTable ExpLoanCod từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpLoanCod từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpLoanCod từ Database
		/// </summary>
		List<ExpLoanCod> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpLoanCod từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpLoanCod> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpLoanCod> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpLoanCod từ Database
		/// </summary>
		ExpLoanCod GetObject(string schema, String BillCode);
		/// <summary>
		/// Lấy một ExpLoanCod đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpLoanCod GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpLoanCod GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpLoanCod vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpLoanCod _ExpLoanCod);
		/// <summary>
		/// Insert danh sách đối tượng ExpLoanCod vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpLoanCod> _ExpLoanCods);
		/// <summary>
		/// Cập nhật ExpLoanCod vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpLoanCod _ExpLoanCod, String BillCode);
		/// <summary>
		/// Cập nhật ExpLoanCod vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpLoanCod _ExpLoanCod);
		/// <summary>
		/// Cập nhật danh sách ExpLoanCod vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpLoanCod> _ExpLoanCods);
		/// <summary>
		/// Cập nhật ExpLoanCod vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpLoanCod _ExpLoanCod, string condition);
		/// <summary>
		/// Xóa ExpLoanCod trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BillCode);
		/// <summary>
		/// Xóa ExpLoanCod trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpLoanCod _ExpLoanCod);
		/// <summary>
		/// Xóa ExpLoanCod trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpLoanCod trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpLoanCod> _ExpLoanCods);
	}
}
