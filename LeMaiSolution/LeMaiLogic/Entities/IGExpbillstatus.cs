using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpbillstatus
	{
		/// <summary>
		/// Lấy một DataTable GExpBillStatus từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpBillStatus từ Database
		/// </summary>
		List<GExpBillStatus> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpBillStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpBillStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpBillStatus từ Database
		/// </summary>
		GExpBillStatus GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một GExpBillStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpBillStatus GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpBillStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpBillStatus vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpBillStatus _GExpBillStatus);
		/// <summary>
		/// Insert danh sách đối tượng GExpBillStatus vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpBillStatus> _GExpBillStatuss);
		/// <summary>
		/// Cập nhật GExpBillStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpBillStatus _GExpBillStatus, Int32 Id);
		/// <summary>
		/// Cập nhật GExpBillStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpBillStatus _GExpBillStatus);
		/// <summary>
		/// Cập nhật danh sách GExpBillStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpBillStatus> _GExpBillStatuss);
		/// <summary>
		/// Cập nhật GExpBillStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpBillStatus _GExpBillStatus, string condition);
		/// <summary>
		/// Xóa GExpBillStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa GExpBillStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpBillStatus _GExpBillStatus);
		/// <summary>
		/// Xóa GExpBillStatus trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpBillStatus trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpBillStatus> _GExpBillStatuss);
	}
}
