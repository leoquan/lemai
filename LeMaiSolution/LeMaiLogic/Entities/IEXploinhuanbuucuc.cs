using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXploinhuanbuucuc
	{
		/// <summary>
		/// Lấy một DataTable ExpLoiNhuanBuuCuc từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpLoiNhuanBuuCuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpLoiNhuanBuuCuc từ Database
		/// </summary>
		List<ExpLoiNhuanBuuCuc> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpLoiNhuanBuuCuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpLoiNhuanBuuCuc> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpLoiNhuanBuuCuc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpLoiNhuanBuuCuc từ Database
		/// </summary>
		ExpLoiNhuanBuuCuc GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpLoiNhuanBuuCuc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpLoiNhuanBuuCuc GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpLoiNhuanBuuCuc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpLoiNhuanBuuCuc vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpLoiNhuanBuuCuc _ExpLoiNhuanBuuCuc);
		/// <summary>
		/// Insert danh sách đối tượng ExpLoiNhuanBuuCuc vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpLoiNhuanBuuCuc> _ExpLoiNhuanBuuCucs);
		/// <summary>
		/// Cập nhật ExpLoiNhuanBuuCuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpLoiNhuanBuuCuc _ExpLoiNhuanBuuCuc, String Id);
		/// <summary>
		/// Cập nhật ExpLoiNhuanBuuCuc vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpLoiNhuanBuuCuc _ExpLoiNhuanBuuCuc);
		/// <summary>
		/// Cập nhật danh sách ExpLoiNhuanBuuCuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpLoiNhuanBuuCuc> _ExpLoiNhuanBuuCucs);
		/// <summary>
		/// Cập nhật ExpLoiNhuanBuuCuc vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpLoiNhuanBuuCuc _ExpLoiNhuanBuuCuc, string condition);
		/// <summary>
		/// Xóa ExpLoiNhuanBuuCuc trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpLoiNhuanBuuCuc trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpLoiNhuanBuuCuc _ExpLoiNhuanBuuCuc);
		/// <summary>
		/// Xóa ExpLoiNhuanBuuCuc trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpLoiNhuanBuuCuc trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpLoiNhuanBuuCuc> _ExpLoiNhuanBuuCucs);
	}
}
