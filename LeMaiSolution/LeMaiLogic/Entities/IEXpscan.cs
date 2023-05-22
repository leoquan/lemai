using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpscan
	{
		/// <summary>
		/// Lấy một DataTable ExpScan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpScan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpScan từ Database
		/// </summary>
		List<ExpScan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpScan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpScan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpScan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpScan từ Database
		/// </summary>
		ExpScan GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpScan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpScan GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpScan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpScan vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpScan _ExpScan);
		/// <summary>
		/// Insert danh sách đối tượng ExpScan vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpScan> _ExpScans);
		/// <summary>
		/// Cập nhật ExpScan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpScan _ExpScan, String Id);
		/// <summary>
		/// Cập nhật ExpScan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpScan _ExpScan);
		/// <summary>
		/// Cập nhật danh sách ExpScan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpScan> _ExpScans);
		/// <summary>
		/// Cập nhật ExpScan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpScan _ExpScan, string condition);
		/// <summary>
		/// Xóa ExpScan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpScan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpScan _ExpScan);
		/// <summary>
		/// Xóa ExpScan trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpScan trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpScan> _ExpScans);
	}
}
