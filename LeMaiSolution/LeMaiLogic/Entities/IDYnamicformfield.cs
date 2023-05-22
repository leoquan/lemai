using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IDYnamicformfield
	{
		/// <summary>
		/// Lấy một DataTable DynamicFormField từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable DynamicFormField từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách DynamicFormField từ Database
		/// </summary>
		List<DynamicFormField> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách DynamicFormField từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<DynamicFormField> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<DynamicFormField> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một DynamicFormField từ Database
		/// </summary>
		DynamicFormField GetObject(string schema, String FK_DynamicForm, String FK_DynamicField);
		/// <summary>
		/// Lấy một DynamicFormField đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		DynamicFormField GetObjectCon(string schema, string condition, params Object[] parameters);
		DynamicFormField GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới DynamicFormField vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, DynamicFormField _DynamicFormField);
		/// <summary>
		/// Insert danh sách đối tượng DynamicFormField vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<DynamicFormField> _DynamicFormFields);
		/// <summary>
		/// Cập nhật DynamicFormField vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, DynamicFormField _DynamicFormField, String FK_DynamicForm, String FK_DynamicField);
		/// <summary>
		/// Cập nhật DynamicFormField vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, DynamicFormField _DynamicFormField);
		/// <summary>
		/// Cập nhật danh sách DynamicFormField vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<DynamicFormField> _DynamicFormFields);
		/// <summary>
		/// Cập nhật DynamicFormField vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, DynamicFormField _DynamicFormField, string condition);
		/// <summary>
		/// Xóa DynamicFormField trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_DynamicForm, String FK_DynamicField);
		/// <summary>
		/// Xóa DynamicFormField trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, DynamicFormField _DynamicFormField);
		/// <summary>
		/// Xóa DynamicFormField trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa DynamicFormField trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<DynamicFormField> _DynamicFormFields);
	}
}
