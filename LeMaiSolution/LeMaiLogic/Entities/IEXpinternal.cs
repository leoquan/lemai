using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpinternal
	{
		/// <summary>
		/// Lấy một DataTable ExpInternal từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpInternal từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpInternal từ Database
		/// </summary>
		List<ExpInternal> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpInternal từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpInternal> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpInternal> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpInternal từ Database
		/// </summary>
		ExpInternal GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpInternal đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpInternal GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpInternal GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpInternal vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpInternal _ExpInternal);
		/// <summary>
		/// Insert danh sách đối tượng ExpInternal vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpInternal> _ExpInternals);
		/// <summary>
		/// Cập nhật ExpInternal vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpInternal _ExpInternal, String Id);
		/// <summary>
		/// Cập nhật ExpInternal vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpInternal _ExpInternal);
		/// <summary>
		/// Cập nhật danh sách ExpInternal vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpInternal> _ExpInternals);
		/// <summary>
		/// Cập nhật ExpInternal vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpInternal _ExpInternal, string condition);
		/// <summary>
		/// Xóa ExpInternal trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpInternal trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpInternal _ExpInternal);
		/// <summary>
		/// Xóa ExpInternal trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpInternal trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpInternal> _ExpInternals);
	}
}
