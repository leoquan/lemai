using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcustomergroup
	{
		/// <summary>
		/// Lấy một DataTable ExpCustomerGroup từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCustomerGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCustomerGroup từ Database
		/// </summary>
		List<ExpCustomerGroup> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCustomerGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCustomerGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCustomerGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCustomerGroup từ Database
		/// </summary>
		ExpCustomerGroup GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpCustomerGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCustomerGroup GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCustomerGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCustomerGroup vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCustomerGroup _ExpCustomerGroup);
		/// <summary>
		/// Insert danh sách đối tượng ExpCustomerGroup vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCustomerGroup> _ExpCustomerGroups);
		/// <summary>
		/// Cập nhật ExpCustomerGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCustomerGroup _ExpCustomerGroup, String Id);
		/// <summary>
		/// Cập nhật ExpCustomerGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCustomerGroup _ExpCustomerGroup);
		/// <summary>
		/// Cập nhật danh sách ExpCustomerGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCustomerGroup> _ExpCustomerGroups);
		/// <summary>
		/// Cập nhật ExpCustomerGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCustomerGroup _ExpCustomerGroup, string condition);
		/// <summary>
		/// Xóa ExpCustomerGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpCustomerGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCustomerGroup _ExpCustomerGroup);
		/// <summary>
		/// Xóa ExpCustomerGroup trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCustomerGroup trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCustomerGroup> _ExpCustomerGroups);
	}
}
