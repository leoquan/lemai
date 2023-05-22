using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpchungtuct
	{
		/// <summary>
		/// Lấy một DataTable ExpChungTuCt từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpChungTuCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpChungTuCt từ Database
		/// </summary>
		List<ExpChungTuCt> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpChungTuCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpChungTuCt> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpChungTuCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpChungTuCt từ Database
		/// </summary>
		ExpChungTuCt GetObject(string schema, String FK_ExpChungTu, String BILL_CODE);
		/// <summary>
		/// Lấy một ExpChungTuCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpChungTuCt GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpChungTuCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpChungTuCt vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpChungTuCt _ExpChungTuCt);
		/// <summary>
		/// Insert danh sách đối tượng ExpChungTuCt vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpChungTuCt> _ExpChungTuCts);
		/// <summary>
		/// Cập nhật ExpChungTuCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpChungTuCt _ExpChungTuCt, String FK_ExpChungTu, String BILL_CODE);
		/// <summary>
		/// Cập nhật ExpChungTuCt vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpChungTuCt _ExpChungTuCt);
		/// <summary>
		/// Cập nhật danh sách ExpChungTuCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpChungTuCt> _ExpChungTuCts);
		/// <summary>
		/// Cập nhật ExpChungTuCt vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpChungTuCt _ExpChungTuCt, string condition);
		/// <summary>
		/// Xóa ExpChungTuCt trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_ExpChungTu, String BILL_CODE);
		/// <summary>
		/// Xóa ExpChungTuCt trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpChungTuCt _ExpChungTuCt);
		/// <summary>
		/// Xóa ExpChungTuCt trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpChungTuCt trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpChungTuCt> _ExpChungTuCts);
	}
}
