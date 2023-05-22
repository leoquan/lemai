using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVCxuathang
	{
		/// <summary>
		/// Lấy một DataTable VCXuatHang từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VCXuatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VCXuatHang từ Database
		/// </summary>
		List<VCXuatHang> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VCXuatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VCXuatHang> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VCXuatHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VCXuatHang từ Database
		/// </summary>
		VCXuatHang GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một VCXuatHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VCXuatHang GetObjectCon(string schema, string condition, params Object[] parameters);
		VCXuatHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VCXuatHang vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VCXuatHang _VCXuatHang);
		/// <summary>
		/// Insert danh sách đối tượng VCXuatHang vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VCXuatHang> _VCXuatHangs);
		/// <summary>
		/// Cập nhật VCXuatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VCXuatHang _VCXuatHang, String Id);
		/// <summary>
		/// Cập nhật VCXuatHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VCXuatHang _VCXuatHang);
		/// <summary>
		/// Cập nhật danh sách VCXuatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VCXuatHang> _VCXuatHangs);
		/// <summary>
		/// Cập nhật VCXuatHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VCXuatHang _VCXuatHang, string condition);
		/// <summary>
		/// Xóa VCXuatHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa VCXuatHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VCXuatHang _VCXuatHang);
		/// <summary>
		/// Xóa VCXuatHang trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VCXuatHang trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VCXuatHang> _VCXuatHangs);
	}
}
