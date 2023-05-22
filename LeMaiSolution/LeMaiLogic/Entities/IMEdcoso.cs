using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdcoso
	{
		/// <summary>
		/// Lấy một DataTable MedCoSo từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedCoSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedCoSo từ Database
		/// </summary>
		List<MedCoSo> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedCoSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedCoSo> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedCoSo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedCoSo từ Database
		/// </summary>
		MedCoSo GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedCoSo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedCoSo GetObjectCon(string schema, string condition, params Object[] parameters);
		MedCoSo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedCoSo vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedCoSo _MedCoSo);
		/// <summary>
		/// Insert danh sách đối tượng MedCoSo vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedCoSo> _MedCoSos);
		/// <summary>
		/// Cập nhật MedCoSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedCoSo _MedCoSo, String id);
		/// <summary>
		/// Cập nhật MedCoSo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedCoSo _MedCoSo);
		/// <summary>
		/// Cập nhật danh sách MedCoSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedCoSo> _MedCoSos);
		/// <summary>
		/// Cập nhật MedCoSo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedCoSo _MedCoSo, string condition);
		/// <summary>
		/// Xóa MedCoSo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedCoSo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedCoSo _MedCoSo);
		/// <summary>
		/// Xóa MedCoSo trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedCoSo trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedCoSo> _MedCoSos);
	}
}
