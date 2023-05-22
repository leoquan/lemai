using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpprovincefee
	{
		/// <summary>
		/// Lấy một DataTable ExpProvinceFee từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpProvinceFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpProvinceFee từ Database
		/// </summary>
		List<ExpProvinceFee> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpProvinceFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpProvinceFee> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpProvinceFee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpProvinceFee từ Database
		/// </summary>
		ExpProvinceFee GetObject(string schema, String FeeID);
		/// <summary>
		/// Lấy một ExpProvinceFee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpProvinceFee GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpProvinceFee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpProvinceFee vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpProvinceFee _ExpProvinceFee);
		/// <summary>
		/// Insert danh sách đối tượng ExpProvinceFee vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpProvinceFee> _ExpProvinceFees);
		/// <summary>
		/// Cập nhật ExpProvinceFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpProvinceFee _ExpProvinceFee, String FeeID);
		/// <summary>
		/// Cập nhật ExpProvinceFee vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpProvinceFee _ExpProvinceFee);
		/// <summary>
		/// Cập nhật danh sách ExpProvinceFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpProvinceFee> _ExpProvinceFees);
		/// <summary>
		/// Cập nhật ExpProvinceFee vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpProvinceFee _ExpProvinceFee, string condition);
		/// <summary>
		/// Xóa ExpProvinceFee trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FeeID);
		/// <summary>
		/// Xóa ExpProvinceFee trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpProvinceFee _ExpProvinceFee);
		/// <summary>
		/// Xóa ExpProvinceFee trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpProvinceFee trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpProvinceFee> _ExpProvinceFees);
	}
}
