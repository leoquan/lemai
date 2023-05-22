using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcheckbalance
	{
		/// <summary>
		/// Lấy một DataTable ExpCheckBalance từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCheckBalance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCheckBalance từ Database
		/// </summary>
		List<ExpCheckBalance> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCheckBalance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCheckBalance> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCheckBalance> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCheckBalance từ Database
		/// </summary>
		ExpCheckBalance GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpCheckBalance đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCheckBalance GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCheckBalance GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCheckBalance vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCheckBalance _ExpCheckBalance);
		/// <summary>
		/// Insert danh sách đối tượng ExpCheckBalance vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCheckBalance> _ExpCheckBalances);
		/// <summary>
		/// Cập nhật ExpCheckBalance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCheckBalance _ExpCheckBalance, String Id);
		/// <summary>
		/// Cập nhật ExpCheckBalance vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCheckBalance _ExpCheckBalance);
		/// <summary>
		/// Cập nhật danh sách ExpCheckBalance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCheckBalance> _ExpCheckBalances);
		/// <summary>
		/// Cập nhật ExpCheckBalance vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCheckBalance _ExpCheckBalance, string condition);
		/// <summary>
		/// Xóa ExpCheckBalance trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpCheckBalance trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCheckBalance _ExpCheckBalance);
		/// <summary>
		/// Xóa ExpCheckBalance trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCheckBalance trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCheckBalance> _ExpCheckBalances);
	}
}
