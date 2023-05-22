using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IDYnamicfield
	{
		/// <summary>
		/// Lấy một DataTable DynamicField từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable DynamicField từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách DynamicField từ Database
		/// </summary>
		List<DynamicField> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách DynamicField từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<DynamicField> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<DynamicField> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một DynamicField từ Database
		/// </summary>
		DynamicField GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một DynamicField đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		DynamicField GetObjectCon(string schema, string condition, params Object[] parameters);
		DynamicField GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới DynamicField vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, DynamicField _DynamicField);
		/// <summary>
		/// Insert danh sách đối tượng DynamicField vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<DynamicField> _DynamicFields);
		/// <summary>
		/// Cập nhật DynamicField vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, DynamicField _DynamicField, String Id);
		/// <summary>
		/// Cập nhật DynamicField vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, DynamicField _DynamicField);
		/// <summary>
		/// Cập nhật danh sách DynamicField vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<DynamicField> _DynamicFields);
		/// <summary>
		/// Cập nhật DynamicField vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, DynamicField _DynamicField, string condition);
		/// <summary>
		/// Xóa DynamicField trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa DynamicField trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, DynamicField _DynamicField);
		/// <summary>
		/// Xóa DynamicField trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa DynamicField trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<DynamicField> _DynamicFields);
	}
}
