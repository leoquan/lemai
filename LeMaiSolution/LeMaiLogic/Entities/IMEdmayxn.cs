using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdmayxn
	{
		/// <summary>
		/// Lấy một DataTable MedMayXN từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedMayXN từ Database
		/// </summary>
		List<MedMayXN> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedMayXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedMayXN> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedMayXN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedMayXN từ Database
		/// </summary>
		MedMayXN GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedMayXN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedMayXN GetObjectCon(string schema, string condition, params Object[] parameters);
		MedMayXN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedMayXN vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedMayXN _MedMayXN);
		/// <summary>
		/// Insert danh sách đối tượng MedMayXN vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedMayXN> _MedMayXNs);
		/// <summary>
		/// Cập nhật MedMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedMayXN _MedMayXN, Int32 id);
		/// <summary>
		/// Cập nhật MedMayXN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedMayXN _MedMayXN);
		/// <summary>
		/// Cập nhật danh sách MedMayXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedMayXN> _MedMayXNs);
		/// <summary>
		/// Cập nhật MedMayXN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedMayXN _MedMayXN, string condition);
		/// <summary>
		/// Xóa MedMayXN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedMayXN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedMayXN _MedMayXN);
		/// <summary>
		/// Xóa MedMayXN trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedMayXN trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedMayXN> _MedMayXNs);
	}
}
