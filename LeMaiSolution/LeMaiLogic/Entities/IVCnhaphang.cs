using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVCnhaphang
	{
		/// <summary>
		/// Lấy một DataTable VCNhapHang từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VCNhapHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VCNhapHang từ Database
		/// </summary>
		List<VCNhapHang> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VCNhapHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VCNhapHang> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VCNhapHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VCNhapHang từ Database
		/// </summary>
		VCNhapHang GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một VCNhapHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VCNhapHang GetObjectCon(string schema, string condition, params Object[] parameters);
		VCNhapHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VCNhapHang vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VCNhapHang _VCNhapHang);
		/// <summary>
		/// Insert danh sách đối tượng VCNhapHang vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VCNhapHang> _VCNhapHangs);
		/// <summary>
		/// Cập nhật VCNhapHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VCNhapHang _VCNhapHang, String Id);
		/// <summary>
		/// Cập nhật VCNhapHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VCNhapHang _VCNhapHang);
		/// <summary>
		/// Cập nhật danh sách VCNhapHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VCNhapHang> _VCNhapHangs);
		/// <summary>
		/// Cập nhật VCNhapHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VCNhapHang _VCNhapHang, string condition);
		/// <summary>
		/// Xóa VCNhapHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa VCNhapHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VCNhapHang _VCNhapHang);
		/// <summary>
		/// Xóa VCNhapHang trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VCNhapHang trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VCNhapHang> _VCNhapHangs);
	}
}
