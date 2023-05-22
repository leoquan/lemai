using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IROom
	{
		/// <summary>
		/// Lấy một DataTable Room từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable Room từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách Room từ Database
		/// </summary>
		List<Room> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách Room từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<Room> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<Room> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một Room từ Database
		/// </summary>
		Room GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một Room đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		Room GetObjectCon(string schema, string condition, params Object[] parameters);
		Room GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới Room vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, Room _Room);
		/// <summary>
		/// Insert danh sách đối tượng Room vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<Room> _Rooms);
		/// <summary>
		/// Cập nhật Room vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, Room _Room, String Id);
		/// <summary>
		/// Cập nhật Room vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, Room _Room);
		/// <summary>
		/// Cập nhật danh sách Room vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<Room> _Rooms);
		/// <summary>
		/// Cập nhật Room vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, Room _Room, string condition);
		/// <summary>
		/// Xóa Room trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa Room trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Room _Room);
		/// <summary>
		/// Xóa Room trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa Room trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<Room> _Rooms);
	}
}
