using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpwardbamboo
	{
		/// <summary>
		/// Lấy một DataTable GExpWardBamboo từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpWardBamboo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpWardBamboo từ Database
		/// </summary>
		List<GExpWardBamboo> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpWardBamboo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpWardBamboo> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpWardBamboo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpWardBamboo từ Database
		/// </summary>
		GExpWardBamboo GetObject(string schema, String communeCode);
		/// <summary>
		/// Lấy một GExpWardBamboo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpWardBamboo GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpWardBamboo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpWardBamboo vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpWardBamboo _GExpWardBamboo);
		/// <summary>
		/// Insert danh sách đối tượng GExpWardBamboo vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpWardBamboo> _GExpWardBamboos);
		/// <summary>
		/// Cập nhật GExpWardBamboo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpWardBamboo _GExpWardBamboo, String communeCode);
		/// <summary>
		/// Cập nhật GExpWardBamboo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpWardBamboo _GExpWardBamboo);
		/// <summary>
		/// Cập nhật danh sách GExpWardBamboo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpWardBamboo> _GExpWardBamboos);
		/// <summary>
		/// Cập nhật GExpWardBamboo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpWardBamboo _GExpWardBamboo, string condition);
		/// <summary>
		/// Xóa GExpWardBamboo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String communeCode);
		/// <summary>
		/// Xóa GExpWardBamboo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpWardBamboo _GExpWardBamboo);
		/// <summary>
		/// Xóa GExpWardBamboo trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpWardBamboo trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpWardBamboo> _GExpWardBamboos);
	}
}
