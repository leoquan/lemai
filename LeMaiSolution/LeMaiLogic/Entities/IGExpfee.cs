using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpfee
	{
		/// <summary>
		/// Lấy một DataTable GExpFee từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpFee từ Database
		/// </summary>
		List<GExpFee> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpFee> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpFee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpFee từ Database
		/// </summary>
		GExpFee GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpFee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpFee GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpFee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpFee vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpFee _GExpFee);
		/// <summary>
		/// Insert danh sách đối tượng GExpFee vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpFee> _GExpFees);
		/// <summary>
		/// Cập nhật GExpFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpFee _GExpFee, String Id);
		/// <summary>
		/// Cập nhật GExpFee vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpFee _GExpFee);
		/// <summary>
		/// Cập nhật danh sách GExpFee vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpFee> _GExpFees);
		/// <summary>
		/// Cập nhật GExpFee vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpFee _GExpFee, string condition);
		/// <summary>
		/// Xóa GExpFee trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpFee trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpFee _GExpFee);
		/// <summary>
		/// Xóa GExpFee trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpFee trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpFee> _GExpFees);
	}
}
