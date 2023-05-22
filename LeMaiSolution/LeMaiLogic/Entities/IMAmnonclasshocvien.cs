using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMAmnonclasshocvien
	{
		/// <summary>
		/// Lấy một DataTable MamNonClassHocVien từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MamNonClassHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MamNonClassHocVien từ Database
		/// </summary>
		List<MamNonClassHocVien> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MamNonClassHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MamNonClassHocVien> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MamNonClassHocVien> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MamNonClassHocVien từ Database
		/// </summary>
		MamNonClassHocVien GetObject(string schema, String FK_MamNonClass, String FK_MamNonHocVien);
		/// <summary>
		/// Lấy một MamNonClassHocVien đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MamNonClassHocVien GetObjectCon(string schema, string condition, params Object[] parameters);
		MamNonClassHocVien GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MamNonClassHocVien vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MamNonClassHocVien _MamNonClassHocVien);
		/// <summary>
		/// Insert danh sách đối tượng MamNonClassHocVien vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MamNonClassHocVien> _MamNonClassHocViens);
		/// <summary>
		/// Cập nhật MamNonClassHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MamNonClassHocVien _MamNonClassHocVien, String FK_MamNonClass, String FK_MamNonHocVien);
		/// <summary>
		/// Cập nhật MamNonClassHocVien vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MamNonClassHocVien _MamNonClassHocVien);
		/// <summary>
		/// Cập nhật danh sách MamNonClassHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MamNonClassHocVien> _MamNonClassHocViens);
		/// <summary>
		/// Cập nhật MamNonClassHocVien vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MamNonClassHocVien _MamNonClassHocVien, string condition);
		/// <summary>
		/// Xóa MamNonClassHocVien trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_MamNonClass, String FK_MamNonHocVien);
		/// <summary>
		/// Xóa MamNonClassHocVien trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MamNonClassHocVien _MamNonClassHocVien);
		/// <summary>
		/// Xóa MamNonClassHocVien trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MamNonClassHocVien trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MamNonClassHocVien> _MamNonClassHocViens);
	}
}
