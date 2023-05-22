using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpnhapkho
	{
		/// <summary>
		/// Lấy một DataTable ExpNhapKho từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpNhapKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpNhapKho từ Database
		/// </summary>
		List<ExpNhapKho> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpNhapKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpNhapKho> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpNhapKho> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpNhapKho từ Database
		/// </summary>
		ExpNhapKho GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpNhapKho đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpNhapKho GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpNhapKho GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpNhapKho vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpNhapKho _ExpNhapKho);
		/// <summary>
		/// Insert danh sách đối tượng ExpNhapKho vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpNhapKho> _ExpNhapKhos);
		/// <summary>
		/// Cập nhật ExpNhapKho vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpNhapKho _ExpNhapKho, String Id);
		/// <summary>
		/// Cập nhật ExpNhapKho vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpNhapKho _ExpNhapKho);
		/// <summary>
		/// Cập nhật danh sách ExpNhapKho vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpNhapKho> _ExpNhapKhos);
		/// <summary>
		/// Cập nhật ExpNhapKho vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpNhapKho _ExpNhapKho, string condition);
		/// <summary>
		/// Xóa ExpNhapKho trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpNhapKho trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpNhapKho _ExpNhapKho);
		/// <summary>
		/// Xóa ExpNhapKho trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpNhapKho trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpNhapKho> _ExpNhapKhos);
	}
}
