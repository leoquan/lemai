using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEnufunctionaccount
	{
		/// <summary>
		/// Lấy một DataTable MenuFunction_Account từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MenuFunction_Account từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MenuFunction_Account từ Database
		/// </summary>
		List<MenuFunction_Account> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MenuFunction_Account từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MenuFunction_Account> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MenuFunction_Account> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MenuFunction_Account từ Database
		/// </summary>
		MenuFunction_Account GetObject(string schema, String FK_AccountObject, String FK_MenuFunction);
		/// <summary>
		/// Lấy một MenuFunction_Account đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MenuFunction_Account GetObjectCon(string schema, string condition, params Object[] parameters);
		MenuFunction_Account GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MenuFunction_Account vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MenuFunction_Account _MenuFunction_Account);
		/// <summary>
		/// Insert danh sách đối tượng MenuFunction_Account vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MenuFunction_Account> _MenuFunction_Accounts);
		/// <summary>
		/// Cập nhật MenuFunction_Account vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MenuFunction_Account _MenuFunction_Account, String FK_AccountObject, String FK_MenuFunction);
		/// <summary>
		/// Cập nhật MenuFunction_Account vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MenuFunction_Account _MenuFunction_Account);
		/// <summary>
		/// Cập nhật danh sách MenuFunction_Account vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MenuFunction_Account> _MenuFunction_Accounts);
		/// <summary>
		/// Cập nhật MenuFunction_Account vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MenuFunction_Account _MenuFunction_Account, string condition);
		/// <summary>
		/// Xóa MenuFunction_Account trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_AccountObject, String FK_MenuFunction);
		/// <summary>
		/// Xóa MenuFunction_Account trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MenuFunction_Account _MenuFunction_Account);
		/// <summary>
		/// Xóa MenuFunction_Account trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MenuFunction_Account trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MenuFunction_Account> _MenuFunction_Accounts);
	}
}
