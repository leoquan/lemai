using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IACcountobjectcommission
	{
		/// <summary>
		/// Lấy một DataTable AccountObjectCommission từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable AccountObjectCommission từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách AccountObjectCommission từ Database
		/// </summary>
		List<AccountObjectCommission> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách AccountObjectCommission từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<AccountObjectCommission> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<AccountObjectCommission> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một AccountObjectCommission từ Database
		/// </summary>
		AccountObjectCommission GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một AccountObjectCommission đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		AccountObjectCommission GetObjectCon(string schema, string condition, params Object[] parameters);
		AccountObjectCommission GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới AccountObjectCommission vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, AccountObjectCommission _AccountObjectCommission);
		/// <summary>
		/// Insert danh sách đối tượng AccountObjectCommission vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<AccountObjectCommission> _AccountObjectCommissions);
		/// <summary>
		/// Cập nhật AccountObjectCommission vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, AccountObjectCommission _AccountObjectCommission, String Id);
		/// <summary>
		/// Cập nhật AccountObjectCommission vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, AccountObjectCommission _AccountObjectCommission);
		/// <summary>
		/// Cập nhật danh sách AccountObjectCommission vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<AccountObjectCommission> _AccountObjectCommissions);
		/// <summary>
		/// Cập nhật AccountObjectCommission vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, AccountObjectCommission _AccountObjectCommission, string condition);
		/// <summary>
		/// Xóa AccountObjectCommission trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa AccountObjectCommission trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, AccountObjectCommission _AccountObjectCommission);
		/// <summary>
		/// Xóa AccountObjectCommission trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa AccountObjectCommission trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<AccountObjectCommission> _AccountObjectCommissions);
	}
}
