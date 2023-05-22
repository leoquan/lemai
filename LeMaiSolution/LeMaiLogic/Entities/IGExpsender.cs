using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpsender
	{
		/// <summary>
		/// Lấy một DataTable GExpSender từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpSender từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpSender từ Database
		/// </summary>
		List<GExpSender> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpSender từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpSender> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpSender> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpSender từ Database
		/// </summary>
		GExpSender GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpSender đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpSender GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpSender GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpSender vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpSender _GExpSender);
		/// <summary>
		/// Insert danh sách đối tượng GExpSender vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpSender> _GExpSenders);
		/// <summary>
		/// Cập nhật GExpSender vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpSender _GExpSender, String Id);
		/// <summary>
		/// Cập nhật GExpSender vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpSender _GExpSender);
		/// <summary>
		/// Cập nhật danh sách GExpSender vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpSender> _GExpSenders);
		/// <summary>
		/// Cập nhật GExpSender vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpSender _GExpSender, string condition);
		/// <summary>
		/// Xóa GExpSender trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpSender trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpSender _GExpSender);
		/// <summary>
		/// Xóa GExpSender trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpSender trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpSender> _GExpSenders);
	}
}
