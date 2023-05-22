using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcachgiao
	{
		/// <summary>
		/// Lấy một DataTable ExpCachGiao từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCachGiao từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCachGiao từ Database
		/// </summary>
		List<ExpCachGiao> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCachGiao từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCachGiao> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCachGiao> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCachGiao từ Database
		/// </summary>
		ExpCachGiao GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpCachGiao đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCachGiao GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCachGiao GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCachGiao vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCachGiao _ExpCachGiao);
		/// <summary>
		/// Insert danh sách đối tượng ExpCachGiao vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCachGiao> _ExpCachGiaos);
		/// <summary>
		/// Cập nhật ExpCachGiao vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCachGiao _ExpCachGiao, String Id);
		/// <summary>
		/// Cập nhật ExpCachGiao vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCachGiao _ExpCachGiao);
		/// <summary>
		/// Cập nhật danh sách ExpCachGiao vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCachGiao> _ExpCachGiaos);
		/// <summary>
		/// Cập nhật ExpCachGiao vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCachGiao _ExpCachGiao, string condition);
		/// <summary>
		/// Xóa ExpCachGiao trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpCachGiao trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCachGiao _ExpCachGiao);
		/// <summary>
		/// Xóa ExpCachGiao trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCachGiao trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCachGiao> _ExpCachGiaos);
	}
}
