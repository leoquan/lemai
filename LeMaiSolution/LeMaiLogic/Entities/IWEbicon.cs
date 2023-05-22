using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbicon
	{
		/// <summary>
		/// Lấy một DataTable WebIcon từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebIcon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebIcon từ Database
		/// </summary>
		List<WebIcon> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebIcon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebIcon> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebIcon> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebIcon từ Database
		/// </summary>
		WebIcon GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebIcon đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebIcon GetObjectCon(string schema, string condition, params Object[] parameters);
		WebIcon GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebIcon vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebIcon _WebIcon);
		/// <summary>
		/// Insert danh sách đối tượng WebIcon vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebIcon> _WebIcons);
		/// <summary>
		/// Cập nhật WebIcon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebIcon _WebIcon, String Id);
		/// <summary>
		/// Cập nhật WebIcon vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebIcon _WebIcon);
		/// <summary>
		/// Cập nhật danh sách WebIcon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebIcon> _WebIcons);
		/// <summary>
		/// Cập nhật WebIcon vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebIcon _WebIcon, string condition);
		/// <summary>
		/// Xóa WebIcon trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebIcon trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebIcon _WebIcon);
		/// <summary>
		/// Xóa WebIcon trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebIcon trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebIcon> _WebIcons);
	}
}
