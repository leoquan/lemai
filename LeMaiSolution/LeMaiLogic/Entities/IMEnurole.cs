using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEnurole
	{
		/// <summary>
		/// Lấy một DataTable MenuRole từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MenuRole từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MenuRole từ Database
		/// </summary>
		List<MenuRole> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MenuRole từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MenuRole> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MenuRole> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MenuRole từ Database
		/// </summary>
		MenuRole GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MenuRole đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MenuRole GetObjectCon(string schema, string condition, params Object[] parameters);
		MenuRole GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MenuRole vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MenuRole _MenuRole);
		/// <summary>
		/// Insert danh sách đối tượng MenuRole vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MenuRole> _MenuRoles);
		/// <summary>
		/// Cập nhật MenuRole vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MenuRole _MenuRole, String Id);
		/// <summary>
		/// Cập nhật MenuRole vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MenuRole _MenuRole);
		/// <summary>
		/// Cập nhật danh sách MenuRole vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MenuRole> _MenuRoles);
		/// <summary>
		/// Cập nhật MenuRole vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MenuRole _MenuRole, string condition);
		/// <summary>
		/// Xóa MenuRole trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MenuRole trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MenuRole _MenuRole);
		/// <summary>
		/// Xóa MenuRole trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MenuRole trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MenuRole> _MenuRoles);
	}
}
