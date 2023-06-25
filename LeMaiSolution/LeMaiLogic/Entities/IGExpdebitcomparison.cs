using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdebitcomparison
	{
		/// <summary>
		/// Lấy một DataTable GExpDebitComparison từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDebitComparison từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDebitComparison từ Database
		/// </summary>
		List<GExpDebitComparison> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDebitComparison từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDebitComparison> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDebitComparison> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDebitComparison từ Database
		/// </summary>
		GExpDebitComparison GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpDebitComparison đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDebitComparison GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDebitComparison GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDebitComparison vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDebitComparison _GExpDebitComparison);
		/// <summary>
		/// Insert danh sách đối tượng GExpDebitComparison vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDebitComparison> _GExpDebitComparisons);
		/// <summary>
		/// Cập nhật GExpDebitComparison vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDebitComparison _GExpDebitComparison, String Id);
		/// <summary>
		/// Cập nhật GExpDebitComparison vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDebitComparison _GExpDebitComparison);
		/// <summary>
		/// Cập nhật danh sách GExpDebitComparison vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDebitComparison> _GExpDebitComparisons);
		/// <summary>
		/// Cập nhật GExpDebitComparison vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDebitComparison _GExpDebitComparison, string condition);
		/// <summary>
		/// Xóa GExpDebitComparison trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpDebitComparison trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDebitComparison _GExpDebitComparison);
		/// <summary>
		/// Xóa GExpDebitComparison trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDebitComparison trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDebitComparison> _GExpDebitComparisons);
	}
}
