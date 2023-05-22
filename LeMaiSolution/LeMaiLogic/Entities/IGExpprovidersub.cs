using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovidersub
	{
		/// <summary>
		/// Lấy một DataTable GExpProviderSub từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProviderSub từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProviderSub từ Database
		/// </summary>
		List<GExpProviderSub> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProviderSub từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProviderSub> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProviderSub> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProviderSub từ Database
		/// </summary>
		GExpProviderSub GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpProviderSub đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProviderSub GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProviderSub GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProviderSub vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProviderSub _GExpProviderSub);
		/// <summary>
		/// Insert danh sách đối tượng GExpProviderSub vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProviderSub> _GExpProviderSubs);
		/// <summary>
		/// Cập nhật GExpProviderSub vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProviderSub _GExpProviderSub, String Id);
		/// <summary>
		/// Cập nhật GExpProviderSub vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProviderSub _GExpProviderSub);
		/// <summary>
		/// Cập nhật danh sách GExpProviderSub vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProviderSub> _GExpProviderSubs);
		/// <summary>
		/// Cập nhật GExpProviderSub vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProviderSub _GExpProviderSub, string condition);
		/// <summary>
		/// Xóa GExpProviderSub trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpProviderSub trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProviderSub _GExpProviderSub);
		/// <summary>
		/// Xóa GExpProviderSub trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProviderSub trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProviderSub> _GExpProviderSubs);
	}
}
