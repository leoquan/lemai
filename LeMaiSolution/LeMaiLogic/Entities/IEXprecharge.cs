using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXprecharge
	{
		/// <summary>
		/// Lấy một DataTable ExpRecharge từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpRecharge từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpRecharge từ Database
		/// </summary>
		List<ExpRecharge> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpRecharge từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpRecharge> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpRecharge> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpRecharge từ Database
		/// </summary>
		ExpRecharge GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpRecharge đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpRecharge GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpRecharge GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpRecharge vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpRecharge _ExpRecharge);
		/// <summary>
		/// Insert danh sách đối tượng ExpRecharge vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpRecharge> _ExpRecharges);
		/// <summary>
		/// Cập nhật ExpRecharge vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpRecharge _ExpRecharge, String Id);
		/// <summary>
		/// Cập nhật ExpRecharge vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpRecharge _ExpRecharge);
		/// <summary>
		/// Cập nhật danh sách ExpRecharge vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpRecharge> _ExpRecharges);
		/// <summary>
		/// Cập nhật ExpRecharge vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpRecharge _ExpRecharge, string condition);
		/// <summary>
		/// Xóa ExpRecharge trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpRecharge trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpRecharge _ExpRecharge);
		/// <summary>
		/// Xóa ExpRecharge trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpRecharge trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpRecharge> _ExpRecharges);
	}
}
