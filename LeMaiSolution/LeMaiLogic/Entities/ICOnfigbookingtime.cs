using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ICOnfigbookingtime
	{
		/// <summary>
		/// Lấy một DataTable ConfigBookingTime từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ConfigBookingTime từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ConfigBookingTime từ Database
		/// </summary>
		List<ConfigBookingTime> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ConfigBookingTime từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ConfigBookingTime> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ConfigBookingTime> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ConfigBookingTime từ Database
		/// </summary>
		ConfigBookingTime GetObject(string schema, String ID, Int32 Hour, Int32 Minute, Int32 Day);
		/// <summary>
		/// Lấy một ConfigBookingTime đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ConfigBookingTime GetObjectCon(string schema, string condition, params Object[] parameters);
		ConfigBookingTime GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ConfigBookingTime vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ConfigBookingTime _ConfigBookingTime);
		/// <summary>
		/// Insert danh sách đối tượng ConfigBookingTime vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ConfigBookingTime> _ConfigBookingTimes);
		/// <summary>
		/// Cập nhật ConfigBookingTime vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ConfigBookingTime _ConfigBookingTime, String ID, Int32 Hour, Int32 Minute, Int32 Day);
		/// <summary>
		/// Cập nhật ConfigBookingTime vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ConfigBookingTime _ConfigBookingTime);
		/// <summary>
		/// Cập nhật danh sách ConfigBookingTime vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ConfigBookingTime> _ConfigBookingTimes);
		/// <summary>
		/// Cập nhật ConfigBookingTime vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ConfigBookingTime _ConfigBookingTime, string condition);
		/// <summary>
		/// Xóa ConfigBookingTime trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String ID, Int32 Hour, Int32 Minute, Int32 Day);
		/// <summary>
		/// Xóa ConfigBookingTime trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ConfigBookingTime _ConfigBookingTime);
		/// <summary>
		/// Xóa ConfigBookingTime trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ConfigBookingTime trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ConfigBookingTime> _ConfigBookingTimes);
	}
}
