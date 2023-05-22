using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IBOokingdetail
	{
		/// <summary>
		/// Lấy một DataTable BookingDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable BookingDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách BookingDetail từ Database
		/// </summary>
		List<BookingDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách BookingDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<BookingDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<BookingDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một BookingDetail từ Database
		/// </summary>
		BookingDetail GetObject(string schema, String ID);
		/// <summary>
		/// Lấy một BookingDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		BookingDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		BookingDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới BookingDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, BookingDetail _BookingDetail);
		/// <summary>
		/// Insert danh sách đối tượng BookingDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<BookingDetail> _BookingDetails);
		/// <summary>
		/// Cập nhật BookingDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, BookingDetail _BookingDetail, String ID);
		/// <summary>
		/// Cập nhật BookingDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, BookingDetail _BookingDetail);
		/// <summary>
		/// Cập nhật danh sách BookingDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<BookingDetail> _BookingDetails);
		/// <summary>
		/// Cập nhật BookingDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, BookingDetail _BookingDetail, string condition);
		/// <summary>
		/// Xóa BookingDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String ID);
		/// <summary>
		/// Xóa BookingDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, BookingDetail _BookingDetail);
		/// <summary>
		/// Xóa BookingDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa BookingDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<BookingDetail> _BookingDetails);
	}
}
