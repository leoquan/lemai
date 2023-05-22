using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpwardvtp
	{
		/// <summary>
		/// Lấy một DataTable GExpWardVTP từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpWardVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpWardVTP từ Database
		/// </summary>
		List<GExpWardVTP> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpWardVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpWardVTP> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpWardVTP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpWardVTP từ Database
		/// </summary>
		GExpWardVTP GetObject(string schema, String communeCode);
		/// <summary>
		/// Lấy một GExpWardVTP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpWardVTP GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpWardVTP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpWardVTP vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpWardVTP _GExpWardVTP);
		/// <summary>
		/// Insert danh sách đối tượng GExpWardVTP vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpWardVTP> _GExpWardVTPs);
		/// <summary>
		/// Cập nhật GExpWardVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpWardVTP _GExpWardVTP, String communeCode);
		/// <summary>
		/// Cập nhật GExpWardVTP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpWardVTP _GExpWardVTP);
		/// <summary>
		/// Cập nhật danh sách GExpWardVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpWardVTP> _GExpWardVTPs);
		/// <summary>
		/// Cập nhật GExpWardVTP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpWardVTP _GExpWardVTP, string condition);
		/// <summary>
		/// Xóa GExpWardVTP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String communeCode);
		/// <summary>
		/// Xóa GExpWardVTP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpWardVTP _GExpWardVTP);
		/// <summary>
		/// Xóa GExpWardVTP trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpWardVTP trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpWardVTP> _GExpWardVTPs);
	}
}
