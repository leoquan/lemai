using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISAlekhachhang
	{
		/// <summary>
		/// Lấy một DataTable SaleKhachHang từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SaleKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SaleKhachHang từ Database
		/// </summary>
		List<SaleKhachHang> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SaleKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SaleKhachHang> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SaleKhachHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SaleKhachHang từ Database
		/// </summary>
		SaleKhachHang GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SaleKhachHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SaleKhachHang GetObjectCon(string schema, string condition, params Object[] parameters);
		SaleKhachHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SaleKhachHang vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SaleKhachHang _SaleKhachHang);
		/// <summary>
		/// Insert danh sách đối tượng SaleKhachHang vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SaleKhachHang> _SaleKhachHangs);
		/// <summary>
		/// Cập nhật SaleKhachHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SaleKhachHang _SaleKhachHang, String Id);
		/// <summary>
		/// Cập nhật SaleKhachHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SaleKhachHang _SaleKhachHang);
		/// <summary>
		/// Cập nhật danh sách SaleKhachHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SaleKhachHang> _SaleKhachHangs);
		/// <summary>
		/// Cập nhật SaleKhachHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SaleKhachHang _SaleKhachHang, string condition);
		/// <summary>
		/// Xóa SaleKhachHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SaleKhachHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SaleKhachHang _SaleKhachHang);
		/// <summary>
		/// Xóa SaleKhachHang trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SaleKhachHang trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SaleKhachHang> _SaleKhachHangs);
	}
}
