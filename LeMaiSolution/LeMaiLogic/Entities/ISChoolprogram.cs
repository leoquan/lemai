using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISChoolprogram
	{
		/// <summary>
		/// Lấy một DataTable SchoolProgram từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SchoolProgram từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SchoolProgram từ Database
		/// </summary>
		List<SchoolProgram> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SchoolProgram từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SchoolProgram> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SchoolProgram> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SchoolProgram từ Database
		/// </summary>
		SchoolProgram GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SchoolProgram đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SchoolProgram GetObjectCon(string schema, string condition, params Object[] parameters);
		SchoolProgram GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SchoolProgram vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SchoolProgram _SchoolProgram);
		/// <summary>
		/// Insert danh sách đối tượng SchoolProgram vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SchoolProgram> _SchoolPrograms);
		/// <summary>
		/// Cập nhật SchoolProgram vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SchoolProgram _SchoolProgram, String Id);
		/// <summary>
		/// Cập nhật SchoolProgram vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SchoolProgram _SchoolProgram);
		/// <summary>
		/// Cập nhật danh sách SchoolProgram vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SchoolProgram> _SchoolPrograms);
		/// <summary>
		/// Cập nhật SchoolProgram vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SchoolProgram _SchoolProgram, string condition);
		/// <summary>
		/// Xóa SchoolProgram trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SchoolProgram trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SchoolProgram _SchoolProgram);
		/// <summary>
		/// Xóa SchoolProgram trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SchoolProgram trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SchoolProgram> _SchoolPrograms);
	}
}
