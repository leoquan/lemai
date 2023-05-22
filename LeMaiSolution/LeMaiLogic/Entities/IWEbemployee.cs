using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbemployee
	{
		/// <summary>
		/// Lấy một DataTable WebEmployee từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebEmployee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebEmployee từ Database
		/// </summary>
		List<WebEmployee> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebEmployee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebEmployee> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebEmployee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebEmployee từ Database
		/// </summary>
		WebEmployee GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebEmployee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebEmployee GetObjectCon(string schema, string condition, params Object[] parameters);
		WebEmployee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebEmployee vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebEmployee _WebEmployee);
		/// <summary>
		/// Insert danh sách đối tượng WebEmployee vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebEmployee> _WebEmployees);
		/// <summary>
		/// Cập nhật WebEmployee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebEmployee _WebEmployee, String Id);
		/// <summary>
		/// Cập nhật WebEmployee vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebEmployee _WebEmployee);
		/// <summary>
		/// Cập nhật danh sách WebEmployee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebEmployee> _WebEmployees);
		/// <summary>
		/// Cập nhật WebEmployee vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebEmployee _WebEmployee, string condition);
		/// <summary>
		/// Xóa WebEmployee trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebEmployee trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebEmployee _WebEmployee);
		/// <summary>
		/// Xóa WebEmployee trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebEmployee trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebEmployee> _WebEmployees);
	}
}
