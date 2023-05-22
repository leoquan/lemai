using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdketqua
	{
		/// <summary>
		/// Lấy một DataTable MedKetQua từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKetQua từ Database
		/// </summary>
		List<MedKetQua> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKetQua> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKetQua> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKetQua từ Database
		/// </summary>
		MedKetQua GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedKetQua đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKetQua GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKetQua GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKetQua vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKetQua _MedKetQua);
		/// <summary>
		/// Insert danh sách đối tượng MedKetQua vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKetQua> _MedKetQuas);
		/// <summary>
		/// Cập nhật MedKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKetQua _MedKetQua, String id);
		/// <summary>
		/// Cập nhật MedKetQua vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKetQua _MedKetQua);
		/// <summary>
		/// Cập nhật danh sách MedKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKetQua> _MedKetQuas);
		/// <summary>
		/// Cập nhật MedKetQua vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKetQua _MedKetQua, string condition);
		/// <summary>
		/// Xóa MedKetQua trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedKetQua trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKetQua _MedKetQua);
		/// <summary>
		/// Xóa MedKetQua trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKetQua trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKetQua> _MedKetQuas);
	}
}
