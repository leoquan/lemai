using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IDYnamicfilledforms
	{
		/// <summary>
		/// Lấy một DataTable DynamicFilledForms từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable DynamicFilledForms từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách DynamicFilledForms từ Database
		/// </summary>
		List<DynamicFilledForms> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách DynamicFilledForms từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<DynamicFilledForms> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<DynamicFilledForms> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một DynamicFilledForms từ Database
		/// </summary>
		DynamicFilledForms GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một DynamicFilledForms đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		DynamicFilledForms GetObjectCon(string schema, string condition, params Object[] parameters);
		DynamicFilledForms GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới DynamicFilledForms vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, DynamicFilledForms _DynamicFilledForms);
		/// <summary>
		/// Insert danh sách đối tượng DynamicFilledForms vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<DynamicFilledForms> _DynamicFilledFormss);
		/// <summary>
		/// Cập nhật DynamicFilledForms vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, DynamicFilledForms _DynamicFilledForms, String Id);
		/// <summary>
		/// Cập nhật DynamicFilledForms vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, DynamicFilledForms _DynamicFilledForms);
		/// <summary>
		/// Cập nhật danh sách DynamicFilledForms vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<DynamicFilledForms> _DynamicFilledFormss);
		/// <summary>
		/// Cập nhật DynamicFilledForms vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, DynamicFilledForms _DynamicFilledForms, string condition);
		/// <summary>
		/// Xóa DynamicFilledForms trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa DynamicFilledForms trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, DynamicFilledForms _DynamicFilledForms);
		/// <summary>
		/// Xóa DynamicFilledForms trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa DynamicFilledForms trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<DynamicFilledForms> _DynamicFilledFormss);
	}
}
