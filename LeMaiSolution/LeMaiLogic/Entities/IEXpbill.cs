using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpbill
	{
		/// <summary>
		/// Lấy một DataTable ExpBILL từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpBILL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpBILL từ Database
		/// </summary>
		List<ExpBILL> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpBILL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpBILL> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpBILL> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpBILL từ Database
		/// </summary>
		ExpBILL GetObject(string schema, String BILL_CODE);
		/// <summary>
		/// Lấy một ExpBILL đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpBILL GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpBILL GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpBILL vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpBILL _ExpBILL);
		/// <summary>
		/// Insert danh sách đối tượng ExpBILL vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpBILL> _ExpBILLs);
		/// <summary>
		/// Cập nhật ExpBILL vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpBILL _ExpBILL, String BILL_CODE);
		/// <summary>
		/// Cập nhật ExpBILL vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpBILL _ExpBILL);
		/// <summary>
		/// Cập nhật danh sách ExpBILL vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpBILL> _ExpBILLs);
		/// <summary>
		/// Cập nhật ExpBILL vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpBILL _ExpBILL, string condition);
		/// <summary>
		/// Xóa ExpBILL trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BILL_CODE);
		/// <summary>
		/// Xóa ExpBILL trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpBILL _ExpBILL);
		/// <summary>
		/// Xóa ExpBILL trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpBILL trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpBILL> _ExpBILLs);
	}
}
