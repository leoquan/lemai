using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IACcountobjecttype
	{
		/// <summary>
		/// Lấy một DataTable AccountObjectType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable AccountObjectType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách AccountObjectType từ Database
		/// </summary>
		List<AccountObjectType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách AccountObjectType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<AccountObjectType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<AccountObjectType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một AccountObjectType từ Database
		/// </summary>
		AccountObjectType GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một AccountObjectType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		AccountObjectType GetObjectCon(string schema, string condition, params Object[] parameters);
		AccountObjectType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới AccountObjectType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, AccountObjectType _AccountObjectType);
		/// <summary>
		/// Insert danh sách đối tượng AccountObjectType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<AccountObjectType> _AccountObjectTypes);
		/// <summary>
		/// Cập nhật AccountObjectType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, AccountObjectType _AccountObjectType, Int32 Id);
		/// <summary>
		/// Cập nhật AccountObjectType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, AccountObjectType _AccountObjectType);
		/// <summary>
		/// Cập nhật danh sách AccountObjectType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<AccountObjectType> _AccountObjectTypes);
		/// <summary>
		/// Cập nhật AccountObjectType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, AccountObjectType _AccountObjectType, string condition);
		/// <summary>
		/// Xóa AccountObjectType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa AccountObjectType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, AccountObjectType _AccountObjectType);
		/// <summary>
		/// Xóa AccountObjectType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa AccountObjectType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<AccountObjectType> _AccountObjectTypes);
	}
}
