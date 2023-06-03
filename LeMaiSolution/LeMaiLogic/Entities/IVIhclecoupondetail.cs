using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIhclecoupondetail
	{
		/// <summary>
		/// Lấy một DataTable VihcleCouponDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VihcleCouponDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VihcleCouponDetail từ Database
		/// </summary>
		List<VihcleCouponDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VihcleCouponDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VihcleCouponDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VihcleCouponDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VihcleCouponDetail từ Database
		/// </summary>
		VihcleCouponDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một VihcleCouponDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VihcleCouponDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		VihcleCouponDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VihcleCouponDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VihcleCouponDetail _VihcleCouponDetail);
		/// <summary>
		/// Insert danh sách đối tượng VihcleCouponDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VihcleCouponDetail> _VihcleCouponDetails);
		/// <summary>
		/// Cập nhật VihcleCouponDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VihcleCouponDetail _VihcleCouponDetail, String Id);
		/// <summary>
		/// Cập nhật VihcleCouponDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VihcleCouponDetail _VihcleCouponDetail);
		/// <summary>
		/// Cập nhật danh sách VihcleCouponDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VihcleCouponDetail> _VihcleCouponDetails);
		/// <summary>
		/// Cập nhật VihcleCouponDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VihcleCouponDetail _VihcleCouponDetail, string condition);
		/// <summary>
		/// Xóa VihcleCouponDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa VihcleCouponDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VihcleCouponDetail _VihcleCouponDetail);
		/// <summary>
		/// Xóa VihcleCouponDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VihcleCouponDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VihcleCouponDetail> _VihcleCouponDetails);
	}
}
