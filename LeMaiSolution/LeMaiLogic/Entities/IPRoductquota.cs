using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IPRoductquota
	{
		/// <summary>
		/// Lấy một DataTable ProductQuota từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ProductQuota từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ProductQuota từ Database
		/// </summary>
		List<ProductQuota> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ProductQuota từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ProductQuota> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ProductQuota> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ProductQuota từ Database
		/// </summary>
		ProductQuota GetObject(string schema, String FK_ServiceQuota, String FK_ServiceRefer);
		/// <summary>
		/// Lấy một ProductQuota đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ProductQuota GetObjectCon(string schema, string condition, params Object[] parameters);
		ProductQuota GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ProductQuota vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ProductQuota _ProductQuota);
		/// <summary>
		/// Insert danh sách đối tượng ProductQuota vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ProductQuota> _ProductQuotas);
		/// <summary>
		/// Cập nhật ProductQuota vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ProductQuota _ProductQuota, String FK_ServiceQuota, String FK_ServiceRefer);
		/// <summary>
		/// Cập nhật ProductQuota vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ProductQuota _ProductQuota);
		/// <summary>
		/// Cập nhật danh sách ProductQuota vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ProductQuota> _ProductQuotas);
		/// <summary>
		/// Cập nhật ProductQuota vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ProductQuota _ProductQuota, string condition);
		/// <summary>
		/// Xóa ProductQuota trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_ServiceQuota, String FK_ServiceRefer);
		/// <summary>
		/// Xóa ProductQuota trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ProductQuota _ProductQuota);
		/// <summary>
		/// Xóa ProductQuota trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ProductQuota trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ProductQuota> _ProductQuotas);
	}
}
