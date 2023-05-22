using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcommenttype
	{
		/// <summary>
		/// Lấy một DataTable ExpCommentType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCommentType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCommentType từ Database
		/// </summary>
		List<ExpCommentType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCommentType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCommentType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCommentType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCommentType từ Database
		/// </summary>
		ExpCommentType GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpCommentType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCommentType GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCommentType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCommentType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCommentType _ExpCommentType);
		/// <summary>
		/// Insert danh sách đối tượng ExpCommentType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCommentType> _ExpCommentTypes);
		/// <summary>
		/// Cập nhật ExpCommentType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCommentType _ExpCommentType, String Id);
		/// <summary>
		/// Cập nhật ExpCommentType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCommentType _ExpCommentType);
		/// <summary>
		/// Cập nhật danh sách ExpCommentType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCommentType> _ExpCommentTypes);
		/// <summary>
		/// Cập nhật ExpCommentType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCommentType _ExpCommentType, string condition);
		/// <summary>
		/// Xóa ExpCommentType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpCommentType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCommentType _ExpCommentType);
		/// <summary>
		/// Xóa ExpCommentType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCommentType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCommentType> _ExpCommentTypes);
	}
}
