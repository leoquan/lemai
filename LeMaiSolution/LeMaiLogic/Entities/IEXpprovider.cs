using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpprovider
	{
		/// <summary>
		/// Lấy một DataTable ExpProvider từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpProvider từ Database
		/// </summary>
		List<ExpProvider> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpProvider> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpProvider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpProvider từ Database
		/// </summary>
		ExpProvider GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpProvider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpProvider GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpProvider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpProvider vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpProvider _ExpProvider);
		/// <summary>
		/// Insert danh sách đối tượng ExpProvider vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpProvider> _ExpProviders);
		/// <summary>
		/// Cập nhật ExpProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpProvider _ExpProvider, String Id);
		/// <summary>
		/// Cập nhật ExpProvider vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpProvider _ExpProvider);
		/// <summary>
		/// Cập nhật danh sách ExpProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpProvider> _ExpProviders);
		/// <summary>
		/// Cập nhật ExpProvider vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpProvider _ExpProvider, string condition);
		/// <summary>
		/// Xóa ExpProvider trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpProvider trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpProvider _ExpProvider);
		/// <summary>
		/// Xóa ExpProvider trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpProvider trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpProvider> _ExpProviders);
	}
}
