using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbpage
	{
		/// <summary>
		/// Lấy một DataTable WebPage từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebPage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebPage từ Database
		/// </summary>
		List<WebPage> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebPage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebPage> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebPage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebPage từ Database
		/// </summary>
		WebPage GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebPage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebPage GetObjectCon(string schema, string condition, params Object[] parameters);
		WebPage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebPage vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebPage _WebPage);
		/// <summary>
		/// Insert danh sách đối tượng WebPage vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebPage> _WebPages);
		/// <summary>
		/// Cập nhật WebPage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebPage _WebPage, String Id);
		/// <summary>
		/// Cập nhật WebPage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebPage _WebPage);
		/// <summary>
		/// Cập nhật danh sách WebPage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebPage> _WebPages);
		/// <summary>
		/// Cập nhật WebPage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebPage _WebPage, string condition);
		/// <summary>
		/// Xóa WebPage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebPage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebPage _WebPage);
		/// <summary>
		/// Xóa WebPage trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebPage trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebPage> _WebPages);
	}
}
