using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpwardvnp
	{
		/// <summary>
		/// Lấy một DataTable GExpWardVNP từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpWardVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpWardVNP từ Database
		/// </summary>
		List<GExpWardVNP> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpWardVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpWardVNP> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpWardVNP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpWardVNP từ Database
		/// </summary>
		GExpWardVNP GetObject(string schema, String communeCode);
		/// <summary>
		/// Lấy một GExpWardVNP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpWardVNP GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpWardVNP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpWardVNP vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpWardVNP _GExpWardVNP);
		/// <summary>
		/// Insert danh sách đối tượng GExpWardVNP vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpWardVNP> _GExpWardVNPs);
		/// <summary>
		/// Cập nhật GExpWardVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpWardVNP _GExpWardVNP, String communeCode);
		/// <summary>
		/// Cập nhật GExpWardVNP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpWardVNP _GExpWardVNP);
		/// <summary>
		/// Cập nhật danh sách GExpWardVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpWardVNP> _GExpWardVNPs);
		/// <summary>
		/// Cập nhật GExpWardVNP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpWardVNP _GExpWardVNP, string condition);
		/// <summary>
		/// Xóa GExpWardVNP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String communeCode);
		/// <summary>
		/// Xóa GExpWardVNP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpWardVNP _GExpWardVNP);
		/// <summary>
		/// Xóa GExpWardVNP trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpWardVNP trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpWardVNP> _GExpWardVNPs);
	}
}
