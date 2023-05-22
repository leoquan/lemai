using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpprovincefeecustomer
	{
		/// <summary>
		/// Lấy một DataTable ExpProvinceFeeCustomer từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpProvinceFeeCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpProvinceFeeCustomer từ Database
		/// </summary>
		List<ExpProvinceFeeCustomer> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpProvinceFeeCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpProvinceFeeCustomer> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpProvinceFeeCustomer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpProvinceFeeCustomer từ Database
		/// </summary>
		ExpProvinceFeeCustomer GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpProvinceFeeCustomer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpProvinceFeeCustomer GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpProvinceFeeCustomer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpProvinceFeeCustomer vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpProvinceFeeCustomer _ExpProvinceFeeCustomer);
		/// <summary>
		/// Insert danh sách đối tượng ExpProvinceFeeCustomer vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpProvinceFeeCustomer> _ExpProvinceFeeCustomers);
		/// <summary>
		/// Cập nhật ExpProvinceFeeCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpProvinceFeeCustomer _ExpProvinceFeeCustomer, String Id);
		/// <summary>
		/// Cập nhật ExpProvinceFeeCustomer vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpProvinceFeeCustomer _ExpProvinceFeeCustomer);
		/// <summary>
		/// Cập nhật danh sách ExpProvinceFeeCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpProvinceFeeCustomer> _ExpProvinceFeeCustomers);
		/// <summary>
		/// Cập nhật ExpProvinceFeeCustomer vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpProvinceFeeCustomer _ExpProvinceFeeCustomer, string condition);
		/// <summary>
		/// Xóa ExpProvinceFeeCustomer trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpProvinceFeeCustomer trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpProvinceFeeCustomer _ExpProvinceFeeCustomer);
		/// <summary>
		/// Xóa ExpProvinceFeeCustomer trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpProvinceFeeCustomer trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpProvinceFeeCustomer> _ExpProvinceFeeCustomers);
	}
}
