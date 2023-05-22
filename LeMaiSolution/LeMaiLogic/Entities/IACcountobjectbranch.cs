using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IACcountobjectbranch
	{
		/// <summary>
		/// Lấy một DataTable AccountObjectBranch từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable AccountObjectBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách AccountObjectBranch từ Database
		/// </summary>
		List<AccountObjectBranch> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách AccountObjectBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<AccountObjectBranch> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<AccountObjectBranch> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một AccountObjectBranch từ Database
		/// </summary>
		AccountObjectBranch GetObject(string schema, String FK_Branch, String FK_AccountObject);
		/// <summary>
		/// Lấy một AccountObjectBranch đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		AccountObjectBranch GetObjectCon(string schema, string condition, params Object[] parameters);
		AccountObjectBranch GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới AccountObjectBranch vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, AccountObjectBranch _AccountObjectBranch);
		/// <summary>
		/// Insert danh sách đối tượng AccountObjectBranch vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<AccountObjectBranch> _AccountObjectBranchs);
		/// <summary>
		/// Cập nhật AccountObjectBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, AccountObjectBranch _AccountObjectBranch, String FK_Branch, String FK_AccountObject);
		/// <summary>
		/// Cập nhật AccountObjectBranch vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, AccountObjectBranch _AccountObjectBranch);
		/// <summary>
		/// Cập nhật danh sách AccountObjectBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<AccountObjectBranch> _AccountObjectBranchs);
		/// <summary>
		/// Cập nhật AccountObjectBranch vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, AccountObjectBranch _AccountObjectBranch, string condition);
		/// <summary>
		/// Xóa AccountObjectBranch trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_Branch, String FK_AccountObject);
		/// <summary>
		/// Xóa AccountObjectBranch trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, AccountObjectBranch _AccountObjectBranch);
		/// <summary>
		/// Xóa AccountObjectBranch trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa AccountObjectBranch trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<AccountObjectBranch> _AccountObjectBranchs);
	}
}
