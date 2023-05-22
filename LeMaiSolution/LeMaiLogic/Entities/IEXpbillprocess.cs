using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpbillprocess
	{
		/// <summary>
		/// Lấy một DataTable ExpBillProcess từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpBillProcess từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpBillProcess từ Database
		/// </summary>
		List<ExpBillProcess> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpBillProcess từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpBillProcess> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpBillProcess> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpBillProcess từ Database
		/// </summary>
		ExpBillProcess GetObject(string schema, String Bill_Code, Int32 Type);
		/// <summary>
		/// Lấy một ExpBillProcess đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpBillProcess GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpBillProcess GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpBillProcess vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpBillProcess _ExpBillProcess);
		/// <summary>
		/// Insert danh sách đối tượng ExpBillProcess vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpBillProcess> _ExpBillProcesss);
		/// <summary>
		/// Cập nhật ExpBillProcess vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpBillProcess _ExpBillProcess, String Bill_Code, Int32 Type);
		/// <summary>
		/// Cập nhật ExpBillProcess vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpBillProcess _ExpBillProcess);
		/// <summary>
		/// Cập nhật danh sách ExpBillProcess vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpBillProcess> _ExpBillProcesss);
		/// <summary>
		/// Cập nhật ExpBillProcess vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpBillProcess _ExpBillProcess, string condition);
		/// <summary>
		/// Xóa ExpBillProcess trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Bill_Code, Int32 Type);
		/// <summary>
		/// Xóa ExpBillProcess trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpBillProcess _ExpBillProcess);
		/// <summary>
		/// Xóa ExpBillProcess trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpBillProcess trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpBillProcess> _ExpBillProcesss);
	}
}
