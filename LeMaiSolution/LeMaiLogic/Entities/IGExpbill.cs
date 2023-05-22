using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpbill
	{
		/// <summary>
		/// Lấy một DataTable GExpBill từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpBill từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpBill từ Database
		/// </summary>
		List<GExpBill> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpBill từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpBill> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpBill> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpBill từ Database
		/// </summary>
		GExpBill GetObject(string schema, String BillCode);
		/// <summary>
		/// Lấy một GExpBill đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpBill GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpBill GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpBill vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpBill _GExpBill);
		/// <summary>
		/// Insert danh sách đối tượng GExpBill vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpBill> _GExpBills);
		/// <summary>
		/// Cập nhật GExpBill vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpBill _GExpBill, String BillCode);
		/// <summary>
		/// Cập nhật GExpBill vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpBill _GExpBill);
		/// <summary>
		/// Cập nhật danh sách GExpBill vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpBill> _GExpBills);
		/// <summary>
		/// Cập nhật GExpBill vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpBill _GExpBill, string condition);
		/// <summary>
		/// Xóa GExpBill trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BillCode);
		/// <summary>
		/// Xóa GExpBill trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpBill _GExpBill);
		/// <summary>
		/// Xóa GExpBill trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpBill trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpBill> _GExpBills);
	}
}
