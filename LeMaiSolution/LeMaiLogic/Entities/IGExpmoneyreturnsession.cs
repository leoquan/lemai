using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpmoneyreturnsession
	{
		/// <summary>
		/// Lấy một DataTable GExpMoneyReturnSession từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpMoneyReturnSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpMoneyReturnSession từ Database
		/// </summary>
		List<GExpMoneyReturnSession> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpMoneyReturnSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpMoneyReturnSession> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpMoneyReturnSession> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpMoneyReturnSession từ Database
		/// </summary>
		GExpMoneyReturnSession GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpMoneyReturnSession đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpMoneyReturnSession GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpMoneyReturnSession GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpMoneyReturnSession vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpMoneyReturnSession _GExpMoneyReturnSession);
		/// <summary>
		/// Insert danh sách đối tượng GExpMoneyReturnSession vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpMoneyReturnSession> _GExpMoneyReturnSessions);
		/// <summary>
		/// Cập nhật GExpMoneyReturnSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpMoneyReturnSession _GExpMoneyReturnSession, String Id);
		/// <summary>
		/// Cập nhật GExpMoneyReturnSession vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpMoneyReturnSession _GExpMoneyReturnSession);
		/// <summary>
		/// Cập nhật danh sách GExpMoneyReturnSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpMoneyReturnSession> _GExpMoneyReturnSessions);
		/// <summary>
		/// Cập nhật GExpMoneyReturnSession vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpMoneyReturnSession _GExpMoneyReturnSession, string condition);
		/// <summary>
		/// Xóa GExpMoneyReturnSession trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpMoneyReturnSession trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpMoneyReturnSession _GExpMoneyReturnSession);
		/// <summary>
		/// Xóa GExpMoneyReturnSession trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpMoneyReturnSession trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpMoneyReturnSession> _GExpMoneyReturnSessions);
	}
}
