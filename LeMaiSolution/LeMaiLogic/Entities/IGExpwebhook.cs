using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpwebhook
	{
		/// <summary>
		/// Lấy một DataTable GExpWebhook từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpWebhook từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpWebhook từ Database
		/// </summary>
		List<GExpWebhook> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpWebhook từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpWebhook> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpWebhook> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpWebhook từ Database
		/// </summary>
		GExpWebhook GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpWebhook đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpWebhook GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpWebhook GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpWebhook vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpWebhook _GExpWebhook);
		/// <summary>
		/// Insert danh sách đối tượng GExpWebhook vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpWebhook> _GExpWebhooks);
		/// <summary>
		/// Cập nhật GExpWebhook vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpWebhook _GExpWebhook, String Id);
		/// <summary>
		/// Cập nhật GExpWebhook vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpWebhook _GExpWebhook);
		/// <summary>
		/// Cập nhật danh sách GExpWebhook vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpWebhook> _GExpWebhooks);
		/// <summary>
		/// Cập nhật GExpWebhook vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpWebhook _GExpWebhook, string condition);
		/// <summary>
		/// Xóa GExpWebhook trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpWebhook trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpWebhook _GExpWebhook);
		/// <summary>
		/// Xóa GExpWebhook trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpWebhook trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpWebhook> _GExpWebhooks);
	}
}
