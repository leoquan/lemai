using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpnhapkhoct
	{
		/// <summary>
		/// Lấy một DataTable ExpNhapKhoCt từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpNhapKhoCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpNhapKhoCt từ Database
		/// </summary>
		List<ExpNhapKhoCt> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpNhapKhoCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpNhapKhoCt> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpNhapKhoCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpNhapKhoCt từ Database
		/// </summary>
		ExpNhapKhoCt GetObject(string schema, String FK_NhapKho, String FK_VatTu);
		/// <summary>
		/// Lấy một ExpNhapKhoCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpNhapKhoCt GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpNhapKhoCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpNhapKhoCt vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpNhapKhoCt _ExpNhapKhoCt);
		/// <summary>
		/// Insert danh sách đối tượng ExpNhapKhoCt vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpNhapKhoCt> _ExpNhapKhoCts);
		/// <summary>
		/// Cập nhật ExpNhapKhoCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpNhapKhoCt _ExpNhapKhoCt, String FK_NhapKho, String FK_VatTu);
		/// <summary>
		/// Cập nhật ExpNhapKhoCt vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpNhapKhoCt _ExpNhapKhoCt);
		/// <summary>
		/// Cập nhật danh sách ExpNhapKhoCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpNhapKhoCt> _ExpNhapKhoCts);
		/// <summary>
		/// Cập nhật ExpNhapKhoCt vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpNhapKhoCt _ExpNhapKhoCt, string condition);
		/// <summary>
		/// Xóa ExpNhapKhoCt trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_NhapKho, String FK_VatTu);
		/// <summary>
		/// Xóa ExpNhapKhoCt trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpNhapKhoCt _ExpNhapKhoCt);
		/// <summary>
		/// Xóa ExpNhapKhoCt trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpNhapKhoCt trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpNhapKhoCt> _ExpNhapKhoCts);
	}
}
