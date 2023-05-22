using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpproblem
	{
		/// <summary>
		/// Lấy một DataTable ExpProblem từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpProblem từ Database
		/// </summary>
		List<ExpProblem> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpProblem> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpProblem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpProblem từ Database
		/// </summary>
		ExpProblem GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpProblem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpProblem GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpProblem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpProblem vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpProblem _ExpProblem);
		/// <summary>
		/// Insert danh sách đối tượng ExpProblem vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpProblem> _ExpProblems);
		/// <summary>
		/// Cập nhật ExpProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpProblem _ExpProblem, String Id);
		/// <summary>
		/// Cập nhật ExpProblem vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpProblem _ExpProblem);
		/// <summary>
		/// Cập nhật danh sách ExpProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpProblem> _ExpProblems);
		/// <summary>
		/// Cập nhật ExpProblem vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpProblem _ExpProblem, string condition);
		/// <summary>
		/// Xóa ExpProblem trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpProblem trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpProblem _ExpProblem);
		/// <summary>
		/// Xóa ExpProblem trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpProblem trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpProblem> _ExpProblems);
	}
}
