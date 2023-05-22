using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbsetting
	{
		/// <summary>
		/// Lấy một DataTable WebSetting từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebSetting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebSetting từ Database
		/// </summary>
		List<WebSetting> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebSetting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebSetting> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebSetting> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebSetting từ Database
		/// </summary>
		WebSetting GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebSetting đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebSetting GetObjectCon(string schema, string condition, params Object[] parameters);
		WebSetting GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebSetting vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebSetting _WebSetting);
		/// <summary>
		/// Insert danh sách đối tượng WebSetting vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebSetting> _WebSettings);
		/// <summary>
		/// Cập nhật WebSetting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebSetting _WebSetting, String Id);
		/// <summary>
		/// Cập nhật WebSetting vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebSetting _WebSetting);
		/// <summary>
		/// Cập nhật danh sách WebSetting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebSetting> _WebSettings);
		/// <summary>
		/// Cập nhật WebSetting vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebSetting _WebSetting, string condition);
		/// <summary>
		/// Xóa WebSetting trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebSetting trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebSetting _WebSetting);
		/// <summary>
		/// Xóa WebSetting trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebSetting trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebSetting> _WebSettings);
	}
}
