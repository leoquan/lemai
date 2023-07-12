using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovincebamboo
	{
		/// <summary>
		/// Lấy một DataTable GExpProvinceBamboo từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProvinceBamboo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProvinceBamboo từ Database
		/// </summary>
		List<GExpProvinceBamboo> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProvinceBamboo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProvinceBamboo> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProvinceBamboo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProvinceBamboo từ Database
		/// </summary>
		GExpProvinceBamboo GetObject(string schema, String provinceCode);
		/// <summary>
		/// Lấy một GExpProvinceBamboo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProvinceBamboo GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProvinceBamboo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProvinceBamboo vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProvinceBamboo _GExpProvinceBamboo);
		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceBamboo vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProvinceBamboo> _GExpProvinceBamboos);
		/// <summary>
		/// Cập nhật GExpProvinceBamboo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProvinceBamboo _GExpProvinceBamboo, String provinceCode);
		/// <summary>
		/// Cập nhật GExpProvinceBamboo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProvinceBamboo _GExpProvinceBamboo);
		/// <summary>
		/// Cập nhật danh sách GExpProvinceBamboo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProvinceBamboo> _GExpProvinceBamboos);
		/// <summary>
		/// Cập nhật GExpProvinceBamboo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProvinceBamboo _GExpProvinceBamboo, string condition);
		/// <summary>
		/// Xóa GExpProvinceBamboo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String provinceCode);
		/// <summary>
		/// Xóa GExpProvinceBamboo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProvinceBamboo _GExpProvinceBamboo);
		/// <summary>
		/// Xóa GExpProvinceBamboo trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProvinceBamboo trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProvinceBamboo> _GExpProvinceBamboos);
	}
}
