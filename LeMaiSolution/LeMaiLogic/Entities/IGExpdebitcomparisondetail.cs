using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdebitcomparisondetail
	{
		/// <summary>
		/// Lấy một DataTable GExpDebitComparisonDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDebitComparisonDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDebitComparisonDetail từ Database
		/// </summary>
		List<GExpDebitComparisonDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDebitComparisonDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDebitComparisonDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDebitComparisonDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDebitComparisonDetail từ Database
		/// </summary>
		GExpDebitComparisonDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpDebitComparisonDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDebitComparisonDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDebitComparisonDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDebitComparisonDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDebitComparisonDetail _GExpDebitComparisonDetail);
		/// <summary>
		/// Insert danh sách đối tượng GExpDebitComparisonDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDebitComparisonDetail> _GExpDebitComparisonDetails);
		/// <summary>
		/// Cập nhật GExpDebitComparisonDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDebitComparisonDetail _GExpDebitComparisonDetail, String Id);
		/// <summary>
		/// Cập nhật GExpDebitComparisonDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDebitComparisonDetail _GExpDebitComparisonDetail);
		/// <summary>
		/// Cập nhật danh sách GExpDebitComparisonDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDebitComparisonDetail> _GExpDebitComparisonDetails);
		/// <summary>
		/// Cập nhật GExpDebitComparisonDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDebitComparisonDetail _GExpDebitComparisonDetail, string condition);
		/// <summary>
		/// Xóa GExpDebitComparisonDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpDebitComparisonDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDebitComparisonDetail _GExpDebitComparisonDetail);
		/// <summary>
		/// Xóa GExpDebitComparisonDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDebitComparisonDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDebitComparisonDetail> _GExpDebitComparisonDetails);
	}
}
