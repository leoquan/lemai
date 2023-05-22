using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcontentmessage
	{
		/// <summary>
		/// Lấy một DataTable ExpContentMessage từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpContentMessage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpContentMessage từ Database
		/// </summary>
		List<ExpContentMessage> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpContentMessage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpContentMessage> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpContentMessage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpContentMessage từ Database
		/// </summary>
		ExpContentMessage GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpContentMessage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpContentMessage GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpContentMessage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpContentMessage vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpContentMessage _ExpContentMessage);
		/// <summary>
		/// Insert danh sách đối tượng ExpContentMessage vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpContentMessage> _ExpContentMessages);
		/// <summary>
		/// Cập nhật ExpContentMessage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpContentMessage _ExpContentMessage, String Id);
		/// <summary>
		/// Cập nhật ExpContentMessage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpContentMessage _ExpContentMessage);
		/// <summary>
		/// Cập nhật danh sách ExpContentMessage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpContentMessage> _ExpContentMessages);
		/// <summary>
		/// Cập nhật ExpContentMessage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpContentMessage _ExpContentMessage, string condition);
		/// <summary>
		/// Xóa ExpContentMessage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpContentMessage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpContentMessage _ExpContentMessage);
		/// <summary>
		/// Xóa ExpContentMessage trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpContentMessage trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpContentMessage> _ExpContentMessages);
	}
}
