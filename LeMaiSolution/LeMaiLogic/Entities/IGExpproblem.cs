using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpproblem
	{
		/// <summary>
		/// Lấy một DataTable GExpProblem từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProblem từ Database
		/// </summary>
		List<GExpProblem> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProblem> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProblem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProblem từ Database
		/// </summary>
		GExpProblem GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpProblem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProblem GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProblem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProblem vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProblem _GExpProblem);
		/// <summary>
		/// Insert danh sách đối tượng GExpProblem vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProblem> _GExpProblems);
		/// <summary>
		/// Cập nhật GExpProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProblem _GExpProblem, String Id);
		/// <summary>
		/// Cập nhật GExpProblem vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProblem _GExpProblem);
		/// <summary>
		/// Cập nhật danh sách GExpProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProblem> _GExpProblems);
		/// <summary>
		/// Cập nhật GExpProblem vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProblem _GExpProblem, string condition);
		/// <summary>
		/// Xóa GExpProblem trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpProblem trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProblem _GExpProblem);
		/// <summary>
		/// Xóa GExpProblem trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProblem trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProblem> _GExpProblems);
	}
}
