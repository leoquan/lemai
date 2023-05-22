using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpaccountcustomer
	{
		/// <summary>
		/// Lấy một DataTable ExpAccountCustomer từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpAccountCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpAccountCustomer từ Database
		/// </summary>
		List<ExpAccountCustomer> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpAccountCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpAccountCustomer> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpAccountCustomer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpAccountCustomer từ Database
		/// </summary>
		ExpAccountCustomer GetObject(string schema, String FK_Account, String FK_Customer);
		/// <summary>
		/// Lấy một ExpAccountCustomer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpAccountCustomer GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpAccountCustomer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpAccountCustomer vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpAccountCustomer _ExpAccountCustomer);
		/// <summary>
		/// Insert danh sách đối tượng ExpAccountCustomer vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpAccountCustomer> _ExpAccountCustomers);
		/// <summary>
		/// Cập nhật ExpAccountCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpAccountCustomer _ExpAccountCustomer, String FK_Account, String FK_Customer);
		/// <summary>
		/// Cập nhật ExpAccountCustomer vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpAccountCustomer _ExpAccountCustomer);
		/// <summary>
		/// Cập nhật danh sách ExpAccountCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpAccountCustomer> _ExpAccountCustomers);
		/// <summary>
		/// Cập nhật ExpAccountCustomer vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpAccountCustomer _ExpAccountCustomer, string condition);
		/// <summary>
		/// Xóa ExpAccountCustomer trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_Account, String FK_Customer);
		/// <summary>
		/// Xóa ExpAccountCustomer trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpAccountCustomer _ExpAccountCustomer);
		/// <summary>
		/// Xóa ExpAccountCustomer trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpAccountCustomer trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpAccountCustomer> _ExpAccountCustomers);
	}
}
