using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IACcountobject
	{
		/// <summary>
		/// Lấy một DataTable AccountObject từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách AccountObject từ Database
		/// </summary>
		List<AccountObject> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<AccountObject> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<AccountObject> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một AccountObject từ Database
		/// </summary>
		AccountObject GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một AccountObject đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		AccountObject GetObjectCon(string schema, string condition, params Object[] parameters);
		AccountObject GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới AccountObject vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, AccountObject _AccountObject);
		/// <summary>
		/// Insert danh sách đối tượng AccountObject vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<AccountObject> _AccountObjects);
		/// <summary>
		/// Cập nhật AccountObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, AccountObject _AccountObject, String Id);
		/// <summary>
		/// Cập nhật AccountObject vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, AccountObject _AccountObject);
		/// <summary>
		/// Cập nhật danh sách AccountObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<AccountObject> _AccountObjects);
		/// <summary>
		/// Cập nhật AccountObject vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, AccountObject _AccountObject, string condition);
		/// <summary>
		/// Xóa AccountObject trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa AccountObject trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, AccountObject _AccountObject);
		/// <summary>
		/// Xóa AccountObject trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa AccountObject trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<AccountObject> _AccountObjects);
	}
}
