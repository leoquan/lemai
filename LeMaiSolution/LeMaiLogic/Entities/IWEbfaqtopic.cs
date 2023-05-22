using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbfaqtopic
	{
		/// <summary>
		/// Lấy một DataTable WebFaqTopic từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebFaqTopic từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebFaqTopic từ Database
		/// </summary>
		List<WebFaqTopic> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebFaqTopic từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebFaqTopic> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebFaqTopic> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebFaqTopic từ Database
		/// </summary>
		WebFaqTopic GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebFaqTopic đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebFaqTopic GetObjectCon(string schema, string condition, params Object[] parameters);
		WebFaqTopic GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebFaqTopic vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebFaqTopic _WebFaqTopic);
		/// <summary>
		/// Insert danh sách đối tượng WebFaqTopic vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebFaqTopic> _WebFaqTopics);
		/// <summary>
		/// Cập nhật WebFaqTopic vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebFaqTopic _WebFaqTopic, String Id);
		/// <summary>
		/// Cập nhật WebFaqTopic vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebFaqTopic _WebFaqTopic);
		/// <summary>
		/// Cập nhật danh sách WebFaqTopic vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebFaqTopic> _WebFaqTopics);
		/// <summary>
		/// Cập nhật WebFaqTopic vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebFaqTopic _WebFaqTopic, string condition);
		/// <summary>
		/// Xóa WebFaqTopic trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebFaqTopic trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebFaqTopic _WebFaqTopic);
		/// <summary>
		/// Xóa WebFaqTopic trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebFaqTopic trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebFaqTopic> _WebFaqTopics);
	}
}
