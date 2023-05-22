using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExperror
	{
		/// <summary>
		/// Lấy một DataTable GExpError từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpError từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpError từ Database
		/// </summary>
		List<GExpError> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpError từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpError> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpError> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpError từ Database
		/// </summary>
		GExpError GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpError đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpError GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpError GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpError vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpError _GExpError);
		/// <summary>
		/// Insert danh sách đối tượng GExpError vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpError> _GExpErrors);
		/// <summary>
		/// Cập nhật GExpError vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpError _GExpError, String Id);
		/// <summary>
		/// Cập nhật GExpError vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpError _GExpError);
		/// <summary>
		/// Cập nhật danh sách GExpError vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpError> _GExpErrors);
		/// <summary>
		/// Cập nhật GExpError vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpError _GExpError, string condition);
		/// <summary>
		/// Xóa GExpError trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpError trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpError _GExpError);
		/// <summary>
		/// Xóa GExpError trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpError trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpError> _GExpErrors);
	}
}
