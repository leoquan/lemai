using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSkpitarget
	{
		/// <summary>
		/// Lấy một DataTable GsKPITarget từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsKPITarget từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsKPITarget từ Database
		/// </summary>
		List<GsKPITarget> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsKPITarget từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsKPITarget> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsKPITarget> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsKPITarget từ Database
		/// </summary>
		GsKPITarget GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsKPITarget đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsKPITarget GetObjectCon(string schema, string condition, params Object[] parameters);
		GsKPITarget GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsKPITarget vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsKPITarget _GsKPITarget);
		/// <summary>
		/// Insert danh sách đối tượng GsKPITarget vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsKPITarget> _GsKPITargets);
		/// <summary>
		/// Cập nhật GsKPITarget vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsKPITarget _GsKPITarget, String Id);
		/// <summary>
		/// Cập nhật GsKPITarget vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsKPITarget _GsKPITarget);
		/// <summary>
		/// Cập nhật danh sách GsKPITarget vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsKPITarget> _GsKPITargets);
		/// <summary>
		/// Cập nhật GsKPITarget vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsKPITarget _GsKPITarget, string condition);
		/// <summary>
		/// Xóa GsKPITarget trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsKPITarget trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsKPITarget _GsKPITarget);
		/// <summary>
		/// Xóa GsKPITarget trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsKPITarget trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsKPITarget> _GsKPITargets);
	}
}
