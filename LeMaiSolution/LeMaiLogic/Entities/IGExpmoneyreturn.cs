using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpmoneyreturn
	{
		/// <summary>
		/// Lấy một DataTable GExpMoneyReturn từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpMoneyReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpMoneyReturn từ Database
		/// </summary>
		List<GExpMoneyReturn> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpMoneyReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpMoneyReturn> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpMoneyReturn> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpMoneyReturn từ Database
		/// </summary>
		GExpMoneyReturn GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpMoneyReturn đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpMoneyReturn GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpMoneyReturn GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpMoneyReturn vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpMoneyReturn _GExpMoneyReturn);
		/// <summary>
		/// Insert danh sách đối tượng GExpMoneyReturn vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpMoneyReturn> _GExpMoneyReturns);
		/// <summary>
		/// Cập nhật GExpMoneyReturn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpMoneyReturn _GExpMoneyReturn, String Id);
		/// <summary>
		/// Cập nhật GExpMoneyReturn vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpMoneyReturn _GExpMoneyReturn);
		/// <summary>
		/// Cập nhật danh sách GExpMoneyReturn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpMoneyReturn> _GExpMoneyReturns);
		/// <summary>
		/// Cập nhật GExpMoneyReturn vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpMoneyReturn _GExpMoneyReturn, string condition);
		/// <summary>
		/// Xóa GExpMoneyReturn trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpMoneyReturn trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpMoneyReturn _GExpMoneyReturn);
		/// <summary>
		/// Xóa GExpMoneyReturn trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpMoneyReturn trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpMoneyReturn> _GExpMoneyReturns);
	}
}
