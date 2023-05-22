using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpkykettoan
	{
		/// <summary>
		/// Lấy một DataTable ExpKyKetToan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpKyKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpKyKetToan từ Database
		/// </summary>
		List<ExpKyKetToan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpKyKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpKyKetToan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpKyKetToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpKyKetToan từ Database
		/// </summary>
		ExpKyKetToan GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpKyKetToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpKyKetToan GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpKyKetToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpKyKetToan vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpKyKetToan _ExpKyKetToan);
		/// <summary>
		/// Insert danh sách đối tượng ExpKyKetToan vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpKyKetToan> _ExpKyKetToans);
		/// <summary>
		/// Cập nhật ExpKyKetToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpKyKetToan _ExpKyKetToan, String Id);
		/// <summary>
		/// Cập nhật ExpKyKetToan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpKyKetToan _ExpKyKetToan);
		/// <summary>
		/// Cập nhật danh sách ExpKyKetToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpKyKetToan> _ExpKyKetToans);
		/// <summary>
		/// Cập nhật ExpKyKetToan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpKyKetToan _ExpKyKetToan, string condition);
		/// <summary>
		/// Xóa ExpKyKetToan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpKyKetToan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpKyKetToan _ExpKyKetToan);
		/// <summary>
		/// Xóa ExpKyKetToan trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpKyKetToan trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpKyKetToan> _ExpKyKetToans);
	}
}
