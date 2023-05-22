using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEnufunctiongroup
	{
		/// <summary>
		/// Lấy một DataTable MenuFunctionGroup từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MenuFunctionGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MenuFunctionGroup từ Database
		/// </summary>
		List<MenuFunctionGroup> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MenuFunctionGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MenuFunctionGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MenuFunctionGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MenuFunctionGroup từ Database
		/// </summary>
		MenuFunctionGroup GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MenuFunctionGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MenuFunctionGroup GetObjectCon(string schema, string condition, params Object[] parameters);
		MenuFunctionGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MenuFunctionGroup vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MenuFunctionGroup _MenuFunctionGroup);
		/// <summary>
		/// Insert danh sách đối tượng MenuFunctionGroup vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MenuFunctionGroup> _MenuFunctionGroups);
		/// <summary>
		/// Cập nhật MenuFunctionGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MenuFunctionGroup _MenuFunctionGroup, String Id);
		/// <summary>
		/// Cập nhật MenuFunctionGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MenuFunctionGroup _MenuFunctionGroup);
		/// <summary>
		/// Cập nhật danh sách MenuFunctionGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MenuFunctionGroup> _MenuFunctionGroups);
		/// <summary>
		/// Cập nhật MenuFunctionGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MenuFunctionGroup _MenuFunctionGroup, string condition);
		/// <summary>
		/// Xóa MenuFunctionGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MenuFunctionGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MenuFunctionGroup _MenuFunctionGroup);
		/// <summary>
		/// Xóa MenuFunctionGroup trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MenuFunctionGroup trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MenuFunctionGroup> _MenuFunctionGroups);
	}
}
