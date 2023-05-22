using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpfee
	{
		/// <summary>
		/// Lấy một DataTable ExpFee từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpFee từ Database
		/// </summary>
		List<ExpFee> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpFee> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpFee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpFee từ Database
		/// </summary>
		ExpFee GetObject(string schema, String MaBG);
		/// <summary>
		/// Lấy một ExpFee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpFee GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpFee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpFee vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpFee _ExpFee);
		/// <summary>
		/// Insert danh sách đối tượng ExpFee vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpFee> _ExpFees);
		/// <summary>
		/// Cập nhật ExpFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpFee _ExpFee, String MaBG);
		/// <summary>
		/// Cập nhật ExpFee vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpFee _ExpFee);
		/// <summary>
		/// Cập nhật danh sách ExpFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpFee> _ExpFees);
		/// <summary>
		/// Cập nhật ExpFee vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpFee _ExpFee, string condition);
		/// <summary>
		/// Xóa ExpFee trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String MaBG);
		/// <summary>
		/// Xóa ExpFee trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpFee _ExpFee);
		/// <summary>
		/// Xóa ExpFee trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpFee trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpFee> _ExpFees);
	}
}
