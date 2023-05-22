using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpsalexuatkho
	{
		/// <summary>
		/// Lấy một DataTable ExpSaleXuatKho từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpSaleXuatKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpSaleXuatKho từ Database
		/// </summary>
		List<ExpSaleXuatKho> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpSaleXuatKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpSaleXuatKho> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpSaleXuatKho> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpSaleXuatKho từ Database
		/// </summary>
		ExpSaleXuatKho GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpSaleXuatKho đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpSaleXuatKho GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpSaleXuatKho GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpSaleXuatKho vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpSaleXuatKho _ExpSaleXuatKho);
		/// <summary>
		/// Insert danh sách đối tượng ExpSaleXuatKho vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpSaleXuatKho> _ExpSaleXuatKhos);
		/// <summary>
		/// Cập nhật ExpSaleXuatKho vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpSaleXuatKho _ExpSaleXuatKho, String Id);
		/// <summary>
		/// Cập nhật ExpSaleXuatKho vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpSaleXuatKho _ExpSaleXuatKho);
		/// <summary>
		/// Cập nhật danh sách ExpSaleXuatKho vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpSaleXuatKho> _ExpSaleXuatKhos);
		/// <summary>
		/// Cập nhật ExpSaleXuatKho vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpSaleXuatKho _ExpSaleXuatKho, string condition);
		/// <summary>
		/// Xóa ExpSaleXuatKho trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpSaleXuatKho trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpSaleXuatKho _ExpSaleXuatKho);
		/// <summary>
		/// Xóa ExpSaleXuatKho trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpSaleXuatKho trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpSaleXuatKho> _ExpSaleXuatKhos);
	}
}
