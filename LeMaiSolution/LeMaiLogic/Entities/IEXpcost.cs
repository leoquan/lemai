using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcost
	{
		/// <summary>
		/// Lấy một DataTable ExpCost từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCost từ Database
		/// </summary>
		List<ExpCost> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCost> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCost> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCost từ Database
		/// </summary>
		ExpCost GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpCost đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCost GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCost GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCost vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCost _ExpCost);
		/// <summary>
		/// Insert danh sách đối tượng ExpCost vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCost> _ExpCosts);
		/// <summary>
		/// Cập nhật ExpCost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCost _ExpCost, String Id);
		/// <summary>
		/// Cập nhật ExpCost vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCost _ExpCost);
		/// <summary>
		/// Cập nhật danh sách ExpCost vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCost> _ExpCosts);
		/// <summary>
		/// Cập nhật ExpCost vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCost _ExpCost, string condition);
		/// <summary>
		/// Xóa ExpCost trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpCost trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCost _ExpCost);
		/// <summary>
		/// Xóa ExpCost trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCost trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCost> _ExpCosts);
	}
}
