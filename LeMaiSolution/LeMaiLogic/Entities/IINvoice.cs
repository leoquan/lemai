using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IINvoice
	{
		/// <summary>
		/// Lấy một DataTable Invoice từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable Invoice từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách Invoice từ Database
		/// </summary>
		List<Invoice> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách Invoice từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<Invoice> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<Invoice> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một Invoice từ Database
		/// </summary>
		Invoice GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một Invoice đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		Invoice GetObjectCon(string schema, string condition, params Object[] parameters);
		Invoice GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới Invoice vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, Invoice _Invoice);
		/// <summary>
		/// Insert danh sách đối tượng Invoice vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<Invoice> _Invoices);
		/// <summary>
		/// Cập nhật Invoice vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, Invoice _Invoice, String Id);
		/// <summary>
		/// Cập nhật Invoice vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, Invoice _Invoice);
		/// <summary>
		/// Cập nhật danh sách Invoice vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<Invoice> _Invoices);
		/// <summary>
		/// Cập nhật Invoice vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, Invoice _Invoice, string condition);
		/// <summary>
		/// Xóa Invoice trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa Invoice trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Invoice _Invoice);
		/// <summary>
		/// Xóa Invoice trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa Invoice trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<Invoice> _Invoices);
	}
}
