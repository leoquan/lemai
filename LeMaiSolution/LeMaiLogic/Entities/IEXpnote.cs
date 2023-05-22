using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpnote
	{
		/// <summary>
		/// Lấy một DataTable ExpNote từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpNote từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpNote từ Database
		/// </summary>
		List<ExpNote> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpNote từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpNote> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpNote> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpNote từ Database
		/// </summary>
		ExpNote GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpNote đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpNote GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpNote GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpNote vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpNote _ExpNote);
		/// <summary>
		/// Insert danh sách đối tượng ExpNote vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpNote> _ExpNotes);
		/// <summary>
		/// Cập nhật ExpNote vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpNote _ExpNote, String Id);
		/// <summary>
		/// Cập nhật ExpNote vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpNote _ExpNote);
		/// <summary>
		/// Cập nhật danh sách ExpNote vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpNote> _ExpNotes);
		/// <summary>
		/// Cập nhật ExpNote vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpNote _ExpNote, string condition);
		/// <summary>
		/// Xóa ExpNote trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpNote trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpNote _ExpNote);
		/// <summary>
		/// Xóa ExpNote trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpNote trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpNote> _ExpNotes);
	}
}
