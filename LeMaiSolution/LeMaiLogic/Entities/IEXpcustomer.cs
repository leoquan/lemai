using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcustomer
	{
		/// <summary>
		/// Lấy một DataTable ExpCustomer từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCustomer từ Database
		/// </summary>
		List<ExpCustomer> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCustomer> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCustomer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCustomer từ Database
		/// </summary>
		ExpCustomer GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpCustomer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCustomer GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCustomer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCustomer vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCustomer _ExpCustomer);
		/// <summary>
		/// Insert danh sách đối tượng ExpCustomer vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCustomer> _ExpCustomers);
		/// <summary>
		/// Cập nhật ExpCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCustomer _ExpCustomer, String Id);
		/// <summary>
		/// Cập nhật ExpCustomer vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCustomer _ExpCustomer);
		/// <summary>
		/// Cập nhật danh sách ExpCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCustomer> _ExpCustomers);
		/// <summary>
		/// Cập nhật ExpCustomer vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCustomer _ExpCustomer, string condition);
		/// <summary>
		/// Xóa ExpCustomer trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpCustomer trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCustomer _ExpCustomer);
		/// <summary>
		/// Xóa ExpCustomer trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCustomer trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCustomer> _ExpCustomers);
	}
}
