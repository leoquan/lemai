using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEddmso
	{
		/// <summary>
		/// Lấy một DataTable MedDmSo từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedDmSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedDmSo từ Database
		/// </summary>
		List<MedDmSo> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedDmSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedDmSo> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedDmSo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedDmSo từ Database
		/// </summary>
		MedDmSo GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedDmSo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedDmSo GetObjectCon(string schema, string condition, params Object[] parameters);
		MedDmSo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedDmSo vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedDmSo _MedDmSo);
		/// <summary>
		/// Insert danh sách đối tượng MedDmSo vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedDmSo> _MedDmSos);
		/// <summary>
		/// Cập nhật MedDmSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedDmSo _MedDmSo, Int32 id);
		/// <summary>
		/// Cập nhật MedDmSo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedDmSo _MedDmSo);
		/// <summary>
		/// Cập nhật danh sách MedDmSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedDmSo> _MedDmSos);
		/// <summary>
		/// Cập nhật MedDmSo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedDmSo _MedDmSo, string condition);
		/// <summary>
		/// Xóa MedDmSo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedDmSo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedDmSo _MedDmSo);
		/// <summary>
		/// Xóa MedDmSo trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedDmSo trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedDmSo> _MedDmSos);
	}
}
