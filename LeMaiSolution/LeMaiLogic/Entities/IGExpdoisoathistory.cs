using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdoisoathistory
	{
		/// <summary>
		/// Lấy một DataTable GExpDoiSoatHistory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDoiSoatHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDoiSoatHistory từ Database
		/// </summary>
		List<GExpDoiSoatHistory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDoiSoatHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDoiSoatHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDoiSoatHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDoiSoatHistory từ Database
		/// </summary>
		GExpDoiSoatHistory GetObject(string schema, String BillCode);
		/// <summary>
		/// Lấy một GExpDoiSoatHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDoiSoatHistory GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDoiSoatHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDoiSoatHistory vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDoiSoatHistory _GExpDoiSoatHistory);
		/// <summary>
		/// Insert danh sách đối tượng GExpDoiSoatHistory vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDoiSoatHistory> _GExpDoiSoatHistorys);
		/// <summary>
		/// Cập nhật GExpDoiSoatHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDoiSoatHistory _GExpDoiSoatHistory, String BillCode);
		/// <summary>
		/// Cập nhật GExpDoiSoatHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDoiSoatHistory _GExpDoiSoatHistory);
		/// <summary>
		/// Cập nhật danh sách GExpDoiSoatHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDoiSoatHistory> _GExpDoiSoatHistorys);
		/// <summary>
		/// Cập nhật GExpDoiSoatHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDoiSoatHistory _GExpDoiSoatHistory, string condition);
		/// <summary>
		/// Xóa GExpDoiSoatHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BillCode);
		/// <summary>
		/// Xóa GExpDoiSoatHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDoiSoatHistory _GExpDoiSoatHistory);
		/// <summary>
		/// Xóa GExpDoiSoatHistory trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDoiSoatHistory trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDoiSoatHistory> _GExpDoiSoatHistorys);
	}
}
