using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpbalancedetail
	{
		/// <summary>
		/// Lấy một DataTable GExpBalanceDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpBalanceDetail từ Database
		/// </summary>
		List<GExpBalanceDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpBalanceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpBalanceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpBalanceDetail từ Database
		/// </summary>
		GExpBalanceDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpBalanceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpBalanceDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpBalanceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpBalanceDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpBalanceDetail _GExpBalanceDetail);
		/// <summary>
		/// Insert danh sách đối tượng GExpBalanceDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpBalanceDetail> _GExpBalanceDetails);
		/// <summary>
		/// Cập nhật GExpBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpBalanceDetail _GExpBalanceDetail, String Id);
		/// <summary>
		/// Cập nhật GExpBalanceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpBalanceDetail _GExpBalanceDetail);
		/// <summary>
		/// Cập nhật danh sách GExpBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpBalanceDetail> _GExpBalanceDetails);
		/// <summary>
		/// Cập nhật GExpBalanceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpBalanceDetail _GExpBalanceDetail, string condition);
		/// <summary>
		/// Xóa GExpBalanceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpBalanceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpBalanceDetail _GExpBalanceDetail);
		/// <summary>
		/// Xóa GExpBalanceDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpBalanceDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpBalanceDetail> _GExpBalanceDetails);
	}
}
