using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpproviceproblem
	{
		/// <summary>
		/// Lấy một DataTable ExpProviceProblem từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpProviceProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpProviceProblem từ Database
		/// </summary>
		List<ExpProviceProblem> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpProviceProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpProviceProblem> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpProviceProblem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpProviceProblem từ Database
		/// </summary>
		ExpProviceProblem GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpProviceProblem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpProviceProblem GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpProviceProblem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpProviceProblem vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpProviceProblem _ExpProviceProblem);
		/// <summary>
		/// Insert danh sách đối tượng ExpProviceProblem vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpProviceProblem> _ExpProviceProblems);
		/// <summary>
		/// Cập nhật ExpProviceProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpProviceProblem _ExpProviceProblem, String Id);
		/// <summary>
		/// Cập nhật ExpProviceProblem vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpProviceProblem _ExpProviceProblem);
		/// <summary>
		/// Cập nhật danh sách ExpProviceProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpProviceProblem> _ExpProviceProblems);
		/// <summary>
		/// Cập nhật ExpProviceProblem vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpProviceProblem _ExpProviceProblem, string condition);
		/// <summary>
		/// Xóa ExpProviceProblem trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpProviceProblem trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpProviceProblem _ExpProviceProblem);
		/// <summary>
		/// Xóa ExpProviceProblem trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpProviceProblem trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpProviceProblem> _ExpProviceProblems);
	}
}
