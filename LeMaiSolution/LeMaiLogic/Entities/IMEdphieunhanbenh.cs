using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdphieunhanbenh
	{
		/// <summary>
		/// Lấy một DataTable MedPhieuNhanBenh từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedPhieuNhanBenh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedPhieuNhanBenh từ Database
		/// </summary>
		List<MedPhieuNhanBenh> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedPhieuNhanBenh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedPhieuNhanBenh> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedPhieuNhanBenh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedPhieuNhanBenh từ Database
		/// </summary>
		MedPhieuNhanBenh GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedPhieuNhanBenh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedPhieuNhanBenh GetObjectCon(string schema, string condition, params Object[] parameters);
		MedPhieuNhanBenh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedPhieuNhanBenh vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedPhieuNhanBenh _MedPhieuNhanBenh);
		/// <summary>
		/// Insert danh sách đối tượng MedPhieuNhanBenh vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedPhieuNhanBenh> _MedPhieuNhanBenhs);
		/// <summary>
		/// Cập nhật MedPhieuNhanBenh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedPhieuNhanBenh _MedPhieuNhanBenh, String id);
		/// <summary>
		/// Cập nhật MedPhieuNhanBenh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedPhieuNhanBenh _MedPhieuNhanBenh);
		/// <summary>
		/// Cập nhật danh sách MedPhieuNhanBenh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedPhieuNhanBenh> _MedPhieuNhanBenhs);
		/// <summary>
		/// Cập nhật MedPhieuNhanBenh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedPhieuNhanBenh _MedPhieuNhanBenh, string condition);
		/// <summary>
		/// Xóa MedPhieuNhanBenh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedPhieuNhanBenh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedPhieuNhanBenh _MedPhieuNhanBenh);
		/// <summary>
		/// Xóa MedPhieuNhanBenh trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedPhieuNhanBenh trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedPhieuNhanBenh> _MedPhieuNhanBenhs);
	}
}
