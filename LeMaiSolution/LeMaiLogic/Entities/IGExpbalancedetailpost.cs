using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpbalancedetailpost
	{
		/// <summary>
		/// Lấy một DataTable GExpBalanceDetailPost từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpBalanceDetailPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpBalanceDetailPost từ Database
		/// </summary>
		List<GExpBalanceDetailPost> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpBalanceDetailPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpBalanceDetailPost> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpBalanceDetailPost> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpBalanceDetailPost từ Database
		/// </summary>
		GExpBalanceDetailPost GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpBalanceDetailPost đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpBalanceDetailPost GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpBalanceDetailPost GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpBalanceDetailPost vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpBalanceDetailPost _GExpBalanceDetailPost);
		/// <summary>
		/// Insert danh sách đối tượng GExpBalanceDetailPost vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpBalanceDetailPost> _GExpBalanceDetailPosts);
		/// <summary>
		/// Cập nhật GExpBalanceDetailPost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpBalanceDetailPost _GExpBalanceDetailPost, String Id);
		/// <summary>
		/// Cập nhật GExpBalanceDetailPost vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpBalanceDetailPost _GExpBalanceDetailPost);
		/// <summary>
		/// Cập nhật danh sách GExpBalanceDetailPost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpBalanceDetailPost> _GExpBalanceDetailPosts);
		/// <summary>
		/// Cập nhật GExpBalanceDetailPost vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpBalanceDetailPost _GExpBalanceDetailPost, string condition);
		/// <summary>
		/// Xóa GExpBalanceDetailPost trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpBalanceDetailPost trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpBalanceDetailPost _GExpBalanceDetailPost);
		/// <summary>
		/// Xóa GExpBalanceDetailPost trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpBalanceDetailPost trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpBalanceDetailPost> _GExpBalanceDetailPosts);
	}
}
