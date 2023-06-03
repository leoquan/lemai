using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIhclecoupon
	{
		/// <summary>
		/// Lấy một DataTable VihcleCoupon từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VihcleCoupon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VihcleCoupon từ Database
		/// </summary>
		List<VihcleCoupon> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VihcleCoupon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VihcleCoupon> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VihcleCoupon> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VihcleCoupon từ Database
		/// </summary>
		VihcleCoupon GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một VihcleCoupon đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VihcleCoupon GetObjectCon(string schema, string condition, params Object[] parameters);
		VihcleCoupon GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VihcleCoupon vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VihcleCoupon _VihcleCoupon);
		/// <summary>
		/// Insert danh sách đối tượng VihcleCoupon vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VihcleCoupon> _VihcleCoupons);
		/// <summary>
		/// Cập nhật VihcleCoupon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VihcleCoupon _VihcleCoupon, String Id);
		/// <summary>
		/// Cập nhật VihcleCoupon vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VihcleCoupon _VihcleCoupon);
		/// <summary>
		/// Cập nhật danh sách VihcleCoupon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VihcleCoupon> _VihcleCoupons);
		/// <summary>
		/// Cập nhật VihcleCoupon vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VihcleCoupon _VihcleCoupon, string condition);
		/// <summary>
		/// Xóa VihcleCoupon trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa VihcleCoupon trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VihcleCoupon _VihcleCoupon);
		/// <summary>
		/// Xóa VihcleCoupon trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VihcleCoupon trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VihcleCoupon> _VihcleCoupons);
	}
}
