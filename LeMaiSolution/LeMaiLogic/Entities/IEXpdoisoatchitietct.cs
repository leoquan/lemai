using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpdoisoatchitietct
	{
		/// <summary>
		/// Lấy một DataTable ExpDoiSoatChiTietCt từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpDoiSoatChiTietCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpDoiSoatChiTietCt từ Database
		/// </summary>
		List<ExpDoiSoatChiTietCt> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpDoiSoatChiTietCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpDoiSoatChiTietCt> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpDoiSoatChiTietCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpDoiSoatChiTietCt từ Database
		/// </summary>
		ExpDoiSoatChiTietCt GetObject(string schema, String BILL_CODE);
		/// <summary>
		/// Lấy một ExpDoiSoatChiTietCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpDoiSoatChiTietCt GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpDoiSoatChiTietCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpDoiSoatChiTietCt vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpDoiSoatChiTietCt _ExpDoiSoatChiTietCt);
		/// <summary>
		/// Insert danh sách đối tượng ExpDoiSoatChiTietCt vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpDoiSoatChiTietCt> _ExpDoiSoatChiTietCts);
		/// <summary>
		/// Cập nhật ExpDoiSoatChiTietCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpDoiSoatChiTietCt _ExpDoiSoatChiTietCt, String BILL_CODE);
		/// <summary>
		/// Cập nhật ExpDoiSoatChiTietCt vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpDoiSoatChiTietCt _ExpDoiSoatChiTietCt);
		/// <summary>
		/// Cập nhật danh sách ExpDoiSoatChiTietCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpDoiSoatChiTietCt> _ExpDoiSoatChiTietCts);
		/// <summary>
		/// Cập nhật ExpDoiSoatChiTietCt vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpDoiSoatChiTietCt _ExpDoiSoatChiTietCt, string condition);
		/// <summary>
		/// Xóa ExpDoiSoatChiTietCt trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BILL_CODE);
		/// <summary>
		/// Xóa ExpDoiSoatChiTietCt trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpDoiSoatChiTietCt _ExpDoiSoatChiTietCt);
		/// <summary>
		/// Xóa ExpDoiSoatChiTietCt trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpDoiSoatChiTietCt trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpDoiSoatChiTietCt> _ExpDoiSoatChiTietCts);
	}
}
