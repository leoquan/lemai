using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpconsignmentstatus
	{
		/// <summary>
		/// Lấy một DataTable ExpConsignmentStatus từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpConsignmentStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpConsignmentStatus từ Database
		/// </summary>
		List<ExpConsignmentStatus> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpConsignmentStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpConsignmentStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpConsignmentStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpConsignmentStatus từ Database
		/// </summary>
		ExpConsignmentStatus GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpConsignmentStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpConsignmentStatus GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpConsignmentStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpConsignmentStatus vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpConsignmentStatus _ExpConsignmentStatus);
		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentStatus vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpConsignmentStatus> _ExpConsignmentStatuss);
		/// <summary>
		/// Cập nhật ExpConsignmentStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpConsignmentStatus _ExpConsignmentStatus, String Id);
		/// <summary>
		/// Cập nhật ExpConsignmentStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpConsignmentStatus _ExpConsignmentStatus);
		/// <summary>
		/// Cập nhật danh sách ExpConsignmentStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpConsignmentStatus> _ExpConsignmentStatuss);
		/// <summary>
		/// Cập nhật ExpConsignmentStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpConsignmentStatus _ExpConsignmentStatus, string condition);
		/// <summary>
		/// Xóa ExpConsignmentStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpConsignmentStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpConsignmentStatus _ExpConsignmentStatus);
		/// <summary>
		/// Xóa ExpConsignmentStatus trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpConsignmentStatus trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpConsignmentStatus> _ExpConsignmentStatuss);
	}
}
