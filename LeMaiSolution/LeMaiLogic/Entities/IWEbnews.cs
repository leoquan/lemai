using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbnews
	{
		/// <summary>
		/// Lấy một DataTable WebNews từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebNews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebNews từ Database
		/// </summary>
		List<WebNews> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebNews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebNews> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebNews> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebNews từ Database
		/// </summary>
		WebNews GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebNews đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebNews GetObjectCon(string schema, string condition, params Object[] parameters);
		WebNews GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebNews vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebNews _WebNews);
		/// <summary>
		/// Insert danh sách đối tượng WebNews vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebNews> _WebNewss);
		/// <summary>
		/// Cập nhật WebNews vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebNews _WebNews, String Id);
		/// <summary>
		/// Cập nhật WebNews vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebNews _WebNews);
		/// <summary>
		/// Cập nhật danh sách WebNews vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebNews> _WebNewss);
		/// <summary>
		/// Cập nhật WebNews vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebNews _WebNews, string condition);
		/// <summary>
		/// Xóa WebNews trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebNews trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebNews _WebNews);
		/// <summary>
		/// Xóa WebNews trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebNews trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebNews> _WebNewss);
	}
}
