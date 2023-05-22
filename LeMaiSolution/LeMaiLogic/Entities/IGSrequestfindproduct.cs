using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSrequestfindproduct
	{
		/// <summary>
		/// Lấy một DataTable GsRequestFindProduct từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsRequestFindProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsRequestFindProduct từ Database
		/// </summary>
		List<GsRequestFindProduct> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsRequestFindProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsRequestFindProduct> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsRequestFindProduct> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsRequestFindProduct từ Database
		/// </summary>
		GsRequestFindProduct GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsRequestFindProduct đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsRequestFindProduct GetObjectCon(string schema, string condition, params Object[] parameters);
		GsRequestFindProduct GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsRequestFindProduct vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsRequestFindProduct _GsRequestFindProduct);
		/// <summary>
		/// Insert danh sách đối tượng GsRequestFindProduct vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsRequestFindProduct> _GsRequestFindProducts);
		/// <summary>
		/// Cập nhật GsRequestFindProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsRequestFindProduct _GsRequestFindProduct, String Id);
		/// <summary>
		/// Cập nhật GsRequestFindProduct vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsRequestFindProduct _GsRequestFindProduct);
		/// <summary>
		/// Cập nhật danh sách GsRequestFindProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsRequestFindProduct> _GsRequestFindProducts);
		/// <summary>
		/// Cập nhật GsRequestFindProduct vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsRequestFindProduct _GsRequestFindProduct, string condition);
		/// <summary>
		/// Xóa GsRequestFindProduct trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsRequestFindProduct trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsRequestFindProduct _GsRequestFindProduct);
		/// <summary>
		/// Xóa GsRequestFindProduct trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsRequestFindProduct trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsRequestFindProduct> _GsRequestFindProducts);
	}
}
