using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpwardvn
	{
		/// <summary>
		/// Lấy một DataTable GExpWardVN từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpWardVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpWardVN từ Database
		/// </summary>
		List<GExpWardVN> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpWardVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpWardVN> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpWardVN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpWardVN từ Database
		/// </summary>
		GExpWardVN GetObject(string schema, String communeCode);
		/// <summary>
		/// Lấy một GExpWardVN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpWardVN GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpWardVN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpWardVN vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpWardVN _GExpWardVN);
		/// <summary>
		/// Insert danh sách đối tượng GExpWardVN vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpWardVN> _GExpWardVNs);
		/// <summary>
		/// Cập nhật GExpWardVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpWardVN _GExpWardVN, String communeCode);
		/// <summary>
		/// Cập nhật GExpWardVN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpWardVN _GExpWardVN);
		/// <summary>
		/// Cập nhật danh sách GExpWardVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpWardVN> _GExpWardVNs);
		/// <summary>
		/// Cập nhật GExpWardVN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpWardVN _GExpWardVN, string condition);
		/// <summary>
		/// Xóa GExpWardVN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String communeCode);
		/// <summary>
		/// Xóa GExpWardVN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpWardVN _GExpWardVN);
		/// <summary>
		/// Xóa GExpWardVN trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpWardVN trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpWardVN> _GExpWardVNs);
	}
}
