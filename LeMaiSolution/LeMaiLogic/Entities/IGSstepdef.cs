using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSstepdef
	{
		/// <summary>
		/// Lấy một DataTable GsStepDef từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsStepDef từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsStepDef từ Database
		/// </summary>
		List<GsStepDef> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsStepDef từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsStepDef> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsStepDef> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsStepDef từ Database
		/// </summary>
		GsStepDef GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsStepDef đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsStepDef GetObjectCon(string schema, string condition, params Object[] parameters);
		GsStepDef GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsStepDef vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsStepDef _GsStepDef);
		/// <summary>
		/// Insert danh sách đối tượng GsStepDef vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsStepDef> _GsStepDefs);
		/// <summary>
		/// Cập nhật GsStepDef vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsStepDef _GsStepDef, String Id);
		/// <summary>
		/// Cập nhật GsStepDef vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsStepDef _GsStepDef);
		/// <summary>
		/// Cập nhật danh sách GsStepDef vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsStepDef> _GsStepDefs);
		/// <summary>
		/// Cập nhật GsStepDef vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsStepDef _GsStepDef, string condition);
		/// <summary>
		/// Xóa GsStepDef trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsStepDef trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsStepDef _GsStepDef);
		/// <summary>
		/// Xóa GsStepDef trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsStepDef trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsStepDef> _GsStepDefs);
	}
}
