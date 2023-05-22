using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpbalancedetailtype
	{
		/// <summary>
		/// Lấy một DataTable GExpBalanceDetailType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpBalanceDetailType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpBalanceDetailType từ Database
		/// </summary>
		List<GExpBalanceDetailType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpBalanceDetailType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpBalanceDetailType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpBalanceDetailType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpBalanceDetailType từ Database
		/// </summary>
		GExpBalanceDetailType GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpBalanceDetailType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpBalanceDetailType GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpBalanceDetailType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpBalanceDetailType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpBalanceDetailType _GExpBalanceDetailType);
		/// <summary>
		/// Insert danh sách đối tượng GExpBalanceDetailType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpBalanceDetailType> _GExpBalanceDetailTypes);
		/// <summary>
		/// Cập nhật GExpBalanceDetailType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpBalanceDetailType _GExpBalanceDetailType, String Id);
		/// <summary>
		/// Cập nhật GExpBalanceDetailType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpBalanceDetailType _GExpBalanceDetailType);
		/// <summary>
		/// Cập nhật danh sách GExpBalanceDetailType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpBalanceDetailType> _GExpBalanceDetailTypes);
		/// <summary>
		/// Cập nhật GExpBalanceDetailType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpBalanceDetailType _GExpBalanceDetailType, string condition);
		/// <summary>
		/// Xóa GExpBalanceDetailType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpBalanceDetailType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpBalanceDetailType _GExpBalanceDetailType);
		/// <summary>
		/// Xóa GExpBalanceDetailType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpBalanceDetailType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpBalanceDetailType> _GExpBalanceDetailTypes);
	}
}
