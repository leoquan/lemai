using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMAmnonhocvien
	{
		/// <summary>
		/// Lấy một DataTable MamNonHocVien từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MamNonHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MamNonHocVien từ Database
		/// </summary>
		List<MamNonHocVien> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MamNonHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MamNonHocVien> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MamNonHocVien> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MamNonHocVien từ Database
		/// </summary>
		MamNonHocVien GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MamNonHocVien đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MamNonHocVien GetObjectCon(string schema, string condition, params Object[] parameters);
		MamNonHocVien GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MamNonHocVien vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MamNonHocVien _MamNonHocVien);
		/// <summary>
		/// Insert danh sách đối tượng MamNonHocVien vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MamNonHocVien> _MamNonHocViens);
		/// <summary>
		/// Cập nhật MamNonHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MamNonHocVien _MamNonHocVien, String Id);
		/// <summary>
		/// Cập nhật MamNonHocVien vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MamNonHocVien _MamNonHocVien);
		/// <summary>
		/// Cập nhật danh sách MamNonHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MamNonHocVien> _MamNonHocViens);
		/// <summary>
		/// Cập nhật MamNonHocVien vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MamNonHocVien _MamNonHocVien, string condition);
		/// <summary>
		/// Xóa MamNonHocVien trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MamNonHocVien trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MamNonHocVien _MamNonHocVien);
		/// <summary>
		/// Xóa MamNonHocVien trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MamNonHocVien trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MamNonHocVien> _MamNonHocViens);
	}
}
