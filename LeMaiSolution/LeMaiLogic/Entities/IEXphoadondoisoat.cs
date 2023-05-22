using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXphoadondoisoat
	{
		/// <summary>
		/// Lấy một DataTable ExpHoaDonDoiSoat từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpHoaDonDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpHoaDonDoiSoat từ Database
		/// </summary>
		List<ExpHoaDonDoiSoat> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpHoaDonDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpHoaDonDoiSoat> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpHoaDonDoiSoat> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpHoaDonDoiSoat từ Database
		/// </summary>
		ExpHoaDonDoiSoat GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpHoaDonDoiSoat đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpHoaDonDoiSoat GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpHoaDonDoiSoat GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpHoaDonDoiSoat vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpHoaDonDoiSoat _ExpHoaDonDoiSoat);
		/// <summary>
		/// Insert danh sách đối tượng ExpHoaDonDoiSoat vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpHoaDonDoiSoat> _ExpHoaDonDoiSoats);
		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpHoaDonDoiSoat _ExpHoaDonDoiSoat, String Id);
		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoat vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpHoaDonDoiSoat _ExpHoaDonDoiSoat);
		/// <summary>
		/// Cập nhật danh sách ExpHoaDonDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpHoaDonDoiSoat> _ExpHoaDonDoiSoats);
		/// <summary>
		/// Cập nhật ExpHoaDonDoiSoat vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpHoaDonDoiSoat _ExpHoaDonDoiSoat, string condition);
		/// <summary>
		/// Xóa ExpHoaDonDoiSoat trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpHoaDonDoiSoat trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpHoaDonDoiSoat _ExpHoaDonDoiSoat);
		/// <summary>
		/// Xóa ExpHoaDonDoiSoat trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpHoaDonDoiSoat trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpHoaDonDoiSoat> _ExpHoaDonDoiSoats);
	}
}
