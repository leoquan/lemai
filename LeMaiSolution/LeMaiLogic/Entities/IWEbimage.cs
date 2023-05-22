using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbimage
	{
		/// <summary>
		/// Lấy một DataTable WebImage từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebImage từ Database
		/// </summary>
		List<WebImage> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebImage> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebImage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebImage từ Database
		/// </summary>
		WebImage GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebImage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebImage GetObjectCon(string schema, string condition, params Object[] parameters);
		WebImage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebImage vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebImage _WebImage);
		/// <summary>
		/// Insert danh sách đối tượng WebImage vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebImage> _WebImages);
		/// <summary>
		/// Cập nhật WebImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebImage _WebImage, String Id);
		/// <summary>
		/// Cập nhật WebImage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebImage _WebImage);
		/// <summary>
		/// Cập nhật danh sách WebImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebImage> _WebImages);
		/// <summary>
		/// Cập nhật WebImage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebImage _WebImage, string condition);
		/// <summary>
		/// Xóa WebImage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebImage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebImage _WebImage);
		/// <summary>
		/// Xóa WebImage trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebImage trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebImage> _WebImages);
	}
}
