using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpscantt
	{
		/// <summary>
		/// Lấy một DataTable ExpScanTT từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpScanTT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpScanTT từ Database
		/// </summary>
		List<ExpScanTT> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpScanTT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpScanTT> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpScanTT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpScanTT từ Database
		/// </summary>
		ExpScanTT GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpScanTT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpScanTT GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpScanTT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpScanTT vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpScanTT _ExpScanTT);
		/// <summary>
		/// Insert danh sách đối tượng ExpScanTT vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpScanTT> _ExpScanTTs);
		/// <summary>
		/// Cập nhật ExpScanTT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpScanTT _ExpScanTT, String Id);
		/// <summary>
		/// Cập nhật ExpScanTT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpScanTT _ExpScanTT);
		/// <summary>
		/// Cập nhật danh sách ExpScanTT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpScanTT> _ExpScanTTs);
		/// <summary>
		/// Cập nhật ExpScanTT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpScanTT _ExpScanTT, string condition);
		/// <summary>
		/// Xóa ExpScanTT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpScanTT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpScanTT _ExpScanTT);
		/// <summary>
		/// Xóa ExpScanTT trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpScanTT trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpScanTT> _ExpScanTTs);
	}
}
