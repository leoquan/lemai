using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbreviews
	{
		/// <summary>
		/// Lấy một DataTable WebReviews từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebReviews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebReviews từ Database
		/// </summary>
		List<WebReviews> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebReviews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebReviews> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebReviews> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebReviews từ Database
		/// </summary>
		WebReviews GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebReviews đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebReviews GetObjectCon(string schema, string condition, params Object[] parameters);
		WebReviews GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebReviews vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebReviews _WebReviews);
		/// <summary>
		/// Insert danh sách đối tượng WebReviews vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebReviews> _WebReviewss);
		/// <summary>
		/// Cập nhật WebReviews vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebReviews _WebReviews, String Id);
		/// <summary>
		/// Cập nhật WebReviews vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebReviews _WebReviews);
		/// <summary>
		/// Cập nhật danh sách WebReviews vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebReviews> _WebReviewss);
		/// <summary>
		/// Cập nhật WebReviews vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebReviews _WebReviews, string condition);
		/// <summary>
		/// Xóa WebReviews trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebReviews trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebReviews _WebReviews);
		/// <summary>
		/// Xóa WebReviews trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebReviews trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebReviews> _WebReviewss);
	}
}
