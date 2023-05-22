using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpbalancedetail
	{
		/// <summary>
		/// Lấy một DataTable ExpBalanceDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpBalanceDetail từ Database
		/// </summary>
		List<ExpBalanceDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpBalanceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpBalanceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpBalanceDetail từ Database
		/// </summary>
		ExpBalanceDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpBalanceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpBalanceDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpBalanceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpBalanceDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpBalanceDetail _ExpBalanceDetail);
		/// <summary>
		/// Insert danh sách đối tượng ExpBalanceDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpBalanceDetail> _ExpBalanceDetails);
		/// <summary>
		/// Cập nhật ExpBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpBalanceDetail _ExpBalanceDetail, String Id);
		/// <summary>
		/// Cập nhật ExpBalanceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpBalanceDetail _ExpBalanceDetail);
		/// <summary>
		/// Cập nhật danh sách ExpBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpBalanceDetail> _ExpBalanceDetails);
		/// <summary>
		/// Cập nhật ExpBalanceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpBalanceDetail _ExpBalanceDetail, string condition);
		/// <summary>
		/// Xóa ExpBalanceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpBalanceDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpBalanceDetail _ExpBalanceDetail);
		/// <summary>
		/// Xóa ExpBalanceDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpBalanceDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpBalanceDetail> _ExpBalanceDetails);
	}
}
