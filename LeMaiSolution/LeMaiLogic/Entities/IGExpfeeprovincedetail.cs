using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpfeeprovincedetail
	{
		/// <summary>
		/// Lấy một DataTable GExpFeeProvinceDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpFeeProvinceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpFeeProvinceDetail từ Database
		/// </summary>
		List<GExpFeeProvinceDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpFeeProvinceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpFeeProvinceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpFeeProvinceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpFeeProvinceDetail từ Database
		/// </summary>
		GExpFeeProvinceDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpFeeProvinceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpFeeProvinceDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpFeeProvinceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpFeeProvinceDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpFeeProvinceDetail _GExpFeeProvinceDetail);
		/// <summary>
		/// Insert danh sách đối tượng GExpFeeProvinceDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpFeeProvinceDetail> _GExpFeeProvinceDetails);
		/// <summary>
		/// Cập nhật GExpFeeProvinceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpFeeProvinceDetail _GExpFeeProvinceDetail, String Id);
		/// <summary>
		/// Cập nhật GExpFeeProvinceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpFeeProvinceDetail _GExpFeeProvinceDetail);
		/// <summary>
		/// Cập nhật danh sách GExpFeeProvinceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpFeeProvinceDetail> _GExpFeeProvinceDetails);
		/// <summary>
		/// Cập nhật GExpFeeProvinceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpFeeProvinceDetail _GExpFeeProvinceDetail, string condition);
		/// <summary>
		/// Xóa GExpFeeProvinceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpFeeProvinceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpFeeProvinceDetail _GExpFeeProvinceDetail);
		/// <summary>
		/// Xóa GExpFeeProvinceDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpFeeProvinceDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpFeeProvinceDetail> _GExpFeeProvinceDetails);
	}
}
