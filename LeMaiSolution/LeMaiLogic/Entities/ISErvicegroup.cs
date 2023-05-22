using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISErvicegroup
	{
		/// <summary>
		/// Lấy một DataTable ServiceGroup từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ServiceGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ServiceGroup từ Database
		/// </summary>
		List<ServiceGroup> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ServiceGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ServiceGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ServiceGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ServiceGroup từ Database
		/// </summary>
		ServiceGroup GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ServiceGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ServiceGroup GetObjectCon(string schema, string condition, params Object[] parameters);
		ServiceGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ServiceGroup vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ServiceGroup _ServiceGroup);
		/// <summary>
		/// Insert danh sách đối tượng ServiceGroup vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ServiceGroup> _ServiceGroups);
		/// <summary>
		/// Cập nhật ServiceGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ServiceGroup _ServiceGroup, String Id);
		/// <summary>
		/// Cập nhật ServiceGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ServiceGroup _ServiceGroup);
		/// <summary>
		/// Cập nhật danh sách ServiceGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ServiceGroup> _ServiceGroups);
		/// <summary>
		/// Cập nhật ServiceGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ServiceGroup _ServiceGroup, string condition);
		/// <summary>
		/// Xóa ServiceGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ServiceGroup trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ServiceGroup _ServiceGroup);
		/// <summary>
		/// Xóa ServiceGroup trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ServiceGroup trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ServiceGroup> _ServiceGroups);
	}
}
