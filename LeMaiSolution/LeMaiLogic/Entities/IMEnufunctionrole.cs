using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEnufunctionrole
	{
		/// <summary>
		/// Lấy một DataTable MenuFunction_Role từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MenuFunction_Role từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MenuFunction_Role từ Database
		/// </summary>
		List<MenuFunction_Role> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MenuFunction_Role từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MenuFunction_Role> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MenuFunction_Role> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MenuFunction_Role từ Database
		/// </summary>
		MenuFunction_Role GetObject(string schema, String FK_Role, String FK_MenuFunction);
		/// <summary>
		/// Lấy một MenuFunction_Role đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MenuFunction_Role GetObjectCon(string schema, string condition, params Object[] parameters);
		MenuFunction_Role GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MenuFunction_Role vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MenuFunction_Role _MenuFunction_Role);
		/// <summary>
		/// Insert danh sách đối tượng MenuFunction_Role vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MenuFunction_Role> _MenuFunction_Roles);
		/// <summary>
		/// Cập nhật MenuFunction_Role vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MenuFunction_Role _MenuFunction_Role, String FK_Role, String FK_MenuFunction);
		/// <summary>
		/// Cập nhật MenuFunction_Role vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MenuFunction_Role _MenuFunction_Role);
		/// <summary>
		/// Cập nhật danh sách MenuFunction_Role vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MenuFunction_Role> _MenuFunction_Roles);
		/// <summary>
		/// Cập nhật MenuFunction_Role vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MenuFunction_Role _MenuFunction_Role, string condition);
		/// <summary>
		/// Xóa MenuFunction_Role trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_Role, String FK_MenuFunction);
		/// <summary>
		/// Xóa MenuFunction_Role trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MenuFunction_Role _MenuFunction_Role);
		/// <summary>
		/// Xóa MenuFunction_Role trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MenuFunction_Role trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MenuFunction_Role> _MenuFunction_Roles);
	}
}
