using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXppost
	{
		/// <summary>
		/// Lấy một DataTable ExpPost từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpPost từ Database
		/// </summary>
		List<ExpPost> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpPost> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpPost> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpPost từ Database
		/// </summary>
		ExpPost GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpPost đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpPost GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpPost GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpPost vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpPost _ExpPost);
		/// <summary>
		/// Insert danh sách đối tượng ExpPost vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpPost> _ExpPosts);
		/// <summary>
		/// Cập nhật ExpPost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpPost _ExpPost, String Id);
		/// <summary>
		/// Cập nhật ExpPost vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpPost _ExpPost);
		/// <summary>
		/// Cập nhật danh sách ExpPost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpPost> _ExpPosts);
		/// <summary>
		/// Cập nhật ExpPost vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpPost _ExpPost, string condition);
		/// <summary>
		/// Xóa ExpPost trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpPost trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpPost _ExpPost);
		/// <summary>
		/// Xóa ExpPost trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpPost trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpPost> _ExpPosts);
	}
}
