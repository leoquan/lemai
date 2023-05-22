using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpautoreport
	{
		/// <summary>
		/// Lấy một DataTable ExpAutoReport từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpAutoReport từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpAutoReport từ Database
		/// </summary>
		List<ExpAutoReport> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpAutoReport từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpAutoReport> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpAutoReport> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpAutoReport từ Database
		/// </summary>
		ExpAutoReport GetObject(string schema, String No);
		/// <summary>
		/// Lấy một ExpAutoReport đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpAutoReport GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpAutoReport GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpAutoReport vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpAutoReport _ExpAutoReport);
		/// <summary>
		/// Insert danh sách đối tượng ExpAutoReport vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpAutoReport> _ExpAutoReports);
		/// <summary>
		/// Cập nhật ExpAutoReport vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpAutoReport _ExpAutoReport, String No);
		/// <summary>
		/// Cập nhật ExpAutoReport vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpAutoReport _ExpAutoReport);
		/// <summary>
		/// Cập nhật danh sách ExpAutoReport vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpAutoReport> _ExpAutoReports);
		/// <summary>
		/// Cập nhật ExpAutoReport vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpAutoReport _ExpAutoReport, string condition);
		/// <summary>
		/// Xóa ExpAutoReport trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String No);
		/// <summary>
		/// Xóa ExpAutoReport trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpAutoReport _ExpAutoReport);
		/// <summary>
		/// Xóa ExpAutoReport trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpAutoReport trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpAutoReport> _ExpAutoReports);
	}
}
