using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcomplainservice
	{
		/// <summary>
		/// Lấy một DataTable ExpComplainService từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpComplainService từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpComplainService từ Database
		/// </summary>
		List<ExpComplainService> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpComplainService từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpComplainService> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpComplainService> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpComplainService từ Database
		/// </summary>
		ExpComplainService GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpComplainService đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpComplainService GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpComplainService GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpComplainService vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpComplainService _ExpComplainService);
		/// <summary>
		/// Insert danh sách đối tượng ExpComplainService vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpComplainService> _ExpComplainServices);
		/// <summary>
		/// Cập nhật ExpComplainService vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpComplainService _ExpComplainService, String Id);
		/// <summary>
		/// Cập nhật ExpComplainService vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpComplainService _ExpComplainService);
		/// <summary>
		/// Cập nhật danh sách ExpComplainService vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpComplainService> _ExpComplainServices);
		/// <summary>
		/// Cập nhật ExpComplainService vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpComplainService _ExpComplainService, string condition);
		/// <summary>
		/// Xóa ExpComplainService trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpComplainService trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpComplainService _ExpComplainService);
		/// <summary>
		/// Xóa ExpComplainService trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpComplainService trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpComplainService> _ExpComplainServices);
	}
}
