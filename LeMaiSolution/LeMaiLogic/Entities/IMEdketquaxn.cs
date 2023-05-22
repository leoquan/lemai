using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdketquaxn
	{
		/// <summary>
		/// Lấy một DataTable MedKetQuaXN từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKetQuaXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKetQuaXN từ Database
		/// </summary>
		List<MedKetQuaXN> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKetQuaXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKetQuaXN> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKetQuaXN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKetQuaXN từ Database
		/// </summary>
		MedKetQuaXN GetObject(string schema, String id, Int32 stt);
		/// <summary>
		/// Lấy một MedKetQuaXN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKetQuaXN GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKetQuaXN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKetQuaXN vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKetQuaXN _MedKetQuaXN);
		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaXN vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKetQuaXN> _MedKetQuaXNs);
		/// <summary>
		/// Cập nhật MedKetQuaXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKetQuaXN _MedKetQuaXN, String id, Int32 stt);
		/// <summary>
		/// Cập nhật MedKetQuaXN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKetQuaXN _MedKetQuaXN);
		/// <summary>
		/// Cập nhật danh sách MedKetQuaXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKetQuaXN> _MedKetQuaXNs);
		/// <summary>
		/// Cập nhật MedKetQuaXN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKetQuaXN _MedKetQuaXN, string condition);
		/// <summary>
		/// Xóa MedKetQuaXN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id, Int32 stt);
		/// <summary>
		/// Xóa MedKetQuaXN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKetQuaXN _MedKetQuaXN);
		/// <summary>
		/// Xóa MedKetQuaXN trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKetQuaXN trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKetQuaXN> _MedKetQuaXNs);
	}
}
