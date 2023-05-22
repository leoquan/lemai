using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpgroupfee
	{
		/// <summary>
		/// Lấy một DataTable ExpGroupFee từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpGroupFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpGroupFee từ Database
		/// </summary>
		List<ExpGroupFee> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpGroupFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpGroupFee> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpGroupFee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpGroupFee từ Database
		/// </summary>
		ExpGroupFee GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpGroupFee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpGroupFee GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpGroupFee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpGroupFee vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpGroupFee _ExpGroupFee);
		/// <summary>
		/// Insert danh sách đối tượng ExpGroupFee vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpGroupFee> _ExpGroupFees);
		/// <summary>
		/// Cập nhật ExpGroupFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpGroupFee _ExpGroupFee, String Id);
		/// <summary>
		/// Cập nhật ExpGroupFee vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpGroupFee _ExpGroupFee);
		/// <summary>
		/// Cập nhật danh sách ExpGroupFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpGroupFee> _ExpGroupFees);
		/// <summary>
		/// Cập nhật ExpGroupFee vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpGroupFee _ExpGroupFee, string condition);
		/// <summary>
		/// Xóa ExpGroupFee trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpGroupFee trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpGroupFee _ExpGroupFee);
		/// <summary>
		/// Xóa ExpGroupFee trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpGroupFee trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpGroupFee> _ExpGroupFees);
	}
}
