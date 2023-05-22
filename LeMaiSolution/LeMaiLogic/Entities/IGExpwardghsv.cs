using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpwardghsv
	{
		/// <summary>
		/// Lấy một DataTable GExpWardGHSV từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpWardGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpWardGHSV từ Database
		/// </summary>
		List<GExpWardGHSV> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpWardGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpWardGHSV> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpWardGHSV> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpWardGHSV từ Database
		/// </summary>
		GExpWardGHSV GetObject(string schema, String communeCode);
		/// <summary>
		/// Lấy một GExpWardGHSV đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpWardGHSV GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpWardGHSV GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpWardGHSV vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpWardGHSV _GExpWardGHSV);
		/// <summary>
		/// Insert danh sách đối tượng GExpWardGHSV vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpWardGHSV> _GExpWardGHSVs);
		/// <summary>
		/// Cập nhật GExpWardGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpWardGHSV _GExpWardGHSV, String communeCode);
		/// <summary>
		/// Cập nhật GExpWardGHSV vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpWardGHSV _GExpWardGHSV);
		/// <summary>
		/// Cập nhật danh sách GExpWardGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpWardGHSV> _GExpWardGHSVs);
		/// <summary>
		/// Cập nhật GExpWardGHSV vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpWardGHSV _GExpWardGHSV, string condition);
		/// <summary>
		/// Xóa GExpWardGHSV trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String communeCode);
		/// <summary>
		/// Xóa GExpWardGHSV trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpWardGHSV _GExpWardGHSV);
		/// <summary>
		/// Xóa GExpWardGHSV trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpWardGHSV trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpWardGHSV> _GExpWardGHSVs);
	}
}
