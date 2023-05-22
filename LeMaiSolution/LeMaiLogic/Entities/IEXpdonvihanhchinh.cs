using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpdonvihanhchinh
	{
		/// <summary>
		/// Lấy một DataTable ExpDonViHanhChinh từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpDonViHanhChinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpDonViHanhChinh từ Database
		/// </summary>
		List<ExpDonViHanhChinh> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpDonViHanhChinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpDonViHanhChinh> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpDonViHanhChinh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpDonViHanhChinh từ Database
		/// </summary>
		ExpDonViHanhChinh GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpDonViHanhChinh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpDonViHanhChinh GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpDonViHanhChinh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpDonViHanhChinh vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpDonViHanhChinh _ExpDonViHanhChinh);
		/// <summary>
		/// Insert danh sách đối tượng ExpDonViHanhChinh vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpDonViHanhChinh> _ExpDonViHanhChinhs);
		/// <summary>
		/// Cập nhật ExpDonViHanhChinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpDonViHanhChinh _ExpDonViHanhChinh, String Id);
		/// <summary>
		/// Cập nhật ExpDonViHanhChinh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpDonViHanhChinh _ExpDonViHanhChinh);
		/// <summary>
		/// Cập nhật danh sách ExpDonViHanhChinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpDonViHanhChinh> _ExpDonViHanhChinhs);
		/// <summary>
		/// Cập nhật ExpDonViHanhChinh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpDonViHanhChinh _ExpDonViHanhChinh, string condition);
		/// <summary>
		/// Xóa ExpDonViHanhChinh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpDonViHanhChinh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpDonViHanhChinh _ExpDonViHanhChinh);
		/// <summary>
		/// Xóa ExpDonViHanhChinh trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpDonViHanhChinh trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpDonViHanhChinh> _ExpDonViHanhChinhs);
	}
}
