using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExporder
	{
		/// <summary>
		/// Lấy một DataTable GExpOrder từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpOrder từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpOrder từ Database
		/// </summary>
		List<GExpOrder> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpOrder từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpOrder> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpOrder> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpOrder từ Database
		/// </summary>
		GExpOrder GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpOrder đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpOrder GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpOrder GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpOrder vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpOrder _GExpOrder);
		/// <summary>
		/// Insert danh sách đối tượng GExpOrder vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpOrder> _GExpOrders);
		/// <summary>
		/// Cập nhật GExpOrder vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpOrder _GExpOrder, String Id);
		/// <summary>
		/// Cập nhật GExpOrder vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpOrder _GExpOrder);
		/// <summary>
		/// Cập nhật danh sách GExpOrder vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpOrder> _GExpOrders);
		/// <summary>
		/// Cập nhật GExpOrder vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpOrder _GExpOrder, string condition);
		/// <summary>
		/// Xóa GExpOrder trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpOrder trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpOrder _GExpOrder);
		/// <summary>
		/// Xóa GExpOrder trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpOrder trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpOrder> _GExpOrders);
	}
}
