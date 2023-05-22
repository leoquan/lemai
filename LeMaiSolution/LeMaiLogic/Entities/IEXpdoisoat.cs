using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpdoisoat
	{
		/// <summary>
		/// Lấy một DataTable ExpDoiSoat từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpDoiSoat từ Database
		/// </summary>
		List<ExpDoiSoat> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpDoiSoat> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpDoiSoat> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpDoiSoat từ Database
		/// </summary>
		ExpDoiSoat GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpDoiSoat đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpDoiSoat GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpDoiSoat GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpDoiSoat vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpDoiSoat _ExpDoiSoat);
		/// <summary>
		/// Insert danh sách đối tượng ExpDoiSoat vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpDoiSoat> _ExpDoiSoats);
		/// <summary>
		/// Cập nhật ExpDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpDoiSoat _ExpDoiSoat, String Id);
		/// <summary>
		/// Cập nhật ExpDoiSoat vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpDoiSoat _ExpDoiSoat);
		/// <summary>
		/// Cập nhật danh sách ExpDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpDoiSoat> _ExpDoiSoats);
		/// <summary>
		/// Cập nhật ExpDoiSoat vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpDoiSoat _ExpDoiSoat, string condition);
		/// <summary>
		/// Xóa ExpDoiSoat trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpDoiSoat trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpDoiSoat _ExpDoiSoat);
		/// <summary>
		/// Xóa ExpDoiSoat trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpDoiSoat trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpDoiSoat> _ExpDoiSoats);
	}
}
