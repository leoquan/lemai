using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpscancome
	{
		/// <summary>
		/// Lấy một DataTable GExpScanCome từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpScanCome từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpScanCome từ Database
		/// </summary>
		List<GExpScanCome> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpScanCome từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpScanCome> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpScanCome> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpScanCome từ Database
		/// </summary>
		GExpScanCome GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpScanCome đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpScanCome GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpScanCome GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpScanCome vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpScanCome _GExpScanCome);
		/// <summary>
		/// Insert danh sách đối tượng GExpScanCome vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpScanCome> _GExpScanComes);
		/// <summary>
		/// Cập nhật GExpScanCome vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpScanCome _GExpScanCome, String Id);
		/// <summary>
		/// Cập nhật GExpScanCome vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpScanCome _GExpScanCome);
		/// <summary>
		/// Cập nhật danh sách GExpScanCome vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpScanCome> _GExpScanComes);
		/// <summary>
		/// Cập nhật GExpScanCome vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpScanCome _GExpScanCome, string condition);
		/// <summary>
		/// Xóa GExpScanCome trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpScanCome trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpScanCome _GExpScanCome);
		/// <summary>
		/// Xóa GExpScanCome trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpScanCome trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpScanCome> _GExpScanComes);
	}
}
