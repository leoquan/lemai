using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpdestination
	{
		/// <summary>
		/// Lấy một DataTable ExpDestination từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpDestination từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpDestination từ Database
		/// </summary>
		List<ExpDestination> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpDestination từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpDestination> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpDestination> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpDestination từ Database
		/// </summary>
		ExpDestination GetObject(string schema, String ExpId);
		/// <summary>
		/// Lấy một ExpDestination đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpDestination GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpDestination GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpDestination vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpDestination _ExpDestination);
		/// <summary>
		/// Insert danh sách đối tượng ExpDestination vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpDestination> _ExpDestinations);
		/// <summary>
		/// Cập nhật ExpDestination vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpDestination _ExpDestination, String ExpId);
		/// <summary>
		/// Cập nhật ExpDestination vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpDestination _ExpDestination);
		/// <summary>
		/// Cập nhật danh sách ExpDestination vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpDestination> _ExpDestinations);
		/// <summary>
		/// Cập nhật ExpDestination vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpDestination _ExpDestination, string condition);
		/// <summary>
		/// Xóa ExpDestination trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String ExpId);
		/// <summary>
		/// Xóa ExpDestination trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpDestination _ExpDestination);
		/// <summary>
		/// Xóa ExpDestination trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpDestination trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpDestination> _ExpDestinations);
	}
}
