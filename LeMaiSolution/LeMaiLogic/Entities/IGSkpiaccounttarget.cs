using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSkpiaccounttarget
	{
		/// <summary>
		/// Lấy một DataTable GsKPIAccountTarget từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsKPIAccountTarget từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsKPIAccountTarget từ Database
		/// </summary>
		List<GsKPIAccountTarget> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsKPIAccountTarget từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsKPIAccountTarget> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsKPIAccountTarget> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsKPIAccountTarget từ Database
		/// </summary>
		GsKPIAccountTarget GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsKPIAccountTarget đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsKPIAccountTarget GetObjectCon(string schema, string condition, params Object[] parameters);
		GsKPIAccountTarget GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsKPIAccountTarget vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsKPIAccountTarget _GsKPIAccountTarget);
		/// <summary>
		/// Insert danh sách đối tượng GsKPIAccountTarget vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsKPIAccountTarget> _GsKPIAccountTargets);
		/// <summary>
		/// Cập nhật GsKPIAccountTarget vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsKPIAccountTarget _GsKPIAccountTarget, String Id);
		/// <summary>
		/// Cập nhật GsKPIAccountTarget vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsKPIAccountTarget _GsKPIAccountTarget);
		/// <summary>
		/// Cập nhật danh sách GsKPIAccountTarget vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsKPIAccountTarget> _GsKPIAccountTargets);
		/// <summary>
		/// Cập nhật GsKPIAccountTarget vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsKPIAccountTarget _GsKPIAccountTarget, string condition);
		/// <summary>
		/// Xóa GsKPIAccountTarget trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsKPIAccountTarget trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsKPIAccountTarget _GsKPIAccountTarget);
		/// <summary>
		/// Xóa GsKPIAccountTarget trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsKPIAccountTarget trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsKPIAccountTarget> _GsKPIAccountTargets);
	}
}
