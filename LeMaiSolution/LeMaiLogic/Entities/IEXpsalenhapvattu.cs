using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpsalenhapvattu
	{
		/// <summary>
		/// Lấy một DataTable ExpSaleNhapVatTu từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpSaleNhapVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpSaleNhapVatTu từ Database
		/// </summary>
		List<ExpSaleNhapVatTu> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpSaleNhapVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpSaleNhapVatTu> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpSaleNhapVatTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpSaleNhapVatTu từ Database
		/// </summary>
		ExpSaleNhapVatTu GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpSaleNhapVatTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpSaleNhapVatTu GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpSaleNhapVatTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpSaleNhapVatTu vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpSaleNhapVatTu _ExpSaleNhapVatTu);
		/// <summary>
		/// Insert danh sách đối tượng ExpSaleNhapVatTu vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpSaleNhapVatTu> _ExpSaleNhapVatTus);
		/// <summary>
		/// Cập nhật ExpSaleNhapVatTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpSaleNhapVatTu _ExpSaleNhapVatTu, String Id);
		/// <summary>
		/// Cập nhật ExpSaleNhapVatTu vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpSaleNhapVatTu _ExpSaleNhapVatTu);
		/// <summary>
		/// Cập nhật danh sách ExpSaleNhapVatTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpSaleNhapVatTu> _ExpSaleNhapVatTus);
		/// <summary>
		/// Cập nhật ExpSaleNhapVatTu vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpSaleNhapVatTu _ExpSaleNhapVatTu, string condition);
		/// <summary>
		/// Xóa ExpSaleNhapVatTu trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpSaleNhapVatTu trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpSaleNhapVatTu _ExpSaleNhapVatTu);
		/// <summary>
		/// Xóa ExpSaleNhapVatTu trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpSaleNhapVatTu trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpSaleNhapVatTu> _ExpSaleNhapVatTus);
	}
}
