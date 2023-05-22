using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpscansign
	{
		/// <summary>
		/// Lấy một DataTable GExpScanSign từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpScanSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpScanSign từ Database
		/// </summary>
		List<GExpScanSign> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpScanSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpScanSign> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpScanSign> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpScanSign từ Database
		/// </summary>
		GExpScanSign GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpScanSign đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpScanSign GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpScanSign GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpScanSign vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpScanSign _GExpScanSign);
		/// <summary>
		/// Insert danh sách đối tượng GExpScanSign vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpScanSign> _GExpScanSigns);
		/// <summary>
		/// Cập nhật GExpScanSign vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpScanSign _GExpScanSign, String Id);
		/// <summary>
		/// Cập nhật GExpScanSign vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpScanSign _GExpScanSign);
		/// <summary>
		/// Cập nhật danh sách GExpScanSign vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpScanSign> _GExpScanSigns);
		/// <summary>
		/// Cập nhật GExpScanSign vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpScanSign _GExpScanSign, string condition);
		/// <summary>
		/// Xóa GExpScanSign trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpScanSign trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpScanSign _GExpScanSign);
		/// <summary>
		/// Xóa GExpScanSign trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpScanSign trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpScanSign> _GExpScanSigns);
	}
}
