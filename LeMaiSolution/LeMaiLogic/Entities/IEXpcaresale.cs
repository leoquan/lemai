using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcaresale
	{
		/// <summary>
		/// Lấy một DataTable ExpCareSale từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCareSale từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCareSale từ Database
		/// </summary>
		List<ExpCareSale> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCareSale từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCareSale> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCareSale> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCareSale từ Database
		/// </summary>
		ExpCareSale GetObject(string schema, String CustomerId);
		/// <summary>
		/// Lấy một ExpCareSale đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCareSale GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCareSale GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCareSale vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCareSale _ExpCareSale);
		/// <summary>
		/// Insert danh sách đối tượng ExpCareSale vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCareSale> _ExpCareSales);
		/// <summary>
		/// Cập nhật ExpCareSale vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCareSale _ExpCareSale, String CustomerId);
		/// <summary>
		/// Cập nhật ExpCareSale vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCareSale _ExpCareSale);
		/// <summary>
		/// Cập nhật danh sách ExpCareSale vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCareSale> _ExpCareSales);
		/// <summary>
		/// Cập nhật ExpCareSale vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCareSale _ExpCareSale, string condition);
		/// <summary>
		/// Xóa ExpCareSale trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String CustomerId);
		/// <summary>
		/// Xóa ExpCareSale trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCareSale _ExpCareSale);
		/// <summary>
		/// Xóa ExpCareSale trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCareSale trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCareSale> _ExpCareSales);
	}
}
