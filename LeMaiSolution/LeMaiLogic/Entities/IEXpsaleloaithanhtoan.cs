using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpsaleloaithanhtoan
	{
		/// <summary>
		/// Lấy một DataTable ExpSaleLoaiThanhToan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpSaleLoaiThanhToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpSaleLoaiThanhToan từ Database
		/// </summary>
		List<ExpSaleLoaiThanhToan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpSaleLoaiThanhToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpSaleLoaiThanhToan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpSaleLoaiThanhToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpSaleLoaiThanhToan từ Database
		/// </summary>
		ExpSaleLoaiThanhToan GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpSaleLoaiThanhToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpSaleLoaiThanhToan GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpSaleLoaiThanhToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpSaleLoaiThanhToan vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpSaleLoaiThanhToan _ExpSaleLoaiThanhToan);
		/// <summary>
		/// Insert danh sách đối tượng ExpSaleLoaiThanhToan vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpSaleLoaiThanhToan> _ExpSaleLoaiThanhToans);
		/// <summary>
		/// Cập nhật ExpSaleLoaiThanhToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpSaleLoaiThanhToan _ExpSaleLoaiThanhToan, String Id);
		/// <summary>
		/// Cập nhật ExpSaleLoaiThanhToan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpSaleLoaiThanhToan _ExpSaleLoaiThanhToan);
		/// <summary>
		/// Cập nhật danh sách ExpSaleLoaiThanhToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpSaleLoaiThanhToan> _ExpSaleLoaiThanhToans);
		/// <summary>
		/// Cập nhật ExpSaleLoaiThanhToan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpSaleLoaiThanhToan _ExpSaleLoaiThanhToan, string condition);
		/// <summary>
		/// Xóa ExpSaleLoaiThanhToan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpSaleLoaiThanhToan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpSaleLoaiThanhToan _ExpSaleLoaiThanhToan);
		/// <summary>
		/// Xóa ExpSaleLoaiThanhToan trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpSaleLoaiThanhToan trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpSaleLoaiThanhToan> _ExpSaleLoaiThanhToans);
	}
}
