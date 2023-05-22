using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpaccept
	{
		/// <summary>
		/// Lấy một DataTable GExpAccept từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpAccept từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpAccept từ Database
		/// </summary>
		List<GExpAccept> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpAccept từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpAccept> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpAccept> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpAccept từ Database
		/// </summary>
		GExpAccept GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpAccept đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpAccept GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpAccept GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpAccept vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpAccept _GExpAccept);
		/// <summary>
		/// Insert danh sách đối tượng GExpAccept vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpAccept> _GExpAccepts);
		/// <summary>
		/// Cập nhật GExpAccept vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpAccept _GExpAccept, String Id);
		/// <summary>
		/// Cập nhật GExpAccept vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpAccept _GExpAccept);
		/// <summary>
		/// Cập nhật danh sách GExpAccept vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpAccept> _GExpAccepts);
		/// <summary>
		/// Cập nhật GExpAccept vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpAccept _GExpAccept, string condition);
		/// <summary>
		/// Xóa GExpAccept trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpAccept trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpAccept _GExpAccept);
		/// <summary>
		/// Xóa GExpAccept trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpAccept trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpAccept> _GExpAccepts);
	}
}
