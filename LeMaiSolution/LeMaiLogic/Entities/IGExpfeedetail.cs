using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpfeedetail
	{
		/// <summary>
		/// Lấy một DataTable GExpFeeDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpFeeDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpFeeDetail từ Database
		/// </summary>
		List<GExpFeeDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpFeeDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpFeeDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpFeeDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpFeeDetail từ Database
		/// </summary>
		GExpFeeDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpFeeDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpFeeDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpFeeDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpFeeDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpFeeDetail _GExpFeeDetail);
		/// <summary>
		/// Insert danh sách đối tượng GExpFeeDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpFeeDetail> _GExpFeeDetails);
		/// <summary>
		/// Cập nhật GExpFeeDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpFeeDetail _GExpFeeDetail, String Id);
		/// <summary>
		/// Cập nhật GExpFeeDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpFeeDetail _GExpFeeDetail);
		/// <summary>
		/// Cập nhật danh sách GExpFeeDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpFeeDetail> _GExpFeeDetails);
		/// <summary>
		/// Cập nhật GExpFeeDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpFeeDetail _GExpFeeDetail, string condition);
		/// <summary>
		/// Xóa GExpFeeDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpFeeDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpFeeDetail _GExpFeeDetail);
		/// <summary>
		/// Xóa GExpFeeDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpFeeDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpFeeDetail> _GExpFeeDetails);
	}
}
