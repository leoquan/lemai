using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSrequestfindproducthistory
	{
		/// <summary>
		/// Lấy một DataTable GsRequestFindProductHistory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsRequestFindProductHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsRequestFindProductHistory từ Database
		/// </summary>
		List<GsRequestFindProductHistory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsRequestFindProductHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsRequestFindProductHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsRequestFindProductHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsRequestFindProductHistory từ Database
		/// </summary>
		GsRequestFindProductHistory GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsRequestFindProductHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsRequestFindProductHistory GetObjectCon(string schema, string condition, params Object[] parameters);
		GsRequestFindProductHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsRequestFindProductHistory vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsRequestFindProductHistory _GsRequestFindProductHistory);
		/// <summary>
		/// Insert danh sách đối tượng GsRequestFindProductHistory vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsRequestFindProductHistory> _GsRequestFindProductHistorys);
		/// <summary>
		/// Cập nhật GsRequestFindProductHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsRequestFindProductHistory _GsRequestFindProductHistory, String Id);
		/// <summary>
		/// Cập nhật GsRequestFindProductHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsRequestFindProductHistory _GsRequestFindProductHistory);
		/// <summary>
		/// Cập nhật danh sách GsRequestFindProductHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsRequestFindProductHistory> _GsRequestFindProductHistorys);
		/// <summary>
		/// Cập nhật GsRequestFindProductHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsRequestFindProductHistory _GsRequestFindProductHistory, string condition);
		/// <summary>
		/// Xóa GsRequestFindProductHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsRequestFindProductHistory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsRequestFindProductHistory _GsRequestFindProductHistory);
		/// <summary>
		/// Xóa GsRequestFindProductHistory trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsRequestFindProductHistory trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsRequestFindProductHistory> _GsRequestFindProductHistorys);
	}
}
