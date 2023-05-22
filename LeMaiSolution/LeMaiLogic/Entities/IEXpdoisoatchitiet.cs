using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpdoisoatchitiet
	{
		/// <summary>
		/// Lấy một DataTable ExpDoiSoatChiTiet từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpDoiSoatChiTiet từ Database
		/// </summary>
		List<ExpDoiSoatChiTiet> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpDoiSoatChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpDoiSoatChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpDoiSoatChiTiet từ Database
		/// </summary>
		ExpDoiSoatChiTiet GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpDoiSoatChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpDoiSoatChiTiet GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpDoiSoatChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpDoiSoatChiTiet vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpDoiSoatChiTiet _ExpDoiSoatChiTiet);
		/// <summary>
		/// Insert danh sách đối tượng ExpDoiSoatChiTiet vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpDoiSoatChiTiet> _ExpDoiSoatChiTiets);
		/// <summary>
		/// Cập nhật ExpDoiSoatChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpDoiSoatChiTiet _ExpDoiSoatChiTiet, String Id);
		/// <summary>
		/// Cập nhật ExpDoiSoatChiTiet vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpDoiSoatChiTiet _ExpDoiSoatChiTiet);
		/// <summary>
		/// Cập nhật danh sách ExpDoiSoatChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpDoiSoatChiTiet> _ExpDoiSoatChiTiets);
		/// <summary>
		/// Cập nhật ExpDoiSoatChiTiet vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpDoiSoatChiTiet _ExpDoiSoatChiTiet, string condition);
		/// <summary>
		/// Xóa ExpDoiSoatChiTiet trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpDoiSoatChiTiet trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpDoiSoatChiTiet _ExpDoiSoatChiTiet);
		/// <summary>
		/// Xóa ExpDoiSoatChiTiet trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpDoiSoatChiTiet trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpDoiSoatChiTiet> _ExpDoiSoatChiTiets);
	}
}
