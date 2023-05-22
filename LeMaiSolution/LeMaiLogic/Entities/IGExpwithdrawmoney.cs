using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpwithdrawmoney
	{
		/// <summary>
		/// Lấy một DataTable GExpWithdrawMoney từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpWithdrawMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpWithdrawMoney từ Database
		/// </summary>
		List<GExpWithdrawMoney> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpWithdrawMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpWithdrawMoney> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpWithdrawMoney> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpWithdrawMoney từ Database
		/// </summary>
		GExpWithdrawMoney GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpWithdrawMoney đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpWithdrawMoney GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpWithdrawMoney GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpWithdrawMoney vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpWithdrawMoney _GExpWithdrawMoney);
		/// <summary>
		/// Insert danh sách đối tượng GExpWithdrawMoney vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpWithdrawMoney> _GExpWithdrawMoneys);
		/// <summary>
		/// Cập nhật GExpWithdrawMoney vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpWithdrawMoney _GExpWithdrawMoney, String Id);
		/// <summary>
		/// Cập nhật GExpWithdrawMoney vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpWithdrawMoney _GExpWithdrawMoney);
		/// <summary>
		/// Cập nhật danh sách GExpWithdrawMoney vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpWithdrawMoney> _GExpWithdrawMoneys);
		/// <summary>
		/// Cập nhật GExpWithdrawMoney vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpWithdrawMoney _GExpWithdrawMoney, string condition);
		/// <summary>
		/// Xóa GExpWithdrawMoney trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpWithdrawMoney trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpWithdrawMoney _GExpWithdrawMoney);
		/// <summary>
		/// Xóa GExpWithdrawMoney trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpWithdrawMoney trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpWithdrawMoney> _GExpWithdrawMoneys);
	}
}
