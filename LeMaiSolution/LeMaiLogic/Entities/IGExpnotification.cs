using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpnotification
	{
		/// <summary>
		/// Lấy một DataTable GExpNotification từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpNotification từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpNotification từ Database
		/// </summary>
		List<GExpNotification> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpNotification từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpNotification> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpNotification> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpNotification từ Database
		/// </summary>
		GExpNotification GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpNotification đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpNotification GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpNotification GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpNotification vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpNotification _GExpNotification);
		/// <summary>
		/// Insert danh sách đối tượng GExpNotification vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpNotification> _GExpNotifications);
		/// <summary>
		/// Cập nhật GExpNotification vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpNotification _GExpNotification, String Id);
		/// <summary>
		/// Cập nhật GExpNotification vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpNotification _GExpNotification);
		/// <summary>
		/// Cập nhật danh sách GExpNotification vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpNotification> _GExpNotifications);
		/// <summary>
		/// Cập nhật GExpNotification vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpNotification _GExpNotification, string condition);
		/// <summary>
		/// Xóa GExpNotification trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpNotification trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpNotification _GExpNotification);
		/// <summary>
		/// Xóa GExpNotification trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpNotification trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpNotification> _GExpNotifications);
	}
}
