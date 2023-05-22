using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISAlebanggiachitiet
	{
		/// <summary>
		/// Lấy một DataTable SaleBangGiaChiTiet từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SaleBangGiaChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SaleBangGiaChiTiet từ Database
		/// </summary>
		List<SaleBangGiaChiTiet> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SaleBangGiaChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SaleBangGiaChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SaleBangGiaChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SaleBangGiaChiTiet từ Database
		/// </summary>
		SaleBangGiaChiTiet GetObject(string schema, String FK_BangGia, String FK_SanPham);
		/// <summary>
		/// Lấy một SaleBangGiaChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SaleBangGiaChiTiet GetObjectCon(string schema, string condition, params Object[] parameters);
		SaleBangGiaChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SaleBangGiaChiTiet vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SaleBangGiaChiTiet _SaleBangGiaChiTiet);
		/// <summary>
		/// Insert danh sách đối tượng SaleBangGiaChiTiet vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SaleBangGiaChiTiet> _SaleBangGiaChiTiets);
		/// <summary>
		/// Cập nhật SaleBangGiaChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SaleBangGiaChiTiet _SaleBangGiaChiTiet, String FK_BangGia, String FK_SanPham);
		/// <summary>
		/// Cập nhật SaleBangGiaChiTiet vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SaleBangGiaChiTiet _SaleBangGiaChiTiet);
		/// <summary>
		/// Cập nhật danh sách SaleBangGiaChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SaleBangGiaChiTiet> _SaleBangGiaChiTiets);
		/// <summary>
		/// Cập nhật SaleBangGiaChiTiet vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SaleBangGiaChiTiet _SaleBangGiaChiTiet, string condition);
		/// <summary>
		/// Xóa SaleBangGiaChiTiet trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_BangGia, String FK_SanPham);
		/// <summary>
		/// Xóa SaleBangGiaChiTiet trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SaleBangGiaChiTiet _SaleBangGiaChiTiet);
		/// <summary>
		/// Xóa SaleBangGiaChiTiet trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SaleBangGiaChiTiet trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SaleBangGiaChiTiet> _SaleBangGiaChiTiets);
	}
}
