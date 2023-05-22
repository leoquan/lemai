using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXploaimathang
	{
		/// <summary>
		/// Lấy một DataTable ExpLoaiMatHang từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpLoaiMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpLoaiMatHang từ Database
		/// </summary>
		List<ExpLoaiMatHang> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpLoaiMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpLoaiMatHang> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpLoaiMatHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpLoaiMatHang từ Database
		/// </summary>
		ExpLoaiMatHang GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpLoaiMatHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpLoaiMatHang GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpLoaiMatHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpLoaiMatHang vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpLoaiMatHang _ExpLoaiMatHang);
		/// <summary>
		/// Insert danh sách đối tượng ExpLoaiMatHang vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpLoaiMatHang> _ExpLoaiMatHangs);
		/// <summary>
		/// Cập nhật ExpLoaiMatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpLoaiMatHang _ExpLoaiMatHang, String Id);
		/// <summary>
		/// Cập nhật ExpLoaiMatHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpLoaiMatHang _ExpLoaiMatHang);
		/// <summary>
		/// Cập nhật danh sách ExpLoaiMatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpLoaiMatHang> _ExpLoaiMatHangs);
		/// <summary>
		/// Cập nhật ExpLoaiMatHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpLoaiMatHang _ExpLoaiMatHang, string condition);
		/// <summary>
		/// Xóa ExpLoaiMatHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpLoaiMatHang trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpLoaiMatHang _ExpLoaiMatHang);
		/// <summary>
		/// Xóa ExpLoaiMatHang trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpLoaiMatHang trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpLoaiMatHang> _ExpLoaiMatHangs);
	}
}
