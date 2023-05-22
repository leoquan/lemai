using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IDYnamicform
	{
		/// <summary>
		/// Lấy một DataTable DynamicForm từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable DynamicForm từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách DynamicForm từ Database
		/// </summary>
		List<DynamicForm> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách DynamicForm từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<DynamicForm> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<DynamicForm> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một DynamicForm từ Database
		/// </summary>
		DynamicForm GetObject(string schema, String FormName);
		/// <summary>
		/// Lấy một DynamicForm đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		DynamicForm GetObjectCon(string schema, string condition, params Object[] parameters);
		DynamicForm GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới DynamicForm vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, DynamicForm _DynamicForm);
		/// <summary>
		/// Insert danh sách đối tượng DynamicForm vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<DynamicForm> _DynamicForms);
		/// <summary>
		/// Cập nhật DynamicForm vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, DynamicForm _DynamicForm, String FormName);
		/// <summary>
		/// Cập nhật DynamicForm vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, DynamicForm _DynamicForm);
		/// <summary>
		/// Cập nhật danh sách DynamicForm vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<DynamicForm> _DynamicForms);
		/// <summary>
		/// Cập nhật DynamicForm vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, DynamicForm _DynamicForm, string condition);
		/// <summary>
		/// Xóa DynamicForm trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FormName);
		/// <summary>
		/// Xóa DynamicForm trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, DynamicForm _DynamicForm);
		/// <summary>
		/// Xóa DynamicForm trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa DynamicForm trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<DynamicForm> _DynamicForms);
	}
}
