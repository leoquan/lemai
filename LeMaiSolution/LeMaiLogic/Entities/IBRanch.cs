using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IBRanch
	{
		/// <summary>
		/// Lấy một DataTable Branch từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable Branch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách Branch từ Database
		/// </summary>
		List<Branch> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách Branch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<Branch> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<Branch> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một Branch từ Database
		/// </summary>
		Branch GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một Branch đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		Branch GetObjectCon(string schema, string condition, params Object[] parameters);
		Branch GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới Branch vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, Branch _Branch);
		/// <summary>
		/// Insert danh sách đối tượng Branch vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<Branch> _Branchs);
		/// <summary>
		/// Cập nhật Branch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, Branch _Branch, String Id);
		/// <summary>
		/// Cập nhật Branch vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, Branch _Branch);
		/// <summary>
		/// Cập nhật danh sách Branch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<Branch> _Branchs);
		/// <summary>
		/// Cập nhật Branch vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, Branch _Branch, string condition);
		/// <summary>
		/// Xóa Branch trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa Branch trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Branch _Branch);
		/// <summary>
		/// Xóa Branch trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa Branch trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<Branch> _Branchs);
	}
}
