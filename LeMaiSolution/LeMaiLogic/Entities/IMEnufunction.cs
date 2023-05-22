using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEnufunction
	{
		/// <summary>
		/// Lấy một DataTable MenuFunction từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MenuFunction từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MenuFunction từ Database
		/// </summary>
		List<MenuFunction> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MenuFunction từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MenuFunction> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MenuFunction> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MenuFunction từ Database
		/// </summary>
		MenuFunction GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MenuFunction đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MenuFunction GetObjectCon(string schema, string condition, params Object[] parameters);
		MenuFunction GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MenuFunction vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MenuFunction _MenuFunction);
		/// <summary>
		/// Insert danh sách đối tượng MenuFunction vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MenuFunction> _MenuFunctions);
		/// <summary>
		/// Cập nhật MenuFunction vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MenuFunction _MenuFunction, String Id);
		/// <summary>
		/// Cập nhật MenuFunction vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MenuFunction _MenuFunction);
		/// <summary>
		/// Cập nhật danh sách MenuFunction vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MenuFunction> _MenuFunctions);
		/// <summary>
		/// Cập nhật MenuFunction vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MenuFunction _MenuFunction, string condition);
		/// <summary>
		/// Xóa MenuFunction trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MenuFunction trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MenuFunction _MenuFunction);
		/// <summary>
		/// Xóa MenuFunction trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MenuFunction trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MenuFunction> _MenuFunctions);
	}
}
