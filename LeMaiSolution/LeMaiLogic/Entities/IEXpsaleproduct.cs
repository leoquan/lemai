using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpsaleproduct
	{
		/// <summary>
		/// Lấy một DataTable ExpSaleProduct từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpSaleProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpSaleProduct từ Database
		/// </summary>
		List<ExpSaleProduct> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpSaleProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpSaleProduct> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpSaleProduct> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpSaleProduct từ Database
		/// </summary>
		ExpSaleProduct GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpSaleProduct đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpSaleProduct GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpSaleProduct GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpSaleProduct vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpSaleProduct _ExpSaleProduct);
		/// <summary>
		/// Insert danh sách đối tượng ExpSaleProduct vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpSaleProduct> _ExpSaleProducts);
		/// <summary>
		/// Cập nhật ExpSaleProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpSaleProduct _ExpSaleProduct, String Id);
		/// <summary>
		/// Cập nhật ExpSaleProduct vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpSaleProduct _ExpSaleProduct);
		/// <summary>
		/// Cập nhật danh sách ExpSaleProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpSaleProduct> _ExpSaleProducts);
		/// <summary>
		/// Cập nhật ExpSaleProduct vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpSaleProduct _ExpSaleProduct, string condition);
		/// <summary>
		/// Xóa ExpSaleProduct trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpSaleProduct trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpSaleProduct _ExpSaleProduct);
		/// <summary>
		/// Xóa ExpSaleProduct trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpSaleProduct trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpSaleProduct> _ExpSaleProducts);
	}
}
