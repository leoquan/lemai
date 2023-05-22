using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdmauketqua
	{
		/// <summary>
		/// Lấy một DataTable MedMauKetQua từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedMauKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedMauKetQua từ Database
		/// </summary>
		List<MedMauKetQua> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedMauKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedMauKetQua> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedMauKetQua> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedMauKetQua từ Database
		/// </summary>
		MedMauKetQua GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedMauKetQua đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedMauKetQua GetObjectCon(string schema, string condition, params Object[] parameters);
		MedMauKetQua GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedMauKetQua vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedMauKetQua _MedMauKetQua);
		/// <summary>
		/// Insert danh sách đối tượng MedMauKetQua vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedMauKetQua> _MedMauKetQuas);
		/// <summary>
		/// Cập nhật MedMauKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedMauKetQua _MedMauKetQua, String id);
		/// <summary>
		/// Cập nhật MedMauKetQua vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedMauKetQua _MedMauKetQua);
		/// <summary>
		/// Cập nhật danh sách MedMauKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedMauKetQua> _MedMauKetQuas);
		/// <summary>
		/// Cập nhật MedMauKetQua vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedMauKetQua _MedMauKetQua, string condition);
		/// <summary>
		/// Xóa MedMauKetQua trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedMauKetQua trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedMauKetQua _MedMauKetQua);
		/// <summary>
		/// Xóa MedMauKetQua trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedMauKetQua trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedMauKetQua> _MedMauKetQuas);
	}
}
