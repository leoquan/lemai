using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpbillstatus
	{
		/// <summary>
		/// Lấy một DataTable ExpBILLStatus từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpBILLStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpBILLStatus từ Database
		/// </summary>
		List<ExpBILLStatus> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpBILLStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpBILLStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpBILLStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpBILLStatus từ Database
		/// </summary>
		ExpBILLStatus GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một ExpBILLStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpBILLStatus GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpBILLStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpBILLStatus vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpBILLStatus _ExpBILLStatus);
		/// <summary>
		/// Insert danh sách đối tượng ExpBILLStatus vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpBILLStatus> _ExpBILLStatuss);
		/// <summary>
		/// Cập nhật ExpBILLStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpBILLStatus _ExpBILLStatus, Int32 Id);
		/// <summary>
		/// Cập nhật ExpBILLStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpBILLStatus _ExpBILLStatus);
		/// <summary>
		/// Cập nhật danh sách ExpBILLStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpBILLStatus> _ExpBILLStatuss);
		/// <summary>
		/// Cập nhật ExpBILLStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpBILLStatus _ExpBILLStatus, string condition);
		/// <summary>
		/// Xóa ExpBILLStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa ExpBILLStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpBILLStatus _ExpBILLStatus);
		/// <summary>
		/// Xóa ExpBILLStatus trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpBILLStatus trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpBILLStatus> _ExpBILLStatuss);
	}
}
