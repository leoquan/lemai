using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcachthanhtoan
	{
		/// <summary>
		/// Lấy một DataTable ExpCachThanhToan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCachThanhToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCachThanhToan từ Database
		/// </summary>
		List<ExpCachThanhToan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCachThanhToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCachThanhToan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCachThanhToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCachThanhToan từ Database
		/// </summary>
		ExpCachThanhToan GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpCachThanhToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCachThanhToan GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCachThanhToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCachThanhToan vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCachThanhToan _ExpCachThanhToan);
		/// <summary>
		/// Insert danh sách đối tượng ExpCachThanhToan vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCachThanhToan> _ExpCachThanhToans);
		/// <summary>
		/// Cập nhật ExpCachThanhToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCachThanhToan _ExpCachThanhToan, String Id);
		/// <summary>
		/// Cập nhật ExpCachThanhToan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCachThanhToan _ExpCachThanhToan);
		/// <summary>
		/// Cập nhật danh sách ExpCachThanhToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCachThanhToan> _ExpCachThanhToans);
		/// <summary>
		/// Cập nhật ExpCachThanhToan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCachThanhToan _ExpCachThanhToan, string condition);
		/// <summary>
		/// Xóa ExpCachThanhToan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpCachThanhToan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCachThanhToan _ExpCachThanhToan);
		/// <summary>
		/// Xóa ExpCachThanhToan trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCachThanhToan trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCachThanhToan> _ExpCachThanhToans);
	}
}
