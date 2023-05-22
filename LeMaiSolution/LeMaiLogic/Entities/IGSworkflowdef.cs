using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSworkflowdef
	{
		/// <summary>
		/// Lấy một DataTable GsWorkFlowDef từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsWorkFlowDef từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsWorkFlowDef từ Database
		/// </summary>
		List<GsWorkFlowDef> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsWorkFlowDef từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsWorkFlowDef> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsWorkFlowDef> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsWorkFlowDef từ Database
		/// </summary>
		GsWorkFlowDef GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsWorkFlowDef đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsWorkFlowDef GetObjectCon(string schema, string condition, params Object[] parameters);
		GsWorkFlowDef GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsWorkFlowDef vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsWorkFlowDef _GsWorkFlowDef);
		/// <summary>
		/// Insert danh sách đối tượng GsWorkFlowDef vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsWorkFlowDef> _GsWorkFlowDefs);
		/// <summary>
		/// Cập nhật GsWorkFlowDef vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsWorkFlowDef _GsWorkFlowDef, String Id);
		/// <summary>
		/// Cập nhật GsWorkFlowDef vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsWorkFlowDef _GsWorkFlowDef);
		/// <summary>
		/// Cập nhật danh sách GsWorkFlowDef vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsWorkFlowDef> _GsWorkFlowDefs);
		/// <summary>
		/// Cập nhật GsWorkFlowDef vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsWorkFlowDef _GsWorkFlowDef, string condition);
		/// <summary>
		/// Xóa GsWorkFlowDef trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsWorkFlowDef trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsWorkFlowDef _GsWorkFlowDef);
		/// <summary>
		/// Xóa GsWorkFlowDef trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsWorkFlowDef trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsWorkFlowDef> _GsWorkFlowDefs);
	}
}
