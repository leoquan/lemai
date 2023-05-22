using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdphieunhanbenhchitiet
	{
		/// <summary>
		/// Lấy một DataTable MedPhieuNhanBenhChiTiet từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedPhieuNhanBenhChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedPhieuNhanBenhChiTiet từ Database
		/// </summary>
		List<MedPhieuNhanBenhChiTiet> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedPhieuNhanBenhChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedPhieuNhanBenhChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedPhieuNhanBenhChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedPhieuNhanBenhChiTiet từ Database
		/// </summary>
		MedPhieuNhanBenhChiTiet GetObject(string schema, String id_phieunhanbenh, Int32 stt);
		/// <summary>
		/// Lấy một MedPhieuNhanBenhChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedPhieuNhanBenhChiTiet GetObjectCon(string schema, string condition, params Object[] parameters);
		MedPhieuNhanBenhChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedPhieuNhanBenhChiTiet vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedPhieuNhanBenhChiTiet _MedPhieuNhanBenhChiTiet);
		/// <summary>
		/// Insert danh sách đối tượng MedPhieuNhanBenhChiTiet vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedPhieuNhanBenhChiTiet> _MedPhieuNhanBenhChiTiets);
		/// <summary>
		/// Cập nhật MedPhieuNhanBenhChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedPhieuNhanBenhChiTiet _MedPhieuNhanBenhChiTiet, String id_phieunhanbenh, Int32 stt);
		/// <summary>
		/// Cập nhật MedPhieuNhanBenhChiTiet vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedPhieuNhanBenhChiTiet _MedPhieuNhanBenhChiTiet);
		/// <summary>
		/// Cập nhật danh sách MedPhieuNhanBenhChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedPhieuNhanBenhChiTiet> _MedPhieuNhanBenhChiTiets);
		/// <summary>
		/// Cập nhật MedPhieuNhanBenhChiTiet vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedPhieuNhanBenhChiTiet _MedPhieuNhanBenhChiTiet, string condition);
		/// <summary>
		/// Xóa MedPhieuNhanBenhChiTiet trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id_phieunhanbenh, Int32 stt);
		/// <summary>
		/// Xóa MedPhieuNhanBenhChiTiet trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedPhieuNhanBenhChiTiet _MedPhieuNhanBenhChiTiet);
		/// <summary>
		/// Xóa MedPhieuNhanBenhChiTiet trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedPhieuNhanBenhChiTiet trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedPhieuNhanBenhChiTiet> _MedPhieuNhanBenhChiTiets);
	}
}
