using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IACcountobjectgroup
	{
		/// <summary>
		/// Lấy một DataTable AccountObjectGroup từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable AccountObjectGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách AccountObjectGroup từ Database
		/// </summary>
		List<AccountObjectGroup> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách AccountObjectGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<AccountObjectGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<AccountObjectGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một AccountObjectGroup từ Database
		/// </summary>
		AccountObjectGroup GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một AccountObjectGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		AccountObjectGroup GetObjectCon(string schema, string condition, params Object[] parameters);
		AccountObjectGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới AccountObjectGroup vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, AccountObjectGroup _AccountObjectGroup);
		/// <summary>
		/// Insert danh sách đối tượng AccountObjectGroup vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<AccountObjectGroup> _AccountObjectGroups);
		/// <summary>
		/// Cập nhật AccountObjectGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, AccountObjectGroup _AccountObjectGroup, String Id);
		/// <summary>
		/// Cập nhật AccountObjectGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, AccountObjectGroup _AccountObjectGroup);
		/// <summary>
		/// Cập nhật danh sách AccountObjectGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<AccountObjectGroup> _AccountObjectGroups);
		/// <summary>
		/// Cập nhật AccountObjectGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, AccountObjectGroup _AccountObjectGroup, string condition);
		/// <summary>
		/// Xóa AccountObjectGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa AccountObjectGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, AccountObjectGroup _AccountObjectGroup);
		/// <summary>
		/// Xóa AccountObjectGroup trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa AccountObjectGroup trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<AccountObjectGroup> _AccountObjectGroups);
	}
}
