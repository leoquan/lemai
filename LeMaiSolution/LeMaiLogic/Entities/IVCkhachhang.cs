using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVCkhachhang
	{
		/// <summary>
		/// Lấy một DataTable VCKhachHang từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VCKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VCKhachHang từ Database
		/// </summary>
		List<VCKhachHang> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VCKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VCKhachHang> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VCKhachHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VCKhachHang từ Database
		/// </summary>
		VCKhachHang GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một VCKhachHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VCKhachHang GetObjectCon(string schema, string condition, params Object[] parameters);
		VCKhachHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VCKhachHang vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VCKhachHang _VCKhachHang);
		/// <summary>
		/// Insert danh sách đối tượng VCKhachHang vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VCKhachHang> _VCKhachHangs);
		/// <summary>
		/// Cập nhật VCKhachHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VCKhachHang _VCKhachHang, String Id);
		/// <summary>
		/// Cập nhật VCKhachHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VCKhachHang _VCKhachHang);
		/// <summary>
		/// Cập nhật danh sách VCKhachHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VCKhachHang> _VCKhachHangs);
		/// <summary>
		/// Cập nhật VCKhachHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VCKhachHang _VCKhachHang, string condition);
		/// <summary>
		/// Xóa VCKhachHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa VCKhachHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VCKhachHang _VCKhachHang);
		/// <summary>
		/// Xóa VCKhachHang trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VCKhachHang trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VCKhachHang> _VCKhachHangs);
	}
}
