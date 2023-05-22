using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSrequestinstance
	{
		/// <summary>
		/// Lấy một DataTable GsRequestInstance từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsRequestInstance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsRequestInstance từ Database
		/// </summary>
		List<GsRequestInstance> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsRequestInstance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsRequestInstance> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsRequestInstance> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsRequestInstance từ Database
		/// </summary>
		GsRequestInstance GetObject(string schema, String FK_RequestProduct, String FK_StepDef);
		/// <summary>
		/// Lấy một GsRequestInstance đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsRequestInstance GetObjectCon(string schema, string condition, params Object[] parameters);
		GsRequestInstance GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsRequestInstance vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsRequestInstance _GsRequestInstance);
		/// <summary>
		/// Insert danh sách đối tượng GsRequestInstance vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsRequestInstance> _GsRequestInstances);
		/// <summary>
		/// Cập nhật GsRequestInstance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsRequestInstance _GsRequestInstance, String FK_RequestProduct, String FK_StepDef);
		/// <summary>
		/// Cập nhật GsRequestInstance vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsRequestInstance _GsRequestInstance);
		/// <summary>
		/// Cập nhật danh sách GsRequestInstance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsRequestInstance> _GsRequestInstances);
		/// <summary>
		/// Cập nhật GsRequestInstance vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsRequestInstance _GsRequestInstance, string condition);
		/// <summary>
		/// Xóa GsRequestInstance trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_RequestProduct, String FK_StepDef);
		/// <summary>
		/// Xóa GsRequestInstance trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsRequestInstance _GsRequestInstance);
		/// <summary>
		/// Xóa GsRequestInstance trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsRequestInstance trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsRequestInstance> _GsRequestInstances);
	}
}
