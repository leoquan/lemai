using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpwebhookport
	{
		/// <summary>
		/// Lấy một DataTable GExpWebhookPort từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpWebhookPort từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpWebhookPort từ Database
		/// </summary>
		List<GExpWebhookPort> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpWebhookPort từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpWebhookPort> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpWebhookPort> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpWebhookPort từ Database
		/// </summary>
		GExpWebhookPort GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpWebhookPort đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpWebhookPort GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpWebhookPort GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpWebhookPort vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpWebhookPort _GExpWebhookPort);
		/// <summary>
		/// Insert danh sách đối tượng GExpWebhookPort vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpWebhookPort> _GExpWebhookPorts);
		/// <summary>
		/// Cập nhật GExpWebhookPort vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpWebhookPort _GExpWebhookPort, String Id);
		/// <summary>
		/// Cập nhật GExpWebhookPort vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpWebhookPort _GExpWebhookPort);
		/// <summary>
		/// Cập nhật danh sách GExpWebhookPort vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpWebhookPort> _GExpWebhookPorts);
		/// <summary>
		/// Cập nhật GExpWebhookPort vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpWebhookPort _GExpWebhookPort, string condition);
		/// <summary>
		/// Xóa GExpWebhookPort trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpWebhookPort trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpWebhookPort _GExpWebhookPort);
		/// <summary>
		/// Xóa GExpWebhookPort trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpWebhookPort trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpWebhookPort> _GExpWebhookPorts);
	}
}
