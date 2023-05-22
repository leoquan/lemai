using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovider
	{
		/// <summary>
		/// Lấy một DataTable GExpProvider từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProvider từ Database
		/// </summary>
		List<GExpProvider> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProvider> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProvider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProvider từ Database
		/// </summary>
		GExpProvider GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpProvider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProvider GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProvider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProvider vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProvider _GExpProvider);
		/// <summary>
		/// Insert danh sách đối tượng GExpProvider vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProvider> _GExpProviders);
		/// <summary>
		/// Cập nhật GExpProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProvider _GExpProvider, String Id);
		/// <summary>
		/// Cập nhật GExpProvider vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProvider _GExpProvider);
		/// <summary>
		/// Cập nhật danh sách GExpProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProvider> _GExpProviders);
		/// <summary>
		/// Cập nhật GExpProvider vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProvider _GExpProvider, string condition);
		/// <summary>
		/// Xóa GExpProvider trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpProvider trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProvider _GExpProvider);
		/// <summary>
		/// Xóa GExpProvider trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProvider trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProvider> _GExpProviders);
	}
}
