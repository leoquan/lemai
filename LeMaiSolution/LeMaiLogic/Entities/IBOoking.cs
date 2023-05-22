using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IBOoking
	{
		/// <summary>
		/// Lấy một DataTable Booking từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable Booking từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách Booking từ Database
		/// </summary>
		List<Booking> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách Booking từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<Booking> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<Booking> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một Booking từ Database
		/// </summary>
		Booking GetObject(string schema, String Id, String FK_ConfigBookingTime);
		/// <summary>
		/// Lấy một Booking đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		Booking GetObjectCon(string schema, string condition, params Object[] parameters);
		Booking GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới Booking vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, Booking _Booking);
		/// <summary>
		/// Insert danh sách đối tượng Booking vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<Booking> _Bookings);
		/// <summary>
		/// Cập nhật Booking vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, Booking _Booking, String Id, String FK_ConfigBookingTime);
		/// <summary>
		/// Cập nhật Booking vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, Booking _Booking);
		/// <summary>
		/// Cập nhật danh sách Booking vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<Booking> _Bookings);
		/// <summary>
		/// Cập nhật Booking vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, Booking _Booking, string condition);
		/// <summary>
		/// Xóa Booking trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id, String FK_ConfigBookingTime);
		/// <summary>
		/// Xóa Booking trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Booking _Booking);
		/// <summary>
		/// Xóa Booking trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa Booking trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<Booking> _Bookings);
	}
}
