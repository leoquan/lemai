using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IINvoicedetail
	{
		/// <summary>
		/// Lấy một DataTable InvoiceDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable InvoiceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách InvoiceDetail từ Database
		/// </summary>
		List<InvoiceDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách InvoiceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<InvoiceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<InvoiceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một InvoiceDetail từ Database
		/// </summary>
		InvoiceDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một InvoiceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		InvoiceDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		InvoiceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới InvoiceDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, InvoiceDetail _InvoiceDetail);
		/// <summary>
		/// Insert danh sách đối tượng InvoiceDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<InvoiceDetail> _InvoiceDetails);
		/// <summary>
		/// Cập nhật InvoiceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, InvoiceDetail _InvoiceDetail, String Id);
		/// <summary>
		/// Cập nhật InvoiceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, InvoiceDetail _InvoiceDetail);
		/// <summary>
		/// Cập nhật danh sách InvoiceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<InvoiceDetail> _InvoiceDetails);
		/// <summary>
		/// Cập nhật InvoiceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, InvoiceDetail _InvoiceDetail, string condition);
		/// <summary>
		/// Xóa InvoiceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa InvoiceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, InvoiceDetail _InvoiceDetail);
		/// <summary>
		/// Xóa InvoiceDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa InvoiceDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<InvoiceDetail> _InvoiceDetails);
	}
}
