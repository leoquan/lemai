using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISChoolhocvien
	{
		/// <summary>
		/// Lấy một DataTable SchoolHocVien từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SchoolHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SchoolHocVien từ Database
		/// </summary>
		List<SchoolHocVien> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SchoolHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SchoolHocVien> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SchoolHocVien> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SchoolHocVien từ Database
		/// </summary>
		SchoolHocVien GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SchoolHocVien đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SchoolHocVien GetObjectCon(string schema, string condition, params Object[] parameters);
		SchoolHocVien GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SchoolHocVien vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SchoolHocVien _SchoolHocVien);
		/// <summary>
		/// Insert danh sách đối tượng SchoolHocVien vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SchoolHocVien> _SchoolHocViens);
		/// <summary>
		/// Cập nhật SchoolHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SchoolHocVien _SchoolHocVien, String Id);
		/// <summary>
		/// Cập nhật SchoolHocVien vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SchoolHocVien _SchoolHocVien);
		/// <summary>
		/// Cập nhật danh sách SchoolHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SchoolHocVien> _SchoolHocViens);
		/// <summary>
		/// Cập nhật SchoolHocVien vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SchoolHocVien _SchoolHocVien, string condition);
		/// <summary>
		/// Xóa SchoolHocVien trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SchoolHocVien trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SchoolHocVien _SchoolHocVien);
		/// <summary>
		/// Xóa SchoolHocVien trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SchoolHocVien trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SchoolHocVien> _SchoolHocViens);
	}
}
