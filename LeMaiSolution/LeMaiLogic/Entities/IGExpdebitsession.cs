using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdebitsession
	{
		/// <summary>
		/// Lấy một DataTable GExpDebitSession từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDebitSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDebitSession từ Database
		/// </summary>
		List<GExpDebitSession> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDebitSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDebitSession> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDebitSession> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDebitSession từ Database
		/// </summary>
		GExpDebitSession GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpDebitSession đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDebitSession GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDebitSession GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDebitSession vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDebitSession _GExpDebitSession);
		/// <summary>
		/// Insert danh sách đối tượng GExpDebitSession vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDebitSession> _GExpDebitSessions);
		/// <summary>
		/// Cập nhật GExpDebitSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDebitSession _GExpDebitSession, String Id);
		/// <summary>
		/// Cập nhật GExpDebitSession vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDebitSession _GExpDebitSession);
		/// <summary>
		/// Cập nhật danh sách GExpDebitSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDebitSession> _GExpDebitSessions);
		/// <summary>
		/// Cập nhật GExpDebitSession vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDebitSession _GExpDebitSession, string condition);
		/// <summary>
		/// Xóa GExpDebitSession trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpDebitSession trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDebitSession _GExpDebitSession);
		/// <summary>
		/// Xóa GExpDebitSession trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDebitSession trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDebitSession> _GExpDebitSessions);
	}
}
