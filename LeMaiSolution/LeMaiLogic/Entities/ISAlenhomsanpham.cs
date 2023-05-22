using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISAlenhomsanpham
	{
		/// <summary>
		/// Lấy một DataTable SaleNhomSanPham từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SaleNhomSanPham từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SaleNhomSanPham từ Database
		/// </summary>
		List<SaleNhomSanPham> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SaleNhomSanPham từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SaleNhomSanPham> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SaleNhomSanPham> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SaleNhomSanPham từ Database
		/// </summary>
		SaleNhomSanPham GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SaleNhomSanPham đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SaleNhomSanPham GetObjectCon(string schema, string condition, params Object[] parameters);
		SaleNhomSanPham GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SaleNhomSanPham vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SaleNhomSanPham _SaleNhomSanPham);
		/// <summary>
		/// Insert danh sách đối tượng SaleNhomSanPham vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SaleNhomSanPham> _SaleNhomSanPhams);
		/// <summary>
		/// Cập nhật SaleNhomSanPham vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SaleNhomSanPham _SaleNhomSanPham, String Id);
		/// <summary>
		/// Cập nhật SaleNhomSanPham vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SaleNhomSanPham _SaleNhomSanPham);
		/// <summary>
		/// Cập nhật danh sách SaleNhomSanPham vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SaleNhomSanPham> _SaleNhomSanPhams);
		/// <summary>
		/// Cập nhật SaleNhomSanPham vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SaleNhomSanPham _SaleNhomSanPham, string condition);
		/// <summary>
		/// Xóa SaleNhomSanPham trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SaleNhomSanPham trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SaleNhomSanPham _SaleNhomSanPham);
		/// <summary>
		/// Xóa SaleNhomSanPham trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SaleNhomSanPham trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SaleNhomSanPham> _SaleNhomSanPhams);
	}
}
