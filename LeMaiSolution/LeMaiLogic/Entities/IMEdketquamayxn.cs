using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdketquamayxn
	{
		/// <summary>
		/// Lấy một DataTable MedKetQuaMayXN từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKetQuaMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKetQuaMayXN từ Database
		/// </summary>
		List<MedKetQuaMayXN> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKetQuaMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKetQuaMayXN> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKetQuaMayXN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKetQuaMayXN từ Database
		/// </summary>
		MedKetQuaMayXN GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedKetQuaMayXN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKetQuaMayXN GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKetQuaMayXN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKetQuaMayXN vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKetQuaMayXN _MedKetQuaMayXN);
		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaMayXN vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKetQuaMayXN> _MedKetQuaMayXNs);
		/// <summary>
		/// Cập nhật MedKetQuaMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKetQuaMayXN _MedKetQuaMayXN, String id);
		/// <summary>
		/// Cập nhật MedKetQuaMayXN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKetQuaMayXN _MedKetQuaMayXN);
		/// <summary>
		/// Cập nhật danh sách MedKetQuaMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKetQuaMayXN> _MedKetQuaMayXNs);
		/// <summary>
		/// Cập nhật MedKetQuaMayXN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKetQuaMayXN _MedKetQuaMayXN, string condition);
		/// <summary>
		/// Xóa MedKetQuaMayXN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedKetQuaMayXN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKetQuaMayXN _MedKetQuaMayXN);
		/// <summary>
		/// Xóa MedKetQuaMayXN trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKetQuaMayXN trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKetQuaMayXN> _MedKetQuaMayXNs);
	}
}
