using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEnuroleaccountobject
	{
		/// <summary>
		/// Lấy một DataTable MenuRole_AccountObject từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MenuRole_AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MenuRole_AccountObject từ Database
		/// </summary>
		List<MenuRole_AccountObject> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MenuRole_AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MenuRole_AccountObject> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MenuRole_AccountObject> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MenuRole_AccountObject từ Database
		/// </summary>
		MenuRole_AccountObject GetObject(string schema, String FK_Role, String FK_AccountObject);
		/// <summary>
		/// Lấy một MenuRole_AccountObject đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MenuRole_AccountObject GetObjectCon(string schema, string condition, params Object[] parameters);
		MenuRole_AccountObject GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MenuRole_AccountObject vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MenuRole_AccountObject _MenuRole_AccountObject);
		/// <summary>
		/// Insert danh sách đối tượng MenuRole_AccountObject vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MenuRole_AccountObject> _MenuRole_AccountObjects);
		/// <summary>
		/// Cập nhật MenuRole_AccountObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MenuRole_AccountObject _MenuRole_AccountObject, String FK_Role, String FK_AccountObject);
		/// <summary>
		/// Cập nhật MenuRole_AccountObject vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MenuRole_AccountObject _MenuRole_AccountObject);
		/// <summary>
		/// Cập nhật danh sách MenuRole_AccountObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MenuRole_AccountObject> _MenuRole_AccountObjects);
		/// <summary>
		/// Cập nhật MenuRole_AccountObject vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MenuRole_AccountObject _MenuRole_AccountObject, string condition);
		/// <summary>
		/// Xóa MenuRole_AccountObject trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_Role, String FK_AccountObject);
		/// <summary>
		/// Xóa MenuRole_AccountObject trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MenuRole_AccountObject _MenuRole_AccountObject);
		/// <summary>
		/// Xóa MenuRole_AccountObject trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MenuRole_AccountObject trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MenuRole_AccountObject> _MenuRole_AccountObjects);
	}
}
