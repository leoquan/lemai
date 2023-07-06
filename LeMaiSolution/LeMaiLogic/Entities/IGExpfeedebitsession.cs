using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpfeedebitsession
	{
		/// <summary>
		/// Lấy một DataTable GExpFeeDebitSession từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpFeeDebitSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpFeeDebitSession từ Database
		/// </summary>
		List<GExpFeeDebitSession> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpFeeDebitSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpFeeDebitSession> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpFeeDebitSession> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpFeeDebitSession từ Database
		/// </summary>
		GExpFeeDebitSession GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpFeeDebitSession đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpFeeDebitSession GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpFeeDebitSession GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpFeeDebitSession vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpFeeDebitSession _GExpFeeDebitSession);
		/// <summary>
		/// Insert danh sách đối tượng GExpFeeDebitSession vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpFeeDebitSession> _GExpFeeDebitSessions);
		/// <summary>
		/// Cập nhật GExpFeeDebitSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpFeeDebitSession _GExpFeeDebitSession, String Id);
		/// <summary>
		/// Cập nhật GExpFeeDebitSession vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpFeeDebitSession _GExpFeeDebitSession);
		/// <summary>
		/// Cập nhật danh sách GExpFeeDebitSession vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpFeeDebitSession> _GExpFeeDebitSessions);
		/// <summary>
		/// Cập nhật GExpFeeDebitSession vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpFeeDebitSession _GExpFeeDebitSession, string condition);
		/// <summary>
		/// Xóa GExpFeeDebitSession trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpFeeDebitSession trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpFeeDebitSession _GExpFeeDebitSession);
		/// <summary>
		/// Xóa GExpFeeDebitSession trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpFeeDebitSession trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpFeeDebitSession> _GExpFeeDebitSessions);
	}
}
