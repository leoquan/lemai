using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpcode
	{
		/// <summary>
		/// Lấy một DataTable GExpCode từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpCode từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpCode từ Database
		/// </summary>
		List<GExpCode> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpCode từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpCode> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpCode> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpCode từ Database
		/// </summary>
		GExpCode GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpCode đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpCode GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpCode GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpCode vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpCode _GExpCode);
		/// <summary>
		/// Insert danh sách đối tượng GExpCode vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpCode> _GExpCodes);
		/// <summary>
		/// Cập nhật GExpCode vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpCode _GExpCode, String Id);
		/// <summary>
		/// Cập nhật GExpCode vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpCode _GExpCode);
		/// <summary>
		/// Cập nhật danh sách GExpCode vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpCode> _GExpCodes);
		/// <summary>
		/// Cập nhật GExpCode vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpCode _GExpCode, string condition);
		/// <summary>
		/// Xóa GExpCode trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpCode trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpCode _GExpCode);
		/// <summary>
		/// Xóa GExpCode trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpCode trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpCode> _GExpCodes);
	}
}
