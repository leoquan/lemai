using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcomment
	{
		/// <summary>
		/// Lấy một DataTable ExpComment từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpComment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpComment từ Database
		/// </summary>
		List<ExpComment> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpComment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpComment> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpComment> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpComment từ Database
		/// </summary>
		ExpComment GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpComment đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpComment GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpComment GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpComment vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpComment _ExpComment);
		/// <summary>
		/// Insert danh sách đối tượng ExpComment vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpComment> _ExpComments);
		/// <summary>
		/// Cập nhật ExpComment vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpComment _ExpComment, String Id);
		/// <summary>
		/// Cập nhật ExpComment vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpComment _ExpComment);
		/// <summary>
		/// Cập nhật danh sách ExpComment vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpComment> _ExpComments);
		/// <summary>
		/// Cập nhật ExpComment vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpComment _ExpComment, string condition);
		/// <summary>
		/// Xóa ExpComment trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpComment trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpComment _ExpComment);
		/// <summary>
		/// Xóa ExpComment trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpComment trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpComment> _ExpComments);
	}
}
