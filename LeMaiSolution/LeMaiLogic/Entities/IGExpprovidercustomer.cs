using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovidercustomer
	{
		/// <summary>
		/// Lấy một DataTable GExpProviderCustomer từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProviderCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProviderCustomer từ Database
		/// </summary>
		List<GExpProviderCustomer> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProviderCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProviderCustomer> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProviderCustomer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProviderCustomer từ Database
		/// </summary>
		GExpProviderCustomer GetObject(string schema, String ProviderId, String CustomerId);
		/// <summary>
		/// Lấy một GExpProviderCustomer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProviderCustomer GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProviderCustomer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProviderCustomer vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProviderCustomer _GExpProviderCustomer);
		/// <summary>
		/// Insert danh sách đối tượng GExpProviderCustomer vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProviderCustomer> _GExpProviderCustomers);
		/// <summary>
		/// Cập nhật GExpProviderCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProviderCustomer _GExpProviderCustomer, String ProviderId, String CustomerId);
		/// <summary>
		/// Cập nhật GExpProviderCustomer vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProviderCustomer _GExpProviderCustomer);
		/// <summary>
		/// Cập nhật danh sách GExpProviderCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProviderCustomer> _GExpProviderCustomers);
		/// <summary>
		/// Cập nhật GExpProviderCustomer vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProviderCustomer _GExpProviderCustomer, string condition);
		/// <summary>
		/// Xóa GExpProviderCustomer trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String ProviderId, String CustomerId);
		/// <summary>
		/// Xóa GExpProviderCustomer trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProviderCustomer _GExpProviderCustomer);
		/// <summary>
		/// Xóa GExpProviderCustomer trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProviderCustomer trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProviderCustomer> _GExpProviderCustomers);
	}
}
