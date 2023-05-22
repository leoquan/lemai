using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcontact
	{
		/// <summary>
		/// Lấy một DataTable ExpContact từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpContact từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpContact từ Database
		/// </summary>
		List<ExpContact> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpContact từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpContact> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpContact> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpContact từ Database
		/// </summary>
		ExpContact GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpContact đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpContact GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpContact GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpContact vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpContact _ExpContact);
		/// <summary>
		/// Insert danh sách đối tượng ExpContact vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpContact> _ExpContacts);
		/// <summary>
		/// Cập nhật ExpContact vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpContact _ExpContact, String Id);
		/// <summary>
		/// Cập nhật ExpContact vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpContact _ExpContact);
		/// <summary>
		/// Cập nhật danh sách ExpContact vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpContact> _ExpContacts);
		/// <summary>
		/// Cập nhật ExpContact vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpContact _ExpContact, string condition);
		/// <summary>
		/// Xóa ExpContact trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpContact trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpContact _ExpContact);
		/// <summary>
		/// Xóa ExpContact trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpContact trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpContact> _ExpContacts);
	}
}
