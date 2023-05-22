using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpmistake
	{
		/// <summary>
		/// Lấy một DataTable ExpMistake từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpMistake từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpMistake từ Database
		/// </summary>
		List<ExpMistake> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpMistake từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpMistake> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpMistake> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpMistake từ Database
		/// </summary>
		ExpMistake GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpMistake đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpMistake GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpMistake GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpMistake vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpMistake _ExpMistake);
		/// <summary>
		/// Insert danh sách đối tượng ExpMistake vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpMistake> _ExpMistakes);
		/// <summary>
		/// Cập nhật ExpMistake vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpMistake _ExpMistake, String Id);
		/// <summary>
		/// Cập nhật ExpMistake vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpMistake _ExpMistake);
		/// <summary>
		/// Cập nhật danh sách ExpMistake vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpMistake> _ExpMistakes);
		/// <summary>
		/// Cập nhật ExpMistake vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpMistake _ExpMistake, string condition);
		/// <summary>
		/// Xóa ExpMistake trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpMistake trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpMistake _ExpMistake);
		/// <summary>
		/// Xóa ExpMistake trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpMistake trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpMistake> _ExpMistakes);
	}
}
