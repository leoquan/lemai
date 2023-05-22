using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpscansend
	{
		/// <summary>
		/// Lấy một DataTable GExpScanSend từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpScanSend từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpScanSend từ Database
		/// </summary>
		List<GExpScanSend> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpScanSend từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpScanSend> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpScanSend> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpScanSend từ Database
		/// </summary>
		GExpScanSend GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpScanSend đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpScanSend GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpScanSend GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpScanSend vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpScanSend _GExpScanSend);
		/// <summary>
		/// Insert danh sách đối tượng GExpScanSend vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpScanSend> _GExpScanSends);
		/// <summary>
		/// Cập nhật GExpScanSend vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpScanSend _GExpScanSend, String Id);
		/// <summary>
		/// Cập nhật GExpScanSend vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpScanSend _GExpScanSend);
		/// <summary>
		/// Cập nhật danh sách GExpScanSend vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpScanSend> _GExpScanSends);
		/// <summary>
		/// Cập nhật GExpScanSend vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpScanSend _GExpScanSend, string condition);
		/// <summary>
		/// Xóa GExpScanSend trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpScanSend trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpScanSend _GExpScanSend);
		/// <summary>
		/// Xóa GExpScanSend trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpScanSend trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpScanSend> _GExpScanSends);
	}
}
