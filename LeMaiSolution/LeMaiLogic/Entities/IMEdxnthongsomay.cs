using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdxnthongsomay
	{
		/// <summary>
		/// Lấy một DataTable MedXNThongSoMay từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedXNThongSoMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedXNThongSoMay từ Database
		/// </summary>
		List<MedXNThongSoMay> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedXNThongSoMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedXNThongSoMay> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedXNThongSoMay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedXNThongSoMay từ Database
		/// </summary>
		MedXNThongSoMay GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedXNThongSoMay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedXNThongSoMay GetObjectCon(string schema, string condition, params Object[] parameters);
		MedXNThongSoMay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedXNThongSoMay vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedXNThongSoMay _MedXNThongSoMay);
		/// <summary>
		/// Insert danh sách đối tượng MedXNThongSoMay vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedXNThongSoMay> _MedXNThongSoMays);
		/// <summary>
		/// Cập nhật MedXNThongSoMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedXNThongSoMay _MedXNThongSoMay, Int32 id);
		/// <summary>
		/// Cập nhật MedXNThongSoMay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedXNThongSoMay _MedXNThongSoMay);
		/// <summary>
		/// Cập nhật danh sách MedXNThongSoMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedXNThongSoMay> _MedXNThongSoMays);
		/// <summary>
		/// Cập nhật MedXNThongSoMay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedXNThongSoMay _MedXNThongSoMay, string condition);
		/// <summary>
		/// Xóa MedXNThongSoMay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedXNThongSoMay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedXNThongSoMay _MedXNThongSoMay);
		/// <summary>
		/// Xóa MedXNThongSoMay trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedXNThongSoMay trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedXNThongSoMay> _MedXNThongSoMays);
	}
}
