using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpscan
	{
		/// <summary>
		/// Lấy một DataTable GExpScan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpScan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpScan từ Database
		/// </summary>
		List<GExpScan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpScan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpScan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpScan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpScan từ Database
		/// </summary>
		GExpScan GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpScan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpScan GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpScan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpScan vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpScan _GExpScan);
		/// <summary>
		/// Insert danh sách đối tượng GExpScan vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpScan> _GExpScans);
		/// <summary>
		/// Cập nhật GExpScan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpScan _GExpScan, String Id);
		/// <summary>
		/// Cập nhật GExpScan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpScan _GExpScan);
		/// <summary>
		/// Cập nhật danh sách GExpScan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpScan> _GExpScans);
		/// <summary>
		/// Cập nhật GExpScan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpScan _GExpScan, string condition);
		/// <summary>
		/// Xóa GExpScan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpScan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpScan _GExpScan);
		/// <summary>
		/// Xóa GExpScan trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpScan trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpScan> _GExpScans);
	}
}
