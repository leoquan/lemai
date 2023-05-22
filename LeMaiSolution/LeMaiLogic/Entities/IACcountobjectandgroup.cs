using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IACcountobjectandgroup
	{
		/// <summary>
		/// Lấy một DataTable AccountObjectAndGroup từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable AccountObjectAndGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách AccountObjectAndGroup từ Database
		/// </summary>
		List<AccountObjectAndGroup> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách AccountObjectAndGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<AccountObjectAndGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<AccountObjectAndGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một AccountObjectAndGroup từ Database
		/// </summary>
		AccountObjectAndGroup GetObject(string schema, String FK_Account, String FK_Group);
		/// <summary>
		/// Lấy một AccountObjectAndGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		AccountObjectAndGroup GetObjectCon(string schema, string condition, params Object[] parameters);
		AccountObjectAndGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới AccountObjectAndGroup vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, AccountObjectAndGroup _AccountObjectAndGroup);
		/// <summary>
		/// Insert danh sách đối tượng AccountObjectAndGroup vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<AccountObjectAndGroup> _AccountObjectAndGroups);
		/// <summary>
		/// Cập nhật AccountObjectAndGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, AccountObjectAndGroup _AccountObjectAndGroup, String FK_Account, String FK_Group);
		/// <summary>
		/// Cập nhật AccountObjectAndGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, AccountObjectAndGroup _AccountObjectAndGroup);
		/// <summary>
		/// Cập nhật danh sách AccountObjectAndGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<AccountObjectAndGroup> _AccountObjectAndGroups);
		/// <summary>
		/// Cập nhật AccountObjectAndGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, AccountObjectAndGroup _AccountObjectAndGroup, string condition);
		/// <summary>
		/// Xóa AccountObjectAndGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_Account, String FK_Group);
		/// <summary>
		/// Xóa AccountObjectAndGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, AccountObjectAndGroup _AccountObjectAndGroup);
		/// <summary>
		/// Xóa AccountObjectAndGroup trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa AccountObjectAndGroup trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<AccountObjectAndGroup> _AccountObjectAndGroups);
	}
}
