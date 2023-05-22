using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpbillstatusname
	{
		/// <summary>
		/// Lấy một DataTable GExpBillStatusName từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpBillStatusName từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpBillStatusName từ Database
		/// </summary>
		List<GExpBillStatusName> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpBillStatusName từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpBillStatusName> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpBillStatusName> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpBillStatusName từ Database
		/// </summary>
		GExpBillStatusName GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpBillStatusName đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpBillStatusName GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpBillStatusName GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpBillStatusName vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpBillStatusName _GExpBillStatusName);
		/// <summary>
		/// Insert danh sách đối tượng GExpBillStatusName vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpBillStatusName> _GExpBillStatusNames);
		/// <summary>
		/// Cập nhật GExpBillStatusName vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpBillStatusName _GExpBillStatusName, String Id);
		/// <summary>
		/// Cập nhật GExpBillStatusName vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpBillStatusName _GExpBillStatusName);
		/// <summary>
		/// Cập nhật danh sách GExpBillStatusName vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpBillStatusName> _GExpBillStatusNames);
		/// <summary>
		/// Cập nhật GExpBillStatusName vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpBillStatusName _GExpBillStatusName, string condition);
		/// <summary>
		/// Xóa GExpBillStatusName trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpBillStatusName trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpBillStatusName _GExpBillStatusName);
		/// <summary>
		/// Xóa GExpBillStatusName trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpBillStatusName trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpBillStatusName> _GExpBillStatusNames);
	}
}
