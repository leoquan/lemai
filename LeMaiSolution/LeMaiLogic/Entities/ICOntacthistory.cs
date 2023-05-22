using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ICOntacthistory
	{
		/// <summary>
		/// Lấy một DataTable ContactHistory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ContactHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ContactHistory từ Database
		/// </summary>
		List<ContactHistory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ContactHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ContactHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ContactHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ContactHistory từ Database
		/// </summary>
		ContactHistory GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ContactHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ContactHistory GetObjectCon(string schema, string condition, params Object[] parameters);
		ContactHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ContactHistory vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ContactHistory _ContactHistory);
		/// <summary>
		/// Insert danh sách đối tượng ContactHistory vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ContactHistory> _ContactHistorys);
		/// <summary>
		/// Cập nhật ContactHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ContactHistory _ContactHistory, String Id);
		/// <summary>
		/// Cập nhật ContactHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ContactHistory _ContactHistory);
		/// <summary>
		/// Cập nhật danh sách ContactHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ContactHistory> _ContactHistorys);
		/// <summary>
		/// Cập nhật ContactHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ContactHistory _ContactHistory, string condition);
		/// <summary>
		/// Xóa ContactHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ContactHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ContactHistory _ContactHistory);
		/// <summary>
		/// Xóa ContactHistory trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ContactHistory trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ContactHistory> _ContactHistorys);
	}
}
