using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSsteprequestfindproduct
	{
		/// <summary>
		/// Lấy một DataTable GsStepRequestFindProduct từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsStepRequestFindProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsStepRequestFindProduct từ Database
		/// </summary>
		List<GsStepRequestFindProduct> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsStepRequestFindProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsStepRequestFindProduct> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsStepRequestFindProduct> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsStepRequestFindProduct từ Database
		/// </summary>
		GsStepRequestFindProduct GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsStepRequestFindProduct đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsStepRequestFindProduct GetObjectCon(string schema, string condition, params Object[] parameters);
		GsStepRequestFindProduct GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsStepRequestFindProduct vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsStepRequestFindProduct _GsStepRequestFindProduct);
		/// <summary>
		/// Insert danh sách đối tượng GsStepRequestFindProduct vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsStepRequestFindProduct> _GsStepRequestFindProducts);
		/// <summary>
		/// Cập nhật GsStepRequestFindProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsStepRequestFindProduct _GsStepRequestFindProduct, String Id);
		/// <summary>
		/// Cập nhật GsStepRequestFindProduct vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsStepRequestFindProduct _GsStepRequestFindProduct);
		/// <summary>
		/// Cập nhật danh sách GsStepRequestFindProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsStepRequestFindProduct> _GsStepRequestFindProducts);
		/// <summary>
		/// Cập nhật GsStepRequestFindProduct vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsStepRequestFindProduct _GsStepRequestFindProduct, string condition);
		/// <summary>
		/// Xóa GsStepRequestFindProduct trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsStepRequestFindProduct trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsStepRequestFindProduct _GsStepRequestFindProduct);
		/// <summary>
		/// Xóa GsStepRequestFindProduct trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsStepRequestFindProduct trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsStepRequestFindProduct> _GsStepRequestFindProducts);
	}
}
