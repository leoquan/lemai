using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpbankemail
	{
		/// <summary>
		/// Lấy một DataTable GExpBankEmail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpBankEmail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpBankEmail từ Database
		/// </summary>
		List<GExpBankEmail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpBankEmail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpBankEmail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpBankEmail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpBankEmail từ Database
		/// </summary>
		GExpBankEmail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpBankEmail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpBankEmail GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpBankEmail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpBankEmail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpBankEmail _GExpBankEmail);
		/// <summary>
		/// Insert danh sách đối tượng GExpBankEmail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpBankEmail> _GExpBankEmails);
		/// <summary>
		/// Cập nhật GExpBankEmail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpBankEmail _GExpBankEmail, String Id);
		/// <summary>
		/// Cập nhật GExpBankEmail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpBankEmail _GExpBankEmail);
		/// <summary>
		/// Cập nhật danh sách GExpBankEmail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpBankEmail> _GExpBankEmails);
		/// <summary>
		/// Cập nhật GExpBankEmail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpBankEmail _GExpBankEmail, string condition);
		/// <summary>
		/// Xóa GExpBankEmail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpBankEmail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpBankEmail _GExpBankEmail);
		/// <summary>
		/// Xóa GExpBankEmail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpBankEmail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpBankEmail> _GExpBankEmails);
	}
}
