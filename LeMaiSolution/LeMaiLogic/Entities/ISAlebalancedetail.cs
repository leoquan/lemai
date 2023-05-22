using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISAlebalancedetail
	{
		/// <summary>
		/// Lấy một DataTable SaleBalanceDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SaleBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SaleBalanceDetail từ Database
		/// </summary>
		List<SaleBalanceDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SaleBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SaleBalanceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SaleBalanceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SaleBalanceDetail từ Database
		/// </summary>
		SaleBalanceDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SaleBalanceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SaleBalanceDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		SaleBalanceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SaleBalanceDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SaleBalanceDetail _SaleBalanceDetail);
		/// <summary>
		/// Insert danh sách đối tượng SaleBalanceDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SaleBalanceDetail> _SaleBalanceDetails);
		/// <summary>
		/// Cập nhật SaleBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SaleBalanceDetail _SaleBalanceDetail, String Id);
		/// <summary>
		/// Cập nhật SaleBalanceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SaleBalanceDetail _SaleBalanceDetail);
		/// <summary>
		/// Cập nhật danh sách SaleBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SaleBalanceDetail> _SaleBalanceDetails);
		/// <summary>
		/// Cập nhật SaleBalanceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SaleBalanceDetail _SaleBalanceDetail, string condition);
		/// <summary>
		/// Xóa SaleBalanceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SaleBalanceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SaleBalanceDetail _SaleBalanceDetail);
		/// <summary>
		/// Xóa SaleBalanceDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SaleBalanceDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SaleBalanceDetail> _SaleBalanceDetails);
	}
}
