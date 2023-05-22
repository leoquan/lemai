using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IROomgroup
	{
		/// <summary>
		/// Lấy một DataTable RoomGroup từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable RoomGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách RoomGroup từ Database
		/// </summary>
		List<RoomGroup> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách RoomGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<RoomGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<RoomGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một RoomGroup từ Database
		/// </summary>
		RoomGroup GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một RoomGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		RoomGroup GetObjectCon(string schema, string condition, params Object[] parameters);
		RoomGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới RoomGroup vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, RoomGroup _RoomGroup);
		/// <summary>
		/// Insert danh sách đối tượng RoomGroup vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<RoomGroup> _RoomGroups);
		/// <summary>
		/// Cập nhật RoomGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, RoomGroup _RoomGroup, String Id);
		/// <summary>
		/// Cập nhật RoomGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, RoomGroup _RoomGroup);
		/// <summary>
		/// Cập nhật danh sách RoomGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<RoomGroup> _RoomGroups);
		/// <summary>
		/// Cập nhật RoomGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, RoomGroup _RoomGroup, string condition);
		/// <summary>
		/// Xóa RoomGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa RoomGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, RoomGroup _RoomGroup);
		/// <summary>
		/// Xóa RoomGroup trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa RoomGroup trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<RoomGroup> _RoomGroups);
	}
}
