using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IDYnamicfilledformfields
	{
		/// <summary>
		/// Lấy một DataTable DynamicFilledFormFields từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable DynamicFilledFormFields từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách DynamicFilledFormFields từ Database
		/// </summary>
		List<DynamicFilledFormFields> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách DynamicFilledFormFields từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<DynamicFilledFormFields> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<DynamicFilledFormFields> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một DynamicFilledFormFields từ Database
		/// </summary>
		DynamicFilledFormFields GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một DynamicFilledFormFields đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		DynamicFilledFormFields GetObjectCon(string schema, string condition, params Object[] parameters);
		DynamicFilledFormFields GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới DynamicFilledFormFields vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, DynamicFilledFormFields _DynamicFilledFormFields);
		/// <summary>
		/// Insert danh sách đối tượng DynamicFilledFormFields vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<DynamicFilledFormFields> _DynamicFilledFormFieldss);
		/// <summary>
		/// Cập nhật DynamicFilledFormFields vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, DynamicFilledFormFields _DynamicFilledFormFields, String Id);
		/// <summary>
		/// Cập nhật DynamicFilledFormFields vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, DynamicFilledFormFields _DynamicFilledFormFields);
		/// <summary>
		/// Cập nhật danh sách DynamicFilledFormFields vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<DynamicFilledFormFields> _DynamicFilledFormFieldss);
		/// <summary>
		/// Cập nhật DynamicFilledFormFields vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, DynamicFilledFormFields _DynamicFilledFormFields, string condition);
		/// <summary>
		/// Xóa DynamicFilledFormFields trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa DynamicFilledFormFields trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, DynamicFilledFormFields _DynamicFilledFormFields);
		/// <summary>
		/// Xóa DynamicFilledFormFields trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa DynamicFilledFormFields trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<DynamicFilledFormFields> _DynamicFilledFormFieldss);
	}
}
