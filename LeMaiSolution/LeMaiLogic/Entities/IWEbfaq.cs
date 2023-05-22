using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbfaq
	{
		/// <summary>
		/// Lấy một DataTable WebFaq từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebFaq từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebFaq từ Database
		/// </summary>
		List<WebFaq> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebFaq từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebFaq> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebFaq> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebFaq từ Database
		/// </summary>
		WebFaq GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebFaq đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebFaq GetObjectCon(string schema, string condition, params Object[] parameters);
		WebFaq GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebFaq vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebFaq _WebFaq);
		/// <summary>
		/// Insert danh sách đối tượng WebFaq vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebFaq> _WebFaqs);
		/// <summary>
		/// Cập nhật WebFaq vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebFaq _WebFaq, String Id);
		/// <summary>
		/// Cập nhật WebFaq vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebFaq _WebFaq);
		/// <summary>
		/// Cập nhật danh sách WebFaq vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebFaq> _WebFaqs);
		/// <summary>
		/// Cập nhật WebFaq vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebFaq _WebFaq, string condition);
		/// <summary>
		/// Xóa WebFaq trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebFaq trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebFaq _WebFaq);
		/// <summary>
		/// Xóa WebFaq trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebFaq trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebFaq> _WebFaqs);
	}
}
