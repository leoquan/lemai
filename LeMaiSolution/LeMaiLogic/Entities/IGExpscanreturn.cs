using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpscanreturn
	{
		/// <summary>
		/// Lấy một DataTable GExpScanReturn từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpScanReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpScanReturn từ Database
		/// </summary>
		List<GExpScanReturn> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpScanReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpScanReturn> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpScanReturn> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpScanReturn từ Database
		/// </summary>
		GExpScanReturn GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpScanReturn đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpScanReturn GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpScanReturn GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpScanReturn vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpScanReturn _GExpScanReturn);
		/// <summary>
		/// Insert danh sách đối tượng GExpScanReturn vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpScanReturn> _GExpScanReturns);
		/// <summary>
		/// Cập nhật GExpScanReturn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpScanReturn _GExpScanReturn, String Id);
		/// <summary>
		/// Cập nhật GExpScanReturn vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpScanReturn _GExpScanReturn);
		/// <summary>
		/// Cập nhật danh sách GExpScanReturn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpScanReturn> _GExpScanReturns);
		/// <summary>
		/// Cập nhật GExpScanReturn vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpScanReturn _GExpScanReturn, string condition);
		/// <summary>
		/// Xóa GExpScanReturn trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpScanReturn trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpScanReturn _GExpScanReturn);
		/// <summary>
		/// Xóa GExpScanReturn trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpScanReturn trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpScanReturn> _GExpScanReturns);
	}
}
