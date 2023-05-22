using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdhistoryct
	{
		/// <summary>
		/// Lấy một DataTable MedHiStoryCT từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedHiStoryCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedHiStoryCT từ Database
		/// </summary>
		List<MedHiStoryCT> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedHiStoryCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedHiStoryCT> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedHiStoryCT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedHiStoryCT từ Database
		/// </summary>
		MedHiStoryCT GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedHiStoryCT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedHiStoryCT GetObjectCon(string schema, string condition, params Object[] parameters);
		MedHiStoryCT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedHiStoryCT vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedHiStoryCT _MedHiStoryCT);
		/// <summary>
		/// Insert danh sách đối tượng MedHiStoryCT vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedHiStoryCT> _MedHiStoryCTs);
		/// <summary>
		/// Cập nhật MedHiStoryCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedHiStoryCT _MedHiStoryCT, String id);
		/// <summary>
		/// Cập nhật MedHiStoryCT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedHiStoryCT _MedHiStoryCT);
		/// <summary>
		/// Cập nhật danh sách MedHiStoryCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedHiStoryCT> _MedHiStoryCTs);
		/// <summary>
		/// Cập nhật MedHiStoryCT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedHiStoryCT _MedHiStoryCT, string condition);
		/// <summary>
		/// Xóa MedHiStoryCT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedHiStoryCT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedHiStoryCT _MedHiStoryCT);
		/// <summary>
		/// Xóa MedHiStoryCT trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedHiStoryCT trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedHiStoryCT> _MedHiStoryCTs);
	}
}
