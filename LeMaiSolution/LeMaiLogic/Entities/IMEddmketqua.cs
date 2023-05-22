using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEddmketqua
	{
		/// <summary>
		/// Lấy một DataTable MedDmKetQua từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedDmKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedDmKetQua từ Database
		/// </summary>
		List<MedDmKetQua> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedDmKetQua từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedDmKetQua> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedDmKetQua> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedDmKetQua từ Database
		/// </summary>
		MedDmKetQua GetObject(string schema, Int32 dmten, Int32 idten);
		/// <summary>
		/// Lấy một MedDmKetQua đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedDmKetQua GetObjectCon(string schema, string condition, params Object[] parameters);
		MedDmKetQua GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedDmKetQua vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedDmKetQua _MedDmKetQua);
		/// <summary>
		/// Insert danh sách đối tượng MedDmKetQua vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedDmKetQua> _MedDmKetQuas);
		/// <summary>
		/// Cập nhật MedDmKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedDmKetQua _MedDmKetQua, Int32 dmten, Int32 idten);
		/// <summary>
		/// Cập nhật MedDmKetQua vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedDmKetQua _MedDmKetQua);
		/// <summary>
		/// Cập nhật danh sách MedDmKetQua vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedDmKetQua> _MedDmKetQuas);
		/// <summary>
		/// Cập nhật MedDmKetQua vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedDmKetQua _MedDmKetQua, string condition);
		/// <summary>
		/// Xóa MedDmKetQua trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 dmten, Int32 idten);
		/// <summary>
		/// Xóa MedDmKetQua trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedDmKetQua _MedDmKetQua);
		/// <summary>
		/// Xóa MedDmKetQua trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedDmKetQua trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedDmKetQua> _MedDmKetQuas);
	}
}
