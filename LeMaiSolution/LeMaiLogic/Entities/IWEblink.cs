using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEblink
	{
		/// <summary>
		/// Lấy một DataTable WebLink từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebLink từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebLink từ Database
		/// </summary>
		List<WebLink> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebLink từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebLink> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebLink> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebLink từ Database
		/// </summary>
		WebLink GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebLink đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebLink GetObjectCon(string schema, string condition, params Object[] parameters);
		WebLink GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebLink vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebLink _WebLink);
		/// <summary>
		/// Insert danh sách đối tượng WebLink vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebLink> _WebLinks);
		/// <summary>
		/// Cập nhật WebLink vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebLink _WebLink, String Id);
		/// <summary>
		/// Cập nhật WebLink vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebLink _WebLink);
		/// <summary>
		/// Cập nhật danh sách WebLink vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebLink> _WebLinks);
		/// <summary>
		/// Cập nhật WebLink vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebLink _WebLink, string condition);
		/// <summary>
		/// Xóa WebLink trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebLink trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebLink _WebLink);
		/// <summary>
		/// Xóa WebLink trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebLink trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebLink> _WebLinks);
	}
}
