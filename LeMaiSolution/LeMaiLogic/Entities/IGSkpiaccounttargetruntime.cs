using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSkpiaccounttargetruntime
	{
		/// <summary>
		/// Lấy một DataTable GsKPIAccountTargetRuntime từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsKPIAccountTargetRuntime từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsKPIAccountTargetRuntime từ Database
		/// </summary>
		List<GsKPIAccountTargetRuntime> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsKPIAccountTargetRuntime từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsKPIAccountTargetRuntime> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsKPIAccountTargetRuntime> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsKPIAccountTargetRuntime từ Database
		/// </summary>
		GsKPIAccountTargetRuntime GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsKPIAccountTargetRuntime đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsKPIAccountTargetRuntime GetObjectCon(string schema, string condition, params Object[] parameters);
		GsKPIAccountTargetRuntime GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsKPIAccountTargetRuntime vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsKPIAccountTargetRuntime _GsKPIAccountTargetRuntime);
		/// <summary>
		/// Insert danh sách đối tượng GsKPIAccountTargetRuntime vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsKPIAccountTargetRuntime> _GsKPIAccountTargetRuntimes);
		/// <summary>
		/// Cập nhật GsKPIAccountTargetRuntime vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsKPIAccountTargetRuntime _GsKPIAccountTargetRuntime, String Id);
		/// <summary>
		/// Cập nhật GsKPIAccountTargetRuntime vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsKPIAccountTargetRuntime _GsKPIAccountTargetRuntime);
		/// <summary>
		/// Cập nhật danh sách GsKPIAccountTargetRuntime vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsKPIAccountTargetRuntime> _GsKPIAccountTargetRuntimes);
		/// <summary>
		/// Cập nhật GsKPIAccountTargetRuntime vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsKPIAccountTargetRuntime _GsKPIAccountTargetRuntime, string condition);
		/// <summary>
		/// Xóa GsKPIAccountTargetRuntime trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsKPIAccountTargetRuntime trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsKPIAccountTargetRuntime _GsKPIAccountTargetRuntime);
		/// <summary>
		/// Xóa GsKPIAccountTargetRuntime trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsKPIAccountTargetRuntime trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsKPIAccountTargetRuntime> _GsKPIAccountTargetRuntimes);
	}
}
