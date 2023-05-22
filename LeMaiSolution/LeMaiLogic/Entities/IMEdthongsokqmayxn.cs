using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdthongsokqmayxn
	{
		/// <summary>
		/// Lấy một DataTable MedThongSoKQMayXN từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedThongSoKQMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedThongSoKQMayXN từ Database
		/// </summary>
		List<MedThongSoKQMayXN> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedThongSoKQMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedThongSoKQMayXN> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedThongSoKQMayXN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedThongSoKQMayXN từ Database
		/// </summary>
		MedThongSoKQMayXN GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedThongSoKQMayXN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedThongSoKQMayXN GetObjectCon(string schema, string condition, params Object[] parameters);
		MedThongSoKQMayXN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedThongSoKQMayXN vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedThongSoKQMayXN _MedThongSoKQMayXN);
		/// <summary>
		/// Insert danh sách đối tượng MedThongSoKQMayXN vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedThongSoKQMayXN> _MedThongSoKQMayXNs);
		/// <summary>
		/// Cập nhật MedThongSoKQMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedThongSoKQMayXN _MedThongSoKQMayXN, String id);
		/// <summary>
		/// Cập nhật MedThongSoKQMayXN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedThongSoKQMayXN _MedThongSoKQMayXN);
		/// <summary>
		/// Cập nhật danh sách MedThongSoKQMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedThongSoKQMayXN> _MedThongSoKQMayXNs);
		/// <summary>
		/// Cập nhật MedThongSoKQMayXN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedThongSoKQMayXN _MedThongSoKQMayXN, string condition);
		/// <summary>
		/// Xóa MedThongSoKQMayXN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedThongSoKQMayXN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedThongSoKQMayXN _MedThongSoKQMayXN);
		/// <summary>
		/// Xóa MedThongSoKQMayXN trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedThongSoKQMayXN trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedThongSoKQMayXN> _MedThongSoKQMayXNs);
	}
}
