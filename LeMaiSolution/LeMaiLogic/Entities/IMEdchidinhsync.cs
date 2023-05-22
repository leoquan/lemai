using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdchidinhsync
	{
		/// <summary>
		/// Lấy một DataTable MedChiDinhSync từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedChiDinhSync từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedChiDinhSync từ Database
		/// </summary>
		List<MedChiDinhSync> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedChiDinhSync từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedChiDinhSync> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedChiDinhSync> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedChiDinhSync từ Database
		/// </summary>
		MedChiDinhSync GetObject(string schema, String id_local);
		/// <summary>
		/// Lấy một MedChiDinhSync đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedChiDinhSync GetObjectCon(string schema, string condition, params Object[] parameters);
		MedChiDinhSync GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedChiDinhSync vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedChiDinhSync _MedChiDinhSync);
		/// <summary>
		/// Insert danh sách đối tượng MedChiDinhSync vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedChiDinhSync> _MedChiDinhSyncs);
		/// <summary>
		/// Cập nhật MedChiDinhSync vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedChiDinhSync _MedChiDinhSync, String id_local);
		/// <summary>
		/// Cập nhật MedChiDinhSync vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedChiDinhSync _MedChiDinhSync);
		/// <summary>
		/// Cập nhật danh sách MedChiDinhSync vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedChiDinhSync> _MedChiDinhSyncs);
		/// <summary>
		/// Cập nhật MedChiDinhSync vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedChiDinhSync _MedChiDinhSync, string condition);
		/// <summary>
		/// Xóa MedChiDinhSync trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id_local);
		/// <summary>
		/// Xóa MedChiDinhSync trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedChiDinhSync _MedChiDinhSync);
		/// <summary>
		/// Xóa MedChiDinhSync trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedChiDinhSync trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedChiDinhSync> _MedChiDinhSyncs);
	}
}
