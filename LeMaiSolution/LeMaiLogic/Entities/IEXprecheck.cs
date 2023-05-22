using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXprecheck
	{
		/// <summary>
		/// Lấy một DataTable ExpReCheck từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpReCheck từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpReCheck từ Database
		/// </summary>
		List<ExpReCheck> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpReCheck từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpReCheck> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpReCheck> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpReCheck từ Database
		/// </summary>
		ExpReCheck GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpReCheck đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpReCheck GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpReCheck GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpReCheck vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpReCheck _ExpReCheck);
		/// <summary>
		/// Insert danh sách đối tượng ExpReCheck vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpReCheck> _ExpReChecks);
		/// <summary>
		/// Cập nhật ExpReCheck vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpReCheck _ExpReCheck, String Id);
		/// <summary>
		/// Cập nhật ExpReCheck vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpReCheck _ExpReCheck);
		/// <summary>
		/// Cập nhật danh sách ExpReCheck vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpReCheck> _ExpReChecks);
		/// <summary>
		/// Cập nhật ExpReCheck vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpReCheck _ExpReCheck, string condition);
		/// <summary>
		/// Xóa ExpReCheck trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpReCheck trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpReCheck _ExpReCheck);
		/// <summary>
		/// Xóa ExpReCheck trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpReCheck trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpReCheck> _ExpReChecks);
	}
}
