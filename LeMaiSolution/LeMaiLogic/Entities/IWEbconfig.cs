using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbconfig
	{
		/// <summary>
		/// Lấy một DataTable WebConfig từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebConfig từ Database
		/// </summary>
		List<WebConfig> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebConfig> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebConfig> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebConfig từ Database
		/// </summary>
		WebConfig GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebConfig đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebConfig GetObjectCon(string schema, string condition, params Object[] parameters);
		WebConfig GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebConfig vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebConfig _WebConfig);
		/// <summary>
		/// Insert danh sách đối tượng WebConfig vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebConfig> _WebConfigs);
		/// <summary>
		/// Cập nhật WebConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebConfig _WebConfig, String Id);
		/// <summary>
		/// Cập nhật WebConfig vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebConfig _WebConfig);
		/// <summary>
		/// Cập nhật danh sách WebConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebConfig> _WebConfigs);
		/// <summary>
		/// Cập nhật WebConfig vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebConfig _WebConfig, string condition);
		/// <summary>
		/// Xóa WebConfig trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebConfig trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebConfig _WebConfig);
		/// <summary>
		/// Xóa WebConfig trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebConfig trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebConfig> _WebConfigs);
	}
}
