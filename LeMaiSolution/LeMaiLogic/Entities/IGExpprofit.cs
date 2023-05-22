using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprofit
	{
		/// <summary>
		/// Lấy một DataTable GExpProfit từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProfit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProfit từ Database
		/// </summary>
		List<GExpProfit> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProfit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProfit> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProfit> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProfit từ Database
		/// </summary>
		GExpProfit GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpProfit đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProfit GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProfit GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProfit vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProfit _GExpProfit);
		/// <summary>
		/// Insert danh sách đối tượng GExpProfit vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProfit> _GExpProfits);
		/// <summary>
		/// Cập nhật GExpProfit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProfit _GExpProfit, String Id);
		/// <summary>
		/// Cập nhật GExpProfit vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProfit _GExpProfit);
		/// <summary>
		/// Cập nhật danh sách GExpProfit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProfit> _GExpProfits);
		/// <summary>
		/// Cập nhật GExpProfit vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProfit _GExpProfit, string condition);
		/// <summary>
		/// Xóa GExpProfit trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpProfit trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProfit _GExpProfit);
		/// <summary>
		/// Xóa GExpProfit trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProfit trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProfit> _GExpProfits);
	}
}
