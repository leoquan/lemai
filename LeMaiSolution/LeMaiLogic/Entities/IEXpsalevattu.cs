using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpsalevattu
	{
		/// <summary>
		/// Lấy một DataTable ExpSaleVatTu từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpSaleVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpSaleVatTu từ Database
		/// </summary>
		List<ExpSaleVatTu> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpSaleVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpSaleVatTu> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpSaleVatTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpSaleVatTu từ Database
		/// </summary>
		ExpSaleVatTu GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpSaleVatTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpSaleVatTu GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpSaleVatTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpSaleVatTu vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpSaleVatTu _ExpSaleVatTu);
		/// <summary>
		/// Insert danh sách đối tượng ExpSaleVatTu vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpSaleVatTu> _ExpSaleVatTus);
		/// <summary>
		/// Cập nhật ExpSaleVatTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpSaleVatTu _ExpSaleVatTu, String Id);
		/// <summary>
		/// Cập nhật ExpSaleVatTu vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpSaleVatTu _ExpSaleVatTu);
		/// <summary>
		/// Cập nhật danh sách ExpSaleVatTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpSaleVatTu> _ExpSaleVatTus);
		/// <summary>
		/// Cập nhật ExpSaleVatTu vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpSaleVatTu _ExpSaleVatTu, string condition);
		/// <summary>
		/// Xóa ExpSaleVatTu trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpSaleVatTu trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpSaleVatTu _ExpSaleVatTu);
		/// <summary>
		/// Xóa ExpSaleVatTu trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpSaleVatTu trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpSaleVatTu> _ExpSaleVatTus);
	}
}
