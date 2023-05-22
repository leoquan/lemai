using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISChoolhocphan
	{
		/// <summary>
		/// Lấy một DataTable SchoolHocPhan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SchoolHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SchoolHocPhan từ Database
		/// </summary>
		List<SchoolHocPhan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SchoolHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SchoolHocPhan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SchoolHocPhan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SchoolHocPhan từ Database
		/// </summary>
		SchoolHocPhan GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SchoolHocPhan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SchoolHocPhan GetObjectCon(string schema, string condition, params Object[] parameters);
		SchoolHocPhan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SchoolHocPhan vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SchoolHocPhan _SchoolHocPhan);
		/// <summary>
		/// Insert danh sách đối tượng SchoolHocPhan vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SchoolHocPhan> _SchoolHocPhans);
		/// <summary>
		/// Cập nhật SchoolHocPhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SchoolHocPhan _SchoolHocPhan, String Id);
		/// <summary>
		/// Cập nhật SchoolHocPhan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SchoolHocPhan _SchoolHocPhan);
		/// <summary>
		/// Cập nhật danh sách SchoolHocPhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SchoolHocPhan> _SchoolHocPhans);
		/// <summary>
		/// Cập nhật SchoolHocPhan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SchoolHocPhan _SchoolHocPhan, string condition);
		/// <summary>
		/// Xóa SchoolHocPhan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SchoolHocPhan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SchoolHocPhan _SchoolHocPhan);
		/// <summary>
		/// Xóa SchoolHocPhan trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SchoolHocPhan trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SchoolHocPhan> _SchoolHocPhans);
	}
}
