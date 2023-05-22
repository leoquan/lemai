using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISYsdiagrams
	{
		/// <summary>
		/// Lấy một DataTable sysdiagrams từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable sysdiagrams từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách sysdiagrams từ Database
		/// </summary>
		List<sysdiagrams> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách sysdiagrams từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<sysdiagrams> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<sysdiagrams> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một sysdiagrams từ Database
		/// </summary>
		sysdiagrams GetObject(string schema, Int32 diagram_id);
		/// <summary>
		/// Lấy một sysdiagrams đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		sysdiagrams GetObjectCon(string schema, string condition, params Object[] parameters);
		sysdiagrams GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới sysdiagrams vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, sysdiagrams _sysdiagrams);
		/// <summary>
		/// Insert danh sách đối tượng sysdiagrams vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<sysdiagrams> _sysdiagramss);
		/// <summary>
		/// Cập nhật sysdiagrams vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, sysdiagrams _sysdiagrams, Int32 diagram_id);
		/// <summary>
		/// Cập nhật sysdiagrams vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, sysdiagrams _sysdiagrams);
		/// <summary>
		/// Cập nhật danh sách sysdiagrams vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<sysdiagrams> _sysdiagramss);
		/// <summary>
		/// Cập nhật sysdiagrams vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, sysdiagrams _sysdiagrams, string condition);
		/// <summary>
		/// Xóa sysdiagrams trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 diagram_id);
		/// <summary>
		/// Xóa sysdiagrams trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, sysdiagrams _sysdiagrams);
		/// <summary>
		/// Xóa sysdiagrams trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa sysdiagrams trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<sysdiagrams> _sysdiagramss);
	}
}
