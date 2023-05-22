using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXphoadondoisoatkl
	{
		/// <summary>
		/// Lấy một DataTable ExpHoaDonDoiSoatKL từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpHoaDonDoiSoatKL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpHoaDonDoiSoatKL từ Database
		/// </summary>
		List<ExpHoaDonDoiSoatKL> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpHoaDonDoiSoatKL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpHoaDonDoiSoatKL> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpHoaDonDoiSoatKL> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpHoaDonDoiSoatKL từ Database
		/// </summary>
		ExpHoaDonDoiSoatKL GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpHoaDonDoiSoatKL đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpHoaDonDoiSoatKL GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpHoaDonDoiSoatKL GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpHoaDonDoiSoatKL vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpHoaDonDoiSoatKL _ExpHoaDonDoiSoatKL);
		/// <summary>
		/// Insert danh sách đối tượng ExpHoaDonDoiSoatKL vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpHoaDonDoiSoatKL> _ExpHoaDonDoiSoatKLs);
		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoatKL vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpHoaDonDoiSoatKL _ExpHoaDonDoiSoatKL, String Id);
		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoatKL vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpHoaDonDoiSoatKL _ExpHoaDonDoiSoatKL);
		/// <summary>
		/// Cập nhật danh sách ExpHoaDonDoiSoatKL vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpHoaDonDoiSoatKL> _ExpHoaDonDoiSoatKLs);
		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoatKL vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpHoaDonDoiSoatKL _ExpHoaDonDoiSoatKL, string condition);
		/// <summary>
		/// Xóa ExpHoaDonDoiSoatKL trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpHoaDonDoiSoatKL trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpHoaDonDoiSoatKL _ExpHoaDonDoiSoatKL);
		/// <summary>
		/// Xóa ExpHoaDonDoiSoatKL trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpHoaDonDoiSoatKL trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpHoaDonDoiSoatKL> _ExpHoaDonDoiSoatKLs);
	}
}
