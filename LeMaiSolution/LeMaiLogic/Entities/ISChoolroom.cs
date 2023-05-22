using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISChoolroom
	{
		/// <summary>
		/// Lấy một DataTable SchoolRoom từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SchoolRoom từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SchoolRoom từ Database
		/// </summary>
		List<SchoolRoom> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SchoolRoom từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SchoolRoom> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SchoolRoom> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SchoolRoom từ Database
		/// </summary>
		SchoolRoom GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SchoolRoom đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SchoolRoom GetObjectCon(string schema, string condition, params Object[] parameters);
		SchoolRoom GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SchoolRoom vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SchoolRoom _SchoolRoom);
		/// <summary>
		/// Insert danh sách đối tượng SchoolRoom vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SchoolRoom> _SchoolRooms);
		/// <summary>
		/// Cập nhật SchoolRoom vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SchoolRoom _SchoolRoom, String Id);
		/// <summary>
		/// Cập nhật SchoolRoom vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SchoolRoom _SchoolRoom);
		/// <summary>
		/// Cập nhật danh sách SchoolRoom vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SchoolRoom> _SchoolRooms);
		/// <summary>
		/// Cập nhật SchoolRoom vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SchoolRoom _SchoolRoom, string condition);
		/// <summary>
		/// Xóa SchoolRoom trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SchoolRoom trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SchoolRoom _SchoolRoom);
		/// <summary>
		/// Xóa SchoolRoom trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SchoolRoom trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SchoolRoom> _SchoolRooms);
	}
}
