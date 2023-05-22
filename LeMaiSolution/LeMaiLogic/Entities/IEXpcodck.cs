using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcodck
	{
		/// <summary>
		/// Lấy một DataTable ExpCODCK từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCODCK từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCODCK từ Database
		/// </summary>
		List<ExpCODCK> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCODCK từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCODCK> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCODCK> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCODCK từ Database
		/// </summary>
		ExpCODCK GetObject(string schema, String BILL_CODE);
		/// <summary>
		/// Lấy một ExpCODCK đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCODCK GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCODCK GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCODCK vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCODCK _ExpCODCK);
		/// <summary>
		/// Insert danh sách đối tượng ExpCODCK vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCODCK> _ExpCODCKs);
		/// <summary>
		/// Cập nhật ExpCODCK vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCODCK _ExpCODCK, String BILL_CODE);
		/// <summary>
		/// Cập nhật ExpCODCK vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCODCK _ExpCODCK);
		/// <summary>
		/// Cập nhật danh sách ExpCODCK vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCODCK> _ExpCODCKs);
		/// <summary>
		/// Cập nhật ExpCODCK vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCODCK _ExpCODCK, string condition);
		/// <summary>
		/// Xóa ExpCODCK trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BILL_CODE);
		/// <summary>
		/// Xóa ExpCODCK trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCODCK _ExpCODCK);
		/// <summary>
		/// Xóa ExpCODCK trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCODCK trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCODCK> _ExpCODCKs);
	}
}
