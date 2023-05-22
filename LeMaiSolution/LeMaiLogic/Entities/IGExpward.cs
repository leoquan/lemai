using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpward
	{
		/// <summary>
		/// Lấy một DataTable GExpWard từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpWard từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpWard từ Database
		/// </summary>
		List<GExpWard> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpWard từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpWard> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpWard> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpWard từ Database
		/// </summary>
		GExpWard GetObject(string schema, String WardId);
		/// <summary>
		/// Lấy một GExpWard đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpWard GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpWard GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpWard vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpWard _GExpWard);
		/// <summary>
		/// Insert danh sách đối tượng GExpWard vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpWard> _GExpWards);
		/// <summary>
		/// Cập nhật GExpWard vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpWard _GExpWard, String WardId);
		/// <summary>
		/// Cập nhật GExpWard vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpWard _GExpWard);
		/// <summary>
		/// Cập nhật danh sách GExpWard vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpWard> _GExpWards);
		/// <summary>
		/// Cập nhật GExpWard vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpWard _GExpWard, string condition);
		/// <summary>
		/// Xóa GExpWard trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String WardId);
		/// <summary>
		/// Xóa GExpWard trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpWard _GExpWard);
		/// <summary>
		/// Xóa GExpWard trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpWard trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpWard> _GExpWards);
	}
}
