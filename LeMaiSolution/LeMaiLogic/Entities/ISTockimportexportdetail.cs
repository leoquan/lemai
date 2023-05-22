using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISTockimportexportdetail
	{
		/// <summary>
		/// Lấy một DataTable StockImportExportDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable StockImportExportDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách StockImportExportDetail từ Database
		/// </summary>
		List<StockImportExportDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách StockImportExportDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<StockImportExportDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<StockImportExportDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một StockImportExportDetail từ Database
		/// </summary>
		StockImportExportDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một StockImportExportDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		StockImportExportDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		StockImportExportDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới StockImportExportDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, StockImportExportDetail _StockImportExportDetail);
		/// <summary>
		/// Insert danh sách đối tượng StockImportExportDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<StockImportExportDetail> _StockImportExportDetails);
		/// <summary>
		/// Cập nhật StockImportExportDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, StockImportExportDetail _StockImportExportDetail, String Id);
		/// <summary>
		/// Cập nhật StockImportExportDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, StockImportExportDetail _StockImportExportDetail);
		/// <summary>
		/// Cập nhật danh sách StockImportExportDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<StockImportExportDetail> _StockImportExportDetails);
		/// <summary>
		/// Cập nhật StockImportExportDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, StockImportExportDetail _StockImportExportDetail, string condition);
		/// <summary>
		/// Xóa StockImportExportDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa StockImportExportDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, StockImportExportDetail _StockImportExportDetail);
		/// <summary>
		/// Xóa StockImportExportDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa StockImportExportDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<StockImportExportDetail> _StockImportExportDetails);
	}
}
