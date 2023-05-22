using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVOucher
	{
		/// <summary>
		/// Lấy một DataTable Voucher từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable Voucher từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách Voucher từ Database
		/// </summary>
		List<Voucher> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách Voucher từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<Voucher> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<Voucher> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một Voucher từ Database
		/// </summary>
		Voucher GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một Voucher đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		Voucher GetObjectCon(string schema, string condition, params Object[] parameters);
		Voucher GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới Voucher vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, Voucher _Voucher);
		/// <summary>
		/// Insert danh sách đối tượng Voucher vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<Voucher> _Vouchers);
		/// <summary>
		/// Cập nhật Voucher vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, Voucher _Voucher, String Id);
		/// <summary>
		/// Cập nhật Voucher vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, Voucher _Voucher);
		/// <summary>
		/// Cập nhật danh sách Voucher vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<Voucher> _Vouchers);
		/// <summary>
		/// Cập nhật Voucher vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, Voucher _Voucher, string condition);
		/// <summary>
		/// Xóa Voucher trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa Voucher trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Voucher _Voucher);
		/// <summary>
		/// Xóa Voucher trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa Voucher trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<Voucher> _Vouchers);
	}
}
