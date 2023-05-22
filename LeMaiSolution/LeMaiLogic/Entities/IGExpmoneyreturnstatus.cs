using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpmoneyreturnstatus
	{
		/// <summary>
		/// Lấy một DataTable GExpMoneyReturnStatus từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpMoneyReturnStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpMoneyReturnStatus từ Database
		/// </summary>
		List<GExpMoneyReturnStatus> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpMoneyReturnStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpMoneyReturnStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpMoneyReturnStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpMoneyReturnStatus từ Database
		/// </summary>
		GExpMoneyReturnStatus GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một GExpMoneyReturnStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpMoneyReturnStatus GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpMoneyReturnStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpMoneyReturnStatus vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpMoneyReturnStatus _GExpMoneyReturnStatus);
		/// <summary>
		/// Insert danh sách đối tượng GExpMoneyReturnStatus vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpMoneyReturnStatus> _GExpMoneyReturnStatuss);
		/// <summary>
		/// Cập nhật GExpMoneyReturnStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpMoneyReturnStatus _GExpMoneyReturnStatus, Int32 Id);
		/// <summary>
		/// Cập nhật GExpMoneyReturnStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpMoneyReturnStatus _GExpMoneyReturnStatus);
		/// <summary>
		/// Cập nhật danh sách GExpMoneyReturnStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpMoneyReturnStatus> _GExpMoneyReturnStatuss);
		/// <summary>
		/// Cập nhật GExpMoneyReturnStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpMoneyReturnStatus _GExpMoneyReturnStatus, string condition);
		/// <summary>
		/// Xóa GExpMoneyReturnStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa GExpMoneyReturnStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpMoneyReturnStatus _GExpMoneyReturnStatus);
		/// <summary>
		/// Xóa GExpMoneyReturnStatus trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpMoneyReturnStatus trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpMoneyReturnStatus> _GExpMoneyReturnStatuss);
	}
}
