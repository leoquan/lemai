using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVCmathang
	{
		/// <summary>
		/// Lấy một DataTable VCMatHang từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VCMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VCMatHang từ Database
		/// </summary>
		List<VCMatHang> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VCMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VCMatHang> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VCMatHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VCMatHang từ Database
		/// </summary>
		VCMatHang GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một VCMatHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VCMatHang GetObjectCon(string schema, string condition, params Object[] parameters);
		VCMatHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VCMatHang vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VCMatHang _VCMatHang);
		/// <summary>
		/// Insert danh sách đối tượng VCMatHang vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VCMatHang> _VCMatHangs);
		/// <summary>
		/// Cập nhật VCMatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VCMatHang _VCMatHang, String Id);
		/// <summary>
		/// Cập nhật VCMatHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VCMatHang _VCMatHang);
		/// <summary>
		/// Cập nhật danh sách VCMatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VCMatHang> _VCMatHangs);
		/// <summary>
		/// Cập nhật VCMatHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VCMatHang _VCMatHang, string condition);
		/// <summary>
		/// Xóa VCMatHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa VCMatHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VCMatHang _VCMatHang);
		/// <summary>
		/// Xóa VCMatHang trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VCMatHang trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VCMatHang> _VCMatHangs);
	}
}
