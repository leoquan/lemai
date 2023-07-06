using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdebitsessiondetail
	{
		/// <summary>
		/// Lấy một DataTable GExpDebitSessionDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDebitSessionDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDebitSessionDetail từ Database
		/// </summary>
		List<GExpDebitSessionDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDebitSessionDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDebitSessionDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDebitSessionDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDebitSessionDetail từ Database
		/// </summary>
		GExpDebitSessionDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpDebitSessionDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDebitSessionDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDebitSessionDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDebitSessionDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDebitSessionDetail _GExpDebitSessionDetail);
		/// <summary>
		/// Insert danh sách đối tượng GExpDebitSessionDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDebitSessionDetail> _GExpDebitSessionDetails);
		/// <summary>
		/// Cập nhật GExpDebitSessionDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDebitSessionDetail _GExpDebitSessionDetail, String Id);
		/// <summary>
		/// Cập nhật GExpDebitSessionDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDebitSessionDetail _GExpDebitSessionDetail);
		/// <summary>
		/// Cập nhật danh sách GExpDebitSessionDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDebitSessionDetail> _GExpDebitSessionDetails);
		/// <summary>
		/// Cập nhật GExpDebitSessionDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDebitSessionDetail _GExpDebitSessionDetail, string condition);
		/// <summary>
		/// Xóa GExpDebitSessionDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpDebitSessionDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDebitSessionDetail _GExpDebitSessionDetail);
		/// <summary>
		/// Xóa GExpDebitSessionDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDebitSessionDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDebitSessionDetail> _GExpDebitSessionDetails);
	}
}
