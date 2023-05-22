using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpconsignment
	{
		/// <summary>
		/// Lấy một DataTable ExpConsignment từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpConsignment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpConsignment từ Database
		/// </summary>
		List<ExpConsignment> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpConsignment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpConsignment> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpConsignment> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpConsignment từ Database
		/// </summary>
		ExpConsignment GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpConsignment đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpConsignment GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpConsignment GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpConsignment vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpConsignment _ExpConsignment);
		/// <summary>
		/// Insert danh sách đối tượng ExpConsignment vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpConsignment> _ExpConsignments);
		/// <summary>
		/// Cập nhật ExpConsignment vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpConsignment _ExpConsignment, String Id);
		/// <summary>
		/// Cập nhật ExpConsignment vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpConsignment _ExpConsignment);
		/// <summary>
		/// Cập nhật danh sách ExpConsignment vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpConsignment> _ExpConsignments);
		/// <summary>
		/// Cập nhật ExpConsignment vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpConsignment _ExpConsignment, string condition);
		/// <summary>
		/// Xóa ExpConsignment trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpConsignment trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpConsignment _ExpConsignment);
		/// <summary>
		/// Xóa ExpConsignment trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpConsignment trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpConsignment> _ExpConsignments);
	}
}
