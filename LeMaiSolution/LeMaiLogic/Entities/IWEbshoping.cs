using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbshoping
	{
		/// <summary>
		/// Lấy một DataTable WebShoping từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebShoping từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebShoping từ Database
		/// </summary>
		List<WebShoping> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebShoping từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebShoping> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebShoping> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebShoping từ Database
		/// </summary>
		WebShoping GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebShoping đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebShoping GetObjectCon(string schema, string condition, params Object[] parameters);
		WebShoping GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebShoping vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebShoping _WebShoping);
		/// <summary>
		/// Insert danh sách đối tượng WebShoping vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebShoping> _WebShopings);
		/// <summary>
		/// Cập nhật WebShoping vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebShoping _WebShoping, String Id);
		/// <summary>
		/// Cập nhật WebShoping vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebShoping _WebShoping);
		/// <summary>
		/// Cập nhật danh sách WebShoping vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebShoping> _WebShopings);
		/// <summary>
		/// Cập nhật WebShoping vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebShoping _WebShoping, string condition);
		/// <summary>
		/// Xóa WebShoping trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebShoping trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebShoping _WebShoping);
		/// <summary>
		/// Xóa WebShoping trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebShoping trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebShoping> _WebShopings);
	}
}
