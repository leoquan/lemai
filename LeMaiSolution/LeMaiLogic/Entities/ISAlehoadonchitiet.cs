using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISAlehoadonchitiet
	{
		/// <summary>
		/// Lấy một DataTable SaleHoaDonChiTiet từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SaleHoaDonChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SaleHoaDonChiTiet từ Database
		/// </summary>
		List<SaleHoaDonChiTiet> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SaleHoaDonChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SaleHoaDonChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SaleHoaDonChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SaleHoaDonChiTiet từ Database
		/// </summary>
		SaleHoaDonChiTiet GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SaleHoaDonChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SaleHoaDonChiTiet GetObjectCon(string schema, string condition, params Object[] parameters);
		SaleHoaDonChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SaleHoaDonChiTiet vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SaleHoaDonChiTiet _SaleHoaDonChiTiet);
		/// <summary>
		/// Insert danh sách đối tượng SaleHoaDonChiTiet vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SaleHoaDonChiTiet> _SaleHoaDonChiTiets);
		/// <summary>
		/// Cập nhật SaleHoaDonChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SaleHoaDonChiTiet _SaleHoaDonChiTiet, String Id);
		/// <summary>
		/// Cập nhật SaleHoaDonChiTiet vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SaleHoaDonChiTiet _SaleHoaDonChiTiet);
		/// <summary>
		/// Cập nhật danh sách SaleHoaDonChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SaleHoaDonChiTiet> _SaleHoaDonChiTiets);
		/// <summary>
		/// Cập nhật SaleHoaDonChiTiet vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SaleHoaDonChiTiet _SaleHoaDonChiTiet, string condition);
		/// <summary>
		/// Xóa SaleHoaDonChiTiet trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SaleHoaDonChiTiet trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SaleHoaDonChiTiet _SaleHoaDonChiTiet);
		/// <summary>
		/// Xóa SaleHoaDonChiTiet trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SaleHoaDonChiTiet trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SaleHoaDonChiTiet> _SaleHoaDonChiTiets);
	}
}
