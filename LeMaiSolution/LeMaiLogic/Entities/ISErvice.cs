using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISErvice
	{
		/// <summary>
		/// Lấy một DataTable Service từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable Service từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách Service từ Database
		/// </summary>
		List<Service> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách Service từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<Service> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<Service> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một Service từ Database
		/// </summary>
		Service GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một Service đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		Service GetObjectCon(string schema, string condition, params Object[] parameters);
		Service GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới Service vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, Service _Service);
		/// <summary>
		/// Insert danh sách đối tượng Service vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<Service> _Services);
		/// <summary>
		/// Cập nhật Service vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, Service _Service, String Id);
		/// <summary>
		/// Cập nhật Service vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, Service _Service);
		/// <summary>
		/// Cập nhật danh sách Service vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<Service> _Services);
		/// <summary>
		/// Cập nhật Service vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, Service _Service, string condition);
		/// <summary>
		/// Xóa Service trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa Service trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Service _Service);
		/// <summary>
		/// Xóa Service trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa Service trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<Service> _Services);
	}
}
